using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Selects
{
	// Token: 0x0200009B RID: 155
	[NullableContext(1)]
	[Register("kotlinx/coroutines/selects/SelectInstance", "", "Xamarin.KotlinX.Coroutines.Selects.ISelectInstanceInvoker")]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public interface ISelectInstance : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060006D8 RID: 1752
		ICoroutineContext Context { [Register("getContext", "()Lkotlin/coroutines/CoroutineContext;", "GetGetContextHandler:Xamarin.KotlinX.Coroutines.Selects.ISelectInstanceInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x060006D9 RID: 1753
		[Register("disposeOnCompletion", "(Lkotlinx/coroutines/DisposableHandle;)V", "GetDisposeOnCompletion_Lkotlinx_coroutines_DisposableHandle_Handler:Xamarin.KotlinX.Coroutines.Selects.ISelectInstanceInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void DisposeOnCompletion(IDisposableHandle disposableHandle);

		// Token: 0x060006DA RID: 1754
		[NullableContext(2)]
		[Register("selectInRegistrationPhase", "(Ljava/lang/Object;)V", "GetSelectInRegistrationPhase_Ljava_lang_Object_Handler:Xamarin.KotlinX.Coroutines.Selects.ISelectInstanceInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void SelectInRegistrationPhase(Java.Lang.Object internalResult);

		// Token: 0x060006DB RID: 1755
		[Register("trySelect", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "GetTrySelect_Ljava_lang_Object_Ljava_lang_Object_Handler:Xamarin.KotlinX.Coroutines.Selects.ISelectInstanceInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		bool TrySelect(Java.Lang.Object clauseObject, [Nullable(2)] Java.Lang.Object result);
	}
}
