using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/GenericRequest", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"A", "T", "Z", "R"})]
	public sealed partial class GenericRequest : global::Java.Lang.Object, global::Com.Bumptech.Glide.Request.IRequest, global::Com.Bumptech.Glide.Request.IResourceCallback, global::Com.Bumptech.Glide.Request.Target.ISizeReadyCallback {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest.Status']"
		[global::Android.Runtime.Register ("com/bumptech/glide/request/GenericRequest$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr CANCELLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest.Status']/field[@name='CANCELLED']"
			[Register ("CANCELLED")]
			public static global::Com.Bumptech.Glide.Request.GenericRequest.Status Cancelled {
				get {
					if (CANCELLED_jfieldId == IntPtr.Zero)
						CANCELLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCELLED", "Lcom/bumptech/glide/request/GenericRequest$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCELLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.GenericRequest.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CLEARED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest.Status']/field[@name='CLEARED']"
			[Register ("CLEARED")]
			public static global::Com.Bumptech.Glide.Request.GenericRequest.Status Cleared {
				get {
					if (CLEARED_jfieldId == IntPtr.Zero)
						CLEARED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLEARED", "Lcom/bumptech/glide/request/GenericRequest$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLEARED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.GenericRequest.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMPLETE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest.Status']/field[@name='COMPLETE']"
			[Register ("COMPLETE")]
			public static global::Com.Bumptech.Glide.Request.GenericRequest.Status Complete {
				get {
					if (COMPLETE_jfieldId == IntPtr.Zero)
						COMPLETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETE", "Lcom/bumptech/glide/request/GenericRequest$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.GenericRequest.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FAILED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest.Status']/field[@name='FAILED']"
			[Register ("FAILED")]
			public static global::Com.Bumptech.Glide.Request.GenericRequest.Status Failed {
				get {
					if (FAILED_jfieldId == IntPtr.Zero)
						FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED", "Lcom/bumptech/glide/request/GenericRequest$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.GenericRequest.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PAUSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest.Status']/field[@name='PAUSED']"
			[Register ("PAUSED")]
			public static global::Com.Bumptech.Glide.Request.GenericRequest.Status Paused {
				get {
					if (PAUSED_jfieldId == IntPtr.Zero)
						PAUSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSED", "Lcom/bumptech/glide/request/GenericRequest$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAUSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.GenericRequest.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PENDING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest.Status']/field[@name='PENDING']"
			[Register ("PENDING")]
			public static global::Com.Bumptech.Glide.Request.GenericRequest.Status Pending {
				get {
					if (PENDING_jfieldId == IntPtr.Zero)
						PENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PENDING", "Lcom/bumptech/glide/request/GenericRequest$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PENDING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.GenericRequest.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RUNNING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest.Status']/field[@name='RUNNING']"
			[Register ("RUNNING")]
			public static global::Com.Bumptech.Glide.Request.GenericRequest.Status Running {
				get {
					if (RUNNING_jfieldId == IntPtr.Zero)
						RUNNING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RUNNING", "Lcom/bumptech/glide/request/GenericRequest$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RUNNING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.GenericRequest.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WAITING_FOR_SIZE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest.Status']/field[@name='WAITING_FOR_SIZE']"
			[Register ("WAITING_FOR_SIZE")]
			public static global::Com.Bumptech.Glide.Request.GenericRequest.Status WaitingForSize {
				get {
					if (WAITING_FOR_SIZE_jfieldId == IntPtr.Zero)
						WAITING_FOR_SIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WAITING_FOR_SIZE", "Lcom/bumptech/glide/request/GenericRequest$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WAITING_FOR_SIZE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.GenericRequest.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/request/GenericRequest$Status", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Status); }
			}

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/GenericRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericRequest); }
		}

		internal GenericRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isCancelled;
		public unsafe bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "GetIsCancelledHandler")]
			get {
				if (id_isCancelled == IntPtr.Zero)
					id_isCancelled = JNIEnv.GetMethodID (class_ref, "isCancelled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isCancelled);
				} finally {
				}
			}
		}

		static IntPtr id_isComplete;
		public unsafe bool IsComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest']/method[@name='isComplete' and count(parameter)=0]"
			[Register ("isComplete", "()Z", "GetIsCompleteHandler")]
			get {
				if (id_isComplete == IntPtr.Zero)
					id_isComplete = JNIEnv.GetMethodID (class_ref, "isComplete", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isComplete);
				} finally {
				}
			}
		}

		static IntPtr id_isFailed;
		public unsafe bool IsFailed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest']/method[@name='isFailed' and count(parameter)=0]"
			[Register ("isFailed", "()Z", "GetIsFailedHandler")]
			get {
				if (id_isFailed == IntPtr.Zero)
					id_isFailed = JNIEnv.GetMethodID (class_ref, "isFailed", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isFailed);
				} finally {
				}
			}
		}

		static IntPtr id_isPaused;
		public unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest']/method[@name='isPaused' and count(parameter)=0]"
			[Register ("isPaused", "()Z", "GetIsPausedHandler")]
			get {
				if (id_isPaused == IntPtr.Zero)
					id_isPaused = JNIEnv.GetMethodID (class_ref, "isPaused", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isPaused);
				} finally {
				}
			}
		}

		static IntPtr id_isResourceSet;
		public unsafe bool IsResourceSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest']/method[@name='isResourceSet' and count(parameter)=0]"
			[Register ("isResourceSet", "()Z", "GetIsResourceSetHandler")]
			get {
				if (id_isResourceSet == IntPtr.Zero)
					id_isResourceSet = JNIEnv.GetMethodID (class_ref, "isResourceSet", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isResourceSet);
				} finally {
				}
			}
		}

		static IntPtr id_isRunning;
		public unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isRunning);
				} finally {
				}
			}
		}

		static IntPtr id_begin;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest']/method[@name='begin' and count(parameter)=0]"
		[Register ("begin", "()V", "")]
		public unsafe void Begin ()
		{
			if (id_begin == IntPtr.Zero)
				id_begin = JNIEnv.GetMethodID (class_ref, "begin", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_begin);
			} finally {
			}
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_clear);
			} finally {
			}
		}

		static IntPtr id_onException_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest']/method[@name='onException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onException", "(Ljava/lang/Exception;)V", "")]
		public unsafe void OnException (global::Java.Lang.Exception p0)
		{
			if (id_onException_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onException_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onException", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_onException_Ljava_lang_Exception_, __args);
			} finally {
			}
		}

		static IntPtr id_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest']/method[@name='onResourceReady' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.load.engine.Resource&lt;?&gt;']]"
		[Register ("onResourceReady", "(Lcom/bumptech/glide/load/engine/Resource;)V", "")]
		public unsafe void OnResourceReady (global::Com.Bumptech.Glide.Load.Engine.IResource p0)
		{
			if (id_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_ == IntPtr.Zero)
				id_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_ = JNIEnv.GetMethodID (class_ref, "onResourceReady", "(Lcom/bumptech/glide/load/engine/Resource;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_, __args);
			} finally {
			}
		}

		static IntPtr id_onSizeReady_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest']/method[@name='onSizeReady' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onSizeReady", "(II)V", "")]
		public unsafe void OnSizeReady (int p0, int p1)
		{
			if (id_onSizeReady_II == IntPtr.Zero)
				id_onSizeReady_II = JNIEnv.GetMethodID (class_ref, "onSizeReady", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_onSizeReady_II, __args);
			} finally {
			}
		}

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "")]
		public unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_pause);
			} finally {
			}
		}

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request']/class[@name='GenericRequest']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "")]
		public unsafe void Recycle ()
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
