using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin.Jvm
{
	// Token: 0x0200015A RID: 346
	[Register("kotlin/jvm/JvmName", "", "Kotlin.Jvm.IJvmNameInvoker")]
	public interface IJvmName : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060011FD RID: 4605
		[NullableContext(2)]
		[Register("name", "()Ljava/lang/String;", "GetNameHandler:Kotlin.Jvm.IJvmNameInvoker, Xamarin.Kotlin.StdLib")]
		string Name();
	}
}
