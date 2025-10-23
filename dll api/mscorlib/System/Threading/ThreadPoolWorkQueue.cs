﻿using System;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System.Threading
{
	// Token: 0x020001E5 RID: 485
	internal sealed class ThreadPoolWorkQueue
	{
		// Token: 0x060011B2 RID: 4530 RVA: 0x00047F24 File Offset: 0x00046124
		public ThreadPoolWorkQueue()
		{
			this.queueTail = (this.queueHead = new ThreadPoolWorkQueue.QueueSegment());
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00047F4F File Offset: 0x0004614F
		[SecurityCritical]
		public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue()
		{
			if (ThreadPoolWorkQueueThreadLocals.threadLocals == null)
			{
				ThreadPoolWorkQueueThreadLocals.threadLocals = new ThreadPoolWorkQueueThreadLocals(this);
			}
			return ThreadPoolWorkQueueThreadLocals.threadLocals;
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00047F68 File Offset: 0x00046168
		[SecurityCritical]
		internal void EnsureThreadRequested()
		{
			int num;
			for (int i = this.numOutstandingThreadRequests; i < ThreadPoolGlobals.processorCount; i = num)
			{
				num = Interlocked.CompareExchange(ref this.numOutstandingThreadRequests, i + 1, i);
				if (num == i)
				{
					ThreadPool.RequestWorkerThread();
					return;
				}
			}
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00047FA8 File Offset: 0x000461A8
		[SecurityCritical]
		internal void MarkThreadRequestSatisfied()
		{
			int num;
			for (int i = this.numOutstandingThreadRequests; i > 0; i = num)
			{
				num = Interlocked.CompareExchange(ref this.numOutstandingThreadRequests, i - 1, i);
				if (num == i)
				{
					break;
				}
			}
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00047FDC File Offset: 0x000461DC
		[SecurityCritical]
		public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal)
		{
			ThreadPoolWorkQueueThreadLocals threadPoolWorkQueueThreadLocals = null;
			if (!forceGlobal)
			{
				threadPoolWorkQueueThreadLocals = ThreadPoolWorkQueueThreadLocals.threadLocals;
			}
			if (threadPoolWorkQueueThreadLocals != null)
			{
				threadPoolWorkQueueThreadLocals.workStealingQueue.LocalPush(callback);
			}
			else
			{
				ThreadPoolWorkQueue.QueueSegment queueSegment = this.queueHead;
				while (!queueSegment.TryEnqueue(callback))
				{
					Interlocked.CompareExchange<ThreadPoolWorkQueue.QueueSegment>(ref queueSegment.Next, new ThreadPoolWorkQueue.QueueSegment(), null);
					while (queueSegment.Next != null)
					{
						Interlocked.CompareExchange<ThreadPoolWorkQueue.QueueSegment>(ref this.queueHead, queueSegment.Next, queueSegment);
						queueSegment = this.queueHead;
					}
				}
			}
			ThreadPool.NotifyWorkItemQueued();
			this.EnsureThreadRequested();
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00048060 File Offset: 0x00046260
		[SecurityCritical]
		internal bool LocalFindAndPop(IThreadPoolWorkItem callback)
		{
			ThreadPoolWorkQueueThreadLocals threadLocals = ThreadPoolWorkQueueThreadLocals.threadLocals;
			return threadLocals != null && threadLocals.workStealingQueue.LocalFindAndPop(callback);
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00048084 File Offset: 0x00046284
		[SecurityCritical]
		public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal)
		{
			callback = null;
			missedSteal = false;
			ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue = tl.workStealingQueue;
			workStealingQueue.LocalPop(out callback);
			if (callback == null)
			{
				ThreadPoolWorkQueue.QueueSegment queueSegment = this.queueTail;
				while (!queueSegment.TryDequeue(out callback) && queueSegment.Next != null && queueSegment.IsUsedUp())
				{
					Interlocked.CompareExchange<ThreadPoolWorkQueue.QueueSegment>(ref this.queueTail, queueSegment.Next, queueSegment);
					queueSegment = this.queueTail;
				}
			}
			if (callback == null)
			{
				ThreadPoolWorkQueue.WorkStealingQueue[] array = ThreadPoolWorkQueue.allThreadQueues.Current;
				int num = tl.random.Next(array.Length);
				for (int i = array.Length; i > 0; i--)
				{
					ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue2 = Volatile.Read<ThreadPoolWorkQueue.WorkStealingQueue>(ref array[num % array.Length]);
					if (workStealingQueue2 != null && workStealingQueue2 != workStealingQueue && workStealingQueue2.TrySteal(out callback, ref missedSteal))
					{
						break;
					}
					num++;
				}
			}
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00048148 File Offset: 0x00046348
		[SecurityCritical]
		internal static bool Dispatch()
		{
			ThreadPoolWorkQueue workQueue = ThreadPoolGlobals.workQueue;
			int tickCount = Environment.TickCount;
			workQueue.MarkThreadRequestSatisfied();
			bool flag = true;
			IThreadPoolWorkItem threadPoolWorkItem = null;
			try
			{
				ThreadPoolWorkQueueThreadLocals tl = workQueue.EnsureCurrentThreadHasQueue();
				while ((long)(Environment.TickCount - tickCount) < 30L)
				{
					try
					{
					}
					finally
					{
						bool flag2 = false;
						workQueue.Dequeue(tl, out threadPoolWorkItem, out flag2);
						if (threadPoolWorkItem == null)
						{
							flag = flag2;
						}
						else
						{
							workQueue.EnsureThreadRequested();
						}
					}
					if (threadPoolWorkItem == null)
					{
						return true;
					}
					if (ThreadPoolGlobals.enableWorkerTracking)
					{
						bool flag3 = false;
						try
						{
							try
							{
							}
							finally
							{
								ThreadPool.ReportThreadStatus(true);
								flag3 = true;
							}
							threadPoolWorkItem.ExecuteWorkItem();
							threadPoolWorkItem = null;
							goto IL_7C;
						}
						finally
						{
							if (flag3)
							{
								ThreadPool.ReportThreadStatus(false);
							}
						}
						goto IL_74;
					}
					goto IL_74;
					IL_7C:
					if (!ThreadPool.NotifyWorkItemComplete())
					{
						return false;
					}
					continue;
					IL_74:
					threadPoolWorkItem.ExecuteWorkItem();
					threadPoolWorkItem = null;
					goto IL_7C;
				}
				return true;
			}
			catch (ThreadAbortException tae)
			{
				if (threadPoolWorkItem != null)
				{
					threadPoolWorkItem.MarkAborted(tae);
				}
				flag = false;
			}
			finally
			{
				if (flag)
				{
					workQueue.EnsureThreadRequested();
				}
			}
			return true;
		}

		// Token: 0x040006D1 RID: 1745
		internal volatile ThreadPoolWorkQueue.QueueSegment queueHead;

		// Token: 0x040006D2 RID: 1746
		internal volatile ThreadPoolWorkQueue.QueueSegment queueTail;

		// Token: 0x040006D3 RID: 1747
		internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues = new ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>(16);

		// Token: 0x040006D4 RID: 1748
		private volatile int numOutstandingThreadRequests;

		// Token: 0x020001E6 RID: 486
		internal class SparseArray<T> where T : class
		{
			// Token: 0x060011BB RID: 4539 RVA: 0x0004825E File Offset: 0x0004645E
			internal SparseArray(int initialSize)
			{
				this.m_array = new T[initialSize];
			}

			// Token: 0x170001B8 RID: 440
			// (get) Token: 0x060011BC RID: 4540 RVA: 0x00048274 File Offset: 0x00046474
			internal T[] Current
			{
				get
				{
					return this.m_array;
				}
			}

			// Token: 0x060011BD RID: 4541 RVA: 0x00048280 File Offset: 0x00046480
			internal int Add(T e)
			{
				for (;;)
				{
					T[] array = this.m_array;
					T[] obj = array;
					lock (obj)
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (array[i] == null)
							{
								Volatile.Write<T>(ref array[i], e);
								return i;
							}
							if (i == array.Length - 1 && array == this.m_array)
							{
								T[] array2 = new T[array.Length * 2];
								Array.Copy(array, array2, i + 1);
								array2[i + 1] = e;
								this.m_array = array2;
								return i + 1;
							}
						}
						continue;
					}
					break;
				}
				int result;
				return result;
			}

			// Token: 0x060011BE RID: 4542 RVA: 0x00048338 File Offset: 0x00046538
			internal void Remove(T e)
			{
				T[] array = this.m_array;
				lock (array)
				{
					for (int i = 0; i < this.m_array.Length; i++)
					{
						if (this.m_array[i] == e)
						{
							Volatile.Write<T>(ref this.m_array[i], default(T));
							break;
						}
					}
				}
			}

			// Token: 0x040006D5 RID: 1749
			private volatile T[] m_array;
		}

		// Token: 0x020001E7 RID: 487
		internal class WorkStealingQueue
		{
			// Token: 0x060011BF RID: 4543 RVA: 0x000483C4 File Offset: 0x000465C4
			public void LocalPush(IThreadPoolWorkItem obj)
			{
				int num = this.m_tailIndex;
				if (num == 2147483647)
				{
					bool flag = false;
					try
					{
						this.m_foreignLock.Enter(ref flag);
						if (this.m_tailIndex == 2147483647)
						{
							this.m_headIndex &= this.m_mask;
							num = (this.m_tailIndex &= this.m_mask);
						}
					}
					finally
					{
						if (flag)
						{
							this.m_foreignLock.Exit(true);
						}
					}
				}
				if (num < this.m_headIndex + this.m_mask)
				{
					Volatile.Write<IThreadPoolWorkItem>(ref this.m_array[num & this.m_mask], obj);
					this.m_tailIndex = num + 1;
					return;
				}
				bool flag2 = false;
				try
				{
					this.m_foreignLock.Enter(ref flag2);
					int headIndex = this.m_headIndex;
					int num2 = this.m_tailIndex - this.m_headIndex;
					if (num2 >= this.m_mask)
					{
						IThreadPoolWorkItem[] array = new IThreadPoolWorkItem[this.m_array.Length << 1];
						for (int i = 0; i < this.m_array.Length; i++)
						{
							array[i] = this.m_array[i + headIndex & this.m_mask];
						}
						this.m_array = array;
						this.m_headIndex = 0;
						num = (this.m_tailIndex = num2);
						this.m_mask = (this.m_mask << 1 | 1);
					}
					Volatile.Write<IThreadPoolWorkItem>(ref this.m_array[num & this.m_mask], obj);
					this.m_tailIndex = num + 1;
				}
				finally
				{
					if (flag2)
					{
						this.m_foreignLock.Exit(false);
					}
				}
			}

			// Token: 0x060011C0 RID: 4544 RVA: 0x0004858C File Offset: 0x0004678C
			public bool LocalFindAndPop(IThreadPoolWorkItem obj)
			{
				if (this.m_array[this.m_tailIndex - 1 & this.m_mask] == obj)
				{
					IThreadPoolWorkItem threadPoolWorkItem;
					return this.LocalPop(out threadPoolWorkItem);
				}
				for (int i = this.m_tailIndex - 2; i >= this.m_headIndex; i--)
				{
					if (this.m_array[i & this.m_mask] == obj)
					{
						bool flag = false;
						try
						{
							this.m_foreignLock.Enter(ref flag);
							if (this.m_array[i & this.m_mask] == null)
							{
								return false;
							}
							Volatile.Write<IThreadPoolWorkItem>(ref this.m_array[i & this.m_mask], null);
							if (i == this.m_tailIndex)
							{
								this.m_tailIndex--;
							}
							else if (i == this.m_headIndex)
							{
								this.m_headIndex++;
							}
							return true;
						}
						finally
						{
							if (flag)
							{
								this.m_foreignLock.Exit(false);
							}
						}
					}
				}
				return false;
			}

			// Token: 0x060011C1 RID: 4545 RVA: 0x000486AC File Offset: 0x000468AC
			public bool LocalPop(out IThreadPoolWorkItem obj)
			{
				int num3;
				for (;;)
				{
					int num = this.m_tailIndex;
					if (this.m_headIndex >= num)
					{
						break;
					}
					num--;
					Interlocked.Exchange(ref this.m_tailIndex, num);
					if (this.m_headIndex > num)
					{
						bool flag = false;
						bool result;
						try
						{
							this.m_foreignLock.Enter(ref flag);
							if (this.m_headIndex <= num)
							{
								int num2 = num & this.m_mask;
								obj = Volatile.Read<IThreadPoolWorkItem>(ref this.m_array[num2]);
								if (obj == null)
								{
									continue;
								}
								this.m_array[num2] = null;
								result = true;
							}
							else
							{
								this.m_tailIndex = num + 1;
								obj = null;
								result = false;
							}
						}
						finally
						{
							if (flag)
							{
								this.m_foreignLock.Exit(false);
							}
						}
						return result;
					}
					num3 = (num & this.m_mask);
					obj = Volatile.Read<IThreadPoolWorkItem>(ref this.m_array[num3]);
					if (obj != null)
					{
						goto Block_2;
					}
				}
				obj = null;
				return false;
				Block_2:
				this.m_array[num3] = null;
				return true;
			}

			// Token: 0x060011C2 RID: 4546 RVA: 0x000487A8 File Offset: 0x000469A8
			public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal)
			{
				return this.TrySteal(out obj, ref missedSteal, 0);
			}

			// Token: 0x060011C3 RID: 4547 RVA: 0x000487B4 File Offset: 0x000469B4
			private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout)
			{
				obj = null;
				while (this.m_headIndex < this.m_tailIndex)
				{
					bool flag = false;
					try
					{
						this.m_foreignLock.TryEnter(millisecondsTimeout, ref flag);
						if (flag)
						{
							int headIndex = this.m_headIndex;
							Interlocked.Exchange(ref this.m_headIndex, headIndex + 1);
							if (headIndex < this.m_tailIndex)
							{
								int num = headIndex & this.m_mask;
								obj = Volatile.Read<IThreadPoolWorkItem>(ref this.m_array[num]);
								if (obj == null)
								{
									continue;
								}
								this.m_array[num] = null;
								return true;
							}
							else
							{
								this.m_headIndex = headIndex;
								obj = null;
								missedSteal = true;
							}
						}
						else
						{
							missedSteal = true;
						}
					}
					finally
					{
						if (flag)
						{
							this.m_foreignLock.Exit(false);
						}
					}
					return false;
				}
				return false;
			}

			// Token: 0x040006D6 RID: 1750
			internal volatile IThreadPoolWorkItem[] m_array = new IThreadPoolWorkItem[32];

			// Token: 0x040006D7 RID: 1751
			private volatile int m_mask = 31;

			// Token: 0x040006D8 RID: 1752
			private volatile int m_headIndex;

			// Token: 0x040006D9 RID: 1753
			private volatile int m_tailIndex;

			// Token: 0x040006DA RID: 1754
			private SpinLock m_foreignLock = new SpinLock(false);
		}

		// Token: 0x020001E8 RID: 488
		internal class QueueSegment
		{
			// Token: 0x060011C5 RID: 4549 RVA: 0x000488AC File Offset: 0x00046AAC
			private void GetIndexes(out int upper, out int lower)
			{
				int num = this.indexes;
				upper = (num >> 16 & 65535);
				lower = (num & 65535);
			}

			// Token: 0x060011C6 RID: 4550 RVA: 0x000488D8 File Offset: 0x00046AD8
			private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower)
			{
				int num = prevUpper << 16 | (prevLower & 65535);
				int value = newUpper << 16 | (newLower & 65535);
				int num2 = Interlocked.CompareExchange(ref this.indexes, value, num);
				prevUpper = (num2 >> 16 & 65535);
				prevLower = (num2 & 65535);
				return num2 == num;
			}

			// Token: 0x060011C7 RID: 4551 RVA: 0x00048929 File Offset: 0x00046B29
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
			public QueueSegment()
			{
				this.nodes = new IThreadPoolWorkItem[256];
			}

			// Token: 0x060011C8 RID: 4552 RVA: 0x00048944 File Offset: 0x00046B44
			public bool IsUsedUp()
			{
				int num;
				int num2;
				this.GetIndexes(out num, out num2);
				return num == this.nodes.Length && num2 == this.nodes.Length;
			}

			// Token: 0x060011C9 RID: 4553 RVA: 0x00048974 File Offset: 0x00046B74
			public bool TryEnqueue(IThreadPoolWorkItem node)
			{
				int num;
				int newLower;
				this.GetIndexes(out num, out newLower);
				while (num != this.nodes.Length)
				{
					if (this.CompareExchangeIndexes(ref num, num + 1, ref newLower, newLower))
					{
						Volatile.Write<IThreadPoolWorkItem>(ref this.nodes[num], node);
						return true;
					}
				}
				return false;
			}

			// Token: 0x060011CA RID: 4554 RVA: 0x000489BC File Offset: 0x00046BBC
			public bool TryDequeue(out IThreadPoolWorkItem node)
			{
				int num;
				int num2;
				this.GetIndexes(out num, out num2);
				while (num2 != num)
				{
					if (this.CompareExchangeIndexes(ref num, num, ref num2, num2 + 1))
					{
						SpinWait spinWait = default(SpinWait);
						for (;;)
						{
							IThreadPoolWorkItem threadPoolWorkItem;
							node = (threadPoolWorkItem = Volatile.Read<IThreadPoolWorkItem>(ref this.nodes[num2]));
							if (threadPoolWorkItem != null)
							{
								break;
							}
							spinWait.SpinOnce();
						}
						this.nodes[num2] = null;
						return true;
					}
				}
				node = null;
				return false;
			}

			// Token: 0x040006DB RID: 1755
			internal readonly IThreadPoolWorkItem[] nodes;

			// Token: 0x040006DC RID: 1756
			private volatile int indexes;

			// Token: 0x040006DD RID: 1757
			public volatile ThreadPoolWorkQueue.QueueSegment Next;
		}
	}
}
