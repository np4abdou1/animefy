using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Android.Content;
using Android.Gms.Common.Apis;
using Android.Gms.Extensions;
using Android.Gms.Tasks;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Auth.Api.SignIn
{
	// Token: 0x02000004 RID: 4
	[Register("com/google/android/gms/auth/api/signin/GoogleSignInClient", DoNotGenerateAcw = true)]
	public class GoogleSignInClient : GoogleApi
	{
		// Token: 0x06000018 RID: 24 RVA: 0x000028E3 File Offset: 0x00000AE3
		public System.Threading.Tasks.Task RevokeAccessAsync()
		{
			return this.RevokeAccess().AsAsync();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000028F0 File Offset: 0x00000AF0
		public System.Threading.Tasks.Task SignOutAsync()
		{
			return this.SignOut().AsAsync();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000028FD File Offset: 0x00000AFD
		public Task<GoogleSignInAccount> SilentSignInAsync()
		{
			return this.SilentSignIn().AsAsync<GoogleSignInAccount>();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001B RID: 27 RVA: 0x0000290C File Offset: 0x00000B0C
		internal static IntPtr class_ref
		{
			get
			{
				return GoogleSignInClient._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002930 File Offset: 0x00000B30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GoogleSignInClient._members;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002938 File Offset: 0x00000B38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GoogleSignInClient._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000295C File Offset: 0x00000B5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GoogleSignInClient._members.ManagedPeerType;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002968 File Offset: 0x00000B68
		protected GoogleSignInClient(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002972 File Offset: 0x00000B72
		private static Delegate GetGetSignInIntentHandler()
		{
			if (GoogleSignInClient.cb_getSignInIntent == null)
			{
				GoogleSignInClient.cb_getSignInIntent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInClient.n_GetSignInIntent));
			}
			return GoogleSignInClient.cb_getSignInIntent;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002996 File Offset: 0x00000B96
		private static IntPtr n_GetSignInIntent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleSignInClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SignInIntent);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000029AC File Offset: 0x00000BAC
		public virtual Intent SignInIntent
		{
			[Register("getSignInIntent", "()Landroid/content/Intent;", "GetGetSignInIntentHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Intent>(GoogleSignInClient._members.InstanceMethods.InvokeVirtualObjectMethod("getSignInIntent.()Landroid/content/Intent;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000029DE File Offset: 0x00000BDE
		private static Delegate GetRevokeAccessHandler()
		{
			if (GoogleSignInClient.cb_revokeAccess == null)
			{
				GoogleSignInClient.cb_revokeAccess = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInClient.n_RevokeAccess));
			}
			return GoogleSignInClient.cb_revokeAccess;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002A02 File Offset: 0x00000C02
		private static IntPtr n_RevokeAccess(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleSignInClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RevokeAccess());
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002A18 File Offset: 0x00000C18
		[Register("revokeAccess", "()Lcom/google/android/gms/tasks/Task;", "GetRevokeAccessHandler")]
		public virtual Android.Gms.Tasks.Task RevokeAccess()
		{
			return Java.Lang.Object.GetObject<Android.Gms.Tasks.Task>(GoogleSignInClient._members.InstanceMethods.InvokeVirtualObjectMethod("revokeAccess.()Lcom/google/android/gms/tasks/Task;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002A4A File Offset: 0x00000C4A
		private static Delegate GetSignOutHandler()
		{
			if (GoogleSignInClient.cb_signOut == null)
			{
				GoogleSignInClient.cb_signOut = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInClient.n_SignOut));
			}
			return GoogleSignInClient.cb_signOut;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002A6E File Offset: 0x00000C6E
		private static IntPtr n_SignOut(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleSignInClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SignOut());
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002A84 File Offset: 0x00000C84
		[Register("signOut", "()Lcom/google/android/gms/tasks/Task;", "GetSignOutHandler")]
		public virtual Android.Gms.Tasks.Task SignOut()
		{
			return Java.Lang.Object.GetObject<Android.Gms.Tasks.Task>(GoogleSignInClient._members.InstanceMethods.InvokeVirtualObjectMethod("signOut.()Lcom/google/android/gms/tasks/Task;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002AB6 File Offset: 0x00000CB6
		private static Delegate GetSilentSignInHandler()
		{
			if (GoogleSignInClient.cb_silentSignIn == null)
			{
				GoogleSignInClient.cb_silentSignIn = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GoogleSignInClient.n_SilentSignIn));
			}
			return GoogleSignInClient.cb_silentSignIn;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002ADA File Offset: 0x00000CDA
		private static IntPtr n_SilentSignIn(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GoogleSignInClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SilentSignIn());
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Register("silentSignIn", "()Lcom/google/android/gms/tasks/Task;", "GetSilentSignInHandler")]
		public virtual Android.Gms.Tasks.Task SilentSignIn()
		{
			return Java.Lang.Object.GetObject<Android.Gms.Tasks.Task>(GoogleSignInClient._members.InstanceMethods.InvokeVirtualObjectMethod("silentSignIn.()Lcom/google/android/gms/tasks/Task;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000002 RID: 2
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/auth/api/signin/GoogleSignInClient", typeof(GoogleSignInClient));

		// Token: 0x04000003 RID: 3
		private static Delegate cb_getSignInIntent;

		// Token: 0x04000004 RID: 4
		private static Delegate cb_revokeAccess;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_signOut;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_silentSignIn;
	}
}
