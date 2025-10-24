using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000C4 RID: 196
	[Register("com/google/android/datatransport/runtime/dagger/multibindings/IntKey", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings.IIntKeyInvoker")]
	public interface IIntKey : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600070F RID: 1807
		[Register("value", "()I", "GetValueHandler:Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings.IIntKeyInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		int Value();
	}
}
