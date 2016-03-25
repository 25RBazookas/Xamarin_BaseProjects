using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/ThumbnailRequestCoordinator", DoNotGenerateAcw=true)]
	public partial class ThumbnailRequestCoordinator : global::Java.Lang.Object, global::Com.Bumptech.Glide.Request.IRequest, global::Com.Bumptech.Glide.Request.IRequestCoordinator {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/ThumbnailRequestCoordinator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThumbnailRequestCoordinator); }
		}

		protected ThumbnailRequestCoordinator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/constructor[@name='ThumbnailRequestCoordinator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThumbnailRequestCoordinator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ThumbnailRequestCoordinator)) {
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

		static IntPtr id_ctor_Lcom_bumptech_glide_request_RequestCoordinator_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/constructor[@name='ThumbnailRequestCoordinator' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.RequestCoordinator']]"
		[Register (".ctor", "(Lcom/bumptech/glide/request/RequestCoordinator;)V", "")]
		public unsafe ThumbnailRequestCoordinator (global::Com.Bumptech.Glide.Request.IRequestCoordinator p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ThumbnailRequestCoordinator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/request/RequestCoordinator;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/request/RequestCoordinator;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_request_RequestCoordinator_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_request_RequestCoordinator_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/request/RequestCoordinator;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_request_RequestCoordinator_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_request_RequestCoordinator_, __args);
			} finally {
			}
		}

		static Delegate cb_isAnyResourceSet;
#pragma warning disable 0169
		static Delegate GetIsAnyResourceSetHandler ()
		{
			if (cb_isAnyResourceSet == null)
				cb_isAnyResourceSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAnyResourceSet);
			return cb_isAnyResourceSet;
		}

		static bool n_IsAnyResourceSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnyResourceSet;
		}
#pragma warning restore 0169

		static IntPtr id_isAnyResourceSet;
		public virtual unsafe bool IsAnyResourceSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/method[@name='isAnyResourceSet' and count(parameter)=0]"
			[Register ("isAnyResourceSet", "()Z", "GetIsAnyResourceSetHandler")]
			get {
				if (id_isAnyResourceSet == IntPtr.Zero)
					id_isAnyResourceSet = JNIEnv.GetMethodID (class_ref, "isAnyResourceSet", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isAnyResourceSet);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAnyResourceSet", "()Z"));
				} finally {
				}
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
			global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancelled;
		}
#pragma warning restore 0169

		static IntPtr id_isCancelled;
		public virtual unsafe bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/method[@name='isCancelled' and count(parameter)=0]"
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

		static Delegate cb_isComplete;
#pragma warning disable 0169
		static Delegate GetIsCompleteHandler ()
		{
			if (cb_isComplete == null)
				cb_isComplete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsComplete);
			return cb_isComplete;
		}

		static bool n_IsComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsComplete;
		}
#pragma warning restore 0169

		static IntPtr id_isComplete;
		public virtual unsafe bool IsComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/method[@name='isComplete' and count(parameter)=0]"
			[Register ("isComplete", "()Z", "GetIsCompleteHandler")]
			get {
				if (id_isComplete == IntPtr.Zero)
					id_isComplete = JNIEnv.GetMethodID (class_ref, "isComplete", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isComplete);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isComplete", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isFailed;
#pragma warning disable 0169
		static Delegate GetIsFailedHandler ()
		{
			if (cb_isFailed == null)
				cb_isFailed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFailed);
			return cb_isFailed;
		}

		static bool n_IsFailed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFailed;
		}
