using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']"
	[global::Android.Runtime.Register ("com/bumptech/glide/Glide", DoNotGenerateAcw=true)]
	public partial class Glide : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide.ClearTarget']"
		[global::Android.Runtime.Register ("com/bumptech/glide/Glide$ClearTarget", DoNotGenerateAcw=true)]
		public partial class ClearTarget : global::Com.Bumptech.Glide.Request.Target.ViewTarget {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/Glide$ClearTarget", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ClearTarget); }
			}

			protected ClearTarget (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide.ClearTarget']/constructor[@name='Glide.ClearTarget' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register (".ctor", "(Landroid/view/View;)V", "")]
			public unsafe ClearTarget (global::Android.Views.View p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (ClearTarget)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/View;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/View;)V", __args);
						return;
					}

					if (id_ctor_Landroid_view_View_ == IntPtr.Zero)
						id_ctor_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_View_, __args);
				} finally {
				}
			}

			static Delegate cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_;
#pragma warning disable 0169
			static Delegate GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_Handler ()
			{
				if (cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ == null)
					cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_);
				return cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_;
			}

			static void n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Bumptech.Glide.Glide.ClearTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Glide.ClearTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation p1 = (global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnResourceReady (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide.ClearTarget']/method[@name='onResourceReady' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.bumptech.glide.request.animation.GlideAnimation&lt;? super java.lang.Object&gt;']]"
			[Register ("onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation;)V", "GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_Handler")]
			public override unsafe void OnResourceReady (global::Java.Lang.Object p0, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation p1)
			{
				if (id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ == IntPtr.Zero)
					id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_ = JNIEnv.GetMethodID (class_ref, "onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/animation/GlideAnimation;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/Glide", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Glide); }
		}

		protected Glide (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBitmapPool;
#pragma warning disable 0169
		static Delegate GetGetBitmapPoolHandler ()
		{
			if (cb_getBitmapPool == null)
				cb_getBitmapPool = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitmapPool);
			return cb_getBitmapPool;
		}

		static IntPtr n_GetBitmapPool (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Glide __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Glide> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BitmapPool);
		}
