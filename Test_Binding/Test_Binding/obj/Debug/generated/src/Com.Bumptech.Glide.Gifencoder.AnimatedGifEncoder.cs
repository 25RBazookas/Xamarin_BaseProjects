using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Gifencoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.gifencoder']/class[@name='AnimatedGifEncoder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/gifencoder/AnimatedGifEncoder", DoNotGenerateAcw=true)]
	public partial class AnimatedGifEncoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/gifencoder/AnimatedGifEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimatedGifEncoder); }
		}

		protected AnimatedGifEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.gifencoder']/class[@name='AnimatedGifEncoder']/constructor[@name='AnimatedGifEncoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnimatedGifEncoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AnimatedGifEncoder)) {
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

		static Delegate cb_addFrame_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetAddFrame_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_addFrame_Landroid_graphics_Bitmap_ == null)
				cb_addFrame_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddFrame_Landroid_graphics_Bitmap_);
			return cb_addFrame_Landroid_graphics_Bitmap_;
		}

		static bool n_AddFrame_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddFrame (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addFrame_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifencoder']/class[@name='AnimatedGifEncoder']/method[@name='addFrame' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("addFrame", "(Landroid/graphics/Bitmap;)Z", "GetAddFrame_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe bool AddFrame (global::Android.Graphics.Bitmap p0)
		{
			if (id_addFrame_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_addFrame_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "addFrame", "(Landroid/graphics/Bitmap;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_addFrame_Landroid_graphics_Bitmap_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFrame", "(Landroid/graphics/Bitmap;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Finish);
			return cb_finish;
		}

		static bool n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Finish ();
		}
#pragma warning restore 0169

		static IntPtr id_finish;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifencoder']/class[@name='AnimatedGifEncoder']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()Z", "GetFinishHandler")]
		public virtual unsafe bool Finish ()
		{
			if (id_finish == IntPtr.Zero)
				id_finish = JNIEnv.GetMethodID (class_ref, "finish", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_finish);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finish", "()Z"));
			} finally {
			}
		}

		static Delegate cb_setDelay_I;
