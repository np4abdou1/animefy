using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Mono.Net.Security
{
	// Token: 0x0200000B RID: 11
	internal abstract class AsyncProtocolRequest
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000026FA File Offset: 0x000008FA
		public MobileAuthenticatedStream Parent { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002702 File Offset: 0x00000902
		public bool RunSynchronously { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000270A File Offset: 0x0000090A
		public string Name
		{
			get
			{
				return base.GetType().Name;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002717 File Offset: 0x00000917
		// (set) Token: 0x06000032 RID: 50 RVA: 0x0000271F File Offset: 0x0000091F
		public int UserResult { get; protected set; }

		// Token: 0x06000033 RID: 51 RVA: 0x00002728 File Offset: 0x00000928
		public AsyncProtocolRequest(MobileAuthenticatedStream parent, bool sync)
		{
			this.Parent = parent;
			this.RunSynchronously = sync;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000274C File Offset: 0x0000094C
		internal void RequestRead(int size)
		{
			object obj = this.locker;
			lock (obj)
			{
				this.RequestedSize += size;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002794 File Offset: 0x00000994
		internal void RequestWrite()
		{
			this.WriteRequested = 1;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000027A0 File Offset: 0x000009A0
		internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken)
		{
			AsyncProtocolRequest.<StartOperation>d__23 <StartOperation>d__;
			<StartOperation>d__.<>t__builder = AsyncTaskMethodBuilder<AsyncProtocolResult>.Create();
			<StartOperation>d__.<>4__this = this;
			<StartOperation>d__.cancellationToken = cancellationToken;
			<StartOperation>d__.<>1__state = -1;
			<StartOperation>d__.<>t__builder.Start<AsyncProtocolRequest.<StartOperation>d__23>(ref <StartOperation>d__);
			return <StartOperation>d__.<>t__builder.Task;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000027EC File Offset: 0x000009EC
		private Task ProcessOperation(CancellationToken cancellationToken)
		{
			AsyncProtocolRequest.<ProcessOperation>d__24 <ProcessOperation>d__;
			<ProcessOperation>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ProcessOperation>d__.<>4__this = this;
			<ProcessOperation>d__.cancellationToken = cancellationToken;
			<ProcessOperation>d__.<>1__state = -1;
			<ProcessOperation>d__.<>t__builder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>(ref <ProcessOperation>d__);
			return <ProcessOperation>d__.<>t__builder.Task;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002838 File Offset: 0x00000A38
		private Task<int?> InnerRead(CancellationToken cancellationToken)
		{
			AsyncProtocolRequest.<InnerRead>d__25 <InnerRead>d__;
			<InnerRead>d__.<>t__builder = AsyncTaskMethodBuilder<int?>.Create();
			<InnerRead>d__.<>4__this = this;
			<InnerRead>d__.cancellationToken = cancellationToken;
			<InnerRead>d__.<>1__state = -1;
			<InnerRead>d__.<>t__builder.Start<AsyncProtocolRequest.<InnerRead>d__25>(ref <InnerRead>d__);
			return <InnerRead>d__.<>t__builder.Task;
		}

		// Token: 0x06000039 RID: 57
		protected abstract AsyncOperationStatus Run(AsyncOperationStatus status);

		// Token: 0x0600003A RID: 58 RVA: 0x00002883 File Offset: 0x00000A83
		public override string ToString()
		{
			return string.Format("[{0}]", this.Name);
		}

		// Token: 0x04000019 RID: 25
		private int Started;

		// Token: 0x0400001A RID: 26
		private int RequestedSize;

		// Token: 0x0400001B RID: 27
		private int WriteRequested;

		// Token: 0x0400001C RID: 28
		private readonly object locker = new object();
	}
}
