using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000029 RID: 41
	[Register("com/google/errorprone/annotations/Keep", "", "Xamarin.Google.ErrorProne.Annotations.IKeepInvoker")]
	public interface IKeep : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
