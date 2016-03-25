using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ByteArrayPool']"
	[global::Android.Runtime.Register ("com/bumptech/glide/util/ByteArrayPool", DoNotGenerateAcw=true)]
	public sealed partial class ByteArrayPool : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/util/ByteArrayPool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteArrayPool); }
		}

		internal ByteArrayPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ByteArrayPool']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_clear);
			} finally {
			}
		}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ByteArrayPool']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/bumptech/glide/util/ByteArrayPool;", "")]
		public static unsafe global::Com.Bumptech.Glide.Util.ByteArrayPool Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetStaticMethodID (class_ref, "get", "()Lcom/bumptech/glide/util/ByteArrayPool;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.ByteArrayPool> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ByteArrayPool']/method[@name='getBytes' and count(parameter)=0]"
		[Register ("getBytes", "()[B", "")]
		public unsafe byte[] GetBytes ()
		{
			if (id_getBytes == IntPtr.Zero)
				id_getBytes = JNIEnv.GetMethodID (class_ref, "getBytes", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_releaseBytes_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='ByteArrayPool']/method[@name='releaseBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("releaseBytes", "([B)Z", "")]
		public unsafe bool ReleaseBytes (byte[] p0)
		{
			if (id_releaseBytes_arrayB == IntPtr.Zero)
				id_releaseBytes_arrayB = JNIEnv.GetMethodID (class_ref, "releaseBytes", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_releaseBytes_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
