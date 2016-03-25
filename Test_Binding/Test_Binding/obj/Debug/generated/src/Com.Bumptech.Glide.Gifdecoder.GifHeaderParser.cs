using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Gifdecoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifHeaderParser']"
	[global::Android.Runtime.Register ("com/bumptech/glide/gifdecoder/GifHeaderParser", DoNotGenerateAcw=true)]
	public partial class GifHeaderParser : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifHeaderParser']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "GifHeaderParser";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/gifdecoder/GifHeaderParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifHeaderParser); }
		}

		protected GifHeaderParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifHeaderParser']/constructor[@name='GifHeaderParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GifHeaderParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (GifHeaderParser)) {
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

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifHeaderParser']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_parseHeader;
#pragma warning disable 0169
		static Delegate GetParseHeaderHandler ()
		{
			if (cb_parseHeader == null)
				cb_parseHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ParseHeader);
			return cb_parseHeader;
		}

		static IntPtr n_ParseHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ParseHeader ());
		}
#pragma warning restore 0169

		static IntPtr id_parseHeader;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifHeaderParser']/method[@name='parseHeader' and count(parameter)=0]"
		[Register ("parseHeader", "()Lcom/bumptech/glide/gifdecoder/GifHeader;", "GetParseHeaderHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Gifdecoder.GifHeader ParseHeader ()
		{
			if (id_parseHeader == IntPtr.Zero)
				id_parseHeader = JNIEnv.GetMethodID (class_ref, "parseHeader", "()Lcom/bumptech/glide/gifdecoder/GifHeader;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeader> (JNIEnv.CallObjectMethod  (Handle, id_parseHeader), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeader> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseHeader", "()Lcom/bumptech/glide/gifdecoder/GifHeader;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setData_arrayB;
#pragma warning disable 0169
		static Delegate GetSetData_arrayBHandler ()
		{
			if (cb_setData_arrayB == null)
				cb_setData_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetData_arrayB);
			return cb_setData_arrayB;
		}

		static IntPtr n_SetData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetData (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setData_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifHeaderParser']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setData", "([B)Lcom/bumptech/glide/gifdecoder/GifHeaderParser;", "GetSetData_arrayBHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser SetData (byte[] p0)
		{
			if (id_setData_arrayB == IntPtr.Zero)
				id_setData_arrayB = JNIEnv.GetMethodID (class_ref, "setData", "([B)Lcom/bumptech/glide/gifdecoder/GifHeaderParser;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser> (JNIEnv.CallObjectMethod  (Handle, id_setData_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "([B)Lcom/bumptech/glide/gifdecoder/GifHeaderParser;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
