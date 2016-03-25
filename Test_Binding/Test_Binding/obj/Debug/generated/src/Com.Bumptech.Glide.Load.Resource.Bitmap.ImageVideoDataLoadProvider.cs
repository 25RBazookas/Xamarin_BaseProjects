using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Bitmap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageVideoDataLoadProvider']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/ImageVideoDataLoadProvider", DoNotGenerateAcw=true)]
	public partial class ImageVideoDataLoadProvider : global::Java.Lang.Object, global::Com.Bumptech.Glide.Provider.IDataLoadProvider {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/ImageVideoDataLoadProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageVideoDataLoadProvider); }
		}

		protected ImageVideoDataLoadProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_provider_DataLoadProvider_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageVideoDataLoadProvider']/constructor[@name='ImageVideoDataLoadProvider' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.provider.DataLoadProvider&lt;java.io.InputStream, android.graphics.Bitmap&gt;'] and parameter[2][@type='com.bumptech.glide.provider.DataLoadProvider&lt;android.os.ParcelFileDescriptor, android.graphics.Bitmap&gt;']]"
		[Register (".ctor", "(Lcom/bumptech/glide/provider/DataLoadProvider;Lcom/bumptech/glide/provider/DataLoadProvider;)V", "")]
		public unsafe ImageVideoDataLoadProvider (global::Com.Bumptech.Glide.Provider.IDataLoadProvider p0, global::Com.Bumptech.Glide.Provider.IDataLoadProvider p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ImageVideoDataLoadProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/provider/DataLoadProvider;Lcom/bumptech/glide/provider/DataLoadProvider;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/provider/DataLoadProvider;Lcom/bumptech/glide/provider/DataLoadProvider;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_provider_DataLoadProvider_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_provider_DataLoadProvider_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/provider/DataLoadProvider;Lcom/bumptech/glide/provider/DataLoadProvider;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_provider_DataLoadProvider_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_provider_DataLoadProvider_, __args);
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
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageVideoDataLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageVideoDataLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CacheDecoder);
		}
#pragma warning restore 0169

		static IntPtr id_getCacheDecoder;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IResourceDecoder CacheDecoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageVideoDataLoadProvider']/method[@name='getCacheDecoder' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageVideoDataLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageVideoDataLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Encoder);
		}
#pragma warning restore 0169

		static IntPtr id_getEncoder;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IResourceEncoder Encoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageVideoDataLoadProvider']/method[@name='getEncoder' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageVideoDataLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageVideoDataLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceDecoder);
		}
#pragma warning restore 0169

		static IntPtr id_getSourceDecoder;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IResourceDecoder SourceDecoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageVideoDataLoadProvider']/method[@name='getSourceDecoder' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageVideoDataLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageVideoDataLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceEncoder);
		}
#pragma warning restore 0169

		static IntPtr id_getSourceEncoder;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IEncoder SourceEncoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageVideoDataLoadProvider']/method[@name='getSourceEncoder' and count(parameter)=0]"
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

	}
}
