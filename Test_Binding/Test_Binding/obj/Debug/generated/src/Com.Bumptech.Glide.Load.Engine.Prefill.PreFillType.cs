using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine.Prefill {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.prefill']/class[@name='PreFillType']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/prefill/PreFillType", DoNotGenerateAcw=true)]
	public sealed partial class PreFillType : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.prefill']/class[@name='PreFillType.Builder']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/prefill/PreFillType$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/engine/prefill/PreFillType$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.prefill']/class[@name='PreFillType.Builder']/constructor[@name='PreFillType.Builder' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register (".ctor", "(I)V", "")]
			public unsafe Builder (int p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (Builder)) {
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

			static IntPtr id_ctor_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.prefill']/class[@name='PreFillType.Builder']/constructor[@name='PreFillType.Builder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe Builder (int p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (Builder)) {
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

			static Delegate cb_setConfig_Landroid_graphics_Bitmap_Config_;
#pragma warning disable 0169
			static Delegate GetSetConfig_Landroid_graphics_Bitmap_Config_Handler ()
			{
				if (cb_setConfig_Landroid_graphics_Bitmap_Config_ == null)
					cb_setConfig_Landroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetConfig_Landroid_graphics_Bitmap_Config_);
				return cb_setConfig_Landroid_graphics_Bitmap_Config_;
			}

			static IntPtr n_SetConfig_Landroid_graphics_Bitmap_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap.Config p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetConfig (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setConfig_Landroid_graphics_Bitmap_Config_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.prefill']/class[@name='PreFillType.Builder']/method[@name='setConfig' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap.Config']]"
			[Register ("setConfig", "(Landroid/graphics/Bitmap$Config;)Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;", "GetSetConfig_Landroid_graphics_Bitmap_Config_Handler")]
			public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder SetConfig (global::Android.Graphics.Bitmap.Config p0)
			{
				if (id_setConfig_Landroid_graphics_Bitmap_Config_ == IntPtr.Zero)
					id_setConfig_Landroid_graphics_Bitmap_Config_ = JNIEnv.GetMethodID (class_ref, "setConfig", "(Landroid/graphics/Bitmap$Config;)Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setConfig_Landroid_graphics_Bitmap_Config_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConfig", "(Landroid/graphics/Bitmap$Config;)Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setWeight_I;
#pragma warning disable 0169
			static Delegate GetSetWeight_IHandler ()
			{
				if (cb_setWeight_I == null)
					cb_setWeight_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetWeight_I);
				return cb_setWeight_I;
			}

			static IntPtr n_SetWeight_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetWeight (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setWeight_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.prefill']/class[@name='PreFillType.Builder']/method[@name='setWeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWeight", "(I)Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;", "GetSetWeight_IHandler")]
			public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder SetWeight (int p0)
			{
				if (id_setWeight_I == IntPtr.Zero)
					id_setWeight_I = JNIEnv.GetMethodID (class_ref, "setWeight", "(I)Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setWeight_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Prefill.PreFillType.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWeight", "(I)Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal PreFillType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
