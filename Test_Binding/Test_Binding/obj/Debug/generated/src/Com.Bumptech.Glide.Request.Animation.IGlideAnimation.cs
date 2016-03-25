using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Animation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.request.animation']/interface[@name='GlideAnimation.ViewAdapter']"
	[Register ("com/bumptech/glide/request/animation/GlideAnimation$ViewAdapter", "", "Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapterInvoker")]
	public partial interface IGlideAnimationViewAdapter : IJavaObject {

		global::Android.Graphics.Drawables.Drawable CurrentDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/interface[@name='GlideAnimation.ViewAdapter']/method[@name='getCurrentDrawable' and count(parameter)=0]"
			[Register ("getCurrentDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetCurrentDrawableHandler:Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapterInvoker, Test_Binding")] get;
		}

		global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/interface[@name='GlideAnimation.ViewAdapter']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler:Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapterInvoker, Test_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/interface[@name='GlideAnimation.ViewAdapter']/method[@name='setDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetDrawable_Landroid_graphics_drawable_Drawable_Handler:Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapterInvoker, Test_Binding")]
		void SetDrawable (global::Android.Graphics.Drawables.Drawable p0);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/GlideAnimation$ViewAdapter", DoNotGenerateAcw=true)]
	internal class IGlideAnimationViewAdapterInvoker : global::Java.Lang.Object, IGlideAnimationViewAdapter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/request/animation/GlideAnimation$ViewAdapter");
		IntPtr class_ref;

		public static IGlideAnimationViewAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGlideAnimationViewAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.request.animation.GlideAnimation.ViewAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGlideAnimationViewAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IGlideAnimationViewAdapterInvoker); }
		}

		static Delegate cb_getCurrentDrawable;
#pragma warning disable 0169
		static Delegate GetGetCurrentDrawableHandler ()
		{
			if (cb_getCurrentDrawable == null)
				cb_getCurrentDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentDrawable);
			return cb_getCurrentDrawable;
		}

		static IntPtr n_GetCurrentDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentDrawable);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentDrawable;
		public unsafe global::Android.Graphics.Drawables.Drawable CurrentDrawable {
			get {
				if (id_getCurrentDrawable == IntPtr.Zero)
					id_getCurrentDrawable = JNIEnv.GetMethodID (class_ref, "getCurrentDrawable", "()Landroid/graphics/drawable/Drawable;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (Handle, id_getCurrentDrawable), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		IntPtr id_getView;
		public unsafe global::Android.Views.View View {
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Landroid/view/View;");
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getView), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_setDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawable (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDrawable_Landroid_graphics_drawable_Drawable_;
		public unsafe void SetDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setDrawable_Landroid_graphics_drawable_Drawable_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.request.animation']/interface[@name='GlideAnimation']"
	[Register ("com/bumptech/glide/request/animation/GlideAnimation", "", "Com.Bumptech.Glide.Request.Animation.IGlideAnimationInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial interface IGlideAnimation : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/interface[@name='GlideAnimation']/method[@name='animate' and count(parameter)=2 and parameter[1][@type='R'] and parameter[2][@type='com.bumptech.glide.request.animation.GlideAnimation.ViewAdapter']]"
		[Register ("animate", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation$ViewAdapter;)Z", "GetAnimate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_Handler:Com.Bumptech.Glide.Request.Animation.IGlideAnimationInvoker, Test_Binding")]
		bool Animate (global::Java.Lang.Object p0, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter p1);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/GlideAnimation", DoNotGenerateAcw=true)]
	internal class IGlideAnimationInvoker : global::Java.Lang.Object, IGlideAnimation {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/request/animation/GlideAnimation");
		IntPtr class_ref;

		public static IGlideAnimation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGlideAnimation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.request.animation.GlideAnimation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGlideAnimationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IGlideAnimationInvoker); }
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
			global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter p1 = (global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Animate (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_;
		public unsafe bool Animate (global::Java.Lang.Object p0, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter p1)
		{
			if (id_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_ == IntPtr.Zero)
				id_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_ = JNIEnv.GetMethodID (class_ref, "animate", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation$ViewAdapter;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_animate_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ViewAdapter_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
