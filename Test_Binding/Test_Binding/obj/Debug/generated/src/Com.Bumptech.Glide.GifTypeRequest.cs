using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GifTypeRequest']"
	[global::Android.Runtime.Register ("com/bumptech/glide/GifTypeRequest", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"ModelType"})]
	public partial class GifTypeRequest : global::Com.Bumptech.Glide.GifRequestBuilder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/GifTypeRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifTypeRequest); }
		}

		protected GifTypeRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_toBytes;
#pragma warning disable 0169
		static Delegate GetToBytesHandler ()
		{
			if (cb_toBytes == null)
				cb_toBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToBytes);
			return cb_toBytes;
		}

		static IntPtr n_ToBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.GifTypeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifTypeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToBytes ());
		}
#pragma warning restore 0169

		static IntPtr id_toBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GifTypeRequest']/method[@name='toBytes' and count(parameter)=0]"
		[Register ("toBytes", "()Lcom/bumptech/glide/GenericRequestBuilder;", "GetToBytesHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder ToBytes ()
		{
			if (id_toBytes == IntPtr.Zero)
				id_toBytes = JNIEnv.GetMethodID (class_ref, "toBytes", "()Lcom/bumptech/glide/GenericRequestBuilder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_toBytes), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toBytes", "()Lcom/bumptech/glide/GenericRequestBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_transcode_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetTranscode_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Ljava_lang_Class_Handler ()
		{
			if (cb_transcode_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Ljava_lang_Class_ == null)
				cb_transcode_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Transcode_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Ljava_lang_Class_);
			return cb_transcode_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Ljava_lang_Class_;
		}

		static IntPtr n_Transcode_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.GifTypeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifTypeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder p0 = (global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transcode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transcode_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GifTypeRequest']/method[@name='transcode' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.resource.transcode.ResourceTranscoder&lt;com.bumptech.glide.load.resource.gif.GifDrawable, R&gt;'] and parameter[2][@type='java.lang.Class&lt;R&gt;']]"
		[Register ("transcode", "(Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Ljava/lang/Class;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetTranscode_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Transcode (global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder p0, global::Java.Lang.Class p1)
		{
			if (id_transcode_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Ljava_lang_Class_ == IntPtr.Zero)
				id_transcode_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "transcode", "(Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Ljava/lang/Class;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_transcode_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transcode", "(Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Ljava/lang/Class;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
