using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Provider {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='FixedLoadProvider']"
	[global::Android.Runtime.Register ("com/bumptech/glide/provider/FixedLoadProvider", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"A", "T", "Z", "R"})]
	public partial class FixedLoadProvider : global::Java.Lang.Object, global::Com.Bumptech.Glide.Provider.ILoadProvider {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/provider/FixedLoadProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FixedLoadProvider); }
		}

		protected FixedLoadProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_provider_DataLoadProvider_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='FixedLoadProvider']/constructor[@name='FixedLoadProvider' and count(parameter)=3 and parameter[1][@type='com.bumptech.glide.load.model.ModelLoader&lt;A, T&gt;'] and parameter[2][@type='com.bumptech.glide.load.resource.transcode.ResourceTranscoder&lt;Z, R&gt;'] and parameter[3][@type='com.bumptech.glide.provider.DataLoadProvider&lt;T, Z&gt;']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/model/ModelLoader;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Lcom/bumptech/glide/provider/DataLoadProvider;)V", "")]
		public unsafe FixedLoadProvider (global::Com.Bumptech.Glide.Load.Model.IModelLoader p0, global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder p1, global::Com.Bumptech.Glide.Provider.IDataLoadProvider p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (FixedLoadProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/model/ModelLoader;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Lcom/bumptech/glide/provider/DataLoadProvider;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/model/ModelLoader;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Lcom/bumptech/glide/provider/DataLoadProvider;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_provider_DataLoadProvider_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_provider_DataLoadProvider_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/model/ModelLoader;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Lcom/bumptech/glide/provider/DataLoadProvider;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_provider_DataLoadProvider_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_provider_DataLoadProvider_, __args);
			} finally {
			}
		}

		static Delegate cb_getCacheDecoder;
#pragma warning disable 0169
		static Delegate GetGetCacheDecoderHandler ()
		{
			if (cb_getCacheDecoder == null)
				cb_getCacheDecoder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCacheDecoder);
			return cb_getCacheDecoder;
		}

		static IntPtr n_GetCacheDecoder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Provider.FixedLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.FixedLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CacheDecoder);
		}
#pragma warning restore 0169

		static IntPtr id_getCacheDecoder;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IResourceDecoder CacheDecoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='FixedLoadProvider']/method[@name='getCacheDecoder' and count(parameter)=0]"
			[Register ("getCacheDecoder", "()Lcom/bumptech/glide/load/ResourceDecoder;", "GetGetCacheDecoderHandler")]
			get {
				if (id_getCacheDecoder == IntPtr.Zero)
					id_getCacheDecoder = JNIEnv.GetMethodID (class_ref, "getCacheDecoder", "()Lcom/bumptech/glide/load/ResourceDecoder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceDecoder> (JNIEnv.CallObjectMethod  (Handle, id_getCacheDecoder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceDecoder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCacheDecoder", "()Lcom/bumptech/glide/load/ResourceDecoder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEncoder;
#pragma warning disable 0169
		static Delegate GetGetEncoderHandler ()
		{
			if (cb_getEncoder == null)
				cb_getEncoder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncoder);
			return cb_getEncoder;
		}

		static IntPtr n_GetEncoder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Provider.FixedLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.FixedLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Encoder);
		}
#pragma warning restore 0169

		static IntPtr id_getEncoder;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IResourceEncoder Encoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='FixedLoadProvider']/method[@name='getEncoder' and count(parameter)=0]"
			[Register ("getEncoder", "()Lcom/bumptech/glide/load/ResourceEncoder;", "GetGetEncoderHandler")]
			get {
				if (id_getEncoder == IntPtr.Zero)
					id_getEncoder = JNIEnv.GetMethodID (class_ref, "getEncoder", "()Lcom/bumptech/glide/load/ResourceEncoder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceEncoder> (JNIEnv.CallObjectMethod  (Handle, id_getEncoder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceEncoder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncoder", "()Lcom/bumptech/glide/load/ResourceEncoder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getModelLoader;
#pragma warning disable 0169
		static Delegate GetGetModelLoaderHandler ()
		{
			if (cb_getModelLoader == null)
				cb_getModelLoader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModelLoader);
			return cb_getModelLoader;
		}

		static IntPtr n_GetModelLoader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Provider.FixedLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.FixedLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ModelLoader);
		}
