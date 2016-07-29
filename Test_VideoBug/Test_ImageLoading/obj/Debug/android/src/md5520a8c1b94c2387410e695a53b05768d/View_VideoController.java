package md5520a8c1b94c2387410e695a53b05768d;


public class View_VideoController
	extends android.widget.FrameLayout
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_isEnabled:()Z:GetIsEnabledHandler\n" +
			"n_setEnabled:(Z)V:GetSetEnabled_ZHandler\n" +
			"n_onFinishInflate:()V:GetOnFinishInflateHandler\n" +
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_onTrackballEvent:(Landroid/view/MotionEvent;)Z:GetOnTrackballEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_dispatchKeyEvent:(Landroid/view/KeyEvent;)Z:GetDispatchKeyEvent_Landroid_view_KeyEvent_Handler\n" +
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Test_ImageLoading.View_VideoController, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", View_VideoController.class, __md_methods);
	}


	public View_VideoController (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == View_VideoController.class)
			mono.android.TypeManager.Activate ("Test_ImageLoading.View_VideoController, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public View_VideoController (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == View_VideoController.class)
			mono.android.TypeManager.Activate ("Test_ImageLoading.View_VideoController, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public View_VideoController (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == View_VideoController.class)
			mono.android.TypeManager.Activate ("Test_ImageLoading.View_VideoController, Test_ImageLoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public boolean isEnabled ()
	{
		return n_isEnabled ();
	}

	private native boolean n_isEnabled ();


	public void setEnabled (boolean p0)
	{
		n_setEnabled (p0);
	}

	private native void n_setEnabled (boolean p0);


	public void onFinishInflate ()
	{
		n_onFinishInflate ();
	}

	private native void n_onFinishInflate ();


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);


	public boolean onTrackballEvent (android.view.MotionEvent p0)
	{
		return n_onTrackballEvent (p0);
	}

	private native boolean n_onTrackballEvent (android.view.MotionEvent p0);


	public boolean dispatchKeyEvent (android.view.KeyEvent p0)
	{
		return n_dispatchKeyEvent (p0);
	}

	private native boolean n_dispatchKeyEvent (android.view.KeyEvent p0);


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

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
