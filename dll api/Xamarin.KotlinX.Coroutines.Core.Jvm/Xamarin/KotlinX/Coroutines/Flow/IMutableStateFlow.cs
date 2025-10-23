using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000AF RID: 175
	[Register("kotlinx/coroutines/flow/MutableStateFlow", "", "Xamarin.KotlinX.Coroutines.Flow.IMutableStateFlowInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IMutableStateFlow : IMutableSharedFlow, IFlowCollector, IJavaObject, IDisposable, IJavaPeerable, ISharedFlow, IFlow, IStateFlow
	{
		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600080F RID: 2063
		// (set) Token: 0x06000810 RID: 2064
		[Nullable(2)]
		Java.Lang.Object Value { [NullableContext(2)] [Register("getValue", "()Ljava/lang/Object;", "GetGetValueHandler:Xamarin.KotlinX.Coroutines.Flow.IMutableStateFlowInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; [NullableContext(2)] [Register("setValue", "(Ljava/lang/Object;)V", "GetSetValue_Ljava_lang_Object_Handler:Xamarin.KotlinX.Coroutines.Flow.IMutableStateFlowInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] set; }

		// Token: 0x06000811 RID: 2065
		[NullableContext(2)]
		[Register("compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "GetCompareAndSet_Ljava_lang_Object_Ljava_lang_Object_Handler:Xamarin.KotlinX.Coroutines.Flow.IMutableStateFlowInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		bool CompareAndSet(Java.Lang.Object expect, Java.Lang.Object update);
	}
}
