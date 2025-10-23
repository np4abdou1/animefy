using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;
using Xamarin.KotlinX.Coroutines.Selects;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000E0 RID: 224
	[NullableContext(1)]
	[Register("kotlinx/coroutines/channels/SendChannel", "", "Xamarin.KotlinX.Coroutines.Channels.ISendChannelInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface ISendChannel : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000A67 RID: 2663
		bool IsClosedForSend { [Register("isClosedForSend", "()Z", "GetIsClosedForSendHandler:Xamarin.KotlinX.Coroutines.Channels.ISendChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000A68 RID: 2664
		ISelectClause2 OnSend { [Register("getOnSend", "()Lkotlinx/coroutines/selects/SelectClause2;", "GetGetOnSendHandler:Xamarin.KotlinX.Coroutines.Channels.ISendChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x06000A69 RID: 2665
		[NullableContext(2)]
		[Register("close", "(Ljava/lang/Throwable;)Z", "GetClose_Ljava_lang_Throwable_Handler:Xamarin.KotlinX.Coroutines.Channels.ISendChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		bool Close(Throwable cause);

		// Token: 0x06000A6A RID: 2666
		[Register("invokeOnClose", "(Lkotlin/jvm/functions/Function1;)V", "GetInvokeOnClose_Lkotlin_jvm_functions_Function1_Handler:Xamarin.KotlinX.Coroutines.Channels.ISendChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void InvokeOnClose(IFunction1 handler);

		// Token: 0x06000A6B RID: 2667
		[NullableContext(2)]
		[Obsolete("deprecated")]
		[Register("offer", "(Ljava/lang/Object;)Z", "GetOffer_Ljava_lang_Object_Handler:Xamarin.KotlinX.Coroutines.Channels.ISendChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		bool Offer(Java.Lang.Object element);

		// Token: 0x06000A6C RID: 2668
		[NullableContext(2)]
		[Register("send", "(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetSend_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler:Xamarin.KotlinX.Coroutines.Channels.ISendChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		Java.Lang.Object Send(Java.Lang.Object element, [Nullable(1)] IContinuation p1);

		// Token: 0x06000A6D RID: 2669
		[Register("trySend-JP2dKIU", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetTrySend_Ljava_lang_Object_Handler:Xamarin.KotlinX.Coroutines.Channels.ISendChannelInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		Java.Lang.Object TrySend([Nullable(2)] Java.Lang.Object element);
	}
}
