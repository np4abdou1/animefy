using System;
using System.Runtime.ExceptionServices;

namespace Mono.Net.Security
{
	// Token: 0x0200000A RID: 10
	internal class AsyncProtocolResult
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000026CC File Offset: 0x000008CC
		public int UserResult { get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000026D4 File Offset: 0x000008D4
		public ExceptionDispatchInfo Error { get; }

		// Token: 0x0600002C RID: 44 RVA: 0x000026DC File Offset: 0x000008DC
		public AsyncProtocolResult(int result)
		{
			this.UserResult = result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000026EB File Offset: 0x000008EB
		public AsyncProtocolResult(ExceptionDispatchInfo error)
		{
			this.Error = error;
		}
	}
}
