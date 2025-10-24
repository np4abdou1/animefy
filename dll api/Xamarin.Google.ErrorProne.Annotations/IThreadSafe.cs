using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200003B RID: 59
	[Register("com/google/errorprone/annotations/ThreadSafe", "", "Xamarin.Google.ErrorProne.Annotations.IThreadSafeInvoker")]
	public interface IThreadSafe : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
