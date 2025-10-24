using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Communicator
{
	// Token: 0x02000178 RID: 376
	[Register("com/applovin/communicator/AppLovinCommunicatorPublisher", "", "Com.Applovin.Communicator.IAppLovinCommunicatorPublisherInvoker")]
	public interface IAppLovinCommunicatorPublisher : IAppLovinCommunicatorEntity, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
