using System;
using System.Collections.ObjectModel;
using System.Runtime.ExceptionServices;
using Internal.Runtime.Augments;

namespace System.Threading.Tasks
{
	// Token: 0x02000225 RID: 549
	internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction
	{
		// Token: 0x0600137A RID: 4986 RVA: 0x0004D870 File Offset: 0x0004BA70
		public UnwrapPromise(Task outerTask, bool lookForOce) : base(null, outerTask.CreationOptions & TaskCreationOptions.AttachedToParent)
		{
			this._lookForOce = lookForOce;
			this._state = 0;
			if (DebuggerSupport.LoggingOn)
			{
				DebuggerSupport.TraceOperationCreation(CausalityTraceLevel.Required, this, "Task.Unwrap", 0UL);
			}
			DebuggerSupport.AddToActiveTasks(this);
			if (outerTask.IsCompleted)
			{
				this.ProcessCompletedOuterTask(outerTask);
				return;
			}
			outerTask.AddCompletionAction(this);
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x0004D8CC File Offset: 0x0004BACC
		public void Invoke(Task completingTask)
		{
			StackGuard currentStackGuard = Task.CurrentStackGuard;
			if (currentStackGuard.TryBeginInliningScope())
			{
				try
				{
					this.InvokeCore(completingTask);
					return;
				}
				finally
				{
					currentStackGuard.EndInliningScope();
				}
			}
			this.InvokeCoreAsync(completingTask);
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x0004D910 File Offset: 0x0004BB10
		private void InvokeCore(Task completingTask)
		{
			byte state = this._state;
			if (state == 0)
			{
				this.ProcessCompletedOuterTask(completingTask);
				return;
			}
			if (state != 1)
			{
				return;
			}
			this.TrySetFromTask(completingTask, false);
			this._state = 2;
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0004D944 File Offset: 0x0004BB44
		private void InvokeCoreAsync(Task completingTask)
		{
			ThreadPool.UnsafeQueueUserWorkItem(delegate(object state)
			{
				Tuple<UnwrapPromise<TResult>, Task> tuple = (Tuple<UnwrapPromise<TResult>, Task>)state;
				tuple.Item1.InvokeCore(tuple.Item2);
			}, Tuple.Create<UnwrapPromise<TResult>, Task>(this, completingTask));
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0004D974 File Offset: 0x0004BB74
		private void ProcessCompletedOuterTask(Task task)
		{
			this._state = 1;
			TaskStatus status = task.Status;
			if (status != TaskStatus.RanToCompletion)
			{
				if (status - TaskStatus.Canceled <= 1)
				{
					this.TrySetFromTask(task, this._lookForOce);
					return;
				}
			}
			else
			{
				Task<Task<TResult>> task2 = task as Task<Task<TResult>>;
				this.ProcessInnerTask((task2 != null) ? task2.Result : ((Task<Task>)task).Result);
			}
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0004D9CC File Offset: 0x0004BBCC
		private bool TrySetFromTask(Task task, bool lookForOce)
		{
			if (DebuggerSupport.LoggingOn)
			{
				DebuggerSupport.TraceOperationRelation(CausalityTraceLevel.Important, this, CausalityRelation.Join);
			}
			bool result = false;
			switch (task.Status)
			{
			case TaskStatus.RanToCompletion:
			{
				Task<TResult> task2 = task as Task<TResult>;
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Completed);
				}
				DebuggerSupport.RemoveFromActiveTasks(this);
				result = base.TrySetResult((task2 != null) ? task2.Result : default(TResult));
				break;
			}
			case TaskStatus.Canceled:
				result = base.TrySetCanceled(task.CancellationToken, task.GetCancellationExceptionDispatchInfo());
				break;
			case TaskStatus.Faulted:
			{
				ReadOnlyCollection<ExceptionDispatchInfo> exceptionDispatchInfos = task.GetExceptionDispatchInfos();
				ExceptionDispatchInfo exceptionDispatchInfo;
				OperationCanceledException ex;
				if (lookForOce && exceptionDispatchInfos.Count > 0 && (exceptionDispatchInfo = exceptionDispatchInfos[0]) != null && (ex = (exceptionDispatchInfo.SourceException as OperationCanceledException)) != null)
				{
					result = base.TrySetCanceled(ex.CancellationToken, exceptionDispatchInfo);
				}
				else
				{
					result = base.TrySetException(exceptionDispatchInfos);
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0004DAA8 File Offset: 0x0004BCA8
		private void ProcessInnerTask(Task task)
		{
			if (task == null)
			{
				base.TrySetCanceled(default(CancellationToken));
				this._state = 2;
				return;
			}
			if (task.IsCompleted)
			{
				this.TrySetFromTask(task, false);
				this._state = 2;
				return;
			}
			task.AddCompletionAction(this);
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x0000B18D File Offset: 0x0000938D
		public bool InvokeMayRunArbitraryCode
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040007C0 RID: 1984
		private byte _state;

		// Token: 0x040007C1 RID: 1985
		private readonly bool _lookForOce;
	}
}
