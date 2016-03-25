using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine.Prefill {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.prefill']/class[@name='BitmapPreFiller']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/prefill/BitmapPreFiller", DoNotGenerateAcw=true)]
	public sealed partial class BitmapPreFiller : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/engine/prefill/BitmapPreFiller", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapPreFiller); }
		}

		internal BitmapPreFiller (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_engine_cache_MemoryCache_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_DecodeFormat_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.prefill']/class[@name='BitmapPreFiller']/constructor[@name='BitmapPreFiller' and count(parameter)=3 and parameter[1][@type='com.bumptech.glide.load.engine.cache.MemoryCache'] and parameter[2][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool'] and parameter[3][@type='com.bumptech.glide.load.DecodeFormat']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/DecodeFormat;)V", "")]
		public unsafe BitmapPreFiller (global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache p0, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1, global::Com.Bumptech.Glide.Load.DecodeFormat p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (BitmapPreFiller)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/engine/cache/MemoryCache;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/DecodeFormat;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/engine/cache/MemoryCache;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/DecodeFormat;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_engine_cache_MemoryCache_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_DecodeFormat_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_engine_cache_MemoryCache_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_DecodeFormat_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/DecodeFormat;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_engine_cache_MemoryCache_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_DecodeFormat_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_engine_cache_MemoryCache_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_DecodeFormat_, __args);
			} finally {
			}
		}

		static IntPtr id_preFill_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.prefill']/class[@name='BitmapPreFiller']/method[@name='preFill' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.prefill.PreFillType.Builder...']]"
		[Register ("preFill", "([Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;)V", "")]
		public unsafe void PreFill (params global:: Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder[] p0)
		{
			if (id_preFill_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_ == IntPtr.Zero)
				id_preFill_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_ = JNIEnv.GetMethodID (class_ref, "preFill", "([Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_preFill_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
