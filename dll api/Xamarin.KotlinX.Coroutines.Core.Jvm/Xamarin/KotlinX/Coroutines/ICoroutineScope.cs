using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000055 RID: 85
	[Register("kotlinx/coroutines/CoroutineScope", "", "Xamarin.KotlinX.Coroutines.ICoroutineScopeInvoker")]
	public interface ICoroutineScope : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000340 RID: 832
		[Nullable(1)]
		ICoroutineContext CoroutineContext { [NullableContext(1)] [Register("getCoroutineContext", "()Lkotlin/coroutines/CoroutineContext;", "GetGetCoroutineContextHandler:Xamarin.KotlinX.Coroutines.ICoroutineScopeInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }
	}
}
