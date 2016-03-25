using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Gif {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawableTransformation']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/gif/GifDrawableTransformation", DoNotGenerateAcw=true)]
	public partial class GifDrawableTransformation : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.ITransformation {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/gif/GifDrawableTransformation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifDrawableTransformation); }
		}

		protected GifDrawableTransformation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawableTransformation']/constructor[@name='GifDrawableTransformation' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.Transformation&lt;android.graphics.Bitmap&gt;'] and parameter[2][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/Transformation;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", "")]
		public unsafe GifDrawableTransformation (global::Com.Bumptech.Glide.Load.ITransformation p0, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (GifDrawableTransformation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/Transformation;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/Transformation;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/Transformation;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_Transformation_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_, __args);
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
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawableTransformation __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawableTransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawableTransformation']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_transform_Lcom_bumptech_glide_load_engine_Resource_II;
#pragma warning disable 0169
		static Delegate GetTransform_Lcom_bumptech_glide_load_engine_Resource_IIHandler ()
		{
			if (cb_transform_Lcom_bumptech_glide_load_engine_Resource_II == null)
				cb_transform_Lcom_bumptech_glide_load_engine_Resource_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Transform_Lcom_bumptech_glide_load_engine_Resource_II);
			return cb_transform_Lcom_bumptech_glide_load_engine_Resource_II;
		}

		static IntPtr n_Transform_Lcom_bumptech_glide_load_engine_Resource_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawableTransformation __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawableTransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p0 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transform (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transform_Lcom_bumptech_glide_load_engine_Resource_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawableTransformation']/method[@name='transform' and count(parameter)=3 and parameter[1][@type='com.bumptech.glide.load.engine.Resource&lt;com.bumptech.glide.load.resource.gif.GifDrawable&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("transform", "(Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;", "GetTransform_Lcom_bumptech_glide_load_engine_Resource_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Transform (global::Com.Bumptech.Glide.Load.Engine.IResource p0, int p1, int p2)
		{
			if (id_transform_Lcom_bumptech_glide_load_engine_Resource_II == IntPtr.Zero)
				id_transform_Lcom_bumptech_glide_load_engine_Resource_II = JNIEnv.GetMethodID (class_ref, "transform", "(Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Bumptech.Glide.Load.Engine.IResource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod  (Handle, id_transform_Lcom_bumptech_glide_load_engine_Resource_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transform", "(Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.ITransformation
		global::Com.Bumptech.Glide.Load.Engine.IResource global::Com.Bumptech.Glide.Load.ITransformation.Transform (global::Com.Bumptech.Glide.Load.Engine.IResource p0, int p1, int p2)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Bumptech.Glide.Load.Engine.IResource>(Transform (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.Bumptech.Glide.Load.Engine.IResource<global::Java.Lang.Object>>(p0), p1, p2));
		}

	}
}
