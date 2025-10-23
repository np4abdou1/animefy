using System;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000C0 RID: 192
	[Register("com/applovin/mediation/MaxNetworkResponseInfo", "", "Com.Applovin.Mediation.IMaxNetworkResponseInfoInvoker")]
	public interface IMaxNetworkResponseInfo : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600068C RID: 1676
		MaxNetworkResponseInfoAdLoadState AdLoadState { [Register("getAdLoadState", "()Lcom/applovin/mediation/MaxNetworkResponseInfo$AdLoadState;", "GetGetAdLoadStateHandler:Com.Applovin.Mediation.IMaxNetworkResponseInfoInvoker, AppLovin")] get; }

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600068D RID: 1677
		Bundle Credentials { [Register("getCredentials", "()Landroid/os/Bundle;", "GetGetCredentialsHandler:Com.Applovin.Mediation.IMaxNetworkResponseInfoInvoker, AppLovin")] get; }

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600068E RID: 1678
		IMaxError Error { [Register("getError", "()Lcom/applovin/mediation/MaxError;", "GetGetErrorHandler:Com.Applovin.Mediation.IMaxNetworkResponseInfoInvoker, AppLovin")] get; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600068F RID: 1679
		long LatencyMillis { [Register("getLatencyMillis", "()J", "GetGetLatencyMillisHandler:Com.Applovin.Mediation.IMaxNetworkResponseInfoInvoker, AppLovin")] get; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000690 RID: 1680
		IMaxMediatedNetworkInfo MediatedNetwork { [Register("getMediatedNetwork", "()Lcom/applovin/mediation/MaxMediatedNetworkInfo;", "GetGetMediatedNetworkHandler:Com.Applovin.Mediation.IMaxNetworkResponseInfoInvoker, AppLovin")] get; }
	}
}
