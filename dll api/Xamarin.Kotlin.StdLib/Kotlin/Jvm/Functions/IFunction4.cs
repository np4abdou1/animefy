using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x02000208 RID: 520
	[Register("kotlin/jvm/functions/Function4", "", "Kotlin.Jvm.Functions.IFunction4Invoker")]
	[JavaTypeParameters(new string[]
	{
		"P1",
		"P2",
		"P3",
		"P4",
		"R"
	})]
	public interface IFunction4 : IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600188D RID: 6285
		[NullableContext(2)]
		[Register("invoke", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler:Kotlin.Jvm.Functions.IFunction4Invoker, Xamarin.Kotlin.StdLib")]
		Java.Lang.Object Invoke(Java.Lang.Object p0, Java.Lang.Object p1, Java.Lang.Object p2, Java.Lang.Object p3);
	}
}
