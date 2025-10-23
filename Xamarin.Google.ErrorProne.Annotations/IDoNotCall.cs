using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000017 RID: 23
	[Register("com/google/errorprone/annotations/DoNotCall", "", "Xamarin.Google.ErrorProne.Annotations.IDoNotCallInvoker")]
	public interface IDoNotCall : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000075 RID: 117
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:Xamarin.Google.ErrorProne.Annotations.IDoNotCallInvoker, Xamarin.Google.ErrorProne.Annotations")]
		string Value();
	}
}