#pragma warning restore 0169

		static IntPtr id_isFailed;
		public virtual unsafe bool IsFailed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/method[@name='isFailed' and count(parameter)=0]"
			[Register ("isFailed", "()Z", "GetIsFailedHandler")]
			get {
				if (id_isFailed == IntPtr.Zero)
					id_isFailed = JNIEnv.GetMethodID (class_ref, "isFailed", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isFailed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFailed", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isPaused;
#pragma warning disable 0169
		static Delegate GetIsPausedHandler ()
		{
			if (cb_isPaused == null)
				cb_isPaused = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPaused);
			return cb_isPaused;
		}

		static bool n_IsPaused (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		static IntPtr id_isPaused;
		public virtual unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/method[@name='isPaused' and count(parameter)=0]"
			[Register ("isPaused", "()Z", "GetIsPausedHandler")]
			get {
				if (id_isPaused == IntPtr.Zero)
					id_isPaused = JNIEnv.GetMethodID (class_ref, "isPaused", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isPaused);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPaused", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isResourceSet;
#pragma warning disable 0169
		static Delegate GetIsResourceSetHandler ()
		{
			if (cb_isResourceSet == null)
				cb_isResourceSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsResourceSet);
			return cb_isResourceSet;
		}

		static bool n_IsResourceSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsResourceSet;
		}
#pragma warning restore 0169

		static IntPtr id_isResourceSet;
		public virtual unsafe bool IsResourceSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/method[@name='isResourceSet' and count(parameter)=0]"
			[Register ("isResourceSet", "()Z", "GetIsResourceSetHandler")]
			get {
				if (id_isResourceSet == IntPtr.Zero)
					id_isResourceSet = JNIEnv.GetMethodID (class_ref, "isResourceSet", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isResourceSet);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isResourceSet", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		static IntPtr id_isRunning;
		public virtual unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isRunning);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRunning", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_begin;
#pragma warning disable 0169
		static Delegate GetBeginHandler ()
		{
			if (cb_begin == null)
				cb_begin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Begin);
			return cb_begin;
		}

		static void n_Begin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Begin ();
		}
#pragma warning restore 0169

		static IntPtr id_begin;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/method[@name='begin' and count(parameter)=0]"
		[Register ("begin", "()V", "GetBeginHandler")]
		public virtual unsafe void Begin ()
		{
			if (id_begin == IntPtr.Zero)
				id_begin = JNIEnv.GetMethodID (class_ref, "begin", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_begin);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "begin", "()V"));
			} finally {
			}
		}

		static Delegate cb_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_;
