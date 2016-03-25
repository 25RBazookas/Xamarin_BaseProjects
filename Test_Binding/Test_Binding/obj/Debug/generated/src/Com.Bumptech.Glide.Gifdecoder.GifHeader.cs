using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Gifdecoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifHeader']"
	[global::Android.Runtime.Register ("com/bumptech/glide/gifdecoder/GifHeader", DoNotGenerateAcw=true)]
	public partial class GifHeader : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/gifdecoder/GifHeader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifHeader); }
		}

		protected GifHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifHeader']/constructor[@name='GifHeader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GifHeader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (GifHeader)) {
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

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifHeader']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNumFrames;
#pragma warning disable 0169
		static Delegate GetGetNumFramesHandler ()
		{
			if (cb_getNumFrames == null)
				cb_getNumFrames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumFrames);
			return cb_getNumFrames;
		}

		static int n_GetNumFrames (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumFrames;
		}
#pragma warning restore 0169

		static IntPtr id_getNumFrames;
		public virtual unsafe int NumFrames {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifHeader']/method[@name='getNumFrames' and count(parameter)=0]"
			[Register ("getNumFrames", "()I", "GetGetNumFramesHandler")]
			get {
				if (id_getNumFrames == IntPtr.Zero)
					id_getNumFrames = JNIEnv.GetMethodID (class_ref, "getNumFrames", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNumFrames);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumFrames", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatus);
			return cb_getStatus;
		}

		static int n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Status;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		public virtual unsafe int Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifHeader']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()I", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getStatus);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifHeader']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
				} finally {
				}
			}
		}

	}
}
