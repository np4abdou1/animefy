using System;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200036B RID: 875
	internal class ClientContextReplySink : IMessageSink
	{
		// Token: 0x06001B7E RID: 7038 RVA: 0x00076A7F File Offset: 0x00074C7F
		public ClientContextReplySink(Context ctx, IMessageSink replySink)
		{
			this._replySink = replySink;
			this._context = ctx;
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00076A95 File Offset: 0x00074C95
		public IMessage SyncProcessMessage(IMessage msg)
		{
			Context.NotifyGlobalDynamicSinks(false, msg, true, true);
			this._context.NotifyDynamicSinks(false, msg, true, true);
			return this._replySink.SyncProcessMessage(msg);
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0002AD12 File Offset: 0x00028F12
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000B93 RID: 2963
		private IMessageSink _replySink;

		// Token: 0x04000B94 RID: 2964
		private Context _context;
	}
}
