using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Security;
using System.Security.Principal;

namespace System.Threading
{
	/// <summary>Creates and controls a thread, sets its priority, and gets its status.</summary>
	// Token: 0x020001DD RID: 477
	[StructLayout(0)]
	public sealed class Thread : CriticalFinalizerObject
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Thread" /> class.</summary>
		/// <param name="start">A <see cref="T:System.Threading.ThreadStart" /> delegate that represents the methods to be invoked when this thread begins executing. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="start" /> parameter is <see langword="null" />. </exception>
		// Token: 0x0600116D RID: 4461 RVA: 0x00047A43 File Offset: 0x00045C43
		[SecuritySafeCritical]
		public Thread(ThreadStart start)
		{
			if (start == null)
			{
				throw new ArgumentNullException("start");
			}
			this.SetStartHelper(start, 0);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Thread" /> class, specifying a delegate that allows an object to be passed to the thread when the thread is started and specifying the maximum stack size for the thread.</summary>
		/// <param name="start">A <see cref="T:System.Threading.ParameterizedThreadStart" /> delegate that represents the methods to be invoked when this thread begins executing.</param>
		/// <param name="maxStackSize">The maximum stack size, in bytes, to be used by the thread, or 0 to use the default maximum stack size specified in the header for the executable.Important   For partially trusted code, <paramref name="maxStackSize" /> is ignored if it is greater than the default stack size. No exception is thrown.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="start" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="maxStackSize" /> is less than zero.</exception>
		// Token: 0x0600116E RID: 4462 RVA: 0x00047A61 File Offset: 0x00045C61
		[SecuritySafeCritical]
		public Thread(ParameterizedThreadStart start, int maxStackSize)
		{
			if (start == null)
			{
				throw new ArgumentNullException("start");
			}
			if (0 > maxStackSize)
			{
				throw new ArgumentOutOfRangeException("maxStackSize", Environment.GetResourceString("Non-negative number required."));
			}
			this.SetStartHelper(start, maxStackSize);
		}

		/// <summary>Causes the operating system to change the state of the current instance to <see cref="F:System.Threading.ThreadState.Running" />.</summary>
		/// <exception cref="T:System.Threading.ThreadStateException">The thread has already been started. </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is not enough memory available to start this thread. </exception>
		// Token: 0x0600116F RID: 4463 RVA: 0x00047A98 File Offset: 0x00045C98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			this.Start(ref stackCrawlMark);
		}

