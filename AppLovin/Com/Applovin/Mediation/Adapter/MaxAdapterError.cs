using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Applovin.Impl.Mediation;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x0200010E RID: 270
	[Register("com/applovin/mediation/adapter/MaxAdapterError", DoNotGenerateAcw = true)]
	public class MaxAdapterError : MaxErrorImpl
	{
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0001E97C File Offset: 0x0001CB7C
		[Register("AD_DISPLAY_FAILED")]
		public static MaxAdapterError AdDisplayFailed
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("AD_DISPLAY_FAILED.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x0001E9AC File Offset: 0x0001CBAC
		[Register("AD_EXPIRED")]
		public static MaxAdapterError AdExpired
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("AD_EXPIRED.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x0001E9DC File Offset: 0x0001CBDC
		[Register("AD_FREQUENCY_CAPPED")]
		public static MaxAdapterError AdFrequencyCapped
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("AD_FREQUENCY_CAPPED.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x0001EA0C File Offset: 0x0001CC0C
		[Register("AD_NOT_READY")]
		public static MaxAdapterError AdNotReady
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("AD_NOT_READY.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0001EA3C File Offset: 0x0001CC3C
		[Register("BAD_REQUEST")]
		public static MaxAdapterError BadRequest
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("BAD_REQUEST.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0001EA6C File Offset: 0x0001CC6C
		[Register("INTERNAL_ERROR")]
		public static MaxAdapterError InternalError
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("INTERNAL_ERROR.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x0001EA9C File Offset: 0x0001CC9C
		[Register("INVALID_CONFIGURATION")]
		public static MaxAdapterError InvalidConfiguration
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("INVALID_CONFIGURATION.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0001EACC File Offset: 0x0001CCCC
		[Register("INVALID_LOAD_STATE")]
		public static MaxAdapterError InvalidLoadState
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("INVALID_LOAD_STATE.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x0001EAFC File Offset: 0x0001CCFC
		[Register("MISSING_ACTIVITY")]
		public static MaxAdapterError MissingActivity
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("MISSING_ACTIVITY.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x0001EB2C File Offset: 0x0001CD2C
		[Register("MISSING_REQUIRED_NATIVE_AD_ASSETS")]
		public static MaxAdapterError MissingRequiredNativeAdAssets
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("MISSING_REQUIRED_NATIVE_AD_ASSETS.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0001EB5C File Offset: 0x0001CD5C
		[Register("NOT_INITIALIZED")]
		public static MaxAdapterError NotInitialized
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("NOT_INITIALIZED.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x0001EB8C File Offset: 0x0001CD8C
		[Register("NO_CONNECTION")]
		public static MaxAdapterError NoConnection
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("NO_CONNECTION.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0001EBBC File Offset: 0x0001CDBC
		[Register("NO_FILL")]
		public static MaxAdapterError NoFill
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("NO_FILL.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0001EBEC File Offset: 0x0001CDEC
		[Register("REWARD_ERROR")]
		public static MaxAdapterError RewardError
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("REWARD_ERROR.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x0001EC1C File Offset: 0x0001CE1C
		[Register("SERVER_ERROR")]
		public static MaxAdapterError ServerError
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("SERVER_ERROR.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x0001EC4C File Offset: 0x0001CE4C
		[Register("SIGNAL_COLLECTION_NOT_SUPPORTED")]
		public static MaxAdapterError SignalCollectionNotSupported
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("SIGNAL_COLLECTION_NOT_SUPPORTED.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x0001EC7C File Offset: 0x0001CE7C
		[Register("SIGNAL_COLLECTION_TIMEOUT")]
		public static MaxAdapterError SignalCollectionTimeout
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("SIGNAL_COLLECTION_TIMEOUT.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x0001ECAC File Offset: 0x0001CEAC
		[Register("TIMEOUT")]
		public static MaxAdapterError Timeout
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("TIMEOUT.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0001ECDC File Offset: 0x0001CEDC
		[Register("UNSPECIFIED")]
		public static MaxAdapterError Unspecified
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("UNSPECIFIED.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0001ED0C File Offset: 0x0001CF0C
		[Register("WEBVIEW_ERROR")]
		public static MaxAdapterError WebviewError
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterError>(MaxAdapterError._members.StaticFields.GetObjectValue("WEBVIEW_ERROR.Lcom/applovin/mediation/adapter/MaxAdapterError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0001ED3C File Offset: 0x0001CF3C
		internal new static IntPtr class_ref
		{
			get
			{
				return MaxAdapterError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0001ED60 File Offset: 0x0001CF60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxAdapterError._members;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0001ED68 File Offset: 0x0001CF68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxAdapterError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x0001ED8C File Offset: 0x0001CF8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxAdapterError._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0001ED98 File Offset: 0x0001CF98
		protected MaxAdapterError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0001EDA4 File Offset: 0x0001CFA4
		[Register(".ctor", "(Lcom/applovin/mediation/adapter/MaxAdapterError;ILjava/lang/String;)V", "")]
		public unsafe MaxAdapterError(MaxAdapterError p0, int p1, string p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p2);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue(intPtr);
				base.SetHandle(MaxAdapterError._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/mediation/adapter/MaxAdapterError;ILjava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxAdapterError._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/mediation/adapter/MaxAdapterError;ILjava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0001EE88 File Offset: 0x0001D088
		[Register(".ctor", "(I)V", "")]
		public unsafe MaxAdapterError(int p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			base.SetHandle(MaxAdapterError._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			MaxAdapterError._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0001EF0C File Offset: 0x0001D10C
		[Register(".ctor", "(II)V", "")]
		public unsafe MaxAdapterError(int p0, int p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			ptr[1] = new JniArgumentValue(p1);
			base.SetHandle(MaxAdapterError._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			MaxAdapterError._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0001EFA4 File Offset: 0x0001D1A4
		[Register(".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe MaxAdapterError(int p0, string p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(MaxAdapterError._members.InstanceMethods.StartCreateInstance("(ILjava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxAdapterError._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0001F05C File Offset: 0x0001D25C
		[Register(".ctor", "(ILjava/lang/String;ILjava/lang/String;)V", "")]
		public unsafe MaxAdapterError(int p0, string p1, int p2, string p3) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			IntPtr intPtr2 = JNIEnv.NewString(p3);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(p2);
				ptr[3] = new JniArgumentValue(intPtr2);
				base.SetHandle(MaxAdapterError._members.InstanceMethods.StartCreateInstance("(ILjava/lang/String;ILjava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxAdapterError._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/String;ILjava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0001F150 File Offset: 0x0001D350
		private static Delegate GetGetThirdPartySdkErrorCodeHandler()
		{
			if (MaxAdapterError.cb_getThirdPartySdkErrorCode == null)
			{
				MaxAdapterError.cb_getThirdPartySdkErrorCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MaxAdapterError.n_GetThirdPartySdkErrorCode));
			}
			return MaxAdapterError.cb_getThirdPartySdkErrorCode;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0001F174 File Offset: 0x0001D374
		private static int n_GetThirdPartySdkErrorCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxAdapterError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThirdPartySdkErrorCode;
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0001F183 File Offset: 0x0001D383
		public virtual int ThirdPartySdkErrorCode
		{
			[Register("getThirdPartySdkErrorCode", "()I", "GetGetThirdPartySdkErrorCodeHandler")]
			get
			{
				return MaxAdapterError._members.InstanceMethods.InvokeVirtualInt32Method("getThirdPartySdkErrorCode.()I", this, null);
			}
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0001F19C File Offset: 0x0001D39C
		private static Delegate GetGetThirdPartySdkErrorMessageHandler()
		{
			if (MaxAdapterError.cb_getThirdPartySdkErrorMessage == null)
			{
				MaxAdapterError.cb_getThirdPartySdkErrorMessage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdapterError.n_GetThirdPartySdkErrorMessage));
			}
			return MaxAdapterError.cb_getThirdPartySdkErrorMessage;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0001F1C0 File Offset: 0x0001D3C0
		private static IntPtr n_GetThirdPartySdkErrorMessage(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxAdapterError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThirdPartySdkErrorMessage);
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x0001F1D4 File Offset: 0x0001D3D4
		public virtual string ThirdPartySdkErrorMessage
		{
			[Register("getThirdPartySdkErrorMessage", "()Ljava/lang/String;", "GetGetThirdPartySdkErrorMessageHandler")]
			get
			{
				return JNIEnv.GetString(MaxAdapterError._members.InstanceMethods.InvokeVirtualObjectMethod("getThirdPartySdkErrorMessage.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040003B2 RID: 946
		[Register("ERROR_CODE_AD_DISPLAY_FAILED")]
		public const int ErrorCodeAdDisplayFailed = -4205;

		// Token: 0x040003B3 RID: 947
		[Register("ERROR_CODE_AD_EXPIRED")]
		public const int ErrorCodeAdExpired = -5213;

		// Token: 0x040003B4 RID: 948
		[Register("ERROR_CODE_AD_FREQUENCY_CAPPED")]
		public const int ErrorCodeAdFrequencyCapped = -5214;

		// Token: 0x040003B5 RID: 949
		[Register("ERROR_CODE_AD_NOT_READY")]
		public const int ErrorCodeAdNotReady = -5205;

		// Token: 0x040003B6 RID: 950
		[Register("ERROR_CODE_BAD_REQUEST")]
		public const int ErrorCodeBadRequest = -5203;

		// Token: 0x040003B7 RID: 951
		[Register("ERROR_CODE_INTERNAL_ERROR")]
		public const int ErrorCodeInternalError = -5209;

		// Token: 0x040003B8 RID: 952
		[Register("ERROR_CODE_INVALID_CONFIGURATION")]
		public const int ErrorCodeInvalidConfiguration = -5202;

		// Token: 0x040003B9 RID: 953
		[Register("ERROR_CODE_INVALID_LOAD_STATE")]
		public const int ErrorCodeInvalidLoadState = -5201;

		// Token: 0x040003BA RID: 954
		[Register("ERROR_CODE_MISSING_ACTIVITY")]
		public const int ErrorCodeMissingActivity = -5601;

		// Token: 0x040003BB RID: 955
		[Register("ERROR_CODE_MISSING_REQUIRED_NATIVE_AD_ASSETS")]
		public const int ErrorCodeMissingRequiredNativeAdAssets = -5400;

		// Token: 0x040003BC RID: 956
		[Register("ERROR_CODE_NOT_INITIALIZED")]
		public const int ErrorCodeNotInitialized = -5204;

		// Token: 0x040003BD RID: 957
		[Register("ERROR_CODE_NO_CONNECTION")]
		public const int ErrorCodeNoConnection = -5207;

		// Token: 0x040003BE RID: 958
		[Register("ERROR_CODE_NO_FILL")]
		public const int ErrorCodeNoFill = 204;

		// Token: 0x040003BF RID: 959
		[Register("ERROR_CODE_REWARD_ERROR")]
		public const int ErrorCodeRewardError = -5302;

		// Token: 0x040003C0 RID: 960
		[Register("ERROR_CODE_SERVER_ERROR")]
		public const int ErrorCodeServerError = -5208;

		// Token: 0x040003C1 RID: 961
		[Register("ERROR_CODE_SIGNAL_COLLECTION_NOT_SUPPORTED")]
		public const int ErrorCodeSignalCollectionNotSupported = -5211;

		// Token: 0x040003C2 RID: 962
		[Register("ERROR_CODE_SIGNAL_COLLECTION_TIMEOUT")]
		public const int ErrorCodeSignalCollectionTimeout = -5210;

		// Token: 0x040003C3 RID: 963
		[Register("ERROR_CODE_TIMEOUT")]
		public const int ErrorCodeTimeout = -5206;

		// Token: 0x040003C4 RID: 964
		[Register("ERROR_CODE_UNSPECIFIED")]
		public const int ErrorCodeUnspecified = -5200;

		// Token: 0x040003C5 RID: 965
		[Register("ERROR_CODE_WEBVIEW_ERROR")]
		public const int ErrorCodeWebviewError = -5212;

		// Token: 0x040003C6 RID: 966
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/MaxAdapterError", typeof(MaxAdapterError));

		// Token: 0x040003C7 RID: 967
		private static Delegate cb_getThirdPartySdkErrorCode;

		// Token: 0x040003C8 RID: 968
		private static Delegate cb_getThirdPartySdkErrorMessage;
	}
}
