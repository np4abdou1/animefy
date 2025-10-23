using System;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x02000344 RID: 836
	internal class AsyncRequest
	{
		// Token: 0x06001AE8 RID: 6888 RVA: 0x00074E7B File Offset: 0x0007307B
		public AsyncRequest(IMessage msgRequest, IMessageSink replySink)
		{
			this.ReplySink = replySink;
			this.MsgRequest = msgRequest;
		}

		// Token: 0x04000B43 RID: 2883
		internal IMessageSink ReplySink;

		// Token: 0x04000B44 RID: 2884
		internal IMessage MsgRequest;
	}
}
