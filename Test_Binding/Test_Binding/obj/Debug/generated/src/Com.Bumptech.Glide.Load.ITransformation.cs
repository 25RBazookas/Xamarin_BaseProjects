using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load']/interface[@name='Transformation']"
	[Register ("com/bumptech/glide/load/Transformation", "", "Com.Bumptech.Glide.Load.ITransformationInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ITransformation : IJavaObject {

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load']/interface[@name='Transformation']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Bumptech.Glide.Load.ITransformationInvoker, Test_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load']/interface[@name='Transformation']/method[@name='transform' and count(parameter)=3 and parameter[1][@type='com.bumptech.glide.load.engine.Resource&lt;T&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("transform", "(Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;", "GetTransform_Lcom_bumptech_glide_load_engine_Resource_IIHandler:Com.Bumptech.Glide.Load.ITransformationInvoker, Test_Binding")]
		global::Com.Bumptech.Glide.Load.Engine.IResource Transform (global::Com.Bumptech.Glide.Load.Engine.IResource p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/Transformation", DoNotGenerateAcw=true)]
	internal class ITransformationInvoker : global::Java.Lang.Object, ITransformation {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/Transformation");
		IntPtr class_ref;

		public static ITransformation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITransformation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.Transformation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITransformationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITransformationInvoker); }
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
			global::Com.Bumptech.Glide.Load.ITransformation __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.ITransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public unsafe string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bumptech.Glide.Load.ITransformation __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.ITransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p0 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transform (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_transform_Lcom_bumptech_glide_load_engine_Resource_II;
		public unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Transform (global::Com.Bumptech.Glide.Load.Engine.IResource p0, int p1, int p2)
		{
			if (id_transform_Lcom_bumptech_glide_load_engine_Resource_II == IntPtr.Zero)
				id_transform_Lcom_bumptech_glide_load_engine_Resource_II = JNIEnv.GetMethodID (class_ref, "transform", "(Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Com.Bumptech.Glide.Load.Engine.IResource __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod (Handle, id_transform_Lcom_bumptech_glide_load_engine_Resource_II, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
