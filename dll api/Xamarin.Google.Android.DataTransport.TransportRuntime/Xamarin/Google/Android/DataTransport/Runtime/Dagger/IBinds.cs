using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x0200009B RID: 155
	[Register("com/google/android/datatransport/runtime/dagger/Binds", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.IBindsInvoker")]
	public interface IBinds : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
