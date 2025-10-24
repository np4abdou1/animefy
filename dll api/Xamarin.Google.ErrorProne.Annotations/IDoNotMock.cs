using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000019 RID: 25
	[Register("com/google/errorprone/annotations/DoNotMock", "", "Xamarin.Google.ErrorProne.Annotations.IDoNotMockInvoker")]
	public interface IDoNotMock : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600008E RID: 142
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:Xamarin.Google.ErrorProne.Annotations.IDoNotMockInvoker, Xamarin.Google.ErrorProne.Annotations")]
		string Value();
	}
}
