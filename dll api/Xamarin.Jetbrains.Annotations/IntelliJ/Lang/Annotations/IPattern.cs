using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x02000053 RID: 83
	[Register("org/intellij/lang/annotations/Pattern", "", "IntelliJ.Lang.Annotations.IPatternInvoker")]
	public interface IPattern : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000299 RID: 665
		[NullableContext(2)]
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:IntelliJ.Lang.Annotations.IPatternInvoker, Xamarin.Jetbrains.Annotations")]
		string Value();
	}
}
