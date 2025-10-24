using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading
{
	/// <summary>Provides a mutual exclusion lock primitive where a thread trying to acquire the lock waits in a loop repeatedly checking until the lock becomes available.</summary>
	// Token: 0x020001CA RID: 458
	[ComVisible(false)]
	[DebuggerTypeProxy(typeof(SpinLock.SystemThreading_SpinLockDebugView))]
	[DebuggerDisplay("IsHeld = {IsHeld}")]
	public struct SpinLock
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.SpinLock" /> structure with the option to track thread IDs to improve debugging.</summary>
		/// <param name="enableThreadOwnerTracking">Whether to capture and use thread IDs for debugging purposes.</param>
		// Token: 0x060010EF RID: 4335 RVA: 0x00046136 File Offset: 0x00044336
		public SpinLock(bool enableThreadOwnerTracking)
		{
			this.m_owner = 0;
			if (!enableThreadOwnerTracking)
			{
				this.m_owner |= int.MinValue;
			}
		}

		/// <summary>Acquires the lock in a reliable manner, such that even if an exception occurs within the method call, <paramref name="lockTaken" /> can be examined reliably to determine whether the lock was acquired.</summary>
		/// <param name="lockTaken">True if the lock is acquired; otherwise, false. <paramref name="lockTaken" /> must be initialized to false prior to calling this method.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="lockTaken" /> argument must be initialized to false prior to calling Enter.</exception>
		/// <exception cref="T:System.Threading.LockRecursionException">Thread ownership tracking is enabled, and the current thread has already acquired this lock.</exception>
		// Token: 0x060010F0 RID: 4336 RVA: 0x0004615C File Offset: 0x0004435C
		public void Enter(ref bool lockTaken)
		{
			Thread.BeginCriticalRegion();
			int owner = this.m_owner;
			if (lockTaken || (owner & -2147483647) != -2147483648 || Interlocked.CompareExchange(ref this.m_owner, owner | 1, owner, ref lockTaken) != owner)
			{
				this.ContinueTryEnter(-1, ref lockTaken);
			}
		}

		/// <summary>Attempts to acquire the lock in a reliable manner, such that even if an exception occurs within the method call, <paramref name="lockTaken" /> can be examined reliably to determine whether the lock was acquired.</summary>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <param name="lockTaken">True if the lock is acquired; otherwise, false. <paramref name="lockTaken" /> must be initialized to false prior to calling this method.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="lockTaken" /> argument must be initialized to false prior to calling TryEnter.</exception>
		/// <exception cref="T:System.Threading.LockRecursionException">Thread ownership tracking is enabled, and the current thread has already acquired this lock.</exception>
		// Token: 0x060010F1 RID: 4337 RVA: 0x000461A4 File Offset: 0x000443A4
		public void TryEnter(int millisecondsTimeout, ref bool lockTaken)
		{
			Thread.BeginCriticalRegion();
			int owner = this.m_owner;
			if ((millisecondsTimeout < -1 | lockTaken) || (owner & -2147483647) != -2147483648 || Interlocked.CompareExchange(ref this.m_owner, owner | 1, owner, ref lockTaken) != owner)
			{
				this.ContinueTryEnter(millisecondsTimeout, ref lockTaken);
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x000461F4 File Offset: 0x000443F4
		private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken)
		{
			Thread.EndCriticalRegion();
			if (lockTaken)
			{
				lockTaken = false;
				throw new ArgumentException(Environment.GetResourceString("The tookLock argument must be set to false before calling this method."));
			}
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", millisecondsTimeout, Environment.GetResourceString("The timeout must be a value between -1 and Int32.MaxValue, inclusive."));
			}
			uint startTime = 0U;
			if (millisecondsTimeout != -1 && millisecondsTimeout != 0)
			{
				startTime = TimeoutHelper.GetTime();
			}
			if (this.IsThreadOwnerTrackingEnabled)
			{
				this.ContinueTryEnterWithThreadTracking(millisecondsTimeout, startTime, ref lockTaken);
				return;
			}
			int num = int.MaxValue;
			int owner = this.m_owner;
			if ((owner & 1) == 0)
			{
				Thread.BeginCriticalRegion();
				if (Interlocked.CompareExchange(ref this.m_owner, owner | 1, owner, ref lockTaken) == owner)
				{
					return;
				}
				Thread.EndCriticalRegion();
			}
			else if ((owner & 2147483646) != SpinLock.MAXIMUM_WAITERS)
			{
				num = (Interlocked.Add(ref this.m_owner, 2) & 2147483646) >> 1;
			}
			if (millisecondsTimeout == 0 || (millisecondsTimeout != -1 && TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout) <= 0))
			{
				this.DecrementWaiters();
				return;
			}
			int processorCount = PlatformHelper.ProcessorCount;
			if (num < processorCount)
			{
				int num2 = 1;
				for (int i = 1; i <= num * 100; i++)
				{
					Thread.SpinWait((num + i) * 100 * num2);
					if (num2 < processorCount)
					{
						num2++;
					}
					owner = this.m_owner;
					if ((owner & 1) == 0)
					{
						Thread.BeginCriticalRegion();
						int value = ((owner & 2147483646) == 0) ? (owner | 1) : (owner - 2 | 1);
						if (Interlocked.CompareExchange(ref this.m_owner, value, owner, ref lockTaken) == owner)
						{
							return;
						}
						Thread.EndCriticalRegion();
					}
				}
			}
			if (millisecondsTimeout != -1 && TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout) <= 0)
			{
				this.DecrementWaiters();
				return;
			}
			int num3 = 0;
			for (;;)
			{
				owner = this.m_owner;
				if ((owner & 1) == 0)
				{
					Thread.BeginCriticalRegion();
					int value2 = ((owner & 2147483646) == 0) ? (owner | 1) : (owner - 2 | 1);
					if (Interlocked.CompareExchange(ref this.m_owner, value2, owner, ref lockTaken) == owner)
					{
						break;
					}
					Thread.EndCriticalRegion();
				}
				if (num3 % 40 == 0)
				{
					Thread.Sleep(1);
				}
				else if (num3 % 10 == 0)
				{
					Thread.Sleep(0);
				}
				else
				{
					Thread.Yield();
				}
				if (num3 % 10 == 0 && millisecondsTimeout != -1 && TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout) <= 0)
				{
					goto Block_25;
				}
				num3++;
			}
			return;
			Block_25:
			this.DecrementWaiters();
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x000463E8 File Offset: 0x000445E8
		private void DecrementWaiters()
		{
			SpinWait spinWait = default(SpinWait);
			for (;;)
			{
				int owner = this.m_owner;
				if ((owner & 2147483646) == 0)
				{
					break;
				}
				if (Interlocked.CompareExchange(ref this.m_owner, owner - 2, owner) == owner)
				{
					return;
				}
				spinWait.SpinOnce();
			}
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0004642C File Offset: 0x0004462C
		private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken)
		{
			int num = 0;
			int managedThreadId = Thread.CurrentThread.ManagedThreadId;
			if (this.m_owner == managedThreadId)
			{
				throw new LockRecursionException(Environment.GetResourceString("The calling thread already holds the lock."));
			}
			SpinWait spinWait = default(SpinWait);
			for (;;)
			{
				spinWait.SpinOnce();
				if (this.m_owner == num)
				{
					Thread.BeginCriticalRegion();
					if (Interlocked.CompareExchange(ref this.m_owner, managedThreadId, num, ref lockTaken) == num)
					{
						break;
					}
					Thread.EndCriticalRegion();
				}
				if (millisecondsTimeout == 0 || (millisecondsTimeout != -1 && spinWait.NextSpinWillYield && TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout) <= 0))
				{
					return;
				}
			}
		}

		/// <summary>Releases the lock.</summary>
		/// <param name="useMemoryBarrier">A Boolean value that indicates whether a memory fence should be issued in order to immediately publish the exit operation to other threads.</param>
		/// <exception cref="T:System.Threading.SynchronizationLockException">Thread ownership tracking is enabled, and the current thread is not the owner of this lock.</exception>
		// Token: 0x060010F5 RID: 4341 RVA: 0x000464B4 File Offset: 0x000446B4
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void Exit(bool useMemoryBarrier)
		{
			if ((this.m_owner & -2147483648) != 0 && !useMemoryBarrier)
			{
				int owner = this.m_owner;
				this.m_owner = (owner & -2);
			}
			else
			{
				this.ExitSlowPath(useMemoryBarrier);
			}
			Thread.EndCriticalRegion();
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x000464F8 File Offset: 0x000446F8
		private void ExitSlowPath(bool useMemoryBarrier)
		{
			bool flag = (this.m_owner & int.MinValue) == 0;
			if (flag && !this.IsHeldByCurrentThread)
			{
				throw new SynchronizationLockException(Environment.GetResourceString("The calling thread does not hold the lock."));
			}
			if (useMemoryBarrier)
			{
				if (flag)
				{
					Interlocked.Exchange(ref this.m_owner, 0);
					return;
				}
				Interlocked.Decrement(ref this.m_owner);
				return;
			}
			else
			{
				if (flag)
				{
					this.m_owner = 0;
					return;
				}
				int owner = this.m_owner;
				this.m_owner = (owner & -2);
				return;
			}
		}

		/// <summary>Gets whether the lock is held by the current thread.</summary>
		/// <returns>true if the lock is held by the current thread; otherwise false.</returns>
		/// <exception cref="T:System.InvalidOperationException">Thread ownership tracking is disabled.</exception>
		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x00046575 File Offset: 0x00044775
		public bool IsHeldByCurrentThread
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				if (!this.IsThreadOwnerTrackingEnabled)
				{
					throw new InvalidOperationException(Environment.GetResourceString("Thread tracking is disabled."));
				}
				return (this.m_owner & int.MaxValue) == Thread.CurrentThread.ManagedThreadId;
			}
		}

		/// <summary>Gets whether thread ownership tracking is enabled for this instance.</summary>
		/// <returns>true if thread ownership tracking is enabled for this instance; otherwise false.</returns>
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x000465A9 File Offset: 0x000447A9
		public bool IsThreadOwnerTrackingEnabled
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return (this.m_owner & int.MinValue) == 0;
			}
		}

		// Token: 0x04000687 RID: 1671
		private volatile int m_owner;

		// Token: 0x04000688 RID: 1672
		private static int MAXIMUM_WAITERS = 2147483646;

		// Token: 0x020001CB RID: 459
		internal class SystemThreading_SpinLockDebugView
		{
		}
	}
}
