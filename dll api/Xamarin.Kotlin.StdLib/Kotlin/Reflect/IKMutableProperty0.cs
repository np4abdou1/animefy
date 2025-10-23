using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Reflect
{
	// Token: 0x02000111 RID: 273
	[Register("kotlin/reflect/KMutableProperty0", "", "Kotlin.Reflect.IKMutableProperty0Invoker")]
	[JavaTypeParameters(new string[]
	{
		"V"
	})]
	public interface IKMutableProperty0 : IKMutableProperty, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IKProperty0, IFunction0, IFunction
	{
		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000CAA RID: 3242
		[Nullable(1)]
		IKMutablePropertySetter Setter { [NullableContext(1)] [Register("getSetter", "()Lkotlin/reflect/KMutableProperty0$Setter;", "GetGetSetterHandler:Kotlin.Reflect.IKMutableProperty0Invoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x06000CAB RID: 3243
		[NullableContext(2)]
		[Register("set", "(Ljava/lang/Object;)V", "GetSet_Ljava_lang_Object_Handler:Kotlin.Reflect.IKMutableProperty0Invoker, Xamarin.Kotlin.StdLib")]
		void Set(Java.Lang.Object value);
	}
}
