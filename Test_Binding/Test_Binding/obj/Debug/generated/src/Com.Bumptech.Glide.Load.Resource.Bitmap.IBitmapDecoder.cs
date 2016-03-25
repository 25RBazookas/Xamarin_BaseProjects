using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Bitmap {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/interface[@name='BitmapDecoder']"
	[Register ("com/bumptech/glide/load/resource/bitmap/BitmapDecoder", "", "Com.Bumptech.Glide.Load.Resource.Bitmap.IBitmapDecoderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IBitmapDecoder : IJavaObject {

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/interface[@name='BitmapDecoder']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Bumptech.Glide.Load.Resource.Bitmap.IBitmapDecoderInvoker, Test_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/interface[@name='BitmapDecoder']/method[@name='decode' and count(parameter)=5 and parameter[1][@type='T'] and parameter[2][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.bumptech.glide.load.DecodeFormat']]"
		[Register ("decode", "(Ljava/lang/Object;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;IILcom/bumptech/glide/load/DecodeFormat;)Landroid/graphics/Bitmap;", "GetDecode_Ljava_lang_Object_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_Handler:Com.Bumptech.Glide.Load.Resource.Bitmap.IBitmapDecoderInvoker, Test_Binding")]
		global::Android.Graphics.Bitmap Decode (global::Java.Lang.Object p0, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1, int p2, int p3, global::Com.Bumptech.Glide.Load.DecodeFormat p4);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/BitmapDecoder", DoNotGenerateAcw=true)]
	internal class IBitmapDecoderInvoker : global::Java.Lang.Object, IBitmapDecoder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/BitmapDecoder");
		IntPtr class_ref;

		public static IBitmapDecoder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBitmapDecoder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.resource.bitmap.BitmapDecoder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBitmapDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBitmapDecoderInvoker); }
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
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.IBitmapDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.IBitmapDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_decode_Ljava_lang_Object_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_lang_Object_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_Handler ()
		{
			if (cb_decode_Ljava_lang_Object_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_ == null)
				cb_decode_Ljava_lang_Object_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_Decode_Ljava_lang_Object_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_);
			return cb_decode_Ljava_lang_Object_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_;
		}

		static IntPtr n_Decode_Ljava_lang_Object_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, IntPtr native_p4)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.IBitmapDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.IBitmapDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1 = (global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.DecodeFormat p4 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.DecodeFormat> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decode_Ljava_lang_Object_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_;
		public unsafe global::Android.Graphics.Bitmap Decode (global::Java.Lang.Object p0, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1, int p2, int p3, global::Com.Bumptech.Glide.Load.DecodeFormat p4)
		{
			if (id_decode_Ljava_lang_Object_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_ == IntPtr.Zero)
				id_decode_Ljava_lang_Object_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/Object;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;IILcom/bumptech/glide/load/DecodeFormat;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_decode_Ljava_lang_Object_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
