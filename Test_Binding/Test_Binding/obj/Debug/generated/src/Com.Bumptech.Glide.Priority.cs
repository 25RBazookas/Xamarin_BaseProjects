using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Priority']"
	[global::Android.Runtime.Register ("com/bumptech/glide/Priority", DoNotGenerateAcw=true)]
	public sealed partial class Priority : global::Java.Lang.Enum {


		static IntPtr HIGH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Priority']/field[@name='HIGH']"
		[Register ("HIGH")]
		public static global::Com.Bumptech.Glide.Priority High {
			get {
				if (HIGH_jfieldId == IntPtr.Zero)
					HIGH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIGH", "Lcom/bumptech/glide/Priority;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HIGH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Priority> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IMMEDIATE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Priority']/field[@name='IMMEDIATE']"
		[Register ("IMMEDIATE")]
		public static global::Com.Bumptech.Glide.Priority Immediate {
			get {
				if (IMMEDIATE_jfieldId == IntPtr.Zero)
					IMMEDIATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMMEDIATE", "Lcom/bumptech/glide/Priority;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IMMEDIATE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Priority> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Priority']/field[@name='LOW']"
		[Register ("LOW")]
		public static global::Com.Bumptech.Glide.Priority Low {
			get {
				if (LOW_jfieldId == IntPtr.Zero)
					LOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOW", "Lcom/bumptech/glide/Priority;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Priority> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NORMAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Priority']/field[@name='NORMAL']"
		[Register ("NORMAL")]
		public static global::Com.Bumptech.Glide.Priority Normal {
			get {
				if (NORMAL_jfieldId == IntPtr.Zero)
					NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NORMAL", "Lcom/bumptech/glide/Priority;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NORMAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Priority> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MyPriority_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Priority']/field[@name='MyPriority']"
		[Register ("MyPriority")]
		public static global::Com.Bumptech.Glide.Priority MyPriority {
			get {
				if (MyPriority_jfieldId == IntPtr.Zero)
					MyPriority_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MyPriority", "Lcom/bumptech/glide/Priority;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MyPriority_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Priority> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/Priority", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Priority); }
		}

		internal Priority (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Priority']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/Priority;", "")]
		public static unsafe global::Com.Bumptech.Glide.Priority ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/Priority;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Bumptech.Glide.Priority __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Priority> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/class[@name='Priority']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/bumptech/glide/Priority;", "")]
		public static unsafe global::Com.Bumptech.Glide.Priority[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bumptech/glide/Priority;");
			try {
				return (global::Com.Bumptech.Glide.Priority[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bumptech.Glide.Priority));
			} finally {
			}
		}

	}
}
