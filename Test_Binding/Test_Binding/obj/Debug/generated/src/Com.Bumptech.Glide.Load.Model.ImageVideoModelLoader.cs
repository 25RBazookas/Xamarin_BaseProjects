using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoModelLoader']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/ImageVideoModelLoader", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"A"})]
	public partial class ImageVideoModelLoader : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Model.IModelLoader {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoModelLoader.ImageVideoFetcher']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/model/ImageVideoModelLoader$ImageVideoFetcher", DoNotGenerateAcw=true)]
		public partial class ImageVideoFetcher : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Data.IDataFetcher {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/model/ImageVideoModelLoader$ImageVideoFetcher", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ImageVideoFetcher); }
			}

			protected ImageVideoFetcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_load_data_DataFetcher_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoModelLoader.ImageVideoFetcher']/constructor[@name='ImageVideoModelLoader.ImageVideoFetcher' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.data.DataFetcher&lt;java.io.InputStream&gt;'] and parameter[2][@type='com.bumptech.glide.load.data.DataFetcher&lt;android.os.ParcelFileDescriptor&gt;']]"
			[Register (".ctor", "(Lcom/bumptech/glide/load/data/DataFetcher;Lcom/bumptech/glide/load/data/DataFetcher;)V", "")]
			public unsafe ImageVideoFetcher (global::Com.Bumptech.Glide.Load.Data.IDataFetcher p0, global::Com.Bumptech.Glide.Load.Data.IDataFetcher p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (ImageVideoFetcher)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/data/DataFetcher;Lcom/bumptech/glide/load/data/DataFetcher;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/data/DataFetcher;Lcom/bumptech/glide/load/data/DataFetcher;)V", __args);
						return;
					}

					if (id_ctor_Lcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_load_data_DataFetcher_ == IntPtr.Zero)
						id_ctor_Lcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_load_data_DataFetcher_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/data/DataFetcher;Lcom/bumptech/glide/load/data/DataFetcher;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_load_data_DataFetcher_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_data_DataFetcher_Lcom_bumptech_glide_load_data_DataFetcher_, __args);
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
				global::Com.Bumptech.Glide.Load.Model.ImageVideoModelLoader.ImageVideoFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ImageVideoModelLoader.ImageVideoFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Id);
			}
#pragma warning restore 0169

			static IntPtr id_getId;
			public virtual unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoModelLoader.ImageVideoFetcher']/method[@name='getId' and count(parameter)=0]"
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
				global::Com.Bumptech.Glide.Load.Model.ImageVideoModelLoader.ImageVideoFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ImageVideoModelLoader.ImageVideoFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Cancel ();
			}
#pragma warning restore 0169

			static IntPtr id_cancel;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoModelLoader.ImageVideoFetcher']/method[@name='cancel' and count(parameter)=0]"
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
				global::Com.Bumptech.Glide.Load.Model.ImageVideoModelLoader.ImageVideoFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ImageVideoModelLoader.ImageVideoFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Cleanup ();
			}
#pragma warning restore 0169

			static IntPtr id_cleanup;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoModelLoader.ImageVideoFetcher']/method[@name='cleanup' and count(parameter)=0]"
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
				global::Com.Bumptech.Glide.Load.Model.ImageVideoModelLoader.ImageVideoFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ImageVideoModelLoader.ImageVideoFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Bumptech.Glide.Priority p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Priority> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadData (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_loadData_Lcom_bumptech_glide_Priority_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoModelLoader.ImageVideoFetcher']/method[@name='loadData' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.Priority']]"
			[Register ("loadData", "(Lcom/bumptech/glide/Priority;)Lcom/bumptech/glide/load/model/ImageVideoWrapper;", "GetLoadData_Lcom_bumptech_glide_Priority_Handler")]
			public virtual unsafe global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper LoadData (global::Com.Bumptech.Glide.Priority p0)
			{
				if (id_loadData_Lcom_bumptech_glide_Priority_ == IntPtr.Zero)
					id_loadData_Lcom_bumptech_glide_Priority_ = JNIEnv.GetMethodID (class_ref, "loadData", "(Lcom/bumptech/glide/Priority;)Lcom/bumptech/glide/load/model/ImageVideoWrapper;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper> (JNIEnv.CallObjectMethod  (Handle, id_loadData_Lcom_bumptech_glide_Priority_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadData", "(Lcom/bumptech/glide/Priority;)Lcom/bumptech/glide/load/model/ImageVideoWrapper;"), __args), JniHandleOwnership.TransferLocalRef);
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/model/ImageVideoModelLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageVideoModelLoader); }
		}

		protected ImageVideoModelLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_Lcom_bumptech_glide_load_model_ModelLoader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoModelLoader']/constructor[@name='ImageVideoModelLoader' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.model.ModelLoader&lt;A, java.io.InputStream&gt;'] and parameter[2][@type='com.bumptech.glide.load.model.ModelLoader&lt;A, android.os.ParcelFileDescriptor&gt;']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/model/ModelLoader;Lcom/bumptech/glide/load/model/ModelLoader;)V", "")]
		public unsafe ImageVideoModelLoader (global::Com.Bumptech.Glide.Load.Model.IModelLoader p0, global::Com.Bumptech.Glide.Load.Model.IModelLoader p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ImageVideoModelLoader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/model/ModelLoader;Lcom/bumptech/glide/load/model/ModelLoader;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/model/ModelLoader;Lcom/bumptech/glide/load/model/ModelLoader;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_Lcom_bumptech_glide_load_model_ModelLoader_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_Lcom_bumptech_glide_load_model_ModelLoader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/model/ModelLoader;Lcom/bumptech/glide/load/model/ModelLoader;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_Lcom_bumptech_glide_load_model_ModelLoader_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_model_ModelLoader_Lcom_bumptech_glide_load_model_ModelLoader_, __args);
			} finally {
			}
		}

		static Delegate cb_getResourceFetcher_Ljava_lang_Object_II;
#pragma warning disable 0169
		static Delegate GetGetResourceFetcher_Ljava_lang_Object_IIHandler ()
		{
			if (cb_getResourceFetcher_Ljava_lang_Object_II == null)
				cb_getResourceFetcher_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetResourceFetcher_Ljava_lang_Object_II);
			return cb_getResourceFetcher_Ljava_lang_Object_II;
		}

		static IntPtr n_GetResourceFetcher_Ljava_lang_Object_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Model.ImageVideoModelLoader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ImageVideoModelLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResourceFetcher (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getResourceFetcher_Ljava_lang_Object_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoModelLoader']/method[@name='getResourceFetcher' and count(parameter)=3 and parameter[1][@type='A'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getResourceFetcher", "(Ljava/lang/Object;II)Lcom/bumptech/glide/load/data/DataFetcher;", "GetGetResourceFetcher_Ljava_lang_Object_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Data.IDataFetcher GetResourceFetcher (global::Java.Lang.Object p0, int p1, int p2)
		{
			if (id_getResourceFetcher_Ljava_lang_Object_II == IntPtr.Zero)
				id_getResourceFetcher_Ljava_lang_Object_II = JNIEnv.GetMethodID (class_ref, "getResourceFetcher", "(Ljava/lang/Object;II)Lcom/bumptech/glide/load/data/DataFetcher;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Bumptech.Glide.Load.Data.IDataFetcher __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (JNIEnv.CallObjectMethod  (Handle, id_getResourceFetcher_Ljava_lang_Object_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResourceFetcher", "(Ljava/lang/Object;II)Lcom/bumptech/glide/load/data/DataFetcher;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
