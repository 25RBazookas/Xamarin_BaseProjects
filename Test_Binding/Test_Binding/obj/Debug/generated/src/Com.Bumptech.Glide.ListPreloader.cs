using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='ListPreloader']"
	[global::Android.Runtime.Register ("com/bumptech/glide/ListPreloader", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class ListPreloader : global::Java.Lang.Object, global::Android.Widget.AbsListView.IOnScrollListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide']/interface[@name='ListPreloader.PreloadModelProvider']"
		[Register ("com/bumptech/glide/ListPreloader$PreloadModelProvider", "", "Com.Bumptech.Glide.ListPreloader/IPreloadModelProviderInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public partial interface IPreloadModelProvider : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/interface[@name='ListPreloader.PreloadModelProvider']/method[@name='getPreloadItems' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getPreloadItems", "(I)Ljava/util/List;", "GetGetPreloadItems_IHandler:Com.Bumptech.Glide.ListPreloader/IPreloadModelProviderInvoker, Test_Binding")]
			global::System.Collections.IList GetPreloadItems (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/interface[@name='ListPreloader.PreloadModelProvider']/method[@name='getPreloadRequestBuilder' and count(parameter)=1 and parameter[1][@type='U']]"
			[Register ("getPreloadRequestBuilder", "(Ljava/lang/Object;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetGetPreloadRequestBuilder_Ljava_lang_Object_Handler:Com.Bumptech.Glide.ListPreloader/IPreloadModelProviderInvoker, Test_Binding")]
			global::Com.Bumptech.Glide.GenericRequestBuilder GetPreloadRequestBuilder (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/bumptech/glide/ListPreloader$PreloadModelProvider", DoNotGenerateAcw=true)]
		internal class IPreloadModelProviderInvoker : global::Java.Lang.Object, IPreloadModelProvider {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/ListPreloader$PreloadModelProvider");
			IntPtr class_ref;

			public static IPreloadModelProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPreloadModelProvider> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.ListPreloader.PreloadModelProvider"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPreloadModelProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IPreloadModelProviderInvoker); }
			}

			static Delegate cb_getPreloadItems_I;
#pragma warning disable 0169
			static Delegate GetGetPreloadItems_IHandler ()
			{
				if (cb_getPreloadItems_I == null)
					cb_getPreloadItems_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPreloadItems_I);
				return cb_getPreloadItems_I;
			}

			static IntPtr n_GetPreloadItems_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Bumptech.Glide.ListPreloader.IPreloadModelProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.ListPreloader.IPreloadModelProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.GetPreloadItems (p0));
			}
#pragma warning restore 0169

			IntPtr id_getPreloadItems_I;
			public unsafe global::System.Collections.IList GetPreloadItems (int p0)
			{
				if (id_getPreloadItems_I == IntPtr.Zero)
					id_getPreloadItems_I = JNIEnv.GetMethodID (class_ref, "getPreloadItems", "(I)Ljava/util/List;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getPreloadItems_I, __args), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_getPreloadRequestBuilder_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetGetPreloadRequestBuilder_Ljava_lang_Object_Handler ()
			{
				if (cb_getPreloadRequestBuilder_Ljava_lang_Object_ == null)
					cb_getPreloadRequestBuilder_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPreloadRequestBuilder_Ljava_lang_Object_);
				return cb_getPreloadRequestBuilder_Ljava_lang_Object_;
			}

			static IntPtr n_GetPreloadRequestBuilder_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.ListPreloader.IPreloadModelProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.ListPreloader.IPreloadModelProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPreloadRequestBuilder (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getPreloadRequestBuilder_Ljava_lang_Object_;
			public unsafe global::Com.Bumptech.Glide.GenericRequestBuilder GetPreloadRequestBuilder (global::Java.Lang.Object p0)
			{
				if (id_getPreloadRequestBuilder_Ljava_lang_Object_ == IntPtr.Zero)
					id_getPreloadRequestBuilder_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getPreloadRequestBuilder", "(Ljava/lang/Object;)Lcom/bumptech/glide/GenericRequestBuilder;");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Bumptech.Glide.GenericRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod (Handle, id_getPreloadRequestBuilder_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide']/interface[@name='ListPreloader.PreloadSizeProvider']"
		[Register ("com/bumptech/glide/ListPreloader$PreloadSizeProvider", "", "Com.Bumptech.Glide.ListPreloader/IPreloadSizeProviderInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial interface IPreloadSizeProvider : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/interface[@name='ListPreloader.PreloadSizeProvider']/method[@name='getPreloadSize' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("getPreloadSize", "(Ljava/lang/Object;II)[I", "GetGetPreloadSize_Ljava_lang_Object_IIHandler:Com.Bumptech.Glide.ListPreloader/IPreloadSizeProviderInvoker, Test_Binding")]
			int[] GetPreloadSize (global::Java.Lang.Object p0, int p1, int p2);

		}

		[global::Android.Runtime.Register ("com/bumptech/glide/ListPreloader$PreloadSizeProvider", DoNotGenerateAcw=true)]
		internal class IPreloadSizeProviderInvoker : global::Java.Lang.Object, IPreloadSizeProvider {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/ListPreloader$PreloadSizeProvider");
			IntPtr class_ref;

			public static IPreloadSizeProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPreloadSizeProvider> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.ListPreloader.PreloadSizeProvider"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPreloadSizeProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IPreloadSizeProviderInvoker); }
			}

			static Delegate cb_getPreloadSize_Ljava_lang_Object_II;
#pragma warning disable 0169
			static Delegate GetGetPreloadSize_Ljava_lang_Object_IIHandler ()
			{
				if (cb_getPreloadSize_Ljava_lang_Object_II == null)
					cb_getPreloadSize_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetPreloadSize_Ljava_lang_Object_II);
				return cb_getPreloadSize_Ljava_lang_Object_II;
			}

			static IntPtr n_GetPreloadSize_Ljava_lang_Object_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				global::Com.Bumptech.Glide.ListPreloader.IPreloadSizeProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.ListPreloader.IPreloadSizeProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewArray (__this.GetPreloadSize (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getPreloadSize_Ljava_lang_Object_II;
			public unsafe int[] GetPreloadSize (global::Java.Lang.Object p0, int p1, int p2)
			{
				if (id_getPreloadSize_Ljava_lang_Object_II == IntPtr.Zero)
					id_getPreloadSize_Ljava_lang_Object_II = JNIEnv.GetMethodID (class_ref, "getPreloadSize", "(Ljava/lang/Object;II)[I");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getPreloadSize_Ljava_lang_Object_II, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='ListPreloader.PreloadTarget']"
		[global::Android.Runtime.Register ("com/bumptech/glide/ListPreloader$PreloadTarget", DoNotGenerateAcw=true)]
		public partial class PreloadTarget : global::Com.Bumptech.Glide.Request.Target.BaseTarget {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/ListPreloader$PreloadTarget", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PreloadTarget); }
			}

			protected PreloadTarget (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
#pragma warning disable 0169
			static Delegate GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler ()
			{
				if (cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == null)
					cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_);
				return cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
			}

			static void n_GetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.ListPreloader.PreloadTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.ListPreloader.PreloadTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback p0 = (global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.GetSize (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='ListPreloader.PreloadTarget']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.target.SizeReadyCallback']]"
			[Register ("getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler")]
			public override unsafe void GetSize (global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback p0)
			{
				if (id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == IntPtr.Zero)
					id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNIEnv.GetMethodID (class_ref, "getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V"), __args);
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
				global::Com.Bumptech.Glide.ListPreloader.PreloadTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.ListPreloader.PreloadTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation p1 = (global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnResourceReady (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_animation_GlideAnimation_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='ListPreloader.PreloadTarget']/method[@name='onResourceReady' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.bumptech.glide.request.animation.GlideAnimation&lt;? super java.lang.Object&gt;']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='ListPreloader.PreloadTargetQueue']"
		[global::Android.Runtime.Register ("com/bumptech/glide/ListPreloader$PreloadTargetQueue", DoNotGenerateAcw=true)]
		public sealed partial class PreloadTargetQueue : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/ListPreloader$PreloadTargetQueue", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PreloadTargetQueue); }
			}

			internal PreloadTargetQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide']/class[@name='ListPreloader.PreloadTargetQueue']/constructor[@name='ListPreloader.PreloadTargetQueue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register (".ctor", "(I)V", "")]
			public unsafe PreloadTargetQueue (int p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (PreloadTargetQueue)) {
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/ListPreloader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ListPreloader); }
		}

		protected ListPreloader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide']/class[@name='ListPreloader']/constructor[@name='ListPreloader' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe ListPreloader (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ListPreloader)) {
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

		static IntPtr id_ctor_Lcom_bumptech_glide_ListPreloader_PreloadModelProvider_Lcom_bumptech_glide_ListPreloader_PreloadSizeProvider_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide']/class[@name='ListPreloader']/constructor[@name='ListPreloader' and count(parameter)=3 and parameter[1][@type='com.bumptech.glide.ListPreloader.PreloadModelProvider&lt;T&gt;'] and parameter[2][@type='com.bumptech.glide.ListPreloader.PreloadSizeProvider&lt;T&gt;'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lcom/bumptech/glide/ListPreloader$PreloadModelProvider;Lcom/bumptech/glide/ListPreloader$PreloadSizeProvider;I)V", "")]
		public unsafe ListPreloader (global::Com.Bumptech.Glide.ListPreloader.IPreloadModelProvider p0, global::Com.Bumptech.Glide.ListPreloader.IPreloadSizeProvider p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (ListPreloader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/ListPreloader$PreloadModelProvider;Lcom/bumptech/glide/ListPreloader$PreloadSizeProvider;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/ListPreloader$PreloadModelProvider;Lcom/bumptech/glide/ListPreloader$PreloadSizeProvider;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_ListPreloader_PreloadModelProvider_Lcom_bumptech_glide_ListPreloader_PreloadSizeProvider_I == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_ListPreloader_PreloadModelProvider_Lcom_bumptech_glide_ListPreloader_PreloadSizeProvider_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/ListPreloader$PreloadModelProvider;Lcom/bumptech/glide/ListPreloader$PreloadSizeProvider;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_ListPreloader_PreloadModelProvider_Lcom_bumptech_glide_ListPreloader_PreloadSizeProvider_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_ListPreloader_PreloadModelProvider_Lcom_bumptech_glide_ListPreloader_PreloadSizeProvider_I, __args);
			} finally {
			}
		}

		static Delegate cb_getDimensions_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetDimensions_Ljava_lang_Object_Handler ()
		{
			if (cb_getDimensions_Ljava_lang_Object_ == null)
				cb_getDimensions_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDimensions_Ljava_lang_Object_);
			return cb_getDimensions_Ljava_lang_Object_;
		}

		static IntPtr n_GetDimensions_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.ListPreloader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.ListPreloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetDimensions (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDimensions_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='ListPreloader']/method[@name='getDimensions' and count(parameter)=1 and parameter[1][@type='T']]"
		[Obsolete (@"deprecated")]
		[Register ("getDimensions", "(Ljava/lang/Object;)[I", "GetGetDimensions_Ljava_lang_Object_Handler")]
		protected virtual unsafe int[] GetDimensions (global::Java.Lang.Object p0)
		{
			if (id_getDimensions_Ljava_lang_Object_ == IntPtr.Zero)
				id_getDimensions_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getDimensions", "(Ljava/lang/Object;)[I");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int[] __ret;
				if (GetType () == ThresholdType)
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getDimensions_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDimensions", "(Ljava/lang/Object;)[I"), __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getItems_II;
#pragma warning disable 0169
		static Delegate GetGetItems_IIHandler ()
		{
			if (cb_getItems_II == null)
				cb_getItems_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_GetItems_II);
			return cb_getItems_II;
		}

		static IntPtr n_GetItems_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Bumptech.Glide.ListPreloader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.ListPreloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.GetItems (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_getItems_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='ListPreloader']/method[@name='getItems' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("getItems", "(II)Ljava/util/List;", "GetGetItems_IIHandler")]
		protected virtual unsafe global::System.Collections.IList GetItems (int p0, int p1)
		{
			if (id_getItems_II == IntPtr.Zero)
				id_getItems_II = JNIEnv.GetMethodID (class_ref, "getItems", "(II)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getItems_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItems", "(II)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRequestBuilder_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetRequestBuilder_Ljava_lang_Object_Handler ()
		{
			if (cb_getRequestBuilder_Ljava_lang_Object_ == null)
				cb_getRequestBuilder_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRequestBuilder_Ljava_lang_Object_);
			return cb_getRequestBuilder_Ljava_lang_Object_;
		}

		static IntPtr n_GetRequestBuilder_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.ListPreloader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.ListPreloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRequestBuilder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestBuilder_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='ListPreloader']/method[@name='getRequestBuilder' and count(parameter)=1 and parameter[1][@type='T']]"
		[Obsolete (@"deprecated")]
		[Register ("getRequestBuilder", "(Ljava/lang/Object;)Lcom/bumptech/glide/GenericRequestBuilder;", "GetGetRequestBuilder_Ljava_lang_Object_Handler")]
		protected virtual unsafe global::Com.Bumptech.Glide.GenericRequestBuilder GetRequestBuilder (global::Java.Lang.Object p0)
		{
			if (id_getRequestBuilder_Ljava_lang_Object_ == IntPtr.Zero)
				id_getRequestBuilder_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getRequestBuilder", "(Ljava/lang/Object;)Lcom/bumptech/glide/GenericRequestBuilder;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Bumptech.Glide.GenericRequestBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallObjectMethod  (Handle, id_getRequestBuilder_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.GenericRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestBuilder", "(Ljava/lang/Object;)Lcom/bumptech/glide/GenericRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onScroll_Landroid_widget_AbsListView_III;
#pragma warning disable 0169
		static Delegate GetOnScroll_Landroid_widget_AbsListView_IIIHandler ()
		{
			if (cb_onScroll_Landroid_widget_AbsListView_III == null)
				cb_onScroll_Landroid_widget_AbsListView_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnScroll_Landroid_widget_AbsListView_III);
			return cb_onScroll_Landroid_widget_AbsListView_III;
		}

		static void n_OnScroll_Landroid_widget_AbsListView_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::Com.Bumptech.Glide.ListPreloader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.ListPreloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScroll (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onScroll_Landroid_widget_AbsListView_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='ListPreloader']/method[@name='onScroll' and count(parameter)=4 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onScroll", "(Landroid/widget/AbsListView;III)V", "GetOnScroll_Landroid_widget_AbsListView_IIIHandler")]
		public virtual unsafe void OnScroll (global::Android.Widget.AbsListView p0, int p1, int p2, int p3)
		{
			if (id_onScroll_Landroid_widget_AbsListView_III == IntPtr.Zero)
				id_onScroll_Landroid_widget_AbsListView_III = JNIEnv.GetMethodID (class_ref, "onScroll", "(Landroid/widget/AbsListView;III)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onScroll_Landroid_widget_AbsListView_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScroll", "(Landroid/widget/AbsListView;III)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
#pragma warning disable 0169
		static Delegate GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler ()
		{
			if (cb_onScrollStateChanged_Landroid_widget_AbsListView_I == null)
				cb_onScrollStateChanged_Landroid_widget_AbsListView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnScrollStateChanged_Landroid_widget_AbsListView_I);
			return cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
		}

		static void n_OnScrollStateChanged_Landroid_widget_AbsListView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Bumptech.Glide.ListPreloader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.ListPreloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ScrollState p1 = (global::Android.Widget.ScrollState) native_p1;
			__this.OnScrollStateChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onScrollStateChanged_Landroid_widget_AbsListView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='ListPreloader']/method[@name='onScrollStateChanged' and count(parameter)=2 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int']]"
		[Register ("onScrollStateChanged", "(Landroid/widget/AbsListView;I)V", "GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler")]
		public virtual unsafe void OnScrollStateChanged (global::Android.Widget.AbsListView p0, [global::Android.Runtime.GeneratedEnum] global::Android.Widget.ScrollState p1)
		{
			if (id_onScrollStateChanged_Landroid_widget_AbsListView_I == IntPtr.Zero)
				id_onScrollStateChanged_Landroid_widget_AbsListView_I = JNIEnv.GetMethodID (class_ref, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onScrollStateChanged_Landroid_widget_AbsListView_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V"), __args);
			} finally {
			}
		}

	}
}
