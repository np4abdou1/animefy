using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000D7 RID: 215
	[Register("kotlinx/coroutines/channels/ChannelIterator", "", "Xamarin.KotlinX.Coroutines.Channels.IChannelIteratorInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface IChannelIterator : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060009E1 RID: 2529
		[NullableContext(1)]
		[Register("hasNext", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetHasNext_Lkotlin_coroutines_Continuation_Handler:Xamarin.KotlinX.Coroutines.Channels.IChannelIteratorInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		[return: Nullable(2)]
		Java.Lang.Object HasNext(IContinuation p0);

		// Token: 0x060009E2 RID: 2530
		[NullableContext(2)]
		[Register("next", "()Ljava/lang/Object;", "GetNextHandler:Xamarin.KotlinX.Coroutines.Channels.IChannelIteratorInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		Java.Lang.Object Next();
	}
}
