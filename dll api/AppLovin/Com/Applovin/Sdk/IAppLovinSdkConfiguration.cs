using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200008F RID: 143
	[Register("com/applovin/sdk/AppLovinSdkConfiguration", "", "Com.Applovin.Sdk.IAppLovinSdkConfigurationInvoker")]
	public interface IAppLovinSdkConfiguration : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060004A4 RID: 1188
		AppLovinSdkConfigurationConsentDialogState ConsentDialogState { [Register("getConsentDialogState", "()Lcom/applovin/sdk/AppLovinSdkConfiguration$ConsentDialogState;", "GetGetConsentDialogStateHandler:Com.Applovin.Sdk.IAppLovinSdkConfigurationInvoker, AppLovin")] get; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060004A5 RID: 1189
		string CountryCode { [Register("getCountryCode", "()Ljava/lang/String;", "GetGetCountryCodeHandler:Com.Applovin.Sdk.IAppLovinSdkConfigurationInvoker, AppLovin")] get; }
	}
}
