using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.WindowsRuntime
{
	// Token: 0x0200042D RID: 1069
	internal static class UnsafeNativeMethods
	{
		// Token: 0x06001FDA RID: 8154
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool RoOriginateLanguageException(int error, string message, IntPtr languageException);

		// Token: 0x06001FDB RID: 8155
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RoReportUnhandledError(IRestrictedErrorInfo error);

		// Token: 0x06001FDC RID: 8156
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IRestrictedErrorInfo GetRestrictedErrorInfo();
	}
}
