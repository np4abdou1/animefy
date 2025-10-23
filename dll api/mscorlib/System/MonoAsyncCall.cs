using System;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000173 RID: 371
	[StructLayout(0)]
	internal class MonoAsyncCall
	{
		// Token: 0x04000599 RID: 1433
		private object msg;

		// Token: 0x0400059A RID: 1434
		private IntPtr cb_method;

		// Token: 0x0400059B RID: 1435
		private object cb_target;

		// Token: 0x0400059C RID: 1436
		private object state;

		// Token: 0x0400059D RID: 1437
		private object res;

		// Token: 0x0400059E RID: 1438
		private object out_args;
	}
}
