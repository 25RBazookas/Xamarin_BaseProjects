using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Gifbitmap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapper']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/gifbitmap/GifBitmapWrapper", DoNotGenerateAcw=true)]
	public partial class GifBitmapWrapper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/gifbitmap/GifBitmapWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifBitmapWrapper); }
		}

		protected GifBitmapWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_engine_Resource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapper']/constructor[@name='GifBitmapWrapper' and count(parameter)=2 and parameter[1][@type='com.bumptech.glide.load.engine.Resource&lt;android.graphics.Bitmap&gt;'] and parameter[2][@type='com.bumptech.glide.load.engine.Resource&lt;com.bumptech.glide.load.resource.gif.GifDrawable&gt;']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/engine/Resource;)V", "")]
		public unsafe GifBitmapWrapper (global::Com.Bumptech.Glide.Load.Engine.IResource p0, global::Com.Bumptech.Glide.Load.Engine.IResource p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (GifBitmapWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/engine/Resource;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/engine/Resource;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_engine_Resource_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_engine_Resource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/engine/Resource;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_engine_Resource_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_engine_Resource_, __args);
			} finally {
			}
		}

		static Delegate cb_getBitmapResource;
#pragma warning disable 0169
		static Delegate GetGetBitmapResourceHandler ()
		{
			if (cb_getBitmapResource == null)
				cb_getBitmapResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitmapResource);
			return cb_getBitmapResource;
		}

		static IntPtr n_GetBitmapResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BitmapResource);
		}
#pragma warning restore 0169

		static IntPtr id_getBitmapResource;
		public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.IResource BitmapResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapper']/method[@name='getBitmapResource' and count(parameter)=0]"
			[Register ("getBitmapResource", "()Lcom/bumptech/glide/load/engine/Resource;", "GetGetBitmapResourceHandler")]
			get {
				if (id_getBitmapResource == IntPtr.Zero)
					id_getBitmapResource = JNIEnv.GetMethodID (class_ref, "getBitmapResource", "()Lcom/bumptech/glide/load/engine/Resource;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod  (Handle, id_getBitmapResource), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitmapResource", "()Lcom/bumptech/glide/load/engine/Resource;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGifResource;
#pragma warning disable 0169
		static Delegate GetGetGifResourceHandler ()
		{
			if (cb_getGifResource == null)
				cb_getGifResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGifResource);
			return cb_getGifResource;
		}

		static IntPtr n_GetGifResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GifResource);
		}
#pragma warning restore 0169

		static IntPtr id_getGifResource;
		public virtual unsafe global::Com.Bumptech.Glide.Load.Engine.IResource GifResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapper']/method[@name='getGifResource' and count(parameter)=0]"
			[Register ("getGifResource", "()Lcom/bumptech/glide/load/engine/Resource;", "GetGetGifResourceHandler")]
			get {
				if (id_getGifResource == IntPtr.Zero)
					id_getGifResource = JNIEnv.GetMethodID (class_ref, "getGifResource", "()Lcom/bumptech/glide/load/engine/Resource;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallObjectMethod  (Handle, id_getGifResource), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.IResource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGifResource", "()Lcom/bumptech/glide/load/engine/Resource;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gifbitmap.GifBitmapWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		public virtual unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gifbitmap']/class[@name='GifBitmapWrapper']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getSize);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()I"));
				} finally {
				}
			}
		}

	}
}
