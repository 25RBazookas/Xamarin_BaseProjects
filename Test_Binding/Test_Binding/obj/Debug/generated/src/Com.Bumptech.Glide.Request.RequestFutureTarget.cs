using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/RequestFutureTarget", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public partial class RequestFutureTarget : global::Java.Lang.Object, global::Com.Bumptech.Glide.Request.IFutureTarget, global::Java.Lang.IRunnable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget.Waiter']"
		[global::Android.Runtime.Register ("com/bumptech/glide/request/RequestFutureTarget$Waiter", DoNotGenerateAcw=true)]
		public partial class Waiter : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/request/RequestFutureTarget$Waiter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Waiter); }
			}

			protected Waiter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_notifyAll_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetNotifyAll_Ljava_lang_Object_Handler ()
			{
				if (cb_notifyAll_Ljava_lang_Object_ == null)
					cb_notifyAll_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyAll_Ljava_lang_Object_);
				return cb_notifyAll_Ljava_lang_Object_;
			}

			static void n_NotifyAll_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Request.RequestFutureTarget.Waiter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget.Waiter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.NotifyAll (p0);
			}
#pragma warning restore 0169

			static IntPtr id_notifyAll_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget.Waiter']/method[@name='notifyAll' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("notifyAll", "(Ljava/lang/Object;)V", "GetNotifyAll_Ljava_lang_Object_Handler")]
			public virtual unsafe void NotifyAll (global::Java.Lang.Object p0)
			{
				if (id_notifyAll_Ljava_lang_Object_ == IntPtr.Zero)
					id_notifyAll_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "notifyAll", "(Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_notifyAll_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyAll", "(Ljava/lang/Object;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_waitForTimeout_Ljava_lang_Object_J;
#pragma warning disable 0169
			static Delegate GetWaitForTimeout_Ljava_lang_Object_JHandler ()
			{
				if (cb_waitForTimeout_Ljava_lang_Object_J == null)
					cb_waitForTimeout_Ljava_lang_Object_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_WaitForTimeout_Ljava_lang_Object_J);
				return cb_waitForTimeout_Ljava_lang_Object_J;
			}

			static void n_WaitForTimeout_Ljava_lang_Object_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
			{
				global::Com.Bumptech.Glide.Request.RequestFutureTarget.Waiter __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget.Waiter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.WaitForTimeout (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_waitForTimeout_Ljava_lang_Object_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget.Waiter']/method[@name='waitForTimeout' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long']]"
			[Register ("waitForTimeout", "(Ljava/lang/Object;J)V", "GetWaitForTimeout_Ljava_lang_Object_JHandler")]
			public virtual unsafe void WaitForTimeout (global::Java.Lang.Object p0, long p1)
			{
				if (id_waitForTimeout_Ljava_lang_Object_J == IntPtr.Zero)
					id_waitForTimeout_Ljava_lang_Object_J = JNIEnv.GetMethodID (class_ref, "waitForTimeout", "(Ljava/lang/Object;J)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_waitForTimeout_Ljava_lang_Object_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waitForTimeout", "(Ljava/lang/Object;J)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/RequestFutureTarget", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestFutureTarget); }
		}

		protected RequestFutureTarget (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Handler_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/constructor[@name='RequestFutureTarget' and count(parameter)=3 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/os/Handler;II)V", "")]
		public unsafe RequestFutureTarget (global::Android.OS.Handler p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (RequestFutureTarget)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Handler;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Handler;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Handler_II == IntPtr.Zero)
					id_ctor_Landroid_os_Handler_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Handler;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Handler_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Handler_II, __args);
			} finally {
			}
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
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancelled;
		}
#pragma warning restore 0169

		static IntPtr id_isCancelled;
		public virtual unsafe bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "GetIsCancelledHandler")]
			get {
				if (id_isCancelled == IntPtr.Zero)
					id_isCancelled = JNIEnv.GetMethodID (class_ref, "isCancelled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isCancelled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCancelled", "()Z"));
				} finally {
				}
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
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDone;
		}
#pragma warning restore 0169

		static IntPtr id_isDone;
		public virtual unsafe bool IsDone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='isDone' and count(parameter)=0]"
			[Register ("isDone", "()Z", "GetIsDoneHandler")]
			get {
				if (id_isDone == IntPtr.Zero)
					id_isDone = JNIEnv.GetMethodID (class_ref, "isDone", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDone);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDone", "()Z"));
				} finally {
				}
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
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.IRequest p0 = (global::Com.Bumptech.Glide.Request.IRequest)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Request = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRequest;
		static IntPtr id_setRequest_Lcom_bumptech_glide_request_Request_;
		public virtual unsafe global::Com.Bumptech.Glide.Request.IRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='getRequest' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='setRequest' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.Request']]"
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

		static Delegate cb_cancel_Z;
#pragma warning disable 0169
		static Delegate GetCancel_ZHandler ()
		{
			if (cb_cancel_Z == null)
				cb_cancel_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_Cancel_Z);
			return cb_cancel_Z;
		}

		static bool n_Cancel_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cancel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cancel_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("cancel", "(Z)Z", "GetCancel_ZHandler")]
		public virtual unsafe bool Cancel (bool p0)
		{
			if (id_cancel_Z == IntPtr.Zero)
				id_cancel_Z = JNIEnv.GetMethodID (class_ref, "cancel", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_cancel_Z, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "(Z)Z"), __args);
			} finally {
			}
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
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
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
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public virtual unsafe global::Java.Lang.Object Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
			try {

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetGet_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_get_JLjava_util_concurrent_TimeUnit_ == null)
				cb_get_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_Get_JLjava_util_concurrent_TimeUnit_);
			return cb_get_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Get_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='get' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "GetGet_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_get_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_get_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback p0 = (global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.target.SizeReadyCallback']]"
		[Register ("getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler")]
		public virtual unsafe void GetSize (global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback p0)
		{
			if (id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == IntPtr.Zero)
				id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNIEnv.GetMethodID (class_ref, "getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V"), __args);
			} finally {
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
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='onDestroy' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadCleared (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onLoadCleared_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='onLoadCleared' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
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
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadFailed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onLoadFailed_Ljava_lang_Exception_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='onLoadFailed' and count(parameter)=2 and parameter[1][@type='java.lang.Exception'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
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
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadStarted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onLoadStarted_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='onLoadStarted' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
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
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation p1 = (global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnResourceReady (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='onResourceReady' and count(parameter)=2 and parameter[1][@type='R'] and parameter[2][@type='com.bumptech.glide.request.animation.GlideAnimation&lt;? super R&gt;']]"
		[Register ("onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation;)V", "GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_Handler")]
		public virtual unsafe void OnResourceReady (global::Java.Lang.Object p0, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation p1)
		{
			if (id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ == IntPtr.Zero)
				id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ = JNIEnv.GetMethodID (class_ref, "onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		static IntPtr id_onStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='onStart' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		static IntPtr id_onStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='onStop' and count(parameter)=0]"
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

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.RequestFutureTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.RequestFutureTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='RequestFutureTarget']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

	}
}
