using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Provider {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='ChildLoadProvider']"
	[global::Android.Runtime.Register ("com/bumptech/glide/provider/ChildLoadProvider", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"A", "T", "Z", "R"})]
	public partial class ChildLoadProvider : global::Java.Lang.Object, global::Com.Bumptech.Glide.Provider.ILoadProvider, global::Java.Lang.ICloneable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/provider/ChildLoadProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChildLoadProvider); }
		}

		protected ChildLoadProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_provider_LoadProvider_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='ChildLoadProvider']/constructor[@name='ChildLoadProvider' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.provider.LoadProvider&lt;A, T, Z, R&gt;']]"
		[Register (".ctor", "(Lcom/bumptech/glide/provider/LoadProvider;)V", "")]
		public unsafe ChildLoadProvider (global::Com.Bumptech.Glide.Provider.ILoadProvider p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ChildLoadProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/provider/LoadProvider;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/provider/LoadProvider;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_provider_LoadProvider_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_provider_LoadProvider_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/provider/LoadProvider;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_provider_LoadProvider_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_provider_LoadProvider_, __args);
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
			global::Com.Bumptech.Glide.Provider.ChildLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ChildLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CacheDecoder);
		}
#pragma warning restore 0169

		static Delegate cb_setCacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_;
#pragma warning disable 0169
		static Delegate GetSetCacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_Handler ()
		{
			if (cb_setCacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ == null)
				cb_setCacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_);
			return cb_setCacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_;
		}

		static void n_SetCacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Provider.ChildLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ChildLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IResourceDecoder p0 = (global::Com.Bumptech.Glide.Load.IResourceDecoder)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceDecoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CacheDecoder = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCacheDecoder;
		static IntPtr id_setCacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IResourceDecoder CacheDecoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='ChildLoadProvider']/method[@name='getCacheDecoder' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='ChildLoadProvider']/method[@name='setCacheDecoder' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.ResourceDecoder&lt;java.io.File, Z&gt;']]"
			[Register ("setCacheDecoder", "(Lcom/bumptech/glide/load/ResourceDecoder;)V", "GetSetCacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_Handler")]
			set {
				if (id_setCacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ == IntPtr.Zero)
					id_setCacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ = JNIEnv.GetMethodID (class_ref, "setCacheDecoder", "(Lcom/bumptech/glide/load/ResourceDecoder;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCacheDecoder", "(Lcom/bumptech/glide/load/ResourceDecoder;)V"), __args);
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
			global::Com.Bumptech.Glide.Provider.ChildLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ChildLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Encoder);
		}
#pragma warning restore 0169

		static Delegate cb_setEncoder_Lcom_bumptech_glide_load_ResourceEncoder_;
#pragma warning disable 0169
		static Delegate GetSetEncoder_Lcom_bumptech_glide_load_ResourceEncoder_Handler ()
		{
			if (cb_setEncoder_Lcom_bumptech_glide_load_ResourceEncoder_ == null)
				cb_setEncoder_Lcom_bumptech_glide_load_ResourceEncoder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEncoder_Lcom_bumptech_glide_load_ResourceEncoder_);
			return cb_setEncoder_Lcom_bumptech_glide_load_ResourceEncoder_;
		}

		static void n_SetEncoder_Lcom_bumptech_glide_load_ResourceEncoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Provider.ChildLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ChildLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IResourceEncoder p0 = (global::Com.Bumptech.Glide.Load.IResourceEncoder)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encoder = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEncoder;
		static IntPtr id_setEncoder_Lcom_bumptech_glide_load_ResourceEncoder_;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IResourceEncoder Encoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='ChildLoadProvider']/method[@name='getEncoder' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='ChildLoadProvider']/method[@name='setEncoder' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.ResourceEncoder&lt;Z&gt;']]"
			[Register ("setEncoder", "(Lcom/bumptech/glide/load/ResourceEncoder;)V", "GetSetEncoder_Lcom_bumptech_glide_load_ResourceEncoder_Handler")]
			set {
				if (id_setEncoder_Lcom_bumptech_glide_load_ResourceEncoder_ == IntPtr.Zero)
					id_setEncoder_Lcom_bumptech_glide_load_ResourceEncoder_ = JNIEnv.GetMethodID (class_ref, "setEncoder", "(Lcom/bumptech/glide/load/ResourceEncoder;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setEncoder_Lcom_bumptech_glide_load_ResourceEncoder_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEncoder", "(Lcom/bumptech/glide/load/ResourceEncoder;)V"), __args);
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
			global::Com.Bumptech.Glide.Provider.ChildLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ChildLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ModelLoader);
		}
#pragma warning restore 0169

		static IntPtr id_getModelLoader;
		public virtual unsafe global::Com.Bumptech.Glide.Load.Model.IModelLoader ModelLoader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='ChildLoadProvider']/method[@name='getModelLoader' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Provider.ChildLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ChildLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceDecoder);
		}
