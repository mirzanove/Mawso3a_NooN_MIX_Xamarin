package mono.org.chromium.content.browser;


public class PositionObserver_ListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.chromium.content.browser.PositionObserver.Listener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPositionChanged:(II)V:GetOnPositionChanged_IIHandler:Org.Chromium.Content.Browser.IPositionObserverListenerInvoker, XWalk.Binding\n" +
			"";
		mono.android.Runtime.register ("Org.Chromium.Content.Browser.IPositionObserverListenerImplementor, XWalk.Binding", PositionObserver_ListenerImplementor.class, __md_methods);
	}


	public PositionObserver_ListenerImplementor ()
	{
		super ();
		if (getClass () == PositionObserver_ListenerImplementor.class)
			mono.android.TypeManager.Activate ("Org.Chromium.Content.Browser.IPositionObserverListenerImplementor, XWalk.Binding", "", this, new java.lang.Object[] {  });
	}


	public void onPositionChanged (int p0, int p1)
	{
		n_onPositionChanged (p0, p1);
	}

	private native void n_onPositionChanged (int p0, int p1);

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