#pragma warning disable 0169
		static Delegate GetCanNotifyStatusChanged_Lcom_bumptech_glide_request_Request_Handler ()
		{
			if (cb_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_ == null)
				cb_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanNotifyStatusChanged_Lcom_bumptech_glide_request_Request_);
			return cb_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_;
		}

		static bool n_CanNotifyStatusChanged_Lcom_bumptech_glide_request_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.IRequest p0 = (global::Com.Bumptech.Glide.Request.IRequest)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanNotifyStatusChanged (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/method[@name='canNotifyStatusChanged' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.Request']]"
		[Register ("canNotifyStatusChanged", "(Lcom/bumptech/glide/request/Request;)Z", "GetCanNotifyStatusChanged_Lcom_bumptech_glide_request_Request_Handler")]
		public virtual unsafe bool CanNotifyStatusChanged (global::Com.Bumptech.Glide.Request.IRequest p0)
		{
			if (id_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
				id_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID (class_ref, "canNotifyStatusChanged", "(Lcom/bumptech/glide/request/Request;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canNotifyStatusChanged", "(Lcom/bumptech/glide/request/Request;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_canSetImage_Lcom_bumptech_glide_request_Request_;
#pragma warning disable 0169
		static Delegate GetCanSetImage_Lcom_bumptech_glide_request_Request_Handler ()
		{
			if (cb_canSetImage_Lcom_bumptech_glide_request_Request_ == null)
				cb_canSetImage_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanSetImage_Lcom_bumptech_glide_request_Request_);
			return cb_canSetImage_Lcom_bumptech_glide_request_Request_;
		}

		static bool n_CanSetImage_Lcom_bumptech_glide_request_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.IRequest p0 = (global::Com.Bumptech.Glide.Request.IRequest)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanSetImage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_canSetImage_Lcom_bumptech_glide_request_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/method[@name='canSetImage' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.Request']]"
		[Register ("canSetImage", "(Lcom/bumptech/glide/request/Request;)Z", "GetCanSetImage_Lcom_bumptech_glide_request_Request_Handler")]
		public virtual unsafe bool CanSetImage (global::Com.Bumptech.Glide.Request.IRequest p0)
		{
			if (id_canSetImage_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
				id_canSetImage_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID (class_ref, "canSetImage", "(Lcom/bumptech/glide/request/Request;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_canSetImage_Lcom_bumptech_glide_request_Request_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canSetImage", "(Lcom/bumptech/glide/request/Request;)Z"), __args);
				return __ret;
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
			global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/method[@name='clear' and count(parameter)=0]"
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

		static Delegate cb_onRequestSuccess_Lcom_bumptech_glide_request_Request_;
#pragma warning disable 0169
		static Delegate GetOnRequestSuccess_Lcom_bumptech_glide_request_Request_Handler ()
		{
			if (cb_onRequestSuccess_Lcom_bumptech_glide_request_Request_ == null)
				cb_onRequestSuccess_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRequestSuccess_Lcom_bumptech_glide_request_Request_);
			return cb_onRequestSuccess_Lcom_bumptech_glide_request_Request_;
		}

		static void n_OnRequestSuccess_Lcom_bumptech_glide_request_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.IRequest p0 = (global::Com.Bumptech.Glide.Request.IRequest)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestSuccess (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRequestSuccess_Lcom_bumptech_glide_request_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/method[@name='onRequestSuccess' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.Request']]"
		[Register ("onRequestSuccess", "(Lcom/bumptech/glide/request/Request;)V", "GetOnRequestSuccess_Lcom_bumptech_glide_request_Request_Handler")]
		public virtual unsafe void OnRequestSuccess (global::Com.Bumptech.Glide.Request.IRequest p0)
		{
			if (id_onRequestSuccess_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
				id_onRequestSuccess_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID (class_ref, "onRequestSuccess", "(Lcom/bumptech/glide/request/Request;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRequestSuccess_Lcom_bumptech_glide_request_Request_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequestSuccess", "(Lcom/bumptech/glide/request/Request;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_pause);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "()V"));
			} finally {
			}
		}

		static Delegate cb_recycle;
#pragma warning disable 0169
		static Delegate GetRecycleHandler ()
		{
			if (cb_recycle == null)
				cb_recycle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Recycle);
			return cb_recycle;
		}

		static void n_Recycle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler")]
		public virtual unsafe void Recycle ()
		{
			if (id_recycle == IntPtr.Zero)
				id_recycle = JNIEnv.GetMethodID (class_ref, "recycle", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_recycle);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recycle", "()V"));
			} finally {
			}
		}

		static Delegate cb_setRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_;
#pragma warning disable 0169
		static Delegate GetSetRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_Handler ()
		{
			if (cb_setRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_ == null)
				cb_setRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_);
			return cb_setRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_;
		}

		static void n_SetRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.ThumbnailRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.IRequest p0 = (global::Com.Bumptech.Glide.Request.IRequest)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.IRequest p1 = (global::Com.Bumptech.Glide.Request.IRequest)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetRequests (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='ThumbnailRequestCoordinator']/method[@name='setRequests' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.request.Request'] and parameter[2][@type='com.bumptech.glide.request.Request']]"
		[Register ("setRequests", "(Lcom/bumptech/glide/request/Request;Lcom/bumptech/glide/request/Request;)V", "GetSetRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_Handler")]
		public virtual unsafe void SetRequests (global::Com.Bumptech.Glide.Request.IRequest p0, global::Com.Bumptech.Glide.Request.IRequest p1)
		{
			if (id_setRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
				id_setRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID (class_ref, "setRequests", "(Lcom/bumptech/glide/request/Request;Lcom/bumptech/glide/request/Request;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRequests_Lcom_bumptech_glide_request_Request_Lcom_bumptech_glide_request_Request_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequests", "(Lcom/bumptech/glide/request/Request;Lcom/bumptech/glide/request/Request;)V"), __args);
			} finally {
			}
		}

	}
}
