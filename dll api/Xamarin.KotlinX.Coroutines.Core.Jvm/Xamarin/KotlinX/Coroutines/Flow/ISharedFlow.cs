using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000B1 RID: 177
	[Register("kotlinx/coroutines/flow/SharedFlow", "", "Xamarin.KotlinX.Coroutines.Flow.ISharedFlowInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface ISharedFlow : IFlow, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000836 RID: 2102
		[Nullable(1)]
		IList ReplayCache { [NullableContext(1)] [Register("getReplayCache", "()Ljava/util/List;", "GetGetReplayCacheHandler:Xamarin.KotlinX.Coroutines.Flow.ISharedFlowInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x06000837 RID: 2103
		[NullableContext(1)]
		[Register("collect", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetCollect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_Handler:Xamarin.KotlinX.Coroutines.Flow.ISharedFlowInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		[return: Nullable(2)]
		Java.Lang.Object Collect(IFlowCollector collector, IContinuation p1);
	}
}
