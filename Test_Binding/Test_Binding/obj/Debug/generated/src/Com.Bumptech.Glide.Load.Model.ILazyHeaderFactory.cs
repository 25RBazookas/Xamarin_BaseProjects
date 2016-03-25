using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.model']/interface[@name='LazyHeaderFactory']"
	[Register ("com/bumptech/glide/load/model/LazyHeaderFactory", "", "Com.Bumptech.Glide.Load.Model.ILazyHeaderFactoryInvoker")]
	public partial interface ILazyHeaderFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/interface[@name='LazyHeaderFactory']/method[@name='buildHeader' and count(parameter)=0]"
		[Register ("buildHeader", "()Ljava/lang/String;", "GetBuildHeaderHandler:Com.Bumptech.Glide.Load.Model.ILazyHeaderFactoryInvoker, Test_Binding")]
		string BuildHeader ();

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/LazyHeaderFactory", DoNotGenerateAcw=true)]
	internal class ILazyHeaderFactoryInvoker : global::Java.Lang.Object, ILazyHeaderFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/model/LazyHeaderFactory");
		IntPtr class_ref;

		public static ILazyHeaderFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILazyHeaderFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.model.LazyHeaderFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILazyHeaderFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILazyHeaderFactoryInvoker); }
		}

		static Delegate cb_buildHeader;
#pragma warning disable 0169
		static Delegate GetBuildHeaderHandler ()
		{
			if (cb_buildHeader == null)
				cb_buildHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildHeader);
			return cb_buildHeader;
		}

		static IntPtr n_BuildHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Model.ILazyHeaderFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ILazyHeaderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BuildHeader ());
		}
#pragma warning restore 0169

		IntPtr id_buildHeader;
		public unsafe string BuildHeader ()
		{
			if (id_buildHeader == IntPtr.Zero)
				id_buildHeader = JNIEnv.GetMethodID (class_ref, "buildHeader", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_buildHeader), JniHandleOwnership.TransferLocalRef);
		}

	}

}
