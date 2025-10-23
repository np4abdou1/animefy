using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x02000342 RID: 834
	[Register("java/util/concurrent/AbstractExecutorService", DoNotGenerateAcw = true)]
	internal class AbstractExecutorServiceInvoker : AbstractExecutorService
	{
		// Token: 0x0600237B RID: 9083 RVA: 0x00063EA6 File Offset: 0x000620A6
		public AbstractExecutorServiceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x00063EB0 File Offset: 0x000620B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractExecutorServiceInvoker._members;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x00063EB7 File Offset: 0x000620B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractExecutorServiceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x00063EC3 File Offset: 0x000620C3
		public override bool IsShutdown
		{
			get
			{
				return AbstractExecutorServiceInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isShutdown.()Z", this, null);
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x00063EDC File Offset: 0x000620DC
		public override bool IsTerminated
		{
			get
			{
				return AbstractExecutorServiceInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isTerminated.()Z", this, null);
			}
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x00063EF8 File Offset: 0x000620F8
		public unsafe override bool AwaitTermination(long timeout, TimeUnit unit)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(timeout);
				ptr[1] = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				result = AbstractExecutorServiceInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("awaitTermination.(JLjava/util/concurrent/TimeUnit;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(unit);
			}
			return result;
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x00063F70 File Offset: 0x00062170
		public override void Shutdown()
		{
			AbstractExecutorServiceInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("shutdown.()V", this, null);
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00063F8C File Offset: 0x0006218C
		public override IList<IRunnable> ShutdownNow()
		{
			return JavaList<IRunnable>.FromJniHandle(AbstractExecutorServiceInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("shutdownNow.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x00063FC0 File Offset: 0x000621C0
		public unsafe override void Execute(IRunnable command)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((command == null) ? IntPtr.Zero : ((Java.Lang.Object)command).Handle);
				AbstractExecutorServiceInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("execute.(Ljava/lang/Runnable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(command);
			}
		}

		// Token: 0x04000E9A RID: 3738
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/AbstractExecutorService", typeof(AbstractExecutorServiceInvoker));
	}
}
