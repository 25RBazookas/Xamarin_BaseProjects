using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Signature {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.signature']/class[@name='EmptySignature']"
	[global::Android.Runtime.Register ("com/bumptech/glide/signature/EmptySignature", DoNotGenerateAcw=true)]
	public sealed partial class EmptySignature : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.IKey {


		public static class InterfaceConsts {

			// The following are fields from: com.bumptech.glide.load.Key

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load']/interface[@name='Key']/field[@name='STRING_CHARSET_NAME']"
			[Register ("STRING_CHARSET_NAME")]
			public const string StringCharsetName = (string) "UTF-8";
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/signature/EmptySignature", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EmptySignature); }
		}

		internal EmptySignature (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_obtain;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.signature']/class[@name='EmptySignature']/method[@name='obtain' and count(parameter)=0]"
		[Register ("obtain", "()Lcom/bumptech/glide/signature/EmptySignature;", "")]
		public static unsafe global::Com.Bumptech.Glide.Signature.EmptySignature Obtain ()
		{
			if (id_obtain == IntPtr.Zero)
				id_obtain = JNIEnv.GetStaticMethodID (class_ref, "obtain", "()Lcom/bumptech/glide/signature/EmptySignature;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Signature.EmptySignature> (JNIEnv.CallStaticObjectMethod  (class_ref, id_obtain), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_updateDiskCacheKey_Ljava_security_MessageDigest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.signature']/class[@name='EmptySignature']/method[@name='updateDiskCacheKey' and count(parameter)=1 and parameter[1][@type='java.security.MessageDigest']]"
		[Register ("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "")]
		public unsafe void UpdateDiskCacheKey (global::Java.Security.MessageDigest p0)
		{
			if (id_updateDiskCacheKey_Ljava_security_MessageDigest_ == IntPtr.Zero)
				id_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNIEnv.GetMethodID (class_ref, "updateDiskCacheKey", "(Ljava/security/MessageDigest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_updateDiskCacheKey_Ljava_security_MessageDigest_, __args);
			} finally {
			}
		}

	}
}
