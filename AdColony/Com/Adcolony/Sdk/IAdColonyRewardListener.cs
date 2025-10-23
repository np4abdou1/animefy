using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Adcolony.Sdk
{
	// Token: 0x02000050 RID: 80
	[Register("com/adcolony/sdk/AdColonyRewardListener", "", "Com.Adcolony.Sdk.IAdColonyRewardListenerInvoker")]
	public interface IAdColonyRewardListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000417 RID: 1047
		[Register("onReward", "(Lcom/adcolony/sdk/AdColonyReward;)V", "GetOnReward_Lcom_adcolony_sdk_AdColonyReward_Handler:Com.Adcolony.Sdk.IAdColonyRewardListenerInvoker, AdColony")]
		void OnReward(AdColonyReward p0);
	}
}
