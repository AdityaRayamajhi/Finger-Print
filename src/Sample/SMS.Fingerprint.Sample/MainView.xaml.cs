using System;
using System.Threading;
using System.Threading.Tasks;
using Plugin.Fingerprint.Abstractions;
using Xamarin.Forms;

namespace SMS.Fingerprint.Sample
{
    public partial class MainView : ContentPage
    {
        private CancellationTokenSource _cancel;
        private bool _initialized;

        public MainView()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (!_initialized)
            {
                _initialized = true;
                lblAuthenticationType.Text = "Auth Type: " + await Plugin.Fingerprint.CrossFingerprint.Current.GetAuthenticationTypeAsync();
            }
        }

        private async void OnAuthenticate(object sender, EventArgs e)
        {
            var reason = "Use fingerprint sensor to Login an user";
            var helptext = "Touch sensor";

            await AuthenticateAsync(reason, tooFast: "Moved too fast");
        }

        private async void OnAuthenticateLocalized(object sender, EventArgs e)
        {
            await AuthenticateAsync("Beweise, dass du Finger hast!", cancel: "Abbrechen", fallback: "Anders!", tooFast: "Viel zu schnell!");
        }

        private async Task AuthenticateAsync(string reason, string title = null, string cancel = null, string fallback = null, string tooFast = null)
        {
            _cancel = swAutoCancel.IsToggled ? new CancellationTokenSource(TimeSpan.FromSeconds(10)) : new CancellationTokenSource();
            lblStatus.Text = "";

            var dialogConfig = new AuthenticationRequestConfiguration(reason)
            { // all optional
                Title = title,
                CancelTitle = cancel,
                FallbackTitle = fallback,
                AllowAlternativeAuthentication = swAllowAlternative.IsToggled
            };

            // optional
            dialogConfig.HelpTexts.MovedTooFast = tooFast;

            var result = await Plugin.Fingerprint.CrossFingerprint.Current.AuthenticateAsync(dialogConfig, _cancel.Token);

            await SetResultAsync(result);
        }

        private async Task SetResultAsync(FingerprintAuthenticationResult result)
        {
            if (result.Authenticated)
            {
                await Navigation.PushAsync(new SecretView());
            }
            else
            {
                lblStatus.Text = $"{result.Status}: {result.ErrorMessage}";
            }
        }
    }
}