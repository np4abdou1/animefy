using System;
using System.Diagnostics;

namespace System.Threading
{
	/// <summary>Provides a slimmed down version of <see cref="T:System.Threading.ManualResetEvent" />.</summary>
	// Token: 0x020001B5 RID: 437
	[DebuggerDisplay("Set = {IsSet}")]
	public class ManualResetEventSlim : IDisposable
	{
		/// <summary>Gets the underlying <see cref="T:System.Threading.WaitHandle" /> object for this <see cref="T:System.Threading.ManualResetEventSlim" />.</summary>
		/// <returns>The underlying <see cref="T:System.Threading.WaitHandle" /> event object fore this <see cref="T:System.Threading.ManualResetEventSlim" />.</returns>
		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x00044519 File Offset: 0x00042719
		public WaitHandle WaitHandle
		{
			get
			{
				this.ThrowIfDisposed();
				if (this.m_eventObj == null)
				{
					this.LazyInitializeEvent();
				}
				return this.m_eventObj;
			}
		}

		/// <summary>Gets whether the event is set.</summary>
		/// <returns>true if the event has is set; otherwise, false.</returns>
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x0004453A File Offset: 0x0004273A
		// (set) Token: 0x0600107C RID: 4220 RVA: 0x00044551 File Offset: 0x00042751
		public bool IsSet
		{
			get
			{
				return ManualResetEventSlim.ExtractStatePortion(this.m_combinedState, int.MinValue) != 0;
			}
			private set
			{
				this.UpdateStateAtomically((value ? 1 : 0) << 31, int.MinValue);
			}
		}

