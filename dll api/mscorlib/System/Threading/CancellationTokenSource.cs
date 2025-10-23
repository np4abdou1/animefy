using System;
using System.Collections.Generic;

namespace System.Threading
{
	/// <summary>Signals to a <see cref="T:System.Threading.CancellationToken" /> that it should be canceled.</summary>
	// Token: 0x020001BA RID: 442
	public class CancellationTokenSource : IDisposable
	{
		/// <summary>Gets whether cancellation has been requested for this <see cref="T:System.Threading.CancellationTokenSource" />.</summary>
		/// <returns>
		///     <see langword="true" /> if cancellation has been requested for this <see cref="T:System.Threading.CancellationTokenSource" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x00044DEE File Offset: 0x00042FEE
		public bool IsCancellationRequested
		{
			get
			{
				return this._state >= 2;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x00044DFE File Offset: 0x00042FFE
		internal bool IsCancellationCompleted
		{
			get
			{
				return this._state == 3;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00044E0B File Offset: 0x0004300B
		internal bool IsDisposed
		{
			get
			{
				return this._disposed;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x00044E13 File Offset: 0x00043013
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x00044E1D File Offset: 0x0004301D
		internal int ThreadIDExecutingCallbacks
		{
			get
			{
				return this._threadIDExecutingCallbacks;
			}
			set
			{
				this._threadIDExecutingCallbacks = value;
			}
		}

		/// <summary>Gets the <see cref="T:System.Threading.CancellationToken" /> associated with this <see cref="T:System.Threading.CancellationTokenSource" />.</summary>
		/// <returns>The <see cref="T:System.Threading.CancellationToken" /> associated with this <see cref="T:System.Threading.CancellationTokenSource" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The token source has been disposed.</exception>
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x00044E28 File Offset: 0x00043028
		public CancellationToken Token
		{
			get
			{
				this.ThrowIfDisposed();
				return new CancellationToken(this);
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x00044E36 File Offset: 0x00043036
		internal CancellationCallbackInfo ExecutingCallback
		{
			get
			{
				return this._executingCallback;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.CancellationTokenSource" /> class.</summary>
		// Token: 0x060010A8 RID: 4264 RVA: 0x00044E40 File Offset: 0x00043040
		public CancellationTokenSource()
		{
			this._state = 1;
		}

		/// <summary>Communicates a request for cancellation.</summary>
		/// <exception cref="T:System.ObjectDisposedException">This <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
		/// <exception cref="T:System.AggregateException">An aggregate exception containing all the exceptions thrown by the registered callbacks on the associated <see cref="T:System.Threading.CancellationToken" />.</exception>
		// Token: 0x060010A9 RID: 4265 RVA: 0x00044E5A File Offset: 0x0004305A
		public void Cancel()
		{
			this.Cancel(false);
		}

		/// <summary>Communicates a request for cancellation, and specifies whether remaining callbacks and cancelable operations should be processed.</summary>
		/// <param name="throwOnFirstException">
		///       <see langword="true" /> if exceptions should immediately propagate; otherwise, <see langword="false" />.</param>
		/// <exception cref="T:System.ObjectDisposedException">This <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
		/// <exception cref="T:System.AggregateException">An aggregate exception containing all the exceptions thrown by the registered callbacks on the associated <see cref="T:System.Threading.CancellationToken" />.</exception>
		// Token: 0x060010AA RID: 4266 RVA: 0x00044E63 File Offset: 0x00043063
		public void Cancel(bool throwOnFirstException)
		{
			this.ThrowIfDisposed();
			this.NotifyCancellation(throwOnFirstException);
		}

		/// <summary>Schedules a cancel operation on this <see cref="T:System.Threading.CancellationTokenSource" /> after the specified number of milliseconds.</summary>
		/// <param name="millisecondsDelay">The time span to wait before canceling this <see cref="T:System.Threading.CancellationTokenSource" />.</param>
		/// <exception cref="T:System.ObjectDisposedException">The exception thrown when this <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception thrown when <paramref name="millisecondsDelay" /> is less than -1.</exception>
		// Token: 0x060010AB RID: 4267 RVA: 0x00044E74 File Offset: 0x00043074
		public void CancelAfter(int millisecondsDelay)
		{
			this.ThrowIfDisposed();
			if (millisecondsDelay < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsDelay");
			}
			if (this.IsCancellationRequested)
			{
				return;
			}
			if (this._timer == null)
			{
				Timer timer = new Timer(CancellationTokenSource.s_timerCallback, this, -1, -1);
				if (Interlocked.CompareExchange<Timer>(ref this._timer, timer, null) != null)
				{
					timer.Dispose();
				}
			}
			try
			{
				this._timer.Change(millisecondsDelay, -1);
			}
			catch (ObjectDisposedException)
			{
			}
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00044EF4 File Offset: 0x000430F4
		private static void TimerCallbackLogic(object obj)
		{
			CancellationTokenSource cancellationTokenSource = (CancellationTokenSource)obj;
			if (!cancellationTokenSource.IsDisposed)
			{
				try
				{
					cancellationTokenSource.Cancel();
				}
				catch (ObjectDisposedException)
				{
					if (!cancellationTokenSource.IsDisposed)
					{
						throw;
					}
				}
			}
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.CancellationTokenSource" /> class.</summary>
		// Token: 0x060010AD RID: 4269 RVA: 0x00044F38 File Offset: 0x00043138
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Threading.CancellationTokenSource" /> class and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
		// Token: 0x060010AE RID: 4270 RVA: 0x00044F48 File Offset: 0x00043148
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && !this._disposed)
			{
				Timer timer = this._timer;
				if (timer != null)
				{
					timer.Dispose();
				}
				this._registeredCallbacksLists = null;
				if (this._kernelEvent != null)
				{
					ManualResetEvent manualResetEvent = Interlocked.Exchange<ManualResetEvent>(ref this._kernelEvent, null);
					if (manualResetEvent != null && this._state != 2)
					{
						manualResetEvent.Dispose();
					}
				}
				this._disposed = true;
			}
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00044FAE File Offset: 0x000431AE
		internal void ThrowIfDisposed()
		{
			if (this._disposed)
			{
				CancellationTokenSource.ThrowObjectDisposedException();
			}
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00044FBD File Offset: 0x000431BD
		private static void ThrowObjectDisposedException()
		{
			throw new ObjectDisposedException(null, "The CancellationTokenSource has been disposed.");
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00044FCC File Offset: 0x000431CC
		internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext)
		{
			if (!this.IsCancellationRequested)
			{
				if (this._disposed)
				{
					return default(CancellationTokenRegistration);
				}
				int num = Environment.CurrentManagedThreadId % CancellationTokenSource.s_nLists;
				CancellationCallbackInfo cancellationCallbackInfo = (targetSyncContext != null) ? new CancellationCallbackInfo.WithSyncContext(callback, stateForCallback, executionContext, this, targetSyncContext) : new CancellationCallbackInfo(callback, stateForCallback, executionContext, this);
				SparselyPopulatedArray<CancellationCallbackInfo>[] array = this._registeredCallbacksLists;
				if (array == null)
				{
					SparselyPopulatedArray<CancellationCallbackInfo>[] array2 = new SparselyPopulatedArray<CancellationCallbackInfo>[CancellationTokenSource.s_nLists];
					array = Interlocked.CompareExchange<SparselyPopulatedArray<CancellationCallbackInfo>[]>(ref this._registeredCallbacksLists, array2, null);
					if (array == null)
					{
						array = array2;
					}
				}
				SparselyPopulatedArray<CancellationCallbackInfo> sparselyPopulatedArray = Volatile.Read<SparselyPopulatedArray<CancellationCallbackInfo>>(ref array[num]);
				if (sparselyPopulatedArray == null)
				{
					SparselyPopulatedArray<CancellationCallbackInfo> value = new SparselyPopulatedArray<CancellationCallbackInfo>(4);
					Interlocked.CompareExchange<SparselyPopulatedArray<CancellationCallbackInfo>>(ref array[num], value, null);
					sparselyPopulatedArray = array[num];
				}
				SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo = sparselyPopulatedArray.Add(cancellationCallbackInfo);
				CancellationTokenRegistration result = new CancellationTokenRegistration(cancellationCallbackInfo, registrationInfo);
				if (!this.IsCancellationRequested)
				{
					return result;
				}
				if (!result.Unregister())
				{
					return result;
				}
			}
			callback(stateForCallback);
			return default(CancellationTokenRegistration);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x000450B4 File Offset: 0x000432B4
		private void NotifyCancellation(bool throwOnFirstException)
		{
			if (!this.IsCancellationRequested && Interlocked.CompareExchange(ref this._state, 2, 1) == 1)
			{
				Timer timer = this._timer;
				if (timer != null)
				{
					timer.Dispose();
				}
				this.ThreadIDExecutingCallbacks = Environment.CurrentManagedThreadId;
				ManualResetEvent kernelEvent = this._kernelEvent;
				if (kernelEvent != null)
				{
					kernelEvent.Set();
				}
				this.ExecuteCallbackHandlers(throwOnFirstException);
			}
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00045114 File Offset: 0x00043314
		private void ExecuteCallbackHandlers(bool throwOnFirstException)
		{
			LowLevelListWithIList<Exception> lowLevelListWithIList = null;
			SparselyPopulatedArray<CancellationCallbackInfo>[] registeredCallbacksLists = this._registeredCallbacksLists;
			if (registeredCallbacksLists == null)
			{
				Interlocked.Exchange(ref this._state, 3);
				return;
			}
			try
			{
				for (int i = 0; i < registeredCallbacksLists.Length; i++)
				{
					SparselyPopulatedArray<CancellationCallbackInfo> sparselyPopulatedArray = Volatile.Read<SparselyPopulatedArray<CancellationCallbackInfo>>(ref registeredCallbacksLists[i]);
					if (sparselyPopulatedArray != null)
					{
						for (SparselyPopulatedArrayFragment<CancellationCallbackInfo> sparselyPopulatedArrayFragment = sparselyPopulatedArray.Tail; sparselyPopulatedArrayFragment != null; sparselyPopulatedArrayFragment = sparselyPopulatedArrayFragment.Prev)
						{
							for (int j = sparselyPopulatedArrayFragment.Length - 1; j >= 0; j--)
							{
								this._executingCallback = sparselyPopulatedArrayFragment[j];
								if (this._executingCallback != null)
								{
									CancellationCallbackCoreWorkArguments cancellationCallbackCoreWorkArguments = new CancellationCallbackCoreWorkArguments(sparselyPopulatedArrayFragment, j);
									try
									{
										CancellationCallbackInfo.WithSyncContext withSyncContext = this._executingCallback as CancellationCallbackInfo.WithSyncContext;
										if (withSyncContext != null)
										{
											withSyncContext.TargetSyncContext.Send(new SendOrPostCallback(this.CancellationCallbackCoreWork_OnSyncContext), cancellationCallbackCoreWorkArguments);
											this.ThreadIDExecutingCallbacks = Environment.CurrentManagedThreadId;
										}
										else
										{
											this.CancellationCallbackCoreWork(cancellationCallbackCoreWorkArguments);
										}
									}
									catch (Exception item)
									{
										if (throwOnFirstException)
										{
											throw;
										}
										if (lowLevelListWithIList == null)
										{
											lowLevelListWithIList = new LowLevelListWithIList<Exception>();
										}
										lowLevelListWithIList.Add(item);
									}
								}
							}
						}
					}
				}
			}
			finally
			{
				this._state = 3;
				this._executingCallback = null;
				Interlocked.MemoryBarrier();
			}
			if (lowLevelListWithIList != null)
			{
				throw new AggregateException(lowLevelListWithIList);
			}
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0004526C File Offset: 0x0004346C
		private void CancellationCallbackCoreWork_OnSyncContext(object obj)
		{
			this.CancellationCallbackCoreWork((CancellationCallbackCoreWorkArguments)obj);
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0004527C File Offset: 0x0004347C
		private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args)
		{
			CancellationCallbackInfo cancellationCallbackInfo = args._currArrayFragment.SafeAtomicRemove(args._currArrayIndex, this._executingCallback);
			if (cancellationCallbackInfo == this._executingCallback)
			{
				cancellationCallbackInfo.CancellationTokenSource.ThreadIDExecutingCallbacks = Environment.CurrentManagedThreadId;
				cancellationCallbackInfo.ExecuteCallback();
			}
		}

		/// <summary>Creates a <see cref="T:System.Threading.CancellationTokenSource" /> that will be in the canceled state when any of the source tokens are in the canceled state.</summary>
		/// <param name="token1">The first cancellation token to observe.</param>
		/// <param name="token2">The second cancellation token to observe.</param>
		/// <returns>A <see cref="T:System.Threading.CancellationTokenSource" /> that is linked to the source tokens.</returns>
		/// <exception cref="T:System.ObjectDisposedException">A <see cref="T:System.Threading.CancellationTokenSource" /> associated with one of the source tokens has been disposed.</exception>
		// Token: 0x060010B6 RID: 4278 RVA: 0x000452C4 File Offset: 0x000434C4
		public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2)
		{
			if (!token1.CanBeCanceled)
			{
				return CancellationTokenSource.CreateLinkedTokenSource(token2);
			}
			if (!token2.CanBeCanceled)
			{
				return new CancellationTokenSource.Linked1CancellationTokenSource(token1);
			}
			return new CancellationTokenSource.Linked2CancellationTokenSource(token1, token2);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x000452ED File Offset: 0x000434ED
		internal static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token)
		{
			if (!token.CanBeCanceled)
			{
				return new CancellationTokenSource();
			}
			return new CancellationTokenSource.Linked1CancellationTokenSource(token);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00045304 File Offset: 0x00043504
		internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo)
		{
			SpinWait spinWait = default(SpinWait);
			while (this.ExecutingCallback == callbackInfo)
			{
				spinWait.SpinOnce();
			}
		}

		// Token: 0x0400064F RID: 1615
		internal static readonly CancellationTokenSource s_canceledSource = new CancellationTokenSource
		{
			_state = 3
		};

		// Token: 0x04000650 RID: 1616
		internal static readonly CancellationTokenSource s_neverCanceledSource = new CancellationTokenSource
		{
			_state = 0
		};

		// Token: 0x04000651 RID: 1617
		private static readonly int s_nLists = (PlatformHelper.ProcessorCount > 24) ? 24 : PlatformHelper.ProcessorCount;

		// Token: 0x04000652 RID: 1618
		private volatile ManualResetEvent _kernelEvent;

		// Token: 0x04000653 RID: 1619
		private volatile SparselyPopulatedArray<CancellationCallbackInfo>[] _registeredCallbacksLists;

		// Token: 0x04000654 RID: 1620
		private volatile int _state;

		// Token: 0x04000655 RID: 1621
		private volatile int _threadIDExecutingCallbacks = -1;

		// Token: 0x04000656 RID: 1622
		private bool _disposed;

		// Token: 0x04000657 RID: 1623
		private volatile CancellationCallbackInfo _executingCallback;

		// Token: 0x04000658 RID: 1624
		private volatile Timer _timer;

		// Token: 0x04000659 RID: 1625
		private static readonly TimerCallback s_timerCallback = new TimerCallback(CancellationTokenSource.TimerCallbackLogic);

		// Token: 0x020001BB RID: 443
		private sealed class Linked1CancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x060010BA RID: 4282 RVA: 0x00045387 File Offset: 0x00043587
			internal Linked1CancellationTokenSource(CancellationToken token1)
			{
				this._reg1 = token1.InternalRegisterWithoutEC(CancellationTokenSource.LinkedNCancellationTokenSource.s_linkedTokenCancelDelegate, this);
			}

			// Token: 0x060010BB RID: 4283 RVA: 0x000453A2 File Offset: 0x000435A2
			protected override void Dispose(bool disposing)
			{
				if (!disposing || this._disposed)
				{
					return;
				}
				this._reg1.Dispose();
				base.Dispose(disposing);
			}

			// Token: 0x0400065A RID: 1626
			private readonly CancellationTokenRegistration _reg1;
		}

		// Token: 0x020001BC RID: 444
		private sealed class Linked2CancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x060010BC RID: 4284 RVA: 0x000453C2 File Offset: 0x000435C2
			internal Linked2CancellationTokenSource(CancellationToken token1, CancellationToken token2)
			{
				this._reg1 = token1.InternalRegisterWithoutEC(CancellationTokenSource.LinkedNCancellationTokenSource.s_linkedTokenCancelDelegate, this);
				this._reg2 = token2.InternalRegisterWithoutEC(CancellationTokenSource.LinkedNCancellationTokenSource.s_linkedTokenCancelDelegate, this);
			}

			// Token: 0x060010BD RID: 4285 RVA: 0x000453F0 File Offset: 0x000435F0
			protected override void Dispose(bool disposing)
			{
				if (!disposing || this._disposed)
				{
					return;
				}
				this._reg1.Dispose();
				this._reg2.Dispose();
				base.Dispose(disposing);
			}

			// Token: 0x0400065B RID: 1627
			private readonly CancellationTokenRegistration _reg1;

			// Token: 0x0400065C RID: 1628
			private readonly CancellationTokenRegistration _reg2;
		}

		// Token: 0x020001BD RID: 445
		private sealed class LinkedNCancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x0400065D RID: 1629
			internal static readonly Action<object> s_linkedTokenCancelDelegate = delegate(object s)
			{
				((CancellationTokenSource)s).NotifyCancellation(false);
			};
		}
	}
}
