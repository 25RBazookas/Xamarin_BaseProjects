using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Manager {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.manager']/interface[@name='LifecycleListener']"
	[Register ("com/bumptech/glide/manager/LifecycleListener", "", "Com.Bumptech.Glide.Manager.ILifecycleListenerInvoker")]
	public partial interface ILifecycleListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/interface[@name='LifecycleListener']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler:Com.Bumptech.Glide.Manager.ILifecycleListenerInvoker, Test_Binding")]
		void OnDestroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/interface[@name='LifecycleListener']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler:Com.Bumptech.Glide.Manager.ILifecycleListenerInvoker, Test_Binding")]
		void OnStart ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/interface[@name='LifecycleListener']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler:Com.Bumptech.Glide.Manager.ILifecycleListenerInvoker, Test_Binding")]
		void OnStop ();

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/manager/LifecycleListener", DoNotGenerateAcw=true)]
	internal class ILifecycleListenerInvoker : global::Java.Lang.Object, ILifecycleListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/manager/LifecycleListener");
		IntPtr class_ref;

		public static ILifecycleListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILifecycleListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.manager.LifecycleListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILifecycleListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILifecycleListenerInvoker); }
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
			global::Com.Bumptech.Glide.Manager.ILifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.ILifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Manager.ILifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.ILifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Manager.ILifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.ILifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	[global::Android.Runtime.Register ("mono/com/bumptech/glide/manager/LifecycleListenerImplementor")]
	internal sealed partial class ILifecycleListenerImplementor : global::Java.Lang.Object, ILifecycleListener {

		object sender;

		public ILifecycleListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/bumptech/glide/manager/LifecycleListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnDestroyHandler;
#pragma warning restore 0649

		public void OnDestroy ()
		{
			var __h = OnDestroyHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnStartHandler;
#pragma warning restore 0649

		public void OnStart ()
		{
			var __h = OnStartHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnStopHandler;
#pragma warning restore 0649

		public void OnStop ()
		{
			var __h = OnStopHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ILifecycleListenerImplementor value)
		{
			return value.OnDestroyHandler == null && value.OnStartHandler == null && value.OnStopHandler == null;
		}
	}

}
