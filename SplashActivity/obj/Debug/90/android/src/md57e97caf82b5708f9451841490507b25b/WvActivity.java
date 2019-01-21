package md57e97caf82b5708f9451841490507b25b;


public class WvActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("com.xamarin.sample.splashscreen.WvActivity, SplashScreen", WvActivity.class, __md_methods);
	}


	public WvActivity ()
	{
		super ();
		if (getClass () == WvActivity.class)
			mono.android.TypeManager.Activate ("com.xamarin.sample.splashscreen.WvActivity, SplashScreen", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
