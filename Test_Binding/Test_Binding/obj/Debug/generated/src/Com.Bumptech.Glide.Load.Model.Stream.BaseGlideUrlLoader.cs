using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='BaseGlideUrlLoader']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/stream/BaseGlideUrlLoader", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class BaseGlideUrlLoader : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Model.Stream.IStreamModelLoader {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/model/stream/BaseGlideUrlLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseGlideUrlLoader); }
		}

		protected BaseGlideUrlLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_Lcom_bumptech_glide_load_model_ModelCache_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='BaseGlideUrlLoader']/constructor[@name='BaseGlideUrlLoader' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.model.ModelLoader&lt;com.bumptech.glide.load.model.GlideUrl, java.io.InputStream&gt;'] and parameter[2][@type='com.bumptech.glide.load.model.ModelCache&lt;T, com.bumptech.glide.load.model.GlideUrl&gt;']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/model/ModelLoader;Lcom/bumptech/glide/load/model/ModelCache;)V", "")]
		public unsafe BaseGlideUrlLoader (global::Com.Bumptech.Glide.Load.Model.IModelLoader p0, global::Com.Bumptech.Glide.Load.Model.ModelCache p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (BaseGlideUrlLoader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/model/ModelLoader;Lcom/bumptech/glide/load/model/ModelCache;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/model/ModelLoader;Lcom/bumptech/glide/load/model/ModelCache;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_Lcom_bumptech_glide_load_model_ModelCache_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_Lcom_bumptech_glide_load_model_ModelCache_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/model/ModelLoader;Lcom/bumptech/glide/load/model/ModelCache;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_Lcom_bumptech_glide_load_model_ModelCache_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_Lcom_bumptech_glide_load_model_ModelCache_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='BaseGlideUrlLoader']/constructor[@name='BaseGlideUrlLoader' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.model.ModelLoader&lt;com.bumptech.glide.load.model.GlideUrl, java.io.InputStream&gt;']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/model/ModelLoader;)V", "")]
		public unsafe BaseGlideUrlLoader (global::Com.Bumptech.Glide.Load.Model.IModelLoader p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BaseGlideUrlLoader)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_model_ModelCache_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='BaseGlideUrlLoader']/constructor[@name='BaseGlideUrlLoader' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.bumptech.glide.load.model.ModelCache&lt;T, com.bumptech.glide.load.model.GlideUrl&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/bumptech/glide/load/model/ModelCache;)V", "")]
		public unsafe BaseGlideUrlLoader (global::Android.Content.Context p0, global::Com.Bumptech.Glide.Load.Model.ModelCache p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (BaseGlideUrlLoader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/bumptech/glide/load/model/ModelCache;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/bumptech/glide/load/model/ModelCache;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_model_ModelCache_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_model_ModelCache_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/bumptech/glide/load/model/ModelCache;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_model_ModelCache_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_model_ModelCache_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='BaseGlideUrlLoader']/constructor[@name='BaseGlideUrlLoader' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BaseGlideUrlLoader (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BaseGlideUrlLoader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getHeaders_Ljava_lang_Object_II;
#pragma warning disable 0169
		static Delegate GetGetHeaders_Ljava_lang_Object_IIHandler ()
		{
			if (cb_getHeaders_Ljava_lang_Object_II == null)
				cb_getHeaders_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetHeaders_Ljava_lang_Object_II);
			return cb_getHeaders_Ljava_lang_Object_II;
		}

		static IntPtr n_GetHeaders_Ljava_lang_Object_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Model.Stream.BaseGlideUrlLoader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.Stream.BaseGlideUrlLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetHeaders (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders_Ljava_lang_Object_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='BaseGlideUrlLoader']/method[@name='getHeaders' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getHeaders", "(Ljava/lang/Object;II)Lcom/bumptech/glide/load/model/Headers;", "GetGetHeaders_Ljava_lang_Object_IIHandler")]
		protected virtual unsafe global::Com.Bumptech.Glide.Load.Model.IHeaders GetHeaders (global::Java.Lang.Object p0, int p1, int p2)
		{
			if (id_getHeaders_Ljava_lang_Object_II == IntPtr.Zero)
				id_getHeaders_Ljava_lang_Object_II = JNIEnv.GetMethodID (class_ref, "getHeaders", "(Ljava/lang/Object;II)Lcom/bumptech/glide/load/model/Headers;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Bumptech.Glide.Load.Model.IHeaders __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IHeaders> (JNIEnv.CallObjectMethod  (Handle, id_getHeaders_Ljava_lang_Object_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IHeaders> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaders", "(Ljava/lang/Object;II)Lcom/bumptech/glide/load/model/Headers;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getResourceFetcher_Ljava_lang_Object_II;
#pragma warning disable 0169
		static Delegate GetGetResourceFetcher_Ljava_lang_Object_IIHandler ()
		{
			if (cb_getResourceFetcher_Ljava_lang_Object_II == null)
				cb_getResourceFetcher_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetResourceFetcher_Ljava_lang_Object_II);
			return cb_getResourceFetcher_Ljava_lang_Object_II;
		}

		static IntPtr n_GetResourceFetcher_Ljava_lang_Object_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Model.Stream.BaseGlideUrlLoader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.Stream.BaseGlideUrlLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResourceFetcher (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getResourceFetcher_Ljava_lang_Object_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='BaseGlideUrlLoader']/method[@name='getResourceFetcher' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getResourceFetcher", "(Ljava/lang/Object;II)Lcom/bumptech/glide/load/data/DataFetcher;", "GetGetResourceFetcher_Ljava_lang_Object_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Data.IDataFetcher GetResourceFetcher (global::Java.Lang.Object p0, int p1, int p2)
		{
			if (id_getResourceFetcher_Ljava_lang_Object_II == IntPtr.Zero)
				id_getResourceFetcher_Ljava_lang_Object_II = JNIEnv.GetMethodID (class_ref, "getResourceFetcher", "(Ljava/lang/Object;II)Lcom/bumptech/glide/load/data/DataFetcher;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Bumptech.Glide.Load.Data.IDataFetcher __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (JNIEnv.CallObjectMethod  (Handle, id_getResourceFetcher_Ljava_lang_Object_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResourceFetcher", "(Ljava/lang/Object;II)Lcom/bumptech/glide/load/data/DataFetcher;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getUrl_Ljava_lang_Object_II;
#pragma warning disable 0169
		static Delegate GetGetUrl_Ljava_lang_Object_IIHandler ()
		{
			if (cb_getUrl_Ljava_lang_Object_II == null)
				cb_getUrl_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetUrl_Ljava_lang_Object_II);
			return cb_getUrl_Ljava_lang_Object_II;
		}

		static IntPtr n_GetUrl_Ljava_lang_Object_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Model.Stream.BaseGlideUrlLoader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.Stream.BaseGlideUrlLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetUrl (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='BaseGlideUrlLoader']/method[@name='getUrl' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getUrl", "(Ljava/lang/Object;II)Ljava/lang/String;", "GetGetUrl_Ljava_lang_Object_IIHandler")]
		protected abstract string GetUrl (global::Java.Lang.Object p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/stream/BaseGlideUrlLoader", DoNotGenerateAcw=true)]
	internal partial class BaseGlideUrlLoaderInvoker : BaseGlideUrlLoader, global::Com.Bumptech.Glide.Load.Model.Stream.IStreamModelLoader, global::Com.Bumptech.Glide.Load.Model.IModelLoader {

		public BaseGlideUrlLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseGlideUrlLoaderInvoker); }
		}

		static IntPtr id_getUrl_Ljava_lang_Object_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='BaseGlideUrlLoader']/method[@name='getUrl' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getUrl", "(Ljava/lang/Object;II)Ljava/lang/String;", "GetGetUrl_Ljava_lang_Object_IIHandler")]
		protected override unsafe string GetUrl (global::Java.Lang.Object p0, int p1, int p2)
		{
			if (id_getUrl_Ljava_lang_Object_II == IntPtr.Zero)
				id_getUrl_Ljava_lang_Object_II = JNIEnv.GetMethodID (class_ref, "getUrl", "(Ljava/lang/Object;II)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUrl_Ljava_lang_Object_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
