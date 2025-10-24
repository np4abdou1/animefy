using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Reflect
{
	// Token: 0x0200012C RID: 300
	[Register("kotlin/reflect/KProperty1", "", "Kotlin.Reflect.IKProperty1Invoker")]
	[JavaTypeParameters(new string[]
	{
		"T",
		"V"
	})]
	public interface IKProperty1 : IFunction1, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKProperty, IKCallable, IKAnnotatedElement
	{
		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000F7B RID: 3963
		[Nullable(1)]
		IKPropertyGetter Getter { [NullableContext(1)] [Register("getGetter", "()Lkotlin/reflect/KProperty1$Getter;", "GetGetGetterHandler:Kotlin.Reflect.IKProperty1Invoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x06000F7C RID: 3964
		[NullableContext(2)]
		[Register("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler:Kotlin.Reflect.IKProperty1Invoker, Xamarin.Kotlin.StdLib")]
		Java.Lang.Object Get(Java.Lang.Object receiver);

		// Token: 0x06000F7D RID: 3965
		[NullableContext(2)]
		[Register("getDelegate", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGetDelegate_Ljava_lang_Object_Handler:Kotlin.Reflect.IKProperty1Invoker, Xamarin.Kotlin.StdLib")]
		Java.Lang.Object GetDelegate(Java.Lang.Object receiver);
	}
}
