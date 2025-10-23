using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Reflect
{
	// Token: 0x020000FF RID: 255
	[NullableContext(1)]
	[Register("kotlin/reflect/KCallable", "", "Kotlin.Reflect.IKCallableInvoker")]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public interface IKCallable : IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000AF9 RID: 2809
		bool IsAbstract { [Register("isAbstract", "()Z", "GetIsAbstractHandler:Kotlin.Reflect.IKCallableInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000AFA RID: 2810
		bool IsFinal { [Register("isFinal", "()Z", "GetIsFinalHandler:Kotlin.Reflect.IKCallableInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000AFB RID: 2811
		bool IsOpen { [Register("isOpen", "()Z", "GetIsOpenHandler:Kotlin.Reflect.IKCallableInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000AFC RID: 2812
		bool IsSuspend { [Register("isSuspend", "()Z", "GetIsSuspendHandler:Kotlin.Reflect.IKCallableInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000AFD RID: 2813
		string Name { [Register("getName", "()Ljava/lang/String;", "GetGetNameHandler:Kotlin.Reflect.IKCallableInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000AFE RID: 2814
		IList<IKParameter> Parameters { [Register("getParameters", "()Ljava/util/List;", "GetGetParametersHandler:Kotlin.Reflect.IKCallableInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000AFF RID: 2815
		IKType ReturnType { [Register("getReturnType", "()Lkotlin/reflect/KType;", "GetGetReturnTypeHandler:Kotlin.Reflect.IKCallableInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000B00 RID: 2816
		IList<IKTypeParameter> TypeParameters { [Register("getTypeParameters", "()Ljava/util/List;", "GetGetTypeParametersHandler:Kotlin.Reflect.IKCallableInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000B01 RID: 2817
		[Nullable(2)]
		KVisibility Visibility { [NullableContext(2)] [Register("getVisibility", "()Lkotlin/reflect/KVisibility;", "GetGetVisibilityHandler:Kotlin.Reflect.IKCallableInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x06000B02 RID: 2818
		[Register("call", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetCall_arrayLjava_lang_Object_Handler:Kotlin.Reflect.IKCallableInvoker, Xamarin.Kotlin.StdLib")]
		[return: Nullable(2)]
		Java.Lang.Object Call(params Java.Lang.Object[] args);

		// Token: 0x06000B03 RID: 2819
		[Register("callBy", "(Ljava/util/Map;)Ljava/lang/Object;", "GetCallBy_Ljava_util_Map_Handler:Kotlin.Reflect.IKCallableInvoker, Xamarin.Kotlin.StdLib")]
		[return: Nullable(2)]
		Java.Lang.Object CallBy(IDictionary args);
	}
}
