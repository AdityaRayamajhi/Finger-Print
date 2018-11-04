using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Samsung.Android.Sdk.Pass.Support {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/interface[@name='IFingerprintManagerProxy']"
	[Register ("com/samsung/android/sdk/pass/support/IFingerprintManagerProxy", "", "Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxyInvoker")]
	public partial interface IFingerprintManagerProxy : IJavaObject {

		int EnrolledFingers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/interface[@name='IFingerprintManagerProxy']/method[@name='getEnrolledFingers' and count(parameter)=0]"
			[Register ("getEnrolledFingers", "()I", "GetGetEnrolledFingersHandler:Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxyInvoker, Plugin.Fingerprint.Android.Samsung")] get;
		}

		bool HasPendingCommand {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/interface[@name='IFingerprintManagerProxy']/method[@name='hasPendingCommand' and count(parameter)=0]"
			[Register ("hasPendingCommand", "()Z", "GetHasPendingCommandHandler:Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxyInvoker, Plugin.Fingerprint.Android.Samsung")] get;
		}

		bool IsEnrolling {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/interface[@name='IFingerprintManagerProxy']/method[@name='isEnrolling' and count(parameter)=0]"
			[Register ("isEnrolling", "()Z", "GetIsEnrollingHandler:Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxyInvoker, Plugin.Fingerprint.Android.Samsung")] get;
		}

		bool IsSupportBackupPassword {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/interface[@name='IFingerprintManagerProxy']/method[@name='isSupportBackupPassword' and count(parameter)=0]"
			[Register ("isSupportBackupPassword", "()Z", "GetIsSupportBackupPasswordHandler:Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxyInvoker, Plugin.Fingerprint.Android.Samsung")] get;
		}

		bool IsSupportFingerprintIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/interface[@name='IFingerprintManagerProxy']/method[@name='isSupportFingerprintIds' and count(parameter)=0]"
			[Register ("isSupportFingerprintIds", "()Z", "GetIsSupportFingerprintIdsHandler:Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxyInvoker, Plugin.Fingerprint.Android.Samsung")] get;
		}

		int SensorType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/interface[@name='IFingerprintManagerProxy']/method[@name='getSensorType' and count(parameter)=0]"
			[Register ("getSensorType", "()I", "GetGetSensorTypeHandler:Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxyInvoker, Plugin.Fingerprint.Android.Samsung")] get;
		}

		int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/interface[@name='IFingerprintManagerProxy']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler:Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxyInvoker, Plugin.Fingerprint.Android.Samsung")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/interface[@name='IFingerprintManagerProxy']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("cancel", "(Landroid/os/IBinder;)Z", "GetCancel_Landroid_os_IBinder_Handler:Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxyInvoker, Plugin.Fingerprint.Android.Samsung")]
		bool Cancel (global::Android.OS.IBinder p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/interface[@name='IFingerprintManagerProxy']/method[@name='getFingerprintId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFingerprintId", "(I)Ljava/lang/String;", "GetGetFingerprintId_IHandler:Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxyInvoker, Plugin.Fingerprint.Android.Samsung")]
		string GetFingerprintId (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/interface[@name='IFingerprintManagerProxy']/method[@name='getIndexName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getIndexName", "(I)Ljava/lang/String;", "GetGetIndexName_IHandler:Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxyInvoker, Plugin.Fingerprint.Android.Samsung")]
		string GetIndexName (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/interface[@name='IFingerprintManagerProxy']/method[@name='identify' and count(parameter)=2 and parameter[1][@type='android.os.IBinder'] and parameter[2][@type='java.lang.String']]"
		[Register ("identify", "(Landroid/os/IBinder;Ljava/lang/String;)I", "GetIdentify_Landroid_os_IBinder_Ljava_lang_String_Handler:Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxyInvoker, Plugin.Fingerprint.Android.Samsung")]
		int Identify (global::Android.OS.IBinder p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/interface[@name='IFingerprintManagerProxy']/method[@name='notifyAppActivityState' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("notifyAppActivityState", "(ILandroid/os/Bundle;)V", "GetNotifyAppActivityState_ILandroid_os_Bundle_Handler:Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxyInvoker, Plugin.Fingerprint.Android.Samsung")]
		void NotifyAppActivityState (int p0, global::Android.OS.Bundle p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/interface[@name='IFingerprintManagerProxy']/method[@name='notifyEnrollEnd' and count(parameter)=0]"
		[Register ("notifyEnrollEnd", "()Z", "GetNotifyEnrollEndHandler:Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxyInvoker, Plugin.Fingerprint.Android.Samsung")]
		bool NotifyEnrollEnd ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.samsung.android.sdk.pass.support']/interface[@name='IFingerprintManagerProxy']/method[@name='unregisterClient' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("unregisterClient", "(Landroid/os/IBinder;)Z", "GetUnregisterClient_Landroid_os_IBinder_Handler:Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxyInvoker, Plugin.Fingerprint.Android.Samsung")]
		bool UnregisterClient (global::Android.OS.IBinder p0);

	}

	[global::Android.Runtime.Register ("com/samsung/android/sdk/pass/support/IFingerprintManagerProxy", DoNotGenerateAcw=true)]
	internal class IFingerprintManagerProxyInvoker : global::Java.Lang.Object, IFingerprintManagerProxy {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/samsung/android/sdk/pass/support/IFingerprintManagerProxy", typeof (IFingerprintManagerProxyInvoker));

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

		public static IFingerprintManagerProxy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFingerprintManagerProxy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.samsung.android.sdk.pass.support.IFingerprintManagerProxy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFingerprintManagerProxyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getEnrolledFingers;
#pragma warning disable 0169
		static Delegate GetGetEnrolledFingersHandler ()
		{
			if (cb_getEnrolledFingers == null)
				cb_getEnrolledFingers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEnrolledFingers);
			return cb_getEnrolledFingers;
		}

		static int n_GetEnrolledFingers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnrolledFingers;
		}
#pragma warning restore 0169

		IntPtr id_getEnrolledFingers;
		public unsafe int EnrolledFingers {
			get {
				if (id_getEnrolledFingers == IntPtr.Zero)
					id_getEnrolledFingers = JNIEnv.GetMethodID (class_ref, "getEnrolledFingers", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEnrolledFingers);
			}
		}

		static Delegate cb_hasPendingCommand;
#pragma warning disable 0169
		static Delegate GetHasPendingCommandHandler ()
		{
			if (cb_hasPendingCommand == null)
				cb_hasPendingCommand = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPendingCommand);
			return cb_hasPendingCommand;
		}

		static bool n_HasPendingCommand (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPendingCommand;
		}
#pragma warning restore 0169

		IntPtr id_hasPendingCommand;
		public unsafe bool HasPendingCommand {
			get {
				if (id_hasPendingCommand == IntPtr.Zero)
					id_hasPendingCommand = JNIEnv.GetMethodID (class_ref, "hasPendingCommand", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasPendingCommand);
			}
		}

		static Delegate cb_isEnrolling;
#pragma warning disable 0169
		static Delegate GetIsEnrollingHandler ()
		{
			if (cb_isEnrolling == null)
				cb_isEnrolling = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnrolling);
			return cb_isEnrolling;
		}

		static bool n_IsEnrolling (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnrolling;
		}
#pragma warning restore 0169

		IntPtr id_isEnrolling;
		public unsafe bool IsEnrolling {
			get {
				if (id_isEnrolling == IntPtr.Zero)
					id_isEnrolling = JNIEnv.GetMethodID (class_ref, "isEnrolling", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnrolling);
			}
		}

		static Delegate cb_isSupportBackupPassword;
#pragma warning disable 0169
		static Delegate GetIsSupportBackupPasswordHandler ()
		{
			if (cb_isSupportBackupPassword == null)
				cb_isSupportBackupPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSupportBackupPassword);
			return cb_isSupportBackupPassword;
		}

		static bool n_IsSupportBackupPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupportBackupPassword;
		}
#pragma warning restore 0169

		IntPtr id_isSupportBackupPassword;
		public unsafe bool IsSupportBackupPassword {
			get {
				if (id_isSupportBackupPassword == IntPtr.Zero)
					id_isSupportBackupPassword = JNIEnv.GetMethodID (class_ref, "isSupportBackupPassword", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupportBackupPassword);
			}
		}

		static Delegate cb_isSupportFingerprintIds;
#pragma warning disable 0169
		static Delegate GetIsSupportFingerprintIdsHandler ()
		{
			if (cb_isSupportFingerprintIds == null)
				cb_isSupportFingerprintIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSupportFingerprintIds);
			return cb_isSupportFingerprintIds;
		}

		static bool n_IsSupportFingerprintIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupportFingerprintIds;
		}
