using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='MultiClassKey']"
	[global::Android.Runtime.Register ("com/bumptech/glide/util/MultiClassKey", DoNotGenerateAcw=true)]
	public partial class MultiClassKey : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/util/MultiClassKey", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiClassKey); }
		}

		protected MultiClassKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='MultiClassKey']/constructor[@name='MultiClassKey' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MultiClassKey ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MultiClassKey)) {
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

		static IntPtr id_ctor_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='MultiClassKey']/constructor[@name='MultiClassKey' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/lang/Class;)V", "")]
		public unsafe MultiClassKey (global::Java.Lang.Class p0, global::Java.Lang.Class p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MultiClassKey)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Class;Ljava/lang/Class;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Class;Ljava/lang/Class;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_Class_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_Class_, __args);
			} finally {
			}
		}

		static Delegate cb_set_Ljava_lang_Class_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_Class_Ljava_lang_Class_Handler ()
		{
			if (cb_set_Ljava_lang_Class_Ljava_lang_Class_ == null)
				cb_set_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_Class_Ljava_lang_Class_);
			return cb_set_Ljava_lang_Class_Ljava_lang_Class_;
		}

		static void n_Set_Ljava_lang_Class_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bumptech.Glide.Util.MultiClassKey __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.MultiClassKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='MultiClassKey']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("set", "(Ljava/lang/Class;Ljava/lang/Class;)V", "GetSet_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		public virtual unsafe void Set (global::Java.Lang.Class p0, global::Java.Lang.Class p1)
		{
			if (id_set_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_set_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/Class;Ljava/lang/Class;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_set_Ljava_lang_Class_Ljava_lang_Class_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/lang/Class;Ljava/lang/Class;)V"), __args);
			} finally {
			}
		}

	}
}
