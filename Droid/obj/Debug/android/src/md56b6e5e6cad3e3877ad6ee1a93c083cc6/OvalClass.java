package md56b6e5e6cad3e3877ad6ee1a93c083cc6;


public class OvalClass
	extends android.graphics.drawable.shapes.OvalShape
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("LoginNavigation.OvalClass, LoginNavigation, Version=1.0.6038.29967, Culture=neutral, PublicKeyToken=null", OvalClass.class, __md_methods);
	}


	public OvalClass () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OvalClass.class)
			mono.android.TypeManager.Activate ("LoginNavigation.OvalClass, LoginNavigation, Version=1.0.6038.29967, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	java.util.ArrayList refList;
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