using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Xamarin.Google.Android.DataTransport.Runtime.Persistence;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling
{
	// Token: 0x02000053 RID: 83
	[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/JobInfoScheduler", DoNotGenerateAcw = true)]
	public class JobInfoScheduler : Java.Lang.Object, IWorkScheduler, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000296 RID: 662 RVA: 0x000081A4 File Offset: 0x000063A4
		internal static IntPtr class_ref
		{
			get
			{
				return JobInfoScheduler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000297 RID: 663 RVA: 0x000081C8 File Offset: 0x000063C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JobInfoScheduler._members;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000298 RID: 664 RVA: 0x000081D0 File Offset: 0x000063D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JobInfoScheduler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000299 RID: 665 RVA: 0x000081F4 File Offset: 0x000063F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JobInfoScheduler._members.ManagedPeerType;
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000026C4 File Offset: 0x000008C4
		protected JobInfoScheduler(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00008200 File Offset: 0x00006400
		[Register(".ctor", "(Landroid/content/Context;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;)V", "")]
		public unsafe JobInfoScheduler(Context applicationContext, IEventStore eventStore, SchedulerConfig config) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((applicationContext == null) ? IntPtr.Zero : applicationContext.Handle);
				ptr[1] = new JniArgumentValue((eventStore == null) ? IntPtr.Zero : ((Java.Lang.Object)eventStore).Handle);
				ptr[2] = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				base.SetHandle(JobInfoScheduler._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				JobInfoScheduler._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(applicationContext);
				GC.KeepAlive(eventStore);
				GC.KeepAlive(config);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00008308 File Offset: 0x00006508
		private static Delegate GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_IHandler()
		{
			if (JobInfoScheduler.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I == null)
			{
				JobInfoScheduler.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(JobInfoScheduler.n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_I));
			}
			return JobInfoScheduler.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000832C File Offset: 0x0000652C
		private static void n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_I(IntPtr jnienv, IntPtr native__this, IntPtr native_transportContext, int attemptNumber)
		{
			JobInfoScheduler @object = Java.Lang.Object.GetObject<JobInfoScheduler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_transportContext, JniHandleOwnership.DoNotTransfer);
			@object.Schedule(object2, attemptNumber);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00008350 File Offset: 0x00006550
		[Register("schedule", "(Lcom/google/android/datatransport/runtime/TransportContext;I)V", "GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_IHandler")]
		public unsafe virtual void Schedule(TransportContext transportContext, int attemptNumber)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transportContext == null) ? IntPtr.Zero : transportContext.Handle);
				ptr[1] = new JniArgumentValue(attemptNumber);
				JobInfoScheduler._members.InstanceMethods.InvokeVirtualVoidMethod("schedule.(Lcom/google/android/datatransport/runtime/TransportContext;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(transportContext);
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000083C8 File Offset: 0x000065C8
		private static Delegate GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_IZHandler()
		{
			if (JobInfoScheduler.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ == null)
			{
				JobInfoScheduler.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIZ_V(JobInfoScheduler.n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ));
			}
			return JobInfoScheduler.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000083EC File Offset: 0x000065EC
		private static void n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ(IntPtr jnienv, IntPtr native__this, IntPtr native_transportContext, int attemptNumber, bool force)
		{
			JobInfoScheduler @object = Java.Lang.Object.GetObject<JobInfoScheduler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_transportContext, JniHandleOwnership.DoNotTransfer);
			@object.Schedule(object2, attemptNumber, force);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00008414 File Offset: 0x00006614
		[Register("schedule", "(Lcom/google/android/datatransport/runtime/TransportContext;IZ)V", "GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_IZHandler")]
		public unsafe virtual void Schedule(TransportContext transportContext, int attemptNumber, bool force)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transportContext == null) ? IntPtr.Zero : transportContext.Handle);
				ptr[1] = new JniArgumentValue(attemptNumber);
				ptr[2] = new JniArgumentValue(force);
				JobInfoScheduler._members.InstanceMethods.InvokeVirtualVoidMethod("schedule.(Lcom/google/android/datatransport/runtime/TransportContext;IZ)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(transportContext);
			}
		}

		// Token: 0x04000095 RID: 149
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/JobInfoScheduler", typeof(JobInfoScheduler));

		// Token: 0x04000096 RID: 150
		private static Delegate cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I;

		// Token: 0x04000097 RID: 151
		private static Delegate cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ;
	}
}
