using System;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	/// <summary>Represents a lock that is used to manage access to a resource, allowing multiple threads for reading or exclusive access for writing.</summary>
	// Token: 0x02000152 RID: 338
	public class ReaderWriterLockSlim : IDisposable
	{
		// Token: 0x06000AA8 RID: 2728 RVA: 0x00027DE7 File Offset: 0x00025FE7
		private void InitializeThreadCounts()
		{
			this.upgradeLockOwnerId = -1;
			this.writeLockOwnerId = -1;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ReaderWriterLockSlim" /> class with default property values.</summary>
		// Token: 0x06000AA9 RID: 2729 RVA: 0x00027DF7 File Offset: 0x00025FF7
		public ReaderWriterLockSlim() : this(LockRecursionPolicy.NoRecursion)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ReaderWriterLockSlim" /> class, specifying the lock recursion policy.</summary>
		/// <param name="recursionPolicy">One of the enumeration values that specifies the lock recursion policy.</param>
		// Token: 0x06000AAA RID: 2730 RVA: 0x00027E00 File Offset: 0x00026000
		public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy)
		{
			if (recursionPolicy == LockRecursionPolicy.SupportsRecursion)
			{
				this.fIsReentrant = true;
			}
			this.InitializeThreadCounts();
			this.fNoWaiters = true;
			this.lockID = Interlocked.Increment(ref ReaderWriterLockSlim.s_nextLockID);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00027E30 File Offset: 0x00026030
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsRWEntryEmpty(ReaderWriterCount rwc)
		{
			return rwc.lockID == 0L || (rwc.readercount == 0 && rwc.writercount == 0 && rwc.upgradecount == 0);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00027E57 File Offset: 0x00026057
		private bool IsRwHashEntryChanged(ReaderWriterCount lrwc)
		{
			return lrwc.lockID != this.lockID;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00027E6C File Offset: 0x0002606C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ReaderWriterCount GetThreadRWCount(bool dontAllocate)
		{
			ReaderWriterCount next = ReaderWriterLockSlim.t_rwc;
			ReaderWriterCount readerWriterCount = null;
			while (next != null)
			{
				if (next.lockID == this.lockID)
				{
					return next;
				}
				if (!dontAllocate && readerWriterCount == null && ReaderWriterLockSlim.IsRWEntryEmpty(next))
				{
					readerWriterCount = next;
				}
				next = next.next;
			}
			if (dontAllocate)
			{
				return null;
			}
			if (readerWriterCount == null)
			{
				readerWriterCount = new ReaderWriterCount();
				readerWriterCount.next = ReaderWriterLockSlim.t_rwc;
				ReaderWriterLockSlim.t_rwc = readerWriterCount;
			}
			readerWriterCount.lockID = this.lockID;
			return readerWriterCount;
		}

		/// <summary>Tries to enter the lock in write mode.</summary>
		/// <exception cref="T:System.Threading.LockRecursionException">The <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" /> property is <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" /> and the current thread has already entered the lock in any mode. -or-The current thread has entered read mode, so trying to enter the lock in write mode would create the possibility of a deadlock. -or-The recursion number would exceed the capacity of the counter. The limit is so large that applications should never encounter it.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ReaderWriterLockSlim" /> object has been disposed. </exception>
		// Token: 0x06000AAE RID: 2734 RVA: 0x00027ED9 File Offset: 0x000260D9
		public void EnterWriteLock()
		{
			this.TryEnterWriteLock(-1);
		}

		/// <summary>Tries to enter the lock in write mode, with an optional time-out.</summary>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or -1 (<see cref="F:System.Threading.Timeout.Infinite" />) to wait indefinitely.</param>
		/// <returns>
		///     <see langword="true" /> if the calling thread entered write mode, otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.Threading.LockRecursionException">The <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" /> property is <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" /> and the current thread has already entered the lock. -or-The current thread initially entered the lock in read mode, and therefore trying to enter write mode would create the possibility of a deadlock. -or-The recursion number would exceed the capacity of the counter. The limit is so large that applications should never encounter it.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="millisecondsTimeout" /> is negative, but it is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> (-1), which is the only negative value allowed. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ReaderWriterLockSlim" /> object has been disposed. </exception>
		// Token: 0x06000AAF RID: 2735 RVA: 0x00027EE3 File Offset: 0x000260E3
		public bool TryEnterWriteLock(int millisecondsTimeout)
		{
			return this.TryEnterWriteLock(new ReaderWriterLockSlim.TimeoutTracker(millisecondsTimeout));
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00027EF1 File Offset: 0x000260F1
		private bool TryEnterWriteLock(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			return this.TryEnterWriteLockCore(timeout);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00027EFC File Offset: 0x000260FC
		private bool TryEnterWriteLockCore(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			if (this.fDisposed)
			{
				throw new ObjectDisposedException(null);
			}
			int managedThreadId = Thread.CurrentThread.ManagedThreadId;
			bool flag = false;
			ReaderWriterCount threadRWCount;
			if (!this.fIsReentrant)
			{
				if (managedThreadId == this.writeLockOwnerId)
				{
					throw new LockRecursionException(SR.GetString("Recursive write lock acquisitions not allowed in this mode."));
				}
				if (managedThreadId == this.upgradeLockOwnerId)
				{
					flag = true;
				}
				this.EnterMyLock();
				threadRWCount = this.GetThreadRWCount(true);
				if (threadRWCount != null && threadRWCount.readercount > 0)
				{
					this.ExitMyLock();
					throw new LockRecursionException(SR.GetString("Write lock may not be acquired with read lock held. This pattern is prone to deadlocks. Please ensure that read locks are released before taking a write lock. If an upgrade is necessary, use an upgrade lock in place of the read lock."));
				}
			}
			else
			{
				this.EnterMyLock();
				threadRWCount = this.GetThreadRWCount(false);
				if (managedThreadId == this.writeLockOwnerId)
				{
					threadRWCount.writercount++;
					this.ExitMyLock();
					return true;
				}
				if (managedThreadId == this.upgradeLockOwnerId)
				{
					flag = true;
				}
				else if (threadRWCount.readercount > 0)
				{
					this.ExitMyLock();
					throw new LockRecursionException(SR.GetString("Write lock may not be acquired with read lock held. This pattern is prone to deadlocks. Please ensure that read locks are released before taking a write lock. If an upgrade is necessary, use an upgrade lock in place of the read lock."));
				}
			}
			int num = 0;
			while (!this.IsWriterAcquired())
			{
				if (flag)
				{
					uint numReaders = this.GetNumReaders();
					if (numReaders == 1U)
					{
						this.SetWriterAcquired();
					}
					else
					{
						if (numReaders != 2U || threadRWCount == null)
						{
							goto IL_12E;
						}
						if (this.IsRwHashEntryChanged(threadRWCount))
						{
							threadRWCount = this.GetThreadRWCount(false);
						}
						if (threadRWCount.readercount <= 0)
						{
							goto IL_12E;
						}
						this.SetWriterAcquired();
					}
					IL_1C6:
					if (this.fIsReentrant)
					{
						if (this.IsRwHashEntryChanged(threadRWCount))
						{
							threadRWCount = this.GetThreadRWCount(false);
						}
						threadRWCount.writercount++;
					}
					this.ExitMyLock();
					this.writeLockOwnerId = managedThreadId;
					return true;
				}
				IL_12E:
				if (num < 20)
				{
					this.ExitMyLock();
					if (timeout.IsExpired)
					{
						return false;
					}
					num++;
					ReaderWriterLockSlim.SpinWait(num);
					this.EnterMyLock();
				}
				else if (flag)
				{
					if (this.waitUpgradeEvent == null)
					{
						this.LazyCreateEvent(ref this.waitUpgradeEvent, true);
					}
					else if (!this.WaitOnEvent(this.waitUpgradeEvent, ref this.numWriteUpgradeWaiters, timeout, true))
					{
						return false;
					}
				}
				else if (this.writeEvent == null)
				{
					this.LazyCreateEvent(ref this.writeEvent, true);
				}
				else if (!this.WaitOnEvent(this.writeEvent, ref this.numWriteWaiters, timeout, true))
				{
					return false;
				}
			}
			this.SetWriterAcquired();
			goto IL_1C6;
		}

		/// <summary>Tries to enter the lock in upgradeable mode.</summary>
		/// <exception cref="T:System.Threading.LockRecursionException">The <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" /> property is <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" /> and the current thread has already entered the lock in any mode. -or-The current thread has entered read mode, so trying to enter upgradeable mode would create the possibility of a deadlock. -or-The recursion number would exceed the capacity of the counter. The limit is so large that applications should never encounter it.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ReaderWriterLockSlim" /> object has been disposed. </exception>
		// Token: 0x06000AB2 RID: 2738 RVA: 0x00028104 File Offset: 0x00026304
		public void EnterUpgradeableReadLock()
		{
			this.TryEnterUpgradeableReadLock(-1);
		}

		/// <summary>Tries to enter the lock in upgradeable mode, with an optional time-out.</summary>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or -1 (<see cref="F:System.Threading.Timeout.Infinite" />) to wait indefinitely.</param>
		/// <returns>
		///     <see langword="true" /> if the calling thread entered upgradeable mode, otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.Threading.LockRecursionException">The <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" /> property is <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" /> and the current thread has already entered the lock. -or-The current thread initially entered the lock in read mode, and therefore trying to enter upgradeable mode would create the possibility of a deadlock. -or-The recursion number would exceed the capacity of the counter. The limit is so large that applications should never encounter it.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="millisecondsTimeout" /> is negative, but it is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> (-1), which is the only negative value allowed. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ReaderWriterLockSlim" /> object has been disposed. </exception>
		// Token: 0x06000AB3 RID: 2739 RVA: 0x0002810E File Offset: 0x0002630E
		public bool TryEnterUpgradeableReadLock(int millisecondsTimeout)
		{
			return this.TryEnterUpgradeableReadLock(new ReaderWriterLockSlim.TimeoutTracker(millisecondsTimeout));
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0002811C File Offset: 0x0002631C
		private bool TryEnterUpgradeableReadLock(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			return this.TryEnterUpgradeableReadLockCore(timeout);
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00028128 File Offset: 0x00026328
		private bool TryEnterUpgradeableReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			if (this.fDisposed)
			{
				throw new ObjectDisposedException(null);
			}
			int managedThreadId = Thread.CurrentThread.ManagedThreadId;
			ReaderWriterCount threadRWCount;
			if (!this.fIsReentrant)
			{
				if (managedThreadId == this.upgradeLockOwnerId)
				{
					throw new LockRecursionException(SR.GetString("Recursive upgradeable lock acquisitions not allowed in this mode."));
				}
				if (managedThreadId == this.writeLockOwnerId)
				{
					throw new LockRecursionException(SR.GetString("Upgradeable lock may not be acquired with write lock held in this mode. Acquiring Upgradeable lock gives the ability to read along with an option to upgrade to a writer."));
				}
				this.EnterMyLock();
				threadRWCount = this.GetThreadRWCount(true);
				if (threadRWCount != null && threadRWCount.readercount > 0)
				{
					this.ExitMyLock();
					throw new LockRecursionException(SR.GetString("Upgradeable lock may not be acquired with read lock held."));
				}
			}
			else
			{
				this.EnterMyLock();
				threadRWCount = this.GetThreadRWCount(false);
				if (managedThreadId == this.upgradeLockOwnerId)
				{
					threadRWCount.upgradecount++;
					this.ExitMyLock();
					return true;
				}
				if (managedThreadId == this.writeLockOwnerId)
				{
					this.owners += 1U;
					this.upgradeLockOwnerId = managedThreadId;
					threadRWCount.upgradecount++;
					if (threadRWCount.readercount > 0)
					{
						this.fUpgradeThreadHoldingRead = true;
					}
					this.ExitMyLock();
					return true;
				}
				if (threadRWCount.readercount > 0)
				{
					this.ExitMyLock();
					throw new LockRecursionException(SR.GetString("Upgradeable lock may not be acquired with read lock held."));
				}
			}
			int num = 0;
			while (this.upgradeLockOwnerId != -1 || this.owners >= 268435454U)
			{
				if (num < 20)
				{
					this.ExitMyLock();
					if (timeout.IsExpired)
					{
						return false;
					}
					num++;
					ReaderWriterLockSlim.SpinWait(num);
					this.EnterMyLock();
				}
				else if (this.upgradeEvent == null)
				{
					this.LazyCreateEvent(ref this.upgradeEvent, true);
				}
				else if (!this.WaitOnEvent(this.upgradeEvent, ref this.numUpgradeWaiters, timeout, false))
				{
					return false;
				}
			}
			this.owners += 1U;
			this.upgradeLockOwnerId = managedThreadId;
			if (this.fIsReentrant)
			{
				if (this.IsRwHashEntryChanged(threadRWCount))
				{
					threadRWCount = this.GetThreadRWCount(false);
				}
				threadRWCount.upgradecount++;
			}
			this.ExitMyLock();
			return true;
		}

		/// <summary>Reduces the recursion count for write mode, and exits write mode if the resulting count is 0 (zero).</summary>
		/// <exception cref="T:System.Threading.SynchronizationLockException">The current thread has not entered the lock in write mode.</exception>
		// Token: 0x06000AB6 RID: 2742 RVA: 0x00028308 File Offset: 0x00026508
		public void ExitWriteLock()
		{
			if (!this.fIsReentrant)
			{
				if (Thread.CurrentThread.ManagedThreadId != this.writeLockOwnerId)
				{
					throw new SynchronizationLockException(SR.GetString("The write lock is being released without being held."));
				}
				this.EnterMyLock();
			}
			else
			{
				this.EnterMyLock();
				ReaderWriterCount threadRWCount = this.GetThreadRWCount(false);
				if (threadRWCount == null)
				{
					this.ExitMyLock();
					throw new SynchronizationLockException(SR.GetString("The write lock is being released without being held."));
				}
				if (threadRWCount.writercount < 1)
				{
					this.ExitMyLock();
					throw new SynchronizationLockException(SR.GetString("The write lock is being released without being held."));
				}
				threadRWCount.writercount--;
				if (threadRWCount.writercount > 0)
				{
					this.ExitMyLock();
					return;
				}
			}
			this.ClearWriterAcquired();
			this.writeLockOwnerId = -1;
			this.ExitAndWakeUpAppropriateWaiters();
		}

		/// <summary>Reduces the recursion count for upgradeable mode, and exits upgradeable mode if the resulting count is 0 (zero).</summary>
		/// <exception cref="T:System.Threading.SynchronizationLockException">The current thread has not entered the lock in upgradeable mode.</exception>
		// Token: 0x06000AB7 RID: 2743 RVA: 0x000283BC File Offset: 0x000265BC
		public void ExitUpgradeableReadLock()
		{
			if (!this.fIsReentrant)
			{
				if (Thread.CurrentThread.ManagedThreadId != this.upgradeLockOwnerId)
				{
					throw new SynchronizationLockException(SR.GetString("The upgradeable lock is being released without being held."));
				}
				this.EnterMyLock();
			}
			else
			{
				this.EnterMyLock();
				ReaderWriterCount threadRWCount = this.GetThreadRWCount(true);
				if (threadRWCount == null)
				{
					this.ExitMyLock();
					throw new SynchronizationLockException(SR.GetString("The upgradeable lock is being released without being held."));
				}
				if (threadRWCount.upgradecount < 1)
				{
					this.ExitMyLock();
					throw new SynchronizationLockException(SR.GetString("The upgradeable lock is being released without being held."));
				}
				threadRWCount.upgradecount--;
				if (threadRWCount.upgradecount > 0)
				{
					this.ExitMyLock();
					return;
				}
				this.fUpgradeThreadHoldingRead = false;
			}
			this.owners -= 1U;
			this.upgradeLockOwnerId = -1;
			this.ExitAndWakeUpAppropriateWaiters();
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00028480 File Offset: 0x00026680
		private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent)
		{
			this.ExitMyLock();
			EventWaitHandle eventWaitHandle;
			if (makeAutoResetEvent)
			{
				eventWaitHandle = new AutoResetEvent(false);
			}
			else
			{
				eventWaitHandle = new ManualResetEvent(false);
			}
			this.EnterMyLock();
			if (waitEvent == null)
			{
				waitEvent = eventWaitHandle;
				return;
			}
			eventWaitHandle.Close();
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x000284BC File Offset: 0x000266BC
		private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, ReaderWriterLockSlim.TimeoutTracker timeout, bool isWriteWaiter)
		{
			waitEvent.Reset();
			numWaiters += 1U;
			this.fNoWaiters = false;
			if (this.numWriteWaiters == 1U)
			{
				this.SetWritersWaiting();
			}
			if (this.numWriteUpgradeWaiters == 1U)
			{
				this.SetUpgraderWaiting();
			}
			bool flag = false;
			this.ExitMyLock();
			try
			{
				flag = waitEvent.WaitOne(timeout.RemainingMilliseconds);
			}
			finally
			{
				this.EnterMyLock();
				numWaiters -= 1U;
				if (this.numWriteWaiters == 0U && this.numWriteUpgradeWaiters == 0U && this.numUpgradeWaiters == 0U && this.numReadWaiters == 0U)
				{
					this.fNoWaiters = true;
				}
				if (this.numWriteWaiters == 0U)
				{
					this.ClearWritersWaiting();
				}
				if (this.numWriteUpgradeWaiters == 0U)
				{
					this.ClearUpgraderWaiting();
				}
				if (!flag)
				{
					if (isWriteWaiter)
					{
						this.ExitAndWakeUpAppropriateReadWaiters();
					}
					else
					{
						this.ExitMyLock();
					}
				}
			}
			return flag;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0002858C File Offset: 0x0002678C
		private void ExitAndWakeUpAppropriateWaiters()
		{
			if (this.fNoWaiters)
			{
				this.ExitMyLock();
				return;
			}
			this.ExitAndWakeUpAppropriateWaitersPreferringWriters();
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x000285A4 File Offset: 0x000267A4
		private void ExitAndWakeUpAppropriateWaitersPreferringWriters()
		{
			uint numReaders = this.GetNumReaders();
			if (this.fIsReentrant && this.numWriteUpgradeWaiters > 0U && this.fUpgradeThreadHoldingRead && numReaders == 2U)
			{
				this.ExitMyLock();
				this.waitUpgradeEvent.Set();
				return;
			}
			if (numReaders == 1U && this.numWriteUpgradeWaiters > 0U)
			{
				this.ExitMyLock();
				this.waitUpgradeEvent.Set();
				return;
			}
			if (numReaders == 0U && this.numWriteWaiters > 0U)
			{
				this.ExitMyLock();
				this.writeEvent.Set();
				return;
			}
			this.ExitAndWakeUpAppropriateReadWaiters();
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00028630 File Offset: 0x00026830
		private void ExitAndWakeUpAppropriateReadWaiters()
		{
			if (this.numWriteWaiters != 0U || this.numWriteUpgradeWaiters != 0U || this.fNoWaiters)
			{
				this.ExitMyLock();
				return;
			}
			bool flag = this.numReadWaiters > 0U;
			bool flag2 = this.numUpgradeWaiters != 0U && this.upgradeLockOwnerId == -1;
			this.ExitMyLock();
			if (flag)
			{
				this.readEvent.Set();
			}
			if (flag2)
			{
				this.upgradeEvent.Set();
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0002869D File Offset: 0x0002689D
		private bool IsWriterAcquired()
		{
			return (this.owners & 3221225471U) == 0U;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x000286AE File Offset: 0x000268AE
		private void SetWriterAcquired()
		{
			this.owners |= 2147483648U;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x000286C2 File Offset: 0x000268C2
		private void ClearWriterAcquired()
		{
			this.owners &= 2147483647U;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x000286D6 File Offset: 0x000268D6
		private void SetWritersWaiting()
		{
			this.owners |= 1073741824U;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x000286EA File Offset: 0x000268EA
		private void ClearWritersWaiting()
		{
			this.owners &= 3221225471U;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x000286FE File Offset: 0x000268FE
		private void SetUpgraderWaiting()
		{
			this.owners |= 536870912U;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00028712 File Offset: 0x00026912
		private void ClearUpgraderWaiting()
		{
			this.owners &= 3758096383U;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00028726 File Offset: 0x00026926
		private uint GetNumReaders()
		{
			return this.owners & 268435455U;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00028734 File Offset: 0x00026934
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void EnterMyLock()
		{
			if (Interlocked.CompareExchange(ref this.myLock, 1, 0) != 0)
			{
				this.EnterMyLockSpin();
			}
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0002874C File Offset: 0x0002694C
		private void EnterMyLockSpin()
		{
			int processorCount = PlatformHelper.ProcessorCount;
			int num = 0;
			for (;;)
			{
				if (num < 10 && processorCount > 1)
				{
					Thread.SpinWait(20 * (num + 1));
				}
				else if (num < 15)
				{
					Thread.Sleep(0);
				}
				else
				{
					Thread.Sleep(1);
				}
				if (this.myLock == 0 && Interlocked.CompareExchange(ref this.myLock, 1, 0) == 0)
				{
					break;
				}
				num++;
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x000287A7 File Offset: 0x000269A7
		private void ExitMyLock()
		{
			Volatile.Write(ref this.myLock, 0);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x000287B5 File Offset: 0x000269B5
		private static void SpinWait(int SpinCount)
		{
			if (SpinCount < 5 && PlatformHelper.ProcessorCount > 1)
			{
				Thread.SpinWait(20 * SpinCount);
				return;
			}
			if (SpinCount < 17)
			{
				Thread.Sleep(0);
				return;
			}
			Thread.Sleep(1);
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.ReaderWriterLockSlim" /> class.</summary>
		/// <exception cref="T:System.Threading.SynchronizationLockException">
		///         <see cref="P:System.Threading.ReaderWriterLockSlim.WaitingReadCount" /> is greater than zero. -or-
		///         <see cref="P:System.Threading.ReaderWriterLockSlim.WaitingUpgradeCount" /> is greater than zero. -or-
		///         <see cref="P:System.Threading.ReaderWriterLockSlim.WaitingWriteCount" /> is greater than zero. </exception>
		// Token: 0x06000AC9 RID: 2761 RVA: 0x000287DF File Offset: 0x000269DF
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x000287E8 File Offset: 0x000269E8
		private void Dispose(bool disposing)
		{
			if (disposing && !this.fDisposed)
			{
				if (this.WaitingReadCount > 0 || this.WaitingUpgradeCount > 0 || this.WaitingWriteCount > 0)
				{
					throw new SynchronizationLockException(SR.GetString("The lock is being disposed while still being used. It either is being held by a thread and/or has active waiters waiting to acquire the lock."));
				}
				if (this.IsReadLockHeld || this.IsUpgradeableReadLockHeld || this.IsWriteLockHeld)
				{
					throw new SynchronizationLockException(SR.GetString("The lock is being disposed while still being used. It either is being held by a thread and/or has active waiters waiting to acquire the lock."));
				}
				if (this.writeEvent != null)
				{
					this.writeEvent.Close();
					this.writeEvent = null;
				}
				if (this.readEvent != null)
				{
					this.readEvent.Close();
					this.readEvent = null;
				}
				if (this.upgradeEvent != null)
				{
					this.upgradeEvent.Close();
					this.upgradeEvent = null;
				}
				if (this.waitUpgradeEvent != null)
				{
					this.waitUpgradeEvent.Close();
					this.waitUpgradeEvent = null;
				}
				this.fDisposed = true;
			}
		}

		/// <summary>Gets a value that indicates whether the current thread has entered the lock in read mode.</summary>
		/// <returns>
		///     <see langword="true" /> if the current thread has entered read mode; otherwise, <see langword="false" />.</returns>
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x000288C8 File Offset: 0x00026AC8
		public bool IsReadLockHeld
		{
			get
			{
				return this.RecursiveReadCount > 0;
			}
		}

		/// <summary>Gets a value that indicates whether the current thread has entered the lock in upgradeable mode. </summary>
		/// <returns>
		///     <see langword="true" /> if the current thread has entered upgradeable mode; otherwise, <see langword="false" />.</returns>
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x000288D6 File Offset: 0x00026AD6
		public bool IsUpgradeableReadLockHeld
		{
			get
			{
				return this.RecursiveUpgradeCount > 0;
			}
		}

		/// <summary>Gets a value that indicates whether the current thread has entered the lock in write mode.</summary>
		/// <returns>
		///     <see langword="true" /> if the current thread has entered write mode; otherwise, <see langword="false" />.</returns>
		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x000288E4 File Offset: 0x00026AE4
		public bool IsWriteLockHeld
		{
			get
			{
				return this.RecursiveWriteCount > 0;
			}
		}

		/// <summary>Gets the number of times the current thread has entered the lock in read mode, as an indication of recursion.</summary>
		/// <returns>0 (zero) if the current thread has not entered read mode, 1 if the thread has entered read mode but has not entered it recursively, or n if the thread has entered the lock recursively n - 1 times.</returns>
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x000288F4 File Offset: 0x00026AF4
		public int RecursiveReadCount
		{
			get
			{
				int result = 0;
				ReaderWriterCount threadRWCount = this.GetThreadRWCount(true);
				if (threadRWCount != null)
				{
					result = threadRWCount.readercount;
				}
				return result;
			}
		}

		/// <summary>Gets the number of times the current thread has entered the lock in upgradeable mode, as an indication of recursion.</summary>
		/// <returns>0 if the current thread has not entered upgradeable mode, 1 if the thread has entered upgradeable mode but has not entered it recursively, or n if the thread has entered upgradeable mode recursively n - 1 times.</returns>
		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00028918 File Offset: 0x00026B18
		public int RecursiveUpgradeCount
		{
			get
			{
				if (this.fIsReentrant)
				{
					int result = 0;
					ReaderWriterCount threadRWCount = this.GetThreadRWCount(true);
					if (threadRWCount != null)
					{
						result = threadRWCount.upgradecount;
					}
					return result;
				}
				if (Thread.CurrentThread.ManagedThreadId == this.upgradeLockOwnerId)
				{
					return 1;
				}
				return 0;
			}
		}

		/// <summary>Gets the number of times the current thread has entered the lock in write mode, as an indication of recursion.</summary>
		/// <returns>0 if the current thread has not entered write mode, 1 if the thread has entered write mode but has not entered it recursively, or n if the thread has entered write mode recursively n - 1 times.</returns>
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00028958 File Offset: 0x00026B58
		public int RecursiveWriteCount
		{
			get
			{
				if (this.fIsReentrant)
				{
					int result = 0;
					ReaderWriterCount threadRWCount = this.GetThreadRWCount(true);
					if (threadRWCount != null)
					{
						result = threadRWCount.writercount;
					}
					return result;
				}
				if (Thread.CurrentThread.ManagedThreadId == this.writeLockOwnerId)
				{
					return 1;
				}
				return 0;
			}
		}

		/// <summary>Gets the total number of threads that are waiting to enter the lock in read mode.</summary>
		/// <returns>The total number of threads that are waiting to enter read mode.</returns>
		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x00028998 File Offset: 0x00026B98
		public int WaitingReadCount
		{
			get
			{
				return (int)this.numReadWaiters;
			}
		}

		/// <summary>Gets the total number of threads that are waiting to enter the lock in upgradeable mode.</summary>
		/// <returns>The total number of threads that are waiting to enter upgradeable mode.</returns>
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x000289A0 File Offset: 0x00026BA0
		public int WaitingUpgradeCount
		{
			get
			{
				return (int)this.numUpgradeWaiters;
			}
		}

		/// <summary>Gets the total number of threads that are waiting to enter the lock in write mode.</summary>
		/// <returns>The total number of threads that are waiting to enter write mode.</returns>
		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x000289A8 File Offset: 0x00026BA8
		public int WaitingWriteCount
		{
			get
			{
				return (int)this.numWriteWaiters;
			}
		}

		// Token: 0x04000334 RID: 820
		private bool fIsReentrant;

		// Token: 0x04000335 RID: 821
		private int myLock;

		// Token: 0x04000336 RID: 822
		private uint numWriteWaiters;

		// Token: 0x04000337 RID: 823
		private uint numReadWaiters;

		// Token: 0x04000338 RID: 824
		private uint numWriteUpgradeWaiters;

		// Token: 0x04000339 RID: 825
		private uint numUpgradeWaiters;

		// Token: 0x0400033A RID: 826
		private bool fNoWaiters;

		// Token: 0x0400033B RID: 827
		private int upgradeLockOwnerId;

		// Token: 0x0400033C RID: 828
		private int writeLockOwnerId;

		// Token: 0x0400033D RID: 829
		private EventWaitHandle writeEvent;

		// Token: 0x0400033E RID: 830
		private EventWaitHandle readEvent;

		// Token: 0x0400033F RID: 831
		private EventWaitHandle upgradeEvent;

		// Token: 0x04000340 RID: 832
		private EventWaitHandle waitUpgradeEvent;

		// Token: 0x04000341 RID: 833
		private static long s_nextLockID;

		// Token: 0x04000342 RID: 834
		private long lockID;

		// Token: 0x04000343 RID: 835
		[ThreadStatic]
		private static ReaderWriterCount t_rwc;

		// Token: 0x04000344 RID: 836
		private bool fUpgradeThreadHoldingRead;

		// Token: 0x04000345 RID: 837
		private uint owners;

		// Token: 0x04000346 RID: 838
		private bool fDisposed;

		// Token: 0x02000153 RID: 339
		private struct TimeoutTracker
		{
			// Token: 0x06000AD4 RID: 2772 RVA: 0x000289B0 File Offset: 0x00026BB0
			public TimeoutTracker(int millisecondsTimeout)
			{
				if (millisecondsTimeout < -1)
				{
					throw new ArgumentOutOfRangeException("millisecondsTimeout");
				}
				this.m_total = millisecondsTimeout;
				if (this.m_total != -1 && this.m_total != 0)
				{
					this.m_start = Environment.TickCount;
					return;
				}
				this.m_start = 0;
			}

			// Token: 0x170001DB RID: 475
			// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x000289EC File Offset: 0x00026BEC
			public int RemainingMilliseconds
			{
				get
				{
					if (this.m_total == -1 || this.m_total == 0)
					{
						return this.m_total;
					}
					int num = Environment.TickCount - this.m_start;
					if (num < 0 || num >= this.m_total)
					{
						return 0;
					}
					return this.m_total - num;
				}
			}

			// Token: 0x170001DC RID: 476
			// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x00028A35 File Offset: 0x00026C35
			public bool IsExpired
			{
				get
				{
					return this.RemainingMilliseconds == 0;
				}
			}

			// Token: 0x04000347 RID: 839
			private int m_total;

			// Token: 0x04000348 RID: 840
			private int m_start;
		}
	}
}
