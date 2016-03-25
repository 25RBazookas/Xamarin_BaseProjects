using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='HttpUrlFetcher']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/data/HttpUrlFetcher", DoNotGenerateAcw=true)]
	public partial class HttpUrlFetcher : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Data.IDataFetcher {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='HttpUrlFetcher.DefaultHttpUrlConnectionFactory']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/data/HttpUrlFetcher$DefaultHttpUrlConnectionFactory", DoNotGenerateAcw=true)]
		public partial class DefaultHttpUrlConnectionFactory : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Data.HttpUrlFetcher.IHttpUrlConnectionFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/data/HttpUrlFetcher$DefaultHttpUrlConnectionFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultHttpUrlConnectionFactory); }
			}

			protected DefaultHttpUrlConnectionFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_build_Ljava_net_URL_;
#pragma warning disable 0169
			static Delegate GetBuild_Ljava_net_URL_Handler ()
			{
				if (cb_build_Ljava_net_URL_ == null)
					cb_build_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Build_Ljava_net_URL_);
				return cb_build_Ljava_net_URL_;
			}

			static IntPtr n_Build_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Data.HttpUrlFetcher.DefaultHttpUrlConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.HttpUrlFetcher.DefaultHttpUrlConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_build_Ljava_net_URL_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='HttpUrlFetcher.DefaultHttpUrlConnectionFactory']/method[@name='build' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
			[Register ("build", "(Ljava/net/URL;)Ljava/net/HttpURLConnection;", "GetBuild_Ljava_net_URL_Handler")]
			public virtual unsafe global::Java.Net.HttpURLConnection Build (global::Java.Net.URL p0)
			{
				if (id_build_Ljava_net_URL_ == IntPtr.Zero)
					id_build_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "build", "(Ljava/net/URL;)Ljava/net/HttpURLConnection;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Java.Net.HttpURLConnection __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallObjectMethod  (Handle, id_build_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "(Ljava/net/URL;)Ljava/net/HttpURLConnection;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.data']/interface[@name='HttpUrlFetcher.HttpUrlConnectionFactory']"
		[Register ("com/bumptech/glide/load/data/HttpUrlFetcher$HttpUrlConnectionFactory", "", "Com.Bumptech.Glide.Load.Data.HttpUrlFetcher/IHttpUrlConnectionFactoryInvoker")]
		public partial interface IHttpUrlConnectionFactory : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/interface[@name='HttpUrlFetcher.HttpUrlConnectionFactory']/method[@name='build' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
			[Register ("build", "(Ljava/net/URL;)Ljava/net/HttpURLConnection;", "GetBuild_Ljava_net_URL_Handler:Com.Bumptech.Glide.Load.Data.HttpUrlFetcher/IHttpUrlConnectionFactoryInvoker, Test_Binding")]
			global::Java.Net.HttpURLConnection Build (global::Java.Net.URL p0);

		}

		[global::Android.Runtime.Register ("com/bumptech/glide/load/data/HttpUrlFetcher$HttpUrlConnectionFactory", DoNotGenerateAcw=true)]
		internal class IHttpUrlConnectionFactoryInvoker : global::Java.Lang.Object, IHttpUrlConnectionFactory {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/data/HttpUrlFetcher$HttpUrlConnectionFactory");
			IntPtr class_ref;

			public static IHttpUrlConnectionFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IHttpUrlConnectionFactory> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.data.HttpUrlFetcher.HttpUrlConnectionFactory"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IHttpUrlConnectionFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IHttpUrlConnectionFactoryInvoker); }
			}

			static Delegate cb_build_Ljava_net_URL_;
#pragma warning disable 0169
			static Delegate GetBuild_Ljava_net_URL_Handler ()
			{
				if (cb_build_Ljava_net_URL_ == null)
					cb_build_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Build_Ljava_net_URL_);
				return cb_build_Ljava_net_URL_;
			}

			static IntPtr n_Build_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Data.HttpUrlFetcher.IHttpUrlConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.HttpUrlFetcher.IHttpUrlConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_build_Ljava_net_URL_;
			public unsafe global::Java.Net.HttpURLConnection Build (global::Java.Net.URL p0)
			{
				if (id_build_Ljava_net_URL_ == IntPtr.Zero)
					id_build_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "build", "(Ljava/net/URL;)Ljava/net/HttpURLConnection;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Net.HttpURLConnection __ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallObjectMethod (Handle, id_build_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/data/HttpUrlFetcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpUrlFetcher); }
		}

		protected HttpUrlFetcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_model_GlideUrl_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='HttpUrlFetcher']/constructor[@name='HttpUrlFetcher' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.model.GlideUrl']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/model/GlideUrl;)V", "")]
		public unsafe HttpUrlFetcher (global::Com.Bumptech.Glide.Load.Model.GlideUrl p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (HttpUrlFetcher)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/model/GlideUrl;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/model/GlideUrl;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_model_GlideUrl_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_model_GlideUrl_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/model/GlideUrl;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_model_GlideUrl_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_model_GlideUrl_, __args);
			} finally {
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Data.HttpUrlFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.HttpUrlFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='HttpUrlFetcher']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Data.HttpUrlFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.HttpUrlFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='HttpUrlFetcher']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cancel);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
			} finally {
			}
		}

		static Delegate cb_cleanup;
