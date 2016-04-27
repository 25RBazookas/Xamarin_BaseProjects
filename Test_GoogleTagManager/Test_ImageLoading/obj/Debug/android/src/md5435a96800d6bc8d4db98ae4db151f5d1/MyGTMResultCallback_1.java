package md5435a96800d6bc8d4db98ae4db151f5d1;


public class MyGTMResultCallback_1
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.common.api.ResultCallback
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onResult:(Lcom/google/android/gms/common/api/Result;)V:GetOnResult_Lcom_google_android_gms_common_api_Result_Handler:Android.Gms.Common.Apis.IResultCallbackInvoker, Xamarin.GooglePlayServices.Basement\n" +
			"";
		mono.android.Runtime.register ("Bazookas.MyGoogleTagManager.MyGTMResultCallback`1, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MyGTMResultCallback_1.class, __md_methods);
	}


	public MyGTMResultCallback_1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MyGTMResultCallback_1.class)
			mono.android.TypeManager.Activate ("Bazookas.MyGoogleTagManager.MyGTMResultCallback`1, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public MyGTMResultCallback_1 (android.content.Context p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == MyGTMResultCallback_1.class)
			mono.android.TypeManager.Activate ("Bazookas.MyGoogleTagManager.MyGTMResultCallback`1, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void onResult (com.google.android.gms.common.api.Result p0)
	{
		n_onResult (p0);
	}

	private native void n_onResult (com.google.android.gms.common.api.Result p0);

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
