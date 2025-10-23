using System;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x02000093 RID: 147
	[Register("com/google/android/datatransport/runtime/backends/TransportBackend", "", "Xamarin.Google.Android.DataTransport.Runtime.Backends.ITransportBackendInvoker")]
	public interface ITransportBackend : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000560 RID: 1376
		[Register("decorate", "(Lcom/google/android/datatransport/runtime/EventInternal;)Lcom/google/android/datatransport/runtime/EventInternal;", "GetDecorate_Lcom_google_android_datatransport_runtime_EventInternal_Handler:Xamarin.Google.Android.DataTransport.Runtime.Backends.ITransportBackendInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		EventInternal Decorate(EventInternal p0);

		// Token: 0x06000561 RID: 1377
		[Register("send", "(Lcom/google/android/datatransport/runtime/backends/BackendRequest;)Lcom/google/android/datatransport/runtime/backends/BackendResponse;", "GetSend_Lcom_google_android_datatransport_runtime_backends_BackendRequest_Handler:Xamarin.Google.Android.DataTransport.Runtime.Backends.ITransportBackendInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		BackendResponse Send(BackendRequest p0);
	}
}
