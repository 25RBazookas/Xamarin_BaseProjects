using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Gifbitmap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapperStreamResourceDecoder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/gifbitmap/GifBitmapWrapperStreamResourceDecoder", DoNotGenerateAcw=true)]
	public partial class GifBitmapWrapperStreamResourceDecoder : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.IResourceDecoder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/gifbitmap/GifBitmapWrapperStreamResourceDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifBitmapWrapperStreamResourceDecoder); }
		}

		protected GifBitmapWrapperStreamResourceDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_ResourceDecoder_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapperStreamResourceDecoder']/constructor[@name='GifBitmapWrapperStreamResourceDecoder' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.ResourceDecoder&lt;com.bumptech.glide.load.model.ImageVideoWrapper, com.bumptech.glide.load.resource.gifbitmap.GifBitmapWrapper&gt;']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/ResourceDecoder;)V", "")]
		public unsafe GifBitmapWrapperStreamResourceDecoder (global::Com.Bumptech.Glide.Load.IResourceDecoder p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GifBitmapWrapperStreamResourceDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/ResourceDecoder;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/ResourceDecoder;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_ResourceDecoder_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_ResourceDecoder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/ResourceDecoder;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_ResourceDecoder_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_ResourceDecoder_, __args);
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
			global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapperStreamResourceDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapperStreamResourceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapperStreamResourceDecoder']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_decode_Ljava_io_InputStream_II;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_io_InputStream_IIHandler ()
		{
			if (cb_decode_Ljava_io_InputStream_II == null)
				cb_decode_Ljava_io_InputStream_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Decode_Ljava_io_InputStream_II);
			return cb_decode_Ljava_io_InputStream_II;
		}

		static IntPtr n_Decode_Ljava_io_InputStream_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapperStreamResourceDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapperStreamResourceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_io_InputStream_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapperStreamResourceDecoder']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("decode", "(Ljava/io/InputStream;II)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Ljava_io_InputStream_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Decode (global::System.IO.Stream p0, int p1, int p2)
		{
			if (id_decode_Ljava_io_InputStream_II == IntPtr.Zero)
				id_decode_Ljava_io_InputStream_II = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/io/InputStream;II)Lcom/bumptech/glide/load/engine/Resource;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Bumptech.Glide.Load.Engine.IResource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod  (Handle, id_decode_Ljava_io_InputStream_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/io/InputStream;II)Lcom/bumptech/glide/load/engine/Resource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.IResourceDecoder
		global::Com.Bumptech.Glide.Load.Engine.IResource global::Com.Bumptech.Glide.Load.IResourceDecoder.Decode (global::Java.Lang.Object p0, int p1, int p2)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Bumptech.Glide.Load.Engine.IResource>(Decode (global::Java.Interop.JavaObjectExtensions.JavaCast<global::System.IO.Stream>(p0), p1, p2));
		}

	}
}
