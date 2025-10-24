using System;

namespace System.Threading
{
	// Token: 0x020001B7 RID: 439
	internal static class PlatformHelper
	{
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x00044BDC File Offset: 0x00042DDC
		internal static int ProcessorCount
		{
			get
			{
				int tickCount = Environment.TickCount;
				int num = PlatformHelper.s_processorCount;
				if (num == 0 || tickCount - PlatformHelper.s_lastProcessorCountRefreshTicks >= 30000)
				{
					num = (PlatformHelper.s_processorCount = Environment.ProcessorCount);
					PlatformHelper.s_lastProcessorCountRefreshTicks = tickCount;
				}
				return num;
			}
		}

		// Token: 0x0400064A RID: 1610
		private static volatile int s_processorCount;

		// Token: 0x0400064B RID: 1611
		private static volatile int s_lastProcessorCountRefreshTicks;

		// Token: 0x0400064C RID: 1612
		internal static readonly bool IsSingleProcessor = PlatformHelper.ProcessorCount == 1;
	}
}
