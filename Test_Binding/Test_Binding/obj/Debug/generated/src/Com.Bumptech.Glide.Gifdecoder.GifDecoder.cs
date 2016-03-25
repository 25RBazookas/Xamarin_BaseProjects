using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Gifdecoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/gifdecoder/GifDecoder", DoNotGenerateAcw=true)]
	public partial class GifDecoder : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/field[@name='STATUS_FORMAT_ERROR']"
		[Register ("STATUS_FORMAT_ERROR")]
		public const int StatusFormatError = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/field[@name='STATUS_OK']"
		[Register ("STATUS_OK")]
		public const int StatusOk = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/field[@name='STATUS_OPEN_ERROR']"
		[Register ("STATUS_OPEN_ERROR")]
		public const int StatusOpenError = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/field[@name='STATUS_PARTIAL_DECODE']"
		[Register ("STATUS_PARTIAL_DECODE")]
		public const int StatusPartialDecode = (int) 3;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/interface[@name='GifDecoder.BitmapProvider']"
		[Register ("com/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider", "", "Com.Bumptech.Glide.Gifdecoder.GifDecoder/IBitmapProviderInvoker")]
		public partial interface IBitmapProvider : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/interface[@name='GifDecoder.BitmapProvider']/method[@name='obtain' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap.Config']]"
			[Register ("obtain", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", "GetObtain_IILandroid_graphics_Bitmap_Config_Handler:Com.Bumptech.Glide.Gifdecoder.GifDecoder/IBitmapProviderInvoker, Test_Binding")]
			global::Android.Graphics.Bitmap Obtain (int p0, int p1, global::Android.Graphics.Bitmap.Config p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/interface[@name='GifDecoder.BitmapProvider']/method[@name='release' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("release", "(Landroid/graphics/Bitmap;)V", "GetRelease_Landroid_graphics_Bitmap_Handler:Com.Bumptech.Glide.Gifdecoder.GifDecoder/IBitmapProviderInvoker, Test_Binding")]
			void Release (global::Android.Graphics.Bitmap p0);

		}

		[global::Android.Runtime.Register ("com/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider", DoNotGenerateAcw=true)]
		internal class IBitmapProviderInvoker : global::Java.Lang.Object, IBitmapProvider {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider");
			IntPtr class_ref;

			public static IBitmapProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBitmapProvider> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.gifdecoder.GifDecoder.BitmapProvider"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBitmapProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IBitmapProviderInvoker); }
			}

			static Delegate cb_obtain_IILandroid_graphics_Bitmap_Config_;
#pragma warning disable 0169
			static Delegate GetObtain_IILandroid_graphics_Bitmap_Config_Handler ()
			{
				if (cb_obtain_IILandroid_graphics_Bitmap_Config_ == null)
					cb_obtain_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_Obtain_IILandroid_graphics_Bitmap_Config_);
				return cb_obtain_IILandroid_graphics_Bitmap_Config_;
			}

			static IntPtr n_Obtain_IILandroid_graphics_Bitmap_Config_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				global::Com.Bumptech.Glide.Gifdecoder.GifDecoder.IBitmapProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder.IBitmapProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap.Config p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Obtain (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_obtain_IILandroid_graphics_Bitmap_Config_;
			public unsafe global::Android.Graphics.Bitmap Obtain (int p0, int p1, global::Android.Graphics.Bitmap.Config p2)
			{
				if (id_obtain_IILandroid_graphics_Bitmap_Config_ == IntPtr.Zero)
					id_obtain_IILandroid_graphics_Bitmap_Config_ = JNIEnv.GetMethodID (class_ref, "obtain", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_obtain_IILandroid_graphics_Bitmap_Config_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_release_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetRelease_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_release_Landroid_graphics_Bitmap_ == null)
					cb_release_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Release_Landroid_graphics_Bitmap_);
				return cb_release_Landroid_graphics_Bitmap_;
			}

			static void n_Release_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Gifdecoder.GifDecoder.IBitmapProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder.IBitmapProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Release (p0);
			}
#pragma warning restore 0169

			IntPtr id_release_Landroid_graphics_Bitmap_;
			public unsafe void Release (global::Android.Graphics.Bitmap p0)
			{
				if (id_release_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_release_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "release", "(Landroid/graphics/Bitmap;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_release_Landroid_graphics_Bitmap_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/gifdecoder/GifDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifDecoder); }
		}

		protected GifDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/constructor[@name='GifDecoder' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.gifdecoder.GifDecoder.BitmapProvider']]"
		[Register (".ctor", "(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;)V", "")]
		public unsafe GifDecoder (global::Com.Bumptech.Glide.Gifdecoder.GifDecoder.IBitmapProvider p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GifDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_, __args);
			} finally {
			}
		}

		static Delegate cb_getCurrentFrameIndex;
#pragma warning disable 0169
		static Delegate GetGetCurrentFrameIndexHandler ()
		{
			if (cb_getCurrentFrameIndex == null)
				cb_getCurrentFrameIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentFrameIndex);
			return cb_getCurrentFrameIndex;
		}

		static int n_GetCurrentFrameIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentFrameIndex;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentFrameIndex;
		public virtual unsafe int CurrentFrameIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='getCurrentFrameIndex' and count(parameter)=0]"
			[Register ("getCurrentFrameIndex", "()I", "GetGetCurrentFrameIndexHandler")]
			get {
				if (id_getCurrentFrameIndex == IntPtr.Zero)
					id_getCurrentFrameIndex = JNIEnv.GetMethodID (class_ref, "getCurrentFrameIndex", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCurrentFrameIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentFrameIndex", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFrameCount;
#pragma warning disable 0169
		static Delegate GetGetFrameCountHandler ()
		{
			if (cb_getFrameCount == null)
				cb_getFrameCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFrameCount);
			return cb_getFrameCount;
		}

		static int n_GetFrameCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrameCount;
		}
