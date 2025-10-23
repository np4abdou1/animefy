using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000B7 RID: 183
	[Register("com/applovin/mediation/MaxError", "", "Com.Applovin.Mediation.IMaxErrorInvoker")]
	public interface IMaxError : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000644 RID: 1604
		string AdLoadFailureInfo { [Register("getAdLoadFailureInfo", "()Ljava/lang/String;", "GetGetAdLoadFailureInfoHandler:Com.Applovin.Mediation.IMaxErrorInvoker, AppLovin")] get; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000645 RID: 1605
		int Code { [Register("getCode", "()I", "GetGetCodeHandler:Com.Applovin.Mediation.IMaxErrorInvoker, AppLovin")] get; }

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000646 RID: 1606
		string Message { [Register("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler:Com.Applovin.Mediation.IMaxErrorInvoker, AppLovin")] get; }

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000647 RID: 1607
		IMaxAdWaterfallInfo Waterfall { [Register("getWaterfall", "()Lcom/applovin/mediation/MaxAdWaterfallInfo;", "GetGetWaterfallHandler:Com.Applovin.Mediation.IMaxErrorInvoker, AppLovin")] get; }
	}
}
