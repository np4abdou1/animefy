using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Synchronization
{
	// Token: 0x02000040 RID: 64
	[Register("com/google/android/datatransport/runtime/synchronization/SynchronizationGuard$CriticalSection", "", "Xamarin.Google.Android.DataTransport.Runtime.Synchronization.ISynchronizationGuardCriticalSectionInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface ISynchronizationGuardCriticalSection : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000202 RID: 514
		[Register("execute", "()Ljava/lang/Object;", "GetExecuteHandler:Xamarin.Google.Android.DataTransport.Runtime.Synchronization.ISynchronizationGuardCriticalSectionInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		Java.Lang.Object Execute();
	}
}
