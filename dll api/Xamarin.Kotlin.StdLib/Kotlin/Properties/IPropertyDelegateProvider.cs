using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Reflect;

namespace Kotlin.Properties
{
	// Token: 0x02000144 RID: 324
	[Register("kotlin/properties/PropertyDelegateProvider", "", "Kotlin.Properties.IPropertyDelegateProviderInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T",
		"D"
	})]
	public interface IPropertyDelegateProvider : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001122 RID: 4386
		[NullableContext(2)]
		[Register("provideDelegate", "(Ljava/lang/Object;Lkotlin/reflect/KProperty;)Ljava/lang/Object;", "GetProvideDelegate_Ljava_lang_Object_Lkotlin_reflect_KProperty_Handler:Kotlin.Properties.IPropertyDelegateProviderInvoker, Xamarin.Kotlin.StdLib")]
		Java.Lang.Object ProvideDelegate(Java.Lang.Object thisRef, [Nullable(1)] IKProperty property);
	}
}
