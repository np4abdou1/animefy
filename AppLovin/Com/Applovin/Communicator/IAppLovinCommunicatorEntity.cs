using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Communicator
{
	// Token: 0x02000174 RID: 372
	[Register("com/applovin/communicator/AppLovinCommunicatorEntity", "", "Com.Applovin.Communicator.IAppLovinCommunicatorEntityInvoker")]
	public interface IAppLovinCommunicatorEntity : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060011ED RID: 4589
		string CommunicatorId { [Register("getCommunicatorId", "()Ljava/lang/String;", "GetGetCommunicatorIdHandler:Com.Applovin.Communicator.IAppLovinCommunicatorEntityInvoker, AppLovin")] get; }
	}
}