#pragma warning disable 0169
		static Delegate GetSetDelay_IHandler ()
		{
			if (cb_setDelay_I == null)
				cb_setDelay_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDelay_I);
			return cb_setDelay_I;
		}

		static void n_SetDelay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDelay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDelay_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifencoder']/class[@name='AnimatedGifEncoder']/method[@name='setDelay' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDelay", "(I)V", "GetSetDelay_IHandler")]
		public virtual unsafe void SetDelay (int p0)
		{
			if (id_setDelay_I == IntPtr.Zero)
				id_setDelay_I = JNIEnv.GetMethodID (class_ref, "setDelay", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDelay_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDelay", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDispose_I;
#pragma warning disable 0169
		static Delegate GetSetDispose_IHandler ()
		{
			if (cb_setDispose_I == null)
				cb_setDispose_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDispose_I);
			return cb_setDispose_I;
		}

		static void n_SetDispose_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDispose (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDispose_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifencoder']/class[@name='AnimatedGifEncoder']/method[@name='setDispose' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDispose", "(I)V", "GetSetDispose_IHandler")]
		public virtual unsafe void SetDispose (int p0)
		{
			if (id_setDispose_I == IntPtr.Zero)
				id_setDispose_I = JNIEnv.GetMethodID (class_ref, "setDispose", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDispose_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDispose", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setFrameRate_F;
#pragma warning disable 0169
		static Delegate GetSetFrameRate_FHandler ()
		{
			if (cb_setFrameRate_F == null)
				cb_setFrameRate_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetFrameRate_F);
			return cb_setFrameRate_F;
		}

		static void n_SetFrameRate_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFrameRate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFrameRate_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifencoder']/class[@name='AnimatedGifEncoder']/method[@name='setFrameRate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setFrameRate", "(F)V", "GetSetFrameRate_FHandler")]
		public virtual unsafe void SetFrameRate (float p0)
		{
			if (id_setFrameRate_F == IntPtr.Zero)
				id_setFrameRate_F = JNIEnv.GetMethodID (class_ref, "setFrameRate", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFrameRate_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFrameRate", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setQuality_I;
#pragma warning disable 0169
		static Delegate GetSetQuality_IHandler ()
		{
			if (cb_setQuality_I == null)
				cb_setQuality_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetQuality_I);
			return cb_setQuality_I;
		}

		static void n_SetQuality_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetQuality (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setQuality_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifencoder']/class[@name='AnimatedGifEncoder']/method[@name='setQuality' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setQuality", "(I)V", "GetSetQuality_IHandler")]
		public virtual unsafe void SetQuality (int p0)
		{
			if (id_setQuality_I == IntPtr.Zero)
				id_setQuality_I = JNIEnv.GetMethodID (class_ref, "setQuality", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setQuality_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQuality", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRepeat_I;
#pragma warning disable 0169
		static Delegate GetSetRepeat_IHandler ()
		{
			if (cb_setRepeat_I == null)
				cb_setRepeat_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRepeat_I);
			return cb_setRepeat_I;
		}

		static void n_SetRepeat_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRepeat (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRepeat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifencoder']/class[@name='AnimatedGifEncoder']/method[@name='setRepeat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRepeat", "(I)V", "GetSetRepeat_IHandler")]
		public virtual unsafe void SetRepeat (int p0)
		{
			if (id_setRepeat_I == IntPtr.Zero)
				id_setRepeat_I = JNIEnv.GetMethodID (class_ref, "setRepeat", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRepeat_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRepeat", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSize_II;
#pragma warning disable 0169
		static Delegate GetSetSize_IIHandler ()
		{
			if (cb_setSize_II == null)
				cb_setSize_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetSize_II);
			return cb_setSize_II;
		}

		static void n_SetSize_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSize_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifencoder']/class[@name='AnimatedGifEncoder']/method[@name='setSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setSize", "(II)V", "GetSetSize_IIHandler")]
		public virtual unsafe void SetSize (int p0, int p1)
		{
			if (id_setSize_II == IntPtr.Zero)
				id_setSize_II = JNIEnv.GetMethodID (class_ref, "setSize", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSize_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSize", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTransparent_I;
#pragma warning disable 0169
		static Delegate GetSetTransparent_IHandler ()
		{
			if (cb_setTransparent_I == null)
				cb_setTransparent_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTransparent_I);
			return cb_setTransparent_I;
		}

		static void n_SetTransparent_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTransparent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTransparent_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifencoder']/class[@name='AnimatedGifEncoder']/method[@name='setTransparent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTransparent", "(I)V", "GetSetTransparent_IHandler")]
		public virtual unsafe void SetTransparent (int p0)
		{
			if (id_setTransparent_I == IntPtr.Zero)
				id_setTransparent_I = JNIEnv.GetMethodID (class_ref, "setTransparent", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTransparent_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransparent", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetStart_Ljava_io_OutputStream_Handler ()
		{
			if (cb_start_Ljava_io_OutputStream_ == null)
				cb_start_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Start_Ljava_io_OutputStream_);
			return cb_start_Ljava_io_OutputStream_;
		}

		static bool n_Start_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Start (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_start_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifencoder']/class[@name='AnimatedGifEncoder']/method[@name='start' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("start", "(Ljava/io/OutputStream;)Z", "GetStart_Ljava_io_OutputStream_Handler")]
		public virtual unsafe bool Start (global::System.IO.Stream p0)
		{
			if (id_start_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_start_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "start", "(Ljava/io/OutputStream;)Z");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_start_Ljava_io_OutputStream_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "(Ljava/io/OutputStream;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_start_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStart_Ljava_lang_String_Handler ()
		{
			if (cb_start_Ljava_lang_String_ == null)
				cb_start_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Start_Ljava_lang_String_);
			return cb_start_Ljava_lang_String_;
		}

		static bool n_Start_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifencoder.AnimatedGifEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Start (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_start_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.gifencoder']/class[@name='AnimatedGifEncoder']/method[@name='start' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("start", "(Ljava/lang/String;)Z", "GetStart_Ljava_lang_String_Handler")]
		public virtual unsafe bool Start (string p0)
		{
			if (id_start_Ljava_lang_String_ == IntPtr.Zero)
				id_start_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "start", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_start_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
