using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200005B RID: 91
	internal static class SafeHandleCache<T> where T : SafeHandle
	{
		// Token: 0x06000208 RID: 520 RVA: 0x0000E210 File Offset: 0x0000C410
		internal static bool IsCachedInvalidHandle(SafeHandle handle)
		{
			return handle == Volatile.Read<T>(ref SafeHandleCache<T>.s_invalidHandle);
		}

		// Token: 0x040001A7 RID: 423
		private static T s_invalidHandle;
	}
}
