using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LogTime']"
	[global::Android.Runtime.Register ("com/bumptech/glide/util/LogTime", DoNotGenerateAcw=true)]
	public sealed partial class LogTime : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/util/LogTime", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LogTime); }
		}

		internal LogTime (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getElapsedMillis_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LogTime']/method[@name='getElapsedMillis' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getElapsedMillis", "(J)D", "")]
		public static unsafe double GetElapsedMillis (long p0)
		{
			if (id_getElapsedMillis_J == IntPtr.Zero)
				id_getElapsedMillis_J = JNIEnv.GetStaticMethodID (class_ref, "getElapsedMillis", "(J)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_getElapsedMillis_J, __args);
			} finally {
			}
		}

		static IntPtr id_getLogTime;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='LogTime']/method[@name='getLogTime' and count(parameter)=0]"
		[Register ("getLogTime", "()J", "")]
		public static unsafe long GetLogTime ()
		{
			if (id_getLogTime == IntPtr.Zero)
				id_getLogTime = JNIEnv.GetStaticMethodID (class_ref, "getLogTime", "()J");
			try {
				return JNIEnv.CallStaticLongMethod  (class_ref, id_getLogTime);
			} finally {
			}
		}

	}
}
