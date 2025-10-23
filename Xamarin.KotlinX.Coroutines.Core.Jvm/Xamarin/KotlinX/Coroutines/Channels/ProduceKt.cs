using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000E2 RID: 226
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/ProduceKt", DoNotGenerateAcw = true)]
	public sealed class ProduceKt : Java.Lang.Object
	{
		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x00025A70 File Offset: 0x00023C70
		internal static IntPtr class_ref
		{
			get
			{
				return ProduceKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00025A94 File Offset: 0x00023C94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ProduceKt._members;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00025A9C File Offset: 0x00023C9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ProduceKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00025AC0 File Offset: 0x00023CC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ProduceKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00025ACC File Offset: 0x00023CCC
		internal ProduceKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00025AD8 File Offset: 0x00023CD8
		[Register("awaitClose", "(Lkotlinx/coroutines/channels/ProducerScope;Lkotlin/jvm/functions/Function0;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object AwaitClose(IProducerScope p0, IFunction0 block, IContinuation p2)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ProduceKt._members.StaticMethods.InvokeObjectMethod("awaitClose.(Lkotlinx/coroutines/channels/ProducerScope;Lkotlin/jvm/functions/Function0;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(block);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00025BAC File Offset: 0x00023DAC
		[Register("produce", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;ILkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/ReceiveChannel;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IReceiveChannel Produce(ICoroutineScope obj, ICoroutineContext context, int capacity, IFunction2 block)
		{
			IReceiveChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[2] = new JniArgumentValue(capacity);
				ptr[3] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<IReceiveChannel>(ProduceKt._members.StaticMethods.InvokeObjectMethod("produce.(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;ILkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/ReceiveChannel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(context);
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00025C98 File Offset: 0x00023E98
		[Register("produce", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;ILkotlinx/coroutines/CoroutineStart;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/ReceiveChannel;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IReceiveChannel Produce(ICoroutineScope obj, ICoroutineContext context, int capacity, CoroutineStart start, [Nullable(2)] IFunction1 onCompletion, IFunction2 block)
		{
			IReceiveChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[2] = new JniArgumentValue(capacity);
				ptr[3] = new JniArgumentValue((start == null) ? IntPtr.Zero : start.Handle);
				ptr[4] = new JniArgumentValue((onCompletion == null) ? IntPtr.Zero : ((Java.Lang.Object)onCompletion).Handle);
				ptr[5] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<IReceiveChannel>(ProduceKt._members.StaticMethods.InvokeObjectMethod("produce.(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;ILkotlinx/coroutines/CoroutineStart;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/ReceiveChannel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(context);
				GC.KeepAlive(start);
				GC.KeepAlive(onCompletion);
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x0400037C RID: 892
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ProduceKt", typeof(ProduceKt));
	}
}
