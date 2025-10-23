using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000A3 RID: 163
	[Register("com/google/android/datatransport/runtime/dagger/Component$Factory", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.IComponentFactoryInvoker")]
	public interface IComponentFactory : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
