using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Manager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerFragment']"
	[global::Android.Runtime.Register ("com/bumptech/glide/manager/RequestManagerFragment", DoNotGenerateAcw=true)]
	public partial class RequestManagerFragment : global::Android.App.Fragment {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerFragment.FragmentRequestManagerTreeNode']"
		[global::Android.Runtime.Register ("com/bumptech/glide/manager/RequestManagerFragment$FragmentRequestManagerTreeNode", DoNotGenerateAcw=true)]
		public partial class FragmentRequestManagerTreeNode : global::Java.Lang.Object, global::Com.Bumptech.Glide.Manager.IRequestManagerTreeNode {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/manager/RequestManagerFragment$FragmentRequestManagerTreeNode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FragmentRequestManagerTreeNode); }
			}

			protected FragmentRequestManagerTreeNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Bumptech.Glide.Manager.RequestManagerFragment.FragmentRequestManagerTreeNode __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestManagerFragment.FragmentRequestManagerTreeNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaSet<global::Com.Bumptech.Glide.RequestManager>.ToLocalJniHandle (__this.Descendants);
			}
#pragma warning restore 0169

			static IntPtr id_getDescendants;
			public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Bumptech.Glide.RequestManager> Descendants {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerFragment.FragmentRequestManagerTreeNode']/method[@name='getDescendants' and count(parameter)=0]"
				[Register ("getDescendants", "()Ljava/util/Set;", "GetGetDescendantsHandler")]
				get {
					if (id_getDescendants == IntPtr.Zero)
						id_getDescendants = JNIEnv.GetMethodID (class_ref, "getDescendants", "()Ljava/util/Set;");
					try {

						if (GetType () == ThresholdType)
							return global::Android.Runtime.JavaSet<global::Com.Bumptech.Glide.RequestManager>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getDescendants), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.JavaSet<global::Com.Bumptech.Glide.RequestManager>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescendants", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/manager/RequestManagerFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestManagerFragment); }
		}

		protected RequestManagerFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerFragment']/constructor[@name='RequestManagerFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestManagerFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RequestManagerFragment)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getDescendantRequestManagerFragments;
#pragma warning disable 0169
		static Delegate GetGetDescendantRequestManagerFragmentsHandler ()
		{
			if (cb_getDescendantRequestManagerFragments == null)
				cb_getDescendantRequestManagerFragments = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescendantRequestManagerFragments);
			return cb_getDescendantRequestManagerFragments;
		}

		static IntPtr n_GetDescendantRequestManagerFragments (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Manager.RequestManagerFragment __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestManagerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Bumptech.Glide.Manager.RequestManagerFragment>.ToLocalJniHandle (__this.DescendantRequestManagerFragments);
		}
#pragma warning restore 0169

		static IntPtr id_getDescendantRequestManagerFragments;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Bumptech.Glide.Manager.RequestManagerFragment> DescendantRequestManagerFragments {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerFragment']/method[@name='getDescendantRequestManagerFragments' and count(parameter)=0]"
			[Register ("getDescendantRequestManagerFragments", "()Ljava/util/Set;", "GetGetDescendantRequestManagerFragmentsHandler")]
			get {
				if (id_getDescendantRequestManagerFragments == IntPtr.Zero)
					id_getDescendantRequestManagerFragments = JNIEnv.GetMethodID (class_ref, "getDescendantRequestManagerFragments", "()Ljava/util/Set;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<global::Com.Bumptech.Glide.Manager.RequestManagerFragment>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getDescendantRequestManagerFragments), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<global::Com.Bumptech.Glide.Manager.RequestManagerFragment>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescendantRequestManagerFragments", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestManager;
#pragma warning disable 0169
		static Delegate GetGetRequestManagerHandler ()
		{
			if (cb_getRequestManager == null)
				cb_getRequestManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestManager);
			return cb_getRequestManager;
		}

		static IntPtr n_GetRequestManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Manager.RequestManagerFragment __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestManagerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestManager);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestManager_Lcom_bumptech_glide_RequestManager_;
#pragma warning disable 0169
		static Delegate GetSetRequestManager_Lcom_bumptech_glide_RequestManager_Handler ()
		{
			if (cb_setRequestManager_Lcom_bumptech_glide_RequestManager_ == null)
				cb_setRequestManager_Lcom_bumptech_glide_RequestManager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequestManager_Lcom_bumptech_glide_RequestManager_);
			return cb_setRequestManager_Lcom_bumptech_glide_RequestManager_;
		}

		static void n_SetRequestManager_Lcom_bumptech_glide_RequestManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Manager.RequestManagerFragment __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestManagerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bumptech.Glide.RequestManager p0 = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestManager = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestManager;
		static IntPtr id_setRequestManager_Lcom_bumptech_glide_RequestManager_;
		public virtual unsafe global::Com.Bumptech.Glide.RequestManager RequestManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerFragment']/method[@name='getRequestManager' and count(parameter)=0]"
			[Register ("getRequestManager", "()Lcom/bumptech/glide/RequestManager;", "GetGetRequestManagerHandler")]
			get {
				if (id_getRequestManager == IntPtr.Zero)
					id_getRequestManager = JNIEnv.GetMethodID (class_ref, "getRequestManager", "()Lcom/bumptech/glide/RequestManager;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallObjectMethod  (Handle, id_getRequestManager), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.RequestManager> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestManager", "()Lcom/bumptech/glide/RequestManager;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerFragment']/method[@name='setRequestManager' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.RequestManager']]"
			[Register ("setRequestManager", "(Lcom/bumptech/glide/RequestManager;)V", "GetSetRequestManager_Lcom_bumptech_glide_RequestManager_Handler")]
			set {
				if (id_setRequestManager_Lcom_bumptech_glide_RequestManager_ == IntPtr.Zero)
					id_setRequestManager_Lcom_bumptech_glide_RequestManager_ = JNIEnv.GetMethodID (class_ref, "setRequestManager", "(Lcom/bumptech/glide/RequestManager;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRequestManager_Lcom_bumptech_glide_RequestManager_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestManager", "(Lcom/bumptech/glide/RequestManager;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestManagerTreeNode;
#pragma warning disable 0169
		static Delegate GetGetRequestManagerTreeNodeHandler ()
		{
			if (cb_getRequestManagerTreeNode == null)
				cb_getRequestManagerTreeNode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestManagerTreeNode);
			return cb_getRequestManagerTreeNode;
		}

		static IntPtr n_GetRequestManagerTreeNode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Manager.RequestManagerFragment __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.RequestManagerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestManagerTreeNode);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestManagerTreeNode;
		public virtual unsafe global::Com.Bumptech.Glide.Manager.IRequestManagerTreeNode RequestManagerTreeNode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.manager']/class[@name='RequestManagerFragment']/method[@name='getRequestManagerTreeNode' and count(parameter)=0]"
			[Register ("getRequestManagerTreeNode", "()Lcom/bumptech/glide/manager/RequestManagerTreeNode;", "GetGetRequestManagerTreeNodeHandler")]
			get {
				if (id_getRequestManagerTreeNode == IntPtr.Zero)
					id_getRequestManagerTreeNode = JNIEnv.GetMethodID (class_ref, "getRequestManagerTreeNode", "()Lcom/bumptech/glide/manager/RequestManagerTreeNode;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.IRequestManagerTreeNode> (JNIEnv.CallObjectMethod  (Handle, id_getRequestManagerTreeNode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Manager.IRequestManagerTreeNode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestManagerTreeNode", "()Lcom/bumptech/glide/manager/RequestManagerTreeNode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
