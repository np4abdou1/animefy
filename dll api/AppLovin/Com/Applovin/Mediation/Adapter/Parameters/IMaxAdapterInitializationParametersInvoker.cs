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
	// Token: 0x02000110 RID: 272
	[Register("com/applovin/mediation/adapter/parameters/MaxAdapterInitializationParameters", DoNotGenerateAcw = true)]
	internal class IMaxAdapterInitializationParametersInvoker : Java.Lang.Object, IMaxAdapterInitializationParameters, IMaxAdapterParameters, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x0001F224 File Offset: 0x0001D424
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxAdapterInitializationParametersInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0001F248 File Offset: 0x0001D448
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxAdapterInitializationParametersInvoker._members;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x0001F24F File Offset: 0x0001D44F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x0001F257 File Offset: 0x0001D457
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxAdapterInitializationParametersInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0001F263 File Offset: 0x0001D463
		public static IMaxAdapterInitializationParameters GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxAdapterInitializationParameters>(handle, transfer);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0001F26C File Offset: 0x0001D46C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxAdapterInitializationParametersInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.parameters.MaxAdapterInitializationParameters'.");
			}
			return handle;
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0001F297 File Offset: 0x0001D497
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0001F2C8 File Offset: 0x0001D4C8
		public IMaxAdapterInitializationParametersInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxAdapterInitializationParametersInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0001F300 File Offset: 0x0001D500
		private static Delegate GetGetAdUnitIdHandler()
		{
			if (IMaxAdapterInitializationParametersInvoker.cb_getAdUnitId == null)
			{
				IMaxAdapterInitializationParametersInvoker.cb_getAdUnitId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterInitializationParametersInvoker.n_GetAdUnitId));
			}
			return IMaxAdapterInitializationParametersInvoker.cb_getAdUnitId;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0001F324 File Offset: 0x0001D524
		private static IntPtr n_GetAdUnitId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAdapterInitializationParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitId);
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x0001F338 File Offset: 0x0001D538
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

		// Token: 0x06000B72 RID: 2930 RVA: 0x0001F389 File Offset: 0x0001D589
		private static Delegate GetGetCustomParametersHandler()
		{
			if (IMaxAdapterInitializationParametersInvoker.cb_getCustomParameters == null)
			{
				IMaxAdapterInitializationParametersInvoker.cb_getCustomParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterInitializationParametersInvoker.n_GetCustomParameters));
			}
			return IMaxAdapterInitializationParametersInvoker.cb_getCustomParameters;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0001F3AD File Offset: 0x0001D5AD
		private static IntPtr n_GetCustomParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterInitializationParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CustomParameters);
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x0001F3C4 File Offset: 0x0001D5C4
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

		// Token: 0x06000B75 RID: 2933 RVA: 0x0001F415 File Offset: 0x0001D615
		private static Delegate GetIsTestingHandler()
		{
			if (IMaxAdapterInitializationParametersInvoker.cb_isTesting == null)
			{
				IMaxAdapterInitializationParametersInvoker.cb_isTesting = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMaxAdapterInitializationParametersInvoker.n_IsTesting));
			}
			return IMaxAdapterInitializationParametersInvoker.cb_isTesting;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0001F439 File Offset: 0x0001D639
		private static bool n_IsTesting(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMaxAdapterInitializationParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTesting;
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0001F448 File Offset: 0x0001D648
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

		// Token: 0x06000B78 RID: 2936 RVA: 0x0001F488 File Offset: 0x0001D688
		private static Delegate GetGetLocalExtraParametersHandler()
		{
			if (IMaxAdapterInitializationParametersInvoker.cb_getLocalExtraParameters == null)
			{
				IMaxAdapterInitializationParametersInvoker.cb_getLocalExtraParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterInitializationParametersInvoker.n_GetLocalExtraParameters));
			}
			return IMaxAdapterInitializationParametersInvoker.cb_getLocalExtraParameters;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0001F4AC File Offset: 0x0001D6AC
		private static IntPtr n_GetLocalExtraParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterInitializationParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LocalExtraParameters);
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x0001F4C0 File Offset: 0x0001D6C0
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

		// Token: 0x06000B7B RID: 2939 RVA: 0x0001F511 File Offset: 0x0001D711
		private static Delegate GetGetServerParametersHandler()
		{
			if (IMaxAdapterInitializationParametersInvoker.cb_getServerParameters == null)
			{
				IMaxAdapterInitializationParametersInvoker.cb_getServerParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterInitializationParametersInvoker.n_GetServerParameters));
			}
			return IMaxAdapterInitializationParametersInvoker.cb_getServerParameters;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0001F535 File Offset: 0x0001D735
		private static IntPtr n_GetServerParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterInitializationParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ServerParameters);
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x0001F54C File Offset: 0x0001D74C
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

		// Token: 0x06000B7E RID: 2942 RVA: 0x0001F59D File Offset: 0x0001D79D
		private static Delegate GetHasUserConsentHandler()
		{
			if (IMaxAdapterInitializationParametersInvoker.cb_hasUserConsent == null)
			{
				IMaxAdapterInitializationParametersInvoker.cb_hasUserConsent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterInitializationParametersInvoker.n_HasUserConsent));
			}
			return IMaxAdapterInitializationParametersInvoker.cb_hasUserConsent;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0001F5C1 File Offset: 0x0001D7C1
		private static IntPtr n_HasUserConsent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterInitializationParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasUserConsent());
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0001F5D8 File Offset: 0x0001D7D8
		public Java.Lang.Boolean HasUserConsent()
		{
			if (this.id_hasUserConsent == IntPtr.Zero)
			{
				this.id_hasUserConsent = JNIEnv.GetMethodID(this.class_ref, "hasUserConsent", "()Ljava/lang/Boolean;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(JNIEnv.CallObjectMethod(base.Handle, this.id_hasUserConsent), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0001F629 File Offset: 0x0001D829
		private static Delegate GetIsAgeRestrictedUserHandler()
		{
			if (IMaxAdapterInitializationParametersInvoker.cb_isAgeRestrictedUser == null)
			{
				IMaxAdapterInitializationParametersInvoker.cb_isAgeRestrictedUser = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterInitializationParametersInvoker.n_IsAgeRestrictedUser));
			}
			return IMaxAdapterInitializationParametersInvoker.cb_isAgeRestrictedUser;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0001F64D File Offset: 0x0001D84D
		private static IntPtr n_IsAgeRestrictedUser(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterInitializationParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAgeRestrictedUser());
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0001F664 File Offset: 0x0001D864
		public Java.Lang.Boolean IsAgeRestrictedUser()
		{
			if (this.id_isAgeRestrictedUser == IntPtr.Zero)
			{
				this.id_isAgeRestrictedUser = JNIEnv.GetMethodID(this.class_ref, "isAgeRestrictedUser", "()Ljava/lang/Boolean;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(JNIEnv.CallObjectMethod(base.Handle, this.id_isAgeRestrictedUser), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private static Delegate GetIsDoNotSellHandler()
		{
			if (IMaxAdapterInitializationParametersInvoker.cb_isDoNotSell == null)
			{
				IMaxAdapterInitializationParametersInvoker.cb_isDoNotSell = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterInitializationParametersInvoker.n_IsDoNotSell));
			}
			return IMaxAdapterInitializationParametersInvoker.cb_isDoNotSell;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0001F6D9 File Offset: 0x0001D8D9
		private static IntPtr n_IsDoNotSell(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterInitializationParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDoNotSell());
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0001F6F0 File Offset: 0x0001D8F0
		public Java.Lang.Boolean IsDoNotSell()
		{
			if (this.id_isDoNotSell == IntPtr.Zero)
			{
				this.id_isDoNotSell = JNIEnv.GetMethodID(this.class_ref, "isDoNotSell", "()Ljava/lang/Boolean;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(JNIEnv.CallObjectMethod(base.Handle, this.id_isDoNotSell), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040003C9 RID: 969
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/parameters/MaxAdapterInitializationParameters", typeof(IMaxAdapterInitializationParametersInvoker));

		// Token: 0x040003CA RID: 970
		private IntPtr class_ref;

		// Token: 0x040003CB RID: 971
		private static Delegate cb_getAdUnitId;

		// Token: 0x040003CC RID: 972
		private IntPtr id_getAdUnitId;

		// Token: 0x040003CD RID: 973
		private static Delegate cb_getCustomParameters;

		// Token: 0x040003CE RID: 974
		private IntPtr id_getCustomParameters;

		// Token: 0x040003CF RID: 975
		private static Delegate cb_isTesting;

		// Token: 0x040003D0 RID: 976
		private IntPtr id_isTesting;

		// Token: 0x040003D1 RID: 977
		private static Delegate cb_getLocalExtraParameters;

		// Token: 0x040003D2 RID: 978
		private IntPtr id_getLocalExtraParameters;

		// Token: 0x040003D3 RID: 979
		private static Delegate cb_getServerParameters;

		// Token: 0x040003D4 RID: 980
		private IntPtr id_getServerParameters;

		// Token: 0x040003D5 RID: 981
		private static Delegate cb_hasUserConsent;

		// Token: 0x040003D6 RID: 982
		private IntPtr id_hasUserConsent;

		// Token: 0x040003D7 RID: 983
		private static Delegate cb_isAgeRestrictedUser;

		// Token: 0x040003D8 RID: 984
		private IntPtr id_isAgeRestrictedUser;

		// Token: 0x040003D9 RID: 985
		private static Delegate cb_isDoNotSell;

		// Token: 0x040003DA RID: 986
		private IntPtr id_isDoNotSell;
	}
}
