using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Target {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='AppWidgetTarget']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/target/AppWidgetTarget", DoNotGenerateAcw=true)]
	public partial class AppWidgetTarget : global::Com.Bumptech.Glide.Request.Target.SimpleTarget {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/target/AppWidgetTarget", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppWidgetTarget); }
		}

		protected AppWidgetTarget (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_ILandroid_content_ComponentName_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='AppWidgetTarget']/constructor[@name='AppWidgetTarget' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.widget.RemoteViews'] and parameter[3][@type='int'] and parameter[4][@type='android.content.ComponentName']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/widget/RemoteViews;ILandroid/content/ComponentName;)V", "")]
		public unsafe AppWidgetTarget (global::Android.Content.Context p0, global::Android.Widget.RemoteViews p1, int p2, global::Android.Content.ComponentName p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (AppWidgetTarget)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/widget/RemoteViews;ILandroid/content/ComponentName;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/widget/RemoteViews;ILandroid/content/ComponentName;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_ILandroid_content_ComponentName_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_ILandroid_content_ComponentName_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/widget/RemoteViews;ILandroid/content/ComponentName;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_ILandroid_content_ComponentName_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_ILandroid_content_ComponentName_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IIILandroid_content_ComponentName_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='AppWidgetTarget']/constructor[@name='AppWidgetTarget' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.widget.RemoteViews'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='android.content.ComponentName']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/widget/RemoteViews;IIILandroid/content/ComponentName;)V", "")]
		public unsafe AppWidgetTarget (global::Android.Content.Context p0, global::Android.Widget.RemoteViews p1, int p2, int p3, int p4, global::Android.Content.ComponentName p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (GetType () != typeof (AppWidgetTarget)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/widget/RemoteViews;IIILandroid/content/ComponentName;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/widget/RemoteViews;IIILandroid/content/ComponentName;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IIILandroid_content_ComponentName_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IIILandroid_content_ComponentName_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/widget/RemoteViews;IIILandroid/content/ComponentName;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IIILandroid_content_ComponentName_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IIILandroid_content_ComponentName_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IarrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='AppWidgetTarget']/constructor[@name='AppWidgetTarget' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.widget.RemoteViews'] and parameter[3][@type='int'] and parameter[4][@type='int...']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/widget/RemoteViews;I[I)V", "")]
		public unsafe AppWidgetTarget (global::Android.Content.Context p0, global::Android.Widget.RemoteViews p1, int p2, params  int[] p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (AppWidgetTarget)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/widget/RemoteViews;I[I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/widget/RemoteViews;I[I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IarrayI == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IarrayI = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/widget/RemoteViews;I[I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IarrayI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IarrayI, __args);
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IIIarrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='AppWidgetTarget']/constructor[@name='AppWidgetTarget' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.widget.RemoteViews'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int...']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/widget/RemoteViews;III[I)V", "")]
		public unsafe AppWidgetTarget (global::Android.Content.Context p0, global::Android.Widget.RemoteViews p1, int p2, int p3, int p4, params  int[] p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p5 = JNIEnv.NewArray (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				if (GetType () != typeof (AppWidgetTarget)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/widget/RemoteViews;III[I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/widget/RemoteViews;III[I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IIIarrayI == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IIIarrayI = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/widget/RemoteViews;III[I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IIIarrayI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IIIarrayI, __args);
			} finally {
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}
		}

		static Delegate cb_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_animation_GlideAnimation_;
#pragma warning disable 0169
		static Delegate GetOnResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_animation_GlideAnimation_Handler ()
		{
			if (cb_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_animation_GlideAnimation_ == null)
				cb_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_animation_GlideAnimation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_animation_GlideAnimation_);
			return cb_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_animation_GlideAnimation_;
		}

		static void n_OnResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_animation_GlideAnimation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Request.Target.AppWidgetTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.AppWidgetTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation p1 = (global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnResourceReady (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_animation_GlideAnimation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='AppWidgetTarget']/method[@name='onResourceReady' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.bumptech.glide.request.animation.GlideAnimation&lt;? super android.graphics.Bitmap&gt;']]"
		[Register ("onResourceReady", "(Landroid/graphics/Bitmap;Lcom/bumptech/glide/request/animation/GlideAnimation;)V", "GetOnResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_animation_GlideAnimation_Handler")]
		public virtual unsafe void OnResourceReady (global::Android.Graphics.Bitmap p0, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation p1)
		{
			if (id_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_animation_GlideAnimation_ == IntPtr.Zero)
				id_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_animation_GlideAnimation_ = JNIEnv.GetMethodID (class_ref, "onResourceReady", "(Landroid/graphics/Bitmap;Lcom/bumptech/glide/request/animation/GlideAnimation;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_animation_GlideAnimation_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResourceReady", "(Landroid/graphics/Bitmap;Lcom/bumptech/glide/request/animation/GlideAnimation;)V"), __args);
			} finally {
			}
		}

	}
}
