package md52842779aef36a255d3f5d53dff9cb2df;


public class RecyclerViewHolder_Image
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Bazookas.RecyclerViewHolder.RecyclerViewHolder_Image, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RecyclerViewHolder_Image.class, __md_methods);
	}


	public RecyclerViewHolder_Image (android.view.View p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == RecyclerViewHolder_Image.class)
			mono.android.TypeManager.Activate ("Bazookas.RecyclerViewHolder.RecyclerViewHolder_Image, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
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
