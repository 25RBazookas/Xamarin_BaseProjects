using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LruCache']"
	[global::Android.Runtime.Register ("com/bumptech/glide/util/LruCache", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Y"})]
	public partial class LruCache : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/util/LruCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LruCache); }
		}

		protected LruCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LruCache']/constructor[@name='LruCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe LruCache (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (LruCache)) {
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
			global::Com.Bumptech.Glide.Util.LruCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.LruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentSize;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentSize;
		public virtual unsafe int CurrentSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LruCache']/method[@name='getCurrentSize' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Util.LruCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.LruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxSize;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxSize;
		public virtual unsafe int MaxSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LruCache']/method[@name='getMaxSize' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Util.LruCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.LruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearMemory ();
		}
#pragma warning restore 0169

		static IntPtr id_clearMemory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LruCache']/method[@name='clearMemory' and count(parameter)=0]"
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

		static Delegate cb_contains_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetContains_Ljava_lang_Object_Handler ()
		{
			if (cb_contains_Ljava_lang_Object_ == null)
				cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Ljava_lang_Object_);
			return cb_contains_Ljava_lang_Object_;
		}

		static bool n_Contains_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Util.LruCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.LruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_contains_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LruCache']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("contains", "(Ljava/lang/Object;)Z", "GetContains_Ljava_lang_Object_Handler")]
		public virtual unsafe bool Contains (global::Java.Lang.Object p0)
		{
			if (id_contains_Ljava_lang_Object_ == IntPtr.Zero)
				id_contains_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_contains_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(Ljava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_get_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_Object_Handler ()
		{
			if (cb_get_Ljava_lang_Object_ == null)
				cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_Object_);
			return cb_get_Ljava_lang_Object_;
		}

		static IntPtr n_Get_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Util.LruCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.LruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LruCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (global::Java.Lang.Object p0)
		{
			if (id_get_Ljava_lang_Object_ == IntPtr.Zero)
				id_get_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getSize_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetSize_Ljava_lang_Object_Handler ()
		{
			if (cb_getSize_Ljava_lang_Object_ == null)
				cb_getSize_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetSize_Ljava_lang_Object_);
			return cb_getSize_Ljava_lang_Object_;
		}

		static int n_GetSize_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Util.LruCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.LruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetSize (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSize_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LruCache']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='Y']]"
		[Register ("getSize", "(Ljava/lang/Object;)I", "GetGetSize_Ljava_lang_Object_Handler")]
		protected virtual unsafe int GetSize (global::Java.Lang.Object p0)
		{
			if (id_getSize_Ljava_lang_Object_ == IntPtr.Zero)
				id_getSize_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getSize", "(Ljava/lang/Object;)I");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_getSize_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "(Ljava/lang/Object;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onItemEvicted_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnItemEvicted_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_onItemEvicted_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_onItemEvicted_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnItemEvicted_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_onItemEvicted_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_OnItemEvicted_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Util.LruCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.LruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnItemEvicted (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onItemEvicted_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LruCache']/method[@name='onItemEvicted' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='Y']]"
		[Register ("onItemEvicted", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetOnItemEvicted_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		protected virtual unsafe void OnItemEvicted (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_onItemEvicted_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_onItemEvicted_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onItemEvicted", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onItemEvicted_Ljava_lang_Object_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onItemEvicted", "(Ljava/lang/Object;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_put_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_put_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_Put_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Util.LruCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.LruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LruCache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='Y']]"
		[Register ("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Put (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_put_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_put_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_put_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_remove_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_Object_Handler ()
		{
			if (cb_remove_Ljava_lang_Object_ == null)
				cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_Object_);
			return cb_remove_Ljava_lang_Object_;
		}

		static IntPtr n_Remove_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Util.LruCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.LruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Remove (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LruCache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetRemove_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Remove (global::Java.Lang.Object p0)
		{
			if (id_remove_Ljava_lang_Object_ == IntPtr.Zero)
				id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_remove_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Bumptech.Glide.Util.LruCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.LruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSizeMultiplier (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSizeMultiplier_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LruCache']/method[@name='setSizeMultiplier' and count(parameter)=1 and parameter[1][@type='float']]"
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

		static Delegate cb_trimToSize_I;
#pragma warning disable 0169
		static Delegate GetTrimToSize_IHandler ()
		{
			if (cb_trimToSize_I == null)
				cb_trimToSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_TrimToSize_I);
			return cb_trimToSize_I;
		}

		static void n_TrimToSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.Util.LruCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.LruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrimToSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_trimToSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LruCache']/method[@name='trimToSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("trimToSize", "(I)V", "GetTrimToSize_IHandler")]
		protected virtual unsafe void TrimToSize (int p0)
		{
			if (id_trimToSize_I == IntPtr.Zero)
				id_trimToSize_I = JNIEnv.GetMethodID (class_ref, "trimToSize", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_trimToSize_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trimToSize", "(I)V"), __args);
			} finally {
			}
		}

	}
}
