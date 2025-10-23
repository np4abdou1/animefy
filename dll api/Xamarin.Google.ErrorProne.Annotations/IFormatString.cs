using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200001D RID: 29
	[Register("com/google/errorprone/annotations/FormatString", "", "Xamarin.Google.ErrorProne.Annotations.IFormatStringInvoker")]
	public interface IFormatString : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
