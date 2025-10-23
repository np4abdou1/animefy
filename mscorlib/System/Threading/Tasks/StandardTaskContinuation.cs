using System;

namespace System.Threading.Tasks
{
	// Token: 0x0200022B RID: 555
	internal class StandardTaskContinuation : TaskContinuation
	{
		// Token: 0x0600138E RID: 5006 RVA: 0x0004DD48 File Offset: 0x0004BF48
		internal StandardTaskContinuation(Task task, TaskContinuationOptions options, TaskScheduler scheduler)
		{
			this.m_task = task;
			this.m_options = options;
			this.m_taskScheduler = scheduler;
			if (DebuggerSupport.LoggingOn)
			{
				CausalityTraceLevel traceLevel = CausalityTraceLevel.Required;
				Task task2 = this.m_task;
				string str = "Task.ContinueWith: ";
				Delegate action = task.m_action;
				DebuggerSupport.TraceOperationCreation(traceLevel, task2, str + ((action != null) ? action.ToString() : null), 0UL);
			}
			DebuggerSupport.AddToActiveTasks(this.m_task);
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x0004DDAC File Offset: 0x0004BFAC
		internal override void Run(Task completedTask, bool bCanInlineContinuationTask)
		{
			TaskContinuationOptions options = this.m_options;
			bool flag = completedTask.IsCompletedSuccessfully ? ((options & TaskContinuationOptions.NotOnRanToCompletion) == TaskContinuationOptions.None) : (completedTask.IsCanceled ? ((options & TaskContinuationOptions.NotOnCanceled) == TaskContinuationOptions.None) : ((options & TaskContinuationOptions.NotOnFaulted) == TaskContinuationOptions.None));
			Task task = this.m_task;
			if (flag)
			{
				if (!task.IsCanceled && DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationRelation(CausalityTraceLevel.Important, task, CausalityRelation.AssignDelegate);
				}
				task.m_taskScheduler = this.m_taskScheduler;
				if (bCanInlineContinuationTask && (options & TaskContinuationOptions.ExecuteSynchronously) != TaskContinuationOptions.None)
				{
					TaskContinuation.InlineIfPossibleOrElseQueue(task, true);
					return;
				}
				try
				{
					task.ScheduleAndStart(true);
					return;
				}
				catch (TaskSchedulerException)
				{
					return;
				}
			}
			task.InternalCancel(false);
		}

		// Token: 0x040007C7 RID: 1991
		internal readonly Task m_task;

		// Token: 0x040007C8 RID: 1992
		internal readonly TaskContinuationOptions m_options;

		// Token: 0x040007C9 RID: 1993
		private readonly TaskScheduler m_taskScheduler;
	}
}
