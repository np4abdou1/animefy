using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200008C RID: 140
	[Register("com/applovin/sdk/AppLovinPostbackService", "", "Com.Applovin.Sdk.IAppLovinPostbackServiceInvoker")]
	public interface IAppLovinPostbackService : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600048C RID: 1164
		[Register("dispatchPostbackAsync", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinPostbackListener;)V", "GetDispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_Handler:Com.Applovin.Sdk.IAppLovinPostbackServiceInvoker, AppLovin")]
		void DispatchPostbackAsync(string p0, IAppLovinPostbackListener p1);
	}
}
