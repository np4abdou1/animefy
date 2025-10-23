using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000474 RID: 1140
	internal static class JitHelpers
	{
		// Token: 0x06002087 RID: 8327 RVA: 0x00089097 File Offset: 0x00087297
		internal static T UnsafeCast<T>(object o) where T : class
		{
			return Array.UnsafeMov<object, T>(o);
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x0008909F File Offset: 0x0008729F
		internal static int UnsafeEnumCast<T>(T val) where T : struct
		{
			return Array.UnsafeMov<T, int>(val);
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x000890A7 File Offset: 0x000872A7
		internal static long UnsafeEnumCastLong<T>(T val) where T : struct
		{
			return Array.UnsafeMov<T, long>(val);
		}
	}
}
