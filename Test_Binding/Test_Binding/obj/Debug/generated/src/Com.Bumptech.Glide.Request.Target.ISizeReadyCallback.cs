using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Target {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.request.target']/interface[@name='SizeReadyCallback']"
	[Register ("com/bumptech/glide/request/target/SizeReadyCallback", "", "Com.Bumptech.Glide.Request.Target.ISizeReadyCallbackInvoker")]
	public partial interface ISizeReadyCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/interface[@name='SizeReadyCallback']/method[@name='onSizeReady' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onSizeReady", "(II)V", "GetOnSizeReady_IIHandler:Com.Bumptech.Glide.Request.Target.ISizeReadyCallbackInvoker, Test_Binding")]
		void OnSizeReady (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/request/target/SizeReadyCallback", DoNotGenerateAcw=true)]
	internal class ISizeReadyCallbackInvoker : global::Java.Lang.Object, ISizeReadyCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/request/target/SizeReadyCallback");
		IntPtr class_ref;

		public static ISizeReadyCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISizeReadyCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.request.target.SizeReadyCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISizeReadyCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISizeReadyCallbackInvoker); }
		}

		static Delegate cb_onSizeReady_II;
#pragma warning disable 0169
		static Delegate GetOnSizeReady_IIHandler ()
		{
			if (cb_onSizeReady_II == null)
				cb_onSizeReady_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnSizeReady_II);
			return cb_onSizeReady_II;
		}

		static void n_OnSizeReady_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSizeReady (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSizeReady_II;
		public unsafe void OnSizeReady (int p0, int p1)
		{
			if (id_onSizeReady_II == IntPtr.Zero)
				id_onSizeReady_II = JNIEnv.GetMethodID (class_ref, "onSizeReady", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onSizeReady_II, __args);
		}

	}

}
