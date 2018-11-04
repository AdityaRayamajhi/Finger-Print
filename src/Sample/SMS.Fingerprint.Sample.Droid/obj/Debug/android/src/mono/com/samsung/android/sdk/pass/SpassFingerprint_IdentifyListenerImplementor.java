package mono.com.samsung.android.sdk.pass;


public class SpassFingerprint_IdentifyListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.samsung.android.sdk.pass.SpassFingerprint.IdentifyListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCompleted:()V:GetOnCompletedHandler:Com.Samsung.Android.Sdk.Pass.SpassFingerprint/IIdentifyListenerInvoker, Plugin.Fingerprint.Android.Samsung\n" +
			"n_onFinished:(I)V:GetOnFinished_IHandler:Com.Samsung.Android.Sdk.Pass.SpassFingerprint/IIdentifyListenerInvoker, Plugin.Fingerprint.Android.Samsung\n" +
			"n_onReady:()V:GetOnReadyHandler:Com.Samsung.Android.Sdk.Pass.SpassFingerprint/IIdentifyListenerInvoker, Plugin.Fingerprint.Android.Samsung\n" +
			"n_onStarted:()V:GetOnStartedHandler:Com.Samsung.Android.Sdk.Pass.SpassFingerprint/IIdentifyListenerInvoker, Plugin.Fingerprint.Android.Samsung\n" +
			"";
		mono.android.Runtime.register ("Com.Samsung.Android.Sdk.Pass.SpassFingerprint+IIdentifyListenerImplementor, Plugin.Fingerprint.Android.Samsung", SpassFingerprint_IdentifyListenerImplementor.class, __md_methods);
	}


	public SpassFingerprint_IdentifyListenerImplementor ()
	{
		super ();
		if (getClass () == SpassFingerprint_IdentifyListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Samsung.Android.Sdk.Pass.SpassFingerprint+IIdentifyListenerImplementor, Plugin.Fingerprint.Android.Samsung", "", this, new java.lang.Object[] {  });
	}


	public void onCompleted ()
	{
		n_onCompleted ();
	}

	private native void n_onCompleted ();


	public void onFinished (int p0)
	{
		n_onFinished (p0);
	}

	private native void n_onFinished (int p0);


	public void onReady ()
	{
		n_onReady ();
	}

	private native void n_onReady ();


	public void onStarted ()
	{
		n_onStarted ();
	}

	private native void n_onStarted ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
