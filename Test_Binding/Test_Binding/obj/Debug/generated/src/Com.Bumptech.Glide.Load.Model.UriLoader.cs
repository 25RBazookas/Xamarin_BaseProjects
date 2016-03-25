using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='UriLoader']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/UriLoader", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class UriLoader : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Model.IModelLoader {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/model/UriLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UriLoader); }
		}

		protected UriLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_model_ModelLoader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='UriLoader']/constructor[@name='UriLoader' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.bumptech.glide.load.model.ModelLoader&lt;com.bumptech.glide.load.model.GlideUrl, T&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/bumptech/glide/load/model/ModelLoader;)V", "")]
		public unsafe UriLoader (global::Android.Content.Context p0, global::Com.Bumptech.Glide.Load.Model.IModelLoader p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (UriLoader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/bumptech/glide/load/model/ModelLoader;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/bumptech/glide/load/model/ModelLoader;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_model_ModelLoader_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_model_ModelLoader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/bumptech/glide/load/model/ModelLoader;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_model_ModelLoader_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_model_ModelLoader_, __args);
			} finally {
			}
		}

		static Delegate cb_getAssetPathFetcher_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAssetPathFetcher_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_getAssetPathFetcher_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_getAssetPathFetcher_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAssetPathFetcher_Landroid_content_Context_Ljava_lang_String_);
			return cb_getAssetPathFetcher_Landroid_content_Context_Ljava_lang_String_;
		}

		static IntPtr n_GetAssetPathFetcher_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Load.Model.UriLoader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.UriLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAssetPathFetcher (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='UriLoader']/method[@name='getAssetPathFetcher' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAssetPathFetcher", "(Landroid/content/Context;Ljava/lang/String;)Lcom/bumptech/glide/load/data/DataFetcher;", "GetGetAssetPathFetcher_Landroid_content_Context_Ljava_lang_String_Handler")]
		protected abstract global::Com.Bumptech.Glide.Load.Data.IDataFetcher GetAssetPathFetcher (global::Android.Content.Context p0, string p1);

		static Delegate cb_getLocalUriFetcher_Landroid_content_Context_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGetLocalUriFetcher_Landroid_content_Context_Landroid_net_Uri_Handler ()
		{
			if (cb_getLocalUriFetcher_Landroid_content_Context_Landroid_net_Uri_ == null)
				cb_getLocalUriFetcher_Landroid_content_Context_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLocalUriFetcher_Landroid_content_Context_Landroid_net_Uri_);
			return cb_getLocalUriFetcher_Landroid_content_Context_Landroid_net_Uri_;
		}

		static IntPtr n_GetLocalUriFetcher_Landroid_content_Context_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Load.Model.UriLoader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.UriLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLocalUriFetcher (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='UriLoader']/method[@name='getLocalUriFetcher' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("getLocalUriFetcher", "(Landroid/content/Context;Landroid/net/Uri;)Lcom/bumptech/glide/load/data/DataFetcher;", "GetGetLocalUriFetcher_Landroid_content_Context_Landroid_net_Uri_Handler")]
		protected abstract global::Com.Bumptech.Glide.Load.Data.IDataFetcher GetLocalUriFetcher (global::Android.Content.Context p0, global::Android.Net.Uri p1);

		static IntPtr id_getResourceFetcher_Landroid_net_Uri_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='UriLoader']/method[@name='getResourceFetcher' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getResourceFetcher", "(Landroid/net/Uri;II)Lcom/bumptech/glide/load/data/DataFetcher;", "")]
		public unsafe global::Com.Bumptech.Glide.Load.Data.IDataFetcher GetResourceFetcher (global::Android.Net.Uri p0, int p1, int p2)
		{
			if (id_getResourceFetcher_Landroid_net_Uri_II == IntPtr.Zero)
				id_getResourceFetcher_Landroid_net_Uri_II = JNIEnv.GetMethodID (class_ref, "getResourceFetcher", "(Landroid/net/Uri;II)Lcom/bumptech/glide/load/data/DataFetcher;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Bumptech.Glide.Load.Data.IDataFetcher __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (JNIEnv.CallObjectMethod  (Handle, id_getResourceFetcher_Landroid_net_Uri_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/UriLoader", DoNotGenerateAcw=true)]
	internal partial class UriLoaderInvoker : UriLoader, global::Com.Bumptech.Glide.Load.Model.IModelLoader {

		public UriLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UriLoaderInvoker); }
		}

		static IntPtr id_getAssetPathFetcher_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='UriLoader']/method[@name='getAssetPathFetcher' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAssetPathFetcher", "(Landroid/content/Context;Ljava/lang/String;)Lcom/bumptech/glide/load/data/DataFetcher;", "GetGetAssetPathFetcher_Landroid_content_Context_Ljava_lang_String_Handler")]
		protected override unsafe global::Com.Bumptech.Glide.Load.Data.IDataFetcher GetAssetPathFetcher (global::Android.Content.Context p0, string p1)
		{
			if (id_getAssetPathFetcher_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getAssetPathFetcher_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAssetPathFetcher", "(Landroid/content/Context;Ljava/lang/String;)Lcom/bumptech/glide/load/data/DataFetcher;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Bumptech.Glide.Load.Data.IDataFetcher __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (JNIEnv.CallObjectMethod  (Handle, id_getAssetPathFetcher_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getLocalUriFetcher_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='UriLoader']/method[@name='getLocalUriFetcher' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("getLocalUriFetcher", "(Landroid/content/Context;Landroid/net/Uri;)Lcom/bumptech/glide/load/data/DataFetcher;", "GetGetLocalUriFetcher_Landroid_content_Context_Landroid_net_Uri_Handler")]
		protected override unsafe global::Com.Bumptech.Glide.Load.Data.IDataFetcher GetLocalUriFetcher (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_getLocalUriFetcher_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_getLocalUriFetcher_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getLocalUriFetcher", "(Landroid/content/Context;Landroid/net/Uri;)Lcom/bumptech/glide/load/data/DataFetcher;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Bumptech.Glide.Load.Data.IDataFetcher __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (JNIEnv.CallObjectMethod  (Handle, id_getLocalUriFetcher_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
