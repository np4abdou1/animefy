using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;

namespace System.Threading
{
	/// <summary>Represents a lightweight alternative to <see cref="T:System.Threading.Semaphore" /> that limits the number of threads that can access a resource or pool of resources concurrently.</summary>
	// Token: 0x020001C7 RID: 455
	[ComVisible(false)]
	[DebuggerDisplay("Current Count = {m_currentCount}")]
	public class SemaphoreSlim : IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.SemaphoreSlim" /> class, specifying the initial and maximum number of requests that can be granted concurrently.</summary>
		/// <param name="initialCount">The initial number of requests for the semaphore that can be granted concurrently.</param>
		/// <param name="maxCount">The maximum number of requests for the semaphore that can be granted concurrently.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="initialCount" /> is less than 0, or <paramref name="initialCount" /> is greater than <paramref name="maxCount" />, or <paramref name="maxCount" /> is equal to or less than 0.</exception>
		// Token: 0x060010D8 RID: 4312 RVA: 0x000457C0 File Offset: 0x000439C0
		public SemaphoreSlim(int initialCount, int maxCount)
		{
			if (initialCount < 0 || initialCount > maxCount)
			{
				throw new ArgumentOutOfRangeException("initialCount", initialCount, SemaphoreSlim.GetResourceString("The initialCount argument must be non-negative and less than or equal to the maximumCount."));
			}
			if (maxCount <= 0)
			{
				throw new ArgumentOutOfRangeException("maxCount", maxCount, SemaphoreSlim.GetResourceString("The maximumCount argument must be a positive number. If a maximum is not required, use the constructor without a maxCount parameter."));
			}
			this.m_maxCount = maxCount;
			this.m_lockObj = new object();
			this.m_currentCount = initialCount;
		}

		/// <summary>Blocks the current thread until it can enter the <see cref="T:System.Threading.SemaphoreSlim" />.</summary>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception>
		// Token: 0x060010D9 RID: 4313 RVA: 0x00045830 File Offset: 0x00043A30
		public void Wait()
		{
			this.Wait(-1, default(CancellationToken));
		}

