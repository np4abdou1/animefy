using System;

namespace System.Threading.Tasks
{
	// Token: 0x0200022E RID: 558
	internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
	{
		// Token: 0x06001398 RID: 5016 RVA: 0x0004DF1D File Offset: 0x0004C11D
		internal TaskSchedulerAwaitTaskContinuation(TaskScheduler scheduler, Action action, bool flowExecutionContext) : base(action, flowExecutionContext)
		{
			this.m_scheduler = scheduler;
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0004DF30 File Offset: 0x0004C130
		internal sealed override void Run(Task ignored, bool canInlineContinuationTask)
		{
			if (this.m_scheduler == TaskScheduler.Default)
			{
				base.Run(ignored, canInlineContinuationTask);
				return;
			}
			bool flag = canInlineContinuationTask && (TaskScheduler.InternalCurrent == this.m_scheduler || ThreadPool.IsThreadPoolThread);
			Task task = base.CreateTask(delegate(object state)
			{
				try
				{
					((Action)state)();
				}
				catch (Exception exc)
				{
					AwaitTaskContinuation.ThrowAsyncIfNecessary(exc);
				}
			}, this.m_action, this.m_scheduler);
			if (flag)
			{
				TaskContinuation.InlineIfPossibleOrElseQueue(task, false);
				return;
			}
			try
			{
				task.ScheduleAndStart(false);
			}
			catch (TaskSchedulerException)
			{
			}
		}

		// Token: 0x040007CE RID: 1998
		private readonly TaskScheduler m_scheduler;
	}
}
