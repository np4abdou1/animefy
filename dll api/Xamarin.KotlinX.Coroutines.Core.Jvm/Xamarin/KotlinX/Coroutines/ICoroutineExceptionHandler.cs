using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000053 RID: 83
	[Register("kotlinx/coroutines/CoroutineExceptionHandler", "", "Xamarin.KotlinX.Coroutines.ICoroutineExceptionHandlerInvoker")]
	public interface ICoroutineExceptionHandler : ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000323 RID: 803
		[NullableContext(1)]
		[Register("handleException", "(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Throwable;)V", "GetHandleException_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Throwable_Handler:Xamarin.KotlinX.Coroutines.ICoroutineExceptionHandlerInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void HandleException(ICoroutineContext context, Throwable exception);

		// Token: 0x04000103 RID: 259
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CoroutineExceptionHandler", typeof(ICoroutineExceptionHandler), true);
	}
}
