using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='GlideUrl']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/GlideUrl", DoNotGenerateAcw=true)]
	public partial class GlideUrl : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/model/GlideUrl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GlideUrl); }
		}

		protected GlideUrl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_bumptech_glide_load_model_Headers_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='GlideUrl']/constructor[@name='GlideUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.bumptech.glide.load.model.Headers']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/bumptech/glide/load/model/Headers;)V", "")]
		public unsafe GlideUrl (string p0, global::Com.Bumptech.Glide.Load.Model.IHeaders p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (GlideUrl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/bumptech/glide/load/model/Headers;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/bumptech/glide/load/model/Headers;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_bumptech_glide_load_model_Headers_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_bumptech_glide_load_model_Headers_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/bumptech/glide/load/model/Headers;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_bumptech_glide_load_model_Headers_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_bumptech_glide_load_model_Headers_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_net_URL_Lcom_bumptech_glide_load_model_Headers_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='GlideUrl']/constructor[@name='GlideUrl' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='com.bumptech.glide.load.model.Headers']]"
		[Register (".ctor", "(Ljava/net/URL;Lcom/bumptech/glide/load/model/Headers;)V", "")]
		public unsafe GlideUrl (global::Java.Net.URL p0, global::Com.Bumptech.Glide.Load.Model.IHeaders p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (GlideUrl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/URL;Lcom/bumptech/glide/load/model/Headers;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/net/URL;Lcom/bumptech/glide/load/model/Headers;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_Lcom_bumptech_glide_load_model_Headers_ == IntPtr.Zero)
					id_ctor_Ljava_net_URL_Lcom_bumptech_glide_load_model_Headers_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Lcom/bumptech/glide/load/model/Headers;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Lcom_bumptech_glide_load_model_Headers_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_net_URL_Lcom_bumptech_glide_load_model_Headers_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='GlideUrl']/constructor[@name='GlideUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe GlideUrl (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (GlideUrl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_net_URL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='GlideUrl']/constructor[@name='GlideUrl' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register (".ctor", "(Ljava/net/URL;)V", "")]
		public unsafe GlideUrl (global::Java.Net.URL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GlideUrl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/URL;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/net/URL;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_ == IntPtr.Zero)
					id_ctor_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_net_URL_, __args);
			} finally {
			}
		}

		static Delegate cb_getCacheKey;
#pragma warning disable 0169
		static Delegate GetGetCacheKeyHandler ()
		{
			if (cb_getCacheKey == null)
				cb_getCacheKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCacheKey);
			return cb_getCacheKey;
		}

		static IntPtr n_GetCacheKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Model.GlideUrl __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.GlideUrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CacheKey);
		}
#pragma warning restore 0169

		static IntPtr id_getCacheKey;
		public virtual unsafe string CacheKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='GlideUrl']/method[@name='getCacheKey' and count(parameter)=0]"
			[Register ("getCacheKey", "()Ljava/lang/String;", "GetGetCacheKeyHandler")]
			get {
				if (id_getCacheKey == IntPtr.Zero)
					id_getCacheKey = JNIEnv.GetMethodID (class_ref, "getCacheKey", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCacheKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCacheKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			global::Com.Bumptech.Glide.Load.Model.GlideUrl __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.GlideUrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='GlideUrl']/method[@name='getHeaders' and count(parameter)=0]"
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

		static Delegate cb_toStringUrl;
#pragma warning disable 0169
		static Delegate GetToStringUrlHandler ()
		{
			if (cb_toStringUrl == null)
				cb_toStringUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToStringUrl);
			return cb_toStringUrl;
		}

		static IntPtr n_ToStringUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Model.GlideUrl __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.GlideUrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToStringUrl ());
		}
#pragma warning restore 0169

		static IntPtr id_toStringUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='GlideUrl']/method[@name='toStringUrl' and count(parameter)=0]"
		[Register ("toStringUrl", "()Ljava/lang/String;", "GetToStringUrlHandler")]
		public virtual unsafe string ToStringUrl ()
		{
			if (id_toStringUrl == IntPtr.Zero)
				id_toStringUrl = JNIEnv.GetMethodID (class_ref, "toStringUrl", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toStringUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toStringUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toURL;
#pragma warning disable 0169
		static Delegate GetToURLHandler ()
		{
			if (cb_toURL == null)
				cb_toURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToURL);
			return cb_toURL;
		}

		static IntPtr n_ToURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Model.GlideUrl __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.GlideUrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToURL ());
		}
#pragma warning restore 0169

		static IntPtr id_toURL;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='GlideUrl']/method[@name='toURL' and count(parameter)=0]"
		[Register ("toURL", "()Ljava/net/URL;", "GetToURLHandler")]
		public virtual unsafe global::Java.Net.URL ToURL ()
		{
			if (id_toURL == IntPtr.Zero)
				id_toURL = JNIEnv.GetMethodID (class_ref, "toURL", "()Ljava/net/URL;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallObjectMethod  (Handle, id_toURL), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toURL", "()Ljava/net/URL;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
