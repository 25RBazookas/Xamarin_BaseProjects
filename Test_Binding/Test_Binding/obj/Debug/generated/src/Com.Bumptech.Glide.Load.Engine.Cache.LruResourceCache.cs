using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='LruResourceCache']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/cache/LruResourceCache", DoNotGenerateAcw=true)]
	public partial class LruResourceCache : global::Com.Bumptech.Glide.Util.LruCache, global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/engine/cache/LruResourceCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LruResourceCache); }
		}

		protected LruResourceCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='LruResourceCache']/constructor[@name='LruResourceCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe LruResourceCache (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (LruResourceCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_getSize_Lcom_bumptech_glide_load_engine_Resource_;
#pragma warning disable 0169
		static Delegate GetGetSize_Lcom_bumptech_glide_load_engine_Resource_Handler ()
		{
			if (cb_getSize_Lcom_bumptech_glide_load_engine_Resource_ == null)
				cb_getSize_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetSize_Lcom_bumptech_glide_load_engine_Resource_);
			return cb_getSize_Lcom_bumptech_glide_load_engine_Resource_;
		}

		static int n_GetSize_Lcom_bumptech_glide_load_engine_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.LruResourceCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.LruResourceCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p0 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetSize (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSize_Lcom_bumptech_glide_load_engine_Resource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='LruResourceCache']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.Resource&lt;?&gt;']]"
		[Register ("getSize", "(Lcom/bumptech/glide/load/engine/Resource;)I", "GetGetSize_Lcom_bumptech_glide_load_engine_Resource_Handler")]
		protected virtual unsafe int GetSize (global::Com.Bumptech.Glide.Load.Engine.IResource p0)
		{
			if (id_getSize_Lcom_bumptech_glide_load_engine_Resource_ == IntPtr.Zero)
				id_getSize_Lcom_bumptech_glide_load_engine_Resource_ = JNIEnv.GetMethodID (class_ref, "getSize", "(Lcom/bumptech/glide/load/engine/Resource;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_getSize_Lcom_bumptech_glide_load_engine_Resource_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "(Lcom/bumptech/glide/load/engine/Resource;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;
#pragma warning disable 0169
		static Delegate GetOnItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_Handler ()
		{
			if (cb_onItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ == null)
				cb_onItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_);
			return cb_onItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;
		}

		static void n_OnItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.LruResourceCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.LruResourceCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IKey p0 = (global::Com.Bumptech.Glide.Load.IKey)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p1 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnItemEvicted (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='LruResourceCache']/method[@name='onItemEvicted' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.Key'] and parameter[2][@type='com.bumptech.glide.load.engine.Resource&lt;?&gt;']]"
		[Register ("onItemEvicted", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)V", "GetOnItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_Handler")]
		protected virtual unsafe void OnItemEvicted (global::Com.Bumptech.Glide.Load.IKey p0, global::Com.Bumptech.Glide.Load.Engine.IResource p1)
		{
			if (id_onItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ == IntPtr.Zero)
				id_onItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ = JNIEnv.GetMethodID (class_ref, "onItemEvicted", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onItemEvicted", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_;
#pragma warning disable 0169
		static Delegate GetSetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_Handler ()
		{
			if (cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_ == null)
				cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_);
			return cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_;
		}

		static void n_SetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.LruResourceCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.LruResourceCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener p0 = (global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResourceRemovedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='LruResourceCache']/method[@name='setResourceRemovedListener' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.cache.MemoryCache.ResourceRemovedListener']]"
		[Register ("setResourceRemovedListener", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener;)V", "GetSetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_Handler")]
		public virtual unsafe void SetResourceRemovedListener (global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener p0)
		{
			if (id_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_ == IntPtr.Zero)
				id_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_ = JNIEnv.GetMethodID (class_ref, "setResourceRemovedListener", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResourceRemovedListener", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_trimMemory_I;
#pragma warning disable 0169
		static Delegate GetTrimMemory_IHandler ()
		{
			if (cb_trimMemory_I == null)
				cb_trimMemory_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_TrimMemory_I);
			return cb_trimMemory_I;
		}

		static void n_TrimMemory_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.LruResourceCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.LruResourceCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrimMemory (p0);
		}
#pragma warning restore 0169

		static IntPtr id_trimMemory_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='LruResourceCache']/method[@name='trimMemory' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("trimMemory", "(I)V", "GetTrimMemory_IHandler")]
		public virtual unsafe void TrimMemory (int p0)
		{
			if (id_trimMemory_I == IntPtr.Zero)
				id_trimMemory_I = JNIEnv.GetMethodID (class_ref, "trimMemory", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_trimMemory_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trimMemory", "(I)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener"
		public event EventHandler<global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheResourceRemovedEventArgs> ResourceRemoved {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener, global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListenerImplementor>(
						ref weak_implementor_SetResourceRemovedListener,
						__CreateIMemoryCacheResourceRemovedListenerImplementor,
						SetResourceRemovedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener, global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListenerImplementor>(
						ref weak_implementor_SetResourceRemovedListener,
						global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListenerImplementor.__IsEmpty,
						__v => SetResourceRemovedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetResourceRemovedListener;

		global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListenerImplementor __CreateIMemoryCacheResourceRemovedListenerImplementor ()
		{
			return new global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListenerImplementor (this);
		}
#endregion
	}
}
