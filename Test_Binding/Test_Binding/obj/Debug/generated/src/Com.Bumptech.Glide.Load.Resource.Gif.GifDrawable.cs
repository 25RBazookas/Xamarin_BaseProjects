using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Gif {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/gif/GifDrawable", DoNotGenerateAcw=true)]
	public partial class GifDrawable : global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable.GifState']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/gif/GifDrawable$GifState", DoNotGenerateAcw=true)]
		public partial class GifState : global::Android.Graphics.Drawables.Drawable.ConstantState {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/resource/gif/GifDrawable$GifState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GifState); }
			}

			protected GifState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayBLandroid_content_Context_Lcom_bumptech_glide_load_Transformation_IILcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable.GifState']/constructor[@name='GifDrawable.GifState' and count(parameter)=9 and parameter[1][@type='com.bumptech.glide.gifdecoder.GifHeader'] and parameter[2][@type='byte[]'] and parameter[3][@type='android.content.Context'] and parameter[4][@type='com.bumptech.glide.load.Transformation&lt;android.graphics.Bitmap&gt;'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='com.bumptech.glide.gifdecoder.GifDecoder.BitmapProvider'] and parameter[8][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool'] and parameter[9][@type='android.graphics.Bitmap']]"
			[Register (".ctor", "(Lcom/bumptech/glide/gifdecoder/GifHeader;[BLandroid/content/Context;Lcom/bumptech/glide/load/Transformation;IILcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;)V", "")]
			public unsafe GifState (global::Com.Bumptech.Glide.Gifdecoder.GifHeader p0, byte[] p1, global::Android.Content.Context p2, global::Com.Bumptech.Glide.Load.ITransformation p3, int p4, int p5, global::Com.Bumptech.Glide.Gifdecoder.GifDecoder.IBitmapProvider p6, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p7, global::Android.Graphics.Bitmap p8)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [9];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					__args [5] = new JValue (p5);
					__args [6] = new JValue (p6);
					__args [7] = new JValue (p7);
					__args [8] = new JValue (p8);
					if (GetType () != typeof (GifState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/gifdecoder/GifHeader;[BLandroid/content/Context;Lcom/bumptech/glide/load/Transformation;IILcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/gifdecoder/GifHeader;[BLandroid/content/Context;Lcom/bumptech/glide/load/Transformation;IILcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;)V", __args);
						return;
					}

					if (id_ctor_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayBLandroid_content_Context_Lcom_bumptech_glide_load_Transformation_IILcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_ == IntPtr.Zero)
						id_ctor_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayBLandroid_content_Context_Lcom_bumptech_glide_load_Transformation_IILcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/gifdecoder/GifHeader;[BLandroid/content/Context;Lcom/bumptech/glide/load/Transformation;IILcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayBLandroid_content_Context_Lcom_bumptech_glide_load_Transformation_IILcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayBLandroid_content_Context_Lcom_bumptech_glide_load_Transformation_IILcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_, __args);
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static IntPtr id_ctor_Lcom_bumptech_glide_load_resource_gif_GifDrawable_GifState_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable.GifState']/constructor[@name='GifDrawable.GifState' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.resource.gif.GifDrawable.GifState']]"
			[Register (".ctor", "(Lcom/bumptech/glide/load/resource/gif/GifDrawable$GifState;)V", "")]
			public unsafe GifState (global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable.GifState p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (GifState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/resource/gif/GifDrawable$GifState;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/resource/gif/GifDrawable$GifState;)V", __args);
						return;
					}

					if (id_ctor_Lcom_bumptech_glide_load_resource_gif_GifDrawable_GifState_ == IntPtr.Zero)
						id_ctor_Lcom_bumptech_glide_load_resource_gif_GifDrawable_GifState_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/resource/gif/GifDrawable$GifState;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_resource_gif_GifDrawable_GifState_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_resource_gif_GifDrawable_GifState_, __args);
				} finally {
				}
			}

			static Delegate cb_getChangingConfigurations;
#pragma warning disable 0169
			static Delegate GetGetChangingConfigurationsHandler ()
			{
				if (cb_getChangingConfigurations == null)
					cb_getChangingConfigurations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChangingConfigurations);
				return cb_getChangingConfigurations;
			}

			static int n_GetChangingConfigurations (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable.GifState __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable.GifState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return (int) __this.ChangingConfigurations;
			}
