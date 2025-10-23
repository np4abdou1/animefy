using System;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;

namespace System.Runtime.InteropServices
{
	/// <summary>Represents a wrapper class for operating system handles. This class must be inherited.</summary>
	// Token: 0x0200041B RID: 1051
	[SecurityCritical]
	[StructLayout(0)]
	public abstract class SafeHandle : CriticalFinalizerObject, IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.SafeHandle" /> class with the specified invalid handle value.</summary>
		/// <param name="invalidHandleValue">The value of an invalid handle (usually 0 or -1).  Your implementation of <see cref="P:System.Runtime.InteropServices.SafeHandle.IsInvalid" /> should return <see langword="true" /> for this value.</param>
		/// <param name="ownsHandle">
		///       <see langword="true" /> to reliably let <see cref="T:System.Runtime.InteropServices.SafeHandle" /> release the handle during the finalization phase; otherwise, <see langword="false" /> (not recommended). </param>
		/// <exception cref="T:System.TypeLoadException">The derived class resides in an assembly without unmanaged code access permission. </exception>
		// Token: 0x06001F57 RID: 8023 RVA: 0x0008690E File Offset: 0x00084B0E
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		protected SafeHandle(IntPtr invalidHandleValue, bool ownsHandle)
		{
			this.handle = invalidHandleValue;
			this._state = 4;
			this._ownsHandle = ownsHandle;
			if (!ownsHandle)
			{
				GC.SuppressFinalize(this);
			}
			this._fullyInitialized = true;
		}

		/// <summary>Frees all resources associated with the handle.</summary>
		// Token: 0x06001F58 RID: 8024 RVA: 0x0008693C File Offset: 0x00084B3C
		[SecuritySafeCritical]
		~SafeHandle()
		{
			this.Dispose(false);
		}

		/// <summary>Sets the handle to the specified pre-existing handle.</summary>
		/// <param name="handle">The pre-existing handle to use. </param>
		// Token: 0x06001F59 RID: 8025 RVA: 0x0008696C File Offset: 0x00084B6C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected void SetHandle(IntPtr handle)
		{
			this.handle = handle;
		}

		/// <summary>Returns the value of the <see cref="F:System.Runtime.InteropServices.SafeHandle.handle" /> field.</summary>
		/// <returns>An <see langword="IntPtr" /> representing the value of the <see cref="F:System.Runtime.InteropServices.SafeHandle.handle" /> field. If the handle has been marked invalid with <see cref="M:System.Runtime.InteropServices.SafeHandle.SetHandleAsInvalid" />, this method still returns the original handle value, which can be a stale value.</returns>
		// Token: 0x06001F5A RID: 8026 RVA: 0x00086975 File Offset: 0x00084B75
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public IntPtr DangerousGetHandle()
		{
			return this.handle;
		}

