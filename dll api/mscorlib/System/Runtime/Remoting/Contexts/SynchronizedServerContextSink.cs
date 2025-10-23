using System;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x0200033C RID: 828
	internal class SynchronizedServerContextSink : IMessageSink
	{
		// Token: 0x06001ABC RID: 6844 RVA: 0x00074134 File Offset: 0x00072334
		public SynchronizedServerContextSink(IMessageSink next, SynchronizationAttribute att)
		{
			this._att = att;
			this._next = next;
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0007414A File Offset: 0x0007234A
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			this._att.AcquireLock();
			replySink = new SynchronizedContextReplySink(replySink, this._att, false);
			return this._next.AsyncProcessMessage(msg, replySink);
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00074174 File Offset: 0x00072374
		public IMessage SyncProcessMessage(IMessage msg)
		{
			this._att.AcquireLock();
			IMessage result;
			try
			{
				result = this._next.SyncProcessMessage(msg);
			}
			finally
			{
				this._att.ReleaseLock();
			}
			return result;
		}

		// Token: 0x04000B30 RID: 2864
		private IMessageSink _next;

		// Token: 0x04000B31 RID: 2865
		private SynchronizationAttribute _att;
	}
}
