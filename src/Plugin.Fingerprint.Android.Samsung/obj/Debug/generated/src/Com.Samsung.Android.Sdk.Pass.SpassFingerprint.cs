using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Samsung.Android.Sdk.Pass {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']"
	[global::Android.Runtime.Register ("com/samsung/android/sdk/pass/SpassFingerprint", DoNotGenerateAcw=true)]
	public partial class SpassFingerprint : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/field[@name='ACTION_FINGERPRINT_ADDED']"
		[Register ("ACTION_FINGERPRINT_ADDED")]
		public const string ActionFingerprintAdded = (string) "com.samsung.android.intent.action.FINGERPRINT_ADDED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/field[@name='ACTION_FINGERPRINT_REMOVED']"
		[Register ("ACTION_FINGERPRINT_REMOVED")]
		public const string ActionFingerprintRemoved = (string) "com.samsung.android.intent.action.FINGERPRINT_REMOVED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/field[@name='ACTION_FINGERPRINT_RESET']"
		[Register ("ACTION_FINGERPRINT_RESET")]
		public const string ActionFingerprintReset = (string) "com.samsung.android.intent.action.FINGERPRINT_RESET";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.samsung.android.sdk.pass']/interface[@name='SpassFingerprint.IdentifyListener']"
		[Register ("com/samsung/android/sdk/pass/SpassFingerprint$IdentifyListener", "", "Com.Samsung.Android.Sdk.Pass.SpassFingerprint/IIdentifyListenerInvoker")]
		public partial interface IIdentifyListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/interface[@name='SpassFingerprint.IdentifyListener']/method[@name='onCompleted' and count(parameter)=0]"
			[Register ("onCompleted", "()V", "GetOnCompletedHandler:Com.Samsung.Android.Sdk.Pass.SpassFingerprint/IIdentifyListenerInvoker, Plugin.Fingerprint.Android.Samsung")]
			void OnCompleted ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/interface[@name='SpassFingerprint.IdentifyListener']/method[@name='onFinished' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onFinished", "(I)V", "GetOnFinished_IHandler:Com.Samsung.Android.Sdk.Pass.SpassFingerprint/IIdentifyListenerInvoker, Plugin.Fingerprint.Android.Samsung")]
			void OnFinished ([global::Android.Runtime.GeneratedEnum] global::Com.Samsung.Android.Sdk.Pass.SpassFingerprintStatus p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/interface[@name='SpassFingerprint.IdentifyListener']/method[@name='onReady' and count(parameter)=0]"
			[Register ("onReady", "()V", "GetOnReadyHandler:Com.Samsung.Android.Sdk.Pass.SpassFingerprint/IIdentifyListenerInvoker, Plugin.Fingerprint.Android.Samsung")]
			void OnReady ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/interface[@name='SpassFingerprint.IdentifyListener']/method[@name='onStarted' and count(parameter)=0]"
			[Register ("onStarted", "()V", "GetOnStartedHandler:Com.Samsung.Android.Sdk.Pass.SpassFingerprint/IIdentifyListenerInvoker, Plugin.Fingerprint.Android.Samsung")]
			void OnStarted ();

		}

		[global::Android.Runtime.Register ("com/samsung/android/sdk/pass/SpassFingerprint$IdentifyListener", DoNotGenerateAcw=true)]
		internal class IIdentifyListenerInvoker : global::Java.Lang.Object, IIdentifyListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/samsung/android/sdk/pass/SpassFingerprint$IdentifyListener", typeof (IIdentifyListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IIdentifyListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IIdentifyListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.samsung.android.sdk.pass.SpassFingerprint.IdentifyListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IIdentifyListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCompleted;
#pragma warning disable 0169
			static Delegate GetOnCompletedHandler ()
			{
				if (cb_onCompleted == null)
					cb_onCompleted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCompleted);
				return cb_onCompleted;
			}

			static void n_OnCompleted (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCompleted ();
			}
#pragma warning restore 0169

			IntPtr id_onCompleted;
			public unsafe void OnCompleted ()
			{
				if (id_onCompleted == IntPtr.Zero)
					id_onCompleted = JNIEnv.GetMethodID (class_ref, "onCompleted", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompleted);
			}

			static Delegate cb_onFinished_I;
#pragma warning disable 0169
			static Delegate GetOnFinished_IHandler ()
			{
				if (cb_onFinished_I == null)
					cb_onFinished_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnFinished_I);
				return cb_onFinished_I;
			}

			static void n_OnFinished_I (IntPtr jnienv, IntPtr native__this, int native_p0)
			{
				global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Samsung.Android.Sdk.Pass.SpassFingerprintStatus p0 = (global::Com.Samsung.Android.Sdk.Pass.SpassFingerprintStatus) native_p0;
				__this.OnFinished (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFinished_I;
			public unsafe void OnFinished ([global::Android.Runtime.GeneratedEnum] global::Com.Samsung.Android.Sdk.Pass.SpassFingerprintStatus p0)
			{
				if (id_onFinished_I == IntPtr.Zero)
					id_onFinished_I = JNIEnv.GetMethodID (class_ref, "onFinished", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((int) p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFinished_I, __args);
			}

			static Delegate cb_onReady;
#pragma warning disable 0169
			static Delegate GetOnReadyHandler ()
			{
				if (cb_onReady == null)
					cb_onReady = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnReady);
				return cb_onReady;
			}

			static void n_OnReady (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnReady ();
			}
#pragma warning restore 0169

			IntPtr id_onReady;
			public unsafe void OnReady ()
			{
				if (id_onReady == IntPtr.Zero)
					id_onReady = JNIEnv.GetMethodID (class_ref, "onReady", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReady);
			}

			static Delegate cb_onStarted;
#pragma warning disable 0169
			static Delegate GetOnStartedHandler ()
			{
				if (cb_onStarted == null)
					cb_onStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStarted);
				return cb_onStarted;
			}

			static void n_OnStarted (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnStarted ();
			}
#pragma warning restore 0169

			IntPtr id_onStarted;
			public unsafe void OnStarted ()
			{
				if (id_onStarted == IntPtr.Zero)
					id_onStarted = JNIEnv.GetMethodID (class_ref, "onStarted", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStarted);
			}

		}

		// event args for com.samsung.android.sdk.pass.SpassFingerprint.IdentifyListener.onFinished
		public partial class FinishedEventArgs : global::System.EventArgs {

			public FinishedEventArgs (global::Com.Samsung.Android.Sdk.Pass.SpassFingerprintStatus p0)
			{
				this.p0 = p0;
			}

			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprintStatus p0;
			public global::Com.Samsung.Android.Sdk.Pass.SpassFingerprintStatus P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/samsung/android/sdk/pass/SpassFingerprint_IdentifyListenerImplementor")]
		internal sealed partial class IIdentifyListenerImplementor : global::Java.Lang.Object, IIdentifyListener {

			object sender;

			public IIdentifyListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/samsung/android/sdk/pass/SpassFingerprint_IdentifyListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnCompletedHandler;
#pragma warning restore 0649

			public void OnCompleted ()
			{
				var __h = OnCompletedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<FinishedEventArgs> OnFinishedHandler;
#pragma warning restore 0649

			public void OnFinished ([global::Android.Runtime.GeneratedEnum] global::Com.Samsung.Android.Sdk.Pass.SpassFingerprintStatus p0)
			{
				var __h = OnFinishedHandler;
				if (__h != null)
					__h (sender, new FinishedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler OnReadyHandler;
#pragma warning restore 0649

			public void OnReady ()
			{
				var __h = OnReadyHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnStartedHandler;
#pragma warning restore 0649

			public void OnStarted ()
			{
				var __h = OnStartedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IIdentifyListenerImplementor value)
			{
				return value.OnCompletedHandler == null && value.OnFinishedHandler == null && value.OnReadyHandler == null && value.OnStartedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.samsung.android.sdk.pass']/interface[@name='SpassFingerprint.RegisterListener']"
		[Register ("com/samsung/android/sdk/pass/SpassFingerprint$RegisterListener", "", "Com.Samsung.Android.Sdk.Pass.SpassFingerprint/IRegisterListenerInvoker")]
		public partial interface IRegisterListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/interface[@name='SpassFingerprint.RegisterListener']/method[@name='onFinished' and count(parameter)=0]"
			[Register ("onFinished", "()V", "GetOnFinishedHandler:Com.Samsung.Android.Sdk.Pass.SpassFingerprint/IRegisterListenerInvoker, Plugin.Fingerprint.Android.Samsung")]
			void OnFinished ();

		}

		[global::Android.Runtime.Register ("com/samsung/android/sdk/pass/SpassFingerprint$RegisterListener", DoNotGenerateAcw=true)]
		internal class IRegisterListenerInvoker : global::Java.Lang.Object, IRegisterListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/samsung/android/sdk/pass/SpassFingerprint$RegisterListener", typeof (IRegisterListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IRegisterListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegisterListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.samsung.android.sdk.pass.SpassFingerprint.RegisterListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegisterListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFinished;
#pragma warning disable 0169
			static Delegate GetOnFinishedHandler ()
			{
				if (cb_onFinished == null)
					cb_onFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFinished);
				return cb_onFinished;
			}

			static void n_OnFinished (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IRegisterListener __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IRegisterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFinished ();
			}
#pragma warning restore 0169

			IntPtr id_onFinished;
			public unsafe void OnFinished ()
			{
				if (id_onFinished == IntPtr.Zero)
					id_onFinished = JNIEnv.GetMethodID (class_ref, "onFinished", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFinished);
			}

		}

		[global::Android.Runtime.Register ("mono/com/samsung/android/sdk/pass/SpassFingerprint_RegisterListenerImplementor")]
		internal sealed partial class IRegisterListenerImplementor : global::Java.Lang.Object, IRegisterListener {

			object sender;

			public IRegisterListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/samsung/android/sdk/pass/SpassFingerprint_RegisterListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnFinished ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IRegisterListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/samsung/android/sdk/pass/SpassFingerprint", typeof (SpassFingerprint));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected SpassFingerprint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/constructor[@name='SpassFingerprint' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SpassFingerprint (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getGuideForPoorQuality;
#pragma warning disable 0169
		static Delegate GetGetGuideForPoorQualityHandler ()
		{
			if (cb_getGuideForPoorQuality == null)
				cb_getGuideForPoorQuality = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGuideForPoorQuality);
			return cb_getGuideForPoorQuality;
		}

		static IntPtr n_GetGuideForPoorQuality (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GuideForPoorQuality);
		}
#pragma warning restore 0169

		public virtual unsafe string GuideForPoorQuality {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/method[@name='getGuideForPoorQuality' and count(parameter)=0]"
			[Register ("getGuideForPoorQuality", "()Ljava/lang/String;", "GetGetGuideForPoorQualityHandler")]
			get {
				const string __id = "getGuideForPoorQuality.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasRegisteredFinger;
#pragma warning disable 0169
		static Delegate GetHasRegisteredFingerHandler ()
		{
			if (cb_hasRegisteredFinger == null)
				cb_hasRegisteredFinger = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasRegisteredFinger);
			return cb_hasRegisteredFinger;
		}

		static bool n_HasRegisteredFinger (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasRegisteredFinger;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasRegisteredFinger {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/method[@name='hasRegisteredFinger' and count(parameter)=0]"
			[Register ("hasRegisteredFinger", "()Z", "GetHasRegisteredFingerHandler")]
			get {
				const string __id = "hasRegisteredFinger.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIdentifiedFingerprintIndex;
#pragma warning disable 0169
		static Delegate GetGetIdentifiedFingerprintIndexHandler ()
		{
			if (cb_getIdentifiedFingerprintIndex == null)
				cb_getIdentifiedFingerprintIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIdentifiedFingerprintIndex);
			return cb_getIdentifiedFingerprintIndex;
		}

		static int n_GetIdentifiedFingerprintIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IdentifiedFingerprintIndex;
		}
#pragma warning restore 0169

		public virtual unsafe int IdentifiedFingerprintIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/method[@name='getIdentifiedFingerprintIndex' and count(parameter)=0]"
			[Register ("getIdentifiedFingerprintIndex", "()I", "GetGetIdentifiedFingerprintIndexHandler")]
			get {
				const string __id = "getIdentifiedFingerprintIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRegisteredFingerprintName;
#pragma warning disable 0169
		static Delegate GetGetRegisteredFingerprintNameHandler ()
		{
			if (cb_getRegisteredFingerprintName == null)
				cb_getRegisteredFingerprintName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegisteredFingerprintName);
			return cb_getRegisteredFingerprintName;
		}

		static IntPtr n_GetRegisteredFingerprintName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RegisteredFingerprintName);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Util.SparseArray RegisteredFingerprintName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/method[@name='getRegisteredFingerprintName' and count(parameter)=0]"
			[Register ("getRegisteredFingerprintName", "()Landroid/util/SparseArray;", "GetGetRegisteredFingerprintNameHandler")]
			get {
				const string __id = "getRegisteredFingerprintName.()Landroid/util/SparseArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRegisteredFingerprintUniqueID;
#pragma warning disable 0169
		static Delegate GetGetRegisteredFingerprintUniqueIDHandler ()
		{
			if (cb_getRegisteredFingerprintUniqueID == null)
				cb_getRegisteredFingerprintUniqueID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegisteredFingerprintUniqueID);
			return cb_getRegisteredFingerprintUniqueID;
		}

		static IntPtr n_GetRegisteredFingerprintUniqueID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RegisteredFingerprintUniqueID);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Util.SparseArray RegisteredFingerprintUniqueID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/method[@name='getRegisteredFingerprintUniqueID' and count(parameter)=0]"
			[Register ("getRegisteredFingerprintUniqueID", "()Landroid/util/SparseArray;", "GetGetRegisteredFingerprintUniqueIDHandler")]
			get {
				const string __id = "getRegisteredFingerprintUniqueID.()Landroid/util/SparseArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cancelIdentify;
#pragma warning disable 0169
		static Delegate GetCancelIdentifyHandler ()
		{
			if (cb_cancelIdentify == null)
				cb_cancelIdentify = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelIdentify);
			return cb_cancelIdentify;
		}

		static void n_CancelIdentify (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelIdentify ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/method[@name='cancelIdentify' and count(parameter)=0]"
		[Register ("cancelIdentify", "()V", "GetCancelIdentifyHandler")]
		public virtual unsafe void CancelIdentify ()
		{
			const string __id = "cancelIdentify.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_changeStandbyString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetChangeStandbyString_Ljava_lang_String_Handler ()
		{
			if (cb_changeStandbyString_Ljava_lang_String_ == null)
				cb_changeStandbyString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ChangeStandbyString_Ljava_lang_String_);
			return cb_changeStandbyString_Ljava_lang_String_;
		}

		static void n_ChangeStandbyString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChangeStandbyString (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/method[@name='changeStandbyString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("changeStandbyString", "(Ljava/lang/String;)V", "GetChangeStandbyString_Ljava_lang_String_Handler")]
		public virtual unsafe void ChangeStandbyString (string p0)
		{
			const string __id = "changeStandbyString.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCanceledOnTouchOutside_Z;
#pragma warning disable 0169
		static Delegate GetSetCanceledOnTouchOutside_ZHandler ()
		{
			if (cb_setCanceledOnTouchOutside_Z == null)
				cb_setCanceledOnTouchOutside_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCanceledOnTouchOutside_Z);
			return cb_setCanceledOnTouchOutside_Z;
		}

		static void n_SetCanceledOnTouchOutside_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCanceledOnTouchOutside (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/method[@name='setCanceledOnTouchOutside' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCanceledOnTouchOutside", "(Z)V", "GetSetCanceledOnTouchOutside_ZHandler")]
		public virtual unsafe void SetCanceledOnTouchOutside (bool p0)
		{
			const string __id = "setCanceledOnTouchOutside.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDialogBgTransparency_I;
#pragma warning disable 0169
		static Delegate GetSetDialogBgTransparency_IHandler ()
		{
			if (cb_setDialogBgTransparency_I == null)
				cb_setDialogBgTransparency_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDialogBgTransparency_I);
			return cb_setDialogBgTransparency_I;
		}

		static void n_SetDialogBgTransparency_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDialogBgTransparency (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/method[@name='setDialogBgTransparency' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDialogBgTransparency", "(I)V", "GetSetDialogBgTransparency_IHandler")]
		public virtual unsafe void SetDialogBgTransparency (int p0)
		{
			const string __id = "setDialogBgTransparency.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDialogButton_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDialogButton_Ljava_lang_String_Handler ()
		{
			if (cb_setDialogButton_Ljava_lang_String_ == null)
				cb_setDialogButton_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDialogButton_Ljava_lang_String_);
			return cb_setDialogButton_Ljava_lang_String_;
		}

		static void n_SetDialogButton_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDialogButton (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/method[@name='setDialogButton' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDialogButton", "(Ljava/lang/String;)V", "GetSetDialogButton_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDialogButton (string p0)
		{
			const string __id = "setDialogButton.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDialogIcon_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDialogIcon_Ljava_lang_String_Handler ()
		{
			if (cb_setDialogIcon_Ljava_lang_String_ == null)
				cb_setDialogIcon_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDialogIcon_Ljava_lang_String_);
			return cb_setDialogIcon_Ljava_lang_String_;
		}

		static void n_SetDialogIcon_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDialogIcon (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/method[@name='setDialogIcon' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDialogIcon", "(Ljava/lang/String;)V", "GetSetDialogIcon_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDialogIcon (string p0)
		{
			const string __id = "setDialogIcon.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDialogTitle_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetDialogTitle_Ljava_lang_String_IHandler ()
		{
			if (cb_setDialogTitle_Ljava_lang_String_I == null)
				cb_setDialogTitle_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetDialogTitle_Ljava_lang_String_I);
			return cb_setDialogTitle_Ljava_lang_String_I;
		}

		static void n_SetDialogTitle_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDialogTitle (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/method[@name='setDialogTitle' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setDialogTitle", "(Ljava/lang/String;I)V", "GetSetDialogTitle_Ljava_lang_String_IHandler")]
		public virtual unsafe void SetDialogTitle (string p0, int p1)
		{
			const string __id = "setDialogTitle.(Ljava/lang/String;I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setIntendedFingerprintIndex_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetIntendedFingerprintIndex_Ljava_util_ArrayList_Handler ()
		{
			if (cb_setIntendedFingerprintIndex_Ljava_util_ArrayList_ == null)
				cb_setIntendedFingerprintIndex_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIntendedFingerprintIndex_Ljava_util_ArrayList_);
			return cb_setIntendedFingerprintIndex_Ljava_util_ArrayList_;
		}

		static void n_SetIntendedFingerprintIndex_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIntendedFingerprintIndex (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/method[@name='setIntendedFingerprintIndex' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
		[Register ("setIntendedFingerprintIndex", "(Ljava/util/ArrayList;)V", "GetSetIntendedFingerprintIndex_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void SetIntendedFingerprintIndex (global::System.Collections.IList p0)
		{
			const string __id = "setIntendedFingerprintIndex.(Ljava/util/ArrayList;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_startIdentify_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_;
#pragma warning disable 0169
		static Delegate GetStartIdentify_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_Handler ()
		{
			if (cb_startIdentify_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_ == null)
				cb_startIdentify_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartIdentify_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_);
			return cb_startIdentify_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_;
		}

		static void n_StartIdentify_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener p0 = (global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener)global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartIdentify (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/method[@name='startIdentify' and count(parameter)=1 and parameter[1][@type='com.samsung.android.sdk.pass.SpassFingerprint.IdentifyListener']]"
		[Register ("startIdentify", "(Lcom/samsung/android/sdk/pass/SpassFingerprint$IdentifyListener;)V", "GetStartIdentify_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_Handler")]
		public virtual unsafe void StartIdentify (global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener p0)
		{
			const string __id = "startIdentify.(Lcom/samsung/android/sdk/pass/SpassFingerprint$IdentifyListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startIdentifyWithDialog_Landroid_content_Context_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_Z;
#pragma warning disable 0169
		static Delegate GetStartIdentifyWithDialog_Landroid_content_Context_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_ZHandler ()
		{
			if (cb_startIdentifyWithDialog_Landroid_content_Context_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_Z == null)
				cb_startIdentifyWithDialog_Landroid_content_Context_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_StartIdentifyWithDialog_Landroid_content_Context_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_Z);
			return cb_startIdentifyWithDialog_Landroid_content_Context_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_Z;
		}

		static void n_StartIdentifyWithDialog_Landroid_content_Context_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener p1 = (global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener)global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartIdentifyWithDialog (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassFingerprint']/method[@name='startIdentifyWithDialog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.samsung.android.sdk.pass.SpassFingerprint.IdentifyListener'] and parameter[3][@type='boolean']]"
		[Register ("startIdentifyWithDialog", "(Landroid/content/Context;Lcom/samsung/android/sdk/pass/SpassFingerprint$IdentifyListener;Z)V", "GetStartIdentifyWithDialog_Landroid_content_Context_Lcom_samsung_android_sdk_pass_SpassFingerprint_IdentifyListener_ZHandler")]
		public virtual unsafe void StartIdentifyWithDialog (global::Android.Content.Context p0, global::Com.Samsung.Android.Sdk.Pass.SpassFingerprint.IIdentifyListener p1, bool p2)
		{
			const string __id = "startIdentifyWithDialog.(Landroid/content/Context;Lcom/samsung/android/sdk/pass/SpassFingerprint$IdentifyListener;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
