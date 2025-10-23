using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x0200035A RID: 858
	[Register("java/util/concurrent/ThreadPoolExecutor", DoNotGenerateAcw = true)]
	public class ThreadPoolExecutor : AbstractExecutorService
	{
		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06002611 RID: 9745 RVA: 0x0006D76D File Offset: 0x0006B96D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ThreadPoolExecutor._members;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x0006D774 File Offset: 0x0006B974
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ThreadPoolExecutor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06002613 RID: 9747 RVA: 0x0006D798 File Offset: 0x0006B998
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ThreadPoolExecutor._members.ManagedPeerType;
			}
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x00063EA6 File Offset: 0x000620A6
		protected ThreadPoolExecutor(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x0006D7A4 File Offset: 0x0006B9A4
		private static Delegate GetIsShutdownHandler()
		{
			if (ThreadPoolExecutor.cb_isShutdown == null)
			{
				ThreadPoolExecutor.cb_isShutdown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ThreadPoolExecutor.n_IsShutdown));
			}
			return ThreadPoolExecutor.cb_isShutdown;
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x0006D7C8 File Offset: 0x0006B9C8
		private static bool n_IsShutdown(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ThreadPoolExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsShutdown;
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x0006D7D7 File Offset: 0x0006B9D7
		public override bool IsShutdown
		{
			get
			{
				return ThreadPoolExecutor._members.InstanceMethods.InvokeVirtualBooleanMethod("isShutdown.()Z", this, null);
			}
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x0006D7F0 File Offset: 0x0006B9F0
		private static Delegate GetIsTerminatedHandler()
		{
			if (ThreadPoolExecutor.cb_isTerminated == null)
			{
				ThreadPoolExecutor.cb_isTerminated = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ThreadPoolExecutor.n_IsTerminated));
			}
			return ThreadPoolExecutor.cb_isTerminated;
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x0006D814 File Offset: 0x0006BA14
		private static bool n_IsTerminated(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ThreadPoolExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTerminated;
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x0006D823 File Offset: 0x0006BA23
		public override bool IsTerminated
		{
			get
			{
				return ThreadPoolExecutor._members.InstanceMethods.InvokeVirtualBooleanMethod("isTerminated.()Z", this, null);
			}
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x0006D83C File Offset: 0x0006BA3C
		private static Delegate GetAwaitTermination_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (ThreadPoolExecutor.cb_awaitTermination_JLjava_util_concurrent_TimeUnit_ == null)
			{
				ThreadPoolExecutor.cb_awaitTermination_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_Z(ThreadPoolExecutor.n_AwaitTermination_JLjava_util_concurrent_TimeUnit_));
			}
			return ThreadPoolExecutor.cb_awaitTermination_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x0006D860 File Offset: 0x0006BA60
		private static bool n_AwaitTermination_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			AbstractExecutorService @object = Java.Lang.Object.GetObject<ThreadPoolExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return @object.AwaitTermination(timeout, object2);
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x0006D884 File Offset: 0x0006BA84
		public unsafe override bool AwaitTermination(long timeout, TimeUnit unit)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(timeout);
				ptr[1] = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				result = ThreadPoolExecutor._members.InstanceMethods.InvokeVirtualBooleanMethod("awaitTermination.(JLjava/util/concurrent/TimeUnit;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(unit);
			}
			return result;
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x0006D8FC File Offset: 0x0006BAFC
		private static Delegate GetExecute_Ljava_lang_Runnable_Handler()
		{
			if (ThreadPoolExecutor.cb_execute_Ljava_lang_Runnable_ == null)
			{
				ThreadPoolExecutor.cb_execute_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ThreadPoolExecutor.n_Execute_Ljava_lang_Runnable_));
			}
			return ThreadPoolExecutor.cb_execute_Ljava_lang_Runnable_;
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x0006D920 File Offset: 0x0006BB20
		private static void n_Execute_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_command)
		{
			AbstractExecutorService @object = Java.Lang.Object.GetObject<ThreadPoolExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			@object.Execute(object2);
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x0006D944 File Offset: 0x0006BB44
		public unsafe override void Execute(IRunnable command)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((command == null) ? IntPtr.Zero : ((Java.Lang.Object)command).Handle);
				ThreadPoolExecutor._members.InstanceMethods.InvokeVirtualVoidMethod("execute.(Ljava/lang/Runnable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(command);
			}
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x0006D9AC File Offset: 0x0006BBAC
		private static Delegate GetShutdownHandler()
		{
			if (ThreadPoolExecutor.cb_shutdown == null)
			{
				ThreadPoolExecutor.cb_shutdown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ThreadPoolExecutor.n_Shutdown));
			}
			return ThreadPoolExecutor.cb_shutdown;
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x0006D9D0 File Offset: 0x0006BBD0
		private static void n_Shutdown(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ThreadPoolExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Shutdown();
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x0006D9DF File Offset: 0x0006BBDF
		public override void Shutdown()
		{
			ThreadPoolExecutor._members.InstanceMethods.InvokeVirtualVoidMethod("shutdown.()V", this, null);
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x0006D9F8 File Offset: 0x0006BBF8
		private static Delegate GetShutdownNowHandler()
		{
			if (ThreadPoolExecutor.cb_shutdownNow == null)
			{
				ThreadPoolExecutor.cb_shutdownNow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ThreadPoolExecutor.n_ShutdownNow));
			}
			return ThreadPoolExecutor.cb_shutdownNow;
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x0006DA1C File Offset: 0x0006BC1C
		private static IntPtr n_ShutdownNow(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IRunnable>.ToLocalJniHandle(Java.Lang.Object.GetObject<ThreadPoolExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShutdownNow());
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x0006DA30 File Offset: 0x0006BC30
		public override IList<IRunnable> ShutdownNow()
		{
			return JavaList<IRunnable>.FromJniHandle(ThreadPoolExecutor._members.InstanceMethods.InvokeVirtualObjectMethod("shutdownNow.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000FC2 RID: 4034
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/ThreadPoolExecutor", typeof(ThreadPoolExecutor));

		// Token: 0x04000FC3 RID: 4035
		private static Delegate cb_isShutdown;

		// Token: 0x04000FC4 RID: 4036
		private static Delegate cb_isTerminated;

		// Token: 0x04000FC5 RID: 4037
		private static Delegate cb_awaitTermination_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000FC6 RID: 4038
		private static Delegate cb_execute_Ljava_lang_Runnable_;

		// Token: 0x04000FC7 RID: 4039
		private static Delegate cb_shutdown;

		// Token: 0x04000FC8 RID: 4040
		private static Delegate cb_shutdownNow;
	}
}
