using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Bitmap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageVideoBitmapDecoder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/ImageVideoBitmapDecoder", DoNotGenerateAcw=true)]
	public partial class ImageVideoBitmapDecoder : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.IResourceDecoder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/ImageVideoBitmapDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageVideoBitmapDecoder); }
		}

		protected ImageVideoBitmapDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_ResourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageVideoBitmapDecoder']/constructor[@name='ImageVideoBitmapDecoder' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.ResourceDecoder&lt;java.io.InputStream, android.graphics.Bitmap&gt;'] and parameter[2][@type='com.bumptech.glide.load.ResourceDecoder&lt;android.os.ParcelFileDescriptor, android.graphics.Bitmap&gt;']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/ResourceDecoder;Lcom/bumptech/glide/load/ResourceDecoder;)V", "")]
		public unsafe ImageVideoBitmapDecoder (global::Com.Bumptech.Glide.Load.IResourceDecoder p0, global::Com.Bumptech.Glide.Load.IResourceDecoder p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ImageVideoBitmapDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/ResourceDecoder;Lcom/bumptech/glide/load/ResourceDecoder;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/ResourceDecoder;Lcom/bumptech/glide/load/ResourceDecoder;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_ResourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_ResourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/ResourceDecoder;Lcom/bumptech/glide/load/ResourceDecoder;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_ResourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_ResourceDecoder_Lcom_bumptech_glide_load_ResourceDecoder_, __args);
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
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageVideoBitmapDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageVideoBitmapDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageVideoBitmapDecoder']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II;
#pragma warning disable 0169
		static Delegate GetDecode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_IIHandler ()
		{
			if (cb_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II == null)
				cb_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II);
			return cb_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II;
		}

		static IntPtr n_Decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageVideoBitmapDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageVideoBitmapDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageVideoBitmapDecoder']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='com.bumptech.glide.load.model.ImageVideoWrapper'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("decode", "(Lcom/bumptech/glide/load/model/ImageVideoWrapper;II)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Decode (global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper p0, int p1, int p2)
		{
			if (id_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II == IntPtr.Zero)
				id_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/bumptech/glide/load/model/ImageVideoWrapper;II)Lcom/bumptech/glide/load/engine/Resource;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Bumptech.Glide.Load.Engine.IResource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod  (Handle, id_decode_Lcom_bumptech_glide_load_model_ImageVideoWrapper_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Lcom/bumptech/glide/load/model/ImageVideoWrapper;II)Lcom/bumptech/glide/load/engine/Resource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.IResourceDecoder
		global::Com.Bumptech.Glide.Load.Engine.IResource global::Com.Bumptech.Glide.Load.IResourceDecoder.Decode (global::Java.Lang.Object p0, int p1, int p2)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Bumptech.Glide.Load.Engine.IResource>(Decode (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper>(p0), p1, p2));
		}

	}
}