#pragma warning restore 0169

			static IntPtr id_getChangingConfigurations;
			public override unsafe global::Android.Content.PM.ConfigChanges ChangingConfigurations {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable.GifState']/method[@name='getChangingConfigurations' and count(parameter)=0]"
				[Register ("getChangingConfigurations", "()I", "GetGetChangingConfigurationsHandler")]
				get {
					if (id_getChangingConfigurations == IntPtr.Zero)
						id_getChangingConfigurations = JNIEnv.GetMethodID (class_ref, "getChangingConfigurations", "()I");
					try {

						if (GetType () == ThresholdType)
							return (global::Android.Content.PM.ConfigChanges) JNIEnv.CallIntMethod  (Handle, id_getChangingConfigurations);
						else
							return (global::Android.Content.PM.ConfigChanges) JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChangingConfigurations", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_newDrawable;
#pragma warning disable 0169
			static Delegate GetNewDrawableHandler ()
			{
				if (cb_newDrawable == null)
					cb_newDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewDrawable);
				return cb_newDrawable;
			}

			static IntPtr n_NewDrawable (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable.GifState __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable.GifState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.NewDrawable ());
			}
#pragma warning restore 0169

			static IntPtr id_newDrawable;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable.GifState']/method[@name='newDrawable' and count(parameter)=0]"
			[Register ("newDrawable", "()Landroid/graphics/drawable/Drawable;", "GetNewDrawableHandler")]
			public override unsafe global::Android.Graphics.Drawables.Drawable NewDrawable ()
			{
				if (id_newDrawable == IntPtr.Zero)
					id_newDrawable = JNIEnv.GetMethodID (class_ref, "newDrawable", "()Landroid/graphics/drawable/Drawable;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_newDrawable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/gif/GifDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifDrawable); }
		}

		protected GifDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_resource_gif_GifDrawable_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_Transformation_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/constructor[@name='GifDrawable' and count(parameter)=3 and parameter[1][@type='com.bumptech.glide.load.resource.gif.GifDrawable'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='com.bumptech.glide.load.Transformation&lt;android.graphics.Bitmap&gt;']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/resource/gif/GifDrawable;Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/Transformation;)V", "")]
		public unsafe GifDrawable (global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable p0, global::Android.Graphics.Bitmap p1, global::Com.Bumptech.Glide.Load.ITransformation p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (GifDrawable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/resource/gif/GifDrawable;Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/Transformation;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/resource/gif/GifDrawable;Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/Transformation;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_resource_gif_GifDrawable_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_Transformation_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_resource_gif_GifDrawable_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_Transformation_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/resource/gif/GifDrawable;Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/Transformation;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_resource_gif_GifDrawable_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_Transformation_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_resource_gif_GifDrawable_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_Transformation_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_Transformation_IILcom_bumptech_glide_gifdecoder_GifHeader_arrayBLandroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/constructor[@name='GifDrawable' and count(parameter)=9 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.bumptech.glide.gifdecoder.GifDecoder.BitmapProvider'] and parameter[3][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool'] and parameter[4][@type='com.bumptech.glide.load.Transformation&lt;android.graphics.Bitmap&gt;'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='com.bumptech.glide.gifdecoder.GifHeader'] and parameter[8][@type='byte[]'] and parameter[9][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/Transformation;IILcom/bumptech/glide/gifdecoder/GifHeader;[BLandroid/graphics/Bitmap;)V", "")]
		public unsafe GifDrawable (global::Android.Content.Context p0, global::Com.Bumptech.Glide.Gifdecoder.GifDecoder.IBitmapProvider p1, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p2, global::Com.Bumptech.Glide.Load.ITransformation p3, int p4, int p5, global::Com.Bumptech.Glide.Gifdecoder.GifHeader p6, byte[] p7, global::Android.Graphics.Bitmap p8)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p7 = JNIEnv.NewArray (p7);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (native_p7);
				__args [8] = new JValue (p8);
				if (GetType () != typeof (GifDrawable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/Transformation;IILcom/bumptech/glide/gifdecoder/GifHeader;[BLandroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/Transformation;IILcom/bumptech/glide/gifdecoder/GifHeader;[BLandroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_Transformation_IILcom_bumptech_glide_gifdecoder_GifHeader_arrayBLandroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_Transformation_IILcom_bumptech_glide_gifdecoder_GifHeader_arrayBLandroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/Transformation;IILcom/bumptech/glide/gifdecoder/GifHeader;[BLandroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_Transformation_IILcom_bumptech_glide_gifdecoder_GifHeader_arrayBLandroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_Transformation_IILcom_bumptech_glide_gifdecoder_GifHeader_arrayBLandroid_graphics_Bitmap_, __args);
			} finally {
				if (p7 != null) {
					JNIEnv.CopyArray (native_p7, p7);
					JNIEnv.DeleteLocalRef (native_p7);
				}
			}
		}

		static Delegate cb_getDecoder;
#pragma warning disable 0169
		static Delegate GetGetDecoderHandler ()
		{
			if (cb_getDecoder == null)
				cb_getDecoder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDecoder);
			return cb_getDecoder;
		}

		static IntPtr n_GetDecoder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Decoder);
		}
#pragma warning restore 0169

		static IntPtr id_getDecoder;
		public virtual unsafe global::Com.Bumptech.Glide.Gifdecoder.GifDecoder Decoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='getDecoder' and count(parameter)=0]"
			[Register ("getDecoder", "()Lcom/bumptech/glide/gifdecoder/GifDecoder;", "GetGetDecoderHandler")]
			get {
				if (id_getDecoder == IntPtr.Zero)
					id_getDecoder = JNIEnv.GetMethodID (class_ref, "getDecoder", "()Lcom/bumptech/glide/gifdecoder/GifDecoder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (JNIEnv.CallObjectMethod  (Handle, id_getDecoder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDecoder", "()Lcom/bumptech/glide/gifdecoder/GifDecoder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFirstFrame;
#pragma warning disable 0169
		static Delegate GetGetFirstFrameHandler ()
		{
			if (cb_getFirstFrame == null)
				cb_getFirstFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirstFrame);
			return cb_getFirstFrame;
		}

		static IntPtr n_GetFirstFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FirstFrame);
		}
#pragma warning restore 0169

		static IntPtr id_getFirstFrame;
		public virtual unsafe global::Android.Graphics.Bitmap FirstFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='getFirstFrame' and count(parameter)=0]"
			[Register ("getFirstFrame", "()Landroid/graphics/Bitmap;", "GetGetFirstFrameHandler")]
			get {
				if (id_getFirstFrame == IntPtr.Zero)
					id_getFirstFrame = JNIEnv.GetMethodID (class_ref, "getFirstFrame", "()Landroid/graphics/Bitmap;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getFirstFrame), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstFrame", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFrameCount;
#pragma warning disable 0169
		static Delegate GetGetFrameCountHandler ()
		{
			if (cb_getFrameCount == null)
				cb_getFrameCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFrameCount);
			return cb_getFrameCount;
		}

		static int n_GetFrameCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrameCount;
		}
#pragma warning restore 0169

		static IntPtr id_getFrameCount;
		public virtual unsafe int FrameCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='getFrameCount' and count(parameter)=0]"
			[Register ("getFrameCount", "()I", "GetGetFrameCountHandler")]
			get {
				if (id_getFrameCount == IntPtr.Zero)
					id_getFrameCount = JNIEnv.GetMethodID (class_ref, "getFrameCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getFrameCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFrameTransformation;
#pragma warning disable 0169
		static Delegate GetGetFrameTransformationHandler ()
		{
			if (cb_getFrameTransformation == null)
				cb_getFrameTransformation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFrameTransformation);
			return cb_getFrameTransformation;
		}

		static IntPtr n_GetFrameTransformation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FrameTransformation);
		}
