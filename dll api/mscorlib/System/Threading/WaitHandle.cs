using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Contexts;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	/// <summary>Encapsulates operating system–specific objects that wait for exclusive access to shared resources.</summary>
	// Token: 0x020001EE RID: 494
	[ComVisible(true)]
	[StructLayout(0)]
	public abstract class WaitHandle : MarshalByRefObject, IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.WaitHandle" /> class.</summary>
		// Token: 0x060011E8 RID: 4584 RVA: 0x00048E18 File Offset: 0x00047018
		protected WaitHandle()
		{
			this.Init();
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00048E26 File Offset: 0x00047026
		[SecuritySafeCritical]
		private void Init()
		{
			this.safeWaitHandle = null;
			this.waitHandle = WaitHandle.InvalidHandle;
			this.hasThreadAffinity = false;
		}

		/// <summary>Gets or sets the native operating system handle.</summary>
		/// <returns>An <see langword="IntPtr" /> representing the native operating system handle. The default is the value of the <see cref="F:System.Threading.WaitHandle.InvalidHandle" /> field.</returns>
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x00048E43 File Offset: 0x00047043
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x00048E64 File Offset: 0x00047064
		public virtual IntPtr Handle
		{
			[SecuritySafeCritical]
			get
			{
				if (this.safeWaitHandle != null)
				{
					return this.safeWaitHandle.DangerousGetHandle();
				}
				return WaitHandle.InvalidHandle;
			}
			[SecurityCritical]
			set
			{
				if (value == WaitHandle.InvalidHandle)
				{
					if (this.safeWaitHandle != null)
					{
						this.safeWaitHandle.SetHandleAsInvalid();
						this.safeWaitHandle = null;
					}
				}
				else
				{
					this.safeWaitHandle = new SafeWaitHandle(value, true);
				}
				this.waitHandle = value;
			}
		}

		/// <summary>Gets or sets the native operating system handle.</summary>
		/// <returns>A <see cref="T:Microsoft.Win32.SafeHandles.SafeWaitHandle" /> representing the native operating system handle.</returns>
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x00048EB6 File Offset: 0x000470B6
		// (set) Token: 0x060011ED RID: 4589 RVA: 0x00048EE0 File Offset: 0x000470E0
		public SafeWaitHandle SafeWaitHandle
		{
			[SecurityCritical]
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
			get
			{
				if (this.safeWaitHandle == null)
				{
					this.safeWaitHandle = new SafeWaitHandle(WaitHandle.InvalidHandle, false);
				}
				return this.safeWaitHandle;
			}
			[SecurityCritical]
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			set
			{
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
				}
				finally
				{
					if (value == null)
					{
						this.safeWaitHandle = null;
						this.waitHandle = WaitHandle.InvalidHandle;
					}
					else
					{
						this.safeWaitHandle = value;
						this.waitHandle = this.safeWaitHandle.DangerousGetHandle();
					}
				}
			}
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00048F3C File Offset: 0x0004713C
		[SecurityCritical]
		internal void SetHandleInternal(SafeWaitHandle handle)
		{
			this.safeWaitHandle = handle;
			this.waitHandle = handle.DangerousGetHandle();
		}

		/// <summary>Blocks the current thread until the current <see cref="T:System.Threading.WaitHandle" /> receives a signal, using a 32-bit signed integer to specify the time interval and specifying whether to exit the synchronization domain before the wait.</summary>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely. </param>
		/// <param name="exitContext">
		///       <see langword="true" /> to exit the synchronization domain for the context before the wait (if in a synchronized context), and reacquire it afterward; otherwise, <see langword="false" />. </param>
		/// <returns>
		///     <see langword="true" /> if the current instance receives a signal; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out. </exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">The current instance is a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
		// Token: 0x060011EF RID: 4591 RVA: 0x00048F53 File Offset: 0x00047153
		public virtual bool WaitOne(int millisecondsTimeout, bool exitContext)
		{
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			return this.WaitOne((long)millisecondsTimeout, exitContext);
		}

		/// <summary>Blocks the current thread until the current <see cref="T:System.Threading.WaitHandle" /> receives a signal.</summary>
		/// <returns>
		///     <see langword="true" /> if the current instance receives a signal. If the current instance is never signaled, <see cref="M:System.Threading.WaitHandle.WaitOne(System.Int32,System.Boolean)" /> never returns.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed. </exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">The current instance is a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
		// Token: 0x060011F0 RID: 4592 RVA: 0x00048F77 File Offset: 0x00047177
		public virtual bool WaitOne()
		{
			return this.WaitOne(-1, false);
		}

		/// <summary>Blocks the current thread until the current <see cref="T:System.Threading.WaitHandle" /> receives a signal, using a 32-bit signed integer to specify the time interval in milliseconds.</summary>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely. </param>
		/// <returns>
		///     <see langword="true" /> if the current instance receives a signal; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out. </exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">The current instance is a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
		// Token: 0x060011F1 RID: 4593 RVA: 0x00048F81 File Offset: 0x00047181
		public virtual bool WaitOne(int millisecondsTimeout)
		{
			return this.WaitOne(millisecondsTimeout, false);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00048F8B File Offset: 0x0004718B
		[SecuritySafeCritical]
		private bool WaitOne(long timeout, bool exitContext)
		{
			return WaitHandle.InternalWaitOne(this.safeWaitHandle, timeout, this.hasThreadAffinity, exitContext);
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00048FA4 File Offset: 0x000471A4
		[SecurityCritical]
		internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			if (waitableSafeHandle == null)
			{
				throw new ObjectDisposedException(null, Environment.GetResourceString("Cannot access a disposed object."));
			}
			int num = WaitHandle.WaitOneNative(waitableSafeHandle, (uint)millisecondsTimeout, hasThreadAffinity, exitContext);
			if (num == 128)
			{
				WaitHandle.ThrowAbandonedMutexException();
			}
			return num != 258 && num != int.MaxValue;
		}

		/// <summary>Waits for any of the elements in the specified array to receive a signal, using a 32-bit signed integer to specify the time interval, and specifying whether to exit the synchronization domain before the wait.</summary>
		/// <param name="waitHandles">A <see langword="WaitHandle" /> array containing the objects for which the current instance will wait. </param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely. </param>
		/// <param name="exitContext">
		///       <see langword="true" /> to exit the synchronization domain for the context before the wait (if in a synchronized context), and reacquire it afterward; otherwise, <see langword="false" />. </param>
		/// <returns>The array index of the object that satisfied the wait, or <see cref="F:System.Threading.WaitHandle.WaitTimeout" /> if no object satisfied the wait and a time interval equivalent to <paramref name="millisecondsTimeout" /> has passed.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is <see langword="null" />.-or-One or more of the objects in the <paramref name="waitHandles" /> array is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits. </exception>
		/// <exception cref="T:System.ApplicationException">
		///         <paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 1.0 or 1.1. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out. </exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 2.0 or later. </exception>
		/// <exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
		// Token: 0x060011F4 RID: 4596 RVA: 0x00048FF4 File Offset: 0x000471F4
		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
		{
			if (waitHandles == null)
			{
				throw new ArgumentNullException(Environment.GetResourceString("The waitHandles parameter cannot be null."));
			}
			if (waitHandles.Length == 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Waithandle array may not be empty."));
			}
			if (64 < waitHandles.Length)
			{
				throw new NotSupportedException(Environment.GetResourceString("The number of WaitHandles must be less than or equal to 64."));
			}
			if (-1 > millisecondsTimeout)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			WaitHandle[] array = new WaitHandle[waitHandles.Length];
			for (int i = 0; i < waitHandles.Length; i++)
			{
				WaitHandle waitHandle = waitHandles[i];
				if (waitHandle == null)
				{
					throw new ArgumentNullException(Environment.GetResourceString("At least one element in the specified array was null."));
				}
				if (RemotingServices.IsTransparentProxy(waitHandle))
				{
					throw new InvalidOperationException(Environment.GetResourceString("Cannot wait on a transparent proxy."));
				}
				array[i] = waitHandle;
			}
			int num = WaitHandle.WaitMultiple(array, millisecondsTimeout, exitContext, false);
			if (128 <= num && 128 + array.Length > num)
			{
				int num2 = num - 128;
				if (0 <= num2 && num2 < array.Length)
				{
					WaitHandle.ThrowAbandonedMutexException(num2, array[num2]);
				}
				else
				{
					WaitHandle.ThrowAbandonedMutexException();
				}
			}
			GC.KeepAlive(array);
			return num;
		}

		/// <summary>Waits for any of the elements in the specified array to receive a signal, using a <see cref="T:System.TimeSpan" /> to specify the time interval and specifying whether to exit the synchronization domain before the wait.</summary>
		/// <param name="waitHandles">A <see langword="WaitHandle" /> array containing the objects for which the current instance will wait. </param>
		/// <param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely. </param>
		/// <param name="exitContext">
		///       <see langword="true" /> to exit the synchronization domain for the context before the wait (if in a synchronized context), and reacquire it afterward; otherwise, <see langword="false" />. </param>
		/// <returns>The array index of the object that satisfied the wait, or <see cref="F:System.Threading.WaitHandle.WaitTimeout" /> if no object satisfied the wait and a time interval equivalent to <paramref name="timeout" /> has passed.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is <see langword="null" />.-or-One or more of the objects in the <paramref name="waitHandles" /> array is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits. </exception>
		/// <exception cref="T:System.ApplicationException">
		///         <paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 1.0 or 1.1. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out. -or-
		///
		///         <paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 2.0 or later. </exception>
		/// <exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
		// Token: 0x060011F5 RID: 4597 RVA: 0x000490F0 File Offset: 0x000472F0
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (-1L > num || 2147483647L < num)
			{
				throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			return WaitHandle.WaitAny(waitHandles, (int)num, exitContext);
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00049132 File Offset: 0x00047332
		private static void ThrowAbandonedMutexException()
		{
			throw new AbandonedMutexException();
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00049139 File Offset: 0x00047339
		private static void ThrowAbandonedMutexException(int location, WaitHandle handle)
		{
			throw new AbandonedMutexException(location, handle);
		}

		/// <summary>Releases all resources held by the current <see cref="T:System.Threading.WaitHandle" />.</summary>
		// Token: 0x060011F8 RID: 4600 RVA: 0x00049142 File Offset: 0x00047342
		public virtual void Close()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>When overridden in a derived class, releases the unmanaged resources used by the <see cref="T:System.Threading.WaitHandle" />, and optionally releases the managed resources.</summary>
		/// <param name="explicitDisposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x060011F9 RID: 4601 RVA: 0x00049151 File Offset: 0x00047351
		[SecuritySafeCritical]
		protected virtual void Dispose(bool explicitDisposing)
		{
			if (this.safeWaitHandle != null)
			{
				this.safeWaitHandle.Close();
			}
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.WaitHandle" /> class.</summary>
		// Token: 0x060011FA RID: 4602 RVA: 0x00049142 File Offset: 0x00047342
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0004916C File Offset: 0x0004736C
		private unsafe static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			bool flag = false;
			int result;
			try
			{
				waitableSafeHandle.DangerousAddRef(ref flag);
				if (exitContext)
				{
					SynchronizationAttribute.ExitContext();
				}
				IntPtr intPtr = waitableSafeHandle.DangerousGetHandle();
				result = WaitHandle.Wait_internal(&intPtr, 1, false, (int)millisecondsTimeout);
			}
			finally
			{
				if (flag)
				{
					waitableSafeHandle.DangerousRelease();
				}
				if (exitContext)
				{
					SynchronizationAttribute.EnterContext();
				}
			}
			return result;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x000491C4 File Offset: 0x000473C4
		private unsafe static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll)
		{
			if (waitHandles.Length > 64)
			{
				return int.MaxValue;
			}
			int num = -1;
			SynchronizationContext synchronizationContext = SynchronizationContext.Current;
			int result;
			try
			{
				if (exitContext)
				{
					SynchronizationAttribute.ExitContext();
				}
				for (int i = 0; i < waitHandles.Length; i++)
				{
					try
					{
					}
					finally
					{
						bool flag = false;
						waitHandles[i].SafeWaitHandle.DangerousAddRef(ref flag);
						num = i;
					}
				}
				if (synchronizationContext != null && synchronizationContext.IsWaitNotificationRequired())
				{
					IntPtr[] array = new IntPtr[waitHandles.Length];
					for (int j = 0; j < waitHandles.Length; j++)
					{
						array[j] = waitHandles[j].SafeWaitHandle.DangerousGetHandle();
					}
					result = synchronizationContext.Wait(array, false, millisecondsTimeout);
				}
				else
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)waitHandles.Length) * (UIntPtr)sizeof(IntPtr))];
					for (int k = 0; k < waitHandles.Length; k++)
					{
						ptr[k] = waitHandles[k].SafeWaitHandle.DangerousGetHandle();
					}
					result = WaitHandle.Wait_internal(ptr, waitHandles.Length, WaitAll, millisecondsTimeout);
				}
			}
			finally
			{
				for (int l = num; l >= 0; l--)
				{
					waitHandles[l].SafeWaitHandle.DangerousRelease();
				}
				if (exitContext)
				{
					SynchronizationAttribute.EnterContext();
				}
			}
			return result;
		}

		// Token: 0x060011FD RID: 4605
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms);

		/// <summary>Indicates that a <see cref="M:System.Threading.WaitHandle.WaitAny(System.Threading.WaitHandle[],System.Int32,System.Boolean)" /> operation timed out before any of the wait handles were signaled. This field is constant.</summary>
		// Token: 0x040006E7 RID: 1767
		public const int WaitTimeout = 258;

		// Token: 0x040006E8 RID: 1768
		private const int MAX_WAITHANDLES = 64;

		// Token: 0x040006E9 RID: 1769
		private IntPtr waitHandle;

		// Token: 0x040006EA RID: 1770
		[SecurityCritical]
		internal volatile SafeWaitHandle safeWaitHandle;

		// Token: 0x040006EB RID: 1771
		internal bool hasThreadAffinity;

		// Token: 0x040006EC RID: 1772
		private const int WAIT_OBJECT_0 = 0;

		// Token: 0x040006ED RID: 1773
		private const int WAIT_ABANDONED = 128;

		// Token: 0x040006EE RID: 1774
		private const int WAIT_FAILED = 2147483647;

		// Token: 0x040006EF RID: 1775
		private const int ERROR_TOO_MANY_POSTS = 298;

		// Token: 0x040006F0 RID: 1776
		private const int ERROR_NOT_OWNED_BY_CALLER = 299;

		/// <summary>Represents an invalid native operating system handle. This field is read-only.</summary>
		// Token: 0x040006F1 RID: 1777
		protected static readonly IntPtr InvalidHandle = (IntPtr)(-1);

		// Token: 0x040006F2 RID: 1778
		internal const int MaxWaitHandles = 64;
	}
}
