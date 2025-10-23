using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Time
{
	// Token: 0x02000035 RID: 53
	[Register("com/google/android/datatransport/runtime/time/WallTime", "", "Xamarin.Google.Android.DataTransport.Runtime.Time.IWallTimeInvoker")]
	public interface IWallTime : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
