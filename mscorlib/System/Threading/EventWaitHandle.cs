using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	/// <summary>Represents a thread synchronization event.</summary>
	// Token: 0x020001D2 RID: 466
	[ComVisible(true)]
	public class EventWaitHandle : WaitHandle
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.EventWaitHandle" /> class, specifying whether the wait handle is initially signaled, and whether it resets automatically or manually.</summary>
		/// <param name="initialState">
		///       <see langword="true" /> to set the initial state to signaled; <see langword="false" /> to set it to nonsignaled.</param>
		/// <param name="mode">One of the <see cref="T:System.Threading.EventResetMode" /> values that determines whether the event resets automatically or manually.</param>
		// Token: 0x06001111 RID: 4369 RVA: 0x00046DA0 File Offset: 0x00044FA0
		[SecuritySafeCritical]
		public EventWaitHandle(bool initialState, EventResetMode mode) : this(initialState, mode, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.EventWaitHandle" /> class, specifying whether the wait handle is initially signaled if created as a result of this call, whether it resets automatically or manually, and the name of a system synchronization event.</summary>
		/// <param name="initialState">
		///       <see langword="true" /> to set the initial state to signaled if the named event is created as a result of this call; <see langword="false" /> to set it to nonsignaled.</param>
		/// <param name="mode">One of the <see cref="T:System.Threading.EventResetMode" /> values that determines whether the event resets automatically or manually.</param>
		/// <param name="name">The name of a system-wide synchronization event.</param>
		/// <exception cref="T:System.IO.IOException">A Win32 error occurred.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The named event exists and has access control security, but the user does not have <see cref="F:System.Security.AccessControl.EventWaitHandleRights.FullControl" />.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">The named event cannot be created, perhaps because a wait handle of a different type has the same name.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="name" /> is longer than 260 characters.</exception>
		// Token: 0x06001112 RID: 4370 RVA: 0x00046DAC File Offset: 0x00044FAC
		[SecurityCritical]
		public EventWaitHandle(bool initialState, EventResetMode mode, string name)
		{
			if (name != null && 260 < name.Length)
			{
				throw new ArgumentException(Environment.GetResourceString("The name can be no more than 260 characters in length.", new object[]
				{
					name
				}));
			}
			int num;
			SafeWaitHandle safeWaitHandle;
			if (mode != EventResetMode.AutoReset)
			{
				if (mode != EventResetMode.ManualReset)
				{
					throw new ArgumentException(Environment.GetResourceString("Value of flags is invalid.", new object[]
					{
						name
					}));
				}
				safeWaitHandle = new SafeWaitHandle(NativeEventCalls.CreateEvent_internal(true, initialState, name, out num), true);
			}
			else
			{
				safeWaitHandle = new SafeWaitHandle(NativeEventCalls.CreateEvent_internal(false, initialState, name, out num), true);
			}
			if (safeWaitHandle.IsInvalid)
			{
				safeWaitHandle.SetHandleAsInvalid();
				if (name != null && name.Length != 0 && 6 == num)
				{
					throw new WaitHandleCannotBeOpenedException(Environment.GetResourceString("A WaitHandle with system-wide name '{0}' cannot be created. A WaitHandle of a different type might have the same name.", new object[]
					{
						name
					}));
				}
				__Error.WinIOError(num, name);
			}
			base.SetHandleInternal(safeWaitHandle);
		}

		/// <summary>Sets the state of the event to nonsignaled, causing threads to block.</summary>
		/// <returns>
		///     <see langword="true" /> if the operation succeeds; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="M:System.Threading.WaitHandle.Close" /> method was previously called on this <see cref="T:System.Threading.EventWaitHandle" />.</exception>
		// Token: 0x06001113 RID: 4371 RVA: 0x00046E77 File Offset: 0x00045077
		[SecuritySafeCritical]
		public bool Reset()
		{
			bool flag = NativeEventCalls.ResetEvent(this.safeWaitHandle);
			if (!flag)
			{
				throw new IOException();
			}
			return flag;
		}

		/// <summary>Sets the state of the event to signaled, allowing one or more waiting threads to proceed.</summary>
		/// <returns>
		///     <see langword="true" /> if the operation succeeds; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="M:System.Threading.WaitHandle.Close" /> method was previously called on this <see cref="T:System.Threading.EventWaitHandle" />.</exception>
		// Token: 0x06001114 RID: 4372 RVA: 0x00046E8F File Offset: 0x0004508F
		[SecuritySafeCritical]
		public bool Set()
		{
			bool flag = NativeEventCalls.SetEvent(this.safeWaitHandle);
			if (!flag)
			{
				throw new IOException();
			}
			return flag;
		}
	}
}
