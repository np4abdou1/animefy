using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200000F RID: 15
	[Register("com/google/errorprone/annotations/CanIgnoreReturnValue", "", "Xamarin.Google.ErrorProne.Annotations.ICanIgnoreReturnValueInvoker")]
	public interface ICanIgnoreReturnValue : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
