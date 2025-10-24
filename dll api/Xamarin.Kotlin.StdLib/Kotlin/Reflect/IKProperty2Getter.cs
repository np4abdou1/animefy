using System;
using Android.Runtime;
using Java.Interop;
using Kotlin.Jvm.Functions;

namespace Kotlin.Reflect
{
	// Token: 0x0200012E RID: 302
	[Register("kotlin/reflect/KProperty2$Getter", "", "Kotlin.Reflect.IKProperty2GetterInvoker")]
	[JavaTypeParameters(new string[]
	{
		"D",
		"E",
		"V"
	})]
	public interface IKProperty2Getter : IFunction2, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKPropertyGetter, IKFunction, IKCallable, IKAnnotatedElement, IKPropertyAccessor
	{
	}
}
