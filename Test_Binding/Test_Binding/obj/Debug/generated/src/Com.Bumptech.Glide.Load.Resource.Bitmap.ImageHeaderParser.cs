using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Bitmap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/ImageHeaderParser", DoNotGenerateAcw=true)]
	public partial class ImageHeaderParser : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.ImageType']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType", DoNotGenerateAcw=true)]
		public sealed partial class ImageType : global::Java.Lang.Enum {


			static IntPtr GIF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.ImageType']/field[@name='GIF']"
			[Register ("GIF")]
			public static global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType Gif {
				get {
					if (GIF_jfieldId == IntPtr.Zero)
						GIF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GIF", "Lcom/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GIF_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr JPEG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.ImageType']/field[@name='JPEG']"
			[Register ("JPEG")]
			public static global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType Jpeg {
				get {
					if (JPEG_jfieldId == IntPtr.Zero)
						JPEG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JPEG", "Lcom/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JPEG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PNG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.ImageType']/field[@name='PNG']"
			[Register ("PNG")]
			public static global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType Png {
				get {
					if (PNG_jfieldId == IntPtr.Zero)
						PNG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PNG", "Lcom/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PNG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PNG_A_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.ImageType']/field[@name='PNG_A']"
			[Register ("PNG_A")]
			public static global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType PngA {
				get {
					if (PNG_A_jfieldId == IntPtr.Zero)
						PNG_A_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PNG_A", "Lcom/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PNG_A_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.ImageType']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ImageType); }
			}

			internal ImageType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_hasAlpha;
			public unsafe bool HasAlpha {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.ImageType']/method[@name='hasAlpha' and count(parameter)=0]"
				[Register ("hasAlpha", "()Z", "GetHasAlphaHandler")]
				get {
					if (id_hasAlpha == IntPtr.Zero)
						id_hasAlpha = JNIEnv.GetMethodID (class_ref, "hasAlpha", "()Z");
					try {
						return JNIEnv.CallBooleanMethod  (Handle, id_hasAlpha);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.ImageType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType;", "")]
			public static unsafe global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.ImageType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType;", "")]
			public static unsafe global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType;");
				try {
					return (global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.RandomAccessReader']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/ImageHeaderParser$RandomAccessReader", DoNotGenerateAcw=true)]
		public partial class RandomAccessReader : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/ImageHeaderParser$RandomAccessReader", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RandomAccessReader); }
			}

			protected RandomAccessReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_arrayB;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.RandomAccessReader']/constructor[@name='ImageHeaderParser.RandomAccessReader' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register (".ctor", "([B)V", "")]
			public unsafe RandomAccessReader (byte[] p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (RandomAccessReader)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([B)V", __args);
						return;
					}

					if (id_ctor_arrayB == IntPtr.Zero)
						id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayB, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_getInt16_I;
#pragma warning disable 0169
			static Delegate GetGetInt16_IHandler ()
			{
				if (cb_getInt16_I == null)
					cb_getInt16_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, short>) n_GetInt16_I);
				return cb_getInt16_I;
			}

			static short n_GetInt16_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.RandomAccessReader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.RandomAccessReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetInt16 (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getInt16_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.RandomAccessReader']/method[@name='getInt16' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getInt16", "(I)S", "GetGetInt16_IHandler")]
			public virtual unsafe short GetInt16 (int p0)
			{
				if (id_getInt16_I == IntPtr.Zero)
					id_getInt16_I = JNIEnv.GetMethodID (class_ref, "getInt16", "(I)S");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallShortMethod  (Handle, id_getInt16_I, __args);
					else
						return JNIEnv.CallNonvirtualShortMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInt16", "(I)S"), __args);
				} finally {
				}
			}

			static Delegate cb_getInt32_I;
#pragma warning disable 0169
			static Delegate GetGetInt32_IHandler ()
			{
				if (cb_getInt32_I == null)
					cb_getInt32_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetInt32_I);
				return cb_getInt32_I;
			}

			static int n_GetInt32_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.RandomAccessReader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.RandomAccessReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetInt32 (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getInt32_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.RandomAccessReader']/method[@name='getInt32' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getInt32", "(I)I", "GetGetInt32_IHandler")]
			public virtual unsafe int GetInt32 (int p0)
			{
				if (id_getInt32_I == IntPtr.Zero)
					id_getInt32_I = JNIEnv.GetMethodID (class_ref, "getInt32", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getInt32_I, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInt32", "(I)I"), __args);
				} finally {
				}
			}

			static Delegate cb_length;
#pragma warning disable 0169
			static Delegate GetLengthHandler ()
			{
				if (cb_length == null)
					cb_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Length);
				return cb_length;
			}

			static int n_Length (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.RandomAccessReader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.RandomAccessReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Length ();
			}
#pragma warning restore 0169

			static IntPtr id_length;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.RandomAccessReader']/method[@name='length' and count(parameter)=0]"
			[Register ("length", "()I", "GetLengthHandler")]
			public virtual unsafe int Length ()
			{
				if (id_length == IntPtr.Zero)
					id_length = JNIEnv.GetMethodID (class_ref, "length", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_length);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "length", "()I"));
				} finally {
				}
			}

			static Delegate cb_order_Ljava_nio_ByteOrder_;
#pragma warning disable 0169
			static Delegate GetOrder_Ljava_nio_ByteOrder_Handler ()
			{
				if (cb_order_Ljava_nio_ByteOrder_ == null)
					cb_order_Ljava_nio_ByteOrder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Order_Ljava_nio_ByteOrder_);
				return cb_order_Ljava_nio_ByteOrder_;
			}

			static void n_Order_Ljava_nio_ByteOrder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.RandomAccessReader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.RandomAccessReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteOrder p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteOrder> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Order (p0);
			}
#pragma warning restore 0169

			static IntPtr id_order_Ljava_nio_ByteOrder_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.RandomAccessReader']/method[@name='order' and count(parameter)=1 and parameter[1][@type='java.nio.ByteOrder']]"
			[Register ("order", "(Ljava/nio/ByteOrder;)V", "GetOrder_Ljava_nio_ByteOrder_Handler")]
			public virtual unsafe void Order (global::Java.Nio.ByteOrder p0)
			{
				if (id_order_Ljava_nio_ByteOrder_ == IntPtr.Zero)
					id_order_Ljava_nio_ByteOrder_ = JNIEnv.GetMethodID (class_ref, "order", "(Ljava/nio/ByteOrder;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_order_Ljava_nio_ByteOrder_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "order", "(Ljava/nio/ByteOrder;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.StreamReader']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bitmap/ImageHeaderParser$StreamReader", DoNotGenerateAcw=true)]
		public partial class StreamReader : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/ImageHeaderParser$StreamReader", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StreamReader); }
			}

			protected StreamReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_InputStream_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.StreamReader']/constructor[@name='ImageHeaderParser.StreamReader' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
			public unsafe StreamReader (global::System.IO.Stream p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (StreamReader)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
						id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_getByte;
#pragma warning disable 0169
			static Delegate GetGetByteHandler ()
			{
				if (cb_getByte == null)
					cb_getByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetByte);
				return cb_getByte;
			}

			static int n_GetByte (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.StreamReader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.StreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Byte;
			}
#pragma warning restore 0169

			static IntPtr id_getByte;
			public virtual unsafe int Byte {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.StreamReader']/method[@name='getByte' and count(parameter)=0]"
				[Register ("getByte", "()I", "GetGetByteHandler")]
				get {
					if (id_getByte == IntPtr.Zero)
						id_getByte = JNIEnv.GetMethodID (class_ref, "getByte", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod  (Handle, id_getByte);
						else
							return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getByte", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getUInt16;
#pragma warning disable 0169
			static Delegate GetGetUInt16Handler ()
			{
				if (cb_getUInt16 == null)
					cb_getUInt16 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUInt16);
				return cb_getUInt16;
			}

			static int n_GetUInt16 (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.StreamReader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.StreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.UInt16;
			}
#pragma warning restore 0169

			static IntPtr id_getUInt16;
			public virtual unsafe int UInt16 {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.StreamReader']/method[@name='getUInt16' and count(parameter)=0]"
				[Register ("getUInt16", "()I", "GetGetUInt16Handler")]
				get {
					if (id_getUInt16 == IntPtr.Zero)
						id_getUInt16 = JNIEnv.GetMethodID (class_ref, "getUInt16", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod  (Handle, id_getUInt16);
						else
							return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUInt16", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getUInt8;
#pragma warning disable 0169
			static Delegate GetGetUInt8Handler ()
			{
				if (cb_getUInt8 == null)
					cb_getUInt8 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetUInt8);
				return cb_getUInt8;
			}

			static short n_GetUInt8 (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.StreamReader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.StreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.UInt8;
			}
#pragma warning restore 0169

			static IntPtr id_getUInt8;
			public virtual unsafe short UInt8 {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.StreamReader']/method[@name='getUInt8' and count(parameter)=0]"
				[Register ("getUInt8", "()S", "GetGetUInt8Handler")]
				get {
					if (id_getUInt8 == IntPtr.Zero)
						id_getUInt8 = JNIEnv.GetMethodID (class_ref, "getUInt8", "()S");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallShortMethod  (Handle, id_getUInt8);
						else
							return JNIEnv.CallNonvirtualShortMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUInt8", "()S"));
					} finally {
					}
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
				global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.StreamReader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.StreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Read (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_read_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.StreamReader']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

			static Delegate cb_skip_J;
#pragma warning disable 0169
			static Delegate GetSkip_JHandler ()
			{
				if (cb_skip_J == null)
					cb_skip_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long>) n_Skip_J);
				return cb_skip_J;
			}

			static long n_Skip_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.StreamReader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.StreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Skip (p0);
			}
#pragma warning restore 0169

			static IntPtr id_skip_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser.StreamReader']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("skip", "(J)J", "GetSkip_JHandler")]
			public virtual unsafe long Skip (long p0)
			{
				if (id_skip_J == IntPtr.Zero)
					id_skip_J = JNIEnv.GetMethodID (class_ref, "skip", "(J)J");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_skip_J, __args);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skip", "(J)J"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bitmap/ImageHeaderParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageHeaderParser); }
		}

		protected ImageHeaderParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser']/constructor[@name='ImageHeaderParser' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe ImageHeaderParser (global::System.IO.Stream p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (ImageHeaderParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_hasAlpha;
#pragma warning disable 0169
		static Delegate GetHasAlphaHandler ()
		{
			if (cb_hasAlpha == null)
				cb_hasAlpha = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAlpha);
			return cb_hasAlpha;
		}

		static bool n_HasAlpha (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAlpha;
		}
#pragma warning restore 0169

		static IntPtr id_hasAlpha;
		public virtual unsafe bool HasAlpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser']/method[@name='hasAlpha' and count(parameter)=0]"
			[Register ("hasAlpha", "()Z", "GetHasAlphaHandler")]
			get {
				if (id_hasAlpha == IntPtr.Zero)
					id_hasAlpha = JNIEnv.GetMethodID (class_ref, "hasAlpha", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasAlpha);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasAlpha", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOrientation);
			return cb_getOrientation;
		}

		static int n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Orientation;
		}
#pragma warning restore 0169

		static IntPtr id_getOrientation;
		public virtual unsafe int Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()I", "GetGetOrientationHandler")]
			get {
				if (id_getOrientation == IntPtr.Zero)
					id_getOrientation = JNIEnv.GetMethodID (class_ref, "getOrientation", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getOrientation);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientation", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bitmap']/class[@name='ImageHeaderParser']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bitmap.ImageHeaderParser.ImageType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/bumptech/glide/load/resource/bitmap/ImageHeaderParser$ImageType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
