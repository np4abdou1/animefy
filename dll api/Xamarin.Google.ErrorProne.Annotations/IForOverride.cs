using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200001F RID: 31
	[Register("com/google/errorprone/annotations/ForOverride", "", "Xamarin.Google.ErrorProne.Annotations.IForOverrideInvoker")]
	public interface IForOverride : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
