using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='Util']"
	[global::Android.Runtime.Register ("com/bumptech/glide/util/Util", DoNotGenerateAcw=true)]
	public sealed partial class Util : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/util/Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Util); }
		}

		internal Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isOnBackgroundThread;
		public static unsafe bool IsOnBackgroundThread {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='Util']/method[@name='isOnBackgroundThread' and count(parameter)=0]"
			[Register ("isOnBackgroundThread", "()Z", "GetIsOnBackgroundThreadHandler")]
			get {
				if (id_isOnBackgroundThread == IntPtr.Zero)
					id_isOnBackgroundThread = JNIEnv.GetStaticMethodID (class_ref, "isOnBackgroundThread", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isOnBackgroundThread);
				} finally {
				}
			}
		}

		static IntPtr id_isOnMainThread;
		public static unsafe bool IsOnMainThread {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='Util']/method[@name='isOnMainThread' and count(parameter)=0]"
			[Register ("isOnMainThread", "()Z", "GetIsOnMainThreadHandler")]
			get {
				if (id_isOnMainThread == IntPtr.Zero)
					id_isOnMainThread = JNIEnv.GetStaticMethodID (class_ref, "isOnMainThread", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isOnMainThread);
				} finally {
				}
			}
		}

		static IntPtr id_assertBackgroundThread;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='Util']/method[@name='assertBackgroundThread' and count(parameter)=0]"
		[Register ("assertBackgroundThread", "()V", "")]
		public static unsafe void AssertBackgroundThread ()
		{
			if (id_assertBackgroundThread == IntPtr.Zero)
				id_assertBackgroundThread = JNIEnv.GetStaticMethodID (class_ref, "assertBackgroundThread", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_assertBackgroundThread);
			} finally {
			}
		}

		static IntPtr id_assertMainThread;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='Util']/method[@name='assertMainThread' and count(parameter)=0]"
		[Register ("assertMainThread", "()V", "")]
		public static unsafe void AssertMainThread ()
		{
			if (id_assertMainThread == IntPtr.Zero)
				id_assertMainThread = JNIEnv.GetStaticMethodID (class_ref, "assertMainThread", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_assertMainThread);
			} finally {
			}
		}

		static IntPtr id_createQueue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='Util']/method[@name='createQueue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createQueue", "(I)Ljava/util/Queue;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.IQueue CreateQueue (int p0)
		{
			if (id_createQueue_I == IntPtr.Zero)
				id_createQueue_I = JNIEnv.GetStaticMethodID (class_ref, "createQueue", "(I)Ljava/util/Queue;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IQueue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createQueue_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getBitmapByteSize_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='Util']/method[@name='getBitmapByteSize' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("getBitmapByteSize", "(Landroid/graphics/Bitmap;)I", "")]
		public static unsafe int GetBitmapByteSize (global::Android.Graphics.Bitmap p0)
		{
			if (id_getBitmapByteSize_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_getBitmapByteSize_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "getBitmapByteSize", "(Landroid/graphics/Bitmap;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getBitmapByteSize_Landroid_graphics_Bitmap_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getBitmapByteSize_IILandroid_graphics_Bitmap_Config_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='Util']/method[@name='getBitmapByteSize' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap.Config']]"
		[Register ("getBitmapByteSize", "(IILandroid/graphics/Bitmap$Config;)I", "")]
		public static unsafe int GetBitmapByteSize (int p0, int p1, global::Android.Graphics.Bitmap.Config p2)
		{
			if (id_getBitmapByteSize_IILandroid_graphics_Bitmap_Config_ == IntPtr.Zero)
				id_getBitmapByteSize_IILandroid_graphics_Bitmap_Config_ = JNIEnv.GetStaticMethodID (class_ref, "getBitmapByteSize", "(IILandroid/graphics/Bitmap$Config;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getBitmapByteSize_IILandroid_graphics_Bitmap_Config_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getSize_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='Util']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Obsolete (@"deprecated")]
		[Register ("getSize", "(Landroid/graphics/Bitmap;)I", "")]
		public static unsafe int GetSize (global::Android.Graphics.Bitmap p0)
		{
			if (id_getSize_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_getSize_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "getSize", "(Landroid/graphics/Bitmap;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getSize_Landroid_graphics_Bitmap_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getSnapshot_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='Util']/method[@name='getSnapshot' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;T&gt;']]"
		[Register ("getSnapshot", "(Ljava/util/Collection;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IList GetSnapshot (global::System.Collections.ICollection p0)
		{
			if (id_getSnapshot_Ljava_util_Collection_ == IntPtr.Zero)
				id_getSnapshot_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "getSnapshot", "(Ljava/util/Collection;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSnapshot_Ljava_util_Collection_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isValidDimensions_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='Util']/method[@name='isValidDimensions' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("isValidDimensions", "(II)Z", "")]
		public static unsafe bool IsValidDimensions (int p0, int p1)
		{
			if (id_isValidDimensions_II == IntPtr.Zero)
				id_isValidDimensions_II = JNIEnv.GetStaticMethodID (class_ref, "isValidDimensions", "(II)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isValidDimensions_II, __args);
			} finally {
			}
		}

		static IntPtr id_sha1BytesToHex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='Util']/method[@name='sha1BytesToHex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha1BytesToHex", "([B)Ljava/lang/String;", "")]
		public static unsafe string Sha1BytesToHex (byte[] p0)
		{
			if (id_sha1BytesToHex_arrayB == IntPtr.Zero)
				id_sha1BytesToHex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha1BytesToHex", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha1BytesToHex_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_sha256BytesToHex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='Util']/method[@name='sha256BytesToHex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha256BytesToHex", "([B)Ljava/lang/String;", "")]
		public static unsafe string Sha256BytesToHex (byte[] p0)
		{
			if (id_sha256BytesToHex_arrayB == IntPtr.Zero)
				id_sha256BytesToHex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha256BytesToHex", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha256BytesToHex_arrayB, __args), JniHandleOwnership.TransferLocalRef);
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
