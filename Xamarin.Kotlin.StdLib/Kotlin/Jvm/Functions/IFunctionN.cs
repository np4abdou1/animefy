using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Internal;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x02000214 RID: 532
	[Register("kotlin/jvm/functions/FunctionN", "", "Kotlin.Jvm.Functions.IFunctionNInvoker")]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public interface IFunctionN : IFunction, IJavaObject, IDisposable, IJavaPeerable, IFunctionBase
	{
		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060018DB RID: 6363
		int Arity { [Register("getArity", "()I", "GetGetArityHandler:Kotlin.Jvm.Functions.IFunctionNInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x060018DC RID: 6364
		[NullableContext(1)]
		[Register("invoke", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_arrayLjava_lang_Object_Handler:Kotlin.Jvm.Functions.IFunctionNInvoker, Xamarin.Kotlin.StdLib")]
		[return: Nullable(2)]
		Java.Lang.Object Invoke(params Java.Lang.Object[] args);
	}
}
