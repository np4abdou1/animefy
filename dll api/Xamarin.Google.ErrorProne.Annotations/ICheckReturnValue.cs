using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000011 RID: 17
	[Register("com/google/errorprone/annotations/CheckReturnValue", "", "Xamarin.Google.ErrorProne.Annotations.ICheckReturnValueInvoker")]
	public interface ICheckReturnValue : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
