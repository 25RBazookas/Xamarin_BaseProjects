package md56a4fe4d71330587f42be99c8d6ef92b8;


public class Fragment_GoogleTagManager_MyResultCallback_1
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
		mono.android.Runtime.register ("Bazookas.Fragments.Fragment_GoogleTagManager+MyResultCallback`1, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Fragment_GoogleTagManager_MyResultCallback_1.class, __md_methods);
	}


	public Fragment_GoogleTagManager_MyResultCallback_1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Fragment_GoogleTagManager_MyResultCallback_1.class)
			mono.android.TypeManager.Activate ("Bazookas.Fragments.Fragment_GoogleTagManager+MyResultCallback`1, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public Fragment_GoogleTagManager_MyResultCallback_1 (android.app.Activity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == Fragment_GoogleTagManager_MyResultCallback_1.class)
			mono.android.TypeManager.Activate ("Bazookas.Fragments.Fragment_GoogleTagManager+MyResultCallback`1, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.Activity, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
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
