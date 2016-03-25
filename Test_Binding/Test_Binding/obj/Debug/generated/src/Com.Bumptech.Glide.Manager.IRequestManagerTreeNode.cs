using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Manager {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.manager']/interface[@name='RequestManagerTreeNode']"
	[Register ("com/bumptech/glide/manager/RequestManagerTreeNode", "", "Com.Bumptech.Glide.Manager.IRequestManagerTreeNodeInvoker")]
	public partial interface IRequestManagerTreeNode : IJavaObject {

		global::System.Collections.Generic.ICollection<global::Com.Bumptech.Glide.RequestManager> Descendants {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/interface[@name='RequestManagerTreeNode']/method[@name='getDescendants' and count(parameter)=0]"
			[Register ("getDescendants", "()Ljava/util/Set;", "GetGetDescendantsHandler:Com.Bumptech.Glide.Manager.IRequestManagerTreeNodeInvoker, Test_Binding")] get;
		}

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/manager/RequestManagerTreeNode", DoNotGenerateAcw=true)]
	internal class IRequestManagerTreeNodeInvoker : global::Java.Lang.Object, IRequestManagerTreeNode {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/manager/RequestManagerTreeNode");
		IntPtr class_ref;

		public static IRequestManagerTreeNode GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRequestManagerTreeNode> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.manager.RequestManagerTreeNode"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRequestManagerTreeNodeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRequestManagerTreeNodeInvoker); }
		}

		static Delegate cb_getDescendants;
#pragma warning disable 0169
		static Delegate GetGetDescendantsHandler ()
		{
			if (cb_getDescendants == null)
				cb_getDescendants = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescendants);
			return cb_getDescendants;
		}

		static IntPtr n_GetDescendants (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Manager.IRequestManagerTreeNode __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.IRequestManagerTreeNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Bumptech.Glide.RequestManager>.ToLocalJniHandle (__this.Descendants);
		}
#pragma warning restore 0169

		IntPtr id_getDescendants;
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Bumptech.Glide.RequestManager> Descendants {
			get {
				if (id_getDescendants == IntPtr.Zero)
					id_getDescendants = JNIEnv.GetMethodID (class_ref, "getDescendants", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<global::Com.Bumptech.Glide.RequestManager>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getDescendants), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
