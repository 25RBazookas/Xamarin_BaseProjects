using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='DrawableCrossFadeViewAnimation']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/DrawableCrossFadeViewAnimation", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends android.graphics.drawable.Drawable"})]
	public partial class DrawableCrossFadeViewAnimation : global::Java.Lang.Object, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/animation/DrawableCrossFadeViewAnimation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawableCrossFadeViewAnimation); }
		}

		protected DrawableCrossFadeViewAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_request_animation_GlideAnimation_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='DrawableCrossFadeViewAnimation']/constructor[@name='DrawableCrossFadeViewAnimation' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.request.animation.GlideAnimation&lt;T&gt;'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/bumptech/glide/request/animation/GlideAnimation;I)V", "")]
		public unsafe DrawableCrossFadeViewAnimation (global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DrawableCrossFadeViewAnimation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/request/animation/GlideAnimation;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/request/animation/GlideAnimation;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_request_animation_GlideAnimation_I == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_request_animation_GlideAnimation_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/request/animation/GlideAnimation;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_request_animation_GlideAnimation_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_request_animation_GlideAnimation_I, __args);
			} finally {
			}
		}

		static Delegate cb_animate_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_;
#pragma warning disable 0169
		static Delegate GetAnimate_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_Handler ()
		{
			if (cb_animate_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_ == null)
				cb_animate_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Animate_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_);
			return cb_animate_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_;
		}

		static bool n_Animate_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Request.Animation.DrawableCrossFadeViewAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.DrawableCrossFadeViewAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter p1 = (global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Animate (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_animate_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='DrawableCrossFadeViewAnimation']/method[@name='animate' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='com.bumptech.glide.request.animation.GlideAnimation.ViewAdapter']]"
		[Register ("animate", "(Landroid/graphics/drawable/Drawable;Lcom/bumptech/glide/request/animation/GlideAnimation$ViewAdapter;)Z", "GetAnimate_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_Handler")]
		public virtual unsafe bool Animate (global::Java.Lang.Object p0, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter p1)
		{
			if (id_animate_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_ == IntPtr.Zero)
				id_animate_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_ = JNIEnv.GetMethodID (class_ref, "animate", "(Landroid/graphics/drawable/Drawable;Lcom/bumptech/glide/request/animation/GlideAnimation$ViewAdapter;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_animate_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animate", "(Landroid/graphics/drawable/Drawable;Lcom/bumptech/glide/request/animation/GlideAnimation$ViewAdapter;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
