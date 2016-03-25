using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='LocalUriFetcher']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/data/LocalUriFetcher", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class LocalUriFetcher : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Data.IDataFetcher {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/data/LocalUriFetcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocalUriFetcher); }
		}

		protected LocalUriFetcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='LocalUriFetcher']/constructor[@name='LocalUriFetcher' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/net/Uri;)V", "")]
		public unsafe LocalUriFetcher (global::Android.Content.Context p0, global::Android.Net.Uri p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (LocalUriFetcher)) {
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

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Data.LocalUriFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.LocalUriFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='LocalUriFetcher']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Data.LocalUriFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.LocalUriFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='LocalUriFetcher']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cancel);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
			} finally {
			}
		}

		static Delegate cb_cleanup;
#pragma warning disable 0169
		static Delegate GetCleanupHandler ()
		{
			if (cb_cleanup == null)
				cb_cleanup = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cleanup);
			return cb_cleanup;
		}

		static void n_Cleanup (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Data.LocalUriFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.LocalUriFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cleanup ();
		}
#pragma warning restore 0169

		static IntPtr id_cleanup;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='LocalUriFetcher']/method[@name='cleanup' and count(parameter)=0]"
		[Register ("cleanup", "()V", "GetCleanupHandler")]
		public virtual unsafe void Cleanup ()
		{
			if (id_cleanup == IntPtr.Zero)
				id_cleanup = JNIEnv.GetMethodID (class_ref, "cleanup", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cleanup);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cleanup", "()V"));
			} finally {
			}
		}

		static Delegate cb_close_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetClose_Ljava_lang_Object_Handler ()
		{
			if (cb_close_Ljava_lang_Object_ == null)
				cb_close_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Close_Ljava_lang_Object_);
			return cb_close_Ljava_lang_Object_;
		}

		static void n_Close_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Data.LocalUriFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.LocalUriFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Close (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='LocalUriFetcher']/method[@name='close' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("close", "(Ljava/lang/Object;)V", "GetClose_Ljava_lang_Object_Handler")]
		protected abstract void Close (global::Java.Lang.Object p0);

		static IntPtr id_loadData_Lcom_bumptech_glide_Priority_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='LocalUriFetcher']/method[@name='loadData' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.Priority']]"
		[Register ("loadData", "(Lcom/bumptech/glide/Priority;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object LoadData (global::Com.Bumptech.Glide.Priority p0)
		{
			if (id_loadData_Lcom_bumptech_glide_Priority_ == IntPtr.Zero)
				id_loadData_Lcom_bumptech_glide_Priority_ = JNIEnv.GetMethodID (class_ref, "loadData", "(Lcom/bumptech/glide/Priority;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_loadData_Lcom_bumptech_glide_Priority_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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
			global::Com.Bumptech.Glide.Load.Data.LocalUriFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.LocalUriFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentResolver p1 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentResolver> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadResource (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='LocalUriFetcher']/method[@name='loadResource' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.content.ContentResolver']]"
		[Register ("loadResource", "(Landroid/net/Uri;Landroid/content/ContentResolver;)Ljava/lang/Object;", "GetLoadResource_Landroid_net_Uri_Landroid_content_ContentResolver_Handler")]
		protected abstract global::Java.Lang.Object LoadResource (global::Android.Net.Uri p0, global::Android.Content.ContentResolver p1);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/data/LocalUriFetcher", DoNotGenerateAcw=true)]
	internal partial class LocalUriFetcherInvoker : LocalUriFetcher, global::Com.Bumptech.Glide.Load.Data.IDataFetcher {

		public LocalUriFetcherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocalUriFetcherInvoker); }
		}

		static IntPtr id_close_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='LocalUriFetcher']/method[@name='close' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("close", "(Ljava/lang/Object;)V", "GetClose_Ljava_lang_Object_Handler")]
		protected override unsafe void Close (global::Java.Lang.Object p0)
		{
			if (id_close_Ljava_lang_Object_ == IntPtr.Zero)
				id_close_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "close", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_close_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='LocalUriFetcher']/method[@name='loadResource' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.content.ContentResolver']]"
		[Register ("loadResource", "(Landroid/net/Uri;Landroid/content/ContentResolver;)Ljava/lang/Object;", "GetLoadResource_Landroid_net_Uri_Landroid_content_ContentResolver_Handler")]
		protected override unsafe global::Java.Lang.Object LoadResource (global::Android.Net.Uri p0, global::Android.Content.ContentResolver p1)
		{
			if (id_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ == IntPtr.Zero)
				id_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ = JNIEnv.GetMethodID (class_ref, "loadResource", "(Landroid/net/Uri;Landroid/content/ContentResolver;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
