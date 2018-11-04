package mono.com.samsung.android.sdk.pass;


public class SpassFingerprint_RegisterListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.samsung.android.sdk.pass.SpassFingerprint.RegisterListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFinished:()V:GetOnFinishedHandler:Com.Samsung.Android.Sdk.Pass.SpassFingerprint/IRegisterListenerInvoker, Plugin.Fingerprint.Android.Samsung\n" +
			"";
		mono.android.Runtime.register ("Com.Samsung.Android.Sdk.Pass.SpassFingerprint+IRegisterListenerImplementor, Plugin.Fingerprint.Android.Samsung", SpassFingerprint_RegisterListenerImplementor.class, __md_methods);
	}


	public SpassFingerprint_RegisterListenerImplementor ()
	{
		super ();
		if (getClass () == SpassFingerprint_RegisterListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Samsung.Android.Sdk.Pass.SpassFingerprint+IRegisterListenerImplementor, Plugin.Fingerprint.Android.Samsung", "", this, new java.lang.Object[] {  });
	}


	public void onFinished ()
	{
		n_onFinished ();
	}

	private native void n_onFinished ();

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