		/// <summary>Gets the number of spin waits that will occur before falling back to a kernel-based wait operation.</summary>
		/// <returns>Returns the number of spin waits that will occur before falling back to a kernel-based wait operation.</returns>
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x00044568 File Offset: 0x00042768
		// (set) Token: 0x0600107E RID: 4222 RVA: 0x0004457E File Offset: 0x0004277E
		public int SpinCount
		{
			get
			{
				return ManualResetEventSlim.ExtractStatePortionAndShiftRight(this.m_combinedState, 1073217536, 19);
			}
			private set
			{
				this.m_combinedState = ((this.m_combinedState & -1073217537) | value << 19);
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x0004459B File Offset: 0x0004279B
		// (set) Token: 0x06001080 RID: 4224 RVA: 0x000445B0 File Offset: 0x000427B0
		private int Waiters
		{
			get
			{
				return ManualResetEventSlim.ExtractStatePortionAndShiftRight(this.m_combinedState, 524287, 0);
			}
			set
			{
				if (value >= 524287)
				{
					throw new InvalidOperationException(string.Format("There are too many threads currently waiting on the event. A maximum of {0} waiting threads are supported.", 524287));
				}
				this.UpdateStateAtomically(value, 524287);
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ManualResetEventSlim" /> class with a Boolean value indicating whether to set the intial state to signaled.</summary>
		/// <param name="initialState">true to set the initial state signaled; false to set the initial state to nonsignaled.</param>
		// Token: 0x06001081 RID: 4225 RVA: 0x000445E0 File Offset: 0x000427E0
		public ManualResetEventSlim(bool initialState)
		{
			this.Initialize(initialState, SpinWait.SpinCountforSpinBeforeWait);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ManualResetEventSlim" /> class with a Boolean value indicating whether to set the intial state to signaled and a specified spin count.</summary>
		/// <param name="initialState">true to set the initial state to signaled; false to set the initial state to nonsignaled.</param>
		/// <param name="spinCount">The number of spin waits that will occur before falling back to a kernel-based wait operation.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="spinCount" /> is less than 0 or greater than the maximum allowed value.</exception>
		// Token: 0x06001082 RID: 4226 RVA: 0x000445F4 File Offset: 0x000427F4
		public ManualResetEventSlim(bool initialState, int spinCount)
		{
			if (spinCount < 0)
			{
				throw new ArgumentOutOfRangeException("spinCount");
			}
			if (spinCount > 2047)
			{
				throw new ArgumentOutOfRangeException("spinCount", string.Format("The spinCount argument must be in the range 0 to {0}, inclusive.", 2047));
			}
			this.Initialize(initialState, spinCount);
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00044645 File Offset: 0x00042845
		private void Initialize(bool initialState, int spinCount)
		{
			this.m_combinedState = (initialState ? int.MinValue : 0);
			this.SpinCount = (PlatformHelper.IsSingleProcessor ? 1 : spinCount);
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0004466C File Offset: 0x0004286C
		private void EnsureLockObjectCreated()
		{
			if (this.m_lock != null)
			{
				return;
			}
			object value = new object();
			Interlocked.CompareExchange(ref this.m_lock, value, null);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00044698 File Offset: 0x00042898
		private bool LazyInitializeEvent()
		{
			bool isSet = this.IsSet;
			ManualResetEvent manualResetEvent = new ManualResetEvent(isSet);
			if (Interlocked.CompareExchange<ManualResetEvent>(ref this.m_eventObj, manualResetEvent, null) != null)
			{
				manualResetEvent.Dispose();
				return false;
			}
			if (this.IsSet != isSet)
			{
				ManualResetEvent obj = manualResetEvent;
				lock (obj)
				{
					if (this.m_eventObj == manualResetEvent)
					{
						manualResetEvent.Set();
					}
				}
			}
			return true;
		}

		/// <summary>Sets the state of the event to signaled, which allows one or more threads waiting on the event to proceed.</summary>
		// Token: 0x06001086 RID: 4230 RVA: 0x00044710 File Offset: 0x00042910
		public void Set()
		{
			this.Set(false);
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0004471C File Offset: 0x0004291C
		private void Set(bool duringCancellation)
		{
			this.IsSet = true;
			if (this.Waiters > 0)
			{
				object @lock = this.m_lock;
				lock (@lock)
				{
					Monitor.PulseAll(this.m_lock);
				}
			}
			ManualResetEvent eventObj = this.m_eventObj;
			if (eventObj != null && !duringCancellation)
			{
				ManualResetEvent obj = eventObj;
				lock (obj)
				{
					if (this.m_eventObj != null)
					{
						this.m_eventObj.Set();
					}
				}
			}
		}

		/// <summary>Blocks the current thread until the current <see cref="T:System.Threading.ManualResetEventSlim" /> is set, using a 32-bit signed integer to measure the time interval, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" />(-1) to wait indefinitely.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Threading.ManualResetEventSlim" /> was set; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.OperationCanceledException">
		///         <paramref name="cancellationToken" /> was canceled.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.InvalidOperationException">The maximum number of waiters has been exceeded.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed or the <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has been disposed.</exception>
		// Token: 0x06001088 RID: 4232 RVA: 0x000447C0 File Offset: 0x000429C0
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			this.ThrowIfDisposed();
			cancellationToken.ThrowIfCancellationRequested();
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout");
			}
			if (!this.IsSet)
			{
				if (millisecondsTimeout == 0)
				{
					return false;
				}
				uint startTime = 0U;
				bool flag = false;
				int num = millisecondsTimeout;
				if (millisecondsTimeout != -1)
				{
					startTime = TimeoutHelper.GetTime();
					flag = true;
				}
				int spinCount = this.SpinCount;
				SpinWait spinWait = default(SpinWait);
				while (spinWait.Count < spinCount)
				{
					spinWait.SpinOnce(40);
					if (this.IsSet)
					{
						return true;
					}
					if (spinWait.Count >= 100 && spinWait.Count % 10 == 0)
					{
						cancellationToken.ThrowIfCancellationRequested();
					}
				}
				this.EnsureLockObjectCreated();
				using (cancellationToken.InternalRegisterWithoutEC(ManualResetEventSlim.s_cancellationTokenCallback, this))
				{
					object @lock = this.m_lock;
					lock (@lock)
					{
						while (!this.IsSet)
						{
							cancellationToken.ThrowIfCancellationRequested();
							if (flag)
							{
								num = TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout);
								if (num <= 0)
								{
									return false;
								}
							}
							this.Waiters++;
							if (this.IsSet)
							{
								int waiters = this.Waiters;
								this.Waiters = waiters - 1;
								return true;
							}
							try
							{
								if (!Monitor.Wait(this.m_lock, num))
								{
									return false;
								}
							}
							finally
							{
								this.Waiters--;
							}
						}
					}
				}
				return true;
			}
			return true;
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.ManualResetEventSlim" /> class.</summary>
		// Token: 0x06001089 RID: 4233 RVA: 0x00044944 File Offset: 0x00042B44
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Threading.ManualResetEventSlim" />, and optionally releases the managed resources.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
		// Token: 0x0600108A RID: 4234 RVA: 0x00044954 File Offset: 0x00042B54
		protected virtual void Dispose(bool disposing)
		{
			if ((this.m_combinedState & 1073741824) != 0)
			{
				return;
			}
			this.m_combinedState |= 1073741824;
			if (disposing)
			{
				ManualResetEvent eventObj = this.m_eventObj;
				if (eventObj != null)
				{
					ManualResetEvent obj = eventObj;
					lock (obj)
					{
						eventObj.Dispose();
						this.m_eventObj = null;
					}
				}
			}
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x000449D0 File Offset: 0x00042BD0
		private void ThrowIfDisposed()
		{
			if ((this.m_combinedState & 1073741824) != 0)
			{
				throw new ObjectDisposedException("The event has been disposed.");
			}
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x000449F0 File Offset: 0x00042BF0
		private static void CancellationTokenCallback(object obj)
		{
			ManualResetEventSlim manualResetEventSlim = obj as ManualResetEventSlim;
			object @lock = manualResetEventSlim.m_lock;
			lock (@lock)
			{
				Monitor.PulseAll(manualResetEventSlim.m_lock);
			}
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x00044A40 File Offset: 0x00042C40
		private void UpdateStateAtomically(int newBits, int updateBitsMask)
		{
			SpinWait spinWait = default(SpinWait);
			for (;;)
			{
				int combinedState = this.m_combinedState;
				int value = (combinedState & ~updateBitsMask) | newBits;
				if (Interlocked.CompareExchange(ref this.m_combinedState, value, combinedState) == combinedState)
				{
					break;
				}
				spinWait.SpinOnce();
			}
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00044A7E File Offset: 0x00042C7E
		private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount)
		{
			return (int)((uint)(state & mask) >> rightBitShiftCount);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00044A88 File Offset: 0x00042C88
		private static int ExtractStatePortion(int state, int mask)
		{
			return state & mask;
		}

		// Token: 0x04000644 RID: 1604
		private volatile object m_lock;

		// Token: 0x04000645 RID: 1605
		private volatile ManualResetEvent m_eventObj;

		// Token: 0x04000646 RID: 1606
		private volatile int m_combinedState;

		// Token: 0x04000647 RID: 1607
		private static Action<object> s_cancellationTokenCallback = new Action<object>(ManualResetEventSlim.CancellationTokenCallback);
	}
}
