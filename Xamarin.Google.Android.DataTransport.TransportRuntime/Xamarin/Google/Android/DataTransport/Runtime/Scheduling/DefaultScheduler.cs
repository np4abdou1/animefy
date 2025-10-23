using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using Xamarin.Google.Android.DataTransport.Runtime.Backends;
using Xamarin.Google.Android.DataTransport.Runtime.Persistence;
using Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling;
using Xamarin.Google.Android.DataTransport.Runtime.Synchronization;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling
{
	// Token: 0x02000045 RID: 69
	[Register("com/google/android/datatransport/runtime/scheduling/DefaultScheduler", DoNotGenerateAcw = true)]
	public class DefaultScheduler : Java.Lang.Object, IScheduler, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00006794 File Offset: 0x00004994
		internal static IntPtr class_ref
		{
			get
			{
				return DefaultScheduler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000224 RID: 548 RVA: 0x000067B8 File Offset: 0x000049B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DefaultScheduler._members;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000067C0 File Offset: 0x000049C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DefaultScheduler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000226 RID: 550 RVA: 0x000067E4 File Offset: 0x000049E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DefaultScheduler._members.ManagedPeerType;
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000026C4 File Offset: 0x000008C4
		protected DefaultScheduler(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000067F0 File Offset: 0x000049F0
		[Register(".ctor", "(Ljava/util/concurrent/Executor;Lcom/google/android/datatransport/runtime/backends/BackendRegistry;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard;)V", "")]
		public unsafe DefaultScheduler(IExecutor executor, IBackendRegistry backendRegistry, IWorkScheduler workScheduler, IEventStore eventStore, ISynchronizationGuard guard) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				ptr[1] = new JniArgumentValue((backendRegistry == null) ? IntPtr.Zero : ((Java.Lang.Object)backendRegistry).Handle);
				ptr[2] = new JniArgumentValue((workScheduler == null) ? IntPtr.Zero : ((Java.Lang.Object)workScheduler).Handle);
				ptr[3] = new JniArgumentValue((eventStore == null) ? IntPtr.Zero : ((Java.Lang.Object)eventStore).Handle);
				ptr[4] = new JniArgumentValue((guard == null) ? IntPtr.Zero : ((Java.Lang.Object)guard).Handle);
				base.SetHandle(DefaultScheduler._members.InstanceMethods.StartCreateInstance("(Ljava/util/concurrent/Executor;Lcom/google/android/datatransport/runtime/backends/BackendRegistry;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DefaultScheduler._members.InstanceMethods.FinishCreateInstance("(Ljava/util/concurrent/Executor;Lcom/google/android/datatransport/runtime/backends/BackendRegistry;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(executor);
				GC.KeepAlive(backendRegistry);
				GC.KeepAlive(workScheduler);
				GC.KeepAlive(eventStore);
				GC.KeepAlive(guard);
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00006974 File Offset: 0x00004B74
		private static Delegate GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_Handler()
		{
			if (DefaultScheduler.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_ == null)
			{
				DefaultScheduler.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(DefaultScheduler.n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_));
			}
			return DefaultScheduler.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00006998 File Offset: 0x00004B98
		private static void n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_transportContext, IntPtr native_e, IntPtr native__callback)
		{
			DefaultScheduler @object = Java.Lang.Object.GetObject<DefaultScheduler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_transportContext, JniHandleOwnership.DoNotTransfer);
			EventInternal object3 = Java.Lang.Object.GetObject<EventInternal>(native_e, JniHandleOwnership.DoNotTransfer);
			ITransportScheduleCallback object4 = Java.Lang.Object.GetObject<ITransportScheduleCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.Schedule(object2, object3, object4);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000069D0 File Offset: 0x00004BD0
		[Register("schedule", "(Lcom/google/android/datatransport/runtime/TransportContext;Lcom/google/android/datatransport/runtime/EventInternal;Lcom/google/android/datatransport/TransportScheduleCallback;)V", "GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_Handler")]
		public unsafe virtual void Schedule(TransportContext transportContext, EventInternal e, ITransportScheduleCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transportContext == null) ? IntPtr.Zero : transportContext.Handle);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				DefaultScheduler._members.InstanceMethods.InvokeVirtualVoidMethod("schedule.(Lcom/google/android/datatransport/runtime/TransportContext;Lcom/google/android/datatransport/runtime/EventInternal;Lcom/google/android/datatransport/TransportScheduleCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(transportContext);
				GC.KeepAlive(e);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0400007D RID: 125
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/DefaultScheduler", typeof(DefaultScheduler));

		// Token: 0x0400007E RID: 126
		private static Delegate cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_;
	}
}
