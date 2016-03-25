using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemoryCacheAdapter']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/cache/MemoryCacheAdapter", DoNotGenerateAcw=true)]
	public partial class MemoryCacheAdapter : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/engine/cache/MemoryCacheAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MemoryCacheAdapter); }
		}

		protected MemoryCacheAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemoryCacheAdapter']/constructor[@name='MemoryCacheAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MemoryCacheAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MemoryCacheAdapter)) {
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

		static Delegate cb_getCurrentSize;
#pragma warning disable 0169
		static Delegate GetGetCurrentSizeHandler ()
		{
			if (cb_getCurrentSize == null)
				cb_getCurrentSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentSize);
			return cb_getCurrentSize;
		}

		static int n_GetCurrentSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentSize;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentSize;
		public virtual unsafe int CurrentSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemoryCacheAdapter']/method[@name='getCurrentSize' and count(parameter)=0]"
			[Register ("getCurrentSize", "()I", "GetGetCurrentSizeHandler")]
			get {
				if (id_getCurrentSize == IntPtr.Zero)
					id_getCurrentSize = JNIEnv.GetMethodID (class_ref, "getCurrentSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCurrentSize);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxSize;
#pragma warning disable 0169
		static Delegate GetGetMaxSizeHandler ()
		{
			if (cb_getMaxSize == null)
				cb_getMaxSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxSize);
			return cb_getMaxSize;
		}

		static int n_GetMaxSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxSize;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxSize;
		public virtual unsafe int MaxSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemoryCacheAdapter']/method[@name='getMaxSize' and count(parameter)=0]"
			[Register ("getMaxSize", "()I", "GetGetMaxSizeHandler")]
			get {
				if (id_getMaxSize == IntPtr.Zero)
					id_getMaxSize = JNIEnv.GetMethodID (class_ref, "getMaxSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMaxSize);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_clearMemory;
#pragma warning disable 0169
		static Delegate GetClearMemoryHandler ()
		{
			if (cb_clearMemory == null)
				cb_clearMemory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearMemory);
			return cb_clearMemory;
		}

		static void n_ClearMemory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearMemory ();
		}
#pragma warning restore 0169

		static IntPtr id_clearMemory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemoryCacheAdapter']/method[@name='clearMemory' and count(parameter)=0]"
		[Register ("clearMemory", "()V", "GetClearMemoryHandler")]
		public virtual unsafe void ClearMemory ()
		{
			if (id_clearMemory == IntPtr.Zero)
				id_clearMemory = JNIEnv.GetMethodID (class_ref, "clearMemory", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearMemory);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearMemory", "()V"));
			} finally {
			}
		}

		static Delegate cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;
#pragma warning disable 0169
		static Delegate GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_Handler ()
		{
			if (cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ == null)
				cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_);
			return cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;
		}

		static IntPtr n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IKey p0 = (global::Com.Bumptech.Glide.Load.IKey)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p1 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemoryCacheAdapter']/method[@name='put' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.Key'] and parameter[2][@type='com.bumptech.glide.load.engine.Resource&lt;?&gt;']]"
		[Register ("put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;", "GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Put (global::Com.Bumptech.Glide.Load.IKey p0, global::Com.Bumptech.Glide.Load.Engine.IResource p1)
		{
			if (id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ == IntPtr.Zero)
				id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ = JNIEnv.GetMethodID (class_ref, "put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Bumptech.Glide.Load.Engine.IResource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod  (Handle, id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_remove_Lcom_bumptech_glide_load_Key_;
#pragma warning disable 0169
		static Delegate GetRemove_Lcom_bumptech_glide_load_Key_Handler ()
		{
			if (cb_remove_Lcom_bumptech_glide_load_Key_ == null)
				cb_remove_Lcom_bumptech_glide_load_Key_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Lcom_bumptech_glide_load_Key_);
			return cb_remove_Lcom_bumptech_glide_load_Key_;
		}

		static IntPtr n_Remove_Lcom_bumptech_glide_load_Key_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IKey p0 = (global::Com.Bumptech.Glide.Load.IKey)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Remove (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_remove_Lcom_bumptech_glide_load_Key_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemoryCacheAdapter']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.Key']]"
		[Register ("remove", "(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/load/engine/Resource;", "GetRemove_Lcom_bumptech_glide_load_Key_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Remove (global::Com.Bumptech.Glide.Load.IKey p0)
		{
			if (id_remove_Lcom_bumptech_glide_load_Key_ == IntPtr.Zero)
				id_remove_Lcom_bumptech_glide_load_Key_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/load/engine/Resource;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.Load.Engine.IResource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod  (Handle, id_remove_Lcom_bumptech_glide_load_Key_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/load/engine/Resource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener p0 = (global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResourceRemovedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemoryCacheAdapter']/method[@name='setResourceRemovedListener' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.cache.MemoryCache.ResourceRemovedListener']]"
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

		static Delegate cb_setSizeMultiplier_F;
#pragma warning disable 0169
		static Delegate GetSetSizeMultiplier_FHandler ()
		{
			if (cb_setSizeMultiplier_F == null)
				cb_setSizeMultiplier_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSizeMultiplier_F);
			return cb_setSizeMultiplier_F;
		}

		static void n_SetSizeMultiplier_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSizeMultiplier (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSizeMultiplier_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemoryCacheAdapter']/method[@name='setSizeMultiplier' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setSizeMultiplier", "(F)V", "GetSetSizeMultiplier_FHandler")]
		public virtual unsafe void SetSizeMultiplier (float p0)
		{
			if (id_setSizeMultiplier_F == IntPtr.Zero)
				id_setSizeMultiplier_F = JNIEnv.GetMethodID (class_ref, "setSizeMultiplier", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSizeMultiplier_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSizeMultiplier", "(F)V"), __args);
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrimMemory (p0);
		}
#pragma warning restore 0169

		static IntPtr id_trimMemory_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemoryCacheAdapter']/method[@name='trimMemory' and count(parameter)=1 and parameter[1][@type='int']]"
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
