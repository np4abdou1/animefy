using System;
using System.Threading;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200036F RID: 879
	[Serializable]
	internal class EnvoyTerminatorSink : IMessageSink
	{
		// Token: 0x06001B9A RID: 7066 RVA: 0x00076E8F File Offset: 0x0007508F
		public IMessage SyncProcessMessage(IMessage msg)
		{
			return Thread.CurrentContext.GetClientContextSinkChain().SyncProcessMessage(msg);
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x00076EA1 File Offset: 0x000750A1
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return Thread.CurrentContext.GetClientContextSinkChain().AsyncProcessMessage(msg, replySink);
		}

		// Token: 0x04000B9D RID: 2973
		public static EnvoyTerminatorSink Instance = new EnvoyTerminatorSink();
	}
}
