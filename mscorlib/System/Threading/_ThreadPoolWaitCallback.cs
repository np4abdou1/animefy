using System;
using System.Security;

namespace System.Threading
{
	// Token: 0x020001EA RID: 490
	internal static class _ThreadPoolWaitCallback
	{
		// Token: 0x060011CE RID: 4558 RVA: 0x00048B0C File Offset: 0x00046D0C
		[SecurityCritical]
		internal static bool PerformWaitCallback()
		{
			return ThreadPoolWorkQueue.Dispatch();
		}
	}
}
