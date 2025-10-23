using System;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling
{
	// Token: 0x02000047 RID: 71
	[Register("com/google/android/datatransport/runtime/scheduling/Scheduler", "", "Xamarin.Google.Android.DataTransport.Runtime.Scheduling.ISchedulerInvoker")]
	public interface IScheduler : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000237 RID: 567
		[Register("schedule", "(Lcom/google/android/datatransport/runtime/TransportContext;Lcom/google/android/datatransport/runtime/EventInternal;Lcom/google/android/datatransport/TransportScheduleCallback;)V", "GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_Handler:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.ISchedulerInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		void Schedule(TransportContext p0, EventInternal p1, ITransportScheduleCallback p2);
	}
}
