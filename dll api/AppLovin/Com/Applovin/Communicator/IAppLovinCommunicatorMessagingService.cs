using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Communicator
{
	// Token: 0x02000176 RID: 374
	[Register("com/applovin/communicator/AppLovinCommunicatorMessagingService", "", "Com.Applovin.Communicator.IAppLovinCommunicatorMessagingServiceInvoker")]
	public interface IAppLovinCommunicatorMessagingService : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060011FA RID: 4602
		[Register("publish", "(Lcom/applovin/communicator/AppLovinCommunicatorMessage;)V", "GetPublish_Lcom_applovin_communicator_AppLovinCommunicatorMessage_Handler:Com.Applovin.Communicator.IAppLovinCommunicatorMessagingServiceInvoker, AppLovin")]
		void Publish(AppLovinCommunicatorMessage p0);
	}
}
