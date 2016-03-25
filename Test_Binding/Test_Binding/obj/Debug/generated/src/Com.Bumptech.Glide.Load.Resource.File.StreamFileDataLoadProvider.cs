using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.File {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.file']/class[@name='StreamFileDataLoadProvider']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/file/StreamFileDataLoadProvider", DoNotGenerateAcw=true)]
	public partial class StreamFileDataLoadProvider : global::Java.Lang.Object, global::Com.Bumptech.Glide.Provider.IDataLoadProvider {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.file']/class[@name='StreamFileDataLoadProvider.ErrorSourceDecoder']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/file/StreamFileDataLoadProvider$ErrorSourceDecoder", DoNotGenerateAcw=true)]
		public partial class ErrorSourceDecoder : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.IResourceDecoder {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/resource/file/StreamFileDataLoadProvider$ErrorSourceDecoder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ErrorSourceDecoder); }
			}

			protected ErrorSourceDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Bumptech.Glide.Load.Resource.File.StreamFileDataLoadProvider.ErrorSourceDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.File.StreamFileDataLoadProvider.ErrorSourceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Id);
			}
#pragma warning restore 0169

			static IntPtr id_getId;
			public virtual unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.file']/class[@name='StreamFileDataLoadProvider.ErrorSourceDecoder']/method[@name='getId' and count(parameter)=0]"
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

			static Delegate cb_decode_Ljava_io_InputStream_II;
#pragma warning disable 0169
			static Delegate GetDecode_Ljava_io_InputStream_IIHandler ()
			{
				if (cb_decode_Ljava_io_InputStream_II == null)
					cb_decode_Ljava_io_InputStream_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Decode_Ljava_io_InputStream_II);
				return cb_decode_Ljava_io_InputStream_II;
			}

			static IntPtr n_Decode_Ljava_io_InputStream_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				global::Com.Bumptech.Glide.Load.Resource.File.StreamFileDataLoadProvider.ErrorSourceDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.File.StreamFileDataLoadProvider.ErrorSourceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_decode_Ljava_io_InputStream_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.file']/class[@name='StreamFileDataLoadProvider.ErrorSourceDecoder']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("decode", "(Ljava/io/InputStream;II)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Ljava_io_InputStream_IIHandler")]
			public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Decode (global::System.IO.Stream p0, int p1, int p2)
			{
				if (id_decode_Ljava_io_InputStream_II == IntPtr.Zero)
					id_decode_Ljava_io_InputStream_II = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/io/InputStream;II)Lcom/bumptech/glide/load/engine/Resource;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					global::Com.Bumptech.Glide.Load.Engine.IResource __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod  (Handle, id_decode_Ljava_io_InputStream_II, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/io/InputStream;II)Lcom/bumptech/glide/load/engine/Resource;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_decode_Ljava_lang_Object_II;
#pragma warning disable 0169
			static Delegate GetDecode_Ljava_lang_Object_IIHandler ()
			{
				if (cb_decode_Ljava_lang_Object_II == null)
					cb_decode_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Decode_Ljava_lang_Object_II);
				return cb_decode_Ljava_lang_Object_II;
			}

			static IntPtr n_Decode_Ljava_lang_Object_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				global::Com.Bumptech.Glide.Load.Resource.File.StreamFileDataLoadProvider.ErrorSourceDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.File.StreamFileDataLoadProvider.ErrorSourceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_decode_Ljava_lang_Object_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.file']/class[@name='StreamFileDataLoadProvider.ErrorSourceDecoder']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("decode", "(Ljava/lang/Object;II)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Ljava_lang_Object_IIHandler")]
			public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Decode (global::Java.Lang.Object p0, int p1, int p2)
			{
				if (id_decode_Ljava_lang_Object_II == IntPtr.Zero)
					id_decode_Ljava_lang_Object_II = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/Object;II)Lcom/bumptech/glide/load/engine/Resource;");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					global::Com.Bumptech.Glide.Load.Engine.IResource __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod  (Handle, id_decode_Ljava_lang_Object_II, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/lang/Object;II)Lcom/bumptech/glide/load/engine/Resource;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.IResourceDecoder
			global::Com.Bumptech.Glide.Load.Engine.IResource global::Com.Bumptech.Glide.Load.IResourceDecoder.Decode (global::Java.Lang.Object p0, int p1, int p2)
			{
				return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Bumptech.Glide.Load.Engine.IResource>(Decode (global::Java.Interop.JavaObjectExtensions.JavaCast<global::System.IO.Stream>(p0), p1, p2));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/file/StreamFileDataLoadProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StreamFileDataLoadProvider); }
		}

		protected StreamFileDataLoadProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.file']/class[@name='StreamFileDataLoadProvider']/constructor[@name='StreamFileDataLoadProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StreamFileDataLoadProvider ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StreamFileDataLoadProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
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
			global::Com.Bumptech.Glide.Load.Resource.File.StreamFileDataLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.File.StreamFileDataLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CacheDecoder);
		}
#pragma warning restore 0169

		static IntPtr id_getCacheDecoder;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IResourceDecoder CacheDecoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.file']/class[@name='StreamFileDataLoadProvider']/method[@name='getCacheDecoder' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Load.Resource.File.StreamFileDataLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.File.StreamFileDataLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Encoder);
		}
#pragma warning restore 0169

		static IntPtr id_getEncoder;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IResourceEncoder Encoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.file']/class[@name='StreamFileDataLoadProvider']/method[@name='getEncoder' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Load.Resource.File.StreamFileDataLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.File.StreamFileDataLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceDecoder);
		}
#pragma warning restore 0169

		static IntPtr id_getSourceDecoder;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IResourceDecoder SourceDecoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.file']/class[@name='StreamFileDataLoadProvider']/method[@name='getSourceDecoder' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Load.Resource.File.StreamFileDataLoadProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.File.StreamFileDataLoadProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceEncoder);
		}
#pragma warning restore 0169

		static IntPtr id_getSourceEncoder;
		public virtual unsafe global::Com.Bumptech.Glide.Load.IEncoder SourceEncoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.file']/class[@name='StreamFileDataLoadProvider']/method[@name='getSourceEncoder' and count(parameter)=0]"
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
