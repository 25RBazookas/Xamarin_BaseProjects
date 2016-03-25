using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Engine.Executor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor']"
	[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor", DoNotGenerateAcw=true)]
	public partial class FifoPriorityThreadPoolExecutor : global::Java.Util.Concurrent.ThreadPoolExecutor {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor.DefaultThreadFactory']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$DefaultThreadFactory", DoNotGenerateAcw=true)]
		public partial class DefaultThreadFactory : global::Java.Lang.Object, global::Java.Util.Concurrent.IThreadFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$DefaultThreadFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultThreadFactory); }
			}

			protected DefaultThreadFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor.DefaultThreadFactory']/constructor[@name='FifoPriorityThreadPoolExecutor.DefaultThreadFactory' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DefaultThreadFactory ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (DefaultThreadFactory)) {
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

			static Delegate cb_newThread_Ljava_lang_Runnable_;
#pragma warning disable 0169
			static Delegate GetNewThread_Ljava_lang_Runnable_Handler ()
			{
				if (cb_newThread_Ljava_lang_Runnable_ == null)
					cb_newThread_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewThread_Ljava_lang_Runnable_);
				return cb_newThread_Ljava_lang_Runnable_;
			}

			static IntPtr n_NewThread_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.DefaultThreadFactory __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.DefaultThreadFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewThread (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_newThread_Ljava_lang_Runnable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor.DefaultThreadFactory']/method[@name='newThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;", "GetNewThread_Ljava_lang_Runnable_Handler")]
			public virtual unsafe global::Java.Lang.Thread NewThread (global::Java.Lang.IRunnable p0)
			{
				if (id_newThread_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_newThread_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Java.Lang.Thread __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod  (Handle, id_newThread_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor.LoadTask']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$LoadTask", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial class LoadTask : global::Java.Util.Concurrent.FutureTask, global::Java.Lang.IComparable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$LoadTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LoadTask); }
			}

			protected LoadTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Runnable_Ljava_lang_Object_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor.LoadTask']/constructor[@name='FifoPriorityThreadPoolExecutor.LoadTask' and count(parameter)=3 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='T'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Ljava/lang/Runnable;Ljava/lang/Object;I)V", "")]
			public unsafe LoadTask (global::Java.Lang.IRunnable p0, global::Java.Lang.Object p1, int p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (LoadTask)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Runnable;Ljava/lang/Object;I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Runnable;Ljava/lang/Object;I)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_Runnable_Ljava_lang_Object_I == IntPtr.Zero)
						id_ctor_Ljava_lang_Runnable_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Runnable;Ljava/lang/Object;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Runnable_Ljava_lang_Object_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Runnable_Ljava_lang_Object_I, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_compareTo_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCompareTo_Ljava_lang_Object_Handler ()
			{
				if (cb_compareTo_Ljava_lang_Object_ == null)
					cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Ljava_lang_Object_);
				return cb_compareTo_Ljava_lang_Object_;
			}

			static int n_CompareTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.LoadTask __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.LoadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.CompareTo (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_compareTo_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor.LoadTask']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
			public virtual unsafe int CompareTo (global::Java.Lang.Object p0)
			{
				if (id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
					id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Ljava/lang/Object;)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Ljava_lang_Object_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Ljava/lang/Object;)I"), __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy']"
		[global::Android.Runtime.Register ("com/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy", DoNotGenerateAcw=true)]
		public partial class UncaughtThrowableStrategy : global::Java.Lang.Enum {


			static IntPtr IGNORE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy']/field[@name='IGNORE']"
			[Register ("IGNORE")]
			public static global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy Ignore {
				get {
					if (IGNORE_jfieldId == IntPtr.Zero)
						IGNORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IGNORE", "Lcom/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IGNORE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy']/field[@name='LOG']"
			[Register ("LOG")]
			public static global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy Log {
				get {
					if (LOG_jfieldId == IntPtr.Zero)
						LOG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOG", "Lcom/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr THROW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy']/field[@name='THROW']"
			[Register ("THROW")]
			public static global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy Throw {
				get {
					if (THROW_jfieldId == IntPtr.Zero)
						THROW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THROW", "Lcom/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THROW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UncaughtThrowableStrategy); }
			}

			protected UncaughtThrowableStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_handle_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetHandle_Ljava_lang_Throwable_Handler ()
			{
				if (cb_handle_Ljava_lang_Throwable_ == null)
					cb_handle_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Handle_Ljava_lang_Throwable_);
				return cb_handle_Ljava_lang_Throwable_;
			}

			static void n_Handle_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Handle (p0);
			}
#pragma warning restore 0169

			static IntPtr id_handle_Ljava_lang_Throwable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy']/method[@name='handle' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("handle", "(Ljava/lang/Throwable;)V", "GetHandle_Ljava_lang_Throwable_Handler")]
			protected virtual unsafe void Handle (global::Java.Lang.Throwable p0)
			{
				if (id_handle_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_handle_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "handle", "(Ljava/lang/Throwable;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_handle_Ljava_lang_Throwable_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handle", "(Ljava/lang/Throwable;)V"), __args);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy;", "")]
			public static unsafe global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy __ret = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy;", "")]
			public static unsafe global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy;");
				try {
					return (global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FifoPriorityThreadPoolExecutor); }
		}

		protected FifoPriorityThreadPoolExecutor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIJLjava_util_concurrent_TimeUnit_Ljava_util_concurrent_ThreadFactory_Lcom_bumptech_glide_load_engine_executor_FifoPriorityThreadPoolExecutor_UncaughtThrowableStrategy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor']/constructor[@name='FifoPriorityThreadPoolExecutor' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='java.util.concurrent.TimeUnit'] and parameter[5][@type='java.util.concurrent.ThreadFactory'] and parameter[6][@type='com.bumptech.glide.load.engine.executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy']]"
		[Register (".ctor", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/ThreadFactory;Lcom/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy;)V", "")]
		public unsafe FifoPriorityThreadPoolExecutor (int p0, int p1, long p2, global::Java.Util.Concurrent.TimeUnit p3, global::Java.Util.Concurrent.IThreadFactory p4, global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (GetType () != typeof (FifoPriorityThreadPoolExecutor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/ThreadFactory;Lcom/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/ThreadFactory;Lcom/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy;)V", __args);
					return;
				}

				if (id_ctor_IIJLjava_util_concurrent_TimeUnit_Ljava_util_concurrent_ThreadFactory_Lcom_bumptech_glide_load_engine_executor_FifoPriorityThreadPoolExecutor_UncaughtThrowableStrategy_ == IntPtr.Zero)
					id_ctor_IIJLjava_util_concurrent_TimeUnit_Ljava_util_concurrent_ThreadFactory_Lcom_bumptech_glide_load_engine_executor_FifoPriorityThreadPoolExecutor_UncaughtThrowableStrategy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/ThreadFactory;Lcom/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIJLjava_util_concurrent_TimeUnit_Ljava_util_concurrent_ThreadFactory_Lcom_bumptech_glide_load_engine_executor_FifoPriorityThreadPoolExecutor_UncaughtThrowableStrategy_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIJLjava_util_concurrent_TimeUnit_Ljava_util_concurrent_ThreadFactory_Lcom_bumptech_glide_load_engine_executor_FifoPriorityThreadPoolExecutor_UncaughtThrowableStrategy_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_ILcom_bumptech_glide_load_engine_executor_FifoPriorityThreadPoolExecutor_UncaughtThrowableStrategy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor']/constructor[@name='FifoPriorityThreadPoolExecutor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.bumptech.glide.load.engine.executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy']]"
		[Register (".ctor", "(ILcom/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy;)V", "")]
		public unsafe FifoPriorityThreadPoolExecutor (int p0, global::Com.Bumptech.Glide.Load.Engine.Executor.FifoPriorityThreadPoolExecutor.UncaughtThrowableStrategy p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FifoPriorityThreadPoolExecutor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILcom/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILcom/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy;)V", __args);
					return;
				}

				if (id_ctor_ILcom_bumptech_glide_load_engine_executor_FifoPriorityThreadPoolExecutor_UncaughtThrowableStrategy_ == IntPtr.Zero)
					id_ctor_ILcom_bumptech_glide_load_engine_executor_FifoPriorityThreadPoolExecutor_UncaughtThrowableStrategy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILcom/bumptech/glide/load/engine/executor/FifoPriorityThreadPoolExecutor$UncaughtThrowableStrategy;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILcom_bumptech_glide_load_engine_executor_FifoPriorityThreadPoolExecutor_UncaughtThrowableStrategy_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILcom_bumptech_glide_load_engine_executor_FifoPriorityThreadPoolExecutor_UncaughtThrowableStrategy_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.load.engine.executor']/class[@name='FifoPriorityThreadPoolExecutor']/constructor[@name='FifoPriorityThreadPoolExecutor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe FifoPriorityThreadPoolExecutor (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FifoPriorityThreadPoolExecutor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

	}
}
