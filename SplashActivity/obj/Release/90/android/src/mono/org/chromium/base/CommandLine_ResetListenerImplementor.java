package mono.org.chromium.base;


public class CommandLine_ResetListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.chromium.base.CommandLine.ResetListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCommandLineReset:()V:GetOnCommandLineResetHandler:Org.Chromium.Base.CommandLine/IResetListenerInvoker, XWalk.Binding\n" +
			"";
		mono.android.Runtime.register ("Org.Chromium.Base.CommandLine+IResetListenerImplementor, XWalk.Binding", CommandLine_ResetListenerImplementor.class, __md_methods);
	}


	public CommandLine_ResetListenerImplementor ()
	{
		super ();
		if (getClass () == CommandLine_ResetListenerImplementor.class)
			mono.android.TypeManager.Activate ("Org.Chromium.Base.CommandLine+IResetListenerImplementor, XWalk.Binding", "", this, new java.lang.Object[] {  });
	}


	public void onCommandLineReset ()
	{
		n_onCommandLineReset ();
	}

	private native void n_onCommandLineReset ();

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
