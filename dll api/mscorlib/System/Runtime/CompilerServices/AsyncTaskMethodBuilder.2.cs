using System;
using System.Diagnostics;
using System.Security;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	/// <summary>Represents a builder for asynchronous methods that returns a task and provides a parameter for the result.</summary>
	/// <typeparam name="TResult">The result to use to complete the task.</typeparam>
	// Token: 0x02000464 RID: 1124
	public struct AsyncTaskMethodBuilder<TResult>
	{
		/// <summary>Creates an instance of the <see cref="T:System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1" /> class.</summary>
		/// <returns>A new instance of the builder.</returns>
		// Token: 0x0600205D RID: 8285 RVA: 0x00088784 File Offset: 0x00086984
		public static AsyncTaskMethodBuilder<TResult> Create()
		{
			return default(AsyncTaskMethodBuilder<TResult>);
		}

		/// <summary>Begins running the builder with the associated state machine.</summary>
		/// <param name="stateMachine">The state machine instance, passed by reference.</param>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="stateMachine" /> is <see langword="null" />.</exception>
		// Token: 0x0600205E RID: 8286 RVA: 0x0008879C File Offset: 0x0008699C
		[SecuritySafeCritical]
		[DebuggerStepThrough]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			if (stateMachine == null)
			{
				throw new ArgumentNullException("stateMachine");
			}
			ExecutionContextSwitcher executionContextSwitcher = default(ExecutionContextSwitcher);
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				ExecutionContext.EstablishCopyOnWriteScope(ref executionContextSwitcher);
				stateMachine.MoveNext();
			}
			finally
			{
				executionContextSwitcher.Undo();
			}
		}

		/// <summary>Associates the builder with the specified state machine.</summary>
		/// <param name="stateMachine">The state machine instance to associate with the builder.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="stateMachine" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The state machine was previously set.</exception>
		// Token: 0x0600205F RID: 8287 RVA: 0x000887FC File Offset: 0x000869FC
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.m_coreState.SetStateMachine(stateMachine);
		}

		/// <summary>Schedules the state machine to proceed to the next action when the specified awaiter completes. This method can be called from partially trusted code.</summary>
		/// <param name="awaiter">The awaiter.</param>
		/// <param name="stateMachine">The state machine.</param>
		/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		// Token: 0x06002060 RID: 8288 RVA: 0x0008880C File Offset: 0x00086A0C
		[SecuritySafeCritical]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			try
			{
				AsyncMethodBuilderCore.MoveNextRunner runner = null;
				Action completionAction = this.m_coreState.GetCompletionAction(AsyncCausalityTracer.LoggingOn ? this.Task : null, ref runner);
				if (this.m_coreState.m_stateMachine == null)
				{
					Task<TResult> task = this.Task;
					this.m_coreState.PostBoxInitialization(stateMachine, runner, task);
				}
				awaiter.UnsafeOnCompleted(completionAction);
			}
			catch (Exception exception)
			{
				AsyncMethodBuilderCore.ThrowAsync(exception, null);
			}
		}

		/// <summary>Gets the task for this builder.</summary>
		/// <returns>The task for this builder.</returns>
		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x0008888C File Offset: 0x00086A8C
		public Task<TResult> Task
		{
			get
			{
				Task<TResult> task = this.m_task;
				if (task == null)
				{
					task = (this.m_task = new Task<TResult>());
				}
				return task;
			}
		}

		/// <summary>Marks the task as successfully completed.</summary>
		/// <param name="result">The result to use to complete the task.</param>
		/// <exception cref="T:System.InvalidOperationException">The task has already completed.</exception>
		// Token: 0x06002062 RID: 8290 RVA: 0x000888B4 File Offset: 0x00086AB4
		public void SetResult(TResult result)
		{
			Task<TResult> task = this.m_task;
			if (task == null)
			{
				this.m_task = AsyncTaskMethodBuilder<TResult>.GetTaskForResult(result);
				return;
			}
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationCompletion(CausalityTraceLevel.Required, task.Id, AsyncCausalityStatus.Completed);
			}
			if (System.Threading.Tasks.Task.s_asyncDebuggingEnabled)
			{
				System.Threading.Tasks.Task.RemoveFromActiveTasks(task.Id);
			}
			if (!task.TrySetResult(result))
			{
				throw new InvalidOperationException(Environment.GetResourceString("An attempt was made to transition a task to a final state when it had already completed."));
			}
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x00088918 File Offset: 0x00086B18
		internal void SetResult(Task<TResult> completedTask)
		{
			if (this.m_task == null)
			{
				this.m_task = completedTask;
				return;
			}
			this.SetResult(default(TResult));
		}

		/// <summary>Marks the task as failed and binds the specified exception to the task.</summary>
		/// <param name="exception">The exception to bind to the task.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="exception" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The task has already completed.</exception>
		// Token: 0x06002064 RID: 8292 RVA: 0x00088944 File Offset: 0x00086B44
		public void SetException(Exception exception)
		{
			if (exception == null)
			{
				throw new ArgumentNullException("exception");
			}
			Task<TResult> task = this.m_task;
			if (task == null)
			{
				task = this.Task;
			}
			OperationCanceledException ex = exception as OperationCanceledException;
			if (!((ex != null) ? task.TrySetCanceled(ex.CancellationToken, ex) : task.TrySetException(exception)))
			{
				throw new InvalidOperationException(Environment.GetResourceString("An attempt was made to transition a task to a final state when it had already completed."));
			}
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000889A2 File Offset: 0x00086BA2
		internal void SetNotificationForWaitCompletion(bool enabled)
		{
			this.Task.SetNotificationForWaitCompletion(enabled);
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x000889B0 File Offset: 0x00086BB0
		private object ObjectIdForDebugger
		{
			get
			{
				return this.Task;
			}
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000889B8 File Offset: 0x00086BB8
		[SecuritySafeCritical]
		internal static Task<TResult> GetTaskForResult(TResult result)
		{
			if (default(TResult) != null)
			{
				if (typeof(TResult) == typeof(bool))
				{
					return JitHelpers.UnsafeCast<Task<TResult>>(((bool)((object)result)) ? AsyncTaskCache.TrueTask : AsyncTaskCache.FalseTask);
				}
				if (typeof(TResult) == typeof(int))
				{
					int num = (int)((object)result);
					if (num < 9 && num >= -1)
					{
						return JitHelpers.UnsafeCast<Task<TResult>>(AsyncTaskCache.Int32Tasks[num - -1]);
					}
				}
				else if ((typeof(TResult) == typeof(uint) && (uint)((object)result) == 0U) || (typeof(TResult) == typeof(byte) && (byte)((object)result) == 0) || (typeof(TResult) == typeof(sbyte) && (sbyte)((object)result) == 0) || (typeof(TResult) == typeof(char) && (char)((object)result) == '\0') || (typeof(TResult) == typeof(long) && (long)((object)result) == 0L) || (typeof(TResult) == typeof(ulong) && (ulong)((object)result) == 0UL) || (typeof(TResult) == typeof(short) && (short)((object)result) == 0) || (typeof(TResult) == typeof(ushort) && (ushort)((object)result) == 0) || (typeof(TResult) == typeof(IntPtr) && (IntPtr)0 == (IntPtr)((object)result)) || (typeof(TResult) == typeof(UIntPtr) && (UIntPtr)0 == (UIntPtr)((object)result)))
				{
					return AsyncTaskMethodBuilder<TResult>.s_defaultResultTask;
				}
			}
			else if (result == null)
			{
				return AsyncTaskMethodBuilder<TResult>.s_defaultResultTask;
			}
			return new Task<TResult>(result);
		}

		// Token: 0x04000F5E RID: 3934
		internal static readonly Task<TResult> s_defaultResultTask = AsyncTaskCache.CreateCacheableTask<TResult>(default(TResult));

		// Token: 0x04000F5F RID: 3935
		private AsyncMethodBuilderCore m_coreState;

		// Token: 0x04000F60 RID: 3936
		private Task<TResult> m_task;
	}
}
