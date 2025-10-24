using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x0200019F RID: 415
	[Register("kotlin/jvm/internal/FunctionAdapter", "", "Kotlin.Jvm.Internal.IFunctionAdapterInvoker")]
	public interface IFunctionAdapter : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001475 RID: 5237
		[Nullable(2)]
		IFunction FunctionDelegate { [NullableContext(2)] [Register("getFunctionDelegate", "()Lkotlin/Function;", "GetGetFunctionDelegateHandler:Kotlin.Jvm.Internal.IFunctionAdapterInvoker, Xamarin.Kotlin.StdLib")] get; }
	}
}