		/// <summary>Gets a value indicating whether the handle is closed.</summary>
		/// <returns>
		///     <see langword="true" /> if the handle is closed; otherwise, <see langword="false" />.</returns>
		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x0008697D File Offset: 0x00084B7D
		public bool IsClosed
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return (this._state & 1) == 1;
			}
		}

		/// <summary>When overridden in a derived class, gets a value indicating whether the handle value is invalid.</summary>
		/// <returns>
		///     <see langword="true" /> if the handle value is invalid; otherwise, <see langword="false" />.</returns>
		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001F5C RID: 8028
		public abstract bool IsInvalid { [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)] get; }

		/// <summary>Marks the handle for releasing and freeing resources.</summary>
		// Token: 0x06001F5D RID: 8029 RVA: 0x0008698A File Offset: 0x00084B8A
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void Close()
		{
			this.Dispose(true);
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Runtime.InteropServices.SafeHandle" /> class.</summary>
		// Token: 0x06001F5E RID: 8030 RVA: 0x0008698A File Offset: 0x00084B8A
		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Runtime.InteropServices.SafeHandle" /> class specifying whether to perform a normal dispose operation.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> for a normal dispose operation; <see langword="false" /> to finalize the handle.</param>
		// Token: 0x06001F5F RID: 8031 RVA: 0x00086993 File Offset: 0x00084B93
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.InternalDispose();
				return;
			}
			this.InternalFinalize();
		}

		/// <summary>When overridden in a derived class, executes the code required to free the handle.</summary>
		/// <returns>
		///     <see langword="true" /> if the handle is released successfully; otherwise, in the event of a catastrophic failure,<see langword=" false" />. In this case, it generates a releaseHandleFailed MDA Managed Debugging Assistant.</returns>
		// Token: 0x06001F60 RID: 8032
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected abstract bool ReleaseHandle();

		/// <summary>Marks a handle as no longer used.</summary>
		// Token: 0x06001F61 RID: 8033 RVA: 0x000869A8 File Offset: 0x00084BA8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void SetHandleAsInvalid()
		{
			try
			{
			}
			finally
			{
				int state;
				int value;
				do
				{
					state = this._state;
					value = (state | 1);
				}
				while (Interlocked.CompareExchange(ref this._state, value, state) != state);
				GC.SuppressFinalize(this);
			}
		}

		/// <summary>Manually increments the reference counter on <see cref="T:System.Runtime.InteropServices.SafeHandle" /> instances.</summary>
		/// <param name="success">
		///       <see langword="true" /> if the reference counter was successfully incremented; otherwise, <see langword="false" />.</param>
		// Token: 0x06001F62 RID: 8034 RVA: 0x000869EC File Offset: 0x00084BEC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public void DangerousAddRef(ref bool success)
		{
			try
			{
			}
			finally
			{
				if (!this._fullyInitialized)
				{
					throw new InvalidOperationException();
				}
				for (;;)
				{
					int state = this._state;
					if ((state & 1) != 0)
					{
						break;
					}
					int value = state + 4;
					if (Interlocked.CompareExchange(ref this._state, value, state) == state)
					{
						goto Block_5;
					}
				}
				throw new ObjectDisposedException(null, "Safe handle has been closed");
				Block_5:
				success = true;
			}
		}

		/// <summary>Manually decrements the reference counter on a <see cref="T:System.Runtime.InteropServices.SafeHandle" /> instance.</summary>
		// Token: 0x06001F63 RID: 8035 RVA: 0x00086A4C File Offset: 0x00084C4C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void DangerousRelease()
		{
			this.DangerousReleaseInternal(false);
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00086A55 File Offset: 0x00084C55
		private void InternalDispose()
		{
			if (!this._fullyInitialized)
			{
				throw new InvalidOperationException();
			}
			this.DangerousReleaseInternal(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00086A72 File Offset: 0x00084C72
		private void InternalFinalize()
		{
			if (this._fullyInitialized)
			{
				this.DangerousReleaseInternal(true);
			}
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x00086A84 File Offset: 0x00084C84
		private void DangerousReleaseInternal(bool dispose)
		{
			try
			{
			}
			finally
			{
				if (!this._fullyInitialized)
				{
					throw new InvalidOperationException();
				}
				bool flag;
				for (;;)
				{
					int state = this._state;
					if (dispose && (state & 2) != 0)
					{
						break;
					}
					if ((state & 2147483644) == 0)
					{
						goto Block_6;
					}
					flag = ((state & 2147483644) == 4 && (state & 1) == 0 && this._ownsHandle && !this.IsInvalid);
					int num = state - 4;
					if ((state & 2147483644) == 4)
					{
						num |= 1;
					}
					if (dispose)
					{
						num |= 2;
					}
					if (Interlocked.CompareExchange(ref this._state, num, state) == state)
					{
						goto IL_9A;
					}
				}
				flag = false;
				goto IL_9A;
				Block_6:
				throw new ObjectDisposedException(null, "Safe handle has been closed");
				IL_9A:
				if (flag)
				{
					this.ReleaseHandle();
				}
			}
		}

		/// <summary>Specifies the handle to be wrapped.</summary>
		// Token: 0x04000F0B RID: 3851
		protected IntPtr handle;

		// Token: 0x04000F0C RID: 3852
		private int _state;

		// Token: 0x04000F0D RID: 3853
		private bool _ownsHandle;

		// Token: 0x04000F0E RID: 3854
		private bool _fullyInitialized;

		// Token: 0x04000F0F RID: 3855
		private const int RefCount_Mask = 2147483644;

		// Token: 0x04000F10 RID: 3856
		private const int RefCount_One = 4;
	}
}
