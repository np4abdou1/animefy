using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000BA RID: 186
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/flow/LintKt", DoNotGenerateAcw = true)]
	public sealed class LintKt : Java.Lang.Object
	{
		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x0001ED08 File Offset: 0x0001CF08
		internal static IntPtr class_ref
		{
			get
			{
				return LintKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0001ED2C File Offset: 0x0001CF2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LintKt._members;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x0001ED34 File Offset: 0x0001CF34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LintKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x0001ED58 File Offset: 0x0001CF58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LintKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0001ED64 File Offset: 0x0001CF64
		internal LintKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0001ED70 File Offset: 0x0001CF70
		[Obsolete("deprecated")]
		[Register("cancel", "(Lkotlinx/coroutines/flow/FlowCollector;Ljava/util/concurrent/CancellationException;)V", "")]
		public unsafe static void Cancel(IFlowCollector obj, [Nullable(2)] CancellationException cause)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				LintKt._members.StaticMethods.InvokeVoidMethod("cancel.(Lkotlinx/coroutines/flow/FlowCollector;Ljava/util/concurrent/CancellationException;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0001EE00 File Offset: 0x0001D000
		[Obsolete("deprecated")]
		[Register("cancellable", "(Lkotlinx/coroutines/flow/SharedFlow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Cancellable(ISharedFlow obj)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(LintKt._members.StaticMethods.InvokeObjectMethod("cancellable.(Lkotlinx/coroutines/flow/SharedFlow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0001EE78 File Offset: 0x0001D078
		[Obsolete("deprecated")]
		[Register("conflate", "(Lkotlinx/coroutines/flow/StateFlow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Conflate(IStateFlow obj)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(LintKt._members.StaticMethods.InvokeObjectMethod("conflate.(Lkotlinx/coroutines/flow/StateFlow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0001EEF0 File Offset: 0x0001D0F0
		[Obsolete("deprecated")]
		[Register("distinctUntilChanged", "(Lkotlinx/coroutines/flow/StateFlow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow DistinctUntilChanged(IStateFlow obj)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(LintKt._members.StaticMethods.InvokeObjectMethod("distinctUntilChanged.(Lkotlinx/coroutines/flow/StateFlow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0001EF68 File Offset: 0x0001D168
		[Obsolete("deprecated")]
		[Register("flowOn", "(Lkotlinx/coroutines/flow/SharedFlow;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow FlowOn(ISharedFlow obj, ICoroutineContext context)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(LintKt._members.StaticMethods.InvokeObjectMethod("flowOn.(Lkotlinx/coroutines/flow/SharedFlow;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0001F00C File Offset: 0x0001D20C
		[Obsolete("deprecated")]
		[Register("getCoroutineContext", "(Lkotlinx/coroutines/flow/FlowCollector;)Lkotlin/coroutines/CoroutineContext;", "")]
		public unsafe static ICoroutineContext GetCoroutineContext(IFlowCollector obj)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(LintKt._members.StaticMethods.InvokeObjectMethod("getCoroutineContext.(Lkotlinx/coroutines/flow/FlowCollector;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0001F084 File Offset: 0x0001D284
		[Obsolete("deprecated")]
		[Register("isActive", "(Lkotlinx/coroutines/flow/FlowCollector;)Z", "")]
		public unsafe static bool IsActive(IFlowCollector obj)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				result = LintKt._members.StaticMethods.InvokeBooleanMethod("isActive.(Lkotlinx/coroutines/flow/FlowCollector;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x040002B8 RID: 696
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/LintKt", typeof(LintKt));
	}
}
