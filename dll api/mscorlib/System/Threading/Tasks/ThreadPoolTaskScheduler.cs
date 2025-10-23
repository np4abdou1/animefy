using System;
using Internal.Runtime.Augments;
using Internal.Threading.Tasks.Tracing;

namespace System.Threading.Tasks
{
	// Token: 0x02000237 RID: 567
	internal sealed class ThreadPoolTaskScheduler : TaskScheduler
	{
		// Token: 0x060013D5 RID: 5077 RVA: 0x0004E8B9 File Offset: 0x0004CAB9
		internal ThreadPoolTaskScheduler()
		{
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0004E8C4 File Offset: 0x0004CAC4
		protected internal override void QueueTask(Task task)
		{
			if (TaskTrace.Enabled)
			{
				Task internalCurrent = Task.InternalCurrent;
				Task parent = task.m_parent;
				TaskTrace.TaskScheduled(base.Id, (internalCurrent == null) ? 0 : internalCurrent.Id, task.Id, (parent == null) ? 0 : parent.Id, (int)task.Options);
			}
			if ((task.Options & TaskCreationOptions.LongRunning) != TaskCreationOptions.None)
			{
				RuntimeThread runtimeThread = RuntimeThread.Create(ThreadPoolTaskScheduler.s_longRunningThreadWork, 0);
				runtimeThread.IsBackground = true;
				runtimeThread.Start(task);
				return;
			}
			bool forceGlobal = (task.Options & TaskCreationOptions.PreferFairness) > TaskCreationOptions.None;
			ThreadPool.UnsafeQueueCustomWorkItem(task, forceGlobal);
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0004E94C File Offset: 0x0004CB4C
		protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
		{
			if (taskWasPreviouslyQueued && !ThreadPool.TryPopCustomWorkItem(task))
			{
				return false;
			}
			bool result = false;
			try
			{
				result = task.ExecuteEntry(false);
			}
			finally
			{
				if (taskWasPreviouslyQueued)
				{
					this.NotifyWorkItemProgress();
				}
			}
			return result;
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0004E990 File Offset: 0x0004CB90
		protected internal override bool TryDequeue(Task task)
		{
			return ThreadPool.TryPopCustomWorkItem(task);
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0004E998 File Offset: 0x0004CB98
		internal override void NotifyWorkItemProgress()
		{
			ThreadPool.NotifyWorkItemProgress();
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		internal override bool RequiresAtomicStartTransition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x040007E5 RID: 2021
		private static readonly ParameterizedThreadStart s_longRunningThreadWork = delegate(object s)
		{
			((Task)s).ExecuteEntry(false);
		};
	}
}
