using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Gif {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawableResource']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/gif/GifDrawableResource", DoNotGenerateAcw=true)]
	public partial class GifDrawableResource : global::Com.Bumptech.Glide.Load.Resource.Drawable.DrawableResource {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/gif/GifDrawableResource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifDrawableResource); }
		}

		protected GifDrawableResource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_bumptech_glide_load_resource_gif_GifDrawable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawableResource']/constructor[@name='GifDrawableResource' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.resource.gif.GifDrawable']]"
		[Register (".ctor", "(Lcom/bumptech/glide/load/resource/gif/GifDrawable;)V", "")]
		public unsafe GifDrawableResource (global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawable p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GifDrawableResource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/bumptech/glide/load/resource/gif/GifDrawable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/bumptech/glide/load/resource/gif/GifDrawable;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bumptech_glide_load_resource_gif_GifDrawable_ == IntPtr.Zero)
					id_ctor_Lcom_bumptech_glide_load_resource_gif_GifDrawable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bumptech/glide/load/resource/gif/GifDrawable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bumptech_glide_load_resource_gif_GifDrawable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_bumptech_glide_load_resource_gif_GifDrawable_, __args);
			} finally {
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
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawableResource __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawableResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		public override unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawableResource']/method[@name='getSize' and count(parameter)=0]"
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

		static Delegate cb_recycle;
#pragma warning disable 0169
		static Delegate GetRecycleHandler ()
		{
			if (cb_recycle == null)
				cb_recycle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Recycle);
			return cb_recycle;
		}

		static void n_Recycle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawableResource __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Gif.GifDrawableResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.gif']/class[@name='GifDrawableResource']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler")]
		public override unsafe void Recycle ()
		{
			if (id_recycle == IntPtr.Zero)
				id_recycle = JNIEnv.GetMethodID (class_ref, "recycle", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_recycle);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recycle", "()V"));
			} finally {
			}
		}

	}
}
