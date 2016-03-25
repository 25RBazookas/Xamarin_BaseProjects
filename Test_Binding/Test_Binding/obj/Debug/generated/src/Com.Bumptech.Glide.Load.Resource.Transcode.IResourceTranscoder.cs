using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Transcode {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/interface[@name='ResourceTranscoder']"
	[Register ("com/bumptech/glide/load/resource/transcode/ResourceTranscoder", "", "Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Z", "R"})]
	public partial interface IResourceTranscoder : IJavaObject {

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/interface[@name='ResourceTranscoder']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoderInvoker, Test_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.transcode']/interface[@name='ResourceTranscoder']/method[@name='transcode' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.Resource&lt;Z&gt;']]"
		[Register ("transcode", "(Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;", "GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Handler:Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoderInvoker, Test_Binding")]
		global::Com.Bumptech.Glide.Load.Engine.IResource Transcode (global::Com.Bumptech.Glide.Load.Engine.IResource p0);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/transcode/ResourceTranscoder", DoNotGenerateAcw=true)]
	internal class IResourceTranscoderInvoker : global::Java.Lang.Object, IResourceTranscoder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/resource/transcode/ResourceTranscoder");
		IntPtr class_ref;

		public static IResourceTranscoder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResourceTranscoder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.resource.transcode.ResourceTranscoder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResourceTranscoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IResourceTranscoderInvoker); }
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
			global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_transcode_Lcom_bumptech_glide_load_engine_Resource_;
#pragma warning disable 0169
		static Delegate GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Handler ()
		{
			if (cb_transcode_Lcom_bumptech_glide_load_engine_Resource_ == null)
				cb_transcode_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transcode_Lcom_bumptech_glide_load_engine_Resource_);
			return cb_transcode_Lcom_bumptech_glide_load_engine_Resource_;
		}

		static IntPtr n_Transcode_Lcom_bumptech_glide_load_engine_Resource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.Load.Engine.IResource p0 = (global::Com.Bumptech.Glide.Load.Engine.IResource)global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transcode (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_transcode_Lcom_bumptech_glide_load_engine_Resource_;
		public unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Transcode (global::Com.Bumptech.Glide.Load.Engine.IResource p0)
		{
			if (id_transcode_Lcom_bumptech_glide_load_engine_Resource_ == IntPtr.Zero)
				id_transcode_Lcom_bumptech_glide_load_engine_Resource_ = JNIEnv.GetMethodID (class_ref, "transcode", "(Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Bumptech.Glide.Load.Engine.IResource __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod (Handle, id_transcode_Lcom_bumptech_glide_load_engine_Resource_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
