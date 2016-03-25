using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/GenericRequestBuilder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"ModelType", "DataType", "ResourceType", "TranscodeType"})]
	public partial class GenericRequestBuilder : global::Java.Lang.Object, global::Java.Lang.ICloneable {


		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/field[@name='context']"
		[Register ("context")]
		protected global::Android.Content.Context Context {
			get {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, context_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, context_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr glide_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/field[@name='glide']"
		[Register ("glide")]
		protected global::Com.Bumptech.Glide.Glide Glide {
			get {
				if (glide_jfieldId == IntPtr.Zero)
					glide_jfieldId = JNIEnv.GetFieldID (class_ref, "glide", "Lcom/bumptech/glide/Glide;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, glide_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Glide> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (glide_jfieldId == IntPtr.Zero)
					glide_jfieldId = JNIEnv.GetFieldID (class_ref, "glide", "Lcom/bumptech/glide/Glide;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, glide_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr lifecycle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/field[@name='lifecycle']"
		[Register ("lifecycle")]
		protected global::Com.Bumptech.Glide.Manager.ILifecycle Lifecycle {
			get {
				if (lifecycle_jfieldId == IntPtr.Zero)
					lifecycle_jfieldId = JNIEnv.GetFieldID (class_ref, "lifecycle", "Lcom/bumptech/glide/manager/Lifecycle;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, lifecycle_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.ILifecycle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (lifecycle_jfieldId == IntPtr.Zero)
					lifecycle_jfieldId = JNIEnv.GetFieldID (class_ref, "lifecycle", "Lcom/bumptech/glide/manager/Lifecycle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, lifecycle_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr modelClass_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/field[@name='modelClass']"
		[Register ("modelClass")]
		protected global::Java.Lang.Class ModelClass {
			get {
				if (modelClass_jfieldId == IntPtr.Zero)
					modelClass_jfieldId = JNIEnv.GetFieldID (class_ref, "modelClass", "Ljava/lang/Class;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, modelClass_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (modelClass_jfieldId == IntPtr.Zero)
					modelClass_jfieldId = JNIEnv.GetFieldID (class_ref, "modelClass", "Ljava/lang/Class;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, modelClass_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr requestTracker_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/field[@name='requestTracker']"
		[Register ("requestTracker")]
		protected global::Com.Bumptech.Glide.Manager.RequestTracker RequestTracker {
			get {
				if (requestTracker_jfieldId == IntPtr.Zero)
					requestTracker_jfieldId = JNIEnv.GetFieldID (class_ref, "requestTracker", "Lcom/bumptech/glide/manager/RequestTracker;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, requestTracker_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestTracker> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (requestTracker_jfieldId == IntPtr.Zero)
					requestTracker_jfieldId = JNIEnv.GetFieldID (class_ref, "requestTracker", "Lcom/bumptech/glide/manager/RequestTracker;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, requestTracker_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr transcodeClass_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/field[@name='transcodeClass']"
		[Register ("transcodeClass")]
		protected global::Java.Lang.Class TranscodeClass {
			get {
				if (transcodeClass_jfieldId == IntPtr.Zero)
					transcodeClass_jfieldId = JNIEnv.GetFieldID (class_ref, "transcodeClass", "Ljava/lang/Class;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, transcodeClass_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (transcodeClass_jfieldId == IntPtr.Zero)
					transcodeClass_jfieldId = JNIEnv.GetFieldID (class_ref, "transcodeClass", "Ljava/lang/Class;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, transcodeClass_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/GenericRequestBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericRequestBuilder); }
		}

		protected GenericRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_animate_Landroid_view_animation_Animation_;
#pragma warning disable 0169
		static Delegate GetAnimate_Landroid_view_animation_Animation_Handler ()
		{
			if (cb_animate_Landroid_view_animation_Animation_ == null)
				cb_animate_Landroid_view_animation_Animation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Animate_Landroid_view_animation_Animation_);
			return cb_animate_Landroid_view_animation_Animation_;
		}

		static IntPtr n_Animate_Landroid_view_animation_Animation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.Animation p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Animate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_animate_Landroid_view_animation_Animation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='animate' and count(parameter)=1 and parameter[1][@type='android.view.animation.Animation']]"
		[Obsolete (@"deprecated")]
		[Register ("animate", "(Landroid/view/animation/Animation;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetAnimate_Landroid_view_animation_Animation_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Animate (global::Android.Views.Animations.Animation p0)
		{
			if (id_animate_Landroid_view_animation_Animation_ == IntPtr.Zero)
				id_animate_Landroid_view_animation_Animation_ = JNIEnv.GetMethodID (class_ref, "animate", "(Landroid/view/animation/Animation;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_animate_Landroid_view_animation_Animation_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animate", "(Landroid/view/animation/Animation;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_animate_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_;
#pragma warning disable 0169
		static Delegate GetAnimate_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_Handler ()
		{
			if (cb_animate_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_ == null)
				cb_animate_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Animate_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_);
			return cb_animate_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_;
		}

		static IntPtr n_Animate_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Animation.ViewPropertyAnimation.IAnimator p0 = (global::Com.Bumptech.Glide.Request.Animation.ViewPropertyAnimation.IAnimator)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.ViewPropertyAnimation.IAnimator> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Animate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_animate_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='animate' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.animation.ViewPropertyAnimation.Animator']]"
		[Register ("animate", "(Lcom/bumptech/glide/request/animation/ViewPropertyAnimation$Animator;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetAnimate_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Animate (global::Com.Bumptech.Glide.Request.Animation.ViewPropertyAnimation.IAnimator p0)
		{
			if (id_animate_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_ == IntPtr.Zero)
				id_animate_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_ = JNIEnv.GetMethodID (class_ref, "animate", "(Lcom/bumptech/glide/request/animation/ViewPropertyAnimation$Animator;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_animate_Lcom_bumptech_glide_request_animation_ViewPropertyAnimation_Animator_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animate", "(Lcom/bumptech/glide/request/animation/ViewPropertyAnimation$Animator;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_animate_I;
#pragma warning disable 0169
		static Delegate GetAnimate_IHandler ()
		{
			if (cb_animate_I == null)
				cb_animate_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Animate_I);
			return cb_animate_I;
		}

		static IntPtr n_Animate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Animate (p0));
		}
#pragma warning restore 0169

		static IntPtr id_animate_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='animate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("animate", "(I)Lcom/bumptech/glide/GenericRequestBuilder;", "GetAnimate_IHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Animate (int p0)
		{
			if (id_animate_I == IntPtr.Zero)
				id_animate_I = JNIEnv.GetMethodID (class_ref, "animate", "(I)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_animate_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animate", "(I)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_cacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_;
#pragma warning disable 0169
		static Delegate GetCacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_Handler ()
		{
			if (cb_cacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ == null)
				cb_cacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_);
			return cb_cacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_;
		}

		static IntPtr n_CacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IResourceDecoder p0 = (global::Com.Bumptech.Glide.Load.IResourceDecoder)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceDecoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CacheDecoder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_cacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='cacheDecoder' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.ResourceDecoder&lt;java.io.File, ResourceType&gt;']]"
		[Register ("cacheDecoder", "(Lcom/bumptech/glide/load/ResourceDecoder;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetCacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder CacheDecoder (global::Com.Bumptech.Glide.Load.IResourceDecoder p0)
		{
			if (id_cacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ == IntPtr.Zero)
				id_cacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_ = JNIEnv.GetMethodID (class_ref, "cacheDecoder", "(Lcom/bumptech/glide/load/ResourceDecoder;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_cacheDecoder_Lcom_bumptech_glide_load_ResourceDecoder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cacheDecoder", "(Lcom/bumptech/glide/load/ResourceDecoder;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/bumptech/glide/GenericRequestBuilder;", "GetCloneHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/bumptech/glide/GenericRequestBuilder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lcom/bumptech/glide/GenericRequestBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_decoder_Lcom_bumptech_glide_load_ResourceDecoder_;
#pragma warning disable 0169
		static Delegate GetDecoder_Lcom_bumptech_glide_load_ResourceDecoder_Handler ()
		{
			if (cb_decoder_Lcom_bumptech_glide_load_ResourceDecoder_ == null)
				cb_decoder_Lcom_bumptech_glide_load_ResourceDecoder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decoder_Lcom_bumptech_glide_load_ResourceDecoder_);
			return cb_decoder_Lcom_bumptech_glide_load_ResourceDecoder_;
		}

		static IntPtr n_Decoder_Lcom_bumptech_glide_load_ResourceDecoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IResourceDecoder p0 = (global::Com.Bumptech.Glide.Load.IResourceDecoder)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceDecoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decoder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decoder_Lcom_bumptech_glide_load_ResourceDecoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='decoder' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.ResourceDecoder&lt;DataType, ResourceType&gt;']]"
		[Register ("decoder", "(Lcom/bumptech/glide/load/ResourceDecoder;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetDecoder_Lcom_bumptech_glide_load_ResourceDecoder_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Decoder (global::Com.Bumptech.Glide.Load.IResourceDecoder p0)
		{
			if (id_decoder_Lcom_bumptech_glide_load_ResourceDecoder_ == IntPtr.Zero)
				id_decoder_Lcom_bumptech_glide_load_ResourceDecoder_ = JNIEnv.GetMethodID (class_ref, "decoder", "(Lcom/bumptech/glide/load/ResourceDecoder;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_decoder_Lcom_bumptech_glide_load_ResourceDecoder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decoder", "(Lcom/bumptech/glide/load/ResourceDecoder;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_diskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_;
#pragma warning disable 0169
		static Delegate GetDiskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_Handler ()
		{
			if (cb_diskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_ == null)
				cb_diskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DiskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_);
			return cb_diskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_;
		}

		static IntPtr n_DiskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DiskCacheStrategy (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_diskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='diskCacheStrategy' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.DiskCacheStrategy']]"
		[Register ("diskCacheStrategy", "(Lcom/bumptech/glide/load/engine/DiskCacheStrategy;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetDiskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder DiskCacheStrategy (global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy p0)
		{
			if (id_diskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_ == IntPtr.Zero)
				id_diskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_ = JNIEnv.GetMethodID (class_ref, "diskCacheStrategy", "(Lcom/bumptech/glide/load/engine/DiskCacheStrategy;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_diskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "diskCacheStrategy", "(Lcom/bumptech/glide/load/engine/DiskCacheStrategy;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_dontAnimate;
#pragma warning disable 0169
		static Delegate GetDontAnimateHandler ()
		{
			if (cb_dontAnimate == null)
				cb_dontAnimate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DontAnimate);
			return cb_dontAnimate;
		}

		static IntPtr n_DontAnimate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DontAnimate ());
		}
#pragma warning restore 0169

		static IntPtr id_dontAnimate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='dontAnimate' and count(parameter)=0]"
		[Register ("dontAnimate", "()Lcom/bumptech/glide/GenericRequestBuilder;", "GetDontAnimateHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder DontAnimate ()
		{
			if (id_dontAnimate == IntPtr.Zero)
				id_dontAnimate = JNIEnv.GetMethodID (class_ref, "dontAnimate", "()Lcom/bumptech/glide/GenericRequestBuilder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_dontAnimate), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dontAnimate", "()Lcom/bumptech/glide/GenericRequestBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dontTransform;
#pragma warning disable 0169
		static Delegate GetDontTransformHandler ()
		{
			if (cb_dontTransform == null)
				cb_dontTransform = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DontTransform);
			return cb_dontTransform;
		}

		static IntPtr n_DontTransform (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DontTransform ());
		}
#pragma warning restore 0169

		static IntPtr id_dontTransform;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='dontTransform' and count(parameter)=0]"
		[Register ("dontTransform", "()Lcom/bumptech/glide/GenericRequestBuilder;", "GetDontTransformHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder DontTransform ()
		{
			if (id_dontTransform == IntPtr.Zero)
				id_dontTransform = JNIEnv.GetMethodID (class_ref, "dontTransform", "()Lcom/bumptech/glide/GenericRequestBuilder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_dontTransform), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dontTransform", "()Lcom/bumptech/glide/GenericRequestBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_encoder_Lcom_bumptech_glide_load_ResourceEncoder_;
#pragma warning disable 0169
		static Delegate GetEncoder_Lcom_bumptech_glide_load_ResourceEncoder_Handler ()
		{
			if (cb_encoder_Lcom_bumptech_glide_load_ResourceEncoder_ == null)
				cb_encoder_Lcom_bumptech_glide_load_ResourceEncoder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encoder_Lcom_bumptech_glide_load_ResourceEncoder_);
			return cb_encoder_Lcom_bumptech_glide_load_ResourceEncoder_;
		}

		static IntPtr n_Encoder_Lcom_bumptech_glide_load_ResourceEncoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IResourceEncoder p0 = (global::Com.Bumptech.Glide.Load.IResourceEncoder)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encoder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encoder_Lcom_bumptech_glide_load_ResourceEncoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='encoder' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.ResourceEncoder&lt;ResourceType&gt;']]"
		[Register ("encoder", "(Lcom/bumptech/glide/load/ResourceEncoder;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetEncoder_Lcom_bumptech_glide_load_ResourceEncoder_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Encoder (global::Com.Bumptech.Glide.Load.IResourceEncoder p0)
		{
			if (id_encoder_Lcom_bumptech_glide_load_ResourceEncoder_ == IntPtr.Zero)
				id_encoder_Lcom_bumptech_glide_load_ResourceEncoder_ = JNIEnv.GetMethodID (class_ref, "encoder", "(Lcom/bumptech/glide/load/ResourceEncoder;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_encoder_Lcom_bumptech_glide_load_ResourceEncoder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encoder", "(Lcom/bumptech/glide/load/ResourceEncoder;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_error_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetError_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_error_Landroid_graphics_drawable_Drawable_ == null)
				cb_error_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Error_Landroid_graphics_drawable_Drawable_);
			return cb_error_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_Error_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Error (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_error_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='error' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("error", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetError_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Error (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_error_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_error_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "error", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_error_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "error", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_error_I;
#pragma warning disable 0169
		static Delegate GetError_IHandler ()
		{
			if (cb_error_I == null)
				cb_error_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Error_I);
			return cb_error_I;
		}

		static IntPtr n_Error_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Error (p0));
		}
#pragma warning restore 0169

		static IntPtr id_error_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='error' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("error", "(I)Lcom/bumptech/glide/GenericRequestBuilder;", "GetError_IHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Error (int p0)
		{
			if (id_error_I == IntPtr.Zero)
				id_error_I = JNIEnv.GetMethodID (class_ref, "error", "(I)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_error_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "error", "(I)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fallback_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetFallback_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_fallback_Landroid_graphics_drawable_Drawable_ == null)
				cb_fallback_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Fallback_Landroid_graphics_drawable_Drawable_);
			return cb_fallback_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_Fallback_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Fallback (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_fallback_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='fallback' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("fallback", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetFallback_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Fallback (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_fallback_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_fallback_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "fallback", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_fallback_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fallback", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_fallback_I;
#pragma warning disable 0169
		static Delegate GetFallback_IHandler ()
		{
			if (cb_fallback_I == null)
				cb_fallback_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Fallback_I);
			return cb_fallback_I;
		}

		static IntPtr n_Fallback_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Fallback (p0));
		}
#pragma warning restore 0169

		static IntPtr id_fallback_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='fallback' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fallback", "(I)Lcom/bumptech/glide/GenericRequestBuilder;", "GetFallback_IHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Fallback (int p0)
		{
			if (id_fallback_I == IntPtr.Zero)
				id_fallback_I = JNIEnv.GetMethodID (class_ref, "fallback", "(I)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_fallback_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fallback", "(I)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_into_Lcom_bumptech_glide_request_target_Target_;
#pragma warning disable 0169
		static Delegate GetInto_Lcom_bumptech_glide_request_target_Target_Handler ()
		{
			if (cb_into_Lcom_bumptech_glide_request_target_Target_ == null)
				cb_into_Lcom_bumptech_glide_request_target_Target_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Into_Lcom_bumptech_glide_request_target_Target_);
			return cb_into_Lcom_bumptech_glide_request_target_Target_;
		}

		static IntPtr n_Into_Lcom_bumptech_glide_request_target_Target_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Into (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_into_Lcom_bumptech_glide_request_target_Target_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='into' and count(parameter)=1 and parameter[1][@type='Y']]"
		[Register ("into", "(Lcom/bumptech/glide/request/target/Target;)Lcom/bumptech/glide/request/target/Target;", "GetInto_Lcom_bumptech_glide_request_target_Target_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Y extends com.bumptech.glide.request.target.Target<TranscodeType>"})]
		public virtual unsafe global::Java.Lang.Object Into (global::Java.Lang.Object p0)
		{
			if (id_into_Lcom_bumptech_glide_request_target_Target_ == IntPtr.Zero)
				id_into_Lcom_bumptech_glide_request_target_Target_ = JNIEnv.GetMethodID (class_ref, "into", "(Lcom/bumptech/glide/request/target/Target;)Lcom/bumptech/glide/request/target/Target;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_into_Lcom_bumptech_glide_request_target_Target_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "into", "(Lcom/bumptech/glide/request/target/Target;)Lcom/bumptech/glide/request/target/Target;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_into_Landroid_widget_ImageView_;
#pragma warning disable 0169
		static Delegate GetInto_Landroid_widget_ImageView_Handler ()
		{
			if (cb_into_Landroid_widget_ImageView_ == null)
				cb_into_Landroid_widget_ImageView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Into_Landroid_widget_ImageView_);
			return cb_into_Landroid_widget_ImageView_;
		}

		static IntPtr n_Into_Landroid_widget_ImageView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Into (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_into_Landroid_widget_ImageView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='into' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register ("into", "(Landroid/widget/ImageView;)Lcom/bumptech/glide/request/target/Target;", "GetInto_Landroid_widget_ImageView_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.Request.Target.ITarget Into (global::Android.Widget.ImageView p0)
		{
			if (id_into_Landroid_widget_ImageView_ == IntPtr.Zero)
				id_into_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "into", "(Landroid/widget/ImageView;)Lcom/bumptech/glide/request/target/Target;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.Request.Target.ITarget __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (JNIEnv.CallObjectMethod  (Handle, id_into_Landroid_widget_ImageView_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "into", "(Landroid/widget/ImageView;)Lcom/bumptech/glide/request/target/Target;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_into_II;
#pragma warning disable 0169
		static Delegate GetInto_IIHandler ()
		{
			if (cb_into_II == null)
				cb_into_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_Into_II);
			return cb_into_II;
		}

		static IntPtr n_Into_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Into (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_into_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='into' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("into", "(II)Lcom/bumptech/glide/request/FutureTarget;", "GetInto_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Request.IFutureTarget Into (int p0, int p1)
		{
			if (id_into_II == IntPtr.Zero)
				id_into_II = JNIEnv.GetMethodID (class_ref, "into", "(II)Lcom/bumptech/glide/request/FutureTarget;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (JNIEnv.CallObjectMethod  (Handle, id_into_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "into", "(II)Lcom/bumptech/glide/request/FutureTarget;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_listener_Lcom_bumptech_glide_request_RequestListener_;
#pragma warning disable 0169
		static Delegate GetListener_Lcom_bumptech_glide_request_RequestListener_Handler ()
		{
			if (cb_listener_Lcom_bumptech_glide_request_RequestListener_ == null)
				cb_listener_Lcom_bumptech_glide_request_RequestListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Listener_Lcom_bumptech_glide_request_RequestListener_);
			return cb_listener_Lcom_bumptech_glide_request_RequestListener_;
		}

		static IntPtr n_Listener_Lcom_bumptech_glide_request_RequestListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.IRequestListener p0 = (global::Com.Bumptech.Glide.Request.IRequestListener)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IRequestListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Listener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_listener_Lcom_bumptech_glide_request_RequestListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='listener' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.RequestListener&lt;? super ModelType, TranscodeType&gt;']]"
		[Register ("listener", "(Lcom/bumptech/glide/request/RequestListener;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetListener_Lcom_bumptech_glide_request_RequestListener_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Listener (global::Com.Bumptech.Glide.Request.IRequestListener p0)
		{
			if (id_listener_Lcom_bumptech_glide_request_RequestListener_ == IntPtr.Zero)
				id_listener_Lcom_bumptech_glide_request_RequestListener_ = JNIEnv.GetMethodID (class_ref, "listener", "(Lcom/bumptech/glide/request/RequestListener;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_listener_Lcom_bumptech_glide_request_RequestListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listener", "(Lcom/bumptech/glide/request/RequestListener;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_load_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_lang_Object_Handler ()
		{
			if (cb_load_Ljava_lang_Object_ == null)
				cb_load_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_Ljava_lang_Object_);
			return cb_load_Ljava_lang_Object_;
		}

		static IntPtr n_Load_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_load_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='load' and count(parameter)=1 and parameter[1][@type='ModelType']]"
		[Register ("load", "(Ljava/lang/Object;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetLoad_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Load (global::Java.Lang.Object p0)
		{
			if (id_load_Ljava_lang_Object_ == IntPtr.Zero)
				id_load_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/lang/Object;)Lcom/bumptech/glide/GenericRequestBuilder;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_load_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "(Ljava/lang/Object;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_override_II;
#pragma warning disable 0169
		static Delegate GetOverride_IIHandler ()
		{
			if (cb_override_II == null)
				cb_override_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_Override_II);
			return cb_override_II;
		}

		static IntPtr n_Override_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Override (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_override_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='override' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("override", "(II)Lcom/bumptech/glide/GenericRequestBuilder;", "GetOverride_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Override (int p0, int p1)
		{
			if (id_override_II == IntPtr.Zero)
				id_override_II = JNIEnv.GetMethodID (class_ref, "override", "(II)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_override_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "override", "(II)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_placeholder_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetPlaceholder_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_placeholder_Landroid_graphics_drawable_Drawable_ == null)
				cb_placeholder_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Placeholder_Landroid_graphics_drawable_Drawable_);
			return cb_placeholder_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_Placeholder_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Placeholder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_placeholder_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='placeholder' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("placeholder", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetPlaceholder_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Placeholder (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_placeholder_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_placeholder_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "placeholder", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_placeholder_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "placeholder", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_placeholder_I;
#pragma warning disable 0169
		static Delegate GetPlaceholder_IHandler ()
		{
			if (cb_placeholder_I == null)
				cb_placeholder_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Placeholder_I);
			return cb_placeholder_I;
		}

		static IntPtr n_Placeholder_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Placeholder (p0));
		}
#pragma warning restore 0169

		static IntPtr id_placeholder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='placeholder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("placeholder", "(I)Lcom/bumptech/glide/GenericRequestBuilder;", "GetPlaceholder_IHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Placeholder (int p0)
		{
			if (id_placeholder_I == IntPtr.Zero)
				id_placeholder_I = JNIEnv.GetMethodID (class_ref, "placeholder", "(I)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_placeholder_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "placeholder", "(I)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_preload;
#pragma warning disable 0169
		static Delegate GetPreloadHandler ()
		{
			if (cb_preload == null)
				cb_preload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Preload);
			return cb_preload;
		}

		static IntPtr n_Preload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Preload ());
		}
#pragma warning restore 0169

		static IntPtr id_preload;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='preload' and count(parameter)=0]"
		[Register ("preload", "()Lcom/bumptech/glide/request/target/Target;", "GetPreloadHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Request.Target.ITarget Preload ()
		{
			if (id_preload == IntPtr.Zero)
				id_preload = JNIEnv.GetMethodID (class_ref, "preload", "()Lcom/bumptech/glide/request/target/Target;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (JNIEnv.CallObjectMethod  (Handle, id_preload), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "preload", "()Lcom/bumptech/glide/request/target/Target;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_preload_II;
#pragma warning disable 0169
		static Delegate GetPreload_IIHandler ()
		{
			if (cb_preload_II == null)
				cb_preload_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_Preload_II);
			return cb_preload_II;
		}

		static IntPtr n_Preload_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Preload (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_preload_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='preload' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("preload", "(II)Lcom/bumptech/glide/request/target/Target;", "GetPreload_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Request.Target.ITarget Preload (int p0, int p1)
		{
			if (id_preload_II == IntPtr.Zero)
				id_preload_II = JNIEnv.GetMethodID (class_ref, "preload", "(II)Lcom/bumptech/glide/request/target/Target;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (JNIEnv.CallObjectMethod  (Handle, id_preload_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "preload", "(II)Lcom/bumptech/glide/request/target/Target;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_priority_Lcom_bumptech_glide_Priority_;
#pragma warning disable 0169
		static Delegate GetPriority_Lcom_bumptech_glide_Priority_Handler ()
		{
			if (cb_priority_Lcom_bumptech_glide_Priority_ == null)
				cb_priority_Lcom_bumptech_glide_Priority_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Priority_Lcom_bumptech_glide_Priority_);
			return cb_priority_Lcom_bumptech_glide_Priority_;
		}

		static IntPtr n_Priority_Lcom_bumptech_glide_Priority_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Priority p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Priority> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Priority (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_priority_Lcom_bumptech_glide_Priority_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='priority' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.Priority']]"
		[Register ("priority", "(Lcom/bumptech/glide/Priority;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetPriority_Lcom_bumptech_glide_Priority_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Priority (global::Com.Bumptech.Glide.Priority p0)
		{
			if (id_priority_Lcom_bumptech_glide_Priority_ == IntPtr.Zero)
				id_priority_Lcom_bumptech_glide_Priority_ = JNIEnv.GetMethodID (class_ref, "priority", "(Lcom/bumptech/glide/Priority;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_priority_Lcom_bumptech_glide_Priority_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "priority", "(Lcom/bumptech/glide/Priority;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_signature_Lcom_bumptech_glide_load_Key_;
#pragma warning disable 0169
		static Delegate GetSignature_Lcom_bumptech_glide_load_Key_Handler ()
		{
			if (cb_signature_Lcom_bumptech_glide_load_Key_ == null)
				cb_signature_Lcom_bumptech_glide_load_Key_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Signature_Lcom_bumptech_glide_load_Key_);
			return cb_signature_Lcom_bumptech_glide_load_Key_;
		}

		static IntPtr n_Signature_Lcom_bumptech_glide_load_Key_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IKey p0 = (global::Com.Bumptech.Glide.Load.IKey)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Signature (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_signature_Lcom_bumptech_glide_load_Key_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='signature' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.Key']]"
		[Register ("signature", "(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetSignature_Lcom_bumptech_glide_load_Key_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Signature (global::Com.Bumptech.Glide.Load.IKey p0)
		{
			if (id_signature_Lcom_bumptech_glide_load_Key_ == IntPtr.Zero)
				id_signature_Lcom_bumptech_glide_load_Key_ = JNIEnv.GetMethodID (class_ref, "signature", "(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_signature_Lcom_bumptech_glide_load_Key_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "signature", "(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_sizeMultiplier_F;
#pragma warning disable 0169
		static Delegate GetSizeMultiplier_FHandler ()
		{
			if (cb_sizeMultiplier_F == null)
				cb_sizeMultiplier_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SizeMultiplier_F);
			return cb_sizeMultiplier_F;
		}

		static IntPtr n_SizeMultiplier_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SizeMultiplier (p0));
		}
#pragma warning restore 0169

		static IntPtr id_sizeMultiplier_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='sizeMultiplier' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("sizeMultiplier", "(F)Lcom/bumptech/glide/GenericRequestBuilder;", "GetSizeMultiplier_FHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder SizeMultiplier (float p0)
		{
			if (id_sizeMultiplier_F == IntPtr.Zero)
				id_sizeMultiplier_F = JNIEnv.GetMethodID (class_ref, "sizeMultiplier", "(F)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_sizeMultiplier_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sizeMultiplier", "(F)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skipMemoryCache_Z;
#pragma warning disable 0169
		static Delegate GetSkipMemoryCache_ZHandler ()
		{
			if (cb_skipMemoryCache_Z == null)
				cb_skipMemoryCache_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SkipMemoryCache_Z);
			return cb_skipMemoryCache_Z;
		}

		static IntPtr n_SkipMemoryCache_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkipMemoryCache (p0));
		}
#pragma warning restore 0169

		static IntPtr id_skipMemoryCache_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='skipMemoryCache' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("skipMemoryCache", "(Z)Lcom/bumptech/glide/GenericRequestBuilder;", "GetSkipMemoryCache_ZHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder SkipMemoryCache (bool p0)
		{
			if (id_skipMemoryCache_Z == IntPtr.Zero)
				id_skipMemoryCache_Z = JNIEnv.GetMethodID (class_ref, "skipMemoryCache", "(Z)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_skipMemoryCache_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skipMemoryCache", "(Z)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sourceEncoder_Lcom_bumptech_glide_load_Encoder_;
#pragma warning disable 0169
		static Delegate GetSourceEncoder_Lcom_bumptech_glide_load_Encoder_Handler ()
		{
			if (cb_sourceEncoder_Lcom_bumptech_glide_load_Encoder_ == null)
				cb_sourceEncoder_Lcom_bumptech_glide_load_Encoder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SourceEncoder_Lcom_bumptech_glide_load_Encoder_);
			return cb_sourceEncoder_Lcom_bumptech_glide_load_Encoder_;
		}

		static IntPtr n_SourceEncoder_Lcom_bumptech_glide_load_Encoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.IEncoder p0 = (global::Com.Bumptech.Glide.Load.IEncoder)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SourceEncoder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sourceEncoder_Lcom_bumptech_glide_load_Encoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='sourceEncoder' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.Encoder&lt;DataType&gt;']]"
		[Register ("sourceEncoder", "(Lcom/bumptech/glide/load/Encoder;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetSourceEncoder_Lcom_bumptech_glide_load_Encoder_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder SourceEncoder (global::Com.Bumptech.Glide.Load.IEncoder p0)
		{
			if (id_sourceEncoder_Lcom_bumptech_glide_load_Encoder_ == IntPtr.Zero)
				id_sourceEncoder_Lcom_bumptech_glide_load_Encoder_ = JNIEnv.GetMethodID (class_ref, "sourceEncoder", "(Lcom/bumptech/glide/load/Encoder;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_sourceEncoder_Lcom_bumptech_glide_load_Encoder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sourceEncoder", "(Lcom/bumptech/glide/load/Encoder;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_thumbnail_Lcom_bumptech_glide_GenericRequestBuilder_;
#pragma warning disable 0169
		static Delegate GetThumbnail_Lcom_bumptech_glide_GenericRequestBuilder_Handler ()
		{
			if (cb_thumbnail_Lcom_bumptech_glide_GenericRequestBuilder_ == null)
				cb_thumbnail_Lcom_bumptech_glide_GenericRequestBuilder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Thumbnail_Lcom_bumptech_glide_GenericRequestBuilder_);
			return cb_thumbnail_Lcom_bumptech_glide_GenericRequestBuilder_;
		}

		static IntPtr n_Thumbnail_Lcom_bumptech_glide_GenericRequestBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.GenericRequestBuilder p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Thumbnail (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_thumbnail_Lcom_bumptech_glide_GenericRequestBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='thumbnail' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.GenericRequestBuilder&lt;?, ?, ?, TranscodeType&gt;']]"
		[Register ("thumbnail", "(Lcom/bumptech/glide/GenericRequestBuilder;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetThumbnail_Lcom_bumptech_glide_GenericRequestBuilder_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Thumbnail (global::Com.Bumptech.Glide.GenericRequestBuilder p0)
		{
			if (id_thumbnail_Lcom_bumptech_glide_GenericRequestBuilder_ == IntPtr.Zero)
				id_thumbnail_Lcom_bumptech_glide_GenericRequestBuilder_ = JNIEnv.GetMethodID (class_ref, "thumbnail", "(Lcom/bumptech/glide/GenericRequestBuilder;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_thumbnail_Lcom_bumptech_glide_GenericRequestBuilder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "thumbnail", "(Lcom/bumptech/glide/GenericRequestBuilder;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_thumbnail_F;
#pragma warning disable 0169
		static Delegate GetThumbnail_FHandler ()
		{
			if (cb_thumbnail_F == null)
				cb_thumbnail_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Thumbnail_F);
			return cb_thumbnail_F;
		}

		static IntPtr n_Thumbnail_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Thumbnail (p0));
		}
#pragma warning restore 0169

		static IntPtr id_thumbnail_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='thumbnail' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("thumbnail", "(F)Lcom/bumptech/glide/GenericRequestBuilder;", "GetThumbnail_FHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Thumbnail (float p0)
		{
			if (id_thumbnail_F == IntPtr.Zero)
				id_thumbnail_F = JNIEnv.GetMethodID (class_ref, "thumbnail", "(F)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_thumbnail_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "thumbnail", "(F)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_transcoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_;
#pragma warning disable 0169
		static Delegate GetTranscoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Handler ()
		{
			if (cb_transcoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ == null)
				cb_transcoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transcoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_);
			return cb_transcoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_;
		}

		static IntPtr n_Transcoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder p0 = (global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transcoder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transcoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='transcoder' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.resource.transcode.ResourceTranscoder&lt;ResourceType, TranscodeType&gt;']]"
		[Register ("transcoder", "(Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetTranscoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Transcoder (global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder p0)
		{
			if (id_transcoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ == IntPtr.Zero)
				id_transcoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ = JNIEnv.GetMethodID (class_ref, "transcoder", "(Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)Lcom/bumptech/glide/GenericRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_transcoder_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transcoder", "(Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_transform_arrayLcom_bumptech_glide_load_Transformation_;
#pragma warning disable 0169
		static Delegate GetTransform_arrayLcom_bumptech_glide_load_Transformation_Handler ()
		{
			if (cb_transform_arrayLcom_bumptech_glide_load_Transformation_ == null)
				cb_transform_arrayLcom_bumptech_glide_load_Transformation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transform_arrayLcom_bumptech_glide_load_Transformation_);
			return cb_transform_arrayLcom_bumptech_glide_load_Transformation_;
		}

		static IntPtr n_Transform_arrayLcom_bumptech_glide_load_Transformation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.GenericRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.ITransformation[] p0 = (global::Com.Bumptech.Glide.Load.ITransformation[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bumptech.Glide.Load.ITransformation));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transform (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transform_arrayLcom_bumptech_glide_load_Transformation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='GenericRequestBuilder']/method[@name='transform' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.Transformation&lt;ResourceType&gt;...']]"
		[Register ("transform", "([Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetTransform_arrayLcom_bumptech_glide_load_Transformation_Handler")]
		public virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder Transform (params global:: Com.Bumptech.Glide.Load.ITransformation[] p0)
		{
			if (id_transform_arrayLcom_bumptech_glide_load_Transformation_ == IntPtr.Zero)
				id_transform_arrayLcom_bumptech_glide_load_Transformation_ = JNIEnv.GetMethodID (class_ref, "transform", "([Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/GenericRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_transform_arrayLcom_bumptech_glide_load_Transformation_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transform", "([Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
