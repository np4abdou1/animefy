using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000075 RID: 117
	[Register("kotlinx/coroutines/ThreadContextElement", "", "Xamarin.KotlinX.Coroutines.IThreadContextElementInvoker")]
	[JavaTypeParameters(new string[]
	{
		"S"
	})]
	public interface IThreadContextElement : ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000504 RID: 1284
		[NullableContext(1)]
		[Register("restoreThreadContext", "(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Object;)V", "GetRestoreThreadContext_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Object_Handler:Xamarin.KotlinX.Coroutines.IThreadContextElementInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void RestoreThreadContext(ICoroutineContext context, [Nullable(2)] Java.Lang.Object oldState);

		// Token: 0x06000505 RID: 1285
		[NullableContext(1)]
		[Register("updateThreadContext", "(Lkotlin/coroutines/CoroutineContext;)Ljava/lang/Object;", "GetUpdateThreadContext_Lkotlin_coroutines_CoroutineContext_Handler:Xamarin.KotlinX.Coroutines.IThreadContextElementInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		[return: Nullable(2)]
		Java.Lang.Object UpdateThreadContext(ICoroutineContext context);
	}
}
