using System;
using Android.Runtime;
using Java.Interop;
using Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport;

namespace Xamarin.Google.Android.DataTransport.Runtime.Persistence
{
	// Token: 0x0200006C RID: 108
	[Register("com/google/android/datatransport/runtime/scheduling/persistence/ClientHealthMetricsStore", "", "Xamarin.Google.Android.DataTransport.Runtime.Persistence.IClientHealthMetricsStoreInvoker")]
	public interface IClientHealthMetricsStore : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000389 RID: 905
		[Register("loadClientMetrics", "()Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics;", "GetLoadClientMetricsHandler:Xamarin.Google.Android.DataTransport.Runtime.Persistence.IClientHealthMetricsStoreInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		ClientMetrics LoadClientMetrics();

		// Token: 0x0600038A RID: 906
		[Register("recordLogEventDropped", "(JLcom/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason;Ljava/lang/String;)V", "GetRecordLogEventDropped_JLcom_google_android_datatransport_runtime_firebase_transport_LogEventDropped_Reason_Ljava_lang_String_Handler:Xamarin.Google.Android.DataTransport.Runtime.Persistence.IClientHealthMetricsStoreInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		void RecordLogEventDropped(long p0, LogEventDropped.Reason p1, string p2);

		// Token: 0x0600038B RID: 907
		[Register("resetClientMetrics", "()V", "GetResetClientMetricsHandler:Xamarin.Google.Android.DataTransport.Runtime.Persistence.IClientHealthMetricsStoreInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		void ResetClientMetrics();
	}
}
