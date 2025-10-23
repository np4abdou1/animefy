using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200003C RID: 60
	[NullableContext(1)]
	[Register("kotlinx/coroutines/CancellableContinuation", "", "Xamarin.KotlinX.Coroutines.ICancellableContinuationInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface ICancellableContinuation : IContinuation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000170 RID: 368
		bool IsActive { [Register("isActive", "()Z", "GetIsActiveHandler:Xamarin.KotlinX.Coroutines.ICancellableContinuationInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000171 RID: 369
		bool IsCancelled { [Register("isCancelled", "()Z", "GetIsCancelledHandler:Xamarin.KotlinX.Coroutines.ICancellableContinuationInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000172 RID: 370
		bool IsCompleted { [Register("isCompleted", "()Z", "GetIsCompletedHandler:Xamarin.KotlinX.Coroutines.ICancellableContinuationInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x06000173 RID: 371
		[NullableContext(2)]
		[Register("cancel", "(Ljava/lang/Throwable;)Z", "GetCancel_Ljava_lang_Throwable_Handler:Xamarin.KotlinX.Coroutines.ICancellableContinuationInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		bool Cancel(Throwable cause);

		// Token: 0x06000174 RID: 372
		[Register("completeResume", "(Ljava/lang/Object;)V", "GetCompleteResume_Ljava_lang_Object_Handler:Xamarin.KotlinX.Coroutines.ICancellableContinuationInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void CompleteResume(Java.Lang.Object token);

		// Token: 0x06000175 RID: 373
		[Register("initCancellability", "()V", "GetInitCancellabilityHandler:Xamarin.KotlinX.Coroutines.ICancellableContinuationInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void InitCancellability();

		// Token: 0x06000176 RID: 374
		[Register("invokeOnCancellation", "(Lkotlin/jvm/functions/Function1;)V", "GetInvokeOnCancellation_Lkotlin_jvm_functions_Function1_Handler:Xamarin.KotlinX.Coroutines.ICancellableContinuationInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void InvokeOnCancellation(IFunction1 handler);

		// Token: 0x06000177 RID: 375
		[NullableContext(2)]
		[Register("resume", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)V", "GetResume_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_Handler:Xamarin.KotlinX.Coroutines.ICancellableContinuationInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void Resume(Java.Lang.Object value, IFunction1 onCancellation);

		// Token: 0x06000178 RID: 376
		[Register("resumeUndispatched", "(Lkotlinx/coroutines/CoroutineDispatcher;Ljava/lang/Object;)V", "GetResumeUndispatched_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Object_Handler:Xamarin.KotlinX.Coroutines.ICancellableContinuationInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void ResumeUndispatched(CoroutineDispatcher p0, [Nullable(2)] Java.Lang.Object value);

		// Token: 0x06000179 RID: 377
		[Register("resumeUndispatchedWithException", "(Lkotlinx/coroutines/CoroutineDispatcher;Ljava/lang/Throwable;)V", "GetResumeUndispatchedWithException_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Throwable_Handler:Xamarin.KotlinX.Coroutines.ICancellableContinuationInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void ResumeUndispatchedWithException(CoroutineDispatcher p0, Throwable exception);

		// Token: 0x0600017A RID: 378
		[NullableContext(2)]
		[Register("tryResume", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetTryResume_Ljava_lang_Object_Ljava_lang_Object_Handler:Xamarin.KotlinX.Coroutines.ICancellableContinuationInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		Java.Lang.Object TryResume(Java.Lang.Object value, Java.Lang.Object idempotent);

		// Token: 0x0600017B RID: 379
		[NullableContext(2)]
		[Register("tryResume", "(Ljava/lang/Object;Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "GetTryResume_Ljava_lang_Object_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_Handler:Xamarin.KotlinX.Coroutines.ICancellableContinuationInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		Java.Lang.Object TryResume(Java.Lang.Object value, Java.Lang.Object idempotent, IFunction1 onCancellation);

		// Token: 0x0600017C RID: 380
		[Register("tryResumeWithException", "(Ljava/lang/Throwable;)Ljava/lang/Object;", "GetTryResumeWithException_Ljava_lang_Throwable_Handler:Xamarin.KotlinX.Coroutines.ICancellableContinuationInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		[return: Nullable(2)]
		Java.Lang.Object TryResumeWithException(Throwable exception);
	}
}
