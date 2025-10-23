using System;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Threading
{
	/// <summary>Provides a pool of threads that can be used to execute tasks, post work items, process asynchronous I/O, wait on behalf of other threads, and process timers.</summary>
	// Token: 0x020001EC RID: 492
	public static class ThreadPool
	{
		// Token: 0x060011D4 RID: 4564 RVA: 0x00048BB0 File Offset: 0x00046DB0
		[SecurityCritical]
		private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack)
		{
			if (waitObject == null)
			{
				throw new ArgumentNullException("waitObject");
			}
			if (callBack == null)
			{
				throw new ArgumentNullException("callBack");
			}
			if (millisecondsTimeOutInterval != 4294967295U && millisecondsTimeOutInterval > 2147483647U)
			{
				throw new NotSupportedException("Timeout is too big. Maximum is Int32.MaxValue");
			}
			RegisteredWaitHandle registeredWaitHandle = new RegisteredWaitHandle(waitObject, callBack, state, new TimeSpan(0, 0, 0, 0, (int)millisecondsTimeOutInterval), executeOnlyOnce);
			if (compressStack)
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(registeredWaitHandle.Wait), null);
			}
			else
			{
				ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(registeredWaitHandle.Wait), null);
			}
			return registeredWaitHandle;
		}

		/// <summary>Registers a delegate to wait for a <see cref="T:System.Threading.WaitHandle" />, specifying a <see cref="T:System.TimeSpan" /> value for the time-out.</summary>
		/// <param name="waitObject">The <see cref="T:System.Threading.WaitHandle" /> to register. Use a <see cref="T:System.Threading.WaitHandle" /> other than <see cref="T:System.Threading.Mutex" />.</param>
		/// <param name="callBack">The <see cref="T:System.Threading.WaitOrTimerCallback" /> delegate to call when the <paramref name="waitObject" /> parameter is signaled. </param>
		/// <param name="state">The object passed to the delegate. </param>
		/// <param name="timeout">The time-out represented by a <see cref="T:System.TimeSpan" />. If <paramref name="timeout" /> is 0 (zero), the function tests the object's state and returns immediately. If <paramref name="timeout" /> is -1, the function's time-out interval never elapses. </param>
		/// <param name="executeOnlyOnce">
		///       <see langword="true" /> to indicate that the thread will no longer wait on the <paramref name="waitObject" /> parameter after the delegate has been called; <see langword="false" /> to indicate that the timer is reset every time the wait operation completes until the wait is unregistered. </param>
		/// <returns>The <see cref="T:System.Threading.RegisteredWaitHandle" /> that encapsulates the native handle.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="timeout" /> parameter is less than -1. </exception>
		/// <exception cref="T:System.NotSupportedException">The <paramref name="timeout" /> parameter is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		// Token: 0x060011D5 RID: 4565 RVA: 0x00048C34 File Offset: 0x00046E34
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L)
			{
				throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			if (num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("Argument must be less than or equal to 2^31 - 1 milliseconds."));
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)num, executeOnlyOnce, ref stackCrawlMark, true);
		}

		/// <summary>Queues a method for execution, and specifies an object containing data to be used by the method. The method executes when a thread pool thread becomes available.</summary>
		/// <param name="callBack">A <see cref="T:System.Threading.WaitCallback" /> representing the method to execute. </param>
		/// <param name="state">An object containing data to be used by the method. </param>
		/// <returns>
		///     <see langword="true" /> if the method is successfully queued; <see cref="T:System.NotSupportedException" /> is thrown if the work item could not be queued.</returns>
		/// <exception cref="T:System.NotSupportedException">The common language runtime (CLR) is hosted, and the host does not support this action.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="callBack" /> is <see langword="null" />.</exception>
		// Token: 0x060011D6 RID: 4566 RVA: 0x00048C94 File Offset: 0x00046E94
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool QueueUserWorkItem(WaitCallback callBack, object state)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.QueueUserWorkItemHelper(callBack, state, ref stackCrawlMark, true, true);
		}

		/// <summary>Queues a method for execution. The method executes when a thread pool thread becomes available.</summary>
		/// <param name="callBack">A <see cref="T:System.Threading.WaitCallback" /> that represents the method to be executed. </param>
		/// <returns>
		///     <see langword="true" /> if the method is successfully queued; <see cref="T:System.NotSupportedException" /> is thrown if the work item could not be queued.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="callBack" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">The common language runtime (CLR) is hosted, and the host does not support this action.</exception>
		// Token: 0x060011D7 RID: 4567 RVA: 0x00048CB0 File Offset: 0x00046EB0
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool QueueUserWorkItem(WaitCallback callBack)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.QueueUserWorkItemHelper(callBack, null, ref stackCrawlMark, true, true);
		}

		/// <summary>Queues the specified delegate to the thread pool, but does not propagate the calling stack to the worker thread.</summary>
		/// <param name="callBack">A <see cref="T:System.Threading.WaitCallback" /> that represents the delegate to invoke when a thread in the thread pool picks up the work item. </param>
		/// <param name="state">The object that is passed to the delegate when serviced from the thread pool. </param>
		/// <returns>
		///     <see langword="true" /> if the method succeeds; <see cref="T:System.OutOfMemoryException" /> is thrown if the work item could not be queued.</returns>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ApplicationException">An out-of-memory condition was encountered.</exception>
		/// <exception cref="T:System.OutOfMemoryException">The work item could not be queued.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="callBack" /> is <see langword="null" />.</exception>
		// Token: 0x060011D8 RID: 4568 RVA: 0x00048CCC File Offset: 0x00046ECC
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.QueueUserWorkItemHelper(callBack, state, ref stackCrawlMark, false, true);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00048CE8 File Offset: 0x00046EE8
		public static bool QueueUserWorkItem<TState>(Action<TState> callBack, TState state, bool preferLocal)
		{
			if (callBack == null)
			{
				throw new ArgumentNullException("callBack");
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.QueueUserWorkItemHelper(delegate(object x)
			{
				callBack((TState)((object)x));
			}, state, ref stackCrawlMark, true, !preferLocal);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00048D34 File Offset: 0x00046F34
		[SecurityCritical]
		private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = true)
		{
			bool result = true;
			if (callBack != null)
			{
				ThreadPool.EnsureVMInitialized();
				try
				{
					return result;
				}
				finally
				{
					QueueUserWorkItemCallback callback = new QueueUserWorkItemCallback(callBack, state, compressStack, ref stackMark);
					ThreadPoolGlobals.workQueue.Enqueue(callback, forceGlobal);
					result = true;
				}
			}
			throw new ArgumentNullException("WaitCallback");
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00048D84 File Offset: 0x00046F84
		[SecurityCritical]
		internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal)
		{
			ThreadPool.EnsureVMInitialized();
			try
			{
			}
			finally
			{
				ThreadPoolGlobals.workQueue.Enqueue(workItem, forceGlobal);
			}
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00048DB8 File Offset: 0x00046FB8
		[SecurityCritical]
		internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem)
		{
			return ThreadPoolGlobals.vmTpInitialized && ThreadPoolGlobals.workQueue.LocalFindAndPop(workItem);
		}

		// Token: 0x060011DD RID: 4573
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool RequestWorkerThread();

		// Token: 0x060011DE RID: 4574 RVA: 0x00048DD0 File Offset: 0x00046FD0
		[SecurityCritical]
		private static void EnsureVMInitialized()
		{
			if (!ThreadPoolGlobals.vmTpInitialized)
			{
				ThreadPool.InitializeVMTp(ref ThreadPoolGlobals.enableWorkerTracking);
				ThreadPoolGlobals.vmTpInitialized = true;
			}
		}

		// Token: 0x060011DF RID: 4575
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool NotifyWorkItemComplete();

		// Token: 0x060011E0 RID: 4576
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void ReportThreadStatus(bool isWorking);

		// Token: 0x060011E1 RID: 4577 RVA: 0x00048DED File Offset: 0x00046FED
		[SecuritySafeCritical]
		internal static void NotifyWorkItemProgress()
		{
			ThreadPool.EnsureVMInitialized();
			ThreadPool.NotifyWorkItemProgressNative();
		}

		// Token: 0x060011E2 RID: 4578
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void NotifyWorkItemProgressNative();

		// Token: 0x060011E3 RID: 4579
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void NotifyWorkItemQueued();

		// Token: 0x060011E4 RID: 4580
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitializeVMTp(ref bool enableWorkerTracking);

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x00048DF9 File Offset: 0x00046FF9
		internal static bool IsThreadPoolThread
		{
			get
			{
				return Thread.CurrentThread.IsThreadPoolThread;
			}
		}
	}
}