#pragma warning restore 0169

		static IntPtr id_getFrameTransformation;
		public virtual unsafe global::Com.Bumptech.Glide.Load.ITransformation FrameTransformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='getFrameTransformation' and count(parameter)=0]"
			[Register ("getFrameTransformation", "()Lcom/bumptech/glide/load/Transformation;", "GetGetFrameTransformationHandler")]
			get {
				if (id_getFrameTransformation == IntPtr.Zero)
					id_getFrameTransformation = JNIEnv.GetMethodID (class_ref, "getFrameTransformation", "()Lcom/bumptech/glide/load/Transformation;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.ITransformation> (JNIEnv.CallObjectMethod  (Handle, id_getFrameTransformation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.ITransformation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameTransformation", "()Lcom/bumptech/glide/load/Transformation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAnimated;
#pragma warning disable 0169
		static Delegate GetIsAnimatedHandler ()
		{
			if (cb_isAnimated == null)
				cb_isAnimated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAnimated);
			return cb_isAnimated;
		}

		static bool n_IsAnimated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnimated;
		}
#pragma warning restore 0169

		static IntPtr id_isAnimated;
		public override unsafe bool IsAnimated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='isAnimated' and count(parameter)=0]"
			[Register ("isAnimated", "()Z", "GetIsAnimatedHandler")]
			get {
				if (id_isAnimated == IntPtr.Zero)
					id_isAnimated = JNIEnv.GetMethodID (class_ref, "isAnimated", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isAnimated);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAnimated", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		static IntPtr id_isRunning;
		public override unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isRunning);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRunning", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getOpacity;
