using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Samsung.Android.Sdk.Pass.Support {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/class[@name='SdkSupporter']"
	[global::Android.Runtime.Register ("com/samsung/android/sdk/pass/support/SdkSupporter", DoNotGenerateAcw=true)]
	public partial class SdkSupporter : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/class[@name='SdkSupporter']/field[@name='CLASSNAME_FINGERPRINT_CLIENT']"
		[Register ("CLASSNAME_FINGERPRINT_CLIENT")]
		public const string ClassnameFingerprintClient = (string) "com.samsung.android.fingerprint.IFingerprintClient$Stub";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/class[@name='SdkSupporter']/field[@name='CLASSNAME_FINGERPRINT_CLIENT_SPEC_BUILDER']"
		[Register ("CLASSNAME_FINGERPRINT_CLIENT_SPEC_BUILDER")]
		public const string ClassnameFingerprintClientSpecBuilder = (string) "com.samsung.android.fingerprint.FingerprintManager$FingerprintClientSpecBuilder";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/class[@name='SdkSupporter']/field[@name='CLASSNAME_FINGERPRINT_MANAGER']"
		[Register ("CLASSNAME_FINGERPRINT_MANAGER")]
		public const string ClassnameFingerprintManager = (string) "com.samsung.android.fingerprint.FingerprintManager";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/samsung/android/sdk/pass/support/SdkSupporter", typeof (SdkSupporter));
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

		protected SdkSupporter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/class[@name='SdkSupporter']/constructor[@name='SdkSupporter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SdkSupporter ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/class[@name='SdkSupporter']/method[@name='copyStaticFields' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("copyStaticFields", "(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool CopyStaticFields (global::Java.Lang.Object p0, global::Java.Lang.Class p1, string p2, string p3)
		{
			const string __id = "copyStaticFields.(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
