using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='UrlLoader']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/UrlLoader", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class UrlLoader : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Model.IModelLoader {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/model/UrlLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UrlLoader); }
		}

		protected UrlLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='UrlLoader']/constructor[@name='UrlLoader' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.model.ModelLoader&lt;com.bumptech.glide.load.model.GlideUrl, T&gt;']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/model/ModelLoader;)V", "")]
		public unsafe UrlLoader (global::Com.Bumptech.Glide.Load.Model.IModelLoader p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (UrlLoader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/model/ModelLoader;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/model/ModelLoader;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/model/ModelLoader;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_, __args);
			} finally {
			}
		}

		static Delegate cb_getResourceFetcher_Ljava_net_URL_II;
#pragma warning disable 0169
		static Delegate GetGetResourceFetcher_Ljava_net_URL_IIHandler ()
		{
			if (cb_getResourceFetcher_Ljava_net_URL_II == null)
				cb_getResourceFetcher_Ljava_net_URL_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetResourceFetcher_Ljava_net_URL_II);
			return cb_getResourceFetcher_Ljava_net_URL_II;
		}

		static IntPtr n_GetResourceFetcher_Ljava_net_URL_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Model.UrlLoader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.UrlLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResourceFetcher (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getResourceFetcher_Ljava_net_URL_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='UrlLoader']/method[@name='getResourceFetcher' and count(parameter)=3 and parameter[1][@type='java.net.URL'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getResourceFetcher", "(Ljava/net/URL;II)Lcom/bumptech/glide/load/data/DataFetcher;", "GetGetResourceFetcher_Ljava_net_URL_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Data.IDataFetcher GetResourceFetcher (global::Java.Net.URL p0, int p1, int p2)
		{
			if (id_getResourceFetcher_Ljava_net_URL_II == IntPtr.Zero)
				id_getResourceFetcher_Ljava_net_URL_II = JNIEnv.GetMethodID (class_ref, "getResourceFetcher", "(Ljava/net/URL;II)Lcom/bumptech/glide/load/data/DataFetcher;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Bumptech.Glide.Load.Data.IDataFetcher __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (JNIEnv.CallObjectMethod  (Handle, id_getResourceFetcher_Ljava_net_URL_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResourceFetcher", "(Ljava/net/URL;II)Lcom/bumptech/glide/load/data/DataFetcher;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
