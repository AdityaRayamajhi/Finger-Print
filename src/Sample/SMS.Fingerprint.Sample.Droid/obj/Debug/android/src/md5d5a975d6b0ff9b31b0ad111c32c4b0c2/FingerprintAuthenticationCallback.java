package md5d5a975d6b0ff9b31b0ad111c32c4b0c2;


public class FingerprintAuthenticationCallback
	extends android.hardware.fingerprint.FingerprintManager.AuthenticationCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAuthenticationSucceeded:(Landroid/hardware/fingerprint/FingerprintManager$AuthenticationResult;)V:GetOnAuthenticationSucceeded_Landroid_hardware_fingerprint_FingerprintManager_AuthenticationResult_Handler\n" +
			"n_onAuthenticationError:(ILjava/lang/CharSequence;)V:GetOnAuthenticationError_ILjava_lang_CharSequence_Handler\n" +
			"n_onAuthenticationFailed:()V:GetOnAuthenticationFailedHandler\n" +
			"n_onAuthenticationHelp:(ILjava/lang/CharSequence;)V:GetOnAuthenticationHelp_ILjava_lang_CharSequence_Handler\n" +
			"";
		mono.android.Runtime.register ("Plugin.Fingerprint.Standard.FingerprintAuthenticationCallback, Plugin.Fingerprint", FingerprintAuthenticationCallback.class, __md_methods);
	}


	public FingerprintAuthenticationCallback ()
	{
		super ();
		if (getClass () == FingerprintAuthenticationCallback.class)
			mono.android.TypeManager.Activate ("Plugin.Fingerprint.Standard.FingerprintAuthenticationCallback, Plugin.Fingerprint", "", this, new java.lang.Object[] {  });
	}


	public void onAuthenticationSucceeded (android.hardware.fingerprint.FingerprintManager.AuthenticationResult p0)
	{
		n_onAuthenticationSucceeded (p0);
	}

	private native void n_onAuthenticationSucceeded (android.hardware.fingerprint.FingerprintManager.AuthenticationResult p0);


	public void onAuthenticationError (int p0, java.lang.CharSequence p1)
	{
		n_onAuthenticationError (p0, p1);
	}

	private native void n_onAuthenticationError (int p0, java.lang.CharSequence p1);


	public void onAuthenticationFailed ()
	{
		n_onAuthenticationFailed ();
	}

	private native void n_onAuthenticationFailed ();


	public void onAuthenticationHelp (int p0, java.lang.CharSequence p1)
	{
		n_onAuthenticationHelp (p0, p1);
	}

	private native void n_onAuthenticationHelp (int p0, java.lang.CharSequence p1);

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
