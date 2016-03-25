using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Signature {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.signature']/class[@name='ApplicationVersionSignature']"
	[global::Android.Runtime.Register ("com/bumptech/glide/signature/ApplicationVersionSignature", DoNotGenerateAcw=true)]
	public sealed partial class ApplicationVersionSignature : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/signature/ApplicationVersionSignature", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplicationVersionSignature); }
		}

		internal ApplicationVersionSignature (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_obtain_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.signature']/class[@name='ApplicationVersionSignature']/method[@name='obtain' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("obtain", "(Landroid/content/Context;)Lcom/bumptech/glide/load/Key;", "")]
		public static unsafe global::Com.Bumptech.Glide.Load.IKey Obtain (global::Android.Content.Context p0)
		{
			if (id_obtain_Landroid_content_Context_ == IntPtr.Zero)
				id_obtain_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "obtain", "(Landroid/content/Context;)Lcom/bumptech/glide/load/Key;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Bumptech.Glide.Load.IKey __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_obtain_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
