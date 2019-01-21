package mono.org.chromium.content.browser;


public class ContentViewCore_SmartClipDataListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.chromium.content.browser.ContentViewCore.SmartClipDataListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSmartClipDataExtracted:(Ljava/lang/String;Ljava/lang/String;Landroid/graphics/Rect;)V:GetOnSmartClipDataExtracted_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_Rect_Handler:Org.Chromium.Content.Browser.ContentViewCore/ISmartClipDataListenerInvoker, XWalk.Binding\n" +
			"";
		mono.android.Runtime.register ("Org.Chromium.Content.Browser.ContentViewCore+ISmartClipDataListenerImplementor, XWalk.Binding", ContentViewCore_SmartClipDataListenerImplementor.class, __md_methods);
	}


	public ContentViewCore_SmartClipDataListenerImplementor ()
	{
		super ();
		if (getClass () == ContentViewCore_SmartClipDataListenerImplementor.class)
			mono.android.TypeManager.Activate ("Org.Chromium.Content.Browser.ContentViewCore+ISmartClipDataListenerImplementor, XWalk.Binding", "", this, new java.lang.Object[] {  });
	}


	public void onSmartClipDataExtracted (java.lang.String p0, java.lang.String p1, android.graphics.Rect p2)
	{
		n_onSmartClipDataExtracted (p0, p1, p2);
	}

	private native void n_onSmartClipDataExtracted (java.lang.String p0, java.lang.String p1, android.graphics.Rect p2);

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
