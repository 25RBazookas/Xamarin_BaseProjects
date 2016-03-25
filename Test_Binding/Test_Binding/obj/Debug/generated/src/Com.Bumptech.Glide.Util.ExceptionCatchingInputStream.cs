using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ExceptionCatchingInputStream']"
	[global::Android.Runtime.Register ("com/bumptech/glide/util/ExceptionCatchingInputStream", DoNotGenerateAcw=true)]
	public partial class ExceptionCatchingInputStream : global::Java.IO.InputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/util/ExceptionCatchingInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExceptionCatchingInputStream); }
		}

		protected ExceptionCatchingInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getException;
#pragma warning disable 0169
		static Delegate GetGetExceptionHandler ()
		{
			if (cb_getException == null)
				cb_getException = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetException);
			return cb_getException;
		}

		static IntPtr n_GetException (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Util.ExceptionCatchingInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.ExceptionCatchingInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Exception);
		}
#pragma warning restore 0169

		static IntPtr id_getException;
		public virtual unsafe global::Java.IO.IOException Exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ExceptionCatchingInputStream']/method[@name='getException' and count(parameter)=0]"
			[Register ("getException", "()Ljava/io/IOException;", "GetGetExceptionHandler")]
			get {
				if (id_getException == IntPtr.Zero)
					id_getException = JNIEnv.GetMethodID (class_ref, "getException", "()Ljava/io/IOException;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (JNIEnv.CallObjectMethod  (Handle, id_getException), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getException", "()Ljava/io/IOException;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_obtain_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ExceptionCatchingInputStream']/method[@name='obtain' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("obtain", "(Ljava/io/InputStream;)Lcom/bumptech/glide/util/ExceptionCatchingInputStream;", "")]
		public static unsafe global::Com.Bumptech.Glide.Util.ExceptionCatchingInputStream Obtain (global::System.IO.Stream p0)
		{
			if (id_obtain_Ljava_io_InputStream_ == IntPtr.Zero)
				id_obtain_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "obtain", "(Ljava/io/InputStream;)Lcom/bumptech/glide/util/ExceptionCatchingInputStream;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Bumptech.Glide.Util.ExceptionCatchingInputStream __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.ExceptionCatchingInputStream> (JNIEnv.CallStaticObjectMethod  (class_ref, id_obtain_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_read;
#pragma warning disable 0169
		static Delegate GetReadHandler ()
		{
			if (cb_read == null)
				cb_read = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Read);
			return cb_read;
		}

		static int n_Read (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Util.ExceptionCatchingInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.ExceptionCatchingInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read ();
		}
#pragma warning restore 0169

		static IntPtr id_read;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ExceptionCatchingInputStream']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()I", "GetReadHandler")]
		public override unsafe int Read ()
		{
			if (id_read == IntPtr.Zero)
				id_read = JNIEnv.GetMethodID (class_ref, "read", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_read);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "()I"));
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Util.ExceptionCatchingInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.ExceptionCatchingInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ExceptionCatchingInputStream']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			} finally {
			}
		}

	}
}
