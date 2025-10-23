using System;
using System.Runtime.CompilerServices;

namespace System.Buffers.Binary
{
	// Token: 0x0200065A RID: 1626
	public static class BinaryPrimitives
	{
		// Token: 0x0600310D RID: 12557 RVA: 0x000C593A File Offset: 0x000C3B3A
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort ReverseEndianness(ushort value)
		{
			return (ushort)((value >> 8) + ((int)value << 8));
		}
	}
}
