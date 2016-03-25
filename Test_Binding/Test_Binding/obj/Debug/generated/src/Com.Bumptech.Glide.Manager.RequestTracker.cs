using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Manager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestTracker']"
	[global::Android.Runtime.Register ("com/bumptech/glide/manager/RequestTracker", DoNotGenerateAcw=true)]
	public partial class RequestTracker : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/manager/RequestTracker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestTracker); }
		}

		protected RequestTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestTracker']/constructor[@name='RequestTracker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestTracker ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RequestTracker)) {
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
			global::Com.Bumptech.Glide.Manager.RequestTracker __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		static IntPtr id_isPaused;
		public virtual unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestTracker']/method[@name='isPaused' and count(parameter)=0]"
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

		static Delegate cb_clearRequests;
#pragma warning disable 0169
		static Delegate GetClearRequestsHandler ()
		{
			if (cb_clearRequests == null)
				cb_clearRequests = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearRequests);
			return cb_clearRequests;
		}

		static void n_ClearRequests (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Manager.RequestTracker __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearRequests ();
		}
#pragma warning restore 0169

		static IntPtr id_clearRequests;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestTracker']/method[@name='clearRequests' and count(parameter)=0]"
		[Register ("clearRequests", "()V", "GetClearRequestsHandler")]
		public virtual unsafe void ClearRequests ()
		{
			if (id_clearRequests == IntPtr.Zero)
				id_clearRequests = JNIEnv.GetMethodID (class_ref, "clearRequests", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearRequests);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearRequests", "()V"));
			} finally {
			}
		}

		static Delegate cb_pauseRequests;
#pragma warning disable 0169
		static Delegate GetPauseRequestsHandler ()
		{
			if (cb_pauseRequests == null)
				cb_pauseRequests = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PauseRequests);
			return cb_pauseRequests;
		}

		static void n_PauseRequests (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Manager.RequestTracker __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseRequests ();
		}
#pragma warning restore 0169

		static IntPtr id_pauseRequests;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestTracker']/method[@name='pauseRequests' and count(parameter)=0]"
		[Register ("pauseRequests", "()V", "GetPauseRequestsHandler")]
		public virtual unsafe void PauseRequests ()
		{
			if (id_pauseRequests == IntPtr.Zero)
				id_pauseRequests = JNIEnv.GetMethodID (class_ref, "pauseRequests", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_pauseRequests);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pauseRequests", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeRequest_Lcom_bumptech_glide_request_Request_;
#pragma warning disable 0169
		static Delegate GetRemoveRequest_Lcom_bumptech_glide_request_Request_Handler ()
		{
			if (cb_removeRequest_Lcom_bumptech_glide_request_Request_ == null)
				cb_removeRequest_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveRequest_Lcom_bumptech_glide_request_Request_);
			return cb_removeRequest_Lcom_bumptech_glide_request_Request_;
		}

		static void n_RemoveRequest_Lcom_bumptech_glide_request_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Manager.RequestTracker __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.IRequest p0 = (global::Com.Bumptech.Glide.Request.IRequest)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveRequest (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeRequest_Lcom_bumptech_glide_request_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestTracker']/method[@name='removeRequest' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.Request']]"
		[Register ("removeRequest", "(Lcom/bumptech/glide/request/Request;)V", "GetRemoveRequest_Lcom_bumptech_glide_request_Request_Handler")]
		public virtual unsafe void RemoveRequest (global::Com.Bumptech.Glide.Request.IRequest p0)
		{
			if (id_removeRequest_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
				id_removeRequest_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID (class_ref, "removeRequest", "(Lcom/bumptech/glide/request/Request;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeRequest_Lcom_bumptech_glide_request_Request_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeRequest", "(Lcom/bumptech/glide/request/Request;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_restartRequests;
#pragma warning disable 0169
		static Delegate GetRestartRequestsHandler ()
		{
			if (cb_restartRequests == null)
				cb_restartRequests = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RestartRequests);
			return cb_restartRequests;
		}

		static void n_RestartRequests (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Manager.RequestTracker __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RestartRequests ();
		}
#pragma warning restore 0169

		static IntPtr id_restartRequests;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestTracker']/method[@name='restartRequests' and count(parameter)=0]"
		[Register ("restartRequests", "()V", "GetRestartRequestsHandler")]
		public virtual unsafe void RestartRequests ()
		{
			if (id_restartRequests == IntPtr.Zero)
				id_restartRequests = JNIEnv.GetMethodID (class_ref, "restartRequests", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_restartRequests);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "restartRequests", "()V"));
			} finally {
			}
		}

		static Delegate cb_resumeRequests;
#pragma warning disable 0169
		static Delegate GetResumeRequestsHandler ()
		{
			if (cb_resumeRequests == null)
				cb_resumeRequests = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResumeRequests);
			return cb_resumeRequests;
		}

		static void n_ResumeRequests (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Manager.RequestTracker __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeRequests ();
		}
#pragma warning restore 0169

		static IntPtr id_resumeRequests;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestTracker']/method[@name='resumeRequests' and count(parameter)=0]"
		[Register ("resumeRequests", "()V", "GetResumeRequestsHandler")]
		public virtual unsafe void ResumeRequests ()
		{
			if (id_resumeRequests == IntPtr.Zero)
				id_resumeRequests = JNIEnv.GetMethodID (class_ref, "resumeRequests", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resumeRequests);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resumeRequests", "()V"));
			} finally {
			}
		}

		static Delegate cb_runRequest_Lcom_bumptech_glide_request_Request_;
#pragma warning disable 0169
		static Delegate GetRunRequest_Lcom_bumptech_glide_request_Request_Handler ()
		{
			if (cb_runRequest_Lcom_bumptech_glide_request_Request_ == null)
				cb_runRequest_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RunRequest_Lcom_bumptech_glide_request_Request_);
			return cb_runRequest_Lcom_bumptech_glide_request_Request_;
		}

		static void n_RunRequest_Lcom_bumptech_glide_request_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Manager.RequestTracker __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.IRequest p0 = (global::Com.Bumptech.Glide.Request.IRequest)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RunRequest (p0);
		}
#pragma warning restore 0169

		static IntPtr id_runRequest_Lcom_bumptech_glide_request_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestTracker']/method[@name='runRequest' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.Request']]"
		[Register ("runRequest", "(Lcom/bumptech/glide/request/Request;)V", "GetRunRequest_Lcom_bumptech_glide_request_Request_Handler")]
		public virtual unsafe void RunRequest (global::Com.Bumptech.Glide.Request.IRequest p0)
		{
			if (id_runRequest_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
				id_runRequest_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID (class_ref, "runRequest", "(Lcom/bumptech/glide/request/Request;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_runRequest_Lcom_bumptech_glide_request_Request_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "runRequest", "(Lcom/bumptech/glide/request/Request;)V"), __args);
			} finally {
			}
		}

	}
}
