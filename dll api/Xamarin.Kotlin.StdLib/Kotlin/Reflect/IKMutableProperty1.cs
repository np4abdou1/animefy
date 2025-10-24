using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Reflect
{
	// Token: 0x02000115 RID: 277
	[Register("kotlin/reflect/KMutableProperty1", "", "Kotlin.Reflect.IKMutableProperty1Invoker")]
	[JavaTypeParameters(new string[]
	{
		"T",
		"V"
	})]
	public interface IKMutableProperty1 : IKMutableProperty, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IKProperty1, IFunction1, IFunction
	{
		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000D30 RID: 3376
		[Nullable(1)]
		IKMutablePropertySetter Setter { [NullableContext(1)] [Register("getSetter", "()Lkotlin/reflect/KMutableProperty1$Setter;", "GetGetSetterHandler:Kotlin.Reflect.IKMutableProperty1Invoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x06000D31 RID: 3377
		[NullableContext(2)]
		[Register("set", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetSet_Ljava_lang_Object_Ljava_lang_Object_Handler:Kotlin.Reflect.IKMutableProperty1Invoker, Xamarin.Kotlin.StdLib")]
		void Set(Java.Lang.Object receiver, Java.Lang.Object value);
	}
}
