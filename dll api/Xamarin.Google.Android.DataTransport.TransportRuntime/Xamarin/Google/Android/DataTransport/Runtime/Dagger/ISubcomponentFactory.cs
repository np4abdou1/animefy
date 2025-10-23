using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000B5 RID: 181
	[Register("com/google/android/datatransport/runtime/dagger/Subcomponent$Factory", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.ISubcomponentFactoryInvoker")]
	public interface ISubcomponentFactory : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
