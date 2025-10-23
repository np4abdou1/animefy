using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter.Parameters
{
	// Token: 0x02000114 RID: 276
	[Register("com/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters", DoNotGenerateAcw = true)]
	internal class IMaxAdapterResponseParametersInvoker : Java.Lang.Object, IMaxAdapterResponseParameters, IMaxAdapterParameters, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0001FC94 File Offset: 0x0001DE94
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxAdapterResponseParametersInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x0001FCB8 File Offset: 0x0001DEB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxAdapterResponseParametersInvoker._members;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x0001FCBF File Offset: 0x0001DEBF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0001FCC7 File Offset: 0x0001DEC7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxAdapterResponseParametersInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0001FCD3 File Offset: 0x0001DED3
		public static IMaxAdapterResponseParameters GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(handle, transfer);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0001FCDC File Offset: 0x0001DEDC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxAdapterResponseParametersInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.parameters.MaxAdapterResponseParameters'.");
			}
			return handle;
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0001FD07 File Offset: 0x0001DF07
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0001FD38 File Offset: 0x0001DF38
		public IMaxAdapterResponseParametersInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxAdapterResponseParametersInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0001FD70 File Offset: 0x0001DF70
		private static Delegate GetGetBidExpirationMillisHandler()
		{
			if (IMaxAdapterResponseParametersInvoker.cb_getBidExpirationMillis == null)
			{
				IMaxAdapterResponseParametersInvoker.cb_getBidExpirationMillis = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(IMaxAdapterResponseParametersInvoker.n_GetBidExpirationMillis));
			}
			return IMaxAdapterResponseParametersInvoker.cb_getBidExpirationMillis;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0001FD94 File Offset: 0x0001DF94
		private static long n_GetBidExpirationMillis(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BidExpirationMillis;
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x0001FDA3 File Offset: 0x0001DFA3
		public long BidExpirationMillis
		{
			get
			{
				if (this.id_getBidExpirationMillis == IntPtr.Zero)
				{
					this.id_getBidExpirationMillis = JNIEnv.GetMethodID(this.class_ref, "getBidExpirationMillis", "()J");
				}
				return JNIEnv.CallLongMethod(base.Handle, this.id_getBidExpirationMillis);
			}
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0001FDE3 File Offset: 0x0001DFE3
		private static Delegate GetGetBidResponseHandler()
		{
			if (IMaxAdapterResponseParametersInvoker.cb_getBidResponse == null)
			{
				IMaxAdapterResponseParametersInvoker.cb_getBidResponse = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterResponseParametersInvoker.n_GetBidResponse));
			}
			return IMaxAdapterResponseParametersInvoker.cb_getBidResponse;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0001FE07 File Offset: 0x0001E007
		private static IntPtr n_GetBidResponse(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BidResponse);
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x0001FE1C File Offset: 0x0001E01C
		public string BidResponse
		{
			get
			{
				if (this.id_getBidResponse == IntPtr.Zero)
				{
					this.id_getBidResponse = JNIEnv.GetMethodID(this.class_ref, "getBidResponse", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getBidResponse), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0001FE6D File Offset: 0x0001E06D
		private static Delegate GetGetThirdPartyAdPlacementIdHandler()
		{
			if (IMaxAdapterResponseParametersInvoker.cb_getThirdPartyAdPlacementId == null)
			{
				IMaxAdapterResponseParametersInvoker.cb_getThirdPartyAdPlacementId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterResponseParametersInvoker.n_GetThirdPartyAdPlacementId));
			}
			return IMaxAdapterResponseParametersInvoker.cb_getThirdPartyAdPlacementId;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0001FE91 File Offset: 0x0001E091
		private static IntPtr n_GetThirdPartyAdPlacementId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThirdPartyAdPlacementId);
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0001FEA8 File Offset: 0x0001E0A8
		public string ThirdPartyAdPlacementId
		{
			get
			{
				if (this.id_getThirdPartyAdPlacementId == IntPtr.Zero)
				{
					this.id_getThirdPartyAdPlacementId = JNIEnv.GetMethodID(this.class_ref, "getThirdPartyAdPlacementId", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getThirdPartyAdPlacementId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0001FEF9 File Offset: 0x0001E0F9
		private static Delegate GetGetAdUnitIdHandler()
		{
			if (IMaxAdapterResponseParametersInvoker.cb_getAdUnitId == null)
			{
				IMaxAdapterResponseParametersInvoker.cb_getAdUnitId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterResponseParametersInvoker.n_GetAdUnitId));
			}
			return IMaxAdapterResponseParametersInvoker.cb_getAdUnitId;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0001FF1D File Offset: 0x0001E11D
		private static IntPtr n_GetAdUnitId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitId);
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x0001FF34 File Offset: 0x0001E134
		public string AdUnitId
		{
			get
			{
				if (this.id_getAdUnitId == IntPtr.Zero)
				{
					this.id_getAdUnitId = JNIEnv.GetMethodID(this.class_ref, "getAdUnitId", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdUnitId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0001FF85 File Offset: 0x0001E185
		private static Delegate GetGetCustomParametersHandler()
		{
			if (IMaxAdapterResponseParametersInvoker.cb_getCustomParameters == null)
			{
				IMaxAdapterResponseParametersInvoker.cb_getCustomParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterResponseParametersInvoker.n_GetCustomParameters));
			}
			return IMaxAdapterResponseParametersInvoker.cb_getCustomParameters;
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0001FFA9 File Offset: 0x0001E1A9
		private static IntPtr n_GetCustomParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CustomParameters);
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0001FFC0 File Offset: 0x0001E1C0
		public Bundle CustomParameters
		{
			get
			{
				if (this.id_getCustomParameters == IntPtr.Zero)
				{
					this.id_getCustomParameters = JNIEnv.GetMethodID(this.class_ref, "getCustomParameters", "()Landroid/os/Bundle;");
				}
				return Java.Lang.Object.GetObject<Bundle>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCustomParameters), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00020011 File Offset: 0x0001E211
		private static Delegate GetIsTestingHandler()
		{
			if (IMaxAdapterResponseParametersInvoker.cb_isTesting == null)
			{
				IMaxAdapterResponseParametersInvoker.cb_isTesting = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMaxAdapterResponseParametersInvoker.n_IsTesting));
			}
			return IMaxAdapterResponseParametersInvoker.cb_isTesting;
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00020035 File Offset: 0x0001E235
		private static bool n_IsTesting(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTesting;
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00020044 File Offset: 0x0001E244
		public bool IsTesting
		{
			get
			{
				if (this.id_isTesting == IntPtr.Zero)
				{
					this.id_isTesting = JNIEnv.GetMethodID(this.class_ref, "isTesting", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isTesting);
			}
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00020084 File Offset: 0x0001E284
		private static Delegate GetGetLocalExtraParametersHandler()
		{
			if (IMaxAdapterResponseParametersInvoker.cb_getLocalExtraParameters == null)
			{
				IMaxAdapterResponseParametersInvoker.cb_getLocalExtraParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterResponseParametersInvoker.n_GetLocalExtraParameters));
			}
			return IMaxAdapterResponseParametersInvoker.cb_getLocalExtraParameters;
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x000200A8 File Offset: 0x0001E2A8
		private static IntPtr n_GetLocalExtraParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LocalExtraParameters);
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x000200BC File Offset: 0x0001E2BC
		public IDictionary<string, Java.Lang.Object> LocalExtraParameters
		{
			get
			{
				if (this.id_getLocalExtraParameters == IntPtr.Zero)
				{
					this.id_getLocalExtraParameters = JNIEnv.GetMethodID(this.class_ref, "getLocalExtraParameters", "()Ljava/util/Map;");
				}
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getLocalExtraParameters), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0002010D File Offset: 0x0001E30D
		private static Delegate GetGetServerParametersHandler()
		{
			if (IMaxAdapterResponseParametersInvoker.cb_getServerParameters == null)
			{
				IMaxAdapterResponseParametersInvoker.cb_getServerParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterResponseParametersInvoker.n_GetServerParameters));
			}
			return IMaxAdapterResponseParametersInvoker.cb_getServerParameters;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00020131 File Offset: 0x0001E331
		private static IntPtr n_GetServerParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ServerParameters);
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x00020148 File Offset: 0x0001E348
		public Bundle ServerParameters
		{
			get
			{
				if (this.id_getServerParameters == IntPtr.Zero)
				{
					this.id_getServerParameters = JNIEnv.GetMethodID(this.class_ref, "getServerParameters", "()Landroid/os/Bundle;");
				}
				return Java.Lang.Object.GetObject<Bundle>(JNIEnv.CallObjectMethod(base.Handle, this.id_getServerParameters), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00020199 File Offset: 0x0001E399
		private static Delegate GetHasUserConsentHandler()
		{
			if (IMaxAdapterResponseParametersInvoker.cb_hasUserConsent == null)
			{
				IMaxAdapterResponseParametersInvoker.cb_hasUserConsent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterResponseParametersInvoker.n_HasUserConsent));
			}
			return IMaxAdapterResponseParametersInvoker.cb_hasUserConsent;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000201BD File Offset: 0x0001E3BD
		private static IntPtr n_HasUserConsent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasUserConsent());
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000201D4 File Offset: 0x0001E3D4
		public Java.Lang.Boolean HasUserConsent()
		{
			if (this.id_hasUserConsent == IntPtr.Zero)
			{
				this.id_hasUserConsent = JNIEnv.GetMethodID(this.class_ref, "hasUserConsent", "()Ljava/lang/Boolean;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(JNIEnv.CallObjectMethod(base.Handle, this.id_hasUserConsent), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00020225 File Offset: 0x0001E425
		private static Delegate GetIsAgeRestrictedUserHandler()
		{
			if (IMaxAdapterResponseParametersInvoker.cb_isAgeRestrictedUser == null)
			{
				IMaxAdapterResponseParametersInvoker.cb_isAgeRestrictedUser = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterResponseParametersInvoker.n_IsAgeRestrictedUser));
			}
			return IMaxAdapterResponseParametersInvoker.cb_isAgeRestrictedUser;
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00020249 File Offset: 0x0001E449
		private static IntPtr n_IsAgeRestrictedUser(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAgeRestrictedUser());
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00020260 File Offset: 0x0001E460
		public Java.Lang.Boolean IsAgeRestrictedUser()
		{
			if (this.id_isAgeRestrictedUser == IntPtr.Zero)
			{
				this.id_isAgeRestrictedUser = JNIEnv.GetMethodID(this.class_ref, "isAgeRestrictedUser", "()Ljava/lang/Boolean;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(JNIEnv.CallObjectMethod(base.Handle, this.id_isAgeRestrictedUser), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000202B1 File Offset: 0x0001E4B1
		private static Delegate GetIsDoNotSellHandler()
		{
			if (IMaxAdapterResponseParametersInvoker.cb_isDoNotSell == null)
			{
				IMaxAdapterResponseParametersInvoker.cb_isDoNotSell = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterResponseParametersInvoker.n_IsDoNotSell));
			}
			return IMaxAdapterResponseParametersInvoker.cb_isDoNotSell;
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x000202D5 File Offset: 0x0001E4D5
		private static IntPtr n_IsDoNotSell(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDoNotSell());
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x000202EC File Offset: 0x0001E4EC
		public Java.Lang.Boolean IsDoNotSell()
		{
			if (this.id_isDoNotSell == IntPtr.Zero)
			{
				this.id_isDoNotSell = JNIEnv.GetMethodID(this.class_ref, "isDoNotSell", "()Ljava/lang/Boolean;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(JNIEnv.CallObjectMethod(base.Handle, this.id_isDoNotSell), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040003ED RID: 1005
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters", typeof(IMaxAdapterResponseParametersInvoker));

		// Token: 0x040003EE RID: 1006
		private IntPtr class_ref;

		// Token: 0x040003EF RID: 1007
		private static Delegate cb_getBidExpirationMillis;

		// Token: 0x040003F0 RID: 1008
		private IntPtr id_getBidExpirationMillis;

		// Token: 0x040003F1 RID: 1009
		private static Delegate cb_getBidResponse;

		// Token: 0x040003F2 RID: 1010
		private IntPtr id_getBidResponse;

		// Token: 0x040003F3 RID: 1011
		private static Delegate cb_getThirdPartyAdPlacementId;

		// Token: 0x040003F4 RID: 1012
		private IntPtr id_getThirdPartyAdPlacementId;

		// Token: 0x040003F5 RID: 1013
		private static Delegate cb_getAdUnitId;

		// Token: 0x040003F6 RID: 1014
		private IntPtr id_getAdUnitId;

		// Token: 0x040003F7 RID: 1015
		private static Delegate cb_getCustomParameters;

		// Token: 0x040003F8 RID: 1016
		private IntPtr id_getCustomParameters;

		// Token: 0x040003F9 RID: 1017
		private static Delegate cb_isTesting;

		// Token: 0x040003FA RID: 1018
		private IntPtr id_isTesting;

		// Token: 0x040003FB RID: 1019
		private static Delegate cb_getLocalExtraParameters;

		// Token: 0x040003FC RID: 1020
		private IntPtr id_getLocalExtraParameters;

		// Token: 0x040003FD RID: 1021
		private static Delegate cb_getServerParameters;

		// Token: 0x040003FE RID: 1022
		private IntPtr id_getServerParameters;

		// Token: 0x040003FF RID: 1023
		private static Delegate cb_hasUserConsent;

		// Token: 0x04000400 RID: 1024
		private IntPtr id_hasUserConsent;

		// Token: 0x04000401 RID: 1025
		private static Delegate cb_isAgeRestrictedUser;

		// Token: 0x04000402 RID: 1026
		private IntPtr id_isAgeRestrictedUser;

		// Token: 0x04000403 RID: 1027
		private static Delegate cb_isDoNotSell;

		// Token: 0x04000404 RID: 1028
		private IntPtr id_isDoNotSell;
	}
}
