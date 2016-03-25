using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine.Bitmap_recycle {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='SizeConfigStrategy']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/bitmap_recycle/SizeConfigStrategy", DoNotGenerateAcw=true)]
	public partial class SizeConfigStrategy : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.ILruPoolStrategy {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='SizeConfigStrategy.Key']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/bitmap_recycle/SizeConfigStrategy$Key", DoNotGenerateAcw=true)]
		public sealed partial class Key : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IPoolable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/engine/bitmap_recycle/SizeConfigStrategy$Key", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Key); }
			}

			internal Key (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_bumptech_glide_load_engine_bitmap_recycle_SizeConfigStrategy_KeyPool_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='SizeConfigStrategy.Key']/constructor[@name='SizeConfigStrategy.Key' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.bitmap_recycle.SizeConfigStrategy.KeyPool']]"
			[Register (".ctor", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/SizeConfigStrategy$KeyPool;)V", "")]
			public unsafe Key (global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.SizeConfigStrategy.KeyPool p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (Key)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/engine/bitmap_recycle/SizeConfigStrategy$KeyPool;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/engine/bitmap_recycle/SizeConfigStrategy$KeyPool;)V", __args);
						return;
					}

					if (id_ctor_Lcom_bumptech_glide_load_engine_bitmap_recycle_SizeConfigStrategy_KeyPool_ == IntPtr.Zero)
						id_ctor_Lcom_bumptech_glide_load_engine_bitmap_recycle_SizeConfigStrategy_KeyPool_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/SizeConfigStrategy$KeyPool;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_engine_bitmap_recycle_SizeConfigStrategy_KeyPool_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_engine_bitmap_recycle_SizeConfigStrategy_KeyPool_, __args);
				} finally {
				}
			}

			static IntPtr id_init_ILandroid_graphics_Bitmap_Config_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='SizeConfigStrategy.Key']/method[@name='init' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.Bitmap.Config']]"
			[Register ("init", "(ILandroid/graphics/Bitmap$Config;)V", "")]
			public unsafe void Init (int p0, global::Android.Graphics.Bitmap.Config p1)
			{
				if (id_init_ILandroid_graphics_Bitmap_Config_ == IntPtr.Zero)
					id_init_ILandroid_graphics_Bitmap_Config_ = JNIEnv.GetMethodID (class_ref, "init", "(ILandroid/graphics/Bitmap$Config;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					JNIEnv.CallVoidMethod  (Handle, id_init_ILandroid_graphics_Bitmap_Config_, __args);
				} finally {
				}
			}

			static IntPtr id_offer;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='SizeConfigStrategy.Key']/method[@name='offer' and count(parameter)=0]"
			[Register ("offer", "()V", "")]
			public unsafe void Offer ()
			{
				if (id_offer == IntPtr.Zero)
					id_offer = JNIEnv.GetMethodID (class_ref, "offer", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_offer);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='SizeConfigStrategy.KeyPool']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/bitmap_recycle/SizeConfigStrategy$KeyPool", DoNotGenerateAcw=true)]
		public partial class KeyPool : global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.BaseKeyPool {

			protected KeyPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/engine/bitmap_recycle/SizeConfigStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SizeConfigStrategy); }
		}

		protected SizeConfigStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='SizeConfigStrategy']/constructor[@name='SizeConfigStrategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SizeConfigStrategy ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SizeConfigStrategy)) {
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.SizeConfigStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.SizeConfigStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap.Config p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_IILandroid_graphics_Bitmap_Config_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='SizeConfigStrategy']/method[@name='get' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap.Config']]"
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

		static Delegate cb_getSize_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetGetSize_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_getSize_Landroid_graphics_Bitmap_ == null)
				cb_getSize_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetSize_Landroid_graphics_Bitmap_);
			return cb_getSize_Landroid_graphics_Bitmap_;
		}

		static int n_GetSize_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.SizeConfigStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.SizeConfigStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetSize (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSize_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='SizeConfigStrategy']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("getSize", "(Landroid/graphics/Bitmap;)I", "GetGetSize_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe int GetSize (global::Android.Graphics.Bitmap p0)
		{
			if (id_getSize_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_getSize_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "getSize", "(Landroid/graphics/Bitmap;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_getSize_Landroid_graphics_Bitmap_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "(Landroid/graphics/Bitmap;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_logBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetLogBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_logBitmap_Landroid_graphics_Bitmap_ == null)
				cb_logBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LogBitmap_Landroid_graphics_Bitmap_);
			return cb_logBitmap_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_LogBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.SizeConfigStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.SizeConfigStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.LogBitmap (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_logBitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='SizeConfigStrategy']/method[@name='logBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("logBitmap", "(Landroid/graphics/Bitmap;)Ljava/lang/String;", "GetLogBitmap_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe string LogBitmap (global::Android.Graphics.Bitmap p0)
		{
			if (id_logBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_logBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "logBitmap", "(Landroid/graphics/Bitmap;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_logBitmap_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logBitmap", "(Landroid/graphics/Bitmap;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_logBitmap_IILandroid_graphics_Bitmap_Config_;
#pragma warning disable 0169
		static Delegate GetLogBitmap_IILandroid_graphics_Bitmap_Config_Handler ()
		{
			if (cb_logBitmap_IILandroid_graphics_Bitmap_Config_ == null)
				cb_logBitmap_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_LogBitmap_IILandroid_graphics_Bitmap_Config_);
			return cb_logBitmap_IILandroid_graphics_Bitmap_Config_;
		}

		static IntPtr n_LogBitmap_IILandroid_graphics_Bitmap_Config_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.SizeConfigStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.SizeConfigStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap.Config p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.LogBitmap (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_logBitmap_IILandroid_graphics_Bitmap_Config_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='SizeConfigStrategy']/method[@name='logBitmap' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap.Config']]"
		[Register ("logBitmap", "(IILandroid/graphics/Bitmap$Config;)Ljava/lang/String;", "GetLogBitmap_IILandroid_graphics_Bitmap_Config_Handler")]
		public virtual unsafe string LogBitmap (int p0, int p1, global::Android.Graphics.Bitmap.Config p2)
		{
			if (id_logBitmap_IILandroid_graphics_Bitmap_Config_ == IntPtr.Zero)
				id_logBitmap_IILandroid_graphics_Bitmap_Config_ = JNIEnv.GetMethodID (class_ref, "logBitmap", "(IILandroid/graphics/Bitmap$Config;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_logBitmap_IILandroid_graphics_Bitmap_Config_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logBitmap", "(IILandroid/graphics/Bitmap$Config;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_put_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetPut_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_put_Landroid_graphics_Bitmap_ == null)
				cb_put_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Put_Landroid_graphics_Bitmap_);
			return cb_put_Landroid_graphics_Bitmap_;
		}

		static void n_Put_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.SizeConfigStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.SizeConfigStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0);
		}
#pragma warning restore 0169

		static IntPtr id_put_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='SizeConfigStrategy']/method[@name='put' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("put", "(Landroid/graphics/Bitmap;)V", "GetPut_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void Put (global::Android.Graphics.Bitmap p0)
		{
			if (id_put_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_put_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "put", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_put_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Landroid/graphics/Bitmap;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeLast;
#pragma warning disable 0169
		static Delegate GetRemoveLastHandler ()
		{
			if (cb_removeLast == null)
				cb_removeLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveLast);
			return cb_removeLast;
		}

		static IntPtr n_RemoveLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.SizeConfigStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.SizeConfigStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveLast ());
		}
#pragma warning restore 0169

		static IntPtr id_removeLast;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='SizeConfigStrategy']/method[@name='removeLast' and count(parameter)=0]"
		[Register ("removeLast", "()Landroid/graphics/Bitmap;", "GetRemoveLastHandler")]
		public virtual unsafe global::Android.Graphics.Bitmap RemoveLast ()
		{
			if (id_removeLast == IntPtr.Zero)
				id_removeLast = JNIEnv.GetMethodID (class_ref, "removeLast", "()Landroid/graphics/Bitmap;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_removeLast), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeLast", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
