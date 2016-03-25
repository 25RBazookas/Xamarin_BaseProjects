using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Target {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ViewTarget']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/target/ViewTarget", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends android.view.View", "Z"})]
	public abstract partial class ViewTarget : global::Com.Bumptech.Glide.Request.Target.BaseTarget {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ViewTarget.SizeDeterminer']"
		[global::Android.Runtime.Register ("com/bumptech/glide/request/target/ViewTarget$SizeDeterminer", DoNotGenerateAcw=true)]
		public partial class SizeDeterminer : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ViewTarget.SizeDeterminer.SizeDeterminerLayoutListener']"
			[global::Android.Runtime.Register ("com/bumptech/glide/request/target/ViewTarget$SizeDeterminer$SizeDeterminerLayoutListener", DoNotGenerateAcw=true)]
			public partial class SizeDeterminerLayoutListener : global::Java.Lang.Object, global::Android.Views.ViewTreeObserver.IOnPreDrawListener {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/bumptech/glide/request/target/ViewTarget$SizeDeterminer$SizeDeterminerLayoutListener", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (SizeDeterminerLayoutListener); }
				}

				protected SizeDeterminerLayoutListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor_Lcom_bumptech_glide_request_target_ViewTarget_SizeDeterminer_;
				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ViewTarget.SizeDeterminer.SizeDeterminerLayoutListener']/constructor[@name='ViewTarget.SizeDeterminer.SizeDeterminerLayoutListener' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.target.ViewTarget.SizeDeterminer']]"
				[Register (".ctor", "(Lcom/bumptech/glide/request/target/ViewTarget$SizeDeterminer;)V", "")]
				public unsafe SizeDeterminerLayoutListener (global::Com.Bumptech.Glide.Request.Target.ViewTarget.SizeDeterminer p0)
					: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (Handle != IntPtr.Zero)
						return;

					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (p0);
						if (GetType () != typeof (SizeDeterminerLayoutListener)) {
							SetHandle (
									global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/request/target/ViewTarget$SizeDeterminer;)V", __args),
									JniHandleOwnership.TransferLocalRef);
							global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/request/target/ViewTarget$SizeDeterminer;)V", __args);
							return;
						}

						if (id_ctor_Lcom_bumptech_glide_request_target_ViewTarget_SizeDeterminer_ == IntPtr.Zero)
							id_ctor_Lcom_bumptech_glide_request_target_ViewTarget_SizeDeterminer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/request/target/ViewTarget$SizeDeterminer;)V");
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_request_target_ViewTarget_SizeDeterminer_, __args),
								JniHandleOwnership.TransferLocalRef);
						JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_request_target_ViewTarget_SizeDeterminer_, __args);
					} finally {
					}
				}

				static Delegate cb_onPreDraw;
#pragma warning disable 0169
				static Delegate GetOnPreDrawHandler ()
				{
					if (cb_onPreDraw == null)
						cb_onPreDraw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnPreDraw);
					return cb_onPreDraw;
				}

				static bool n_OnPreDraw (IntPtr jnienv, IntPtr native__this)
				{
					global::Com.Bumptech.Glide.Request.Target.ViewTarget.SizeDeterminer.SizeDeterminerLayoutListener __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ViewTarget.SizeDeterminer.SizeDeterminerLayoutListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.OnPreDraw ();
				}
#pragma warning restore 0169

				static IntPtr id_onPreDraw;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ViewTarget.SizeDeterminer.SizeDeterminerLayoutListener']/method[@name='onPreDraw' and count(parameter)=0]"
				[Register ("onPreDraw", "()Z", "GetOnPreDrawHandler")]
				public virtual unsafe bool OnPreDraw ()
				{
					if (id_onPreDraw == IntPtr.Zero)
						id_onPreDraw = JNIEnv.GetMethodID (class_ref, "onPreDraw", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod  (Handle, id_onPreDraw);
						else
							return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPreDraw", "()Z"));
					} finally {
					}
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/request/target/ViewTarget$SizeDeterminer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SizeDeterminer); }
			}

			protected SizeDeterminer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ViewTarget.SizeDeterminer']/constructor[@name='ViewTarget.SizeDeterminer' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register (".ctor", "(Landroid/view/View;)V", "")]
			public unsafe SizeDeterminer (global::Android.Views.View p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (SizeDeterminer)) {
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
				global::Com.Bumptech.Glide.Request.Target.ViewTarget.SizeDeterminer __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ViewTarget.SizeDeterminer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback p0 = (global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.GetSize (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ViewTarget.SizeDeterminer']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.target.SizeReadyCallback']]"
			[Register ("getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler")]
			public virtual unsafe void GetSize (global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback p0)
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

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/target/ViewTarget", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewTarget); }
		}

		protected ViewTarget (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ViewTarget']/constructor[@name='ViewTarget' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe ViewTarget (global::Java.Lang.Object p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (ViewTarget)) {
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
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.Target.ViewTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ViewTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		static IntPtr id_getView;
		public virtual unsafe global::Java.Lang.Object View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ViewTarget']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getView), JniHandleOwnership.TransferLocalRef);
					else
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

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
			global::Com.Bumptech.Glide.Request.Target.ViewTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ViewTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback p0 = (global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ViewTarget']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.request.target.SizeReadyCallback']]"
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

		static IntPtr id_setTagId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ViewTarget']/method[@name='setTagId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTagId", "(I)V", "")]
		public static unsafe void SetTagId (int p0)
		{
			if (id_setTagId_I == IntPtr.Zero)
				id_setTagId_I = JNIEnv.GetStaticMethodID (class_ref, "setTagId", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setTagId_I, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/request/target/ViewTarget", DoNotGenerateAcw=true)]
	internal partial class ViewTargetInvoker : ViewTarget {

		public ViewTargetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewTargetInvoker); }
		}

	}

}
