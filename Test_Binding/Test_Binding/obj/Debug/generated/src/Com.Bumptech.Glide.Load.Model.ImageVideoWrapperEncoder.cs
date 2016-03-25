using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoWrapperEncoder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/ImageVideoWrapperEncoder", DoNotGenerateAcw=true)]
	public partial class ImageVideoWrapperEncoder : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.IEncoder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/model/ImageVideoWrapperEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageVideoWrapperEncoder); }
		}

		protected ImageVideoWrapperEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_Encoder_Lcom_bumptech_glide_load_Encoder_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoWrapperEncoder']/constructor[@name='ImageVideoWrapperEncoder' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.Encoder&lt;java.io.InputStream&gt;'] and parameter[2][@type='com.bumptech.glide.load.Encoder&lt;android.os.ParcelFileDescriptor&gt;']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/Encoder;Lcom/bumptech/glide/load/Encoder;)V", "")]
		public unsafe ImageVideoWrapperEncoder (global::Com.Bumptech.Glide.Load.IEncoder p0, global::Com.Bumptech.Glide.Load.IEncoder p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ImageVideoWrapperEncoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/Encoder;Lcom/bumptech/glide/load/Encoder;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/Encoder;Lcom/bumptech/glide/load/Encoder;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_Encoder_Lcom_bumptech_glide_load_Encoder_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_Encoder_Lcom_bumptech_glide_load_Encoder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/Encoder;Lcom/bumptech/glide/load/Encoder;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_Encoder_Lcom_bumptech_glide_load_Encoder_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_Encoder_Lcom_bumptech_glide_load_Encoder_, __args);
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
			global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapperEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapperEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoWrapperEncoder']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_encode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_Ljava_io_OutputStream_Handler ()
		{
			if (cb_encode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_Ljava_io_OutputStream_ == null)
				cb_encode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Encode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_Ljava_io_OutputStream_);
			return cb_encode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_Ljava_io_OutputStream_;
		}

		static bool n_Encode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapperEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapperEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Encode (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoWrapperEncoder']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.model.ImageVideoWrapper'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("encode", "(Lcom/bumptech/glide/load/model/ImageVideoWrapper;Ljava/io/OutputStream;)Z", "GetEncode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_Ljava_io_OutputStream_Handler")]
		public virtual unsafe bool Encode (global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper p0, global::System.IO.Stream p1)
		{
			if (id_encode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_encode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(Lcom/bumptech/glide/load/model/ImageVideoWrapper;Ljava/io/OutputStream;)Z");
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_encode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_Ljava_io_OutputStream_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Lcom/bumptech/glide/load/model/ImageVideoWrapper;Ljava/io/OutputStream;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.IEncoder
		bool global::Com.Bumptech.Glide.Load.IEncoder.Encode (global::Java.Lang.Object p0, global::System.IO.Stream p1)
		{
			return Encode (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper>(p0), p1);
		}

	}
}
