using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000D1 RID: 209
	[Register("com/google/android/datatransport/runtime/dagger/multibindings/StringKey", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings.IStringKeyInvoker")]
	public interface IStringKey : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000785 RID: 1925
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings.IStringKeyInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		string Value();
	}
}
