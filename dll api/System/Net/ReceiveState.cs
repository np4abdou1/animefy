using System;

namespace System.Net
{
	// Token: 0x0200011D RID: 285
	internal class ReceiveState
	{
		// Token: 0x06000824 RID: 2084 RVA: 0x0002D8AC File Offset: 0x0002BAAC
		internal ReceiveState(CommandStream connection)
		{
			this.Connection = connection;
			this.Resp = new ResponseDescription();
			this.Buffer = new byte[1024];
			this.ValidThrough = 0;
		}

		// Token: 0x0400059D RID: 1437
		internal ResponseDescription Resp;

		// Token: 0x0400059E RID: 1438
		internal int ValidThrough;

		// Token: 0x0400059F RID: 1439
		internal byte[] Buffer;

		// Token: 0x040005A0 RID: 1440
		internal CommandStream Connection;
	}
}
