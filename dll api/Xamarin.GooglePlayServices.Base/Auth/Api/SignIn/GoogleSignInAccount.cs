using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Accounts;
using Android.Gms.Common.Apis;
using Android.Gms.Common.Internal.SafeParcel;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Auth.Api.SignIn
{
	// Token: 0x02000015 RID: 21
	[Register("com/google/android/gms/auth/api/signin/GoogleSignInAccount", DoNotGenerateAcw = true)]
	public class GoogleSignInAccount : AbstractSafeParcelable, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Register("describeContents", "()I", "")]
		public new int DescribeContents()
		{
			if (GoogleSignInAccount.id_describeContents == IntPtr.Zero)
			{
				GoogleSignInAccount.id_describeContents = JNIEnv.GetMethodID(GoogleSignInAccount.class_ref, "describeContents", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, GoogleSignInAccount.id_describeContents);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0000208C File Offset: 0x0000028C
		[Register("CREATOR")]
		public static IParcelableCreator Creator
		{
			get
			{
				return Java.Lang.Object.GetObject<IParcelableCreator>(GoogleSignInAccount._members.StaticFields.GetObjectValue("CREATOR.Landroid/os/Parcelable$Creator;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000020BC File Offset: 0x000002BC
		internal static IntPtr class_ref
		{
			get
			{
				return GoogleSignInAccount._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000020E0 File Offset: 0x000002E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GoogleSignInAccount._members;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000020E8 File Offset: 0x000002E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GoogleSignInAccount._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000210C File Offset: 0x0000030C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GoogleSignInAccount._members.ManagedPeerType;
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002118 File Offset: 0x00000318
		protected GoogleSignInAccount(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002122 File Offset: 0x00000322
		private static Delegate GetGetAccountHandler()
		{
			if (GoogleSignInAccount.cb_getAccount == null)
			{
				GoogleSignInAccount.cb_getAccount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInAccount.n_GetAccount));
			}
			return GoogleSignInAccount.cb_getAccount;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002146 File Offset: 0x00000346
		private static IntPtr n_GetAccount(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleSignInAccount>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Account);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000215C File Offset: 0x0000035C
		public virtual Account Account
		{
			[Register("getAccount", "()Landroid/accounts/Account;", "GetGetAccountHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Account>(GoogleSignInAccount._members.InstanceMethods.InvokeVirtualObjectMethod("getAccount.()Landroid/accounts/Account;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000218E File Offset: 0x0000038E
		private static Delegate GetGetDisplayNameHandler()
		{
			if (GoogleSignInAccount.cb_getDisplayName == null)
			{
				GoogleSignInAccount.cb_getDisplayName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInAccount.n_GetDisplayName));
			}
			return GoogleSignInAccount.cb_getDisplayName;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000021B2 File Offset: 0x000003B2
		private static IntPtr n_GetDisplayName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<GoogleSignInAccount>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisplayName);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000021C8 File Offset: 0x000003C8
		public virtual string DisplayName
		{
			[Register("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get
			{
				return JNIEnv.GetString(GoogleSignInAccount._members.InstanceMethods.InvokeVirtualObjectMethod("getDisplayName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000021FA File Offset: 0x000003FA
		private static Delegate GetGetEmailHandler()
		{
			if (GoogleSignInAccount.cb_getEmail == null)
			{
				GoogleSignInAccount.cb_getEmail = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInAccount.n_GetEmail));
			}
			return GoogleSignInAccount.cb_getEmail;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000221E File Offset: 0x0000041E
		private static IntPtr n_GetEmail(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<GoogleSignInAccount>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Email);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002234 File Offset: 0x00000434
		public virtual string Email
		{
			[Register("getEmail", "()Ljava/lang/String;", "GetGetEmailHandler")]
			get
			{
				return JNIEnv.GetString(GoogleSignInAccount._members.InstanceMethods.InvokeVirtualObjectMethod("getEmail.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002266 File Offset: 0x00000466
		private static Delegate GetGetFamilyNameHandler()
		{
			if (GoogleSignInAccount.cb_getFamilyName == null)
			{
				GoogleSignInAccount.cb_getFamilyName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInAccount.n_GetFamilyName));
			}
			return GoogleSignInAccount.cb_getFamilyName;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000228A File Offset: 0x0000048A
		private static IntPtr n_GetFamilyName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<GoogleSignInAccount>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FamilyName);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000022A0 File Offset: 0x000004A0
		public virtual string FamilyName
		{
			[Register("getFamilyName", "()Ljava/lang/String;", "GetGetFamilyNameHandler")]
			get
			{
				return JNIEnv.GetString(GoogleSignInAccount._members.InstanceMethods.InvokeVirtualObjectMethod("getFamilyName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000022D2 File Offset: 0x000004D2
		private static Delegate GetGetGivenNameHandler()
		{
			if (GoogleSignInAccount.cb_getGivenName == null)
			{
				GoogleSignInAccount.cb_getGivenName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInAccount.n_GetGivenName));
			}
			return GoogleSignInAccount.cb_getGivenName;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000022F6 File Offset: 0x000004F6
		private static IntPtr n_GetGivenName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<GoogleSignInAccount>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GivenName);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000230C File Offset: 0x0000050C
		public virtual string GivenName
		{
			[Register("getGivenName", "()Ljava/lang/String;", "GetGetGivenNameHandler")]
			get
			{
				return JNIEnv.GetString(GoogleSignInAccount._members.InstanceMethods.InvokeVirtualObjectMethod("getGivenName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000233E File Offset: 0x0000053E
		private static Delegate GetGetGrantedScopesHandler()
		{
			if (GoogleSignInAccount.cb_getGrantedScopes == null)
			{
				GoogleSignInAccount.cb_getGrantedScopes = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInAccount.n_GetGrantedScopes));
			}
			return GoogleSignInAccount.cb_getGrantedScopes;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002362 File Offset: 0x00000562
		private static IntPtr n_GetGrantedScopes(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet<Scope>.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleSignInAccount>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GrantedScopes);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002378 File Offset: 0x00000578
		public virtual ICollection<Scope> GrantedScopes
		{
			[Register("getGrantedScopes", "()Ljava/util/Set;", "GetGetGrantedScopesHandler")]
			get
			{
				return JavaSet<Scope>.FromJniHandle(GoogleSignInAccount._members.InstanceMethods.InvokeVirtualObjectMethod("getGrantedScopes.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000023AA File Offset: 0x000005AA
		private static Delegate GetGetIdHandler()
		{
			if (GoogleSignInAccount.cb_getId == null)
			{
				GoogleSignInAccount.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInAccount.n_GetId));
			}
			return GoogleSignInAccount.cb_getId;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000023CE File Offset: 0x000005CE
		private static IntPtr n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<GoogleSignInAccount>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000023E4 File Offset: 0x000005E4
		public virtual string Id
		{
			[Register("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get
			{
				return JNIEnv.GetString(GoogleSignInAccount._members.InstanceMethods.InvokeVirtualObjectMethod("getId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002416 File Offset: 0x00000616
		private static Delegate GetGetIdTokenHandler()
		{
			if (GoogleSignInAccount.cb_getIdToken == null)
			{
				GoogleSignInAccount.cb_getIdToken = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInAccount.n_GetIdToken));
			}
			return GoogleSignInAccount.cb_getIdToken;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000243A File Offset: 0x0000063A
		private static IntPtr n_GetIdToken(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<GoogleSignInAccount>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IdToken);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002450 File Offset: 0x00000650
		public virtual string IdToken
		{
			[Register("getIdToken", "()Ljava/lang/String;", "GetGetIdTokenHandler")]
			get
			{
				return JNIEnv.GetString(GoogleSignInAccount._members.InstanceMethods.InvokeVirtualObjectMethod("getIdToken.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002482 File Offset: 0x00000682
		private static Delegate GetIsExpiredHandler()
		{
			if (GoogleSignInAccount.cb_isExpired == null)
			{
				GoogleSignInAccount.cb_isExpired = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(GoogleSignInAccount.n_IsExpired));
			}
			return GoogleSignInAccount.cb_isExpired;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000024A6 File Offset: 0x000006A6
		private static bool n_IsExpired(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GoogleSignInAccount>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExpired;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000024B5 File Offset: 0x000006B5
		public virtual bool IsExpired
		{
			[Register("isExpired", "()Z", "GetIsExpiredHandler")]
			get
			{
				return GoogleSignInAccount._members.InstanceMethods.InvokeVirtualBooleanMethod("isExpired.()Z", this, null);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000024CE File Offset: 0x000006CE
		private static Delegate GetGetPhotoUrlHandler()
		{
			if (GoogleSignInAccount.cb_getPhotoUrl == null)
			{
				GoogleSignInAccount.cb_getPhotoUrl = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInAccount.n_GetPhotoUrl));
			}
			return GoogleSignInAccount.cb_getPhotoUrl;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000024F2 File Offset: 0x000006F2
		private static IntPtr n_GetPhotoUrl(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleSignInAccount>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PhotoUrl);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002508 File Offset: 0x00000708
		public virtual Android.Net.Uri PhotoUrl
		{
			[Register("getPhotoUrl", "()Landroid/net/Uri;", "GetGetPhotoUrlHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Android.Net.Uri>(GoogleSignInAccount._members.InstanceMethods.InvokeVirtualObjectMethod("getPhotoUrl.()Landroid/net/Uri;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000253A File Offset: 0x0000073A
		private static Delegate GetGetRequestedScopesHandler()
		{
			if (GoogleSignInAccount.cb_getRequestedScopes == null)
			{
				GoogleSignInAccount.cb_getRequestedScopes = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInAccount.n_GetRequestedScopes));
			}
			return GoogleSignInAccount.cb_getRequestedScopes;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000255E File Offset: 0x0000075E
		private static IntPtr n_GetRequestedScopes(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet<Scope>.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleSignInAccount>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestedScopes);
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002574 File Offset: 0x00000774
		public virtual ICollection<Scope> RequestedScopes
		{
			[Register("getRequestedScopes", "()Ljava/util/Set;", "GetGetRequestedScopesHandler")]
			get
			{
				return JavaSet<Scope>.FromJniHandle(GoogleSignInAccount._members.InstanceMethods.InvokeVirtualObjectMethod("getRequestedScopes.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000025A6 File Offset: 0x000007A6
		private static Delegate GetGetServerAuthCodeHandler()
		{
			if (GoogleSignInAccount.cb_getServerAuthCode == null)
			{
				GoogleSignInAccount.cb_getServerAuthCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInAccount.n_GetServerAuthCode));
			}
			return GoogleSignInAccount.cb_getServerAuthCode;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000025CA File Offset: 0x000007CA
		private static IntPtr n_GetServerAuthCode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<GoogleSignInAccount>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ServerAuthCode);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000025E0 File Offset: 0x000007E0
		public virtual string ServerAuthCode
		{
			[Register("getServerAuthCode", "()Ljava/lang/String;", "GetGetServerAuthCodeHandler")]
			get
			{
				return JNIEnv.GetString(GoogleSignInAccount._members.InstanceMethods.InvokeVirtualObjectMethod("getServerAuthCode.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002614 File Offset: 0x00000814
		[Register("createDefault", "()Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", "")]
		public static GoogleSignInAccount CreateDefault()
		{
			return Java.Lang.Object.GetObject<GoogleSignInAccount>(GoogleSignInAccount._members.StaticMethods.InvokeObjectMethod("createDefault.()Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002648 File Offset: 0x00000848
		[Register("fromAccount", "(Landroid/accounts/Account;)Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", "")]
		public unsafe static GoogleSignInAccount FromAccount(Account account)
		{
			GoogleSignInAccount @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((account == null) ? IntPtr.Zero : account.Handle);
				@object = Java.Lang.Object.GetObject<GoogleSignInAccount>(GoogleSignInAccount._members.StaticMethods.InvokeObjectMethod("fromAccount.(Landroid/accounts/Account;)Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(account);
			}
			return @object;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000026BC File Offset: 0x000008BC
		private static Delegate GetRequestExtraScopes_arrayLcom_google_android_gms_common_api_Scope_Handler()
		{
			if (GoogleSignInAccount.cb_requestExtraScopes_arrayLcom_google_android_gms_common_api_Scope_ == null)
			{
				GoogleSignInAccount.cb_requestExtraScopes_arrayLcom_google_android_gms_common_api_Scope_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GoogleSignInAccount.n_RequestExtraScopes_arrayLcom_google_android_gms_common_api_Scope_));
			}
			return GoogleSignInAccount.cb_requestExtraScopes_arrayLcom_google_android_gms_common_api_Scope_;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000026E0 File Offset: 0x000008E0
		private static IntPtr n_RequestExtraScopes_arrayLcom_google_android_gms_common_api_Scope_(IntPtr jnienv, IntPtr native__this, IntPtr native_scopes)
		{
			GoogleSignInAccount @object = Java.Lang.Object.GetObject<GoogleSignInAccount>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Scope[] array = (Scope[])JNIEnv.GetArray(native_scopes, JniHandleOwnership.DoNotTransfer, typeof(Scope));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.RequestExtraScopes(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Scope>(array, native_scopes);
			}
			return result;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002724 File Offset: 0x00000924
		[Register("requestExtraScopes", "([Lcom/google/android/gms/common/api/Scope;)Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", "GetRequestExtraScopes_arrayLcom_google_android_gms_common_api_Scope_Handler")]
		public unsafe virtual GoogleSignInAccount RequestExtraScopes(params Scope[] scopes)
		{
			IntPtr intPtr = JNIEnv.NewArray<Scope>(scopes);
			GoogleSignInAccount @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<GoogleSignInAccount>(GoogleSignInAccount._members.InstanceMethods.InvokeVirtualObjectMethod("requestExtraScopes.([Lcom/google/android/gms/common/api/Scope;)Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (scopes != null)
				{
					JNIEnv.CopyArray<Scope>(intPtr, scopes);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(scopes);
			}
			return @object;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000027A0 File Offset: 0x000009A0
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (GoogleSignInAccount.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				GoogleSignInAccount.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(GoogleSignInAccount.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return GoogleSignInAccount.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000027C4 File Offset: 0x000009C4
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_flags)
		{
			AbstractSafeParcelable @object = Java.Lang.Object.GetObject<GoogleSignInAccount>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native__out, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000027EC File Offset: 0x000009EC
		[Register("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public unsafe override void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				GoogleSignInAccount._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002864 File Offset: 0x00000A64
		[Register("zaa", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;Ljava/lang/Long;Ljava/lang/String;Ljava/util/Set;)Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", "")]
		public unsafe static GoogleSignInAccount Zaa(string p0, string p1, string p2, string p3, string p4, string p5, Android.Net.Uri p6, Long p7, string p8, ICollection p9)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			IntPtr intPtr3 = JNIEnv.NewString(p2);
			IntPtr intPtr4 = JNIEnv.NewString(p3);
			IntPtr intPtr5 = JNIEnv.NewString(p4);
			IntPtr intPtr6 = JNIEnv.NewString(p5);
			IntPtr intPtr7 = JNIEnv.NewString(p8);
			IntPtr intPtr8 = JavaSet.ToLocalJniHandle(p9);
			GoogleSignInAccount @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue(intPtr6);
				ptr[6] = new JniArgumentValue((p6 == null) ? IntPtr.Zero : p6.Handle);
				ptr[7] = new JniArgumentValue((p7 == null) ? IntPtr.Zero : p7.Handle);
				ptr[8] = new JniArgumentValue(intPtr7);
				ptr[9] = new JniArgumentValue(intPtr8);
				@object = Java.Lang.Object.GetObject<GoogleSignInAccount>(GoogleSignInAccount._members.StaticMethods.InvokeObjectMethod("zaa.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;Ljava/lang/Long;Ljava/lang/String;Ljava/util/Set;)Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				JNIEnv.DeleteLocalRef(intPtr6);
				JNIEnv.DeleteLocalRef(intPtr7);
				JNIEnv.DeleteLocalRef(intPtr8);
				GC.KeepAlive(p6);
				GC.KeepAlive(p7);
				GC.KeepAlive(p9);
			}
			return @object;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002A50 File Offset: 0x00000C50
		[Register("zab", "(Ljava/lang/String;)Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", "")]
		public unsafe static GoogleSignInAccount Zab(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			GoogleSignInAccount @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<GoogleSignInAccount>(GoogleSignInAccount._members.StaticMethods.InvokeObjectMethod("zab.(Ljava/lang/String;)Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Register("zac", "()Ljava/lang/String;", "")]
		public string Zac()
		{
			return JNIEnv.GetString(GoogleSignInAccount._members.InstanceMethods.InvokeNonvirtualObjectMethod("zac.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Register("zad", "()Ljava/lang/String;", "")]
		public string Zad()
		{
			return JNIEnv.GetString(GoogleSignInAccount._members.InstanceMethods.InvokeNonvirtualObjectMethod("zad.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000001 RID: 1
		private static IntPtr id_describeContents;

		// Token: 0x04000002 RID: 2
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/auth/api/signin/GoogleSignInAccount", typeof(GoogleSignInAccount));

		// Token: 0x04000003 RID: 3
		private static Delegate cb_getAccount;

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getDisplayName;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_getEmail;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_getFamilyName;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_getGivenName;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_getGrantedScopes;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_getId;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_getIdToken;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_isExpired;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_getPhotoUrl;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_getRequestedScopes;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_getServerAuthCode;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_requestExtraScopes_arrayLcom_google_android_gms_common_api_Scope_;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
