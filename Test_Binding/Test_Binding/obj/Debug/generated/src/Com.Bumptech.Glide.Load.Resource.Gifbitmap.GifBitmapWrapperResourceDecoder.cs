using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Gifbitmap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapperResourceDecoder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/gifbitmap/GifBitmapWrapperResourceDecoder", DoNotGenerateAcw=true)]
	public partial class GifBitmapWrapperResourceDecoder : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.IResourceDecoder {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapperResourceDecoder.BufferedStreamFactory']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/gifbitmap/GifBitmapWrapperResourceDecoder$BufferedStreamFactory", DoNotGenerateAcw=true)]
		public partial class BufferedStreamFactory : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/resource/gifbitmap/GifBitmapWrapperResourceDecoder$BufferedStreamFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BufferedStreamFactory); }
			}

			protected BufferedStreamFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_build_Ljava_io_InputStream_arrayB;
#pragma warning disable 0169
			static Delegate GetBuild_Ljava_io_InputStream_arrayBHandler ()
			{
				if (cb_build_Ljava_io_InputStream_arrayB == null)
					cb_build_Ljava_io_InputStream_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Build_Ljava_io_InputStream_arrayB);
				return cb_build_Ljava_io_InputStream_arrayB;
			}

			static IntPtr n_Build_Ljava_io_InputStream_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapperResourceDecoder.BufferedStreamFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapperResourceDecoder.BufferedStreamFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Build (p0, p1));
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_build_Ljava_io_InputStream_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapperResourceDecoder.BufferedStreamFactory']/method[@name='build' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='byte[]']]"
			[Register ("build", "(Ljava/io/InputStream;[B)Ljava/io/InputStream;", "GetBuild_Ljava_io_InputStream_arrayBHandler")]
			public virtual unsafe global::System.IO.Stream Build (global::System.IO.Stream p0, byte[] p1)
			{
				if (id_build_Ljava_io_InputStream_arrayB == IntPtr.Zero)
					id_build_Ljava_io_InputStream_arrayB = JNIEnv.GetMethodID (class_ref, "build", "(Ljava/io/InputStream;[B)Ljava/io/InputStream;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);

					global::System.IO.Stream __ret;
					if (GetType () == ThresholdType)
						__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_build_Ljava_io_InputStream_arrayB, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "(Ljava/io/InputStream;[B)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapperResourceDecoder.ImageTypeParser']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/gifbitmap/GifBitmapWrapperResourceDecoder$ImageTypeParser", DoNotGenerateAcw=true)]
		public partial class ImageTypeParser : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/resource/gifbitmap/GifBitmapWrapperResourceDecoder$ImageTypeParser", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ImageTypeParser); }
			}

			protected ImageTypeParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_parse_Ljava_io_InputStream_;
#pragma warning disable 0169
			static Delegate GetParse_Ljava_io_InputStream_Handler ()
			{
				if (cb_parse_Ljava_io_InputStream_ == null)
					cb_parse_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Parse_Ljava_io_InputStream_);
				return cb_parse_Ljava_io_InputStream_;
			}

			static IntPtr n_Parse_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapperResourceDecoder.ImageTypeParser __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapperResourceDecoder.ImageTypeParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_parse_Ljava_io_InputStream_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapperResourceDecoder.ImageTypeParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("parse", "(Ljava/io/InputStream;)Lcom/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType;", "GetParse_Ljava_io_InputStream_Handler")]
			public virtual unsafe global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType Parse (global::System.IO.Stream p0)
			{
				if (id_parse_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parse_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/io/InputStream;)Lcom/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType> (JNIEnv.CallObjectMethod  (Handle, id_parse_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Ljava/io/InputStream;)Lcom/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/gifbitmap/GifBitmapWrapperResourceDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifBitmapWrapperResourceDecoder); }
		}

		protected GifBitmapWrapperResourceDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_ResourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapperResourceDecoder']/constructor[@name='GifBitmapWrapperResourceDecoder' and count(parameter)=3 and parameter[1][@type='com.bumptech.glide.load.ResourceDecoder&lt;com.bumptech.glide.load.model.ImageVideoWrapper, android.graphics.Bitmap&gt;'] and parameter[2][@type='com.bumptech.glide.load.ResourceDecoder&lt;java.io.InputStream, com.bumptech.glide.load.resource.gif.GifDrawable&gt;'] and parameter[3][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/ResourceDecoder;Lcom/bumptech/glide/load/ResourceDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", "")]
		public unsafe GifBitmapWrapperResourceDecoder (global::Com.Bumptech.Glide.Load.IResourceDecoder p0, global::Com.Bumptech.Glide.Load.IResourceDecoder p1, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (GifBitmapWrapperResourceDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/ResourceDecoder;Lcom/bumptech/glide/load/ResourceDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/ResourceDecoder;Lcom/bumptech/glide/load/ResourceDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_ResourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_ResourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/ResourceDecoder;Lcom/bumptech/glide/load/ResourceDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_ResourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_ResourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_, __args);
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
			global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapperResourceDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapperResourceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapperResourceDecoder']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II;
#pragma warning disable 0169
		static Delegate GetDecode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_IIHandler ()
		{
			if (cb_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II == null)
				cb_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II);
			return cb_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II;
		}

		static IntPtr n_Decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapperResourceDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapperResourceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapperResourceDecoder']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='com.bumptech.glide.load.model.ImageVideoWrapper'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("decode", "(Lcom/bumptech/glide/load/model/ImageVideoWrapper;II)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Decode (global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper p0, int p1, int p2)
		{
			if (id_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II == IntPtr.Zero)
				id_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/bumptech/glide/load/model/ImageVideoWrapper;II)Lcom/bumptech/glide/load/engine/Resource;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Bumptech.Glide.Load.Engine.IResource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod  (Handle, id_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Lcom/bumptech/glide/load/model/ImageVideoWrapper;II)Lcom/bumptech/glide/load/engine/Resource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.IResourceDecoder
		global::Com.Bumptech.Glide.Load.Engine.IResource global::Com.Bumptech.Glide.Load.IResourceDecoder.Decode (global::Java.Lang.Object p0, int p1, int p2)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Bumptech.Glide.Load.Engine.IResource>(Decode (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper>(p0), p1, p2));
		}

	}
}
