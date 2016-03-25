using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ContentLengthInputStream']"
	[global::Android.Runtime.Register ("com/bumptech/glide/util/ContentLengthInputStream", DoNotGenerateAcw=true)]
	public sealed partial class ContentLengthInputStream : global::Java.IO.FilterInputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/util/ContentLengthInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentLengthInputStream); }
		}

		internal ContentLengthInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_obtain_Ljava_io_InputStream_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ContentLengthInputStream']/method[@name='obtain' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.lang.String']]"
		[Register ("obtain", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/io/InputStream;", "")]
		public static unsafe global::System.IO.Stream Obtain (global::System.IO.Stream p0, string p1)
		{
			if (id_obtain_Ljava_io_InputStream_Ljava_lang_String_ == IntPtr.Zero)
				id_obtain_Ljava_io_InputStream_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "obtain", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/io/InputStream;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_obtain_Ljava_io_InputStream_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_obtain_Ljava_io_InputStream_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ContentLengthInputStream']/method[@name='obtain' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='long']]"
		[Register ("obtain", "(Ljava/io/InputStream;J)Ljava/io/InputStream;", "")]
		public static unsafe global::System.IO.Stream Obtain (global::System.IO.Stream p0, long p1)
		{
			if (id_obtain_Ljava_io_InputStream_J == IntPtr.Zero)
				id_obtain_Ljava_io_InputStream_J = JNIEnv.GetStaticMethodID (class_ref, "obtain", "(Ljava/io/InputStream;J)Ljava/io/InputStream;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_obtain_Ljava_io_InputStream_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
