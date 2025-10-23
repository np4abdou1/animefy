using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Util.Concurrent;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000CE RID: 206
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("kotlinx/coroutines/channels/BroadcastChannel", "", "Xamarin.KotlinX.Coroutines.Channels.IBroadcastChannelInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface IBroadcastChannel : ISendChannel, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600095D RID: 2397
		[NullableContext(2)]
		[Register("cancel", "(Ljava/util/concurrent/CancellationException;)V", "GetCancel_Ljava_util_concurrent_CancellationException_Handler:Xamarin.KotlinX.Coroutines.Channels.IBroadcastChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void Cancel(CancellationException cause);

		// Token: 0x0600095E RID: 2398
		[NullableContext(1)]
		[Register("openSubscription", "()Lkotlinx/coroutines/channels/ReceiveChannel;", "GetOpenSubscriptionHandler:Xamarin.KotlinX.Coroutines.Channels.IBroadcastChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		IReceiveChannel OpenSubscription();
	}
}
