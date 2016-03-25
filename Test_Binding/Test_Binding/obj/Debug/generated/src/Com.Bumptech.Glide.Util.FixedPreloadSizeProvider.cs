using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='FixedPreloadSizeProvider']"
	[global::Android.Runtime.Register ("com/bumptech/glide/util/FixedPreloadSizeProvider", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class FixedPreloadSizeProvider : global::Java.Lang.Object, global::Com.Bumptech.Glide.ListPreloader.IPreloadSizeProvider {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/util/FixedPreloadSizeProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FixedPreloadSizeProvider); }
		}

		protected FixedPreloadSizeProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='FixedPreloadSizeProvider']/constructor[@name='FixedPreloadSizeProvider' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe FixedPreloadSizeProvider (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FixedPreloadSizeProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static Delegate cb_getPreloadSize_Ljava_lang_Object_II;
#pragma warning disable 0169
		static Delegate GetGetPreloadSize_Ljava_lang_Object_IIHandler ()
		{
			if (cb_getPreloadSize_Ljava_lang_Object_II == null)
				cb_getPreloadSize_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetPreloadSize_Ljava_lang_Object_II);
			return cb_getPreloadSize_Ljava_lang_Object_II;
		}

		static IntPtr n_GetPreloadSize_Ljava_lang_Object_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Util.FixedPreloadSizeProvider __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Util.FixedPreloadSizeProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetPreloadSize (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPreloadSize_Ljava_lang_Object_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.util']/class[@name='FixedPreloadSizeProvider']/method[@name='getPreloadSize' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getPreloadSize", "(Ljava/lang/Object;II)[I", "GetGetPreloadSize_Ljava_lang_Object_IIHandler")]
		public virtual unsafe int[] GetPreloadSize (global::Java.Lang.Object p0, int p1, int p2)
		{
			if (id_getPreloadSize_Ljava_lang_Object_II == IntPtr.Zero)
				id_getPreloadSize_Ljava_lang_Object_II = JNIEnv.GetMethodID (class_ref, "getPreloadSize", "(Ljava/lang/Object;II)[I");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int[] __ret;
				if (GetType () == ThresholdType)
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPreloadSize_Ljava_lang_Object_II, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreloadSize", "(Ljava/lang/Object;II)[I"), __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
