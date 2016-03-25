using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']"
	[global::Android.Runtime.Register ("com/bumptech/glide/RequestManager", DoNotGenerateAcw=true)]
	public partial class RequestManager : global::Java.Lang.Object, global::Com.Bumptech.Glide.Manager.ILifecycleListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide']/interface[@name='RequestManager.DefaultOptions']"
		[Register ("com/bumptech/glide/RequestManager$DefaultOptions", "", "Com.Bumptech.Glide.RequestManager/IDefaultOptionsInvoker")]
		public partial interface IDefaultOptions : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/interface[@name='RequestManager.DefaultOptions']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.GenericRequestBuilder&lt;T, ?, ?, ?&gt;']]"
			[Register ("apply", "(Lcom/bumptech/glide/GenericRequestBuilder;)V", "GetApply_Lcom_bumptech_glide_GenericRequestBuilder_Handler:Com.Bumptech.Glide.RequestManager/IDefaultOptionsInvoker, Test_Binding")]
			[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
			void Apply (global::Com.Bumptech.Glide.GenericRequestBuilder p0);

		}

		[global::Android.Runtime.Register ("com/bumptech/glide/RequestManager$DefaultOptions", DoNotGenerateAcw=true)]
		internal class IDefaultOptionsInvoker : global::Java.Lang.Object, IDefaultOptions {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/RequestManager$DefaultOptions");
			IntPtr class_ref;

			public static IDefaultOptions GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDefaultOptions> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.RequestManager.DefaultOptions"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDefaultOptionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDefaultOptionsInvoker); }
			}

			static Delegate cb_apply_Lcom_bumptech_glide_GenericRequestBuilder_;
#pragma warning disable 0169
			static Delegate GetApply_Lcom_bumptech_glide_GenericRequestBuilder_Handler ()
			{
				if (cb_apply_Lcom_bumptech_glide_GenericRequestBuilder_ == null)
					cb_apply_Lcom_bumptech_glide_GenericRequestBuilder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Apply_Lcom_bumptech_glide_GenericRequestBuilder_);
				return cb_apply_Lcom_bumptech_glide_GenericRequestBuilder_;
			}

			static void n_Apply_Lcom_bumptech_glide_GenericRequestBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.RequestManager.IDefaultOptions __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager.IDefaultOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Bumptech.Glide.GenericRequestBuilder p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Apply (p0);
			}
#pragma warning restore 0169

			IntPtr id_apply_Lcom_bumptech_glide_GenericRequestBuilder_;
			public unsafe void Apply (global::Com.Bumptech.Glide.GenericRequestBuilder p0)
			{
				if (id_apply_Lcom_bumptech_glide_GenericRequestBuilder_ == IntPtr.Zero)
					id_apply_Lcom_bumptech_glide_GenericRequestBuilder_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lcom/bumptech/glide/GenericRequestBuilder;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_apply_Lcom_bumptech_glide_GenericRequestBuilder_, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager.GenericModelRequest']"
		[global::Android.Runtime.Register ("com/bumptech/glide/RequestManager$GenericModelRequest", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"A", "T"})]
		public sealed partial class GenericModelRequest : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager.GenericModelRequest.GenericTypeRequest']"
			[global::Android.Runtime.Register ("com/bumptech/glide/RequestManager$GenericModelRequest$GenericTypeRequest", DoNotGenerateAcw=true)]
			public sealed partial class GenericTypeRequest : global::Java.Lang.Object {

				internal GenericTypeRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/RequestManager$GenericModelRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GenericModelRequest); }
			}

			internal GenericModelRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_from_Ljava_lang_Class_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager.GenericModelRequest']/method[@name='from' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;A&gt;']]"
			[Register ("from", "(Ljava/lang/Class;)Lcom/bumptech/glide/RequestManager$GenericModelRequest$GenericTypeRequest;", "")]
			public unsafe global::Com.Bumptech.Glide.RequestManager.GenericModelRequest.GenericTypeRequest From (global::Java.Lang.Class p0)
			{
				if (id_from_Ljava_lang_Class_ == IntPtr.Zero)
					id_from_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "from", "(Ljava/lang/Class;)Lcom/bumptech/glide/RequestManager$GenericModelRequest$GenericTypeRequest;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Bumptech.Glide.RequestManager.GenericModelRequest.GenericTypeRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager.GenericModelRequest.GenericTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_from_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_load_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager.GenericModelRequest']/method[@name='load' and count(parameter)=1 and parameter[1][@type='A']]"
			[Register ("load", "(Ljava/lang/Object;)Lcom/bumptech/glide/RequestManager$GenericModelRequest$GenericTypeRequest;", "")]
			public unsafe global::Com.Bumptech.Glide.RequestManager.GenericModelRequest.GenericTypeRequest Load (global::Java.Lang.Object p0)
			{
				if (id_load_Ljava_lang_Object_ == IntPtr.Zero)
					id_load_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/lang/Object;)Lcom/bumptech/glide/RequestManager$GenericModelRequest$GenericTypeRequest;");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bumptech.Glide.RequestManager.GenericModelRequest.GenericTypeRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager.GenericModelRequest.GenericTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_load_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager.ImageModelRequest']"
		[global::Android.Runtime.Register ("com/bumptech/glide/RequestManager$ImageModelRequest", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public sealed partial class ImageModelRequest : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/RequestManager$ImageModelRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ImageModelRequest); }
			}

			internal ImageModelRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_from_Ljava_lang_Class_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager.ImageModelRequest']/method[@name='from' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
			[Register ("from", "(Ljava/lang/Class;)Lcom/bumptech/glide/DrawableTypeRequest;", "")]
			public unsafe global::Com.Bumptech.Glide.DrawableTypeRequest From (global::Java.Lang.Class p0)
			{
				if (id_from_Ljava_lang_Class_ == IntPtr.Zero)
					id_from_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "from", "(Ljava/lang/Class;)Lcom/bumptech/glide/DrawableTypeRequest;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Bumptech.Glide.DrawableTypeRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_from_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_load_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager.ImageModelRequest']/method[@name='load' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("load", "(Ljava/lang/Object;)Lcom/bumptech/glide/DrawableTypeRequest;", "")]
			public unsafe global::Com.Bumptech.Glide.DrawableTypeRequest Load (global::Java.Lang.Object p0)
			{
				if (id_load_Ljava_lang_Object_ == IntPtr.Zero)
					id_load_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/lang/Object;)Lcom/bumptech/glide/DrawableTypeRequest;");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bumptech.Glide.DrawableTypeRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_load_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager.OptionsApplier']"
		[global::Android.Runtime.Register ("com/bumptech/glide/RequestManager$OptionsApplier", DoNotGenerateAcw=true)]
		public partial class OptionsApplier : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/RequestManager$OptionsApplier", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OptionsApplier); }
			}

			protected OptionsApplier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_apply_Lcom_bumptech_glide_GenericRequestBuilder_;
