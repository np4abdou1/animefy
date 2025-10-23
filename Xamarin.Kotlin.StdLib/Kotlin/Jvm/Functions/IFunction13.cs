using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x020001F0 RID: 496
	[Register("kotlin/jvm/functions/Function13", "", "Kotlin.Jvm.Functions.IFunction13Invoker")]
	[JavaTypeParameters(new string[]
	{
		"P1",
		"P2",
		"P3",
		"P4",
		"P5",
		"P6",
		"P7",
		"P8",
		"P9",
		"P10",
		"P11",
		"P12",
		"P13",
		"R"
	})]
	public interface IFunction13 : IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060017F1 RID: 6129
		[NullableContext(2)]
		[Register("invoke", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler:Kotlin.Jvm.Functions.IFunction13Invoker, Xamarin.Kotlin.StdLib")]
		Java.Lang.Object Invoke(Java.Lang.Object p0, Java.Lang.Object p1, Java.Lang.Object p2, Java.Lang.Object p3, Java.Lang.Object p4, Java.Lang.Object p5, Java.Lang.Object p6, Java.Lang.Object p7, Java.Lang.Object p8, Java.Lang.Object p9, Java.Lang.Object p10, Java.Lang.Object p11, Java.Lang.Object p12);
	}
}
