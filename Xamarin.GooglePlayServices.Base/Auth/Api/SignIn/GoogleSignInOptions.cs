using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Accounts;
using Android.Gms.Auth.Api.SignIn.Internal;
using Android.Gms.Common.Apis;
using Android.Gms.Common.Internal.SafeParcel;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Auth.Api.SignIn
{
	// Token: 0x02000016 RID: 22
	[Register("com/google/android/gms/auth/api/signin/GoogleSignInOptions", DoNotGenerateAcw = true)]
	public class GoogleSignInOptions : AbstractSafeParcelable, Api.IApiOptionsOptional, Api.IApiOptionsHasOptions, Api.IApiOptions, IJavaObject, IDisposable, IJavaPeerable, Api.IApiOptionsNotRequiredOptions, IParcelable
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00002B3D File Offset: 0x00000D3D
		[Register("describeContents", "()I", "")]
		public new int DescribeContents()
		{
			if (GoogleSignInOptions.id_describeContents == IntPtr.Zero)
			{
				GoogleSignInOptions.id_describeContents = JNIEnv.GetMethodID(GoogleSignInOptions.class_ref, "describeContents", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, GoogleSignInOptions.id_describeContents);
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Register("CREATOR")]
		public static IParcelableCreator Creator
		{
			get
			{
				return Java.Lang.Object.GetObject<IParcelableCreator>(GoogleSignInOptions._members.StaticFields.GetObjectValue("CREATOR.Landroid/os/Parcelable$Creator;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002BAC File Offset: 0x00000DAC
		[Register("DEFAULT_GAMES_SIGN_IN")]
		public static GoogleSignInOptions DefaultGamesSignIn
		{
			get
			{
				return Java.Lang.Object.GetObject<GoogleSignInOptions>(GoogleSignInOptions._members.StaticFields.GetObjectValue("DEFAULT_GAMES_SIGN_IN.Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002BDC File Offset: 0x00000DDC
		[Register("DEFAULT_SIGN_IN")]
		public static GoogleSignInOptions DefaultSignIn
		{
			get
			{
				return Java.Lang.Object.GetObject<GoogleSignInOptions>(GoogleSignInOptions._members.StaticFields.GetObjectValue("DEFAULT_SIGN_IN.Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Register("zaa")]
		public static Scope Zaa
		{
			get
			{
				return Java.Lang.Object.GetObject<Scope>(GoogleSignInOptions._members.StaticFields.GetObjectValue("zaa.Lcom/google/android/gms/common/api/Scope;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Register("zac")]
		public static Scope Zac
		{
			get
			{
				return Java.Lang.Object.GetObject<Scope>(GoogleSignInOptions._members.StaticFields.GetObjectValue("zac.Lcom/google/android/gms/common/api/Scope;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002C6C File Offset: 0x00000E6C
		[Register("zad")]
		public static Scope Zad
		{
			get
			{
				return Java.Lang.Object.GetObject<Scope>(GoogleSignInOptions._members.StaticFields.GetObjectValue("zad.Lcom/google/android/gms/common/api/Scope;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002C9C File Offset: 0x00000E9C
		[Register("zae")]
		public static Scope Zae
		{
			get
			{
				return Java.Lang.Object.GetObject<Scope>(GoogleSignInOptions._members.StaticFields.GetObjectValue("zae.Lcom/google/android/gms/common/api/Scope;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002CCC File Offset: 0x00000ECC
		internal static IntPtr class_ref
		{
			get
			{
				return GoogleSignInOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002CF0 File Offset: 0x00000EF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GoogleSignInOptions._members;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00002CF8 File Offset: 0x00000EF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GoogleSignInOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002D1C File Offset: 0x00000F1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GoogleSignInOptions._members.ManagedPeerType;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002118 File Offset: 0x00000318
		protected GoogleSignInOptions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002D28 File Offset: 0x00000F28
		private static Delegate GetGetAccountHandler()
		{
			if (GoogleSignInOptions.cb_getAccount == null)
			{
				GoogleSignInOptions.cb_getAccount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInOptions.n_GetAccount));
			}
			return GoogleSignInOptions.cb_getAccount;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002D4C File Offset: 0x00000F4C
		private static IntPtr n_GetAccount(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleSignInOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Account);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00002D60 File Offset: 0x00000F60
		public virtual Account Account
		{
			[Register("getAccount", "()Landroid/accounts/Account;", "GetGetAccountHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Account>(GoogleSignInOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getAccount.()Landroid/accounts/Account;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002D92 File Offset: 0x00000F92
		private static Delegate GetGetExtensionsHandler()
		{
			if (GoogleSignInOptions.cb_getExtensions == null)
			{
				GoogleSignInOptions.cb_getExtensions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInOptions.n_GetExtensions));
			}
			return GoogleSignInOptions.cb_getExtensions;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002DB6 File Offset: 0x00000FB6
		private static IntPtr n_GetExtensions(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<GoogleSignInOptionsExtensionParcelable>.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleSignInOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Extensions);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002DCC File Offset: 0x00000FCC
		public virtual IList<GoogleSignInOptionsExtensionParcelable> Extensions
		{
			[Register("getExtensions", "()Ljava/util/ArrayList;", "GetGetExtensionsHandler")]
			get
			{
				return JavaList<GoogleSignInOptionsExtensionParcelable>.FromJniHandle(GoogleSignInOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getExtensions.()Ljava/util/ArrayList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002DFE File Offset: 0x00000FFE
		private static Delegate GetIsForceCodeForRefreshTokenHandler()
		{
			if (GoogleSignInOptions.cb_isForceCodeForRefreshToken == null)
			{
				GoogleSignInOptions.cb_isForceCodeForRefreshToken = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(GoogleSignInOptions.n_IsForceCodeForRefreshToken));
			}
			return GoogleSignInOptions.cb_isForceCodeForRefreshToken;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002E22 File Offset: 0x00001022
		private static bool n_IsForceCodeForRefreshToken(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GoogleSignInOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsForceCodeForRefreshToken;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00002E31 File Offset: 0x00001031
		public virtual bool IsForceCodeForRefreshToken
		{
			[Register("isForceCodeForRefreshToken", "()Z", "GetIsForceCodeForRefreshTokenHandler")]
			get
			{
				return GoogleSignInOptions._members.InstanceMethods.InvokeVirtualBooleanMethod("isForceCodeForRefreshToken.()Z", this, null);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002E4A File Offset: 0x0000104A
		private static Delegate GetIsIdTokenRequestedHandler()
		{
			if (GoogleSignInOptions.cb_isIdTokenRequested == null)
			{
				GoogleSignInOptions.cb_isIdTokenRequested = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(GoogleSignInOptions.n_IsIdTokenRequested));
			}
			return GoogleSignInOptions.cb_isIdTokenRequested;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002E6E File Offset: 0x0000106E
		private static bool n_IsIdTokenRequested(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GoogleSignInOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsIdTokenRequested;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002E7D File Offset: 0x0000107D
		public virtual bool IsIdTokenRequested
		{
			[Register("isIdTokenRequested", "()Z", "GetIsIdTokenRequestedHandler")]
			get
			{
				return GoogleSignInOptions._members.InstanceMethods.InvokeVirtualBooleanMethod("isIdTokenRequested.()Z", this, null);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002E96 File Offset: 0x00001096
		private static Delegate GetIsServerAuthCodeRequestedHandler()
		{
			if (GoogleSignInOptions.cb_isServerAuthCodeRequested == null)
			{
				GoogleSignInOptions.cb_isServerAuthCodeRequested = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(GoogleSignInOptions.n_IsServerAuthCodeRequested));
			}
			return GoogleSignInOptions.cb_isServerAuthCodeRequested;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002EBA File Offset: 0x000010BA
		private static bool n_IsServerAuthCodeRequested(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GoogleSignInOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsServerAuthCodeRequested;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002EC9 File Offset: 0x000010C9
		public virtual bool IsServerAuthCodeRequested
		{
			[Register("isServerAuthCodeRequested", "()Z", "GetIsServerAuthCodeRequestedHandler")]
			get
			{
				return GoogleSignInOptions._members.InstanceMethods.InvokeVirtualBooleanMethod("isServerAuthCodeRequested.()Z", this, null);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002EE2 File Offset: 0x000010E2
		private static Delegate GetGetLogSessionIdHandler()
		{
			if (GoogleSignInOptions.cb_getLogSessionId == null)
			{
				GoogleSignInOptions.cb_getLogSessionId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInOptions.n_GetLogSessionId));
			}
			return GoogleSignInOptions.cb_getLogSessionId;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002F06 File Offset: 0x00001106
		private static IntPtr n_GetLogSessionId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<GoogleSignInOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LogSessionId);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00002F1C File Offset: 0x0000111C
		public virtual string LogSessionId
		{
			[Register("getLogSessionId", "()Ljava/lang/String;", "GetGetLogSessionIdHandler")]
			get
			{
				return JNIEnv.GetString(GoogleSignInOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getLogSessionId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002F4E File Offset: 0x0000114E
		private static Delegate GetGetScopesHandler()
		{
			if (GoogleSignInOptions.cb_getScopes == null)
			{
				GoogleSignInOptions.cb_getScopes = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInOptions.n_GetScopes));
			}
			return GoogleSignInOptions.cb_getScopes;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002F72 File Offset: 0x00001172
		private static IntPtr n_GetScopes(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<Scope>.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleSignInOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Scopes);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002F88 File Offset: 0x00001188
		public virtual IList<Scope> Scopes
		{
			[Register("getScopes", "()Ljava/util/ArrayList;", "GetGetScopesHandler")]
			get
			{
				return JavaList<Scope>.FromJniHandle(GoogleSignInOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getScopes.()Ljava/util/ArrayList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002FBA File Offset: 0x000011BA
		private static Delegate GetGetServerClientIdHandler()
		{
			if (GoogleSignInOptions.cb_getServerClientId == null)
			{
				GoogleSignInOptions.cb_getServerClientId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInOptions.n_GetServerClientId));
			}
			return GoogleSignInOptions.cb_getServerClientId;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002FDE File Offset: 0x000011DE
		private static IntPtr n_GetServerClientId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<GoogleSignInOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ServerClientId);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002FF4 File Offset: 0x000011F4
		public virtual string ServerClientId
		{
			[Register("getServerClientId", "()Ljava/lang/String;", "GetGetServerClientIdHandler")]
			get
			{
				return JNIEnv.GetString(GoogleSignInOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getServerClientId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003026 File Offset: 0x00001226
		private static Delegate GetGetScopeArrayHandler()
		{
			if (GoogleSignInOptions.cb_getScopeArray == null)
			{
				GoogleSignInOptions.cb_getScopeArray = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInOptions.n_GetScopeArray));
			}
			return GoogleSignInOptions.cb_getScopeArray;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000304A File Offset: 0x0000124A
		private static IntPtr n_GetScopeArray(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Scope>(Java.Lang.Object.GetObject<GoogleSignInOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetScopeArray());
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003060 File Offset: 0x00001260
		[Register("getScopeArray", "()[Lcom/google/android/gms/common/api/Scope;", "GetGetScopeArrayHandler")]
		public virtual Scope[] GetScopeArray()
		{
			return (Scope[])JNIEnv.GetArray(GoogleSignInOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getScopeArray.()[Lcom/google/android/gms/common/api/Scope;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Scope));
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000030A1 File Offset: 0x000012A1
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (GoogleSignInOptions.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				GoogleSignInOptions.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(GoogleSignInOptions.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return GoogleSignInOptions.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000030C8 File Offset: 0x000012C8
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_flags)
		{
			AbstractSafeParcelable @object = Java.Lang.Object.GetObject<GoogleSignInOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native__out, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000030F0 File Offset: 0x000012F0
		[Register("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public unsafe override void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				GoogleSignInOptions._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003168 File Offset: 0x00001368
		[Register("zab", "(Ljava/lang/String;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;", "")]
		public unsafe static GoogleSignInOptions Zab(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			GoogleSignInOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<GoogleSignInOptions>(GoogleSignInOptions._members.StaticMethods.InvokeObjectMethod("zab.(Ljava/lang/String;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000031D4 File Offset: 0x000013D4
		[Register("zaf", "()Ljava/lang/String;", "")]
		public string Zaf()
		{
			return JNIEnv.GetString(GoogleSignInOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("zaf.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000011 RID: 17
		private static IntPtr id_describeContents;

		// Token: 0x04000012 RID: 18
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/auth/api/signin/GoogleSignInOptions", typeof(GoogleSignInOptions));

		// Token: 0x04000013 RID: 19
		private static Delegate cb_getAccount;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_getExtensions;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_isForceCodeForRefreshToken;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_isIdTokenRequested;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_isServerAuthCodeRequested;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_getLogSessionId;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_getScopes;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_getServerClientId;

		// Token: 0x0400001B RID: 27
		private static Delegate cb_getScopeArray;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;

		// Token: 0x02000017 RID: 23
		[Register("com/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder", DoNotGenerateAcw = true)]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000B3 RID: 179 RVA: 0x00003224 File Offset: 0x00001424
			internal static IntPtr class_ref
			{
				get
				{
					return GoogleSignInOptions.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000B4 RID: 180 RVA: 0x00003248 File Offset: 0x00001448
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return GoogleSignInOptions.Builder._members;
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003250 File Offset: 0x00001450
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return GoogleSignInOptions.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060000B6 RID: 182 RVA: 0x00003274 File Offset: 0x00001474
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return GoogleSignInOptions.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x060000B7 RID: 183 RVA: 0x00003280 File Offset: 0x00001480
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x0000328C File Offset: 0x0000148C
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(GoogleSignInOptions.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				GoogleSignInOptions.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x000032FC File Offset: 0x000014FC
			[Register(".ctor", "(Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;)V", "")]
			public unsafe Builder(GoogleSignInOptions googleSignInOptions) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((googleSignInOptions == null) ? IntPtr.Zero : googleSignInOptions.Handle);
					base.SetHandle(GoogleSignInOptions.Builder._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					GoogleSignInOptions.Builder._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(googleSignInOptions);
				}
			}

			// Token: 0x060000BA RID: 186 RVA: 0x000033AC File Offset: 0x000015AC
			[Register("addExtension", "(Lcom/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", "")]
			public unsafe GoogleSignInOptions.Builder AddExtension(IGoogleSignInOptionsExtension extension)
			{
				GoogleSignInOptions.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((extension == null) ? IntPtr.Zero : ((Java.Lang.Object)extension).Handle);
					@object = Java.Lang.Object.GetObject<GoogleSignInOptions.Builder>(GoogleSignInOptions.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("addExtension.(Lcom/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(extension);
				}
				return @object;
			}

			// Token: 0x060000BB RID: 187 RVA: 0x00003424 File Offset: 0x00001624
			[Register("build", "()Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;", "")]
			public GoogleSignInOptions Build()
			{
				return Java.Lang.Object.GetObject<GoogleSignInOptions>(GoogleSignInOptions.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060000BC RID: 188 RVA: 0x00003458 File Offset: 0x00001658
			[Register("requestEmail", "()Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", "")]
			public GoogleSignInOptions.Builder RequestEmail()
			{
				return Java.Lang.Object.GetObject<GoogleSignInOptions.Builder>(GoogleSignInOptions.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("requestEmail.()Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060000BD RID: 189 RVA: 0x0000348C File Offset: 0x0000168C
			[Register("requestId", "()Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", "")]
			public GoogleSignInOptions.Builder RequestId()
			{
				return Java.Lang.Object.GetObject<GoogleSignInOptions.Builder>(GoogleSignInOptions.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("requestId.()Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060000BE RID: 190 RVA: 0x000034C0 File Offset: 0x000016C0
			[Register("requestIdToken", "(Ljava/lang/String;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", "")]
			public unsafe GoogleSignInOptions.Builder RequestIdToken(string serverClientId)
			{
				IntPtr intPtr = JNIEnv.NewString(serverClientId);
				GoogleSignInOptions.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<GoogleSignInOptions.Builder>(GoogleSignInOptions.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("requestIdToken.(Ljava/lang/String;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060000BF RID: 191 RVA: 0x0000352C File Offset: 0x0000172C
			[Register("requestProfile", "()Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", "")]
			public GoogleSignInOptions.Builder RequestProfile()
			{
				return Java.Lang.Object.GetObject<GoogleSignInOptions.Builder>(GoogleSignInOptions.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("requestProfile.()Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x00003560 File Offset: 0x00001760
			[Register("requestScopes", "(Lcom/google/android/gms/common/api/Scope;[Lcom/google/android/gms/common/api/Scope;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", "")]
			public unsafe GoogleSignInOptions.Builder RequestScopes(Scope scope, params Scope[] scopes)
			{
				IntPtr intPtr = JNIEnv.NewArray<Scope>(scopes);
				GoogleSignInOptions.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((scope == null) ? IntPtr.Zero : scope.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<GoogleSignInOptions.Builder>(GoogleSignInOptions.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("requestScopes.(Lcom/google/android/gms/common/api/Scope;[Lcom/google/android/gms/common/api/Scope;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					if (scopes != null)
					{
						JNIEnv.CopyArray<Scope>(intPtr, scopes);
						JNIEnv.DeleteLocalRef(intPtr);
					}
					GC.KeepAlive(scope);
					GC.KeepAlive(scopes);
				}
				return @object;
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x00003604 File Offset: 0x00001804
			[Register("requestServerAuthCode", "(Ljava/lang/String;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", "")]
			public unsafe GoogleSignInOptions.Builder RequestServerAuthCode(string serverClientId)
			{
				IntPtr intPtr = JNIEnv.NewString(serverClientId);
				GoogleSignInOptions.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<GoogleSignInOptions.Builder>(GoogleSignInOptions.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("requestServerAuthCode.(Ljava/lang/String;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x00003670 File Offset: 0x00001870
			[Register("requestServerAuthCode", "(Ljava/lang/String;Z)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", "")]
			public unsafe GoogleSignInOptions.Builder RequestServerAuthCode(string serverClientId, bool forceCodeForRefreshToken)
			{
				IntPtr intPtr = JNIEnv.NewString(serverClientId);
				GoogleSignInOptions.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue(forceCodeForRefreshToken);
					@object = Java.Lang.Object.GetObject<GoogleSignInOptions.Builder>(GoogleSignInOptions.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("requestServerAuthCode.(Ljava/lang/String;Z)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x000036F0 File Offset: 0x000018F0
			[Register("setAccountName", "(Ljava/lang/String;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", "")]
			public unsafe GoogleSignInOptions.Builder SetAccountName(string accountName)
			{
				IntPtr intPtr = JNIEnv.NewString(accountName);
				GoogleSignInOptions.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<GoogleSignInOptions.Builder>(GoogleSignInOptions.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setAccountName.(Ljava/lang/String;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x0000375C File Offset: 0x0000195C
			[Register("setHostedDomain", "(Ljava/lang/String;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", "")]
			public unsafe GoogleSignInOptions.Builder SetHostedDomain(string hostedDomain)
			{
				IntPtr intPtr = JNIEnv.NewString(hostedDomain);
				GoogleSignInOptions.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<GoogleSignInOptions.Builder>(GoogleSignInOptions.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setHostedDomain.(Ljava/lang/String;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x000037C8 File Offset: 0x000019C8
			[Register("setLogSessionId", "(Ljava/lang/String;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", "")]
			public unsafe GoogleSignInOptions.Builder SetLogSessionId(string logSessionId)
			{
				IntPtr intPtr = JNIEnv.NewString(logSessionId);
				GoogleSignInOptions.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<GoogleSignInOptions.Builder>(GoogleSignInOptions.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setLogSessionId.(Ljava/lang/String;)Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0400001D RID: 29
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/auth/api/signin/GoogleSignInOptions$Builder", typeof(GoogleSignInOptions.Builder));
		}
	}
}
