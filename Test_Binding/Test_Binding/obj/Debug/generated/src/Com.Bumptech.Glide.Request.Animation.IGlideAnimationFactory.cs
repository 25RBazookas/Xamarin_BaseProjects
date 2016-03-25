using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Animation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.request.animation']/interface[@name='GlideAnimationFactory']"
	[Register ("com/bumptech/glide/request/animation/GlideAnimationFactory", "", "Com.Bumptech.Glide.Request.Animation.IGlideAnimationFactoryInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial interface IGlideAnimationFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.animation']/interface[@name='GlideAnimationFactory']/method[@name='build' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("build", "(ZZ)Lcom/bumptech/glide/request/animation/GlideAnimation;", "GetBuild_ZZHandler:Com.Bumptech.Glide.Request.Animation.IGlideAnimationFactoryInvoker, Test_Binding")]
		global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation Build (bool p0, bool p1);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/request/animation/GlideAnimationFactory", DoNotGenerateAcw=true)]
	internal class IGlideAnimationFactoryInvoker : global::Java.Lang.Object, IGlideAnimationFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/request/animation/GlideAnimationFactory");
		IntPtr class_ref;

		public static IGlideAnimationFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGlideAnimationFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.request.animation.GlideAnimationFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGlideAnimationFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IGlideAnimationFactoryInvoker); }
		}

		static Delegate cb_build_ZZ;
#pragma warning disable 0169
		static Delegate GetBuild_ZZHandler ()
		{
			if (cb_build_ZZ == null)
				cb_build_ZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool, IntPtr>) n_Build_ZZ);
			return cb_build_ZZ;
		}

		static IntPtr n_Build_ZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1)
		{
			global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build (p0, p1));
		}
#pragma warning restore 0169

		IntPtr id_build_ZZ;
		public unsafe global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation Build (bool p0, bool p1)
		{
			if (id_build_ZZ == IntPtr.Zero)
				id_build_ZZ = JNIEnv.GetMethodID (class_ref, "build", "(ZZ)Lcom/bumptech/glide/request/animation/GlideAnimation;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Animation.IGlideAnimation> (JNIEnv.CallObjectMethod (Handle, id_build_ZZ, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
