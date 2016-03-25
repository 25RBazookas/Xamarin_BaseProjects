using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GifRequestBuilder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/GifRequestBuilder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"ModelType"})]
	public partial class GifRequestBuilder : global::Com.Bumptech.Glide.GenericRequestBuilder, global::Com.Bumptech.Glide.IBitmapOptions, global::Com.Bumptech.Glide.IDrawableOptions {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/GifRequestBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifRequestBuilder); }
		}

		protected GifRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Bumptech.Glide.GifRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CenterCrop ());
		}
#pragma warning restore 0169

		static IntPtr id_centerCrop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GifRequestBuilder']/method[@name='centerCrop' and count(parameter)=0]"
		[Register ("centerCrop", "()Lcom/bumptech/glide/GifRequestBuilder;", "GetCenterCropHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GifRequestBuilder CenterCrop ()
		{
			if (id_centerCrop == IntPtr.Zero)
				id_centerCrop = JNIEnv.GetMethodID (class_ref, "centerCrop", "()Lcom/bumptech/glide/GifRequestBuilder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_centerCrop), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "centerCrop", "()Lcom/bumptech/glide/GifRequestBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_crossFade;
#pragma warning disable 0169
		static Delegate GetCrossFadeHandler ()
		{
			if (cb_crossFade == null)
				cb_crossFade = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CrossFade);
			return cb_crossFade;
		}

		static IntPtr n_CrossFade (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.GifRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CrossFade ());
		}
#pragma warning restore 0169

		static IntPtr id_crossFade;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GifRequestBuilder']/method[@name='crossFade' and count(parameter)=0]"
		[Register ("crossFade", "()Lcom/bumptech/glide/GifRequestBuilder;", "GetCrossFadeHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GifRequestBuilder CrossFade ()
		{
			if (id_crossFade == IntPtr.Zero)
				id_crossFade = JNIEnv.GetMethodID (class_ref, "crossFade", "()Lcom/bumptech/glide/GifRequestBuilder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_crossFade), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "crossFade", "()Lcom/bumptech/glide/GifRequestBuilder;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bumptech.Glide.GifRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.Animation p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CrossFade (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_crossFade_Landroid_view_animation_Animation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GifRequestBuilder']/method[@name='crossFade' and count(parameter)=2 and parameter[1][@type='android.view.animation.Animation'] and parameter[2][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("crossFade", "(Landroid/view/animation/Animation;I)Lcom/bumptech/glide/GifRequestBuilder;", "GetCrossFade_Landroid_view_animation_Animation_IHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GifRequestBuilder CrossFade (global::Android.Views.Animations.Animation p0, int p1)
		{
			if (id_crossFade_Landroid_view_animation_Animation_I == IntPtr.Zero)
				id_crossFade_Landroid_view_animation_Animation_I = JNIEnv.GetMethodID (class_ref, "crossFade", "(Landroid/view/animation/Animation;I)Lcom/bumptech/glide/GifRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Bumptech.Glide.GifRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_crossFade_Landroid_view_animation_Animation_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "crossFade", "(Landroid/view/animation/Animation;I)Lcom/bumptech/glide/GifRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bumptech.Glide.GifRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CrossFade (p0));
		}
#pragma warning restore 0169

		static IntPtr id_crossFade_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GifRequestBuilder']/method[@name='crossFade' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("crossFade", "(I)Lcom/bumptech/glide/GifRequestBuilder;", "GetCrossFade_IHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GifRequestBuilder CrossFade (int p0)
		{
			if (id_crossFade_I == IntPtr.Zero)
				id_crossFade_I = JNIEnv.GetMethodID (class_ref, "crossFade", "(I)Lcom/bumptech/glide/GifRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_crossFade_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "crossFade", "(I)Lcom/bumptech/glide/GifRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bumptech.Glide.GifRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CrossFade (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_crossFade_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GifRequestBuilder']/method[@name='crossFade' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("crossFade", "(II)Lcom/bumptech/glide/GifRequestBuilder;", "GetCrossFade_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GifRequestBuilder CrossFade (int p0, int p1)
		{
			if (id_crossFade_II == IntPtr.Zero)
				id_crossFade_II = JNIEnv.GetMethodID (class_ref, "crossFade", "(II)Lcom/bumptech/glide/GifRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_crossFade_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "crossFade", "(II)Lcom/bumptech/glide/GifRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bumptech.Glide.GifRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FitCenter ());
		}
#pragma warning restore 0169

		static IntPtr id_fitCenter;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GifRequestBuilder']/method[@name='fitCenter' and count(parameter)=0]"
		[Register ("fitCenter", "()Lcom/bumptech/glide/GifRequestBuilder;", "GetFitCenterHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GifRequestBuilder FitCenter ()
		{
			if (id_fitCenter == IntPtr.Zero)
				id_fitCenter = JNIEnv.GetMethodID (class_ref, "fitCenter", "()Lcom/bumptech/glide/GifRequestBuilder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_fitCenter), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fitCenter", "()Lcom/bumptech/glide/GifRequestBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_thumbnail_Lcom_bumptech_glide_GifRequestBuilder_;
#pragma warning disable 0169
		static Delegate GetThumbnail_Lcom_bumptech_glide_GifRequestBuilder_Handler ()
		{
			if (cb_thumbnail_Lcom_bumptech_glide_GifRequestBuilder_ == null)
				cb_thumbnail_Lcom_bumptech_glide_GifRequestBuilder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Thumbnail_Lcom_bumptech_glide_GifRequestBuilder_);
			return cb_thumbnail_Lcom_bumptech_glide_GifRequestBuilder_;
		}

		static IntPtr n_Thumbnail_Lcom_bumptech_glide_GifRequestBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GifRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.GifRequestBuilder p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Thumbnail (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_thumbnail_Lcom_bumptech_glide_GifRequestBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GifRequestBuilder']/method[@name='thumbnail' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.GifRequestBuilder&lt;?&gt;']]"
		[Register ("thumbnail", "(Lcom/bumptech/glide/GifRequestBuilder;)Lcom/bumptech/glide/GifRequestBuilder;", "GetThumbnail_Lcom_bumptech_glide_GifRequestBuilder_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GifRequestBuilder Thumbnail (global::Com.Bumptech.Glide.GifRequestBuilder p0)
		{
			if (id_thumbnail_Lcom_bumptech_glide_GifRequestBuilder_ == IntPtr.Zero)
				id_thumbnail_Lcom_bumptech_glide_GifRequestBuilder_ = JNIEnv.GetMethodID (class_ref, "thumbnail", "(Lcom/bumptech/glide/GifRequestBuilder;)Lcom/bumptech/glide/GifRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GifRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_thumbnail_Lcom_bumptech_glide_GifRequestBuilder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "thumbnail", "(Lcom/bumptech/glide/GifRequestBuilder;)Lcom/bumptech/glide/GifRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_transformFrame_arrayLcom_bumptech_glide_load_Transformation_;
#pragma warning disable 0169
		static Delegate GetTransformFrame_arrayLcom_bumptech_glide_load_Transformation_Handler ()
		{
			if (cb_transformFrame_arrayLcom_bumptech_glide_load_Transformation_ == null)
				cb_transformFrame_arrayLcom_bumptech_glide_load_Transformation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TransformFrame_arrayLcom_bumptech_glide_load_Transformation_);
			return cb_transformFrame_arrayLcom_bumptech_glide_load_Transformation_;
		}

		static IntPtr n_TransformFrame_arrayLcom_bumptech_glide_load_Transformation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GifRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.ITransformation[] p0 = (global::Com.Bumptech.Glide.Load.ITransformation[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bumptech.Glide.Load.ITransformation));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TransformFrame (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transformFrame_arrayLcom_bumptech_glide_load_Transformation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GifRequestBuilder']/method[@name='transformFrame' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.Transformation&lt;android.graphics.Bitmap&gt;...']]"
		[Register ("transformFrame", "([Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/GifRequestBuilder;", "GetTransformFrame_arrayLcom_bumptech_glide_load_Transformation_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GifRequestBuilder TransformFrame (params global:: Com.Bumptech.Glide.Load.ITransformation[] p0)
		{
			if (id_transformFrame_arrayLcom_bumptech_glide_load_Transformation_ == IntPtr.Zero)
				id_transformFrame_arrayLcom_bumptech_glide_load_Transformation_ = JNIEnv.GetMethodID (class_ref, "transformFrame", "([Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/GifRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Bumptech.Glide.GifRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_transformFrame_arrayLcom_bumptech_glide_load_Transformation_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transformFrame", "([Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/GifRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_transformFrame_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_;
#pragma warning disable 0169
		static Delegate GetTransformFrame_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_Handler ()
		{
			if (cb_transformFrame_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_ == null)
				cb_transformFrame_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TransformFrame_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_);
			return cb_transformFrame_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_;
		}

		static IntPtr n_TransformFrame_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GifRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.BitmapTransformation[] p0 = (global::Com.Bumptech.Glide.Load.Resource.Bitmap.BitmapTransformation[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bumptech.Glide.Load.Resource.Bitmap.BitmapTransformation));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TransformFrame (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transformFrame_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GifRequestBuilder']/method[@name='transformFrame' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.resource.bitmap.BitmapTransformation...']]"
		[Register ("transformFrame", "([Lcom/bumptech/glide/load/resource/bitmap/BitmapTransformation;)Lcom/bumptech/glide/GifRequestBuilder;", "GetTransformFrame_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GifRequestBuilder TransformFrame (params global:: Com.Bumptech.Glide.Load.Resource.Bitmap.BitmapTransformation[] p0)
		{
			if (id_transformFrame_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_ == IntPtr.Zero)
				id_transformFrame_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_ = JNIEnv.GetMethodID (class_ref, "transformFrame", "([Lcom/bumptech/glide/load/resource/bitmap/BitmapTransformation;)Lcom/bumptech/glide/GifRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Bumptech.Glide.GifRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_transformFrame_arrayLcom_bumptech_glide_load_resource_bitmap_BitmapTransformation_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GifRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transformFrame", "([Lcom/bumptech/glide/load/resource/bitmap/BitmapTransformation;)Lcom/bumptech/glide/GifRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
