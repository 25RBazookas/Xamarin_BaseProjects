using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Bitmap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/GlideBitmapDrawable", DoNotGenerateAcw=true)]
	public partial class GlideBitmapDrawable : global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable.BitmapState']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/GlideBitmapDrawable$BitmapState", DoNotGenerateAcw=true)]
		public partial class BitmapState : global::Android.Graphics.Drawables.Drawable.ConstantState {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/GlideBitmapDrawable$BitmapState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BitmapState); }
			}

			protected BitmapState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_graphics_Bitmap_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable.BitmapState']/constructor[@name='GlideBitmapDrawable.BitmapState' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register (".ctor", "(Landroid/graphics/Bitmap;)V", "")]
			public unsafe BitmapState (global::Android.Graphics.Bitmap p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (BitmapState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/Bitmap;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/Bitmap;)V", __args);
						return;
					}

					if (id_ctor_Landroid_graphics_Bitmap_ == IntPtr.Zero)
						id_ctor_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_, __args);
				} finally {
				}
			}

			static Delegate cb_getChangingConfigurations;
#pragma warning disable 0169
			static Delegate GetGetChangingConfigurationsHandler ()
			{
				if (cb_getChangingConfigurations == null)
					cb_getChangingConfigurations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChangingConfigurations);
				return cb_getChangingConfigurations;
			}

			static int n_GetChangingConfigurations (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable.BitmapState __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable.BitmapState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return (int) __this.ChangingConfigurations;
			}
