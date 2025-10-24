using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200005B RID: 91
	[Register("kotlinx/coroutines/Delay", "", "Xamarin.KotlinX.Coroutines.IDelayInvoker")]
	public interface IDelay : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060003B2 RID: 946
		[NullableContext(1)]
		[Obsolete("deprecated")]
		[Register("delay", "(JLkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetDelay_JLkotlin_coroutines_Continuation_Handler:Xamarin.KotlinX.Coroutines.IDelayInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		[return: Nullable(2)]
		Java.Lang.Object Delay(long time, IContinuation p1);

		// Token: 0x060003B3 RID: 947
		[NullableContext(1)]
		[Register("invokeOnTimeout", "(JLjava/lang/Runnable;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/DisposableHandle;", "GetInvokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_Handler:Xamarin.KotlinX.Coroutines.IDelayInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		IDisposableHandle InvokeOnTimeout(long timeMillis, IRunnable block, ICoroutineContext context);

		// Token: 0x060003B4 RID: 948
		[NullableContext(1)]
		[Register("scheduleResumeAfterDelay", "(JLkotlinx/coroutines/CancellableContinuation;)V", "GetScheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_Handler:Xamarin.KotlinX.Coroutines.IDelayInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void ScheduleResumeAfterDelay(long timeMillis, ICancellableContinuation continuation);
	}
}
