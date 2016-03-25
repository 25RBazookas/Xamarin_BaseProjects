using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Target {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='DrawableImageViewTarget']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/target/DrawableImageViewTarget", DoNotGenerateAcw=true)]
	public partial class DrawableImageViewTarget : global::Com.Bumptech.Glide.Request.Target.ImageViewTarget {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/target/DrawableImageViewTarget", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawableImageViewTarget); }
		}

		protected DrawableImageViewTarget (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_ImageView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='DrawableImageViewTarget']/constructor[@name='DrawableImageViewTarget' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register (".ctor", "(Landroid/widget/ImageView;)V", "")]
		public unsafe DrawableImageViewTarget (global::Android.Widget.ImageView p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DrawableImageViewTarget)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/ImageView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/ImageView;)V", __args);
					return;
				}

				if (id_ctor_Landroid_widget_ImageView_ == IntPtr.Zero)
					id_ctor_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/ImageView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_ImageView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_ImageView_, __args);
			} finally {
			}
		}

		static Delegate cb_setResource_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetResource_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setResource_Landroid_graphics_drawable_Drawable_ == null)
				cb_setResource_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResource_Landroid_graphics_drawable_Drawable_);
			return cb_setResource_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetResource_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Request.Target.DrawableImageViewTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.DrawableImageViewTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setResource_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='DrawableImageViewTarget']/method[@name='setResource' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setResource", "(Landroid/graphics/drawable/Drawable;)V", "GetSetResource_Landroid_graphics_drawable_Drawable_Handler")]
		protected virtual unsafe void SetResource (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setResource_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setResource_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setResource", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setResource_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResource", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

	}
}
