using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Xamarin.Google.Android.DataTransport.Runtime.Persistence;
using Xamarin.Google.Android.DataTransport.Runtime.Time;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling
{
	// Token: 0x0200004F RID: 79
	[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/AlarmManagerScheduler", DoNotGenerateAcw = true)]
	public class AlarmManagerScheduler : Java.Lang.Object, IWorkScheduler, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600026E RID: 622 RVA: 0x000079DC File Offset: 0x00005BDC
		internal static IntPtr class_ref
		{
			get
			{
				return AlarmManagerScheduler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00007A00 File Offset: 0x00005C00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AlarmManagerScheduler._members;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00007A08 File Offset: 0x00005C08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AlarmManagerScheduler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00007A2C File Offset: 0x00005C2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AlarmManagerScheduler._members.ManagedPeerType;
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000026C4 File Offset: 0x000008C4
		protected AlarmManagerScheduler(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00007A38 File Offset: 0x00005C38
		[Register(".ctor", "(Landroid/content/Context;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;)V", "")]
		public unsafe AlarmManagerScheduler(Context applicationContext, IEventStore eventStore, IClock clock, SchedulerConfig config) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((applicationContext == null) ? IntPtr.Zero : applicationContext.Handle);
				ptr[1] = new JniArgumentValue((eventStore == null) ? IntPtr.Zero : ((Java.Lang.Object)eventStore).Handle);
				ptr[2] = new JniArgumentValue((clock == null) ? IntPtr.Zero : ((Java.Lang.Object)clock).Handle);
				ptr[3] = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				base.SetHandle(AlarmManagerScheduler._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AlarmManagerScheduler._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(applicationContext);
				GC.KeepAlive(eventStore);
				GC.KeepAlive(clock);
				GC.KeepAlive(config);
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00007B70 File Offset: 0x00005D70
		private static Delegate GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_IHandler()
		{
			if (AlarmManagerScheduler.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I == null)
			{
				AlarmManagerScheduler.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(AlarmManagerScheduler.n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_I));
			}
			return AlarmManagerScheduler.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00007B94 File Offset: 0x00005D94
		private static void n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_I(IntPtr jnienv, IntPtr native__this, IntPtr native_transportContext, int attemptNumber)
		{
			AlarmManagerScheduler @object = Java.Lang.Object.GetObject<AlarmManagerScheduler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_transportContext, JniHandleOwnership.DoNotTransfer);
			@object.Schedule(object2, attemptNumber);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00007BB8 File Offset: 0x00005DB8
		[Register("schedule", "(Lcom/google/android/datatransport/runtime/TransportContext;I)V", "GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_IHandler")]
		public unsafe virtual void Schedule(TransportContext transportContext, int attemptNumber)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transportContext == null) ? IntPtr.Zero : transportContext.Handle);
				ptr[1] = new JniArgumentValue(attemptNumber);
				AlarmManagerScheduler._members.InstanceMethods.InvokeVirtualVoidMethod("schedule.(Lcom/google/android/datatransport/runtime/TransportContext;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(transportContext);
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00007C30 File Offset: 0x00005E30
		private static Delegate GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_IZHandler()
		{
			if (AlarmManagerScheduler.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ == null)
			{
				AlarmManagerScheduler.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIZ_V(AlarmManagerScheduler.n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ));
			}
			return AlarmManagerScheduler.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00007C54 File Offset: 0x00005E54
		private static void n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ(IntPtr jnienv, IntPtr native__this, IntPtr native_transportContext, int attemptNumber, bool force)
		{
			AlarmManagerScheduler @object = Java.Lang.Object.GetObject<AlarmManagerScheduler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_transportContext, JniHandleOwnership.DoNotTransfer);
			@object.Schedule(object2, attemptNumber, force);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00007C7C File Offset: 0x00005E7C
		[Register("schedule", "(Lcom/google/android/datatransport/runtime/TransportContext;IZ)V", "GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_IZHandler")]
		public unsafe virtual void Schedule(TransportContext transportContext, int attemptNumber, bool force)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transportContext == null) ? IntPtr.Zero : transportContext.Handle);
				ptr[1] = new JniArgumentValue(attemptNumber);
				ptr[2] = new JniArgumentValue(force);
				AlarmManagerScheduler._members.InstanceMethods.InvokeVirtualVoidMethod("schedule.(Lcom/google/android/datatransport/runtime/TransportContext;IZ)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(transportContext);
			}
		}

		// Token: 0x0400008A RID: 138
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/AlarmManagerScheduler", typeof(AlarmManagerScheduler));

		// Token: 0x0400008B RID: 139
		private static Delegate cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I;

		// Token: 0x0400008C RID: 140
		private static Delegate cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ;
	}
}
