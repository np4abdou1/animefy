using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Coroutines
{
	// Token: 0x02000257 RID: 599
	[Register("kotlin/coroutines/ContinuationInterceptor", "", "Kotlin.Coroutines.IContinuationInterceptorInvoker")]
	public interface IContinuationInterceptor : ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001B7C RID: 7036
		[NullableContext(1)]
		[Register("get", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler:Kotlin.Coroutines.IContinuationInterceptorInvoker, Xamarin.Kotlin.StdLib")]
		[JavaTypeParameters(new string[]
		{
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		Java.Lang.Object Get(ICoroutineContextKey key);

		// Token: 0x06001B7D RID: 7037
		[NullableContext(1)]
		[Register("interceptContinuation", "(Lkotlin/coroutines/Continuation;)Lkotlin/coroutines/Continuation;", "GetInterceptContinuation_Lkotlin_coroutines_Continuation_Handler:Kotlin.Coroutines.IContinuationInterceptorInvoker, Xamarin.Kotlin.StdLib")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		IContinuation InterceptContinuation(IContinuation continuation);

		// Token: 0x06001B7E RID: 7038
		[NullableContext(1)]
		[Register("minusKey", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler:Kotlin.Coroutines.IContinuationInterceptorInvoker, Xamarin.Kotlin.StdLib")]
		ICoroutineContext MinusKey(ICoroutineContextKey key);

		// Token: 0x06001B7F RID: 7039
		[NullableContext(1)]
		[Register("releaseInterceptedContinuation", "(Lkotlin/coroutines/Continuation;)V", "GetReleaseInterceptedContinuation_Lkotlin_coroutines_Continuation_Handler:Kotlin.Coroutines.IContinuationInterceptorInvoker, Xamarin.Kotlin.StdLib")]
		void ReleaseInterceptedContinuation(IContinuation continuation);

		// Token: 0x04000872 RID: 2162
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/ContinuationInterceptor", typeof(IContinuationInterceptor), true);
	}
}
