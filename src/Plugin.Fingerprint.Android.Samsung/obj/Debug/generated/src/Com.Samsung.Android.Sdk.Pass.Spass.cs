using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Samsung.Android.Sdk.Pass {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='Spass']"
	[global::Android.Runtime.Register ("com/samsung/android/sdk/pass/Spass", DoNotGenerateAcw=true)]
	public partial class Spass : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='Spass']/field[@name='DEVICE_FINGERPRINT']"
		[Register ("DEVICE_FINGERPRINT")]
		public const int DeviceFingerprint = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='Spass']/field[@name='DEVICE_FINGERPRINT_AVAILABLE_PASSWORD']"
		[Register ("DEVICE_FINGERPRINT_AVAILABLE_PASSWORD")]
		public const int DeviceFingerprintAvailablePassword = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='Spass']/field[@name='DEVICE_FINGERPRINT_CUSTOMIZED_DIALOG']"
		[Register ("DEVICE_FINGERPRINT_CUSTOMIZED_DIALOG")]
		public const int DeviceFingerprintCustomizedDialog = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='Spass']/field[@name='DEVICE_FINGERPRINT_FINGER_INDEX']"
		[Register ("DEVICE_FINGERPRINT_FINGER_INDEX")]
		public const int DeviceFingerprintFingerIndex = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='Spass']/field[@name='DEVICE_FINGERPRINT_UNIQUE_ID']"
		[Register ("DEVICE_FINGERPRINT_UNIQUE_ID")]
		public const int DeviceFingerprintUniqueId = (int) 3;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/samsung/android/sdk/pass/Spass", typeof (Spass));
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

		protected Spass (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='Spass']/constructor[@name='Spass' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Spass ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getVersionCode;
#pragma warning disable 0169
		static Delegate GetGetVersionCodeHandler ()
		{
			if (cb_getVersionCode == null)
				cb_getVersionCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersionCode);
			return cb_getVersionCode;
		}

		static int n_GetVersionCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.Spass __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Spass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VersionCode;
		}
#pragma warning restore 0169

		public virtual unsafe int VersionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='Spass']/method[@name='getVersionCode' and count(parameter)=0]"
			[Register ("getVersionCode", "()I", "GetGetVersionCodeHandler")]
			get {
				const string __id = "getVersionCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getVersionName;
#pragma warning disable 0169
		static Delegate GetGetVersionNameHandler ()
		{
			if (cb_getVersionName == null)
				cb_getVersionName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersionName);
			return cb_getVersionName;
		}

		static IntPtr n_GetVersionName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.Spass __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Spass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersionName);
		}
#pragma warning restore 0169

		public virtual unsafe string VersionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='Spass']/method[@name='getVersionName' and count(parameter)=0]"
			[Register ("getVersionName", "()Ljava/lang/String;", "GetGetVersionNameHandler")]
			get {
				const string __id = "getVersionName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_initialize_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInitialize_Landroid_content_Context_Handler ()
		{
			if (cb_initialize_Landroid_content_Context_ == null)
				cb_initialize_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Initialize_Landroid_content_Context_);
			return cb_initialize_Landroid_content_Context_;
		}

		static void n_Initialize_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Samsung.Android.Sdk.Pass.Spass __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Spass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='Spass']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initialize", "(Landroid/content/Context;)V", "GetInitialize_Landroid_content_Context_Handler")]
		public virtual unsafe void Initialize (global::Android.Content.Context p0)
		{
			const string __id = "initialize.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isFeatureEnabled_I;
#pragma warning disable 0169
		static Delegate GetIsFeatureEnabled_IHandler ()
		{
			if (cb_isFeatureEnabled_I == null)
				cb_isFeatureEnabled_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsFeatureEnabled_I);
			return cb_isFeatureEnabled_I;
		}

		static bool n_IsFeatureEnabled_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Samsung.Android.Sdk.Pass.Spass __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Spass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFeatureEnabled (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='Spass']/method[@name='isFeatureEnabled' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isFeatureEnabled", "(I)Z", "GetIsFeatureEnabled_IHandler")]
		public virtual unsafe bool IsFeatureEnabled (int p0)
		{
			const string __id = "isFeatureEnabled.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
