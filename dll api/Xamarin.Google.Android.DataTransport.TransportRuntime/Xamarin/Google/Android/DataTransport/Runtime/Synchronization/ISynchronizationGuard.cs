using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Synchronization
{
	// Token: 0x02000042 RID: 66
	[Register("com/google/android/datatransport/runtime/synchronization/SynchronizationGuard", "", "Xamarin.Google.Android.DataTransport.Runtime.Synchronization.ISynchronizationGuardInvoker")]
	public interface ISynchronizationGuard : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600020F RID: 527
		[Register("runCriticalSection", "(Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard$CriticalSection;)Ljava/lang/Object;", "GetRunCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_Handler:Xamarin.Google.Android.DataTransport.Runtime.Synchronization.ISynchronizationGuardInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		Java.Lang.Object RunCriticalSection(ISynchronizationGuardCriticalSection p0);
	}
}
