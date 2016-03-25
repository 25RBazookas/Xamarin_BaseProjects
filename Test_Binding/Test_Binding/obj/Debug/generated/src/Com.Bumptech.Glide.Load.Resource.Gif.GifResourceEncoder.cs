using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Gif {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceEncoder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/gif/GifResourceEncoder", DoNotGenerateAcw=true)]
	public partial class GifResourceEncoder : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.IResourceEncoder {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceEncoder.Factory']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/gif/GifResourceEncoder$Factory", DoNotGenerateAcw=true)]
		public partial class Factory : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/resource/gif/GifResourceEncoder$Factory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Factory); }
			}

			protected Factory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_buildDecoder_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_;
#pragma warning disable 0169
			static Delegate GetBuildDecoder_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_Handler ()
			{
				if (cb_buildDecoder_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_ == null)
					cb_buildDecoder_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildDecoder_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_);
				return cb_buildDecoder_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_;
			}

			static IntPtr n_BuildDecoder_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceEncoder.Factory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceEncoder.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Bumptech.Glide.Gifdecoder.GifDecoder.IBitmapProvider p0 = (global::Com.Bumptech.Glide.Gifdecoder.GifDecoder.IBitmapProvider)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder.IBitmapProvider> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildDecoder (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_buildDecoder_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceEncoder.Factory']/method[@name='buildDecoder' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.gifdecoder.GifDecoder.BitmapProvider']]"
			[Register ("buildDecoder", "(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;)Lcom/bumptech/glide/gifdecoder/GifDecoder;", "GetBuildDecoder_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_Handler")]
			public virtual unsafe global::Com.Bumptech.Glide.Gifdecoder.GifDecoder BuildDecoder (global::Com.Bumptech.Glide.Gifdecoder.GifDecoder.IBitmapProvider p0)
			{
				if (id_buildDecoder_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_ == IntPtr.Zero)
					id_buildDecoder_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_ = JNIEnv.GetMethodID (class_ref, "buildDecoder", "(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;)Lcom/bumptech/glide/gifdecoder/GifDecoder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (JNIEnv.CallObjectMethod  (Handle, id_buildDecoder_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildDecoder", "(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;)Lcom/bumptech/glide/gifdecoder/GifDecoder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_buildEncoder;
#pragma warning disable 0169
			static Delegate GetBuildEncoderHandler ()
			{
				if (cb_buildEncoder == null)
					cb_buildEncoder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildEncoder);
				return cb_buildEncoder;
			}

			static IntPtr n_BuildEncoder (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceEncoder.Factory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceEncoder.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BuildEncoder ());
			}
#pragma warning restore 0169

			static IntPtr id_buildEncoder;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceEncoder.Factory']/method[@name='buildEncoder' and count(parameter)=0]"
			[Register ("buildEncoder", "()Lcom/bumptech/glide/gifencoder/AnimatedGifEncoder;", "GetBuildEncoderHandler")]
			public virtual unsafe global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder BuildEncoder ()
			{
				if (id_buildEncoder == IntPtr.Zero)
					id_buildEncoder = JNIEnv.GetMethodID (class_ref, "buildEncoder", "()Lcom/bumptech/glide/gifencoder/AnimatedGifEncoder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder> (JNIEnv.CallObjectMethod  (Handle, id_buildEncoder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildEncoder", "()Lcom/bumptech/glide/gifencoder/AnimatedGifEncoder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_buildFrameResource_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_;
#pragma warning disable 0169
			static Delegate GetBuildFrameResource_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Handler ()
			{
				if (cb_buildFrameResource_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ == null)
					cb_buildFrameResource_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildFrameResource_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_);
				return cb_buildFrameResource_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_;
			}

			static IntPtr n_BuildFrameResource_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceEncoder.Factory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceEncoder.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1 = (global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildFrameResource (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_buildFrameResource_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceEncoder.Factory']/method[@name='buildFrameResource' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool']]"
			[Register ("buildFrameResource", "(Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/load/engine/Resource;", "GetBuildFrameResource_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Handler")]
			public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.IResource BuildFrameResource (global::Android.Graphics.Bitmap p0, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1)
			{
				if (id_buildFrameResource_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ == IntPtr.Zero)
					id_buildFrameResource_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ = JNIEnv.GetMethodID (class_ref, "buildFrameResource", "(Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/load/engine/Resource;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Com.Bumptech.Glide.Load.Engine.IResource __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod  (Handle, id_buildFrameResource_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildFrameResource", "(Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/load/engine/Resource;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_buildParser;
#pragma warning disable 0169
			static Delegate GetBuildParserHandler ()
			{
				if (cb_buildParser == null)
					cb_buildParser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildParser);
				return cb_buildParser;
			}

			static IntPtr n_BuildParser (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceEncoder.Factory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceEncoder.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BuildParser ());
			}
#pragma warning restore 0169

			static IntPtr id_buildParser;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceEncoder.Factory']/method[@name='buildParser' and count(parameter)=0]"
			[Register ("buildParser", "()Lcom/bumptech/glide/gifdecoder/GifHeaderParser;", "GetBuildParserHandler")]
			public virtual unsafe global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser BuildParser ()
			{
				if (id_buildParser == IntPtr.Zero)
					id_buildParser = JNIEnv.GetMethodID (class_ref, "buildParser", "()Lcom/bumptech/glide/gifdecoder/GifHeaderParser;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser> (JNIEnv.CallObjectMethod  (Handle, id_buildParser), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildParser", "()Lcom/bumptech/glide/gifdecoder/GifHeaderParser;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/gif/GifResourceEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifResourceEncoder); }
		}

		protected GifResourceEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceEncoder']/constructor[@name='GifResourceEncoder' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", "")]
		public unsafe GifResourceEncoder (global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GifResourceEncoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_, __args);
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
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceEncoder']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_Handler ()
		{
			if (cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_ == null)
				cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_);
			return cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_;
		}

		static bool n_Encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p0 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Encode (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceEncoder']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.engine.Resource&lt;com.bumptech.glide.load.resource.gif.GifDrawable&gt;'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("encode", "(Lcom/bumptech/glide/load/engine/Resource;Ljava/io/OutputStream;)Z", "GetEncode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_Handler")]
		public virtual unsafe bool Encode (global::Com.Bumptech.Glide.Load.Engine.IResource p0, global::System.IO.Stream p1)
		{
			if (id_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(Lcom/bumptech/glide/load/engine/Resource;Ljava/io/OutputStream;)Z");
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Lcom/bumptech/glide/load/engine/Resource;Ljava/io/OutputStream;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