#pragma warning restore 0169

		static Delegate cb_setSourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_;
#pragma warning disable 0169
		static Delegate GetSetSourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_Handler ()
		{
			if (cb_setSourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ == null)
				cb_setSourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_);
			return cb_setSourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_;
		}

		static void n_SetSourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Provider.ChildLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ChildLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IResourceDecoder p0 = (global::Com.Bumptech.Glide.Load.IResourceDecoder)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceDecoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SourceDecoder = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSourceDecoder;
		static IntPtr id_setSourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IResourceDecoder SourceDecoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='ChildLoadProvider']/method[@name='getSourceDecoder' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='ChildLoadProvider']/method[@name='setSourceDecoder' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.ResourceDecoder&lt;T, Z&gt;']]"
			[Register ("setSourceDecoder", "(Lcom/bumptech/glide/load/ResourceDecoder;)V", "GetSetSourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_Handler")]
			set {
				if (id_setSourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ == IntPtr.Zero)
					id_setSourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ = JNIEnv.GetMethodID (class_ref, "setSourceDecoder", "(Lcom/bumptech/glide/load/ResourceDecoder;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSourceDecoder", "(Lcom/bumptech/glide/load/ResourceDecoder;)V"), __args);
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
			global::Com.Bumptech.Glide.Provider.ChildLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ChildLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceEncoder);
		}
#pragma warning restore 0169

		static Delegate cb_setSourceEncoder_Lcom_bumptech_glide_load_Encoder_;
#pragma warning disable 0169
		static Delegate GetSetSourceEncoder_Lcom_bumptech_glide_load_Encoder_Handler ()
		{
			if (cb_setSourceEncoder_Lcom_bumptech_glide_load_Encoder_ == null)
				cb_setSourceEncoder_Lcom_bumptech_glide_load_Encoder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSourceEncoder_Lcom_bumptech_glide_load_Encoder_);
			return cb_setSourceEncoder_Lcom_bumptech_glide_load_Encoder_;
		}

		static void n_SetSourceEncoder_Lcom_bumptech_glide_load_Encoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Provider.ChildLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ChildLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IEncoder p0 = (global::Com.Bumptech.Glide.Load.IEncoder)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SourceEncoder = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSourceEncoder;
		static IntPtr id_setSourceEncoder_Lcom_bumptech_glide_load_Encoder_;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IEncoder SourceEncoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='ChildLoadProvider']/method[@name='getSourceEncoder' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='ChildLoadProvider']/method[@name='setSourceEncoder' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.Encoder&lt;T&gt;']]"
			[Register ("setSourceEncoder", "(Lcom/bumptech/glide/load/Encoder;)V", "GetSetSourceEncoder_Lcom_bumptech_glide_load_Encoder_Handler")]
			set {
				if (id_setSourceEncoder_Lcom_bumptech_glide_load_Encoder_ == IntPtr.Zero)
					id_setSourceEncoder_Lcom_bumptech_glide_load_Encoder_ = JNIEnv.GetMethodID (class_ref, "setSourceEncoder", "(Lcom/bumptech/glide/load/Encoder;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSourceEncoder_Lcom_bumptech_glide_load_Encoder_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSourceEncoder", "(Lcom/bumptech/glide/load/Encoder;)V"), __args);
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
			global::Com.Bumptech.Glide.Provider.ChildLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ChildLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Transcoder);
		}
#pragma warning restore 0169

		static Delegate cb_setTranscoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_;
#pragma warning disable 0169
		static Delegate GetSetTranscoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Handler ()
		{
			if (cb_setTranscoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ == null)
				cb_setTranscoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTranscoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_);
			return cb_setTranscoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_;
		}

		static void n_SetTranscoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Provider.ChildLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ChildLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder p0 = (global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Transcoder = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTranscoder;
		static IntPtr id_setTranscoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_;
		public virtual unsafe global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder Transcoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='ChildLoadProvider']/method[@name='getTranscoder' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='ChildLoadProvider']/method[@name='setTranscoder' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.resource.transcode.ResourceTranscoder&lt;Z, R&gt;']]"
			[Register ("setTranscoder", "(Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)V", "GetSetTranscoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Handler")]
			set {
				if (id_setTranscoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ == IntPtr.Zero)
					id_setTranscoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ = JNIEnv.GetMethodID (class_ref, "setTranscoder", "(Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTranscoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTranscoder", "(Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Provider.ChildLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ChildLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/class[@name='ChildLoadProvider']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/bumptech/glide/provider/ChildLoadProvider;", "GetCloneHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Provider.ChildLoadProvider Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/bumptech/glide/provider/ChildLoadProvider;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ChildLoadProvider> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ChildLoadProvider> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lcom/bumptech/glide/provider/ChildLoadProvider;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
