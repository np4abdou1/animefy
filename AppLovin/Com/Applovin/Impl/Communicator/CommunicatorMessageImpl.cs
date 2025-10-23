using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Com.Applovin.Communicator;
using Java.Interop;
using Java.Lang;
using Java.Lang.Ref;

namespace Com.Applovin.Impl.Communicator
{
	// Token: 0x0200015C RID: 348
	[Register("com/applovin/impl/communicator/CommunicatorMessageImpl", DoNotGenerateAcw = true)]
	public abstract class CommunicatorMessageImpl : Intent
	{
		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x00031A88 File Offset: 0x0002FC88
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x00031AB8 File Offset: 0x0002FCB8
		[Register("publisherRef")]
		protected Java.Lang.Ref.WeakReference PublisherRef
		{
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Ref.WeakReference>(CommunicatorMessageImpl._members.InstanceFields.GetObjectValue("publisherRef.Ljava/lang/ref/WeakReference;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					CommunicatorMessageImpl._members.InstanceFields.SetValue("publisherRef.Ljava/lang/ref/WeakReference;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x00031B04 File Offset: 0x0002FD04
		// (set) Token: 0x06001133 RID: 4403 RVA: 0x00031B1B File Offset: 0x0002FD1B
		[Register("sticky")]
		protected bool Sticky
		{
			get
			{
				return CommunicatorMessageImpl._members.InstanceFields.GetBooleanValue("sticky.Z", this);
			}
			set
			{
				CommunicatorMessageImpl._members.InstanceFields.SetValue("sticky.Z", this, value);
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x00031B34 File Offset: 0x0002FD34
		internal static IntPtr class_ref
		{
			get
			{
				return CommunicatorMessageImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x00031B58 File Offset: 0x0002FD58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CommunicatorMessageImpl._members;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x00031B60 File Offset: 0x0002FD60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CommunicatorMessageImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x00031B84 File Offset: 0x0002FD84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CommunicatorMessageImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00031B90 File Offset: 0x0002FD90
		protected CommunicatorMessageImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x00031B9C File Offset: 0x0002FD9C
		[Register(".ctor", "(Landroid/os/Bundle;Ljava/lang/String;Lcom/applovin/communicator/AppLovinCommunicatorPublisher;Z)V", "")]
		public unsafe CommunicatorMessageImpl(Bundle p0, string p1, IAppLovinCommunicatorPublisher p2, bool p3) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(CommunicatorMessageImpl._members.InstanceMethods.StartCreateInstance("(Landroid/os/Bundle;Ljava/lang/String;Lcom/applovin/communicator/AppLovinCommunicatorPublisher;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CommunicatorMessageImpl._members.InstanceMethods.FinishCreateInstance("(Landroid/os/Bundle;Ljava/lang/String;Lcom/applovin/communicator/AppLovinCommunicatorPublisher;Z)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00031CB0 File Offset: 0x0002FEB0
		private static Delegate GetGetMessageDataHandler()
		{
			if (CommunicatorMessageImpl.cb_getMessageData == null)
			{
				CommunicatorMessageImpl.cb_getMessageData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CommunicatorMessageImpl.n_GetMessageData));
			}
			return CommunicatorMessageImpl.cb_getMessageData;
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00031CD4 File Offset: 0x0002FED4
		private static IntPtr n_GetMessageData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CommunicatorMessageImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MessageData);
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600113C RID: 4412
		public abstract Bundle MessageData { [Register("getMessageData", "()Landroid/os/Bundle;", "GetGetMessageDataHandler")] get; }

		// Token: 0x0600113D RID: 4413 RVA: 0x00031CE8 File Offset: 0x0002FEE8
		private static Delegate GetGetPublisherIdHandler()
		{
			if (CommunicatorMessageImpl.cb_getPublisherId == null)
			{
				CommunicatorMessageImpl.cb_getPublisherId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CommunicatorMessageImpl.n_GetPublisherId));
			}
			return CommunicatorMessageImpl.cb_getPublisherId;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00031D0C File Offset: 0x0002FF0C
		private static IntPtr n_GetPublisherId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<CommunicatorMessageImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PublisherId);
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600113F RID: 4415
		public abstract string PublisherId { [Register("getPublisherId", "()Ljava/lang/String;", "GetGetPublisherIdHandler")] get; }

		// Token: 0x06001140 RID: 4416 RVA: 0x00031D20 File Offset: 0x0002FF20
		private static Delegate GetGetTopicHandler()
		{
			if (CommunicatorMessageImpl.cb_getTopic == null)
			{
				CommunicatorMessageImpl.cb_getTopic = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CommunicatorMessageImpl.n_GetTopic));
			}
			return CommunicatorMessageImpl.cb_getTopic;
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00031D44 File Offset: 0x0002FF44
		private static IntPtr n_GetTopic(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<CommunicatorMessageImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Topic);
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001142 RID: 4418
		public abstract string Topic { [Register("getTopic", "()Ljava/lang/String;", "GetGetTopicHandler")] get; }

		// Token: 0x06001143 RID: 4419 RVA: 0x00031D58 File Offset: 0x0002FF58
		[Register("create", "(Landroid/os/Bundle;Ljava/lang/String;Lcom/applovin/communicator/AppLovinCommunicatorPublisher;Z)Lcom/applovin/communicator/AppLovinCommunicatorMessage;", "")]
		public unsafe static AppLovinCommunicatorMessage Create(Bundle p0, string p1, IAppLovinCommunicatorPublisher p2, bool p3)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			AppLovinCommunicatorMessage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				ptr[3] = new JniArgumentValue(p3);
				@object = Java.Lang.Object.GetObject<AppLovinCommunicatorMessage>(CommunicatorMessageImpl._members.StaticMethods.InvokeObjectMethod("create.(Landroid/os/Bundle;Ljava/lang/String;Lcom/applovin/communicator/AppLovinCommunicatorPublisher;Z)Lcom/applovin/communicator/AppLovinCommunicatorMessage;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x040005A5 RID: 1445
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/communicator/CommunicatorMessageImpl", typeof(CommunicatorMessageImpl));

		// Token: 0x040005A6 RID: 1446
		private static Delegate cb_getMessageData;

		// Token: 0x040005A7 RID: 1447
		private static Delegate cb_getPublisherId;

		// Token: 0x040005A8 RID: 1448
		private static Delegate cb_getTopic;
	}
}
