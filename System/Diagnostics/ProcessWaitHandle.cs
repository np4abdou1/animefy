using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics
{
	// Token: 0x020000D1 RID: 209
	internal class ProcessWaitHandle : WaitHandle
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x000250B8 File Offset: 0x000232B8
		internal ProcessWaitHandle(SafeProcessHandle processHandle)
		{
			SafeWaitHandle safeWaitHandle = null;
			if (!NativeMethods.DuplicateHandle(new HandleRef(this, NativeMethods.GetCurrentProcess()), processHandle, new HandleRef(this, NativeMethods.GetCurrentProcess()), out safeWaitHandle, 0, false, 2))
			{
				throw new SystemException("Unknown error in DuplicateHandle");
			}
			base.SafeWaitHandle = safeWaitHandle;
		}
	}
}
