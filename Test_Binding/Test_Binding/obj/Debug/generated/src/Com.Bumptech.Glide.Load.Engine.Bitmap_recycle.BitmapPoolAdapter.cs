using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine.Bitmap_recycle {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='BitmapPoolAdapter']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/bitmap_recycle/BitmapPoolAdapter", DoNotGenerateAcw=true)]
	public partial class BitmapPoolAdapter : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/engine/bitmap_recycle/BitmapPoolAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapPoolAdapter); }
		}

		protected BitmapPoolAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='BitmapPoolAdapter']/constructor[@name='BitmapPoolAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BitmapPoolAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BitmapPoolAdapter)) {
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.BitmapPoolAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.BitmapPoolAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxSize;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxSize;
		public virtual unsafe int MaxSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='BitmapPoolAdapter']/method[@name='getMaxSize' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.BitmapPoolAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.BitmapPoolAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearMemory ();
		}
#pragma warning restore 0169

		static IntPtr id_clearMemory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='BitmapPoolAdapter']/method[@name='clearMemory' and count(parameter)=0]"
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

		static Delegate cb_get_IILandroid_graphics_Bitmap_Config_;
#pragma warning disable 0169
		static Delegate GetGet_IILandroid_graphics_Bitmap_Config_Handler ()
		{
			if (cb_get_IILandroid_graphics_Bitmap_Config_ == null)
				cb_get_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_Get_IILandroid_graphics_Bitmap_Config_);
			return cb_get_IILandroid_graphics_Bitmap_Config_;
		}

		static IntPtr n_Get_IILandroid_graphics_Bitmap_Config_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.BitmapPoolAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.BitmapPoolAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap.Config p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_IILandroid_graphics_Bitmap_Config_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='BitmapPoolAdapter']/method[@name='get' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap.Config']]"
		[Register ("get", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", "GetGet_IILandroid_graphics_Bitmap_Config_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap Get (int p0, int p1, global::Android.Graphics.Bitmap.Config p2)
		{
			if (id_get_IILandroid_graphics_Bitmap_Config_ == IntPtr.Zero)
				id_get_IILandroid_graphics_Bitmap_Config_ = JNIEnv.GetMethodID (class_ref, "get", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Android.Graphics.Bitmap __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_get_IILandroid_graphics_Bitmap_Config_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getDirty_IILandroid_graphics_Bitmap_Config_;
#pragma warning disable 0169
		static Delegate GetGetDirty_IILandroid_graphics_Bitmap_Config_Handler ()
		{
			if (cb_getDirty_IILandroid_graphics_Bitmap_Config_ == null)
				cb_getDirty_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_GetDirty_IILandroid_graphics_Bitmap_Config_);
			return cb_getDirty_IILandroid_graphics_Bitmap_Config_;
		}

		static IntPtr n_GetDirty_IILandroid_graphics_Bitmap_Config_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.BitmapPoolAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.BitmapPoolAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap.Config p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDirty (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDirty_IILandroid_graphics_Bitmap_Config_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='BitmapPoolAdapter']/method[@name='getDirty' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap.Config']]"
		[Register ("getDirty", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", "GetGetDirty_IILandroid_graphics_Bitmap_Config_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap GetDirty (int p0, int p1, global::Android.Graphics.Bitmap.Config p2)
		{
			if (id_getDirty_IILandroid_graphics_Bitmap_Config_ == IntPtr.Zero)
				id_getDirty_IILandroid_graphics_Bitmap_Config_ = JNIEnv.GetMethodID (class_ref, "getDirty", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Android.Graphics.Bitmap __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getDirty_IILandroid_graphics_Bitmap_Config_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDirty", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_put_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetPut_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_put_Landroid_graphics_Bitmap_ == null)
				cb_put_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Put_Landroid_graphics_Bitmap_);
			return cb_put_Landroid_graphics_Bitmap_;
		}

		static bool n_Put_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.BitmapPoolAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.BitmapPoolAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Put (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='BitmapPoolAdapter']/method[@name='put' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("put", "(Landroid/graphics/Bitmap;)Z", "GetPut_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe bool Put (global::Android.Graphics.Bitmap p0)
		{
			if (id_put_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_put_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "put", "(Landroid/graphics/Bitmap;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_put_Landroid_graphics_Bitmap_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Landroid/graphics/Bitmap;)Z"), __args);
				return __ret;
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.BitmapPoolAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.BitmapPoolAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSizeMultiplier (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSizeMultiplier_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='BitmapPoolAdapter']/method[@name='setSizeMultiplier' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.BitmapPoolAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.BitmapPoolAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrimMemory (p0);
		}
#pragma warning restore 0169

		static IntPtr id_trimMemory_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='BitmapPoolAdapter']/method[@name='trimMemory' and count(parameter)=1 and parameter[1][@type='int']]"
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

	}
}
