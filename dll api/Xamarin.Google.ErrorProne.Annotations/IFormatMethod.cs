using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200001B RID: 27
	[Register("com/google/errorprone/annotations/FormatMethod", "", "Xamarin.Google.ErrorProne.Annotations.IFormatMethodInvoker")]
	public interface IFormatMethod : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
