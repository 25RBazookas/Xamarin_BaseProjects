using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemorySizeCalculator']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/cache/MemorySizeCalculator", DoNotGenerateAcw=true)]
	public partial class MemorySizeCalculator : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemorySizeCalculator.DisplayMetricsScreenDimensions']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/cache/MemorySizeCalculator$DisplayMetricsScreenDimensions", DoNotGenerateAcw=true)]
		public partial class DisplayMetricsScreenDimensions : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator.IScreenDimensions {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/engine/cache/MemorySizeCalculator$DisplayMetricsScreenDimensions", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DisplayMetricsScreenDimensions); }
			}

			protected DisplayMetricsScreenDimensions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_util_DisplayMetrics_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemorySizeCalculator.DisplayMetricsScreenDimensions']/constructor[@name='MemorySizeCalculator.DisplayMetricsScreenDimensions' and count(parameter)=1 and parameter[1][@type='android.util.DisplayMetrics']]"
			[Register (".ctor", "(Landroid/util/DisplayMetrics;)V", "")]
			public unsafe DisplayMetricsScreenDimensions (global::Android.Util.DisplayMetrics p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (DisplayMetricsScreenDimensions)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/util/DisplayMetrics;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/util/DisplayMetrics;)V", __args);
						return;
					}

					if (id_ctor_Landroid_util_DisplayMetrics_ == IntPtr.Zero)
						id_ctor_Landroid_util_DisplayMetrics_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/util/DisplayMetrics;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_util_DisplayMetrics_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_util_DisplayMetrics_, __args);
				} finally {
				}
			}

			static Delegate cb_getHeightPixels;
#pragma warning disable 0169
			static Delegate GetGetHeightPixelsHandler ()
			{
				if (cb_getHeightPixels == null)
					cb_getHeightPixels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeightPixels);
				return cb_getHeightPixels;
			}

			static int n_GetHeightPixels (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator.DisplayMetricsScreenDimensions __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator.DisplayMetricsScreenDimensions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HeightPixels;
			}
