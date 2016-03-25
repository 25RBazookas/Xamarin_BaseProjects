using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Data {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.data']/interface[@name='DataFetcher']"
	[Register ("com/bumptech/glide/load/data/DataFetcher", "", "Com.Bumptech.Glide.Load.Data.IDataFetcherInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IDataFetcher : IJavaObject {

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/interface[@name='DataFetcher']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Bumptech.Glide.Load.Data.IDataFetcherInvoker, Test_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/interface[@name='DataFetcher']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:Com.Bumptech.Glide.Load.Data.IDataFetcherInvoker, Test_Binding")]
		void Cancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/interface[@name='DataFetcher']/method[@name='cleanup' and count(parameter)=0]"
		[Register ("cleanup", "()V", "GetCleanupHandler:Com.Bumptech.Glide.Load.Data.IDataFetcherInvoker, Test_Binding")]
		void Cleanup ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/interface[@name='DataFetcher']/method[@name='loadData' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.Priority']]"
		[Register ("loadData", "(Lcom/bumptech/glide/Priority;)Ljava/lang/Object;", "GetLoadData_Lcom_bumptech_glide_Priority_Handler:Com.Bumptech.Glide.Load.Data.IDataFetcherInvoker, Test_Binding")]
		global::Java.Lang.Object LoadData (global::Com.Bumptech.Glide.Priority p0);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/data/DataFetcher", DoNotGenerateAcw=true)]
	internal class IDataFetcherInvoker : global::Java.Lang.Object, IDataFetcher {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/data/DataFetcher");
		IntPtr class_ref;

		public static IDataFetcher GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataFetcher> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.data.DataFetcher"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataFetcherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDataFetcherInvoker); }
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
			global::Com.Bumptech.Glide.Load.Data.IDataFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public unsafe string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bumptech.Glide.Load.Data.IDataFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (Handle, id_cancel);
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
			global::Com.Bumptech.Glide.Load.Data.IDataFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cleanup ();
		}
#pragma warning restore 0169

		IntPtr id_cleanup;
		public unsafe void Cleanup ()
		{
			if (id_cleanup == IntPtr.Zero)
				id_cleanup = JNIEnv.GetMethodID (class_ref, "cleanup", "()V");
			JNIEnv.CallVoidMethod (Handle, id_cleanup);
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
			global::Com.Bumptech.Glide.Load.Data.IDataFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Priority p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Priority> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadData (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadData_Lcom_bumptech_glide_Priority_;
		public unsafe global::Java.Lang.Object LoadData (global::Com.Bumptech.Glide.Priority p0)
		{
			if (id_loadData_Lcom_bumptech_glide_Priority_ == IntPtr.Zero)
				id_loadData_Lcom_bumptech_glide_Priority_ = JNIEnv.GetMethodID (class_ref, "loadData", "(Lcom/bumptech/glide/Priority;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_loadData_Lcom_bumptech_glide_Priority_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
