using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk
{
	// Token: 0x02000133 RID: 307
	[Register("com/applovin/impl/sdk/UserServiceImpl", DoNotGenerateAcw = true)]
	public class UserServiceImpl : Java.Lang.Object, IAppLovinUserService, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x000262A8 File Offset: 0x000244A8
		internal static IntPtr class_ref
		{
			get
			{
				return UserServiceImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x000262CC File Offset: 0x000244CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UserServiceImpl._members;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x000262D4 File Offset: 0x000244D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UserServiceImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x000262F8 File Offset: 0x000244F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UserServiceImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000021F0 File Offset: 0x000003F0
		protected UserServiceImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00026304 File Offset: 0x00024504
		private static Delegate GetPreloadConsentDialogHandler()
		{
			if (UserServiceImpl.cb_preloadConsentDialog == null)
			{
				UserServiceImpl.cb_preloadConsentDialog = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(UserServiceImpl.n_PreloadConsentDialog));
			}
			return UserServiceImpl.cb_preloadConsentDialog;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00026328 File Offset: 0x00024528
		private static void n_PreloadConsentDialog(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<UserServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PreloadConsentDialog();
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00026337 File Offset: 0x00024537
		[Register("preloadConsentDialog", "()V", "GetPreloadConsentDialogHandler")]
		public virtual void PreloadConsentDialog()
		{
			UserServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("preloadConsentDialog.()V", this, null);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00026350 File Offset: 0x00024550
		private static Delegate GetShowConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_Handler()
		{
			if (UserServiceImpl.cb_showConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_ == null)
			{
				UserServiceImpl.cb_showConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(UserServiceImpl.n_ShowConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_));
			}
			return UserServiceImpl.cb_showConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_;
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00026374 File Offset: 0x00024574
		private static void n_ShowConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			UserServiceImpl @object = Java.Lang.Object.GetObject<UserServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinUserServiceOnConsentDialogDismissListener object3 = Java.Lang.Object.GetObject<IAppLovinUserServiceOnConsentDialogDismissListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.ShowConsentDialog(object2, object3);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x000263A0 File Offset: 0x000245A0
		[Register("showConsentDialog", "(Landroid/app/Activity;Lcom/applovin/sdk/AppLovinUserService$OnConsentDialogDismissListener;)V", "GetShowConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_Handler")]
		public unsafe virtual void ShowConsentDialog(Activity p0, IAppLovinUserServiceOnConsentDialogDismissListener p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				UserServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("showConsentDialog.(Landroid/app/Activity;Lcom/applovin/sdk/AppLovinUserService$OnConsentDialogDismissListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x040004DA RID: 1242
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/UserServiceImpl", typeof(UserServiceImpl));

		// Token: 0x040004DB RID: 1243
		private static Delegate cb_preloadConsentDialog;

		// Token: 0x040004DC RID: 1244
		private static Delegate cb_showConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_;
	}
}
