using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine.Cache {

	[Register ("com/bumptech/glide/load/engine/cache/DiskCache$Factory")]
	public abstract class DiskCacheFactory {

		internal DiskCacheFactory ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='DiskCache.Factory']/field[@name='DEFAULT_DISK_CACHE_DIR']"
		[Register ("DEFAULT_DISK_CACHE_DIR")]
		public const string DefaultDiskCacheDir = (string) "image_manager_disk_cache";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='DiskCache.Factory']/field[@name='DEFAULT_DISK_CACHE_SIZE']"
		[Register ("DEFAULT_DISK_CACHE_SIZE")]
		public const int DefaultDiskCacheSize = (int) 262144000;
	}

	[global::System.Obsolete ("Use the 'DiskCacheFactory' type. This type will be removed in a future release.")]
	public abstract class DiskCacheFactoryConsts : DiskCacheFactory {

		private DiskCacheFactoryConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='DiskCache.Factory']"
	[Register ("com/bumptech/glide/load/engine/cache/DiskCache$Factory", "", "Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheFactoryInvoker")]
	public partial interface IDiskCacheFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='DiskCache.Factory']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/bumptech/glide/load/engine/cache/DiskCache;", "GetBuildHandler:Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheFactoryInvoker, Test_Binding")]
		global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache Build ();

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/cache/DiskCache$Factory", DoNotGenerateAcw=true)]
	internal class IDiskCacheFactoryInvoker : global::Java.Lang.Object, IDiskCacheFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/engine/cache/DiskCache$Factory");
		IntPtr class_ref;

		public static IDiskCacheFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDiskCacheFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.engine.cache.DiskCache.Factory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDiskCacheFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDiskCacheFactoryInvoker); }
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		IntPtr id_build;
		public unsafe global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/bumptech/glide/load/engine/cache/DiskCache;");
			return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache> (JNIEnv.CallObjectMethod (Handle, id_build), JniHandleOwnership.TransferLocalRef);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='DiskCache.Writer']"
	[Register ("com/bumptech/glide/load/engine/cache/DiskCache$Writer", "", "Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheWriterInvoker")]
	public partial interface IDiskCacheWriter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='DiskCache.Writer']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("write", "(Ljava/io/File;)Z", "GetWrite_Ljava_io_File_Handler:Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheWriterInvoker, Test_Binding")]
		bool Write (global::Java.IO.File p0);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/cache/DiskCache$Writer", DoNotGenerateAcw=true)]
	internal class IDiskCacheWriterInvoker : global::Java.Lang.Object, IDiskCacheWriter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/engine/cache/DiskCache$Writer");
		IntPtr class_ref;

		public static IDiskCacheWriter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDiskCacheWriter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.engine.cache.DiskCache.Writer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDiskCacheWriterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDiskCacheWriterInvoker); }
		}

		static Delegate cb_write_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_io_File_Handler ()
		{
			if (cb_write_Ljava_io_File_ == null)
				cb_write_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Write_Ljava_io_File_);
			return cb_write_Ljava_io_File_;
		}

		static bool n_Write_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheWriter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Write (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_write_Ljava_io_File_;
		public unsafe bool Write (global::Java.IO.File p0)
		{
			if (id_write_Ljava_io_File_ == IntPtr.Zero)
				id_write_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/io/File;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_write_Ljava_io_File_, __args);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='DiskCache']"
	[Register ("com/bumptech/glide/load/engine/cache/DiskCache", "", "Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheInvoker")]
	public partial interface IDiskCache : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='DiskCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheInvoker, Test_Binding")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='DiskCache']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.Key']]"
		[Register ("delete", "(Lcom/bumptech/glide/load/Key;)V", "GetDelete_Lcom_bumptech_glide_load_Key_Handler:Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheInvoker, Test_Binding")]
		void Delete (global::Com.Bumptech.Glide.Load.IKey p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='DiskCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.Key']]"
		[Register ("get", "(Lcom/bumptech/glide/load/Key;)Ljava/io/File;", "GetGet_Lcom_bumptech_glide_load_Key_Handler:Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheInvoker, Test_Binding")]
		global::Java.IO.File Get (global::Com.Bumptech.Glide.Load.IKey p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='DiskCache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.Key'] and parameter[2][@type='com.bumptech.glide.load.engine.cache.DiskCache.Writer']]"
		[Register ("put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/cache/DiskCache$Writer;)V", "GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_Handler:Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheInvoker, Test_Binding")]
		void Put (global::Com.Bumptech.Glide.Load.IKey p0, global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheWriter p1);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/cache/DiskCache", DoNotGenerateAcw=true)]
	internal class IDiskCacheInvoker : global::Java.Lang.Object, IDiskCache {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/engine/cache/DiskCache");
		IntPtr class_ref;

		public static IDiskCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDiskCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.engine.cache.DiskCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDiskCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDiskCacheInvoker); }
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (Handle, id_clear);
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IKey p0 = (global::Com.Bumptech.Glide.Load.IKey)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		IntPtr id_delete_Lcom_bumptech_glide_load_Key_;
		public unsafe void Delete (global::Com.Bumptech.Glide.Load.IKey p0)
		{
			if (id_delete_Lcom_bumptech_glide_load_Key_ == IntPtr.Zero)
				id_delete_Lcom_bumptech_glide_load_Key_ = JNIEnv.GetMethodID (class_ref, "delete", "(Lcom/bumptech/glide/load/Key;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_delete_Lcom_bumptech_glide_load_Key_, __args);
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IKey p0 = (global::Com.Bumptech.Glide.Load.IKey)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Lcom_bumptech_glide_load_Key_;
		public unsafe global::Java.IO.File Get (global::Com.Bumptech.Glide.Load.IKey p0)
		{
			if (id_get_Lcom_bumptech_glide_load_Key_ == IntPtr.Zero)
				id_get_Lcom_bumptech_glide_load_Key_ = JNIEnv.GetMethodID (class_ref, "get", "(Lcom/bumptech/glide/load/Key;)Ljava/io/File;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (Handle, id_get_Lcom_bumptech_glide_load_Key_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IKey p0 = (global::Com.Bumptech.Glide.Load.IKey)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheWriter p1 = (global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheWriter)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheWriter> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_;
		public unsafe void Put (global::Com.Bumptech.Glide.Load.IKey p0, global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheWriter p1)
		{
			if (id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_ == IntPtr.Zero)
				id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_ = JNIEnv.GetMethodID (class_ref, "put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/cache/DiskCache$Writer;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_, __args);
		}

	}

}
