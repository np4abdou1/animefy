using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Communicator
{
	// Token: 0x0200017A RID: 378
	[Register("com/applovin/communicator/AppLovinCommunicatorSubscriber", "", "Com.Applovin.Communicator.IAppLovinCommunicatorSubscriberInvoker")]
	public interface IAppLovinCommunicatorSubscriber : IAppLovinCommunicatorEntity, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001213 RID: 4627
		[Register("onMessageReceived", "(Lcom/applovin/communicator/AppLovinCommunicatorMessage;)V", "GetOnMessageReceived_Lcom_applovin_communicator_AppLovinCommunicatorMessage_Handler:Com.Applovin.Communicator.IAppLovinCommunicatorSubscriberInvoker, AppLovin")]
		void OnMessageReceived(AppLovinCommunicatorMessage p0);
	}
}
