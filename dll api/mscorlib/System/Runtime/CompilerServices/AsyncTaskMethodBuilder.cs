using System;
using System.Diagnostics;
using System.Security;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	/// <summary>Represents a builder for asynchronous methods that return a task.</summary>
	// Token: 0x02000463 RID: 1123
	public struct AsyncTaskMethodBuilder
	{
		/// <summary>Creates an instance of the <see cref="T:System.Runtime.CompilerServices.AsyncTaskMethodBuilder" /> class.</summary>
		/// <returns>A new instance of the builder.</returns>
		// Token: 0x06002053 RID: 8275 RVA: 0x000886A0 File Offset: 0x000868A0
		public static AsyncTaskMethodBuilder Create()
		{
			return default(AsyncTaskMethodBuilder);
		}

		/// <summary>Begins running the builder with the associated state machine.</summary>
		/// <param name="stateMachine">The state machine instance, passed by reference.</param>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="stateMachine" /> is <see langword="null" />.</exception>
		// Token: 0x06002054 RID: 8276 RVA: 0x000886B8 File Offset: 0x000868B8
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
		// Token: 0x06002055 RID: 8277 RVA: 0x00088718 File Offset: 0x00086918
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.m_builder.SetStateMachine(stateMachine);
		}

		/// <summary>Schedules the state machine to proceed to the next action when the specified awaiter completes. This method can be called from partially trusted code.</summary>
		/// <param name="awaiter">The awaiter.</param>
		/// <param name="stateMachine">The state machine.</param>
		/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		// Token: 0x06002056 RID: 8278 RVA: 0x00088726 File Offset: 0x00086926
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			this.m_builder.AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine);
		}

		/// <summary>Gets the task for this builder.</summary>
		/// <returns>The task for this builder.</returns>
		/// <exception cref="T:System.InvalidOperationException">The builder is not initialized.</exception>
		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x00088735 File Offset: 0x00086935
		public Task Task
		{
			get
			{
				return this.m_builder.Task;
			}
		}

		/// <summary>Marks the task as successfully completed.</summary>
		/// <exception cref="T:System.InvalidOperationException">The task has already completed.-or-The builder is not initialized.</exception>
		// Token: 0x06002058 RID: 8280 RVA: 0x00088742 File Offset: 0x00086942
		public void SetResult()
		{
			this.m_builder.SetResult(AsyncTaskMethodBuilder.s_cachedCompleted);
		}

		/// <summary>Marks the task as failed and binds the specified exception to the task.</summary>
		/// <param name="exception">The exception to bind to the task.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="exception" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The task has already completed.-or-The builder is not initialized.</exception>
		// Token: 0x06002059 RID: 8281 RVA: 0x00088754 File Offset: 0x00086954
		public void SetException(Exception exception)
		{
			this.m_builder.SetException(exception);
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00088762 File Offset: 0x00086962
		internal void SetNotificationForWaitCompletion(bool enabled)
		{
			this.m_builder.SetNotificationForWaitCompletion(enabled);
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x00088770 File Offset: 0x00086970
		internal object ObjectIdForDebugger
		{
			get
			{
				return this.Task;
			}
		}

		// Token: 0x04000F5C RID: 3932
		private static readonly Task<VoidTaskResult> s_cachedCompleted = AsyncTaskMethodBuilder<VoidTaskResult>.s_defaultResultTask;

		// Token: 0x04000F5D RID: 3933
		private AsyncTaskMethodBuilder<VoidTaskResult> m_builder;
	}
}
