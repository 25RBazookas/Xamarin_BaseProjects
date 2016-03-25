using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='HttpUrlGlideUrlLoader']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/stream/HttpUrlGlideUrlLoader", DoNotGenerateAcw=true)]
	public partial class HttpUrlGlideUrlLoader : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Model.IModelLoader {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='HttpUrlGlideUrlLoader.Factory']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/model/stream/HttpUrlGlideUrlLoader$Factory", DoNotGenerateAcw=true)]
		public partial class Factory : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/model/stream/HttpUrlGlideUrlLoader$Factory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Factory); }
			}

			protected Factory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='HttpUrlGlideUrlLoader.Factory']/constructor[@name='HttpUrlGlideUrlLoader.Factory' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Factory ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Factory)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

			static Delegate cb_build_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_;
#pragma warning disable 0169
			static Delegate GetBuild_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_Handler ()
			{
				if (cb_build_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_ == null)
					cb_build_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Build_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_);
				return cb_build_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_;
			}

			static IntPtr n_Build_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Bumptech.Glide.Load.Model.Stream.HttpUrlGlideUrlLoader.Factory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.Stream.HttpUrlGlideUrlLoader.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory p1 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_build_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='HttpUrlGlideUrlLoader.Factory']/method[@name='build' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.bumptech.glide.load.model.GenericLoaderFactory']]"
			[Register ("build", "(Landroid/content/Context;Lcom/bumptech/glide/load/model/GenericLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_Handler")]
			public virtual unsafe global::Com.Bumptech.Glide.Load.Model.IModelLoader Build (global::Android.Content.Context p0, global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory p1)
			{
				if (id_build_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_ == IntPtr.Zero)
					id_build_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_ = JNIEnv.GetMethodID (class_ref, "build", "(Landroid/content/Context;Lcom/bumptech/glide/load/model/GenericLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Com.Bumptech.Glide.Load.Model.IModelLoader __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallObjectMethod  (Handle, id_build_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "(Landroid/content/Context;Lcom/bumptech/glide/load/model/GenericLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_teardown;
#pragma warning disable 0169
			static Delegate GetTeardownHandler ()
			{
				if (cb_teardown == null)
					cb_teardown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Teardown);
				return cb_teardown;
			}

			static void n_Teardown (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Model.Stream.HttpUrlGlideUrlLoader.Factory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.Stream.HttpUrlGlideUrlLoader.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Teardown ();
			}
#pragma warning restore 0169

			static IntPtr id_teardown;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='HttpUrlGlideUrlLoader.Factory']/method[@name='teardown' and count(parameter)=0]"
			[Register ("teardown", "()V", "GetTeardownHandler")]
			public virtual unsafe void Teardown ()
			{
				if (id_teardown == IntPtr.Zero)
					id_teardown = JNIEnv.GetMethodID (class_ref, "teardown", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_teardown);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "teardown", "()V"));
				} finally {
				}
			}

			// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.Model.IModelLoaderFactory
			global::Com.Bumptech.Glide.Load.Model.IModelLoader global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory.Build (global::Android.Content.Context p0, global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory p1)
			{
				return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Bumptech.Glide.Load.Model.IModelLoader>(Build (p0, p1));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/model/stream/HttpUrlGlideUrlLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpUrlGlideUrlLoader); }
		}

		protected HttpUrlGlideUrlLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='HttpUrlGlideUrlLoader']/constructor[@name='HttpUrlGlideUrlLoader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpUrlGlideUrlLoader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HttpUrlGlideUrlLoader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_model_ModelCache_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='HttpUrlGlideUrlLoader']/constructor[@name='HttpUrlGlideUrlLoader' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.model.ModelCache&lt;com.bumptech.glide.load.model.GlideUrl, com.bumptech.glide.load.model.GlideUrl&gt;']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/model/ModelCache;)V", "")]
		public unsafe HttpUrlGlideUrlLoader (global::Com.Bumptech.Glide.Load.Model.ModelCache p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (HttpUrlGlideUrlLoader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/model/ModelCache;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/model/ModelCache;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_model_ModelCache_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_model_ModelCache_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/model/ModelCache;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_model_ModelCache_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_model_ModelCache_, __args);
			} finally {
			}
		}

		static Delegate cb_getResourceFetcher_Lcom_bumptech_glide_load_model_GlideUrl_II;
#pragma warning disable 0169
		static Delegate GetGetResourceFetcher_Lcom_bumptech_glide_load_model_GlideUrl_IIHandler ()
		{
			if (cb_getResourceFetcher_Lcom_bumptech_glide_load_model_GlideUrl_II == null)
				cb_getResourceFetcher_Lcom_bumptech_glide_load_model_GlideUrl_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetResourceFetcher_Lcom_bumptech_glide_load_model_GlideUrl_II);
			return cb_getResourceFetcher_Lcom_bumptech_glide_load_model_GlideUrl_II;
		}

		static IntPtr n_GetResourceFetcher_Lcom_bumptech_glide_load_model_GlideUrl_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Model.Stream.HttpUrlGlideUrlLoader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.Stream.HttpUrlGlideUrlLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Model.GlideUrl p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.GlideUrl> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResourceFetcher (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getResourceFetcher_Lcom_bumptech_glide_load_model_GlideUrl_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/class[@name='HttpUrlGlideUrlLoader']/method[@name='getResourceFetcher' and count(parameter)=3 and parameter[1][@type='com.bumptech.glide.load.model.GlideUrl'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getResourceFetcher", "(Lcom/bumptech/glide/load/model/GlideUrl;II)Lcom/bumptech/glide/load/data/DataFetcher;", "GetGetResourceFetcher_Lcom_bumptech_glide_load_model_GlideUrl_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Data.IDataFetcher GetResourceFetcher (global::Com.Bumptech.Glide.Load.Model.GlideUrl p0, int p1, int p2)
		{
			if (id_getResourceFetcher_Lcom_bumptech_glide_load_model_GlideUrl_II == IntPtr.Zero)
				id_getResourceFetcher_Lcom_bumptech_glide_load_model_GlideUrl_II = JNIEnv.GetMethodID (class_ref, "getResourceFetcher", "(Lcom/bumptech/glide/load/model/GlideUrl;II)Lcom/bumptech/glide/load/data/DataFetcher;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Bumptech.Glide.Load.Data.IDataFetcher __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (JNIEnv.CallObjectMethod  (Handle, id_getResourceFetcher_Lcom_bumptech_glide_load_model_GlideUrl_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResourceFetcher", "(Lcom/bumptech/glide/load/model/GlideUrl;II)Lcom/bumptech/glide/load/data/DataFetcher;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.Model.IModelLoader
		global::Com.Bumptech.Glide.Load.Data.IDataFetcher global::Com.Bumptech.Glide.Load.Model.IModelLoader.GetResourceFetcher (global::Java.Lang.Object p0, int p1, int p2)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Bumptech.Glide.Load.Data.IDataFetcher>(GetResourceFetcher (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.Bumptech.Glide.Load.Model.GlideUrl>(p0), p1, p2));
		}

	}
}
