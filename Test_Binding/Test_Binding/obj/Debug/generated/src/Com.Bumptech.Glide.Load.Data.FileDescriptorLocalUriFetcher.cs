using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='FileDescriptorLocalUriFetcher']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/data/FileDescriptorLocalUriFetcher", DoNotGenerateAcw=true)]
	public partial class FileDescriptorLocalUriFetcher : global::Com.Bumptech.Glide.Load.Data.LocalUriFetcher {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/data/FileDescriptorLocalUriFetcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileDescriptorLocalUriFetcher); }
		}

		protected FileDescriptorLocalUriFetcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='FileDescriptorLocalUriFetcher']/constructor[@name='FileDescriptorLocalUriFetcher' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/net/Uri;)V", "")]
		public unsafe FileDescriptorLocalUriFetcher (global::Android.Content.Context p0, global::Android.Net.Uri p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FileDescriptorLocalUriFetcher)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/net/Uri;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/net/Uri;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/net/Uri;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_net_Uri_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_net_Uri_, __args);
			} finally {
			}
		}

		static Delegate cb_close_Landroid_os_ParcelFileDescriptor_;
#pragma warning disable 0169
		static Delegate GetClose_Landroid_os_ParcelFileDescriptor_Handler ()
		{
			if (cb_close_Landroid_os_ParcelFileDescriptor_ == null)
				cb_close_Landroid_os_ParcelFileDescriptor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Close_Landroid_os_ParcelFileDescriptor_);
			return cb_close_Landroid_os_ParcelFileDescriptor_;
		}

		static void n_Close_Landroid_os_ParcelFileDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Data.FileDescriptorLocalUriFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.FileDescriptorLocalUriFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelFileDescriptor p0 = global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Close (p0);
		}
#pragma warning restore 0169

		static IntPtr id_close_Landroid_os_ParcelFileDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='FileDescriptorLocalUriFetcher']/method[@name='close' and count(parameter)=1 and parameter[1][@type='android.os.ParcelFileDescriptor']]"
		[Register ("close", "(Landroid/os/ParcelFileDescriptor;)V", "GetClose_Landroid_os_ParcelFileDescriptor_Handler")]
		protected virtual unsafe void Close (global::Android.OS.ParcelFileDescriptor p0)
		{
			if (id_close_Landroid_os_ParcelFileDescriptor_ == IntPtr.Zero)
				id_close_Landroid_os_ParcelFileDescriptor_ = JNIEnv.GetMethodID (class_ref, "close", "(Landroid/os/ParcelFileDescriptor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close_Landroid_os_ParcelFileDescriptor_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "(Landroid/os/ParcelFileDescriptor;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_;
#pragma warning disable 0169
		static Delegate GetLoadResource_Landroid_net_Uri_Landroid_content_ContentResolver_Handler ()
		{
			if (cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ == null)
				cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadResource_Landroid_net_Uri_Landroid_content_ContentResolver_);
			return cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_;
		}

		static IntPtr n_LoadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Load.Data.FileDescriptorLocalUriFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.FileDescriptorLocalUriFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentResolver p1 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentResolver> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadResource (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='FileDescriptorLocalUriFetcher']/method[@name='loadResource' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.content.ContentResolver']]"
		[Register ("loadResource", "(Landroid/net/Uri;Landroid/content/ContentResolver;)Landroid/os/ParcelFileDescriptor;", "GetLoadResource_Landroid_net_Uri_Landroid_content_ContentResolver_Handler")]
		protected virtual unsafe global::Android.OS.ParcelFileDescriptor LoadResource (global::Android.Net.Uri p0, global::Android.Content.ContentResolver p1)
		{
			if (id_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ == IntPtr.Zero)
				id_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ = JNIEnv.GetMethodID (class_ref, "loadResource", "(Landroid/net/Uri;Landroid/content/ContentResolver;)Landroid/os/ParcelFileDescriptor;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.OS.ParcelFileDescriptor __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadResource", "(Landroid/net/Uri;Landroid/content/ContentResolver;)Landroid/os/ParcelFileDescriptor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
