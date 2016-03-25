using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='Headers.1']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/Headers$1", DoNotGenerateAcw=true)]
	public partial class Headers1 : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Model.IHeaders {


		public static class InterfaceConsts {

			// The following are fields from: com.bumptech.glide.load.model.Headers

			static IntPtr DEFAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.model']/interface[@name='Headers']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Com.Bumptech.Glide.Load.Model.IHeaders Default {
				get {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/bumptech/glide/load/model/Headers;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IHeaders> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.model']/interface[@name='Headers']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Bumptech.Glide.Load.Model.IHeaders None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/bumptech/glide/load/model/Headers;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IHeaders> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/model/Headers$1", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Headers1); }
		}

		protected Headers1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getHeaders;
#pragma warning disable 0169
		static Delegate GetGetHeadersHandler ()
		{
			if (cb_getHeaders == null)
				cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
			return cb_getHeaders;
		}

		static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Model.Headers1 __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.Headers1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='Headers.1']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler")]
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaders", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

	[Register ("com/bumptech/glide/load/model/Headers")]
	public abstract class Headers {

		internal Headers ()
		{
		}

		static IntPtr DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.model']/interface[@name='Headers']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Bumptech.Glide.Load.Model.IHeaders Default {
			get {
				if (DEFAULT_jfieldId == IntPtr.Zero)
					DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/bumptech/glide/load/model/Headers;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IHeaders> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.model']/interface[@name='Headers']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Bumptech.Glide.Load.Model.IHeaders None {
			get {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/bumptech/glide/load/model/Headers;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IHeaders> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/model/Headers");
	}

	[global::System.Obsolete ("Use the 'Headers' type. This type will be removed in a future release.")]
	public abstract class HeadersConsts : Headers {

		private HeadersConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.model']/interface[@name='Headers']"
	[Register ("com/bumptech/glide/load/model/Headers", "", "Com.Bumptech.Glide.Load.Model.IHeadersInvoker")]
	public partial interface IHeaders : IJavaObject {

		global::System.Collections.Generic.IDictionary<string, string> Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/interface[@name='Headers']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler:Com.Bumptech.Glide.Load.Model.IHeadersInvoker, Test_Binding")] get;
		}

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/Headers", DoNotGenerateAcw=true)]
	internal class IHeadersInvoker : global::Java.Lang.Object, IHeaders {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/model/Headers");
		IntPtr class_ref;

		public static IHeaders GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHeaders> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.model.Headers"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHeadersInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHeadersInvoker); }
		}

		static Delegate cb_getHeaders;
#pragma warning disable 0169
		static Delegate GetGetHeadersHandler ()
		{
			if (cb_getHeaders == null)
				cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
			return cb_getHeaders;
		}

		static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Model.IHeaders __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.IHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		IntPtr id_getHeaders;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> Headers {
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