#pragma warning restore 0169

			static IntPtr id_getHeightPixels;
			public virtual unsafe int HeightPixels {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemorySizeCalculator.DisplayMetricsScreenDimensions']/method[@name='getHeightPixels' and count(parameter)=0]"
				[Register ("getHeightPixels", "()I", "GetGetHeightPixelsHandler")]
				get {
					if (id_getHeightPixels == IntPtr.Zero)
						id_getHeightPixels = JNIEnv.GetMethodID (class_ref, "getHeightPixels", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod  (Handle, id_getHeightPixels);
						else
							return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeightPixels", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getWidthPixels;
#pragma warning disable 0169
			static Delegate GetGetWidthPixelsHandler ()
			{
				if (cb_getWidthPixels == null)
					cb_getWidthPixels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidthPixels);
				return cb_getWidthPixels;
			}

			static int n_GetWidthPixels (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator.DisplayMetricsScreenDimensions __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator.DisplayMetricsScreenDimensions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.WidthPixels;
			}
#pragma warning restore 0169

			static IntPtr id_getWidthPixels;
			public virtual unsafe int WidthPixels {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemorySizeCalculator.DisplayMetricsScreenDimensions']/method[@name='getWidthPixels' and count(parameter)=0]"
				[Register ("getWidthPixels", "()I", "GetGetWidthPixelsHandler")]
				get {
					if (id_getWidthPixels == IntPtr.Zero)
						id_getWidthPixels = JNIEnv.GetMethodID (class_ref, "getWidthPixels", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod  (Handle, id_getWidthPixels);
						else
							return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidthPixels", "()I"));
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='MemorySizeCalculator.ScreenDimensions']"
		[Register ("com/bumptech/glide/load/engine/cache/MemorySizeCalculator$ScreenDimensions", "", "Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator/IScreenDimensionsInvoker")]
		public partial interface IScreenDimensions : IJavaObject {

			int HeightPixels {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='MemorySizeCalculator.ScreenDimensions']/method[@name='getHeightPixels' and count(parameter)=0]"
				[Register ("getHeightPixels", "()I", "GetGetHeightPixelsHandler:Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator/IScreenDimensionsInvoker, Test_Binding")] get;
			}

			int WidthPixels {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/interface[@name='MemorySizeCalculator.ScreenDimensions']/method[@name='getWidthPixels' and count(parameter)=0]"
				[Register ("getWidthPixels", "()I", "GetGetWidthPixelsHandler:Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator/IScreenDimensionsInvoker, Test_Binding")] get;
			}

		}

		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/cache/MemorySizeCalculator$ScreenDimensions", DoNotGenerateAcw=true)]
		internal class IScreenDimensionsInvoker : global::Java.Lang.Object, IScreenDimensions {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/engine/cache/MemorySizeCalculator$ScreenDimensions");
			IntPtr class_ref;

			public static IScreenDimensions GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IScreenDimensions> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.engine.cache.MemorySizeCalculator.ScreenDimensions"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IScreenDimensionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IScreenDimensionsInvoker); }
			}

			static Delegate cb_getHeightPixels;
#pragma warning disable 0169
			static Delegate GetGetHeightPixelsHandler ()
			{
				if (cb_getHeightPixels == null)
					cb_getHeightPixels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeightPixels);
				return cb_getHeightPixels;
			}

			static int n_GetHeightPixels (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator.IScreenDimensions __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator.IScreenDimensions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HeightPixels;
			}
#pragma warning restore 0169

			IntPtr id_getHeightPixels;
			public unsafe int HeightPixels {
				get {
					if (id_getHeightPixels == IntPtr.Zero)
						id_getHeightPixels = JNIEnv.GetMethodID (class_ref, "getHeightPixels", "()I");
					return JNIEnv.CallIntMethod (Handle, id_getHeightPixels);
				}
			}

			static Delegate cb_getWidthPixels;
#pragma warning disable 0169
			static Delegate GetGetWidthPixelsHandler ()
			{
				if (cb_getWidthPixels == null)
					cb_getWidthPixels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidthPixels);
				return cb_getWidthPixels;
			}

			static int n_GetWidthPixels (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator.IScreenDimensions __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator.IScreenDimensions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.WidthPixels;
			}
#pragma warning restore 0169

			IntPtr id_getWidthPixels;
			public unsafe int WidthPixels {
				get {
					if (id_getWidthPixels == IntPtr.Zero)
						id_getWidthPixels = JNIEnv.GetMethodID (class_ref, "getWidthPixels", "()I");
					return JNIEnv.CallIntMethod (Handle, id_getWidthPixels);
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/engine/cache/MemorySizeCalculator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MemorySizeCalculator); }
		}

		protected MemorySizeCalculator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemorySizeCalculator']/constructor[@name='MemorySizeCalculator' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MemorySizeCalculator (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MemorySizeCalculator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getBitmapPoolSize;
#pragma warning disable 0169
		static Delegate GetGetBitmapPoolSizeHandler ()
		{
			if (cb_getBitmapPoolSize == null)
				cb_getBitmapPoolSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBitmapPoolSize);
			return cb_getBitmapPoolSize;
		}

		static int n_GetBitmapPoolSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BitmapPoolSize;
		}
#pragma warning restore 0169

		static IntPtr id_getBitmapPoolSize;
		public virtual unsafe int BitmapPoolSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemorySizeCalculator']/method[@name='getBitmapPoolSize' and count(parameter)=0]"
			[Register ("getBitmapPoolSize", "()I", "GetGetBitmapPoolSizeHandler")]
			get {
				if (id_getBitmapPoolSize == IntPtr.Zero)
					id_getBitmapPoolSize = JNIEnv.GetMethodID (class_ref, "getBitmapPoolSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getBitmapPoolSize);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitmapPoolSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMemoryCacheSize;
#pragma warning disable 0169
		static Delegate GetGetMemoryCacheSizeHandler ()
		{
			if (cb_getMemoryCacheSize == null)
				cb_getMemoryCacheSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMemoryCacheSize);
			return cb_getMemoryCacheSize;
		}

		static int n_GetMemoryCacheSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MemoryCacheSize;
		}
#pragma warning restore 0169

		static IntPtr id_getMemoryCacheSize;
		public virtual unsafe int MemoryCacheSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.cache']/class[@name='MemorySizeCalculator']/method[@name='getMemoryCacheSize' and count(parameter)=0]"
			[Register ("getMemoryCacheSize", "()I", "GetGetMemoryCacheSizeHandler")]
			get {
				if (id_getMemoryCacheSize == IntPtr.Zero)
					id_getMemoryCacheSize = JNIEnv.GetMethodID (class_ref, "getMemoryCacheSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMemoryCacheSize);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMemoryCacheSize", "()I"));
				} finally {
				}
			}
		}

	}
}
