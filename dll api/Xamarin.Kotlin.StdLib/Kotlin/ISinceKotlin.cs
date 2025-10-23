using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x0200007F RID: 127
	[Register("kotlin/SinceKotlin", "", "Kotlin.ISinceKotlinInvoker")]
	public interface ISinceKotlin : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000357 RID: 855
		[NullableContext(2)]
		[Register("version", "()Ljava/lang/String;", "GetVersionHandler:Kotlin.ISinceKotlinInvoker, Xamarin.Kotlin.StdLib")]
		string Version();
	}
}
