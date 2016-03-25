using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ModelCache']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/ModelCache", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"A", "B"})]
	public partial class ModelCache : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ModelCache.ModelKey']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/model/ModelCache$ModelKey", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"A"})]
		public sealed partial class ModelKey : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/model/ModelCache$ModelKey", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ModelKey); }
			}

			internal ModelKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_release;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ModelCache.ModelKey']/method[@name='release' and count(parameter)=0]"
			[Register ("release", "()V", "")]
			public unsafe void Release ()
			{
				if (id_release == IntPtr.Zero)
					id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_release);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/model/ModelCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ModelCache); }
		}

		protected ModelCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ModelCache']/constructor[@name='ModelCache' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ModelCache ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ModelCache)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ModelCache']/constructor[@name='ModelCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe ModelCache (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ModelCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_get_Ljava_lang_Object_II;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_Object_IIHandler ()
		{
			if (cb_get_Ljava_lang_Object_II == null)
				cb_get_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Get_Ljava_lang_Object_II);
			return cb_get_Ljava_lang_Object_II;
		}

		static IntPtr n_Get_Ljava_lang_Object_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.Model.ModelCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ModelCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_Object_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ModelCache']/method[@name='get' and count(parameter)=3 and parameter[1][@type='A'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("get", "(Ljava/lang/Object;II)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_IIHandler")]
		public virtual unsafe global::Java.Lang.Object Get (global::Java.Lang.Object p0, int p1, int p2)
		{
			if (id_get_Ljava_lang_Object_II == IntPtr.Zero)
				id_get_Ljava_lang_Object_II = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/Object;II)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_Object_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/Object;II)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_Object_IILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_Object_IILjava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_Object_IILjava_lang_Object_ == null)
				cb_put_Ljava_lang_Object_IILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Put_Ljava_lang_Object_IILjava_lang_Object_);
			return cb_put_Ljava_lang_Object_IILjava_lang_Object_;
		}

		static void n_Put_Ljava_lang_Object_IILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Bumptech.Glide.Load.Model.ModelCache __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Model.ModelCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_Object_IILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.model']/class[@name='ModelCache']/method[@name='put' and count(parameter)=4 and parameter[1][@type='A'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='B']]"
		[Register ("put", "(Ljava/lang/Object;IILjava/lang/Object;)V", "GetPut_Ljava_lang_Object_IILjava_lang_Object_Handler")]
		public virtual unsafe void Put (global::Java.Lang.Object p0, int p1, int p2, global::Java.Lang.Object p3)
		{
			if (id_put_Ljava_lang_Object_IILjava_lang_Object_ == IntPtr.Zero)
				id_put_Ljava_lang_Object_IILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/Object;IILjava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p3 = JNIEnv.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_lang_Object_IILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/Object;IILjava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
