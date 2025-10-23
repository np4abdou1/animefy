using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000B5 RID: 181
	[Register("com/applovin/mediation/MaxAdWaterfallInfo", "", "Com.Applovin.Mediation.IMaxAdWaterfallInfoInvoker")]
	public interface IMaxAdWaterfallInfo : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000627 RID: 1575
		long LatencyMillis { [Register("getLatencyMillis", "()J", "GetGetLatencyMillisHandler:Com.Applovin.Mediation.IMaxAdWaterfallInfoInvoker, AppLovin")] get; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000628 RID: 1576
		IMaxAd LoadedAd { [Register("getLoadedAd", "()Lcom/applovin/mediation/MaxAd;", "GetGetLoadedAdHandler:Com.Applovin.Mediation.IMaxAdWaterfallInfoInvoker, AppLovin")] get; }

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000629 RID: 1577
		string Name { [Register("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Applovin.Mediation.IMaxAdWaterfallInfoInvoker, AppLovin")] get; }

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600062A RID: 1578
		IList<IMaxNetworkResponseInfo> NetworkResponses { [Register("getNetworkResponses", "()Ljava/util/List;", "GetGetNetworkResponsesHandler:Com.Applovin.Mediation.IMaxAdWaterfallInfoInvoker, AppLovin")] get; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600062B RID: 1579
		string TestName { [Register("getTestName", "()Ljava/lang/String;", "GetGetTestNameHandler:Com.Applovin.Mediation.IMaxAdWaterfallInfoInvoker, AppLovin")] get; }
	}
}
