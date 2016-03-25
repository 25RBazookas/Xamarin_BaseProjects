using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Bitmap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='BitmapEncoder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/BitmapEncoder", DoNotGenerateAcw=true)]
	public partial class BitmapEncoder : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.IResourceEncoder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/BitmapEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapEncoder); }
		}

		protected BitmapEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='BitmapEncoder']/constructor[@name='BitmapEncoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BitmapEncoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BitmapEncoder)) {
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

		static IntPtr id_ctor_Landroid_graphics_Bitmap_CompressFormat_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='BitmapEncoder']/constructor[@name='BitmapEncoder' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap.CompressFormat'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap$CompressFormat;I)V", "")]
		public unsafe BitmapEncoder (global::Android.Graphics.Bitmap.CompressFormat p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (BitmapEncoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/Bitmap$CompressFormat;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/Bitmap$CompressFormat;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_Bitmap_CompressFormat_I == IntPtr.Zero)
					id_ctor_Landroid_graphics_Bitmap_CompressFormat_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap$CompressFormat;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_CompressFormat_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_CompressFormat_I, __args);
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
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.BitmapEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.BitmapEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='BitmapEncoder']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_Handler ()
		{
			if (cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_ == null)
				cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_);
			return cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_;
		}

		static bool n_Encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.BitmapEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.BitmapEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p0 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Encode (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='BitmapEncoder']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.engine.Resource&lt;android.graphics.Bitmap&gt;'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("encode", "(Lcom/bumptech/glide/load/engine/Resource;Ljava/io/OutputStream;)Z", "GetEncode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_Handler")]
		public virtual unsafe bool Encode (global::Com.Bumptech.Glide.Load.Engine.IResource p0, global::System.IO.Stream p1)
		{
			if (id_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(Lcom/bumptech/glide/load/engine/Resource;Ljava/io/OutputStream;)Z");
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_OutputStream_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Lcom/bumptech/glide/load/engine/Resource;Ljava/io/OutputStream;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
