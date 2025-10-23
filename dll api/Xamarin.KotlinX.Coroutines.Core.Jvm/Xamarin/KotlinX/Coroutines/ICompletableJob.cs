using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000048 RID: 72
	[Register("kotlinx/coroutines/CompletableJob", "", "Xamarin.KotlinX.Coroutines.ICompletableJobInvoker")]
	public interface ICompletableJob : IJob, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600028A RID: 650
		[Register("complete", "()Z", "GetCompleteHandler:Xamarin.KotlinX.Coroutines.ICompletableJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		bool Complete();

		// Token: 0x0600028B RID: 651
		[NullableContext(1)]
		[Register("completeExceptionally", "(Ljava/lang/Throwable;)Z", "GetCompleteExceptionally_Ljava_lang_Throwable_Handler:Xamarin.KotlinX.Coroutines.ICompletableJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		bool CompleteExceptionally(Throwable exception);
	}
}
