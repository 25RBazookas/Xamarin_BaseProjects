using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='DiskCacheAdapter']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/cache/DiskCacheAdapter", DoNotGenerateAcw=true)]
	public partial class DiskCacheAdapter : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/engine/cache/DiskCacheAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiskCacheAdapter); }
		}

		protected DiskCacheAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='DiskCacheAdapter']/constructor[@name='DiskCacheAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DiskCacheAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DiskCacheAdapter)) {
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

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.DiskCacheAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.DiskCacheAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='DiskCacheAdapter']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_delete_Lcom_bumptech_glide_load_Key_;
#pragma warning disable 0169
		static Delegate GetDelete_Lcom_bumptech_glide_load_Key_Handler ()
		{
			if (cb_delete_Lcom_bumptech_glide_load_Key_ == null)
				cb_delete_Lcom_bumptech_glide_load_Key_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Delete_Lcom_bumptech_glide_load_Key_);
			return cb_delete_Lcom_bumptech_glide_load_Key_;
		}

		static void n_Delete_Lcom_bumptech_glide_load_Key_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.DiskCacheAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.DiskCacheAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IKey p0 = (global::Com.Bumptech.Glide.Load.IKey)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_delete_Lcom_bumptech_glide_load_Key_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='DiskCacheAdapter']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.Key']]"
		[Register ("delete", "(Lcom/bumptech/glide/load/Key;)V", "GetDelete_Lcom_bumptech_glide_load_Key_Handler")]
		public virtual unsafe void Delete (global::Com.Bumptech.Glide.Load.IKey p0)
		{
			if (id_delete_Lcom_bumptech_glide_load_Key_ == IntPtr.Zero)
				id_delete_Lcom_bumptech_glide_load_Key_ = JNIEnv.GetMethodID (class_ref, "delete", "(Lcom/bumptech/glide/load/Key;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_delete_Lcom_bumptech_glide_load_Key_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "(Lcom/bumptech/glide/load/Key;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_get_Lcom_bumptech_glide_load_Key_;
#pragma warning disable 0169
		static Delegate GetGet_Lcom_bumptech_glide_load_Key_Handler ()
		{
			if (cb_get_Lcom_bumptech_glide_load_Key_ == null)
				cb_get_Lcom_bumptech_glide_load_Key_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Lcom_bumptech_glide_load_Key_);
			return cb_get_Lcom_bumptech_glide_load_Key_;
		}

		static IntPtr n_Get_Lcom_bumptech_glide_load_Key_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.DiskCacheAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.DiskCacheAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IKey p0 = (global::Com.Bumptech.Glide.Load.IKey)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Lcom_bumptech_glide_load_Key_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='DiskCacheAdapter']/method[@name='get' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.Key']]"
		[Register ("get", "(Lcom/bumptech/glide/load/Key;)Ljava/io/File;", "GetGet_Lcom_bumptech_glide_load_Key_Handler")]
		public virtual unsafe global::Java.IO.File Get (global::Com.Bumptech.Glide.Load.IKey p0)
		{
			if (id_get_Lcom_bumptech_glide_load_Key_ == IntPtr.Zero)
				id_get_Lcom_bumptech_glide_load_Key_ = JNIEnv.GetMethodID (class_ref, "get", "(Lcom/bumptech/glide/load/Key;)Ljava/io/File;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.IO.File __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_get_Lcom_bumptech_glide_load_Key_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Lcom/bumptech/glide/load/Key;)Ljava/io/File;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_;
#pragma warning disable 0169
		static Delegate GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_Handler ()
		{
			if (cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_ == null)
				cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_);
			return cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_;
		}

		static void n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.DiskCacheAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.DiskCacheAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IKey p0 = (global::Com.Bumptech.Glide.Load.IKey)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheWriter p1 = (global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheWriter)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheWriter> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='DiskCacheAdapter']/method[@name='put' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.Key'] and parameter[2][@type='com.bumptech.glide.load.engine.cache.DiskCache.Writer']]"
		[Register ("put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/cache/DiskCache$Writer;)V", "GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_Handler")]
		public virtual unsafe void Put (global::Com.Bumptech.Glide.Load.IKey p0, global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheWriter p1)
		{
			if (id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_ == IntPtr.Zero)
				id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_ = JNIEnv.GetMethodID (class_ref, "put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/cache/DiskCache$Writer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/cache/DiskCache$Writer;)V"), __args);
			} finally {
			}
		}

	}
}
