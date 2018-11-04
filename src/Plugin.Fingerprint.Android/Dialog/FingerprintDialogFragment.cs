using System;
using System.Threading;
using System.Threading.Tasks;
using Android.Animation;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using Plugin.Fingerprint.Abstractions;
using Plugin.Fingerprint.Contract;
using Plugin.Fingerprint.Utils;

namespace Plugin.Fingerprint.Dialog
{
    public class FingerprintDialogFragment : DialogFragment, IAuthenticationFailedListener, IDialogInterfaceOnKeyListener
    {
        private TaskCompletionSource<FingerprintAuthenticationResult> _resultTaskCompletionSource;
        private TextView _helpText;
        private TextView _dialogTitle;
        private Button _cancelButton;
        private Button _fallbackButton;
        private ImageView _icon;
        private bool _canceledByLifecycle;
        private CancellationTokenSource _cancelationTokenSource;
        private IAndroidFingerprintImplementation _implementation;

        protected Color? DefaultColor;
        protected Color NegativeColor = new Color(217, 59, 59);
        protected Color PositiveColor = new Color(90, 185, 83);

        protected AuthenticationRequestConfiguration Configuration { get; private set; }

        public FingerprintDialogFragment()
        {
        }

        public FingerprintDialogFragment(IntPtr ptr, JniHandleOwnership owner) : base(ptr, owner)
        {
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RetainInstance = true;
            SetStyle(DialogFragmentStyle.NoTitle, 0);
        }

        public override void OnResume()
        {
            base.OnResume();

            var param = Dialog.Window.Attributes;
            param.Width = ViewGroup.LayoutParams.WrapContent;
            param.Height = ViewGroup.LayoutParams.WrapContent;
            Dialog.Window.Attributes = param;

            if (_cancelButton != null)
            {
                _cancelButton.Text = string.IsNullOrWhiteSpace(Configuration.CancelTitle) ? Application.Context.GetString(Android.Resource.String.Cancel) : Configuration.CancelTitle;
                _cancelButton.Click += OnCancel;
            }

            if (_fallbackButton != null)
            {
                if (Configuration.AllowAlternativeAuthentication)
                {
                    _fallbackButton.Text = string.IsNullOrWhiteSpace(Configuration.FallbackTitle) ? "Use Fallback" : Configuration.FallbackTitle;
                    _fallbackButton.Click += OnFallback;
                }
                else
                {
					_fallbackButton.Visibility = ViewStates.Gone;
                }
            }

            if (_dialogTitle != null)
            {
                _dialogTitle.Text = string.IsNullOrWhiteSpace(Configuration.Title) ? "Fingerprint Login" : Configuration.CancelTitle;
            }

            StartAuthenticationAsync();
        }

        public override void OnPause()
        {
            DetachEventHandlers();

            _canceledByLifecycle = true;
            _cancelationTokenSource?.Cancel();

            base.OnPause();
        }

        public override Android.App.Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            var dialog = base.OnCreateDialog(savedInstanceState);
            dialog.SetCanceledOnTouchOutside(false);
            dialog.SetOnKeyListener(this);
            return dialog;
        }

        public async Task<FingerprintAuthenticationResult> ShowAsync(AuthenticationRequestConfiguration config, IAndroidFingerprintImplementation implementation, CancellationToken cancellationToken)
        {
            Configuration = config;
            _implementation = implementation;

            var currentActivity = CrossFingerprint.CurrentActivity;
            Show(currentActivity.FragmentManager, "fingerprint-fragment");

            using (cancellationToken.Register(OnExternalCancel))
            {
                return await _resultTaskCompletionSource.Task;
            }
        }

        public override void Show(FragmentManager manager, string tag)
        {
            _resultTaskCompletionSource = new TaskCompletionSource<FingerprintAuthenticationResult>();
            base.Show(manager, tag);
        }

        protected void DetachEventHandlers()
        {
            if (_cancelButton != null)
            {
                _cancelButton.Click -= OnCancel;
            }

            if (_fallbackButton != null)
            {
                _fallbackButton.Click -= OnFallback;
            }
        }

        private void SetManualResult(FingerprintAuthenticationResultStatus status, bool animation = true)
        {
            _canceledByLifecycle = true;
            _cancelationTokenSource?.Cancel();

            Dismiss(new FingerprintAuthenticationResult
            {
                Status = status
            }, animation);
        }

        private async void Dismiss(FingerprintAuthenticationResult result, bool animation = true)
        {
            DetachEventHandlers();
            if (animation)
            {
               // HideHelpText();
                await AnimateResultAsync(result.Status);
            }

            _resultTaskCompletionSource.TrySetResult(result);
            DismissAllowingStateLoss();
        }

        private void OnExternalCancel()
        {
            SetManualResult(FingerprintAuthenticationResultStatus.Canceled, false);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.FingerprintDialog, container);
            var reason = view.FindViewById<TextView>(Resource.Id.fingerprint_txtReason);
            if(reason != null && Configuration?.Reason != null)
            {
                reason.Text = Configuration.Reason;
            }

            _dialogTitle = view.FindViewById<TextView>(Resource.Id.content_title);
            _helpText = view.FindViewById<TextView>(Resource.Id.fingerprint_txtHelp);
            _cancelButton = view.FindViewById<Button>(Resource.Id.fingerprint_btnCancel);
            _fallbackButton = view.FindViewById<Button>(Resource.Id.fingerprint_btnFallback);
            _icon = view.FindViewById<ImageView>(Resource.Id.fingerprint_imgFingerprint);

            if(Configuration?.Title != null)
            {
                _dialogTitle.Text = Configuration?.Title;
            }

