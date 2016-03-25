using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Bitmap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='FileDescriptorBitmapDecoder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/FileDescriptorBitmapDecoder", DoNotGenerateAcw=true)]
	public partial class FileDescriptorBitmapDecoder : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.IResourceDecoder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/FileDescriptorBitmapDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileDescriptorBitmapDecoder); }
		}

		protected FileDescriptorBitmapDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_resource_bitmap_VideoBitmapDecoder_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_DecodeFormat_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='FileDescriptorBitmapDecoder']/constructor[@name='FileDescriptorBitmapDecoder' and count(parameter)=3 and parameter[1][@type='com.bumptech.glide.load.resource.bitmap.VideoBitmapDecoder'] and parameter[2][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool'] and parameter[3][@type='com.bumptech.glide.load.DecodeFormat']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/resource/bitmap/VideoBitmapDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/DecodeFormat;)V", "")]
		public unsafe FileDescriptorBitmapDecoder (global::Com.Bumptech.Glide.Load.Resource.Bitmap.VideoBitmapDecoder p0, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1, global::Com.Bumptech.Glide.Load.DecodeFormat p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (FileDescriptorBitmapDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/resource/bitmap/VideoBitmapDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/DecodeFormat;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/resource/bitmap/VideoBitmapDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/DecodeFormat;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_resource_bitmap_VideoBitmapDecoder_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_DecodeFormat_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_resource_bitmap_VideoBitmapDecoder_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_DecodeFormat_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/resource/bitmap/VideoBitmapDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/DecodeFormat;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_resource_bitmap_VideoBitmapDecoder_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_DecodeFormat_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_resource_bitmap_VideoBitmapDecoder_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_DecodeFormat_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_DecodeFormat_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='FileDescriptorBitmapDecoder']/constructor[@name='FileDescriptorBitmapDecoder' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool'] and parameter[2][@type='com.bumptech.glide.load.DecodeFormat']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/DecodeFormat;)V", "")]
		public unsafe FileDescriptorBitmapDecoder (global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p0, global::Com.Bumptech.Glide.Load.DecodeFormat p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FileDescriptorBitmapDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/DecodeFormat;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/DecodeFormat;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_DecodeFormat_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_DecodeFormat_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/DecodeFormat;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_DecodeFormat_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Lcom_bumptech_glide_load_DecodeFormat_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_DecodeFormat_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='FileDescriptorBitmapDecoder']/constructor[@name='FileDescriptorBitmapDecoder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.bumptech.glide.load.DecodeFormat']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/bumptech/glide/load/DecodeFormat;)V", "")]
		public unsafe FileDescriptorBitmapDecoder (global::Android.Content.Context p0, global::Com.Bumptech.Glide.Load.DecodeFormat p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FileDescriptorBitmapDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/bumptech/glide/load/DecodeFormat;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/bumptech/glide/load/DecodeFormat;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_DecodeFormat_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_DecodeFormat_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/bumptech/glide/load/DecodeFormat;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_DecodeFormat_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_DecodeFormat_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='FileDescriptorBitmapDecoder']/constructor[@name='FileDescriptorBitmapDecoder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe FileDescriptorBitmapDecoder (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FileDescriptorBitmapDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
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
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.FileDescriptorBitmapDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.FileDescriptorBitmapDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='FileDescriptorBitmapDecoder']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_decode_Landroid_os_ParcelFileDescriptor_II;
#pragma warning disable 0169
		static Delegate GetDecode_Landroid_os_ParcelFileDescriptor_IIHandler ()
		{
			if (cb_decode_Landroid_os_ParcelFileDescriptor_II == null)
				cb_decode_Landroid_os_ParcelFileDescriptor_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Decode_Landroid_os_ParcelFileDescriptor_II);
			return cb_decode_Landroid_os_ParcelFileDescriptor_II;
		}

		static IntPtr n_Decode_Landroid_os_ParcelFileDescriptor_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.FileDescriptorBitmapDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.FileDescriptorBitmapDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelFileDescriptor p0 = global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Landroid_os_ParcelFileDescriptor_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='FileDescriptorBitmapDecoder']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='android.os.ParcelFileDescriptor'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("decode", "(Landroid/os/ParcelFileDescriptor;II)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Landroid_os_ParcelFileDescriptor_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Decode (global::Android.OS.ParcelFileDescriptor p0, int p1, int p2)
		{
			if (id_decode_Landroid_os_ParcelFileDescriptor_II == IntPtr.Zero)
				id_decode_Landroid_os_ParcelFileDescriptor_II = JNIEnv.GetMethodID (class_ref, "decode", "(Landroid/os/ParcelFileDescriptor;II)Lcom/bumptech/glide/load/engine/Resource;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Bumptech.Glide.Load.Engine.IResource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod  (Handle, id_decode_Landroid_os_ParcelFileDescriptor_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Landroid/os/ParcelFileDescriptor;II)Lcom/bumptech/glide/load/engine/Resource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.IResourceDecoder
		global::Com.Bumptech.Glide.Load.Engine.IResource global::Com.Bumptech.Glide.Load.IResourceDecoder.Decode (global::Java.Lang.Object p0, int p1, int p2)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Bumptech.Glide.Load.Engine.IResource>(Decode (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Android.OS.ParcelFileDescriptor>(p0), p1, p2));
		}

	}
}
