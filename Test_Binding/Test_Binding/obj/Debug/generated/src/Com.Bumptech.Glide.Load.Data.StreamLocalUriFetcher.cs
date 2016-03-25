using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='StreamLocalUriFetcher']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/data/StreamLocalUriFetcher", DoNotGenerateAcw=true)]
	public partial class StreamLocalUriFetcher : global::Com.Bumptech.Glide.Load.Data.LocalUriFetcher {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/data/StreamLocalUriFetcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StreamLocalUriFetcher); }
		}

		protected StreamLocalUriFetcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='StreamLocalUriFetcher']/constructor[@name='StreamLocalUriFetcher' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/net/Uri;)V", "")]
		public unsafe StreamLocalUriFetcher (global::Android.Content.Context p0, global::Android.Net.Uri p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (StreamLocalUriFetcher)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/net/Uri;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/net/Uri;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/net/Uri;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_net_Uri_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_net_Uri_, __args);
			} finally {
			}
		}

		static Delegate cb_close_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetClose_Ljava_io_InputStream_Handler ()
		{
			if (cb_close_Ljava_io_InputStream_ == null)
				cb_close_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Close_Ljava_io_InputStream_);
			return cb_close_Ljava_io_InputStream_;
		}

		static void n_Close_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Data.StreamLocalUriFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.StreamLocalUriFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Close (p0);
		}
#pragma warning restore 0169

		static IntPtr id_close_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='StreamLocalUriFetcher']/method[@name='close' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("close", "(Ljava/io/InputStream;)V", "GetClose_Ljava_io_InputStream_Handler")]
		protected virtual unsafe void Close (global::System.IO.Stream p0)
		{
			if (id_close_Ljava_io_InputStream_ == IntPtr.Zero)
				id_close_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "close", "(Ljava/io/InputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close_Ljava_io_InputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "(Ljava/io/InputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_;
#pragma warning disable 0169
		static Delegate GetLoadResource_Landroid_net_Uri_Landroid_content_ContentResolver_Handler ()
		{
			if (cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ == null)
				cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadResource_Landroid_net_Uri_Landroid_content_ContentResolver_);
			return cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_;
		}

		static IntPtr n_LoadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Load.Data.StreamLocalUriFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.StreamLocalUriFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentResolver p1 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentResolver> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.LoadResource (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='StreamLocalUriFetcher']/method[@name='loadResource' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.content.ContentResolver']]"
		[Register ("loadResource", "(Landroid/net/Uri;Landroid/content/ContentResolver;)Ljava/io/InputStream;", "GetLoadResource_Landroid_net_Uri_Landroid_content_ContentResolver_Handler")]
		protected virtual unsafe global::System.IO.Stream LoadResource (global::Android.Net.Uri p0, global::Android.Content.ContentResolver p1)
		{
			if (id_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ == IntPtr.Zero)
				id_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ = JNIEnv.GetMethodID (class_ref, "loadResource", "(Landroid/net/Uri;Landroid/content/ContentResolver;)Ljava/io/InputStream;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadResource", "(Landroid/net/Uri;Landroid/content/ContentResolver;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
