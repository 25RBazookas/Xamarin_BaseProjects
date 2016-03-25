using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Gif {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceDecoder']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/gif/GifResourceDecoder", DoNotGenerateAcw=true)]
	public partial class GifResourceDecoder : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.IResourceDecoder {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceDecoder.GifDecoderPool']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/gif/GifResourceDecoder$GifDecoderPool", DoNotGenerateAcw=true)]
		public partial class GifDecoderPool : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/resource/gif/GifResourceDecoder$GifDecoderPool", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GifDecoderPool); }
			}

			protected GifDecoderPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_obtain_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_;
#pragma warning disable 0169
			static Delegate GetObtain_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_Handler ()
			{
				if (cb_obtain_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_ == null)
					cb_obtain_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Obtain_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_);
				return cb_obtain_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_;
			}

			static IntPtr n_Obtain_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceDecoder.GifDecoderPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceDecoder.GifDecoderPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Bumptech.Glide.Gifdecoder.GifDecoder.IBitmapProvider p0 = (global::Com.Bumptech.Glide.Gifdecoder.GifDecoder.IBitmapProvider)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder.IBitmapProvider> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Obtain (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_obtain_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceDecoder.GifDecoderPool']/method[@name='obtain' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.gifdecoder.GifDecoder.BitmapProvider']]"
			[Register ("obtain", "(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;)Lcom/bumptech/glide/gifdecoder/GifDecoder;", "GetObtain_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_Handler")]
			public virtual unsafe global::Com.Bumptech.Glide.Gifdecoder.GifDecoder Obtain (global::Com.Bumptech.Glide.Gifdecoder.GifDecoder.IBitmapProvider p0)
			{
				if (id_obtain_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_ == IntPtr.Zero)
					id_obtain_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_ = JNIEnv.GetMethodID (class_ref, "obtain", "(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;)Lcom/bumptech/glide/gifdecoder/GifDecoder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Bumptech.Glide.Gifdecoder.GifDecoder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (JNIEnv.CallObjectMethod  (Handle, id_obtain_Lcom_bumptech_glide_gifdecoder_GifDecoder_BitmapProvider_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "obtain", "(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;)Lcom/bumptech/glide/gifdecoder/GifDecoder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_release_Lcom_bumptech_glide_gifdecoder_GifDecoder_;
#pragma warning disable 0169
			static Delegate GetRelease_Lcom_bumptech_glide_gifdecoder_GifDecoder_Handler ()
			{
				if (cb_release_Lcom_bumptech_glide_gifdecoder_GifDecoder_ == null)
					cb_release_Lcom_bumptech_glide_gifdecoder_GifDecoder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Release_Lcom_bumptech_glide_gifdecoder_GifDecoder_);
				return cb_release_Lcom_bumptech_glide_gifdecoder_GifDecoder_;
			}

			static void n_Release_Lcom_bumptech_glide_gifdecoder_GifDecoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceDecoder.GifDecoderPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceDecoder.GifDecoderPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Bumptech.Glide.Gifdecoder.GifDecoder p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifDecoder> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Release (p0);
			}
