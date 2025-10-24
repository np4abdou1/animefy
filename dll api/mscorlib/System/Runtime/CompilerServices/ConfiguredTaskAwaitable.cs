using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	/// <summary>Provides an awaitable object that enables configured awaits on a task.</summary>
	// Token: 0x0200045D RID: 1117
	public readonly struct ConfiguredTaskAwaitable
	{
		// Token: 0x0600203D RID: 8253 RVA: 0x0008839D File Offset: 0x0008659D
		internal ConfiguredTaskAwaitable(Task task, bool continueOnCapturedContext)
		{
			this.m_configuredTaskAwaiter = new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(task, continueOnCapturedContext);
		}

		/// <summary>Returns an awaiter for this awaitable object.</summary>
		/// <returns>The awaiter.</returns>
		// Token: 0x0600203E RID: 8254 RVA: 0x000883AC File Offset: 0x000865AC
		public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
		{
			return this.m_configuredTaskAwaiter;
		}

		// Token: 0x04000F53 RID: 3923
		private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter;

		/// <summary>Provides an awaiter for an awaitable (<see cref="T:System.Runtime.CompilerServices.ConfiguredTaskAwaitable" />) object.</summary>
		// Token: 0x0200045E RID: 1118
		public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion
		{
			// Token: 0x0600203F RID: 8255 RVA: 0x000883B4 File Offset: 0x000865B4
			internal ConfiguredTaskAwaiter(Task task, bool continueOnCapturedContext)
			{
				this.m_task = task;
				this.m_continueOnCapturedContext = continueOnCapturedContext;
			}

			/// <summary>Gets a value that specifies whether the task being awaited is completed.</summary>
			/// <returns>
			///     <see langword="true" /> if the task being awaited is completed; otherwise, <see langword="false" />.</returns>
			/// <exception cref="T:System.NullReferenceException">The awaiter was not properly initialized.</exception>
			// Token: 0x1700040D RID: 1037
			// (get) Token: 0x06002040 RID: 8256 RVA: 0x000883C4 File Offset: 0x000865C4
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
			// Token: 0x06002041 RID: 8257 RVA: 0x000883D1 File Offset: 0x000865D1
			public void OnCompleted(Action continuation)
			{
				TaskAwaiter.OnCompletedInternal(this.m_task, continuation, this.m_continueOnCapturedContext, true);
			}

			/// <summary>Schedules the continuation action for the task associated with this awaiter.</summary>
			/// <param name="continuation">The action to invoke when the await operation completes.</param>
			/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuation" /> argument is <see langword="null" />.</exception>
			/// <exception cref="T:System.NullReferenceException">The awaiter was not properly initialized.</exception>
			// Token: 0x06002042 RID: 8258 RVA: 0x000883E6 File Offset: 0x000865E6
			public void UnsafeOnCompleted(Action continuation)
			{
				TaskAwaiter.OnCompletedInternal(this.m_task, continuation, this.m_continueOnCapturedContext, false);
			}

			/// <summary>Ends the await on the completed task.</summary>
			/// <exception cref="T:System.NullReferenceException">The awaiter was not properly initialized.</exception>
			/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task was canceled.</exception>
			/// <exception cref="T:System.Exception">The task completed in a faulted state.</exception>
			// Token: 0x06002043 RID: 8259 RVA: 0x000883FB File Offset: 0x000865FB
			[StackTraceHidden]
			public void GetResult()
			{
				TaskAwaiter.ValidateEnd(this.m_task);
			}

			// Token: 0x04000F54 RID: 3924
			internal readonly Task m_task;

			// Token: 0x04000F55 RID: 3925
			internal readonly bool m_continueOnCapturedContext;
		}
	}
}
