using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load {

	[Register ("com/bumptech/glide/load/Key")]
	public abstract class Key {

		internal Key ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load']/interface[@name='Key']/field[@name='STRING_CHARSET_NAME']"
		[Register ("STRING_CHARSET_NAME")]
		public const string StringCharsetName = (string) "UTF-8";
	}

	[global::System.Obsolete ("Use the 'Key' type. This type will be removed in a future release.")]
	public abstract class KeyConsts : Key {

		private KeyConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load']/interface[@name='Key']"
	[Register ("com/bumptech/glide/load/Key", "", "Com.Bumptech.Glide.Load.IKeyInvoker")]
	public partial interface IKey : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load']/interface[@name='Key']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "GetEquals_Ljava_lang_Object_Handler:Com.Bumptech.Glide.Load.IKeyInvoker, Test_Binding")]
		bool Equals (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load']/interface[@name='Key']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "GetGetHashCodeHandler:Com.Bumptech.Glide.Load.IKeyInvoker, Test_Binding")]
		int GetHashCode ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load']/interface[@name='Key']/method[@name='updateDiskCacheKey' and count(parameter)=1 and parameter[1][@type='java.security.MessageDigest']]"
		[Register ("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler:Com.Bumptech.Glide.Load.IKeyInvoker, Test_Binding")]
		void UpdateDiskCacheKey (global::Java.Security.MessageDigest p0);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/Key", DoNotGenerateAcw=true)]
	internal class IKeyInvoker : global::Java.Lang.Object, IKey {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/Key");
		IntPtr class_ref;

		public static IKey GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IKey> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.Key"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IKeyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IKeyInvoker); }
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.IKey __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.IKey __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (Handle, id_hashCode);
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
			global::Com.Bumptech.Glide.Load.IKey __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.MessageDigest p0 = global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateDiskCacheKey (p0);
		}
#pragma warning restore 0169

		IntPtr id_updateDiskCacheKey_Ljava_security_MessageDigest_;
		public unsafe void UpdateDiskCacheKey (global::Java.Security.MessageDigest p0)
		{
			if (id_updateDiskCacheKey_Ljava_security_MessageDigest_ == IntPtr.Zero)
				id_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNIEnv.GetMethodID (class_ref, "updateDiskCacheKey", "(Ljava/security/MessageDigest;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_updateDiskCacheKey_Ljava_security_MessageDigest_, __args);
		}

	}

}
