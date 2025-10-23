using System;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000388 RID: 904
	internal class ServerObjectTerminatorSink : IMessageSink
	{
		// Token: 0x06001C59 RID: 7257 RVA: 0x00078E23 File Offset: 0x00077023
		public ServerObjectTerminatorSink(IMessageSink nextSink)
		{
			this._nextSink = nextSink;
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x00078E34 File Offset: 0x00077034
		public IMessage SyncProcessMessage(IMessage msg)
		{
			ServerIdentity serverIdentity = (ServerIdentity)RemotingServices.GetMessageTargetIdentity(msg);
			serverIdentity.NotifyServerDynamicSinks(true, msg, false, false);
			IMessage result = this._nextSink.SyncProcessMessage(msg);
			serverIdentity.NotifyServerDynamicSinks(false, msg, false, false);
			return result;
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x00078E70 File Offset: 0x00077070
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			ServerIdentity serverIdentity = (ServerIdentity)RemotingServices.GetMessageTargetIdentity(msg);
			if (serverIdentity.HasServerDynamicSinks)
			{
				serverIdentity.NotifyServerDynamicSinks(true, msg, false, true);
				if (replySink != null)
				{
					replySink = new ServerObjectReplySink(serverIdentity, replySink);
				}
			}
			IMessageCtrl result = this._nextSink.AsyncProcessMessage(msg, replySink);
			if (replySink == null)
			{
				serverIdentity.NotifyServerDynamicSinks(false, msg, true, true);
			}
			return result;
		}

		// Token: 0x04000BE6 RID: 3046
		private IMessageSink _nextSink;
	}
}
