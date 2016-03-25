using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='GlideDrawable']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/drawable/GlideDrawable", DoNotGenerateAcw=true)]
	public abstract partial class GlideDrawable : global::Android.Graphics.Drawables.Drawable, global::Android.Graphics.Drawables.IAnimatable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='GlideDrawable']/field[@name='LOOP_FOREVER']"
		[Register ("LOOP_FOREVER")]
		public const int LoopForever = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='GlideDrawable']/field[@name='LOOP_INTRINSIC']"
		[Register ("LOOP_INTRINSIC")]
		public const int LoopIntrinsic = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/drawable/GlideDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GlideDrawable); }
		}

		protected GlideDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='GlideDrawable']/constructor[@name='GlideDrawable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GlideDrawable ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (GlideDrawable)) {
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
			global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnimated;
		}
#pragma warning restore 0169

		public abstract bool IsAnimated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='GlideDrawable']/method[@name='isAnimated' and count(parameter)=0]"
			[Register ("isAnimated", "()Z", "GetIsAnimatedHandler")] get;
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
			global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLoopCount (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='GlideDrawable']/method[@name='setLoopCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLoopCount", "(I)V", "GetSetLoopCount_IHandler")]
		public abstract void SetLoopCount (int p0);

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
			global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='GlideDrawable']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public abstract void Start ();

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
			global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='GlideDrawable']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public abstract void Stop ();

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
			global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		public abstract global::System.Boolean IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='GlideDrawable']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/drawable/GlideDrawable", DoNotGenerateAcw=true)]
	internal partial class GlideDrawableInvoker : GlideDrawable {

		public GlideDrawableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (GlideDrawableInvoker); }
		}

		static IntPtr id_isAnimated;
		public override unsafe bool IsAnimated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='GlideDrawable']/method[@name='isAnimated' and count(parameter)=0]"
			[Register ("isAnimated", "()Z", "GetIsAnimatedHandler")]
			get {
				if (id_isAnimated == IntPtr.Zero)
					id_isAnimated = JNIEnv.GetMethodID (class_ref, "isAnimated", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isAnimated);
				} finally {
				}
			}
		}

		static IntPtr id_setLoopCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='GlideDrawable']/method[@name='setLoopCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLoopCount", "(I)V", "GetSetLoopCount_IHandler")]
		public override unsafe void SetLoopCount (int p0)
		{
			if (id_setLoopCount_I == IntPtr.Zero)
				id_setLoopCount_I = JNIEnv.GetMethodID (class_ref, "setLoopCount", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setLoopCount_I, __args);
			} finally {
			}
		}

		static IntPtr id_isRunning;
		public override unsafe global::System.Boolean IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='GlideDrawable']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isRunning);
				} finally {
				}
			}
		}

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='GlideDrawable']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public override unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_start);
			} finally {
			}
		}

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='GlideDrawable']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public override unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_stop);
			} finally {
			}
		}

		static IntPtr id_getOpacity;
		public override unsafe global::System.Int32 Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.graphics.drawable']/class[@name='Drawable']/method[@name='getOpacity' and count(parameter)=0]"
			[Register ("getOpacity", "()I", "GetGetOpacityHandler")]
			get {
				if (id_getOpacity == IntPtr.Zero)
					id_getOpacity = JNIEnv.GetMethodID (class_ref, "getOpacity", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getOpacity);
				} finally {
				}
			}
		}

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.graphics.drawable']/class[@name='Drawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='Android.Graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas canvas)
		{
			if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (canvas);
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_, __args);
			} finally {
			}
		}

		static IntPtr id_setAlpha_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.graphics.drawable']/class[@name='Drawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='System.Int32']]"
		[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public override unsafe void SetAlpha (int alpha)
		{
			if (id_setAlpha_I == IntPtr.Zero)
				id_setAlpha_I = JNIEnv.GetMethodID (class_ref, "setAlpha", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (alpha);
				JNIEnv.CallVoidMethod  (Handle, id_setAlpha_I, __args);
			} finally {
			}
		}

		static IntPtr id_setColorFilter_Landroid_graphics_ColorFilter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.graphics.drawable']/class[@name='Drawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='Android.Graphics.ColorFilter']]"
		[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public override unsafe void SetColorFilter (global::Android.Graphics.ColorFilter cf)
		{
			if (id_setColorFilter_Landroid_graphics_ColorFilter_ == IntPtr.Zero)
				id_setColorFilter_Landroid_graphics_ColorFilter_ = JNIEnv.GetMethodID (class_ref, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cf);
				JNIEnv.CallVoidMethod  (Handle, id_setColorFilter_Landroid_graphics_ColorFilter_, __args);
			} finally {
			}
		}

	}

}
