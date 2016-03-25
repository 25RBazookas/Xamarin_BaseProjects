using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load']/interface[@name='ResourceDecoder']"
	[Register ("com/bumptech/glide/load/ResourceDecoder", "", "Com.Bumptech.Glide.Load.IResourceDecoderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Z"})]
	public partial interface IResourceDecoder : IJavaObject {

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load']/interface[@name='ResourceDecoder']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Bumptech.Glide.Load.IResourceDecoderInvoker, Test_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load']/interface[@name='ResourceDecoder']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("decode", "(Ljava/lang/Object;II)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Ljava_lang_Object_IIHandler:Com.Bumptech.Glide.Load.IResourceDecoderInvoker, Test_Binding")]
		global::Com.Bumptech.Glide.Load.Engine.IResource Decode (global::Java.Lang.Object p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/ResourceDecoder", DoNotGenerateAcw=true)]
	internal class IResourceDecoderInvoker : global::Java.Lang.Object, IResourceDecoder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/ResourceDecoder");
		IntPtr class_ref;

		public static IResourceDecoder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResourceDecoder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.ResourceDecoder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResourceDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IResourceDecoderInvoker); }
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
			global::Com.Bumptech.Glide.Load.IResourceDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_decode_Ljava_lang_Object_II;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_lang_Object_IIHandler ()
		{
			if (cb_decode_Ljava_lang_Object_II == null)
				cb_decode_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Decode_Ljava_lang_Object_II);
			return cb_decode_Ljava_lang_Object_II;
		}

		static IntPtr n_Decode_Ljava_lang_Object_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Bumptech.Glide.Load.IResourceDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decode_Ljava_lang_Object_II;
		public unsafe global::Com.Bumptech.Glide.Load.Engine.IResource Decode (global::Java.Lang.Object p0, int p1, int p2)
		{
			if (id_decode_Ljava_lang_Object_II == IntPtr.Zero)
				id_decode_Ljava_lang_Object_II = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/Object;II)Lcom/bumptech/glide/load/engine/Resource;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Com.Bumptech.Glide.Load.Engine.IResource __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod (Handle, id_decode_Ljava_lang_Object_II, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
