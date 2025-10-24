using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Gms.Common.Apis;
using Android.Gms.Extensions;
using Android.Gms.Tasks;
using Android.Runtime;
using AndroidX.Fragment.App;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Auth.Api.SignIn
{
	// Token: 0x02000003 RID: 3
	[Register("com/google/android/gms/auth/api/signin/GoogleSignIn", DoNotGenerateAcw = true)]
	public sealed class GoogleSignIn : Java.Lang.Object
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		public static Task<GoogleSignInAccount> GetSignedInAccountFromIntentAsync(Intent intent)
		{
			return GoogleSignIn.GetSignedInAccountFromIntent(intent).AsAsync<GoogleSignInAccount>();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002060 File Offset: 0x00000260
		internal static IntPtr class_ref
		{
			get
			{
				return GoogleSignIn._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002084 File Offset: 0x00000284
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GoogleSignIn._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000208C File Offset: 0x0000028C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GoogleSignIn._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020B0 File Offset: 0x000002B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GoogleSignIn._members.ManagedPeerType;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020BC File Offset: 0x000002BC
		internal GoogleSignIn(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020C8 File Offset: 0x000002C8
		[Register("getAccountForExtension", "(Landroid/content/Context;Lcom/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension;)Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", "")]
		public unsafe static GoogleSignInAccount GetAccountForExtension(Context context, IGoogleSignInOptionsExtension extension)
		{
			GoogleSignInAccount @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((extension == null) ? IntPtr.Zero : ((Java.Lang.Object)extension).Handle);
				@object = Java.Lang.Object.GetObject<GoogleSignInAccount>(GoogleSignIn._members.StaticMethods.InvokeObjectMethod("getAccountForExtension.(Landroid/content/Context;Lcom/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension;)Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(extension);
			}
			return @object;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002168 File Offset: 0x00000368
		[Register("getAccountForScopes", "(Landroid/content/Context;Lcom/google/android/gms/common/api/Scope;[Lcom/google/android/gms/common/api/Scope;)Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", "")]
		public unsafe static GoogleSignInAccount GetAccountForScopes(Context context, Scope scope, params Scope[] scopes)
		{
			IntPtr intPtr = JNIEnv.NewArray<Scope>(scopes);
			GoogleSignInAccount @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((scope == null) ? IntPtr.Zero : scope.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<GoogleSignInAccount>(GoogleSignIn._members.StaticMethods.InvokeObjectMethod("getAccountForScopes.(Landroid/content/Context;Lcom/google/android/gms/common/api/Scope;[Lcom/google/android/gms/common/api/Scope;)Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (scopes != null)
				{
					JNIEnv.CopyArray<Scope>(intPtr, scopes);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(context);
				GC.KeepAlive(scope);
				GC.KeepAlive(scopes);
			}
			return @object;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002238 File Offset: 0x00000438
		[Register("getClient", "(Landroid/app/Activity;Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;)Lcom/google/android/gms/auth/api/signin/GoogleSignInClient;", "")]
		public unsafe static GoogleSignInClient GetClient(Activity activity, GoogleSignInOptions options)
		{
			GoogleSignInClient @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<GoogleSignInClient>(GoogleSignIn._members.StaticMethods.InvokeObjectMethod("getClient.(Landroid/app/Activity;Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;)Lcom/google/android/gms/auth/api/signin/GoogleSignInClient;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022D4 File Offset: 0x000004D4
		[Register("getClient", "(Landroid/content/Context;Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;)Lcom/google/android/gms/auth/api/signin/GoogleSignInClient;", "")]
		public unsafe static GoogleSignInClient GetClient(Context context, GoogleSignInOptions options)
		{
			GoogleSignInClient @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<GoogleSignInClient>(GoogleSignIn._members.StaticMethods.InvokeObjectMethod("getClient.(Landroid/content/Context;Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;)Lcom/google/android/gms/auth/api/signin/GoogleSignInClient;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002370 File Offset: 0x00000570
		[Register("getLastSignedInAccount", "(Landroid/content/Context;)Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", "")]
		public unsafe static GoogleSignInAccount GetLastSignedInAccount(Context context)
		{
			GoogleSignInAccount @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<GoogleSignInAccount>(GoogleSignIn._members.StaticMethods.InvokeObjectMethod("getLastSignedInAccount.(Landroid/content/Context;)Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000023E4 File Offset: 0x000005E4
		[Register("getSignedInAccountFromIntent", "(Landroid/content/Intent;)Lcom/google/android/gms/tasks/Task;", "")]
		public unsafe static Android.Gms.Tasks.Task GetSignedInAccountFromIntent(Intent data)
		{
			Android.Gms.Tasks.Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
				@object = Java.Lang.Object.GetObject<Android.Gms.Tasks.Task>(GoogleSignIn._members.StaticMethods.InvokeObjectMethod("getSignedInAccountFromIntent.(Landroid/content/Intent;)Lcom/google/android/gms/tasks/Task;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(data);
			}
			return @object;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002458 File Offset: 0x00000658
		[Register("hasPermissions", "(Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;Lcom/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension;)Z", "")]
		public unsafe static bool HasPermissions(GoogleSignInAccount account, IGoogleSignInOptionsExtension extension)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((account == null) ? IntPtr.Zero : account.Handle);
				ptr[1] = new JniArgumentValue((extension == null) ? IntPtr.Zero : ((Java.Lang.Object)extension).Handle);
				result = GoogleSignIn._members.StaticMethods.InvokeBooleanMethod("hasPermissions.(Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;Lcom/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(account);
				GC.KeepAlive(extension);
			}
			return result;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000024EC File Offset: 0x000006EC
		[Register("hasPermissions", "(Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;[Lcom/google/android/gms/common/api/Scope;)Z", "")]
		public unsafe static bool HasPermissions(GoogleSignInAccount account, params Scope[] scopes)
		{
			IntPtr intPtr = JNIEnv.NewArray<Scope>(scopes);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((account == null) ? IntPtr.Zero : account.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = GoogleSignIn._members.StaticMethods.InvokeBooleanMethod("hasPermissions.(Lcom/google/android/gms/auth/api/signin/GoogleSignInAccount;[Lcom/google/android/gms/common/api/Scope;)Z", ptr);
			}
			finally
			{
				if (scopes != null)
				{
					JNIEnv.CopyArray<Scope>(intPtr, scopes);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(account);
				GC.KeepAlive(scopes);
			}
			return result;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002580 File Offset: 0x00000780
		[Register("requestPermissions", "(Landroid/app/Activity;ILcom/google/android/gms/auth/api/signin/GoogleSignInAccount;Lcom/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension;)V", "")]
		public unsafe static void RequestPermissions(Activity activity, int requestCode, GoogleSignInAccount account, IGoogleSignInOptionsExtension extension)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(requestCode);
				ptr[2] = new JniArgumentValue((account == null) ? IntPtr.Zero : account.Handle);
				ptr[3] = new JniArgumentValue((extension == null) ? IntPtr.Zero : ((Java.Lang.Object)extension).Handle);
				GoogleSignIn._members.StaticMethods.InvokeVoidMethod("requestPermissions.(Landroid/app/Activity;ILcom/google/android/gms/auth/api/signin/GoogleSignInAccount;Lcom/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(account);
				GC.KeepAlive(extension);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002650 File Offset: 0x00000850
		[Register("requestPermissions", "(Landroid/app/Activity;ILcom/google/android/gms/auth/api/signin/GoogleSignInAccount;[Lcom/google/android/gms/common/api/Scope;)V", "")]
		public unsafe static void RequestPermissions(Activity activity, int requestCode, GoogleSignInAccount account, params Scope[] scopes)
		{
			IntPtr intPtr = JNIEnv.NewArray<Scope>(scopes);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(requestCode);
				ptr[2] = new JniArgumentValue((account == null) ? IntPtr.Zero : account.Handle);
				ptr[3] = new JniArgumentValue(intPtr);
				GoogleSignIn._members.StaticMethods.InvokeVoidMethod("requestPermissions.(Landroid/app/Activity;ILcom/google/android/gms/auth/api/signin/GoogleSignInAccount;[Lcom/google/android/gms/common/api/Scope;)V", ptr);
			}
			finally
			{
				if (scopes != null)
				{
					JNIEnv.CopyArray<Scope>(intPtr, scopes);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(activity);
				GC.KeepAlive(account);
				GC.KeepAlive(scopes);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002724 File Offset: 0x00000924
		[Register("requestPermissions", "(Landroidx/fragment/app/Fragment;ILcom/google/android/gms/auth/api/signin/GoogleSignInAccount;Lcom/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension;)V", "")]
		public unsafe static void RequestPermissions(AndroidX.Fragment.App.Fragment fragment, int requestCode, GoogleSignInAccount account, IGoogleSignInOptionsExtension extension)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue(requestCode);
				ptr[2] = new JniArgumentValue((account == null) ? IntPtr.Zero : account.Handle);
				ptr[3] = new JniArgumentValue((extension == null) ? IntPtr.Zero : ((Java.Lang.Object)extension).Handle);
				GoogleSignIn._members.StaticMethods.InvokeVoidMethod("requestPermissions.(Landroidx/fragment/app/Fragment;ILcom/google/android/gms/auth/api/signin/GoogleSignInAccount;Lcom/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
				GC.KeepAlive(account);
				GC.KeepAlive(extension);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000027F4 File Offset: 0x000009F4
		[Register("requestPermissions", "(Landroidx/fragment/app/Fragment;ILcom/google/android/gms/auth/api/signin/GoogleSignInAccount;[Lcom/google/android/gms/common/api/Scope;)V", "")]
		public unsafe static void RequestPermissions(AndroidX.Fragment.App.Fragment fragment, int requestCode, GoogleSignInAccount account, params Scope[] scopes)
		{
			IntPtr intPtr = JNIEnv.NewArray<Scope>(scopes);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue(requestCode);
				ptr[2] = new JniArgumentValue((account == null) ? IntPtr.Zero : account.Handle);
				ptr[3] = new JniArgumentValue(intPtr);
				GoogleSignIn._members.StaticMethods.InvokeVoidMethod("requestPermissions.(Landroidx/fragment/app/Fragment;ILcom/google/android/gms/auth/api/signin/GoogleSignInAccount;[Lcom/google/android/gms/common/api/Scope;)V", ptr);
			}
			finally
			{
				if (scopes != null)
				{
					JNIEnv.CopyArray<Scope>(intPtr, scopes);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(fragment);
				GC.KeepAlive(account);
				GC.KeepAlive(scopes);
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/auth/api/signin/GoogleSignIn", typeof(GoogleSignIn));
	}
}
