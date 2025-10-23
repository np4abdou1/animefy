using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Win32
{
	// Token: 0x0200006F RID: 111
	internal static class NativeMethods
	{
		// Token: 0x060002BE RID: 702 RVA: 0x0000A834 File Offset: 0x00008A34
		public static bool DuplicateHandle(HandleRef hSourceProcessHandle, SafeHandle hSourceHandle, HandleRef hTargetProcess, out SafeWaitHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
		{
			bool flag = false;
			bool result;
			try
			{
				hSourceHandle.DangerousAddRef(ref flag);
				IntPtr existingHandle;
				MonoIOError monoIOError;
				bool flag2 = MonoIO.DuplicateHandle(hSourceProcessHandle.Handle, hSourceHandle.DangerousGetHandle(), hTargetProcess.Handle, out existingHandle, dwDesiredAccess, bInheritHandle ? 1 : 0, dwOptions, out monoIOError);
				if (monoIOError != MonoIOError.ERROR_SUCCESS)
				{
					throw MonoIO.GetException(monoIOError);
				}
				targetHandle = new SafeWaitHandle(existingHandle, true);
				result = flag2;
			}
			finally
			{
				if (flag)
				{
					hSourceHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
		{
			IntPtr existingHandle;
			MonoIOError monoIOError;
			bool result = MonoIO.DuplicateHandle(hSourceProcessHandle.Handle, hSourceHandle.Handle, hTargetProcess.Handle, out existingHandle, dwDesiredAccess, bInheritHandle ? 1 : 0, dwOptions, out monoIOError);
			if (monoIOError != MonoIOError.ERROR_SUCCESS)
			{
				throw MonoIO.GetException(monoIOError);
			}
			targetHandle = new SafeProcessHandle(existingHandle, true);
			return result;
		}

		// Token: 0x060002C0 RID: 704
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr GetCurrentProcess();

		// Token: 0x060002C1 RID: 705
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetExitCodeProcess(IntPtr processHandle, out int exitCode);

		// Token: 0x060002C2 RID: 706 RVA: 0x0000A8F4 File Offset: 0x00008AF4
		public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode)
		{
			bool flag = false;
			bool exitCodeProcess;
			try
			{
				processHandle.DangerousAddRef(ref flag);
				exitCodeProcess = NativeMethods.GetExitCodeProcess(processHandle.DangerousGetHandle(), out exitCode);
			}
			finally
			{
				if (flag)
				{
					processHandle.DangerousRelease();
				}
			}
			return exitCodeProcess;
		}

		// Token: 0x060002C3 RID: 707
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCurrentProcessId();

		// Token: 0x060002C4 RID: 708
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CloseProcess(IntPtr handle);
	}
}
