using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x0200004F RID: 79
	[Register("org/intellij/lang/annotations/Language", "", "IntelliJ.Lang.Annotations.ILanguageInvoker")]
	public interface ILanguage : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600024F RID: 591
		[NullableContext(2)]
		[Register("prefix", "()Ljava/lang/String;", "GetPrefixHandler:IntelliJ.Lang.Annotations.ILanguageInvoker, Xamarin.Jetbrains.Annotations")]
		string Prefix();

		// Token: 0x06000250 RID: 592
		[NullableContext(2)]
		[Register("suffix", "()Ljava/lang/String;", "GetSuffixHandler:IntelliJ.Lang.Annotations.ILanguageInvoker, Xamarin.Jetbrains.Annotations")]
		string Suffix();

		// Token: 0x06000251 RID: 593
		[NullableContext(2)]
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:IntelliJ.Lang.Annotations.ILanguageInvoker, Xamarin.Jetbrains.Annotations")]
		string Value();
	}
}