#pragma warning disable 0169
			static Delegate GetApply_Lcom_bumptech_glide_GenericRequestBuilder_Handler ()
			{
				if (cb_apply_Lcom_bumptech_glide_GenericRequestBuilder_ == null)
					cb_apply_Lcom_bumptech_glide_GenericRequestBuilder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Apply_Lcom_bumptech_glide_GenericRequestBuilder_);
				return cb_apply_Lcom_bumptech_glide_GenericRequestBuilder_;
			}

			static IntPtr n_Apply_Lcom_bumptech_glide_GenericRequestBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.RequestManager.OptionsApplier __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager.OptionsApplier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_apply_Lcom_bumptech_glide_GenericRequestBuilder_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager.OptionsApplier']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='X']]"
			[Register ("apply", "(Lcom/bumptech/glide/GenericRequestBuilder;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetApply_Lcom_bumptech_glide_GenericRequestBuilder_Handler")]
			[global::Java.Interop.JavaTypeParameters (new string [] {"A", "X extends com.bumptech.glide.GenericRequestBuilder<A, ?, ?, ?>"})]
			public virtual unsafe global::Java.Lang.Object Apply (global::Java.Lang.Object p0)
			{
				if (id_apply_Lcom_bumptech_glide_GenericRequestBuilder_ == IntPtr.Zero)
					id_apply_Lcom_bumptech_glide_GenericRequestBuilder_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lcom/bumptech/glide/GenericRequestBuilder;)Lcom/bumptech/glide/GenericRequestBuilder;");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Object __ret;
					if (GetType () == ThresholdType)
						__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_apply_Lcom_bumptech_glide_GenericRequestBuilder_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "apply", "(Lcom/bumptech/glide/GenericRequestBuilder;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager.RequestManagerConnectivityListener']"
		[global::Android.Runtime.Register ("com/bumptech/glide/RequestManager$RequestManagerConnectivityListener", DoNotGenerateAcw=true)]
		public partial class RequestManagerConnectivityListener : global::Java.Lang.Object, global::Com.Bumptech.Glide.Manager.IConnectivityMonitorConnectivityListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/RequestManager$RequestManagerConnectivityListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RequestManagerConnectivityListener); }
			}

			protected RequestManagerConnectivityListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_bumptech_glide_manager_RequestTracker_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager.RequestManagerConnectivityListener']/constructor[@name='RequestManager.RequestManagerConnectivityListener' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.manager.RequestTracker']]"
			[Register (".ctor", "(Lcom/bumptech/glide/manager/RequestTracker;)V", "")]
			public unsafe RequestManagerConnectivityListener (global::Com.Bumptech.Glide.Manager.RequestTracker p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (RequestManagerConnectivityListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/manager/RequestTracker;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/manager/RequestTracker;)V", __args);
						return;
					}

					if (id_ctor_Lcom_bumptech_glide_manager_RequestTracker_ == IntPtr.Zero)
						id_ctor_Lcom_bumptech_glide_manager_RequestTracker_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/manager/RequestTracker;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_manager_RequestTracker_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_manager_RequestTracker_, __args);
				} finally {
				}
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
				global::Com.Bumptech.Glide.RequestManager.RequestManagerConnectivityListener __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager.RequestManagerConnectivityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectivityChanged (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onConnectivityChanged_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager.RequestManagerConnectivityListener']/method[@name='onConnectivityChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onConnectivityChanged", "(Z)V", "GetOnConnectivityChanged_ZHandler")]
			public virtual unsafe void OnConnectivityChanged (bool p0)
			{
				if (id_onConnectivityChanged_Z == IntPtr.Zero)
					id_onConnectivityChanged_Z = JNIEnv.GetMethodID (class_ref, "onConnectivityChanged", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onConnectivityChanged_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectivityChanged", "(Z)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager.VideoModelRequest']"
		[global::Android.Runtime.Register ("com/bumptech/glide/RequestManager$VideoModelRequest", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public sealed partial class VideoModelRequest : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/RequestManager$VideoModelRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VideoModelRequest); }
			}

			internal VideoModelRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_load_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager.VideoModelRequest']/method[@name='load' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("load", "(Ljava/lang/Object;)Lcom/bumptech/glide/DrawableTypeRequest;", "")]
			public unsafe global::Com.Bumptech.Glide.DrawableTypeRequest Load (global::Java.Lang.Object p0)
			{
				if (id_load_Ljava_lang_Object_ == IntPtr.Zero)
					id_load_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/lang/Object;)Lcom/bumptech/glide/DrawableTypeRequest;");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bumptech.Glide.DrawableTypeRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_load_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/RequestManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestManager); }
		}

		protected RequestManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/constructor[@name='RequestManager' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.bumptech.glide.manager.Lifecycle'] and parameter[3][@type='com.bumptech.glide.manager.RequestManagerTreeNode']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/bumptech/glide/manager/Lifecycle;Lcom/bumptech/glide/manager/RequestManagerTreeNode;)V", "")]
		public unsafe RequestManager (global::Android.Content.Context p0, global::Com.Bumptech.Glide.Manager.ILifecycle p1, global::Com.Bumptech.Glide.Manager.IRequestManagerTreeNode p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (RequestManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/bumptech/glide/manager/Lifecycle;Lcom/bumptech/glide/manager/RequestManagerTreeNode;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/bumptech/glide/manager/Lifecycle;Lcom/bumptech/glide/manager/RequestManagerTreeNode;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/bumptech/glide/manager/Lifecycle;Lcom/bumptech/glide/manager/RequestManagerTreeNode;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_, __args);
			} finally {
			}
		}

		static Delegate cb_isPaused;
#pragma warning disable 0169
		static Delegate GetIsPausedHandler ()
		{
			if (cb_isPaused == null)
				cb_isPaused = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPaused);
			return cb_isPaused;
		}

		static bool n_IsPaused (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		static IntPtr id_isPaused;
		public virtual unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='isPaused' and count(parameter)=0]"
			[Register ("isPaused", "()Z", "GetIsPausedHandler")]
			get {
				if (id_isPaused == IntPtr.Zero)
					id_isPaused = JNIEnv.GetMethodID (class_ref, "isPaused", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isPaused);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPaused", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_from_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetFrom_Ljava_lang_Class_Handler ()
		{
			if (cb_from_Ljava_lang_Class_ == null)
				cb_from_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_From_Ljava_lang_Class_);
			return cb_from_Ljava_lang_Class_;
		}

		static IntPtr n_From_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.From (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_from_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='from' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("from", "(Ljava/lang/Class;)Lcom/bumptech/glide/DrawableTypeRequest;", "GetFrom_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest From (global::Java.Lang.Class p0)
		{
			if (id_from_Ljava_lang_Class_ == IntPtr.Zero)
				id_from_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "from", "(Ljava/lang/Class;)Lcom/bumptech/glide/DrawableTypeRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.DrawableTypeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_from_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "from", "(Ljava/lang/Class;)Lcom/bumptech/glide/DrawableTypeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_fromBytes;
#pragma warning disable 0169
		static Delegate GetFromBytesHandler ()
		{
			if (cb_fromBytes == null)
				cb_fromBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FromBytes);
			return cb_fromBytes;
		}

		static IntPtr n_FromBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FromBytes ());
		}
