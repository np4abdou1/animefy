using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using Internal.Threading.Tasks.Tracing;

namespace System.Runtime.CompilerServices
{
	/// <summary>Provides an object that waits for the completion of an asynchronous task. </summary>
	// Token: 0x0200045A RID: 1114
	public readonly struct TaskAwaiter : ICriticalNotifyCompletion
	{
		// Token: 0x0600202E RID: 8238 RVA: 0x00088197 File Offset: 0x00086397
		internal TaskAwaiter(Task task)
		{
			this.m_task = task;
		}

		/// <summary>Gets a value that indicates whether the asynchronous task has completed.</summary>
		/// <returns>
		///     <see langword="true" /> if the task has completed; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.NullReferenceException">The <see cref="T:System.Runtime.CompilerServices.TaskAwaiter" /> object was not properly initialized.</exception>
		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x000881A0 File Offset: 0x000863A0
		public bool IsCompleted
		{
			get
			{
				return this.m_task.IsCompleted;
			}
		}

		/// <summary>Schedules the continuation action for the asynchronous task that is associated with this awaiter.</summary>
		/// <param name="continuation">The action to invoke when the await operation completes.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="continuation" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The awaiter was not properly initialized.</exception>
		// Token: 0x06002030 RID: 8240 RVA: 0x000881AD File Offset: 0x000863AD
		public void UnsafeOnCompleted(Action continuation)
		{
			TaskAwaiter.OnCompletedInternal(this.m_task, continuation, true, false);
		}

		/// <summary>Ends the wait for the completion of the asynchronous task.</summary>
		/// <exception cref="T:System.NullReferenceException">The <see cref="T:System.Runtime.CompilerServices.TaskAwaiter" /> object was not properly initialized.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task was canceled.</exception>
		/// <exception cref="T:System.Exception">The task completed in a <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> state.</exception>
		// Token: 0x06002031 RID: 8241 RVA: 0x000881BD File Offset: 0x000863BD
		[StackTraceHidden]
		public void GetResult()
		{
			TaskAwaiter.ValidateEnd(this.m_task);
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x000881CA File Offset: 0x000863CA
		[StackTraceHidden]
		internal static void ValidateEnd(Task task)
		{
			if (task.IsWaitNotificationEnabledOrNotRanToCompletion)
			{
				TaskAwaiter.HandleNonSuccessAndDebuggerNotification(task);
			}
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x000881DC File Offset: 0x000863DC
		[StackTraceHidden]
		private static void HandleNonSuccessAndDebuggerNotification(Task task)
		{
			if (!task.IsCompleted)
			{
				task.InternalWait(-1, default(CancellationToken));
			}
			task.NotifyDebuggerOfWaitCompletionIfNecessary();
			if (!task.IsCompletedSuccessfully)
			{
				TaskAwaiter.ThrowForNonSuccess(task);
			}
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x00088218 File Offset: 0x00086418
		[StackTraceHidden]
		private static void ThrowForNonSuccess(Task task)
		{
			TaskStatus status = task.Status;
			if (status == TaskStatus.Canceled)
			{
				ExceptionDispatchInfo cancellationExceptionDispatchInfo = task.GetCancellationExceptionDispatchInfo();
				if (cancellationExceptionDispatchInfo != null)
				{
					cancellationExceptionDispatchInfo.Throw();
				}
				throw new TaskCanceledException(task);
			}
			if (status != TaskStatus.Faulted)
			{
				return;
			}
			ReadOnlyCollection<ExceptionDispatchInfo> exceptionDispatchInfos = task.GetExceptionDispatchInfos();
			if (exceptionDispatchInfos.Count > 0)
			{
				exceptionDispatchInfos[0].Throw();
				return;
			}
			throw task.Exception;
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x0008826F File Offset: 0x0008646F
		internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext)
		{
			if (continuation == null)
			{
				throw new ArgumentNullException("continuation");
			}
			if (TaskTrace.Enabled)
			{
				continuation = TaskAwaiter.OutputWaitEtwEvents(task, continuation);
			}
			task.SetContinuationForAwait(continuation, continueOnCapturedContext, flowExecutionContext);
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x00088298 File Offset: 0x00086498
		private static Action OutputWaitEtwEvents(Task task, Action continuation)
		{
			Task internalCurrent = Task.InternalCurrent;
			TaskTrace.TaskWaitBegin_Asynchronous((internalCurrent != null) ? internalCurrent.m_taskScheduler.Id : TaskScheduler.Default.Id, (internalCurrent != null) ? internalCurrent.Id : 0, task.Id);
			return delegate()
			{
				if (TaskTrace.Enabled)
				{
					Task internalCurrent2 = Task.InternalCurrent;
					TaskTrace.TaskWaitEnd((internalCurrent2 != null) ? internalCurrent2.m_taskScheduler.Id : TaskScheduler.Default.Id, (internalCurrent2 != null) ? internalCurrent2.Id : 0, task.Id);
				}
				continuation();
			};
		}

		// Token: 0x04000F4F RID: 3919
		internal readonly Task m_task;
	}
}
