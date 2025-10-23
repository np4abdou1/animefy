using System;
using System.IO;
using System.Security;

namespace Microsoft.Win32.SafeHandles
{
	/// <summary>Represents a wrapper class for a file handle. </summary>
	// Token: 0x0200005D RID: 93
	[SecurityCritical]
	public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		/// <summary>Initializes a new instance of the <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle" /> class. </summary>
		/// <param name="preexistingHandle">An <see cref="T:System.IntPtr" /> object that represents the pre-existing handle to use.</param>
		/// <param name="ownsHandle">
		///       <see langword="true" /> to reliably release the handle during the finalization phase; <see langword="false" /> to prevent reliable release (not recommended).</param>
		// Token: 0x06000210 RID: 528 RVA: 0x0000E2B3 File Offset: 0x0000C4B3
		public SafeFileHandle(IntPtr preexistingHandle, bool ownsHandle) : base(ownsHandle)
		{
			base.SetHandle(preexistingHandle);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000E2C4 File Offset: 0x0000C4C4
		[SecurityCritical]
		protected override bool ReleaseHandle()
		{
			MonoIOError monoIOError;
			MonoIO.Close(this.handle, out monoIOError);
			return monoIOError == MonoIOError.ERROR_SUCCESS;
		}
	}
}
