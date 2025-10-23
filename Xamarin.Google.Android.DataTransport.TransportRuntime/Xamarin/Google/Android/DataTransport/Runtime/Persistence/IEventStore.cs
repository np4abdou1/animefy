using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Persistence
{
	// Token: 0x0200006E RID: 110
	[Register("com/google/android/datatransport/runtime/scheduling/persistence/EventStore", "", "Xamarin.Google.Android.DataTransport.Runtime.Persistence.IEventStoreInvoker")]
	public interface IEventStore : ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600039E RID: 926
		[Register("cleanUp", "()I", "GetCleanUpHandler:Xamarin.Google.Android.DataTransport.Runtime.Persistence.IEventStoreInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		int CleanUp();

		// Token: 0x0600039F RID: 927
		[Register("getNextCallTime", "(Lcom/google/android/datatransport/runtime/TransportContext;)J", "GetGetNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_Handler:Xamarin.Google.Android.DataTransport.Runtime.Persistence.IEventStoreInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		long GetNextCallTime(TransportContext p0);

		// Token: 0x060003A0 RID: 928
		[Register("hasPendingEventsFor", "(Lcom/google/android/datatransport/runtime/TransportContext;)Z", "GetHasPendingEventsFor_Lcom_google_android_datatransport_runtime_TransportContext_Handler:Xamarin.Google.Android.DataTransport.Runtime.Persistence.IEventStoreInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		bool HasPendingEventsFor(TransportContext p0);

		// Token: 0x060003A1 RID: 929
		[Register("loadActiveContexts", "()Ljava/lang/Iterable;", "GetLoadActiveContextsHandler:Xamarin.Google.Android.DataTransport.Runtime.Persistence.IEventStoreInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		IIterable LoadActiveContexts();

		// Token: 0x060003A2 RID: 930
		[Register("loadBatch", "(Lcom/google/android/datatransport/runtime/TransportContext;)Ljava/lang/Iterable;", "GetLoadBatch_Lcom_google_android_datatransport_runtime_TransportContext_Handler:Xamarin.Google.Android.DataTransport.Runtime.Persistence.IEventStoreInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		IIterable LoadBatch(TransportContext p0);

		// Token: 0x060003A3 RID: 931
		[Register("persist", "(Lcom/google/android/datatransport/runtime/TransportContext;Lcom/google/android/datatransport/runtime/EventInternal;)Lcom/google/android/datatransport/runtime/scheduling/persistence/PersistedEvent;", "GetPersist_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Handler:Xamarin.Google.Android.DataTransport.Runtime.Persistence.IEventStoreInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		PersistedEvent Persist(TransportContext p0, EventInternal p1);

		// Token: 0x060003A4 RID: 932
		[Register("recordFailure", "(Ljava/lang/Iterable;)V", "GetRecordFailure_Ljava_lang_Iterable_Handler:Xamarin.Google.Android.DataTransport.Runtime.Persistence.IEventStoreInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		void RecordFailure(IIterable p0);

		// Token: 0x060003A5 RID: 933
		[Register("recordNextCallTime", "(Lcom/google/android/datatransport/runtime/TransportContext;J)V", "GetRecordNextCallTime_Lcom_google_android_datatransport_runtime_TransportContext_JHandler:Xamarin.Google.Android.DataTransport.Runtime.Persistence.IEventStoreInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		void RecordNextCallTime(TransportContext p0, long p1);

		// Token: 0x060003A6 RID: 934
		[Register("recordSuccess", "(Ljava/lang/Iterable;)V", "GetRecordSuccess_Ljava_lang_Iterable_Handler:Xamarin.Google.Android.DataTransport.Runtime.Persistence.IEventStoreInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		void RecordSuccess(IIterable p0);
	}
}
