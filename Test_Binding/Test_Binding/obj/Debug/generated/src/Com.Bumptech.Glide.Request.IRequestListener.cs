using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='RequestListener']"
	[Register ("com/bumptech/glide/request/RequestListener", "", "Com.Bumptech.Glide.Request.IRequestListenerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public partial interface IRequestListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='RequestListener']/method[@name='onException' and count(parameter)=4 and parameter[1][@type='java.lang.Exception'] and parameter[2][@type='T'] and parameter[3][@type='com.bumptech.glide.request.target.Target&lt;R&gt;'] and parameter[4][@type='boolean']]"
		[Register ("onException", "(Ljava/lang/Exception;Ljava/lang/Object;Lcom/bumptech/glide/request/target/Target;Z)Z", "GetOnException_Ljava_lang_Exception_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZHandler:Com.Bumptech.Glide.Request.IRequestListenerInvoker, Test_Binding")]
		bool OnException (global::Java.Lang.Exception p0, global::Java.Lang.Object p1, global::Com.Bumptech.Glide.Request.Target.ITarget p2, bool p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/interface[@name='RequestListener']/method[@name='onResourceReady' and count(parameter)=5 and parameter[1][@type='R'] and parameter[2][@type='T'] and parameter[3][@type='com.bumptech.glide.request.target.Target&lt;R&gt;'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("onResourceReady", "(Ljava/lang/Object;Ljava/lang/Object;Lcom/bumptech/glide/request/target/Target;ZZ)Z", "GetOnResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZZHandler:Com.Bumptech.Glide.Request.IRequestListenerInvoker, Test_Binding")]
		bool OnResourceReady (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Com.Bumptech.Glide.Request.Target.ITarget p2, bool p3, bool p4);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/request/RequestListener", DoNotGenerateAcw=true)]
	internal class IRequestListenerInvoker : global::Java.Lang.Object, IRequestListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/request/RequestListener");
		IntPtr class_ref;

		public static IRequestListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRequestListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.request.RequestListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRequestListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRequestListenerInvoker); }
		}

		static Delegate cb_onException_Ljava_lang_Exception_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z;
#pragma warning disable 0169
		static Delegate GetOnException_Ljava_lang_Exception_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZHandler ()
		{
			if (cb_onException_Ljava_lang_Exception_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z == null)
				cb_onException_Ljava_lang_Exception_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_OnException_Ljava_lang_Exception_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z);
			return cb_onException_Ljava_lang_Exception_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z;
		}

		static bool n_OnException_Ljava_lang_Exception_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Bumptech.Glide.Request.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Target.ITarget p2 = (global::Com.Bumptech.Glide.Request.Target.ITarget)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnException (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onException_Ljava_lang_Exception_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z;
		public unsafe bool OnException (global::Java.Lang.Exception p0, global::Java.Lang.Object p1, global::Com.Bumptech.Glide.Request.Target.ITarget p2, bool p3)
		{
			if (id_onException_Ljava_lang_Exception_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z == IntPtr.Zero)
				id_onException_Ljava_lang_Exception_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z = JNIEnv.GetMethodID (class_ref, "onException", "(Ljava/lang/Exception;Ljava/lang/Object;Lcom/bumptech/glide/request/target/Target;Z)Z");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onException_Ljava_lang_Exception_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZZ;
#pragma warning disable 0169
		static Delegate GetOnResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZZHandler ()
		{
			if (cb_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZZ == null)
				cb_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, bool, bool>) n_OnResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZZ);
			return cb_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZZ;
		}

		static bool n_OnResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3, bool p4)
		{
			global::Com.Bumptech.Glide.Request.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Target.ITarget p2 = (global::Com.Bumptech.Glide.Request.Target.ITarget)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnResourceReady (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZZ;
		public unsafe bool OnResourceReady (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Com.Bumptech.Glide.Request.Target.ITarget p2, bool p3, bool p4)
		{
			if (id_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZZ == IntPtr.Zero)
				id_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZZ = JNIEnv.GetMethodID (class_ref, "onResourceReady", "(Ljava/lang/Object;Ljava/lang/Object;Lcom/bumptech/glide/request/target/Target;ZZ)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZZ, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

	public partial class ExceptionEventArgs : global::System.EventArgs {

		public ExceptionEventArgs (bool handled, global::Java.Lang.Exception p0, global::Java.Lang.Object p1, global::Com.Bumptech.Glide.Request.Target.ITarget p2, bool p3)
		{
			this.handled = handled;
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		global::Java.Lang.Exception p0;
		public global::Java.Lang.Exception P0 {
			get { return p0; }
		}

		global::Java.Lang.Object p1;
		public global::Java.Lang.Object P1 {
			get { return p1; }
		}

		global::Com.Bumptech.Glide.Request.Target.ITarget p2;
		public global::Com.Bumptech.Glide.Request.Target.ITarget P2 {
			get { return p2; }
		}

		bool p3;
		public bool P3 {
			get { return p3; }
		}
	}

	public partial class ResourceReadyEventArgs : global::System.EventArgs {

		public ResourceReadyEventArgs (bool handled, global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Com.Bumptech.Glide.Request.Target.ITarget p2, bool p3, bool p4)
		{
			this.handled = handled;
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		global::Java.Lang.Object p0;
		public global::Java.Lang.Object P0 {
			get { return p0; }
		}

		global::Java.Lang.Object p1;
		public global::Java.Lang.Object P1 {
			get { return p1; }
		}

		global::Com.Bumptech.Glide.Request.Target.ITarget p2;
		public global::Com.Bumptech.Glide.Request.Target.ITarget P2 {
			get { return p2; }
		}

		bool p3;
		public bool P3 {
			get { return p3; }
		}

		bool p4;
		public bool P4 {
			get { return p4; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/bumptech/glide/request/RequestListenerImplementor")]
	internal sealed partial class IRequestListenerImplementor : global::Java.Lang.Object, IRequestListener {

		object sender;

		public IRequestListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/bumptech/glide/request/RequestListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ExceptionEventArgs> OnExceptionHandler;
#pragma warning restore 0649

		public bool OnException (global::Java.Lang.Exception p0, global::Java.Lang.Object p1, global::Com.Bumptech.Glide.Request.Target.ITarget p2, bool p3)
		{
			var __h = OnExceptionHandler;
			if (__h == null)
				return false;
			var __e = new ExceptionEventArgs (true, p0, p1, p2, p3);
			__h (sender, __e);
			return __e.Handled;
		}
#pragma warning disable 0649
		public EventHandler<ResourceReadyEventArgs> OnResourceReadyHandler;
#pragma warning restore 0649

		public bool OnResourceReady (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Com.Bumptech.Glide.Request.Target.ITarget p2, bool p3, bool p4)
		{
			var __h = OnResourceReadyHandler;
			if (__h == null)
				return false;
			var __e = new ResourceReadyEventArgs (true, p0, p1, p2, p3, p4);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (IRequestListenerImplementor value)
		{
			return value.OnExceptionHandler == null && value.OnResourceReadyHandler == null;
		}
	}

}
