using System;
using System.Runtime.Remoting.Activation;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000387 RID: 903
	internal class ServerContextTerminatorSink : IMessageSink
	{
		// Token: 0x06001C56 RID: 7254 RVA: 0x00078DE8 File Offset: 0x00076FE8
		public IMessage SyncProcessMessage(IMessage msg)
		{
			if (msg is IConstructionCallMessage)
			{
				return ActivationServices.CreateInstanceFromMessage((IConstructionCallMessage)msg);
			}
			return ((ServerIdentity)RemotingServices.GetMessageTargetIdentity(msg)).SyncObjectProcessMessage(msg);
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00078E0F File Offset: 0x0007700F
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return ((ServerIdentity)RemotingServices.GetMessageTargetIdentity(msg)).AsyncObjectProcessMessage(msg, replySink);
		}
	}
}
