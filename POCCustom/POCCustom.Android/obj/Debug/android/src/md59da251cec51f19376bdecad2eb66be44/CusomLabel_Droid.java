package md59da251cec51f19376bdecad2eb66be44;


public class CusomLabel_Droid
	extends md51558244f76c53b6aeda52c8a337f2c37.LabelRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("POCCustom.Droid.CusomLabel_Droid, POCCustom.Android", CusomLabel_Droid.class, __md_methods);
	}


	public CusomLabel_Droid (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CusomLabel_Droid.class)
			mono.android.TypeManager.Activate ("POCCustom.Droid.CusomLabel_Droid, POCCustom.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CusomLabel_Droid (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CusomLabel_Droid.class)
			mono.android.TypeManager.Activate ("POCCustom.Droid.CusomLabel_Droid, POCCustom.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CusomLabel_Droid (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CusomLabel_Droid.class)
			mono.android.TypeManager.Activate ("POCCustom.Droid.CusomLabel_Droid, POCCustom.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
