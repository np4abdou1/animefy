using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using Kotlin.Coroutines;
using Xamarin.KotlinX.Coroutines.Selects;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000DD RID: 221
	[NullableContext(1)]
	[Register("kotlinx/coroutines/channels/ReceiveChannel", "", "Xamarin.KotlinX.Coroutines.Channels.IReceiveChannelInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface IReceiveChannel : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000A27 RID: 2599
		bool IsClosedForReceive { [Register("isClosedForReceive", "()Z", "GetIsClosedForReceiveHandler:Xamarin.KotlinX.Coroutines.Channels.IReceiveChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000A28 RID: 2600
		bool IsEmpty { [Register("isEmpty", "()Z", "GetIsEmptyHandler:Xamarin.KotlinX.Coroutines.Channels.IReceiveChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000A29 RID: 2601
		ISelectClause1 OnReceive { [Register("getOnReceive", "()Lkotlinx/coroutines/selects/SelectClause1;", "GetGetOnReceiveHandler:Xamarin.KotlinX.Coroutines.Channels.IReceiveChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000A2A RID: 2602
		ISelectClause1 OnReceiveCatching { [Register("getOnReceiveCatching", "()Lkotlinx/coroutines/selects/SelectClause1;", "GetGetOnReceiveCatchingHandler:Xamarin.KotlinX.Coroutines.Channels.IReceiveChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000A2B RID: 2603
		ISelectClause1 OnReceiveOrNull { [Register("getOnReceiveOrNull", "()Lkotlinx/coroutines/selects/SelectClause1;", "GetGetOnReceiveOrNullHandler:Xamarin.KotlinX.Coroutines.Channels.IReceiveChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x06000A2C RID: 2604
		[NullableContext(2)]
		[Register("cancel", "(Ljava/util/concurrent/CancellationException;)V", "GetCancel_Ljava_util_concurrent_CancellationException_Handler:Xamarin.KotlinX.Coroutines.Channels.IReceiveChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void Cancel(CancellationException cause);

		// Token: 0x06000A2D RID: 2605
		[Register("iterator", "()Lkotlinx/coroutines/channels/ChannelIterator;", "GetIteratorHandler:Xamarin.KotlinX.Coroutines.Channels.IReceiveChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		IChannelIterator Iterator();

		// Token: 0x06000A2E RID: 2606
		[NullableContext(2)]
		[Obsolete("deprecated")]
		[Register("poll", "()Ljava/lang/Object;", "GetPollHandler:Xamarin.KotlinX.Coroutines.Channels.IReceiveChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		Java.Lang.Object Poll();

		// Token: 0x06000A2F RID: 2607
		[Register("receive", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetReceive_Lkotlin_coroutines_Continuation_Handler:Xamarin.KotlinX.Coroutines.Channels.IReceiveChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		[return: Nullable(2)]
		Java.Lang.Object Receive(IContinuation p0);

		// Token: 0x06000A30 RID: 2608
		[Register("receiveCatching-JP2dKIU", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetReceiveCatching_Lkotlin_coroutines_Continuation_Handler:Xamarin.KotlinX.Coroutines.Channels.IReceiveChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		[return: Nullable(2)]
		Java.Lang.Object ReceiveCatching(IContinuation p0);

		// Token: 0x06000A31 RID: 2609
		[Obsolete("deprecated")]
		[Register("receiveOrNull", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetReceiveOrNull_Lkotlin_coroutines_Continuation_Handler:Xamarin.KotlinX.Coroutines.Channels.IReceiveChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		[return: Nullable(2)]
		Java.Lang.Object ReceiveOrNull(IContinuation p0);

		// Token: 0x06000A32 RID: 2610
		[Register("tryReceive-PtdJZtk", "()Ljava/lang/Object;", "GetTryReceiveHandler:Xamarin.KotlinX.Coroutines.Channels.IReceiveChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		Java.Lang.Object TryReceive();
	}
}