		/// <summary>Causes the operating system to change the state of the current instance to <see cref="F:System.Threading.ThreadState.Running" />, and optionally supplies an object containing data to be used by the method the thread executes.</summary>
		/// <param name="parameter">An object that contains data to be used by the method the thread executes.</param>
		/// <exception cref="T:System.Threading.ThreadStateException">The thread has already been started. </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is not enough memory available to start this thread. </exception>
		/// <exception cref="T:System.InvalidOperationException">This thread was created using a <see cref="T:System.Threading.ThreadStart" /> delegate instead of a <see cref="T:System.Threading.ParameterizedThreadStart" /> delegate.</exception>
		// Token: 0x06001170 RID: 4464 RVA: 0x00047AB0 File Offset: 0x00045CB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start(object parameter)
		{
			if (this.m_Delegate is ThreadStart)
			{
				throw new InvalidOperationException(Environment.GetResourceString("The thread was created with a ThreadStart delegate that does not accept a parameter."));
			}
			this.m_ThreadStartArg = parameter;
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			this.Start(ref stackCrawlMark);
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00047AEC File Offset: 0x00045CEC
		[SecuritySafeCritical]
		private void Start(ref StackCrawlMark stackMark)
		{
			if (this.m_Delegate != null)
			{
				ThreadHelper threadHelper = (ThreadHelper)this.m_Delegate.Target;
				ExecutionContext executionContextHelper = ExecutionContext.Capture(ref stackMark, ExecutionContext.CaptureOptions.IgnoreSyncCtx);
				threadHelper.SetExecutionContextHelper(executionContextHelper);
			}
			object obj = null;
			this.StartInternal(obj, ref stackMark);
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00047B29 File Offset: 0x00045D29
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal ExecutionContext.Reader GetExecutionContextReader()
		{
			return new ExecutionContext.Reader(this.m_ExecutionContext);
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x00047B36 File Offset: 0x00045D36
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x00047B41 File Offset: 0x00045D41
		internal bool ExecutionContextBelongsToCurrentScope
		{
			get
			{
				return !this.m_ExecutionContextBelongsToOuterScope;
			}
			set
			{
				this.m_ExecutionContextBelongsToOuterScope = !value;
			}
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00047B50 File Offset: 0x00045D50
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal ExecutionContext GetMutableExecutionContext()
		{
			if (this.m_ExecutionContext == null)
			{
				this.m_ExecutionContext = new ExecutionContext();
			}
			else if (!this.ExecutionContextBelongsToCurrentScope)
			{
				ExecutionContext executionContext = this.m_ExecutionContext.CreateMutableCopy();
				this.m_ExecutionContext = executionContext;
			}
			this.ExecutionContextBelongsToCurrentScope = true;
			return this.m_ExecutionContext;
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00047B9A File Offset: 0x00045D9A
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope)
		{
			this.m_ExecutionContext = value;
			this.ExecutionContextBelongsToCurrentScope = belongsToCurrentScope;
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00047BAA File Offset: 0x00045DAA
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope)
		{
			this.m_ExecutionContext = value.DangerousGetRawExecutionContext();
			this.ExecutionContextBelongsToCurrentScope = belongsToCurrentScope;
		}

		// Token: 0x06001178 RID: 4472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SleepInternal(int millisecondsTimeout);

		/// <summary>Suspends the current thread for the specified number of milliseconds.</summary>
		/// <param name="millisecondsTimeout">The number of milliseconds for which the thread is suspended. If the value of the <paramref name="millisecondsTimeout" /> argument is zero, the thread relinquishes the remainder of its time slice to any thread of equal priority that is ready to run. If there are no other threads of equal priority that are ready to run, execution of the current thread is not suspended. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The time-out value is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />. </exception>
		// Token: 0x06001179 RID: 4473 RVA: 0x00047BC0 File Offset: 0x00045DC0
		[SecuritySafeCritical]
		public static void Sleep(int millisecondsTimeout)
		{
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			Thread.SleepInternal(millisecondsTimeout);
		}

		// Token: 0x0600117A RID: 4474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool YieldInternal();

		/// <summary>Causes the calling thread to yield execution to another thread that is ready to run on the current processor. The operating system selects the thread to yield to.</summary>
		/// <returns>
		///     <see langword="true" /> if the operating system switched execution to another thread; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600117B RID: 4475 RVA: 0x00047BE1 File Offset: 0x00045DE1
		public static bool Yield()
		{
			return Thread.YieldInternal();
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x00047BE8 File Offset: 0x00045DE8
		[SecurityCritical]
		private void SetStartHelper(Delegate start, int maxStackSize)
		{
			maxStackSize = Thread.GetProcessDefaultStackSize(maxStackSize);
			ThreadHelper @object = new ThreadHelper(start);
			if (start is ThreadStart)
			{
				this.SetStart(new ThreadStart(@object.ThreadStart), maxStackSize);
				return;
			}
			this.SetStart(new ParameterizedThreadStart(@object.ThreadStart), maxStackSize);
		}

		/// <summary>Gets or sets the current culture used by the Resource Manager to look up culture-specific resources at run time.</summary>
		/// <returns>An object that represents the current culture.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is set to <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The property is set to a culture name that cannot be used to locate a resource file. Resource filenames must include only letters, numbers, hyphens or underscores.</exception>
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x00047C33 File Offset: 0x00045E33
		public CultureInfo CurrentUICulture
		{
			get
			{
				return this.GetCurrentUICultureNoAppX();
			}
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00047C3C File Offset: 0x00045E3C
		internal CultureInfo GetCurrentUICultureNoAppX()
		{
			if (Thread.m_CurrentUICulture != null)
			{
				return Thread.m_CurrentUICulture;
			}
			CultureInfo defaultThreadCurrentUICulture = CultureInfo.DefaultThreadCurrentUICulture;
			if (defaultThreadCurrentUICulture == null)
			{
				return CultureInfo.UserDefaultUICulture;
			}
			return defaultThreadCurrentUICulture;
		}

		/// <summary>Gets or sets the culture for the current thread.</summary>
		/// <returns>An object that represents the culture for the current thread.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         The property is set to <see langword="null" />.</exception>
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x00047C66 File Offset: 0x00045E66
		public CultureInfo CurrentCulture
		{
			get
			{
				return this.GetCurrentCultureNoAppX();
			}
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00047C70 File Offset: 0x00045E70
		private CultureInfo GetCurrentCultureNoAppX()
		{
			if (Thread.m_CurrentCulture != null)
			{
				return Thread.m_CurrentCulture;
			}
			CultureInfo defaultThreadCurrentCulture = CultureInfo.DefaultThreadCurrentCulture;
			if (defaultThreadCurrentCulture == null)
			{
				return CultureInfo.UserDefaultCulture;
			}
			return defaultThreadCurrentCulture;
		}

		/// <summary>Synchronizes memory access as follows: The processor executing the current thread cannot reorder instructions in such a way that memory accesses prior to the call to <see cref="M:System.Threading.Thread.MemoryBarrier" /> execute after memory accesses that follow the call to <see cref="M:System.Threading.Thread.MemoryBarrier" />.</summary>
		// Token: 0x06001181 RID: 4481
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MemoryBarrier();

		// Token: 0x06001182 RID: 4482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ConstructInternalThread();

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x00047C9A File Offset: 0x00045E9A
		private InternalThread Internal
		{
			get
			{
				if (this.internal_thread == null)
				{
					this.ConstructInternalThread();
				}
				return this.internal_thread;
			}
		}

		/// <summary>Gets the current context in which the thread is executing.</summary>
		/// <returns>A <see cref="T:System.Runtime.Remoting.Contexts.Context" /> representing the current thread context.</returns>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x00047CB0 File Offset: 0x00045EB0
		public static Context CurrentContext
		{
			get
			{
				return AppDomain.InternalGetContext();
			}
		}

		// Token: 0x06001185 RID: 4485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetCurrentThread_icall(ref Thread thread);

		// Token: 0x06001186 RID: 4486 RVA: 0x00047CB8 File Offset: 0x00045EB8
		private static Thread GetCurrentThread()
		{
			Thread result = null;
			Thread.GetCurrentThread_icall(ref result);
			return result;
		}

		/// <summary>Gets the currently running thread.</summary>
		/// <returns>A <see cref="T:System.Threading.Thread" /> that is the representation of the currently running thread.</returns>
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00047CD0 File Offset: 0x00045ED0
		public static Thread CurrentThread
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
			get
			{
				Thread thread = Thread.current_thread;
				if (thread != null)
				{
					return thread;
				}
				return Thread.GetCurrentThread();
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x00047CED File Offset: 0x00045EED
		internal static int CurrentThreadId
		{
			get
			{
				return (int)Thread.CurrentThread.internal_thread.thread_id;
			}
		}

		/// <summary>Returns a unique application domain identifier.</summary>
		/// <returns>A 32-bit signed integer uniquely identifying the application domain.</returns>
		// Token: 0x06001189 RID: 4489
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetDomainID();

		// Token: 0x0600118A RID: 4490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool Thread_internal(MulticastDelegate start);

		/// <summary>Ensures that resources are freed and other cleanup operations are performed when the garbage collector reclaims the <see cref="T:System.Threading.Thread" /> object. </summary>
		// Token: 0x0600118B RID: 4491 RVA: 0x00047D00 File Offset: 0x00045F00
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		~Thread()
		{
		}

		/// <summary>Gets a value indicating whether or not a thread belongs to the managed thread pool.</summary>
		/// <returns>
		///     <see langword="true" /> if this thread belongs to the managed thread pool; otherwise, <see langword="false" />.</returns>
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x00047D28 File Offset: 0x00045F28
		public bool IsThreadPoolThread
		{
			get
			{
				return this.IsThreadPoolThreadInternal;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x00047D30 File Offset: 0x00045F30
		internal bool IsThreadPoolThreadInternal
		{
			get
			{
				return this.Internal.threadpool_thread;
			}
		}

		/// <summary>Gets or sets a value indicating whether or not a thread is a background thread.</summary>
		/// <returns>
		///     <see langword="true" /> if this thread is or is to become a background thread; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.Threading.ThreadStateException">The thread is dead. </exception>
		// Token: 0x170001B5 RID: 437
		// (set) Token: 0x0600118E RID: 4494 RVA: 0x00047D3D File Offset: 0x00045F3D
		public bool IsBackground
		{
			set
			{
				this.ValidateThreadState();
				if (value)
				{
					Thread.SetState(this.Internal, ThreadState.Background);
					return;
				}
				Thread.ClrState(this.Internal, ThreadState.Background);
			}
		}

		// Token: 0x0600118F RID: 4495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetName_internal(InternalThread thread);

		// Token: 0x06001190 RID: 4496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void SetName_icall(InternalThread thread, char* name, int nameLength);

		// Token: 0x06001191 RID: 4497 RVA: 0x00047D64 File Offset: 0x00045F64
		private unsafe static void SetName_internal(InternalThread thread, string name)
		{
			fixed (string text = name)
			{
				char* ptr = text;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				Thread.SetName_icall(thread, ptr, (name != null) ? name.Length : 0);
			}
		}

		/// <summary>Gets or sets the name of the thread.</summary>
		/// <returns>A string containing the name of the thread, or <see langword="null" /> if no name was set.</returns>
		/// <exception cref="T:System.InvalidOperationException">A set operation was requested, but the <see langword="Name" /> property has already been set. </exception>
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x00047D96 File Offset: 0x00045F96
		// (set) Token: 0x06001193 RID: 4499 RVA: 0x00047DA3 File Offset: 0x00045FA3
		public string Name
		{
			get
			{
				return Thread.GetName_internal(this.Internal);
			}
			set
			{
				Thread.SetName_internal(this.Internal, value);
			}
		}

		// Token: 0x06001194 RID: 4500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SpinWait_nop();

		/// <summary>Causes a thread to wait the number of times defined by the <paramref name="iterations" /> parameter.</summary>
		/// <param name="iterations">A 32-bit signed integer that defines how long a thread is to wait. </param>
		// Token: 0x06001195 RID: 4501 RVA: 0x00047DB1 File Offset: 0x00045FB1
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void SpinWait(int iterations)
		{
			if (iterations < 0)
			{
				return;
			}
			while (iterations-- > 0)
			{
				Thread.SpinWait_nop();
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00047DC6 File Offset: 0x00045FC6
		private void StartInternal(object principal, ref StackCrawlMark stackMark)
		{
			this.Internal._serialized_principal = Thread.CurrentThread.Internal._serialized_principal;
			if (!this.Thread_internal(this.m_Delegate))
			{
				throw new SystemException("Thread creation failed.");
			}
			this.m_ThreadStartArg = null;
		}

		// Token: 0x06001197 RID: 4503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetState(InternalThread thread, ThreadState set);

		// Token: 0x06001198 RID: 4504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ClrState(InternalThread thread, ThreadState clr);

		// Token: 0x06001199 RID: 4505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ThreadState GetState(InternalThread thread);

		// Token: 0x0600119A RID: 4506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int SystemMaxStackStize();

		// Token: 0x0600119B RID: 4507 RVA: 0x00047E04 File Offset: 0x00046004
		private static int GetProcessDefaultStackSize(int maxStackSize)
		{
			if (maxStackSize == 0)
			{
				return 0;
			}
			if (maxStackSize < 131072)
			{
				return 131072;
			}
			int pageSize = Environment.GetPageSize();
			if (maxStackSize % pageSize != 0)
			{
				maxStackSize = maxStackSize / (pageSize - 1) * pageSize;
			}
			return Math.Min(maxStackSize, Thread.SystemMaxStackStize());
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00047E43 File Offset: 0x00046043
		private void SetStart(MulticastDelegate start, int maxStackSize)
		{
			this.m_Delegate = start;
			this.Internal.stack_size = maxStackSize;
		}

		/// <summary>Gets a unique identifier for the current managed thread. </summary>
		/// <returns>An integer that represents a unique identifier for this managed thread.</returns>
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x00047E58 File Offset: 0x00046058
		public int ManagedThreadId
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return this.Internal.managed_id;
			}
		}

		/// <summary>Notifies a host that execution is about to enter a region of code in which the effects of a thread abort or unhandled exception might jeopardize other tasks in the application domain.</summary>
		// Token: 0x0600119E RID: 4510 RVA: 0x00047E65 File Offset: 0x00046065
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void BeginCriticalRegion()
		{
			Thread.CurrentThread.Internal.critical_region_level++;
		}

		/// <summary>Notifies a host that execution is about to enter a region of code in which the effects of a thread abort or unhandled exception are limited to the current task.</summary>
		// Token: 0x0600119F RID: 4511 RVA: 0x00047E82 File Offset: 0x00046082
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void EndCriticalRegion()
		{
			Thread.CurrentThread.Internal.critical_region_level--;
		}

		/// <summary>Returns an <see cref="T:System.Threading.ApartmentState" /> value indicating the apartment state.</summary>
		/// <returns>One of the <see cref="T:System.Threading.ApartmentState" /> values indicating the apartment state of the managed thread. The default is <see cref="F:System.Threading.ApartmentState.Unknown" />.</returns>
		// Token: 0x060011A0 RID: 4512 RVA: 0x00047E9F File Offset: 0x0004609F
		public ApartmentState GetApartmentState()
		{
			this.ValidateThreadState();
			return (ApartmentState)this.Internal.apartment_state;
		}

		/// <summary>Returns a hash code for the current thread.</summary>
		/// <returns>An integer hash code value.</returns>
		// Token: 0x060011A1 RID: 4513 RVA: 0x00047EB3 File Offset: 0x000460B3
		[ComVisible(false)]
		public override int GetHashCode()
		{
			return this.ManagedThreadId;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00047EBB File Offset: 0x000460BB
		private ThreadState ValidateThreadState()
		{
			ThreadState state = Thread.GetState(this.Internal);
			if ((state & ThreadState.Stopped) != ThreadState.Running)
			{
				throw new ThreadStateException("Thread is dead; state can not be accessed.");
			}
			return state;
		}

		// Token: 0x040006B9 RID: 1721
		private static LocalDataStoreMgr s_LocalDataStoreMgr;

		// Token: 0x040006BA RID: 1722
		[ThreadStatic]
		private static LocalDataStoreHolder s_LocalDataStore;

		// Token: 0x040006BB RID: 1723
		[ThreadStatic]
		internal static CultureInfo m_CurrentCulture;

		// Token: 0x040006BC RID: 1724
		[ThreadStatic]
		internal static CultureInfo m_CurrentUICulture;

		// Token: 0x040006BD RID: 1725
		private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture;

		// Token: 0x040006BE RID: 1726
		private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture;

		// Token: 0x040006BF RID: 1727
		private InternalThread internal_thread;

		// Token: 0x040006C0 RID: 1728
		private object m_ThreadStartArg;

		// Token: 0x040006C1 RID: 1729
		private object pending_exception;

		// Token: 0x040006C2 RID: 1730
		[ThreadStatic]
		private static Thread current_thread;

		// Token: 0x040006C3 RID: 1731
		private MulticastDelegate m_Delegate;

		// Token: 0x040006C4 RID: 1732
		private ExecutionContext m_ExecutionContext;

		// Token: 0x040006C5 RID: 1733
		private bool m_ExecutionContextBelongsToOuterScope;

		// Token: 0x040006C6 RID: 1734
		private IPrincipal principal;

		// Token: 0x040006C7 RID: 1735
		private int principal_version;
	}
}
