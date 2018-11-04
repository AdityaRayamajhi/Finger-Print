using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Samsung.Android.Sdk.Pass {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassInvalidStateException']"
	[global::Android.Runtime.Register ("com/samsung/android/sdk/pass/SpassInvalidStateException", DoNotGenerateAcw=true)]
	public partial class SpassInvalidStateException : global::Java.Lang.IllegalStateException {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassInvalidStateException']/field[@name='STATUS_OPERATION_DENIED']"
		[Register ("STATUS_OPERATION_DENIED")]
		public const int StatusOperationDenied = (int) 1;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/samsung/android/sdk/pass/SpassInvalidStateException", typeof (SpassInvalidStateException));
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

		protected SpassInvalidStateException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassInvalidStateException']/constructor[@name='SpassInvalidStateException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe SpassInvalidStateException (string p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.SpassInvalidStateException __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.SpassInvalidStateException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		public virtual unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass']/class[@name='SpassInvalidStateException']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
