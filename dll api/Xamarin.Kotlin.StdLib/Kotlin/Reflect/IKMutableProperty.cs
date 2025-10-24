using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Reflect
{
	// Token: 0x0200010D RID: 269
	[Register("kotlin/reflect/KMutableProperty", "", "Kotlin.Reflect.IKMutablePropertyInvoker")]
	[JavaTypeParameters(new string[]
	{
		"V"
	})]
	public interface IKMutableProperty : IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000C31 RID: 3121
		[Nullable(1)]
		IKMutablePropertySetter Setter { [NullableContext(1)] [Register("getSetter", "()Lkotlin/reflect/KMutableProperty$Setter;", "GetGetSetterHandler:Kotlin.Reflect.IKMutablePropertyInvoker, Xamarin.Kotlin.StdLib")] get; }
	}
}
