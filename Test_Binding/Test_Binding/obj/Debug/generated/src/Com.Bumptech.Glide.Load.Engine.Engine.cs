using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/Engine", DoNotGenerateAcw=true)]
	public partial class Engine : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Engine.IEngineJobListener, global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine.EngineJobFactory']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/Engine$EngineJobFactory", DoNotGenerateAcw=true)]
		public partial class EngineJobFactory : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/engine/Engine$EngineJobFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EngineJobFactory); }
			}

			protected EngineJobFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_util_concurrent_ExecutorService_Ljava_util_concurrent_ExecutorService_Lcom_bumptech_glide_load_engine_EngineJobListener_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine.EngineJobFactory']/constructor[@name='Engine.EngineJobFactory' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.ExecutorService'] and parameter[2][@type='java.util.concurrent.ExecutorService'] and parameter[3][@type='com.bumptech.glide.load.engine.EngineJobListener']]"
			[Register (".ctor", "(Ljava/util/concurrent/ExecutorService;Ljava/util/concurrent/ExecutorService;Lcom/bumptech/glide/load/engine/EngineJobListener;)V", "")]
			public unsafe EngineJobFactory (global::Java.Util.Concurrent.IExecutorService p0, global::Java.Util.Concurrent.IExecutorService p1, global::Com.Bumptech.Glide.Load.Engine.IEngineJobListener p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (EngineJobFactory)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/concurrent/ExecutorService;Ljava/util/concurrent/ExecutorService;Lcom/bumptech/glide/load/engine/EngineJobListener;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/concurrent/ExecutorService;Ljava/util/concurrent/ExecutorService;Lcom/bumptech/glide/load/engine/EngineJobListener;)V", __args);
						return;
					}

					if (id_ctor_Ljava_util_concurrent_ExecutorService_Ljava_util_concurrent_ExecutorService_Lcom_bumptech_glide_load_engine_EngineJobListener_ == IntPtr.Zero)
						id_ctor_Ljava_util_concurrent_ExecutorService_Ljava_util_concurrent_ExecutorService_Lcom_bumptech_glide_load_engine_EngineJobListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/ExecutorService;Ljava/util/concurrent/ExecutorService;Lcom/bumptech/glide/load/engine/EngineJobListener;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_ExecutorService_Ljava_util_concurrent_ExecutorService_Lcom_bumptech_glide_load_engine_EngineJobListener_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_concurrent_ExecutorService_Ljava_util_concurrent_ExecutorService_Lcom_bumptech_glide_load_engine_EngineJobListener_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine.LazyDiskCacheProvider']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/Engine$LazyDiskCacheProvider", DoNotGenerateAcw=true)]
		public partial class LazyDiskCacheProvider : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/engine/Engine$LazyDiskCacheProvider", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LazyDiskCacheProvider); }
			}

			protected LazyDiskCacheProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine.LazyDiskCacheProvider']/constructor[@name='Engine.LazyDiskCacheProvider' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.cache.DiskCache.Factory']]"
			[Register (".ctor", "(Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;)V", "")]
			public unsafe LazyDiskCacheProvider (global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheFactory p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (LazyDiskCacheProvider)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;)V", __args);
						return;
					}

					if (id_ctor_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_ == IntPtr.Zero)
						id_ctor_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_, __args);
				} finally {
				}
			}

			static Delegate cb_getDiskCache;
#pragma warning disable 0169
			static Delegate GetGetDiskCacheHandler ()
			{
				if (cb_getDiskCache == null)
					cb_getDiskCache = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDiskCache);
				return cb_getDiskCache;
			}

			static IntPtr n_GetDiskCache (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Engine.Engine.LazyDiskCacheProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Engine.LazyDiskCacheProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DiskCache);
			}
