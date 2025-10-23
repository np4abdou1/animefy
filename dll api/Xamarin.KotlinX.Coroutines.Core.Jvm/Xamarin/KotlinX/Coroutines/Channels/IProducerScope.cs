using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000DA RID: 218
	[Register("kotlinx/coroutines/channels/ProducerScope", "", "Xamarin.KotlinX.Coroutines.Channels.IProducerScopeInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface IProducerScope : ICoroutineScope, IJavaObject, IDisposable, IJavaPeerable, ISendChannel
	{
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060009F9 RID: 2553
		[Nullable(1)]
		ISendChannel Channel { [NullableContext(1)] [Register("getChannel", "()Lkotlinx/coroutines/channels/SendChannel;", "GetGetChannelHandler:Xamarin.KotlinX.Coroutines.Channels.IProducerScopeInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }
	}
}
