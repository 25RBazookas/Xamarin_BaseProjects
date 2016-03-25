using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Manager {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.manager']/interface[@name='ConnectivityMonitor.ConnectivityListener']"
	[Register ("com/bumptech/glide/manager/ConnectivityMonitor$ConnectivityListener", "", "Com.Bumptech.Glide.Manager.IConnectivityMonitorConnectivityListenerInvoker")]
	public partial interface IConnectivityMonitorConnectivityListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/interface[@name='ConnectivityMonitor.ConnectivityListener']/method[@name='onConnectivityChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onConnectivityChanged", "(Z)V", "GetOnConnectivityChanged_ZHandler:Com.Bumptech.Glide.Manager.IConnectivityMonitorConnectivityListenerInvoker, Test_Binding")]
		void OnConnectivityChanged (bool p0);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/manager/ConnectivityMonitor$ConnectivityListener", DoNotGenerateAcw=true)]
	internal class IConnectivityMonitorConnectivityListenerInvoker : global::Java.Lang.Object, IConnectivityMonitorConnectivityListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/manager/ConnectivityMonitor$ConnectivityListener");
		IntPtr class_ref;

		public static IConnectivityMonitorConnectivityListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectivityMonitorConnectivityListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.manager.ConnectivityMonitor.ConnectivityListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectivityMonitorConnectivityListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConnectivityMonitorConnectivityListenerInvoker); }
		}

		static Delegate cb_onConnectivityChanged_Z;
#pragma warning disable 0169
		static Delegate GetOnConnectivityChanged_ZHandler ()
		{
			if (cb_onConnectivityChanged_Z == null)
				cb_onConnectivityChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnConnectivityChanged_Z);
			return cb_onConnectivityChanged_Z;
		}

		static void n_OnConnectivityChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Bumptech.Glide.Manager.IConnectivityMonitorConnectivityListener __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.IConnectivityMonitorConnectivityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectivityChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnectivityChanged_Z;
		public unsafe void OnConnectivityChanged (bool p0)
		{
			if (id_onConnectivityChanged_Z == IntPtr.Zero)
				id_onConnectivityChanged_Z = JNIEnv.GetMethodID (class_ref, "onConnectivityChanged", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onConnectivityChanged_Z, __args);
		}

	}

	public partial class ConnectivityMonitorConnectivityEventArgs : global::System.EventArgs {

		public ConnectivityMonitorConnectivityEventArgs (bool p0)
		{
			this.p0 = p0;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/bumptech/glide/manager/ConnectivityMonitor_ConnectivityListenerImplementor")]
	internal sealed partial class IConnectivityMonitorConnectivityListenerImplementor : global::Java.Lang.Object, IConnectivityMonitorConnectivityListener {

		object sender;

		public IConnectivityMonitorConnectivityListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/bumptech/glide/manager/ConnectivityMonitor_ConnectivityListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ConnectivityMonitorConnectivityEventArgs> Handler;
#pragma warning restore 0649

		public void OnConnectivityChanged (bool p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ConnectivityMonitorConnectivityEventArgs (p0));
		}

		internal static bool __IsEmpty (IConnectivityMonitorConnectivityListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.manager']/interface[@name='ConnectivityMonitor']"
	[Register ("com/bumptech/glide/manager/ConnectivityMonitor", "", "Com.Bumptech.Glide.Manager.IConnectivityMonitorInvoker")]
	public partial interface IConnectivityMonitor : global::Com.Bumptech.Glide.Manager.ILifecycleListener {

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/manager/ConnectivityMonitor", DoNotGenerateAcw=true)]
	internal class IConnectivityMonitorInvoker : global::Java.Lang.Object, IConnectivityMonitor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/manager/ConnectivityMonitor");
		IntPtr class_ref;

		public static IConnectivityMonitor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectivityMonitor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.manager.ConnectivityMonitor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectivityMonitorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConnectivityMonitorInvoker); }
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
			global::Com.Bumptech.Glide.Manager.IConnectivityMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.IConnectivityMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Manager.IConnectivityMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.IConnectivityMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bumptech.Glide.Manager.IConnectivityMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.IConnectivityMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

}
