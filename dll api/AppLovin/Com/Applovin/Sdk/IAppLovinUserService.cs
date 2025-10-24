using System;
using Android.App;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000098 RID: 152
	[Register("com/applovin/sdk/AppLovinUserService", "", "Com.Applovin.Sdk.IAppLovinUserServiceInvoker")]
	public interface IAppLovinUserService : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600051B RID: 1307
		[Register("preloadConsentDialog", "()V", "GetPreloadConsentDialogHandler:Com.Applovin.Sdk.IAppLovinUserServiceInvoker, AppLovin")]
		void PreloadConsentDialog();

		// Token: 0x0600051C RID: 1308
		[Register("showConsentDialog", "(Landroid/app/Activity;Lcom/applovin/sdk/AppLovinUserService$OnConsentDialogDismissListener;)V", "GetShowConsentDialog_Landroid_app_Activity_Lcom_applovin_sdk_AppLovinUserService_OnConsentDialogDismissListener_Handler:Com.Applovin.Sdk.IAppLovinUserServiceInvoker, AppLovin")]
		void ShowConsentDialog(Activity p0, IAppLovinUserServiceOnConsentDialogDismissListener p1);
	}
}
