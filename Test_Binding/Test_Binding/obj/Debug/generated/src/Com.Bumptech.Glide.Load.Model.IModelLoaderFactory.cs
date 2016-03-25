using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.model']/interface[@name='ModelLoaderFactory']"
	[Register ("com/bumptech/glide/load/model/ModelLoaderFactory", "", "Com.Bumptech.Glide.Load.Model.IModelLoaderFactoryInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Y"})]
	public partial interface IModelLoaderFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/interface[@name='ModelLoaderFactory']/method[@name='build' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.bumptech.glide.load.model.GenericLoaderFactory']]"
		[Register ("build", "(Landroid/content/Context;Lcom/bumptech/glide/load/model/GenericLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_Handler:Com.Bumptech.Glide.Load.Model.IModelLoaderFactoryInvoker, Test_Binding")]
		global::Com.Bumptech.Glide.Load.Model.IModelLoader Build (global::Android.Content.Context p0, global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/interface[@name='ModelLoaderFactory']/method[@name='teardown' and count(parameter)=0]"
		[Register ("teardown", "()V", "GetTeardownHandler:Com.Bumptech.Glide.Load.Model.IModelLoaderFactoryInvoker, Test_Binding")]
		void Teardown ();

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/ModelLoaderFactory", DoNotGenerateAcw=true)]
	internal class IModelLoaderFactoryInvoker : global::Java.Lang.Object, IModelLoaderFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/model/ModelLoaderFactory");
		IntPtr class_ref;

		public static IModelLoaderFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IModelLoaderFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.model.ModelLoaderFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IModelLoaderFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IModelLoaderFactoryInvoker); }
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
			global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory p1 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_build_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_;
		public unsafe global::Com.Bumptech.Glide.Load.Model.IModelLoader Build (global::Android.Content.Context p0, global::Com.Bumptech.Glide.Load.Model.GenericLoaderFactory p1)
		{
			if (id_build_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_ == IntPtr.Zero)
				id_build_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_ = JNIEnv.GetMethodID (class_ref, "build", "(Landroid/content/Context;Lcom/bumptech/glide/load/model/GenericLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Com.Bumptech.Glide.Load.Model.IModelLoader __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallObjectMethod (Handle, id_build_Landroid_content_Context_Lcom_bumptech_glide_load_model_GenericLoaderFactory_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Teardown ();
		}
#pragma warning restore 0169

		IntPtr id_teardown;
		public unsafe void Teardown ()
		{
			if (id_teardown == IntPtr.Zero)
				id_teardown = JNIEnv.GetMethodID (class_ref, "teardown", "()V");
			JNIEnv.CallVoidMethod (Handle, id_teardown);
		}

	}

}
