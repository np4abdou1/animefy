using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000AB RID: 171
	[Register("kotlinx/coroutines/flow/FlowCollector", "", "Xamarin.KotlinX.Coroutines.Flow.IFlowCollectorInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IFlowCollector : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060007E3 RID: 2019
		[NullableContext(2)]
		[Register("emit", "(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetEmit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler:Xamarin.KotlinX.Coroutines.Flow.IFlowCollectorInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		Java.Lang.Object Emit(Java.Lang.Object value, [Nullable(1)] IContinuation p1);
	}
}
