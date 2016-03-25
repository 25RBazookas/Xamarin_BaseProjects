using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='RequestCoordinator']"
	[Register ("com/bumptech/glide/request/RequestCoordinator", "", "Com.Bumptech.Glide.Request.IRequestCoordinatorInvoker")]
	public partial interface IRequestCoordinator : IJavaObject {

		bool IsAnyResourceSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='RequestCoordinator']/method[@name='isAnyResourceSet' and count(parameter)=0]"
			[Register ("isAnyResourceSet", "()Z", "GetIsAnyResourceSetHandler:Com.Bumptech.Glide.Request.IRequestCoordinatorInvoker, Test_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='RequestCoordinator']/method[@name='canNotifyStatusChanged' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.Request']]"
		[Register ("canNotifyStatusChanged", "(Lcom/bumptech/glide/request/Request;)Z", "GetCanNotifyStatusChanged_Lcom_bumptech_glide_request_Request_Handler:Com.Bumptech.Glide.Request.IRequestCoordinatorInvoker, Test_Binding")]
		bool CanNotifyStatusChanged (global::Com.Bumptech.Glide.Request.IRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='RequestCoordinator']/method[@name='canSetImage' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.Request']]"
		[Register ("canSetImage", "(Lcom/bumptech/glide/request/Request;)Z", "GetCanSetImage_Lcom_bumptech_glide_request_Request_Handler:Com.Bumptech.Glide.Request.IRequestCoordinatorInvoker, Test_Binding")]
		bool CanSetImage (global::Com.Bumptech.Glide.Request.IRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='RequestCoordinator']/method[@name='onRequestSuccess' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.Request']]"
		[Register ("onRequestSuccess", "(Lcom/bumptech/glide/request/Request;)V", "GetOnRequestSuccess_Lcom_bumptech_glide_request_Request_Handler:Com.Bumptech.Glide.Request.IRequestCoordinatorInvoker, Test_Binding")]
		void OnRequestSuccess (global::Com.Bumptech.Glide.Request.IRequest p0);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/request/RequestCoordinator", DoNotGenerateAcw=true)]
	internal class IRequestCoordinatorInvoker : global::Java.Lang.Object, IRequestCoordinator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/request/RequestCoordinator");
		IntPtr class_ref;

		public static IRequestCoordinator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRequestCoordinator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.request.RequestCoordinator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRequestCoordinatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRequestCoordinatorInvoker); }
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
			global::Com.Bumptech.Glide.Request.IRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnyResourceSet;
		}
#pragma warning restore 0169

		IntPtr id_isAnyResourceSet;
		public unsafe bool IsAnyResourceSet {
			get {
				if (id_isAnyResourceSet == IntPtr.Zero)
					id_isAnyResourceSet = JNIEnv.GetMethodID (class_ref, "isAnyResourceSet", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isAnyResourceSet);
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
			global::Com.Bumptech.Glide.Request.IRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.IRequest p0 = (global::Com.Bumptech.Glide.Request.IRequest)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanNotifyStatusChanged (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_;
		public unsafe bool CanNotifyStatusChanged (global::Com.Bumptech.Glide.Request.IRequest p0)
		{
			if (id_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
				id_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID (class_ref, "canNotifyStatusChanged", "(Lcom/bumptech/glide/request/Request;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_, __args);
			return __ret;
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
			global::Com.Bumptech.Glide.Request.IRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.IRequest p0 = (global::Com.Bumptech.Glide.Request.IRequest)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanSetImage (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_canSetImage_Lcom_bumptech_glide_request_Request_;
		public unsafe bool CanSetImage (global::Com.Bumptech.Glide.Request.IRequest p0)
		{
			if (id_canSetImage_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
				id_canSetImage_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID (class_ref, "canSetImage", "(Lcom/bumptech/glide/request/Request;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_canSetImage_Lcom_bumptech_glide_request_Request_, __args);
			return __ret;
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
			global::Com.Bumptech.Glide.Request.IRequestCoordinator __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequestCoordinator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.IRequest p0 = (global::Com.Bumptech.Glide.Request.IRequest)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRequestSuccess_Lcom_bumptech_glide_request_Request_;
		public unsafe void OnRequestSuccess (global::Com.Bumptech.Glide.Request.IRequest p0)
		{
			if (id_onRequestSuccess_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
				id_onRequestSuccess_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID (class_ref, "onRequestSuccess", "(Lcom/bumptech/glide/request/Request;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onRequestSuccess_Lcom_bumptech_glide_request_Request_, __args);
		}

	}

}
