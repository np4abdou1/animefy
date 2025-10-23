using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Communicator
{
	// Token: 0x0200017B RID: 379
	[Register("com/applovin/communicator/AppLovinCommunicatorSubscriber", DoNotGenerateAcw = true)]
	internal class IAppLovinCommunicatorSubscriberInvoker : Java.Lang.Object, IAppLovinCommunicatorSubscriber, IAppLovinCommunicatorEntity, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x00034028 File Offset: 0x00032228
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinCommunicatorSubscriberInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x0003404C File Offset: 0x0003224C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinCommunicatorSubscriberInvoker._members;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x00034053 File Offset: 0x00032253
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x0003405B File Offset: 0x0003225B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinCommunicatorSubscriberInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00034067 File Offset: 0x00032267
		public static IAppLovinCommunicatorSubscriber GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinCommunicatorSubscriber>(handle, transfer);
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00034070 File Offset: 0x00032270
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinCommunicatorSubscriberInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.communicator.AppLovinCommunicatorSubscriber'.");
			}
			return handle;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0003409B File Offset: 0x0003229B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x000340CC File Offset: 0x000322CC
		public IAppLovinCommunicatorSubscriberInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinCommunicatorSubscriberInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00034104 File Offset: 0x00032304
		private static Delegate GetOnMessageReceived_Lcom_applovin_communicator_AppLovinCommunicatorMessage_Handler()
		{
			if (IAppLovinCommunicatorSubscriberInvoker.cb_onMessageReceived_Lcom_applovin_communicator_AppLovinCommunicatorMessage_ == null)
			{
				IAppLovinCommunicatorSubscriberInvoker.cb_onMessageReceived_Lcom_applovin_communicator_AppLovinCommunicatorMessage_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinCommunicatorSubscriberInvoker.n_OnMessageReceived_Lcom_applovin_communicator_AppLovinCommunicatorMessage_));
			}
			return IAppLovinCommunicatorSubscriberInvoker.cb_onMessageReceived_Lcom_applovin_communicator_AppLovinCommunicatorMessage_;
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00034128 File Offset: 0x00032328
		private static void n_OnMessageReceived_Lcom_applovin_communicator_AppLovinCommunicatorMessage_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinCommunicatorSubscriber @object = Java.Lang.Object.GetObject<IAppLovinCommunicatorSubscriber>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AppLovinCommunicatorMessage object2 = Java.Lang.Object.GetObject<AppLovinCommunicatorMessage>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnMessageReceived(object2);
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0003414C File Offset: 0x0003234C
		public unsafe void OnMessageReceived(AppLovinCommunicatorMessage p0)
		{
			if (this.id_onMessageReceived_Lcom_applovin_communicator_AppLovinCommunicatorMessage_ == IntPtr.Zero)
			{
				this.id_onMessageReceived_Lcom_applovin_communicator_AppLovinCommunicatorMessage_ = JNIEnv.GetMethodID(this.class_ref, "onMessageReceived", "(Lcom/applovin/communicator/AppLovinCommunicatorMessage;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onMessageReceived_Lcom_applovin_communicator_AppLovinCommunicatorMessage_, ptr);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x000341BF File Offset: 0x000323BF
		private static Delegate GetGetCommunicatorIdHandler()
		{
			if (IAppLovinCommunicatorSubscriberInvoker.cb_getCommunicatorId == null)
			{
				IAppLovinCommunicatorSubscriberInvoker.cb_getCommunicatorId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinCommunicatorSubscriberInvoker.n_GetCommunicatorId));
			}
			return IAppLovinCommunicatorSubscriberInvoker.cb_getCommunicatorId;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x000341E3 File Offset: 0x000323E3
		private static IntPtr n_GetCommunicatorId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAppLovinCommunicatorSubscriber>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CommunicatorId);
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x000341F8 File Offset: 0x000323F8
		public string CommunicatorId
		{
			get
			{
				if (this.id_getCommunicatorId == IntPtr.Zero)
				{
					this.id_getCommunicatorId = JNIEnv.GetMethodID(this.class_ref, "getCommunicatorId", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getCommunicatorId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040005E6 RID: 1510
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/communicator/AppLovinCommunicatorSubscriber", typeof(IAppLovinCommunicatorSubscriberInvoker));

		// Token: 0x040005E7 RID: 1511
		private IntPtr class_ref;

		// Token: 0x040005E8 RID: 1512
		private static Delegate cb_onMessageReceived_Lcom_applovin_communicator_AppLovinCommunicatorMessage_;

		// Token: 0x040005E9 RID: 1513
		private IntPtr id_onMessageReceived_Lcom_applovin_communicator_AppLovinCommunicatorMessage_;

		// Token: 0x040005EA RID: 1514
		private static Delegate cb_getCommunicatorId;

		// Token: 0x040005EB RID: 1515
		private IntPtr id_getCommunicatorId;
	}
}
