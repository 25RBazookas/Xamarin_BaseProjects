using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine.Bitmap_recycle {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/bitmap_recycle/LruBitmapPool", DoNotGenerateAcw=true)]
	public partial class LruBitmapPool : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/interface[@name='LruBitmapPool.BitmapTracker']"
		[Register ("com/bumptech/glide/load/engine/bitmap_recycle/LruBitmapPool$BitmapTracker", "", "Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool/IBitmapTrackerInvoker")]
		public partial interface IBitmapTracker : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/interface[@name='LruBitmapPool.BitmapTracker']/method[@name='add' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("add", "(Landroid/graphics/Bitmap;)V", "GetAdd_Landroid_graphics_Bitmap_Handler:Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool/IBitmapTrackerInvoker, Test_Binding")]
			void Add (global::Android.Graphics.Bitmap p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/interface[@name='LruBitmapPool.BitmapTracker']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("remove", "(Landroid/graphics/Bitmap;)V", "GetRemove_Landroid_graphics_Bitmap_Handler:Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool/IBitmapTrackerInvoker, Test_Binding")]
			void Remove (global::Android.Graphics.Bitmap p0);

		}

		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/bitmap_recycle/LruBitmapPool$BitmapTracker", DoNotGenerateAcw=true)]
		internal class IBitmapTrackerInvoker : global::Java.Lang.Object, IBitmapTracker {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/engine/bitmap_recycle/LruBitmapPool$BitmapTracker");
			IntPtr class_ref;

			public static IBitmapTracker GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBitmapTracker> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.engine.bitmap_recycle.LruBitmapPool.BitmapTracker"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBitmapTrackerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IBitmapTrackerInvoker); }
			}

			static Delegate cb_add_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetAdd_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_add_Landroid_graphics_Bitmap_ == null)
					cb_add_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Landroid_graphics_Bitmap_);
				return cb_add_Landroid_graphics_Bitmap_;
			}

			static void n_Add_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool.IBitmapTracker __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool.IBitmapTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Add (p0);
			}
#pragma warning restore 0169

			IntPtr id_add_Landroid_graphics_Bitmap_;
			public unsafe void Add (global::Android.Graphics.Bitmap p0)
			{
				if (id_add_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_add_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "add", "(Landroid/graphics/Bitmap;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_add_Landroid_graphics_Bitmap_, __args);
			}

			static Delegate cb_remove_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetRemove_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_remove_Landroid_graphics_Bitmap_ == null)
					cb_remove_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Landroid_graphics_Bitmap_);
				return cb_remove_Landroid_graphics_Bitmap_;
			}

			static void n_Remove_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool.IBitmapTracker __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool.IBitmapTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Remove (p0);
			}
#pragma warning restore 0169

			IntPtr id_remove_Landroid_graphics_Bitmap_;
			public unsafe void Remove (global::Android.Graphics.Bitmap p0)
			{
				if (id_remove_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_remove_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "remove", "(Landroid/graphics/Bitmap;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_remove_Landroid_graphics_Bitmap_, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool.NullBitmapTracker']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/bitmap_recycle/LruBitmapPool$NullBitmapTracker", DoNotGenerateAcw=true)]
		public partial class NullBitmapTracker : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool.IBitmapTracker {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/engine/bitmap_recycle/LruBitmapPool$NullBitmapTracker", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NullBitmapTracker); }
			}

			protected NullBitmapTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_add_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetAdd_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_add_Landroid_graphics_Bitmap_ == null)
					cb_add_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Landroid_graphics_Bitmap_);
				return cb_add_Landroid_graphics_Bitmap_;
			}

			static void n_Add_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool.NullBitmapTracker __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool.NullBitmapTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Add (p0);
			}
#pragma warning restore 0169

			static IntPtr id_add_Landroid_graphics_Bitmap_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool.NullBitmapTracker']/method[@name='add' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("add", "(Landroid/graphics/Bitmap;)V", "GetAdd_Landroid_graphics_Bitmap_Handler")]
			public virtual unsafe void Add (global::Android.Graphics.Bitmap p0)
			{
				if (id_add_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_add_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "add", "(Landroid/graphics/Bitmap;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_add_Landroid_graphics_Bitmap_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Landroid/graphics/Bitmap;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_remove_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetRemove_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_remove_Landroid_graphics_Bitmap_ == null)
					cb_remove_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Landroid_graphics_Bitmap_);
				return cb_remove_Landroid_graphics_Bitmap_;
			}

			static void n_Remove_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool.NullBitmapTracker __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool.NullBitmapTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Remove (p0);
			}
