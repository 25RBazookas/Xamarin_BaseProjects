using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Provider {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.provider']/interface[@name='LoadProvider']"
	[Register ("com/bumptech/glide/provider/LoadProvider", "", "Com.Bumptech.Glide.Provider.ILoadProviderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"A", "T", "Z", "R"})]
	public partial interface ILoadProvider : global::Com.Bumptech.Glide.Provider.IDataLoadProvider {

		global::Com.Bumptech.Glide.Load.Model.IModelLoader ModelLoader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/interface[@name='LoadProvider']/method[@name='getModelLoader' and count(parameter)=0]"
			[Register ("getModelLoader", "()Lcom/bumptech/glide/load/model/ModelLoader;", "GetGetModelLoaderHandler:Com.Bumptech.Glide.Provider.ILoadProviderInvoker, Test_Binding")] get;
		}

		global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder Transcoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/interface[@name='LoadProvider']/method[@name='getTranscoder' and count(parameter)=0]"
			[Register ("getTranscoder", "()Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;", "GetGetTranscoderHandler:Com.Bumptech.Glide.Provider.ILoadProviderInvoker, Test_Binding")] get;
		}

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/provider/LoadProvider", DoNotGenerateAcw=true)]
	internal class ILoadProviderInvoker : global::Java.Lang.Object, ILoadProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/provider/LoadProvider");
		IntPtr class_ref;

		public static ILoadProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoadProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.provider.LoadProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoadProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILoadProviderInvoker); }
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
			global::Com.Bumptech.Glide.Provider.ILoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ILoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ModelLoader);
		}
#pragma warning restore 0169

		IntPtr id_getModelLoader;
		public unsafe global::Com.Bumptech.Glide.Load.Model.IModelLoader ModelLoader {
			get {
				if (id_getModelLoader == IntPtr.Zero)
					id_getModelLoader = JNIEnv.GetMethodID (class_ref, "getModelLoader", "()Lcom/bumptech/glide/load/model/ModelLoader;");
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallObjectMethod (Handle, id_getModelLoader), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bumptech.Glide.Provider.ILoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ILoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Transcoder);
		}
#pragma warning restore 0169

		IntPtr id_getTranscoder;
		public unsafe global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder Transcoder {
			get {
				if (id_getTranscoder == IntPtr.Zero)
					id_getTranscoder = JNIEnv.GetMethodID (class_ref, "getTranscoder", "()Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;");
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder> (JNIEnv.CallObjectMethod (Handle, id_getTranscoder), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bumptech.Glide.Provider.ILoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ILoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CacheDecoder);
		}
#pragma warning restore 0169

		IntPtr id_getCacheDecoder;
		public unsafe global::Com.Bumptech.Glide.Load.IResourceDecoder CacheDecoder {
			get {
				if (id_getCacheDecoder == IntPtr.Zero)
					id_getCacheDecoder = JNIEnv.GetMethodID (class_ref, "getCacheDecoder", "()Lcom/bumptech/glide/load/ResourceDecoder;");
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceDecoder> (JNIEnv.CallObjectMethod (Handle, id_getCacheDecoder), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bumptech.Glide.Provider.ILoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ILoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Encoder);
		}
#pragma warning restore 0169

		IntPtr id_getEncoder;
		public unsafe global::Com.Bumptech.Glide.Load.IResourceEncoder Encoder {
			get {
				if (id_getEncoder == IntPtr.Zero)
					id_getEncoder = JNIEnv.GetMethodID (class_ref, "getEncoder", "()Lcom/bumptech/glide/load/ResourceEncoder;");
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceEncoder> (JNIEnv.CallObjectMethod (Handle, id_getEncoder), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bumptech.Glide.Provider.ILoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ILoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceDecoder);
		}
#pragma warning restore 0169

		IntPtr id_getSourceDecoder;
		public unsafe global::Com.Bumptech.Glide.Load.IResourceDecoder SourceDecoder {
			get {
				if (id_getSourceDecoder == IntPtr.Zero)
					id_getSourceDecoder = JNIEnv.GetMethodID (class_ref, "getSourceDecoder", "()Lcom/bumptech/glide/load/ResourceDecoder;");
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceDecoder> (JNIEnv.CallObjectMethod (Handle, id_getSourceDecoder), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bumptech.Glide.Provider.ILoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.ILoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceEncoder);
		}
#pragma warning restore 0169

		IntPtr id_getSourceEncoder;
		public unsafe global::Com.Bumptech.Glide.Load.IEncoder SourceEncoder {
			get {
				if (id_getSourceEncoder == IntPtr.Zero)
					id_getSourceEncoder = JNIEnv.GetMethodID (class_ref, "getSourceEncoder", "()Lcom/bumptech/glide/load/Encoder;");
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IEncoder> (JNIEnv.CallObjectMethod (Handle, id_getSourceEncoder), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
