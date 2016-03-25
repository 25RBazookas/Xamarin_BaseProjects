using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Transcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/class[@name='TranscoderRegistry']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/transcode/TranscoderRegistry", DoNotGenerateAcw=true)]
	public partial class TranscoderRegistry : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/transcode/TranscoderRegistry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TranscoderRegistry); }
		}

		protected TranscoderRegistry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/class[@name='TranscoderRegistry']/constructor[@name='TranscoderRegistry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TranscoderRegistry ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TranscoderRegistry)) {
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

		static Delegate cb_get_Ljava_lang_Class_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_Class_Ljava_lang_Class_Handler ()
		{
			if (cb_get_Ljava_lang_Class_Ljava_lang_Class_ == null)
				cb_get_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_Class_Ljava_lang_Class_);
			return cb_get_Ljava_lang_Class_Ljava_lang_Class_;
		}

		static IntPtr n_Get_Ljava_lang_Class_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Load.Resource.Transcode.TranscoderRegistry __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.TranscoderRegistry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/class[@name='TranscoderRegistry']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;Z&gt;'] and parameter[2][@type='java.lang.Class&lt;R&gt;']]"
		[Register ("get", "(Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;", "GetGet_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Z", "R"})]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder Get (global::Java.Lang.Class p0, global::Java.Lang.Class p1)
		{
			if (id_get_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_get_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_Class_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Handler ()
		{
			if (cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ == null)
				cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_);
			return cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_;
		}

		static void n_Register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Bumptech.Glide.Load.Resource.Transcode.TranscoderRegistry __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.TranscoderRegistry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder p2 = (global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Register (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/class[@name='TranscoderRegistry']/method[@name='register' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;Z&gt;'] and parameter[2][@type='java.lang.Class&lt;R&gt;'] and parameter[3][@type='com.bumptech.glide.load.resource.transcode.ResourceTranscoder&lt;Z, R&gt;']]"
		[Register ("register", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)V", "GetRegister_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Z", "R"})]
		public virtual unsafe void Register (global::Java.Lang.Class p0, global::Java.Lang.Class p1, global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder p2)
		{
			if (id_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ == IntPtr.Zero)
				id_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ = JNIEnv.GetMethodID (class_ref, "register", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)V"), __args);
			} finally {
			}
		}

	}
}
