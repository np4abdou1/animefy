using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000099 RID: 153
	[Register("com/applovin/sdk/AppLovinUserService", DoNotGenerateAcw = true)]
	internal class IAppLovinUserServiceInvoker : Java.Lang.Object, IAppLovinUserService, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0000D708 File Offset: 0x0000B908
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinUserServiceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x0000D72C File Offset: 0x0000B92C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinUserServiceInvoker._members;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0000D733 File Offset: 0x0000B933
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0000D73B File Offset: 0x0000B93B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinUserServiceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0000D747 File Offset: 0x0000B947
		public static IAppLovinUserService GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinUserService>(handle, transfer);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0000D750 File Offset: 0x0000B950
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinUserServiceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinUserService'.");
			}
			return handle;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0000D77B File Offset: 0x0000B97B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000D7AC File Offset: 0x0000B9AC
		public IAppLovinUserServiceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinUserServiceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0000D7E4 File Offset: 0x0000B9E4
		private static Delegate GetPreloadConsentDialogHandler()
		{
			if (IAppLovinUserServiceInvoker.cb_preloadConsentDialog == null)
			{
				IAppLovinUserServiceInvoker.cb_preloadConsentDialog = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IAppLovinUserServiceInvoker.n_PreloadConsentDialog));
			}
			return IAppLovinUserServiceInvoker.cb_preloadConsentDialog;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0000D808 File Offset: 0x0000BA08
		private static void n_PreloadConsentDialog(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IAppLovinUserService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PreloadConsentDialog();
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0000D817 File Offset: 0x0000BA17
		public void PreloadConsentDialog()
		{
			if (this.id_preloadConsentDialog == IntPtr.Zero)
			{
				this.id_preloadConsentDialog = JNIEnv.GetMethodID(this.class_ref, "preloadConsentDialog", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_preloadConsentDialog);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0000D857 File Offset: 0x0000BA57
		private static Delegate GetShowConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_Handler()
		{
			if (IAppLovinUserServiceInvoker.cb_showConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_ == null)
			{
				IAppLovinUserServiceInvoker.cb_showConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinUserServiceInvoker.n_ShowConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_));
			}
			return IAppLovinUserServiceInvoker.cb_showConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0000D87C File Offset: 0x0000BA7C
		private static void n_ShowConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinUserService @object = Java.Lang.Object.GetObject<IAppLovinUserService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinUserServiceOnConsentDialogDismissListener object3 = Java.Lang.Object.GetObject<IAppLovinUserServiceOnConsentDialogDismissListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.ShowConsentDialog(object2, object3);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
		public unsafe void ShowConsentDialog(Activity p0, IAppLovinUserServiceOnConsentDialogDismissListener p1)
		{
			if (this.id_showConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_ == IntPtr.Zero)
			{
				this.id_showConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_ = JNIEnv.GetMethodID(this.class_ref, "showConsentDialog", "(Landroid/app/Activity;Lcom/applovin/sdk/AppLovinUserService$OnConsentDialogDismissListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_showConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_, ptr);
		}

		// Token: 0x04000187 RID: 391
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinUserService", typeof(IAppLovinUserServiceInvoker));

		// Token: 0x04000188 RID: 392
		private IntPtr class_ref;

		// Token: 0x04000189 RID: 393
		private static Delegate cb_preloadConsentDialog;

		// Token: 0x0400018A RID: 394
		private IntPtr id_preloadConsentDialog;

		// Token: 0x0400018B RID: 395
		private static Delegate cb_showConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_;

		// Token: 0x0400018C RID: 396
		private IntPtr id_showConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_;
	}
}
