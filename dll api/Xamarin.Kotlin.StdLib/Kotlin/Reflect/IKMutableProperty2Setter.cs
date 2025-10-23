using System;
using Android.Runtime;
using Java.Interop;
using Kotlin.Jvm.Functions;

namespace Kotlin.Reflect
{
	// Token: 0x02000117 RID: 279
	[Register("kotlin/reflect/KMutableProperty2$Setter", "", "Kotlin.Reflect.IKMutableProperty2SetterInvoker")]
	[JavaTypeParameters(new string[]
	{
		"D",
		"E",
		"V"
	})]
	public interface IKMutableProperty2Setter : IFunction3, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKMutablePropertySetter, IKFunction, IKCallable, IKAnnotatedElement, IKPropertyAccessor
	{
	}
}
