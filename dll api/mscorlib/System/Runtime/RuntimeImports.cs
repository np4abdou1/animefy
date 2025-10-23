using System;
using System.Runtime.CompilerServices;

namespace System.Runtime
{
	// Token: 0x020002FD RID: 765
	internal static class RuntimeImports
	{
		// Token: 0x0600194B RID: 6475 RVA: 0x0006E8C4 File Offset: 0x0006CAC4
		internal unsafe static void RhZeroMemory(ref byte b, ulong byteLength)
		{
			fixed (byte* ptr = &b)
			{
				RuntimeImports.ZeroMemory((void*)ptr, (uint)byteLength);
			}
		}

		// Token: 0x0600194C RID: 6476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void ZeroMemory(void* p, uint byteLength);

		// Token: 0x0600194D RID: 6477
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void Memmove(byte* dest, byte* src, uint len);

		// Token: 0x0600194E RID: 6478
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void Memmove_wbarrier(byte* dest, byte* src, uint len, IntPtr type_handle);
	}
}
