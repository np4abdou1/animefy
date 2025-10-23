using System;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Reflect
{
	// Token: 0x02000122 RID: 290
	[Register("kotlin/reflect/KProperty$Getter", "", "Kotlin.Reflect.IKPropertyGetterInvoker")]
	[JavaTypeParameters(new string[]
	{
		"V"
	})]
	public interface IKPropertyGetter : IKFunction, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKCallable, IKAnnotatedElement, IKPropertyAccessor
	{
	}
}
