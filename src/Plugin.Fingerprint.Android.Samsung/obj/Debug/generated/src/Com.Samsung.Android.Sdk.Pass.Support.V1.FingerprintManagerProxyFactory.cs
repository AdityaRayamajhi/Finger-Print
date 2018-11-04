using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Samsung.Android.Sdk.Pass.Support.V1 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.samsung.android.sdk.pass.support.v1']/class[@name='FingerprintManagerProxyFactory']"
	[global::Android.Runtime.Register ("com/samsung/android/sdk/pass/support/v1/FingerprintManagerProxyFactory", DoNotGenerateAcw=true)]
	public partial class FingerprintManagerProxyFactory : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/samsung/android/sdk/pass/support/v1/FingerprintManagerProxyFactory", typeof (FingerprintManagerProxyFactory));
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

		protected FingerprintManagerProxyFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.samsung.android.sdk.pass.support.v1']/class[@name='FingerprintManagerProxyFactory']/constructor[@name='FingerprintManagerProxyFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FingerprintManagerProxyFactory ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support.v1']/class[@name='FingerprintManagerProxyFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("create", "(Landroid/content/Context;)Lcom/samsung/android/sdk/pass/support/IFingerprintManagerProxy;", "")]
		public static unsafe global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy Create (global::Android.Content.Context p0)
		{
			const string __id = "create.(Landroid/content/Context;)Lcom/samsung/android/sdk/pass/support/IFingerprintManagerProxy;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
