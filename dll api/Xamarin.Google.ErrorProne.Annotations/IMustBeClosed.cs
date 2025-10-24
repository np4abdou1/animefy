using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200002C RID: 44
	[Register("com/google/errorprone/annotations/MustBeClosed", "", "Xamarin.Google.ErrorProne.Annotations.IMustBeClosedInvoker")]
	public interface IMustBeClosed : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
