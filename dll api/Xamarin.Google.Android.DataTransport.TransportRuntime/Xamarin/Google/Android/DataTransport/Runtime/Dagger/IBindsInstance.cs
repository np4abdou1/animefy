using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x0200009D RID: 157
	[Register("com/google/android/datatransport/runtime/dagger/BindsInstance", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.IBindsInstanceInvoker")]
	public interface IBindsInstance : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
