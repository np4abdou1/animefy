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
	// Token: 0x02000116 RID: 278
	[Register("com/applovin/mediation/adapter/parameters/MaxAdapterSignalCollectionParameters", DoNotGenerateAcw = true)]
	internal class IMaxAdapterSignalCollectionParametersInvoker : Java.Lang.Object, IMaxAdapterSignalCollectionParameters, IMaxAdapterParameters, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x00020358 File Offset: 0x0001E558
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxAdapterSignalCollectionParametersInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x0002037C File Offset: 0x0001E57C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxAdapterSignalCollectionParametersInvoker._members;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00020383 File Offset: 0x0001E583
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0002038B File Offset: 0x0001E58B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxAdapterSignalCollectionParametersInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00020397 File Offset: 0x0001E597
		public static IMaxAdapterSignalCollectionParameters GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxAdapterSignalCollectionParameters>(handle, transfer);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x000203A0 File Offset: 0x0001E5A0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxAdapterSignalCollectionParametersInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.parameters.MaxAdapterSignalCollectionParameters'.");
			}
			return handle;
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x000203CB File Offset: 0x0001E5CB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x000203FC File Offset: 0x0001E5FC
		public IMaxAdapterSignalCollectionParametersInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxAdapterSignalCollectionParametersInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00020434 File Offset: 0x0001E634
		private static Delegate GetGetAdFormatHandler()
		{
			if (IMaxAdapterSignalCollectionParametersInvoker.cb_getAdFormat == null)
			{
				IMaxAdapterSignalCollectionParametersInvoker.cb_getAdFormat = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterSignalCollectionParametersInvoker.n_GetAdFormat));
			}
			return IMaxAdapterSignalCollectionParametersInvoker.cb_getAdFormat;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00020458 File Offset: 0x0001E658
		private static IntPtr n_GetAdFormat(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterSignalCollectionParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdFormat);
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x0002046C File Offset: 0x0001E66C
		public MaxAdFormat AdFormat
		{
			get
			{
				if (this.id_getAdFormat == IntPtr.Zero)
				{
					this.id_getAdFormat = JNIEnv.GetMethodID(this.class_ref, "getAdFormat", "()Lcom/applovin/mediation/MaxAdFormat;");
				}
				return Java.Lang.Object.GetObject<MaxAdFormat>(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdFormat), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x000204BD File Offset: 0x0001E6BD
		private static Delegate GetGetAdUnitIdHandler()
		{
			if (IMaxAdapterSignalCollectionParametersInvoker.cb_getAdUnitId == null)
			{
				IMaxAdapterSignalCollectionParametersInvoker.cb_getAdUnitId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterSignalCollectionParametersInvoker.n_GetAdUnitId));
			}
			return IMaxAdapterSignalCollectionParametersInvoker.cb_getAdUnitId;
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x000204E1 File Offset: 0x0001E6E1
		private static IntPtr n_GetAdUnitId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAdapterSignalCollectionParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitId);
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x000204F8 File Offset: 0x0001E6F8
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

		// Token: 0x06000BED RID: 3053 RVA: 0x00020549 File Offset: 0x0001E749
		private static Delegate GetGetCustomParametersHandler()
		{
			if (IMaxAdapterSignalCollectionParametersInvoker.cb_getCustomParameters == null)
			{
				IMaxAdapterSignalCollectionParametersInvoker.cb_getCustomParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterSignalCollectionParametersInvoker.n_GetCustomParameters));
			}
			return IMaxAdapterSignalCollectionParametersInvoker.cb_getCustomParameters;
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0002056D File Offset: 0x0001E76D
		private static IntPtr n_GetCustomParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterSignalCollectionParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CustomParameters);
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00020584 File Offset: 0x0001E784
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

		// Token: 0x06000BF0 RID: 3056 RVA: 0x000205D5 File Offset: 0x0001E7D5
		private static Delegate GetIsTestingHandler()
		{
			if (IMaxAdapterSignalCollectionParametersInvoker.cb_isTesting == null)
			{
				IMaxAdapterSignalCollectionParametersInvoker.cb_isTesting = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMaxAdapterSignalCollectionParametersInvoker.n_IsTesting));
			}
			return IMaxAdapterSignalCollectionParametersInvoker.cb_isTesting;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x000205F9 File Offset: 0x0001E7F9
		private static bool n_IsTesting(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMaxAdapterSignalCollectionParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTesting;
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00020608 File Offset: 0x0001E808
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

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00020648 File Offset: 0x0001E848
		private static Delegate GetGetLocalExtraParametersHandler()
		{
			if (IMaxAdapterSignalCollectionParametersInvoker.cb_getLocalExtraParameters == null)
			{
				IMaxAdapterSignalCollectionParametersInvoker.cb_getLocalExtraParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterSignalCollectionParametersInvoker.n_GetLocalExtraParameters));
			}
			return IMaxAdapterSignalCollectionParametersInvoker.cb_getLocalExtraParameters;
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0002066C File Offset: 0x0001E86C
		private static IntPtr n_GetLocalExtraParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterSignalCollectionParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LocalExtraParameters);
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00020680 File Offset: 0x0001E880
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

		// Token: 0x06000BF6 RID: 3062 RVA: 0x000206D1 File Offset: 0x0001E8D1
		private static Delegate GetGetServerParametersHandler()
		{
			if (IMaxAdapterSignalCollectionParametersInvoker.cb_getServerParameters == null)
			{
				IMaxAdapterSignalCollectionParametersInvoker.cb_getServerParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterSignalCollectionParametersInvoker.n_GetServerParameters));
			}
			return IMaxAdapterSignalCollectionParametersInvoker.cb_getServerParameters;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x000206F5 File Offset: 0x0001E8F5
		private static IntPtr n_GetServerParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterSignalCollectionParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ServerParameters);
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0002070C File Offset: 0x0001E90C
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

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0002075D File Offset: 0x0001E95D
		private static Delegate GetHasUserConsentHandler()
		{
			if (IMaxAdapterSignalCollectionParametersInvoker.cb_hasUserConsent == null)
			{
				IMaxAdapterSignalCollectionParametersInvoker.cb_hasUserConsent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterSignalCollectionParametersInvoker.n_HasUserConsent));
			}
			return IMaxAdapterSignalCollectionParametersInvoker.cb_hasUserConsent;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00020781 File Offset: 0x0001E981
		private static IntPtr n_HasUserConsent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterSignalCollectionParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasUserConsent());
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00020798 File Offset: 0x0001E998
		public Java.Lang.Boolean HasUserConsent()
		{
			if (this.id_hasUserConsent == IntPtr.Zero)
			{
				this.id_hasUserConsent = JNIEnv.GetMethodID(this.class_ref, "hasUserConsent", "()Ljava/lang/Boolean;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(JNIEnv.CallObjectMethod(base.Handle, this.id_hasUserConsent), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x000207E9 File Offset: 0x0001E9E9
		private static Delegate GetIsAgeRestrictedUserHandler()
		{
			if (IMaxAdapterSignalCollectionParametersInvoker.cb_isAgeRestrictedUser == null)
			{
				IMaxAdapterSignalCollectionParametersInvoker.cb_isAgeRestrictedUser = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterSignalCollectionParametersInvoker.n_IsAgeRestrictedUser));
			}
			return IMaxAdapterSignalCollectionParametersInvoker.cb_isAgeRestrictedUser;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0002080D File Offset: 0x0001EA0D
		private static IntPtr n_IsAgeRestrictedUser(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterSignalCollectionParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAgeRestrictedUser());
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00020824 File Offset: 0x0001EA24
		public Java.Lang.Boolean IsAgeRestrictedUser()
		{
			if (this.id_isAgeRestrictedUser == IntPtr.Zero)
			{
				this.id_isAgeRestrictedUser = JNIEnv.GetMethodID(this.class_ref, "isAgeRestrictedUser", "()Ljava/lang/Boolean;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(JNIEnv.CallObjectMethod(base.Handle, this.id_isAgeRestrictedUser), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00020875 File Offset: 0x0001EA75
		private static Delegate GetIsDoNotSellHandler()
		{
			if (IMaxAdapterSignalCollectionParametersInvoker.cb_isDoNotSell == null)
			{
				IMaxAdapterSignalCollectionParametersInvoker.cb_isDoNotSell = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterSignalCollectionParametersInvoker.n_IsDoNotSell));
			}
			return IMaxAdapterSignalCollectionParametersInvoker.cb_isDoNotSell;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00020899 File Offset: 0x0001EA99
		private static IntPtr n_IsDoNotSell(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterSignalCollectionParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDoNotSell());
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x000208B0 File Offset: 0x0001EAB0
		public Java.Lang.Boolean IsDoNotSell()
		{
			if (this.id_isDoNotSell == IntPtr.Zero)
			{
				this.id_isDoNotSell = JNIEnv.GetMethodID(this.class_ref, "isDoNotSell", "()Ljava/lang/Boolean;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(JNIEnv.CallObjectMethod(base.Handle, this.id_isDoNotSell), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000405 RID: 1029
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/parameters/MaxAdapterSignalCollectionParameters", typeof(IMaxAdapterSignalCollectionParametersInvoker));

		// Token: 0x04000406 RID: 1030
		private IntPtr class_ref;

		// Token: 0x04000407 RID: 1031
		private static Delegate cb_getAdFormat;

		// Token: 0x04000408 RID: 1032
		private IntPtr id_getAdFormat;

		// Token: 0x04000409 RID: 1033
		private static Delegate cb_getAdUnitId;

		// Token: 0x0400040A RID: 1034
		private IntPtr id_getAdUnitId;

		// Token: 0x0400040B RID: 1035
		private static Delegate cb_getCustomParameters;

		// Token: 0x0400040C RID: 1036
		private IntPtr id_getCustomParameters;

		// Token: 0x0400040D RID: 1037
		private static Delegate cb_isTesting;

		// Token: 0x0400040E RID: 1038
		private IntPtr id_isTesting;

		// Token: 0x0400040F RID: 1039
		private static Delegate cb_getLocalExtraParameters;

		// Token: 0x04000410 RID: 1040
		private IntPtr id_getLocalExtraParameters;

		// Token: 0x04000411 RID: 1041
		private static Delegate cb_getServerParameters;

		// Token: 0x04000412 RID: 1042
		private IntPtr id_getServerParameters;

		// Token: 0x04000413 RID: 1043
		private static Delegate cb_hasUserConsent;

		// Token: 0x04000414 RID: 1044
		private IntPtr id_hasUserConsent;

		// Token: 0x04000415 RID: 1045
		private static Delegate cb_isAgeRestrictedUser;

		// Token: 0x04000416 RID: 1046
		private IntPtr id_isAgeRestrictedUser;

		// Token: 0x04000417 RID: 1047
		private static Delegate cb_isDoNotSell;

		// Token: 0x04000418 RID: 1048
		private IntPtr id_isDoNotSell;
	}
}