#pragma warning restore 0169

		static IntPtr id_getFrameCount;
		public virtual unsafe int FrameCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='getFrameCount' and count(parameter)=0]"
			[Register ("getFrameCount", "()I", "GetGetFrameCountHandler")]
			get {
				if (id_getFrameCount == IntPtr.Zero)
					id_getFrameCount = JNIEnv.GetMethodID (class_ref, "getFrameCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getFrameCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameCount", "()I"));
				} finally {
				}
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
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='getHeight' and count(parameter)=0]"
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

		static Delegate cb_getLoopCount;
#pragma warning disable 0169
		static Delegate GetGetLoopCountHandler ()
		{
			if (cb_getLoopCount == null)
				cb_getLoopCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLoopCount);
			return cb_getLoopCount;
		}

		static int n_GetLoopCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LoopCount;
		}
#pragma warning restore 0169

		static IntPtr id_getLoopCount;
		public virtual unsafe int LoopCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='getLoopCount' and count(parameter)=0]"
			[Register ("getLoopCount", "()I", "GetGetLoopCountHandler")]
			get {
				if (id_getLoopCount == IntPtr.Zero)
					id_getLoopCount = JNIEnv.GetMethodID (class_ref, "getLoopCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getLoopCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLoopCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNextDelay;
#pragma warning disable 0169
		static Delegate GetGetNextDelayHandler ()
		{
			if (cb_getNextDelay == null)
				cb_getNextDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNextDelay);
			return cb_getNextDelay;
		}

		static int n_GetNextDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextDelay;
		}
#pragma warning restore 0169

		static IntPtr id_getNextDelay;
		public virtual unsafe int NextDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='getNextDelay' and count(parameter)=0]"
			[Register ("getNextDelay", "()I", "GetGetNextDelayHandler")]
			get {
				if (id_getNextDelay == IntPtr.Zero)
					id_getNextDelay = JNIEnv.GetMethodID (class_ref, "getNextDelay", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNextDelay);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextDelay", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNextFrame;
#pragma warning disable 0169
		static Delegate GetGetNextFrameHandler ()
		{
			if (cb_getNextFrame == null)
				cb_getNextFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNextFrame);
			return cb_getNextFrame;
		}

		static IntPtr n_GetNextFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextFrame);
		}
#pragma warning restore 0169

		static IntPtr id_getNextFrame;
		public virtual unsafe global::Android.Graphics.Bitmap NextFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='getNextFrame' and count(parameter)=0]"
			[Register ("getNextFrame", "()Landroid/graphics/Bitmap;", "GetGetNextFrameHandler")]
			get {
				if (id_getNextFrame == IntPtr.Zero)
					id_getNextFrame = JNIEnv.GetMethodID (class_ref, "getNextFrame", "()Landroid/graphics/Bitmap;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getNextFrame), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextFrame", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Status;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		public virtual unsafe int Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='getStatus' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='getWidth' and count(parameter)=0]"
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

		static Delegate cb_advance;
#pragma warning disable 0169
		static Delegate GetAdvanceHandler ()
		{
			if (cb_advance == null)
				cb_advance = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Advance);
			return cb_advance;
		}

		static void n_Advance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Advance ();
		}
