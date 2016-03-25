using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Manager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='ConnectivityMonitorFactory']"
	[global::Android.Runtime.Register ("com/bumptech/glide/manager/ConnectivityMonitorFactory", DoNotGenerateAcw=true)]
	public partial class ConnectivityMonitorFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/manager/ConnectivityMonitorFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectivityMonitorFactory); }
		}

		protected ConnectivityMonitorFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='ConnectivityMonitorFactory']/constructor[@name='ConnectivityMonitorFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectivityMonitorFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ConnectivityMonitorFactory)) {
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

		static Delegate cb_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_;
#pragma warning disable 0169
		static Delegate GetBuild_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_Handler ()
		{
			if (cb_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_ == null)
				cb_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_);
			return cb_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_;
		}

		static IntPtr n_Build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Manager.ConnectivityMonitorFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.ConnectivityMonitorFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Manager.IConnectivityMonitorConnectivityListener p1 = (global::Com.Bumptech.Glide.Manager.IConnectivityMonitorConnectivityListener)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.IConnectivityMonitorConnectivityListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='ConnectivityMonitorFactory']/method[@name='build' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.bumptech.glide.manager.ConnectivityMonitor.ConnectivityListener']]"
		[Register ("build", "(Landroid/content/Context;Lcom/bumptech/glide/manager/ConnectivityMonitor$ConnectivityListener;)Lcom/bumptech/glide/manager/ConnectivityMonitor;", "GetBuild_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.Manager.IConnectivityMonitor Build (global::Android.Content.Context p0, global::Com.Bumptech.Glide.Manager.IConnectivityMonitorConnectivityListener p1)
		{
			if (id_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_ == IntPtr.Zero)
				id_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_ = JNIEnv.GetMethodID (class_ref, "build", "(Landroid/content/Context;Lcom/bumptech/glide/manager/ConnectivityMonitor$ConnectivityListener;)Lcom/bumptech/glide/manager/ConnectivityMonitor;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Bumptech.Glide.Manager.IConnectivityMonitor __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.IConnectivityMonitor> (JNIEnv.CallObjectMethod  (Handle, id_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.IConnectivityMonitor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "(Landroid/content/Context;Lcom/bumptech/glide/manager/ConnectivityMonitor$ConnectivityListener;)Lcom/bumptech/glide/manager/ConnectivityMonitor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
