using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Target {

	[Register ("com/bumptech/glide/request/target/Target")]
	public abstract class Target {

		internal Target ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.request.target']/interface[@name='Target']/field[@name='SIZE_ORIGINAL']"
		[Register ("SIZE_ORIGINAL")]
		public const int SizeOriginal = (int) -2147483648;

		// The following are fields from: com.bumptech.glide.manager.LifecycleListener
	}

	[global::System.Obsolete ("Use the 'Target' type. This type will be removed in a future release.")]
	public abstract class TargetConsts : Target {

		private TargetConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.request.target']/interface[@name='Target']"
	[Register ("com/bumptech/glide/request/target/Target", "", "Com.Bumptech.Glide.Request.Target.ITargetInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial interface ITarget : global::Com.Bumptech.Glide.Manager.ILifecycleListener {

		global::Com.Bumptech.Glide.Request.IRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/interface[@name='Target']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/bumptech/glide/request/Request;", "GetGetRequestHandler:Com.Bumptech.Glide.Request.Target.ITargetInvoker, Test_Binding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/interface[@name='Target']/method[@name='setRequest' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.Request']]"
			[Register ("setRequest", "(Lcom/bumptech/glide/request/Request;)V", "GetSetRequest_Lcom_bumptech_glide_request_Request_Handler:Com.Bumptech.Glide.Request.Target.ITargetInvoker, Test_Binding")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/interface[@name='Target']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.target.SizeReadyCallback']]"
		[Register ("getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler:Com.Bumptech.Glide.Request.Target.ITargetInvoker, Test_Binding")]
		void GetSize (global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/interface[@name='Target']/method[@name='onLoadCleared' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("onLoadCleared", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler:Com.Bumptech.Glide.Request.Target.ITargetInvoker, Test_Binding")]
		void OnLoadCleared (global::Android.Graphics.Drawables.Drawable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/interface[@name='Target']/method[@name='onLoadFailed' and count(parameter)=2 and parameter[1][@type='java.lang.Exception'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("onLoadFailed", "(Ljava/lang/Exception;Landroid/graphics/drawable/Drawable;)V", "GetOnLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_Handler:Com.Bumptech.Glide.Request.Target.ITargetInvoker, Test_Binding")]
		void OnLoadFailed (global::Java.Lang.Exception p0, global::Android.Graphics.Drawables.Drawable p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/interface[@name='Target']/method[@name='onLoadStarted' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("onLoadStarted", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadStarted_Landroid_graphics_drawable_Drawable_Handler:Com.Bumptech.Glide.Request.Target.ITargetInvoker, Test_Binding")]
		void OnLoadStarted (global::Android.Graphics.Drawables.Drawable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/interface[@name='Target']/method[@name='onResourceReady' and count(parameter)=2 and parameter[1][@type='R'] and parameter[2][@type='com.bumptech.glide.request.animation.GlideAnimation&lt;? super R&gt;']]"
		[Register ("onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation;)V", "GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_Handler:Com.Bumptech.Glide.Request.Target.ITargetInvoker, Test_Binding")]
		void OnResourceReady (global::Java.Lang.Object p0, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation p1);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/request/target/Target", DoNotGenerateAcw=true)]
	internal class ITargetInvoker : global::Java.Lang.Object, ITarget {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/request/target/Target");
		IntPtr class_ref;

		public static ITarget GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITarget> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.request.target.Target"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITargetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITargetInvoker); }
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
			global::Com.Bumptech.Glide.Request.Target.ITarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Request.Target.ITarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Request.Target.ITarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Request.Target.ITarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Request.Target.ITarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Request.Target.ITarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Request.Target.ITarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Request.Target.ITarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Request.Target.ITarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Request.Target.ITarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