		/// <summary>Blocks the current thread until it can enter the <see cref="T:System.Threading.SemaphoreSlim" />, using a 32-bit signed integer that specifies the timeout, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" />(-1) to wait indefinitely.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe.</param>
		/// <returns>
		///     <see langword="true" /> if the current thread successfully entered the <see cref="T:System.Threading.SemaphoreSlim" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.OperationCanceledException">
		///         <paramref name="cancellationToken" /> was canceled.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.SemaphoreSlim" /> instance has been disposed, or the <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has been disposed.</exception>
		// Token: 0x060010DA RID: 4314 RVA: 0x00045850 File Offset: 0x00043A50
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			this.CheckDispose();
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("totalMilliSeconds", millisecondsTimeout, SemaphoreSlim.GetResourceString("The timeout must represent a value between -1 and Int32.MaxValue, inclusive."));
			}
			cancellationToken.ThrowIfCancellationRequested();
			if (millisecondsTimeout == 0 && this.m_currentCount == 0)
			{
				return false;
			}
			uint startTime = 0U;
			if (millisecondsTimeout != -1 && millisecondsTimeout > 0)
			{
				startTime = TimeoutHelper.GetTime();
			}
			bool result = false;
			Task<bool> task = null;
			bool flag = false;
			CancellationTokenRegistration cancellationTokenRegistration = cancellationToken.InternalRegisterWithoutEC(SemaphoreSlim.s_cancellationTokenCanceledEventHandler, this);
			try
			{
				SpinWait spinWait = default(SpinWait);
				while (this.m_currentCount == 0 && !spinWait.NextSpinWillYield)
				{
					spinWait.SpinOnce();
				}
				try
				{
				}
				finally
				{
					Monitor.Enter(this.m_lockObj, ref flag);
					if (flag)
					{
						this.m_waitCount++;
					}
				}
				if (this.m_asyncHead != null)
				{
					task = this.WaitAsync(millisecondsTimeout, cancellationToken);
				}
				else
				{
					OperationCanceledException ex = null;
					if (this.m_currentCount == 0)
					{
						if (millisecondsTimeout == 0)
						{
							return false;
						}
						try
						{
							result = this.WaitUntilCountOrTimeout(millisecondsTimeout, startTime, cancellationToken);
						}
						catch (OperationCanceledException ex)
						{
						}
					}
					if (this.m_currentCount > 0)
					{
						result = true;
						this.m_currentCount--;
					}
					else if (ex != null)
					{
						throw ex;
					}
					if (this.m_waitHandle != null && this.m_currentCount == 0)
					{
						this.m_waitHandle.Reset();
					}
				}
			}
			finally
			{
				if (flag)
				{
					this.m_waitCount--;
					Monitor.Exit(this.m_lockObj);
				}
				cancellationTokenRegistration.Dispose();
			}
			if (task == null)
			{
				return result;
			}
			return task.GetAwaiter().GetResult();
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x000459FC File Offset: 0x00043BFC
		private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken)
		{
			int num = -1;
			while (this.m_currentCount == 0)
			{
				cancellationToken.ThrowIfCancellationRequested();
				if (millisecondsTimeout != -1)
				{
					num = TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout);
					if (num <= 0)
					{
						return false;
					}
				}
				if (!Monitor.Wait(this.m_lockObj, num))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Asynchronously waits to enter the <see cref="T:System.Threading.SemaphoreSlim" />. </summary>
		/// <returns>A task that will complete when the semaphore has been entered.</returns>
		// Token: 0x060010DC RID: 4316 RVA: 0x00045A44 File Offset: 0x00043C44
		public Task WaitAsync()
		{
			return this.WaitAsync(-1, default(CancellationToken));
		}

		/// <summary>Asynchronously waits to enter the <see cref="T:System.Threading.SemaphoreSlim" />, using a 32-bit signed integer to measure the time interval, while observing a <see cref="T:System.Threading.CancellationToken" />. </summary>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe.</param>
		/// <returns>A task that will complete with a result of <see langword="true" /> if the current thread successfully entered the <see cref="T:System.Threading.SemaphoreSlim" />, otherwise with a result of <see langword="false" />. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed. </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///         <paramref name="cancellationToken" /> was canceled. </exception>
		// Token: 0x060010DD RID: 4317 RVA: 0x00045A64 File Offset: 0x00043C64
		public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			this.CheckDispose();
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("totalMilliSeconds", millisecondsTimeout, SemaphoreSlim.GetResourceString("The timeout must represent a value between -1 and Int32.MaxValue, inclusive."));
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCancellation<bool>(cancellationToken);
			}
			object lockObj = this.m_lockObj;
			Task<bool> result;
			lock (lockObj)
			{
				if (this.m_currentCount > 0)
				{
					this.m_currentCount--;
					if (this.m_waitHandle != null && this.m_currentCount == 0)
					{
						this.m_waitHandle.Reset();
					}
					result = SemaphoreSlim.s_trueTask;
				}
				else if (millisecondsTimeout == 0)
				{
					result = SemaphoreSlim.s_falseTask;
				}
				else
				{
					SemaphoreSlim.TaskNode taskNode = this.CreateAndAddAsyncWaiter();
					result = ((millisecondsTimeout == -1 && !cancellationToken.CanBeCanceled) ? taskNode : this.WaitUntilCountOrTimeoutAsync(taskNode, millisecondsTimeout, cancellationToken));
				}
			}
			return result;
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00045B48 File Offset: 0x00043D48
		private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter()
		{
			SemaphoreSlim.TaskNode taskNode = new SemaphoreSlim.TaskNode();
			if (this.m_asyncHead == null)
			{
				this.m_asyncHead = taskNode;
				this.m_asyncTail = taskNode;
			}
			else
			{
				this.m_asyncTail.Next = taskNode;
				taskNode.Prev = this.m_asyncTail;
				this.m_asyncTail = taskNode;
			}
			return taskNode;
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00045B94 File Offset: 0x00043D94
		private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task)
		{
			bool result = this.m_asyncHead == task || task.Prev != null;
			if (task.Next != null)
			{
				task.Next.Prev = task.Prev;
			}
			if (task.Prev != null)
			{
				task.Prev.Next = task.Next;
			}
			if (this.m_asyncHead == task)
			{
				this.m_asyncHead = task.Next;
			}
			if (this.m_asyncTail == task)
			{
				this.m_asyncTail = task.Prev;
			}
			task.Next = (task.Prev = null);
			return result;
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00045C24 File Offset: 0x00043E24
		private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32 <WaitUntilCountOrTimeoutAsync>d__;
			<WaitUntilCountOrTimeoutAsync>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<WaitUntilCountOrTimeoutAsync>d__.<>4__this = this;
			<WaitUntilCountOrTimeoutAsync>d__.asyncWaiter = asyncWaiter;
			<WaitUntilCountOrTimeoutAsync>d__.millisecondsTimeout = millisecondsTimeout;
			<WaitUntilCountOrTimeoutAsync>d__.cancellationToken = cancellationToken;
			<WaitUntilCountOrTimeoutAsync>d__.<>1__state = -1;
			<WaitUntilCountOrTimeoutAsync>d__.<>t__builder.Start<SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>(ref <WaitUntilCountOrTimeoutAsync>d__);
			return <WaitUntilCountOrTimeoutAsync>d__.<>t__builder.Task;
		}

		/// <summary>Releases the <see cref="T:System.Threading.SemaphoreSlim" /> object once.</summary>
		/// <returns>The previous count of the <see cref="T:System.Threading.SemaphoreSlim" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception>
		/// <exception cref="T:System.Threading.SemaphoreFullException">The <see cref="T:System.Threading.SemaphoreSlim" /> has already reached its maximum size.</exception>
		// Token: 0x060010E1 RID: 4321 RVA: 0x00045C7F File Offset: 0x00043E7F
		public int Release()
		{
			return this.Release(1);
		}

		/// <summary>Releases the <see cref="T:System.Threading.SemaphoreSlim" /> object a specified number of times.</summary>
		/// <param name="releaseCount">The number of times to exit the semaphore.</param>
		/// <returns>The previous count of the <see cref="T:System.Threading.SemaphoreSlim" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="releaseCount" /> is less than 1.</exception>
		/// <exception cref="T:System.Threading.SemaphoreFullException">The <see cref="T:System.Threading.SemaphoreSlim" /> has already reached its maximum size.</exception>
		// Token: 0x060010E2 RID: 4322 RVA: 0x00045C88 File Offset: 0x00043E88
		public int Release(int releaseCount)
		{
			this.CheckDispose();
			if (releaseCount < 1)
			{
				throw new ArgumentOutOfRangeException("releaseCount", releaseCount, SemaphoreSlim.GetResourceString("The releaseCount argument must be greater than zero."));
			}
			object lockObj = this.m_lockObj;
			int num2;
			lock (lockObj)
			{
				int num = this.m_currentCount;
				num2 = num;
				if (this.m_maxCount - num < releaseCount)
				{
					throw new SemaphoreFullException();
				}
				num += releaseCount;
				int waitCount = this.m_waitCount;
				if (num == 1 || waitCount == 1)
				{
					Monitor.Pulse(this.m_lockObj);
				}
				else if (waitCount > 1)
				{
					Monitor.PulseAll(this.m_lockObj);
				}
				if (this.m_asyncHead != null)
				{
					int num3 = num - waitCount;
					while (num3 > 0 && this.m_asyncHead != null)
					{
						num--;
						num3--;
						SemaphoreSlim.TaskNode asyncHead = this.m_asyncHead;
						this.RemoveAsyncWaiter(asyncHead);
						SemaphoreSlim.QueueWaiterTask(asyncHead);
					}
				}
				this.m_currentCount = num;
				if (this.m_waitHandle != null && num2 == 0 && num > 0)
				{
					this.m_waitHandle.Set();
				}
			}
			return num2;
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00045DA0 File Offset: 0x00043FA0
		[SecuritySafeCritical]
		private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask)
		{
			ThreadPool.UnsafeQueueCustomWorkItem(waiterTask, false);
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.SemaphoreSlim" /> class.</summary>
		// Token: 0x060010E4 RID: 4324 RVA: 0x00045DA9 File Offset: 0x00043FA9
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Threading.SemaphoreSlim" />, and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
		// Token: 0x060010E5 RID: 4325 RVA: 0x00045DB8 File Offset: 0x00043FB8
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.m_waitHandle != null)
				{
					this.m_waitHandle.Close();
					this.m_waitHandle = null;
				}
				this.m_lockObj = null;
				this.m_asyncHead = null;
				this.m_asyncTail = null;
			}
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00045DF4 File Offset: 0x00043FF4
		private static void CancellationTokenCanceledEventHandler(object obj)
		{
			SemaphoreSlim semaphoreSlim = obj as SemaphoreSlim;
			object lockObj = semaphoreSlim.m_lockObj;
			lock (lockObj)
			{
				Monitor.PulseAll(semaphoreSlim.m_lockObj);
			}
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00045E40 File Offset: 0x00044040
		private void CheckDispose()
		{
			if (this.m_lockObj == null)
			{
				throw new ObjectDisposedException(null, SemaphoreSlim.GetResourceString("The semaphore has been disposed."));
			}
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x00045E5B File Offset: 0x0004405B
		private static string GetResourceString(string str)
		{
			return Environment.GetResourceString(str);
		}

		// Token: 0x04000671 RID: 1649
		private volatile int m_currentCount;

		// Token: 0x04000672 RID: 1650
		private readonly int m_maxCount;

		// Token: 0x04000673 RID: 1651
		private volatile int m_waitCount;

		// Token: 0x04000674 RID: 1652
		private object m_lockObj;

		// Token: 0x04000675 RID: 1653
		private volatile ManualResetEvent m_waitHandle;

		// Token: 0x04000676 RID: 1654
		private SemaphoreSlim.TaskNode m_asyncHead;

		// Token: 0x04000677 RID: 1655
		private SemaphoreSlim.TaskNode m_asyncTail;

		// Token: 0x04000678 RID: 1656
		private static readonly Task<bool> s_trueTask = new Task<bool>(false, true, (TaskCreationOptions)16384, default(CancellationToken));

		// Token: 0x04000679 RID: 1657
		private static readonly Task<bool> s_falseTask = new Task<bool>(false, false, (TaskCreationOptions)16384, default(CancellationToken));

		// Token: 0x0400067A RID: 1658
		private static Action<object> s_cancellationTokenCanceledEventHandler = new Action<object>(SemaphoreSlim.CancellationTokenCanceledEventHandler);

		// Token: 0x020001C8 RID: 456
		private sealed class TaskNode : Task<bool>, IThreadPoolWorkItem
		{
			// Token: 0x060010EA RID: 4330 RVA: 0x00045EB6 File Offset: 0x000440B6
			internal TaskNode()
			{
			}

			// Token: 0x060010EB RID: 4331 RVA: 0x00045EBE File Offset: 0x000440BE
			[SecurityCritical]
			void IThreadPoolWorkItem.ExecuteWorkItem()
			{
				base.TrySetResult(true);
			}

			// Token: 0x060010EC RID: 4332 RVA: 0x00002A7D File Offset: 0x00000C7D
			[SecurityCritical]
			void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
			{
			}

			// Token: 0x0400067B RID: 1659
			internal SemaphoreSlim.TaskNode Prev;

			// Token: 0x0400067C RID: 1660
			internal SemaphoreSlim.TaskNode Next;
		}
	}
}
