using System;
using System.Security;

namespace Microsoft.Win32.SafeHandles
{
	/// <summary>Provides a managed wrapper for a process handle.</summary>
	// Token: 0x02000070 RID: 112
	[SuppressUnmanagedCodeSecurity]
	public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060002C5 RID: 709 RVA: 0x0000A938 File Offset: 0x00008B38
		internal SafeProcessHandle(IntPtr handle) : base(true)
		{
			base.SetHandle(handle);
		}

		/// <summary>Initializes a new instance of the <see cref="T:Microsoft.Win32.SafeHandles.SafeProcessHandle" /> class from the specified handle, indicating whether to release the handle during the finalization phase. </summary>
		/// <param name="existingHandle">The handle to be wrapped.</param>
		/// <param name="ownsHandle">
		///       <see langword="true" /> to reliably let <see cref="T:Microsoft.Win32.SafeHandles.SafeProcessHandle" /> release the handle during the finalization phase; otherwise, <see langword="false" />.</param>
		// Token: 0x060002C6 RID: 710 RVA: 0x0000A948 File Offset: 0x00008B48
		public SafeProcessHandle(IntPtr existingHandle, bool ownsHandle) : base(ownsHandle)
		{
			base.SetHandle(existingHandle);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000A958 File Offset: 0x00008B58
		protected override bool ReleaseHandle()
		{
			return NativeMethods.CloseProcess(this.handle);
		}

		// Token: 0x04000186 RID: 390
		internal static SafeProcessHandle InvalidHandle = new SafeProcessHandle(IntPtr.Zero);
	}
}
