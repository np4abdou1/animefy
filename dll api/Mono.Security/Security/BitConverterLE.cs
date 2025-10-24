using System;

namespace Mono.Security
{
	// Token: 0x02000005 RID: 5
	internal sealed class BitConverterLE
	{
		// Token: 0x0600001A RID: 26 RVA: 0x000029C8 File Offset: 0x00000BC8
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

		// Token: 0x0600001B RID: 27 RVA: 0x00002A20 File Offset: 0x00000C20
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

		// Token: 0x0600001C RID: 28 RVA: 0x00002AAD File Offset: 0x00000CAD
		internal unsafe static byte[] GetBytes(int value)
		{
			return BitConverterLE.GetUIntBytes((byte*)(&value));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002AB7 File Offset: 0x00000CB7
		internal unsafe static byte[] GetBytes(long value)
		{
			return BitConverterLE.GetULongBytes((byte*)(&value));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002AC1 File Offset: 0x00000CC1
		private unsafe static void UShortFromBytes(byte* dst, byte[] src, int startIndex)
		{
			if (BitConverter.IsLittleEndian)
			{
				*dst = src[startIndex];
				dst[1] = src[startIndex + 1];
				return;
			}
			*dst = src[startIndex + 1];
			dst[1] = src[startIndex];
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002AE8 File Offset: 0x00000CE8
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

		// Token: 0x06000020 RID: 32 RVA: 0x00002B40 File Offset: 0x00000D40
		internal unsafe static int ToInt32(byte[] value, int startIndex)
		{
			int result;
			BitConverterLE.UIntFromBytes((byte*)(&result), value, startIndex);
			return result;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002B58 File Offset: 0x00000D58
		internal unsafe static ushort ToUInt16(byte[] value, int startIndex)
		{
			ushort result;
			BitConverterLE.UShortFromBytes((byte*)(&result), value, startIndex);
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002B70 File Offset: 0x00000D70
		internal unsafe static uint ToUInt32(byte[] value, int startIndex)
		{
			uint result;
			BitConverterLE.UIntFromBytes((byte*)(&result), value, startIndex);
			return result;
		}
	}
}
