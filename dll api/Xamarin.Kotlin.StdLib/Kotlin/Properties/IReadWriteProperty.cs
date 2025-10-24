using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Reflect;

namespace Kotlin.Properties
{
	// Token: 0x02000148 RID: 328
	[Register("kotlin/properties/ReadWriteProperty", "", "Kotlin.Properties.IReadWritePropertyInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T",
		"V"
	})]
	public interface IReadWriteProperty : IReadOnlyProperty, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600113C RID: 4412
		[NullableContext(2)]
		[Register("getValue", "(Ljava/lang/Object;Lkotlin/reflect/KProperty;)Ljava/lang/Object;", "GetGetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Handler:Kotlin.Properties.IReadWritePropertyInvoker, Xamarin.Kotlin.StdLib")]
		Java.Lang.Object GetValue(Java.Lang.Object thisRef, [Nullable(1)] IKProperty property);

		// Token: 0x0600113D RID: 4413
		[NullableContext(2)]
		[Register("setValue", "(Ljava/lang/Object;Lkotlin/reflect/KProperty;Ljava/lang/Object;)V", "GetSetValue_Ljava_lang_Object_Lkotlin_reflect_KProperty_Ljava_lang_Object_Handler:Kotlin.Properties.IReadWritePropertyInvoker, Xamarin.Kotlin.StdLib")]
		void SetValue(Java.Lang.Object thisRef, [Nullable(1)] IKProperty property, Java.Lang.Object value);
	}
}
