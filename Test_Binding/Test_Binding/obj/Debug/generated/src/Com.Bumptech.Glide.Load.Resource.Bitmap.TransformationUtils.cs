using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Bitmap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='TransformationUtils']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/TransformationUtils", DoNotGenerateAcw=true)]
	public sealed partial class TransformationUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='TransformationUtils']/field[@name='PAINT_FLAGS']"
		[Register ("PAINT_FLAGS")]
		public const int PaintFlags = (int) 6;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/TransformationUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TransformationUtils); }
		}

		internal TransformationUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_centerCrop_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='TransformationUtils']/method[@name='centerCrop' and count(parameter)=4 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("centerCrop", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CenterCrop (global::Android.Graphics.Bitmap p0, global::Android.Graphics.Bitmap p1, int p2, int p3)
		{
			if (id_centerCrop_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_II == IntPtr.Zero)
				id_centerCrop_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_II = JNIEnv.GetStaticMethodID (class_ref, "centerCrop", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_centerCrop_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fitCenter_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='TransformationUtils']/method[@name='fitCenter' and count(parameter)=4 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("fitCenter", "(Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap FitCenter (global::Android.Graphics.Bitmap p0, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1, int p2, int p3)
		{
			if (id_fitCenter_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_II == IntPtr.Zero)
				id_fitCenter_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_II = JNIEnv.GetStaticMethodID (class_ref, "fitCenter", "(Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;II)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fitCenter_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getExifOrientationDegrees_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='TransformationUtils']/method[@name='getExifOrientationDegrees' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getExifOrientationDegrees", "(I)I", "")]
		public static unsafe int GetExifOrientationDegrees (int p0)
		{
			if (id_getExifOrientationDegrees_I == IntPtr.Zero)
				id_getExifOrientationDegrees_I = JNIEnv.GetStaticMethodID (class_ref, "getExifOrientationDegrees", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getExifOrientationDegrees_I, __args);
			} finally {
			}
		}

		static IntPtr id_getOrientation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='TransformationUtils']/method[@name='getOrientation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("getOrientation", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetOrientation (string p0)
		{
			if (id_getOrientation_Ljava_lang_String_ == IntPtr.Zero)
				id_getOrientation_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getOrientation", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getOrientation_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_orientImage_Ljava_lang_String_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='TransformationUtils']/method[@name='orientImage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Obsolete (@"deprecated")]
		[Register ("orientImage", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap OrientImage (string p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_orientImage_Ljava_lang_String_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_orientImage_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "orientImage", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_orientImage_Ljava_lang_String_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_rotateImage_Landroid_graphics_Bitmap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='TransformationUtils']/method[@name='rotateImage' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("rotateImage", "(Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap RotateImage (global::Android.Graphics.Bitmap p0, int p1)
		{
			if (id_rotateImage_Landroid_graphics_Bitmap_I == IntPtr.Zero)
				id_rotateImage_Landroid_graphics_Bitmap_I = JNIEnv.GetStaticMethodID (class_ref, "rotateImage", "(Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_rotateImage_Landroid_graphics_Bitmap_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_rotateImageExif_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='TransformationUtils']/method[@name='rotateImageExif' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool'] and parameter[3][@type='int']]"
		[Register ("rotateImageExif", "(Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap RotateImageExif (global::Android.Graphics.Bitmap p0, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1, int p2)
		{
			if (id_rotateImageExif_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_I == IntPtr.Zero)
				id_rotateImageExif_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_I = JNIEnv.GetStaticMethodID (class_ref, "rotateImageExif", "(Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;I)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_rotateImageExif_Landroid_graphics_Bitmap_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setAlpha_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='TransformationUtils']/method[@name='setAlpha' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("setAlpha", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", "")]
		public static unsafe void SetAlpha (global::Android.Graphics.Bitmap p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_setAlpha_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setAlpha_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "setAlpha", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAlpha_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

	}
}
