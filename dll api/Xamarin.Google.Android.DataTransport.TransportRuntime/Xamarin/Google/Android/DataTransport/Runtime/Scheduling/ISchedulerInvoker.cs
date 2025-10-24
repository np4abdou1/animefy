using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling
{
	// Token: 0x02000048 RID: 72
	[Register("com/google/android/datatransport/runtime/scheduling/Scheduler", DoNotGenerateAcw = true)]
	internal class ISchedulerInvoker : Java.Lang.Object, IScheduler, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00006F48 File Offset: 0x00005148
		private static IntPtr java_class_ref
		{
			get
			{
				return ISchedulerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00006F6C File Offset: 0x0000516C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISchedulerInvoker._members;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00006F73 File Offset: 0x00005173
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00006F7B File Offset: 0x0000517B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISchedulerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00006F87 File Offset: 0x00005187
		public static IScheduler GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IScheduler>(handle, transfer);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00006F90 File Offset: 0x00005190
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISchedulerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.scheduling.Scheduler'.");
			}
			return handle;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00006FBB File Offset: 0x000051BB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00006FEC File Offset: 0x000051EC
		public ISchedulerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISchedulerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00007024 File Offset: 0x00005224
		private static Delegate GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_Handler()
		{
			if (ISchedulerInvoker.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_ == null)
			{
				ISchedulerInvoker.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ISchedulerInvoker.n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_));
			}
			return ISchedulerInvoker.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00007048 File Offset: 0x00005248
		private static void n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IScheduler @object = Java.Lang.Object.GetObject<IScheduler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_p0, JniHandleOwnership.DoNotTransfer);
			EventInternal object3 = Java.Lang.Object.GetObject<EventInternal>(native_p1, JniHandleOwnership.DoNotTransfer);
			ITransportScheduleCallback object4 = Java.Lang.Object.GetObject<ITransportScheduleCallback>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.Schedule(object2, object3, object4);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00007080 File Offset: 0x00005280
		public unsafe void Schedule(TransportContext p0, EventInternal p1, ITransportScheduleCallback p2)
		{
			if (this.id_schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_ == IntPtr.Zero)
			{
				this.id_schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_ = JNIEnv.GetMethodID(this.class_ref, "schedule", "(Lcom/google/android/datatransport/runtime/TransportContext;Lcom/google/android/datatransport/runtime/EventInternal;Lcom/google/android/datatransport/TransportScheduleCallback;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_, ptr);
		}

		// Token: 0x04000080 RID: 128
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/Scheduler", typeof(ISchedulerInvoker));

		// Token: 0x04000081 RID: 129
		private IntPtr class_ref;

		// Token: 0x04000082 RID: 130
		private static Delegate cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_;

		// Token: 0x04000083 RID: 131
		private IntPtr id_schedule_Lcom_google_android_datatransport_runtime_TransportContext_Lcom_google_android_datatransport_runtime_EventInternal_Lcom_google_android_datatransport_TransportScheduleCallback_;
	}
}
