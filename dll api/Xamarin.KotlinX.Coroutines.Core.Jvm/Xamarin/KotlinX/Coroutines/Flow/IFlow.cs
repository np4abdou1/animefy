using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000A9 RID: 169
	[Register("kotlinx/coroutines/flow/Flow", "", "Xamarin.KotlinX.Coroutines.Flow.IFlowInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IFlow : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060007D6 RID: 2006
		[NullableContext(1)]
		[Register("collect", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetCollect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_Handler:Xamarin.KotlinX.Coroutines.Flow.IFlowInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		[return: Nullable(2)]
		Java.Lang.Object Collect(IFlowCollector collector, IContinuation p1);
	}
}
