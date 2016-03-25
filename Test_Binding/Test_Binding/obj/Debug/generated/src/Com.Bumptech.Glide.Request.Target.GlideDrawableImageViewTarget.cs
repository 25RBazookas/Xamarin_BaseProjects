using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Target {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='GlideDrawableImageViewTarget']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/target/GlideDrawableImageViewTarget", DoNotGenerateAcw=true)]
	public partial class GlideDrawableImageViewTarget : global::Com.Bumptech.Glide.Request.Target.ImageViewTarget {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/target/GlideDrawableImageViewTarget", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GlideDrawableImageViewTarget); }
		}

		protected GlideDrawableImageViewTarget (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_ImageView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='GlideDrawableImageViewTarget']/constructor[@name='GlideDrawableImageViewTarget' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register (".ctor", "(Landroid/widget/ImageView;)V", "")]
		public unsafe GlideDrawableImageViewTarget (global::Android.Widget.ImageView p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GlideDrawableImageViewTarget)) {
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

		static IntPtr id_ctor_Landroid_widget_ImageView_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='GlideDrawableImageViewTarget']/constructor[@name='GlideDrawableImageViewTarget' and count(parameter)=2 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/widget/ImageView;I)V", "")]
		public unsafe GlideDrawableImageViewTarget (global::Android.Widget.ImageView p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (GlideDrawableImageViewTarget)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/ImageView;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/ImageView;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_widget_ImageView_I == IntPtr.Zero)
					id_ctor_Landroid_widget_ImageView_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/ImageView;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_ImageView_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_ImageView_I, __args);
			} finally {
			}
		}

		static Delegate cb_onResourceReady_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_Lcom_bumptech_glide_request_animation_GlideAnimation_;
#pragma warning disable 0169
		static Delegate GetOnResourceReady_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_Lcom_bumptech_glide_request_animation_GlideAnimation_Handler ()
		{
			if (cb_onResourceReady_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ == null)
				cb_onResourceReady_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnResourceReady_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_Lcom_bumptech_glide_request_animation_GlideAnimation_);
			return cb_onResourceReady_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_Lcom_bumptech_glide_request_animation_GlideAnimation_;
		}

		static void n_OnResourceReady_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Request.Target.GlideDrawableImageViewTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.GlideDrawableImageViewTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation p1 = (global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnResourceReady (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onResourceReady_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_Lcom_bumptech_glide_request_animation_GlideAnimation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='GlideDrawableImageViewTarget']/method[@name='onResourceReady' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.resource.drawable.GlideDrawable'] and parameter[2][@type='com.bumptech.glide.request.animation.GlideAnimation&lt;? super com.bumptech.glide.load.resource.drawable.GlideDrawable&gt;']]"
		[Register ("onResourceReady", "(Lcom/bumptech/glide/load/resource/drawable/GlideDrawable;Lcom/bumptech/glide/request/animation/GlideAnimation;)V", "GetOnResourceReady_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_Lcom_bumptech_glide_request_animation_GlideAnimation_Handler")]
		public virtual unsafe void OnResourceReady (global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable p0, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation p1)
		{
			if (id_onResourceReady_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ == IntPtr.Zero)
				id_onResourceReady_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ = JNIEnv.GetMethodID (class_ref, "onResourceReady", "(Lcom/bumptech/glide/load/resource/drawable/GlideDrawable;Lcom/bumptech/glide/request/animation/GlideAnimation;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onResourceReady_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_Lcom_bumptech_glide_request_animation_GlideAnimation_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResourceReady", "(Lcom/bumptech/glide/load/resource/drawable/GlideDrawable;Lcom/bumptech/glide/request/animation/GlideAnimation;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setResource_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_;
#pragma warning disable 0169
		static Delegate GetSetResource_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_Handler ()
		{
			if (cb_setResource_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_ == null)
				cb_setResource_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResource_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_);
			return cb_setResource_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_;
		}

		static void n_SetResource_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Request.Target.GlideDrawableImageViewTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.GlideDrawableImageViewTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setResource_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='GlideDrawableImageViewTarget']/method[@name='setResource' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.resource.drawable.GlideDrawable']]"
		[Register ("setResource", "(Lcom/bumptech/glide/load/resource/drawable/GlideDrawable;)V", "GetSetResource_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_Handler")]
		protected virtual unsafe void SetResource (global::Com.Bumptech.Glide.Load.Resource.Drawable.GlideDrawable p0)
		{
			if (id_setResource_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_ == IntPtr.Zero)
				id_setResource_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_ = JNIEnv.GetMethodID (class_ref, "setResource", "(Lcom/bumptech/glide/load/resource/drawable/GlideDrawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setResource_Lcom_bumptech_glide_load_resource_drawable_GlideDrawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResource", "(Lcom/bumptech/glide/load/resource/drawable/GlideDrawable;)V"), __args);
			} finally {
			}
		}

	}
}
