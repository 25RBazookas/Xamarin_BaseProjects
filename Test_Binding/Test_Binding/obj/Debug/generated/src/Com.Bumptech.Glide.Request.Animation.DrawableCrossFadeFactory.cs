using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='DrawableCrossFadeFactory']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/DrawableCrossFadeFactory", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends android.graphics.drawable.Drawable"})]
	public partial class DrawableCrossFadeFactory : global::Java.Lang.Object, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationFactory {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='DrawableCrossFadeFactory.DefaultAnimationFactory']"
		[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/DrawableCrossFadeFactory$DefaultAnimationFactory", DoNotGenerateAcw=true)]
		public partial class DefaultAnimationFactory : global::Java.Lang.Object, global::Com.Bumptech.Glide.Request.Animation.ViewAnimation.IAnimationFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/request/animation/DrawableCrossFadeFactory$DefaultAnimationFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultAnimationFactory); }
			}

			protected DefaultAnimationFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Bumptech.Glide.Request.Animation.DrawableCrossFadeFactory.DefaultAnimationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.DrawableCrossFadeFactory.DefaultAnimationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='DrawableCrossFadeFactory.DefaultAnimationFactory']/method[@name='build' and count(parameter)=0]"
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
				return JNIEnv.FindClass ("com/bumptech/glide/request/animation/DrawableCrossFadeFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawableCrossFadeFactory); }
		}

		protected DrawableCrossFadeFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_animation_Animation_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='DrawableCrossFadeFactory']/constructor[@name='DrawableCrossFadeFactory' and count(parameter)=2 and parameter[1][@type='android.view.animation.Animation'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/view/animation/Animation;I)V", "")]
		public unsafe DrawableCrossFadeFactory (global::Android.Views.Animations.Animation p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DrawableCrossFadeFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/animation/Animation;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/animation/Animation;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_animation_Animation_I == IntPtr.Zero)
					id_ctor_Landroid_view_animation_Animation_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/animation/Animation;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_animation_Animation_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_animation_Animation_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='DrawableCrossFadeFactory']/constructor[@name='DrawableCrossFadeFactory' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;II)V", "")]
		public unsafe DrawableCrossFadeFactory (global::Android.Content.Context p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (DrawableCrossFadeFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='DrawableCrossFadeFactory']/constructor[@name='DrawableCrossFadeFactory' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe DrawableCrossFadeFactory (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DrawableCrossFadeFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='DrawableCrossFadeFactory']/constructor[@name='DrawableCrossFadeFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DrawableCrossFadeFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DrawableCrossFadeFactory)) {
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
			global::Com.Bumptech.Glide.Request.Animation.DrawableCrossFadeFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.DrawableCrossFadeFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_build_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/class[@name='DrawableCrossFadeFactory']/method[@name='build' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
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
