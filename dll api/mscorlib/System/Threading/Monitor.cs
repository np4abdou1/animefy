using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Security;

namespace System.Threading
{
	/// <summary>Provides a mechanism that synchronizes access to objects.</summary>
	// Token: 0x020001D9 RID: 473
	public static class Monitor
	{
		/// <summary>Acquires an exclusive lock on the specified object.</summary>
		/// <param name="obj">The object on which to acquire the monitor lock. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001146 RID: 4422
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Enter(object obj);

		/// <summary>Acquires an exclusive lock on the specified object, and atomically sets a value that indicates whether the lock was taken.</summary>
		/// <param name="obj">The object on which to wait. </param>
		/// <param name="lockTaken">The result of the attempt to acquire the lock, passed by reference. The input must be <see langword="false" />. The output is <see langword="true" /> if the lock is acquired; otherwise, the output is <see langword="false" />. The output is set even if an exception occurs during the attempt to acquire the lock. Note   If no exception occurs, the output of this method is always <see langword="true" />.</param>
		/// <exception cref="T:System.ArgumentException">The input to <paramref name="lockTaken" /> is <see langword="true" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001147 RID: 4423 RVA: 0x00047713 File Offset: 0x00045913
		public static void Enter(object obj, ref bool lockTaken)
		{
			if (lockTaken)
			{
				Monitor.ThrowLockTakenException();
			}
			Monitor.ReliableEnter(obj, ref lockTaken);
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00047725 File Offset: 0x00045925
		private static void ThrowLockTakenException()
		{
			throw new ArgumentException(Environment.GetResourceString("Argument must be initialized to false"), "lockTaken");
		}

		/// <summary>Releases an exclusive lock on the specified object.</summary>
		/// <param name="obj">The object on which to release the lock. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">The current thread does not own the lock for the specified object. </exception>
		// Token: 0x06001149 RID: 4425
		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Exit(object obj);

		/// <summary>Attempts to acquire an exclusive lock on the specified object, and atomically sets a value that indicates whether the lock was taken.</summary>
		/// <param name="obj">The object on which to acquire the lock. </param>
		/// <param name="lockTaken">The result of the attempt to acquire the lock, passed by reference. The input must be <see langword="false" />. The output is <see langword="true" /> if the lock is acquired; otherwise, the output is <see langword="false" />. The output is set even if an exception occurs during the attempt to acquire the lock.</param>
		/// <exception cref="T:System.ArgumentException">The input to <paramref name="lockTaken" /> is <see langword="true" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is <see langword="null" />. </exception>
		// Token: 0x0600114A RID: 4426 RVA: 0x0004773B File Offset: 0x0004593B
		public static void TryEnter(object obj, ref bool lockTaken)
		{
			if (lockTaken)
			{
				Monitor.ThrowLockTakenException();
			}
			Monitor.ReliableEnterTimeout(obj, 0, ref lockTaken);
		}

		/// <summary>Releases the lock on an object and blocks the current thread until it reacquires the lock. If the specified time-out interval elapses, the thread enters the ready queue. This method also specifies whether the synchronization domain for the context (if in a synchronized context) is exited before the wait and reacquired afterward.</summary>
		/// <param name="obj">The object on which to wait. </param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait before the thread enters the ready queue. </param>
		/// <param name="exitContext">
		///       <see langword="true" /> to exit and reacquire the synchronization domain for the context (if in a synchronized context) before the wait; otherwise, <see langword="false" />. </param>
		/// <returns>
		///     <see langword="true" /> if the lock was reacquired before the specified time elapsed; <see langword="false" /> if the lock was reacquired after the specified time elapsed. The method does not return until the lock is reacquired.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">
		///         <see langword="Wait" /> is not invoked from within a synchronized block of code. </exception>
		/// <exception cref="T:System.Threading.ThreadInterruptedException">The thread that invokes <see langword="Wait" /> is later interrupted from the waiting state. This happens when another thread calls this thread's <see cref="M:System.Threading.Thread.Interrupt" /> method. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of the <paramref name="millisecondsTimeout" /> parameter is negative, and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		// Token: 0x0600114B RID: 4427 RVA: 0x0004774E File Offset: 0x0004594E
		[SecuritySafeCritical]
		public static bool Wait(object obj, int millisecondsTimeout, bool exitContext)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			return Monitor.ObjWait(exitContext, millisecondsTimeout, obj);
		}