#pragma warning restore 0169

			static IntPtr id_getDiskCache;
			public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache DiskCache {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine.LazyDiskCacheProvider']/method[@name='getDiskCache' and count(parameter)=0]"
				[Register ("getDiskCache", "()Lcom/bumptech/glide/load/engine/cache/DiskCache;", "GetGetDiskCacheHandler")]
				get {
					if (id_getDiskCache == IntPtr.Zero)
						id_getDiskCache = JNIEnv.GetMethodID (class_ref, "getDiskCache", "()Lcom/bumptech/glide/load/engine/cache/DiskCache;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache> (JNIEnv.CallObjectMethod  (Handle, id_getDiskCache), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCache> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDiskCache", "()Lcom/bumptech/glide/load/engine/cache/DiskCache;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine.LoadStatus']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/Engine$LoadStatus", DoNotGenerateAcw=true)]
		public partial class LoadStatus : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/engine/Engine$LoadStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LoadStatus); }
			}

			protected LoadStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_bumptech_glide_request_ResourceCallback_Lcom_bumptech_glide_load_engine_EngineJob_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine.LoadStatus']/constructor[@name='Engine.LoadStatus' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.request.ResourceCallback'] and parameter[2][@type='com.bumptech.glide.load.engine.EngineJob']]"
			[Register (".ctor", "(Lcom/bumptech/glide/request/ResourceCallback;Lcom/bumptech/glide/load/engine/EngineJob;)V", "")]
			public unsafe LoadStatus (global::Com.Bumptech.Glide.Request.IResourceCallback p0, global::Com.Bumptech.Glide.Load.Engine.EngineJob p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (LoadStatus)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/request/ResourceCallback;Lcom/bumptech/glide/load/engine/EngineJob;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/request/ResourceCallback;Lcom/bumptech/glide/load/engine/EngineJob;)V", __args);
						return;
					}

					if (id_ctor_Lcom_bumptech_glide_request_ResourceCallback_Lcom_bumptech_glide_load_engine_EngineJob_ == IntPtr.Zero)
						id_ctor_Lcom_bumptech_glide_request_ResourceCallback_Lcom_bumptech_glide_load_engine_EngineJob_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/request/ResourceCallback;Lcom/bumptech/glide/load/engine/EngineJob;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_request_ResourceCallback_Lcom_bumptech_glide_load_engine_EngineJob_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_request_ResourceCallback_Lcom_bumptech_glide_load_engine_EngineJob_, __args);
				} finally {
				}
			}

			static Delegate cb_cancel;
#pragma warning disable 0169
			static Delegate GetCancelHandler ()
			{
				if (cb_cancel == null)
					cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
				return cb_cancel;
			}

			static void n_Cancel (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Engine.Engine.LoadStatus __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Engine.LoadStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Cancel ();
			}
#pragma warning restore 0169

			static IntPtr id_cancel;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine.LoadStatus']/method[@name='cancel' and count(parameter)=0]"
			[Register ("cancel", "()V", "GetCancelHandler")]
			public virtual unsafe void Cancel ()
			{
				if (id_cancel == IntPtr.Zero)
					id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_cancel);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine.RefQueueIdleHandler']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/Engine$RefQueueIdleHandler", DoNotGenerateAcw=true)]
		public partial class RefQueueIdleHandler : global::Java.Lang.Object, global::Android.OS.MessageQueue.IIdleHandler {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/engine/Engine$RefQueueIdleHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RefQueueIdleHandler); }
			}

			protected RefQueueIdleHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_util_Map_Ljava_lang_ref_ReferenceQueue_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine.RefQueueIdleHandler']/constructor[@name='Engine.RefQueueIdleHandler' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;com.bumptech.glide.load.Key, java.lang.ref.WeakReference&lt;com.bumptech.glide.load.engine.EngineResource&lt;?&gt;&gt;&gt;'] and parameter[2][@type='java.lang.ref.ReferenceQueue&lt;com.bumptech.glide.load.engine.EngineResource&lt;?&gt;&gt;']]"
			[Register (".ctor", "(Ljava/util/Map;Ljava/lang/ref/ReferenceQueue;)V", "")]
			public unsafe RefQueueIdleHandler (global::System.Collections.Generic.IDictionary<global::Com.Bumptech.Glide.Load.IKey, global::Java.Lang.Ref.WeakReference> p0, global::Java.Lang.Ref.ReferenceQueue p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Com.Bumptech.Glide.Load.IKey, global::Java.Lang.Ref.WeakReference>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (RefQueueIdleHandler)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Map;Ljava/lang/ref/ReferenceQueue;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/Map;Ljava/lang/ref/ReferenceQueue;)V", __args);
						return;
					}

					if (id_ctor_Ljava_util_Map_Ljava_lang_ref_ReferenceQueue_ == IntPtr.Zero)
						id_ctor_Ljava_util_Map_Ljava_lang_ref_ReferenceQueue_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;Ljava/lang/ref/ReferenceQueue;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_Ljava_lang_ref_ReferenceQueue_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_Map_Ljava_lang_ref_ReferenceQueue_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_queueIdle;
