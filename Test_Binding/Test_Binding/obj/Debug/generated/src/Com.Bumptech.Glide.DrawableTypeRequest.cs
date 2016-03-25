using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='DrawableTypeRequest']"
	[global::Android.Runtime.Register ("com/bumptech/glide/DrawableTypeRequest", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"ModelType"})]
	public partial class DrawableTypeRequest : global::Com.Bumptech.Glide.DrawableRequestBuilder, global::Com.Bumptech.Glide.IDownloadOptions {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/DrawableTypeRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawableTypeRequest); }
		}

		protected DrawableTypeRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_asGif;
#pragma warning disable 0169
		static Delegate GetAsGifHandler ()
		{
			if (cb_asGif == null)
				cb_asGif = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsGif);
			return cb_asGif;
		}

		static IntPtr n_AsGif (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.DrawableTypeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsGif ());
		}
#pragma warning restore 0169

		static IntPtr id_asGif;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='DrawableTypeRequest']/method[@name='asGif' and count(parameter)=0]"
		[Register ("asGif", "()Lcom/bumptech/glide/GifTypeRequest;", "GetAsGifHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GifTypeRequest AsGif ()
		{
			if (id_asGif == IntPtr.Zero)
				id_asGif = JNIEnv.GetMethodID (class_ref, "asGif", "()Lcom/bumptech/glide/GifTypeRequest;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifTypeRequest> (JNIEnv.CallObjectMethod  (Handle, id_asGif), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifTypeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asGif", "()Lcom/bumptech/glide/GifTypeRequest;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_;
#pragma warning disable 0169
		static Delegate GetDownloadOnly_Lcom_bumptech_glide_request_target_Target_Handler ()
		{
			if (cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_ == null)
				cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DownloadOnly_Lcom_bumptech_glide_request_target_Target_);
			return cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_;
		}

		static IntPtr n_DownloadOnly_Lcom_bumptech_glide_request_target_Target_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.DrawableTypeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DownloadOnly (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_downloadOnly_Lcom_bumptech_glide_request_target_Target_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='DrawableTypeRequest']/method[@name='downloadOnly' and count(parameter)=1 and parameter[1][@type='Y']]"
		[Register ("downloadOnly", "(Lcom/bumptech/glide/request/target/Target;)Lcom/bumptech/glide/request/target/Target;", "GetDownloadOnly_Lcom_bumptech_glide_request_target_Target_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Y extends com.bumptech.glide.request.target.Target<java.io.File>"})]
		public virtual unsafe global::Java.Lang.Object DownloadOnly (global::Java.Lang.Object p0)
		{
			if (id_downloadOnly_Lcom_bumptech_glide_request_target_Target_ == IntPtr.Zero)
				id_downloadOnly_Lcom_bumptech_glide_request_target_Target_ = JNIEnv.GetMethodID (class_ref, "downloadOnly", "(Lcom/bumptech/glide/request/target/Target;)Lcom/bumptech/glide/request/target/Target;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_downloadOnly_Lcom_bumptech_glide_request_target_Target_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downloadOnly", "(Lcom/bumptech/glide/request/target/Target;)Lcom/bumptech/glide/request/target/Target;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_downloadOnly_II;
#pragma warning disable 0169
		static Delegate GetDownloadOnly_IIHandler ()
		{
			if (cb_downloadOnly_II == null)
				cb_downloadOnly_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_DownloadOnly_II);
			return cb_downloadOnly_II;
		}

		static IntPtr n_DownloadOnly_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Bumptech.Glide.DrawableTypeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableTypeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DownloadOnly (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_downloadOnly_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='DrawableTypeRequest']/method[@name='downloadOnly' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("downloadOnly", "(II)Lcom/bumptech/glide/request/FutureTarget;", "GetDownloadOnly_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Request.IFutureTarget DownloadOnly (int p0, int p1)
		{
			if (id_downloadOnly_II == IntPtr.Zero)
				id_downloadOnly_II = JNIEnv.GetMethodID (class_ref, "downloadOnly", "(II)Lcom/bumptech/glide/request/FutureTarget;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (JNIEnv.CallObjectMethod  (Handle, id_downloadOnly_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downloadOnly", "(II)Lcom/bumptech/glide/request/FutureTarget;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
