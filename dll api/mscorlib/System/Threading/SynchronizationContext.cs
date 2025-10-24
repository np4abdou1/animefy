using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System.Threading
{
	/// <summary>Provides the basic functionality for propagating a synchronization context in various synchronization models. </summary>
	// Token: 0x020001DB RID: 475
	public class SynchronizationContext
	{
		/// <summary>Determines if wait notification is required.</summary>
		/// <returns>
		///     <see langword="true" /> if wait notification is required; otherwise, <see langword="false" />. </returns>
		// Token: 0x0600115A RID: 4442 RVA: 0x00047869 File Offset: 0x00045A69
		public bool IsWaitNotificationRequired()
		{
			return (this._props & SynchronizationContextProperties.RequireWaitNotification) > SynchronizationContextProperties.None;
		}

		/// <summary>When overridden in a derived class, dispatches a synchronous message to a synchronization context.</summary>
		/// <param name="d">The <see cref="T:System.Threading.SendOrPostCallback" /> delegate to call.</param>
		/// <param name="state">The object passed to the delegate. </param>
		/// <exception cref="T:System.NotSupportedException">The method was called in a Windows Store app. The implementation of <see cref="T:System.Threading.SynchronizationContext" /> for Windows Store apps does not support the <see cref="M:System.Threading.SynchronizationContext.Send(System.Threading.SendOrPostCallback,System.Object)" /> method. </exception>
		// Token: 0x0600115B RID: 4443 RVA: 0x00047876 File Offset: 0x00045A76
		public virtual void Send(SendOrPostCallback d, object state)
		{
			d(state);
		}

		/// <summary>When overridden in a derived class, dispatches an asynchronous message to a synchronization context.</summary>
		/// <param name="d">The <see cref="T:System.Threading.SendOrPostCallback" /> delegate to call.</param>
		/// <param name="state">The object passed to the delegate.</param>
		// Token: 0x0600115C RID: 4444 RVA: 0x0004787F File Offset: 0x00045A7F
		public virtual void Post(SendOrPostCallback d, object state)
		{
			ThreadPool.QueueUserWorkItem(new WaitCallback(d.Invoke), state);
		}

		/// <summary>When overridden in a derived class, responds to the notification that an operation has started.</summary>
		// Token: 0x0600115D RID: 4445 RVA: 0x00002A7D File Offset: 0x00000C7D
		public virtual void OperationStarted()
		{
		}

		/// <summary>When overridden in a derived class, responds to the notification that an operation has completed.</summary>
		// Token: 0x0600115E RID: 4446 RVA: 0x00002A7D File Offset: 0x00000C7D
		public virtual void OperationCompleted()
		{
		}

		/// <summary>Waits for any or all the elements in the specified array to receive a signal.</summary>
		/// <param name="waitHandles">An array of type <see cref="T:System.IntPtr" /> that contains the native operating system handles.</param>
		/// <param name="waitAll">
		///       <see langword="true" /> to wait for all handles; <see langword="false" /> to wait for any handle. </param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <returns>The array index of the object that satisfied the wait.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="waitHandles" /> is null.</exception>
		// Token: 0x0600115F RID: 4447 RVA: 0x00047894 File Offset: 0x00045A94
		[SecurityCritical]
		[CLSCompliant(false)]
		[PrePrepareMethod]
		public virtual int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
			if (waitHandles == null)
			{
				throw new ArgumentNullException("waitHandles");
			}
			return SynchronizationContext.WaitHelper(waitHandles, waitAll, millisecondsTimeout);
		}

		/// <summary>Helper function that waits for any or all the elements in the specified array to receive a signal.</summary>
		/// <param name="waitHandles">An array of type <see cref="T:System.IntPtr" /> that contains the native operating system handles.</param>
		/// <param name="waitAll">
		///       <see langword="true" /> to wait for all handles;  <see langword="false" /> to wait for any handle. </param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <returns>The array index of the object that satisfied the wait.</returns>
		// Token: 0x06001160 RID: 4448 RVA: 0x000478AC File Offset: 0x00045AAC
		[SecurityCritical]
		[CLSCompliant(false)]
		[PrePrepareMethod]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		protected unsafe static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
			IntPtr* handles;
			if (waitHandles == null || waitHandles.Length == 0)
			{
				handles = null;
			}
			else
			{
				handles = &waitHandles[0];
			}
			return WaitHandle.Wait_internal(handles, waitHandles.Length, waitAll, millisecondsTimeout);
		}

		/// <summary>Sets the current synchronization context.</summary>
		/// <param name="syncContext">The <see cref="T:System.Threading.SynchronizationContext" /> object to be set.</param>
		// Token: 0x06001161 RID: 4449 RVA: 0x000478DC File Offset: 0x00045ADC
		[SecurityCritical]
		public static void SetSynchronizationContext(SynchronizationContext syncContext)
		{
			ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
			mutableExecutionContext.SynchronizationContext = syncContext;
			mutableExecutionContext.SynchronizationContextNoFlow = syncContext;
		}

		/// <summary>Gets the synchronization context for the current thread.</summary>
		/// <returns>A <see cref="T:System.Threading.SynchronizationContext" /> object representing the current synchronization context.</returns>
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x000478F8 File Offset: 0x00045AF8
		public static SynchronizationContext Current
		{
			get
			{
				return Thread.CurrentThread.GetExecutionContextReader().SynchronizationContext ?? SynchronizationContext.GetThreadLocalContext();
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x00047920 File Offset: 0x00045B20
		internal static SynchronizationContext CurrentNoFlow
		{
			[FriendAccessAllowed]
			get
			{
				return Thread.CurrentThread.GetExecutionContextReader().SynchronizationContextNoFlow ?? SynchronizationContext.GetThreadLocalContext();
			}
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00047948 File Offset: 0x00045B48
		private static SynchronizationContext GetThreadLocalContext()
		{
			SynchronizationContext synchronizationContext = null;
			if (synchronizationContext == null)
			{
				synchronizationContext = AndroidPlatform.GetDefaultSyncContext();
			}
			return synchronizationContext;
		}

		/// <summary>When overridden in a derived class, creates a copy of the synchronization context.  </summary>
		/// <returns>A new <see cref="T:System.Threading.SynchronizationContext" /> object.</returns>
		// Token: 0x06001165 RID: 4453 RVA: 0x00047961 File Offset: 0x00045B61
		public virtual SynchronizationContext CreateCopy()
		{
			return new SynchronizationContext();
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x00047968 File Offset: 0x00045B68
		internal static SynchronizationContext CurrentExplicit
		{
			get
			{
				return SynchronizationContext.Current;
			}
		}

		// Token: 0x040006B4 RID: 1716
		private SynchronizationContextProperties _props;
	}
}