#pragma warning disable 0169
			static Delegate GetQueueIdleHandler ()
			{
				if (cb_queueIdle == null)
					cb_queueIdle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_QueueIdle);
				return cb_queueIdle;
			}

			static bool n_QueueIdle (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Engine.Engine.RefQueueIdleHandler __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Engine.RefQueueIdleHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.QueueIdle ();
			}
#pragma warning restore 0169

			static IntPtr id_queueIdle;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine.RefQueueIdleHandler']/method[@name='queueIdle' and count(parameter)=0]"
			[Register ("queueIdle", "()Z", "GetQueueIdleHandler")]
			public virtual unsafe bool QueueIdle ()
			{
				if (id_queueIdle == IntPtr.Zero)
					id_queueIdle = JNIEnv.GetMethodID (class_ref, "queueIdle", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_queueIdle);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "queueIdle", "()Z"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine.ResourceWeakReference']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/Engine$ResourceWeakReference", DoNotGenerateAcw=true)]
		public partial class ResourceWeakReference : global::Java.Lang.Ref.WeakReference {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/engine/Engine$ResourceWeakReference", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResourceWeakReference); }
			}

			protected ResourceWeakReference (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_EngineResource_Ljava_lang_ref_ReferenceQueue_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine.ResourceWeakReference']/constructor[@name='Engine.ResourceWeakReference' and count(parameter)=3 and parameter[1][@type='com.bumptech.glide.load.Key'] and parameter[2][@type='com.bumptech.glide.load.engine.EngineResource&lt;?&gt;'] and parameter[3][@type='java.lang.ref.ReferenceQueue&lt;? super com.bumptech.glide.load.engine.EngineResource&lt;?&gt;&gt;']]"
			[Register (".ctor", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/EngineResource;Ljava/lang/ref/ReferenceQueue;)V", "")]
			public unsafe ResourceWeakReference (global::Com.Bumptech.Glide.Load.IKey p0, global::Com.Bumptech.Glide.Load.Engine.EngineResource p1, global::Java.Lang.Ref.ReferenceQueue p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (ResourceWeakReference)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/EngineResource;Ljava/lang/ref/ReferenceQueue;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/EngineResource;Ljava/lang/ref/ReferenceQueue;)V", __args);
						return;
					}

					if (id_ctor_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_EngineResource_Ljava_lang_ref_ReferenceQueue_ == IntPtr.Zero)
						id_ctor_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_EngineResource_Ljava_lang_ref_ReferenceQueue_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/EngineResource;Ljava/lang/ref/ReferenceQueue;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_EngineResource_Ljava_lang_ref_ReferenceQueue_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_EngineResource_Ljava_lang_ref_ReferenceQueue_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/engine/Engine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Engine); }
		}

		protected Engine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_engine_cache_MemoryCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_Ljava_util_concurrent_ExecutorService_Ljava_util_concurrent_ExecutorService_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine']/constructor[@name='Engine' and count(parameter)=4 and parameter[1][@type='com.bumptech.glide.load.engine.cache.MemoryCache'] and parameter[2][@type='com.bumptech.glide.load.engine.cache.DiskCache.Factory'] and parameter[3][@type='java.util.concurrent.ExecutorService'] and parameter[4][@type='java.util.concurrent.ExecutorService']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache;Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;Ljava/util/concurrent/ExecutorService;Ljava/util/concurrent/ExecutorService;)V", "")]
		public unsafe Engine (global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache p0, global::Com.Bumptech.Glide.Load.Engine.Cache.IDiskCacheFactory p1, global::Java.Util.Concurrent.IExecutorService p2, global::Java.Util.Concurrent.IExecutorService p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (Engine)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/engine/cache/MemoryCache;Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;Ljava/util/concurrent/ExecutorService;Ljava/util/concurrent/ExecutorService;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/engine/cache/MemoryCache;Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;Ljava/util/concurrent/ExecutorService;Ljava/util/concurrent/ExecutorService;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_engine_cache_MemoryCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_Ljava_util_concurrent_ExecutorService_Ljava_util_concurrent_ExecutorService_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_engine_cache_MemoryCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_Ljava_util_concurrent_ExecutorService_Ljava_util_concurrent_ExecutorService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache;Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;Ljava/util/concurrent/ExecutorService;Ljava/util/concurrent/ExecutorService;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_engine_cache_MemoryCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_Ljava_util_concurrent_ExecutorService_Ljava_util_concurrent_ExecutorService_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_engine_cache_MemoryCache_Lcom_bumptech_glide_load_engine_cache_DiskCache_Factory_Ljava_util_concurrent_ExecutorService_Ljava_util_concurrent_ExecutorService_, __args);
			} finally {
			}
		}

		static Delegate cb_clearDiskCache;
