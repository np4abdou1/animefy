using System;

namespace Mono.Net.Security
{
	// Token: 0x0200000F RID: 15
	internal class AsyncHandshakeRequest : AsyncProtocolRequest
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00002D9E File Offset: 0x00000F9E
		public AsyncHandshakeRequest(MobileAuthenticatedStream parent, bool sync) : base(parent, sync)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002DA8 File Offset: 0x00000FA8
		protected override AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			return base.Parent.ProcessHandshake(status, false);
		}
	}
}
