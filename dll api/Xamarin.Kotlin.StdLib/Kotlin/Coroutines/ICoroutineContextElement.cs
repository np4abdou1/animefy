using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Coroutines
{
	// Token: 0x0200025B RID: 603
	[Register("kotlin/coroutines/CoroutineContext$Element", "", "Kotlin.Coroutines.ICoroutineContextElementInvoker")]
	public interface ICoroutineContextElement : ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001BB0 RID: 7088
		[Nullable(1)]
		ICoroutineContextKey Key { [NullableContext(1)] [Register("getKey", "()Lkotlin/coroutines/CoroutineContext$Key;", "GetGetKeyHandler:Kotlin.Coroutines.ICoroutineContextElementInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x06001BB1 RID: 7089
		[NullableContext(2)]
		[Register("fold", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler:Kotlin.Coroutines.ICoroutineContextElementInvoker, Xamarin.Kotlin.StdLib")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		Java.Lang.Object Fold(Java.Lang.Object initial, [Nullable(1)] IFunction2 operation);

		// Token: 0x06001BB2 RID: 7090
		[NullableContext(1)]
		[Register("get", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler:Kotlin.Coroutines.ICoroutineContextElementInvoker, Xamarin.Kotlin.StdLib")]
		[JavaTypeParameters(new string[]
		{
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		Java.Lang.Object Get(ICoroutineContextKey key);

		// Token: 0x06001BB3 RID: 7091
		[NullableContext(1)]
		[Register("minusKey", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler:Kotlin.Coroutines.ICoroutineContextElementInvoker, Xamarin.Kotlin.StdLib")]
		ICoroutineContext MinusKey(ICoroutineContextKey key);
	}
}
