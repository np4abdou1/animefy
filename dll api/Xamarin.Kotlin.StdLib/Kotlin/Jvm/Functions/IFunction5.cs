using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x0200020A RID: 522
	[Register("kotlin/jvm/functions/Function5", "", "Kotlin.Jvm.Functions.IFunction5Invoker")]
	[JavaTypeParameters(new string[]
	{
		"P1",
		"P2",
		"P3",
		"P4",
		"P5",
		"R"
	})]
	public interface IFunction5 : IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600189A RID: 6298
		[NullableContext(2)]
		[Register("invoke", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler:Kotlin.Jvm.Functions.IFunction5Invoker, Xamarin.Kotlin.StdLib")]
		Java.Lang.Object Invoke(Java.Lang.Object p0, Java.Lang.Object p1, Java.Lang.Object p2, Java.Lang.Object p3, Java.Lang.Object p4);
	}
}
