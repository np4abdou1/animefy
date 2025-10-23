using System;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001A1 RID: 417
	[Register("kotlin/jvm/internal/FunctionBase", "", "Kotlin.Jvm.Internal.IFunctionBaseInvoker")]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public interface IFunctionBase : IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001482 RID: 5250
		int Arity { [Register("getArity", "()I", "GetGetArityHandler:Kotlin.Jvm.Internal.IFunctionBaseInvoker, Xamarin.Kotlin.StdLib")] get; }
	}
}
