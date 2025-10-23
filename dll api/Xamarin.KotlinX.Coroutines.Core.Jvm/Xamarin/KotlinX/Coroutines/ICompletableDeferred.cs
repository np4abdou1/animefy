using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000045 RID: 69
	[Register("kotlinx/coroutines/CompletableDeferred", "", "Xamarin.KotlinX.Coroutines.ICompletableDeferredInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface ICompletableDeferred : IDeferred, IJob, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000229 RID: 553
		[NullableContext(2)]
		[Register("complete", "(Ljava/lang/Object;)Z", "GetComplete_Ljava_lang_Object_Handler:Xamarin.KotlinX.Coroutines.ICompletableDeferredInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		bool Complete(Java.Lang.Object value);

		// Token: 0x0600022A RID: 554
		[NullableContext(1)]
		[Register("completeExceptionally", "(Ljava/lang/Throwable;)Z", "GetCompleteExceptionally_Ljava_lang_Throwable_Handler:Xamarin.KotlinX.Coroutines.ICompletableDeferredInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		bool CompleteExceptionally(Throwable exception);
	}
}
