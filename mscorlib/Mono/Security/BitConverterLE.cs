using System;

namespace Mono.Security
{
	// Token: 0x02000043 RID: 67
	internal sealed class BitConverterLE
	{
		// Token: 0x0600010E RID: 270 RVA: 0x00007B24 File Offset: 0x00005D24
		private unsafe static byte[] GetUIntBytes(byte* bytes)
		{
			if (BitConverter.IsLittleEndian)
			{
				return new byte[]
				{
					*bytes,
					bytes[1],
					bytes[2],
					bytes[3]
				};
			}
			return new byte[]
			{
				bytes[3],
				bytes[2],
				bytes[1],
				*bytes
			};
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00007B7C File Offset: 0x00005D7C
		private unsafe static byte[] GetULongBytes(byte* bytes)
		{
			if (BitConverter.IsLittleEndian)
			{
				return new byte[]
				{
					*bytes,
					bytes[1],
					bytes[2],
					bytes[3],
					bytes[4],
					bytes[5],
					bytes[6],
					bytes[7]
				};
			}
			return new byte[]
			{
				bytes[7],
				bytes[6],
				bytes[5],
				bytes[4],
				bytes[3],
				bytes[2],
				bytes[1],
				*bytes
			};
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00007C09 File Offset: 0x00005E09
		internal unsafe static byte[] GetBytes(int value)
		{
			return BitConverterLE.GetUIntBytes((byte*)(&value));
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00007C09 File Offset: 0x00005E09
		internal unsafe static byte[] GetBytes(float value)
		{
			return BitConverterLE.GetUIntBytes((byte*)(&value));
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00007C13 File Offset: 0x00005E13
		internal unsafe static byte[] GetBytes(double value)
		{
			return BitConverterLE.GetULongBytes((byte*)(&value));
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00007C20 File Offset: 0x00005E20
		private unsafe static void UIntFromBytes(byte* dst, byte[] src, int startIndex)
		{
			if (BitConverter.IsLittleEndian)
			{
				*dst = src[startIndex];
				dst[1] = src[startIndex + 1];
				dst[2] = src[startIndex + 2];
				dst[3] = src[startIndex + 3];
				return;
			}
			*dst = src[startIndex + 3];
			dst[1] = src[startIndex + 2];
			dst[2] = src[startIndex + 1];
			dst[3] = src[startIndex];
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00007C78 File Offset: 0x00005E78
		private unsafe static void ULongFromBytes(byte* dst, byte[] src, int startIndex)
		{
			if (BitConverter.IsLittleEndian)
			{
				for (int i = 0; i < 8; i++)
				{
					dst[i] = src[startIndex + i];
				}
				return;
			}
			for (int j = 0; j < 8; j++)
			{
				dst[j] = src[startIndex + (7 - j)];
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00007CBC File Offset: 0x00005EBC
		internal unsafe static float ToSingle(byte[] value, int startIndex)
		{
			float result;
			BitConverterLE.UIntFromBytes((byte*)(&result), value, startIndex);
			return result;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00007CD4 File Offset: 0x00005ED4
		internal unsafe static double ToDouble(byte[] value, int startIndex)
		{
			double result;
			BitConverterLE.ULongFromBytes((byte*)(&result), value, startIndex);
			return result;
		}
	}
}
