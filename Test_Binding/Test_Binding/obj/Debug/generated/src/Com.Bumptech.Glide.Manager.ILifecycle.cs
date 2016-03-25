using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Manager {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.manager']/interface[@name='Lifecycle']"
	[Register ("com/bumptech/glide/manager/Lifecycle", "", "Com.Bumptech.Glide.Manager.ILifecycleInvoker")]
	public partial interface ILifecycle : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/interface[@name='Lifecycle']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.manager.LifecycleListener']]"
		[Register ("addListener", "(Lcom/bumptech/glide/manager/LifecycleListener;)V", "GetAddListener_Lcom_bumptech_glide_manager_LifecycleListener_Handler:Com.Bumptech.Glide.Manager.ILifecycleInvoker, Test_Binding")]
		void AddListener (global::Com.Bumptech.Glide.Manager.ILifecycleListener p0);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/manager/Lifecycle", DoNotGenerateAcw=true)]
	internal class ILifecycleInvoker : global::Java.Lang.Object, ILifecycle {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/manager/Lifecycle");
		IntPtr class_ref;

		public static ILifecycle GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILifecycle> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.manager.Lifecycle"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILifecycleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILifecycleInvoker); }
		}

		static Delegate cb_addListener_Lcom_bumptech_glide_manager_LifecycleListener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lcom_bumptech_glide_manager_LifecycleListener_Handler ()
		{
			if (cb_addListener_Lcom_bumptech_glide_manager_LifecycleListener_ == null)
				cb_addListener_Lcom_bumptech_glide_manager_LifecycleListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddListener_Lcom_bumptech_glide_manager_LifecycleListener_);
			return cb_addListener_Lcom_bumptech_glide_manager_LifecycleListener_;
		}

		static void n_AddListener_Lcom_bumptech_glide_manager_LifecycleListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Manager.ILifecycle __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.ILifecycle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Manager.ILifecycleListener p0 = (global::Com.Bumptech.Glide.Manager.ILifecycleListener)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.ILifecycleListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addListener_Lcom_bumptech_glide_manager_LifecycleListener_;
		public unsafe void AddListener (global::Com.Bumptech.Glide.Manager.ILifecycleListener p0)
		{
			if (id_addListener_Lcom_bumptech_glide_manager_LifecycleListener_ == IntPtr.Zero)
				id_addListener_Lcom_bumptech_glide_manager_LifecycleListener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Lcom/bumptech/glide/manager/LifecycleListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_addListener_Lcom_bumptech_glide_manager_LifecycleListener_, __args);
		}

	}

}
