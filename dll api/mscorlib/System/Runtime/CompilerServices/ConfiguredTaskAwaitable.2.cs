using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	/// <summary>Provides an awaitable object that enables configured awaits on a task.</summary>
	/// <typeparam name="TResult">The type of the result produced by this <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
	// Token: 0x0200045F RID: 1119
	public readonly struct ConfiguredTaskAwaitable<TResult>
	{
		// Token: 0x06002044 RID: 8260 RVA: 0x00088408 File Offset: 0x00086608
		internal ConfiguredTaskAwaitable(Task<TResult> task, bool continueOnCapturedContext)
		{
			this.m_configuredTaskAwaiter = new ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter(task, continueOnCapturedContext);
		}

		/// <summary>Returns an awaiter for this awaitable object.</summary>
		/// <returns>The awaiter.</returns>
		// Token: 0x06002045 RID: 8261 RVA: 0x00088417 File Offset: 0x00086617
		public ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter GetAwaiter()
		{
			return this.m_configuredTaskAwaiter;
		}

		// Token: 0x04000F56 RID: 3926
		private readonly ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter m_configuredTaskAwaiter;

		/// <summary>Provides an awaiter for an awaitable object(<see cref="T:System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1" />).</summary>
		// Token: 0x02000460 RID: 1120
		public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion
		{
			// Token: 0x06002046 RID: 8262 RVA: 0x0008841F File Offset: 0x0008661F
			internal ConfiguredTaskAwaiter(Task<TResult> task, bool continueOnCapturedContext)
			{
				this.m_task = task;
				this.m_continueOnCapturedContext = continueOnCapturedContext;
			}

			/// <summary>Gets a value that specifies whether the task being awaited has been completed.</summary>
			/// <returns>
			///     <see langword="true" /> if the task being awaited has been completed; otherwise, <see langword="false" />.</returns>
			/// <exception cref="T:System.NullReferenceException">The awaiter was not properly initialized.</exception>
			// Token: 0x1700040E RID: 1038
			// (get) Token: 0x06002047 RID: 8263 RVA: 0x0008842F File Offset: 0x0008662F
			public bool IsCompleted
			{
				get
				{
					return this.m_task.IsCompleted;
				}
			}

			/// <summary>Schedules the continuation action for the task associated with this awaiter.</summary>
			/// <param name="continuation">The action to invoke when the await operation completes.</param>
			/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuation" /> argument is <see langword="null" />.</exception>
			/// <exception cref="T:System.NullReferenceException">The awaiter was not properly initialized.</exception>
			// Token: 0x06002048 RID: 8264 RVA: 0x0008843C File Offset: 0x0008663C
			public void UnsafeOnCompleted(Action continuation)
			{
				TaskAwaiter.OnCompletedInternal(this.m_task, continuation, this.m_continueOnCapturedContext, false);
			}

			/// <summary>Ends the await on the completed task.</summary>
			/// <returns>The result of the completed task.</returns>
			/// <exception cref="T:System.NullReferenceException">The awaiter was not properly initialized.</exception>
			/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task was canceled.</exception>
			/// <exception cref="T:System.Exception">The task completed in a faulted state.</exception>
			// Token: 0x06002049 RID: 8265 RVA: 0x00088451 File Offset: 0x00086651
			[StackTraceHidden]
			public TResult GetResult()
			{
				TaskAwaiter.ValidateEnd(this.m_task);
				return this.m_task.ResultOnSuccess;
			}

			// Token: 0x04000F57 RID: 3927
			private readonly Task<TResult> m_task;

			// Token: 0x04000F58 RID: 3928
			private readonly bool m_continueOnCapturedContext;
		}
	}
}
