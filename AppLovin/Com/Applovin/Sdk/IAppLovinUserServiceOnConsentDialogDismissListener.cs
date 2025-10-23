using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000095 RID: 149
	[Register("com/applovin/sdk/AppLovinUserService$OnConsentDialogDismissListener", "", "Com.Applovin.Sdk.IAppLovinUserServiceOnConsentDialogDismissListenerInvoker")]
	public interface IAppLovinUserServiceOnConsentDialogDismissListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600050B RID: 1291
		[Register("onDismiss", "()V", "GetOnDismissHandler:Com.Applovin.Sdk.IAppLovinUserServiceOnConsentDialogDismissListenerInvoker, AppLovin")]
		void OnDismiss();
	}
}
