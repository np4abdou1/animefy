using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000027 RID: 39
	[Register("com/google/errorprone/annotations/InlineMeValidationDisabled", "", "Xamarin.Google.ErrorProne.Annotations.IInlineMeValidationDisabledInvoker")]
	public interface IInlineMeValidationDisabled : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000139 RID: 313
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:Xamarin.Google.ErrorProne.Annotations.IInlineMeValidationDisabledInvoker, Xamarin.Google.ErrorProne.Annotations")]
		string Value();
	}
}
