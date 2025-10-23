using System;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x020001C5 RID: 453
	[ReflectionBlocked]
	public struct LockHolder : IDisposable
	{
		// Token: 0x060010D3 RID: 4307 RVA: 0x00045768 File Offset: 0x00043968
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static LockHolder Hold(Lock l)
		{
			l.Acquire();
			LockHolder result;
			result._lock = l;
			return result;
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00045784 File Offset: 0x00043984
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Dispose()
		{
			this._lock.Release();
		}

		// Token: 0x0400066F RID: 1647
		private Lock _lock;
	}
}
