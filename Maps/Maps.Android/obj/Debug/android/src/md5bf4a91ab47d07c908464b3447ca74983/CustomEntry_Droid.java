package md5bf4a91ab47d07c908464b3447ca74983;


public class CustomEntry_Droid
	extends md51558244f76c53b6aeda52c8a337f2c37.EntryRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Maps.Droid.CustomEntry_Droid, Maps.Android", CustomEntry_Droid.class, __md_methods);
	}


	public CustomEntry_Droid (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomEntry_Droid.class)
			mono.android.TypeManager.Activate ("Maps.Droid.CustomEntry_Droid, Maps.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CustomEntry_Droid (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CustomEntry_Droid.class)
			mono.android.TypeManager.Activate ("Maps.Droid.CustomEntry_Droid, Maps.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CustomEntry_Droid (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomEntry_Droid.class)
			mono.android.TypeManager.Activate ("Maps.Droid.CustomEntry_Droid, Maps.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
