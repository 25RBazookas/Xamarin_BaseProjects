using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='NoAnimation']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/NoAnimation", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial class NoAnimation : global::Java.Lang.Object, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='NoAnimation.NoAnimationFactory']"
		[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/NoAnimation$NoAnimationFactory", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public partial class NoAnimationFactory : global::Java.Lang.Object, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/request/animation/NoAnimation$NoAnimationFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NoAnimationFactory); }
			}

			protected NoAnimationFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='NoAnimation.NoAnimationFactory']/constructor[@name='NoAnimation.NoAnimationFactory' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe NoAnimationFactory ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (NoAnimationFactory)) {
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
				global::Com.Bumptech.Glide.Request.Animation.NoAnimation.NoAnimationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.NoAnimation.NoAnimationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build (p0, p1));
			}
#pragma warning restore 0169

			static IntPtr id_build_ZZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='NoAnimation.NoAnimationFactory']/method[@name='build' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/animation/NoAnimation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NoAnimation); }
		}

		protected NoAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='NoAnimation']/constructor[@name='NoAnimation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NoAnimation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NoAnimation)) {
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

		static IntPtr id_getFactory;
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public static unsafe global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationFactory Factory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='NoAnimation']/method[@name='getFactory' and count(parameter)=0]"
			[Register ("getFactory", "()Lcom/bumptech/glide/request/animation/GlideAnimationFactory;", "GetGetFactoryHandler")]
			get {
				if (id_getFactory == IntPtr.Zero)
					id_getFactory = JNIEnv.GetStaticMethodID (class_ref, "getFactory", "()Lcom/bumptech/glide/request/animation/GlideAnimationFactory;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFactory), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Bumptech.Glide.Request.Animation.NoAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.NoAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter p1 = (global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Animate (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='NoAnimation']/method[@name='animate' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.bumptech.glide.request.animation.GlideAnimation.ViewAdapter']]"
		[Register ("animate", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation$ViewAdapter;)Z", "GetAnimate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_Handler")]
		public virtual unsafe bool Animate (global::Java.Lang.Object p0, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter p1)
		{
			if (id_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_ == IntPtr.Zero)
				id_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_ = JNIEnv.GetMethodID (class_ref, "animate", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation$ViewAdapter;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animate", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation$ViewAdapter;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='NoAnimation']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/bumptech/glide/request/animation/GlideAnimation;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public static unsafe global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetStaticMethodID (class_ref, "get", "()Lcom/bumptech/glide/request/animation/GlideAnimation;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
