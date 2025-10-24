using System;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x0200033D RID: 829
	internal class SynchronizedContextReplySink : IMessageSink
	{
		// Token: 0x06001ABF RID: 6847 RVA: 0x000741B8 File Offset: 0x000723B8
		public SynchronizedContextReplySink(IMessageSink next, SynchronizationAttribute att, bool newLock)
		{
			this._newLock = newLock;
			this._next = next;
			this._att = att;
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x0002AD12 File Offset: 0x00028F12
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x000741D8 File Offset: 0x000723D8
		public IMessage SyncProcessMessage(IMessage msg)
		{
			if (this._newLock)
			{
				this._att.AcquireLock();
			}
			else
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
				if (this._newLock)
				{
					this._att.ReleaseLock();
				}
			}
			return result;
		}

		// Token: 0x04000B32 RID: 2866
		private IMessageSink _next;

		// Token: 0x04000B33 RID: 2867
		private bool _newLock;

		// Token: 0x04000B34 RID: 2868
		private SynchronizationAttribute _att;
	}
}
