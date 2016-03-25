using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='DiskCacheStrategy']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/DiskCacheStrategy", DoNotGenerateAcw=true)]
	public sealed partial class DiskCacheStrategy : global::Java.Lang.Enum {


		static IntPtr ALL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='DiskCacheStrategy']/field[@name='ALL']"
		[Register ("ALL")]
		public static global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy All {
			get {
				if (ALL_jfieldId == IntPtr.Zero)
					ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lcom/bumptech/glide/load/engine/DiskCacheStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='DiskCacheStrategy']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy None {
			get {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/bumptech/glide/load/engine/DiskCacheStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RESULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='DiskCacheStrategy']/field[@name='RESULT']"
		[Register ("RESULT")]
		public static global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy Result {
			get {
				if (RESULT_jfieldId == IntPtr.Zero)
					RESULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT", "Lcom/bumptech/glide/load/engine/DiskCacheStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SOURCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='DiskCacheStrategy']/field[@name='SOURCE']"
		[Register ("SOURCE")]
		public static global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy Source {
			get {
				if (SOURCE_jfieldId == IntPtr.Zero)
					SOURCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOURCE", "Lcom/bumptech/glide/load/engine/DiskCacheStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SOURCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/engine/DiskCacheStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiskCacheStrategy); }
		}

		internal DiskCacheStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_cacheResult;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='DiskCacheStrategy']/method[@name='cacheResult' and count(parameter)=0]"
		[Register ("cacheResult", "()Z", "")]
		public unsafe bool CacheResult ()
		{
			if (id_cacheResult == IntPtr.Zero)
				id_cacheResult = JNIEnv.GetMethodID (class_ref, "cacheResult", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_cacheResult);
			} finally {
			}
		}

		static IntPtr id_cacheSource;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='DiskCacheStrategy']/method[@name='cacheSource' and count(parameter)=0]"
		[Register ("cacheSource", "()Z", "")]
		public unsafe bool CacheSource ()
		{
			if (id_cacheSource == IntPtr.Zero)
				id_cacheSource = JNIEnv.GetMethodID (class_ref, "cacheSource", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_cacheSource);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='DiskCacheStrategy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/load/engine/DiskCacheStrategy;", "")]
		public static unsafe global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/load/engine/DiskCacheStrategy;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine']/class[@name='DiskCacheStrategy']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/bumptech/glide/load/engine/DiskCacheStrategy;", "")]
		public static unsafe global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bumptech/glide/load/engine/DiskCacheStrategy;");
			try {
				return (global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bumptech.Glide.Load.Engine.DiskCacheStrategy));
			} finally {
			}
		}

	}
}
