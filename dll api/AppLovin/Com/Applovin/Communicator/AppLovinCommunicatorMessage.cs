using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Com.Applovin.Impl.Communicator;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Communicator
{
	// Token: 0x02000173 RID: 371
	[Register("com/applovin/communicator/AppLovinCommunicatorMessage", DoNotGenerateAcw = true)]
	public class AppLovinCommunicatorMessage : CommunicatorMessageImpl
	{
		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x000337A8 File Offset: 0x000319A8
		internal new static IntPtr class_ref
		{
			get
			{
				return AppLovinCommunicatorMessage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x000337CC File Offset: 0x000319CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinCommunicatorMessage._members;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x000337D4 File Offset: 0x000319D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinCommunicatorMessage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x000337F8 File Offset: 0x000319F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinCommunicatorMessage._members.ManagedPeerType;
			}
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00031E4B File Offset: 0x0003004B
		protected AppLovinCommunicatorMessage(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00033804 File Offset: 0x00031A04
		[Register(".ctor", "(Landroid/os/Bundle;Ljava/lang/String;Lcom/applovin/communicator/AppLovinCommunicatorPublisher;)V", "")]
		public unsafe AppLovinCommunicatorMessage(Bundle p0, string p1, IAppLovinCommunicatorPublisher p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				base.SetHandle(AppLovinCommunicatorMessage._members.InstanceMethods.StartCreateInstance("(Landroid/os/Bundle;Ljava/lang/String;Lcom/applovin/communicator/AppLovinCommunicatorPublisher;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinCommunicatorMessage._members.InstanceMethods.FinishCreateInstance("(Landroid/os/Bundle;Ljava/lang/String;Lcom/applovin/communicator/AppLovinCommunicatorPublisher;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00033900 File Offset: 0x00031B00
		[Register(".ctor", "(Landroid/os/Bundle;Ljava/lang/String;Lcom/applovin/communicator/AppLovinCommunicatorPublisher;Z)V", "")]
		public unsafe AppLovinCommunicatorMessage(Bundle p0, string p1, IAppLovinCommunicatorPublisher p2, bool p3) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				ptr[3] = new JniArgumentValue(p3);
				base.SetHandle(AppLovinCommunicatorMessage._members.InstanceMethods.StartCreateInstance("(Landroid/os/Bundle;Ljava/lang/String;Lcom/applovin/communicator/AppLovinCommunicatorPublisher;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinCommunicatorMessage._members.InstanceMethods.FinishCreateInstance("(Landroid/os/Bundle;Ljava/lang/String;Lcom/applovin/communicator/AppLovinCommunicatorPublisher;Z)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00033A14 File Offset: 0x00031C14
		private static Delegate GetGetMessageDataHandler()
		{
			if (AppLovinCommunicatorMessage.cb_getMessageData == null)
			{
				AppLovinCommunicatorMessage.cb_getMessageData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinCommunicatorMessage.n_GetMessageData));
			}
			return AppLovinCommunicatorMessage.cb_getMessageData;
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00033A38 File Offset: 0x00031C38
		private static IntPtr n_GetMessageData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinCommunicatorMessage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MessageData);
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x00033A4C File Offset: 0x00031C4C
		public override Bundle MessageData
		{
			[Register("getMessageData", "()Landroid/os/Bundle;", "GetGetMessageDataHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Bundle>(AppLovinCommunicatorMessage._members.InstanceMethods.InvokeVirtualObjectMethod("getMessageData.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00033A7E File Offset: 0x00031C7E
		private static Delegate GetGetPublisherIdHandler()
		{
			if (AppLovinCommunicatorMessage.cb_getPublisherId == null)
			{
				AppLovinCommunicatorMessage.cb_getPublisherId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinCommunicatorMessage.n_GetPublisherId));
			}
			return AppLovinCommunicatorMessage.cb_getPublisherId;
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x00033AA2 File Offset: 0x00031CA2
		private static IntPtr n_GetPublisherId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinCommunicatorMessage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PublisherId);
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x00033AB8 File Offset: 0x00031CB8
		public override string PublisherId
		{
			[Register("getPublisherId", "()Ljava/lang/String;", "GetGetPublisherIdHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinCommunicatorMessage._members.InstanceMethods.InvokeVirtualObjectMethod("getPublisherId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00033AEA File Offset: 0x00031CEA
		private static Delegate GetGetTopicHandler()
		{
			if (AppLovinCommunicatorMessage.cb_getTopic == null)
			{
				AppLovinCommunicatorMessage.cb_getTopic = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinCommunicatorMessage.n_GetTopic));
			}
			return AppLovinCommunicatorMessage.cb_getTopic;
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00033B0E File Offset: 0x00031D0E
		private static IntPtr n_GetTopic(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinCommunicatorMessage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Topic);
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x00033B24 File Offset: 0x00031D24
		public override string Topic
		{
			[Register("getTopic", "()Ljava/lang/String;", "GetGetTopicHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinCommunicatorMessage._members.InstanceMethods.InvokeVirtualObjectMethod("getTopic.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040005D6 RID: 1494
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/communicator/AppLovinCommunicatorMessage", typeof(AppLovinCommunicatorMessage));

		// Token: 0x040005D7 RID: 1495
		private static Delegate cb_getMessageData;

		// Token: 0x040005D8 RID: 1496
		private static Delegate cb_getPublisherId;

		// Token: 0x040005D9 RID: 1497
		private static Delegate cb_getTopic;
	}
}
