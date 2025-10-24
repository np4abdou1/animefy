using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000067 RID: 103
	[Register("com/applovin/sdk/AppLovinAd", "", "Com.Applovin.Sdk.IAppLovinAdInvoker")]
	public interface IAppLovinAd : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000385 RID: 901
		long AdIdNumber { [Register("getAdIdNumber", "()J", "GetGetAdIdNumberHandler:Com.Applovin.Sdk.IAppLovinAdInvoker, AppLovin")] get; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000386 RID: 902
		bool IsVideoAd { [Register("isVideoAd", "()Z", "GetIsVideoAdHandler:Com.Applovin.Sdk.IAppLovinAdInvoker, AppLovin")] get; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000387 RID: 903
		AppLovinAdSize Size { [Register("getSize", "()Lcom/applovin/sdk/AppLovinAdSize;", "GetGetSizeHandler:Com.Applovin.Sdk.IAppLovinAdInvoker, AppLovin")] get; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000388 RID: 904
		AppLovinAdType Type { [Register("getType", "()Lcom/applovin/sdk/AppLovinAdType;", "GetGetTypeHandler:Com.Applovin.Sdk.IAppLovinAdInvoker, AppLovin")] get; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000389 RID: 905
		string ZoneId { [Register("getZoneId", "()Ljava/lang/String;", "GetGetZoneIdHandler:Com.Applovin.Sdk.IAppLovinAdInvoker, AppLovin")] get; }

		// Token: 0x0600038A RID: 906
		[Register("getAdValue", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAdValue_Ljava_lang_String_Handler:Com.Applovin.Sdk.IAppLovinAdInvoker, AppLovin")]
		string GetAdValue(string p0);

		// Token: 0x0600038B RID: 907
		[Register("getAdValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetAdValue_Ljava_lang_String_Ljava_lang_String_Handler:Com.Applovin.Sdk.IAppLovinAdInvoker, AppLovin")]
		string GetAdValue(string p0, string p1);
	}
}