#pragma warning disable 0169
		static Delegate GetGetOpacityHandler ()
		{
			if (cb_getOpacity == null)
				cb_getOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOpacity);
			return cb_getOpacity;
		}

		static int n_GetOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		static IntPtr id_getOpacity;
		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='getOpacity' and count(parameter)=0]"
			[Register ("getOpacity", "()I", "GetGetOpacityHandler")]
			get {
				if (id_getOpacity == IntPtr.Zero)
					id_getOpacity = JNIEnv.GetMethodID (class_ref, "getOpacity", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getOpacity);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpacity", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas p0)
		{
			if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetData ());
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[B", "GetGetDataHandler")]
		public virtual unsafe byte[] GetData ()
		{
			if (id_getData == IntPtr.Zero)
				id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getData), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_onFrameReady_I;
#pragma warning disable 0169
		static Delegate GetOnFrameReady_IHandler ()
		{
			if (cb_onFrameReady_I == null)
				cb_onFrameReady_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnFrameReady_I);
			return cb_onFrameReady_I;
		}

		static void n_OnFrameReady_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFrameReady (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onFrameReady_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='onFrameReady' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onFrameReady", "(I)V", "GetOnFrameReady_IHandler")]
		public virtual unsafe void OnFrameReady (int p0)
		{
			if (id_onFrameReady_I == IntPtr.Zero)
				id_onFrameReady_I = JNIEnv.GetMethodID (class_ref, "onFrameReady", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onFrameReady_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFrameReady", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_recycle;
#pragma warning disable 0169
		static Delegate GetRecycleHandler ()
		{
			if (cb_recycle == null)
				cb_recycle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Recycle);
			return cb_recycle;
		}

		static void n_Recycle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler")]
		public virtual unsafe void Recycle ()
		{
			if (id_recycle == IntPtr.Zero)
				id_recycle = JNIEnv.GetMethodID (class_ref, "recycle", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_recycle);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recycle", "()V"));
			} finally {
			}
		}

		static Delegate cb_setAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetAlpha_IHandler ()
		{
			if (cb_setAlpha_I == null)
				cb_setAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAlpha_I);
			return cb_setAlpha_I;
		}

		static void n_SetAlpha_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAlpha_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public override unsafe void SetAlpha (int p0)
		{
			if (id_setAlpha_I == IntPtr.Zero)
				id_setAlpha_I = JNIEnv.GetMethodID (class_ref, "setAlpha", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAlpha_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlpha", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;
#pragma warning disable 0169
		static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler ()
		{
			if (cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
				cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorFilter_Landroid_graphics_ColorFilter_);
			return cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		static void n_SetColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColorFilter_Landroid_graphics_ColorFilter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public override unsafe void SetColorFilter (global::Android.Graphics.ColorFilter p0)
		{
			if (id_setColorFilter_Landroid_graphics_ColorFilter_ == IntPtr.Zero)
				id_setColorFilter_Landroid_graphics_ColorFilter_ = JNIEnv.GetMethodID (class_ref, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setColorFilter_Landroid_graphics_ColorFilter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_ == null)
				cb_setFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_);
			return cb_setFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_;
		}

		static void n_SetFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.ITransformation p0 = (global::Com.Bumptech.Glide.Load.ITransformation)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.ITransformation> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetFrameTransformation (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='setFrameTransformation' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.Transformation&lt;android.graphics.Bitmap&gt;'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("setFrameTransformation", "(Lcom/bumptech/glide/load/Transformation;Landroid/graphics/Bitmap;)V", "GetSetFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetFrameTransformation (global::Com.Bumptech.Glide.Load.ITransformation p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_setFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setFrameTransformation", "(Lcom/bumptech/glide/load/Transformation;Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFrameTransformation", "(Lcom/bumptech/glide/load/Transformation;Landroid/graphics/Bitmap;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLoopCount_I;
#pragma warning disable 0169
		static Delegate GetSetLoopCount_IHandler ()
		{
			if (cb_setLoopCount_I == null)
				cb_setLoopCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLoopCount_I);
			return cb_setLoopCount_I;
		}

		static void n_SetLoopCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLoopCount (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLoopCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='setLoopCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLoopCount", "(I)V", "GetSetLoopCount_IHandler")]
		public override unsafe void SetLoopCount (int p0)
		{
			if (id_setLoopCount_I == IntPtr.Zero)
				id_setLoopCount_I = JNIEnv.GetMethodID (class_ref, "setLoopCount", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLoopCount_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLoopCount", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public override unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawable']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public override unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
