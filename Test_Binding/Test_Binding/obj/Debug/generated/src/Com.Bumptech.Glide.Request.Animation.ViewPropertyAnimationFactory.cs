using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewPropertyAnimationFactory']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/ViewPropertyAnimationFactory", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial class ViewPropertyAnimationFactory : global::Java.Lang.Object, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationFactory {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/animation/ViewPropertyAnimationFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewPropertyAnimationFactory); }
		}

		protected ViewPropertyAnimationFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewPropertyAnimationFactory']/constructor[@name='ViewPropertyAnimationFactory' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.animation.ViewPropertyAnimation.Animator']]"
		[Register (".ctor", "(Lcom/bumptech/glide/request/animation/ViewPropertyAnimation$Animator;)V", "")]
		public unsafe ViewPropertyAnimationFactory (global::Com.Bumptech.Glide.Request.Animation.ViewPropertyAnimation.IAnimator p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ViewPropertyAnimationFactory)) {
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

		static Delegate cb_build_ZZ;
#pragma warning disable 0169
		static Delegate GetBuild_ZZHandler ()
		{
			if (cb_build_ZZ == null)
				cb_build_ZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool, IntPtr>) n_Build_ZZ);
			return cb_build_ZZ;
		}

		static IntPtr n_Build_ZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1)
		{
			global::Com.Bumptech.Glide.Request.Animation.ViewPropertyAnimationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.ViewPropertyAnimationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_build_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewPropertyAnimationFactory']/method[@name='build' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("build", "(ZZ)Lcom/bumptech/glide/request/animation/GlideAnimation;", "GetBuild_ZZHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation Build (bool p0, bool p1)
		{
			if (id_build_ZZ == IntPtr.Zero)
				id_build_ZZ = JNIEnv.GetMethodID (class_ref, "build", "(ZZ)Lcom/bumptech/glide/request/animation/GlideAnimation;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation> (JNIEnv.CallObjectMethod  (Handle, id_build_ZZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "(ZZ)Lcom/bumptech/glide/request/animation/GlideAnimation;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
