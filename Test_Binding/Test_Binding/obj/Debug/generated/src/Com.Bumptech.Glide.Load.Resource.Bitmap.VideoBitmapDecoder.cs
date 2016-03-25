using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Bitmap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='VideoBitmapDecoder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/VideoBitmapDecoder", DoNotGenerateAcw=true)]
	public partial class VideoBitmapDecoder : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Resource.Bitmap.IBitmapDecoder {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='VideoBitmapDecoder.MediaMetadataRetrieverFactory']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/VideoBitmapDecoder$MediaMetadataRetrieverFactory", DoNotGenerateAcw=true)]
		public partial class MediaMetadataRetrieverFactory : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/VideoBitmapDecoder$MediaMetadataRetrieverFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MediaMetadataRetrieverFactory); }
			}

			protected MediaMetadataRetrieverFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Resource.Bitmap.VideoBitmapDecoder.MediaMetadataRetrieverFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.VideoBitmapDecoder.MediaMetadataRetrieverFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='VideoBitmapDecoder.MediaMetadataRetrieverFactory']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Landroid/media/MediaMetadataRetriever;", "GetBuildHandler")]
			public virtual unsafe global::Android.Media.MediaMetadataRetriever Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Landroid/media/MediaMetadataRetriever;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Media.MediaMetadataRetriever> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Media.MediaMetadataRetriever> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Landroid/media/MediaMetadataRetriever;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/VideoBitmapDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoBitmapDecoder); }
		}

		protected VideoBitmapDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='VideoBitmapDecoder']/constructor[@name='VideoBitmapDecoder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe VideoBitmapDecoder (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (VideoBitmapDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='VideoBitmapDecoder']/constructor[@name='VideoBitmapDecoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoBitmapDecoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VideoBitmapDecoder)) {
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
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.VideoBitmapDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.VideoBitmapDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='VideoBitmapDecoder']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_decode_Landroid_os_ParcelFileDescriptor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_;
#pragma warning disable 0169
		static Delegate GetDecode_Landroid_os_ParcelFileDescriptor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_Handler ()
		{
			if (cb_decode_Landroid_os_ParcelFileDescriptor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_ == null)
				cb_decode_Landroid_os_ParcelFileDescriptor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_Decode_Landroid_os_ParcelFileDescriptor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_);
			return cb_decode_Landroid_os_ParcelFileDescriptor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_;
		}

		static IntPtr n_Decode_Landroid_os_ParcelFileDescriptor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, IntPtr native_p4)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.VideoBitmapDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.VideoBitmapDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelFileDescriptor p0 = global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1 = (global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.DecodeFormat p4 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.DecodeFormat> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Landroid_os_ParcelFileDescriptor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='VideoBitmapDecoder']/method[@name='decode' and count(parameter)=5 and parameter[1][@type='android.os.ParcelFileDescriptor'] and parameter[2][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.bumptech.glide.load.DecodeFormat']]"
		[Register ("decode", "(Landroid/os/ParcelFileDescriptor;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;IILcom/bumptech/glide/load/DecodeFormat;)Landroid/graphics/Bitmap;", "GetDecode_Landroid_os_ParcelFileDescriptor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap Decode (global::Android.OS.ParcelFileDescriptor p0, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1, int p2, int p3, global::Com.Bumptech.Glide.Load.DecodeFormat p4)
		{
			if (id_decode_Landroid_os_ParcelFileDescriptor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_ == IntPtr.Zero)
				id_decode_Landroid_os_ParcelFileDescriptor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_ = JNIEnv.GetMethodID (class_ref, "decode", "(Landroid/os/ParcelFileDescriptor;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;IILcom/bumptech/glide/load/DecodeFormat;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				global::Android.Graphics.Bitmap __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_decode_Landroid_os_ParcelFileDescriptor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_IILcom_bumptech_glide_load_DecodeFormat_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Landroid/os/ParcelFileDescriptor;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;IILcom/bumptech/glide/load/DecodeFormat;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.Resource.Bitmap.IBitmapDecoder
		global::Android.Graphics.Bitmap global::Com.Bumptech.Glide.Load.Resource.Bitmap.IBitmapDecoder.Decode (global::Java.Lang.Object p0, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1, int p2, int p3, global::Com.Bumptech.Glide.Load.DecodeFormat p4)
		{
			return Decode (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Android.OS.ParcelFileDescriptor>(p0), p1, p2, p3, p4);
		}

	}
}
