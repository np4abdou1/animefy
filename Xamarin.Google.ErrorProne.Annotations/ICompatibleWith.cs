using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000013 RID: 19
	[Register("com/google/errorprone/annotations/CompatibleWith", "", "Xamarin.Google.ErrorProne.Annotations.ICompatibleWithInvoker")]
	public interface ICompatibleWith : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000047 RID: 71
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:Xamarin.Google.ErrorProne.Annotations.ICompatibleWithInvoker, Xamarin.Google.ErrorProne.Annotations")]
		string Value();
	}
}
