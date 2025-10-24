using System;

namespace System.Threading
{
	// Token: 0x020001B8 RID: 440
	internal static class TimeoutHelper
	{
		// Token: 0x06001099 RID: 4249 RVA: 0x00044C30 File Offset: 0x00042E30
		public static uint GetTime()
		{
			return (uint)Environment.TickCount;
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00044C38 File Offset: 0x00042E38
		public static int UpdateTimeOut(uint startTime, int originalWaitMillisecondsTimeout)
		{
			uint num = TimeoutHelper.GetTime() - startTime;
			if (num > 2147483647U)
			{
				return 0;
			}
			int num2 = originalWaitMillisecondsTimeout - (int)num;
			if (num2 <= 0)
			{
				return 0;
			}
			return num2;
		}
	}
}
