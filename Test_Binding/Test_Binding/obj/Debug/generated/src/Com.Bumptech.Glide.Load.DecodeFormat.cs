using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load']/class[@name='DecodeFormat']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/DecodeFormat", DoNotGenerateAcw=true)]
	public sealed partial class DecodeFormat : global::Java.Lang.Enum {


		static IntPtr ALWAYS_ARGB_8888_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load']/class[@name='DecodeFormat']/field[@name='ALWAYS_ARGB_8888']"
		[Register ("ALWAYS_ARGB_8888")]
		public static global::Com.Bumptech.Glide.Load.DecodeFormat AlwaysArgb8888 {
			get {
				if (ALWAYS_ARGB_8888_jfieldId == IntPtr.Zero)
					ALWAYS_ARGB_8888_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALWAYS_ARGB_8888", "Lcom/bumptech/glide/load/DecodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALWAYS_ARGB_8888_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.DecodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load']/class[@name='DecodeFormat']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Bumptech.Glide.Load.DecodeFormat Default {
			get {
				if (DEFAULT_jfieldId == IntPtr.Zero)
					DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/bumptech/glide/load/DecodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.DecodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PREFER_ARGB_8888_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load']/class[@name='DecodeFormat']/field[@name='PREFER_ARGB_8888']"
		[Register ("PREFER_ARGB_8888")]
		public static global::Com.Bumptech.Glide.Load.DecodeFormat PreferArgb8888 {
			get {
				if (PREFER_ARGB_8888_jfieldId == IntPtr.Zero)
					PREFER_ARGB_8888_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREFER_ARGB_8888", "Lcom/bumptech/glide/load/DecodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREFER_ARGB_8888_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.DecodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PREFER_RGB_565_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load']/class[@name='DecodeFormat']/field[@name='PREFER_RGB_565']"
		[Register ("PREFER_RGB_565")]
		public static global::Com.Bumptech.Glide.Load.DecodeFormat PreferRgb565 {
			get {
				if (PREFER_RGB_565_jfieldId == IntPtr.Zero)
					PREFER_RGB_565_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREFER_RGB_565", "Lcom/bumptech/glide/load/DecodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREFER_RGB_565_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.DecodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/DecodeFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DecodeFormat); }
		}

		internal DecodeFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load']/class[@name='DecodeFormat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/load/DecodeFormat;", "")]
		public static unsafe global::Com.Bumptech.Glide.Load.DecodeFormat ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/load/DecodeFormat;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Bumptech.Glide.Load.DecodeFormat __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.DecodeFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load']/class[@name='DecodeFormat']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/bumptech/glide/load/DecodeFormat;", "")]
		public static unsafe global::Com.Bumptech.Glide.Load.DecodeFormat[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bumptech/glide/load/DecodeFormat;");
			try {
				return (global::Com.Bumptech.Glide.Load.DecodeFormat[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bumptech.Glide.Load.DecodeFormat));
			} finally {
			}
		}

	}
}
