package md503d41ee802d1e786a421c73ca833a2f7;


public class App
	extends mono.android.app.Application
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:()V:GetOnCreateHandler\n" +
			"n_onTerminate:()V:GetOnTerminateHandler\n" +
			"";
	}


	public App () throws java.lang.Throwable
	{
		super ();
	}

	public void onCreate ()
	{
		mono.android.Runtime.register ("Bazookas.App, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", App.class, __md_methods);
		n_onCreate ();
	}

	private native void n_onCreate ();


	public void onTerminate ()
	{
		n_onTerminate ();
	}

	private native void n_onTerminate ();

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