#pragma warning restore 0169

			static IntPtr id_getChangingConfigurations;
			public override unsafe global::Android.Content.PM.ConfigChanges ChangingConfigurations {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable.BitmapState']/method[@name='getChangingConfigurations' and count(parameter)=0]"
				[Register ("getChangingConfigurations", "()I", "GetGetChangingConfigurationsHandler")]
				get {
					if (id_getChangingConfigurations == IntPtr.Zero)
						id_getChangingConfigurations = JNIEnv.GetMethodID (class_ref, "getChangingConfigurations", "()I");
					try {

						if (GetType () == ThresholdType)
							return (global::Android.Content.PM.ConfigChanges) JNIEnv.CallIntMethod  (Handle, id_getChangingConfigurations);
						else
							return (global::Android.Content.PM.ConfigChanges) JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChangingConfigurations", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_newDrawable;
#pragma warning disable 0169
			static Delegate GetNewDrawableHandler ()
			{
				if (cb_newDrawable == null)
					cb_newDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewDrawable);
				return cb_newDrawable;
			}

			static IntPtr n_NewDrawable (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable.BitmapState __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable.BitmapState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.NewDrawable ());
			}
#pragma warning restore 0169

			static IntPtr id_newDrawable;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable.BitmapState']/method[@name='newDrawable' and count(parameter)=0]"
			[Register ("newDrawable", "()Landroid/graphics/drawable/Drawable;", "GetNewDrawableHandler")]
			public override unsafe global::Android.Graphics.Drawables.Drawable NewDrawable ()
			{
				if (id_newDrawable == IntPtr.Zero)
					id_newDrawable = JNIEnv.GetMethodID (class_ref, "newDrawable", "()Landroid/graphics/drawable/Drawable;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_newDrawable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/GlideBitmapDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GlideBitmapDrawable); }
		}

		protected GlideBitmapDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_res_Resources_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable']/constructor[@name='GlideBitmapDrawable' and count(parameter)=2 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V", "")]
		public unsafe GlideBitmapDrawable (global::Android.Content.Res.Resources p0, global::Android.Graphics.Bitmap p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (GlideBitmapDrawable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_res_Resources_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Landroid_content_res_Resources_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_res_Resources_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_res_Resources_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static Delegate cb_getBitmap;
#pragma warning disable 0169
		static Delegate GetGetBitmapHandler ()
		{
			if (cb_getBitmap == null)
				cb_getBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitmap);
			return cb_getBitmap;
		}

		static IntPtr n_GetBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bitmap);
		}
#pragma warning restore 0169

		static IntPtr id_getBitmap;
		public virtual unsafe global::Android.Graphics.Bitmap Bitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable']/method[@name='getBitmap' and count(parameter)=0]"
			[Register ("getBitmap", "()Landroid/graphics/Bitmap;", "GetGetBitmapHandler")]
			get {
				if (id_getBitmap == IntPtr.Zero)
					id_getBitmap = JNIEnv.GetMethodID (class_ref, "getBitmap", "()Landroid/graphics/Bitmap;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getBitmap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAnimated;
#pragma warning disable 0169
		static Delegate GetIsAnimatedHandler ()
		{
			if (cb_isAnimated == null)
				cb_isAnimated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAnimated);
			return cb_isAnimated;
		}

		static bool n_IsAnimated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnimated;
		}
#pragma warning restore 0169

		static IntPtr id_isAnimated;
		public override unsafe bool IsAnimated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable']/method[@name='isAnimated' and count(parameter)=0]"
			[Register ("isAnimated", "()Z", "GetIsAnimatedHandler")]
			get {
				if (id_isAnimated == IntPtr.Zero)
					id_isAnimated = JNIEnv.GetMethodID (class_ref, "isAnimated", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isAnimated);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAnimated", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		static IntPtr id_isRunning;
		public override unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isRunning);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRunning", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getOpacity;
#pragma warning disable 0169
		static Delegate GetGetOpacityHandler ()
		{
			if (cb_getOpacity == null)
				cb_getOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOpacity);
			return cb_getOpacity;
		}

		static int n_GetOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		static IntPtr id_getOpacity;
		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable']/method[@name='getOpacity' and count(parameter)=0]"
			[Register ("getOpacity", "()I", "GetGetOpacityHandler")]
			get {
				if (id_getOpacity == IntPtr.Zero)
					id_getOpacity = JNIEnv.GetMethodID (class_ref, "getOpacity", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getOpacity);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpacity", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas p0)
		{
			if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetAlpha_IHandler ()
		{
			if (cb_setAlpha_I == null)
				cb_setAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAlpha_I);
			return cb_setAlpha_I;
		}

		static void n_SetAlpha_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAlpha_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public override unsafe void SetAlpha (int p0)
		{
			if (id_setAlpha_I == IntPtr.Zero)
				id_setAlpha_I = JNIEnv.GetMethodID (class_ref, "setAlpha", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAlpha_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlpha", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;
#pragma warning disable 0169
		static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler ()
		{
			if (cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
				cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorFilter_Landroid_graphics_ColorFilter_);
			return cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		static void n_SetColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColorFilter_Landroid_graphics_ColorFilter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public override unsafe void SetColorFilter (global::Android.Graphics.ColorFilter p0)
		{
			if (id_setColorFilter_Landroid_graphics_ColorFilter_ == IntPtr.Zero)
				id_setColorFilter_Landroid_graphics_ColorFilter_ = JNIEnv.GetMethodID (class_ref, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setColorFilter_Landroid_graphics_ColorFilter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLoopCount_I;
#pragma warning disable 0169
		static Delegate GetSetLoopCount_IHandler ()
		{
			if (cb_setLoopCount_I == null)
				cb_setLoopCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLoopCount_I);
			return cb_setLoopCount_I;
		}

		static void n_SetLoopCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLoopCount (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLoopCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable']/method[@name='setLoopCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLoopCount", "(I)V", "GetSetLoopCount_IHandler")]
		public override unsafe void SetLoopCount (int p0)
		{
			if (id_setLoopCount_I == IntPtr.Zero)
				id_setLoopCount_I = JNIEnv.GetMethodID (class_ref, "setLoopCount", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLoopCount_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLoopCount", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public override unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.GlideBitmapDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='GlideBitmapDrawable']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public override unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
