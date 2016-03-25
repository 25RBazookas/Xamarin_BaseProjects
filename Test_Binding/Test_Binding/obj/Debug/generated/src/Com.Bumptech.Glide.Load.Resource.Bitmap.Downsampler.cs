using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Bitmap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='Downsampler']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/Downsampler", DoNotGenerateAcw=true)]
	public abstract partial class Downsampler : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Resource.Bitmap.IBitmapDecoder {


		static IntPtr AT_LEAST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='Downsampler']/field[@name='AT_LEAST']"
		[Register ("AT_LEAST")]
		public static global::Com.Bumptech.Glide.Load.Resource.Bitmap.Downsampler AtLeast {
			get {
				if (AT_LEAST_jfieldId == IntPtr.Zero)
					AT_LEAST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AT_LEAST", "Lcom/bumptech/glide/load/resource/bitmap/Downsampler;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AT_LEAST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.Downsampler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AT_MOST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='Downsampler']/field[@name='AT_MOST']"
		[Register ("AT_MOST")]
		public static global::Com.Bumptech.Glide.Load.Resource.Bitmap.Downsampler AtMost {
			get {
				if (AT_MOST_jfieldId == IntPtr.Zero)
					AT_MOST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AT_MOST", "Lcom/bumptech/glide/load/resource/bitmap/Downsampler;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AT_MOST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.Downsampler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='Downsampler']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Bumptech.Glide.Load.Resource.Bitmap.Downsampler None {
			get {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/bumptech/glide/load/resource/bitmap/Downsampler;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.Downsampler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/Downsampler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Downsampler); }
		}

		protected Downsampler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='Downsampler']/constructor[@name='Downsampler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Downsampler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Downsampler)) {
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

		static Delegate cb_decode_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_Handler ()
		{
			if (cb_decode_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_ == null)
				cb_decode_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_Decode_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_);
			return cb_decode_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_;
		}

		static IntPtr n_Decode_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, IntPtr native_p4)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.Downsampler __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.Downsampler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1 = (global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.DecodeFormat p4 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.DecodeFormat> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='Downsampler']/method[@name='decode' and count(parameter)=5 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.bumptech.glide.load.DecodeFormat']]"
		[Register ("decode", "(Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;IILcom/bumptech/glide/load/DecodeFormat;)Landroid/graphics/Bitmap;", "GetDecode_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap Decode (global::System.IO.Stream p0, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1, int p2, int p3, global::Com.Bumptech.Glide.Load.DecodeFormat p4)
		{
			if (id_decode_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_ == IntPtr.Zero)
				id_decode_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;IILcom/bumptech/glide/load/DecodeFormat;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				global::Android.Graphics.Bitmap __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_decode_Ljava_io_InputStream_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;IILcom/bumptech/glide/load/DecodeFormat;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getDimensions_Lcom_bumptech_glide_util_MarkEnforcingInputStream_Lcom_bumptech_glide_load_resource_bitmap_RecyclableBufferedInputStream_Landroid_graphics_BitmapFactory_Options_;
#pragma warning disable 0169
		static Delegate GetGetDimensions_Lcom_bumptech_glide_util_MarkEnforcingInputStream_Lcom_bumptech_glide_load_resource_bitmap_RecyclableBufferedInputStream_Landroid_graphics_BitmapFactory_Options_Handler ()
		{
			if (cb_getDimensions_Lcom_bumptech_glide_util_MarkEnforcingInputStream_Lcom_bumptech_glide_load_resource_bitmap_RecyclableBufferedInputStream_Landroid_graphics_BitmapFactory_Options_ == null)
				cb_getDimensions_Lcom_bumptech_glide_util_MarkEnforcingInputStream_Lcom_bumptech_glide_load_resource_bitmap_RecyclableBufferedInputStream_Landroid_graphics_BitmapFactory_Options_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDimensions_Lcom_bumptech_glide_util_MarkEnforcingInputStream_Lcom_bumptech_glide_load_resource_bitmap_RecyclableBufferedInputStream_Landroid_graphics_BitmapFactory_Options_);
			return cb_getDimensions_Lcom_bumptech_glide_util_MarkEnforcingInputStream_Lcom_bumptech_glide_load_resource_bitmap_RecyclableBufferedInputStream_Landroid_graphics_BitmapFactory_Options_;
		}

		static IntPtr n_GetDimensions_Lcom_bumptech_glide_util_MarkEnforcingInputStream_Lcom_bumptech_glide_load_resource_bitmap_RecyclableBufferedInputStream_Landroid_graphics_BitmapFactory_Options_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.Downsampler __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.Downsampler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Util.MarkEnforcingInputStream p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.MarkEnforcingInputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.RecyclableBufferedInputStream p1 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.RecyclableBufferedInputStream> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.BitmapFactory.Options p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapFactory.Options> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetDimensions (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDimensions_Lcom_bumptech_glide_util_MarkEnforcingInputStream_Lcom_bumptech_glide_load_resource_bitmap_RecyclableBufferedInputStream_Landroid_graphics_BitmapFactory_Options_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='Downsampler']/method[@name='getDimensions' and count(parameter)=3 and parameter[1][@type='com.bumptech.glide.util.MarkEnforcingInputStream'] and parameter[2][@type='com.bumptech.glide.load.resource.bitmap.RecyclableBufferedInputStream'] and parameter[3][@type='android.graphics.BitmapFactory.Options']]"
		[Register ("getDimensions", "(Lcom/bumptech/glide/util/MarkEnforcingInputStream;Lcom/bumptech/glide/load/resource/bitmap/RecyclableBufferedInputStream;Landroid/graphics/BitmapFactory$Options;)[I", "GetGetDimensions_Lcom_bumptech_glide_util_MarkEnforcingInputStream_Lcom_bumptech_glide_load_resource_bitmap_RecyclableBufferedInputStream_Landroid_graphics_BitmapFactory_Options_Handler")]
		public virtual unsafe int[] GetDimensions (global::Com.Bumptech.Glide.Util.MarkEnforcingInputStream p0, global::Com.Bumptech.Glide.Load.Resource.Bitmap.RecyclableBufferedInputStream p1, global::Android.Graphics.BitmapFactory.Options p2)
		{
			if (id_getDimensions_Lcom_bumptech_glide_util_MarkEnforcingInputStream_Lcom_bumptech_glide_load_resource_bitmap_RecyclableBufferedInputStream_Landroid_graphics_BitmapFactory_Options_ == IntPtr.Zero)
				id_getDimensions_Lcom_bumptech_glide_util_MarkEnforcingInputStream_Lcom_bumptech_glide_load_resource_bitmap_RecyclableBufferedInputStream_Landroid_graphics_BitmapFactory_Options_ = JNIEnv.GetMethodID (class_ref, "getDimensions", "(Lcom/bumptech/glide/util/MarkEnforcingInputStream;Lcom/bumptech/glide/load/resource/bitmap/RecyclableBufferedInputStream;Landroid/graphics/BitmapFactory$Options;)[I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int[] __ret;
				if (GetType () == ThresholdType)
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getDimensions_Lcom_bumptech_glide_util_MarkEnforcingInputStream_Lcom_bumptech_glide_load_resource_bitmap_RecyclableBufferedInputStream_Landroid_graphics_BitmapFactory_Options_, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDimensions", "(Lcom/bumptech/glide/util/MarkEnforcingInputStream;Lcom/bumptech/glide/load/resource/bitmap/RecyclableBufferedInputStream;Landroid/graphics/BitmapFactory$Options;)[I"), __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getSampleSize_IIII;
#pragma warning disable 0169
		static Delegate GetGetSampleSize_IIIIHandler ()
		{
			if (cb_getSampleSize_IIII == null)
				cb_getSampleSize_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, int>) n_GetSampleSize_IIII);
			return cb_getSampleSize_IIII;
		}

		static int n_GetSampleSize_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.Downsampler __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.Downsampler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSampleSize (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='Downsampler']/method[@name='getSampleSize' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("getSampleSize", "(IIII)I", "GetGetSampleSize_IIIIHandler")]
		protected abstract int GetSampleSize (int p0, int p1, int p2, int p3);

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
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.Downsampler __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.Downsampler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public abstract string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='Downsampler']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")] get;
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.Resource.Bitmap.IBitmapDecoder
		global::Android.Graphics.Bitmap global::Com.Bumptech.Glide.Load.Resource.Bitmap.IBitmapDecoder.Decode (global::Java.Lang.Object p0, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1, int p2, int p3, global::Com.Bumptech.Glide.Load.DecodeFormat p4)
		{
			return Decode (global::Java.Interop.JavaObjectExtensions.JavaCast<global::System.IO.Stream>(p0), p1, p2, p3, p4);
		}

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/Downsampler", DoNotGenerateAcw=true)]
	internal partial class DownsamplerInvoker : Downsampler, global::Com.Bumptech.Glide.Load.Resource.Bitmap.IBitmapDecoder {

		public DownsamplerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownsamplerInvoker); }
		}

		static IntPtr id_getSampleSize_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='Downsampler']/method[@name='getSampleSize' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("getSampleSize", "(IIII)I", "GetGetSampleSize_IIIIHandler")]
		protected override unsafe int GetSampleSize (int p0, int p1, int p2, int p3)
		{
			if (id_getSampleSize_IIII == IntPtr.Zero)
				id_getSampleSize_IIII = JNIEnv.GetMethodID (class_ref, "getSampleSize", "(IIII)I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				return JNIEnv.CallIntMethod  (Handle, id_getSampleSize_IIII, __args);
			} finally {
			}
		}

		static IntPtr id_getId;
		public override unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='Downsampler']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
