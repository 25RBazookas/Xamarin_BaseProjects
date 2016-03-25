using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Manager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerRetriever']"
	[global::Android.Runtime.Register ("com/bumptech/glide/manager/RequestManagerRetriever", DoNotGenerateAcw=true)]
	public partial class RequestManagerRetriever : global::Java.Lang.Object, global::Android.OS.Handler.ICallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/manager/RequestManagerRetriever", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestManagerRetriever); }
		}

		protected RequestManagerRetriever (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerRetriever']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/bumptech/glide/manager/RequestManagerRetriever;", "")]
		public static unsafe global::Com.Bumptech.Glide.Manager.RequestManagerRetriever Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetStaticMethodID (class_ref, "get", "()Lcom/bumptech/glide/manager/RequestManagerRetriever;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestManagerRetriever> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetGet_Landroid_app_Activity_Handler ()
		{
			if (cb_get_Landroid_app_Activity_ == null)
				cb_get_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Landroid_app_Activity_);
			return cb_get_Landroid_app_Activity_;
		}

		static IntPtr n_Get_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Manager.RequestManagerRetriever __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestManagerRetriever> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerRetriever']/method[@name='get' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("get", "(Landroid/app/Activity;)Lcom/bumptech/glide/RequestManager;", "GetGet_Landroid_app_Activity_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.RequestManager Get (global::Android.App.Activity p0)
		{
			if (id_get_Landroid_app_Activity_ == IntPtr.Zero)
				id_get_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "get", "(Landroid/app/Activity;)Lcom/bumptech/glide/RequestManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.RequestManager __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallObjectMethod  (Handle, id_get_Landroid_app_Activity_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Landroid/app/Activity;)Lcom/bumptech/glide/RequestManager;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_get_Landroid_app_Fragment_;
#pragma warning disable 0169
		static Delegate GetGet_Landroid_app_Fragment_Handler ()
		{
			if (cb_get_Landroid_app_Fragment_ == null)
				cb_get_Landroid_app_Fragment_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Landroid_app_Fragment_);
			return cb_get_Landroid_app_Fragment_;
		}

		static IntPtr n_Get_Landroid_app_Fragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Manager.RequestManagerRetriever __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestManagerRetriever> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Fragment p0 = global::Java.Lang.Object.GetObject<global::Android.App.Fragment> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Landroid_app_Fragment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerRetriever']/method[@name='get' and count(parameter)=1 and parameter[1][@type='android.app.Fragment']]"
		[Register ("get", "(Landroid/app/Fragment;)Lcom/bumptech/glide/RequestManager;", "GetGet_Landroid_app_Fragment_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.RequestManager Get (global::Android.App.Fragment p0)
		{
			if (id_get_Landroid_app_Fragment_ == IntPtr.Zero)
				id_get_Landroid_app_Fragment_ = JNIEnv.GetMethodID (class_ref, "get", "(Landroid/app/Fragment;)Lcom/bumptech/glide/RequestManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.RequestManager __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallObjectMethod  (Handle, id_get_Landroid_app_Fragment_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Landroid/app/Fragment;)Lcom/bumptech/glide/RequestManager;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_get_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGet_Landroid_content_Context_Handler ()
		{
			if (cb_get_Landroid_content_Context_ == null)
				cb_get_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Landroid_content_Context_);
			return cb_get_Landroid_content_Context_;
		}

		static IntPtr n_Get_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Manager.RequestManagerRetriever __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestManagerRetriever> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerRetriever']/method[@name='get' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("get", "(Landroid/content/Context;)Lcom/bumptech/glide/RequestManager;", "GetGet_Landroid_content_Context_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.RequestManager Get (global::Android.Content.Context p0)
		{
			if (id_get_Landroid_content_Context_ == IntPtr.Zero)
				id_get_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "get", "(Landroid/content/Context;)Lcom/bumptech/glide/RequestManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.RequestManager __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallObjectMethod  (Handle, id_get_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Landroid/content/Context;)Lcom/bumptech/glide/RequestManager;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_get_Landroid_support_v4_app_Fragment_;
#pragma warning disable 0169
		static Delegate GetGet_Landroid_support_v4_app_Fragment_Handler ()
		{
			if (cb_get_Landroid_support_v4_app_Fragment_ == null)
				cb_get_Landroid_support_v4_app_Fragment_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Landroid_support_v4_app_Fragment_);
			return cb_get_Landroid_support_v4_app_Fragment_;
		}

		static IntPtr n_Get_Landroid_support_v4_app_Fragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Manager.RequestManagerRetriever __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestManagerRetriever> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.Fragment p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Landroid_support_v4_app_Fragment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerRetriever']/method[@name='get' and count(parameter)=1 and parameter[1][@type='android.support.v4.app.Fragment']]"
		[Register ("get", "(Landroid/support/v4/app/Fragment;)Lcom/bumptech/glide/RequestManager;", "GetGet_Landroid_support_v4_app_Fragment_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.RequestManager Get (global::Android.Support.V4.App.Fragment p0)
		{
			if (id_get_Landroid_support_v4_app_Fragment_ == IntPtr.Zero)
				id_get_Landroid_support_v4_app_Fragment_ = JNIEnv.GetMethodID (class_ref, "get", "(Landroid/support/v4/app/Fragment;)Lcom/bumptech/glide/RequestManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.RequestManager __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallObjectMethod  (Handle, id_get_Landroid_support_v4_app_Fragment_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Landroid/support/v4/app/Fragment;)Lcom/bumptech/glide/RequestManager;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_get_Landroid_support_v4_app_FragmentActivity_;
#pragma warning disable 0169
		static Delegate GetGet_Landroid_support_v4_app_FragmentActivity_Handler ()
		{
			if (cb_get_Landroid_support_v4_app_FragmentActivity_ == null)
				cb_get_Landroid_support_v4_app_FragmentActivity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Landroid_support_v4_app_FragmentActivity_);
			return cb_get_Landroid_support_v4_app_FragmentActivity_;
		}

		static IntPtr n_Get_Landroid_support_v4_app_FragmentActivity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Manager.RequestManagerRetriever __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestManagerRetriever> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.FragmentActivity p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentActivity> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Landroid_support_v4_app_FragmentActivity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerRetriever']/method[@name='get' and count(parameter)=1 and parameter[1][@type='android.support.v4.app.FragmentActivity']]"
		[Register ("get", "(Landroid/support/v4/app/FragmentActivity;)Lcom/bumptech/glide/RequestManager;", "GetGet_Landroid_support_v4_app_FragmentActivity_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.RequestManager Get (global::Android.Support.V4.App.FragmentActivity p0)
		{
			if (id_get_Landroid_support_v4_app_FragmentActivity_ == IntPtr.Zero)
				id_get_Landroid_support_v4_app_FragmentActivity_ = JNIEnv.GetMethodID (class_ref, "get", "(Landroid/support/v4/app/FragmentActivity;)Lcom/bumptech/glide/RequestManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.RequestManager __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallObjectMethod  (Handle, id_get_Landroid_support_v4_app_FragmentActivity_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Landroid/support/v4/app/FragmentActivity;)Lcom/bumptech/glide/RequestManager;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_handleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_handleMessage_Landroid_os_Message_ == null)
				cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HandleMessage_Landroid_os_Message_);
			return cb_handleMessage_Landroid_os_Message_;
		}

		static bool n_HandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Manager.RequestManagerRetriever __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestManagerRetriever> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleMessage_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerRetriever']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe bool HandleMessage (global::Android.OS.Message p0)
		{
			if (id_handleMessage_Landroid_os_Message_ == IntPtr.Zero)
				id_handleMessage_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Landroid/os/Message;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_handleMessage_Landroid_os_Message_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleMessage", "(Landroid/os/Message;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
