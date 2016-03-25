using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Bytes {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.bytes']/class[@name='BytesResource']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/bytes/BytesResource", DoNotGenerateAcw=true)]
	public partial class BytesResource : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Engine.IResource {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/bytes/BytesResource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BytesResource); }
		}

		protected BytesResource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.bytes']/class[@name='BytesResource']/constructor[@name='BytesResource' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe BytesResource (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (BytesResource)) {
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

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bytes.BytesResource __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bytes.BytesResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		public virtual unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bytes']/class[@name='BytesResource']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getSize);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bytes.BytesResource __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bytes.BytesResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Get ());
		}
#pragma warning restore 0169

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bytes']/class[@name='BytesResource']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()[B", "GetGetHandler")]
		public virtual unsafe byte[] Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_get), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_recycle;
#pragma warning disable 0169
		static Delegate GetRecycleHandler ()
		{
			if (cb_recycle == null)
				cb_recycle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Recycle);
			return cb_recycle;
		}

		static void n_Recycle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Bytes.BytesResource __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Bytes.BytesResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.bytes']/class[@name='BytesResource']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler")]
		public virtual unsafe void Recycle ()
		{
			if (id_recycle == IntPtr.Zero)
				id_recycle = JNIEnv.GetMethodID (class_ref, "recycle", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_recycle);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recycle", "()V"));
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bumptech.Glide.Load.Engine.IResource
		global::Java.Lang.Object global::Com.Bumptech.Glide.Load.Engine.IResource.Get ()
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(Get ());
		}

	}
}
