using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Provider {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.provider']/interface[@name='DataLoadProvider']"
	[Register ("com/bumptech/glide/provider/DataLoadProvider", "", "Com.Bumptech.Glide.Provider.IDataLoadProviderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Z"})]
	public partial interface IDataLoadProvider : IJavaObject {

		global::Com.Bumptech.Glide.Load.IResourceDecoder CacheDecoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/interface[@name='DataLoadProvider']/method[@name='getCacheDecoder' and count(parameter)=0]"
			[Register ("getCacheDecoder", "()Lcom/bumptech/glide/load/ResourceDecoder;", "GetGetCacheDecoderHandler:Com.Bumptech.Glide.Provider.IDataLoadProviderInvoker, Test_Binding")] get;
		}

		global::Com.Bumptech.Glide.Load.IResourceEncoder Encoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/interface[@name='DataLoadProvider']/method[@name='getEncoder' and count(parameter)=0]"
			[Register ("getEncoder", "()Lcom/bumptech/glide/load/ResourceEncoder;", "GetGetEncoderHandler:Com.Bumptech.Glide.Provider.IDataLoadProviderInvoker, Test_Binding")] get;
		}

		global::Com.Bumptech.Glide.Load.IResourceDecoder SourceDecoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/interface[@name='DataLoadProvider']/method[@name='getSourceDecoder' and count(parameter)=0]"
			[Register ("getSourceDecoder", "()Lcom/bumptech/glide/load/ResourceDecoder;", "GetGetSourceDecoderHandler:Com.Bumptech.Glide.Provider.IDataLoadProviderInvoker, Test_Binding")] get;
		}

		global::Com.Bumptech.Glide.Load.IEncoder SourceEncoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.provider']/interface[@name='DataLoadProvider']/method[@name='getSourceEncoder' and count(parameter)=0]"
			[Register ("getSourceEncoder", "()Lcom/bumptech/glide/load/Encoder;", "GetGetSourceEncoderHandler:Com.Bumptech.Glide.Provider.IDataLoadProviderInvoker, Test_Binding")] get;
		}

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/provider/DataLoadProvider", DoNotGenerateAcw=true)]
	internal class IDataLoadProviderInvoker : global::Java.Lang.Object, IDataLoadProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/provider/DataLoadProvider");
		IntPtr class_ref;

		public static IDataLoadProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataLoadProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.provider.DataLoadProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataLoadProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDataLoadProviderInvoker); }
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
			global::Com.Bumptech.Glide.Provider.IDataLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.IDataLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Provider.IDataLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.IDataLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Provider.IDataLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.IDataLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Provider.IDataLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.IDataLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
