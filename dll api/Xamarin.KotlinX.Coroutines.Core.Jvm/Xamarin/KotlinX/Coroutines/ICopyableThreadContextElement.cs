using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200004B RID: 75
	[Register("kotlinx/coroutines/CopyableThreadContextElement", "", "Xamarin.KotlinX.Coroutines.ICopyableThreadContextElementInvoker")]
	[JavaTypeParameters(new string[]
	{
		"S"
	})]
	public interface ICopyableThreadContextElement : IThreadContextElement, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060002DE RID: 734
		[NullableContext(1)]
		[Register("copyForChild", "()Lkotlinx/coroutines/CopyableThreadContextElement;", "GetCopyForChildHandler:Xamarin.KotlinX.Coroutines.ICopyableThreadContextElementInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		ICopyableThreadContextElement CopyForChild();

		// Token: 0x060002DF RID: 735
		[NullableContext(1)]
		[Register("mergeForChild", "(Lkotlin/coroutines/CoroutineContext$Element;)Lkotlin/coroutines/CoroutineContext;", "GetMergeForChild_Lkotlin_coroutines_CoroutineContext_Element_Handler:Xamarin.KotlinX.Coroutines.ICopyableThreadContextElementInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		ICoroutineContext MergeForChild(ICoroutineContextElement overwritingElement);
	}
}
