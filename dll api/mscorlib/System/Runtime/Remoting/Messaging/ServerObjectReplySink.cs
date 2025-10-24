using System;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000389 RID: 905
	internal class ServerObjectReplySink : IMessageSink
	{
		// Token: 0x06001C5C RID: 7260 RVA: 0x00078EC1 File Offset: 0x000770C1
		public ServerObjectReplySink(ServerIdentity identity, IMessageSink replySink)
		{
			this._replySink = replySink;
			this._identity = identity;
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x00078ED7 File Offset: 0x000770D7
		public IMessage SyncProcessMessage(IMessage msg)
		{
			this._identity.NotifyServerDynamicSinks(false, msg, true, true);
			return this._replySink.SyncProcessMessage(msg);
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x0002AD12 File Offset: 0x00028F12
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000BE7 RID: 3047
		private IMessageSink _replySink;

		// Token: 0x04000BE8 RID: 3048
		private ServerIdentity _identity;
	}
}
