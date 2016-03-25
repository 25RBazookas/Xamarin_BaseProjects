using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load']/class[@name='MultiTransformation']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/MultiTransformation", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class MultiTransformation : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.ITransformation {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/MultiTransformation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiTransformation); }
		}

		protected MultiTransformation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLcom_bumptech_glide_load_Transformation_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load']/class[@name='MultiTransformation']/constructor[@name='MultiTransformation' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.Transformation&lt;T&gt;...']]"
		[Register (".ctor", "([Lcom/bumptech/glide/load/Transformation;)V", "")]
		public unsafe MultiTransformation (params global:: Com.Bumptech.Glide.Load.ITransformation[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (MultiTransformation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([Lcom/bumptech/glide/load/Transformation;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([Lcom/bumptech/glide/load/Transformation;)V", __args);
					return;
				}

				if (id_ctor_arrayLcom_bumptech_glide_load_Transformation_ == IntPtr.Zero)
					id_ctor_arrayLcom_bumptech_glide_load_Transformation_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lcom/bumptech/glide/load/Transformation;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLcom_bumptech_glide_load_Transformation_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayLcom_bumptech_glide_load_Transformation_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_Ljava_util_Collection_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load']/class[@name='MultiTransformation']/constructor[@name='MultiTransformation' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends com.bumptech.glide.load.Transformation&lt;T&gt;&gt;']]"
		[Register (".ctor", "(Ljava/util/Collection;)V", "")]
		public unsafe MultiTransformation (global::System.Collections.ICollection p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (MultiTransformation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Collection;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/Collection;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Collection_ == IntPtr.Zero)
					id_ctor_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Collection;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Collection_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_Collection_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Bumptech.Glide.Load.MultiTransformation __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.MultiTransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load']/class[@name='MultiTransformation']/method[@name='getId' and count(parameter)=0]"
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
			global::Com.Bumptech.Glide.Load.MultiTransformation __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.MultiTransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p0 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transform (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transform_Lcom_bumptech_glide_load_engine_Resource_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load']/class[@name='MultiTransformation']/method[@name='transform' and count(parameter)=3 and parameter[1][@type='com.bumptech.glide.load.engine.Resource&lt;T&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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
