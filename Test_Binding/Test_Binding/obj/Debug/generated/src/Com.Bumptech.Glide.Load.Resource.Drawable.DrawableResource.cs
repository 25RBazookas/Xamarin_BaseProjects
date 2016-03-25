using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Resource.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='DrawableResource']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/drawable/DrawableResource", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends android.graphics.drawable.Drawable"})]
	public abstract partial class DrawableResource : global::Java.Lang.Object, global::Com.Bumptech.Glide.Load.Engine.IResource {


		static IntPtr drawable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='DrawableResource']/field[@name='drawable']"
		[Register ("drawable")]
		protected global::Android.Graphics.Drawables.Drawable Drawable {
			get {
				if (drawable_jfieldId == IntPtr.Zero)
					drawable_jfieldId = JNIEnv.GetFieldID (class_ref, "drawable", "Landroid/graphics/drawable/Drawable;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, drawable_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (drawable_jfieldId == IntPtr.Zero)
					drawable_jfieldId = JNIEnv.GetFieldID (class_ref, "drawable", "Landroid/graphics/drawable/Drawable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, drawable_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/resource/drawable/DrawableResource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawableResource); }
		}

		protected DrawableResource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='DrawableResource']/constructor[@name='DrawableResource' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe DrawableResource (global::Java.Lang.Object p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (DrawableResource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/drawable/Drawable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/drawable/Drawable;)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_ctor_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/drawable/Drawable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_drawable_Drawable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_drawable_Drawable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='DrawableResource']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Landroid/graphics/drawable/Drawable;", "")]
		public unsafe global::Java.Lang.Object Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Landroid/graphics/drawable/Drawable;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Bumptech.Glide.Load.Resource.Drawable.DrawableResource __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Drawable.DrawableResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='DrawableResource']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler")]
		public abstract void Recycle ();

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
			global::Com.Bumptech.Glide.Load.Resource.Drawable.DrawableResource __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Resource.Drawable.DrawableResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		public abstract int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='DrawableResource']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/resource/drawable/DrawableResource", DoNotGenerateAcw=true)]
	internal partial class DrawableResourceInvoker : DrawableResource, global::Com.Bumptech.Glide.Load.Engine.IResource {

		public DrawableResourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawableResourceInvoker); }
		}

		static IntPtr id_getSize;
		public override unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='DrawableResource']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getSize);
				} finally {
				}
			}
		}

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.resource.drawable']/class[@name='DrawableResource']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler")]
		public override unsafe void Recycle ()
		{
			if (id_recycle == IntPtr.Zero)
				id_recycle = JNIEnv.GetMethodID (class_ref, "recycle", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_recycle);
			} finally {
			}
		}

	}

}