#pragma warning disable 0169
		static Delegate GetCleanupHandler ()
		{
			if (cb_cleanup == null)
				cb_cleanup = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cleanup);
			return cb_cleanup;
		}

		static void n_Cleanup (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Data.HttpUrlFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.HttpUrlFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cleanup ();
		}
#pragma warning restore 0169

		static IntPtr id_cleanup;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='HttpUrlFetcher']/method[@name='cleanup' and count(parameter)=0]"
		[Register ("cleanup", "()V", "GetCleanupHandler")]
		public virtual unsafe void Cleanup ()
		{
			if (id_cleanup == IntPtr.Zero)
				id_cleanup = JNIEnv.GetMethodID (class_ref, "cleanup", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cleanup);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cleanup", "()V"));
			} finally {
			}
		}

		static Delegate cb_loadData_Lcom_bumptech_glide_Priority_;
#pragma warning disable 0169
		static Delegate GetLoadData_Lcom_bumptech_glide_Priority_Handler ()
		{
			if (cb_loadData_Lcom_bumptech_glide_Priority_ == null)
				cb_loadData_Lcom_bumptech_glide_Priority_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadData_Lcom_bumptech_glide_Priority_);
			return cb_loadData_Lcom_bumptech_glide_Priority_;
		}

		static IntPtr n_LoadData_Lcom_bumptech_glide_Priority_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Data.HttpUrlFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.HttpUrlFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Priority p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Priority> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.LoadData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadData_Lcom_bumptech_glide_Priority_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='HttpUrlFetcher']/method[@name='loadData' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.Priority']]"
		[Register ("loadData", "(Lcom/bumptech/glide/Priority;)Ljava/io/InputStream;", "GetLoadData_Lcom_bumptech_glide_Priority_Handler")]
		public virtual unsafe global::System.IO.Stream LoadData (global::Com.Bumptech.Glide.Priority p0)
		{
			if (id_loadData_Lcom_bumptech_glide_Priority_ == IntPtr.Zero)
				id_loadData_Lcom_bumptech_glide_Priority_ = JNIEnv.GetMethodID (class_ref, "loadData", "(Lcom/bumptech/glide/Priority;)Ljava/io/InputStream;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_loadData_Lcom_bumptech_glide_Priority_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadData", "(Lcom/bumptech/glide/Priority;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.Data.IDataFetcher
		global::Java.Lang.Object global::Com.Bumptech.Glide.Load.Data.IDataFetcher.LoadData (global::Com.Bumptech.Glide.Priority p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(LoadData (p0));
		}

	}
}
