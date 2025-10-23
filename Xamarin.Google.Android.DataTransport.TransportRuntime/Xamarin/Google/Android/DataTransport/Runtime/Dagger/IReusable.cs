using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000B1 RID: 177
	[Register("com/google/android/datatransport/runtime/dagger/Reusable", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.IReusableInvoker")]
	public interface IReusable : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
