using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter.Parameters
{
	// Token: 0x02000113 RID: 275
	[Register("com/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters", "", "Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterResponseParametersInvoker")]
	public interface IMaxAdapterResponseParameters : IMaxAdapterParameters, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000BB1 RID: 2993
		long BidExpirationMillis { [Register("getBidExpirationMillis", "()J", "GetGetBidExpirationMillisHandler:Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterResponseParametersInvoker, AppLovin")] get; }

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000BB2 RID: 2994
		string BidResponse { [Register("getBidResponse", "()Ljava/lang/String;", "GetGetBidResponseHandler:Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterResponseParametersInvoker, AppLovin")] get; }

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000BB3 RID: 2995
		string ThirdPartyAdPlacementId { [Register("getThirdPartyAdPlacementId", "()Ljava/lang/String;", "GetGetThirdPartyAdPlacementIdHandler:Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterResponseParametersInvoker, AppLovin")] get; }
	}
}
