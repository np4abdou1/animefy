using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000AD RID: 173
	[Register("kotlinx/coroutines/flow/MutableSharedFlow", "", "Xamarin.KotlinX.Coroutines.Flow.IMutableSharedFlowInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IMutableSharedFlow : IFlowCollector, IJavaObject, IDisposable, IJavaPeerable, ISharedFlow, IFlow
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060007F0 RID: 2032
		[Nullable(1)]
		IStateFlow SubscriptionCount { [NullableContext(1)] [Register("getSubscriptionCount", "()Lkotlinx/coroutines/flow/StateFlow;", "GetGetSubscriptionCountHandler:Xamarin.KotlinX.Coroutines.Flow.IMutableSharedFlowInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x060007F1 RID: 2033
		[NullableContext(2)]
		[Register("emit", "(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetEmit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler:Xamarin.KotlinX.Coroutines.Flow.IMutableSharedFlowInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		Java.Lang.Object Emit(Java.Lang.Object value, [Nullable(1)] IContinuation p1);

		// Token: 0x060007F2 RID: 2034
		[Register("resetReplayCache", "()V", "GetResetReplayCacheHandler:Xamarin.KotlinX.Coroutines.Flow.IMutableSharedFlowInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void ResetReplayCache();

		// Token: 0x060007F3 RID: 2035
		[NullableContext(2)]
		[Register("tryEmit", "(Ljava/lang/Object;)Z", "GetTryEmit_Ljava_lang_Object_Handler:Xamarin.KotlinX.Coroutines.Flow.IMutableSharedFlowInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		bool TryEmit(Java.Lang.Object value);
	}
}