#pragma warning disable 0169
		static Delegate GetClearDiskCacheHandler ()
		{
			if (cb_clearDiskCache == null)
				cb_clearDiskCache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearDiskCache);
			return cb_clearDiskCache;
		}

		static void n_ClearDiskCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Engine.Engine __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Engine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearDiskCache ();
		}
#pragma warning restore 0169

		static IntPtr id_clearDiskCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine']/method[@name='clearDiskCache' and count(parameter)=0]"
		[Register ("clearDiskCache", "()V", "GetClearDiskCacheHandler")]
		public virtual unsafe void ClearDiskCache ()
		{
			if (id_clearDiskCache == IntPtr.Zero)
				id_clearDiskCache = JNIEnv.GetMethodID (class_ref, "clearDiskCache", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearDiskCache);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearDiskCache", "()V"));
			} finally {
			}
		}

		static Delegate cb_load_Lcom_bumptech_glide_load_Key_IILcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_Priority_ZLcom_bumptech_glide_load_engine_DiskCacheStrategy_Lcom_bumptech_glide_request_ResourceCallback_;
#pragma warning disable 0169
		static Delegate GetLoad_Lcom_bumptech_glide_load_Key_IILcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_Priority_ZLcom_bumptech_glide_load_engine_DiskCacheStrategy_Lcom_bumptech_glide_request_ResourceCallback_Handler ()
		{
			if (cb_load_Lcom_bumptech_glide_load_Key_IILcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_Priority_ZLcom_bumptech_glide_load_engine_DiskCacheStrategy_Lcom_bumptech_glide_request_ResourceCallback_ == null)
				cb_load_Lcom_bumptech_glide_load_Key_IILcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_Priority_ZLcom_bumptech_glide_load_engine_DiskCacheStrategy_Lcom_bumptech_glide_request_ResourceCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr, IntPtr, IntPtr>) n_Load_Lcom_bumptech_glide_load_Key_IILcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_Priority_ZLcom_bumptech_glide_load_engine_DiskCacheStrategy_Lcom_bumptech_glide_request_ResourceCallback_);
			return cb_load_Lcom_bumptech_glide_load_Key_IILcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_Priority_ZLcom_bumptech_glide_load_engine_DiskCacheStrategy_Lcom_bumptech_glide_request_ResourceCallback_;
		}

		static IntPtr n_Load_Lcom_bumptech_glide_load_Key_IILcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_Priority_ZLcom_bumptech_glide_load_engine_DiskCacheStrategy_Lcom_bumptech_glide_request_ResourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, bool p8, IntPtr native_p9, IntPtr native_p10)
		{
			global::Com.Bumptech.Glide.Load.Engine.Engine __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Engine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IKey p0 = (global::Com.Bumptech.Glide.Load.IKey)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Data.IDataFetcher p3 = (global::Com.Bumptech.Glide.Load.Data.IDataFetcher)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Provider.IDataLoadProvider p4 = (global::Com.Bumptech.Glide.Provider.IDataLoadProvider)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Provider.IDataLoadProvider> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.ITransformation p5 = (global::Com.Bumptech.Glide.Load.ITransformation)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.ITransformation> (native_p5, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder p6 = (global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder> (native_p6, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Priority p7 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Priority> (native_p7, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy p9 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy> (native_p9, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.IResourceCallback p10 = (global::Com.Bumptech.Glide.Request.IResourceCallback)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IResourceCallback> (native_p10, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_load_Lcom_bumptech_glide_load_Key_IILcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_Priority_ZLcom_bumptech_glide_load_engine_DiskCacheStrategy_Lcom_bumptech_glide_request_ResourceCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine']/method[@name='load' and count(parameter)=11 and parameter[1][@type='com.bumptech.glide.load.Key'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.bumptech.glide.load.data.DataFetcher&lt;T&gt;'] and parameter[5][@type='com.bumptech.glide.provider.DataLoadProvider&lt;T, Z&gt;'] and parameter[6][@type='com.bumptech.glide.load.Transformation&lt;Z&gt;'] and parameter[7][@type='com.bumptech.glide.load.resource.transcode.ResourceTranscoder&lt;Z, R&gt;'] and parameter[8][@type='com.bumptech.glide.Priority'] and parameter[9][@type='boolean'] and parameter[10][@type='com.bumptech.glide.load.engine.DiskCacheStrategy'] and parameter[11][@type='com.bumptech.glide.request.ResourceCallback']]"
		[Register ("load", "(Lcom/bumptech/glide/load/Key;IILcom/bumptech/glide/load/data/DataFetcher;Lcom/bumptech/glide/provider/DataLoadProvider;Lcom/bumptech/glide/load/Transformation;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Lcom/bumptech/glide/Priority;ZLcom/bumptech/glide/load/engine/DiskCacheStrategy;Lcom/bumptech/glide/request/ResourceCallback;)Lcom/bumptech/glide/load/engine/Engine$LoadStatus;", "GetLoad_Lcom_bumptech_glide_load_Key_IILcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_Priority_ZLcom_bumptech_glide_load_engine_DiskCacheStrategy_Lcom_bumptech_glide_request_ResourceCallback_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Z", "R"})]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.Engine.LoadStatus Load (global::Com.Bumptech.Glide.Load.IKey p0, int p1, int p2, global::Com.Bumptech.Glide.Load.Data.IDataFetcher p3, global::Com.Bumptech.Glide.Provider.IDataLoadProvider p4, global::Com.Bumptech.Glide.Load.ITransformation p5, global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder p6, global::Com.Bumptech.Glide.Priority p7, bool p8, global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy p9, global::Com.Bumptech.Glide.Request.IResourceCallback p10)
		{
			if (id_load_Lcom_bumptech_glide_load_Key_IILcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_Priority_ZLcom_bumptech_glide_load_engine_DiskCacheStrategy_Lcom_bumptech_glide_request_ResourceCallback_ == IntPtr.Zero)
				id_load_Lcom_bumptech_glide_load_Key_IILcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_Priority_ZLcom_bumptech_glide_load_engine_DiskCacheStrategy_Lcom_bumptech_glide_request_ResourceCallback_ = JNIEnv.GetMethodID (class_ref, "load", "(Lcom/bumptech/glide/load/Key;IILcom/bumptech/glide/load/data/DataFetcher;Lcom/bumptech/glide/provider/DataLoadProvider;Lcom/bumptech/glide/load/Transformation;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Lcom/bumptech/glide/Priority;ZLcom/bumptech/glide/load/engine/DiskCacheStrategy;Lcom/bumptech/glide/request/ResourceCallback;)Lcom/bumptech/glide/load/engine/Engine$LoadStatus;");
			try {
				JValue* __args = stackalloc JValue [11];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				__args [10] = new JValue (p10);

				global::Com.Bumptech.Glide.Load.Engine.Engine.LoadStatus __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Engine.LoadStatus> (JNIEnv.CallObjectMethod  (Handle, id_load_Lcom_bumptech_glide_load_Key_IILcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_provider_DataLoadProvider_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Lcom_bumptech_glide_Priority_ZLcom_bumptech_glide_load_engine_DiskCacheStrategy_Lcom_bumptech_glide_request_ResourceCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Engine.LoadStatus> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "(Lcom/bumptech/glide/load/Key;IILcom/bumptech/glide/load/data/DataFetcher;Lcom/bumptech/glide/provider/DataLoadProvider;Lcom/bumptech/glide/load/Transformation;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Lcom/bumptech/glide/Priority;ZLcom/bumptech/glide/load/engine/DiskCacheStrategy;Lcom/bumptech/glide/request/ResourceCallback;)Lcom/bumptech/glide/load/engine/Engine$LoadStatus;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_;
#pragma warning disable 0169
		static Delegate GetOnResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_Handler ()
		{
			if (cb_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_ == null)
				cb_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_);
			return cb_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_;
		}

		static void n_OnResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Engine.Engine __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Engine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p0 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResourceRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine']/method[@name='onResourceRemoved' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.Resource&lt;?&gt;']]"
		[Register ("onResourceRemoved", "(Lcom/bumptech/glide/load/engine/Resource;)V", "GetOnResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_Handler")]
		public virtual unsafe void OnResourceRemoved (global::Com.Bumptech.Glide.Load.Engine.IResource p0)
		{
			if (id_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_ == IntPtr.Zero)
				id_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_ = JNIEnv.GetMethodID (class_ref, "onResourceRemoved", "(Lcom/bumptech/glide/load/engine/Resource;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResourceRemoved", "(Lcom/bumptech/glide/load/engine/Resource;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_release_Lcom_bumptech_glide_load_engine_Resource_;
#pragma warning disable 0169
		static Delegate GetRelease_Lcom_bumptech_glide_load_engine_Resource_Handler ()
		{
			if (cb_release_Lcom_bumptech_glide_load_engine_Resource_ == null)
				cb_release_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Release_Lcom_bumptech_glide_load_engine_Resource_);
			return cb_release_Lcom_bumptech_glide_load_engine_Resource_;
		}

		static void n_Release_Lcom_bumptech_glide_load_engine_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Engine.Engine __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Engine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p0 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Release (p0);
		}
#pragma warning restore 0169

		static IntPtr id_release_Lcom_bumptech_glide_load_engine_Resource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='Engine']/method[@name='release' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.Resource']]"
		[Register ("release", "(Lcom/bumptech/glide/load/engine/Resource;)V", "GetRelease_Lcom_bumptech_glide_load_engine_Resource_Handler")]
		public virtual unsafe void Release (global::Com.Bumptech.Glide.Load.Engine.IResource p0)
		{
			if (id_release_Lcom_bumptech_glide_load_engine_Resource_ == IntPtr.Zero)
				id_release_Lcom_bumptech_glide_load_engine_Resource_ = JNIEnv.GetMethodID (class_ref, "release", "(Lcom/bumptech/glide/load/engine/Resource;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_release_Lcom_bumptech_glide_load_engine_Resource_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "(Lcom/bumptech/glide/load/engine/Resource;)V"), __args);
			} finally {
			}
		}

	}
}
