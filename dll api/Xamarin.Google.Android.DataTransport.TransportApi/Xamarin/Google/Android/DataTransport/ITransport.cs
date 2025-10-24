using System;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport
{
	// Token: 0x0200000F RID: 15
	[Register("com/google/android/datatransport/Transport", "", "Xamarin.Google.Android.DataTransport.ITransportInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface ITransport : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000053 RID: 83
		[Register("schedule", "(Lcom/google/android/datatransport/Event;Lcom/google/android/datatransport/TransportScheduleCallback;)V", "GetSchedule_Lcom_google_android_datatransport_Event_Lcom_google_android_datatransport_TransportScheduleCallback_Handler:Xamarin.Google.Android.DataTransport.ITransportInvoker, Xamarin.Google.Android.DataTransport.TransportApi")]
		void Schedule(Event p0, ITransportScheduleCallback p1);

		// Token: 0x06000054 RID: 84
		[Register("send", "(Lcom/google/android/datatransport/Event;)V", "GetSend_Lcom_google_android_datatransport_Event_Handler:Xamarin.Google.Android.DataTransport.ITransportInvoker, Xamarin.Google.Android.DataTransport.TransportApi")]
		void Send(Event p0);
	}
}
