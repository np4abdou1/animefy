using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk
{
	// Token: 0x02000132 RID: 306
	[Register("com/applovin/impl/sdk/SdkConfigurationImpl", DoNotGenerateAcw = true)]
	public class SdkConfigurationImpl : Java.Lang.Object, IAppLovinSdkConfiguration, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00026158 File Offset: 0x00024358
		internal static IntPtr class_ref
		{
			get
			{
				return SdkConfigurationImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x0002617C File Offset: 0x0002437C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SdkConfigurationImpl._members;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00026184 File Offset: 0x00024384
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SdkConfigurationImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x000261A8 File Offset: 0x000243A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SdkConfigurationImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x000021F0 File Offset: 0x000003F0
		protected SdkConfigurationImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x000261B4 File Offset: 0x000243B4
		private static Delegate GetGetConsentDialogStateHandler()
		{
			if (SdkConfigurationImpl.cb_getConsentDialogState == null)
			{
				SdkConfigurationImpl.cb_getConsentDialogState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SdkConfigurationImpl.n_GetConsentDialogState));
			}
			return SdkConfigurationImpl.cb_getConsentDialogState;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x000261D8 File Offset: 0x000243D8
		private static IntPtr n_GetConsentDialogState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SdkConfigurationImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ConsentDialogState);
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x000261EC File Offset: 0x000243EC
		public virtual AppLovinSdkConfigurationConsentDialogState ConsentDialogState
		{
			[Register("getConsentDialogState", "()Lcom/applovin/sdk/AppLovinSdkConfiguration$ConsentDialogState;", "GetGetConsentDialogStateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AppLovinSdkConfigurationConsentDialogState>(SdkConfigurationImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getConsentDialogState.()Lcom/applovin/sdk/AppLovinSdkConfiguration$ConsentDialogState;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0002621E File Offset: 0x0002441E
		private static Delegate GetGetCountryCodeHandler()
		{
			if (SdkConfigurationImpl.cb_getCountryCode == null)
			{
				SdkConfigurationImpl.cb_getCountryCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SdkConfigurationImpl.n_GetCountryCode));
			}
			return SdkConfigurationImpl.cb_getCountryCode;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00026242 File Offset: 0x00024442
		private static IntPtr n_GetCountryCode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<SdkConfigurationImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CountryCode);
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00026258 File Offset: 0x00024458
		public virtual string CountryCode
		{
			[Register("getCountryCode", "()Ljava/lang/String;", "GetGetCountryCodeHandler")]
			get
			{
				return JNIEnv.GetString(SdkConfigurationImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getCountryCode.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040004D7 RID: 1239
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/SdkConfigurationImpl", typeof(SdkConfigurationImpl));

		// Token: 0x040004D8 RID: 1240
		private static Delegate cb_getConsentDialogState;

		// Token: 0x040004D9 RID: 1241
		private static Delegate cb_getCountryCode;
	}
}
