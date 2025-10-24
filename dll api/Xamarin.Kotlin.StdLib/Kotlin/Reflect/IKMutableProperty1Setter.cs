using System;
using Android.Runtime;
using Java.Interop;
using Kotlin.Jvm.Functions;

namespace Kotlin.Reflect
{
	// Token: 0x02000113 RID: 275
	[Register("kotlin/reflect/KMutableProperty1$Setter", "", "Kotlin.Reflect.IKMutableProperty1SetterInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T",
		"V"
	})]
	public interface IKMutableProperty1Setter : IFunction2, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKMutablePropertySetter, IKFunction, IKCallable, IKAnnotatedElement, IKPropertyAccessor
	{
	}
}
