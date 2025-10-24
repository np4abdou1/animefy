using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x0200020C RID: 524
	[Register("kotlin/jvm/functions/Function6", "", "Kotlin.Jvm.Functions.IFunction6Invoker")]
	[JavaTypeParameters(new string[]
	{
		"P1",
		"P2",
		"P3",
		"P4",
		"P5",
		"P6",
		"R"
	})]
	public interface IFunction6 : IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060018A7 RID: 6311
		[NullableContext(2)]
		[Register("invoke", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler:Kotlin.Jvm.Functions.IFunction6Invoker, Xamarin.Kotlin.StdLib")]
		Java.Lang.Object Invoke(Java.Lang.Object p0, Java.Lang.Object p1, Java.Lang.Object p2, Java.Lang.Object p3, Java.Lang.Object p4, Java.Lang.Object p5);
	}
}
