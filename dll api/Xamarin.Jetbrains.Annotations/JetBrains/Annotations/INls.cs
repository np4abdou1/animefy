using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x0200001E RID: 30
	[Register("org/jetbrains/annotations/Nls", "", "JetBrains.Annotations.INlsInvoker")]
	public interface INls : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000B7 RID: 183
		[NullableContext(2)]
		[Register("capitalization", "()Lorg/jetbrains/annotations/Nls$Capitalization;", "GetCapitalizationHandler:JetBrains.Annotations.INlsInvoker, Xamarin.Jetbrains.Annotations")]
		NlsCapitalization Capitalization();
	}
}
