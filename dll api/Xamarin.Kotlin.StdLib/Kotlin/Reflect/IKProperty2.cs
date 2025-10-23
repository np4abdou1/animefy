using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Reflect
{
	// Token: 0x02000130 RID: 304
	[Register("kotlin/reflect/KProperty2", "", "Kotlin.Reflect.IKProperty2Invoker")]
	[JavaTypeParameters(new string[]
	{
		"D",
		"E",
		"V"
	})]
	public interface IKProperty2 : IFunction2, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKProperty, IKCallable, IKAnnotatedElement
	{
		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000FFC RID: 4092
		[Nullable(1)]
		IKPropertyGetter Getter { [NullableContext(1)] [Register("getGetter", "()Lkotlin/reflect/KProperty2$Getter;", "GetGetGetterHandler:Kotlin.Reflect.IKProperty2Invoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x06000FFD RID: 4093
		[NullableContext(2)]
		[Register("get", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Ljava_lang_Object_Handler:Kotlin.Reflect.IKProperty2Invoker, Xamarin.Kotlin.StdLib")]
		Java.Lang.Object Get(Java.Lang.Object receiver1, Java.Lang.Object receiver2);

		// Token: 0x06000FFE RID: 4094
		[NullableContext(2)]
		[Register("getDelegate", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetGetDelegate_Ljava_lang_Object_Ljava_lang_Object_Handler:Kotlin.Reflect.IKProperty2Invoker, Xamarin.Kotlin.StdLib")]
		Java.Lang.Object GetDelegate(Java.Lang.Object receiver1, Java.Lang.Object receiver2);
	}
}
