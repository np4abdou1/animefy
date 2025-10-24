using System;
using System.Runtime.CompilerServices;
using Internal.Runtime.Augments;

namespace System.Threading.Tasks
{
	// Token: 0x02000230 RID: 560
	internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem
	{
		// Token: 0x0600139D RID: 5021 RVA: 0x0004E008 File Offset: 0x0004C208
		internal AwaitTaskContinuation(Action action, bool flowExecutionContext)
		{
			this.m_action = action;
			if (flowExecutionContext)
			{
				this.m_capturedContext = ExecutionContext.Capture();
			}
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0004E028 File Offset: 0x0004C228
		protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler)
		{
			return new Task(action, state, null, default(CancellationToken), TaskCreationOptions.None, InternalTaskOptions.QueuedByRuntime, scheduler);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0004E04D File Offset: 0x0004C24D
		internal override void Run(Task ignored, bool canInlineContinuationTask)
		{
			if (canInlineContinuationTask && AwaitTaskContinuation.IsValidLocationForInlining)
			{
				this.RunCallback(AwaitTaskContinuation.GetInvokeActionCallback(), this.m_action, ref Task.t_currentTask);
				return;
			}
			ThreadPool.UnsafeQueueCustomWorkItem(this, false);
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x0004E078 File Offset: 0x0004C278
		internal static bool IsValidLocationForInlining
		{
			get
			{
				SynchronizationContext synchronizationContext = SynchronizationContext.Current;
				if (synchronizationContext != null && synchronizationContext.GetType() != typeof(SynchronizationContext))
				{
					return false;
				}
				TaskScheduler internalCurrent = TaskScheduler.InternalCurrent;
				return internalCurrent == null || internalCurrent == TaskScheduler.Default;
			}
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0004E0BA File Offset: 0x0004C2BA
		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
			if (this.m_capturedContext == null)
			{
				this.m_action();
				return;
			}
			ExecutionContext.Run(this.m_capturedContext, AwaitTaskContinuation.GetInvokeActionCallback(), this.m_action);
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0004E0E6 File Offset: 0x0004C2E6
		private static void InvokeAction(object state)
		{
			((Action)state)();
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0004E0F4 File Offset: 0x0004C2F4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected static ContextCallback GetInvokeActionCallback()
		{
			ContextCallback contextCallback = AwaitTaskContinuation.s_invokeActionCallback;
			if (contextCallback == null)
			{
				contextCallback = (AwaitTaskContinuation.s_invokeActionCallback = new ContextCallback(AwaitTaskContinuation.InvokeAction));
			}
			return contextCallback;
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0004E120 File Offset: 0x0004C320
		protected void RunCallback(ContextCallback callback, object state, ref Task currentTask)
		{
			Task task = currentTask;
			SynchronizationContext currentExplicit = SynchronizationContext.CurrentExplicit;
			try
			{
				if (task != null)
				{
					currentTask = null;
				}
				callback(state);
			}
			catch (Exception exc)
			{
				AwaitTaskContinuation.ThrowAsyncIfNecessary(exc);
			}
			finally
			{
				if (task != null)
				{
					currentTask = task;
				}
				SynchronizationContext.SetSynchronizationContext(currentExplicit);
			}
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0004E178 File Offset: 0x0004C378
		internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask)
		{
			if (!allowInlining || !AwaitTaskContinuation.IsValidLocationForInlining)
			{
				AwaitTaskContinuation.UnsafeScheduleAction(action);
				return;
			}
			Task task = currentTask;
			try
			{
				if (task != null)
				{
					currentTask = null;
				}
				action();
			}
			catch (Exception exc)
			{
				AwaitTaskContinuation.ThrowAsyncIfNecessary(exc);
			}
			finally
			{
				if (task != null)
				{
					currentTask = task;
				}
			}
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0004E1D4 File Offset: 0x0004C3D4
		internal static void UnsafeScheduleAction(Action action)
		{
			ThreadPool.UnsafeQueueCustomWorkItem(new AwaitTaskContinuation(action, false), false);
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x0004E1E3 File Offset: 0x0004C3E3
		protected static void ThrowAsyncIfNecessary(Exception exc)
		{
			RuntimeAugments.ReportUnhandledException(exc);
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void MarkAborted(ThreadAbortException e)
		{
		}

		// Token: 0x040007D1 RID: 2001
		private readonly ExecutionContext m_capturedContext;

		// Token: 0x040007D2 RID: 2002
		protected readonly Action m_action;

		// Token: 0x040007D3 RID: 2003
		private static ContextCallback s_invokeActionCallback;
	}
}