		/// <summary>Releases the lock on an object and blocks the current thread until it reacquires the lock. If the specified time-out interval elapses, the thread enters the ready queue.</summary>
		/// <param name="obj">The object on which to wait. </param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait before the thread enters the ready queue. </param>
		/// <returns>
		///     <see langword="true" /> if the lock was reacquired before the specified time elapsed; <see langword="false" /> if the lock was reacquired after the specified time elapsed. The method does not return until the lock is reacquired.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">The calling thread does not own the lock for the specified object. </exception>
		/// <exception cref="T:System.Threading.ThreadInterruptedException">The thread that invokes <see langword="Wait" /> is later interrupted from the waiting state. This happens when another thread calls this thread's <see cref="M:System.Threading.Thread.Interrupt" /> method. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of the <paramref name="millisecondsTimeout" /> parameter is negative, and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />. </exception>
		// Token: 0x0600114C RID: 4428 RVA: 0x00047766 File Offset: 0x00045966
		public static bool Wait(object obj, int millisecondsTimeout)
		{
			return Monitor.Wait(obj, millisecondsTimeout, false);
		}

		/// <summary>Notifies a thread in the waiting queue of a change in the locked object's state.</summary>
		/// <param name="obj">The object a thread is waiting for. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">The calling thread does not own the lock for the specified object. </exception>
		// Token: 0x0600114D RID: 4429 RVA: 0x00047770 File Offset: 0x00045970
		[SecuritySafeCritical]
		public static void Pulse(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			Monitor.ObjPulse(obj);
		}

		/// <summary>Notifies all waiting threads of a change in the object's state.</summary>
		/// <param name="obj">The object that sends the pulse. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">The calling thread does not own the lock for the specified object. </exception>
		// Token: 0x0600114E RID: 4430 RVA: 0x00047786 File Offset: 0x00045986
		[SecuritySafeCritical]
		public static void PulseAll(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			Monitor.ObjPulseAll(obj);
		}

		// Token: 0x0600114F RID: 4431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Monitor_test_synchronised(object obj);

		// Token: 0x06001150 RID: 4432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Monitor_pulse(object obj);

		// Token: 0x06001151 RID: 4433 RVA: 0x0004779C File Offset: 0x0004599C
		private static void ObjPulse(object obj)
		{
			if (!Monitor.Monitor_test_synchronised(obj))
			{
				throw new SynchronizationLockException("Object is not synchronized");
			}
			Monitor.Monitor_pulse(obj);
		}

		// Token: 0x06001152 RID: 4434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Monitor_pulse_all(object obj);

		// Token: 0x06001153 RID: 4435 RVA: 0x000477B7 File Offset: 0x000459B7
		private static void ObjPulseAll(object obj)
		{
			if (!Monitor.Monitor_test_synchronised(obj))
			{
				throw new SynchronizationLockException("Object is not synchronized");
			}
			Monitor.Monitor_pulse_all(obj);
		}

		// Token: 0x06001154 RID: 4436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Monitor_wait(object obj, int ms);

		// Token: 0x06001155 RID: 4437 RVA: 0x000477D4 File Offset: 0x000459D4
		private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj)
		{
			if (millisecondsTimeout < 0 && millisecondsTimeout != -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout");
			}
			if (!Monitor.Monitor_test_synchronised(obj))
			{
				throw new SynchronizationLockException("Object is not synchronized");
			}
			bool result;
			try
			{
				if (exitContext)
				{
					SynchronizationAttribute.ExitContext();
				}
				result = Monitor.Monitor_wait(obj, millisecondsTimeout);
			}
			finally
			{
				if (exitContext)
				{
					SynchronizationAttribute.EnterContext();
				}
			}
			return result;
		}

		// Token: 0x06001156 RID: 4438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken);

		// Token: 0x06001157 RID: 4439 RVA: 0x00047834 File Offset: 0x00045A34
		private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (timeout < 0 && timeout != -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout");
			}
			Monitor.try_enter_with_atomic_var(obj, timeout, ref lockTaken);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x0004785F File Offset: 0x00045A5F
		private static void ReliableEnter(object obj, ref bool lockTaken)
		{
			Monitor.ReliableEnterTimeout(obj, -1, ref lockTaken);
		}
	}
}