#pragma warning restore 0169

			static IntPtr id_release_Lcom_bumptech_glide_gifdecoder_GifDecoder_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceDecoder.GifDecoderPool']/method[@name='release' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.gifdecoder.GifDecoder']]"
			[Register ("release", "(Lcom/bumptech/glide/gifdecoder/GifDecoder;)V", "GetRelease_Lcom_bumptech_glide_gifdecoder_GifDecoder_Handler")]
			public virtual unsafe void Release (global::Com.Bumptech.Glide.Gifdecoder.GifDecoder p0)
			{
				if (id_release_Lcom_bumptech_glide_gifdecoder_GifDecoder_ == IntPtr.Zero)
					id_release_Lcom_bumptech_glide_gifdecoder_GifDecoder_ = JNIEnv.GetMethodID (class_ref, "release", "(Lcom/bumptech/glide/gifdecoder/GifDecoder;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_release_Lcom_bumptech_glide_gifdecoder_GifDecoder_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "(Lcom/bumptech/glide/gifdecoder/GifDecoder;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceDecoder.GifHeaderParserPool']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/gif/GifResourceDecoder$GifHeaderParserPool", DoNotGenerateAcw=true)]
		public partial class GifHeaderParserPool : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/resource/gif/GifResourceDecoder$GifHeaderParserPool", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GifHeaderParserPool); }
			}

			protected GifHeaderParserPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_obtain_arrayB;
#pragma warning disable 0169
			static Delegate GetObtain_arrayBHandler ()
			{
				if (cb_obtain_arrayB == null)
					cb_obtain_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Obtain_arrayB);
				return cb_obtain_arrayB;
			}

			static IntPtr n_Obtain_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceDecoder.GifHeaderParserPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceDecoder.GifHeaderParserPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Obtain (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_obtain_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceDecoder.GifHeaderParserPool']/method[@name='obtain' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("obtain", "([B)Lcom/bumptech/glide/gifdecoder/GifHeaderParser;", "GetObtain_arrayBHandler")]
			public virtual unsafe global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser Obtain (byte[] p0)
			{
				if (id_obtain_arrayB == IntPtr.Zero)
					id_obtain_arrayB = JNIEnv.GetMethodID (class_ref, "obtain", "([B)Lcom/bumptech/glide/gifdecoder/GifHeaderParser;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser> (JNIEnv.CallObjectMethod  (Handle, id_obtain_arrayB, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "obtain", "([B)Lcom/bumptech/glide/gifdecoder/GifHeaderParser;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_release_Lcom_bumptech_glide_gifdecoder_GifHeaderParser_;
#pragma warning disable 0169
			static Delegate GetRelease_Lcom_bumptech_glide_gifdecoder_GifHeaderParser_Handler ()
			{
				if (cb_release_Lcom_bumptech_glide_gifdecoder_GifHeaderParser_ == null)
					cb_release_Lcom_bumptech_glide_gifdecoder_GifHeaderParser_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Release_Lcom_bumptech_glide_gifdecoder_GifHeaderParser_);
				return cb_release_Lcom_bumptech_glide_gifdecoder_GifHeaderParser_;
			}

			static void n_Release_Lcom_bumptech_glide_gifdecoder_GifHeaderParser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceDecoder.GifHeaderParserPool __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceDecoder.GifHeaderParserPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Release (p0);
			}
#pragma warning restore 0169

			static IntPtr id_release_Lcom_bumptech_glide_gifdecoder_GifHeaderParser_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceDecoder.GifHeaderParserPool']/method[@name='release' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.gifdecoder.GifHeaderParser']]"
			[Register ("release", "(Lcom/bumptech/glide/gifdecoder/GifHeaderParser;)V", "GetRelease_Lcom_bumptech_glide_gifdecoder_GifHeaderParser_Handler")]
			public virtual unsafe void Release (global::Com.Bumptech.Glide.Gifdecoder.GifHeaderParser p0)
			{
				if (id_release_Lcom_bumptech_glide_gifdecoder_GifHeaderParser_ == IntPtr.Zero)
					id_release_Lcom_bumptech_glide_gifdecoder_GifHeaderParser_ = JNIEnv.GetMethodID (class_ref, "release", "(Lcom/bumptech/glide/gifdecoder/GifHeaderParser;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_release_Lcom_bumptech_glide_gifdecoder_GifHeaderParser_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "(Lcom/bumptech/glide/gifdecoder/GifHeaderParser;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/gif/GifResourceDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifResourceDecoder); }
		}

		protected GifResourceDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceDecoder']/constructor[@name='GifResourceDecoder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", "")]
		public unsafe GifResourceDecoder (global::Android.Content.Context p0, global::Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (GifResourceDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceDecoder']/constructor[@name='GifResourceDecoder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe GifResourceDecoder (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GifResourceDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceDecoder']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_decode_Ljava_io_InputStream_II;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_io_InputStream_IIHandler ()
		{
			if (cb_decode_Ljava_io_InputStream_II == null)
				cb_decode_Ljava_io_InputStream_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Decode_Ljava_io_InputStream_II);
			return cb_decode_Ljava_io_InputStream_II;
		}

		static IntPtr n_Decode_Ljava_io_InputStream_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifResourceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_io_InputStream_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifResourceDecoder']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("decode", "(Ljava/io/InputStream;II)Lcom/bumptech/glide/load/resource/gif/GifDrawableResource;", "GetDecode_Ljava_io_InputStream_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawableResource Decode (global::System.IO.Stream p0, int p1, int p2)
		{
			if (id_decode_Ljava_io_InputStream_II == IntPtr.Zero)
				id_decode_Ljava_io_InputStream_II = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/io/InputStream;II)Lcom/bumptech/glide/load/resource/gif/GifDrawableResource;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawableResource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawableResource> (JNIEnv.CallObjectMethod  (Handle, id_decode_Ljava_io_InputStream_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawableResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/io/InputStream;II)Lcom/bumptech/glide/load/resource/gif/GifDrawableResource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.IResourceDecoder
		global::Com.Bumptech.Glide.Load.Engine.IResource global::Com.Bumptech.Glide.Load.IResourceDecoder.Decode (global::Java.Lang.Object p0, int p1, int p2)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Bumptech.Glide.Load.Engine.IResource>(Decode (global::Java.Interop.JavaObjectExtensions.JavaCast<global::System.IO.Stream>(p0), p1, p2));
		}

	}
}