#pragma warning restore 0169

			static IntPtr id_remove_Landroid_graphics_Bitmap_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool.NullBitmapTracker']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("remove", "(Landroid/graphics/Bitmap;)V", "GetRemove_Landroid_graphics_Bitmap_Handler")]
			public virtual unsafe void Remove (global::Android.Graphics.Bitmap p0)
			{
				if (id_remove_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_remove_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "remove", "(Landroid/graphics/Bitmap;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_remove_Landroid_graphics_Bitmap_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Landroid/graphics/Bitmap;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool.ThrowingBitmapTracker']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/bitmap_recycle/LruBitmapPool$ThrowingBitmapTracker", DoNotGenerateAcw=true)]
		public partial class ThrowingBitmapTracker : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool.IBitmapTracker {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/engine/bitmap_recycle/LruBitmapPool$ThrowingBitmapTracker", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ThrowingBitmapTracker); }
			}

			protected ThrowingBitmapTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_add_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetAdd_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_add_Landroid_graphics_Bitmap_ == null)
					cb_add_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Landroid_graphics_Bitmap_);
				return cb_add_Landroid_graphics_Bitmap_;
			}

			static void n_Add_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool.ThrowingBitmapTracker __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool.ThrowingBitmapTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Add (p0);
			}
#pragma warning restore 0169

			static IntPtr id_add_Landroid_graphics_Bitmap_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool.ThrowingBitmapTracker']/method[@name='add' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("add", "(Landroid/graphics/Bitmap;)V", "GetAdd_Landroid_graphics_Bitmap_Handler")]
			public virtual unsafe void Add (global::Android.Graphics.Bitmap p0)
			{
				if (id_add_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_add_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "add", "(Landroid/graphics/Bitmap;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_add_Landroid_graphics_Bitmap_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Landroid/graphics/Bitmap;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_remove_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetRemove_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_remove_Landroid_graphics_Bitmap_ == null)
					cb_remove_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Landroid_graphics_Bitmap_);
				return cb_remove_Landroid_graphics_Bitmap_;
			}

			static void n_Remove_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool.ThrowingBitmapTracker __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool.ThrowingBitmapTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Remove (p0);
			}
#pragma warning restore 0169

			static IntPtr id_remove_Landroid_graphics_Bitmap_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool.ThrowingBitmapTracker']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("remove", "(Landroid/graphics/Bitmap;)V", "GetRemove_Landroid_graphics_Bitmap_Handler")]
			public virtual unsafe void Remove (global::Android.Graphics.Bitmap p0)
			{
				if (id_remove_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_remove_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "remove", "(Landroid/graphics/Bitmap;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_remove_Landroid_graphics_Bitmap_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Landroid/graphics/Bitmap;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/engine/bitmap_recycle/LruBitmapPool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LruBitmapPool); }
		}

		protected LruBitmapPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_util_Set_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool']/constructor[@name='LruBitmapPool' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.Set&lt;android.graphics.Bitmap.Config&gt;']]"
		[Register (".ctor", "(ILjava/util/Set;)V", "")]
		public unsafe LruBitmapPool (int p0, global::System.Collections.Generic.ICollection<global::Android.Graphics.Bitmap.Config> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaSet<global::Android.Graphics.Bitmap.Config>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (LruBitmapPool)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/util/Set;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/util/Set;)V", __args);
					return;
				}

				if (id_ctor_ILjava_util_Set_ == IntPtr.Zero)
					id_ctor_ILjava_util_Set_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/util/Set;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_util_Set_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_util_Set_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool']/constructor[@name='LruBitmapPool' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe LruBitmapPool (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (LruBitmapPool)) {
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxSize;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxSize;
		public virtual unsafe int MaxSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool']/method[@name='getMaxSize' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearMemory ();
		}
#pragma warning restore 0169

		static IntPtr id_clearMemory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool']/method[@name='clearMemory' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap.Config p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_IILandroid_graphics_Bitmap_Config_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool']/method[@name='get' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap.Config']]"
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap.Config p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDirty (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDirty_IILandroid_graphics_Bitmap_Config_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool']/method[@name='getDirty' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap.Config']]"
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Put (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool']/method[@name='put' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSizeMultiplier (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSizeMultiplier_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool']/method[@name='setSizeMultiplier' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.LruBitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrimMemory (p0);
		}
#pragma warning restore 0169

		static IntPtr id_trimMemory_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.bitmap_recycle']/class[@name='LruBitmapPool']/method[@name='trimMemory' and count(parameter)=1 and parameter[1][@type='int']]"
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
