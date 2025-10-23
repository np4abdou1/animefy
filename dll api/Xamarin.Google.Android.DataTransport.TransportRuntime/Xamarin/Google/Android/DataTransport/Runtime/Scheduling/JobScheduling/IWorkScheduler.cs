using System;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling
{
	// Token: 0x02000051 RID: 81
	[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler", "", "Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.IWorkSchedulerInvoker")]
	public interface IWorkScheduler : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000285 RID: 645
		[Register("schedule", "(Lcom/google/android/datatransport/runtime/TransportContext;I)V", "GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_IHandler:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.IWorkSchedulerInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		void Schedule(TransportContext p0, int p1);

		// Token: 0x06000286 RID: 646
		[Register("schedule", "(Lcom/google/android/datatransport/runtime/TransportContext;IZ)V", "GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_IZHandler:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.IWorkSchedulerInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		void Schedule(TransportContext p0, int p1, bool p2);
	}
}
