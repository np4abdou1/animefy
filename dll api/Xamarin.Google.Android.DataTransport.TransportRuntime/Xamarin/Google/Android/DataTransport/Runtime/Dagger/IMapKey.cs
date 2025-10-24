using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000A9 RID: 169
	[Register("com/google/android/datatransport/runtime/dagger/MapKey", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.IMapKeyInvoker")]
	public interface IMapKey : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000620 RID: 1568
		[Register("unwrapValue", "()Z", "GetUnwrapValueHandler:Xamarin.Google.Android.DataTransport.Runtime.Dagger.IMapKeyInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		bool UnwrapValue();
	}
}
