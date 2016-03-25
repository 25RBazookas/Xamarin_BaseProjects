using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Target {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='BaseTarget']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/target/BaseTarget", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Z"})]
	public abstract partial class BaseTarget : global::Java.Lang.Object, global::Com.Bumptech.Glide.Request.Target.ITarget {


		public static class InterfaceConsts {

			// The following are fields from: com.bumptech.glide.request.target.Target

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.request.target']/interface[@name='Target']/field[@name='SIZE_ORIGINAL']"
			[Register ("SIZE_ORIGINAL")]
			public const int SizeOriginal = (int) -2147483648;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/target/BaseTarget", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseTarget); }
		}

		protected BaseTarget (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='BaseTarget']/constructor[@name='BaseTarget' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseTarget ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaseTarget)) {
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
			global::Com.Bumptech.Glide.Request.Target.BaseTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.BaseTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Request.Target.BaseTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.BaseTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.IRequest p0 = (global::Com.Bumptech.Glide.Request.IRequest)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Request = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRequest;
		static IntPtr id_setRequest_Lcom_bumptech_glide_request_Request_;
		public virtual unsafe global::Com.Bumptech.Glide.Request.IRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='BaseTarget']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/bumptech/glide/request/Request;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lcom/bumptech/glide/request/Request;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (JNIEnv.CallObjectMethod  (Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequest", "()Lcom/bumptech/glide/request/Request;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='BaseTarget']/method[@name='setRequest' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.Request']]"
			[Register ("setRequest", "(Lcom/bumptech/glide/request/Request;)V", "GetSetRequest_Lcom_bumptech_glide_request_Request_Handler")]
			set {
				if (id_setRequest_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
					id_setRequest_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID (class_ref, "setRequest", "(Lcom/bumptech/glide/request/Request;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRequest_Lcom_bumptech_glide_request_Request_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequest", "(Lcom/bumptech/glide/request/Request;)V"), __args);
				} finally {
				}
			}
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
			global::Com.Bumptech.Glide.Request.Target.BaseTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.BaseTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='BaseTarget']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "()V"));
			} finally {
			}
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
			global::Com.Bumptech.Glide.Request.Target.BaseTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.BaseTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadCleared (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onLoadCleared_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='BaseTarget']/method[@name='onLoadCleared' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("onLoadCleared", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void OnLoadCleared (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_onLoadCleared_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_onLoadCleared_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "onLoadCleared", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLoadCleared_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLoadCleared", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
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
			global::Com.Bumptech.Glide.Request.Target.BaseTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.BaseTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadFailed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='BaseTarget']/method[@name='onLoadFailed' and count(parameter)=2 and parameter[1][@type='java.lang.Exception'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("onLoadFailed", "(Ljava/lang/Exception;Landroid/graphics/drawable/Drawable;)V", "GetOnLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void OnLoadFailed (global::Java.Lang.Exception p0, global::Android.Graphics.Drawables.Drawable p1)
		{
			if (id_onLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_onLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "onLoadFailed", "(Ljava/lang/Exception;Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLoadFailed", "(Ljava/lang/Exception;Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
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
			global::Com.Bumptech.Glide.Request.Target.BaseTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.BaseTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadStarted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onLoadStarted_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='BaseTarget']/method[@name='onLoadStarted' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("onLoadStarted", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadStarted_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void OnLoadStarted (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_onLoadStarted_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_onLoadStarted_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "onLoadStarted", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLoadStarted_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLoadStarted", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
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
			global::Com.Bumptech.Glide.Request.Target.BaseTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.BaseTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		static IntPtr id_onStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='BaseTarget']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual unsafe void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStart);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStart", "()V"));
			} finally {
			}
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
			global::Com.Bumptech.Glide.Request.Target.BaseTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.BaseTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		static IntPtr id_onStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='BaseTarget']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual unsafe void OnStop ()
		{
			if (id_onStop == IntPtr.Zero)
				id_onStop = JNIEnv.GetMethodID (class_ref, "onStop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStop", "()V"));
			} finally {
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
			global::Com.Bumptech.Glide.Request.Target.BaseTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.BaseTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback p0 = (global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetSize (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='BaseTarget']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.target.SizeReadyCallback']]"
		[Register ("getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler")]
		public abstract void GetSize (global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback p0);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/request/target/BaseTarget", DoNotGenerateAcw=true)]
	internal partial class BaseTargetInvoker : BaseTarget, global::Com.Bumptech.Glide.Request.Target.ITarget {

		public BaseTargetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseTargetInvoker); }
		}

		static IntPtr id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='BaseTarget']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.target.SizeReadyCallback']]"
		[Register ("getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler")]
		public override unsafe void GetSize (global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback p0)
		{
			if (id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == IntPtr.Zero)
				id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNIEnv.GetMethodID (class_ref, "getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_, __args);
			} finally {
			}
		}

	}

}
