using System;

namespace System.Threading.Tasks
{
	// Token: 0x0200022A RID: 554
	internal abstract class TaskContinuation
	{
		// Token: 0x0600138B RID: 5003
		internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask);

		// Token: 0x0600138C RID: 5004 RVA: 0x0004DCD4 File Offset: 0x0004BED4
		protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection)
		{
			if (needsProtection)
			{
				if (!task.MarkStarted())
				{
					return;
				}
			}
			else
			{
				task.m_stateFlags |= 65536;
			}
			try
			{
				if (!task.m_taskScheduler.TryRunInline(task, false))
				{
					task.m_taskScheduler.QueueTask(task);
				}
			}
			catch (Exception innerException)
			{
				TaskSchedulerException exceptionObject = new TaskSchedulerException(innerException);
				task.AddException(exceptionObject);
				task.Finish(false);
			}
		}
	}
}
