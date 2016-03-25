using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GlideBuilder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/GlideBuilder", DoNotGenerateAcw=true)]
	public partial class GlideBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/GlideBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GlideBuilder); }
		}

		protected GlideBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GlideBuilder']/constructor[@name='GlideBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe GlideBuilder (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GlideBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_setBitmapPool_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_;
#pragma warning disable 0169
		static Delegate GetSetBitmapPool_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Handler ()
		{
			if (cb_setBitmapPool_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ == null)
				cb_setBitmapPool_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBitmapPool_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_);
			return cb_setBitmapPool_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_;
		}

		static IntPtr n_SetBitmapPool_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GlideBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p0 = (global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBitmapPool (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setBitmapPool_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GlideBuilder']/method[@name='setBitmapPool' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool']]"
		[Register ("setBitmapPool", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/GlideBuilder;", "GetSetBitmapPool_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GlideBuilder SetBitmapPool (global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p0)
		{
			if (id_setBitmapPool_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ == IntPtr.Zero)
				id_setBitmapPool_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ = JNIEnv.GetMethodID (class_ref, "setBitmapPool", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/GlideBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GlideBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setBitmapPool_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBitmapPool", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/GlideBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setDecodeFormat_Lcom_bumptech_glide_load_DecodeFormat_;
#pragma warning disable 0169
		static Delegate GetSetDecodeFormat_Lcom_bumptech_glide_load_DecodeFormat_Handler ()
		{
			if (cb_setDecodeFormat_Lcom_bumptech_glide_load_DecodeFormat_ == null)
				cb_setDecodeFormat_Lcom_bumptech_glide_load_DecodeFormat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDecodeFormat_Lcom_bumptech_glide_load_DecodeFormat_);
			return cb_setDecodeFormat_Lcom_bumptech_glide_load_DecodeFormat_;
		}

		static IntPtr n_SetDecodeFormat_Lcom_bumptech_glide_load_DecodeFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GlideBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.DecodeFormat p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.DecodeFormat> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDecodeFormat (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDecodeFormat_Lcom_bumptech_glide_load_DecodeFormat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GlideBuilder']/method[@name='setDecodeFormat' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.DecodeFormat']]"
		[Register ("setDecodeFormat", "(Lcom/bumptech/glide/load/DecodeFormat;)Lcom/bumptech/glide/GlideBuilder;", "GetSetDecodeFormat_Lcom_bumptech_glide_load_DecodeFormat_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GlideBuilder SetDecodeFormat (global::Com.Bumptech.Glide.Load.DecodeFormat p0)
		{
			if (id_setDecodeFormat_Lcom_bumptech_glide_load_DecodeFormat_ == IntPtr.Zero)
				id_setDecodeFormat_Lcom_bumptech_glide_load_DecodeFormat_ = JNIEnv.GetMethodID (class_ref, "setDecodeFormat", "(Lcom/bumptech/glide/load/DecodeFormat;)Lcom/bumptech/glide/GlideBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GlideBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setDecodeFormat_Lcom_bumptech_glide_load_DecodeFormat_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDecodeFormat", "(Lcom/bumptech/glide/load/DecodeFormat;)Lcom/bumptech/glide/GlideBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_;
#pragma warning disable 0169
		static Delegate GetSetDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Handler ()
		{
			if (cb_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_ == null)
				cb_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_);
			return cb_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_;
		}

		static IntPtr n_SetDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GlideBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache p0 = (global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDiskCache (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GlideBuilder']/method[@name='setDiskCache' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.cache.DiskCache']]"
		[Obsolete (@"deprecated")]
		[Register ("setDiskCache", "(Lcom/bumptech/glide/load/engine/cache/DiskCache;)Lcom/bumptech/glide/GlideBuilder;", "GetSetDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GlideBuilder SetDiskCache (global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache p0)
		{
			if (id_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_ == IntPtr.Zero)
				id_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_ = JNIEnv.GetMethodID (class_ref, "setDiskCache", "(Lcom/bumptech/glide/load/engine/cache/DiskCache;)Lcom/bumptech/glide/GlideBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GlideBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDiskCache", "(Lcom/bumptech/glide/load/engine/cache/DiskCache;)Lcom/bumptech/glide/GlideBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_;
#pragma warning disable 0169
		static Delegate GetSetDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_Handler ()
		{
			if (cb_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_ == null)
				cb_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_);
			return cb_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_;
		}

		static IntPtr n_SetDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GlideBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheFactory p0 = (global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheFactory)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheFactory> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDiskCache (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GlideBuilder']/method[@name='setDiskCache' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.cache.DiskCache.Factory']]"
		[Register ("setDiskCache", "(Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;)Lcom/bumptech/glide/GlideBuilder;", "GetSetDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GlideBuilder SetDiskCache (global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheFactory p0)
		{
			if (id_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_ == IntPtr.Zero)
				id_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_ = JNIEnv.GetMethodID (class_ref, "setDiskCache", "(Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;)Lcom/bumptech/glide/GlideBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GlideBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setDiskCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDiskCache", "(Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;)Lcom/bumptech/glide/GlideBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setDiskCacheService_Ljava_util_concurrent_ExecutorService_;
#pragma warning disable 0169
		static Delegate GetSetDiskCacheService_Ljava_util_concurrent_ExecutorService_Handler ()
		{
			if (cb_setDiskCacheService_Ljava_util_concurrent_ExecutorService_ == null)
				cb_setDiskCacheService_Ljava_util_concurrent_ExecutorService_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDiskCacheService_Ljava_util_concurrent_ExecutorService_);
			return cb_setDiskCacheService_Ljava_util_concurrent_ExecutorService_;
		}

		static IntPtr n_SetDiskCacheService_Ljava_util_concurrent_ExecutorService_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GlideBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.IExecutorService p0 = (global::Java.Util.Concurrent.IExecutorService)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDiskCacheService (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDiskCacheService_Ljava_util_concurrent_ExecutorService_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GlideBuilder']/method[@name='setDiskCacheService' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ExecutorService']]"
		[Register ("setDiskCacheService", "(Ljava/util/concurrent/ExecutorService;)Lcom/bumptech/glide/GlideBuilder;", "GetSetDiskCacheService_Ljava_util_concurrent_ExecutorService_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GlideBuilder SetDiskCacheService (global::Java.Util.Concurrent.IExecutorService p0)
		{
			if (id_setDiskCacheService_Ljava_util_concurrent_ExecutorService_ == IntPtr.Zero)
				id_setDiskCacheService_Ljava_util_concurrent_ExecutorService_ = JNIEnv.GetMethodID (class_ref, "setDiskCacheService", "(Ljava/util/concurrent/ExecutorService;)Lcom/bumptech/glide/GlideBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GlideBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setDiskCacheService_Ljava_util_concurrent_ExecutorService_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDiskCacheService", "(Ljava/util/concurrent/ExecutorService;)Lcom/bumptech/glide/GlideBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setMemoryCache_Lcom_bumptech_glide_load_engine_cache_MemoryCache_;
#pragma warning disable 0169
		static Delegate GetSetMemoryCache_Lcom_bumptech_glide_load_engine_cache_MemoryCache_Handler ()
		{
			if (cb_setMemoryCache_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ == null)
				cb_setMemoryCache_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMemoryCache_Lcom_bumptech_glide_load_engine_cache_MemoryCache_);
			return cb_setMemoryCache_Lcom_bumptech_glide_load_engine_cache_MemoryCache_;
		}

		static IntPtr n_SetMemoryCache_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GlideBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache p0 = (global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMemoryCache (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setMemoryCache_Lcom_bumptech_glide_load_engine_cache_MemoryCache_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GlideBuilder']/method[@name='setMemoryCache' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.cache.MemoryCache']]"
		[Register ("setMemoryCache", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache;)Lcom/bumptech/glide/GlideBuilder;", "GetSetMemoryCache_Lcom_bumptech_glide_load_engine_cache_MemoryCache_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GlideBuilder SetMemoryCache (global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache p0)
		{
			if (id_setMemoryCache_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ == IntPtr.Zero)
				id_setMemoryCache_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ = JNIEnv.GetMethodID (class_ref, "setMemoryCache", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache;)Lcom/bumptech/glide/GlideBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GlideBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setMemoryCache_Lcom_bumptech_glide_load_engine_cache_MemoryCache_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMemoryCache", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache;)Lcom/bumptech/glide/GlideBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setResizeService_Ljava_util_concurrent_ExecutorService_;
#pragma warning disable 0169
		static Delegate GetSetResizeService_Ljava_util_concurrent_ExecutorService_Handler ()
		{
			if (cb_setResizeService_Ljava_util_concurrent_ExecutorService_ == null)
				cb_setResizeService_Ljava_util_concurrent_ExecutorService_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetResizeService_Ljava_util_concurrent_ExecutorService_);
			return cb_setResizeService_Ljava_util_concurrent_ExecutorService_;
		}

		static IntPtr n_SetResizeService_Ljava_util_concurrent_ExecutorService_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GlideBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.IExecutorService p0 = (global::Java.Util.Concurrent.IExecutorService)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetResizeService (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setResizeService_Ljava_util_concurrent_ExecutorService_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GlideBuilder']/method[@name='setResizeService' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ExecutorService']]"
		[Register ("setResizeService", "(Ljava/util/concurrent/ExecutorService;)Lcom/bumptech/glide/GlideBuilder;", "GetSetResizeService_Ljava_util_concurrent_ExecutorService_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GlideBuilder SetResizeService (global::Java.Util.Concurrent.IExecutorService p0)
		{
			if (id_setResizeService_Ljava_util_concurrent_ExecutorService_ == IntPtr.Zero)
				id_setResizeService_Ljava_util_concurrent_ExecutorService_ = JNIEnv.GetMethodID (class_ref, "setResizeService", "(Ljava/util/concurrent/ExecutorService;)Lcom/bumptech/glide/GlideBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GlideBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setResizeService_Ljava_util_concurrent_ExecutorService_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GlideBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResizeService", "(Ljava/util/concurrent/ExecutorService;)Lcom/bumptech/glide/GlideBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
