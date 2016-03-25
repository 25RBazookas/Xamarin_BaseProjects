using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Bitmap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='RecyclableBufferedInputStream']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/RecyclableBufferedInputStream", DoNotGenerateAcw=true)]
	public partial class RecyclableBufferedInputStream : global::Java.IO.FilterInputStream {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='RecyclableBufferedInputStream.InvalidMarkException']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/RecyclableBufferedInputStream$InvalidMarkException", DoNotGenerateAcw=true)]
		public partial class InvalidMarkException : global::Java.Lang.RuntimeException {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/RecyclableBufferedInputStream$InvalidMarkException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InvalidMarkException); }
			}

			protected InvalidMarkException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='RecyclableBufferedInputStream.InvalidMarkException']/constructor[@name='RecyclableBufferedInputStream.InvalidMarkException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe InvalidMarkException (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (InvalidMarkException)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/RecyclableBufferedInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecyclableBufferedInputStream); }
		}

		protected RecyclableBufferedInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='RecyclableBufferedInputStream']/constructor[@name='RecyclableBufferedInputStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Ljava/io/InputStream;[B)V", "")]
		public unsafe RecyclableBufferedInputStream (global::System.IO.Stream p0, byte[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (RecyclableBufferedInputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;[B)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_arrayB == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_arrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_fixMarkLimit;
#pragma warning disable 0169
		static Delegate GetFixMarkLimitHandler ()
		{
			if (cb_fixMarkLimit == null)
				cb_fixMarkLimit = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FixMarkLimit);
			return cb_fixMarkLimit;
		}

		static void n_FixMarkLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.RecyclableBufferedInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.RecyclableBufferedInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FixMarkLimit ();
		}
#pragma warning restore 0169

		static IntPtr id_fixMarkLimit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='RecyclableBufferedInputStream']/method[@name='fixMarkLimit' and count(parameter)=0]"
		[Register ("fixMarkLimit", "()V", "GetFixMarkLimitHandler")]
		public virtual unsafe void FixMarkLimit ()
		{
			if (id_fixMarkLimit == IntPtr.Zero)
				id_fixMarkLimit = JNIEnv.GetMethodID (class_ref, "fixMarkLimit", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_fixMarkLimit);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fixMarkLimit", "()V"));
			} finally {
			}
		}

	}
}
