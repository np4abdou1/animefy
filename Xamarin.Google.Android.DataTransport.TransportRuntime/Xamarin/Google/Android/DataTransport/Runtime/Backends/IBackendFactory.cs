using System;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x0200008F RID: 143
	[Register("com/google/android/datatransport/runtime/backends/BackendFactory", "", "Xamarin.Google.Android.DataTransport.Runtime.Backends.IBackendFactoryInvoker")]
	public interface IBackendFactory : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000546 RID: 1350
		[Register("create", "(Lcom/google/android/datatransport/runtime/backends/CreationContext;)Lcom/google/android/datatransport/runtime/backends/TransportBackend;", "GetCreate_Lcom_google_android_datatransport_runtime_backends_CreationContext_Handler:Xamarin.Google.Android.DataTransport.Runtime.Backends.IBackendFactoryInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		ITransportBackend Create(CreationContext p0);
	}
}
