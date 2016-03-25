using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine.Bitmap_recycle {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/interface[@name='BitmapPool']"
	[Register ("com/bumptech/glide/load/engine/bitmap_recycle/BitmapPool", "", "Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPoolInvoker")]
	public partial interface IBitmapPool : IJavaObject {

		int MaxSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/interface[@name='BitmapPool']/method[@name='getMaxSize' and count(parameter)=0]"
			[Register ("getMaxSize", "()I", "GetGetMaxSizeHandler:Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPoolInvoker, Test_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/interface[@name='BitmapPool']/method[@name='clearMemory' and count(parameter)=0]"
		[Register ("clearMemory", "()V", "GetClearMemoryHandler:Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPoolInvoker, Test_Binding")]
		void ClearMemory ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/interface[@name='BitmapPool']/method[@name='get' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap.Config']]"
		[Register ("get", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", "GetGet_IILandroid_graphics_Bitmap_Config_Handler:Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPoolInvoker, Test_Binding")]
		global::Android.Graphics.Bitmap Get (int p0, int p1, global::Android.Graphics.Bitmap.Config p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/interface[@name='BitmapPool']/method[@name='getDirty' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap.Config']]"
		[Register ("getDirty", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", "GetGetDirty_IILandroid_graphics_Bitmap_Config_Handler:Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPoolInvoker, Test_Binding")]
		global::Android.Graphics.Bitmap GetDirty (int p0, int p1, global::Android.Graphics.Bitmap.Config p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/interface[@name='BitmapPool']/method[@name='put' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("put", "(Landroid/graphics/Bitmap;)Z", "GetPut_Landroid_graphics_Bitmap_Handler:Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPoolInvoker, Test_Binding")]
		bool Put (global::Android.Graphics.Bitmap p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/interface[@name='BitmapPool']/method[@name='setSizeMultiplier' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setSizeMultiplier", "(F)V", "GetSetSizeMultiplier_FHandler:Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPoolInvoker, Test_Binding")]
		void SetSizeMultiplier (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/interface[@name='BitmapPool']/method[@name='trimMemory' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("trimMemory", "(I)V", "GetTrimMemory_IHandler:Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPoolInvoker, Test_Binding")]
		void TrimMemory (int p0);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/bitmap_recycle/BitmapPool", DoNotGenerateAcw=true)]
	internal class IBitmapPoolInvoker : global::Java.Lang.Object, IBitmapPool {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/engine/bitmap_recycle/BitmapPool");
		IntPtr class_ref;

		public static IBitmapPool GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBitmapPool> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBitmapPoolInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBitmapPoolInvoker); }
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap.Config p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_IILandroid_graphics_Bitmap_Config_;
		public unsafe global::Android.Graphics.Bitmap Get (int p0, int p1, global::Android.Graphics.Bitmap.Config p2)
		{
			if (id_get_IILandroid_graphics_Bitmap_Config_ == IntPtr.Zero)
				id_get_IILandroid_graphics_Bitmap_Config_ = JNIEnv.GetMethodID (class_ref, "get", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_get_IILandroid_graphics_Bitmap_Config_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap.Config p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDirty (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDirty_IILandroid_graphics_Bitmap_Config_;
		public unsafe global::Android.Graphics.Bitmap GetDirty (int p0, int p1, global::Android.Graphics.Bitmap.Config p2)
		{
			if (id_getDirty_IILandroid_graphics_Bitmap_Config_ == IntPtr.Zero)
				id_getDirty_IILandroid_graphics_Bitmap_Config_ = JNIEnv.GetMethodID (class_ref, "getDirty", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_getDirty_IILandroid_graphics_Bitmap_Config_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Put (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_put_Landroid_graphics_Bitmap_;
		public unsafe bool Put (global::Android.Graphics.Bitmap p0)
		{
			if (id_put_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_put_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "put", "(Landroid/graphics/Bitmap;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_put_Landroid_graphics_Bitmap_, __args);
			return __ret;
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
