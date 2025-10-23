using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000087 RID: 135
	[Register("com/applovin/sdk/AppLovinPostbackListener", "", "Com.Applovin.Sdk.IAppLovinPostbackListenerInvoker")]
	public interface IAppLovinPostbackListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000472 RID: 1138
		[Register("onPostbackFailure", "(Ljava/lang/String;I)V", "GetOnPostbackFailure_Ljava_lang_String_IHandler:Com.Applovin.Sdk.IAppLovinPostbackListenerInvoker, AppLovin")]
		void OnPostbackFailure(string p0, int p1);

		// Token: 0x06000473 RID: 1139
		[Register("onPostbackSuccess", "(Ljava/lang/String;)V", "GetOnPostbackSuccess_Ljava_lang_String_Handler:Com.Applovin.Sdk.IAppLovinPostbackListenerInvoker, AppLovin")]
		void OnPostbackSuccess(string p0);
	}
}
