using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ViewPreloadSizeProvider']"
	[global::Android.Runtime.Register ("com/bumptech/glide/util/ViewPreloadSizeProvider", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class ViewPreloadSizeProvider : global::Java.Lang.Object, global::Com.Bumptech.Glide.ListPreloader.IPreloadSizeProvider, global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ViewPreloadSizeProvider.SizeViewTarget']"
		[global::Android.Runtime.Register ("com/bumptech/glide/util/ViewPreloadSizeProvider$SizeViewTarget", DoNotGenerateAcw=true)]
		public sealed partial class SizeViewTarget : global::Com.Bumptech.Glide.Request.Target.ViewTarget {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/util/ViewPreloadSizeProvider$SizeViewTarget", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SizeViewTarget); }
			}

			internal SizeViewTarget (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_view_View_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ViewPreloadSizeProvider.SizeViewTarget']/constructor[@name='ViewPreloadSizeProvider.SizeViewTarget' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.bumptech.glide.request.target.SizeReadyCallback']]"
			[Register (".ctor", "(Landroid/view/View;Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "")]
			public unsafe SizeViewTarget (global::Android.Views.View p0, global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (SizeViewTarget)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/View;Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/View;Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", __args);
						return;
					}

					if (id_ctor_Landroid_view_View_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == IntPtr.Zero)
						id_ctor_Landroid_view_View_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;Lcom/bumptech/glide/request/target/SizeReadyCallback;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_Lcom_bumptech_glide_request_target_SizeReadyCallback_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_View_Lcom_bumptech_glide_request_target_SizeReadyCallback_, __args);
				} finally {
				}
			}

			static IntPtr id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ViewPreloadSizeProvider.SizeViewTarget']/method[@name='onResourceReady' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.bumptech.glide.request.animation.GlideAnimation']]"
			[Register ("onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation;)V", "")]
			public override unsafe void OnResourceReady (global::Java.Lang.Object p0, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation p1)
			{
				if (id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ == IntPtr.Zero)
					id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ = JNIEnv.GetMethodID (class_ref, "onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					JNIEnv.CallVoidMethod  (Handle, id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/util/ViewPreloadSizeProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewPreloadSizeProvider); }
		}

		protected ViewPreloadSizeProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ViewPreloadSizeProvider']/constructor[@name='ViewPreloadSizeProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ViewPreloadSizeProvider ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ViewPreloadSizeProvider)) {
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

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ViewPreloadSizeProvider']/constructor[@name='ViewPreloadSizeProvider' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe ViewPreloadSizeProvider (global::Android.Views.View p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ViewPreloadSizeProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/View;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/View;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_View_, __args);
			} finally {
			}
		}

		static Delegate cb_getPreloadSize_Ljava_lang_Object_II;
#pragma warning disable 0169
		static Delegate GetGetPreloadSize_Ljava_lang_Object_IIHandler ()
		{
			if (cb_getPreloadSize_Ljava_lang_Object_II == null)
				cb_getPreloadSize_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetPreloadSize_Ljava_lang_Object_II);
			return cb_getPreloadSize_Ljava_lang_Object_II;
		}

		static IntPtr n_GetPreloadSize_Ljava_lang_Object_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Util.ViewPreloadSizeProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.ViewPreloadSizeProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetPreloadSize (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPreloadSize_Ljava_lang_Object_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ViewPreloadSizeProvider']/method[@name='getPreloadSize' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getPreloadSize", "(Ljava/lang/Object;II)[I", "GetGetPreloadSize_Ljava_lang_Object_IIHandler")]
		public virtual unsafe int[] GetPreloadSize (global::Java.Lang.Object p0, int p1, int p2)
		{
			if (id_getPreloadSize_Ljava_lang_Object_II == IntPtr.Zero)
				id_getPreloadSize_Ljava_lang_Object_II = JNIEnv.GetMethodID (class_ref, "getPreloadSize", "(Ljava/lang/Object;II)[I");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int[] __ret;
				if (GetType () == ThresholdType)
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPreloadSize_Ljava_lang_Object_II, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreloadSize", "(Ljava/lang/Object;II)[I"), __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onSizeReady_II;
#pragma warning disable 0169
		static Delegate GetOnSizeReady_IIHandler ()
		{
			if (cb_onSizeReady_II == null)
				cb_onSizeReady_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnSizeReady_II);
			return cb_onSizeReady_II;
		}

		static void n_OnSizeReady_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Bumptech.Glide.Util.ViewPreloadSizeProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.ViewPreloadSizeProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSizeReady (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onSizeReady_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ViewPreloadSizeProvider']/method[@name='onSizeReady' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onSizeReady", "(II)V", "GetOnSizeReady_IIHandler")]
		public virtual unsafe void OnSizeReady (int p0, int p1)
		{
			if (id_onSizeReady_II == IntPtr.Zero)
				id_onSizeReady_II = JNIEnv.GetMethodID (class_ref, "onSizeReady", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSizeReady_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSizeReady", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetView_Landroid_view_View_Handler ()
		{
			if (cb_setView_Landroid_view_View_ == null)
				cb_setView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetView_Landroid_view_View_);
			return cb_setView_Landroid_view_View_;
		}

		static void n_SetView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Util.ViewPreloadSizeProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.ViewPreloadSizeProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ViewPreloadSizeProvider']/method[@name='setView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setView", "(Landroid/view/View;)V", "GetSetView_Landroid_view_View_Handler")]
		public virtual unsafe void SetView (global::Android.Views.View p0)
		{
			if (id_setView_Landroid_view_View_ == IntPtr.Zero)
				id_setView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setView", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setView_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setView", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

	}
}
