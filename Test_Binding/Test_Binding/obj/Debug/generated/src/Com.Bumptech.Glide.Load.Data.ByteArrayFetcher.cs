using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='ByteArrayFetcher']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/data/ByteArrayFetcher", DoNotGenerateAcw=true)]
	public partial class ByteArrayFetcher : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Data.IDataFetcher {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/data/ByteArrayFetcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteArrayFetcher); }
		}

		protected ByteArrayFetcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='ByteArrayFetcher']/constructor[@name='ByteArrayFetcher' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "([BLjava/lang/String;)V", "")]
		public unsafe ByteArrayFetcher (byte[] p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (ByteArrayFetcher)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([BLjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([BLjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_arrayBLjava_lang_String_ == IntPtr.Zero)
					id_ctor_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "([BLjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayBLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Bumptech.Glide.Load.Data.ByteArrayFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.ByteArrayFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='ByteArrayFetcher']/method[@name='getId' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Load.Data.ByteArrayFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.ByteArrayFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='ByteArrayFetcher']/method[@name='cancel' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Load.Data.ByteArrayFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.ByteArrayFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cleanup ();
		}
#pragma warning restore 0169

		static IntPtr id_cleanup;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='ByteArrayFetcher']/method[@name='cleanup' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Load.Data.ByteArrayFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.ByteArrayFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Priority p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Priority> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.LoadData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadData_Lcom_bumptech_glide_Priority_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='ByteArrayFetcher']/method[@name='loadData' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.Priority']]"
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
