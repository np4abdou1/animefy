using System;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Reflect
{
	// Token: 0x0200010B RID: 267
	[Register("kotlin/reflect/KMutableProperty$Setter", "", "Kotlin.Reflect.IKMutablePropertySetterInvoker")]
	[JavaTypeParameters(new string[]
	{
		"V"
	})]
	public interface IKMutablePropertySetter : IKFunction, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKCallable, IKAnnotatedElement, IKPropertyAccessor
	{
	}
}