#pragma warning restore 0169

		static IntPtr id_advance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='advance' and count(parameter)=0]"
		[Register ("advance", "()V", "GetAdvanceHandler")]
		public virtual unsafe void Advance ()
		{
			if (id_advance == IntPtr.Zero)
				id_advance = JNIEnv.GetMethodID (class_ref, "advance", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_advance);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "advance", "()V"));
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
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='clear' and count(parameter)=0]"
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

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetData ());
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[B", "GetGetDataHandler")]
		public virtual unsafe byte[] GetData ()
		{
			if (id_getData == IntPtr.Zero)
				id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getData), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getDelay_I;
#pragma warning disable 0169
		static Delegate GetGetDelay_IHandler ()
		{
			if (cb_getDelay_I == null)
				cb_getDelay_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetDelay_I);
			return cb_getDelay_I;
		}

		static int n_GetDelay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDelay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getDelay_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='getDelay' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDelay", "(I)I", "GetGetDelay_IHandler")]
		public virtual unsafe int GetDelay (int p0)
		{
			if (id_getDelay_I == IntPtr.Zero)
				id_getDelay_I = JNIEnv.GetMethodID (class_ref, "getDelay", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDelay_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDelay", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_read_arrayB;
#pragma warning disable 0169
		static Delegate GetRead_arrayBHandler ()
		{
			if (cb_read_arrayB == null)
				cb_read_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Read_arrayB);
			return cb_read_arrayB;
		}

		static int n_Read_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_read_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("read", "([B)I", "GetRead_arrayBHandler")]
		public virtual unsafe int Read (byte[] p0)
		{
			if (id_read_arrayB == IntPtr.Zero)
				id_read_arrayB = JNIEnv.GetMethodID (class_ref, "read", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_read_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "([B)I"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_read_Ljava_io_InputStream_I;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_io_InputStream_IHandler ()
		{
			if (cb_read_Ljava_io_InputStream_I == null)
				cb_read_Ljava_io_InputStream_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_Read_Ljava_io_InputStream_I);
			return cb_read_Ljava_io_InputStream_I;
		}

		static int n_Read_Ljava_io_InputStream_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Read (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_io_InputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='read' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
		[Register ("read", "(Ljava/io/InputStream;I)I", "GetRead_Ljava_io_InputStream_IHandler")]
		public virtual unsafe int Read (global::System.IO.Stream p0, int p1)
		{
			if (id_read_Ljava_io_InputStream_I == IntPtr.Zero)
				id_read_Ljava_io_InputStream_I = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/io/InputStream;I)I");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_read_Ljava_io_InputStream_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/io/InputStream;I)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_resetFrameIndex;
#pragma warning disable 0169
		static Delegate GetResetFrameIndexHandler ()
		{
			if (cb_resetFrameIndex == null)
				cb_resetFrameIndex = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetFrameIndex);
			return cb_resetFrameIndex;
		}

		static void n_ResetFrameIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetFrameIndex ();
		}
#pragma warning restore 0169

		static IntPtr id_resetFrameIndex;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='resetFrameIndex' and count(parameter)=0]"
		[Register ("resetFrameIndex", "()V", "GetResetFrameIndexHandler")]
		public virtual unsafe void ResetFrameIndex ()
		{
			if (id_resetFrameIndex == IntPtr.Zero)
				id_resetFrameIndex = JNIEnv.GetMethodID (class_ref, "resetFrameIndex", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resetFrameIndex);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetFrameIndex", "()V"));
			} finally {
			}
		}

		static Delegate cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB;
#pragma warning disable 0169
		static Delegate GetSetData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayBHandler ()
		{
			if (cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB == null)
				cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB);
			return cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB;
		}

		static void n_SetData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Gifdecoder.GifHeader p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetData (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifdecoder']/class[@name='GifDecoder']/method[@name='setData' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.gifdecoder.GifHeader'] and parameter[2][@type='byte[]']]"
		[Register ("setData", "(Lcom/bumptech/glide/gifdecoder/GifHeader;[B)V", "GetSetData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayBHandler")]
		public virtual unsafe void SetData (global::Com.Bumptech.Glide.Gifdecoder.GifHeader p0, byte[] p1)
		{
			if (id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB == IntPtr.Zero)
				id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB = JNIEnv.GetMethodID (class_ref, "setData", "(Lcom/bumptech/glide/gifdecoder/GifHeader;[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Lcom/bumptech/glide/gifdecoder/GifHeader;[B)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
