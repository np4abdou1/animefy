using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x02000341 RID: 833
	[Register("java/util/concurrent/AbstractExecutorService", DoNotGenerateAcw = true)]
	public abstract class AbstractExecutorService : Java.Lang.Object, IExecutorService, IExecutor, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x000636DE File Offset: 0x000618DE
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractExecutorService._members;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x000636E8 File Offset: 0x000618E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractExecutorService._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x0006370C File Offset: 0x0006190C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractExecutorService._members.ManagedPeerType;
			}
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x000021E0 File Offset: 0x000003E0
		protected AbstractExecutorService(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x00063718 File Offset: 0x00061918
		private static Delegate GetInvokeAll_Ljava_util_Collection_Handler()
		{
			if (AbstractExecutorService.cb_invokeAll_Ljava_util_Collection_ == null)
			{
				AbstractExecutorService.cb_invokeAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AbstractExecutorService.n_InvokeAll_Ljava_util_Collection_));
			}
			return AbstractExecutorService.cb_invokeAll_Ljava_util_Collection_;
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x0006373C File Offset: 0x0006193C
		private static IntPtr n_InvokeAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks)
		{
			AbstractExecutorService @object = Java.Lang.Object.GetObject<AbstractExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection tasks = JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			return JavaList.ToLocalJniHandle(@object.InvokeAll(tasks));
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x00063764 File Offset: 0x00061964
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual IList InvokeAll(ICollection tasks)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(tasks);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(AbstractExecutorService._members.InstanceMethods.InvokeVirtualObjectMethod("invokeAll.(Ljava/util/Collection;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tasks);
			}
			return result;
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x000637D8 File Offset: 0x000619D8
		private static Delegate GetInvokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (AbstractExecutorService.cb_invokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_ == null)
			{
				AbstractExecutorService.cb_invokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJL_L(AbstractExecutorService.n_InvokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_));
			}
			return AbstractExecutorService.cb_invokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x000637FC File Offset: 0x000619FC
		private static IntPtr n_InvokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks, long timeout, IntPtr native_unit)
		{
			AbstractExecutorService @object = Java.Lang.Object.GetObject<AbstractExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection tasks = JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return JavaList.ToLocalJniHandle(@object.InvokeAll(tasks, timeout, object2));
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x00063830 File Offset: 0x00061A30
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual IList InvokeAll(ICollection tasks, long timeout, TimeUnit unit)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(tasks);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(timeout);
				ptr[2] = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				result = JavaList.FromJniHandle(AbstractExecutorService._members.InstanceMethods.InvokeVirtualObjectMethod("invokeAll.(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tasks);
				GC.KeepAlive(unit);
			}
			return result;
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x000638E0 File Offset: 0x00061AE0
		private static Delegate GetInvokeAny_Ljava_util_Collection_Handler()
		{
			if (AbstractExecutorService.cb_invokeAny_Ljava_util_Collection_ == null)
			{
				AbstractExecutorService.cb_invokeAny_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AbstractExecutorService.n_InvokeAny_Ljava_util_Collection_));
			}
			return AbstractExecutorService.cb_invokeAny_Ljava_util_Collection_;
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x00063904 File Offset: 0x00061B04
		private static IntPtr n_InvokeAny_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks)
		{
			AbstractExecutorService @object = Java.Lang.Object.GetObject<AbstractExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection tasks = JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeAny(tasks));
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x0006392C File Offset: 0x00061B2C
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual Java.Lang.Object InvokeAny(ICollection tasks)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(tasks);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractExecutorService._members.InstanceMethods.InvokeVirtualObjectMethod("invokeAny.(Ljava/util/Collection;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tasks);
			}
			return @object;
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x000639A0 File Offset: 0x00061BA0
		private static Delegate GetInvokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (AbstractExecutorService.cb_invokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_ == null)
			{
				AbstractExecutorService.cb_invokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJL_L(AbstractExecutorService.n_InvokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_));
			}
			return AbstractExecutorService.cb_invokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x000639C4 File Offset: 0x00061BC4
		private static IntPtr n_InvokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks, long timeout, IntPtr native_unit)
		{
			AbstractExecutorService @object = Java.Lang.Object.GetObject<AbstractExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection tasks = JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeAny(tasks, timeout, object2));
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x000639F8 File Offset: 0x00061BF8
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual Java.Lang.Object InvokeAny(ICollection tasks, long timeout, TimeUnit unit)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(tasks);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(timeout);
				ptr[2] = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractExecutorService._members.InstanceMethods.InvokeVirtualObjectMethod("invokeAny.(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tasks);
				GC.KeepAlive(unit);
			}
			return @object;
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x00063AA8 File Offset: 0x00061CA8
		private static Delegate GetSubmit_Ljava_lang_Runnable_Handler()
		{
			if (AbstractExecutorService.cb_submit_Ljava_lang_Runnable_ == null)
			{
				AbstractExecutorService.cb_submit_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AbstractExecutorService.n_Submit_Ljava_lang_Runnable_));
			}
			return AbstractExecutorService.cb_submit_Ljava_lang_Runnable_;
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x00063ACC File Offset: 0x00061CCC
		private static IntPtr n_Submit_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			AbstractExecutorService @object = Java.Lang.Object.GetObject<AbstractExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_task, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Submit(object2));
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x00063AF4 File Offset: 0x00061CF4
		public unsafe virtual IFuture Submit(IRunnable task)
		{
			IFuture @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((task == null) ? IntPtr.Zero : ((Java.Lang.Object)task).Handle);
				@object = Java.Lang.Object.GetObject<IFuture>(AbstractExecutorService._members.InstanceMethods.InvokeVirtualObjectMethod("submit.(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(task);
			}
			return @object;
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x00063B6C File Offset: 0x00061D6C
		private static Delegate GetSubmit_Ljava_lang_Runnable_Ljava_lang_Object_Handler()
		{
			if (AbstractExecutorService.cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_ == null)
			{
				AbstractExecutorService.cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AbstractExecutorService.n_Submit_Ljava_lang_Runnable_Ljava_lang_Object_));
			}
			return AbstractExecutorService.cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_;
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x00063B90 File Offset: 0x00061D90
		private static IntPtr n_Submit_Ljava_lang_Runnable_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_task, IntPtr native_result)
		{
			AbstractExecutorService @object = Java.Lang.Object.GetObject<AbstractExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_task, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_result, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Submit(object2, object3));
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x00063BC4 File Offset: 0x00061DC4
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual IFuture Submit(IRunnable task, Java.Lang.Object result)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(result);
			IFuture @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((task == null) ? IntPtr.Zero : ((Java.Lang.Object)task).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IFuture>(AbstractExecutorService._members.InstanceMethods.InvokeVirtualObjectMethod("submit.(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(task);
				GC.KeepAlive(result);
			}
			return @object;
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x00063C64 File Offset: 0x00061E64
		private static Delegate GetSubmit_Ljava_util_concurrent_Callable_Handler()
		{
			if (AbstractExecutorService.cb_submit_Ljava_util_concurrent_Callable_ == null)
			{
				AbstractExecutorService.cb_submit_Ljava_util_concurrent_Callable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AbstractExecutorService.n_Submit_Ljava_util_concurrent_Callable_));
			}
			return AbstractExecutorService.cb_submit_Ljava_util_concurrent_Callable_;
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x00063C88 File Offset: 0x00061E88
		private static IntPtr n_Submit_Ljava_util_concurrent_Callable_(IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			AbstractExecutorService @object = Java.Lang.Object.GetObject<AbstractExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICallable object2 = Java.Lang.Object.GetObject<ICallable>(native_task, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Submit(object2));
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x00063CB0 File Offset: 0x00061EB0
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual IFuture Submit(ICallable task)
		{
			IFuture @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((task == null) ? IntPtr.Zero : ((Java.Lang.Object)task).Handle);
				@object = Java.Lang.Object.GetObject<IFuture>(AbstractExecutorService._members.InstanceMethods.InvokeVirtualObjectMethod("submit.(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(task);
			}
			return @object;
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x00063D28 File Offset: 0x00061F28
		private static Delegate GetAwaitTermination_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (AbstractExecutorService.cb_awaitTermination_JLjava_util_concurrent_TimeUnit_ == null)
			{
				AbstractExecutorService.cb_awaitTermination_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_Z(AbstractExecutorService.n_AwaitTermination_JLjava_util_concurrent_TimeUnit_));
			}
			return AbstractExecutorService.cb_awaitTermination_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x00063D4C File Offset: 0x00061F4C
		private static bool n_AwaitTermination_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			AbstractExecutorService @object = Java.Lang.Object.GetObject<AbstractExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return @object.AwaitTermination(timeout, object2);
		}

		// Token: 0x0600236A RID: 9066
		public abstract bool AwaitTermination(long timeout, TimeUnit unit);

		// Token: 0x0600236B RID: 9067 RVA: 0x00063D70 File Offset: 0x00061F70
		private static Delegate GetShutdownHandler()
		{
			if (AbstractExecutorService.cb_shutdown == null)
			{
				AbstractExecutorService.cb_shutdown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AbstractExecutorService.n_Shutdown));
			}
			return AbstractExecutorService.cb_shutdown;
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x00063D94 File Offset: 0x00061F94
		private static void n_Shutdown(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AbstractExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Shutdown();
		}

		// Token: 0x0600236D RID: 9069
		public abstract void Shutdown();

		// Token: 0x0600236E RID: 9070 RVA: 0x00063DA3 File Offset: 0x00061FA3
		private static Delegate GetShutdownNowHandler()
		{
			if (AbstractExecutorService.cb_shutdownNow == null)
			{
				AbstractExecutorService.cb_shutdownNow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractExecutorService.n_ShutdownNow));
			}
			return AbstractExecutorService.cb_shutdownNow;
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x00063DC7 File Offset: 0x00061FC7
		private static IntPtr n_ShutdownNow(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IRunnable>.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShutdownNow());
		}

		// Token: 0x06002370 RID: 9072
		public abstract IList<IRunnable> ShutdownNow();

		// Token: 0x06002371 RID: 9073 RVA: 0x00063DDB File Offset: 0x00061FDB
		private static Delegate GetIsShutdownHandler()
		{
			if (AbstractExecutorService.cb_isShutdown == null)
			{
				AbstractExecutorService.cb_isShutdown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AbstractExecutorService.n_IsShutdown));
			}
			return AbstractExecutorService.cb_isShutdown;
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x00063DFF File Offset: 0x00061FFF
		private static bool n_IsShutdown(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsShutdown;
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06002373 RID: 9075
		public abstract bool IsShutdown { get; }

		// Token: 0x06002374 RID: 9076 RVA: 0x00063E0E File Offset: 0x0006200E
		private static Delegate GetIsTerminatedHandler()
		{
			if (AbstractExecutorService.cb_isTerminated == null)
			{
				AbstractExecutorService.cb_isTerminated = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AbstractExecutorService.n_IsTerminated));
			}
			return AbstractExecutorService.cb_isTerminated;
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x00063E32 File Offset: 0x00062032
		private static bool n_IsTerminated(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTerminated;
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06002376 RID: 9078
		public abstract bool IsTerminated { get; }

		// Token: 0x06002377 RID: 9079 RVA: 0x00063E41 File Offset: 0x00062041
		private static Delegate GetExecute_Ljava_lang_Runnable_Handler()
		{
			if (AbstractExecutorService.cb_execute_Ljava_lang_Runnable_ == null)
			{
				AbstractExecutorService.cb_execute_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AbstractExecutorService.n_Execute_Ljava_lang_Runnable_));
			}
			return AbstractExecutorService.cb_execute_Ljava_lang_Runnable_;
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x00063E68 File Offset: 0x00062068
		private static void n_Execute_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_command)
		{
			AbstractExecutorService @object = Java.Lang.Object.GetObject<AbstractExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			@object.Execute(object2);
		}

		// Token: 0x06002379 RID: 9081
		public abstract void Execute(IRunnable command);

		// Token: 0x04000E8C RID: 3724
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/AbstractExecutorService", typeof(AbstractExecutorService));

		// Token: 0x04000E8D RID: 3725
		private static Delegate cb_invokeAll_Ljava_util_Collection_;

		// Token: 0x04000E8E RID: 3726
		private static Delegate cb_invokeAll_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000E8F RID: 3727
		private static Delegate cb_invokeAny_Ljava_util_Collection_;

		// Token: 0x04000E90 RID: 3728
		private static Delegate cb_invokeAny_Ljava_util_Collection_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000E91 RID: 3729
		private static Delegate cb_submit_Ljava_lang_Runnable_;

		// Token: 0x04000E92 RID: 3730
		private static Delegate cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_;

		// Token: 0x04000E93 RID: 3731
		private static Delegate cb_submit_Ljava_util_concurrent_Callable_;

		// Token: 0x04000E94 RID: 3732
		private static Delegate cb_awaitTermination_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000E95 RID: 3733
		private static Delegate cb_shutdown;

		// Token: 0x04000E96 RID: 3734
		private static Delegate cb_shutdownNow;

		// Token: 0x04000E97 RID: 3735
		private static Delegate cb_isShutdown;

		// Token: 0x04000E98 RID: 3736
		private static Delegate cb_isTerminated;

		// Token: 0x04000E99 RID: 3737
		private static Delegate cb_execute_Ljava_lang_Runnable_;
	}
}
