using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x02000057 RID: 87
	[Register("org/intellij/lang/annotations/RegExp", "", "IntelliJ.Lang.Annotations.IRegExpInvoker")]
	public interface IRegExp : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060002C7 RID: 711
		[NullableContext(2)]
		[Register("prefix", "()Ljava/lang/String;", "GetPrefixHandler:IntelliJ.Lang.Annotations.IRegExpInvoker, Xamarin.Jetbrains.Annotations")]
		string Prefix();

		// Token: 0x060002C8 RID: 712
		[NullableContext(2)]
		[Register("suffix", "()Ljava/lang/String;", "GetSuffixHandler:IntelliJ.Lang.Annotations.IRegExpInvoker, Xamarin.Jetbrains.Annotations")]
		string Suffix();
	}
}
