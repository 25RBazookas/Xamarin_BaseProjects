using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model.File_descriptor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.model.file_descriptor']/interface[@name='FileDescriptorModelLoader']"
	[Register ("com/bumptech/glide/load/model/file_descriptor/FileDescriptorModelLoader", "", "Com.Bumptech.Glide.Load.Model.File_descriptor.IFileDescriptorModelLoaderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IFileDescriptorModelLoader : global::Com.Bumptech.Glide.Load.Model.IModelLoader {

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/file_descriptor/FileDescriptorModelLoader", DoNotGenerateAcw=true)]
	internal class IFileDescriptorModelLoaderInvoker : global::Java.Lang.Object, IFileDescriptorModelLoader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/model/file_descriptor/FileDescriptorModelLoader");
		IntPtr class_ref;

		public static IFileDescriptorModelLoader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFileDescriptorModelLoader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.model.file_descriptor.FileDescriptorModelLoader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFileDescriptorModelLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFileDescriptorModelLoaderInvoker); }
		}

		static Delegate cb_getResourceFetcher_Ljava_lang_Object_II;
#pragma warning disable 0169
		static Delegate GetGetResourceFetcher_Ljava_lang_Object_IIHandler ()
		{
			if (cb_getResourceFetcher_Ljava_lang_Object_II == null)
				cb_getResourceFetcher_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetResourceFetcher_Ljava_lang_Object_II);
			return cb_getResourceFetcher_Ljava_lang_Object_II;
		}

		static IntPtr n_GetResourceFetcher_Ljava_lang_Object_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Model.File_descriptor.IFileDescriptorModelLoader __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.File_descriptor.IFileDescriptorModelLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResourceFetcher (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getResourceFetcher_Ljava_lang_Object_II;
		public unsafe global::Com.Bumptech.Glide.Load.Data.IDataFetcher GetResourceFetcher (global::Java.Lang.Object p0, int p1, int p2)
		{
			if (id_getResourceFetcher_Ljava_lang_Object_II == IntPtr.Zero)
				id_getResourceFetcher_Ljava_lang_Object_II = JNIEnv.GetMethodID (class_ref, "getResourceFetcher", "(Ljava/lang/Object;II)Lcom/bumptech/glide/load/data/DataFetcher;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Com.Bumptech.Glide.Load.Data.IDataFetcher __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Data.IDataFetcher> (JNIEnv.CallObjectMethod (Handle, id_getResourceFetcher_Ljava_lang_Object_II, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
