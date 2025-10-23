using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling
{
	// Token: 0x02000052 RID: 82
	[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler", DoNotGenerateAcw = true)]
	internal class IWorkSchedulerInvoker : Java.Lang.Object, IWorkScheduler, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00007EF4 File Offset: 0x000060F4
		private static IntPtr java_class_ref
		{
			get
			{
				return IWorkSchedulerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00007F18 File Offset: 0x00006118
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWorkSchedulerInvoker._members;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00007F1F File Offset: 0x0000611F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00007F27 File Offset: 0x00006127
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWorkSchedulerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00007F33 File Offset: 0x00006133
		public static IWorkScheduler GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IWorkScheduler>(handle, transfer);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00007F3C File Offset: 0x0000613C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWorkSchedulerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler'.");
			}
			return handle;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00007F67 File Offset: 0x00006167
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00007F98 File Offset: 0x00006198
		public IWorkSchedulerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWorkSchedulerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00007FD0 File Offset: 0x000061D0
		private static Delegate GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_IHandler()
		{
			if (IWorkSchedulerInvoker.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I == null)
			{
				IWorkSchedulerInvoker.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(IWorkSchedulerInvoker.n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_I));
			}
			return IWorkSchedulerInvoker.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00007FF4 File Offset: 0x000061F4
		private static void n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			IWorkScheduler @object = Java.Lang.Object.GetObject<IWorkScheduler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Schedule(object2, p1);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00008018 File Offset: 0x00006218
		public unsafe void Schedule(TransportContext p0, int p1)
		{
			if (this.id_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I == IntPtr.Zero)
			{
				this.id_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I = JNIEnv.GetMethodID(this.class_ref, "schedule", "(Lcom/google/android/datatransport/runtime/TransportContext;I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(p1);
			JNIEnv.CallVoidMethod(base.Handle, this.id_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I, ptr);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000809E File Offset: 0x0000629E
		private static Delegate GetSchedule_Lcom_google_android_datatransport_runtime_TransportContext_IZHandler()
		{
			if (IWorkSchedulerInvoker.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ == null)
			{
				IWorkSchedulerInvoker.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIZ_V(IWorkSchedulerInvoker.n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ));
			}
			return IWorkSchedulerInvoker.cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000080C4 File Offset: 0x000062C4
		private static void n_Schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			IWorkScheduler @object = Java.Lang.Object.GetObject<IWorkScheduler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TransportContext object2 = Java.Lang.Object.GetObject<TransportContext>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Schedule(object2, p1, p2);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000080EC File Offset: 0x000062EC
		public unsafe void Schedule(TransportContext p0, int p1, bool p2)
		{
			if (this.id_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ == IntPtr.Zero)
			{
				this.id_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ = JNIEnv.GetMethodID(this.class_ref, "schedule", "(Lcom/google/android/datatransport/runtime/TransportContext;IZ)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(p1);
			ptr[2] = new JValue(p2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ, ptr);
		}

		// Token: 0x0400008F RID: 143
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler", typeof(IWorkSchedulerInvoker));

		// Token: 0x04000090 RID: 144
		private IntPtr class_ref;

		// Token: 0x04000091 RID: 145
		private static Delegate cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I;

		// Token: 0x04000092 RID: 146
		private IntPtr id_schedule_Lcom_google_android_datatransport_runtime_TransportContext_I;

		// Token: 0x04000093 RID: 147
		private static Delegate cb_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ;

		// Token: 0x04000094 RID: 148
		private IntPtr id_schedule_Lcom_google_android_datatransport_runtime_TransportContext_IZ;
	}
}
