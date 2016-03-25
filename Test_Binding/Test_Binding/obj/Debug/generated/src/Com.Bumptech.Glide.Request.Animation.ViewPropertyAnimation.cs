using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewPropertyAnimation']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/ViewPropertyAnimation", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial class ViewPropertyAnimation : global::Java.Lang.Object, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.request.animation']/interface[@name='ViewPropertyAnimation.Animator']"
		[Register ("com/bumptech/glide/request/animation/ViewPropertyAnimation$Animator", "", "Com.Bumptech.Glide.Request.Animation.ViewPropertyAnimation/IAnimatorInvoker")]
		public partial interface IAnimator : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/interface[@name='ViewPropertyAnimation.Animator']/method[@name='animate' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("animate", "(Landroid/view/View;)V", "GetAnimate_Landroid_view_View_Handler:Com.Bumptech.Glide.Request.Animation.ViewPropertyAnimation/IAnimatorInvoker, Test_Binding")]
			void Animate (global::Android.Views.View p0);

		}

		[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/ViewPropertyAnimation$Animator", DoNotGenerateAcw=true)]
		internal class IAnimatorInvoker : global::Java.Lang.Object, IAnimator {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/request/animation/ViewPropertyAnimation$Animator");
			IntPtr class_ref;

			public static IAnimator GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAnimator> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.request.animation.ViewPropertyAnimation.Animator"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAnimatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAnimatorInvoker); }
			}

			static Delegate cb_animate_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetAnimate_Landroid_view_View_Handler ()
			{
				if (cb_animate_Landroid_view_View_ == null)
					cb_animate_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Animate_Landroid_view_View_);
				return cb_animate_Landroid_view_View_;
			}

			static void n_Animate_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Request.Animation.ViewPropertyAnimation.IAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.ViewPropertyAnimation.IAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Animate (p0);
			}
#pragma warning restore 0169

			IntPtr id_animate_Landroid_view_View_;
			public unsafe void Animate (global::Android.Views.View p0)
			{
				if (id_animate_Landroid_view_View_ == IntPtr.Zero)
					id_animate_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "animate", "(Landroid/view/View;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_animate_Landroid_view_View_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/animation/ViewPropertyAnimation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewPropertyAnimation); }
		}

		protected ViewPropertyAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewPropertyAnimation']/constructor[@name='ViewPropertyAnimation' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.animation.ViewPropertyAnimation.Animator']]"
		[Register (".ctor", "(Lcom/bumptech/glide/request/animation/ViewPropertyAnimation$Animator;)V", "")]
		public unsafe ViewPropertyAnimation (global::Com.Bumptech.Glide.Request.Animation.ViewPropertyAnimation.IAnimator p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ViewPropertyAnimation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/request/animation/ViewPropertyAnimation$Animator;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/request/animation/ViewPropertyAnimation$Animator;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/request/animation/ViewPropertyAnimation$Animator;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_, __args);
			} finally {
			}
		}

		static Delegate cb_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_;
#pragma warning disable 0169
		static Delegate GetAnimate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_Handler ()
		{
			if (cb_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_ == null)
				cb_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_);
			return cb_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_;
		}

		static bool n_Animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Request.Animation.ViewPropertyAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.ViewPropertyAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter p1 = (global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Animate (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewPropertyAnimation']/method[@name='animate' and count(parameter)=2 and parameter[1][@type='R'] and parameter[2][@type='com.bumptech.glide.request.animation.GlideAnimation.ViewAdapter']]"
		[Register ("animate", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation$ViewAdapter;)Z", "GetAnimate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_Handler")]
		public virtual unsafe bool Animate (global::Java.Lang.Object p0, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter p1)
		{
			if (id_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_ == IntPtr.Zero)
				id_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_ = JNIEnv.GetMethodID (class_ref, "animate", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation$ViewAdapter;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animate", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation$ViewAdapter;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
