using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	/// <summary>Represents an asynchronous operation that can return a value.</summary>
	/// <typeparam name="TResult">The type of the result produced by this <see cref="T:System.Threading.Tasks.Task`1" />. </typeparam>
	// Token: 0x02000210 RID: 528
	[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView<>))]
	[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
	public class Task<TResult> : Task
	{
		// Token: 0x060012B7 RID: 4791 RVA: 0x0004AD76 File Offset: 0x00048F76
		internal Task()
		{
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x0004AD7E File Offset: 0x00048F7E
		internal Task(object state, TaskCreationOptions options) : base(state, options, true)
		{
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0004AD8C File Offset: 0x00048F8C
		internal Task(TResult result) : base(false, TaskCreationOptions.None, default(CancellationToken))
		{
			this.m_result = result;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x0004ADB1 File Offset: 0x00048FB1
		internal Task(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) : base(canceled, creationOptions, ct)
		{
			if (!canceled)
			{
				this.m_result = result;
			}
		}

		/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task`1" /> with the specified function.</summary>
		/// <param name="function">The delegate that represents the code to execute in the task. When the function has completed, the task's <see cref="P:System.Threading.Tasks.Task`1.Result" /> property will be set to return the result value of the function.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to be assigned to this task.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is null.</exception>
		// Token: 0x060012BB RID: 4795 RVA: 0x0004ADC7 File Offset: 0x00048FC7
		public Task(Func<TResult> function, CancellationToken cancellationToken) : this(function, null, cancellationToken, TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task`1" /> with the specified action, state, and options.</summary>
		/// <param name="function">The delegate that represents the code to execute in the task. When the function has completed, the task's <see cref="P:System.Threading.Tasks.Task`1.Result" /> property will be set to return the result value of the function.</param>
		/// <param name="state">An object representing data to be used by the function.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to be assigned to the new task.</param>
		/// <param name="creationOptions">The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to customize the task's behavior.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is null.</exception>
		// Token: 0x060012BC RID: 4796 RVA: 0x0004ADD5 File Offset: 0x00048FD5
		public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : this(function, state, Task.InternalCurrentIfAttached(creationOptions), cancellationToken, creationOptions, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0004ADEB File Offset: 0x00048FEB
		internal Task(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) : base(valueSelector, null, parent, cancellationToken, creationOptions, internalOptions, scheduler)
		{
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0004ADFD File Offset: 0x00048FFD
		internal Task(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) : base(valueSelector, state, parent, cancellationToken, creationOptions, internalOptions, scheduler)
		{
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0004AE10 File Offset: 0x00049010
		internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			if (function == null)
			{
				throw new ArgumentNullException("function");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			Task<TResult> task = new Task<TResult>(function, parent, cancellationToken, creationOptions, internalOptions | InternalTaskOptions.QueuedByRuntime, scheduler);
			task.ScheduleAndStart(false);
			return task;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0004AE49 File Offset: 0x00049049
		internal static Task<TResult> StartNew(Task parent, Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			if (function == null)
			{
				throw new ArgumentNullException("function");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			Task<TResult> task = new Task<TResult>(function, state, parent, cancellationToken, creationOptions, internalOptions | InternalTaskOptions.QueuedByRuntime, scheduler);
			task.ScheduleAndStart(false);
			return task;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0004AE84 File Offset: 0x00049084
		internal bool TrySetResult(TResult result)
		{
			if (base.IsCompleted)
			{
				return false;
			}
			if (base.AtomicStateUpdate(67108864, 90177536))
			{
				this.m_result = result;
				Interlocked.Exchange(ref this.m_stateFlags, this.m_stateFlags | 16777216);
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				if (contingentProperties != null)
				{
					contingentProperties.SetCompleted();
				}
				base.FinishStageThree();
				return true;
			}
			return false;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0004AEE9 File Offset: 0x000490E9
		internal void DangerousSetResult(TResult result)
		{
			if (this.m_parent != null)
			{
				this.TrySetResult(result);
				return;
			}
			this.m_result = result;
			this.m_stateFlags |= 16777216;
		}

		/// <summary>Gets the result value of this <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <returns>The result value of this <see cref="T:System.Threading.Tasks.Task`1" />, which is the same type as the task's type parameter.</returns>
		/// <exception cref="T:System.AggregateException">The task was canceled. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains a <see cref="T:System.Threading.Tasks.TaskCanceledException" /> object. -or-An exception was thrown during the execution of the task. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains information about the exception or exceptions. </exception>
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x0004AF19 File Offset: 0x00049119
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public TResult Result
		{
			get
			{
				if (!base.IsWaitNotificationEnabledOrNotRanToCompletion)
				{
					return this.m_result;
				}
				return this.GetResultCore(true);
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x0004AF31 File Offset: 0x00049131
		internal TResult ResultOnSuccess
		{
			get
			{
				return this.m_result;
			}
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0004AF3C File Offset: 0x0004913C
		internal TResult GetResultCore(bool waitCompletionNotification)
		{
			if (!base.IsCompleted)
			{
				base.InternalWait(-1, default(CancellationToken));
			}
			if (waitCompletionNotification)
			{
				base.NotifyDebuggerOfWaitCompletionIfNecessary();
			}
			if (!base.IsCompletedSuccessfully)
			{
				base.ThrowIfExceptional(true);
			}
			return this.m_result;
		}

		/// <summary>Provides access to factory methods for creating and configuring <see cref="T:System.Threading.Tasks.Task`1" /> instances.</summary>
		/// <returns>A factory object that can create a variety of <see cref="T:System.Threading.Tasks.Task`1" /> objects.</returns>
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x0004AF81 File Offset: 0x00049181
		public new static TaskFactory<TResult> Factory
		{
			get
			{
				if (Task<TResult>.s_defaultFactory == null)
				{
					Interlocked.CompareExchange<TaskFactory<TResult>>(ref Task<TResult>.s_defaultFactory, new TaskFactory<TResult>(), null);
				}
				return Task<TResult>.s_defaultFactory;
			}
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0004AFA0 File Offset: 0x000491A0
		internal override void InnerInvoke()
		{
			Func<TResult> func = this.m_action as Func<TResult>;
			if (func != null)
			{
				this.m_result = func();
				return;
			}
			Func<object, TResult> func2 = this.m_action as Func<object, TResult>;
			if (func2 != null)
			{
				this.m_result = func2(this.m_stateObject);
				return;
			}
		}

		/// <summary>Gets an awaiter used to await this <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <returns>An awaiter instance.</returns>
		// Token: 0x060012C8 RID: 4808 RVA: 0x0004AFEB File Offset: 0x000491EB
		public new TaskAwaiter<TResult> GetAwaiter()
		{
			return new TaskAwaiter<TResult>(this);
		}

		/// <summary>Configures an awaiter used to await this <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continueOnCapturedContext">true to attempt to marshal the continuation back to the original context captured; otherwise, false.</param>
		/// <returns>An object used to await this task.</returns>
		// Token: 0x060012C9 RID: 4809 RVA: 0x0004AFF3 File Offset: 0x000491F3
		public new ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			return new ConfiguredTaskAwaitable<TResult>(this, continueOnCapturedContext);
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.-or-The <paramref name="scheduler" /> argument is null.</exception>
		// Token: 0x060012CA RID: 4810 RVA: 0x0004AFFC File Offset: 0x000491FC
		public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0004B01C File Offset: 0x0004921C
		internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			TaskCreationOptions creationOptions;
			InternalTaskOptions internalOptions;
			Task.CreationOptionsFromContinuationOptions(continuationOptions, out creationOptions, out internalOptions);
			Task task = new ContinuationTaskFromResultTask<TResult>(this, continuationAction, null, creationOptions, internalOptions);
			base.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		/// <summary>Creates a continuation that executes according the condition specified in <paramref name="continuationOptions" />.</summary>
		/// <param name="continuationFunction">A function to run according the condition specified in <paramref name="continuationOptions" />.When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <typeparam name="TNewResult"> The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		// Token: 0x060012CC RID: 4812 RVA: 0x0004B068 File Offset: 0x00049268
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0004B08C File Offset: 0x0004928C
		internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			TaskCreationOptions creationOptions;
			InternalTaskOptions internalOptions;
			Task.CreationOptionsFromContinuationOptions(continuationOptions, out creationOptions, out internalOptions);
			Task<TNewResult> task = new ContinuationResultTaskFromResultTask<TResult, TNewResult>(this, continuationFunction, null, creationOptions, internalOptions);
			base.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		// Token: 0x0400075E RID: 1886
		internal TResult m_result;

		// Token: 0x0400075F RID: 1887
		private static TaskFactory<TResult> s_defaultFactory;
	}
}
