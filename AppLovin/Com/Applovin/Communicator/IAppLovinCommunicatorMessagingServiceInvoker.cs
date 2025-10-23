using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Communicator
{
	// Token: 0x02000177 RID: 375
	[Register("com/applovin/communicator/AppLovinCommunicatorMessagingService", DoNotGenerateAcw = true)]
	internal class IAppLovinCommunicatorMessagingServiceInvoker : Java.Lang.Object, IAppLovinCommunicatorMessagingService, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x00033CF4 File Offset: 0x00031EF4
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinCommunicatorMessagingServiceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x00033D18 File Offset: 0x00031F18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinCommunicatorMessagingServiceInvoker._members;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x00033D1F File Offset: 0x00031F1F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x00033D27 File Offset: 0x00031F27
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinCommunicatorMessagingServiceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00033D33 File Offset: 0x00031F33
		public static IAppLovinCommunicatorMessagingService GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinCommunicatorMessagingService>(handle, transfer);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00033D3C File Offset: 0x00031F3C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinCommunicatorMessagingServiceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.communicator.AppLovinCommunicatorMessagingService'.");
			}
			return handle;
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00033D67 File Offset: 0x00031F67
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00033D98 File Offset: 0x00031F98
		public IAppLovinCommunicatorMessagingServiceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinCommunicatorMessagingServiceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00033DD0 File Offset: 0x00031FD0
		private static Delegate GetPublish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_Handler()
		{
			if (IAppLovinCommunicatorMessagingServiceInvoker.cb_publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_ == null)
			{
				IAppLovinCommunicatorMessagingServiceInvoker.cb_publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinCommunicatorMessagingServiceInvoker.n_Publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_));
			}
			return IAppLovinCommunicatorMessagingServiceInvoker.cb_publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_;
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00033DF4 File Offset: 0x00031FF4
		private static void n_Publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinCommunicatorMessagingService @object = Java.Lang.Object.GetObject<IAppLovinCommunicatorMessagingService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AppLovinCommunicatorMessage object2 = Java.Lang.Object.GetObject<AppLovinCommunicatorMessage>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Publish(object2);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00033E18 File Offset: 0x00032018
		public unsafe void Publish(AppLovinCommunicatorMessage p0)
		{
			if (this.id_publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_ == IntPtr.Zero)
			{
				this.id_publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_ = JNIEnv.GetMethodID(this.class_ref, "publish", "(Lcom/applovin/communicator/AppLovinCommunicatorMessage;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_, ptr);
		}

		// Token: 0x040005DE RID: 1502
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/communicator/AppLovinCommunicatorMessagingService", typeof(IAppLovinCommunicatorMessagingServiceInvoker));

		// Token: 0x040005DF RID: 1503
		private IntPtr class_ref;

		// Token: 0x040005E0 RID: 1504
		private static Delegate cb_publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_;

		// Token: 0x040005E1 RID: 1505
		private IntPtr id_publish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_;
	}
}
