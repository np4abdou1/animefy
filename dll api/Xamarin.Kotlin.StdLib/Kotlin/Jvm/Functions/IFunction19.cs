using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x020001FC RID: 508
	[Register("kotlin/jvm/functions/Function19", "", "Kotlin.Jvm.Functions.IFunction19Invoker")]
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
		"P14",
		"P15",
		"P16",
		"P17",
		"P18",
		"P19",
		"R"
	})]
	public interface IFunction19 : IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600183F RID: 6207
		[NullableContext(2)]
		[Register("invoke", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler:Kotlin.Jvm.Functions.IFunction19Invoker, Xamarin.Kotlin.StdLib")]
		Java.Lang.Object Invoke(Java.Lang.Object p0, Java.Lang.Object p1, Java.Lang.Object p2, Java.Lang.Object p3, Java.Lang.Object p4, Java.Lang.Object p5, Java.Lang.Object p6, Java.Lang.Object p7, Java.Lang.Object p8, Java.Lang.Object p9, Java.Lang.Object p10, Java.Lang.Object p11, Java.Lang.Object p12, Java.Lang.Object p13, Java.Lang.Object p14, Java.Lang.Object p15, Java.Lang.Object p16, Java.Lang.Object p17, Java.Lang.Object p18);
	}
}