#pragma warning restore 0169

		IntPtr id_isSupportFingerprintIds;
		public unsafe bool IsSupportFingerprintIds {
			get {
				if (id_isSupportFingerprintIds == IntPtr.Zero)
					id_isSupportFingerprintIds = JNIEnv.GetMethodID (class_ref, "isSupportFingerprintIds", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupportFingerprintIds);
			}
		}

		static Delegate cb_getSensorType;
#pragma warning disable 0169
		static Delegate GetGetSensorTypeHandler ()
		{
			if (cb_getSensorType == null)
				cb_getSensorType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSensorType);
			return cb_getSensorType;
		}

		static int n_GetSensorType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SensorType;
		}
#pragma warning restore 0169

		IntPtr id_getSensorType;
		public unsafe int SensorType {
			get {
				if (id_getSensorType == IntPtr.Zero)
					id_getSensorType = JNIEnv.GetMethodID (class_ref, "getSensorType", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSensorType);
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersion);
			return cb_getVersion;
		}

		static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		IntPtr id_getVersion;
		public unsafe int Version {
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVersion);
			}
		}

		static Delegate cb_cancel_Landroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetCancel_Landroid_os_IBinder_Handler ()
		{
			if (cb_cancel_Landroid_os_IBinder_ == null)
				cb_cancel_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Cancel_Landroid_os_IBinder_);
			return cb_cancel_Landroid_os_IBinder_;
		}

		static bool n_Cancel_Landroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IBinder p0 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Cancel (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_cancel_Landroid_os_IBinder_;
		public unsafe bool Cancel (global::Android.OS.IBinder p0)
		{
			if (id_cancel_Landroid_os_IBinder_ == IntPtr.Zero)
				id_cancel_Landroid_os_IBinder_ = JNIEnv.GetMethodID (class_ref, "cancel", "(Landroid/os/IBinder;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_cancel_Landroid_os_IBinder_, __args);
			return __ret;
		}

		static Delegate cb_getFingerprintId_I;
#pragma warning disable 0169
		static Delegate GetGetFingerprintId_IHandler ()
		{
			if (cb_getFingerprintId_I == null)
				cb_getFingerprintId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetFingerprintId_I);
			return cb_getFingerprintId_I;
		}

		static IntPtr n_GetFingerprintId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetFingerprintId (p0));
		}
