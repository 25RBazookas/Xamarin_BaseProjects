using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='MemoryCache.ResourceRemovedListener']"
	[Register ("com/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener", "", "Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListenerInvoker")]
	public partial interface IMemoryCacheResourceRemovedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='MemoryCache.ResourceRemovedListener']/method[@name='onResourceRemoved' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.Resource&lt;?&gt;']]"
		[Register ("onResourceRemoved", "(Lcom/bumptech/glide/load/engine/Resource;)V", "GetOnResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_Handler:Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListenerInvoker, Test_Binding")]
		void OnResourceRemoved (global::Com.Bumptech.Glide.Load.Engine.IResource p0);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener", DoNotGenerateAcw=true)]
	internal class IMemoryCacheResourceRemovedListenerInvoker : global::Java.Lang.Object, IMemoryCacheResourceRemovedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener");
		IntPtr class_ref;

		public static IMemoryCacheResourceRemovedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMemoryCacheResourceRemovedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.engine.cache.MemoryCache.ResourceRemovedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMemoryCacheResourceRemovedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMemoryCacheResourceRemovedListenerInvoker); }
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p0 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResourceRemoved (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_;
		public unsafe void OnResourceRemoved (global::Com.Bumptech.Glide.Load.Engine.IResource p0)
		{
			if (id_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_ == IntPtr.Zero)
				id_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_ = JNIEnv.GetMethodID (class_ref, "onResourceRemoved", "(Lcom/bumptech/glide/load/engine/Resource;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_, __args);
		}

	}

	public partial class MemoryCacheResourceRemovedEventArgs : global::System.EventArgs {

		public MemoryCacheResourceRemovedEventArgs (global::Com.Bumptech.Glide.Load.Engine.IResource p0)
		{
			this.p0 = p0;
		}

		global::Com.Bumptech.Glide.Load.Engine.IResource p0;
		public global::Com.Bumptech.Glide.Load.Engine.IResource P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/bumptech/glide/load/engine/cache/MemoryCache_ResourceRemovedListenerImplementor")]
	internal sealed partial class IMemoryCacheResourceRemovedListenerImplementor : global::Java.Lang.Object, IMemoryCacheResourceRemovedListener {

		object sender;

		public IMemoryCacheResourceRemovedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/bumptech/glide/load/engine/cache/MemoryCache_ResourceRemovedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MemoryCacheResourceRemovedEventArgs> Handler;
#pragma warning restore 0649

		public void OnResourceRemoved (global::Com.Bumptech.Glide.Load.Engine.IResource p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MemoryCacheResourceRemovedEventArgs (p0));
		}

		internal static bool __IsEmpty (IMemoryCacheResourceRemovedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='MemoryCache']"
	[Register ("com/bumptech/glide/load/engine/cache/MemoryCache", "", "Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker")]
	public partial interface IMemoryCache : IJavaObject {

		int CurrentSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='MemoryCache']/method[@name='getCurrentSize' and count(parameter)=0]"
			[Register ("getCurrentSize", "()I", "GetGetCurrentSizeHandler:Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Test_Binding")] get;
		}

		int MaxSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='MemoryCache']/method[@name='getMaxSize' and count(parameter)=0]"
			[Register ("getMaxSize", "()I", "GetGetMaxSizeHandler:Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Test_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='MemoryCache']/method[@name='clearMemory' and count(parameter)=0]"
		[Register ("clearMemory", "()V", "GetClearMemoryHandler:Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Test_Binding")]
		void ClearMemory ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='MemoryCache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.Key'] and parameter[2][@type='com.bumptech.glide.load.engine.Resource&lt;?&gt;']]"
		[Register ("put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;", "GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_Handler:Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Test_Binding")]
		global::Com.Bumptech.Glide.Load.Engine.IResource Put (global::Com.Bumptech.Glide.Load.IKey p0, global::Com.Bumptech.Glide.Load.Engine.IResource p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='MemoryCache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.Key']]"
		[Register ("remove", "(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/load/engine/Resource;", "GetRemove_Lcom_bumptech_glide_load_Key_Handler:Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Test_Binding")]
		global::Com.Bumptech.Glide.Load.Engine.IResource Remove (global::Com.Bumptech.Glide.Load.IKey p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='MemoryCache']/method[@name='setResourceRemovedListener' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.cache.MemoryCache.ResourceRemovedListener']]"
		[Register ("setResourceRemovedListener", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener;)V", "GetSetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_Handler:Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Test_Binding")]
		void SetResourceRemovedListener (global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='MemoryCache']/method[@name='setSizeMultiplier' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setSizeMultiplier", "(F)V", "GetSetSizeMultiplier_FHandler:Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Test_Binding")]
		void SetSizeMultiplier (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='MemoryCache']/method[@name='trimMemory' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("trimMemory", "(I)V", "GetTrimMemory_IHandler:Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheInvoker, Test_Binding")]
		void TrimMemory (int p0);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/cache/MemoryCache", DoNotGenerateAcw=true)]
	internal class IMemoryCacheInvoker : global::Java.Lang.Object, IMemoryCache {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/engine/cache/MemoryCache");
		IntPtr class_ref;

		public static IMemoryCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMemoryCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.engine.cache.MemoryCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMemoryCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMemoryCacheInvoker); }
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentSize;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentSize;
		public unsafe int CurrentSize {
			get {
				if (id_getCurrentSize == IntPtr.Zero)
					id_getCurrentSize = JNIEnv.GetMethodID (class_ref, "getCurrentSize", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getCurrentSize);
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxSize;
		}
#pragma warning restore 0169

		IntPtr id_getMaxSize;
		public unsafe int MaxSize {
			get {
				if (id_getMaxSize == IntPtr.Zero)
					id_getMaxSize = JNIEnv.GetMethodID (class_ref, "getMaxSize", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getMaxSize);
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearMemory ();
		}
#pragma warning restore 0169

		IntPtr id_clearMemory;
		public unsafe void ClearMemory ()
		{
			if (id_clearMemory == IntPtr.Zero)
				id_clearMemory = JNIEnv.GetMethodID (class_ref, "clearMemory", "()V");
			JNIEnv.CallVoidMethod (Handle, id_clearMemory);
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IKey p0 = (global::Com.Bumptech.Glide.Load.IKey)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p1 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;
		public unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Put (global::Com.Bumptech.Glide.Load.IKey p0, global::Com.Bumptech.Glide.Load.Engine.IResource p1)
		{
			if (id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ == IntPtr.Zero)
				id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ = JNIEnv.GetMethodID (class_ref, "put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Com.Bumptech.Glide.Load.Engine.IResource __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod (Handle, id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IKey p0 = (global::Com.Bumptech.Glide.Load.IKey)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Remove (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_remove_Lcom_bumptech_glide_load_Key_;
		public unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Remove (global::Com.Bumptech.Glide.Load.IKey p0)
		{
			if (id_remove_Lcom_bumptech_glide_load_Key_ == IntPtr.Zero)
				id_remove_Lcom_bumptech_glide_load_Key_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/load/engine/Resource;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Bumptech.Glide.Load.Engine.IResource __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod (Handle, id_remove_Lcom_bumptech_glide_load_Key_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener p0 = (global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResourceRemovedListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_;
		public unsafe void SetResourceRemovedListener (global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCacheResourceRemovedListener p0)
		{
			if (id_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_ == IntPtr.Zero)
				id_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_ = JNIEnv.GetMethodID (class_ref, "setResourceRemovedListener", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_, __args);
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSizeMultiplier (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSizeMultiplier_F;
		public unsafe void SetSizeMultiplier (float p0)
		{
			if (id_setSizeMultiplier_F == IntPtr.Zero)
				id_setSizeMultiplier_F = JNIEnv.GetMethodID (class_ref, "setSizeMultiplier", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setSizeMultiplier_F, __args);
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
			global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.IMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrimMemory (p0);
		}
#pragma warning restore 0169

		IntPtr id_trimMemory_I;
		public unsafe void TrimMemory (int p0)
		{
			if (id_trimMemory_I == IntPtr.Zero)
				id_trimMemory_I = JNIEnv.GetMethodID (class_ref, "trimMemory", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_trimMemory_I, __args);
		}

	}

}
