using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x020001E6 RID: 486
	[Register("kotlin/jvm/functions/Function0", "", "Kotlin.Jvm.Functions.IFunction0Invoker")]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public interface IFunction0 : IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060017B0 RID: 6064
		[NullableContext(2)]
		[Register("invoke", "()Ljava/lang/Object;", "GetInvokeHandler:Kotlin.Jvm.Functions.IFunction0Invoker, Xamarin.Kotlin.StdLib")]
		Java.Lang.Object Invoke();
	}
}
