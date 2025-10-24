using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Coroutines
{
	// Token: 0x0200025F RID: 607
	[Register("kotlin/coroutines/CoroutineContext", "", "Kotlin.Coroutines.ICoroutineContextInvoker")]
	public interface ICoroutineContext : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001BD5 RID: 7125
		[NullableContext(2)]
		[Register("fold", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler:Kotlin.Coroutines.ICoroutineContextInvoker, Xamarin.Kotlin.StdLib")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		Java.Lang.Object Fold(Java.Lang.Object initial, [Nullable(1)] IFunction2 operation);

		// Token: 0x06001BD6 RID: 7126
		[NullableContext(1)]
		[Register("get", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler:Kotlin.Coroutines.ICoroutineContextInvoker, Xamarin.Kotlin.StdLib")]
		[JavaTypeParameters(new string[]
		{
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		Java.Lang.Object Get(ICoroutineContextKey key);

		// Token: 0x06001BD7 RID: 7127
		[NullableContext(1)]
		[Register("minusKey", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler:Kotlin.Coroutines.ICoroutineContextInvoker, Xamarin.Kotlin.StdLib")]
		ICoroutineContext MinusKey(ICoroutineContextKey key);

		// Token: 0x06001BD8 RID: 7128
		[NullableContext(1)]
		[Register("plus", "(Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", "GetPlus_Lkotlin_coroutines_CoroutineContext_Handler:Kotlin.Coroutines.ICoroutineContextInvoker, Xamarin.Kotlin.StdLib")]
		ICoroutineContext Plus(ICoroutineContext context);
	}
}
