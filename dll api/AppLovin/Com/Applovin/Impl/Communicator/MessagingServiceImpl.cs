using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Applovin.Communicator;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Communicator
{
	// Token: 0x0200015E RID: 350
	[Register("com/applovin/impl/communicator/MessagingServiceImpl", DoNotGenerateAcw = true)]
	public class MessagingServiceImpl : Java.Lang.Object, IAppLovinCommunicatorMessagingService, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x00031F20 File Offset: 0x00030120
		internal static IntPtr class_ref
		{
			get
			{
				return MessagingServiceImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x00031F44 File Offset: 0x00030144
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MessagingServiceImpl._members;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00031F4C File Offset: 0x0003014C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MessagingServiceImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x00031F70 File Offset: 0x00030170
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MessagingServiceImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MessagingServiceImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00031F7C File Offset: 0x0003017C
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MessagingServiceImpl(Context p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				base.SetHandle(MessagingServiceImpl._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MessagingServiceImpl._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0003202C File Offset: 0x0003022C
		private static Delegate GetMaybeFlushStickyMessages_Ljava_lang_String_Handler()
		{
			if (MessagingServiceImpl.cb_maybeFlushStickyMessages_Ljava_lang_String_ == null)
			{
				MessagingServiceImpl.cb_maybeFlushStickyMessages_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MessagingServiceImpl.n_MaybeFlushStickyMessages_Ljava_lang_String_));
			}
			return MessagingServiceImpl.cb_maybeFlushStickyMessages_Ljava_lang_String_;
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00032050 File Offset: 0x00030250
		private static void n_MaybeFlushStickyMessages_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MessagingServiceImpl @object = Java.Lang.Object.GetObject<MessagingServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.MaybeFlushStickyMessages(@string);
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00032074 File Offset: 0x00030274
		[Register("maybeFlushStickyMessages", "(Ljava/lang/String;)V", "GetMaybeFlushStickyMessages_Ljava_lang_String_Handler")]
		public unsafe virtual void MaybeFlushStickyMessages(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MessagingServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("maybeFlushStickyMessages.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x000320D0 File Offset: 0x000302D0
		private static Delegate GetPublish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_Handler()
		{
			if (MessagingServiceImpl.cb_publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_ == null)
			{
				MessagingServiceImpl.cb_publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MessagingServiceImpl.n_Publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_));
			}
			return MessagingServiceImpl.cb_publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_;
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x000320F4 File Offset: 0x000302F4
		private static void n_Publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MessagingServiceImpl @object = Java.Lang.Object.GetObject<MessagingServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AppLovinCommunicatorMessage object2 = Java.Lang.Object.GetObject<AppLovinCommunicatorMessage>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Publish(object2);
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00032118 File Offset: 0x00030318
		[Register("publish", "(Lcom/applovin/communicator/AppLovinCommunicatorMessage;)V", "GetPublish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_Handler")]
		public unsafe virtual void Publish(AppLovinCommunicatorMessage p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				MessagingServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("publish.(Lcom/applovin/communicator/AppLovinCommunicatorMessage;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x040005AA RID: 1450
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/communicator/MessagingServiceImpl", typeof(MessagingServiceImpl));

		// Token: 0x040005AB RID: 1451
		private static Delegate cb_maybeFlushStickyMessages_Ljava_lang_String_;

		// Token: 0x040005AC RID: 1452
		private static Delegate cb_publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_;
	}
}
