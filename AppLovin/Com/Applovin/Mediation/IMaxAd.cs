using System;
using Android.Runtime;
using Com.Applovin.Mediation.NativeAds;
using Com.Applovin.Sdk;
using Java.Interop;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000A0 RID: 160
	[Register("com/applovin/mediation/MaxAd", "", "Com.Applovin.Mediation.IMaxAdInvoker")]
	public interface IMaxAd : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600055F RID: 1375
		string AdReviewCreativeId { [Register("getAdReviewCreativeId", "()Ljava/lang/String;", "GetGetAdReviewCreativeIdHandler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")] get; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000560 RID: 1376
		string AdUnitId { [Register("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")] get; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000561 RID: 1377
		string CreativeId { [Register("getCreativeId", "()Ljava/lang/String;", "GetGetCreativeIdHandler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")] get; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000562 RID: 1378
		string DspId { [Register("getDspId", "()Ljava/lang/String;", "GetGetDspIdHandler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")] get; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000563 RID: 1379
		string DspName { [Register("getDspName", "()Ljava/lang/String;", "GetGetDspNameHandler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")] get; }

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000564 RID: 1380
		MaxAdFormat Format { [Register("getFormat", "()Lcom/applovin/mediation/MaxAdFormat;", "GetGetFormatHandler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")] get; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000565 RID: 1381
		MaxNativeAd NativeAd { [Register("getNativeAd", "()Lcom/applovin/mediation/nativeAds/MaxNativeAd;", "GetGetNativeAdHandler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")] get; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000566 RID: 1382
		string NetworkName { [Register("getNetworkName", "()Ljava/lang/String;", "GetGetNetworkNameHandler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")] get; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000567 RID: 1383
		string NetworkPlacement { [Register("getNetworkPlacement", "()Ljava/lang/String;", "GetGetNetworkPlacementHandler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")] get; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000568 RID: 1384
		string Placement { [Register("getPlacement", "()Ljava/lang/String;", "GetGetPlacementHandler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")] get; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000569 RID: 1385
		double Revenue { [Register("getRevenue", "()D", "GetGetRevenueHandler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")] get; }

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600056A RID: 1386
		string RevenuePrecision { [Register("getRevenuePrecision", "()Ljava/lang/String;", "GetGetRevenuePrecisionHandler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")] get; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600056B RID: 1387
		AppLovinSdkUtils.Size Size { [Register("getSize", "()Lcom/applovin/sdk/AppLovinSdkUtils$Size;", "GetGetSizeHandler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")] get; }

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600056C RID: 1388
		IMaxAdWaterfallInfo Waterfall { [Register("getWaterfall", "()Lcom/applovin/mediation/MaxAdWaterfallInfo;", "GetGetWaterfallHandler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")] get; }

		// Token: 0x0600056D RID: 1389
		[Register("getAdValue", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAdValue_Ljava_lang_String_Handler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")]
		string GetAdValue(string p0);

		// Token: 0x0600056E RID: 1390
		[Register("getAdValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetAdValue_Ljava_lang_String_Ljava_lang_String_Handler:Com.Applovin.Mediation.IMaxAdInvoker, AppLovin")]
		string GetAdValue(string p0, string p1);
	}
}
