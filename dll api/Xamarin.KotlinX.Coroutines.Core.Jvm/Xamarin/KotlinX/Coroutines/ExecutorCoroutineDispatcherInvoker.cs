using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000036 RID: 54
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ExecutorCoroutineDispatcher", DoNotGenerateAcw = true)]
	internal class ExecutorCoroutineDispatcherInvoker : ExecutorCoroutineDispatcher
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00005194 File Offset: 0x00003394
		public ExecutorCoroutineDispatcherInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000519E File Offset: 0x0000339E
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExecutorCoroutineDispatcherInvoker._members;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000051A5 File Offset: 0x000033A5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExecutorCoroutineDispatcherInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000051B4 File Offset: 0x000033B4
		public override IExecutor Executor
		{
			[Register("getExecutor", "()Ljava/util/concurrent/Executor;", "GetGetExecutorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IExecutor>(ExecutorCoroutineDispatcherInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getExecutor.()Ljava/util/concurrent/Executor;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000051E6 File Offset: 0x000033E6
		[Register("close", "()V", "GetCloseHandler")]
		public override void Close()
		{
			ExecutorCoroutineDispatcherInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("close.()V", this, null);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00005200 File Offset: 0x00003400
		[Register("dispatch", "(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Runnable;)V", "GetDispatch_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_Handler")]
		public unsafe override void Dispatch(ICoroutineContext context, IRunnable block)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				ExecutorCoroutineDispatcherInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("dispatch.(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Runnable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(block);
			}
		}

		// Token: 0x0400002E RID: 46
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ExecutorCoroutineDispatcher", typeof(ExecutorCoroutineDispatcherInvoker));
	}
}
