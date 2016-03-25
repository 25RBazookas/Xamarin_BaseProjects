using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='Request']"
	[Register ("com/bumptech/glide/request/Request", "", "Com.Bumptech.Glide.Request.IRequestInvoker")]
	public partial interface IRequest : IJavaObject {

		bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='Request']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "GetIsCancelledHandler:Com.Bumptech.Glide.Request.IRequestInvoker, Test_Binding")] get;
		}

		bool IsComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='Request']/method[@name='isComplete' and count(parameter)=0]"
			[Register ("isComplete", "()Z", "GetIsCompleteHandler:Com.Bumptech.Glide.Request.IRequestInvoker, Test_Binding")] get;
		}

		bool IsFailed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='Request']/method[@name='isFailed' and count(parameter)=0]"
			[Register ("isFailed", "()Z", "GetIsFailedHandler:Com.Bumptech.Glide.Request.IRequestInvoker, Test_Binding")] get;
		}

		bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='Request']/method[@name='isPaused' and count(parameter)=0]"
			[Register ("isPaused", "()Z", "GetIsPausedHandler:Com.Bumptech.Glide.Request.IRequestInvoker, Test_Binding")] get;
		}

		bool IsResourceSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='Request']/method[@name='isResourceSet' and count(parameter)=0]"
			[Register ("isResourceSet", "()Z", "GetIsResourceSetHandler:Com.Bumptech.Glide.Request.IRequestInvoker, Test_Binding")] get;
		}

		bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='Request']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler:Com.Bumptech.Glide.Request.IRequestInvoker, Test_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='Request']/method[@name='begin' and count(parameter)=0]"
		[Register ("begin", "()V", "GetBeginHandler:Com.Bumptech.Glide.Request.IRequestInvoker, Test_Binding")]
		void Begin ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='Request']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.Bumptech.Glide.Request.IRequestInvoker, Test_Binding")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='Request']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler:Com.Bumptech.Glide.Request.IRequestInvoker, Test_Binding")]
		void Pause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='Request']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler:Com.Bumptech.Glide.Request.IRequestInvoker, Test_Binding")]
		void Recycle ();

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/request/Request", DoNotGenerateAcw=true)]
	internal class IRequestInvoker : global::Java.Lang.Object, IRequest {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/request/Request");
		IntPtr class_ref;

		public static IRequest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRequest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.request.Request"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRequestInvoker); }
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
			global::Com.Bumptech.Glide.Request.IRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancelled;
		}
#pragma warning restore 0169

		IntPtr id_isCancelled;
		public unsafe bool IsCancelled {
			get {
				if (id_isCancelled == IntPtr.Zero)
					id_isCancelled = JNIEnv.GetMethodID (class_ref, "isCancelled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isCancelled);
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
			global::Com.Bumptech.Glide.Request.IRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsComplete;
		}
#pragma warning restore 0169

		IntPtr id_isComplete;
		public unsafe bool IsComplete {
			get {
				if (id_isComplete == IntPtr.Zero)
					id_isComplete = JNIEnv.GetMethodID (class_ref, "isComplete", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isComplete);
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
			global::Com.Bumptech.Glide.Request.IRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFailed;
		}
#pragma warning restore 0169

		IntPtr id_isFailed;
		public unsafe bool IsFailed {
			get {
				if (id_isFailed == IntPtr.Zero)
					id_isFailed = JNIEnv.GetMethodID (class_ref, "isFailed", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isFailed);
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
			global::Com.Bumptech.Glide.Request.IRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		IntPtr id_isPaused;
		public unsafe bool IsPaused {
			get {
				if (id_isPaused == IntPtr.Zero)
					id_isPaused = JNIEnv.GetMethodID (class_ref, "isPaused", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isPaused);
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
			global::Com.Bumptech.Glide.Request.IRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsResourceSet;
		}
#pragma warning restore 0169

		IntPtr id_isResourceSet;
		public unsafe bool IsResourceSet {
			get {
				if (id_isResourceSet == IntPtr.Zero)
					id_isResourceSet = JNIEnv.GetMethodID (class_ref, "isResourceSet", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isResourceSet);
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
			global::Com.Bumptech.Glide.Request.IRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		IntPtr id_isRunning;
		public unsafe bool IsRunning {
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isRunning);
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
			global::Com.Bumptech.Glide.Request.IRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Begin ();
		}
#pragma warning restore 0169

		IntPtr id_begin;
		public unsafe void Begin ()
		{
			if (id_begin == IntPtr.Zero)
				id_begin = JNIEnv.GetMethodID (class_ref, "begin", "()V");
			JNIEnv.CallVoidMethod (Handle, id_begin);
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
			global::Com.Bumptech.Glide.Request.IRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Request.IRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		IntPtr id_pause;
		public unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			JNIEnv.CallVoidMethod (Handle, id_pause);
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
			global::Com.Bumptech.Glide.Request.IRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		IntPtr id_recycle;
		public unsafe void Recycle ()
		{
			if (id_recycle == IntPtr.Zero)
				id_recycle = JNIEnv.GetMethodID (class_ref, "recycle", "()V");
			JNIEnv.CallVoidMethod (Handle, id_recycle);
		}

	}

}
