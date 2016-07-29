package md56a4fe4d71330587f42be99c8d6ef92b8;


public class Fragment_ImageLoading_Normal
	extends android.support.v4.app.Fragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Bazookas.Fragments.Fragment_ImageLoading_Normal, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Fragment_ImageLoading_Normal.class, __md_methods);
	}


	public Fragment_ImageLoading_Normal () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Fragment_ImageLoading_Normal.class)
			mono.android.TypeManager.Activate ("Bazookas.Fragments.Fragment_ImageLoading_Normal, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public Fragment_ImageLoading_Normal (android.support.v4.app.FragmentManager p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == Fragment_ImageLoading_Normal.class)
			mono.android.TypeManager.Activate ("Bazookas.Fragments.Fragment_ImageLoading_Normal, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Support.V4.App.FragmentManager, Xamarin.Android.Support.v4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


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
