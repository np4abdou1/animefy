using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200001B RID: 27
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/BuildersKt", DoNotGenerateAcw = true)]
	public sealed class BuildersKt : Java.Lang.Object
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000024C4 File Offset: 0x000006C4
		internal static IntPtr class_ref
		{
			get
			{
				return BuildersKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000024E8 File Offset: 0x000006E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BuildersKt._members;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000024F0 File Offset: 0x000006F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BuildersKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002514 File Offset: 0x00000714
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BuildersKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002520 File Offset: 0x00000720
		internal BuildersKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000252C File Offset: 0x0000072C
		[Register("async", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;Lkotlinx/coroutines/CoroutineStart;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/Deferred;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IDeferred Async(ICoroutineScope _this_async, ICoroutineContext context, CoroutineStart start, IFunction2 block)
		{
			IDeferred @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_async == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_async).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[2] = new JniArgumentValue((start == null) ? IntPtr.Zero : start.Handle);
				ptr[3] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<IDeferred>(BuildersKt._members.StaticMethods.InvokeObjectMethod("async.(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;Lkotlinx/coroutines/CoroutineStart;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/Deferred;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_async);
				GC.KeepAlive(context);
				GC.KeepAlive(start);
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000262C File Offset: 0x0000082C
		[Register("invoke", "(Lkotlinx/coroutines/CoroutineDispatcher;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Invoke(CoroutineDispatcher _this_invoke, IFunction2 block, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_invoke == null) ? IntPtr.Zero : _this_invoke.Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BuildersKt._members.StaticMethods.InvokeObjectMethod("invoke.(Lkotlinx/coroutines/CoroutineDispatcher;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_invoke);
				GC.KeepAlive(block);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000026FC File Offset: 0x000008FC
		[Register("launch", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;Lkotlinx/coroutines/CoroutineStart;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/Job;", "")]
		public unsafe static IJob Launch(ICoroutineScope _this_launch, ICoroutineContext context, CoroutineStart start, IFunction2 block)
		{
			IJob @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_launch == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_launch).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[2] = new JniArgumentValue((start == null) ? IntPtr.Zero : start.Handle);
				ptr[3] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<IJob>(BuildersKt._members.StaticMethods.InvokeObjectMethod("launch.(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;Lkotlinx/coroutines/CoroutineStart;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/Job;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_launch);
				GC.KeepAlive(context);
				GC.KeepAlive(start);
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000027FC File Offset: 0x000009FC
		[Register("runBlocking", "(Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object RunBlocking(ICoroutineContext context, IFunction2 block)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BuildersKt._members.StaticMethods.InvokeObjectMethod("runBlocking.(Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000028A0 File Offset: 0x00000AA0
		[Register("withContext", "(Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object WithContext(ICoroutineContext context, IFunction2 block, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BuildersKt._members.StaticMethods.InvokeObjectMethod("withContext.(Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(block);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x04000007 RID: 7
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/BuildersKt", typeof(BuildersKt));
	}
}
