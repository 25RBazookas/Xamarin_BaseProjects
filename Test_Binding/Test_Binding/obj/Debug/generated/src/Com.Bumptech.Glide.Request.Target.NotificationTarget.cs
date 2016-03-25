using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Target {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='NotificationTarget']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/target/NotificationTarget", DoNotGenerateAcw=true)]
	public partial class NotificationTarget : global::Com.Bumptech.Glide.Request.Target.SimpleTarget {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/target/NotificationTarget", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NotificationTarget); }
		}

		protected NotificationTarget (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_ILandroid_app_Notification_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='NotificationTarget']/constructor[@name='NotificationTarget' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.widget.RemoteViews'] and parameter[3][@type='int'] and parameter[4][@type='android.app.Notification'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/widget/RemoteViews;ILandroid/app/Notification;I)V", "")]
		public unsafe NotificationTarget (global::Android.Content.Context p0, global::Android.Widget.RemoteViews p1, int p2, global::Android.App.Notification p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (NotificationTarget)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/widget/RemoteViews;ILandroid/app/Notification;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/widget/RemoteViews;ILandroid/app/Notification;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_ILandroid_app_Notification_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_ILandroid_app_Notification_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/widget/RemoteViews;ILandroid/app/Notification;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_ILandroid_app_Notification_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_ILandroid_app_Notification_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IIILandroid_app_Notification_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='NotificationTarget']/constructor[@name='NotificationTarget' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.widget.RemoteViews'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='android.app.Notification'] and parameter[7][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/widget/RemoteViews;IIILandroid/app/Notification;I)V", "")]
		public unsafe NotificationTarget (global::Android.Content.Context p0, global::Android.Widget.RemoteViews p1, int p2, int p3, int p4, global::Android.App.Notification p5, int p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				if (GetType () != typeof (NotificationTarget)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/widget/RemoteViews;IIILandroid/app/Notification;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/widget/RemoteViews;IIILandroid/app/Notification;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IIILandroid_app_Notification_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IIILandroid_app_Notification_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/widget/RemoteViews;IIILandroid/app/Notification;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IIILandroid_app_Notification_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_widget_RemoteViews_IIILandroid_app_Notification_I, __args);
			} finally {
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
			global::Com.Bumptech.Glide.Request.Target.NotificationTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.NotificationTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation p1 = (global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnResourceReady (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onResourceReady_Landroid_graphics_Bitmap_Lcom_bumptech_glide_request_animation_GlideAnimation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='NotificationTarget']/method[@name='onResourceReady' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.bumptech.glide.request.animation.GlideAnimation&lt;? super android.graphics.Bitmap&gt;']]"
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
