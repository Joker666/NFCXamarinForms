package egg.appearance.droid;


public class ManageNfcTag
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Egg.appearance.Droid.ManageNfcTag, Egg.appearance.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ManageNfcTag.class, __md_methods);
	}


	public ManageNfcTag () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ManageNfcTag.class)
			mono.android.TypeManager.Activate ("Egg.appearance.Droid.ManageNfcTag, Egg.appearance.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
