using System;
using System.Diagnostics;
using System.Security;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	/// <summary>Represents a builder for asynchronous methods that do not return a value.</summary>
	// Token: 0x02000462 RID: 1122
	public struct AsyncVoidMethodBuilder
	{
		/// <summary>Creates an instance of the <see cref="T:System.Runtime.CompilerServices.AsyncVoidMethodBuilder" /> class.</summary>
		/// <returns>A new instance of the builder.</returns>
		// Token: 0x0600204B RID: 8267 RVA: 0x0008846C File Offset: 0x0008666C
		public static AsyncVoidMethodBuilder Create()
		{
			SynchronizationContext currentNoFlow = SynchronizationContext.CurrentNoFlow;
			if (currentNoFlow != null)
			{
				currentNoFlow.OperationStarted();
			}
			return new AsyncVoidMethodBuilder
			{
				m_synchronizationContext = currentNoFlow
			};
		}

		/// <summary>Begins running the builder with the associated state machine.</summary>
		/// <param name="stateMachine">The state machine instance, passed by reference.</param>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="stateMachine" /> is <see langword="null" />.</exception>
		// Token: 0x0600204C RID: 8268 RVA: 0x0008849C File Offset: 0x0008669C
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
		// Token: 0x0600204D RID: 8269 RVA: 0x000884FC File Offset: 0x000866FC
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.m_coreState.SetStateMachine(stateMachine);
		}

		/// <summary>Schedules the state machine to proceed to the next action when the specified awaiter completes. This method can be called from partially trusted code.</summary>
		/// <param name="awaiter">The awaiter.</param>
		/// <param name="stateMachine">The state machine.</param>
		/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		// Token: 0x0600204E RID: 8270 RVA: 0x0008850C File Offset: 0x0008670C
		[SecuritySafeCritical]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			try
			{
				AsyncMethodBuilderCore.MoveNextRunner runner = null;
				Action completionAction = this.m_coreState.GetCompletionAction(AsyncCausalityTracer.LoggingOn ? this.Task : null, ref runner);
				if (this.m_coreState.m_stateMachine == null)
				{
					if (AsyncCausalityTracer.LoggingOn)
					{
						AsyncCausalityTracer.TraceOperationCreation(CausalityTraceLevel.Required, this.Task.Id, "Async: " + stateMachine.GetType().Name, 0UL);
					}
					this.m_coreState.PostBoxInitialization(stateMachine, runner, null);
				}
				awaiter.UnsafeOnCompleted(completionAction);
			}
			catch (Exception exception)
			{
				AsyncMethodBuilderCore.ThrowAsync(exception, null);
			}
		}

		/// <summary>Marks the method builder as successfully completed.</summary>
		/// <exception cref="T:System.InvalidOperationException">The builder is not initialized.</exception>
		// Token: 0x0600204F RID: 8271 RVA: 0x000885BC File Offset: 0x000867BC
		public void SetResult()
		{
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationCompletion(CausalityTraceLevel.Required, this.Task.Id, AsyncCausalityStatus.Completed);
			}
			if (this.m_synchronizationContext != null)
			{
				this.NotifySynchronizationContextOfCompletion();
			}
		}

		/// <summary>Binds an exception to the method builder.</summary>
		/// <param name="exception">The exception to bind.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="exception" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The builder is not initialized.</exception>
		// Token: 0x06002050 RID: 8272 RVA: 0x000885E8 File Offset: 0x000867E8
		public void SetException(Exception exception)
		{
			if (exception == null)
			{
				throw new ArgumentNullException("exception");
			}
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationCompletion(CausalityTraceLevel.Required, this.Task.Id, AsyncCausalityStatus.Error);
			}
			if (this.m_synchronizationContext != null)
			{
				try
				{
					AsyncMethodBuilderCore.ThrowAsync(exception, this.m_synchronizationContext);
					return;
				}
				finally
				{
					this.NotifySynchronizationContextOfCompletion();
				}
			}
			AsyncMethodBuilderCore.ThrowAsync(exception, null);
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00088650 File Offset: 0x00086850
		private void NotifySynchronizationContextOfCompletion()
		{
			try
			{
				this.m_synchronizationContext.OperationCompleted();
			}
			catch (Exception exception)
			{
				AsyncMethodBuilderCore.ThrowAsync(exception, null);
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x00088684 File Offset: 0x00086884
		internal Task Task
		{
			get
			{
				if (this.m_task == null)
				{
					this.m_task = new Task();
				}
				return this.m_task;
			}
		}

		// Token: 0x04000F59 RID: 3929
		private SynchronizationContext m_synchronizationContext;

		// Token: 0x04000F5A RID: 3930
		private AsyncMethodBuilderCore m_coreState;

		// Token: 0x04000F5B RID: 3931
		private Task m_task;
	}
}
