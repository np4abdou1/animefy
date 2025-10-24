using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Reflect
{
	// Token: 0x0200011F RID: 287
	[Register("kotlin/reflect/KProperty$Accessor", "", "Kotlin.Reflect.IKPropertyAccessorInvoker")]
	[JavaTypeParameters(new string[]
	{
		"V"
	})]
	public interface IKPropertyAccessor : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000E33 RID: 3635
		[Nullable(1)]
		IKProperty Property { [NullableContext(1)] [Register("getProperty", "()Lkotlin/reflect/KProperty;", "GetGetPropertyHandler:Kotlin.Reflect.IKPropertyAccessorInvoker, Xamarin.Kotlin.StdLib")] get; }
	}
}
