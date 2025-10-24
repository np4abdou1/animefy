using System;
using Android.Runtime;
using Java.Interop;

namespace Kotlin
{
	// Token: 0x02000069 RID: 105
	[Register("kotlin/Function", "", "Kotlin.IFunctionInvoker")]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public interface IFunction : IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
