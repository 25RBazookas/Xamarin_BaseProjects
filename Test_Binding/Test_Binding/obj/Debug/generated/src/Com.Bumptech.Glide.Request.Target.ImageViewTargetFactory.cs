using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Target {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ImageViewTargetFactory']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/target/ImageViewTargetFactory", DoNotGenerateAcw=true)]
	public partial class ImageViewTargetFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/target/ImageViewTargetFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageViewTargetFactory); }
		}

		protected ImageViewTargetFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ImageViewTargetFactory']/constructor[@name='ImageViewTargetFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageViewTargetFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImageViewTargetFactory)) {
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

		static Delegate cb_buildTarget_Landroid_widget_ImageView_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetBuildTarget_Landroid_widget_ImageView_Ljava_lang_Class_Handler ()
		{
			if (cb_buildTarget_Landroid_widget_ImageView_Ljava_lang_Class_ == null)
				cb_buildTarget_Landroid_widget_ImageView_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildTarget_Landroid_widget_ImageView_Ljava_lang_Class_);
			return cb_buildTarget_Landroid_widget_ImageView_Ljava_lang_Class_;
		}

		static IntPtr n_BuildTarget_Landroid_widget_ImageView_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Request.Target.ImageViewTargetFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ImageViewTargetFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildTarget (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildTarget_Landroid_widget_ImageView_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ImageViewTargetFactory']/method[@name='buildTarget' and count(parameter)=2 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='java.lang.Class&lt;Z&gt;']]"
		[Register ("buildTarget", "(Landroid/widget/ImageView;Ljava/lang/Class;)Lcom/bumptech/glide/request/target/Target;", "GetBuildTarget_Landroid_widget_ImageView_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Z"})]
		public virtual unsafe global::Com.Bumptech.Glide.Request.Target.ITarget BuildTarget (global::Android.Widget.ImageView p0, global::Java.Lang.Class p1)
		{
			if (id_buildTarget_Landroid_widget_ImageView_Ljava_lang_Class_ == IntPtr.Zero)
				id_buildTarget_Landroid_widget_ImageView_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "buildTarget", "(Landroid/widget/ImageView;Ljava/lang/Class;)Lcom/bumptech/glide/request/target/Target;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Bumptech.Glide.Request.Target.ITarget __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (JNIEnv.CallObjectMethod  (Handle, id_buildTarget_Landroid_widget_ImageView_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ITarget> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildTarget", "(Landroid/widget/ImageView;Ljava/lang/Class;)Lcom/bumptech/glide/request/target/Target;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