#pragma warning restore 0169

		IntPtr id_getFingerprintId_I;
		public unsafe string GetFingerprintId (int p0)
		{
			if (id_getFingerprintId_I == IntPtr.Zero)
				id_getFingerprintId_I = JNIEnv.GetMethodID (class_ref, "getFingerprintId", "(I)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFingerprintId_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getIndexName_I;
#pragma warning disable 0169
		static Delegate GetGetIndexName_IHandler ()
		{
			if (cb_getIndexName_I == null)
				cb_getIndexName_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetIndexName_I);
			return cb_getIndexName_I;
		}

		static IntPtr n_GetIndexName_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetIndexName (p0));
		}
#pragma warning restore 0169

		IntPtr id_getIndexName_I;
		public unsafe string GetIndexName (int p0)
		{
			if (id_getIndexName_I == IntPtr.Zero)
				id_getIndexName_I = JNIEnv.GetMethodID (class_ref, "getIndexName", "(I)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIndexName_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_identify_Landroid_os_IBinder_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIdentify_Landroid_os_IBinder_Ljava_lang_String_Handler ()
		{
			if (cb_identify_Landroid_os_IBinder_Ljava_lang_String_ == null)
				cb_identify_Landroid_os_IBinder_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Identify_Landroid_os_IBinder_Ljava_lang_String_);
			return cb_identify_Landroid_os_IBinder_Ljava_lang_String_;
		}

		static int n_Identify_Landroid_os_IBinder_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IBinder p0 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Identify (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_identify_Landroid_os_IBinder_Ljava_lang_String_;
		public unsafe int Identify (global::Android.OS.IBinder p0, string p1)
		{
			if (id_identify_Landroid_os_IBinder_Ljava_lang_String_ == IntPtr.Zero)
				id_identify_Landroid_os_IBinder_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "identify", "(Landroid/os/IBinder;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_identify_Landroid_os_IBinder_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_notifyAppActivityState_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetNotifyAppActivityState_ILandroid_os_Bundle_Handler ()
		{
			if (cb_notifyAppActivityState_ILandroid_os_Bundle_ == null)
				cb_notifyAppActivityState_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_NotifyAppActivityState_ILandroid_os_Bundle_);
			return cb_notifyAppActivityState_ILandroid_os_Bundle_;
		}

		static void n_NotifyAppActivityState_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.NotifyAppActivityState (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_notifyAppActivityState_ILandroid_os_Bundle_;
		public unsafe void NotifyAppActivityState (int p0, global::Android.OS.Bundle p1)
		{
			if (id_notifyAppActivityState_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_notifyAppActivityState_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "notifyAppActivityState", "(ILandroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyAppActivityState_ILandroid_os_Bundle_, __args);
		}

		static Delegate cb_notifyEnrollEnd;
#pragma warning disable 0169
		static Delegate GetNotifyEnrollEndHandler ()
		{
			if (cb_notifyEnrollEnd == null)
				cb_notifyEnrollEnd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_NotifyEnrollEnd);
			return cb_notifyEnrollEnd;
		}

		static bool n_NotifyEnrollEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotifyEnrollEnd ();
		}
#pragma warning restore 0169

		IntPtr id_notifyEnrollEnd;
		public unsafe bool NotifyEnrollEnd ()
		{
			if (id_notifyEnrollEnd == IntPtr.Zero)
				id_notifyEnrollEnd = JNIEnv.GetMethodID (class_ref, "notifyEnrollEnd", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_notifyEnrollEnd);
		}

		static Delegate cb_unregisterClient_Landroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetUnregisterClient_Landroid_os_IBinder_Handler ()
		{
			if (cb_unregisterClient_Landroid_os_IBinder_ == null)
				cb_unregisterClient_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UnregisterClient_Landroid_os_IBinder_);
			return cb_unregisterClient_Landroid_os_IBinder_;
		}

		static bool n_UnregisterClient_Landroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy __this = global::Java.Lang.Object.GetObject<global::Com.Samsung.Android.Sdk.Pass.Support.IFingerprintManagerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IBinder p0 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UnregisterClient (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_unregisterClient_Landroid_os_IBinder_;
		public unsafe bool UnregisterClient (global::Android.OS.IBinder p0)
		{
			if (id_unregisterClient_Landroid_os_IBinder_ == IntPtr.Zero)
				id_unregisterClient_Landroid_os_IBinder_ = JNIEnv.GetMethodID (class_ref, "unregisterClient", "(Landroid/os/IBinder;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_unregisterClient_Landroid_os_IBinder_, __args);
			return __ret;
		}

	}

}
