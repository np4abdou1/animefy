using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x0200023A RID: 570
	[FriendAccessAllowed]
	internal enum AsyncCausalityStatus
	{
		// Token: 0x040007EC RID: 2028
		Started,
		// Token: 0x040007ED RID: 2029
		Completed,
		// Token: 0x040007EE RID: 2030
		Canceled,
		// Token: 0x040007EF RID: 2031
		Error
	}
}
