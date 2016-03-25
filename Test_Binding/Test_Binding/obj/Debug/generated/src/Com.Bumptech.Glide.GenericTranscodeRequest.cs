using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericTranscodeRequest']"
	[global::Android.Runtime.Register ("com/bumptech/glide/GenericTranscodeRequest", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"ModelType", "DataType", "ResourceType"})]
	public partial class GenericTranscodeRequest : global::Com.Bumptech.Glide.GenericRequestBuilder, global::Com.Bumptech.Glide.IDownloadOptions {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/GenericTranscodeRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericTranscodeRequest); }
		}

		protected GenericTranscodeRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_;
#pragma warning disable 0169
		static Delegate GetDownloadOnly_Lcom_bumptech_glide_request_target_Target_Handler ()
		{
			if (cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_ == null)
				cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DownloadOnly_Lcom_bumptech_glide_request_target_Target_);
			return cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_;
		}

		static IntPtr n_DownloadOnly_Lcom_bumptech_glide_request_target_Target_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericTranscodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericTranscodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DownloadOnly (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_downloadOnly_Lcom_bumptech_glide_request_target_Target_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericTranscodeRequest']/method[@name='downloadOnly' and count(parameter)=1 and parameter[1][@type='Y']]"
		[Register ("downloadOnly", "(Lcom/bumptech/glide/request/target/Target;)Lcom/bumptech/glide/request/target/Target;", "GetDownloadOnly_Lcom_bumptech_glide_request_target_Target_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Y extends com.bumptech.glide.request.target.Target<java.io.File>"})]
		public virtual unsafe global::Java.Lang.Object DownloadOnly (global::Java.Lang.Object p0)
		{
			if (id_downloadOnly_Lcom_bumptech_glide_request_target_Target_ == IntPtr.Zero)
				id_downloadOnly_Lcom_bumptech_glide_request_target_Target_ = JNIEnv.GetMethodID (class_ref, "downloadOnly", "(Lcom/bumptech/glide/request/target/Target;)Lcom/bumptech/glide/request/target/Target;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_downloadOnly_Lcom_bumptech_glide_request_target_Target_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downloadOnly", "(Lcom/bumptech/glide/request/target/Target;)Lcom/bumptech/glide/request/target/Target;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_downloadOnly_II;
#pragma warning disable 0169
		static Delegate GetDownloadOnly_IIHandler ()
		{
			if (cb_downloadOnly_II == null)
				cb_downloadOnly_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_DownloadOnly_II);
			return cb_downloadOnly_II;
		}

		static IntPtr n_DownloadOnly_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Bumptech.Glide.GenericTranscodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericTranscodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DownloadOnly (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_downloadOnly_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericTranscodeRequest']/method[@name='downloadOnly' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("downloadOnly", "(II)Lcom/bumptech/glide/request/FutureTarget;", "GetDownloadOnly_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Request.IFutureTarget DownloadOnly (int p0, int p1)
		{
			if (id_downloadOnly_II == IntPtr.Zero)
				id_downloadOnly_II = JNIEnv.GetMethodID (class_ref, "downloadOnly", "(II)Lcom/bumptech/glide/request/FutureTarget;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (JNIEnv.CallObjectMethod  (Handle, id_downloadOnly_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downloadOnly", "(II)Lcom/bumptech/glide/request/FutureTarget;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bumptech.Glide.GenericTranscodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericTranscodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder p0 = (global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transcode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transcode_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericTranscodeRequest']/method[@name='transcode' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.resource.transcode.ResourceTranscoder&lt;ResourceType, TranscodeType&gt;'] and parameter[2][@type='java.lang.Class&lt;TranscodeType&gt;']]"
		[Register ("transcode", "(Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Ljava/lang/Class;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetTranscode_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TranscodeType"})]
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