#pragma warning restore 0169

		static IntPtr id_getModelLoader;
		public virtual unsafe global::Com.Bumptech.Glide.Load.Model.IModelLoader ModelLoader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='FixedLoadProvider']/method[@name='getModelLoader' and count(parameter)=0]"
			[Register ("getModelLoader", "()Lcom/bumptech/glide/load/model/ModelLoader;", "GetGetModelLoaderHandler")]
			get {
				if (id_getModelLoader == IntPtr.Zero)
					id_getModelLoader = JNIEnv.GetMethodID (class_ref, "getModelLoader", "()Lcom/bumptech/glide/load/model/ModelLoader;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallObjectMethod  (Handle, id_getModelLoader), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getModelLoader", "()Lcom/bumptech/glide/load/model/ModelLoader;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSourceDecoder;
#pragma warning disable 0169
		static Delegate GetGetSourceDecoderHandler ()
		{
			if (cb_getSourceDecoder == null)
				cb_getSourceDecoder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSourceDecoder);
			return cb_getSourceDecoder;
		}

		static IntPtr n_GetSourceDecoder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Provider.FixedLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.FixedLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceDecoder);
		}
#pragma warning restore 0169

		static IntPtr id_getSourceDecoder;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IResourceDecoder SourceDecoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='FixedLoadProvider']/method[@name='getSourceDecoder' and count(parameter)=0]"
			[Register ("getSourceDecoder", "()Lcom/bumptech/glide/load/ResourceDecoder;", "GetGetSourceDecoderHandler")]
			get {
				if (id_getSourceDecoder == IntPtr.Zero)
					id_getSourceDecoder = JNIEnv.GetMethodID (class_ref, "getSourceDecoder", "()Lcom/bumptech/glide/load/ResourceDecoder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceDecoder> (JNIEnv.CallObjectMethod  (Handle, id_getSourceDecoder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceDecoder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSourceDecoder", "()Lcom/bumptech/glide/load/ResourceDecoder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSourceEncoder;
#pragma warning disable 0169
		static Delegate GetGetSourceEncoderHandler ()
		{
			if (cb_getSourceEncoder == null)
				cb_getSourceEncoder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSourceEncoder);
			return cb_getSourceEncoder;
		}

		static IntPtr n_GetSourceEncoder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Provider.FixedLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.FixedLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceEncoder);
		}
#pragma warning restore 0169

		static IntPtr id_getSourceEncoder;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IEncoder SourceEncoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='FixedLoadProvider']/method[@name='getSourceEncoder' and count(parameter)=0]"
			[Register ("getSourceEncoder", "()Lcom/bumptech/glide/load/Encoder;", "GetGetSourceEncoderHandler")]
			get {
				if (id_getSourceEncoder == IntPtr.Zero)
					id_getSourceEncoder = JNIEnv.GetMethodID (class_ref, "getSourceEncoder", "()Lcom/bumptech/glide/load/Encoder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IEncoder> (JNIEnv.CallObjectMethod  (Handle, id_getSourceEncoder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IEncoder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSourceEncoder", "()Lcom/bumptech/glide/load/Encoder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTranscoder;
#pragma warning disable 0169
		static Delegate GetGetTranscoderHandler ()
		{
			if (cb_getTranscoder == null)
				cb_getTranscoder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTranscoder);
			return cb_getTranscoder;
		}

		static IntPtr n_GetTranscoder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Provider.FixedLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.FixedLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Transcoder);
		}
#pragma warning restore 0169

		static IntPtr id_getTranscoder;
		public virtual unsafe global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder Transcoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='FixedLoadProvider']/method[@name='getTranscoder' and count(parameter)=0]"
			[Register ("getTranscoder", "()Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;", "GetGetTranscoderHandler")]
			get {
				if (id_getTranscoder == IntPtr.Zero)
					id_getTranscoder = JNIEnv.GetMethodID (class_ref, "getTranscoder", "()Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder> (JNIEnv.CallObjectMethod  (Handle, id_getTranscoder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTranscoder", "()Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
