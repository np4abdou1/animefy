using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Time
{
	// Token: 0x02000033 RID: 51
	[Register("com/google/android/datatransport/runtime/time/Monotonic", "", "Xamarin.Google.Android.DataTransport.Runtime.Time.IMonotonicInvoker")]
	public interface IMonotonic : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
