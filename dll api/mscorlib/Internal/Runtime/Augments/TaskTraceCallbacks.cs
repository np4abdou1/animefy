using System;

namespace Internal.Runtime.Augments
{
	// Token: 0x0200065E RID: 1630
	internal abstract class TaskTraceCallbacks
	{
		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06003116 RID: 12566
		public abstract bool Enabled { get; }

		// Token: 0x06003117 RID: 12567
		public abstract void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		// Token: 0x06003118 RID: 12568
		public abstract void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		// Token: 0x06003119 RID: 12569
		public abstract void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		// Token: 0x0600311A RID: 12570
		public abstract void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions);
	}
}
