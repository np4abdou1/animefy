using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000AF RID: 175
	[Register("com/google/android/datatransport/runtime/dagger/Provides", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.IProvidesInvoker")]
	public interface IProvides : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
