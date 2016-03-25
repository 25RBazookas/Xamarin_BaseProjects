using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='FutureTarget']"
	[Register ("com/bumptech/glide/request/FutureTarget", "", "Com.Bumptech.Glide.Request.IFutureTargetInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial interface IFutureTarget : global::Com.Bumptech.Glide.Request.Target.ITarget, global::Java.Util.Concurrent.IFuture {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='FutureTarget']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.Bumptech.Glide.Request.IFutureTargetInvoker, Test_Binding")]
		void Clear ();

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/request/FutureTarget", DoNotGenerateAcw=true)]
	internal class IFutureTargetInvoker : global::Java.Lang.Object, IFutureTarget {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/request/FutureTarget");
		IntPtr class_ref;

		public static IFutureTarget GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFutureTarget> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.request.FutureTarget"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFutureTargetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFutureTargetInvoker); }
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (Handle, id_clear);
		}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		static Delegate cb_setRequest_Lcom_bumptech_glide_request_Request_;
#pragma warning disable 0169
		static Delegate GetSetRequest_Lcom_bumptech_glide_request_Request_Handler ()
		{
			if (cb_setRequest_Lcom_bumptech_glide_request_Request_ == null)
				cb_setRequest_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequest_Lcom_bumptech_glide_request_Request_);
			return cb_setRequest_Lcom_bumptech_glide_request_Request_;
		}

		static void n_SetRequest_Lcom_bumptech_glide_request_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.IRequest p0 = (global::Com.Bumptech.Glide.Request.IRequest)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Request = p0;
		}
#pragma warning restore 0169

		IntPtr id_getRequest;
		IntPtr id_setRequest_Lcom_bumptech_glide_request_Request_;
		public unsafe global::Com.Bumptech.Glide.Request.IRequest Request {
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lcom/bumptech/glide/request/Request;");
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (JNIEnv.CallObjectMethod (Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setRequest_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
					id_setRequest_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID (class_ref, "setRequest", "(Lcom/bumptech/glide/request/Request;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setRequest_Lcom_bumptech_glide_request_Request_, __args);
			}
		}

		static Delegate cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
#pragma warning disable 0169
		static Delegate GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler ()
		{
			if (cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == null)
				cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_);
			return cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		}

		static void n_GetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback p0 = (global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetSize (p0);
		}
#pragma warning restore 0169

		IntPtr id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		public unsafe void GetSize (global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback p0)
		{
			if (id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == IntPtr.Zero)
				id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNIEnv.GetMethodID (class_ref, "getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_, __args);
		}

		static Delegate cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ == null)
				cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoadCleared_Landroid_graphics_drawable_Drawable_);
			return cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;
		}

		static void n_OnLoadCleared_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadCleared (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLoadCleared_Landroid_graphics_drawable_Drawable_;
		public unsafe void OnLoadCleared (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_onLoadCleared_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_onLoadCleared_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "onLoadCleared", "(Landroid/graphics/drawable/Drawable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onLoadCleared_Landroid_graphics_drawable_Drawable_, __args);
		}

		static Delegate cb_onLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetOnLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_onLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_ == null)
				cb_onLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_);
			return cb_onLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_;
		}

		static void n_OnLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_;
		public unsafe void OnLoadFailed (global::Java.Lang.Exception p0, global::Android.Graphics.Drawables.Drawable p1)
		{
			if (id_onLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_onLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "onLoadFailed", "(Ljava/lang/Exception;Landroid/graphics/drawable/Drawable;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_, __args);
		}

		static Delegate cb_onLoadStarted_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetOnLoadStarted_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_onLoadStarted_Landroid_graphics_drawable_Drawable_ == null)
				cb_onLoadStarted_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoadStarted_Landroid_graphics_drawable_Drawable_);
			return cb_onLoadStarted_Landroid_graphics_drawable_Drawable_;
		}

		static void n_OnLoadStarted_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadStarted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLoadStarted_Landroid_graphics_drawable_Drawable_;
		public unsafe void OnLoadStarted (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_onLoadStarted_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_onLoadStarted_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "onLoadStarted", "(Landroid/graphics/drawable/Drawable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onLoadStarted_Landroid_graphics_drawable_Drawable_, __args);
		}

		static Delegate cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_;
#pragma warning disable 0169
		static Delegate GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_Handler ()
		{
			if (cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ == null)
				cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_);
			return cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_;
		}

		static void n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation p1 = (global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnResourceReady (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_;
		public unsafe void OnResourceReady (global::Java.Lang.Object p0, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation p1)
		{
			if (id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ == IntPtr.Zero)
				id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ = JNIEnv.GetMethodID (class_ref, "onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		IntPtr id_onDestroy;
		public unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onDestroy);
		}

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		IntPtr id_onStart;
		public unsafe void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onStart);
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		IntPtr id_onStop;
		public unsafe void OnStop ()
		{
			if (id_onStop == IntPtr.Zero)
				id_onStop = JNIEnv.GetMethodID (class_ref, "onStop", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onStop);
		}

		static Delegate cb_isCancelled;
#pragma warning disable 0169
		static Delegate GetIsCancelledHandler ()
		{
			if (cb_isCancelled == null)
				cb_isCancelled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCancelled);
			return cb_isCancelled;
		}

		static bool n_IsCancelled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancelled;
		}
#pragma warning restore 0169

		IntPtr id_isCancelled;
		public unsafe global::System.Boolean IsCancelled {
			get {
				if (id_isCancelled == IntPtr.Zero)
					id_isCancelled = JNIEnv.GetMethodID (class_ref, "isCancelled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isCancelled);
			}
		}

		static Delegate cb_isDone;
#pragma warning disable 0169
		static Delegate GetIsDoneHandler ()
		{
			if (cb_isDone == null)
				cb_isDone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDone);
			return cb_isDone;
		}

		static bool n_IsDone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDone;
		}
#pragma warning restore 0169

		IntPtr id_isDone;
		public unsafe global::System.Boolean IsDone {
			get {
				if (id_isDone == IntPtr.Zero)
					id_isDone = JNIEnv.GetMethodID (class_ref, "isDone", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isDone);
			}
		}

		static Delegate cb_cancel_Z;
#pragma warning disable 0169
		static Delegate GetCancel_ZHandler ()
		{
			if (cb_cancel_Z == null)
				cb_cancel_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_Cancel_Z);
			return cb_cancel_Z;
		}

		static bool n_Cancel_Z (IntPtr jnienv, IntPtr native__this, bool mayInterruptIfRunning)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cancel (mayInterruptIfRunning);
		}
#pragma warning restore 0169

		IntPtr id_cancel_Z;
		public unsafe global::System.Boolean Cancel (bool mayInterruptIfRunning)
		{
			if (id_cancel_Z == IntPtr.Zero)
				id_cancel_Z = JNIEnv.GetMethodID (class_ref, "cancel", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (mayInterruptIfRunning);
			return JNIEnv.CallBooleanMethod (Handle, id_cancel_Z, __args);
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		IntPtr id_get;
		public unsafe global::Java.Lang.Object Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_get), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_get_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetGet_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_get_JLjava_util_concurrent_TimeUnit_ == null)
				cb_get_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_Get_JLjava_util_concurrent_TimeUnit_);
			return cb_get_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Get_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			global::Com.Bumptech.Glide.Request.IFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (timeout, unit));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_JLjava_util_concurrent_TimeUnit_;
		public unsafe global::Java.Lang.Object Get (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_get_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_get_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (timeout);
			__args [1] = new JValue (unit);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_get_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
