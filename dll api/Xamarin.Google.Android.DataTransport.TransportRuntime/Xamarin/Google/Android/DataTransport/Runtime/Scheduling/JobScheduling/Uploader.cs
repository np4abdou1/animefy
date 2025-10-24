using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using Xamarin.Google.Android.DataTransport.Runtime.Backends;
using Xamarin.Google.Android.DataTransport.Runtime.Persistence;
using Xamarin.Google.Android.DataTransport.Runtime.Synchronization;
using Xamarin.Google.Android.DataTransport.Runtime.Time;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling
{
	// Token: 0x0200005D RID: 93
	[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader", DoNotGenerateAcw = true)]
	public class Uploader : Java.Lang.Object
	{
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0000950C File Offset: 0x0000770C
		internal static IntPtr class_ref
		{
			get
			{
				return Uploader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00009530 File Offset: 0x00007730
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Uploader._members;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00009538 File Offset: 0x00007738
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Uploader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0000955C File Offset: 0x0000775C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Uploader._members.ManagedPeerType;
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000026C4 File Offset: 0x000008C4
		protected Uploader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00009568 File Offset: 0x00007768
		[Register(".ctor", "(Landroid/content/Context;Lcom/google/android/datatransport/runtime/backends/BackendRegistry;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;Ljava/util/concurrent/Executor;Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/scheduling/persistence/ClientHealthMetricsStore;)V", "")]
		public unsafe Uploader(Context context, IBackendRegistry backendRegistry, IEventStore eventStore, IWorkScheduler workScheduler, IExecutor executor, ISynchronizationGuard guard, IClock clock, IClock uptimeClock, IClientHealthMetricsStore clientHealthMetricsStore) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((backendRegistry == null) ? IntPtr.Zero : ((Java.Lang.Object)backendRegistry).Handle);
				ptr[2] = new JniArgumentValue((eventStore == null) ? IntPtr.Zero : ((Java.Lang.Object)eventStore).Handle);
				ptr[3] = new JniArgumentValue((workScheduler == null) ? IntPtr.Zero : ((Java.Lang.Object)workScheduler).Handle);
				ptr[4] = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				ptr[5] = new JniArgumentValue((guard == null) ? IntPtr.Zero : ((Java.Lang.Object)guard).Handle);
				ptr[6] = new JniArgumentValue((clock == null) ? IntPtr.Zero : ((Java.Lang.Object)clock).Handle);
				ptr[7] = new JniArgumentValue((uptimeClock == null) ? IntPtr.Zero : ((Java.Lang.Object)uptimeClock).Handle);
				ptr[8] = new JniArgumentValue((clientHealthMetricsStore == null) ? IntPtr.Zero : ((Java.Lang.Object)clientHealthMetricsStore).Handle);
				base.SetHandle(Uploader._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/google/android/datatransport/runtime/backends/BackendRegistry;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;Ljava/util/concurrent/Executor;Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/scheduling/persistence/ClientHealthMetricsStore;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Uploader._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/google/android/datatransport/runtime/backends/BackendRegistry;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;Ljava/util/concurrent/Executor;Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/scheduling/persistence/ClientHealthMetricsStore;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(backendRegistry);
				GC.KeepAlive(eventStore);
				GC.KeepAlive(workScheduler);
				GC.KeepAlive(executor);
				GC.KeepAlive(guard);
				GC.KeepAlive(clock);
				GC.KeepAlive(uptimeClock);
				GC.KeepAlive(clientHealthMetricsStore);
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000097B4 File Offset: 0x000079B4
		private static Delegate GetCreateMetricsEvent_Lcom_google_android_datatransport_runtime_backends_TransportBackend_Handler()
		{
			if (Uploader.cb_createMetricsEvent_Lcom_google_android_datatransport_runtime_backends_TransportBackend_ == null)
			{
				Uploader.cb_createMetricsEvent_Lcom_google_android_datatransport_runtime_backends_TransportBackend_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Uploader.n_CreateMetricsEvent_Lcom_google_android_datatransport_runtime_backends_TransportBackend_));
			}
			return Uploader.cb_createMetricsEvent_Lcom_google_android_datatransport_runtime_backends_TransportBackend_;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000097D8 File Offset: 0x000079D8
		private static IntPtr n_CreateMetricsEvent_Lcom_google_android_datatransport_runtime_backends_TransportBackend_(IntPtr jnienv, IntPtr native__this, IntPtr native_backend)
		{
			Uploader @object = Java.Lang.Object.GetObject<Uploader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ITransportBackend object2 = Java.Lang.Object.GetObject<ITransportBackend>(native_backend, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateMetricsEvent(object2));
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00009800 File Offset: 0x00007A00
		[Register("createMetricsEvent", "(Lcom/google/android/datatransport/runtime/backends/TransportBackend;)Lcom/google/android/datatransport/runtime/EventInternal;", "GetCreateMetricsEvent_Lcom_google_android_datatransport_runtime_backends_TransportBackend_Handler")]
		public unsafe virtual EventInternal CreateMetricsEvent(ITransportBackend backend)
		{
			EventInternal @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((backend == null) ? IntPtr.Zero : ((Java.Lang.Object)backend).Handle);
				@object = Java.Lang.Object.GetObject<EventInternal>(Uploader._members.InstanceMethods.InvokeVirtualObjectMethod("createMetricsEvent.(Lcom/google/android/datatransport/runtime/backends/TransportBackend;)Lcom/google/android/datatransport/runtime/EventInternal;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(backend);
			}
			return @object;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00009878 File Offset: 0x00007A78
		private static Delegate GetLogAndUpdateState_Lcom_google_android_datatransport_runtime_TransportContext_IHandler()
		{
			if (Uploader.cb_logAndUpdateState_Lcom_google_android_datatransport_runtime_TransportContext_I == null)
			{
				Uploader.cb_logAndUpdateState_Lcom_google_android_datatransport_runtime_TransportContext_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(Uploader.n_LogAndUpdateState_Lcom_google_android_datatransport_runtime_TransportContext_I));
			}
			return Uploader.cb_logAndUpdateState_Lcom_google_android_datatransport_runtime_TransportContext_I;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000989C File Offset: 0x00007A9C
		private static IntPtr n_LogAndUpdateState_Lcom_google_android_datatransport_runtime_TransportContext_I(IntPtr jnienv, IntPtr native__this, IntPtr native_transportContext, int attemptNumber)
		{
			Uploader @object = Java.Lang.Object.GetObject<Uploader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_transportContext, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.LogAndUpdateState(object2, attemptNumber));
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000098C8 File Offset: 0x00007AC8
		[Register("logAndUpdateState", "(Lcom/google/android/datatransport/runtime/TransportContext;I)Lcom/google/android/datatransport/runtime/backends/BackendResponse;", "GetLogAndUpdateState_Lcom_google_android_datatransport_runtime_TransportContext_IHandler")]
		public unsafe virtual BackendResponse LogAndUpdateState(TransportContext transportContext, int attemptNumber)
		{
			BackendResponse @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transportContext == null) ? IntPtr.Zero : transportContext.Handle);
				ptr[1] = new JniArgumentValue(attemptNumber);
				@object = Java.Lang.Object.GetObject<BackendResponse>(Uploader._members.InstanceMethods.InvokeVirtualObjectMethod("logAndUpdateState.(Lcom/google/android/datatransport/runtime/TransportContext;I)Lcom/google/android/datatransport/runtime/backends/BackendResponse;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(transportContext);
			}
			return @object;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00009950 File Offset: 0x00007B50
		private static Delegate GetUpload_Lcom_google_android_datatransport_runtime_TransportContext_ILjava_lang_Runnable_Handler()
		{
			if (Uploader.cb_upload_Lcom_google_android_datatransport_runtime_TransportContext_ILjava_lang_Runnable_ == null)
			{
				Uploader.cb_upload_Lcom_google_android_datatransport_runtime_TransportContext_ILjava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_V(Uploader.n_Upload_Lcom_google_android_datatransport_runtime_TransportContext_ILjava_lang_Runnable_));
			}
			return Uploader.cb_upload_Lcom_google_android_datatransport_runtime_TransportContext_ILjava_lang_Runnable_;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00009974 File Offset: 0x00007B74
		private static void n_Upload_Lcom_google_android_datatransport_runtime_TransportContext_ILjava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_transportContext, int attemptNumber, IntPtr native__callback)
		{
			Uploader @object = Java.Lang.Object.GetObject<Uploader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_transportContext, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.Upload(object2, attemptNumber, object3);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000099A4 File Offset: 0x00007BA4
		[Register("upload", "(Lcom/google/android/datatransport/runtime/TransportContext;ILjava/lang/Runnable;)V", "GetUpload_Lcom_google_android_datatransport_runtime_TransportContext_ILjava_lang_Runnable_Handler")]
		public unsafe virtual void Upload(TransportContext transportContext, int attemptNumber, IRunnable callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transportContext == null) ? IntPtr.Zero : transportContext.Handle);
				ptr[1] = new JniArgumentValue(attemptNumber);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				Uploader._members.InstanceMethods.InvokeVirtualVoidMethod("upload.(Lcom/google/android/datatransport/runtime/TransportContext;ILjava/lang/Runnable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(transportContext);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x040000AD RID: 173
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader", typeof(Uploader));

		// Token: 0x040000AE RID: 174
		private static Delegate cb_createMetricsEvent_Lcom_google_android_datatransport_runtime_backends_TransportBackend_;

		// Token: 0x040000AF RID: 175
		private static Delegate cb_logAndUpdateState_Lcom_google_android_datatransport_runtime_TransportContext_I;

		// Token: 0x040000B0 RID: 176
		private static Delegate cb_upload_Lcom_google_android_datatransport_runtime_TransportContext_ILjava_lang_Runnable_;
	}
}
