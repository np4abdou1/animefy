using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security;
using Internal.Runtime.Augments;
using Internal.Threading.Tasks.Tracing;

namespace System.Threading.Tasks
{
	/// <summary>Represents an asynchronous operation.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x02000218 RID: 536
	[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
	[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
	public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable
	{
		// Token: 0x060012E2 RID: 4834 RVA: 0x0004B720 File Offset: 0x00049920
		internal Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct)
		{
			if (canceled)
			{
				this.m_stateFlags = (int)((TaskCreationOptions)5242880 | creationOptions);
				Task.ContingentProperties contingentProperties = this.m_contingentProperties = new Task.ContingentProperties();
				contingentProperties.m_cancellationToken = ct;
				contingentProperties.m_internalCancellationRequested = 1;
				return;
			}
			this.m_stateFlags = (int)((TaskCreationOptions)16777216 | creationOptions);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0004B776 File Offset: 0x00049976
		internal Task()
		{
			this.m_stateFlags = 33555456;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0004B78C File Offset: 0x0004998C
		internal Task(object state, TaskCreationOptions creationOptions, bool promiseStyle)
		{
			if ((creationOptions & ~(TaskCreationOptions.AttachedToParent | TaskCreationOptions.RunContinuationsAsynchronously)) != TaskCreationOptions.None)
			{
				throw new ArgumentOutOfRangeException("creationOptions");
			}
			if ((creationOptions & TaskCreationOptions.AttachedToParent) != TaskCreationOptions.None)
			{
				this.m_parent = Task.InternalCurrent;
			}
			this.TaskConstructorCore(null, state, default(CancellationToken), creationOptions, InternalTaskOptions.PromiseTask, null);
		}

		/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task" /> with the specified action.</summary>
		/// <param name="action">The delegate that represents the code to execute in the task.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> argument is <see langword="null" />.</exception>
		// Token: 0x060012E5 RID: 4837 RVA: 0x0004B7D8 File Offset: 0x000499D8
		public Task(Action action) : this(action, null, null, default(CancellationToken), TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task" /> with the specified action and <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="action">The delegate that represents the code to execute in the task.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that the new  task will observe.</param>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
		// Token: 0x060012E6 RID: 4838 RVA: 0x0004B7FA File Offset: 0x000499FA
		public Task(Action action, CancellationToken cancellationToken) : this(action, null, null, cancellationToken, TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x0004B809 File Offset: 0x00049A09
		internal Task(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			if (action == null)
			{
				throw new ArgumentNullException("action");
			}
			if ((creationOptions & TaskCreationOptions.AttachedToParent) != TaskCreationOptions.None)
			{
				this.m_parent = parent;
			}
			this.TaskConstructorCore(action, state, cancellationToken, creationOptions, internalOptions, scheduler);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0004B83C File Offset: 0x00049A3C
		internal void TaskConstructorCore(Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			this.m_action = action;
			this.m_stateObject = state;
			this.m_taskScheduler = scheduler;
			if ((creationOptions & ~(TaskCreationOptions.PreferFairness | TaskCreationOptions.LongRunning | TaskCreationOptions.AttachedToParent | TaskCreationOptions.DenyChildAttach | TaskCreationOptions.HideScheduler | TaskCreationOptions.RunContinuationsAsynchronously)) != TaskCreationOptions.None)
			{
				throw new ArgumentOutOfRangeException("creationOptions");
			}
			int num = (int)(creationOptions | (TaskCreationOptions)internalOptions);
			if (this.m_action == null || (internalOptions & InternalTaskOptions.ContinuationTask) != InternalTaskOptions.None)
			{
				num |= 33554432;
			}
			this.m_stateFlags = num;
			if (this.m_parent != null && (creationOptions & TaskCreationOptions.AttachedToParent) != TaskCreationOptions.None && (this.m_parent.CreationOptions & TaskCreationOptions.DenyChildAttach) == TaskCreationOptions.None)
			{
				this.m_parent.AddNewChild();
			}
			if (cancellationToken.CanBeCanceled)
			{
				this.AssignCancellationToken(cancellationToken, null, null);
			}
			this.CapturedContext = ExecutionContext.Capture();
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0004B8E0 File Offset: 0x00049AE0
		private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation)
		{
			Task.ContingentProperties contingentProperties = this.EnsureContingentPropertiesInitialized(false);
			contingentProperties.m_cancellationToken = cancellationToken;
			try
			{
				if ((this.Options & (TaskCreationOptions)13312) == TaskCreationOptions.None)
				{
					if (cancellationToken.IsCancellationRequested)
					{
						this.InternalCancel(false);
					}
					else
					{
						CancellationTokenRegistration cancellationTokenRegistration;
						if (antecedent == null)
						{
							cancellationTokenRegistration = cancellationToken.InternalRegisterWithoutEC(Task.s_taskCancelCallback, this);
						}
						else
						{
							cancellationTokenRegistration = cancellationToken.InternalRegisterWithoutEC(Task.s_taskCancelCallback, new Tuple<Task, Task, TaskContinuation>(this, antecedent, continuation));
						}
						contingentProperties.m_cancellationRegistration = cancellationTokenRegistration;
					}
				}
			}
			catch
			{
				if (this.m_parent != null && (this.Options & TaskCreationOptions.AttachedToParent) != TaskCreationOptions.None && (this.m_parent.Options & TaskCreationOptions.DenyChildAttach) == TaskCreationOptions.None)
				{
					this.m_parent.DisregardChild();
				}
				throw;
			}
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0004B994 File Offset: 0x00049B94
		private static void TaskCancelCallback(object o)
		{
			Task task = o as Task;
			if (task == null)
			{
				Tuple<Task, Task, TaskContinuation> tuple = o as Tuple<Task, Task, TaskContinuation>;
				if (tuple != null)
				{
					task = tuple.Item1;
					Task item = tuple.Item2;
					TaskContinuation item2 = tuple.Item3;
					item.RemoveContinuation(item2);
				}
			}
			task.InternalCancel(false);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0004B9D9 File Offset: 0x00049BD9
		internal bool TrySetCanceled(CancellationToken tokenToRecord)
		{
			return this.TrySetCanceled(tokenToRecord, null);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0004B9E4 File Offset: 0x00049BE4
		internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException)
		{
			bool result = false;
			if (this.AtomicStateUpdate(67108864, 90177536))
			{
				this.RecordInternalCancellationRequest(tokenToRecord, cancellationException);
				this.CancellationCleanupLogic();
				result = true;
			}
			return result;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0004BA18 File Offset: 0x00049C18
		internal bool TrySetException(object exceptionObject)
		{
			bool result = false;
			this.EnsureContingentPropertiesInitialized(true);
			if (this.AtomicStateUpdate(67108864, 90177536))
			{
				this.AddException(exceptionObject);
				this.Finish(false);
				result = true;
			}
			return result;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x0004BA52 File Offset: 0x00049C52
		internal TaskCreationOptions Options
		{
			get
			{
				return Task.OptionsMethod(this.m_stateFlags);
			}
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0004BA61 File Offset: 0x00049C61
		internal static TaskCreationOptions OptionsMethod(int flags)
		{
			return (TaskCreationOptions)(flags & 65535);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0004BA6C File Offset: 0x00049C6C
		internal bool AtomicStateUpdate(int newBits, int illegalBits)
		{
			SpinWait spinWait = default(SpinWait);
			for (;;)
			{
				int stateFlags = this.m_stateFlags;
				if ((stateFlags & illegalBits) != 0)
				{
					break;
				}
				if (Interlocked.CompareExchange(ref this.m_stateFlags, stateFlags | newBits, stateFlags) == stateFlags)
				{
					return true;
				}
				spinWait.SpinOnce();
			}
			return false;
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0004BAB0 File Offset: 0x00049CB0
		internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags)
		{
			SpinWait spinWait = default(SpinWait);
			for (;;)
			{
				oldFlags = this.m_stateFlags;
				if ((oldFlags & illegalBits) != 0)
				{
					break;
				}
				if (Interlocked.CompareExchange(ref this.m_stateFlags, oldFlags | newBits, oldFlags) == oldFlags)
				{
					return true;
				}
				spinWait.SpinOnce();
			}
			return false;
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0004BAF8 File Offset: 0x00049CF8
		internal void SetNotificationForWaitCompletion(bool enabled)
		{
			if (enabled)
			{
				this.AtomicStateUpdate(268435456, 90177536);
				return;
			}
			SpinWait spinWait = default(SpinWait);
			for (;;)
			{
				int stateFlags = this.m_stateFlags;
				int value = stateFlags & -268435457;
				if (Interlocked.CompareExchange(ref this.m_stateFlags, value, stateFlags) == stateFlags)
				{
					break;
				}
				spinWait.SpinOnce();
			}
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x0004BB4C File Offset: 0x00049D4C
		internal bool NotifyDebuggerOfWaitCompletionIfNecessary()
		{
			if (this.IsWaitNotificationEnabled && this.ShouldNotifyDebuggerOfWaitCompletion)
			{
				this.NotifyDebuggerOfWaitCompletion();
				return true;
			}
			return false;
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x0004BB67 File Offset: 0x00049D67
		internal bool IsWaitNotificationEnabledOrNotRanToCompletion
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return (this.m_stateFlags & 285212672) != 16777216;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x0004BB81 File Offset: 0x00049D81
		internal virtual bool ShouldNotifyDebuggerOfWaitCompletion
		{
			get
			{
				return this.IsWaitNotificationEnabled;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x0004BB89 File Offset: 0x00049D89
		internal bool IsWaitNotificationEnabled
		{
			get
			{
				return (this.m_stateFlags & 268435456) != 0;
			}
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0004BB9C File Offset: 0x00049D9C
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void NotifyDebuggerOfWaitCompletion()
		{
			this.SetNotificationForWaitCompletion(false);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0004BBA5 File Offset: 0x00049DA5
		internal bool MarkStarted()
		{
			return this.AtomicStateUpdate(65536, 4259840);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0004BBB8 File Offset: 0x00049DB8
		internal void AddNewChild()
		{
			Task.ContingentProperties contingentProperties = this.EnsureContingentPropertiesInitialized(true);
			if (contingentProperties.m_completionCountdown == 1)
			{
				contingentProperties.m_completionCountdown++;
				return;
			}
			Interlocked.Increment(ref contingentProperties.m_completionCountdown);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0004BBF7 File Offset: 0x00049DF7
		internal void DisregardChild()
		{
			Interlocked.Decrement(ref this.EnsureContingentPropertiesInitialized(true).m_completionCountdown);
		}

		/// <summary>Starts the <see cref="T:System.Threading.Tasks.Task" />, scheduling it for execution to the current <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> instance has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Threading.Tasks.Task" /> is not in a valid state to be started. It may have already been started, executed, or canceled, or it may have been created in a manner that doesn't support direct scheduling.</exception>
		// Token: 0x060012FB RID: 4859 RVA: 0x0004BC0B File Offset: 0x00049E0B
		public void Start()
		{
			this.Start(TaskScheduler.Current);
		}

		/// <summary>Starts the <see cref="T:System.Threading.Tasks.Task" />, scheduling it for execution to the specified <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> with which to associate and execute this task.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Threading.Tasks.Task" /> is not in a valid state to be started. It may have already been started, executed, or canceled, or it may have been created in a manner that doesn't support direct scheduling.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> instance has been disposed.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskSchedulerException">The scheduler was unable to queue this task.</exception>
		// Token: 0x060012FC RID: 4860 RVA: 0x0004BC18 File Offset: 0x00049E18
		public void Start(TaskScheduler scheduler)
		{
			int stateFlags = this.m_stateFlags;
			if (Task.IsCompletedMethod(stateFlags))
			{
				throw new InvalidOperationException("Start may not be called on a task that has completed.");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			TaskCreationOptions taskCreationOptions = Task.OptionsMethod(stateFlags);
			if ((taskCreationOptions & (TaskCreationOptions)1024) != TaskCreationOptions.None)
			{
				throw new InvalidOperationException("Start may not be called on a promise-style task.");
			}
			if ((taskCreationOptions & (TaskCreationOptions)512) != TaskCreationOptions.None)
			{
				throw new InvalidOperationException("Start may not be called on a continuation task.");
			}
			if (Interlocked.CompareExchange<TaskScheduler>(ref this.m_taskScheduler, scheduler, null) != null)
			{
				throw new InvalidOperationException("Start may not be called on a task that was already started.");
			}
			this.ScheduleAndStart(true);
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0004BC9B File Offset: 0x00049E9B
		internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions)
		{
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			Task task = new Task(action, state, creatingTask, cancellationToken, options, internalOptions | InternalTaskOptions.QueuedByRuntime, scheduler);
			task.ScheduleAndStart(false);
			return task;
		}

		/// <summary>Gets an ID for this <see cref="T:System.Threading.Tasks.Task" /> instance.</summary>
		/// <returns>The identifier that is assigned by the system to this <see cref="T:System.Threading.Tasks.Task" /> instance. </returns>
		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x0004BCC8 File Offset: 0x00049EC8
		public int Id
		{
			get
			{
				if (this.m_taskId == 0)
				{
					int num;
					do
					{
						num = Interlocked.Increment(ref Task.s_taskIdCounter);
					}
					while (num == 0);
					Interlocked.CompareExchange(ref this.m_taskId, num, 0);
				}
				return this.m_taskId;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x0004BD05 File Offset: 0x00049F05
		internal static Task InternalCurrent
		{
			get
			{
				return Task.t_currentTask;
			}
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x0004BD0C File Offset: 0x00049F0C
		internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions)
		{
			if ((creationOptions & TaskCreationOptions.AttachedToParent) == TaskCreationOptions.None)
			{
				return null;
			}
			return Task.InternalCurrent;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x0004BD1C File Offset: 0x00049F1C
		internal static StackGuard CurrentStackGuard
		{
			get
			{
				StackGuard stackGuard = Task.t_stackGuard;
				if (stackGuard == null)
				{
					stackGuard = (Task.t_stackGuard = new StackGuard());
				}
				return stackGuard;
			}
		}

		/// <summary>Gets the <see cref="T:System.AggregateException" /> that caused the <see cref="T:System.Threading.Tasks.Task" /> to end prematurely. If the <see cref="T:System.Threading.Tasks.Task" /> completed successfully or has not yet thrown any exceptions, this will return <see langword="null" />.</summary>
		/// <returns>The <see cref="T:System.AggregateException" /> that caused the <see cref="T:System.Threading.Tasks.Task" /> to end prematurely.</returns>
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x0004BD40 File Offset: 0x00049F40
		public AggregateException Exception
		{
			get
			{
				AggregateException result = null;
				if (this.IsFaulted)
				{
					result = this.GetExceptions(false);
				}
				return result;
			}
		}

		/// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskStatus" /> of this task.</summary>
		/// <returns>The current <see cref="T:System.Threading.Tasks.TaskStatus" /> of this task instance.</returns>
		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x0004BD60 File Offset: 0x00049F60
		public TaskStatus Status
		{
			get
			{
				int stateFlags = this.m_stateFlags;
				TaskStatus result;
				if ((stateFlags & 2097152) != 0)
				{
					result = TaskStatus.Faulted;
				}
				else if ((stateFlags & 4194304) != 0)
				{
					result = TaskStatus.Canceled;
				}
				else if ((stateFlags & 16777216) != 0)
				{
					result = TaskStatus.RanToCompletion;
				}
				else if ((stateFlags & 8388608) != 0)
				{
					result = TaskStatus.WaitingForChildrenToComplete;
				}
				else if ((stateFlags & 131072) != 0)
				{
					result = TaskStatus.Running;
				}
				else if ((stateFlags & 65536) != 0)
				{
					result = TaskStatus.WaitingToRun;
				}
				else if ((stateFlags & 33554432) != 0)
				{
					result = TaskStatus.WaitingForActivation;
				}
				else
				{
					result = TaskStatus.Created;
				}
				return result;
			}
		}

		/// <summary>Gets whether this <see cref="T:System.Threading.Tasks.Task" /> instance has completed execution due to being canceled.</summary>
		/// <returns>
		///     <see langword="true" /> if the task has completed due to being canceled; otherwise <see langword="false" />.</returns>
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x0004BDD4 File Offset: 0x00049FD4
		public bool IsCanceled
		{
			get
			{
				return (this.m_stateFlags & 6291456) == 4194304;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x0004BDEC File Offset: 0x00049FEC
		internal bool IsCancellationRequested
		{
			get
			{
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				return contingentProperties != null && (contingentProperties.m_internalCancellationRequested == 1 || contingentProperties.m_cancellationToken.IsCancellationRequested);
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0004BE20 File Offset: 0x0004A020
		internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection)
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties == null)
			{
				return this.EnsureContingentPropertiesInitializedCore(needsProtection);
			}
			return contingentProperties;
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0004BE44 File Offset: 0x0004A044
		private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection)
		{
			if (needsProtection)
			{
				return LazyInitializer.EnsureInitialized<Task.ContingentProperties>(ref this.m_contingentProperties, Task.s_createContingentProperties);
			}
			return this.m_contingentProperties = new Task.ContingentProperties();
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x0004BE78 File Offset: 0x0004A078
		internal CancellationToken CancellationToken
		{
			get
			{
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				if (contingentProperties != null)
				{
					return contingentProperties.m_cancellationToken;
				}
				return default(CancellationToken);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x0004BEA1 File Offset: 0x0004A0A1
		internal bool IsCancellationAcknowledged
		{
			get
			{
				return (this.m_stateFlags & 1048576) != 0;
			}
		}

		/// <summary>Gets whether this <see cref="T:System.Threading.Tasks.Task" /> has completed.</summary>
		/// <returns>
		///     <see langword="true" /> if the task has completed; otherwise <see langword="false" />.</returns>
		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x0004BEB4 File Offset: 0x0004A0B4
		public bool IsCompleted
		{
			get
			{
				return Task.IsCompletedMethod(this.m_stateFlags);
			}
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x0004BEC3 File Offset: 0x0004A0C3
		private static bool IsCompletedMethod(int flags)
		{
			return (flags & 23068672) != 0;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0004BECF File Offset: 0x0004A0CF
		public bool IsCompletedSuccessfully
		{
			get
			{
				return (this.m_stateFlags & 23068672) == 16777216;
			}
		}

		/// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to create this task.</summary>
		/// <returns>The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to create this task.</returns>
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600130D RID: 4877 RVA: 0x0004BEE6 File Offset: 0x0004A0E6
		public TaskCreationOptions CreationOptions
		{
			get
			{
				return this.Options & (TaskCreationOptions)(-65281);
			}
		}

		/// <summary>Gets a <see cref="T:System.Threading.WaitHandle" /> that can be used to wait for the task to complete.</summary>
		/// <returns>A <see cref="T:System.Threading.WaitHandle" /> that can be used to wait for the task to complete.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x0004BEF4 File Offset: 0x0004A0F4
		WaitHandle IAsyncResult.AsyncWaitHandle
		{
			get
			{
				if ((this.m_stateFlags & 262144) != 0)
				{
					throw new ObjectDisposedException(null, "The task has been disposed.");
				}
				return this.CompletedEvent.WaitHandle;
			}
		}

		/// <summary>Gets the state object supplied when the <see cref="T:System.Threading.Tasks.Task" /> was created, or null if none was supplied.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the state data that was passed in to the task when it was created.</returns>
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x0004BF20 File Offset: 0x0004A120
		public object AsyncState
		{
			get
			{
				return this.m_stateObject;
			}
		}

		/// <summary>Gets an indication of whether the operation completed synchronously.</summary>
		/// <returns>
		///     <see langword="true" /> if the operation completed synchronously; otherwise, <see langword="false" />.</returns>
		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool IAsyncResult.CompletedSynchronously
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x0004BF28 File Offset: 0x0004A128
		internal TaskScheduler ExecutingTaskScheduler
		{
			get
			{
				return this.m_taskScheduler;
			}
		}

		/// <summary>Provides access to factory methods for creating and configuring <see cref="T:System.Threading.Tasks.Task" /> and <see cref="T:System.Threading.Tasks.Task`1" /> instances.</summary>
		/// <returns>A factory object that can create a variety of <see cref="T:System.Threading.Tasks.Task" /> and <see cref="T:System.Threading.Tasks.Task`1" /> objects. </returns>
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x0004BF30 File Offset: 0x0004A130
		public static TaskFactory Factory { get; } = new TaskFactory();

		/// <summary>Gets a task that has already completed successfully. </summary>
		/// <returns>The successfully completed task. </returns>
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06001313 RID: 4883 RVA: 0x0004BF37 File Offset: 0x0004A137
		public static Task CompletedTask { get; } = new Task(false, (TaskCreationOptions)16384, default(CancellationToken));

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x0004BF40 File Offset: 0x0004A140
		internal ManualResetEventSlim CompletedEvent
		{
			get
			{
				Task.ContingentProperties contingentProperties = this.EnsureContingentPropertiesInitialized(true);
				if (contingentProperties.m_completionEvent == null)
				{
					bool isCompleted = this.IsCompleted;
					ManualResetEventSlim manualResetEventSlim = new ManualResetEventSlim(isCompleted);
					if (Interlocked.CompareExchange<ManualResetEventSlim>(ref contingentProperties.m_completionEvent, manualResetEventSlim, null) != null)
					{
						manualResetEventSlim.Dispose();
					}
					else if (!isCompleted && this.IsCompleted)
					{
						manualResetEventSlim.Set();
					}
				}
				return contingentProperties.m_completionEvent;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x0004BFA0 File Offset: 0x0004A1A0
		internal bool ExceptionRecorded
		{
			get
			{
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				return contingentProperties != null && contingentProperties.m_exceptionsHolder != null && contingentProperties.m_exceptionsHolder.ContainsFaultList;
			}
		}

		/// <summary>Gets whether the <see cref="T:System.Threading.Tasks.Task" /> completed due to an unhandled exception.</summary>
		/// <returns>
		///     <see langword="true" /> if the task has thrown an unhandled exception; otherwise <see langword="false" />.</returns>
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x0004BFD2 File Offset: 0x0004A1D2
		public bool IsFaulted
		{
			get
			{
				return (this.m_stateFlags & 2097152) != 0;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x0004BFE8 File Offset: 0x0004A1E8
		// (set) Token: 0x06001318 RID: 4888 RVA: 0x0004C015 File Offset: 0x0004A215
		internal ExecutionContext CapturedContext
		{
			get
			{
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				if (contingentProperties != null && contingentProperties.m_capturedContext != null)
				{
					return contingentProperties.m_capturedContext;
				}
				return ExecutionContext.Default;
			}
			set
			{
				if (value != ExecutionContext.Default)
				{
					this.EnsureContingentPropertiesInitialized(false).m_capturedContext = value;
				}
			}
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.Tasks.Task" /> class.</summary>
		/// <exception cref="T:System.InvalidOperationException">The task is not in one of the final states: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" />, or <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
		// Token: 0x06001319 RID: 4889 RVA: 0x0004C02C File Offset: 0x0004A22C
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Disposes the <see cref="T:System.Threading.Tasks.Task" />, releasing all of its unmanaged resources.</summary>
		/// <param name="disposing">A Boolean value that indicates whether this method is being called due to a call to <see cref="M:System.Threading.Tasks.Task.Dispose" />.</param>
		/// <exception cref="T:System.InvalidOperationException">The task is not in one of the final states: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" />, or <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
		// Token: 0x0600131A RID: 4890 RVA: 0x0004C03C File Offset: 0x0004A23C
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if ((this.Options & (TaskCreationOptions)16384) != TaskCreationOptions.None)
				{
					return;
				}
				if (!this.IsCompleted)
				{
					throw new InvalidOperationException("A task may only be disposed if it is in a completion state (RanToCompletion, Faulted or Canceled).");
				}
				Task.ContingentProperties contingentProperties = Volatile.Read<Task.ContingentProperties>(ref this.m_contingentProperties);
				if (contingentProperties != null)
				{
					ManualResetEventSlim completionEvent = contingentProperties.m_completionEvent;
					if (completionEvent != null)
					{
						contingentProperties.m_completionEvent = null;
						if (!completionEvent.IsSet)
						{
							completionEvent.Set();
						}
						completionEvent.Dispose();
					}
				}
			}
			this.m_stateFlags |= 262144;
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x0004C0BC File Offset: 0x0004A2BC
		internal void ScheduleAndStart(bool needsProtection)
		{
			if (needsProtection)
			{
				if (!this.MarkStarted())
				{
					return;
				}
			}
			else
			{
				this.m_stateFlags |= 65536;
			}
			DebuggerSupport.AddToActiveTasks(this);
			if (DebuggerSupport.LoggingOn && (this.Options & (TaskCreationOptions)512) == TaskCreationOptions.None)
			{
				CausalityTraceLevel traceLevel = CausalityTraceLevel.Required;
				string str = "Task: ";
				Delegate action = this.m_action;
				DebuggerSupport.TraceOperationCreation(traceLevel, this, str + ((action != null) ? action.ToString() : null), 0UL);
			}
			try
			{
				this.m_taskScheduler.QueueTask(this);
			}
			catch (Exception innerException)
			{
				TaskSchedulerException ex = new TaskSchedulerException(innerException);
				this.AddException(ex);
				this.Finish(false);
				if ((this.Options & (TaskCreationOptions)512) == TaskCreationOptions.None)
				{
					this.m_contingentProperties.m_exceptionsHolder.MarkAsHandled(false);
				}
				throw ex;
			}
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0004C184 File Offset: 0x0004A384
		internal void AddException(object exceptionObject)
		{
			this.AddException(exceptionObject, false);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0004C190 File Offset: 0x0004A390
		internal void AddException(object exceptionObject, bool representsCancellation)
		{
			Task.ContingentProperties contingentProperties = this.EnsureContingentPropertiesInitialized(true);
			if (contingentProperties.m_exceptionsHolder == null)
			{
				TaskExceptionHolder taskExceptionHolder = new TaskExceptionHolder(this);
				if (Interlocked.CompareExchange<TaskExceptionHolder>(ref contingentProperties.m_exceptionsHolder, taskExceptionHolder, null) != null)
				{
					taskExceptionHolder.MarkAsHandled(false);
				}
			}
			Task.ContingentProperties obj = contingentProperties;
			lock (obj)
			{
				contingentProperties.m_exceptionsHolder.Add(exceptionObject, representsCancellation);
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0004C204 File Offset: 0x0004A404
		private AggregateException GetExceptions(bool includeTaskCanceledExceptions)
		{
			Exception ex = null;
			if (includeTaskCanceledExceptions && this.IsCanceled)
			{
				ex = new TaskCanceledException(this);
			}
			if (this.ExceptionRecorded)
			{
				return this.m_contingentProperties.m_exceptionsHolder.CreateExceptionObject(false, ex);
			}
			if (ex != null)
			{
				return new AggregateException(new Exception[]
				{
					ex
				});
			}
			return null;
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0004C258 File Offset: 0x0004A458
		internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			if (!this.IsFaulted || !this.ExceptionRecorded)
			{
				return new ReadOnlyCollection<ExceptionDispatchInfo>(Array.Empty<ExceptionDispatchInfo>());
			}
			return this.m_contingentProperties.m_exceptionsHolder.GetExceptionDispatchInfos();
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0004C28C File Offset: 0x0004A48C
		internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties == null)
			{
				return null;
			}
			TaskExceptionHolder exceptionsHolder = contingentProperties.m_exceptionsHolder;
			if (exceptionsHolder == null)
			{
				return null;
			}
			return exceptionsHolder.GetCancellationExceptionDispatchInfo();
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0004C2BC File Offset: 0x0004A4BC
		internal void ThrowIfExceptional(bool includeTaskCanceledExceptions)
		{
			Exception exceptions = this.GetExceptions(includeTaskCanceledExceptions);
			if (exceptions != null)
			{
				this.UpdateExceptionObservedStatus();
				throw exceptions;
			}
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0004C2DC File Offset: 0x0004A4DC
		internal void UpdateExceptionObservedStatus()
		{
			if (this.m_parent != null && (this.Options & TaskCreationOptions.AttachedToParent) != TaskCreationOptions.None && (this.m_parent.CreationOptions & TaskCreationOptions.DenyChildAttach) == TaskCreationOptions.None && Task.InternalCurrent == this.m_parent)
			{
				this.m_stateFlags |= 524288;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x0004C32D File Offset: 0x0004A52D
		internal bool IsExceptionObservedByParent
		{
			get
			{
				return (this.m_stateFlags & 524288) != 0;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x0004C340 File Offset: 0x0004A540
		internal bool IsDelegateInvoked
		{
			get
			{
				return (this.m_stateFlags & 131072) != 0;
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0004C354 File Offset: 0x0004A554
		internal void Finish(bool bUserDelegateExecuted)
		{
			if (!bUserDelegateExecuted)
			{
				this.FinishStageTwo();
				return;
			}
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties == null || contingentProperties.m_completionCountdown == 1 || Interlocked.Decrement(ref contingentProperties.m_completionCountdown) == 0)
			{
				this.FinishStageTwo();
			}
			else
			{
				this.AtomicStateUpdate(8388608, 23068672);
			}
			LowLevelListWithIList<Task> lowLevelListWithIList = (contingentProperties != null) ? contingentProperties.m_exceptionalChildren : null;
			if (lowLevelListWithIList != null)
			{
				LowLevelListWithIList<Task> obj = lowLevelListWithIList;
				lock (obj)
				{
					lowLevelListWithIList.RemoveAll(Task.s_IsExceptionObservedByParentPredicate);
				}
			}
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0004C3F0 File Offset: 0x0004A5F0
		internal void FinishStageTwo()
		{
			this.AddExceptionsFromChildren();
			int num;
			if (this.ExceptionRecorded)
			{
				num = 2097152;
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Error);
				}
				DebuggerSupport.RemoveFromActiveTasks(this);
			}
			else if (this.IsCancellationRequested && this.IsCancellationAcknowledged)
			{
				num = 4194304;
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Canceled);
				}
				DebuggerSupport.RemoveFromActiveTasks(this);
			}
			else
			{
				num = 16777216;
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Completed);
				}
				DebuggerSupport.RemoveFromActiveTasks(this);
			}
			Interlocked.Exchange(ref this.m_stateFlags, this.m_stateFlags | num);
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties != null)
			{
				contingentProperties.SetCompleted();
				contingentProperties.UnregisterCancellationCallback();
			}
			this.FinishStageThree();
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x0004C4A4 File Offset: 0x0004A6A4
		internal void FinishStageThree()
		{
			this.m_action = null;
			if (this.m_parent != null && (this.m_parent.CreationOptions & TaskCreationOptions.DenyChildAttach) == TaskCreationOptions.None && (this.m_stateFlags & 65535 & 4) != 0)
			{
				this.m_parent.ProcessChildCompletion(this);
			}
			this.FinishContinuations();
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0004C4F4 File Offset: 0x0004A6F4
		internal void ProcessChildCompletion(Task childTask)
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (childTask.IsFaulted && !childTask.IsExceptionObservedByParent)
			{
				if (contingentProperties.m_exceptionalChildren == null)
				{
					Interlocked.CompareExchange<LowLevelListWithIList<Task>>(ref contingentProperties.m_exceptionalChildren, new LowLevelListWithIList<Task>(), null);
				}
				LowLevelListWithIList<Task> exceptionalChildren = contingentProperties.m_exceptionalChildren;
				if (exceptionalChildren != null)
				{
					LowLevelListWithIList<Task> obj = exceptionalChildren;
					lock (obj)
					{
						exceptionalChildren.Add(childTask);
					}
				}
			}
			if (Interlocked.Decrement(ref contingentProperties.m_completionCountdown) == 0)
			{
				this.FinishStageTwo();
			}
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0004C584 File Offset: 0x0004A784
		internal void AddExceptionsFromChildren()
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			LowLevelListWithIList<Task> lowLevelListWithIList = (contingentProperties != null) ? contingentProperties.m_exceptionalChildren : null;
			if (lowLevelListWithIList != null)
			{
				LowLevelListWithIList<Task> obj = lowLevelListWithIList;
				lock (obj)
				{
					foreach (Task task in ((IEnumerable<Task>)lowLevelListWithIList))
					{
						if (task.IsFaulted && !task.IsExceptionObservedByParent)
						{
							TaskExceptionHolder exceptionsHolder = task.m_contingentProperties.m_exceptionsHolder;
							this.AddException(exceptionsHolder.CreateExceptionObject(false, null));
						}
					}
				}
				contingentProperties.m_exceptionalChildren = null;
			}
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0004C644 File Offset: 0x0004A844
		private void Execute()
		{
			try
			{
				this.InnerInvoke();
			}
			catch (Exception unhandledException)
			{
				this.HandleException(unhandledException);
			}
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0004C674 File Offset: 0x0004A874
		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
			this.ExecuteEntry(false);
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0004C680 File Offset: 0x0004A880
		internal bool ExecuteEntry(bool bPreventDoubleExecution)
		{
			if (bPreventDoubleExecution)
			{
				int num = 0;
				if (!this.AtomicStateUpdate(131072, 23199744, ref num) && (num & 4194304) == 0)
				{
					return false;
				}
			}
			else
			{
				this.m_stateFlags |= 131072;
			}
			if (!this.IsCancellationRequested && !this.IsCanceled)
			{
				this.ExecuteWithThreadLocal(ref Task.t_currentTask);
			}
			else if (!this.IsCanceled && (Interlocked.Exchange(ref this.m_stateFlags, this.m_stateFlags | 4194304) & 4194304) == 0)
			{
				this.CancellationCleanupLogic();
			}
			return true;
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x0004C714 File Offset: 0x0004A914
		private static void ExecutionContextCallback(object obj)
		{
			(obj as Task).Execute();
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x0004C724 File Offset: 0x0004A924
		internal virtual void InnerInvoke()
		{
			Action action = this.m_action as Action;
			if (action != null)
			{
				action();
				return;
			}
			Action<object> action2 = this.m_action as Action<object>;
			if (action2 != null)
			{
				action2(this.m_stateObject);
				return;
			}
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0004C764 File Offset: 0x0004A964
		private void HandleException(Exception unhandledException)
		{
			OperationCanceledException ex = unhandledException as OperationCanceledException;
			if (ex != null && this.IsCancellationRequested && this.m_contingentProperties.m_cancellationToken == ex.CancellationToken)
			{
				this.SetCancellationAcknowledged();
				this.AddException(ex, true);
				return;
			}
			this.AddException(unhandledException);
		}

		/// <summary>Gets an awaiter used to await this <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <returns>An awaiter instance.</returns>
		// Token: 0x06001330 RID: 4912 RVA: 0x0004C7B3 File Offset: 0x0004A9B3
		public TaskAwaiter GetAwaiter()
		{
			return new TaskAwaiter(this);
		}

		/// <summary>Configures an awaiter used to await this <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="continueOnCapturedContext">
		///       <see langword="true" /> to attempt to marshal the continuation back to the original context captured; otherwise, <see langword="false" />.</param>
		/// <returns>An object used to await this task.</returns>
		// Token: 0x06001331 RID: 4913 RVA: 0x0004C7BB File Offset: 0x0004A9BB
		public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			return new ConfiguredTaskAwaitable(this, continueOnCapturedContext);
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x0004C7C4 File Offset: 0x0004A9C4
		internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext)
		{
			TaskContinuation taskContinuation = null;
			if (continueOnCapturedContext)
			{
				SynchronizationContext synchronizationContext = SynchronizationContext.Current;
				if (synchronizationContext != null && synchronizationContext.GetType() != typeof(SynchronizationContext))
				{
					taskContinuation = new SynchronizationContextAwaitTaskContinuation(synchronizationContext, continuationAction, flowExecutionContext);
				}
				else
				{
					TaskScheduler internalCurrent = TaskScheduler.InternalCurrent;
					if (internalCurrent != null && internalCurrent != TaskScheduler.Default)
					{
						taskContinuation = new TaskSchedulerAwaitTaskContinuation(internalCurrent, continuationAction, flowExecutionContext);
					}
				}
			}
			if (taskContinuation != null)
			{
				if (!this.AddTaskContinuation(taskContinuation, false))
				{
					taskContinuation.Run(this, false);
					return;
				}
			}
			else if (!this.AddTaskContinuation(continuationAction, false))
			{
				AwaitTaskContinuation.UnsafeScheduleAction(continuationAction);
			}
		}

		/// <summary>Waits for the <see cref="T:System.Threading.Tasks.Task" /> to complete execution.</summary>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.AggregateException">The task was canceled. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains a <see cref="T:System.Threading.Tasks.TaskCanceledException" /> object. -or-An exception was thrown during the execution of the task. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains information about the exception or exceptions. </exception>
		// Token: 0x06001333 RID: 4915 RVA: 0x0004C844 File Offset: 0x0004AA44
		public void Wait()
		{
			this.Wait(-1, default(CancellationToken));
		}

		/// <summary>Waits for the <see cref="T:System.Threading.Tasks.Task" /> to complete execution. The wait terminates if a timeout interval elapses or a cancellation token is canceled before the task completes. </summary>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely. </param>
		/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete. </param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Threading.Tasks.Task" /> completed execution within the allotted time; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.AggregateException">The task was canceled. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains a <see cref="T:System.Threading.Tasks.TaskCanceledException" /> object. -or-An exception was thrown during the execution of the task. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains information about the exception or exceptions. </exception>
		// Token: 0x06001334 RID: 4916 RVA: 0x0004C864 File Offset: 0x0004AA64
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout");
			}
			if (!this.IsWaitNotificationEnabledOrNotRanToCompletion)
			{
				return true;
			}
			if (!this.InternalWait(millisecondsTimeout, cancellationToken))
			{
				return false;
			}
			if (this.IsWaitNotificationEnabledOrNotRanToCompletion)
			{
				this.NotifyDebuggerOfWaitCompletionIfNecessary();
				if (this.IsCanceled)
				{
					cancellationToken.ThrowIfCancellationRequested();
				}
				this.ThrowIfExceptional(true);
			}
			return true;
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0004C8BC File Offset: 0x0004AABC
		private bool WrappedTryRunInline()
		{
			if (this.m_taskScheduler == null)
			{
				return false;
			}
			bool result;
			try
			{
				result = this.m_taskScheduler.TryRunInline(this, true);
			}
			catch (Exception innerException)
			{
				throw new TaskSchedulerException(innerException);
			}
			return result;
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x0004C8FC File Offset: 0x0004AAFC
		[MethodImpl(MethodImplOptions.NoOptimization)]
		internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			if (TaskTrace.Enabled)
			{
				Task internalCurrent = Task.InternalCurrent;
				TaskTrace.TaskWaitBegin_Synchronous((internalCurrent != null) ? internalCurrent.m_taskScheduler.Id : TaskScheduler.Default.Id, (internalCurrent != null) ? internalCurrent.Id : 0, this.Id);
			}
			bool flag = this.IsCompleted;
			if (!flag)
			{
				flag = ((millisecondsTimeout == -1 && !cancellationToken.CanBeCanceled && this.WrappedTryRunInline() && this.IsCompleted) || this.SpinThenBlockingWait(millisecondsTimeout, cancellationToken));
			}
			if (TaskTrace.Enabled)
			{
				Task internalCurrent2 = Task.InternalCurrent;
				if (internalCurrent2 != null)
				{
					TaskTrace.TaskWaitEnd(internalCurrent2.m_taskScheduler.Id, internalCurrent2.Id, this.Id);
				}
				else
				{
					TaskTrace.TaskWaitEnd(TaskScheduler.Default.Id, 0, this.Id);
				}
			}
			return flag;
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x0004C9C0 File Offset: 0x0004ABC0
		private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			bool flag = millisecondsTimeout == -1;
			uint num = (uint)(flag ? 0 : Environment.TickCount);
			bool flag2 = this.SpinWait(millisecondsTimeout);
			if (!flag2)
			{
				Task.SetOnInvokeMres setOnInvokeMres = new Task.SetOnInvokeMres();
				try
				{
					this.AddCompletionAction(setOnInvokeMres, true);
					if (flag)
					{
						flag2 = setOnInvokeMres.Wait(-1, cancellationToken);
					}
					else
					{
						uint num2 = (uint)(Environment.TickCount - (int)num);
						if ((ulong)num2 < (ulong)((long)millisecondsTimeout))
						{
							flag2 = setOnInvokeMres.Wait((int)((long)millisecondsTimeout - (long)((ulong)num2)), cancellationToken);
						}
					}
				}
				finally
				{
					if (!this.IsCompleted)
					{
						this.RemoveContinuation(setOnInvokeMres);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x0004CA48 File Offset: 0x0004AC48
		private bool SpinWait(int millisecondsTimeout)
		{
			if (this.IsCompleted)
			{
				return true;
			}
			if (millisecondsTimeout == 0)
			{
				return false;
			}
			int spinCountforSpinBeforeWait = System.Threading.SpinWait.SpinCountforSpinBeforeWait;
			SpinWait spinWait = default(SpinWait);
			while (spinWait.Count < spinCountforSpinBeforeWait)
			{
				spinWait.SpinOnce(-1);
				if (this.IsCompleted)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0004CA94 File Offset: 0x0004AC94
		internal bool InternalCancel(bool bCancelNonExecutingOnly)
		{
			bool flag = false;
			bool flag2 = false;
			TaskSchedulerException ex = null;
			if ((this.m_stateFlags & 65536) != 0)
			{
				TaskScheduler taskScheduler = this.m_taskScheduler;
				try
				{
					flag = (taskScheduler != null && taskScheduler.TryDequeue(this));
				}
				catch (Exception innerException)
				{
					ex = new TaskSchedulerException(innerException);
				}
				bool flag3 = taskScheduler != null && taskScheduler.RequiresAtomicStartTransition;
				if (!flag && bCancelNonExecutingOnly && flag3)
				{
					flag2 = this.AtomicStateUpdate(4194304, 4325376);
				}
			}
			if (!bCancelNonExecutingOnly || flag || flag2)
			{
				this.RecordInternalCancellationRequest();
				if (flag)
				{
					flag2 = this.AtomicStateUpdate(4194304, 4325376);
				}
				else if (!flag2 && (this.m_stateFlags & 65536) == 0)
				{
					flag2 = this.AtomicStateUpdate(4194304, 23265280);
				}
				if (flag2)
				{
					this.CancellationCleanupLogic();
				}
			}
			if (ex != null)
			{
				throw ex;
			}
			return flag2;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0004CB6C File Offset: 0x0004AD6C
		internal void RecordInternalCancellationRequest()
		{
			this.EnsureContingentPropertiesInitialized(true).m_internalCancellationRequested = 1;
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0004CB80 File Offset: 0x0004AD80
		internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord)
		{
			this.RecordInternalCancellationRequest();
			if (tokenToRecord != default(CancellationToken))
			{
				this.m_contingentProperties.m_cancellationToken = tokenToRecord;
			}
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x0004CBB2 File Offset: 0x0004ADB2
		internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException)
		{
			this.RecordInternalCancellationRequest(tokenToRecord);
			if (cancellationException != null)
			{
				this.AddException(cancellationException, true);
			}
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x0004CBC8 File Offset: 0x0004ADC8
		internal void CancellationCleanupLogic()
		{
			Interlocked.Exchange(ref this.m_stateFlags, this.m_stateFlags | 4194304);
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties != null)
			{
				contingentProperties.SetCompleted();
				contingentProperties.UnregisterCancellationCallback();
			}
			if (DebuggerSupport.LoggingOn)
			{
				DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Canceled);
			}
			DebuggerSupport.RemoveFromActiveTasks(this);
			this.FinishStageThree();
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0004CC22 File Offset: 0x0004AE22
		private void SetCancellationAcknowledged()
		{
			this.m_stateFlags |= 1048576;
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0004CC3C File Offset: 0x0004AE3C
		internal void FinishContinuations()
		{
			object obj = Interlocked.Exchange(ref this.m_continuationObject, Task.s_taskCompletionSentinel);
			if (obj != null)
			{
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceSynchronousWorkStart(CausalityTraceLevel.Required, this, CausalitySynchronousWork.CompletionNotification);
				}
				bool flag = (this.m_stateFlags & 134217728) == 0 && (this.m_stateFlags & 64) == 0;
				Action action = obj as Action;
				if (action != null)
				{
					AwaitTaskContinuation.RunOrScheduleAction(action, flag, ref Task.t_currentTask);
					this.LogFinishCompletionNotification();
					return;
				}
				ITaskCompletionAction taskCompletionAction = obj as ITaskCompletionAction;
				if (taskCompletionAction != null)
				{
					if (flag || !taskCompletionAction.InvokeMayRunArbitraryCode)
					{
						taskCompletionAction.Invoke(this);
					}
					else
					{
						ThreadPool.UnsafeQueueCustomWorkItem(new CompletionActionInvoker(taskCompletionAction, this), false);
					}
					this.LogFinishCompletionNotification();
					return;
				}
				TaskContinuation taskContinuation = obj as TaskContinuation;
				if (taskContinuation != null)
				{
					taskContinuation.Run(this, flag);
					this.LogFinishCompletionNotification();
					return;
				}
				LowLevelListWithIList<object> lowLevelListWithIList = obj as LowLevelListWithIList<object>;
				if (lowLevelListWithIList == null)
				{
					this.LogFinishCompletionNotification();
					return;
				}
				LowLevelListWithIList<object> obj2 = lowLevelListWithIList;
				lock (obj2)
				{
				}
				int count = lowLevelListWithIList.Count;
				for (int i = 0; i < count; i++)
				{
					StandardTaskContinuation standardTaskContinuation = lowLevelListWithIList[i] as StandardTaskContinuation;
					if (standardTaskContinuation != null && (standardTaskContinuation.m_options & TaskContinuationOptions.ExecuteSynchronously) == TaskContinuationOptions.None)
					{
						lowLevelListWithIList[i] = null;
						standardTaskContinuation.Run(this, flag);
					}
				}
				for (int j = 0; j < count; j++)
				{
					object obj3 = lowLevelListWithIList[j];
					if (obj3 != null)
					{
						lowLevelListWithIList[j] = null;
						Action action2 = obj3 as Action;
						if (action2 != null)
						{
							AwaitTaskContinuation.RunOrScheduleAction(action2, flag, ref Task.t_currentTask);
						}
						else
						{
							TaskContinuation taskContinuation2 = obj3 as TaskContinuation;
							if (taskContinuation2 != null)
							{
								taskContinuation2.Run(this, flag);
							}
							else
							{
								ITaskCompletionAction taskCompletionAction2 = (ITaskCompletionAction)obj3;
								if (flag || !taskCompletionAction2.InvokeMayRunArbitraryCode)
								{
									taskCompletionAction2.Invoke(this);
								}
								else
								{
									ThreadPool.UnsafeQueueCustomWorkItem(new CompletionActionInvoker(taskCompletionAction2, this), false);
								}
							}
						}
					}
				}
				this.LogFinishCompletionNotification();
			}
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0004CE24 File Offset: 0x0004B024
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void LogFinishCompletionNotification()
		{
			if (DebuggerSupport.LoggingOn)
			{
				DebuggerSupport.TraceSynchronousWorkCompletion(CausalityTraceLevel.Required, CausalitySynchronousWork.CompletionNotification);
			}
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task" /> completes.</summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is <see langword="null" />.</exception>
		// Token: 0x06001341 RID: 4929 RVA: 0x0004CE34 File Offset: 0x0004B034
		public Task ContinueWith(Action<Task> continuationAction)
		{
			return this.ContinueWith(continuationAction, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0004CE58 File Offset: 0x0004B058
		private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
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
			Task task = new ContinuationTaskFromTask(this, continuationAction, null, creationOptions, internalOptions);
			this.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		/// <summary>Creates a continuation that receives caller-supplied state information and a cancellation token and that executes when the target <see cref="T:System.Threading.Tasks.Task" /> completes. The continuation executes based on a set of specified conditions and uses a specified scheduler. </summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation action.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its  execution.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		// Token: 0x06001343 RID: 4931 RVA: 0x0004CEA3 File Offset: 0x0004B0A3
		public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, state, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0004CEB4 File Offset: 0x0004B0B4
		private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
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
			Task task = new ContinuationTaskFromTask(this, continuationAction, state, creationOptions, internalOptions);
			this.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0004CF00 File Offset: 0x0004B100
		internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions)
		{
			TaskContinuationOptions taskContinuationOptions = TaskContinuationOptions.NotOnRanToCompletion | TaskContinuationOptions.NotOnFaulted | TaskContinuationOptions.NotOnCanceled;
			TaskContinuationOptions taskContinuationOptions2 = TaskContinuationOptions.PreferFairness | TaskContinuationOptions.LongRunning | TaskContinuationOptions.AttachedToParent | TaskContinuationOptions.DenyChildAttach | TaskContinuationOptions.HideScheduler | TaskContinuationOptions.RunContinuationsAsynchronously;
			TaskContinuationOptions taskContinuationOptions3 = TaskContinuationOptions.LongRunning | TaskContinuationOptions.ExecuteSynchronously;
			if ((continuationOptions & taskContinuationOptions3) == taskContinuationOptions3)
			{
				throw new ArgumentOutOfRangeException("continuationOptions", "The specified TaskContinuationOptions combined LongRunning and ExecuteSynchronously.  Synchronous continuations should not be long running.");
			}
			if ((continuationOptions & ~((taskContinuationOptions2 | taskContinuationOptions | TaskContinuationOptions.LazyCancellation | TaskContinuationOptions.ExecuteSynchronously) != TaskContinuationOptions.None)) != TaskContinuationOptions.None)
			{
				throw new ArgumentOutOfRangeException("continuationOptions");
			}
			if ((continuationOptions & taskContinuationOptions) == taskContinuationOptions)
			{
				throw new ArgumentOutOfRangeException("continuationOptions", "The specified TaskContinuationOptions excluded all continuation kinds.");
			}
			creationOptions = (TaskCreationOptions)(continuationOptions & taskContinuationOptions2);
			internalOptions = InternalTaskOptions.ContinuationTask;
			if ((continuationOptions & TaskContinuationOptions.LazyCancellation) != TaskContinuationOptions.None)
			{
				internalOptions |= InternalTaskOptions.LazyCancellation;
			}
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0004CF80 File Offset: 0x0004B180
		internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options)
		{
			TaskContinuation taskContinuation = new StandardTaskContinuation(continuationTask, options, scheduler);
			if (cancellationToken.CanBeCanceled)
			{
				if (this.IsCompleted || cancellationToken.IsCancellationRequested)
				{
					continuationTask.AssignCancellationToken(cancellationToken, null, null);
				}
				else
				{
					continuationTask.AssignCancellationToken(cancellationToken, this, taskContinuation);
				}
			}
			if (!continuationTask.IsCompleted && !this.AddTaskContinuation(taskContinuation, false))
			{
				taskContinuation.Run(this, true);
			}
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x0004CFDF File Offset: 0x0004B1DF
		internal void AddCompletionAction(ITaskCompletionAction action)
		{
			this.AddCompletionAction(action, false);
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0004CFE9 File Offset: 0x0004B1E9
		private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers)
		{
			if (!this.AddTaskContinuation(action, addBeforeOthers))
			{
				action.Invoke(this);
			}
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0004CFFC File Offset: 0x0004B1FC
		private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers)
		{
			object continuationObject = this.m_continuationObject;
			if (continuationObject != Task.s_taskCompletionSentinel && !(continuationObject is LowLevelListWithIList<object>))
			{
				Interlocked.CompareExchange(ref this.m_continuationObject, new LowLevelListWithIList<object>
				{
					continuationObject
				}, continuationObject);
			}
			LowLevelListWithIList<object> lowLevelListWithIList = this.m_continuationObject as LowLevelListWithIList<object>;
			if (lowLevelListWithIList != null)
			{
				LowLevelListWithIList<object> obj = lowLevelListWithIList;
				lock (obj)
				{
					if (this.m_continuationObject != Task.s_taskCompletionSentinel)
					{
						if (lowLevelListWithIList.Count == lowLevelListWithIList.Capacity)
						{
							lowLevelListWithIList.RemoveAll(Task.s_IsTaskContinuationNullPredicate);
						}
						if (addBeforeOthers)
						{
							lowLevelListWithIList.Insert(0, tc);
						}
						else
						{
							lowLevelListWithIList.Add(tc);
						}
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0004D0C0 File Offset: 0x0004B2C0
		private bool AddTaskContinuation(object tc, bool addBeforeOthers)
		{
			return !this.IsCompleted && ((this.m_continuationObject == null && Interlocked.CompareExchange(ref this.m_continuationObject, tc, null) == null) || this.AddTaskContinuationComplex(tc, addBeforeOthers));
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0004D0F0 File Offset: 0x0004B2F0
		internal void RemoveContinuation(object continuationObject)
		{
			object continuationObject2 = this.m_continuationObject;
			if (continuationObject2 == Task.s_taskCompletionSentinel)
			{
				return;
			}
			LowLevelListWithIList<object> lowLevelListWithIList = continuationObject2 as LowLevelListWithIList<object>;
			if (lowLevelListWithIList == null)
			{
				if (Interlocked.CompareExchange(ref this.m_continuationObject, new LowLevelListWithIList<object>(), continuationObject) == continuationObject)
				{
					return;
				}
				lowLevelListWithIList = (this.m_continuationObject as LowLevelListWithIList<object>);
			}
			if (lowLevelListWithIList != null)
			{
				LowLevelListWithIList<object> obj = lowLevelListWithIList;
				lock (obj)
				{
					if (this.m_continuationObject != Task.s_taskCompletionSentinel)
					{
						int num = lowLevelListWithIList.IndexOf(continuationObject);
						if (num != -1)
						{
							lowLevelListWithIList[num] = null;
						}
					}
				}
			}
		}

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that's completed successfully with the specified result.</summary>
		/// <param name="result">The result to store into the completed task. </param>
		/// <typeparam name="TResult">The type of the result returned by the task. </typeparam>
		/// <returns>The successfully completed task.</returns>
		// Token: 0x0600134C RID: 4940 RVA: 0x0004D194 File Offset: 0x0004B394
		public static Task<TResult> FromResult<TResult>(TResult result)
		{
			return new Task<TResult>(result);
		}

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that has completed with a specified exception. </summary>
		/// <param name="exception">The exception with which to complete the task. </param>
		/// <returns>The faulted task. </returns>
		// Token: 0x0600134D RID: 4941 RVA: 0x0004D19C File Offset: 0x0004B39C
		public static Task FromException(Exception exception)
		{
			return Task.FromException<VoidTaskResult>(exception);
		}

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that's completed with a specified exception. </summary>
		/// <param name="exception">The exception with which to complete the task. </param>
		/// <typeparam name="TResult">The type of the result returned by the task. </typeparam>
		/// <returns>The faulted task. </returns>
		// Token: 0x0600134E RID: 4942 RVA: 0x0004D1A4 File Offset: 0x0004B3A4
		public static Task<TResult> FromException<TResult>(Exception exception)
		{
			if (exception == null)
			{
				throw new ArgumentNullException("exception");
			}
			Task<TResult> task = new Task<TResult>();
			task.TrySetException(exception);
			return task;
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x0004D1C1 File Offset: 0x0004B3C1
		internal static Task FromCancellation(CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				throw new ArgumentOutOfRangeException("cancellationToken");
			}
			return new Task(true, TaskCreationOptions.None, cancellationToken);
		}

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that's completed due to cancellation with a specified cancellation token.</summary>
		/// <param name="cancellationToken">The cancellation token with which to complete the task. </param>
		/// <returns>The canceled task. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Cancellation has not been requested for <paramref name="cancellationToken" />; its <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> property is <see langword="false" />. </exception>
		// Token: 0x06001350 RID: 4944 RVA: 0x0004D1DF File Offset: 0x0004B3DF
		public static Task FromCanceled(CancellationToken cancellationToken)
		{
			return Task.FromCancellation(cancellationToken);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0004D1E8 File Offset: 0x0004B3E8
		internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				throw new ArgumentOutOfRangeException("cancellationToken");
			}
			return new Task<TResult>(true, default(TResult), TaskCreationOptions.None, cancellationToken);
		}

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that's completed due to cancellation with a specified cancellation token.</summary>
		/// <param name="cancellationToken">The cancellation token with which to complete the task. </param>
		/// <typeparam name="TResult">The type of the result returned by the task. </typeparam>
		/// <returns>The canceled task. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Cancellation has not been requested for <paramref name="cancellationToken" />; its <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> property is <see langword="false" />. </exception>
		// Token: 0x06001352 RID: 4946 RVA: 0x0004D21A File Offset: 0x0004B41A
		public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken)
		{
			return Task.FromCancellation<TResult>(cancellationToken);
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0004D222 File Offset: 0x0004B422
		internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception)
		{
			if (exception == null)
			{
				throw new ArgumentNullException("exception");
			}
			Task<TResult> task = new Task<TResult>();
			task.TrySetCanceled(exception.CancellationToken, exception);
			return task;
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a <see cref="T:System.Threading.Tasks.Task" /> object that represents that work.</summary>
		/// <param name="action">The work to execute asynchronously</param>
		/// <returns>A task that represents the work queued to execute in the ThreadPool.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> parameter was <see langword="null" />.</exception>
		// Token: 0x06001354 RID: 4948 RVA: 0x0004D248 File Offset: 0x0004B448
		public static Task Run(Action action)
		{
			return Task.InternalStartNew(null, action, null, default(CancellationToken), TaskScheduler.Default, TaskCreationOptions.DenyChildAttach, InternalTaskOptions.None);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a <see cref="T:System.Threading.Tasks.Task`1" /> object that represents that work. </summary>
		/// <param name="function">The work to execute asynchronously. </param>
		/// <typeparam name="TResult">The return type of the task. </typeparam>
		/// <returns>A task object that represents the work queued to execute in the thread pool. </returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001355 RID: 4949 RVA: 0x0004D270 File Offset: 0x0004B470
		public static Task<TResult> Run<TResult>(Func<TResult> function)
		{
			return Task<TResult>.StartNew(null, function, default(CancellationToken), TaskCreationOptions.DenyChildAttach, InternalTaskOptions.None, TaskScheduler.Default);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the  task returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was <see langword="null" />.</exception>
		// Token: 0x06001356 RID: 4950 RVA: 0x0004D294 File Offset: 0x0004B494
		public static Task Run(Func<Task> function)
		{
			return Task.Run(function, default(CancellationToken));
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the task returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously. </param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work. </param>
		/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		// Token: 0x06001357 RID: 4951 RVA: 0x0004D2B0 File Offset: 0x0004B4B0
		public static Task Run(Func<Task> function, CancellationToken cancellationToken)
		{
			if (function == null)
			{
				throw new ArgumentNullException("function");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCancellation(cancellationToken);
			}
			return new UnwrapPromise<VoidTaskResult>(Task.Factory.StartNew<Task>(function, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default), true);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the <see langword="Task(TResult)" /> returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
		/// <returns>A <see langword="Task(TResult)" /> that represents a proxy for the <see langword="Task(TResult)" /> returned by <paramref name="function" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was <see langword="null" />.</exception>
		// Token: 0x06001358 RID: 4952 RVA: 0x0004D2E8 File Offset: 0x0004B4E8
		public static Task<TResult> Run<TResult>(Func<Task<TResult>> function)
		{
			return Task.Run<TResult>(function, default(CancellationToken));
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the <see langword="Task(TResult)" /> returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work</param>
		/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
		/// <returns>A <see langword="Task(TResult)" /> that represents a proxy for the <see langword="Task(TResult)" /> returned by <paramref name="function" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		// Token: 0x06001359 RID: 4953 RVA: 0x0004D304 File Offset: 0x0004B504
		public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken)
		{
			if (function == null)
			{
				throw new ArgumentNullException("function");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCancellation<TResult>(cancellationToken);
			}
			return new UnwrapPromise<TResult>(Task.Factory.StartNew<Task<TResult>>(function, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default), true);
		}

		/// <summary>Creates a task that completes after a time delay. </summary>
		/// <param name="millisecondsDelay">The number of milliseconds to wait before completing the returned task, or -1 to wait indefinitely. </param>
		/// <returns>A task that represents the time delay. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="millisecondsDelay" /> argument is less than -1.</exception>
		// Token: 0x0600135A RID: 4954 RVA: 0x0004D33C File Offset: 0x0004B53C
		public static Task Delay(int millisecondsDelay)
		{
			return Task.Delay(millisecondsDelay, default(CancellationToken));
		}

		/// <summary>Creates a cancellable task that completes after a time delay. </summary>
		/// <param name="millisecondsDelay">The number of milliseconds to wait before completing the returned task, or -1 to wait indefinitely. </param>
		/// <param name="cancellationToken">The cancellation token that will be checked prior to completing the returned task. </param>
		/// <returns>A task that represents the time delay. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="millisecondsDelay" /> argument is less than -1. </exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The provided <paramref name="cancellationToken" /> has already been disposed. </exception>
		// Token: 0x0600135B RID: 4955 RVA: 0x0004D358 File Offset: 0x0004B558
		public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
		{
			if (millisecondsDelay < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsDelay", "The value needs to be either -1 (signifying an infinite timeout), 0 or a positive integer.");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCancellation(cancellationToken);
			}
			if (millisecondsDelay == 0)
			{
				return Task.CompletedTask;
			}
			Task.DelayPromise delayPromise = new Task.DelayPromise(cancellationToken);
			if (cancellationToken.CanBeCanceled)
			{
				delayPromise.Registration = cancellationToken.InternalRegisterWithoutEC(delegate(object state)
				{
					((Task.DelayPromise)state).Complete();
				}, delayPromise);
			}
			if (millisecondsDelay != -1)
			{
				delayPromise.Timer = new Timer(delegate(object state)
				{
					((Task.DelayPromise)state).Complete();
				}, delayPromise, millisecondsDelay, -1);
				delayPromise.Timer.KeepRootedWhileScheduled();
			}
			return delayPromise;
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		// Token: 0x0600135C RID: 4956 RVA: 0x0004D40C File Offset: 0x0004B60C
		public static Task<Task> WhenAny(params Task[] tasks)
		{
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			if (tasks.Length == 0)
			{
				throw new ArgumentException("The tasks argument contains no tasks.", "tasks");
			}
			int num = tasks.Length;
			Task[] array = new Task[num];
			for (int i = 0; i < num; i++)
			{
				Task task = tasks[i];
				if (task == null)
				{
					throw new ArgumentException("The tasks argument included a null value.", "tasks");
				}
				array[i] = task;
			}
			return TaskFactory.CommonCWAnyLogic(array);
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		// Token: 0x0600135D RID: 4957 RVA: 0x0004D474 File Offset: 0x0004B674
		public static Task<Task> WhenAny(IEnumerable<Task> tasks)
		{
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			LowLevelListWithIList<Task> lowLevelListWithIList = new LowLevelListWithIList<Task>();
			foreach (Task task in tasks)
			{
				if (task == null)
				{
					throw new ArgumentException("The tasks argument included a null value.", "tasks");
				}
				lowLevelListWithIList.Add(task);
			}
			if (lowLevelListWithIList.Count == 0)
			{
				throw new ArgumentException("The tasks argument contains no tasks.", "tasks");
			}
			return TaskFactory.CommonCWAnyLogic(lowLevelListWithIList);
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0004D504 File Offset: 0x0004B704
		[FriendAccessAllowed]
		internal static bool AddToActiveTasks(Task task)
		{
			object obj = Task.s_activeTasksLock;
			lock (obj)
			{
				Task.s_currentActiveTasks[task.Id] = task;
			}
			return true;
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0004D550 File Offset: 0x0004B750
		[FriendAccessAllowed]
		internal static void RemoveFromActiveTasks(int taskId)
		{
			object obj = Task.s_activeTasksLock;
			lock (obj)
			{
				Task.s_currentActiveTasks.Remove(taskId);
			}
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void MarkAborted(ThreadAbortException e)
		{
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x0004D598 File Offset: 0x0004B798
		[SecurityCritical]
		private void ExecuteWithThreadLocal(ref Task currentTaskSlot)
		{
			Task task = currentTaskSlot;
			try
			{
				currentTaskSlot = this;
				ExecutionContext capturedContext = this.CapturedContext;
				if (capturedContext == null)
				{
					this.Execute();
				}
				else
				{
					ContextCallback contextCallback = Task.s_ecCallback;
					if (contextCallback == null)
					{
						contextCallback = (Task.s_ecCallback = new ContextCallback(Task.ExecutionContextCallback));
					}
					ExecutionContext.Run(capturedContext, contextCallback, this, true);
				}
				if (AsyncCausalityTracer.LoggingOn)
				{
					AsyncCausalityTracer.TraceSynchronousWorkCompletion(CausalityTraceLevel.Required, CausalitySynchronousWork.Execution);
				}
				this.Finish(true);
			}
			finally
			{
				currentTaskSlot = task;
			}
		}

		// Token: 0x04000779 RID: 1913
		internal static int s_taskIdCounter;

		// Token: 0x0400077A RID: 1914
		private volatile int m_taskId;

		// Token: 0x0400077B RID: 1915
		internal Delegate m_action;

		// Token: 0x0400077C RID: 1916
		internal object m_stateObject;

		// Token: 0x0400077D RID: 1917
		internal TaskScheduler m_taskScheduler;

		// Token: 0x0400077E RID: 1918
		internal readonly Task m_parent;

		// Token: 0x0400077F RID: 1919
		internal volatile int m_stateFlags;

		// Token: 0x04000780 RID: 1920
		private volatile object m_continuationObject;

		// Token: 0x04000781 RID: 1921
		private static readonly object s_taskCompletionSentinel = new object();

		// Token: 0x04000782 RID: 1922
		internal static bool s_asyncDebuggingEnabled;

		// Token: 0x04000783 RID: 1923
		internal volatile Task.ContingentProperties m_contingentProperties;

		// Token: 0x04000784 RID: 1924
		private static readonly Action<object> s_taskCancelCallback = new Action<object>(Task.TaskCancelCallback);

		// Token: 0x04000785 RID: 1925
		[ThreadStatic]
		internal static Task t_currentTask;

		// Token: 0x04000786 RID: 1926
		[ThreadStatic]
		private static StackGuard t_stackGuard;

		// Token: 0x04000787 RID: 1927
		private static readonly Func<Task.ContingentProperties> s_createContingentProperties = () => new Task.ContingentProperties();

		// Token: 0x0400078A RID: 1930
		private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate = (Task t) => t.IsExceptionObservedByParent;

		// Token: 0x0400078B RID: 1931
		private static ContextCallback s_ecCallback;

		// Token: 0x0400078C RID: 1932
		private static readonly Predicate<object> s_IsTaskContinuationNullPredicate = (object tc) => tc == null;

		// Token: 0x0400078D RID: 1933
		private static readonly Dictionary<int, Task> s_currentActiveTasks = new Dictionary<int, Task>();

		// Token: 0x0400078E RID: 1934
		private static readonly object s_activeTasksLock = new object();

		// Token: 0x02000219 RID: 537
		internal class ContingentProperties
		{
			// Token: 0x06001363 RID: 4963 RVA: 0x0004D6B0 File Offset: 0x0004B8B0
			internal void SetCompleted()
			{
				ManualResetEventSlim completionEvent = this.m_completionEvent;
				if (completionEvent != null)
				{
					completionEvent.Set();
				}
			}

			// Token: 0x06001364 RID: 4964 RVA: 0x0004D6D0 File Offset: 0x0004B8D0
			internal void UnregisterCancellationCallback()
			{
				if (this.m_cancellationRegistration != null)
				{
					try
					{
						((CancellationTokenRegistration)this.m_cancellationRegistration).Dispose();
					}
					catch (ObjectDisposedException)
					{
					}
					this.m_cancellationRegistration = null;
				}
			}

			// Token: 0x0400078F RID: 1935
			internal ExecutionContext m_capturedContext;

			// Token: 0x04000790 RID: 1936
			internal volatile ManualResetEventSlim m_completionEvent;

			// Token: 0x04000791 RID: 1937
			internal volatile TaskExceptionHolder m_exceptionsHolder;

			// Token: 0x04000792 RID: 1938
			internal CancellationToken m_cancellationToken;

			// Token: 0x04000793 RID: 1939
			internal object m_cancellationRegistration;

			// Token: 0x04000794 RID: 1940
			internal volatile int m_internalCancellationRequested;

			// Token: 0x04000795 RID: 1941
			internal volatile int m_completionCountdown = 1;

			// Token: 0x04000796 RID: 1942
			internal volatile LowLevelListWithIList<Task> m_exceptionalChildren;
		}

		// Token: 0x0200021A RID: 538
		private sealed class SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction
		{
			// Token: 0x06001366 RID: 4966 RVA: 0x0004D725 File Offset: 0x0004B925
			internal SetOnInvokeMres() : base(false, 0)
			{
			}

			// Token: 0x06001367 RID: 4967 RVA: 0x0004D72F File Offset: 0x0004B92F
			public void Invoke(Task completingTask)
			{
				base.Set();
			}

			// Token: 0x170001EC RID: 492
			// (get) Token: 0x06001368 RID: 4968 RVA: 0x0002ACA4 File Offset: 0x00028EA4
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return false;
				}
			}
		}

		// Token: 0x0200021B RID: 539
		private sealed class DelayPromise : Task<VoidTaskResult>
		{
			// Token: 0x06001369 RID: 4969 RVA: 0x0004D737 File Offset: 0x0004B937
			internal DelayPromise(CancellationToken token)
			{
				this.Token = token;
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCreation(CausalityTraceLevel.Required, this, "Task.Delay", 0UL);
				}
				DebuggerSupport.AddToActiveTasks(this);
			}

			// Token: 0x0600136A RID: 4970 RVA: 0x0004D764 File Offset: 0x0004B964
			internal void Complete()
			{
				bool flag;
				if (this.Token.IsCancellationRequested)
				{
					flag = base.TrySetCanceled(this.Token);
				}
				else
				{
					if (DebuggerSupport.LoggingOn)
					{
						DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Completed);
					}
					DebuggerSupport.RemoveFromActiveTasks(this);
					flag = base.TrySetResult(default(VoidTaskResult));
				}
				if (flag)
				{
					if (this.Timer != null)
					{
						this.Timer.Dispose();
					}
					this.Registration.Dispose();
				}
			}

			// Token: 0x04000797 RID: 1943
			internal readonly CancellationToken Token;

			// Token: 0x04000798 RID: 1944
			internal CancellationTokenRegistration Registration;

			// Token: 0x04000799 RID: 1945
			internal Timer Timer;
		}
	}
}
