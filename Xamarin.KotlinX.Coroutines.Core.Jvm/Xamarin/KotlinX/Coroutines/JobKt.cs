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
	// Token: 0x02000077 RID: 119
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/JobKt", DoNotGenerateAcw = true)]
	public sealed class JobKt : Java.Lang.Object
	{
		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x0001132C File Offset: 0x0000F52C
		internal static IntPtr class_ref
		{
			get
			{
				return JobKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00011350 File Offset: 0x0000F550
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JobKt._members;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00011358 File Offset: 0x0000F558
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JobKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0001137C File Offset: 0x0000F57C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JobKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00011388 File Offset: 0x0000F588
		internal JobKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00011394 File Offset: 0x0000F594
		[Register("Job", "(Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/CompletableJob;", "")]
		public unsafe static ICompletableJob Job([Nullable(2)] IJob parent)
		{
			ICompletableJob @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : ((Java.Lang.Object)parent).Handle);
				@object = Java.Lang.Object.GetObject<ICompletableJob>(JobKt._members.StaticMethods.InvokeObjectMethod("Job.(Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/CompletableJob;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(parent);
			}
			return @object;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0001140C File Offset: 0x0000F60C
		[Register("cancel", "(Lkotlin/coroutines/CoroutineContext;Ljava/util/concurrent/CancellationException;)V", "")]
		public unsafe static void Cancel(ICoroutineContext _this_cancel, [Nullable(2)] CancellationException cause)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_cancel == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_cancel).Handle);
				ptr[1] = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				JobKt._members.StaticMethods.InvokeVoidMethod("cancel.(Lkotlin/coroutines/CoroutineContext;Ljava/util/concurrent/CancellationException;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_cancel);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0001149C File Offset: 0x0000F69C
		[Register("cancel", "(Lkotlinx/coroutines/Job;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe static void Cancel(IJob _this_cancel, string message, [Nullable(2)] Throwable cause)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_cancel == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_cancel).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				JobKt._members.StaticMethods.InvokeVoidMethod("cancel.(Lkotlinx/coroutines/Job;Ljava/lang/String;Ljava/lang/Throwable;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_cancel);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00011550 File Offset: 0x0000F750
		[Register("cancelAndJoin", "(Lkotlinx/coroutines/Job;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object CancelAndJoin(IJob _this_cancelAndJoin, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_cancelAndJoin == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_cancelAndJoin).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(JobKt._members.StaticMethods.InvokeObjectMethod("cancelAndJoin.(Lkotlinx/coroutines/Job;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_cancelAndJoin);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000115F4 File Offset: 0x0000F7F4
		[Register("cancelChildren", "(Lkotlin/coroutines/CoroutineContext;Ljava/util/concurrent/CancellationException;)V", "")]
		public unsafe static void CancelChildren(ICoroutineContext _this_cancelChildren, [Nullable(2)] CancellationException cause)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_cancelChildren == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_cancelChildren).Handle);
				ptr[1] = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				JobKt._members.StaticMethods.InvokeVoidMethod("cancelChildren.(Lkotlin/coroutines/CoroutineContext;Ljava/util/concurrent/CancellationException;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_cancelChildren);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00011684 File Offset: 0x0000F884
		[Register("cancelChildren", "(Lkotlinx/coroutines/Job;Ljava/util/concurrent/CancellationException;)V", "")]
		public unsafe static void CancelChildren(IJob _this_cancelChildren, [Nullable(2)] CancellationException cause)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_cancelChildren == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_cancelChildren).Handle);
				ptr[1] = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				JobKt._members.StaticMethods.InvokeVoidMethod("cancelChildren.(Lkotlinx/coroutines/Job;Ljava/util/concurrent/CancellationException;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_cancelChildren);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00011714 File Offset: 0x0000F914
		[Register("cancelFutureOnCancellation", "(Lkotlinx/coroutines/CancellableContinuation;Ljava/util/concurrent/Future;)V", "")]
		public unsafe static void CancelFutureOnCancellation(ICancellableContinuation _this_cancelFutureOnCancellation, IFuture future)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_cancelFutureOnCancellation == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_cancelFutureOnCancellation).Handle);
				ptr[1] = new JniArgumentValue((future == null) ? IntPtr.Zero : ((Java.Lang.Object)future).Handle);
				JobKt._members.StaticMethods.InvokeVoidMethod("cancelFutureOnCancellation.(Lkotlinx/coroutines/CancellableContinuation;Ljava/util/concurrent/Future;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_cancelFutureOnCancellation);
				GC.KeepAlive(future);
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000117A8 File Offset: 0x0000F9A8
		[Register("cancelFutureOnCompletion", "(Lkotlinx/coroutines/Job;Ljava/util/concurrent/Future;)Lkotlinx/coroutines/DisposableHandle;", "")]
		public unsafe static IDisposableHandle CancelFutureOnCompletion(IJob _this_cancelFutureOnCompletion, IFuture future)
		{
			IDisposableHandle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_cancelFutureOnCompletion == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_cancelFutureOnCompletion).Handle);
				ptr[1] = new JniArgumentValue((future == null) ? IntPtr.Zero : ((Java.Lang.Object)future).Handle);
				@object = Java.Lang.Object.GetObject<IDisposableHandle>(JobKt._members.StaticMethods.InvokeObjectMethod("cancelFutureOnCompletion.(Lkotlinx/coroutines/Job;Ljava/util/concurrent/Future;)Lkotlinx/coroutines/DisposableHandle;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_cancelFutureOnCompletion);
				GC.KeepAlive(future);
			}
			return @object;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0001184C File Offset: 0x0000FA4C
		[Register("disposeOnCompletion", "(Lkotlinx/coroutines/Job;Lkotlinx/coroutines/DisposableHandle;)Lkotlinx/coroutines/DisposableHandle;", "")]
		public unsafe static IDisposableHandle DisposeOnCompletion(IJob _this_disposeOnCompletion, IDisposableHandle handle)
		{
			IDisposableHandle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_disposeOnCompletion == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_disposeOnCompletion).Handle);
				ptr[1] = new JniArgumentValue((handle == null) ? IntPtr.Zero : ((Java.Lang.Object)handle).Handle);
				@object = Java.Lang.Object.GetObject<IDisposableHandle>(JobKt._members.StaticMethods.InvokeObjectMethod("disposeOnCompletion.(Lkotlinx/coroutines/Job;Lkotlinx/coroutines/DisposableHandle;)Lkotlinx/coroutines/DisposableHandle;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_disposeOnCompletion);
				GC.KeepAlive(handle);
			}
			return @object;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000118F0 File Offset: 0x0000FAF0
		[Register("ensureActive", "(Lkotlin/coroutines/CoroutineContext;)V", "")]
		public unsafe static void EnsureActive(ICoroutineContext _this_ensureActive)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_ensureActive == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_ensureActive).Handle);
				JobKt._members.StaticMethods.InvokeVoidMethod("ensureActive.(Lkotlin/coroutines/CoroutineContext;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_ensureActive);
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00011958 File Offset: 0x0000FB58
		[Register("ensureActive", "(Lkotlinx/coroutines/Job;)V", "")]
		public unsafe static void EnsureActive(IJob _this_ensureActive)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_ensureActive == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_ensureActive).Handle);
				JobKt._members.StaticMethods.InvokeVoidMethod("ensureActive.(Lkotlinx/coroutines/Job;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_ensureActive);
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000119C0 File Offset: 0x0000FBC0
		[Register("getJob", "(Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/Job;", "")]
		public unsafe static IJob GetJob(ICoroutineContext _this_job)
		{
			IJob @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_job == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_job).Handle);
				@object = Java.Lang.Object.GetObject<IJob>(JobKt._members.StaticMethods.InvokeObjectMethod("getJob.(Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/Job;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_job);
			}
			return @object;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00011A38 File Offset: 0x0000FC38
		[Register("isActive", "(Lkotlin/coroutines/CoroutineContext;)Z", "")]
		public unsafe static bool IsActive(ICoroutineContext _this_isActive)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_isActive == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_isActive).Handle);
				result = JobKt._members.StaticMethods.InvokeBooleanMethod("isActive.(Lkotlin/coroutines/CoroutineContext;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_isActive);
			}
			return result;
		}

		// Token: 0x040001EE RID: 494
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/JobKt", typeof(JobKt));
	}
}
