using System;
using Internal.Runtime.Augments;

namespace Internal.Threading.Tasks.Tracing
{
	// Token: 0x0200065C RID: 1628
	internal static class TaskTrace
	{
		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06003111 RID: 12561 RVA: 0x000C5A84 File Offset: 0x000C3C84
		public static bool Enabled
		{
			get
			{
				TaskTraceCallbacks taskTraceCallbacks = TaskTrace.s_callbacks;
				return taskTraceCallbacks != null && taskTraceCallbacks.Enabled;
			}
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x000C5AA8 File Offset: 0x000C3CA8
		public static void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
			TaskTraceCallbacks taskTraceCallbacks = TaskTrace.s_callbacks;
			if (taskTraceCallbacks == null)
			{
				return;
			}
			taskTraceCallbacks.TaskWaitBegin_Asynchronous(OriginatingTaskSchedulerID, OriginatingTaskID, TaskID);
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x000C5AC8 File Offset: 0x000C3CC8
		public static void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
			TaskTraceCallbacks taskTraceCallbacks = TaskTrace.s_callbacks;
			if (taskTraceCallbacks == null)
			{
				return;
			}
			taskTraceCallbacks.TaskWaitBegin_Synchronous(OriginatingTaskSchedulerID, OriginatingTaskID, TaskID);
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x000C5AE8 File Offset: 0x000C3CE8
		public static void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
			TaskTraceCallbacks taskTraceCallbacks = TaskTrace.s_callbacks;
			if (taskTraceCallbacks == null)
			{
				return;
			}
			taskTraceCallbacks.TaskWaitEnd(OriginatingTaskSchedulerID, OriginatingTaskID, TaskID);
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x000C5B08 File Offset: 0x000C3D08
		public static void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions)
		{
			TaskTraceCallbacks taskTraceCallbacks = TaskTrace.s_callbacks;
			if (taskTraceCallbacks == null)
			{
				return;
			}
			taskTraceCallbacks.TaskScheduled(OriginatingTaskSchedulerID, OriginatingTaskID, TaskID, CreatingTaskID, TaskCreationOptions);
		}

		// Token: 0x04001968 RID: 6504
		private static TaskTraceCallbacks s_callbacks;
	}
}
