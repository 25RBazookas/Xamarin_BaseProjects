using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoWrapper']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/ImageVideoWrapper", DoNotGenerateAcw=true)]
	public partial class ImageVideoWrapper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/model/ImageVideoWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageVideoWrapper); }
		}

		protected ImageVideoWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_Landroid_os_ParcelFileDescriptor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoWrapper']/constructor[@name='ImageVideoWrapper' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='android.os.ParcelFileDescriptor']]"
		[Register (".ctor", "(Ljava/io/InputStream;Landroid/os/ParcelFileDescriptor;)V", "")]
		public unsafe ImageVideoWrapper (global::System.IO.Stream p0, global::Android.OS.ParcelFileDescriptor p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ImageVideoWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;Landroid/os/ParcelFileDescriptor;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;Landroid/os/ParcelFileDescriptor;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_Landroid_os_ParcelFileDescriptor_ == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_Landroid_os_ParcelFileDescriptor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;Landroid/os/ParcelFileDescriptor;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_Landroid_os_ParcelFileDescriptor_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_Landroid_os_ParcelFileDescriptor_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getFileDescriptor;
#pragma warning disable 0169
		static Delegate GetGetFileDescriptorHandler ()
		{
			if (cb_getFileDescriptor == null)
				cb_getFileDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileDescriptor);
			return cb_getFileDescriptor;
		}

		static IntPtr n_GetFileDescriptor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileDescriptor);
		}
#pragma warning restore 0169

		static IntPtr id_getFileDescriptor;
		public virtual unsafe global::Android.OS.ParcelFileDescriptor FileDescriptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoWrapper']/method[@name='getFileDescriptor' and count(parameter)=0]"
			[Register ("getFileDescriptor", "()Landroid/os/ParcelFileDescriptor;", "GetGetFileDescriptorHandler")]
			get {
				if (id_getFileDescriptor == IntPtr.Zero)
					id_getFileDescriptor = JNIEnv.GetMethodID (class_ref, "getFileDescriptor", "()Landroid/os/ParcelFileDescriptor;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_getFileDescriptor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileDescriptor", "()Landroid/os/ParcelFileDescriptor;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStream;
#pragma warning disable 0169
		static Delegate GetGetStreamHandler ()
		{
			if (cb_getStream == null)
				cb_getStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStream);
			return cb_getStream;
		}

		static IntPtr n_GetStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ImageVideoWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Stream);
		}
#pragma warning restore 0169

		static IntPtr id_getStream;
		public virtual unsafe global::System.IO.Stream Stream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ImageVideoWrapper']/method[@name='getStream' and count(parameter)=0]"
			[Register ("getStream", "()Ljava/io/InputStream;", "GetGetStreamHandler")]
			get {
				if (id_getStream == IntPtr.Zero)
					id_getStream = JNIEnv.GetMethodID (class_ref, "getStream", "()Ljava/io/InputStream;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getStream), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
