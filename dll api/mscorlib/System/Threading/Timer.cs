using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Threading
{
	/// <summary>Provides a mechanism for executing a method on a thread pool thread at specified intervals. This class cannot be inherited.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x020001F6 RID: 502
	[ComVisible(true)]
	public sealed class Timer : MarshalByRefObject, IDisposable
	{
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00049A60 File Offset: 0x00047C60
		private static Timer.Scheduler scheduler
		{
			get
			{
				return Timer.Scheduler.Instance;
			}
		}

		/// <summary>Initializes a new instance of the <see langword="Timer" /> class, using a 32-bit signed integer to specify the time interval.</summary>
		/// <param name="callback">A <see cref="T:System.Threading.TimerCallback" /> delegate representing a method to be executed. </param>
		/// <param name="state">An object containing information to be used by the callback method, or <see langword="null" />. </param>
		/// <param name="dueTime">The amount of time to delay before <paramref name="callback" /> is invoked, in milliseconds. Specify <see cref="F:System.Threading.Timeout.Infinite" /> to prevent the timer from starting. Specify zero (0) to start the timer immediately. </param>
		/// <param name="period">The time interval between invocations of <paramref name="callback" />, in milliseconds. Specify <see cref="F:System.Threading.Timeout.Infinite" /> to disable periodic signaling. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="dueTime" /> or <paramref name="period" /> parameter is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="callback" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001231 RID: 4657 RVA: 0x00049A67 File Offset: 0x00047C67
		public Timer(TimerCallback callback, object state, int dueTime, int period)
		{
			this.Init(callback, state, (long)dueTime, (long)period);
		}

		/// <summary>Initializes a new instance of the <see langword="Timer" /> class, using <see cref="T:System.TimeSpan" /> values to measure time intervals.</summary>
		/// <param name="callback">A delegate representing a method to be executed. </param>
		/// <param name="state">An object containing information to be used by the callback method, or <see langword="null" />. </param>
		/// <param name="dueTime">The amount of time to delay before the <paramref name="callback" /> parameter invokes its methods. Specify negative one (-1) milliseconds to prevent the timer from starting. Specify zero (0) to start the timer immediately. </param>
		/// <param name="period">The time interval between invocations of the methods referenced by <paramref name="callback" />. Specify negative one (-1) milliseconds to disable periodic signaling. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The number of milliseconds in the value of <paramref name="dueTime" /> or <paramref name="period" /> is negative and not equal to <see cref="F:System.Threading.Timeout.Infinite" />, or is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="callback" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001232 RID: 4658 RVA: 0x00049A7C File Offset: 0x00047C7C
		public Timer(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period)
		{
			this.Init(callback, state, (long)dueTime.TotalMilliseconds, (long)period.TotalMilliseconds);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00049A9C File Offset: 0x00047C9C
		private void Init(TimerCallback callback, object state, long dueTime, long period)
		{
			if (callback == null)
			{
				throw new ArgumentNullException("callback");
			}
			this.callback = callback;
			this.state = state;
			this.is_dead = false;
			this.is_added = false;
			this.Change(dueTime, period, true);
		}

		/// <summary>Changes the start time and the interval between method invocations for a timer, using 32-bit signed integers to measure time intervals.</summary>
		/// <param name="dueTime">The amount of time to delay before the invoking the callback method specified when the <see cref="T:System.Threading.Timer" /> was constructed, in milliseconds. Specify <see cref="F:System.Threading.Timeout.Infinite" /> to prevent the timer from restarting. Specify zero (0) to restart the timer immediately. </param>
		/// <param name="period">The time interval between invocations of the callback method specified when the <see cref="T:System.Threading.Timer" /> was constructed, in milliseconds. Specify <see cref="F:System.Threading.Timeout.Infinite" /> to disable periodic signaling. </param>
		/// <returns>
		///     <see langword="true" /> if the timer was successfully updated; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Timer" /> has already been disposed. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="dueTime" /> or <paramref name="period" /> parameter is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />. </exception>
		// Token: 0x06001234 RID: 4660 RVA: 0x00049AD3 File Offset: 0x00047CD3
		public bool Change(int dueTime, int period)
		{
			return this.Change((long)dueTime, (long)period, false);
		}

		/// <summary>Changes the start time and the interval between method invocations for a timer, using <see cref="T:System.TimeSpan" /> values to measure time intervals.</summary>
		/// <param name="dueTime">A <see cref="T:System.TimeSpan" /> representing the amount of time to delay before invoking the callback method specified when the <see cref="T:System.Threading.Timer" /> was constructed. Specify negative one (-1) milliseconds to prevent the timer from restarting. Specify zero (0) to restart the timer immediately. </param>
		/// <param name="period">The time interval between invocations of the callback method specified when the <see cref="T:System.Threading.Timer" /> was constructed. Specify negative one (-1) milliseconds to disable periodic signaling. </param>
		/// <returns>
		///     <see langword="true" /> if the timer was successfully updated; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Timer" /> has already been disposed. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="dueTime" /> or <paramref name="period" /> parameter, in milliseconds, is less than -1. </exception>
		/// <exception cref="T:System.NotSupportedException">The <paramref name="dueTime" /> or <paramref name="period" /> parameter, in milliseconds, is greater than 4294967294. </exception>
		// Token: 0x06001235 RID: 4661 RVA: 0x00049AE0 File Offset: 0x00047CE0
		public bool Change(TimeSpan dueTime, TimeSpan period)
		{
			return this.Change((long)dueTime.TotalMilliseconds, (long)period.TotalMilliseconds, false);
		}

		/// <summary>Releases all resources used by the current instance of <see cref="T:System.Threading.Timer" />.</summary>
		// Token: 0x06001236 RID: 4662 RVA: 0x00049AF9 File Offset: 0x00047CF9
		public void Dispose()
		{
			if (this.disposed)
			{
				return;
			}
			this.disposed = true;
			Timer.scheduler.Remove(this);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00049B18 File Offset: 0x00047D18
		private bool Change(long dueTime, long period, bool first)
		{
			if (dueTime > (long)((ulong)-2))
			{
				throw new ArgumentOutOfRangeException("dueTime", "Due time too large");
			}
			if (period > (long)((ulong)-2))
			{
				throw new ArgumentOutOfRangeException("period", "Period too large");
			}
			if (dueTime < -1L)
			{
				throw new ArgumentOutOfRangeException("dueTime");
			}
			if (period < -1L)
			{
				throw new ArgumentOutOfRangeException("period");
			}
			if (this.disposed)
			{
				throw new ObjectDisposedException(null, Environment.GetResourceString("Cannot access a disposed object."));
			}
			this.due_time_ms = dueTime;
			this.period_ms = period;
			long new_next_run;
			if (dueTime == 0L)
			{
				new_next_run = 0L;
			}
			else if (dueTime < 0L)
			{
				new_next_run = long.MaxValue;
				if (first)
				{
					this.next_run = new_next_run;
					return true;
				}
			}
			else
			{
				new_next_run = dueTime * 10000L + Timer.GetTimeMonotonic();
			}
			Timer.scheduler.Change(this, new_next_run);
			return true;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00002A7D File Offset: 0x00000C7D
		internal void KeepRootedWhileScheduled()
		{
		}

		// Token: 0x06001239 RID: 4665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long GetTimeMonotonic();

		// Token: 0x0400072C RID: 1836
		private TimerCallback callback;

		// Token: 0x0400072D RID: 1837
		private object state;

		// Token: 0x0400072E RID: 1838
		private long due_time_ms;

		// Token: 0x0400072F RID: 1839
		private long period_ms;

		// Token: 0x04000730 RID: 1840
		private long next_run;

		// Token: 0x04000731 RID: 1841
		private bool disposed;

		// Token: 0x04000732 RID: 1842
		private bool is_dead;

		// Token: 0x04000733 RID: 1843
		private bool is_added;

		// Token: 0x020001F7 RID: 503
		private struct TimerComparer : IComparer, IComparer<Timer>
		{
			// Token: 0x0600123A RID: 4666 RVA: 0x00049BD8 File Offset: 0x00047DD8
			int IComparer.Compare(object x, object y)
			{
				if (x == y)
				{
					return 0;
				}
				Timer timer = x as Timer;
				if (timer == null)
				{
					return -1;
				}
				Timer timer2 = y as Timer;
				if (timer2 == null)
				{
					return 1;
				}
				return this.Compare(timer, timer2);
			}

			// Token: 0x0600123B RID: 4667 RVA: 0x00049C0B File Offset: 0x00047E0B
			public int Compare(Timer tx, Timer ty)
			{
				return Math.Sign(tx.next_run - ty.next_run);
			}
		}

		// Token: 0x020001F8 RID: 504
		private sealed class Scheduler
		{
			// Token: 0x0600123C RID: 4668 RVA: 0x00049C1F File Offset: 0x00047E1F
			private void InitScheduler()
			{
				this.changed = new ManualResetEvent(false);
				new Thread(new ThreadStart(this.SchedulerThread))
				{
					IsBackground = true
				}.Start();
			}

			// Token: 0x0600123D RID: 4669 RVA: 0x00049C4A File Offset: 0x00047E4A
			private void WakeupScheduler()
			{
				this.changed.Set();
			}

			// Token: 0x0600123E RID: 4670 RVA: 0x00049C58 File Offset: 0x00047E58
			private void SchedulerThread()
			{
				Thread.CurrentThread.Name = "Timer-Scheduler";
				for (;;)
				{
					int millisecondsTimeout = -1;
					lock (this)
					{
						this.changed.Reset();
						millisecondsTimeout = this.RunSchedulerLoop();
					}
					this.changed.WaitOne(millisecondsTimeout);
				}
			}

			// Token: 0x170001BE RID: 446
			// (get) Token: 0x0600123F RID: 4671 RVA: 0x00049CC0 File Offset: 0x00047EC0
			public static Timer.Scheduler Instance
			{
				get
				{
					return Timer.Scheduler.instance;
				}
			}

			// Token: 0x06001240 RID: 4672 RVA: 0x00049CC7 File Offset: 0x00047EC7
			private Scheduler()
			{
				this.list = new List<Timer>(1024);
				this.InitScheduler();
			}

			// Token: 0x06001241 RID: 4673 RVA: 0x00049D00 File Offset: 0x00047F00
			public void Remove(Timer timer)
			{
				lock (this)
				{
					this.InternalRemove(timer);
				}
			}

			// Token: 0x06001242 RID: 4674 RVA: 0x00049D3C File Offset: 0x00047F3C
			public void Change(Timer timer, long new_next_run)
			{
				if (timer.is_dead)
				{
					timer.is_dead = false;
				}
				bool flag = false;
				lock (this)
				{
					this.needReSort = true;
					if (!timer.is_added)
					{
						timer.next_run = new_next_run;
						this.Add(timer);
						flag = (this.current_next_run > new_next_run);
					}
					else
					{
						if (new_next_run == 9223372036854775807L)
						{
							timer.next_run = new_next_run;
							this.InternalRemove(timer);
							return;
						}
						if (!timer.disposed)
						{
							timer.next_run = new_next_run;
							flag = (this.current_next_run > new_next_run);
						}
					}
				}
				if (flag)
				{
					this.WakeupScheduler();
				}
			}

			// Token: 0x06001243 RID: 4675 RVA: 0x00049DEC File Offset: 0x00047FEC
			private void Add(Timer timer)
			{
				timer.is_added = true;
				this.needReSort = true;
				this.list.Add(timer);
				if (this.list.Count == 1)
				{
					this.WakeupScheduler();
				}
			}

			// Token: 0x06001244 RID: 4676 RVA: 0x00049E1E File Offset: 0x0004801E
			private void InternalRemove(Timer timer)
			{
				timer.is_dead = true;
				this.needReSort = true;
			}

			// Token: 0x06001245 RID: 4677 RVA: 0x00049E30 File Offset: 0x00048030
			private static void TimerCB(object o)
			{
				Timer timer = (Timer)o;
				timer.callback(timer.state);
			}

			// Token: 0x06001246 RID: 4678 RVA: 0x00049E58 File Offset: 0x00048058
			private void FireTimer(Timer timer)
			{
				long period_ms = timer.period_ms;
				long due_time_ms = timer.due_time_ms;
				if (period_ms == -1L || ((period_ms == 0L || period_ms == -1L) && due_time_ms != -1L))
				{
					timer.next_run = long.MaxValue;
					timer.is_dead = true;
				}
				else
				{
					timer.next_run = Timer.GetTimeMonotonic() + 10000L * timer.period_ms;
					timer.is_dead = false;
				}
				ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(Timer.Scheduler.TimerCB), timer);
			}

			// Token: 0x06001247 RID: 4679 RVA: 0x00049EDC File Offset: 0x000480DC
			private int RunSchedulerLoop()
			{
				long timeMonotonic = Timer.GetTimeMonotonic();
				Timer.TimerComparer timerComparer = default(Timer.TimerComparer);
				if (this.needReSort)
				{
					this.list.Sort(timerComparer);
					this.needReSort = false;
				}
				long num = long.MaxValue;
				for (int i = 0; i < this.list.Count; i++)
				{
					Timer timer = this.list[i];
					if (!timer.is_dead)
					{
						if (timer.next_run <= timeMonotonic)
						{
							this.FireTimer(timer);
						}
						num = Math.Min(num, timer.next_run);
						if (timer.next_run > timeMonotonic && timer.next_run < 9223372036854775807L)
						{
							timer.is_dead = false;
						}
					}
				}
				for (int i = 0; i < this.list.Count; i++)
				{
					Timer timer2 = this.list[i];
					if (timer2.is_dead)
					{
						timer2.is_added = false;
						this.needReSort = true;
						this.list[i] = this.list[this.list.Count - 1];
						i--;
						this.list.RemoveAt(this.list.Count - 1);
						if (this.list.Count == 0)
						{
							break;
						}
					}
				}
				if (this.needReSort)
				{
					this.list.Sort(timerComparer);
					this.needReSort = false;
				}
				int num2 = -1;
				this.current_next_run = num;
				if (num != 9223372036854775807L)
				{
					long num3 = (num - Timer.GetTimeMonotonic()) / 10000L;
					if (num3 > 2147483647L)
					{
						num2 = 2147483646;
					}
					else
					{
						num2 = (int)num3;
						if (num2 < 0)
						{
							num2 = 0;
						}
					}
				}
				return num2;
			}

			// Token: 0x04000734 RID: 1844
			private static readonly Timer.Scheduler instance = new Timer.Scheduler();

			// Token: 0x04000735 RID: 1845
			private volatile bool needReSort = true;

			// Token: 0x04000736 RID: 1846
			private List<Timer> list;

			// Token: 0x04000737 RID: 1847
			private long current_next_run = long.MaxValue;

			// Token: 0x04000738 RID: 1848
			private ManualResetEvent changed;
		}
	}
}
