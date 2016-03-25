using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Module {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.module']/class[@name='ManifestParser']"
	[global::Android.Runtime.Register ("com/bumptech/glide/module/ManifestParser", DoNotGenerateAcw=true)]
	public sealed partial class ManifestParser : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/module/ManifestParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ManifestParser); }
		}

		internal ManifestParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.module']/class[@name='ManifestParser']/constructor[@name='ManifestParser' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ManifestParser (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ManifestParser)) {
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

		static IntPtr id_parse;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.module']/class[@name='ManifestParser']/method[@name='parse' and count(parameter)=0]"
		[Register ("parse", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Bumptech.Glide.Module.IGlideModule> Parse ()
		{
			if (id_parse == IntPtr.Zero)
				id_parse = JNIEnv.GetMethodID (class_ref, "parse", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Bumptech.Glide.Module.IGlideModule>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_parse), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
