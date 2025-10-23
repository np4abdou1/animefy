using System;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x0200033B RID: 827
	internal class SynchronizedClientContextSink : IMessageSink
	{
		// Token: 0x06001AB9 RID: 6841 RVA: 0x00074086 File Offset: 0x00072286
		public SynchronizedClientContextSink(IMessageSink next, SynchronizationAttribute att)
		{
			this._att = att;
			this._next = next;
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0007409C File Offset: 0x0007229C
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			if (this._att.IsReEntrant)
			{
				this._att.ReleaseLock();
				replySink = new SynchronizedContextReplySink(replySink, this._att, true);
			}
			return this._next.AsyncProcessMessage(msg, replySink);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x000740D4 File Offset: 0x000722D4
		public IMessage SyncProcessMessage(IMessage msg)
		{
			if (this._att.IsReEntrant)
			{
				this._att.ReleaseLock();
			}
			IMessage result;
			try
			{
				result = this._next.SyncProcessMessage(msg);
			}
			finally
			{
				if (this._att.IsReEntrant)
				{
					this._att.AcquireLock();
				}
			}
			return result;
		}

		// Token: 0x04000B2E RID: 2862
		private IMessageSink _next;

		// Token: 0x04000B2F RID: 2863
		private SynchronizationAttribute _att;
	}
}
