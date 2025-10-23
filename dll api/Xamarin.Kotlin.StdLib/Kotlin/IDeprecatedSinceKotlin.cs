using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x0200005B RID: 91
	[Register("kotlin/DeprecatedSinceKotlin", "", "Kotlin.IDeprecatedSinceKotlinInvoker")]
	public interface IDeprecatedSinceKotlin : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060001AD RID: 429
		[NullableContext(2)]
		[Register("errorSince", "()Ljava/lang/String;", "GetErrorSinceHandler:Kotlin.IDeprecatedSinceKotlinInvoker, Xamarin.Kotlin.StdLib")]
		string ErrorSince();

		// Token: 0x060001AE RID: 430
		[NullableContext(2)]
		[Register("hiddenSince", "()Ljava/lang/String;", "GetHiddenSinceHandler:Kotlin.IDeprecatedSinceKotlinInvoker, Xamarin.Kotlin.StdLib")]
		string HiddenSince();

		// Token: 0x060001AF RID: 431
		[NullableContext(2)]
		[Register("warningSince", "()Ljava/lang/String;", "GetWarningSinceHandler:Kotlin.IDeprecatedSinceKotlinInvoker, Xamarin.Kotlin.StdLib")]
		string WarningSince();
	}
}
