using System;

namespace System.Net.Sockets
{
	// Token: 0x0200021A RID: 538
	internal enum SocketOperation
	{
		// Token: 0x04000BB8 RID: 3000
		Accept,
		// Token: 0x04000BB9 RID: 3001
		Connect,
		// Token: 0x04000BBA RID: 3002
		Receive,
		// Token: 0x04000BBB RID: 3003
		ReceiveFrom,
		// Token: 0x04000BBC RID: 3004
		Send,
		// Token: 0x04000BBD RID: 3005
		SendTo,
		// Token: 0x04000BBE RID: 3006
		RecvJustCallback,
		// Token: 0x04000BBF RID: 3007
		SendJustCallback,
		// Token: 0x04000BC0 RID: 3008
		Disconnect,
		// Token: 0x04000BC1 RID: 3009
		AcceptReceive,
		// Token: 0x04000BC2 RID: 3010
		ReceiveGeneric,
		// Token: 0x04000BC3 RID: 3011
		SendGeneric
	}
}
