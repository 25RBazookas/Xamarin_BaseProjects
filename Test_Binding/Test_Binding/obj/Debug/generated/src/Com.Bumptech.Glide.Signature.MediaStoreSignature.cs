using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Signature {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.signature']/class[@name='MediaStoreSignature']"
	[global::Android.Runtime.Register ("com/bumptech/glide/signature/MediaStoreSignature", DoNotGenerateAcw=true)]
	public partial class MediaStoreSignature : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.IKey {


		public static class InterfaceConsts {

			// The following are fields from: com.bumptech.glide.load.Key

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load']/interface[@name='Key']/field[@name='STRING_CHARSET_NAME']"
			[Register ("STRING_CHARSET_NAME")]
			public const string StringCharsetName = (string) "UTF-8";
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/signature/MediaStoreSignature", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaStoreSignature); }
		}

		protected MediaStoreSignature (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_JI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.signature']/class[@name='MediaStoreSignature']/constructor[@name='MediaStoreSignature' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;JI)V", "")]
		public unsafe MediaStoreSignature (string p0, long p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (MediaStoreSignature)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;JI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;JI)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_JI == IntPtr.Zero)
					id_ctor_Ljava_lang_String_JI = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;JI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_JI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_JI, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
#pragma warning disable 0169
		static Delegate GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler ()
		{
			if (cb_updateDiskCacheKey_Ljava_security_MessageDigest_ == null)
				cb_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateDiskCacheKey_Ljava_security_MessageDigest_);
			return cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
		}

		static void n_UpdateDiskCacheKey_Ljava_security_MessageDigest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Signature.MediaStoreSignature __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Signature.MediaStoreSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.MessageDigest p0 = global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateDiskCacheKey (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateDiskCacheKey_Ljava_security_MessageDigest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.signature']/class[@name='MediaStoreSignature']/method[@name='updateDiskCacheKey' and count(parameter)=1 and parameter[1][@type='java.security.MessageDigest']]"
		[Register ("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler")]
		public virtual unsafe void UpdateDiskCacheKey (global::Java.Security.MessageDigest p0)
		{
			if (id_updateDiskCacheKey_Ljava_security_MessageDigest_ == IntPtr.Zero)
				id_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNIEnv.GetMethodID (class_ref, "updateDiskCacheKey", "(Ljava/security/MessageDigest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateDiskCacheKey_Ljava_security_MessageDigest_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateDiskCacheKey", "(Ljava/security/MessageDigest;)V"), __args);
			} finally {
			}
		}

	}
}