            if (DefaultColor.HasValue)
            {
                _icon?.SetColorFilter(DefaultColor.Value);
            }

            return view;
        }

        private async void StartAuthenticationAsync()
        {
            _cancelationTokenSource = new CancellationTokenSource();
            _canceledByLifecycle = false;

            var result = await _implementation.AuthenticateNoDialogAsync(this, _cancelationTokenSource.Token);

            if (!_canceledByLifecycle)
            {
                _cancelationTokenSource = null;
                Dismiss(result);
            }
        }

        private void OnCancel(object sender, EventArgs e)
        {
            SetManualResult(FingerprintAuthenticationResultStatus.Canceled);
        }

        private void OnFallback(object sender, EventArgs e)
        {
            SetManualResult(FingerprintAuthenticationResultStatus.FallbackRequested);
        }

        public bool OnKey(IDialogInterface dialog, Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Up)
            {
                SetManualResult(FingerprintAuthenticationResultStatus.Canceled);
                return true;
            }

            return false;
        }

        public virtual async void OnFailedTry()
        {
          //  HideHelpText();
            await AnimateFailedTryAsync();
        }

        public void OnHelp(FingerprintAuthenticationHelp help, string nativeHelpText)
        {
            if(_helpText == null) return;

            var text = Configuration.HelpTexts.GetText(help, nativeHelpText);
            if (!string.IsNullOrEmpty(text))
            {
                _helpText.Text = text;
                _helpText.Visibility = ViewStates.Visible;
            }
        }

        private void HideHelpText()
        {
            if (_helpText != null)
            {
                _helpText.Visibility = ViewStates.Gone;
            }
        }

        private async Task AnimateResultAsync(FingerprintAuthenticationResultStatus status)
        {
            switch (status)
            {
                case FingerprintAuthenticationResultStatus.Succeeded:
                    await FinalAnimationAsync();
                    break;
                case FingerprintAuthenticationResultStatus.FallbackRequested:
                    await FallbackAnimationAsync();
                    break;
                case FingerprintAuthenticationResultStatus.Canceled:
                    break;
                case FingerprintAuthenticationResultStatus.TooManyAttempts:
                    await TooManyAttemptsAnimationAsync();
                    break;
                case FingerprintAuthenticationResultStatus.Failed:
                case FingerprintAuthenticationResultStatus.Denied:
                case FingerprintAuthenticationResultStatus.Unknown:
                case FingerprintAuthenticationResultStatus.UnknownError:
                case FingerprintAuthenticationResultStatus.NotAvailable:
                    await FailedAnimationAsync();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }

        private async Task FailedAnimationAsync()
        {
            if (_icon == null)
                return;

            _icon.SetImageResource(Resource.Drawable.fingerprint_denied);
            _helpText.Text = "Failed Error!!!!";
            _helpText.SetTextColor(Color.Red);
            var shake = ObjectAnimator.OfFloat(_icon, "translationX", -8f, 8f);
            shake.SetDuration(500);
            shake.SetInterpolator(new CycleInterpolator(5));
            await shake.StartAsync();
        }

        private async Task TooManyAttemptsAnimationAsync()
        {
            if (_icon == null)
                return;

            _icon.SetImageResource(Resource.Drawable.fingerprint_denied);
            _helpText.SetTextColor(Color.Red);
            _helpText.Text = "Too many attempts";
            var shake = ObjectAnimator.OfFloat(_icon, "translationX", -8f, 8f);
            shake.SetDuration(500);
            shake.SetInterpolator(new CycleInterpolator(5));
            await shake.StartAsync();
        }

        private async Task FinalAnimationAsync()
        {
            if (_icon == null)
                return;

            _icon.SetImageResource(Resource.Drawable.fingerprint_accepted);
            var press = ObjectAnimator.OfPropertyValuesHolder(_icon, PropertyValuesHolder.OfFloat("scaleX", 0.7f), PropertyValuesHolder.OfFloat("scaleY", 0.7f));
            press.SetDuration(300);
            press.RepeatMode = ValueAnimatorRepeatMode.Reverse;
            press.RepeatCount = 1;
            await press.StartAsync();
        }

        private async Task AnimateFailedTryAsync()
        {
            if (_icon == null)
                return;

            _icon.SetImageResource(Resource.Drawable.fingerprint_denied);
            _helpText.Text = "Finger print not recognized";
            _helpText.SetTextColor(Color.Red);
            var shake = ObjectAnimator.OfFloat(_icon, "translationX", -8f, 8f);
            shake.SetDuration(500);
            shake.SetInterpolator(new CycleInterpolator(5));
            await shake.StartAsync();
            _icon.SetImageResource(Resource.Drawable.fingerprint_normal);
            _helpText.Text = "Touch sensor";
            _helpText.SetTextColor(Color.DarkGray);
        }

        private async Task FallbackAnimationAsync()
        {
            if (_icon == null)
                return;

            var rotate = ObjectAnimator.OfFloat(_icon, "rotationY", 0f, 180f);
            var fade = ObjectAnimator.OfFloat(_icon, "alpha", 1f, 0f);
            var scale = ObjectAnimator.OfPropertyValuesHolder(_icon, PropertyValuesHolder.OfFloat("scaleX", 0.4f), PropertyValuesHolder.OfFloat("scaleY", 0.4f));
            rotate.SetDuration(200);
            fade.SetDuration(600);
            scale.SetDuration(600);

            var animation = new AnimatorSet();
            animation.Play(rotate).Before(scale);
            animation.Play(fade).With(scale);
            await animation.StartAsync();
        }
    }
}