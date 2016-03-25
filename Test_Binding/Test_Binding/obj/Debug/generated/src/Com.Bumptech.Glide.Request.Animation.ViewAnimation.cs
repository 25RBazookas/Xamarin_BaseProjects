using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewAnimation']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/ViewAnimation", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial class ViewAnimation : global::Java.Lang.Object, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.request.animation']/interface[@name='ViewAnimation.AnimationFactory']"
		[Register ("com/bumptech/glide/request/animation/ViewAnimation$AnimationFactory", "", "Com.Bumptech.Glide.Request.Animation.ViewAnimation/IAnimationFactoryInvoker")]
		public partial interface IAnimationFactory : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/interface[@name='ViewAnimation.AnimationFactory']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Landroid/view/animation/Animation;", "GetBuildHandler:Com.Bumptech.Glide.Request.Animation.ViewAnimation/IAnimationFactoryInvoker, Test_Binding")]
			global::Android.Views.Animations.Animation Build ();

		}

		[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/ViewAnimation$AnimationFactory", DoNotGenerateAcw=true)]
		internal class IAnimationFactoryInvoker : global::Java.Lang.Object, IAnimationFactory {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/request/animation/ViewAnimation$AnimationFactory");
			IntPtr class_ref;

			public static IAnimationFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAnimationFactory> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.request.animation.ViewAnimation.AnimationFactory"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAnimationFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAnimationFactoryInvoker); }
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Request.Animation.ViewAnimation.IAnimationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.ViewAnimation.IAnimationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			IntPtr id_build;
			public unsafe global::Android.Views.Animations.Animation Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Landroid/view/animation/Animation;");
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (JNIEnv.CallObjectMethod (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/animation/ViewAnimation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewAnimation); }
		}

		protected ViewAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Bumptech.Glide.Request.Animation.ViewAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.ViewAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter p1 = (global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Animate (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewAnimation']/method[@name='animate' and count(parameter)=2 and parameter[1][@type='R'] and parameter[2][@type='com.bumptech.glide.request.animation.GlideAnimation.ViewAdapter']]"
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