#pragma warning restore 0169

		static IntPtr id_fromBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='fromBytes' and count(parameter)=0]"
		[Register ("fromBytes", "()Lcom/bumptech/glide/DrawableTypeRequest;", "GetFromBytesHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest FromBytes ()
		{
			if (id_fromBytes == IntPtr.Zero)
				id_fromBytes = JNIEnv.GetMethodID (class_ref, "fromBytes", "()Lcom/bumptech/glide/DrawableTypeRequest;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_fromBytes), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromBytes", "()Lcom/bumptech/glide/DrawableTypeRequest;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fromFile;
#pragma warning disable 0169
		static Delegate GetFromFileHandler ()
		{
			if (cb_fromFile == null)
				cb_fromFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FromFile);
			return cb_fromFile;
		}

		static IntPtr n_FromFile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FromFile ());
		}
#pragma warning restore 0169

		static IntPtr id_fromFile;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='fromFile' and count(parameter)=0]"
		[Register ("fromFile", "()Lcom/bumptech/glide/DrawableTypeRequest;", "GetFromFileHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest FromFile ()
		{
			if (id_fromFile == IntPtr.Zero)
				id_fromFile = JNIEnv.GetMethodID (class_ref, "fromFile", "()Lcom/bumptech/glide/DrawableTypeRequest;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_fromFile), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromFile", "()Lcom/bumptech/glide/DrawableTypeRequest;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fromMediaStore;
#pragma warning disable 0169
		static Delegate GetFromMediaStoreHandler ()
		{
			if (cb_fromMediaStore == null)
				cb_fromMediaStore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FromMediaStore);
			return cb_fromMediaStore;
		}

		static IntPtr n_FromMediaStore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FromMediaStore ());
		}
#pragma warning restore 0169

		static IntPtr id_fromMediaStore;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='fromMediaStore' and count(parameter)=0]"
		[Register ("fromMediaStore", "()Lcom/bumptech/glide/DrawableTypeRequest;", "GetFromMediaStoreHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest FromMediaStore ()
		{
			if (id_fromMediaStore == IntPtr.Zero)
				id_fromMediaStore = JNIEnv.GetMethodID (class_ref, "fromMediaStore", "()Lcom/bumptech/glide/DrawableTypeRequest;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_fromMediaStore), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromMediaStore", "()Lcom/bumptech/glide/DrawableTypeRequest;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fromResource;
#pragma warning disable 0169
		static Delegate GetFromResourceHandler ()
		{
			if (cb_fromResource == null)
				cb_fromResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FromResource);
			return cb_fromResource;
		}

		static IntPtr n_FromResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FromResource ());
		}
#pragma warning restore 0169

		static IntPtr id_fromResource;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='fromResource' and count(parameter)=0]"
		[Register ("fromResource", "()Lcom/bumptech/glide/DrawableTypeRequest;", "GetFromResourceHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest FromResource ()
		{
			if (id_fromResource == IntPtr.Zero)
				id_fromResource = JNIEnv.GetMethodID (class_ref, "fromResource", "()Lcom/bumptech/glide/DrawableTypeRequest;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_fromResource), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromResource", "()Lcom/bumptech/glide/DrawableTypeRequest;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fromString;
#pragma warning disable 0169
		static Delegate GetFromStringHandler ()
		{
			if (cb_fromString == null)
				cb_fromString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FromString);
			return cb_fromString;
		}

		static IntPtr n_FromString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FromString ());
		}
#pragma warning restore 0169

		static IntPtr id_fromString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='fromString' and count(parameter)=0]"
		[Register ("fromString", "()Lcom/bumptech/glide/DrawableTypeRequest;", "GetFromStringHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest FromString ()
		{
			if (id_fromString == IntPtr.Zero)
				id_fromString = JNIEnv.GetMethodID (class_ref, "fromString", "()Lcom/bumptech/glide/DrawableTypeRequest;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_fromString), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromString", "()Lcom/bumptech/glide/DrawableTypeRequest;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fromUri;
#pragma warning disable 0169
		static Delegate GetFromUriHandler ()
		{
			if (cb_fromUri == null)
				cb_fromUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FromUri);
			return cb_fromUri;
		}

		static IntPtr n_FromUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FromUri ());
		}
#pragma warning restore 0169

		static IntPtr id_fromUri;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='fromUri' and count(parameter)=0]"
		[Register ("fromUri", "()Lcom/bumptech/glide/DrawableTypeRequest;", "GetFromUriHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest FromUri ()
		{
			if (id_fromUri == IntPtr.Zero)
				id_fromUri = JNIEnv.GetMethodID (class_ref, "fromUri", "()Lcom/bumptech/glide/DrawableTypeRequest;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_fromUri), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromUri", "()Lcom/bumptech/glide/DrawableTypeRequest;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fromUrl;
#pragma warning disable 0169
		static Delegate GetFromUrlHandler ()
		{
			if (cb_fromUrl == null)
				cb_fromUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FromUrl);
			return cb_fromUrl;
		}

		static IntPtr n_FromUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FromUrl ());
		}
#pragma warning restore 0169

		static IntPtr id_fromUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='fromUrl' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("fromUrl", "()Lcom/bumptech/glide/DrawableTypeRequest;", "GetFromUrlHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest FromUrl ()
		{
			if (id_fromUrl == IntPtr.Zero)
				id_fromUrl = JNIEnv.GetMethodID (class_ref, "fromUrl", "()Lcom/bumptech/glide/DrawableTypeRequest;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_fromUrl), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromUrl", "()Lcom/bumptech/glide/DrawableTypeRequest;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_load_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_lang_Object_Handler ()
		{
			if (cb_load_Ljava_lang_Object_ == null)
				cb_load_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_Ljava_lang_Object_);
			return cb_load_Ljava_lang_Object_;
		}

		static IntPtr n_Load_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_load_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='load' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("load", "(Ljava/lang/Object;)Lcom/bumptech/glide/DrawableTypeRequest;", "GetLoad_Ljava_lang_Object_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest Load (global::Java.Lang.Object p0)
		{
			if (id_load_Ljava_lang_Object_ == IntPtr.Zero)
				id_load_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/lang/Object;)Lcom/bumptech/glide/DrawableTypeRequest;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Bumptech.Glide.DrawableTypeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_load_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "(Ljava/lang/Object;)Lcom/bumptech/glide/DrawableTypeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_load_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetLoad_Landroid_net_Uri_Handler ()
		{
			if (cb_load_Landroid_net_Uri_ == null)
				cb_load_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_Landroid_net_Uri_);
			return cb_load_Landroid_net_Uri_;
		}

		static IntPtr n_Load_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_load_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='load' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("load", "(Landroid/net/Uri;)Lcom/bumptech/glide/DrawableTypeRequest;", "GetLoad_Landroid_net_Uri_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest Load (global::Android.Net.Uri p0)
		{
			if (id_load_Landroid_net_Uri_ == IntPtr.Zero)
				id_load_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "load", "(Landroid/net/Uri;)Lcom/bumptech/glide/DrawableTypeRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.DrawableTypeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_load_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "(Landroid/net/Uri;)Lcom/bumptech/glide/DrawableTypeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_load_arrayB;
#pragma warning disable 0169
		static Delegate GetLoad_arrayBHandler ()
		{
			if (cb_load_arrayB == null)
				cb_load_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_arrayB);
			return cb_load_arrayB;
		}

		static IntPtr n_Load_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_load_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='load' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("load", "([B)Lcom/bumptech/glide/DrawableTypeRequest;", "GetLoad_arrayBHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest Load (byte[] p0)
		{
			if (id_load_arrayB == IntPtr.Zero)
				id_load_arrayB = JNIEnv.GetMethodID (class_ref, "load", "([B)Lcom/bumptech/glide/DrawableTypeRequest;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Bumptech.Glide.DrawableTypeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_load_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "([B)Lcom/bumptech/glide/DrawableTypeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_load_arrayBLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoad_arrayBLjava_lang_String_Handler ()
		{
			if (cb_load_arrayBLjava_lang_String_ == null)
				cb_load_arrayBLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_arrayBLjava_lang_String_);
			return cb_load_arrayBLjava_lang_String_;
		}

		static IntPtr n_Load_arrayBLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_load_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='load' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("load", "([BLjava/lang/String;)Lcom/bumptech/glide/DrawableTypeRequest;", "GetLoad_arrayBLjava_lang_String_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest Load (byte[] p0, string p1)
		{
			if (id_load_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_load_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "load", "([BLjava/lang/String;)Lcom/bumptech/glide/DrawableTypeRequest;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Bumptech.Glide.DrawableTypeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_load_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "([BLjava/lang/String;)Lcom/bumptech/glide/DrawableTypeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_load_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_io_File_Handler ()
		{
			if (cb_load_Ljava_io_File_ == null)
				cb_load_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_Ljava_io_File_);
			return cb_load_Ljava_io_File_;
		}

		static IntPtr n_Load_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_load_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("load", "(Ljava/io/File;)Lcom/bumptech/glide/DrawableTypeRequest;", "GetLoad_Ljava_io_File_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest Load (global::Java.IO.File p0)
		{
			if (id_load_Ljava_io_File_ == IntPtr.Zero)
				id_load_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/io/File;)Lcom/bumptech/glide/DrawableTypeRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.DrawableTypeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_load_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "(Ljava/io/File;)Lcom/bumptech/glide/DrawableTypeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_load_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_lang_Integer_Handler ()
		{
			if (cb_load_Ljava_lang_Integer_ == null)
				cb_load_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_Ljava_lang_Integer_);
			return cb_load_Ljava_lang_Integer_;
		}

		static IntPtr n_Load_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_load_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("load", "(Ljava/lang/Integer;)Lcom/bumptech/glide/DrawableTypeRequest;", "GetLoad_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest Load (global::Java.Lang.Integer p0)
		{
			if (id_load_Ljava_lang_Integer_ == IntPtr.Zero)
				id_load_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/lang/Integer;)Lcom/bumptech/glide/DrawableTypeRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.DrawableTypeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_load_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "(Ljava/lang/Integer;)Lcom/bumptech/glide/DrawableTypeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_load_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_lang_String_Handler ()
		{
			if (cb_load_Ljava_lang_String_ == null)
				cb_load_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_Ljava_lang_String_);
			return cb_load_Ljava_lang_String_;
		}

		static IntPtr n_Load_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_load_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("load", "(Ljava/lang/String;)Lcom/bumptech/glide/DrawableTypeRequest;", "GetLoad_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest Load (string p0)
		{
			if (id_load_Ljava_lang_String_ == IntPtr.Zero)
				id_load_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/lang/String;)Lcom/bumptech/glide/DrawableTypeRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Bumptech.Glide.DrawableTypeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_load_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "(Ljava/lang/String;)Lcom/bumptech/glide/DrawableTypeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_load_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_net_URL_Handler ()
		{
			if (cb_load_Ljava_net_URL_ == null)
				cb_load_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_Ljava_net_URL_);
			return cb_load_Ljava_net_URL_;
		}

		static IntPtr n_Load_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_load_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Obsolete (@"deprecated")]
		[Register ("load", "(Ljava/net/URL;)Lcom/bumptech/glide/DrawableTypeRequest;", "GetLoad_Ljava_net_URL_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest Load (global::Java.Net.URL p0)
		{
			if (id_load_Ljava_net_URL_ == IntPtr.Zero)
				id_load_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/net/URL;)Lcom/bumptech/glide/DrawableTypeRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.DrawableTypeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_load_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "(Ljava/net/URL;)Lcom/bumptech/glide/DrawableTypeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_loadFromMediaStore_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetLoadFromMediaStore_Landroid_net_Uri_Handler ()
		{
			if (cb_loadFromMediaStore_Landroid_net_Uri_ == null)
				cb_loadFromMediaStore_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadFromMediaStore_Landroid_net_Uri_);
			return cb_loadFromMediaStore_Landroid_net_Uri_;
		}

		static IntPtr n_LoadFromMediaStore_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadFromMediaStore (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadFromMediaStore_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='loadFromMediaStore' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("loadFromMediaStore", "(Landroid/net/Uri;)Lcom/bumptech/glide/DrawableTypeRequest;", "GetLoadFromMediaStore_Landroid_net_Uri_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest LoadFromMediaStore (global::Android.Net.Uri p0)
		{
			if (id_loadFromMediaStore_Landroid_net_Uri_ == IntPtr.Zero)
				id_loadFromMediaStore_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "loadFromMediaStore", "(Landroid/net/Uri;)Lcom/bumptech/glide/DrawableTypeRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.DrawableTypeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_loadFromMediaStore_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadFromMediaStore", "(Landroid/net/Uri;)Lcom/bumptech/glide/DrawableTypeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_loadFromMediaStore_Landroid_net_Uri_Ljava_lang_String_JI;
#pragma warning disable 0169
		static Delegate GetLoadFromMediaStore_Landroid_net_Uri_Ljava_lang_String_JIHandler ()
		{
			if (cb_loadFromMediaStore_Landroid_net_Uri_Ljava_lang_String_JI == null)
				cb_loadFromMediaStore_Landroid_net_Uri_Ljava_lang_String_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long, int, IntPtr>) n_LoadFromMediaStore_Landroid_net_Uri_Ljava_lang_String_JI);
			return cb_loadFromMediaStore_Landroid_net_Uri_Ljava_lang_String_JI;
		}

		static IntPtr n_LoadFromMediaStore_Landroid_net_Uri_Ljava_lang_String_JI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, int p3)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadFromMediaStore (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadFromMediaStore_Landroid_net_Uri_Ljava_lang_String_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='loadFromMediaStore' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("loadFromMediaStore", "(Landroid/net/Uri;Ljava/lang/String;JI)Lcom/bumptech/glide/DrawableTypeRequest;", "GetLoadFromMediaStore_Landroid_net_Uri_Ljava_lang_String_JIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableTypeRequest LoadFromMediaStore (global::Android.Net.Uri p0, string p1, long p2, int p3)
		{
			if (id_loadFromMediaStore_Landroid_net_Uri_Ljava_lang_String_JI == IntPtr.Zero)
				id_loadFromMediaStore_Landroid_net_Uri_Ljava_lang_String_JI = JNIEnv.GetMethodID (class_ref, "loadFromMediaStore", "(Landroid/net/Uri;Ljava/lang/String;JI)Lcom/bumptech/glide/DrawableTypeRequest;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Com.Bumptech.Glide.DrawableTypeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_loadFromMediaStore_Landroid_net_Uri_Ljava_lang_String_JI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadFromMediaStore", "(Landroid/net/Uri;Ljava/lang/String;JI)Lcom/bumptech/glide/DrawableTypeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_onLowMemory;
#pragma warning disable 0169
		static Delegate GetOnLowMemoryHandler ()
		{
			if (cb_onLowMemory == null)
				cb_onLowMemory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLowMemory);
			return cb_onLowMemory;
		}

		static void n_OnLowMemory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLowMemory ();
		}
#pragma warning restore 0169

		static IntPtr id_onLowMemory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='onLowMemory' and count(parameter)=0]"
		[Register ("onLowMemory", "()V", "GetOnLowMemoryHandler")]
		public virtual unsafe void OnLowMemory ()
		{
			if (id_onLowMemory == IntPtr.Zero)
				id_onLowMemory = JNIEnv.GetMethodID (class_ref, "onLowMemory", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLowMemory);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLowMemory", "()V"));
			} finally {
			}
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
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		static IntPtr id_onStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual unsafe void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStart);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStart", "()V"));
			} finally {
			}
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
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		static IntPtr id_onStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual unsafe void OnStop ()
		{
			if (id_onStop == IntPtr.Zero)
				id_onStop = JNIEnv.GetMethodID (class_ref, "onStop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStop", "()V"));
			} finally {
			}
		}

		static Delegate cb_onTrimMemory_I;
#pragma warning disable 0169
		static Delegate GetOnTrimMemory_IHandler ()
		{
			if (cb_onTrimMemory_I == null)
				cb_onTrimMemory_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnTrimMemory_I);
			return cb_onTrimMemory_I;
		}

		static void n_OnTrimMemory_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTrimMemory (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onTrimMemory_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='onTrimMemory' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onTrimMemory", "(I)V", "GetOnTrimMemory_IHandler")]
		public virtual unsafe void OnTrimMemory (int p0)
		{
			if (id_onTrimMemory_I == IntPtr.Zero)
				id_onTrimMemory_I = JNIEnv.GetMethodID (class_ref, "onTrimMemory", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onTrimMemory_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTrimMemory", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_pauseRequests;
#pragma warning disable 0169
		static Delegate GetPauseRequestsHandler ()
		{
			if (cb_pauseRequests == null)
				cb_pauseRequests = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PauseRequests);
			return cb_pauseRequests;
		}

		static void n_PauseRequests (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseRequests ();
		}
#pragma warning restore 0169

		static IntPtr id_pauseRequests;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='pauseRequests' and count(parameter)=0]"
		[Register ("pauseRequests", "()V", "GetPauseRequestsHandler")]
		public virtual unsafe void PauseRequests ()
		{
			if (id_pauseRequests == IntPtr.Zero)
				id_pauseRequests = JNIEnv.GetMethodID (class_ref, "pauseRequests", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_pauseRequests);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pauseRequests", "()V"));
			} finally {
			}
		}

		static Delegate cb_pauseRequestsRecursive;
#pragma warning disable 0169
		static Delegate GetPauseRequestsRecursiveHandler ()
		{
			if (cb_pauseRequestsRecursive == null)
				cb_pauseRequestsRecursive = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PauseRequestsRecursive);
			return cb_pauseRequestsRecursive;
		}

		static void n_PauseRequestsRecursive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseRequestsRecursive ();
		}
#pragma warning restore 0169

		static IntPtr id_pauseRequestsRecursive;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='pauseRequestsRecursive' and count(parameter)=0]"
		[Register ("pauseRequestsRecursive", "()V", "GetPauseRequestsRecursiveHandler")]
		public virtual unsafe void PauseRequestsRecursive ()
		{
			if (id_pauseRequestsRecursive == IntPtr.Zero)
				id_pauseRequestsRecursive = JNIEnv.GetMethodID (class_ref, "pauseRequestsRecursive", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_pauseRequestsRecursive);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pauseRequestsRecursive", "()V"));
			} finally {
			}
		}

		static Delegate cb_resumeRequests;
#pragma warning disable 0169
		static Delegate GetResumeRequestsHandler ()
		{
			if (cb_resumeRequests == null)
				cb_resumeRequests = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResumeRequests);
			return cb_resumeRequests;
		}

		static void n_ResumeRequests (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeRequests ();
		}
#pragma warning restore 0169

		static IntPtr id_resumeRequests;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='resumeRequests' and count(parameter)=0]"
		[Register ("resumeRequests", "()V", "GetResumeRequestsHandler")]
		public virtual unsafe void ResumeRequests ()
		{
			if (id_resumeRequests == IntPtr.Zero)
				id_resumeRequests = JNIEnv.GetMethodID (class_ref, "resumeRequests", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resumeRequests);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resumeRequests", "()V"));
			} finally {
			}
		}

		static Delegate cb_resumeRequestsRecursive;
