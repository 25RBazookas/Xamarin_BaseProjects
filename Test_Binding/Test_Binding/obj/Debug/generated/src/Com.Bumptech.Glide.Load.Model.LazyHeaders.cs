using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='LazyHeaders']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/LazyHeaders", DoNotGenerateAcw=true)]
	public sealed partial class LazyHeaders : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Model.IHeaders {


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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='LazyHeaders.Builder']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/model/LazyHeaders$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/model/LazyHeaders$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='LazyHeaders.Builder']/constructor[@name='LazyHeaders.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

			static IntPtr id_addHeader_Ljava_lang_String_Lcom_bumptech_glide_load_model_LazyHeaderFactory_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='LazyHeaders.Builder']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.bumptech.glide.load.model.LazyHeaderFactory']]"
			[Register ("addHeader", "(Ljava/lang/String;Lcom/bumptech/glide/load/model/LazyHeaderFactory;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;", "")]
			public unsafe global::Com.Bumptech.Glide.Load.Model.LazyHeaders.Builder AddHeader (string p0, global::Com.Bumptech.Glide.Load.Model.ILazyHeaderFactory p1)
			{
				if (id_addHeader_Ljava_lang_String_Lcom_bumptech_glide_load_model_LazyHeaderFactory_ == IntPtr.Zero)
					id_addHeader_Ljava_lang_String_Lcom_bumptech_glide_load_model_LazyHeaderFactory_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Lcom/bumptech/glide/load/model/LazyHeaderFactory;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					global::Com.Bumptech.Glide.Load.Model.LazyHeaders.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.LazyHeaders.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addHeader_Ljava_lang_String_Lcom_bumptech_glide_load_model_LazyHeaderFactory_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='LazyHeaders.Builder']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;", "")]
			public unsafe global::Com.Bumptech.Glide.Load.Model.LazyHeaders.Builder AddHeader (string p0, string p1)
			{
				if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					global::Com.Bumptech.Glide.Load.Model.LazyHeaders.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.LazyHeaders.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='LazyHeaders.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/bumptech/glide/load/model/LazyHeaders;", "")]
			public unsafe global::Com.Bumptech.Glide.Load.Model.LazyHeaders Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/bumptech/glide/load/model/LazyHeaders;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.LazyHeaders> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setHeader_Ljava_lang_String_Lcom_bumptech_glide_load_model_LazyHeaderFactory_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='LazyHeaders.Builder']/method[@name='setHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.bumptech.glide.load.model.LazyHeaderFactory']]"
			[Register ("setHeader", "(Ljava/lang/String;Lcom/bumptech/glide/load/model/LazyHeaderFactory;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;", "")]
			public unsafe global::Com.Bumptech.Glide.Load.Model.LazyHeaders.Builder SetHeader (string p0, global::Com.Bumptech.Glide.Load.Model.ILazyHeaderFactory p1)
			{
				if (id_setHeader_Ljava_lang_String_Lcom_bumptech_glide_load_model_LazyHeaderFactory_ == IntPtr.Zero)
					id_setHeader_Ljava_lang_String_Lcom_bumptech_glide_load_model_LazyHeaderFactory_ = JNIEnv.GetMethodID (class_ref, "setHeader", "(Ljava/lang/String;Lcom/bumptech/glide/load/model/LazyHeaderFactory;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					global::Com.Bumptech.Glide.Load.Model.LazyHeaders.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.LazyHeaders.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setHeader_Ljava_lang_String_Lcom_bumptech_glide_load_model_LazyHeaderFactory_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_setHeader_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='LazyHeaders.Builder']/method[@name='setHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("setHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;", "")]
			public unsafe global::Com.Bumptech.Glide.Load.Model.LazyHeaders.Builder SetHeader (string p0, string p1)
			{
				if (id_setHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_setHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					global::Com.Bumptech.Glide.Load.Model.LazyHeaders.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.LazyHeaders.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setHeader_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='LazyHeaders.StringHeaderFactory']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/model/LazyHeaders$StringHeaderFactory", DoNotGenerateAcw=true)]
		public sealed partial class StringHeaderFactory : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Model.ILazyHeaderFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/model/LazyHeaders$StringHeaderFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StringHeaderFactory); }
			}

			internal StringHeaderFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_buildHeader;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='LazyHeaders.StringHeaderFactory']/method[@name='buildHeader' and count(parameter)=0]"
			[Register ("buildHeader", "()Ljava/lang/String;", "")]
			public unsafe string BuildHeader ()
			{
				if (id_buildHeader == IntPtr.Zero)
					id_buildHeader = JNIEnv.GetMethodID (class_ref, "buildHeader", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_buildHeader), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/model/LazyHeaders", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LazyHeaders); }
		}

		internal LazyHeaders (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getHeaders;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='LazyHeaders']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler")]
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/Map;");
				try {
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
