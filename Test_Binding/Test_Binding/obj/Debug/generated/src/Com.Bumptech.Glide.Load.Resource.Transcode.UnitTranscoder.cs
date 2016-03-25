using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Transcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/class[@name='UnitTranscoder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/transcode/UnitTranscoder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Z"})]
	public partial class UnitTranscoder : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/transcode/UnitTranscoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnitTranscoder); }
		}

		protected UnitTranscoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/class[@name='UnitTranscoder']/constructor[@name='UnitTranscoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnitTranscoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UnitTranscoder)) {
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
			global::Com.Bumptech.Glide.Load.Resource.Transcode.UnitTranscoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.UnitTranscoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/class[@name='UnitTranscoder']/method[@name='getId' and count(parameter)=0]"
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

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/class[@name='UnitTranscoder']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Z"})]
		public static unsafe global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetStaticMethodID (class_ref, "get", "()Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_transcode_Lcom_bumptech_glide_load_engine_Resource_;
#pragma warning disable 0169
		static Delegate GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Handler ()
		{
			if (cb_transcode_Lcom_bumptech_glide_load_engine_Resource_ == null)
				cb_transcode_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transcode_Lcom_bumptech_glide_load_engine_Resource_);
			return cb_transcode_Lcom_bumptech_glide_load_engine_Resource_;
		}

		static IntPtr n_Transcode_Lcom_bumptech_glide_load_engine_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Resource.Transcode.UnitTranscoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.UnitTranscoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p0 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transcode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transcode_Lcom_bumptech_glide_load_engine_Resource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/class[@name='UnitTranscoder']/method[@name='transcode' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.Resource&lt;Z&gt;']]"
		[Register ("transcode", "(Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;", "GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Transcode (global::Com.Bumptech.Glide.Load.Engine.IResource p0)
		{
			if (id_transcode_Lcom_bumptech_glide_load_engine_Resource_ == IntPtr.Zero)
				id_transcode_Lcom_bumptech_glide_load_engine_Resource_ = JNIEnv.GetMethodID (class_ref, "transcode", "(Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.Load.Engine.IResource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod  (Handle, id_transcode_Lcom_bumptech_glide_load_engine_Resource_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transcode", "(Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
