using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Com.Applovin.Mediation;
using Com.Applovin.Mediation.Adapter.Parameters;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Mediation
{
	// Token: 0x02000153 RID: 339
	[Register("com/applovin/impl/mediation/MaxAdapterParametersImpl", DoNotGenerateAcw = true)]
	public class MaxAdapterParametersImpl : Java.Lang.Object, IMaxAdapterInitializationParameters, IMaxAdapterParameters, IJavaObject, IDisposable, IJavaPeerable, IMaxAdapterResponseParameters, IMaxAdapterSignalCollectionParameters
	{
		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x0002FBAC File Offset: 0x0002DDAC
		internal static IntPtr class_ref
		{
			get
			{
				return MaxAdapterParametersImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x0002FBD0 File Offset: 0x0002DDD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxAdapterParametersImpl._members;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x0002FBD8 File Offset: 0x0002DDD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxAdapterParametersImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x0002FBFC File Offset: 0x0002DDFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxAdapterParametersImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxAdapterParametersImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0002FC08 File Offset: 0x0002DE08
		private static Delegate GetGetAdFormatHandler()
		{
			if (MaxAdapterParametersImpl.cb_getAdFormat == null)
			{
				MaxAdapterParametersImpl.cb_getAdFormat = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdapterParametersImpl.n_GetAdFormat));
			}
			return MaxAdapterParametersImpl.cb_getAdFormat;
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0002FC2C File Offset: 0x0002DE2C
		private static IntPtr n_GetAdFormat(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxAdapterParametersImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdFormat);
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x0002FC40 File Offset: 0x0002DE40
		public virtual MaxAdFormat AdFormat
		{
			[Register("getAdFormat", "()Lcom/applovin/mediation/MaxAdFormat;", "GetGetAdFormatHandler")]
			get
			{
				return Java.Lang.Object.GetObject<MaxAdFormat>(MaxAdapterParametersImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getAdFormat.()Lcom/applovin/mediation/MaxAdFormat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0002FC72 File Offset: 0x0002DE72
		private static Delegate GetGetAdUnitIdHandler()
		{
			if (MaxAdapterParametersImpl.cb_getAdUnitId == null)
			{
				MaxAdapterParametersImpl.cb_getAdUnitId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdapterParametersImpl.n_GetAdUnitId));
			}
			return MaxAdapterParametersImpl.cb_getAdUnitId;
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0002FC96 File Offset: 0x0002DE96
		private static IntPtr n_GetAdUnitId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxAdapterParametersImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitId);
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x0002FCAC File Offset: 0x0002DEAC
		public virtual string AdUnitId
		{
			[Register("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler")]
			get
			{
				return JNIEnv.GetString(MaxAdapterParametersImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getAdUnitId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0002FCDE File Offset: 0x0002DEDE
		private static Delegate GetGetBidExpirationMillisHandler()
		{
			if (MaxAdapterParametersImpl.cb_getBidExpirationMillis == null)
			{
				MaxAdapterParametersImpl.cb_getBidExpirationMillis = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(MaxAdapterParametersImpl.n_GetBidExpirationMillis));
			}
			return MaxAdapterParametersImpl.cb_getBidExpirationMillis;
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0002FD02 File Offset: 0x0002DF02
		private static long n_GetBidExpirationMillis(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxAdapterParametersImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BidExpirationMillis;
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x0002FD11 File Offset: 0x0002DF11
		public virtual long BidExpirationMillis
		{
			[Register("getBidExpirationMillis", "()J", "GetGetBidExpirationMillisHandler")]
			get
			{
				return MaxAdapterParametersImpl._members.InstanceMethods.InvokeVirtualInt64Method("getBidExpirationMillis.()J", this, null);
			}
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0002FD2A File Offset: 0x0002DF2A
		private static Delegate GetGetBidResponseHandler()
		{
			if (MaxAdapterParametersImpl.cb_getBidResponse == null)
			{
				MaxAdapterParametersImpl.cb_getBidResponse = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdapterParametersImpl.n_GetBidResponse));
			}
			return MaxAdapterParametersImpl.cb_getBidResponse;
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0002FD4E File Offset: 0x0002DF4E
		private static IntPtr n_GetBidResponse(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxAdapterParametersImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BidResponse);
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x0002FD64 File Offset: 0x0002DF64
		public virtual string BidResponse
		{
			[Register("getBidResponse", "()Ljava/lang/String;", "GetGetBidResponseHandler")]
			get
			{
				return JNIEnv.GetString(MaxAdapterParametersImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getBidResponse.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0002FD96 File Offset: 0x0002DF96
		private static Delegate GetGetCustomParametersHandler()
		{
			if (MaxAdapterParametersImpl.cb_getCustomParameters == null)
			{
				MaxAdapterParametersImpl.cb_getCustomParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdapterParametersImpl.n_GetCustomParameters));
			}
			return MaxAdapterParametersImpl.cb_getCustomParameters;
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0002FDBA File Offset: 0x0002DFBA
		private static IntPtr n_GetCustomParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxAdapterParametersImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CustomParameters);
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x0002FDD0 File Offset: 0x0002DFD0
		public virtual Bundle CustomParameters
		{
			[Register("getCustomParameters", "()Landroid/os/Bundle;", "GetGetCustomParametersHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Bundle>(MaxAdapterParametersImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getCustomParameters.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0002FE02 File Offset: 0x0002E002
		private static Delegate GetIsTestingHandler()
		{
			if (MaxAdapterParametersImpl.cb_isTesting == null)
			{
				MaxAdapterParametersImpl.cb_isTesting = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MaxAdapterParametersImpl.n_IsTesting));
			}
			return MaxAdapterParametersImpl.cb_isTesting;
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0002FE26 File Offset: 0x0002E026
		private static bool n_IsTesting(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxAdapterParametersImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTesting;
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x0002FE35 File Offset: 0x0002E035
		public virtual bool IsTesting
		{
			[Register("isTesting", "()Z", "GetIsTestingHandler")]
			get
			{
				return MaxAdapterParametersImpl._members.InstanceMethods.InvokeVirtualBooleanMethod("isTesting.()Z", this, null);
			}
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0002FE4E File Offset: 0x0002E04E
		private static Delegate GetGetLocalExtraParametersHandler()
		{
			if (MaxAdapterParametersImpl.cb_getLocalExtraParameters == null)
			{
				MaxAdapterParametersImpl.cb_getLocalExtraParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdapterParametersImpl.n_GetLocalExtraParameters));
			}
			return MaxAdapterParametersImpl.cb_getLocalExtraParameters;
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0002FE72 File Offset: 0x0002E072
		private static IntPtr n_GetLocalExtraParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxAdapterParametersImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LocalExtraParameters);
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x0002FE88 File Offset: 0x0002E088
		public virtual IDictionary<string, Java.Lang.Object> LocalExtraParameters
		{
			[Register("getLocalExtraParameters", "()Ljava/util/Map;", "GetGetLocalExtraParametersHandler")]
			get
			{
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(MaxAdapterParametersImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getLocalExtraParameters.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0002FEBA File Offset: 0x0002E0BA
		private static Delegate GetGetServerParametersHandler()
		{
			if (MaxAdapterParametersImpl.cb_getServerParameters == null)
			{
				MaxAdapterParametersImpl.cb_getServerParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdapterParametersImpl.n_GetServerParameters));
			}
			return MaxAdapterParametersImpl.cb_getServerParameters;
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x0002FEDE File Offset: 0x0002E0DE
		private static IntPtr n_GetServerParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxAdapterParametersImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ServerParameters);
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x0002FEF4 File Offset: 0x0002E0F4
		public virtual Bundle ServerParameters
		{
			[Register("getServerParameters", "()Landroid/os/Bundle;", "GetGetServerParametersHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Bundle>(MaxAdapterParametersImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getServerParameters.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0002FF26 File Offset: 0x0002E126
		private static Delegate GetGetThirdPartyAdPlacementIdHandler()
		{
			if (MaxAdapterParametersImpl.cb_getThirdPartyAdPlacementId == null)
			{
				MaxAdapterParametersImpl.cb_getThirdPartyAdPlacementId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdapterParametersImpl.n_GetThirdPartyAdPlacementId));
			}
			return MaxAdapterParametersImpl.cb_getThirdPartyAdPlacementId;
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0002FF4A File Offset: 0x0002E14A
		private static IntPtr n_GetThirdPartyAdPlacementId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxAdapterParametersImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThirdPartyAdPlacementId);
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x0002FF60 File Offset: 0x0002E160
		public virtual string ThirdPartyAdPlacementId
		{
			[Register("getThirdPartyAdPlacementId", "()Ljava/lang/String;", "GetGetThirdPartyAdPlacementIdHandler")]
			get
			{
				return JNIEnv.GetString(MaxAdapterParametersImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getThirdPartyAdPlacementId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0002FF92 File Offset: 0x0002E192
		private static Delegate GetHasUserConsentHandler()
		{
			if (MaxAdapterParametersImpl.cb_hasUserConsent == null)
			{
				MaxAdapterParametersImpl.cb_hasUserConsent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdapterParametersImpl.n_HasUserConsent));
			}
			return MaxAdapterParametersImpl.cb_hasUserConsent;
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0002FFB6 File Offset: 0x0002E1B6
		private static IntPtr n_HasUserConsent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxAdapterParametersImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasUserConsent());
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0002FFCC File Offset: 0x0002E1CC
		[Register("hasUserConsent", "()Ljava/lang/Boolean;", "GetHasUserConsentHandler")]
		public virtual Java.Lang.Boolean HasUserConsent()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(MaxAdapterParametersImpl._members.InstanceMethods.InvokeVirtualObjectMethod("hasUserConsent.()Ljava/lang/Boolean;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0002FFFE File Offset: 0x0002E1FE
		private static Delegate GetIsAgeRestrictedUserHandler()
		{
			if (MaxAdapterParametersImpl.cb_isAgeRestrictedUser == null)
			{
				MaxAdapterParametersImpl.cb_isAgeRestrictedUser = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdapterParametersImpl.n_IsAgeRestrictedUser));
			}
			return MaxAdapterParametersImpl.cb_isAgeRestrictedUser;
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00030022 File Offset: 0x0002E222
		private static IntPtr n_IsAgeRestrictedUser(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxAdapterParametersImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAgeRestrictedUser());
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00030038 File Offset: 0x0002E238
		[Register("isAgeRestrictedUser", "()Ljava/lang/Boolean;", "GetIsAgeRestrictedUserHandler")]
		public virtual Java.Lang.Boolean IsAgeRestrictedUser()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(MaxAdapterParametersImpl._members.InstanceMethods.InvokeVirtualObjectMethod("isAgeRestrictedUser.()Ljava/lang/Boolean;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0003006A File Offset: 0x0002E26A
		private static Delegate GetIsDoNotSellHandler()
		{
			if (MaxAdapterParametersImpl.cb_isDoNotSell == null)
			{
				MaxAdapterParametersImpl.cb_isDoNotSell = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdapterParametersImpl.n_IsDoNotSell));
			}
			return MaxAdapterParametersImpl.cb_isDoNotSell;
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0003008E File Offset: 0x0002E28E
		private static IntPtr n_IsDoNotSell(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxAdapterParametersImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDoNotSell());
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x000300A4 File Offset: 0x0002E2A4
		[Register("isDoNotSell", "()Ljava/lang/Boolean;", "GetIsDoNotSellHandler")]
		public virtual Java.Lang.Boolean IsDoNotSell()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(MaxAdapterParametersImpl._members.InstanceMethods.InvokeVirtualObjectMethod("isDoNotSell.()Ljava/lang/Boolean;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000570 RID: 1392
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/mediation/MaxAdapterParametersImpl", typeof(MaxAdapterParametersImpl));

		// Token: 0x04000571 RID: 1393
		private static Delegate cb_getAdFormat;

		// Token: 0x04000572 RID: 1394
		private static Delegate cb_getAdUnitId;

		// Token: 0x04000573 RID: 1395
		private static Delegate cb_getBidExpirationMillis;

		// Token: 0x04000574 RID: 1396
		private static Delegate cb_getBidResponse;

		// Token: 0x04000575 RID: 1397
		private static Delegate cb_getCustomParameters;

		// Token: 0x04000576 RID: 1398
		private static Delegate cb_isTesting;

		// Token: 0x04000577 RID: 1399
		private static Delegate cb_getLocalExtraParameters;

		// Token: 0x04000578 RID: 1400
		private static Delegate cb_getServerParameters;

		// Token: 0x04000579 RID: 1401
		private static Delegate cb_getThirdPartyAdPlacementId;

		// Token: 0x0400057A RID: 1402
		private static Delegate cb_hasUserConsent;

		// Token: 0x0400057B RID: 1403
		private static Delegate cb_isAgeRestrictedUser;

		// Token: 0x0400057C RID: 1404
		private static Delegate cb_isDoNotSell;
	}
}
