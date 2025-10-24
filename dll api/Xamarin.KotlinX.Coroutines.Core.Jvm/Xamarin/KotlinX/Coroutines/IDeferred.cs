using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Xamarin.KotlinX.Coroutines.Selects;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000058 RID: 88
	[Register("kotlinx/coroutines/Deferred", "", "Xamarin.KotlinX.Coroutines.IDeferredInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IDeferred : IJob, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000358 RID: 856
		[Nullable(2)]
		Java.Lang.Object Completed { [NullableContext(2)] [Register("getCompleted", "()Ljava/lang/Object;", "GetGetCompletedHandler:Xamarin.KotlinX.Coroutines.IDeferredInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000359 RID: 857
		[Nullable(2)]
		Throwable CompletionExceptionOrNull { [NullableContext(2)] [Register("getCompletionExceptionOrNull", "()Ljava/lang/Throwable;", "GetGetCompletionExceptionOrNullHandler:Xamarin.KotlinX.Coroutines.IDeferredInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600035A RID: 858
		[Nullable(1)]
		ISelectClause1 OnAwait { [NullableContext(1)] [Register("getOnAwait", "()Lkotlinx/coroutines/selects/SelectClause1;", "GetGetOnAwaitHandler:Xamarin.KotlinX.Coroutines.IDeferredInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x0600035B RID: 859
		[NullableContext(1)]
		[Register("await", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetAwait_Lkotlin_coroutines_Continuation_Handler:Xamarin.KotlinX.Coroutines.IDeferredInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		[return: Nullable(2)]
		Java.Lang.Object Await(IContinuation p0);
	}
}
