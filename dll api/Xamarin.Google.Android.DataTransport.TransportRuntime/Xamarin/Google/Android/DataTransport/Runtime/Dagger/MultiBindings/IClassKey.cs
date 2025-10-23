using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000C0 RID: 192
	[Register("com/google/android/datatransport/runtime/dagger/multibindings/ClassKey", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings.IClassKeyInvoker")]
	public interface IClassKey : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060006E1 RID: 1761
		[Register("value", "()Ljava/lang/Class;", "GetValueHandler:Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings.IClassKeyInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		Class Value();
	}
}
