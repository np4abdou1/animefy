using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.CoroutinesAndroid
{
	// Token: 0x0200000B RID: 11
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/android/HandlerDispatcher", DoNotGenerateAcw = true)]
	internal class HandlerDispatcherInvoker : HandlerDispatcher
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002413 File Offset: 0x00000613
		public HandlerDispatcherInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000241D File Offset: 0x0000061D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HandlerDispatcherInvoker._members;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002424 File Offset: 0x00000624
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HandlerDispatcherInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002430 File Offset: 0x00000630
		public override MainCoroutineDispatcher Immediate
		{
			[Register("getImmediate", "()Lkotlinx/coroutines/android/HandlerDispatcher;", "GetGetImmediateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<MainCoroutineDispatcher>(HandlerDispatcherInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getImmediate.()Lkotlinx/coroutines/android/HandlerDispatcher;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002464 File Offset: 0x00000664
		[Register("scheduleResumeAfterDelay", "(JLkotlinx/coroutines/CancellableContinuation;)V", "GetScheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_Handler")]
		public unsafe override void ScheduleResumeAfterDelay(long timeMillis, ICancellableContinuation continuation)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(timeMillis);
				ptr[1] = new JniArgumentValue((continuation == null) ? IntPtr.Zero : ((Java.Lang.Object)continuation).Handle);
				HandlerDispatcherInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("scheduleResumeAfterDelay.(JLkotlinx/coroutines/CancellableContinuation;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(continuation);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000024E0 File Offset: 0x000006E0
		[Register("dispatch", "(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Runnable;)V", "GetDispatch_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_Handler")]
		public unsafe override void Dispatch(ICoroutineContext context, IRunnable block)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				HandlerDispatcherInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("dispatch.(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Runnable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(block);
			}
		}

		// Token: 0x04000008 RID: 8
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/android/HandlerDispatcher", typeof(HandlerDispatcherInvoker));
	}
}
