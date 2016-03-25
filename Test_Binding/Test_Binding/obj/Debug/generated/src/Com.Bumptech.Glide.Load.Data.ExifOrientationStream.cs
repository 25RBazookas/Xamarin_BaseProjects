using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='ExifOrientationStream']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/data/ExifOrientationStream", DoNotGenerateAcw=true)]
	public partial class ExifOrientationStream : global::Java.IO.FilterInputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/data/ExifOrientationStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExifOrientationStream); }
		}

		protected ExifOrientationStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='ExifOrientationStream']/constructor[@name='ExifOrientationStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/io/InputStream;I)V", "")]
		public unsafe ExifOrientationStream (global::System.IO.Stream p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ExifOrientationStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_I == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
