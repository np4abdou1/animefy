using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Coroutines
{
	// Token: 0x02000251 RID: 593
	[Register("kotlin/coroutines/Continuation", "", "Kotlin.Coroutines.IContinuationInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IContinuation : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001B58 RID: 7000
		[Nullable(1)]
		ICoroutineContext Context { [NullableContext(1)] [Register("getContext", "()Lkotlin/coroutines/CoroutineContext;", "GetGetContextHandler:Kotlin.Coroutines.IContinuationInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x06001B59 RID: 7001
		[NullableContext(1)]
		[Register("resumeWith", "(Ljava/lang/Object;)V", "GetResumeWith_Ljava_lang_Object_Handler:Kotlin.Coroutines.IContinuationInvoker, Xamarin.Kotlin.StdLib")]
		void ResumeWith(Java.Lang.Object result);
	}
}