#pragma warning restore 0169

		static IntPtr id_getBitmapPool;
		public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool BitmapPool {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='getBitmapPool' and count(parameter)=0]"
			[Register ("getBitmapPool", "()Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;", "GetGetBitmapPoolHandler")]
			get {
				if (id_getBitmapPool == IntPtr.Zero)
					id_getBitmapPool = JNIEnv.GetMethodID (class_ref, "getBitmapPool", "()Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool> (JNIEnv.CallObjectMethod  (Handle, id_getBitmapPool), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitmapPool", "()Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isSetup;
		[Obsolete (@"deprecated")]
		public static unsafe bool IsSetup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='isSetup' and count(parameter)=0]"
			[Register ("isSetup", "()Z", "GetIsSetupHandler")]
			get {
				if (id_isSetup == IntPtr.Zero)
					id_isSetup = JNIEnv.GetStaticMethodID (class_ref, "isSetup", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSetup);
				} finally {
				}
			}
		}

		static IntPtr id_buildFileDescriptorModelLoader_Ljava_lang_Object_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='buildFileDescriptorModelLoader' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='android.content.Context']]"
		[Register ("buildFileDescriptorModelLoader", "(Ljava/lang/Object;Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoader;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Bumptech.Glide.Load.Model.IModelLoader BuildFileDescriptorModelLoader (global::Java.Lang.Object p0, global::Android.Content.Context p1)
		{
			if (id_buildFileDescriptorModelLoader_Ljava_lang_Object_Landroid_content_Context_ == IntPtr.Zero)
				id_buildFileDescriptorModelLoader_Ljava_lang_Object_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "buildFileDescriptorModelLoader", "(Ljava/lang/Object;Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoader;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Bumptech.Glide.Load.Model.IModelLoader __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildFileDescriptorModelLoader_Ljava_lang_Object_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_buildFileDescriptorModelLoader_Ljava_lang_Class_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='buildFileDescriptorModelLoader' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='android.content.Context']]"
		[Register ("buildFileDescriptorModelLoader", "(Ljava/lang/Class;Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoader;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Bumptech.Glide.Load.Model.IModelLoader BuildFileDescriptorModelLoader (global::Java.Lang.Class p0, global::Android.Content.Context p1)
		{
			if (id_buildFileDescriptorModelLoader_Ljava_lang_Class_Landroid_content_Context_ == IntPtr.Zero)
				id_buildFileDescriptorModelLoader_Ljava_lang_Class_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "buildFileDescriptorModelLoader", "(Ljava/lang/Class;Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoader;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Bumptech.Glide.Load.Model.IModelLoader __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildFileDescriptorModelLoader_Ljava_lang_Class_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buildModelLoader_Ljava_lang_Object_Ljava_lang_Class_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='buildModelLoader' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='java.lang.Class&lt;Y&gt;'] and parameter[3][@type='android.content.Context']]"
		[Register ("buildModelLoader", "(Ljava/lang/Object;Ljava/lang/Class;Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoader;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Y"})]
		public static unsafe global::Com.Bumptech.Glide.Load.Model.IModelLoader BuildModelLoader (global::Java.Lang.Object p0, global::Java.Lang.Class p1, global::Android.Content.Context p2)
		{
			if (id_buildModelLoader_Ljava_lang_Object_Ljava_lang_Class_Landroid_content_Context_ == IntPtr.Zero)
				id_buildModelLoader_Ljava_lang_Object_Ljava_lang_Class_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "buildModelLoader", "(Ljava/lang/Object;Ljava/lang/Class;Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoader;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Bumptech.Glide.Load.Model.IModelLoader __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildModelLoader_Ljava_lang_Object_Ljava_lang_Class_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='buildModelLoader' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Class&lt;Y&gt;'] and parameter[3][@type='android.content.Context']]"
		[Register ("buildModelLoader", "(Ljava/lang/Class;Ljava/lang/Class;Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoader;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Y"})]
		public static unsafe global::Com.Bumptech.Glide.Load.Model.IModelLoader BuildModelLoader (global::Java.Lang.Class p0, global::Java.Lang.Class p1, global::Android.Content.Context p2)
		{
			if (id_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_ == IntPtr.Zero)
				id_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "buildModelLoader", "(Ljava/lang/Class;Ljava/lang/Class;Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoader;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Bumptech.Glide.Load.Model.IModelLoader __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildModelLoader_Ljava_lang_Class_Ljava_lang_Class_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buildStreamModelLoader_Ljava_lang_Object_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='buildStreamModelLoader' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='android.content.Context']]"
		[Register ("buildStreamModelLoader", "(Ljava/lang/Object;Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoader;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Bumptech.Glide.Load.Model.IModelLoader BuildStreamModelLoader (global::Java.Lang.Object p0, global::Android.Content.Context p1)
		{
			if (id_buildStreamModelLoader_Ljava_lang_Object_Landroid_content_Context_ == IntPtr.Zero)
				id_buildStreamModelLoader_Ljava_lang_Object_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "buildStreamModelLoader", "(Ljava/lang/Object;Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoader;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Bumptech.Glide.Load.Model.IModelLoader __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildStreamModelLoader_Ljava_lang_Object_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_buildStreamModelLoader_Ljava_lang_Class_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='buildStreamModelLoader' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='android.content.Context']]"
		[Register ("buildStreamModelLoader", "(Ljava/lang/Class;Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoader;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Bumptech.Glide.Load.Model.IModelLoader BuildStreamModelLoader (global::Java.Lang.Class p0, global::Android.Content.Context p1)
		{
			if (id_buildStreamModelLoader_Ljava_lang_Class_Landroid_content_Context_ == IntPtr.Zero)
				id_buildStreamModelLoader_Ljava_lang_Class_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "buildStreamModelLoader", "(Ljava/lang/Class;Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoader;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Bumptech.Glide.Load.Model.IModelLoader __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildStreamModelLoader_Ljava_lang_Class_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_clear_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='clear' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("clear", "(Landroid/view/View;)V", "")]
		public static unsafe void Clear (global::Android.Views.View p0)
		{
			if (id_clear_Landroid_view_View_ == IntPtr.Zero)
				id_clear_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "clear", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clear_Landroid_view_View_, __args);
			} finally {
			}
		}

		static IntPtr id_clear_Lcom_bumptech_glide_request_FutureTarget_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='clear' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.FutureTarget&lt;?&gt;']]"
		[Register ("clear", "(Lcom/bumptech/glide/request/FutureTarget;)V", "")]
		public static unsafe void Clear (global::Com.Bumptech.Glide.Request.IFutureTarget p0)
		{
			if (id_clear_Lcom_bumptech_glide_request_FutureTarget_ == IntPtr.Zero)
				id_clear_Lcom_bumptech_glide_request_FutureTarget_ = JNIEnv.GetStaticMethodID (class_ref, "clear", "(Lcom/bumptech/glide/request/FutureTarget;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clear_Lcom_bumptech_glide_request_FutureTarget_, __args);
			} finally {
			}
		}

		static IntPtr id_clear_Lcom_bumptech_glide_request_target_Target_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='clear' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.target.Target&lt;?&gt;']]"
		[Register ("clear", "(Lcom/bumptech/glide/request/target/Target;)V", "")]
		public static unsafe void Clear (global::Com.Bumptech.Glide.Request.Target.ITarget p0)
		{
			if (id_clear_Lcom_bumptech_glide_request_target_Target_ == IntPtr.Zero)
				id_clear_Lcom_bumptech_glide_request_target_Target_ = JNIEnv.GetStaticMethodID (class_ref, "clear", "(Lcom/bumptech/glide/request/target/Target;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clear_Lcom_bumptech_glide_request_target_Target_, __args);
			} finally {
			}
		}

		static Delegate cb_clearDiskCache;
#pragma warning disable 0169
		static Delegate GetClearDiskCacheHandler ()
		{
			if (cb_clearDiskCache == null)
				cb_clearDiskCache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearDiskCache);
			return cb_clearDiskCache;
		}

		static void n_ClearDiskCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Glide __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Glide> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearDiskCache ();
		}
#pragma warning restore 0169

		static IntPtr id_clearDiskCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='clearDiskCache' and count(parameter)=0]"
		[Register ("clearDiskCache", "()V", "GetClearDiskCacheHandler")]
		public virtual unsafe void ClearDiskCache ()
		{
			if (id_clearDiskCache == IntPtr.Zero)
				id_clearDiskCache = JNIEnv.GetMethodID (class_ref, "clearDiskCache", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearDiskCache);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearDiskCache", "()V"));
			} finally {
			}
		}

		static Delegate cb_clearMemory;
#pragma warning disable 0169
		static Delegate GetClearMemoryHandler ()
		{
			if (cb_clearMemory == null)
				cb_clearMemory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearMemory);
			return cb_clearMemory;
		}

		static void n_ClearMemory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Glide __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Glide> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearMemory ();
		}
#pragma warning restore 0169

		static IntPtr id_clearMemory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='clearMemory' and count(parameter)=0]"
		[Register ("clearMemory", "()V", "GetClearMemoryHandler")]
		public virtual unsafe void ClearMemory ()
		{
			if (id_clearMemory == IntPtr.Zero)
				id_clearMemory = JNIEnv.GetMethodID (class_ref, "clearMemory", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearMemory);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearMemory", "()V"));
			} finally {
			}
		}

		static IntPtr id_get_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='get' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("get", "(Landroid/content/Context;)Lcom/bumptech/glide/Glide;", "")]
		public static unsafe global::Com.Bumptech.Glide.Glide Get (global::Android.Content.Context p0)
		{
			if (id_get_Landroid_content_Context_ == IntPtr.Zero)
				id_get_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Landroid/content/Context;)Lcom/bumptech/glide/Glide;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Bumptech.Glide.Glide __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Glide> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPhotoCacheDir_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='getPhotoCacheDir' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPhotoCacheDir", "(Landroid/content/Context;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetPhotoCacheDir (global::Android.Content.Context p0)
		{
			if (id_getPhotoCacheDir_Landroid_content_Context_ == IntPtr.Zero)
				id_getPhotoCacheDir_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getPhotoCacheDir", "(Landroid/content/Context;)Ljava/io/File;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPhotoCacheDir_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPhotoCacheDir_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='getPhotoCacheDir' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getPhotoCacheDir", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetPhotoCacheDir (global::Android.Content.Context p0, string p1)
		{
			if (id_getPhotoCacheDir_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getPhotoCacheDir_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getPhotoCacheDir", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPhotoCacheDir_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_preFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_;
#pragma warning disable 0169
		static Delegate GetPreFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_Handler ()
		{
			if (cb_preFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_ == null)
				cb_preFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PreFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_);
			return cb_preFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_;
		}

		static void n_PreFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Glide __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Glide> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder[] p0 = (global::Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder));
			__this.PreFillBitmapPool (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_preFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='preFillBitmapPool' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.prefill.PreFillType.Builder...']]"
		[Register ("preFillBitmapPool", "([Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;)V", "GetPreFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_Handler")]
		public virtual unsafe void PreFillBitmapPool (params global:: Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder[] p0)
		{
			if (id_preFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_ == IntPtr.Zero)
				id_preFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_ = JNIEnv.GetMethodID (class_ref, "preFillBitmapPool", "([Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_preFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "preFillBitmapPool", "([Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler ()
		{
			if (cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ == null)
				cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_);
			return cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;
		}

		static void n_Register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Bumptech.Glide.Glide __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Glide> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory p2 = (global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Register (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='register' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Class&lt;Y&gt;'] and parameter[3][@type='com.bumptech.glide.load.model.ModelLoaderFactory&lt;T, Y&gt;']]"
		[Register ("register", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)V", "GetRegister_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Y"})]
		public virtual unsafe void Register (global::Java.Lang.Class p0, global::Java.Lang.Class p1, global::Com.Bumptech.Glide.Load.Model.IModelLoaderFactory p2)
		{
			if (id_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ == IntPtr.Zero)
				id_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ = JNIEnv.GetMethodID (class_ref, "register", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMemoryCategory_Lcom_bumptech_glide_MemoryCategory_;
#pragma warning disable 0169
		static Delegate GetSetMemoryCategory_Lcom_bumptech_glide_MemoryCategory_Handler ()
		{
			if (cb_setMemoryCategory_Lcom_bumptech_glide_MemoryCategory_ == null)
				cb_setMemoryCategory_Lcom_bumptech_glide_MemoryCategory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMemoryCategory_Lcom_bumptech_glide_MemoryCategory_);
			return cb_setMemoryCategory_Lcom_bumptech_glide_MemoryCategory_;
		}

		static void n_SetMemoryCategory_Lcom_bumptech_glide_MemoryCategory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Glide __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Glide> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.MemoryCategory p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.MemoryCategory> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMemoryCategory (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMemoryCategory_Lcom_bumptech_glide_MemoryCategory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='setMemoryCategory' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.MemoryCategory']]"
		[Register ("setMemoryCategory", "(Lcom/bumptech/glide/MemoryCategory;)V", "GetSetMemoryCategory_Lcom_bumptech_glide_MemoryCategory_Handler")]
		public virtual unsafe void SetMemoryCategory (global::Com.Bumptech.Glide.MemoryCategory p0)
		{
			if (id_setMemoryCategory_Lcom_bumptech_glide_MemoryCategory_ == IntPtr.Zero)
				id_setMemoryCategory_Lcom_bumptech_glide_MemoryCategory_ = JNIEnv.GetMethodID (class_ref, "setMemoryCategory", "(Lcom/bumptech/glide/MemoryCategory;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMemoryCategory_Lcom_bumptech_glide_MemoryCategory_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMemoryCategory", "(Lcom/bumptech/glide/MemoryCategory;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setup_Lcom_bumptech_glide_GlideBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='setup' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.GlideBuilder']]"
		[Obsolete (@"deprecated")]
		[Register ("setup", "(Lcom/bumptech/glide/GlideBuilder;)V", "")]
		public static unsafe void Setup (global::Com.Bumptech.Glide.GlideBuilder p0)
		{
			if (id_setup_Lcom_bumptech_glide_GlideBuilder_ == IntPtr.Zero)
				id_setup_Lcom_bumptech_glide_GlideBuilder_ = JNIEnv.GetStaticMethodID (class_ref, "setup", "(Lcom/bumptech/glide/GlideBuilder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setup_Lcom_bumptech_glide_GlideBuilder_, __args);
			} finally {
			}
		}

		static Delegate cb_trimMemory_I;
#pragma warning disable 0169
		static Delegate GetTrimMemory_IHandler ()
		{
			if (cb_trimMemory_I == null)
				cb_trimMemory_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_TrimMemory_I);
			return cb_trimMemory_I;
		}

		static void n_TrimMemory_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.Glide __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Glide> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrimMemory (p0);
		}
#pragma warning restore 0169

		static IntPtr id_trimMemory_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='trimMemory' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("trimMemory", "(I)V", "GetTrimMemory_IHandler")]
		public virtual unsafe void TrimMemory (int p0)
		{
			if (id_trimMemory_I == IntPtr.Zero)
				id_trimMemory_I = JNIEnv.GetMethodID (class_ref, "trimMemory", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_trimMemory_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trimMemory", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unregister_Ljava_lang_Class_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetUnregister_Ljava_lang_Class_Ljava_lang_Class_Handler ()
		{
			if (cb_unregister_Ljava_lang_Class_Ljava_lang_Class_ == null)
				cb_unregister_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Unregister_Ljava_lang_Class_Ljava_lang_Class_);
			return cb_unregister_Ljava_lang_Class_Ljava_lang_Class_;
		}

		static void n_Unregister_Ljava_lang_Class_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Glide __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Glide> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Unregister (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_unregister_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='unregister' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Class&lt;Y&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("unregister", "(Ljava/lang/Class;Ljava/lang/Class;)V", "GetUnregister_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Y"})]
		public virtual unsafe void Unregister (global::Java.Lang.Class p0, global::Java.Lang.Class p1)
		{
			if (id_unregister_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_unregister_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "unregister", "(Ljava/lang/Class;Ljava/lang/Class;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_unregister_Ljava_lang_Class_Ljava_lang_Class_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregister", "(Ljava/lang/Class;Ljava/lang/Class;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_with_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='with' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("with", "(Landroid/app/Activity;)Lcom/bumptech/glide/RequestManager;", "")]
		public static unsafe global::Com.Bumptech.Glide.RequestManager With (global::Android.App.Activity p0)
		{
			if (id_with_Landroid_app_Activity_ == IntPtr.Zero)
				id_with_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "with", "(Landroid/app/Activity;)Lcom/bumptech/glide/RequestManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Bumptech.Glide.RequestManager __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_with_Landroid_app_Activity_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_with_Landroid_app_Fragment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='with' and count(parameter)=1 and parameter[1][@type='android.app.Fragment']]"
		[Register ("with", "(Landroid/app/Fragment;)Lcom/bumptech/glide/RequestManager;", "")]
		public static unsafe global::Com.Bumptech.Glide.RequestManager With (global::Android.App.Fragment p0)
		{
			if (id_with_Landroid_app_Fragment_ == IntPtr.Zero)
				id_with_Landroid_app_Fragment_ = JNIEnv.GetStaticMethodID (class_ref, "with", "(Landroid/app/Fragment;)Lcom/bumptech/glide/RequestManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Bumptech.Glide.RequestManager __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_with_Landroid_app_Fragment_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_with_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='with' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("with", "(Landroid/content/Context;)Lcom/bumptech/glide/RequestManager;", "")]
		public static unsafe global::Com.Bumptech.Glide.RequestManager With (global::Android.Content.Context p0)
		{
			if (id_with_Landroid_content_Context_ == IntPtr.Zero)
				id_with_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "with", "(Landroid/content/Context;)Lcom/bumptech/glide/RequestManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Bumptech.Glide.RequestManager __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_with_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_with_Landroid_support_v4_app_Fragment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='with' and count(parameter)=1 and parameter[1][@type='android.support.v4.app.Fragment']]"
		[Register ("with", "(Landroid/support/v4/app/Fragment;)Lcom/bumptech/glide/RequestManager;", "")]
		public static unsafe global::Com.Bumptech.Glide.RequestManager With (global::Android.Support.V4.App.Fragment p0)
		{
			if (id_with_Landroid_support_v4_app_Fragment_ == IntPtr.Zero)
				id_with_Landroid_support_v4_app_Fragment_ = JNIEnv.GetStaticMethodID (class_ref, "with", "(Landroid/support/v4/app/Fragment;)Lcom/bumptech/glide/RequestManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Bumptech.Glide.RequestManager __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_with_Landroid_support_v4_app_Fragment_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_with_Landroid_support_v4_app_FragmentActivity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Glide']/method[@name='with' and count(parameter)=1 and parameter[1][@type='android.support.v4.app.FragmentActivity']]"
		[Register ("with", "(Landroid/support/v4/app/FragmentActivity;)Lcom/bumptech/glide/RequestManager;", "")]
		public static unsafe global::Com.Bumptech.Glide.RequestManager With (global::Android.Support.V4.App.FragmentActivity p0)
		{
			if (id_with_Landroid_support_v4_app_FragmentActivity_ == IntPtr.Zero)
				id_with_Landroid_support_v4_app_FragmentActivity_ = JNIEnv.GetStaticMethodID (class_ref, "with", "(Landroid/support/v4/app/FragmentActivity;)Lcom/bumptech/glide/RequestManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Bumptech.Glide.RequestManager __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_with_Landroid_support_v4_app_FragmentActivity_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
