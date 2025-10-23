using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Security;

namespace System.Threading
{
	/// <summary>Manages the execution context for the current thread. This class cannot be inherited.</summary>
	// Token: 0x020001D5 RID: 469
	[Serializable]
	public sealed class ExecutionContext : IDisposable, ISerializable
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x00046F2A File Offset: 0x0004512A
		// (set) Token: 0x0600111C RID: 4380 RVA: 0x00046F37 File Offset: 0x00045137
		internal bool isNewCapture
		{
			get
			{
				return (this._flags & (ExecutionContext.Flags)5) > ExecutionContext.Flags.None;
			}
			set
			{
				if (value)
				{
					this._flags |= ExecutionContext.Flags.IsNewCapture;
					return;
				}
				this._flags &= (ExecutionContext.Flags)(-2);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x00046F5A File Offset: 0x0004515A
		// (set) Token: 0x0600111E RID: 4382 RVA: 0x00046F67 File Offset: 0x00045167
		internal bool isFlowSuppressed
		{
			get
			{
				return (this._flags & ExecutionContext.Flags.IsFlowSuppressed) > ExecutionContext.Flags.None;
			}
			set
			{
				if (value)
				{
					this._flags |= ExecutionContext.Flags.IsFlowSuppressed;
					return;
				}
				this._flags &= (ExecutionContext.Flags)(-3);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x00046F8A File Offset: 0x0004518A
		internal bool IsPreAllocatedDefault
		{
			get
			{
				return (this._flags & ExecutionContext.Flags.IsPreAllocatedDefault) != ExecutionContext.Flags.None;
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00003ACD File Offset: 0x00001CCD
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal ExecutionContext()
		{
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00046F99 File Offset: 0x00045199
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal ExecutionContext(bool isPreAllocatedDefault)
		{
			if (isPreAllocatedDefault)
			{
				this._flags = ExecutionContext.Flags.IsPreAllocatedDefault;
			}
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00046FAC File Offset: 0x000451AC
		[SecurityCritical]
		[HandleProcessCorruptedStateExceptions]
		internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current)
		{
			List<IAsyncLocal> list = (previous == null) ? null : previous._localChangeNotifications;
			if (list != null)
			{
				foreach (IAsyncLocal asyncLocal in list)
				{
					object obj = null;
					if (previous != null && previous._localValues != null)
					{
						previous._localValues.TryGetValue(asyncLocal, out obj);
					}
					object obj2 = null;
					if (current != null && current._localValues != null)
					{
						current._localValues.TryGetValue(asyncLocal, out obj2);
					}
					if (obj != obj2)
					{
						asyncLocal.OnValueChanged(obj, obj2, true);
					}
				}
			}
			List<IAsyncLocal> list2 = (current == null) ? null : current._localChangeNotifications;
			if (list2 != null && list2 != list)
			{
				try
				{
					foreach (IAsyncLocal asyncLocal2 in list2)
					{
						object obj3 = null;
						if (previous == null || previous._localValues == null || !previous._localValues.TryGetValue(asyncLocal2, out obj3))
						{
							object obj4 = null;
							if (current != null && current._localValues != null)
							{
								current._localValues.TryGetValue(asyncLocal2, out obj4);
							}
							if (obj3 != obj4)
							{
								asyncLocal2.OnValueChanged(obj3, obj4, true);
							}
						}
					}
				}
				catch (Exception exception)
				{
					Environment.FailFast(Environment.GetResourceString("An exception was not handled in an AsyncLocal<T> notification callback."), exception);
				}
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x00047114 File Offset: 0x00045314
		// (set) Token: 0x06001124 RID: 4388 RVA: 0x0004712F File Offset: 0x0004532F
		internal LogicalCallContext LogicalCallContext
		{
			[SecurityCritical]
			get
			{
				if (this._logicalCallContext == null)
				{
					this._logicalCallContext = new LogicalCallContext();
				}
				return this._logicalCallContext;
			}
			[SecurityCritical]
			set
			{
				this._logicalCallContext = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x00047138 File Offset: 0x00045338
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x00047153 File Offset: 0x00045353
		internal IllogicalCallContext IllogicalCallContext
		{
			get
			{
				if (this._illogicalCallContext == null)
				{
					this._illogicalCallContext = new IllogicalCallContext();
				}
				return this._illogicalCallContext;
			}
			set
			{
				this._illogicalCallContext = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x0004715C File Offset: 0x0004535C
		// (set) Token: 0x06001128 RID: 4392 RVA: 0x00047164 File Offset: 0x00045364
		internal SynchronizationContext SynchronizationContext
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return this._syncContext;
			}
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			set
			{
				this._syncContext = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x0004716D File Offset: 0x0004536D
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x00047175 File Offset: 0x00045375
		internal SynchronizationContext SynchronizationContextNoFlow
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return this._syncContextNoFlow;
			}
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			set
			{
				this._syncContextNoFlow = value;
			}
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.ExecutionContext" /> class.</summary>
		// Token: 0x0600112B RID: 4395 RVA: 0x0004717E File Offset: 0x0004537E
		public void Dispose()
		{
			bool isPreAllocatedDefault = this.IsPreAllocatedDefault;
		}

		/// <summary>Runs a method in a specified execution context on the current thread.</summary>
		/// <param name="executionContext">The <see cref="T:System.Threading.ExecutionContext" /> to set.</param>
		/// <param name="callback">A <see cref="T:System.Threading.ContextCallback" /> delegate that represents the method to be run in the provided execution context.</param>
		/// <param name="state">The object to pass to the callback method.</param>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="executionContext" /> is <see langword="null" />.-or-
		///         <paramref name="executionContext" /> was not acquired through a capture operation. -or-
		///         <paramref name="executionContext" /> has already been used as the argument to a <see cref="M:System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext,System.Threading.ContextCallback,System.Object)" /> call.</exception>
		// Token: 0x0600112C RID: 4396 RVA: 0x00047187 File Offset: 0x00045387
		[SecurityCritical]
		public static void Run(ExecutionContext executionContext, ContextCallback callback, object state)
		{
			if (executionContext == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Cannot call Set on a null context"));
			}
			if (!executionContext.isNewCapture)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Cannot apply a context that has been marshaled across AppDomains, that was not acquired through a Capture operation or that has already been the argument to a Set call."));
			}
			ExecutionContext.Run(executionContext, callback, state, false);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x000471BD File Offset: 0x000453BD
		[SecurityCritical]
		[FriendAccessAllowed]
		internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx)
		{
			ExecutionContext.RunInternal(executionContext, callback, state, preserveSyncCtx);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x000471C8 File Offset: 0x000453C8
		internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state)
		{
			ExecutionContext.RunInternal(executionContext, callback, state, false);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x000471D4 File Offset: 0x000453D4
		[SecurityCritical]
		[HandleProcessCorruptedStateExceptions]
		internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx)
		{
			if (!executionContext.IsPreAllocatedDefault)
			{
				executionContext.isNewCapture = false;
			}
			Thread currentThread = Thread.CurrentThread;
			ExecutionContextSwitcher executionContextSwitcher = default(ExecutionContextSwitcher);
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				ExecutionContext.Reader executionContextReader = currentThread.GetExecutionContextReader();
				if ((executionContextReader.IsNull || executionContextReader.IsDefaultFTContext(preserveSyncCtx)) && executionContext.IsDefaultFTContext(preserveSyncCtx) && executionContextReader.HasSameLocalValues(executionContext))
				{
					ExecutionContext.EstablishCopyOnWriteScope(currentThread, true, ref executionContextSwitcher);
				}
				else
				{
					if (executionContext.IsPreAllocatedDefault)
					{
						executionContext = new ExecutionContext();
					}
					executionContextSwitcher = ExecutionContext.SetExecutionContext(executionContext, preserveSyncCtx);
				}
				callback(state);
			}
			finally
			{
				executionContextSwitcher.Undo();
			}
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00047274 File Offset: 0x00045474
		[SecurityCritical]
		internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw)
		{
			ExecutionContext.EstablishCopyOnWriteScope(Thread.CurrentThread, false, ref ecsw);
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00047282 File Offset: 0x00045482
		[SecurityCritical]
		private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw)
		{
			ecsw.outerEC = currentThread.GetExecutionContextReader();
			ecsw.outerECBelongsToScope = currentThread.ExecutionContextBelongsToCurrentScope;
			currentThread.ExecutionContextBelongsToCurrentScope = false;
			ecsw.thread = currentThread;
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x000472AC File Offset: 0x000454AC
		[SecurityCritical]
		[HandleProcessCorruptedStateExceptions]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx)
		{
			ExecutionContextSwitcher result = default(ExecutionContextSwitcher);
			Thread currentThread = Thread.CurrentThread;
			ExecutionContext.Reader executionContextReader = currentThread.GetExecutionContextReader();
			result.thread = currentThread;
			result.outerEC = executionContextReader;
			result.outerECBelongsToScope = currentThread.ExecutionContextBelongsToCurrentScope;
			if (preserveSyncCtx)
			{
				executionContext.SynchronizationContext = executionContextReader.SynchronizationContext;
			}
			executionContext.SynchronizationContextNoFlow = executionContextReader.SynchronizationContextNoFlow;
			currentThread.SetExecutionContext(executionContext, true);
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				ExecutionContext.OnAsyncLocalContextChanged(executionContextReader.DangerousGetRawExecutionContext(), executionContext);
			}
			catch
			{
				result.UndoNoThrow();
				throw;
			}
			return result;
		}

		/// <summary>Creates a copy of the current execution context.</summary>
		/// <returns>An <see cref="T:System.Threading.ExecutionContext" /> object representing the current execution context.</returns>
		/// <exception cref="T:System.InvalidOperationException">This context cannot be copied because it is used. Only newly captured contexts can be copied.</exception>
		// Token: 0x06001133 RID: 4403 RVA: 0x00047340 File Offset: 0x00045540
		[SecuritySafeCritical]
		public ExecutionContext CreateCopy()
		{
			if (!this.isNewCapture)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Only newly captured contexts can be copied"));
			}
			ExecutionContext executionContext = new ExecutionContext();
			executionContext.isNewCapture = true;
			executionContext._syncContext = ((this._syncContext == null) ? null : this._syncContext.CreateCopy());
			executionContext._localValues = this._localValues;
			executionContext._localChangeNotifications = this._localChangeNotifications;
			if (this._logicalCallContext != null)
			{
				executionContext.LogicalCallContext = (LogicalCallContext)this.LogicalCallContext.Clone();
			}
			return executionContext;
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x000473C8 File Offset: 0x000455C8
		[SecuritySafeCritical]
		internal ExecutionContext CreateMutableCopy()
		{
			ExecutionContext executionContext = new ExecutionContext();
			executionContext._syncContext = this._syncContext;
			executionContext._syncContextNoFlow = this._syncContextNoFlow;
			if (this._logicalCallContext != null)
			{
				executionContext.LogicalCallContext = (LogicalCallContext)this.LogicalCallContext.Clone();
			}
			if (this._illogicalCallContext != null)
			{
				executionContext.IllogicalCallContext = this.IllogicalCallContext.CreateCopy();
			}
			executionContext._localValues = this._localValues;
			executionContext._localChangeNotifications = this._localChangeNotifications;
			executionContext.isFlowSuppressed = this.isFlowSuppressed;
			return executionContext;
		}

		/// <summary>Indicates whether the flow of the execution context is currently suppressed.</summary>
		/// <returns>
		///     <see langword="true" /> if the flow is suppressed; otherwise, <see langword="false" />. </returns>
		// Token: 0x06001135 RID: 4405 RVA: 0x00047450 File Offset: 0x00045650
		public static bool IsFlowSuppressed()
		{
			return Thread.CurrentThread.GetExecutionContextReader().IsFlowSuppressed;
		}

		/// <summary>Captures the execution context from the current thread.</summary>
		/// <returns>An <see cref="T:System.Threading.ExecutionContext" /> object representing the execution context for the current thread.</returns>
		// Token: 0x06001136 RID: 4406 RVA: 0x00047470 File Offset: 0x00045670
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ExecutionContext Capture()
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ExecutionContext.Capture(ref stackCrawlMark, ExecutionContext.CaptureOptions.None);
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00047488 File Offset: 0x00045688
		[SecuritySafeCritical]
		[FriendAccessAllowed]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExecutionContext FastCapture()
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ExecutionContext.Capture(ref stackCrawlMark, ExecutionContext.CaptureOptions.IgnoreSyncCtx | ExecutionContext.CaptureOptions.OptimizeDefaultCase);
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x000474A0 File Offset: 0x000456A0
		[SecurityCritical]
		internal static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options)
		{
			ExecutionContext.Reader executionContextReader = Thread.CurrentThread.GetExecutionContextReader();
			if (executionContextReader.IsFlowSuppressed)
			{
				return null;
			}
			SynchronizationContext synchronizationContext = null;
			LogicalCallContext logicalCallContext = null;
			if (!executionContextReader.IsNull)
			{
				if ((options & ExecutionContext.CaptureOptions.IgnoreSyncCtx) == ExecutionContext.CaptureOptions.None)
				{
					synchronizationContext = ((executionContextReader.SynchronizationContext == null) ? null : executionContextReader.SynchronizationContext.CreateCopy());
				}
				if (executionContextReader.LogicalCallContext.HasInfo)
				{
					logicalCallContext = executionContextReader.LogicalCallContext.Clone();
				}
			}
			Dictionary<IAsyncLocal, object> dictionary = null;
			List<IAsyncLocal> list = null;
			if (!executionContextReader.IsNull)
			{
				dictionary = executionContextReader.DangerousGetRawExecutionContext()._localValues;
				list = executionContextReader.DangerousGetRawExecutionContext()._localChangeNotifications;
			}
			if ((options & ExecutionContext.CaptureOptions.OptimizeDefaultCase) != ExecutionContext.CaptureOptions.None && synchronizationContext == null && (logicalCallContext == null || !logicalCallContext.HasInfo) && dictionary == null && list == null)
			{
				return ExecutionContext.s_dummyDefaultEC;
			}
			return new ExecutionContext
			{
				_syncContext = synchronizationContext,
				LogicalCallContext = logicalCallContext,
				_localValues = dictionary,
				_localChangeNotifications = list,
				isNewCapture = true
			};
		}

		/// <summary>Sets the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the logical context information needed to recreate an instance of the current execution context.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to be populated with serialization information. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure representing the destination context of the serialization. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		// Token: 0x06001139 RID: 4409 RVA: 0x00047583 File Offset: 0x00045783
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			if (this._logicalCallContext != null)
			{
				info.AddValue("LogicalCallContext", this._logicalCallContext, typeof(LogicalCallContext));
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x000475B8 File Offset: 0x000457B8
		[SecurityCritical]
		private ExecutionContext(SerializationInfo info, StreamingContext context)
		{
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (enumerator.Name.Equals("LogicalCallContext"))
				{
					this._logicalCallContext = (LogicalCallContext)enumerator.Value;
				}
			}
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x000475FF File Offset: 0x000457FF
		[SecurityCritical]
		internal bool IsDefaultFTContext(bool ignoreSyncCtx)
		{
			return (ignoreSyncCtx || this._syncContext == null) && (this._logicalCallContext == null || !this._logicalCallContext.HasInfo) && (this._illogicalCallContext == null || !this._illogicalCallContext.HasUserData);
		}

		// Token: 0x0400069E RID: 1694
		private SynchronizationContext _syncContext;

		// Token: 0x0400069F RID: 1695
		private SynchronizationContext _syncContextNoFlow;

		// Token: 0x040006A0 RID: 1696
		[SecurityCritical]
		private LogicalCallContext _logicalCallContext;

		// Token: 0x040006A1 RID: 1697
		private IllogicalCallContext _illogicalCallContext;

		// Token: 0x040006A2 RID: 1698
		private ExecutionContext.Flags _flags;

		// Token: 0x040006A3 RID: 1699
		private Dictionary<IAsyncLocal, object> _localValues;

		// Token: 0x040006A4 RID: 1700
		private List<IAsyncLocal> _localChangeNotifications;

		// Token: 0x040006A5 RID: 1701
		private static readonly ExecutionContext s_dummyDefaultEC = new ExecutionContext(true);

		// Token: 0x040006A6 RID: 1702
		internal static readonly ExecutionContext Default = new ExecutionContext();

		// Token: 0x020001D6 RID: 470
		private enum Flags
		{
			// Token: 0x040006A8 RID: 1704
			None,
			// Token: 0x040006A9 RID: 1705
			IsNewCapture,
			// Token: 0x040006AA RID: 1706
			IsFlowSuppressed,
			// Token: 0x040006AB RID: 1707
			IsPreAllocatedDefault = 4
		}

		// Token: 0x020001D7 RID: 471
		internal struct Reader
		{
			// Token: 0x0600113D RID: 4413 RVA: 0x00047654 File Offset: 0x00045854
			public Reader(ExecutionContext ec)
			{
				this.m_ec = ec;
			}

			// Token: 0x0600113E RID: 4414 RVA: 0x0004765D File Offset: 0x0004585D
			public ExecutionContext DangerousGetRawExecutionContext()
			{
				return this.m_ec;
			}

			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x0600113F RID: 4415 RVA: 0x00047665 File Offset: 0x00045865
			public bool IsNull
			{
				get
				{
					return this.m_ec == null;
				}
			}

			// Token: 0x06001140 RID: 4416 RVA: 0x00047670 File Offset: 0x00045870
			[SecurityCritical]
			public bool IsDefaultFTContext(bool ignoreSyncCtx)
			{
				return this.m_ec.IsDefaultFTContext(ignoreSyncCtx);
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x06001141 RID: 4417 RVA: 0x0004767E File Offset: 0x0004587E
			public bool IsFlowSuppressed
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return !this.IsNull && this.m_ec.isFlowSuppressed;
				}
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x06001142 RID: 4418 RVA: 0x00047695 File Offset: 0x00045895
			public SynchronizationContext SynchronizationContext
			{
				get
				{
					if (!this.IsNull)
					{
						return this.m_ec.SynchronizationContext;
					}
					return null;
				}
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x06001143 RID: 4419 RVA: 0x000476AC File Offset: 0x000458AC
			public SynchronizationContext SynchronizationContextNoFlow
			{
				get
				{
					if (!this.IsNull)
					{
						return this.m_ec.SynchronizationContextNoFlow;
					}
					return null;
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x06001144 RID: 4420 RVA: 0x000476C3 File Offset: 0x000458C3
			public LogicalCallContext.Reader LogicalCallContext
			{
				[SecurityCritical]
				get
				{
					return new LogicalCallContext.Reader(this.IsNull ? null : this.m_ec.LogicalCallContext);
				}
			}

			// Token: 0x06001145 RID: 4421 RVA: 0x000476E0 File Offset: 0x000458E0
			[SecurityCritical]
			public bool HasSameLocalValues(ExecutionContext other)
			{
				Dictionary<IAsyncLocal, object> dictionary = this.IsNull ? null : this.m_ec._localValues;
				Dictionary<IAsyncLocal, object> dictionary2 = (other == null) ? null : other._localValues;
				return dictionary == dictionary2;
			}

			// Token: 0x040006AC RID: 1708
			private ExecutionContext m_ec;
		}

		// Token: 0x020001D8 RID: 472
		[Flags]
		internal enum CaptureOptions
		{
			// Token: 0x040006AE RID: 1710
			None = 0,
			// Token: 0x040006AF RID: 1711
			IgnoreSyncCtx = 1,
			// Token: 0x040006B0 RID: 1712
			OptimizeDefaultCase = 2
		}
	}
}
