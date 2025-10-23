using System;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x02000329 RID: 809
	internal class LeaseSink : IMessageSink
	{
		// Token: 0x06001A6D RID: 6765 RVA: 0x000733D3 File Offset: 0x000715D3
		public LeaseSink(IMessageSink nextSink)
		{
			this._nextSink = nextSink;
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x000733E2 File Offset: 0x000715E2
		public IMessage SyncProcessMessage(IMessage msg)
		{
			this.RenewLease(msg);
			return this._nextSink.SyncProcessMessage(msg);
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x000733F7 File Offset: 0x000715F7
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			this.RenewLease(msg);
			return this._nextSink.AsyncProcessMessage(msg, replySink);
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x00073410 File Offset: 0x00071610
		private void RenewLease(IMessage msg)
		{
			ILease lease = ((ServerIdentity)RemotingServices.GetMessageTargetIdentity(msg)).Lease;
			if (lease != null && lease.CurrentLeaseTime < lease.RenewOnCallTime)
			{
				lease.Renew(lease.RenewOnCallTime);
			}
		}

		// Token: 0x04000B08 RID: 2824
		private IMessageSink _nextSink;
	}
}
