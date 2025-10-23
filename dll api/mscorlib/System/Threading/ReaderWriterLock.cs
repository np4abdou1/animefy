using System;
using System.Collections;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading
{
	/// <summary>Defines a lock that supports single writers and multiple readers. </summary>
	// Token: 0x020001F3 RID: 499
	[ComVisible(true)]
	public sealed class ReaderWriterLock : CriticalFinalizerObject
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ReaderWriterLock" /> class.</summary>
		// Token: 0x06001225 RID: 4645 RVA: 0x000495FC File Offset: 0x000477FC
		public ReaderWriterLock()
		{
			this.writer_queue = new LockQueue(this);
			this.reader_locks = new Hashtable();
			GC.SuppressFinalize(this);
		}

		/// <summary>Ensures that resources are freed and other cleanup operations are performed when the garbage collector reclaims the <see cref="T:System.Threading.ReaderWriterLock" /> object. </summary>
		// Token: 0x06001226 RID: 4646 RVA: 0x00049628 File Offset: 0x00047828
		~ReaderWriterLock()
		{
		}

		/// <summary>Acquires the writer lock, using an <see cref="T:System.Int32" /> value for the time-out.</summary>
		/// <param name="millisecondsTimeout">The time-out in milliseconds. </param>
		/// <exception cref="T:System.ApplicationException">
		///         <paramref name="timeout" />
		///          expires before the lock request is granted. </exception>
		// Token: 0x06001227 RID: 4647 RVA: 0x00049650 File Offset: 0x00047850
		public void AcquireWriterLock(int millisecondsTimeout)
		{
			this.AcquireWriterLock(millisecondsTimeout, 1);
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0004965C File Offset: 0x0004785C
		private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount)
		{
			lock (this)
			{
				if (this.HasWriterLock())
				{
					this.state--;
				}
				else
				{
					if (this.state != 0 || !this.writer_queue.IsEmpty)
					{
						while (this.writer_queue.Wait(millisecondsTimeout))
						{
							if (this.state == 0)
							{
								goto IL_5A;
							}
						}
						throw new ApplicationException("Timeout expired");
					}
					IL_5A:
					this.state = -initialLockCount;
					this.writer_lock_owner = Thread.CurrentThreadId;
					this.seq_num++;
				}
			}
		}

		/// <summary>Decrements the lock count on the writer lock.</summary>
		/// <exception cref="T:System.ApplicationException">The thread does not have the writer lock. </exception>
		// Token: 0x06001229 RID: 4649 RVA: 0x00049700 File Offset: 0x00047900
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void ReleaseWriterLock()
		{
			lock (this)
			{
				if (!this.HasWriterLock())
				{
					throw new ApplicationException("The thread does not have the writer lock.");
				}
				this.ReleaseWriterLock(1);
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00049750 File Offset: 0x00047950
		private void ReleaseWriterLock(int releaseCount)
		{
			this.state += releaseCount;
			if (this.state == 0)
			{
				if (this.readers > 0)
				{
					Monitor.PulseAll(this);
					return;
				}
				if (!this.writer_queue.IsEmpty)
				{
					this.writer_queue.Pulse();
				}
			}
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00049790 File Offset: 0x00047990
		private bool HasWriterLock()
		{
			return this.state < 0 && Thread.CurrentThreadId == this.writer_lock_owner;
		}

		// Token: 0x040006F5 RID: 1781
		private int seq_num = 1;

		// Token: 0x040006F6 RID: 1782
		private int state;

		// Token: 0x040006F7 RID: 1783
		private int readers;

		// Token: 0x040006F8 RID: 1784
		private int writer_lock_owner;

		// Token: 0x040006F9 RID: 1785
		private LockQueue writer_queue;

		// Token: 0x040006FA RID: 1786
		private Hashtable reader_locks;
	}
}
