using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Target {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='BitmapImageViewTarget']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/target/BitmapImageViewTarget", DoNotGenerateAcw=true)]
	public partial class BitmapImageViewTarget : global::Com.Bumptech.Glide.Request.Target.ImageViewTarget {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/target/BitmapImageViewTarget", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapImageViewTarget); }
		}

		protected BitmapImageViewTarget (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_ImageView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='BitmapImageViewTarget']/constructor[@name='BitmapImageViewTarget' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register (".ctor", "(Landroid/widget/ImageView;)V", "")]
		public unsafe BitmapImageViewTarget (global::Android.Widget.ImageView p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BitmapImageViewTarget)) {
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

		static Delegate cb_setResource_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetResource_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setResource_Landroid_graphics_Bitmap_ == null)
				cb_setResource_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResource_Landroid_graphics_Bitmap_);
			return cb_setResource_Landroid_graphics_Bitmap_;
		}

		static void n_SetResource_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Request.Target.BitmapImageViewTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.BitmapImageViewTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setResource_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='BitmapImageViewTarget']/method[@name='setResource' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setResource", "(Landroid/graphics/Bitmap;)V", "GetSetResource_Landroid_graphics_Bitmap_Handler")]
		protected virtual unsafe void SetResource (global::Android.Graphics.Bitmap p0)
		{
			if (id_setResource_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setResource_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setResource", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setResource_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResource", "(Landroid/graphics/Bitmap;)V"), __args);
			} finally {
			}
		}

	}
}
