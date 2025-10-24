using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000CA RID: 202
	[Register("com/google/android/datatransport/runtime/dagger/multibindings/LongKey", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings.ILongKeyInvoker")]
	public interface ILongKey : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000752 RID: 1874
		[Register("value", "()J", "GetValueHandler:Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings.ILongKeyInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		long Value();
	}
}
