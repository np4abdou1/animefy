using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000C4 RID: 196
	[Register("com/applovin/mediation/MaxReward", "", "Com.Applovin.Mediation.IMaxRewardInvoker")]
	public interface IMaxReward : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060006AB RID: 1707
		int Amount { [Register("getAmount", "()I", "GetGetAmountHandler:Com.Applovin.Mediation.IMaxRewardInvoker, AppLovin")] get; }

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060006AC RID: 1708
		string Label { [Register("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler:Com.Applovin.Mediation.IMaxRewardInvoker, AppLovin")] get; }
	}
}
