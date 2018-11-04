package md5592023667f3dc7d4afc1d5324b2a7900;


public class MyCustomDialogFragment
	extends md5f842b5ac8eb52ac6d95c95091b13caff.FingerprintDialogFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("SMS.Fingerprint.Sample.Droid.MyCustomDialogFragment, SMS.Fingerprint.Sample.Droid", MyCustomDialogFragment.class, __md_methods);
	}


	public MyCustomDialogFragment ()
	{
		super ();
		if (getClass () == MyCustomDialogFragment.class)
			mono.android.TypeManager.Activate ("SMS.Fingerprint.Sample.Droid.MyCustomDialogFragment, SMS.Fingerprint.Sample.Droid", "", this, new java.lang.Object[] {  });
	}


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);

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
