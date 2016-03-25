using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Module {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.module']/interface[@name='GlideModule']"
	[Register ("com/bumptech/glide/module/GlideModule", "", "Com.Bumptech.Glide.Module.IGlideModuleInvoker")]
	public partial interface IGlideModule : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.module']/interface[@name='GlideModule']/method[@name='applyOptions' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.bumptech.glide.GlideBuilder']]"
		[Register ("applyOptions", "(Landroid/content/Context;Lcom/bumptech/glide/GlideBuilder;)V", "GetApplyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_Handler:Com.Bumptech.Glide.Module.IGlideModuleInvoker, Test_Binding")]
		void ApplyOptions (global::Android.Content.Context p0, global::Com.Bumptech.Glide.GlideBuilder p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.module']/interface[@name='GlideModule']/method[@name='registerComponents' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.bumptech.glide.Glide']]"
		[Register ("registerComponents", "(Landroid/content/Context;Lcom/bumptech/glide/Glide;)V", "GetRegisterComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Handler:Com.Bumptech.Glide.Module.IGlideModuleInvoker, Test_Binding")]
		void RegisterComponents (global::Android.Content.Context p0, global::Com.Bumptech.Glide.Glide p1);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/module/GlideModule", DoNotGenerateAcw=true)]
	internal class IGlideModuleInvoker : global::Java.Lang.Object, IGlideModule {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/module/GlideModule");
		IntPtr class_ref;

		public static IGlideModule GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGlideModule> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.module.GlideModule"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGlideModuleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IGlideModuleInvoker); }
		}

		static Delegate cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_;
#pragma warning disable 0169
		static Delegate GetApplyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_Handler ()
		{
			if (cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_ == null)
				cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ApplyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_);
			return cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_;
		}

		static void n_ApplyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Module.IGlideModule __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Module.IGlideModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.GlideBuilder p1 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ApplyOptions (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_;
		public unsafe void ApplyOptions (global::Android.Content.Context p0, global::Com.Bumptech.Glide.GlideBuilder p1)
		{
			if (id_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_ == IntPtr.Zero)
				id_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_ = JNIEnv.GetMethodID (class_ref, "applyOptions", "(Landroid/content/Context;Lcom/bumptech/glide/GlideBuilder;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_, __args);
		}

		static Delegate cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_;
#pragma warning disable 0169
		static Delegate GetRegisterComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Handler ()
		{
			if (cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_ == null)
				cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_);
			return cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_;
		}

		static void n_RegisterComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Module.IGlideModule __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Module.IGlideModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Glide p1 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Glide> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RegisterComponents (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_;
		public unsafe void RegisterComponents (global::Android.Content.Context p0, global::Com.Bumptech.Glide.Glide p1)
		{
			if (id_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_ == IntPtr.Zero)
				id_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_ = JNIEnv.GetMethodID (class_ref, "registerComponents", "(Landroid/content/Context;Lcom/bumptech/glide/Glide;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_, __args);
		}

	}

}
