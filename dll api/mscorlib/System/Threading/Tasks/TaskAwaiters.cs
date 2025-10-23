using System;

namespace System.Threading.Tasks
{
	// Token: 0x0200020B RID: 523
	internal static class TaskAwaiters
	{
		// Token: 0x06001298 RID: 4760 RVA: 0x0004AB35 File Offset: 0x00048D35
		public static ForceAsyncAwaiter ForceAsync(this Task task)
		{
			return new ForceAsyncAwaiter(task);
		}
	}
}
