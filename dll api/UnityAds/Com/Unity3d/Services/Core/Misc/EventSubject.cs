using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Timer;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Com.Unity3d.Services.Core.Misc
{
	// Token: 0x020000D6 RID: 214
	[Register("com/unity3d/services/core/misc/EventSubject", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public class EventSubject : Java.Lang.Object
	{
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00018690 File Offset: 0x00016890
		internal static IntPtr class_ref
		{
			get
			{
				return EventSubject._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x000186B4 File Offset: 0x000168B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EventSubject._members;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x000186BC File Offset: 0x000168BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EventSubject._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x000186E0 File Offset: 0x000168E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EventSubject._members.ManagedPeerType;
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x000021E8 File Offset: 0x000003E8
		protected EventSubject(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000186EC File Offset: 0x000168EC
		[Register(".ctor", "(Ljava/util/Queue;Ljava/lang/Integer;Lcom/unity3d/services/core/timer/IIntervalTimerFactory;)V", "")]
		public unsafe EventSubject(IQueue eventQueue, Integer durationMs, IIntervalTimerFactory timerFactory) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((eventQueue == null) ? IntPtr.Zero : ((Java.Lang.Object)eventQueue).Handle);
				ptr[1] = new JniArgumentValue((durationMs == null) ? IntPtr.Zero : durationMs.Handle);
				ptr[2] = new JniArgumentValue((timerFactory == null) ? IntPtr.Zero : ((Java.Lang.Object)timerFactory).Handle);
				base.SetHandle(EventSubject._members.InstanceMethods.StartCreateInstance("(Ljava/util/Queue;Ljava/lang/Integer;Lcom/unity3d/services/core/timer/IIntervalTimerFactory;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				EventSubject._members.InstanceMethods.FinishCreateInstance("(Ljava/util/Queue;Ljava/lang/Integer;Lcom/unity3d/services/core/timer/IIntervalTimerFactory;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(eventQueue);
				GC.KeepAlive(durationMs);
				GC.KeepAlive(timerFactory);
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x000187F8 File Offset: 0x000169F8
		private static Delegate GetEventQueueIsEmptyHandler()
		{
			if (EventSubject.cb_eventQueueIsEmpty == null)
			{
				EventSubject.cb_eventQueueIsEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(EventSubject.n_EventQueueIsEmpty));
			}
			return EventSubject.cb_eventQueueIsEmpty;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0001881C File Offset: 0x00016A1C
		private static bool n_EventQueueIsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<EventSubject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EventQueueIsEmpty();
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0001882B File Offset: 0x00016A2B
		[Register("eventQueueIsEmpty", "()Z", "GetEventQueueIsEmptyHandler")]
		public virtual bool EventQueueIsEmpty()
		{
			return EventSubject._members.InstanceMethods.InvokeVirtualBooleanMethod("eventQueueIsEmpty.()Z", this, null);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00018844 File Offset: 0x00016A44
		private static Delegate GetSendNextEventHandler()
		{
			if (EventSubject.cb_sendNextEvent == null)
			{
				EventSubject.cb_sendNextEvent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(EventSubject.n_SendNextEvent));
			}
			return EventSubject.cb_sendNextEvent;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00018868 File Offset: 0x00016A68
		private static void n_SendNextEvent(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<EventSubject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SendNextEvent();
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00018877 File Offset: 0x00016A77
		[Register("sendNextEvent", "()V", "GetSendNextEventHandler")]
		public virtual void SendNextEvent()
		{
			EventSubject._members.InstanceMethods.InvokeVirtualVoidMethod("sendNextEvent.()V", this, null);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00018890 File Offset: 0x00016A90
		private static Delegate GetSubscribe_Lcom_unity3d_services_core_misc_IEventListener_Handler()
		{
			if (EventSubject.cb_subscribe_Lcom_unity3d_services_core_misc_IEventListener_ == null)
			{
				EventSubject.cb_subscribe_Lcom_unity3d_services_core_misc_IEventListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(EventSubject.n_Subscribe_Lcom_unity3d_services_core_misc_IEventListener_));
			}
			return EventSubject.cb_subscribe_Lcom_unity3d_services_core_misc_IEventListener_;
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000188B4 File Offset: 0x00016AB4
		private static void n_Subscribe_Lcom_unity3d_services_core_misc_IEventListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_eventListener)
		{
			EventSubject @object = Java.Lang.Object.GetObject<EventSubject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IEventListener object2 = Java.Lang.Object.GetObject<IEventListener>(native_eventListener, JniHandleOwnership.DoNotTransfer);
			@object.Subscribe(object2);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000188D8 File Offset: 0x00016AD8
		[Register("subscribe", "(Lcom/unity3d/services/core/misc/IEventListener;)V", "GetSubscribe_Lcom_unity3d_services_core_misc_IEventListener_Handler")]
		public unsafe virtual void Subscribe(IEventListener eventListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((eventListener == null) ? IntPtr.Zero : ((Java.Lang.Object)eventListener).Handle);
				EventSubject._members.InstanceMethods.InvokeVirtualVoidMethod("subscribe.(Lcom/unity3d/services/core/misc/IEventListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(eventListener);
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00018940 File Offset: 0x00016B40
		private static Delegate GetUnsubscribeHandler()
		{
			if (EventSubject.cb_unsubscribe == null)
			{
				EventSubject.cb_unsubscribe = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(EventSubject.n_Unsubscribe));
			}
			return EventSubject.cb_unsubscribe;
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00018964 File Offset: 0x00016B64
		private static void n_Unsubscribe(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<EventSubject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Unsubscribe();
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00018973 File Offset: 0x00016B73
		[Register("unsubscribe", "()V", "GetUnsubscribeHandler")]
		public virtual void Unsubscribe()
		{
			EventSubject._members.InstanceMethods.InvokeVirtualVoidMethod("unsubscribe.()V", this, null);
		}

		// Token: 0x040001F7 RID: 503
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/misc/EventSubject", typeof(EventSubject));

		// Token: 0x040001F8 RID: 504
		private static Delegate cb_eventQueueIsEmpty;

		// Token: 0x040001F9 RID: 505
		private static Delegate cb_sendNextEvent;

		// Token: 0x040001FA RID: 506
		private static Delegate cb_subscribe_Lcom_unity3d_services_core_misc_IEventListener_;

		// Token: 0x040001FB RID: 507
		private static Delegate cb_unsubscribe;
	}
}
