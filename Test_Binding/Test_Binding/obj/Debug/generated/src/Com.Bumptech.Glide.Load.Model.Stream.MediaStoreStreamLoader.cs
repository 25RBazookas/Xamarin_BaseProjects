using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='MediaStoreStreamLoader']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/stream/MediaStoreStreamLoader", DoNotGenerateAcw=true)]
	public partial class MediaStoreStreamLoader : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Model.IModelLoader {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/model/stream/MediaStoreStreamLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaStoreStreamLoader); }
		}

		protected MediaStoreStreamLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_model_ModelLoader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='MediaStoreStreamLoader']/constructor[@name='MediaStoreStreamLoader' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.bumptech.glide.load.model.ModelLoader&lt;android.net.Uri, java.io.InputStream&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/bumptech/glide/load/model/ModelLoader;)V", "")]
		public unsafe MediaStoreStreamLoader (global::Android.Content.Context p0, global::Com.Bumptech.Glide.Load.Model.IModelLoader p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MediaStoreStreamLoader)) {
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

		static Delegate cb_getResourceFetcher_Landroid_net_Uri_II;
#pragma warning disable 0169
		static Delegate GetGetResourceFetcher_Landroid_net_Uri_IIHandler ()
		{
			if (cb_getResourceFetcher_Landroid_net_Uri_II == null)
				cb_getResourceFetcher_Landroid_net_Uri_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetResourceFetcher_Landroid_net_Uri_II);
			return cb_getResourceFetcher_Landroid_net_Uri_II;
		}

		static IntPtr n_GetResourceFetcher_Landroid_net_Uri_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Model.Stream.MediaStoreStreamLoader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.Stream.MediaStoreStreamLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResourceFetcher (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getResourceFetcher_Landroid_net_Uri_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='MediaStoreStreamLoader']/method[@name='getResourceFetcher' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getResourceFetcher", "(Landroid/net/Uri;II)Lcom/bumptech/glide/load/data/DataFetcher;", "GetGetResourceFetcher_Landroid_net_Uri_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Data.IDataFetcher GetResourceFetcher (global::Android.Net.Uri p0, int p1, int p2)
		{
			if (id_getResourceFetcher_Landroid_net_Uri_II == IntPtr.Zero)
				id_getResourceFetcher_Landroid_net_Uri_II = JNIEnv.GetMethodID (class_ref, "getResourceFetcher", "(Landroid/net/Uri;II)Lcom/bumptech/glide/load/data/DataFetcher;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Bumptech.Glide.Load.Data.IDataFetcher __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (JNIEnv.CallObjectMethod  (Handle, id_getResourceFetcher_Landroid_net_Uri_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResourceFetcher", "(Landroid/net/Uri;II)Lcom/bumptech/glide/load/data/DataFetcher;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.Model.IModelLoader
		global::Com.Bumptech.Glide.Load.Data.IDataFetcher global::Com.Bumptech.Glide.Load.Model.IModelLoader.GetResourceFetcher (global::Java.Lang.Object p0, int p1, int p2)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Bumptech.Glide.Load.Data.IDataFetcher>(GetResourceFetcher (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Android.Net.Uri>(p0), p1, p2));
		}

	}
}
