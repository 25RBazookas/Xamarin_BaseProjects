package md5520a8c1b94c2387410e695a53b05768d;


public class MessageHandler
	extends android.os.Handler
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_handleMessage:(Landroid/os/Message;)V:GetHandleMessage_Landroid_os_Message_Handler\n" +
			"";
		mono.android.Runtime.register ("Test_ImageLoading.MessageHandler, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MessageHandler.class, __md_methods);
	}


	public MessageHandler () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MessageHandler.class)
			mono.android.TypeManager.Activate ("Test_ImageLoading.MessageHandler, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public MessageHandler (android.os.Handler.Callback p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == MessageHandler.class)
			mono.android.TypeManager.Activate ("Test_ImageLoading.MessageHandler, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.OS.Handler+ICallback, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public MessageHandler (android.os.Looper p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == MessageHandler.class)
			mono.android.TypeManager.Activate ("Test_ImageLoading.MessageHandler, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.OS.Looper, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public MessageHandler (android.os.Looper p0, android.os.Handler.Callback p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == MessageHandler.class)
			mono.android.TypeManager.Activate ("Test_ImageLoading.MessageHandler, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.OS.Looper, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.OS.Handler+ICallback, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}

	public MessageHandler (md5520a8c1b94c2387410e695a53b05768d.View_VideoController p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == MessageHandler.class)
			mono.android.TypeManager.Activate ("Test_ImageLoading.MessageHandler, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Test_ImageLoading.View_VideoController, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void handleMessage (android.os.Message p0)
	{
		n_handleMessage (p0);
	}

	private native void n_handleMessage (android.os.Message p0);

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
