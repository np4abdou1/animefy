using System;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Reflect
{
	// Token: 0x02000109 RID: 265
	[Register("kotlin/reflect/KFunction", "", "Kotlin.Reflect.IKFunctionInvoker")]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public interface IKFunction : IFunction, IJavaObject, IDisposable, IJavaPeerable, IKCallable, IKAnnotatedElement
	{
		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000BB7 RID: 2999
		bool IsExternal { [Register("isExternal", "()Z", "GetIsExternalHandler:Kotlin.Reflect.IKFunctionInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000BB8 RID: 3000
		bool IsInfix { [Register("isInfix", "()Z", "GetIsInfixHandler:Kotlin.Reflect.IKFunctionInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000BB9 RID: 3001
		bool IsInline { [Register("isInline", "()Z", "GetIsInlineHandler:Kotlin.Reflect.IKFunctionInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000BBA RID: 3002
		bool IsOperator { [Register("isOperator", "()Z", "GetIsOperatorHandler:Kotlin.Reflect.IKFunctionInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000BBB RID: 3003
		bool IsSuspend { [Register("isSuspend", "()Z", "GetIsSuspendHandler:Kotlin.Reflect.IKFunctionInvoker, Xamarin.Kotlin.StdLib")] get; }
	}
}
