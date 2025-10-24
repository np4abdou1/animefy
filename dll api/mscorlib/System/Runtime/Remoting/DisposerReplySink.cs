using System;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting
{
	// Token: 0x02000316 RID: 790
	internal class DisposerReplySink : IMessageSink
	{
		// Token: 0x06001A04 RID: 6660 RVA: 0x00071B71 File Offset: 0x0006FD71
		public DisposerReplySink(IMessageSink next, IDisposable disposable)
		{
			this._next = next;
			this._disposable = disposable;
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00071B87 File Offset: 0x0006FD87
		public IMessage SyncProcessMessage(IMessage msg)
		{
			this._disposable.Dispose();
			return this._next.SyncProcessMessage(msg);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0002AD12 File Offset: 0x00028F12
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000AD6 RID: 2774
		private IMessageSink _next;

		// Token: 0x04000AD7 RID: 2775
		private IDisposable _disposable;
	}
}
