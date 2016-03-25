using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine.Executor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/interface[@name='Prioritized']"
	[Register ("com/bumptech/glide/load/engine/executor/Prioritized", "", "Com.Bumptech.Glide.Load.Engine.Executor.IPrioritizedInvoker")]
	public partial interface IPrioritized : IJavaObject {

		int Priority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/interface[@name='Prioritized']/method[@name='getPriority' and count(parameter)=0]"
			[Register ("getPriority", "()I", "GetGetPriorityHandler:Com.Bumptech.Glide.Load.Engine.Executor.IPrioritizedInvoker, Test_Binding")] get;
		}

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/executor/Prioritized", DoNotGenerateAcw=true)]
	internal class IPrioritizedInvoker : global::Java.Lang.Object, IPrioritized {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/engine/executor/Prioritized");
		IntPtr class_ref;

		public static IPrioritized GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPrioritized> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.engine.executor.Prioritized"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPrioritizedInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPrioritizedInvoker); }
		}

		static Delegate cb_getPriority;
#pragma warning disable 0169
		static Delegate GetGetPriorityHandler ()
		{
			if (cb_getPriority == null)
				cb_getPriority = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPriority);
			return cb_getPriority;
		}

		static int n_GetPriority (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Engine.Executor.IPrioritized __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Executor.IPrioritized> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Priority;
		}
#pragma warning restore 0169

		IntPtr id_getPriority;
		public unsafe int Priority {
			get {
				if (id_getPriority == IntPtr.Zero)
					id_getPriority = JNIEnv.GetMethodID (class_ref, "getPriority", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getPriority);
			}
		}

	}

}
