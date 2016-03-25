using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='ResourceCallback']"
	[Register ("com/bumptech/glide/request/ResourceCallback", "", "Com.Bumptech.Glide.Request.IResourceCallbackInvoker")]
	public partial interface IResourceCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='ResourceCallback']/method[@name='onException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onException", "(Ljava/lang/Exception;)V", "GetOnException_Ljava_lang_Exception_Handler:Com.Bumptech.Glide.Request.IResourceCallbackInvoker, Test_Binding")]
		void OnException (global::Java.Lang.Exception p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='ResourceCallback']/method[@name='onResourceReady' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.Resource&lt;?&gt;']]"
		[Register ("onResourceReady", "(Lcom/bumptech/glide/load/engine/Resource;)V", "GetOnResourceReady_Lcom_bumptech_glide_load_engine_Resource_Handler:Com.Bumptech.Glide.Request.IResourceCallbackInvoker, Test_Binding")]
		void OnResourceReady (global::Com.Bumptech.Glide.Load.Engine.IResource p0);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/request/ResourceCallback", DoNotGenerateAcw=true)]
	internal class IResourceCallbackInvoker : global::Java.Lang.Object, IResourceCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/request/ResourceCallback");
		IntPtr class_ref;

		public static IResourceCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResourceCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.request.ResourceCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResourceCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IResourceCallbackInvoker); }
		}

		static Delegate cb_onException_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnException_Ljava_lang_Exception_Handler ()
		{
			if (cb_onException_Ljava_lang_Exception_ == null)
				cb_onException_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnException_Ljava_lang_Exception_);
			return cb_onException_Ljava_lang_Exception_;
		}

		static void n_OnException_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Request.IResourceCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IResourceCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnException (p0);
		}
#pragma warning restore 0169

		IntPtr id_onException_Ljava_lang_Exception_;
		public unsafe void OnException (global::Java.Lang.Exception p0)
		{
			if (id_onException_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onException_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onException", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onException_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_;
#pragma warning disable 0169
		static Delegate GetOnResourceReady_Lcom_bumptech_glide_load_engine_Resource_Handler ()
		{
			if (cb_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_ == null)
				cb_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResourceReady_Lcom_bumptech_glide_load_engine_Resource_);
			return cb_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_;
		}

		static void n_OnResourceReady_Lcom_bumptech_glide_load_engine_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Request.IResourceCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IResourceCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p0 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResourceReady (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_;
		public unsafe void OnResourceReady (global::Com.Bumptech.Glide.Load.Engine.IResource p0)
		{
			if (id_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_ == IntPtr.Zero)
				id_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_ = JNIEnv.GetMethodID (class_ref, "onResourceReady", "(Lcom/bumptech/glide/load/engine/Resource;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_, __args);
		}

	}

}
