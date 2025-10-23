using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000037 RID: 55
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ExecutorsKt", DoNotGenerateAcw = true)]
	public sealed class ExecutorsKt : Java.Lang.Object
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000052B4 File Offset: 0x000034B4
		internal static IntPtr class_ref
		{
			get
			{
				return ExecutorsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000052D8 File Offset: 0x000034D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExecutorsKt._members;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000052E0 File Offset: 0x000034E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExecutorsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00005304 File Offset: 0x00003504
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExecutorsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00005310 File Offset: 0x00003510
		internal ExecutorsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000531C File Offset: 0x0000351C
		[Register("asExecutor", "(Lkotlinx/coroutines/CoroutineDispatcher;)Ljava/util/concurrent/Executor;", "")]
		public unsafe static IExecutor AsExecutor(CoroutineDispatcher obj)
		{
			IExecutor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<IExecutor>(ExecutorsKt._members.StaticMethods.InvokeObjectMethod("asExecutor.(Lkotlinx/coroutines/CoroutineDispatcher;)Ljava/util/concurrent/Executor;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00005390 File Offset: 0x00003590
		[Register("from", "(Ljava/util/concurrent/Executor;)Lkotlinx/coroutines/CoroutineDispatcher;", "")]
		public unsafe static CoroutineDispatcher From(IExecutor obj)
		{
			CoroutineDispatcher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@object = Java.Lang.Object.GetObject<CoroutineDispatcher>(ExecutorsKt._members.StaticMethods.InvokeObjectMethod("from.(Ljava/util/concurrent/Executor;)Lkotlinx/coroutines/CoroutineDispatcher;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00005408 File Offset: 0x00003608
		[Register("from", "(Ljava/util/concurrent/ExecutorService;)Lkotlinx/coroutines/ExecutorCoroutineDispatcher;", "")]
		public unsafe static ExecutorCoroutineDispatcher From(IExecutorService obj)
		{
			ExecutorCoroutineDispatcher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@object = Java.Lang.Object.GetObject<ExecutorCoroutineDispatcher>(ExecutorsKt._members.StaticMethods.InvokeObjectMethod("from.(Ljava/util/concurrent/ExecutorService;)Lkotlinx/coroutines/ExecutorCoroutineDispatcher;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0400002F RID: 47
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ExecutorsKt", typeof(ExecutorsKt));
	}
}
