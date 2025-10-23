using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations.Concurrent
{
	// Token: 0x0200004C RID: 76
	[Register("com/google/errorprone/annotations/concurrent/LazyInit", "", "Xamarin.Google.ErrorProne.Annotations.Concurrent.ILazyInitInvoker")]
	public interface ILazyInit : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
