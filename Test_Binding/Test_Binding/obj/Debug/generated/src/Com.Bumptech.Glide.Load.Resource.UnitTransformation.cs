using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource']/class[@name='UnitTransformation']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/UnitTransformation", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class UnitTransformation : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.ITransformation {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/UnitTransformation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnitTransformation); }
		}

		protected UnitTransformation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource']/class[@name='UnitTransformation']/constructor[@name='UnitTransformation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnitTransformation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UnitTransformation)) {
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
			global::Com.Bumptech.Glide.Load.Resource.UnitTransformation __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.UnitTransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource']/class[@name='UnitTransformation']/method[@name='getId' and count(parameter)=0]"
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

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource']/class[@name='UnitTransformation']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/bumptech/glide/load/resource/UnitTransformation;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Bumptech.Glide.Load.Resource.UnitTransformation Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetStaticMethodID (class_ref, "get", "()Lcom/bumptech/glide/load/resource/UnitTransformation;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.UnitTransformation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_transform_Lcom_bumptech_glide_load_engine_Resource_II;
#pragma warning disable 0169
		static Delegate GetTransform_Lcom_bumptech_glide_load_engine_Resource_IIHandler ()
		{
			if (cb_transform_Lcom_bumptech_glide_load_engine_Resource_II == null)
				cb_transform_Lcom_bumptech_glide_load_engine_Resource_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Transform_Lcom_bumptech_glide_load_engine_Resource_II);
			return cb_transform_Lcom_bumptech_glide_load_engine_Resource_II;
		}

		static IntPtr n_Transform_Lcom_bumptech_glide_load_engine_Resource_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Resource.UnitTransformation __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.UnitTransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p0 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transform (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transform_Lcom_bumptech_glide_load_engine_Resource_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource']/class[@name='UnitTransformation']/method[@name='transform' and count(parameter)=3 and parameter[1][@type='com.bumptech.glide.load.engine.Resource&lt;T&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("transform", "(Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;", "GetTransform_Lcom_bumptech_glide_load_engine_Resource_IIHandler")]
		public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Transform (global::Com.Bumptech.Glide.Load.Engine.IResource p0, int p1, int p2)
		{
			if (id_transform_Lcom_bumptech_glide_load_engine_Resource_II == IntPtr.Zero)
				id_transform_Lcom_bumptech_glide_load_engine_Resource_II = JNIEnv.GetMethodID (class_ref, "transform", "(Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Bumptech.Glide.Load.Engine.IResource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod  (Handle, id_transform_Lcom_bumptech_glide_load_engine_Resource_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transform", "(Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
