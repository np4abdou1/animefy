using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Reflect
{
	// Token: 0x02000119 RID: 281
	[Register("kotlin/reflect/KMutableProperty2", "", "Kotlin.Reflect.IKMutableProperty2Invoker")]
	[JavaTypeParameters(new string[]
	{
		"D",
		"E",
		"V"
	})]
	public interface IKMutableProperty2 : IKMutableProperty, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IKProperty2, IFunction2, IFunction
	{
		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000DB6 RID: 3510
		[Nullable(1)]
		IKMutablePropertySetter Setter { [NullableContext(1)] [Register("getSetter", "()Lkotlin/reflect/KMutableProperty2$Setter;", "GetGetSetterHandler:Kotlin.Reflect.IKMutableProperty2Invoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x06000DB7 RID: 3511
		[NullableContext(2)]
		[Register("set", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "GetSet_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler:Kotlin.Reflect.IKMutableProperty2Invoker, Xamarin.Kotlin.StdLib")]
		void Set(Java.Lang.Object receiver1, Java.Lang.Object receiver2, Java.Lang.Object value);
	}
}
