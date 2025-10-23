using System;
using System.Runtime.CompilerServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002A1 RID: 673
	public static class CryptographicOperations
	{
		// Token: 0x060016F6 RID: 5878 RVA: 0x0005F397 File Offset: 0x0005D597
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static void ZeroMemory(Span<byte> buffer)
		{
			buffer.Clear();
		}
	}
}
