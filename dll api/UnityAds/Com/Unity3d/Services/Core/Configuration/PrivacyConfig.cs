using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000177 RID: 375
	[Register("com/unity3d/services/core/configuration/PrivacyConfig", DoNotGenerateAcw = true)]
	public class PrivacyConfig : Java.Lang.Object
	{
		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x0002CF00 File Offset: 0x0002B100
		internal static IntPtr class_ref
		{
			get
			{
				return PrivacyConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x0002CF24 File Offset: 0x0002B124
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PrivacyConfig._members;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x0002CF2C File Offset: 0x0002B12C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PrivacyConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x0002CF50 File Offset: 0x0002B150
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PrivacyConfig._members.ManagedPeerType;
			}
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x000021E8 File Offset: 0x000003E8
		protected PrivacyConfig(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0002CF5C File Offset: 0x0002B15C
		[Register(".ctor", "()V", "")]
		public PrivacyConfig() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(PrivacyConfig._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			PrivacyConfig._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0002CFCC File Offset: 0x0002B1CC
		[Register(".ctor", "(Lcom/unity3d/services/core/configuration/PrivacyConfigStatus;)V", "")]
		public unsafe PrivacyConfig(PrivacyConfigStatus privacyConfigStatus) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((privacyConfigStatus == null) ? IntPtr.Zero : privacyConfigStatus.Handle);
				base.SetHandle(PrivacyConfig._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/configuration/PrivacyConfigStatus;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PrivacyConfig._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/configuration/PrivacyConfigStatus;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(privacyConfigStatus);
			}
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0002D07C File Offset: 0x0002B27C
		[Register(".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe PrivacyConfig(JSONObject privacyResponse) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((privacyResponse == null) ? IntPtr.Zero : privacyResponse.Handle);
				base.SetHandle(PrivacyConfig._members.InstanceMethods.StartCreateInstance("(Lorg/json/JSONObject;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PrivacyConfig._members.InstanceMethods.FinishCreateInstance("(Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(privacyResponse);
			}
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0002D12C File Offset: 0x0002B32C
		private static Delegate GetGetPrivacyStatusHandler()
		{
			if (PrivacyConfig.cb_getPrivacyStatus == null)
			{
				PrivacyConfig.cb_getPrivacyStatus = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PrivacyConfig.n_GetPrivacyStatus));
			}
			return PrivacyConfig.cb_getPrivacyStatus;
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0002D150 File Offset: 0x0002B350
		private static IntPtr n_GetPrivacyStatus(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PrivacyConfig>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PrivacyStatus);
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x0002D164 File Offset: 0x0002B364
		public virtual PrivacyConfigStatus PrivacyStatus
		{
			[Register("getPrivacyStatus", "()Lcom/unity3d/services/core/configuration/PrivacyConfigStatus;", "GetGetPrivacyStatusHandler")]
			get
			{
				return Java.Lang.Object.GetObject<PrivacyConfigStatus>(PrivacyConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getPrivacyStatus.()Lcom/unity3d/services/core/configuration/PrivacyConfigStatus;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0002D196 File Offset: 0x0002B396
		private static Delegate GetAllowedToSendPiiHandler()
		{
			if (PrivacyConfig.cb_allowedToSendPii == null)
			{
				PrivacyConfig.cb_allowedToSendPii = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(PrivacyConfig.n_AllowedToSendPii));
			}
			return PrivacyConfig.cb_allowedToSendPii;
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0002D1BA File Offset: 0x0002B3BA
		private static bool n_AllowedToSendPii(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<PrivacyConfig>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AllowedToSendPii();
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0002D1C9 File Offset: 0x0002B3C9
		[Register("allowedToSendPii", "()Z", "GetAllowedToSendPiiHandler")]
		public virtual bool AllowedToSendPii()
		{
			return PrivacyConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("allowedToSendPii.()Z", this, null);
		}

		// Token: 0x0400042D RID: 1069
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/PrivacyConfig", typeof(PrivacyConfig));

		// Token: 0x0400042E RID: 1070
		private static Delegate cb_getPrivacyStatus;

		// Token: 0x0400042F RID: 1071
		private static Delegate cb_allowedToSendPii;
	}
}
