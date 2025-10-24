using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Reflect;

namespace Kotlin.Properties
{
	// Token: 0x02000146 RID: 326
	[Register("kotlin/properties/ReadOnlyProperty", "", "Kotlin.Properties.IReadOnlyPropertyInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T",
		"V"
	})]
	public interface IReadOnlyProperty : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600112F RID: 4399
		[NullableContext(2)]
		[Register("getValue", "(Ljava/lang/Object;Lkotlin/reflect/KProperty;)Ljava/lang/Object;", "GetGetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Handler:Kotlin.Properties.IReadOnlyPropertyInvoker, Xamarin.Kotlin.StdLib")]
		Java.Lang.Object GetValue(Java.Lang.Object thisRef, [Nullable(1)] IKProperty property);
	}
}
