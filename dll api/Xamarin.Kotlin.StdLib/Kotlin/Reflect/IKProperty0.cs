using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Reflect
{
	// Token: 0x02000128 RID: 296
	[Register("kotlin/reflect/KProperty0", "", "Kotlin.Reflect.IKProperty0Invoker")]
	[JavaTypeParameters(new string[]
	{
		"V"
	})]
	public interface IKProperty0 : IFunction0, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKProperty, IKCallable, IKAnnotatedElement
	{
		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000EFA RID: 3834
		[Nullable(2)]
		Java.Lang.Object Delegate { [NullableContext(2)] [Register("getDelegate", "()Ljava/lang/Object;", "GetGetDelegateHandler:Kotlin.Reflect.IKProperty0Invoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000EFB RID: 3835
		[Nullable(1)]
		IKPropertyGetter Getter { [NullableContext(1)] [Register("getGetter", "()Lkotlin/reflect/KProperty0$Getter;", "GetGetGetterHandler:Kotlin.Reflect.IKProperty0Invoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x06000EFC RID: 3836
		[NullableContext(2)]
		[Register("get", "()Ljava/lang/Object;", "GetGetHandler:Kotlin.Reflect.IKProperty0Invoker, Xamarin.Kotlin.StdLib")]
		Java.Lang.Object Get();
	}
}
