using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000175 RID: 373
	internal static class TimerThread
	{
		// Token: 0x06000A29 RID: 2601 RVA: 0x00035DD4 File Offset: 0x00033FD4
		static TimerThread()
		{
			TimerThread.s_ThreadEvents = new WaitHandle[]
			{
				TimerThread.s_ThreadShutdownEvent,
				TimerThread.s_ThreadReadyEvent
			};
			AppDomain.CurrentDomain.DomainUnload += TimerThread.OnDomainUnload;
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00035E4C File Offset: 0x0003404C
		internal static TimerThread.Queue CreateQueue(int durationMilliseconds)
		{
			if (durationMilliseconds == -1)
			{
				return new TimerThread.InfiniteTimerQueue();
			}
			if (durationMilliseconds < 0)
			{
				throw new ArgumentOutOfRangeException("durationMilliseconds");
			}
			LinkedList<WeakReference> obj = TimerThread.s_NewQueues;
			TimerThread.TimerQueue timerQueue;
			lock (obj)
			{
				timerQueue = new TimerThread.TimerQueue(durationMilliseconds);
				WeakReference value = new WeakReference(timerQueue);
				TimerThread.s_NewQueues.AddLast(value);
			}
			return timerQueue;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00035EBC File Offset: 0x000340BC
		internal static TimerThread.Queue GetOrCreateQueue(int durationMilliseconds)
		{
			if (durationMilliseconds == -1)
			{
				return new TimerThread.InfiniteTimerQueue();
			}
			if (durationMilliseconds < 0)
			{
				throw new ArgumentOutOfRangeException("durationMilliseconds");
			}
			WeakReference weakReference = (WeakReference)TimerThread.s_QueuesCache[durationMilliseconds];
			TimerThread.TimerQueue timerQueue;
			if (weakReference == null || (timerQueue = (TimerThread.TimerQueue)weakReference.Target) == null)
			{
				LinkedList<WeakReference> obj = TimerThread.s_NewQueues;
				lock (obj)
				{
					weakReference = (WeakReference)TimerThread.s_QueuesCache[durationMilliseconds];
					if (weakReference == null || (timerQueue = (TimerThread.TimerQueue)weakReference.Target) == null)
					{
						timerQueue = new TimerThread.TimerQueue(durationMilliseconds);
						weakReference = new WeakReference(timerQueue);
						TimerThread.s_NewQueues.AddLast(weakReference);
						TimerThread.s_QueuesCache[durationMilliseconds] = weakReference;
						if (++TimerThread.s_CacheScanIteration % 32 == 0)
						{
							List<int> list = new List<int>();
							foreach (object obj2 in TimerThread.s_QueuesCache)
							{
								DictionaryEntry dictionaryEntry = (DictionaryEntry)obj2;
								if (((WeakReference)dictionaryEntry.Value).Target == null)
								{
									list.Add((int)dictionaryEntry.Key);
								}
							}
							for (int i = 0; i < list.Count; i++)
							{
								TimerThread.s_QueuesCache.Remove(list[i]);
							}
						}
					}
				}
			}
			return timerQueue;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00036060 File Offset: 0x00034260
		private static void Prod()
		{
			TimerThread.s_ThreadReadyEvent.Set();
			if (Interlocked.CompareExchange(ref TimerThread.s_ThreadState, 1, 0) == 0)
			{
				new Thread(new ThreadStart(TimerThread.ThreadProc)).Start();
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00036094 File Offset: 0x00034294
		private static void ThreadProc()
		{
			Thread.CurrentThread.IsBackground = true;
			LinkedList<WeakReference> obj = TimerThread.s_Queues;
			lock (obj)
			{
				if (Interlocked.CompareExchange(ref TimerThread.s_ThreadState, 1, 1) == 1)
				{
					bool flag2 = true;
					while (flag2)
					{
						try
						{
							TimerThread.s_ThreadReadyEvent.Reset();
							for (;;)
							{
								if (TimerThread.s_NewQueues.Count > 0)
								{
									LinkedList<WeakReference> obj2 = TimerThread.s_NewQueues;
									lock (obj2)
									{
										for (LinkedListNode<WeakReference> first = TimerThread.s_NewQueues.First; first != null; first = TimerThread.s_NewQueues.First)
										{
											TimerThread.s_NewQueues.Remove(first);
											TimerThread.s_Queues.AddLast(first);
										}
									}
								}
								int tickCount = Environment.TickCount;
								int num = 0;
								bool flag4 = false;
								LinkedListNode<WeakReference> linkedListNode = TimerThread.s_Queues.First;
								while (linkedListNode != null)
								{
									TimerThread.TimerQueue timerQueue = (TimerThread.TimerQueue)linkedListNode.Value.Target;
									if (timerQueue == null)
									{
										LinkedListNode<WeakReference> next = linkedListNode.Next;
										TimerThread.s_Queues.Remove(linkedListNode);
										linkedListNode = next;
									}
									else
									{
										int num2;
										if (timerQueue.Fire(out num2) && (!flag4 || TimerThread.IsTickBetween(tickCount, num, num2)))
										{
											num = num2;
											flag4 = true;
										}
										linkedListNode = linkedListNode.Next;
									}
								}
								int tickCount2 = Environment.TickCount;
								int millisecondsTimeout = (int)(flag4 ? (TimerThread.IsTickBetween(tickCount, num, tickCount2) ? (Math.Min((uint)(num - tickCount2), 2147483632U) + 15U) : 0U) : 30000U);
								int num3 = WaitHandle.WaitAny(TimerThread.s_ThreadEvents, millisecondsTimeout, false);
								if (num3 == 0)
								{
									break;
								}
								if (num3 == 258 && !flag4)
								{
									Interlocked.CompareExchange(ref TimerThread.s_ThreadState, 0, 1);
									if (!TimerThread.s_ThreadReadyEvent.WaitOne(0, false) || Interlocked.CompareExchange(ref TimerThread.s_ThreadState, 1, 0) != 0)
									{
										goto IL_1A8;
									}
								}
							}
							flag2 = false;
							continue;
							IL_1A8:
							flag2 = false;
						}
						catch (Exception exception)
						{
							if (NclUtilities.IsFatal(exception))
							{
								throw;
							}
							bool on = Logging.On;
							Thread.Sleep(1000);
						}
					}
				}
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000362C8 File Offset: 0x000344C8
		private static void StopTimerThread()
		{
			Interlocked.Exchange(ref TimerThread.s_ThreadState, 2);
			TimerThread.s_ThreadShutdownEvent.Set();
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x000362E1 File Offset: 0x000344E1
		private static bool IsTickBetween(int start, int end, int comparand)
		{
			return start <= comparand == end <= comparand != start <= end;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00036300 File Offset: 0x00034500
		private static void OnDomainUnload(object sender, EventArgs e)
		{
			try
			{
				TimerThread.StopTimerThread();
			}
			catch
			{
			}
		}

		// Token: 0x04000767 RID: 1895
		private static LinkedList<WeakReference> s_Queues = new LinkedList<WeakReference>();

		// Token: 0x04000768 RID: 1896
		private static LinkedList<WeakReference> s_NewQueues = new LinkedList<WeakReference>();

		// Token: 0x04000769 RID: 1897
		private static int s_ThreadState = 0;

		// Token: 0x0400076A RID: 1898
		private static AutoResetEvent s_ThreadReadyEvent = new AutoResetEvent(false);

		// Token: 0x0400076B RID: 1899
		private static ManualResetEvent s_ThreadShutdownEvent = new ManualResetEvent(false);

		// Token: 0x0400076C RID: 1900
		private static WaitHandle[] s_ThreadEvents;

		// Token: 0x0400076D RID: 1901
		private static int s_CacheScanIteration;

		// Token: 0x0400076E RID: 1902
		private static Hashtable s_QueuesCache = new Hashtable();

		// Token: 0x02000176 RID: 374
		internal abstract class Queue
		{
			// Token: 0x06000A31 RID: 2609 RVA: 0x00036328 File Offset: 0x00034528
			internal Queue(int durationMilliseconds)
			{
				this.m_DurationMilliseconds = durationMilliseconds;
			}

			// Token: 0x170001D8 RID: 472
			// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00036337 File Offset: 0x00034537
			internal int Duration
			{
				get
				{
					return this.m_DurationMilliseconds;
				}
			}

			// Token: 0x06000A33 RID: 2611
			internal abstract TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context);

			// Token: 0x0400076F RID: 1903
			private readonly int m_DurationMilliseconds;
		}

		// Token: 0x02000177 RID: 375
		internal abstract class Timer : IDisposable
		{
			// Token: 0x06000A34 RID: 2612 RVA: 0x0003633F File Offset: 0x0003453F
			internal Timer(int durationMilliseconds)
			{
				this.m_DurationMilliseconds = durationMilliseconds;
				this.m_StartTimeMilliseconds = Environment.TickCount;
			}

			// Token: 0x170001D9 RID: 473
			// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00036359 File Offset: 0x00034559
			internal int StartTime
			{
				get
				{
					return this.m_StartTimeMilliseconds;
				}
			}

			// Token: 0x170001DA RID: 474
			// (get) Token: 0x06000A36 RID: 2614 RVA: 0x00036361 File Offset: 0x00034561
			internal int Expiration
			{
				get
				{
					return this.m_StartTimeMilliseconds + this.m_DurationMilliseconds;
				}
			}

			// Token: 0x06000A37 RID: 2615
			internal abstract bool Cancel();

			// Token: 0x170001DB RID: 475
			// (get) Token: 0x06000A38 RID: 2616
			internal abstract bool HasExpired { get; }

			// Token: 0x06000A39 RID: 2617 RVA: 0x00036370 File Offset: 0x00034570
			public void Dispose()
			{
				this.Cancel();
			}

			// Token: 0x04000770 RID: 1904
			private readonly int m_StartTimeMilliseconds;

			// Token: 0x04000771 RID: 1905
			private readonly int m_DurationMilliseconds;
		}

		// Token: 0x02000178 RID: 376
		// (Invoke) Token: 0x06000A3B RID: 2619
		internal delegate void Callback(TimerThread.Timer timer, int timeNoticed, object context);

		// Token: 0x02000179 RID: 377
		private class TimerQueue : TimerThread.Queue
		{
			// Token: 0x06000A3E RID: 2622 RVA: 0x00036379 File Offset: 0x00034579
			internal TimerQueue(int durationMilliseconds) : base(durationMilliseconds)
			{
				this.m_Timers = new TimerThread.TimerNode();
				this.m_Timers.Next = this.m_Timers;
				this.m_Timers.Prev = this.m_Timers;
			}

			// Token: 0x06000A3F RID: 2623 RVA: 0x000363B0 File Offset: 0x000345B0
			internal override TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context)
			{
				TimerThread.TimerNode timerNode = new TimerThread.TimerNode(callback, context, base.Duration, this.m_Timers);
				bool flag = false;
				TimerThread.TimerNode timers = this.m_Timers;
				lock (timers)
				{
					if (this.m_Timers.Next == this.m_Timers)
					{
						if (this.m_ThisHandle == IntPtr.Zero)
						{
							this.m_ThisHandle = (IntPtr)GCHandle.Alloc(this);
						}
						flag = true;
					}
					timerNode.Next = this.m_Timers;
					timerNode.Prev = this.m_Timers.Prev;
					this.m_Timers.Prev.Next = timerNode;
					this.m_Timers.Prev = timerNode;
				}
				if (flag)
				{
					TimerThread.Prod();
				}
				return timerNode;
			}

			// Token: 0x06000A40 RID: 2624 RVA: 0x0003647C File Offset: 0x0003467C
			internal bool Fire(out int nextExpiration)
			{
				TimerThread.TimerNode next;
				do
				{
					next = this.m_Timers.Next;
					if (next == this.m_Timers)
					{
						TimerThread.TimerNode timers = this.m_Timers;
						lock (timers)
						{
							next = this.m_Timers.Next;
							if (next == this.m_Timers)
							{
								if (this.m_ThisHandle != IntPtr.Zero)
								{
									((GCHandle)this.m_ThisHandle).Free();
									this.m_ThisHandle = IntPtr.Zero;
								}
								nextExpiration = 0;
								return false;
							}
						}
					}
				}
				while (next.Fire());
				nextExpiration = next.Expiration;
				return true;
			}

			// Token: 0x04000772 RID: 1906
			private IntPtr m_ThisHandle;

			// Token: 0x04000773 RID: 1907
			private readonly TimerThread.TimerNode m_Timers;
		}

		// Token: 0x0200017A RID: 378
		private class InfiniteTimerQueue : TimerThread.Queue
		{
			// Token: 0x06000A41 RID: 2625 RVA: 0x00036530 File Offset: 0x00034730
			internal InfiniteTimerQueue() : base(-1)
			{
			}

			// Token: 0x06000A42 RID: 2626 RVA: 0x00036539 File Offset: 0x00034739
			internal override TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context)
			{
				return new TimerThread.InfiniteTimer();
			}
		}

		// Token: 0x0200017B RID: 379
		private class TimerNode : TimerThread.Timer
		{
			// Token: 0x06000A43 RID: 2627 RVA: 0x00036540 File Offset: 0x00034740
			internal TimerNode(TimerThread.Callback callback, object context, int durationMilliseconds, object queueLock) : base(durationMilliseconds)
			{
				if (callback != null)
				{
					this.m_Callback = callback;
					this.m_Context = context;
				}
				this.m_TimerState = TimerThread.TimerNode.TimerState.Ready;
				this.m_QueueLock = queueLock;
			}

			// Token: 0x06000A44 RID: 2628 RVA: 0x00036569 File Offset: 0x00034769
			internal TimerNode() : base(0)
			{
				this.m_TimerState = TimerThread.TimerNode.TimerState.Sentinel;
			}

			// Token: 0x170001DC RID: 476
			// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00036579 File Offset: 0x00034779
			internal override bool HasExpired
			{
				get
				{
					return this.m_TimerState == TimerThread.TimerNode.TimerState.Fired;
				}
			}

			// Token: 0x170001DD RID: 477
			// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00036584 File Offset: 0x00034784
			// (set) Token: 0x06000A47 RID: 2631 RVA: 0x0003658C File Offset: 0x0003478C
			internal TimerThread.TimerNode Next
			{
				get
				{
					return this.next;
				}
				set
				{
					this.next = value;
				}
			}

			// Token: 0x170001DE RID: 478
			// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00036595 File Offset: 0x00034795
			// (set) Token: 0x06000A49 RID: 2633 RVA: 0x0003659D File Offset: 0x0003479D
			internal TimerThread.TimerNode Prev
			{
				get
				{
					return this.prev;
				}
				set
				{
					this.prev = value;
				}
			}

			// Token: 0x06000A4A RID: 2634 RVA: 0x000365A8 File Offset: 0x000347A8
			internal override bool Cancel()
			{
				if (this.m_TimerState == TimerThread.TimerNode.TimerState.Ready)
				{
					object queueLock = this.m_QueueLock;
					lock (queueLock)
					{
						if (this.m_TimerState == TimerThread.TimerNode.TimerState.Ready)
						{
							this.Next.Prev = this.Prev;
							this.Prev.Next = this.Next;
							this.Next = null;
							this.Prev = null;
							this.m_Callback = null;
							this.m_Context = null;
							this.m_TimerState = TimerThread.TimerNode.TimerState.Cancelled;
							return true;
						}
					}
					return false;
				}
				return false;
			}

			// Token: 0x06000A4B RID: 2635 RVA: 0x00036640 File Offset: 0x00034840
			internal bool Fire()
			{
				if (this.m_TimerState != TimerThread.TimerNode.TimerState.Ready)
				{
					return true;
				}
				int tickCount = Environment.TickCount;
				if (TimerThread.IsTickBetween(base.StartTime, base.Expiration, tickCount))
				{
					return false;
				}
				bool flag = false;
				object queueLock = this.m_QueueLock;
				lock (queueLock)
				{
					if (this.m_TimerState == TimerThread.TimerNode.TimerState.Ready)
					{
						this.m_TimerState = TimerThread.TimerNode.TimerState.Fired;
						this.Next.Prev = this.Prev;
						this.Prev.Next = this.Next;
						this.Next = null;
						this.Prev = null;
						flag = (this.m_Callback != null);
					}
				}
				if (flag)
				{
					try
					{
						TimerThread.Callback callback = this.m_Callback;
						object context = this.m_Context;
						this.m_Callback = null;
						this.m_Context = null;
						callback(this, tickCount, context);
					}
					catch (Exception exception)
					{
						if (NclUtilities.IsFatal(exception))
						{
							throw;
						}
						bool on = Logging.On;
					}
				}
				return true;
			}

			// Token: 0x04000774 RID: 1908
			private TimerThread.TimerNode.TimerState m_TimerState;

			// Token: 0x04000775 RID: 1909
			private TimerThread.Callback m_Callback;

			// Token: 0x04000776 RID: 1910
			private object m_Context;

			// Token: 0x04000777 RID: 1911
			private object m_QueueLock;

			// Token: 0x04000778 RID: 1912
			private TimerThread.TimerNode next;

			// Token: 0x04000779 RID: 1913
			private TimerThread.TimerNode prev;

			// Token: 0x0200017C RID: 380
			private enum TimerState
			{
				// Token: 0x0400077B RID: 1915
				Ready,
				// Token: 0x0400077C RID: 1916
				Fired,
				// Token: 0x0400077D RID: 1917
				Cancelled,
				// Token: 0x0400077E RID: 1918
				Sentinel
			}
		}

		// Token: 0x0200017D RID: 381
		private class InfiniteTimer : TimerThread.Timer
		{
			// Token: 0x06000A4C RID: 2636 RVA: 0x00036734 File Offset: 0x00034934
			internal InfiniteTimer() : base(-1)
			{
			}

			// Token: 0x170001DF RID: 479
			// (get) Token: 0x06000A4D RID: 2637 RVA: 0x000023F6 File Offset: 0x000005F6
			internal override bool HasExpired
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06000A4E RID: 2638 RVA: 0x0003673D File Offset: 0x0003493D
			internal override bool Cancel()
			{
				return Interlocked.Exchange(ref this.cancelled, 1) == 0;
			}

			// Token: 0x0400077F RID: 1919
			private int cancelled;
		}
	}
}
