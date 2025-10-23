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
	// Token: 0x02000112 RID: 274
	[Register("com/applovin/mediation/adapter/parameters/MaxAdapterParameters", DoNotGenerateAcw = true)]
	internal class IMaxAdapterParametersInvoker : Java.Lang.Object, IMaxAdapterParameters, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0001F75C File Offset: 0x0001D95C
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxAdapterParametersInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x0001F780 File Offset: 0x0001D980
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxAdapterParametersInvoker._members;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x0001F787 File Offset: 0x0001D987
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0001F78F File Offset: 0x0001D98F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxAdapterParametersInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0001F79B File Offset: 0x0001D99B
		public static IMaxAdapterParameters GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxAdapterParameters>(handle, transfer);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0001F7A4 File Offset: 0x0001D9A4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxAdapterParametersInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.parameters.MaxAdapterParameters'.");
			}
			return handle;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0001F7CF File Offset: 0x0001D9CF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0001F800 File Offset: 0x0001DA00
		public IMaxAdapterParametersInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxAdapterParametersInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0001F838 File Offset: 0x0001DA38
		private static Delegate GetGetAdUnitIdHandler()
		{
			if (IMaxAdapterParametersInvoker.cb_getAdUnitId == null)
			{
				IMaxAdapterParametersInvoker.cb_getAdUnitId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterParametersInvoker.n_GetAdUnitId));
			}
			return IMaxAdapterParametersInvoker.cb_getAdUnitId;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x0001F85C File Offset: 0x0001DA5C
		private static IntPtr n_GetAdUnitId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAdapterParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitId);
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0001F870 File Offset: 0x0001DA70
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

		// Token: 0x06000B9B RID: 2971 RVA: 0x0001F8C1 File Offset: 0x0001DAC1
		private static Delegate GetGetCustomParametersHandler()
		{
			if (IMaxAdapterParametersInvoker.cb_getCustomParameters == null)
			{
				IMaxAdapterParametersInvoker.cb_getCustomParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterParametersInvoker.n_GetCustomParameters));
			}
			return IMaxAdapterParametersInvoker.cb_getCustomParameters;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0001F8E5 File Offset: 0x0001DAE5
		private static IntPtr n_GetCustomParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CustomParameters);
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x0001F8FC File Offset: 0x0001DAFC
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

		// Token: 0x06000B9E RID: 2974 RVA: 0x0001F94D File Offset: 0x0001DB4D
		private static Delegate GetIsTestingHandler()
		{
			if (IMaxAdapterParametersInvoker.cb_isTesting == null)
			{
				IMaxAdapterParametersInvoker.cb_isTesting = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMaxAdapterParametersInvoker.n_IsTesting));
			}
			return IMaxAdapterParametersInvoker.cb_isTesting;
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0001F971 File Offset: 0x0001DB71
		private static bool n_IsTesting(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMaxAdapterParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTesting;
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x0001F980 File Offset: 0x0001DB80
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

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0001F9C0 File Offset: 0x0001DBC0
		private static Delegate GetGetLocalExtraParametersHandler()
		{
			if (IMaxAdapterParametersInvoker.cb_getLocalExtraParameters == null)
			{
				IMaxAdapterParametersInvoker.cb_getLocalExtraParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterParametersInvoker.n_GetLocalExtraParameters));
			}
			return IMaxAdapterParametersInvoker.cb_getLocalExtraParameters;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0001F9E4 File Offset: 0x0001DBE4
		private static IntPtr n_GetLocalExtraParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LocalExtraParameters);
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x0001F9F8 File Offset: 0x0001DBF8
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

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0001FA49 File Offset: 0x0001DC49
		private static Delegate GetGetServerParametersHandler()
		{
			if (IMaxAdapterParametersInvoker.cb_getServerParameters == null)
			{
				IMaxAdapterParametersInvoker.cb_getServerParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterParametersInvoker.n_GetServerParameters));
			}
			return IMaxAdapterParametersInvoker.cb_getServerParameters;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0001FA6D File Offset: 0x0001DC6D
		private static IntPtr n_GetServerParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ServerParameters);
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x0001FA84 File Offset: 0x0001DC84
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

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0001FAD5 File Offset: 0x0001DCD5
		private static Delegate GetHasUserConsentHandler()
		{
			if (IMaxAdapterParametersInvoker.cb_hasUserConsent == null)
			{
				IMaxAdapterParametersInvoker.cb_hasUserConsent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterParametersInvoker.n_HasUserConsent));
			}
			return IMaxAdapterParametersInvoker.cb_hasUserConsent;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0001FAF9 File Offset: 0x0001DCF9
		private static IntPtr n_HasUserConsent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasUserConsent());
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0001FB10 File Offset: 0x0001DD10
		public Java.Lang.Boolean HasUserConsent()
		{
			if (this.id_hasUserConsent == IntPtr.Zero)
			{
				this.id_hasUserConsent = JNIEnv.GetMethodID(this.class_ref, "hasUserConsent", "()Ljava/lang/Boolean;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(JNIEnv.CallObjectMethod(base.Handle, this.id_hasUserConsent), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0001FB61 File Offset: 0x0001DD61
		private static Delegate GetIsAgeRestrictedUserHandler()
		{
			if (IMaxAdapterParametersInvoker.cb_isAgeRestrictedUser == null)
			{
				IMaxAdapterParametersInvoker.cb_isAgeRestrictedUser = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterParametersInvoker.n_IsAgeRestrictedUser));
			}
			return IMaxAdapterParametersInvoker.cb_isAgeRestrictedUser;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0001FB85 File Offset: 0x0001DD85
		private static IntPtr n_IsAgeRestrictedUser(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAgeRestrictedUser());
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0001FB9C File Offset: 0x0001DD9C
		public Java.Lang.Boolean IsAgeRestrictedUser()
		{
			if (this.id_isAgeRestrictedUser == IntPtr.Zero)
			{
				this.id_isAgeRestrictedUser = JNIEnv.GetMethodID(this.class_ref, "isAgeRestrictedUser", "()Ljava/lang/Boolean;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(JNIEnv.CallObjectMethod(base.Handle, this.id_isAgeRestrictedUser), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0001FBED File Offset: 0x0001DDED
		private static Delegate GetIsDoNotSellHandler()
		{
			if (IMaxAdapterParametersInvoker.cb_isDoNotSell == null)
			{
				IMaxAdapterParametersInvoker.cb_isDoNotSell = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterParametersInvoker.n_IsDoNotSell));
			}
			return IMaxAdapterParametersInvoker.cb_isDoNotSell;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0001FC11 File Offset: 0x0001DE11
		private static IntPtr n_IsDoNotSell(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdapterParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDoNotSell());
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0001FC28 File Offset: 0x0001DE28
		public Java.Lang.Boolean IsDoNotSell()
		{
			if (this.id_isDoNotSell == IntPtr.Zero)
			{
				this.id_isDoNotSell = JNIEnv.GetMethodID(this.class_ref, "isDoNotSell", "()Ljava/lang/Boolean;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Boolean>(JNIEnv.CallObjectMethod(base.Handle, this.id_isDoNotSell), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040003DB RID: 987
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/parameters/MaxAdapterParameters", typeof(IMaxAdapterParametersInvoker));

		// Token: 0x040003DC RID: 988
		private IntPtr class_ref;

		// Token: 0x040003DD RID: 989
		private static Delegate cb_getAdUnitId;

		// Token: 0x040003DE RID: 990
		private IntPtr id_getAdUnitId;

		// Token: 0x040003DF RID: 991
		private static Delegate cb_getCustomParameters;

		// Token: 0x040003E0 RID: 992
		private IntPtr id_getCustomParameters;

		// Token: 0x040003E1 RID: 993
		private static Delegate cb_isTesting;

		// Token: 0x040003E2 RID: 994
		private IntPtr id_isTesting;

		// Token: 0x040003E3 RID: 995
		private static Delegate cb_getLocalExtraParameters;

		// Token: 0x040003E4 RID: 996
		private IntPtr id_getLocalExtraParameters;

		// Token: 0x040003E5 RID: 997
		private static Delegate cb_getServerParameters;

		// Token: 0x040003E6 RID: 998
		private IntPtr id_getServerParameters;

		// Token: 0x040003E7 RID: 999
		private static Delegate cb_hasUserConsent;

		// Token: 0x040003E8 RID: 1000
		private IntPtr id_hasUserConsent;

		// Token: 0x040003E9 RID: 1001
		private static Delegate cb_isAgeRestrictedUser;

		// Token: 0x040003EA RID: 1002
		private IntPtr id_isAgeRestrictedUser;

		// Token: 0x040003EB RID: 1003
		private static Delegate cb_isDoNotSell;

		// Token: 0x040003EC RID: 1004
		private IntPtr id_isDoNotSell;
	}
}
