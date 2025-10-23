using System;
using Android.Runtime;
using Java.Interop;
using Kotlin.Jvm.Functions;

namespace Kotlin.Reflect
{
	// Token: 0x0200012A RID: 298
	[Register("kotlin/reflect/KProperty1$Getter", "", "Kotlin.Reflect.IKProperty1GetterInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T",
		"V"
	})]
	public interface IKProperty1Getter : IFunction1, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKPropertyGetter, IKFunction, IKCallable, IKAnnotatedElement, IKPropertyAccessor
	{
	}
}
