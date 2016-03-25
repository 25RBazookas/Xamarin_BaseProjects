using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/data/MediaStoreThumbFetcher", DoNotGenerateAcw=true)]
	public partial class MediaStoreThumbFetcher : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Data.IDataFetcher {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher.FileService']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/data/MediaStoreThumbFetcher$FileService", DoNotGenerateAcw=true)]
		public partial class FileService : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/data/MediaStoreThumbFetcher$FileService", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FileService); }
			}

			protected FileService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_exists_Ljava_io_File_;
#pragma warning disable 0169
			static Delegate GetExists_Ljava_io_File_Handler ()
			{
				if (cb_exists_Ljava_io_File_ == null)
					cb_exists_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Exists_Ljava_io_File_);
				return cb_exists_Ljava_io_File_;
			}

			static bool n_Exists_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.FileService __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.FileService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Exists (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_exists_Ljava_io_File_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher.FileService']/method[@name='exists' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
			[Register ("exists", "(Ljava/io/File;)Z", "GetExists_Ljava_io_File_Handler")]
			public virtual unsafe bool Exists (global::Java.IO.File p0)
			{
				if (id_exists_Ljava_io_File_ == IntPtr.Zero)
					id_exists_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "exists", "(Ljava/io/File;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod  (Handle, id_exists_Ljava_io_File_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "exists", "(Ljava/io/File;)Z"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGet_Ljava_lang_String_Handler ()
			{
				if (cb_get_Ljava_lang_String_ == null)
					cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
				return cb_get_Ljava_lang_String_;
			}

			static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.FileService __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.FileService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_get_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher.FileService']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("get", "(Ljava/lang/String;)Ljava/io/File;", "GetGet_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.IO.File Get (string p0)
			{
				if (id_get_Ljava_lang_String_ == IntPtr.Zero)
					id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/io/File;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.IO.File __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)Ljava/io/File;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_length_Ljava_io_File_;
#pragma warning disable 0169
			static Delegate GetLength_Ljava_io_File_Handler ()
			{
				if (cb_length_Ljava_io_File_ == null)
					cb_length_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_Length_Ljava_io_File_);
				return cb_length_Ljava_io_File_;
			}

			static long n_Length_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.FileService __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.FileService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
				long __ret = __this.Length (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_length_Ljava_io_File_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher.FileService']/method[@name='length' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
			[Register ("length", "(Ljava/io/File;)J", "GetLength_Ljava_io_File_Handler")]
			public virtual unsafe long Length (global::Java.IO.File p0)
			{
				if (id_length_Ljava_io_File_ == IntPtr.Zero)
					id_length_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "length", "(Ljava/io/File;)J");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					long __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallLongMethod  (Handle, id_length_Ljava_io_File_, __args);
					else
						__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "length", "(Ljava/io/File;)J"), __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher.ImageThumbnailQuery']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/data/MediaStoreThumbFetcher$ImageThumbnailQuery", DoNotGenerateAcw=true)]
		public partial class ImageThumbnailQuery : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.IThumbnailQuery {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/data/MediaStoreThumbFetcher$ImageThumbnailQuery", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ImageThumbnailQuery); }
			}

			protected ImageThumbnailQuery (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_queryPath_Landroid_content_Context_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetQueryPath_Landroid_content_Context_Landroid_net_Uri_Handler ()
			{
				if (cb_queryPath_Landroid_content_Context_Landroid_net_Uri_ == null)
					cb_queryPath_Landroid_content_Context_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_QueryPath_Landroid_content_Context_Landroid_net_Uri_);
				return cb_queryPath_Landroid_content_Context_Landroid_net_Uri_;
			}

			static IntPtr n_QueryPath_Landroid_content_Context_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.ImageThumbnailQuery __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.ImageThumbnailQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.QueryPath (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_queryPath_Landroid_content_Context_Landroid_net_Uri_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher.ImageThumbnailQuery']/method[@name='queryPath' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
			[Register ("queryPath", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/database/Cursor;", "GetQueryPath_Landroid_content_Context_Landroid_net_Uri_Handler")]
			public virtual unsafe global::Android.Database.ICursor QueryPath (global::Android.Content.Context p0, global::Android.Net.Uri p1)
			{
				if (id_queryPath_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
					id_queryPath_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "queryPath", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/database/Cursor;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Android.Database.ICursor __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod  (Handle, id_queryPath_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "queryPath", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/database/Cursor;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.data']/interface[@name='MediaStoreThumbFetcher.ThumbnailQuery']"
		[Register ("com/bumptech/glide/load/data/MediaStoreThumbFetcher$ThumbnailQuery", "", "Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher/IThumbnailQueryInvoker")]
		public partial interface IThumbnailQuery : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/interface[@name='MediaStoreThumbFetcher.ThumbnailQuery']/method[@name='queryPath' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
			[Register ("queryPath", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/database/Cursor;", "GetQueryPath_Landroid_content_Context_Landroid_net_Uri_Handler:Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher/IThumbnailQueryInvoker, Test_Binding")]
			global::Android.Database.ICursor QueryPath (global::Android.Content.Context p0, global::Android.Net.Uri p1);

		}

		[global::Android.Runtime.Register ("com/bumptech/glide/load/data/MediaStoreThumbFetcher$ThumbnailQuery", DoNotGenerateAcw=true)]
		internal class IThumbnailQueryInvoker : global::Java.Lang.Object, IThumbnailQuery {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/data/MediaStoreThumbFetcher$ThumbnailQuery");
			IntPtr class_ref;

			public static IThumbnailQuery GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IThumbnailQuery> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.data.MediaStoreThumbFetcher.ThumbnailQuery"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IThumbnailQueryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IThumbnailQueryInvoker); }
			}

			static Delegate cb_queryPath_Landroid_content_Context_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetQueryPath_Landroid_content_Context_Landroid_net_Uri_Handler ()
			{
				if (cb_queryPath_Landroid_content_Context_Landroid_net_Uri_ == null)
					cb_queryPath_Landroid_content_Context_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_QueryPath_Landroid_content_Context_Landroid_net_Uri_);
				return cb_queryPath_Landroid_content_Context_Landroid_net_Uri_;
			}

			static IntPtr n_QueryPath_Landroid_content_Context_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.IThumbnailQuery __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.IThumbnailQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.QueryPath (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_queryPath_Landroid_content_Context_Landroid_net_Uri_;
			public unsafe global::Android.Database.ICursor QueryPath (global::Android.Content.Context p0, global::Android.Net.Uri p1)
			{
				if (id_queryPath_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
					id_queryPath_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "queryPath", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/database/Cursor;");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Database.ICursor __ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (Handle, id_queryPath_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher.ThumbnailStreamOpener']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/data/MediaStoreThumbFetcher$ThumbnailStreamOpener", DoNotGenerateAcw=true)]
		public partial class ThumbnailStreamOpener : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/data/MediaStoreThumbFetcher$ThumbnailStreamOpener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ThumbnailStreamOpener); }
			}

			protected ThumbnailStreamOpener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_bumptech_glide_load_data_MediaStoreThumbFetcher_ThumbnailQuery_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher.ThumbnailStreamOpener']/constructor[@name='MediaStoreThumbFetcher.ThumbnailStreamOpener' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.data.MediaStoreThumbFetcher.ThumbnailQuery']]"
			[Register (".ctor", "(Lcom/bumptech/glide/load/data/MediaStoreThumbFetcher$ThumbnailQuery;)V", "")]
			public unsafe ThumbnailStreamOpener (global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.IThumbnailQuery p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (ThumbnailStreamOpener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/data/MediaStoreThumbFetcher$ThumbnailQuery;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/data/MediaStoreThumbFetcher$ThumbnailQuery;)V", __args);
						return;
					}

					if (id_ctor_Lcom_bumptech_glide_load_data_MediaStoreThumbFetcher_ThumbnailQuery_ == IntPtr.Zero)
						id_ctor_Lcom_bumptech_glide_load_data_MediaStoreThumbFetcher_ThumbnailQuery_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/data/MediaStoreThumbFetcher$ThumbnailQuery;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_data_MediaStoreThumbFetcher_ThumbnailQuery_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_data_MediaStoreThumbFetcher_ThumbnailQuery_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Lcom_bumptech_glide_load_data_MediaStoreThumbFetcher_FileService_Lcom_bumptech_glide_load_data_MediaStoreThumbFetcher_ThumbnailQuery_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher.ThumbnailStreamOpener']/constructor[@name='MediaStoreThumbFetcher.ThumbnailStreamOpener' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.data.MediaStoreThumbFetcher.FileService'] and parameter[2][@type='com.bumptech.glide.load.data.MediaStoreThumbFetcher.ThumbnailQuery']]"
			[Register (".ctor", "(Lcom/bumptech/glide/load/data/MediaStoreThumbFetcher$FileService;Lcom/bumptech/glide/load/data/MediaStoreThumbFetcher$ThumbnailQuery;)V", "")]
			public unsafe ThumbnailStreamOpener (global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.FileService p0, global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.IThumbnailQuery p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (ThumbnailStreamOpener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/data/MediaStoreThumbFetcher$FileService;Lcom/bumptech/glide/load/data/MediaStoreThumbFetcher$ThumbnailQuery;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/data/MediaStoreThumbFetcher$FileService;Lcom/bumptech/glide/load/data/MediaStoreThumbFetcher$ThumbnailQuery;)V", __args);
						return;
					}

					if (id_ctor_Lcom_bumptech_glide_load_data_MediaStoreThumbFetcher_FileService_Lcom_bumptech_glide_load_data_MediaStoreThumbFetcher_ThumbnailQuery_ == IntPtr.Zero)
						id_ctor_Lcom_bumptech_glide_load_data_MediaStoreThumbFetcher_FileService_Lcom_bumptech_glide_load_data_MediaStoreThumbFetcher_ThumbnailQuery_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/data/MediaStoreThumbFetcher$FileService;Lcom/bumptech/glide/load/data/MediaStoreThumbFetcher$ThumbnailQuery;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_data_MediaStoreThumbFetcher_FileService_Lcom_bumptech_glide_load_data_MediaStoreThumbFetcher_ThumbnailQuery_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_data_MediaStoreThumbFetcher_FileService_Lcom_bumptech_glide_load_data_MediaStoreThumbFetcher_ThumbnailQuery_, __args);
				} finally {
				}
			}

			static Delegate cb_getOrientation_Landroid_content_Context_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetGetOrientation_Landroid_content_Context_Landroid_net_Uri_Handler ()
			{
				if (cb_getOrientation_Landroid_content_Context_Landroid_net_Uri_ == null)
					cb_getOrientation_Landroid_content_Context_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_GetOrientation_Landroid_content_Context_Landroid_net_Uri_);
				return cb_getOrientation_Landroid_content_Context_Landroid_net_Uri_;
			}

			static int n_GetOrientation_Landroid_content_Context_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.ThumbnailStreamOpener __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.ThumbnailStreamOpener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetOrientation (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getOrientation_Landroid_content_Context_Landroid_net_Uri_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher.ThumbnailStreamOpener']/method[@name='getOrientation' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
			[Register ("getOrientation", "(Landroid/content/Context;Landroid/net/Uri;)I", "GetGetOrientation_Landroid_content_Context_Landroid_net_Uri_Handler")]
			public virtual unsafe int GetOrientation (global::Android.Content.Context p0, global::Android.Net.Uri p1)
			{
				if (id_getOrientation_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
					id_getOrientation_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getOrientation", "(Landroid/content/Context;Landroid/net/Uri;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod  (Handle, id_getOrientation_Landroid_content_Context_Landroid_net_Uri_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientation", "(Landroid/content/Context;Landroid/net/Uri;)I"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_open_Landroid_content_Context_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetOpen_Landroid_content_Context_Landroid_net_Uri_Handler ()
			{
				if (cb_open_Landroid_content_Context_Landroid_net_Uri_ == null)
					cb_open_Landroid_content_Context_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Open_Landroid_content_Context_Landroid_net_Uri_);
				return cb_open_Landroid_content_Context_Landroid_net_Uri_;
			}

			static IntPtr n_Open_Landroid_content_Context_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.ThumbnailStreamOpener __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.ThumbnailStreamOpener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Open (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_open_Landroid_content_Context_Landroid_net_Uri_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher.ThumbnailStreamOpener']/method[@name='open' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
			[Register ("open", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/io/InputStream;", "GetOpen_Landroid_content_Context_Landroid_net_Uri_Handler")]
			public virtual unsafe global::System.IO.Stream Open (global::Android.Content.Context p0, global::Android.Net.Uri p1)
			{
				if (id_open_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
					id_open_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "open", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/io/InputStream;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::System.IO.Stream __ret;
					if (GetType () == ThresholdType)
						__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_open_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher.ThumbnailStreamOpenerFactory']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/data/MediaStoreThumbFetcher$ThumbnailStreamOpenerFactory", DoNotGenerateAcw=true)]
		public partial class ThumbnailStreamOpenerFactory : global::Java.Lang.Object {

			protected ThumbnailStreamOpenerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher.VideoThumbnailQuery']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/data/MediaStoreThumbFetcher$VideoThumbnailQuery", DoNotGenerateAcw=true)]
		public partial class VideoThumbnailQuery : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.IThumbnailQuery {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/data/MediaStoreThumbFetcher$VideoThumbnailQuery", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VideoThumbnailQuery); }
			}

			protected VideoThumbnailQuery (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_queryPath_Landroid_content_Context_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetQueryPath_Landroid_content_Context_Landroid_net_Uri_Handler ()
			{
				if (cb_queryPath_Landroid_content_Context_Landroid_net_Uri_ == null)
					cb_queryPath_Landroid_content_Context_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_QueryPath_Landroid_content_Context_Landroid_net_Uri_);
				return cb_queryPath_Landroid_content_Context_Landroid_net_Uri_;
			}

			static IntPtr n_QueryPath_Landroid_content_Context_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.VideoThumbnailQuery __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher.VideoThumbnailQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.QueryPath (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_queryPath_Landroid_content_Context_Landroid_net_Uri_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher.VideoThumbnailQuery']/method[@name='queryPath' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
			[Register ("queryPath", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/database/Cursor;", "GetQueryPath_Landroid_content_Context_Landroid_net_Uri_Handler")]
			public virtual unsafe global::Android.Database.ICursor QueryPath (global::Android.Content.Context p0, global::Android.Net.Uri p1)
			{
				if (id_queryPath_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
					id_queryPath_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "queryPath", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/database/Cursor;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Android.Database.ICursor __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod  (Handle, id_queryPath_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "queryPath", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/database/Cursor;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/data/MediaStoreThumbFetcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaStoreThumbFetcher); }
		}

		protected MediaStoreThumbFetcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_net_Uri_Lcom_bumptech_glide_load_data_DataFetcher_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher']/constructor[@name='MediaStoreThumbFetcher' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='com.bumptech.glide.load.data.DataFetcher&lt;java.io.InputStream&gt;'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/net/Uri;Lcom/bumptech/glide/load/data/DataFetcher;II)V", "")]
		public unsafe MediaStoreThumbFetcher (global::Android.Content.Context p0, global::Android.Net.Uri p1, global::Com.Bumptech.Glide.Load.Data.IDataFetcher p2, int p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (MediaStoreThumbFetcher)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/net/Uri;Lcom/bumptech/glide/load/data/DataFetcher;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/net/Uri;Lcom/bumptech/glide/load/data/DataFetcher;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_net_Uri_Lcom_bumptech_glide_load_data_DataFetcher_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_net_Uri_Lcom_bumptech_glide_load_data_DataFetcher_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/net/Uri;Lcom/bumptech/glide/load/data/DataFetcher;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_net_Uri_Lcom_bumptech_glide_load_data_DataFetcher_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_net_Uri_Lcom_bumptech_glide_load_data_DataFetcher_II, __args);
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
			global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cancel);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
			} finally {
			}
		}

		static Delegate cb_cleanup;
#pragma warning disable 0169
		static Delegate GetCleanupHandler ()
		{
			if (cb_cleanup == null)
				cb_cleanup = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cleanup);
			return cb_cleanup;
		}

		static void n_Cleanup (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cleanup ();
		}
#pragma warning restore 0169

		static IntPtr id_cleanup;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher']/method[@name='cleanup' and count(parameter)=0]"
		[Register ("cleanup", "()V", "GetCleanupHandler")]
		public virtual unsafe void Cleanup ()
		{
			if (id_cleanup == IntPtr.Zero)
				id_cleanup = JNIEnv.GetMethodID (class_ref, "cleanup", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cleanup);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cleanup", "()V"));
			} finally {
			}
		}

		static Delegate cb_loadData_Lcom_bumptech_glide_Priority_;
#pragma warning disable 0169
		static Delegate GetLoadData_Lcom_bumptech_glide_Priority_Handler ()
		{
			if (cb_loadData_Lcom_bumptech_glide_Priority_ == null)
				cb_loadData_Lcom_bumptech_glide_Priority_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadData_Lcom_bumptech_glide_Priority_);
			return cb_loadData_Lcom_bumptech_glide_Priority_;
		}

		static IntPtr n_LoadData_Lcom_bumptech_glide_Priority_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.MediaStoreThumbFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Priority p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Priority> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.LoadData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadData_Lcom_bumptech_glide_Priority_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.data']/class[@name='MediaStoreThumbFetcher']/method[@name='loadData' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.Priority']]"
		[Register ("loadData", "(Lcom/bumptech/glide/Priority;)Ljava/io/InputStream;", "GetLoadData_Lcom_bumptech_glide_Priority_Handler")]
		public virtual unsafe global::System.IO.Stream LoadData (global::Com.Bumptech.Glide.Priority p0)
		{
			if (id_loadData_Lcom_bumptech_glide_Priority_ == IntPtr.Zero)
				id_loadData_Lcom_bumptech_glide_Priority_ = JNIEnv.GetMethodID (class_ref, "loadData", "(Lcom/bumptech/glide/Priority;)Ljava/io/InputStream;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_loadData_Lcom_bumptech_glide_Priority_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadData", "(Lcom/bumptech/glide/Priority;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.Data.IDataFetcher
		global::Java.Lang.Object global::Com.Bumptech.Glide.Load.Data.IDataFetcher.LoadData (global::Com.Bumptech.Glide.Priority p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(LoadData (p0));
		}

	}
}
