using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport
{
	// Token: 0x02000010 RID: 16
	[Register("com/google/android/datatransport/Transport", DoNotGenerateAcw = true)]
	internal class ITransportInvoker : Java.Lang.Object, ITransport, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002960 File Offset: 0x00000B60
		private static IntPtr java_class_ref
		{
			get
			{
				return ITransportInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002984 File Offset: 0x00000B84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITransportInvoker._members;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000298B File Offset: 0x00000B8B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002993 File Offset: 0x00000B93
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITransportInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000299F File Offset: 0x00000B9F
		public static ITransport GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITransport>(handle, transfer);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000029A8 File Offset: 0x00000BA8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITransportInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.Transport'.");
			}
			return handle;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000029D3 File Offset: 0x00000BD3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002A04 File Offset: 0x00000C04
		public ITransportInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITransportInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002A3C File Offset: 0x00000C3C
		private static Delegate GetSchedule_Lcom_google_android_datatransport_Event_Lcom_google_android_datatransport_TransportScheduleCallback_Handler()
		{
			if (ITransportInvoker.cb_schedule_Lcom_google_android_datatransport_Event_Lcom_google_android_datatransport_TransportScheduleCallback_ == null)
			{
				ITransportInvoker.cb_schedule_Lcom_google_android_datatransport_Event_Lcom_google_android_datatransport_TransportScheduleCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ITransportInvoker.n_Schedule_Lcom_google_android_datatransport_Event_Lcom_google_android_datatransport_TransportScheduleCallback_));
			}
			return ITransportInvoker.cb_schedule_Lcom_google_android_datatransport_Event_Lcom_google_android_datatransport_TransportScheduleCallback_;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002A60 File Offset: 0x00000C60
		private static void n_Schedule_Lcom_google_android_datatransport_Event_Lcom_google_android_datatransport_TransportScheduleCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			ITransport @object = Java.Lang.Object.GetObject<ITransport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Event object2 = Java.Lang.Object.GetObject<Event>(native_p0, JniHandleOwnership.DoNotTransfer);
			ITransportScheduleCallback object3 = Java.Lang.Object.GetObject<ITransportScheduleCallback>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Schedule(object2, object3);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002A8C File Offset: 0x00000C8C
		public unsafe void Schedule(Event p0, ITransportScheduleCallback p1)
		{
			if (this.id_schedule_Lcom_google_android_datatransport_Event_Lcom_google_android_datatransport_TransportScheduleCallback_ == IntPtr.Zero)
			{
				this.id_schedule_Lcom_google_android_datatransport_Event_Lcom_google_android_datatransport_TransportScheduleCallback_ = JNIEnv.GetMethodID(this.class_ref, "schedule", "(Lcom/google/android/datatransport/Event;Lcom/google/android/datatransport/TransportScheduleCallback;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_schedule_Lcom_google_android_datatransport_Event_Lcom_google_android_datatransport_TransportScheduleCallback_, ptr);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002B26 File Offset: 0x00000D26
		private static Delegate GetSend_Lcom_google_android_datatransport_Event_Handler()
		{
			if (ITransportInvoker.cb_send_Lcom_google_android_datatransport_Event_ == null)
			{
				ITransportInvoker.cb_send_Lcom_google_android_datatransport_Event_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITransportInvoker.n_Send_Lcom_google_android_datatransport_Event_));
			}
			return ITransportInvoker.cb_send_Lcom_google_android_datatransport_Event_;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002B4C File Offset: 0x00000D4C
		private static void n_Send_Lcom_google_android_datatransport_Event_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITransport @object = Java.Lang.Object.GetObject<ITransport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Event object2 = Java.Lang.Object.GetObject<Event>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Send(object2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002B70 File Offset: 0x00000D70
		public unsafe void Send(Event p0)
		{
			if (this.id_send_Lcom_google_android_datatransport_Event_ == IntPtr.Zero)
			{
				this.id_send_Lcom_google_android_datatransport_Event_ = JNIEnv.GetMethodID(this.class_ref, "send", "(Lcom/google/android/datatransport/Event;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_send_Lcom_google_android_datatransport_Event_, ptr);
		}

		// Token: 0x04000012 RID: 18
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/Transport", typeof(ITransportInvoker));

		// Token: 0x04000013 RID: 19
		private IntPtr class_ref;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_schedule_Lcom_google_android_datatransport_Event_Lcom_google_android_datatransport_TransportScheduleCallback_;

		// Token: 0x04000015 RID: 21
		private IntPtr id_schedule_Lcom_google_android_datatransport_Event_Lcom_google_android_datatransport_TransportScheduleCallback_;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_send_Lcom_google_android_datatransport_Event_;

		// Token: 0x04000017 RID: 23
		private IntPtr id_send_Lcom_google_android_datatransport_Event_;
	}
}
