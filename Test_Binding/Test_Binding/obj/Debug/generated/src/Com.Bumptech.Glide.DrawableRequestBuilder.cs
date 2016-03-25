using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='DrawableRequestBuilder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/DrawableRequestBuilder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"ModelType"})]
	public partial class DrawableRequestBuilder : global::Com.Bumptech.Glide.GenericRequestBuilder, global::Com.Bumptech.Glide.IBitmapOptions, global::Com.Bumptech.Glide.IDrawableOptions {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/DrawableRequestBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawableRequestBuilder); }
		}

		protected DrawableRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_bitmapTransform_arrayLcom_bumptech_glide_load_Transformation_;
#pragma warning disable 0169
		static Delegate GetBitmapTransform_arrayLcom_bumptech_glide_load_Transformation_Handler ()
		{
			if (cb_bitmapTransform_arrayLcom_bumptech_glide_load_Transformation_ == null)
				cb_bitmapTransform_arrayLcom_bumptech_glide_load_Transformation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BitmapTransform_arrayLcom_bumptech_glide_load_Transformation_);
			return cb_bitmapTransform_arrayLcom_bumptech_glide_load_Transformation_;
		}

		static IntPtr n_BitmapTransform_arrayLcom_bumptech_glide_load_Transformation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.DrawableRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.ITransformation[] p0 = (global::Com.Bumptech.Glide.Load.ITransformation[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bumptech.Glide.Load.ITransformation));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BitmapTransform (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_bitmapTransform_arrayLcom_bumptech_glide_load_Transformation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='DrawableRequestBuilder']/method[@name='bitmapTransform' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.Transformation&lt;android.graphics.Bitmap&gt;...']]"
		[Register ("bitmapTransform", "([Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/DrawableRequestBuilder;", "GetBitmapTransform_arrayLcom_bumptech_glide_load_Transformation_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableRequestBuilder BitmapTransform (params global:: Com.Bumptech.Glide.Load.ITransformation[] p0)
		{
			if (id_bitmapTransform_arrayLcom_bumptech_glide_load_Transformation_ == IntPtr.Zero)
				id_bitmapTransform_arrayLcom_bumptech_glide_load_Transformation_ = JNIEnv.GetMethodID (class_ref, "bitmapTransform", "([Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/DrawableRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Bumptech.Glide.DrawableRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_bitmapTransform_arrayLcom_bumptech_glide_load_Transformation_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bitmapTransform", "([Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/DrawableRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_centerCrop;
#pragma warning disable 0169
		static Delegate GetCenterCropHandler ()
		{
			if (cb_centerCrop == null)
				cb_centerCrop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CenterCrop);
			return cb_centerCrop;
		}

		static IntPtr n_CenterCrop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.DrawableRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CenterCrop ());
		}
#pragma warning restore 0169

		static IntPtr id_centerCrop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='DrawableRequestBuilder']/method[@name='centerCrop' and count(parameter)=0]"
		[Register ("centerCrop", "()Lcom/bumptech/glide/DrawableRequestBuilder;", "GetCenterCropHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableRequestBuilder CenterCrop ()
		{
			if (id_centerCrop == IntPtr.Zero)
				id_centerCrop = JNIEnv.GetMethodID (class_ref, "centerCrop", "()Lcom/bumptech/glide/DrawableRequestBuilder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_centerCrop), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "centerCrop", "()Lcom/bumptech/glide/DrawableRequestBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_crossFade;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='DrawableRequestBuilder']/method[@name='crossFade' and count(parameter)=0]"
		[Register ("crossFade", "()Lcom/bumptech/glide/DrawableRequestBuilder;", "")]
		public unsafe global::Com.Bumptech.Glide.DrawableRequestBuilder CrossFade ()
		{
			if (id_crossFade == IntPtr.Zero)
				id_crossFade = JNIEnv.GetMethodID (class_ref, "crossFade", "()Lcom/bumptech/glide/DrawableRequestBuilder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_crossFade), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_crossFade_Landroid_view_animation_Animation_I;
#pragma warning disable 0169
		static Delegate GetCrossFade_Landroid_view_animation_Animation_IHandler ()
		{
			if (cb_crossFade_Landroid_view_animation_Animation_I == null)
				cb_crossFade_Landroid_view_animation_Animation_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_CrossFade_Landroid_view_animation_Animation_I);
			return cb_crossFade_Landroid_view_animation_Animation_I;
		}

		static IntPtr n_CrossFade_Landroid_view_animation_Animation_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Bumptech.Glide.DrawableRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.Animation p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CrossFade (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_crossFade_Landroid_view_animation_Animation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='DrawableRequestBuilder']/method[@name='crossFade' and count(parameter)=2 and parameter[1][@type='android.view.animation.Animation'] and parameter[2][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("crossFade", "(Landroid/view/animation/Animation;I)Lcom/bumptech/glide/DrawableRequestBuilder;", "GetCrossFade_Landroid_view_animation_Animation_IHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableRequestBuilder CrossFade (global::Android.Views.Animations.Animation p0, int p1)
		{
			if (id_crossFade_Landroid_view_animation_Animation_I == IntPtr.Zero)
				id_crossFade_Landroid_view_animation_Animation_I = JNIEnv.GetMethodID (class_ref, "crossFade", "(Landroid/view/animation/Animation;I)Lcom/bumptech/glide/DrawableRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Bumptech.Glide.DrawableRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_crossFade_Landroid_view_animation_Animation_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "crossFade", "(Landroid/view/animation/Animation;I)Lcom/bumptech/glide/DrawableRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_crossFade_I;
#pragma warning disable 0169
		static Delegate GetCrossFade_IHandler ()
		{
			if (cb_crossFade_I == null)
				cb_crossFade_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_CrossFade_I);
			return cb_crossFade_I;
		}

		static IntPtr n_CrossFade_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.DrawableRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CrossFade (p0));
		}
#pragma warning restore 0169

		static IntPtr id_crossFade_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='DrawableRequestBuilder']/method[@name='crossFade' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("crossFade", "(I)Lcom/bumptech/glide/DrawableRequestBuilder;", "GetCrossFade_IHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableRequestBuilder CrossFade (int p0)
		{
			if (id_crossFade_I == IntPtr.Zero)
				id_crossFade_I = JNIEnv.GetMethodID (class_ref, "crossFade", "(I)Lcom/bumptech/glide/DrawableRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_crossFade_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "crossFade", "(I)Lcom/bumptech/glide/DrawableRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_crossFade_II;
#pragma warning disable 0169
		static Delegate GetCrossFade_IIHandler ()
		{
			if (cb_crossFade_II == null)
				cb_crossFade_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_CrossFade_II);
			return cb_crossFade_II;
		}

		static IntPtr n_CrossFade_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Bumptech.Glide.DrawableRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CrossFade (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_crossFade_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='DrawableRequestBuilder']/method[@name='crossFade' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("crossFade", "(II)Lcom/bumptech/glide/DrawableRequestBuilder;", "GetCrossFade_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableRequestBuilder CrossFade (int p0, int p1)
		{
			if (id_crossFade_II == IntPtr.Zero)
				id_crossFade_II = JNIEnv.GetMethodID (class_ref, "crossFade", "(II)Lcom/bumptech/glide/DrawableRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_crossFade_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "crossFade", "(II)Lcom/bumptech/glide/DrawableRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fitCenter;
#pragma warning disable 0169
		static Delegate GetFitCenterHandler ()
		{
			if (cb_fitCenter == null)
				cb_fitCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FitCenter);
			return cb_fitCenter;
		}

		static IntPtr n_FitCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.DrawableRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FitCenter ());
		}
#pragma warning restore 0169

		static IntPtr id_fitCenter;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='DrawableRequestBuilder']/method[@name='fitCenter' and count(parameter)=0]"
		[Register ("fitCenter", "()Lcom/bumptech/glide/DrawableRequestBuilder;", "GetFitCenterHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableRequestBuilder FitCenter ()
		{
			if (id_fitCenter == IntPtr.Zero)
				id_fitCenter = JNIEnv.GetMethodID (class_ref, "fitCenter", "()Lcom/bumptech/glide/DrawableRequestBuilder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_fitCenter), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fitCenter", "()Lcom/bumptech/glide/DrawableRequestBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_thumbnail_Lcom_bumptech_glide_DrawableRequestBuilder_;
#pragma warning disable 0169
		static Delegate GetThumbnail_Lcom_bumptech_glide_DrawableRequestBuilder_Handler ()
		{
			if (cb_thumbnail_Lcom_bumptech_glide_DrawableRequestBuilder_ == null)
				cb_thumbnail_Lcom_bumptech_glide_DrawableRequestBuilder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Thumbnail_Lcom_bumptech_glide_DrawableRequestBuilder_);
			return cb_thumbnail_Lcom_bumptech_glide_DrawableRequestBuilder_;
		}

		static IntPtr n_Thumbnail_Lcom_bumptech_glide_DrawableRequestBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.DrawableRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.DrawableRequestBuilder p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Thumbnail (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_thumbnail_Lcom_bumptech_glide_DrawableRequestBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='DrawableRequestBuilder']/method[@name='thumbnail' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.DrawableRequestBuilder&lt;?&gt;']]"
		[Register ("thumbnail", "(Lcom/bumptech/glide/DrawableRequestBuilder;)Lcom/bumptech/glide/DrawableRequestBuilder;", "GetThumbnail_Lcom_bumptech_glide_DrawableRequestBuilder_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableRequestBuilder Thumbnail (global::Com.Bumptech.Glide.DrawableRequestBuilder p0)
		{
			if (id_thumbnail_Lcom_bumptech_glide_DrawableRequestBuilder_ == IntPtr.Zero)
				id_thumbnail_Lcom_bumptech_glide_DrawableRequestBuilder_ = JNIEnv.GetMethodID (class_ref, "thumbnail", "(Lcom/bumptech/glide/DrawableRequestBuilder;)Lcom/bumptech/glide/DrawableRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.DrawableRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_thumbnail_Lcom_bumptech_glide_DrawableRequestBuilder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "thumbnail", "(Lcom/bumptech/glide/DrawableRequestBuilder;)Lcom/bumptech/glide/DrawableRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_transform_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_;
#pragma warning disable 0169
		static Delegate GetTransform_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_Handler ()
		{
			if (cb_transform_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_ == null)
				cb_transform_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transform_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_);
			return cb_transform_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_;
		}

		static IntPtr n_Transform_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.DrawableRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.BitmapTransformation[] p0 = (global::Com.Bumptech.Glide.Load.Resource.Bitmap.BitmapTransformation[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bumptech.Glide.Load.Resource.Bitmap.BitmapTransformation));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transform (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transform_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='DrawableRequestBuilder']/method[@name='transform' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.resource.bitmap.BitmapTransformation...']]"
		[Register ("transform", "([Lcom/bumptech/glide/load/resource/bitmap/BitmapTransformation;)Lcom/bumptech/glide/DrawableRequestBuilder;", "GetTransform_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.DrawableRequestBuilder Transform (params global:: Com.Bumptech.Glide.Load.Resource.Bitmap.BitmapTransformation[] p0)
		{
			if (id_transform_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_ == IntPtr.Zero)
				id_transform_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_ = JNIEnv.GetMethodID (class_ref, "transform", "([Lcom/bumptech/glide/load/resource/bitmap/BitmapTransformation;)Lcom/bumptech/glide/DrawableRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Bumptech.Glide.DrawableRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_transform_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.DrawableRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transform", "([Lcom/bumptech/glide/load/resource/bitmap/BitmapTransformation;)Lcom/bumptech/glide/DrawableRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
