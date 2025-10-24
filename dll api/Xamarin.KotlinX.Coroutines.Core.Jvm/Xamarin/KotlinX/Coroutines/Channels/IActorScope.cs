using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000CB RID: 203
	[Register("kotlinx/coroutines/channels/ActorScope", "", "Xamarin.KotlinX.Coroutines.Channels.IActorScopeInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface IActorScope : ICoroutineScope, IJavaObject, IDisposable, IJavaPeerable, IReceiveChannel
	{
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000922 RID: 2338
		[Nullable(1)]
		IChannel Channel { [NullableContext(1)] [Register("getChannel", "()Lkotlinx/coroutines/channels/Channel;", "GetGetChannelHandler:Xamarin.KotlinX.Coroutines.Channels.IActorScopeInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }
	}
}
