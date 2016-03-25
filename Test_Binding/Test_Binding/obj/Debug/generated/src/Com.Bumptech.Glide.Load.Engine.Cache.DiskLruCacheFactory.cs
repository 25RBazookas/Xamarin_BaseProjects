using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='DiskLruCacheFactory']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/cache/DiskLruCacheFactory", DoNotGenerateAcw=true)]
	public partial class DiskLruCacheFactory : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheFactory {


		public static class InterfaceConsts {

			// The following are fields from: com.bumptech.glide.load.engine.cache.DiskCache.Factory

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='DiskCache.Factory']/field[@name='DEFAULT_DISK_CACHE_DIR']"
			[Register ("DEFAULT_DISK_CACHE_DIR")]
			public const string DefaultDiskCacheDir = (string) "image_manager_disk_cache";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='DiskCache.Factory']/field[@name='DEFAULT_DISK_CACHE_SIZE']"
			[Register ("DEFAULT_DISK_CACHE_SIZE")]
			public const int DefaultDiskCacheSize = (int) 262144000;
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='DiskLruCacheFactory.CacheDirectoryGetter']"
		[Register ("com/bumptech/glide/load/engine/cache/DiskLruCacheFactory$CacheDirectoryGetter", "", "Com.Bumptech.Glide.Load.Engine.Cache.DiskLruCacheFactory/ICacheDirectoryGetterInvoker")]
		public partial interface ICacheDirectoryGetter : IJavaObject {

			global::Java.IO.File CacheDirectory {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='DiskLruCacheFactory.CacheDirectoryGetter']/method[@name='getCacheDirectory' and count(parameter)=0]"
				[Register ("getCacheDirectory", "()Ljava/io/File;", "GetGetCacheDirectoryHandler:Com.Bumptech.Glide.Load.Engine.Cache.DiskLruCacheFactory/ICacheDirectoryGetterInvoker, Test_Binding")] get;
			}

		}

		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/cache/DiskLruCacheFactory$CacheDirectoryGetter", DoNotGenerateAcw=true)]
		internal class ICacheDirectoryGetterInvoker : global::Java.Lang.Object, ICacheDirectoryGetter {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/engine/cache/DiskLruCacheFactory$CacheDirectoryGetter");
			IntPtr class_ref;

			public static ICacheDirectoryGetter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICacheDirectoryGetter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.engine.cache.DiskLruCacheFactory.CacheDirectoryGetter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICacheDirectoryGetterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICacheDirectoryGetterInvoker); }
			}

			static Delegate cb_getCacheDirectory;
#pragma warning disable 0169
			static Delegate GetGetCacheDirectoryHandler ()
			{
				if (cb_getCacheDirectory == null)
					cb_getCacheDirectory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCacheDirectory);
				return cb_getCacheDirectory;
			}

			static IntPtr n_GetCacheDirectory (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Engine.Cache.DiskLruCacheFactory.ICacheDirectoryGetter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.DiskLruCacheFactory.ICacheDirectoryGetter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CacheDirectory);
			}
#pragma warning restore 0169

			IntPtr id_getCacheDirectory;
			public unsafe global::Java.IO.File CacheDirectory {
				get {
					if (id_getCacheDirectory == IntPtr.Zero)
						id_getCacheDirectory = JNIEnv.GetMethodID (class_ref, "getCacheDirectory", "()Ljava/io/File;");
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (Handle, id_getCacheDirectory), JniHandleOwnership.TransferLocalRef);
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/engine/cache/DiskLruCacheFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiskLruCacheFactory); }
		}

		protected DiskLruCacheFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_engine_cache_DiskLruCacheFactory_CacheDirectoryGetter_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='DiskLruCacheFactory']/constructor[@name='DiskLruCacheFactory' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.engine.cache.DiskLruCacheFactory.CacheDirectoryGetter'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/engine/cache/DiskLruCacheFactory$CacheDirectoryGetter;I)V", "")]
		public unsafe DiskLruCacheFactory (global::Com.Bumptech.Glide.Load.Engine.Cache.DiskLruCacheFactory.ICacheDirectoryGetter p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DiskLruCacheFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/engine/cache/DiskLruCacheFactory$CacheDirectoryGetter;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/engine/cache/DiskLruCacheFactory$CacheDirectoryGetter;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_engine_cache_DiskLruCacheFactory_CacheDirectoryGetter_I == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_engine_cache_DiskLruCacheFactory_CacheDirectoryGetter_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/engine/cache/DiskLruCacheFactory$CacheDirectoryGetter;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_engine_cache_DiskLruCacheFactory_CacheDirectoryGetter_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_engine_cache_DiskLruCacheFactory_CacheDirectoryGetter_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='DiskLruCacheFactory']/constructor[@name='DiskLruCacheFactory' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe DiskLruCacheFactory (string p0, string p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (DiskLruCacheFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='DiskLruCacheFactory']/constructor[@name='DiskLruCacheFactory' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe DiskLruCacheFactory (string p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DiskLruCacheFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_I == IntPtr.Zero)
					id_ctor_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.DiskLruCacheFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.DiskLruCacheFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='DiskLruCacheFactory']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/bumptech/glide/load/engine/cache/DiskCache;", "GetBuildHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/bumptech/glide/load/engine/cache/DiskCache;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/bumptech/glide/load/engine/cache/DiskCache;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
