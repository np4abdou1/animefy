using System;
using System.Diagnostics;

namespace System.Threading.Tasks
{
	/// <summary>Represents an object that handles the low-level work of queuing tasks onto threads.</summary>
	// Token: 0x02000234 RID: 564
	[DebuggerDisplay("Id={Id}")]
	[DebuggerTypeProxy(typeof(TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView))]
	public abstract class TaskScheduler
	{
		/// <summary>Queues a <see cref="T:System.Threading.Tasks.Task" /> to the scheduler. </summary>
		/// <param name="task">The <see cref="T:System.Threading.Tasks.Task" /> to be queued.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="task" /> argument is null.</exception>
		// Token: 0x060013C7 RID: 5063
		protected internal abstract void QueueTask(Task task);

		/// <summary>Determines whether the provided <see cref="T:System.Threading.Tasks.Task" /> can be executed synchronously in this call, and if it can, executes it.</summary>
		/// <param name="task">The <see cref="T:System.Threading.Tasks.Task" /> to be executed.</param>
		/// <param name="taskWasPreviouslyQueued">A Boolean denoting whether or not task has previously been queued. If this parameter is True, then the task may have been previously queued (scheduled); if False, then the task is known not to have been queued, and this call is being made in order to execute the task inline without queuing it.</param>
		/// <returns>A Boolean value indicating whether the task was executed inline.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="task" /> argument is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <paramref name="task" /> was already executed.</exception>
		// Token: 0x060013C8 RID: 5064
		protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

		// Token: 0x060013C9 RID: 5065 RVA: 0x0004E730 File Offset: 0x0004C930
		internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued)
		{
			TaskScheduler executingTaskScheduler = task.ExecutingTaskScheduler;
			if (executingTaskScheduler != this && executingTaskScheduler != null)
			{
				return executingTaskScheduler.TryRunInline(task, taskWasPreviouslyQueued);
			}
			StackGuard currentStackGuard;
			if (executingTaskScheduler == null || task.m_action == null || task.IsDelegateInvoked || task.IsCanceled || !(currentStackGuard = Task.CurrentStackGuard).TryBeginInliningScope())
			{
				return false;
			}
			bool flag = false;
			try
			{
				flag = this.TryExecuteTaskInline(task, taskWasPreviouslyQueued);
			}
			finally
			{
				currentStackGuard.EndInliningScope();
			}
			if (flag && !task.IsDelegateInvoked && !task.IsCanceled)
			{
				throw new InvalidOperationException("The TryExecuteTaskInline call to the underlying scheduler succeeded, but the task body was not invoked.");
			}
			return flag;
		}

		/// <summary>Attempts to dequeue a <see cref="T:System.Threading.Tasks.Task" /> that was previously queued to this scheduler.</summary>
		/// <param name="task">The <see cref="T:System.Threading.Tasks.Task" /> to be dequeued.</param>
		/// <returns>A Boolean denoting whether the <paramref name="task" /> argument was successfully dequeued.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="task" /> argument is null.</exception>
		// Token: 0x060013CA RID: 5066 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected internal virtual bool TryDequeue(Task task)
		{
			return false;
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00002A7D File Offset: 0x00000C7D
		internal virtual void NotifyWorkItemProgress()
		{
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x0000B18D File Offset: 0x0000938D
		internal virtual bool RequiresAtomicStartTransition
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets the default <see cref="T:System.Threading.Tasks.TaskScheduler" /> instance that is provided by the .NET Framework.</summary>
		/// <returns>Returns the default <see cref="T:System.Threading.Tasks.TaskScheduler" /> instance.</returns>
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x0004E7C4 File Offset: 0x0004C9C4
		public static TaskScheduler Default
		{
			get
			{
				return TaskScheduler.s_defaultTaskScheduler;
			}
		}

		/// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskScheduler" /> associated with the currently executing task.</summary>
		/// <returns>Returns the <see cref="T:System.Threading.Tasks.TaskScheduler" /> associated with the currently executing task.</returns>
		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x0004E7CB File Offset: 0x0004C9CB
		public static TaskScheduler Current
		{
			get
			{
				return TaskScheduler.InternalCurrent ?? TaskScheduler.Default;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x0004E7DC File Offset: 0x0004C9DC
		internal static TaskScheduler InternalCurrent
		{
			get
			{
				Task internalCurrent = Task.InternalCurrent;
				if (internalCurrent == null || (internalCurrent.CreationOptions & TaskCreationOptions.HideScheduler) != TaskCreationOptions.None)
				{
					return null;
				}
				return internalCurrent.ExecutingTaskScheduler;
			}
		}

		/// <summary>Gets the unique ID for this <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		/// <returns>Returns the unique ID for this <see cref="T:System.Threading.Tasks.TaskScheduler" />.</returns>
		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x0004E808 File Offset: 0x0004CA08
		public int Id
		{
			get
			{
				if (this.m_taskSchedulerId == 0)
				{
					int num;
					do
					{
						num = Interlocked.Increment(ref TaskScheduler.s_taskSchedulerIdCounter);
					}
					while (num == 0);
					Interlocked.CompareExchange(ref this.m_taskSchedulerId, num, 0);
				}
				return this.m_taskSchedulerId;
			}
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0004E848 File Offset: 0x0004CA48
		internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea)
		{
			using (LockHolder.Hold(TaskScheduler._unobservedTaskExceptionLockObject))
			{
				EventHandler<UnobservedTaskExceptionEventArgs> unobservedTaskException = TaskScheduler._unobservedTaskException;
				if (unobservedTaskException != null)
				{
					unobservedTaskException(sender, ueea);
				}
			}
		}

		// Token: 0x040007DE RID: 2014
		private static readonly TaskScheduler s_defaultTaskScheduler = new ThreadPoolTaskScheduler();

		// Token: 0x040007DF RID: 2015
		internal static int s_taskSchedulerIdCounter;

		// Token: 0x040007E0 RID: 2016
		private volatile int m_taskSchedulerId;

		// Token: 0x040007E1 RID: 2017
		private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException;

		// Token: 0x040007E2 RID: 2018
		private static readonly Lock _unobservedTaskExceptionLockObject = new Lock();

		// Token: 0x02000235 RID: 565
		internal sealed class SystemThreadingTasks_TaskSchedulerDebugView
		{
		}
	}
}
