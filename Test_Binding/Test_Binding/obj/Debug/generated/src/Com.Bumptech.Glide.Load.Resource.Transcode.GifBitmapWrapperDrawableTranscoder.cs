using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Transcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/class[@name='GifBitmapWrapperDrawableTranscoder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/transcode/GifBitmapWrapperDrawableTranscoder", DoNotGenerateAcw=true)]
	public partial class GifBitmapWrapperDrawableTranscoder : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/transcode/GifBitmapWrapperDrawableTranscoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifBitmapWrapperDrawableTranscoder); }
		}

		protected GifBitmapWrapperDrawableTranscoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/class[@name='GifBitmapWrapperDrawableTranscoder']/constructor[@name='GifBitmapWrapperDrawableTranscoder' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.resource.transcode.ResourceTranscoder&lt;android.graphics.Bitmap, com.bumptech.glide.load.resource.bitmap.GlideBitmapDrawable&gt;']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)V", "")]
		public unsafe GifBitmapWrapperDrawableTranscoder (global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GifBitmapWrapperDrawableTranscoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_, __args);
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
			global::Com.Bumptech.Glide.Load.Resource.Transcode.GifBitmapWrapperDrawableTranscoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.GifBitmapWrapperDrawableTranscoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/class[@name='GifBitmapWrapperDrawableTranscoder']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_transcode_Lcom_bumptech_glide_load_engine_Resource_;
#pragma warning disable 0169
		static Delegate GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Handler ()
		{
			if (cb_transcode_Lcom_bumptech_glide_load_engine_Resource_ == null)
				cb_transcode_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transcode_Lcom_bumptech_glide_load_engine_Resource_);
			return cb_transcode_Lcom_bumptech_glide_load_engine_Resource_;
		}

		static IntPtr n_Transcode_Lcom_bumptech_glide_load_engine_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Resource.Transcode.GifBitmapWrapperDrawableTranscoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.GifBitmapWrapperDrawableTranscoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p0 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transcode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transcode_Lcom_bumptech_glide_load_engine_Resource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/class[@name='GifBitmapWrapperDrawableTranscoder']/method[@name='transcode' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.Resource&lt;com.bumptech.glide.load.resource.gifbitmap.GifBitmapWrapper&gt;']]"
		[Register ("transcode", "(Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;", "GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Transcode (global::Com.Bumptech.Glide.Load.Engine.IResource p0)
		{
			if (id_transcode_Lcom_bumptech_glide_load_engine_Resource_ == IntPtr.Zero)
				id_transcode_Lcom_bumptech_glide_load_engine_Resource_ = JNIEnv.GetMethodID (class_ref, "transcode", "(Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.Load.Engine.IResource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod  (Handle, id_transcode_Lcom_bumptech_glide_load_engine_Resource_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transcode", "(Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder
		global::Com.Bumptech.Glide.Load.Engine.IResource global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder.Transcode (global::Com.Bumptech.Glide.Load.Engine.IResource p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Bumptech.Glide.Load.Engine.IResource>(Transcode (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.Bumptech.Glide.Load.Engine.IResource<global::Java.Lang.Object>>(p0)));
		}

	}
}
