using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Future
{
	// Token: 0x020000A7 RID: 167
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/future/FutureKt", DoNotGenerateAcw = true)]
	public sealed class FutureKt : Java.Lang.Object
	{
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x000170A0 File Offset: 0x000152A0
		internal static IntPtr class_ref
		{
			get
			{
				return FutureKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x000170C4 File Offset: 0x000152C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FutureKt._members;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x000170CC File Offset: 0x000152CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FutureKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x000170F0 File Offset: 0x000152F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FutureKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000170FC File Offset: 0x000152FC
		internal FutureKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00017108 File Offset: 0x00015308
		[Register("asCompletableFuture", "(Lkotlinx/coroutines/Deferred;)Ljava/util/concurrent/CompletableFuture;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static CompletableFuture AsCompletableFuture(IDeferred obj)
		{
			CompletableFuture @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(FutureKt._members.StaticMethods.InvokeObjectMethod("asCompletableFuture.(Lkotlinx/coroutines/Deferred;)Ljava/util/concurrent/CompletableFuture;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00017180 File Offset: 0x00015380
		[Register("asCompletableFuture", "(Lkotlinx/coroutines/Job;)Ljava/util/concurrent/CompletableFuture;", "")]
		public unsafe static CompletableFuture AsCompletableFuture(IJob obj)
		{
			CompletableFuture @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(FutureKt._members.StaticMethods.InvokeObjectMethod("asCompletableFuture.(Lkotlinx/coroutines/Job;)Ljava/util/concurrent/CompletableFuture;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x000171F8 File Offset: 0x000153F8
		[Register("asDeferred", "(Ljava/util/concurrent/CompletionStage;)Lkotlinx/coroutines/Deferred;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IDeferred AsDeferred(ICompletionStage obj)
		{
			IDeferred @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@object = Java.Lang.Object.GetObject<IDeferred>(FutureKt._members.StaticMethods.InvokeObjectMethod("asDeferred.(Ljava/util/concurrent/CompletionStage;)Lkotlinx/coroutines/Deferred;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00017270 File Offset: 0x00015470
		[Register("await", "(Ljava/util/concurrent/CompletionStage;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Await(ICompletionStage obj, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FutureKt._members.StaticMethods.InvokeObjectMethod("await.(Ljava/util/concurrent/CompletionStage;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00017314 File Offset: 0x00015514
		[Register("future", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;Lkotlinx/coroutines/CoroutineStart;Lkotlin/jvm/functions/Function2;)Ljava/util/concurrent/CompletableFuture;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static CompletableFuture Future(ICoroutineScope obj, ICoroutineContext context, CoroutineStart start, IFunction2 block)
		{
			CompletableFuture @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[2] = new JniArgumentValue((start == null) ? IntPtr.Zero : start.Handle);
				ptr[3] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(FutureKt._members.StaticMethods.InvokeObjectMethod("future.(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;Lkotlinx/coroutines/CoroutineStart;Lkotlin/jvm/functions/Function2;)Ljava/util/concurrent/CompletableFuture;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(context);
				GC.KeepAlive(start);
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x04000276 RID: 630
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/future/FutureKt", typeof(FutureKt));
	}
}
