using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000CC RID: 204
	[Register("com/google/android/datatransport/runtime/dagger/multibindings/Multibinds", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings.IMultibindsInvoker")]
	public interface IMultibinds : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