#pragma warning disable 0169
		static Delegate GetResumeRequestsRecursiveHandler ()
		{
			if (cb_resumeRequestsRecursive == null)
				cb_resumeRequestsRecursive = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResumeRequestsRecursive);
			return cb_resumeRequestsRecursive;
		}

		static void n_ResumeRequestsRecursive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeRequestsRecursive ();
		}
#pragma warning restore 0169

		static IntPtr id_resumeRequestsRecursive;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='resumeRequestsRecursive' and count(parameter)=0]"
		[Register ("resumeRequestsRecursive", "()V", "GetResumeRequestsRecursiveHandler")]
		public virtual unsafe void ResumeRequestsRecursive ()
		{
			if (id_resumeRequestsRecursive == IntPtr.Zero)
				id_resumeRequestsRecursive = JNIEnv.GetMethodID (class_ref, "resumeRequestsRecursive", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resumeRequestsRecursive);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resumeRequestsRecursive", "()V"));
			} finally {
			}
		}

		static Delegate cb_setDefaultOptions_Lcom_bumptech_glide_RequestManager_DefaultOptions_;
#pragma warning disable 0169
		static Delegate GetSetDefaultOptions_Lcom_bumptech_glide_RequestManager_DefaultOptions_Handler ()
		{
			if (cb_setDefaultOptions_Lcom_bumptech_glide_RequestManager_DefaultOptions_ == null)
				cb_setDefaultOptions_Lcom_bumptech_glide_RequestManager_DefaultOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultOptions_Lcom_bumptech_glide_RequestManager_DefaultOptions_);
			return cb_setDefaultOptions_Lcom_bumptech_glide_RequestManager_DefaultOptions_;
		}

		static void n_SetDefaultOptions_Lcom_bumptech_glide_RequestManager_DefaultOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.RequestManager.IDefaultOptions p0 = (global::Com.Bumptech.Glide.RequestManager.IDefaultOptions)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager.IDefaultOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultOptions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDefaultOptions_Lcom_bumptech_glide_RequestManager_DefaultOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='setDefaultOptions' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.RequestManager.DefaultOptions']]"
		[Register ("setDefaultOptions", "(Lcom/bumptech/glide/RequestManager$DefaultOptions;)V", "GetSetDefaultOptions_Lcom_bumptech_glide_RequestManager_DefaultOptions_Handler")]
		public virtual unsafe void SetDefaultOptions (global::Com.Bumptech.Glide.RequestManager.IDefaultOptions p0)
		{
			if (id_setDefaultOptions_Lcom_bumptech_glide_RequestManager_DefaultOptions_ == IntPtr.Zero)
				id_setDefaultOptions_Lcom_bumptech_glide_RequestManager_DefaultOptions_ = JNIEnv.GetMethodID (class_ref, "setDefaultOptions", "(Lcom/bumptech/glide/RequestManager$DefaultOptions;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDefaultOptions_Lcom_bumptech_glide_RequestManager_DefaultOptions_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultOptions", "(Lcom/bumptech/glide/RequestManager$DefaultOptions;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_using_Lcom_bumptech_glide_load_model_ModelLoader_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetUsing_Lcom_bumptech_glide_load_model_ModelLoader_Ljava_lang_Class_Handler ()
		{
			if (cb_using_Lcom_bumptech_glide_load_model_ModelLoader_Ljava_lang_Class_ == null)
				cb_using_Lcom_bumptech_glide_load_model_ModelLoader_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Using_Lcom_bumptech_glide_load_model_ModelLoader_Ljava_lang_Class_);
			return cb_using_Lcom_bumptech_glide_load_model_ModelLoader_Ljava_lang_Class_;
		}

		static IntPtr n_Using_Lcom_bumptech_glide_load_model_ModelLoader_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Model.IModelLoader p0 = (global::Com.Bumptech.Glide.Load.Model.IModelLoader)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Using (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_using_Lcom_bumptech_glide_load_model_ModelLoader_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='using' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.model.ModelLoader&lt;A, T&gt;'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("using", "(Lcom/bumptech/glide/load/model/ModelLoader;Ljava/lang/Class;)Lcom/bumptech/glide/RequestManager$GenericModelRequest;", "GetUsing_Lcom_bumptech_glide_load_model_ModelLoader_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"A", "T"})]
		public virtual unsafe global::Com.Bumptech.Glide.RequestManager.GenericModelRequest Using (global::Com.Bumptech.Glide.Load.Model.IModelLoader p0, global::Java.Lang.Class p1)
		{
			if (id_using_Lcom_bumptech_glide_load_model_ModelLoader_Ljava_lang_Class_ == IntPtr.Zero)
				id_using_Lcom_bumptech_glide_load_model_ModelLoader_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "using", "(Lcom/bumptech/glide/load/model/ModelLoader;Ljava/lang/Class;)Lcom/bumptech/glide/RequestManager$GenericModelRequest;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Bumptech.Glide.RequestManager.GenericModelRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager.GenericModelRequest> (JNIEnv.CallObjectMethod  (Handle, id_using_Lcom_bumptech_glide_load_model_ModelLoader_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager.GenericModelRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "using", "(Lcom/bumptech/glide/load/model/ModelLoader;Ljava/lang/Class;)Lcom/bumptech/glide/RequestManager$GenericModelRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_using_Lcom_bumptech_glide_load_model_file_descriptor_FileDescriptorModelLoader_;
#pragma warning disable 0169
		static Delegate GetUsing_Lcom_bumptech_glide_load_model_file_descriptor_FileDescriptorModelLoader_Handler ()
		{
			if (cb_using_Lcom_bumptech_glide_load_model_file_descriptor_FileDescriptorModelLoader_ == null)
				cb_using_Lcom_bumptech_glide_load_model_file_descriptor_FileDescriptorModelLoader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Using_Lcom_bumptech_glide_load_model_file_descriptor_FileDescriptorModelLoader_);
			return cb_using_Lcom_bumptech_glide_load_model_file_descriptor_FileDescriptorModelLoader_;
		}

		static IntPtr n_Using_Lcom_bumptech_glide_load_model_file_descriptor_FileDescriptorModelLoader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Model.File_descriptor.IFileDescriptorModelLoader p0 = (global::Com.Bumptech.Glide.Load.Model.File_descriptor.IFileDescriptorModelLoader)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.File_descriptor.IFileDescriptorModelLoader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Using (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_using_Lcom_bumptech_glide_load_model_file_descriptor_FileDescriptorModelLoader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='using' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.model.file_descriptor.FileDescriptorModelLoader&lt;T&gt;']]"
		[Register ("using", "(Lcom/bumptech/glide/load/model/file_descriptor/FileDescriptorModelLoader;)Lcom/bumptech/glide/RequestManager$VideoModelRequest;", "GetUsing_Lcom_bumptech_glide_load_model_file_descriptor_FileDescriptorModelLoader_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Com.Bumptech.Glide.RequestManager.VideoModelRequest Using (global::Com.Bumptech.Glide.Load.Model.File_descriptor.IFileDescriptorModelLoader p0)
		{
			if (id_using_Lcom_bumptech_glide_load_model_file_descriptor_FileDescriptorModelLoader_ == IntPtr.Zero)
				id_using_Lcom_bumptech_glide_load_model_file_descriptor_FileDescriptorModelLoader_ = JNIEnv.GetMethodID (class_ref, "using", "(Lcom/bumptech/glide/load/model/file_descriptor/FileDescriptorModelLoader;)Lcom/bumptech/glide/RequestManager$VideoModelRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.RequestManager.VideoModelRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager.VideoModelRequest> (JNIEnv.CallObjectMethod  (Handle, id_using_Lcom_bumptech_glide_load_model_file_descriptor_FileDescriptorModelLoader_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager.VideoModelRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "using", "(Lcom/bumptech/glide/load/model/file_descriptor/FileDescriptorModelLoader;)Lcom/bumptech/glide/RequestManager$VideoModelRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_using_Lcom_bumptech_glide_load_model_stream_StreamByteArrayLoader_;
#pragma warning disable 0169
		static Delegate GetUsing_Lcom_bumptech_glide_load_model_stream_StreamByteArrayLoader_Handler ()
		{
			if (cb_using_Lcom_bumptech_glide_load_model_stream_StreamByteArrayLoader_ == null)
				cb_using_Lcom_bumptech_glide_load_model_stream_StreamByteArrayLoader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Using_Lcom_bumptech_glide_load_model_stream_StreamByteArrayLoader_);
			return cb_using_Lcom_bumptech_glide_load_model_stream_StreamByteArrayLoader_;
		}

		static IntPtr n_Using_Lcom_bumptech_glide_load_model_stream_StreamByteArrayLoader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Model.Stream.StreamByteArrayLoader p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.Stream.StreamByteArrayLoader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Using (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_using_Lcom_bumptech_glide_load_model_stream_StreamByteArrayLoader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='using' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.model.stream.StreamByteArrayLoader']]"
		[Register ("using", "(Lcom/bumptech/glide/load/model/stream/StreamByteArrayLoader;)Lcom/bumptech/glide/RequestManager$ImageModelRequest;", "GetUsing_Lcom_bumptech_glide_load_model_stream_StreamByteArrayLoader_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.RequestManager.ImageModelRequest Using (global::Com.Bumptech.Glide.Load.Model.Stream.StreamByteArrayLoader p0)
		{
			if (id_using_Lcom_bumptech_glide_load_model_stream_StreamByteArrayLoader_ == IntPtr.Zero)
				id_using_Lcom_bumptech_glide_load_model_stream_StreamByteArrayLoader_ = JNIEnv.GetMethodID (class_ref, "using", "(Lcom/bumptech/glide/load/model/stream/StreamByteArrayLoader;)Lcom/bumptech/glide/RequestManager$ImageModelRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.RequestManager.ImageModelRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager.ImageModelRequest> (JNIEnv.CallObjectMethod  (Handle, id_using_Lcom_bumptech_glide_load_model_stream_StreamByteArrayLoader_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager.ImageModelRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "using", "(Lcom/bumptech/glide/load/model/stream/StreamByteArrayLoader;)Lcom/bumptech/glide/RequestManager$ImageModelRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_using_Lcom_bumptech_glide_load_model_stream_StreamModelLoader_;
#pragma warning disable 0169
		static Delegate GetUsing_Lcom_bumptech_glide_load_model_stream_StreamModelLoader_Handler ()
		{
			if (cb_using_Lcom_bumptech_glide_load_model_stream_StreamModelLoader_ == null)
				cb_using_Lcom_bumptech_glide_load_model_stream_StreamModelLoader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Using_Lcom_bumptech_glide_load_model_stream_StreamModelLoader_);
			return cb_using_Lcom_bumptech_glide_load_model_stream_StreamModelLoader_;
		}

		static IntPtr n_Using_Lcom_bumptech_glide_load_model_stream_StreamModelLoader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Model.Stream.IStreamModelLoader p0 = (global::Com.Bumptech.Glide.Load.Model.Stream.IStreamModelLoader)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.Stream.IStreamModelLoader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Using (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_using_Lcom_bumptech_glide_load_model_stream_StreamModelLoader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='RequestManager']/method[@name='using' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.model.stream.StreamModelLoader&lt;T&gt;']]"
		[Register ("using", "(Lcom/bumptech/glide/load/model/stream/StreamModelLoader;)Lcom/bumptech/glide/RequestManager$ImageModelRequest;", "GetUsing_Lcom_bumptech_glide_load_model_stream_StreamModelLoader_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Com.Bumptech.Glide.RequestManager.ImageModelRequest Using (global::Com.Bumptech.Glide.Load.Model.Stream.IStreamModelLoader p0)
		{
			if (id_using_Lcom_bumptech_glide_load_model_stream_StreamModelLoader_ == IntPtr.Zero)
				id_using_Lcom_bumptech_glide_load_model_stream_StreamModelLoader_ = JNIEnv.GetMethodID (class_ref, "using", "(Lcom/bumptech/glide/load/model/stream/StreamModelLoader;)Lcom/bumptech/glide/RequestManager$ImageModelRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.RequestManager.ImageModelRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager.ImageModelRequest> (JNIEnv.CallObjectMethod  (Handle, id_using_Lcom_bumptech_glide_load_model_stream_StreamModelLoader_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager.ImageModelRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "using", "(Lcom/bumptech/glide/load/model/stream/StreamModelLoader;)Lcom/bumptech/glide/RequestManager$ImageModelRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
