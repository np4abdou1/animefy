using System;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;

namespace Microsoft.Win32.SafeHandles
{
	/// <summary>Represents a wrapper class for a wait handle. </summary>
	// Token: 0x0200005E RID: 94
	[SecurityCritical]
	public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		/// <summary>Initializes a new instance of the <see cref="T:Microsoft.Win32.SafeHandles.SafeWaitHandle" /> class. </summary>
		/// <param name="existingHandle">An <see cref="T:System.IntPtr" /> object that represents the pre-existing handle to use.</param>
		/// <param name="ownsHandle">
		///       <see langword="true" /> to reliably release the handle during the finalization phase; <see langword="false" /> to prevent reliable release (not recommended).</param>
		// Token: 0x06000212 RID: 530 RVA: 0x0000E2B3 File Offset: 0x0000C4B3
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public SafeWaitHandle(IntPtr existingHandle, bool ownsHandle) : base(ownsHandle)
		{
			base.SetHandle(existingHandle);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000E2E3 File Offset: 0x0000C4E3
		[SecurityCritical]
		protected override bool ReleaseHandle()
		{
			NativeEventCalls.CloseEvent_internal(this.handle);
			return true;
		}
	}
}
