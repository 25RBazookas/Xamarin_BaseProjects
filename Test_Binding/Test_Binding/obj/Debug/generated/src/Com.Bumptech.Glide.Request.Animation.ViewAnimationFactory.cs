using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewAnimationFactory']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/ViewAnimationFactory", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial class ViewAnimationFactory : global::Java.Lang.Object, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationFactory {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewAnimationFactory.ConcreteAnimationFactory']"
		[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/ViewAnimationFactory$ConcreteAnimationFactory", DoNotGenerateAcw=true)]
		public partial class ConcreteAnimationFactory : global::Java.Lang.Object, global::Com.Bumptech.Glide.Request.Animation.ViewAnimation.IAnimationFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/request/animation/ViewAnimationFactory$ConcreteAnimationFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConcreteAnimationFactory); }
			}

			protected ConcreteAnimationFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_view_animation_Animation_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewAnimationFactory.ConcreteAnimationFactory']/constructor[@name='ViewAnimationFactory.ConcreteAnimationFactory' and count(parameter)=1 and parameter[1][@type='android.view.animation.Animation']]"
			[Register (".ctor", "(Landroid/view/animation/Animation;)V", "")]
			public unsafe ConcreteAnimationFactory (global::Android.Views.Animations.Animation p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (ConcreteAnimationFactory)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/animation/Animation;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/animation/Animation;)V", __args);
						return;
					}

					if (id_ctor_Landroid_view_animation_Animation_ == IntPtr.Zero)
						id_ctor_Landroid_view_animation_Animation_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/animation/Animation;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_animation_Animation_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_animation_Animation_, __args);
				} finally {
				}
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
				global::Com.Bumptech.Glide.Request.Animation.ViewAnimationFactory.ConcreteAnimationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.ViewAnimationFactory.ConcreteAnimationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewAnimationFactory.ConcreteAnimationFactory']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Landroid/view/animation/Animation;", "GetBuildHandler")]
			public virtual unsafe global::Android.Views.Animations.Animation Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Landroid/view/animation/Animation;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Landroid/view/animation/Animation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewAnimationFactory.ResourceAnimationFactory']"
		[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/ViewAnimationFactory$ResourceAnimationFactory", DoNotGenerateAcw=true)]
		public partial class ResourceAnimationFactory : global::Java.Lang.Object, global::Com.Bumptech.Glide.Request.Animation.ViewAnimation.IAnimationFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/request/animation/ViewAnimationFactory$ResourceAnimationFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResourceAnimationFactory); }
			}

			protected ResourceAnimationFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewAnimationFactory.ResourceAnimationFactory']/constructor[@name='ViewAnimationFactory.ResourceAnimationFactory' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Landroid/content/Context;I)V", "")]
			public unsafe ResourceAnimationFactory (global::Android.Content.Context p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (ResourceAnimationFactory)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;I)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_Context_I == IntPtr.Zero)
						id_ctor_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_I, __args);
				} finally {
				}
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
				global::Com.Bumptech.Glide.Request.Animation.ViewAnimationFactory.ResourceAnimationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.ViewAnimationFactory.ResourceAnimationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewAnimationFactory.ResourceAnimationFactory']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Landroid/view/animation/Animation;", "GetBuildHandler")]
			public virtual unsafe global::Android.Views.Animations.Animation Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Landroid/view/animation/Animation;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Landroid/view/animation/Animation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/animation/ViewAnimationFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewAnimationFactory); }
		}

		protected ViewAnimationFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewAnimationFactory']/constructor[@name='ViewAnimationFactory' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe ViewAnimationFactory (global::Android.Content.Context p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ViewAnimationFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_view_animation_Animation_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewAnimationFactory']/constructor[@name='ViewAnimationFactory' and count(parameter)=1 and parameter[1][@type='android.view.animation.Animation']]"
		[Register (".ctor", "(Landroid/view/animation/Animation;)V", "")]
		public unsafe ViewAnimationFactory (global::Android.Views.Animations.Animation p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ViewAnimationFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/animation/Animation;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/animation/Animation;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_animation_Animation_ == IntPtr.Zero)
					id_ctor_Landroid_view_animation_Animation_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/animation/Animation;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_animation_Animation_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_animation_Animation_, __args);
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
			global::Com.Bumptech.Glide.Request.Animation.ViewAnimationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.ViewAnimationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_build_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='ViewAnimationFactory']/method[@name='build' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
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
