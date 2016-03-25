using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='GenericLoaderFactory']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/GenericLoaderFactory", DoNotGenerateAcw=true)]
	public partial class GenericLoaderFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/model/GenericLoaderFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericLoaderFactory); }
		}

		protected GenericLoaderFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='GenericLoaderFactory']/constructor[@name='GenericLoaderFactory' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe GenericLoaderFactory (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GenericLoaderFactory)) {
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

		static Delegate cb_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetBuildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Handler ()
		{
			if (cb_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_ == null)
				cb_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildModelLoader_Ljava_lang_Class_Ljava_lang_Class_);
			return cb_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_;
		}

		static IntPtr n_BuildModelLoader_Ljava_lang_Class_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildModelLoader (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='GenericLoaderFactory']/method[@name='buildModelLoader' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Class&lt;Y&gt;']]"
		[Register ("buildModelLoader", "(Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Y"})]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Model.IModelLoader BuildModelLoader (global::Java.Lang.Class p0, global::Java.Lang.Class p1)
		{
			if (id_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "buildModelLoader", "(Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/model/ModelLoader;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Bumptech.Glide.Load.Model.IModelLoader __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallObjectMethod  (Handle, id_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildModelLoader", "(Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/model/ModelLoader;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetBuildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_Handler ()
		{
			if (cb_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_ == null)
				cb_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_);
			return cb_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_;
		}

		static IntPtr n_BuildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildModelLoader (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='GenericLoaderFactory']/method[@name='buildModelLoader' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Class&lt;Y&gt;'] and parameter[3][@type='android.content.Context']]"
		[Obsolete (@"deprecated")]
		[Register ("buildModelLoader", "(Ljava/lang/Class;Ljava/lang/Class;Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Y"})]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Model.IModelLoader BuildModelLoader (global::Java.Lang.Class p0, global::Java.Lang.Class p1, global::Android.Content.Context p2)
		{
			if (id_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_ == IntPtr.Zero)
				id_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "buildModelLoader", "(Ljava/lang/Class;Ljava/lang/Class;Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoader;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Bumptech.Glide.Load.Model.IModelLoader __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallObjectMethod  (Handle, id_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildModelLoader", "(Ljava/lang/Class;Ljava/lang/Class;Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoader;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler ()
		{
			if (cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ == null)
				cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_);
			return cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;
		}

		static IntPtr n_Register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory p2 = (global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Register (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='GenericLoaderFactory']/method[@name='register' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Class&lt;Y&gt;'] and parameter[3][@type='com.bumptech.glide.load.model.ModelLoaderFactory&lt;T, Y&gt;']]"
		[Register ("register", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;", "GetRegister_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Y"})]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory Register (global::Java.Lang.Class p0, global::Java.Lang.Class p1, global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory p2)
		{
			if (id_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ == IntPtr.Zero)
				id_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ = JNIEnv.GetMethodID (class_ref, "register", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory> (JNIEnv.CallObjectMethod  (Handle, id_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_unregister_Ljava_lang_Class_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetUnregister_Ljava_lang_Class_Ljava_lang_Class_Handler ()
		{
			if (cb_unregister_Ljava_lang_Class_Ljava_lang_Class_ == null)
				cb_unregister_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Unregister_Ljava_lang_Class_Ljava_lang_Class_);
			return cb_unregister_Ljava_lang_Class_Ljava_lang_Class_;
		}

		static IntPtr n_Unregister_Ljava_lang_Class_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unregister (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_unregister_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='GenericLoaderFactory']/method[@name='unregister' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Class&lt;Y&gt;']]"
		[Register ("unregister", "(Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;", "GetUnregister_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Y"})]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory Unregister (global::Java.Lang.Class p0, global::Java.Lang.Class p1)
		{
			if (id_unregister_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_unregister_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "unregister", "(Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory> (JNIEnv.CallObjectMethod  (Handle, id_unregister_Ljava_lang_Class_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregister", "(Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
