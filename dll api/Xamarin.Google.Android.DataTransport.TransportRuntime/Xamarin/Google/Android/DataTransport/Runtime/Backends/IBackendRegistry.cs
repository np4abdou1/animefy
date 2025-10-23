using System;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x02000091 RID: 145
	[Register("com/google/android/datatransport/runtime/backends/BackendRegistry", "", "Xamarin.Google.Android.DataTransport.Runtime.Backends.IBackendRegistryInvoker")]
	public interface IBackendRegistry : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000553 RID: 1363
		[Register("get", "(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/backends/TransportBackend;", "GetGet_Ljava_lang_String_Handler:Xamarin.Google.Android.DataTransport.Runtime.Backends.IBackendRegistryInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		ITransportBackend Get(string p0);
	}
}
