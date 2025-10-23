using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000E7 RID: 231
	[Register("com/google/android/datatransport/runtime/dagger/internal/InjectedFieldSignature", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.IInjectedFieldSignatureInvoker")]
	public interface IInjectedFieldSignature : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000830 RID: 2096
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.IInjectedFieldSignatureInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		string Value();
	}
}
