using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x020000CF RID: 207
	internal static class Marvin
	{
		// Token: 0x060006C2 RID: 1730 RVA: 0x0001CE11 File Offset: 0x0001B011
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ComputeHash32(ReadOnlySpan<byte> data, ulong seed)
		{
			return Marvin.ComputeHash32(MemoryMarshal.GetReference<byte>(data), data.Length, seed);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0001CE28 File Offset: 0x0001B028
		public unsafe static int ComputeHash32(ref byte data, int count, ulong seed)
		{
			ulong num = (ulong)((long)count);
			uint num2 = (uint)seed;
			uint num3 = (uint)(seed >> 32);
			ulong num4 = 0UL;
			while (num >= 8UL)
			{
				num2 += Unsafe.ReadUnaligned<uint>(Unsafe.AddByteOffset<byte>(ref data, num4));
				Marvin.Block(ref num2, ref num3);
				num2 += Unsafe.ReadUnaligned<uint>(Unsafe.AddByteOffset<byte>(ref data, num4 + 4UL));
				Marvin.Block(ref num2, ref num3);
				num4 += 8UL;
				num -= 8UL;
			}
			ulong num5 = num;
			if (num5 <= 7UL)
			{
				switch ((uint)num5)
				{
				case 0U:
					break;
				case 1U:
					goto IL_CC;
				case 2U:
					goto IL_FC;
				case 3U:
					goto IL_130;
				case 4U:
					num2 += Unsafe.ReadUnaligned<uint>(Unsafe.AddByteOffset<byte>(ref data, num4));
					Marvin.Block(ref num2, ref num3);
					break;
				case 5U:
					num2 += Unsafe.ReadUnaligned<uint>(Unsafe.AddByteOffset<byte>(ref data, num4));
					num4 += 4UL;
					Marvin.Block(ref num2, ref num3);
					goto IL_CC;
				case 6U:
					num2 += Unsafe.ReadUnaligned<uint>(Unsafe.AddByteOffset<byte>(ref data, num4));
					num4 += 4UL;
					Marvin.Block(ref num2, ref num3);
					goto IL_FC;
				case 7U:
					num2 += Unsafe.ReadUnaligned<uint>(Unsafe.AddByteOffset<byte>(ref data, num4));
					num4 += 4UL;
					Marvin.Block(ref num2, ref num3);
					goto IL_130;
				default:
					goto IL_154;
				}
				num2 += 128U;
				goto IL_154;
				IL_CC:
				num2 += (32768U | (uint)(*Unsafe.AddByteOffset<byte>(ref data, num4)));
				goto IL_154;
				IL_FC:
				num2 += (8388608U | (uint)Unsafe.ReadUnaligned<ushort>(Unsafe.AddByteOffset<byte>(ref data, num4)));
				goto IL_154;
				IL_130:
				num2 += (uint)(int.MinValue | (int)(*Unsafe.AddByteOffset<byte>(ref data, num4 + 2UL)) << 16 | (int)Unsafe.ReadUnaligned<ushort>(Unsafe.AddByteOffset<byte>(ref data, num4)));
			}
			IL_154:
			Marvin.Block(ref num2, ref num3);
			Marvin.Block(ref num2, ref num3);
			return (int)(num3 ^ num2);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0001CFA0 File Offset: 0x0001B1A0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Block(ref uint rp0, ref uint rp1)
		{
			uint num = rp0;
			uint num2 = rp1;
			num2 ^= num;
			num = Marvin._rotl(num, 20);
			num += num2;
			num2 = Marvin._rotl(num2, 9);
			num2 ^= num;
			num = Marvin._rotl(num, 27);
			num += num2;
			num2 = Marvin._rotl(num2, 19);
			rp0 = num;
			rp1 = num2;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0001CFED File Offset: 0x0001B1ED
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint _rotl(uint value, int shift)
		{
			return value << shift | value >> 32 - shift;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x0001CFFF File Offset: 0x0001B1FF
		public static ulong DefaultSeed { get; } = Marvin.GenerateSeed();

		// Token: 0x060006C7 RID: 1735 RVA: 0x0001D006 File Offset: 0x0001B206
		private static ulong GenerateSeed()
		{
			return 12874512UL;
		}
	}
}
