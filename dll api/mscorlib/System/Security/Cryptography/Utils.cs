using System;

namespace System.Security.Cryptography
{
	// Token: 0x020002E1 RID: 737
	internal static class Utils
	{
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x00067D87 File Offset: 0x00065F87
		internal static RNGCryptoServiceProvider StaticRandomNumberGenerator
		{
			get
			{
				if (Utils._rng == null)
				{
					Utils._rng = new RNGCryptoServiceProvider();
				}
				return Utils._rng;
			}
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00067DA8 File Offset: 0x00065FA8
		internal static byte[] GenerateRandom(int keySize)
		{
			byte[] array = new byte[keySize];
			Utils.StaticRandomNumberGenerator.GetBytes(array);
			return array;
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0000B18D File Offset: 0x0000938D
		[SecurityCritical]
		internal static bool HasAlgorithm(int dwCalg, int dwKeySize)
		{
			return true;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00067DC8 File Offset: 0x00065FC8
		internal static string DiscardWhiteSpaces(string inputBuffer)
		{
			return Utils.DiscardWhiteSpaces(inputBuffer, 0, inputBuffer.Length);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00067DD8 File Offset: 0x00065FD8
		internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount)
		{
			int num = 0;
			for (int i = 0; i < inputCount; i++)
			{
				if (char.IsWhiteSpace(inputBuffer[inputOffset + i]))
				{
					num++;
				}
			}
			char[] array = new char[inputCount - num];
			num = 0;
			for (int i = 0; i < inputCount; i++)
			{
				if (!char.IsWhiteSpace(inputBuffer[inputOffset + i]))
				{
					array[num++] = inputBuffer[inputOffset + i];
				}
			}
			return new string(array);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00067E44 File Offset: 0x00066044
		internal static int ConvertByteArrayToInt(byte[] input)
		{
			int num = 0;
			for (int i = 0; i < input.Length; i++)
			{
				num *= 256;
				num += (int)input[i];
			}
			return num;
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00067E70 File Offset: 0x00066070
		internal static byte[] ConvertIntToByteArray(int dwInput)
		{
			byte[] array = new byte[8];
			int num = 0;
			if (dwInput == 0)
			{
				return new byte[1];
			}
			int i = dwInput;
			while (i > 0)
			{
				int num2 = i % 256;
				array[num] = (byte)num2;
				i = (i - num2) / 256;
				num++;
			}
			byte[] array2 = new byte[num];
			for (int j = 0; j < num; j++)
			{
				array2[j] = array[num - j - 1];
			}
			return array2;
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00067EDC File Offset: 0x000660DC
		internal static byte[] FixupKeyParity(byte[] key)
		{
			byte[] array = new byte[key.Length];
			for (int i = 0; i < key.Length; i++)
			{
				array[i] = (key[i] & 254);
				byte b = (byte)((int)(array[i] & 15) ^ array[i] >> 4);
				byte b2 = (byte)((int)(b & 3) ^ b >> 2);
				if ((byte)((int)(b2 & 1) ^ b2 >> 1) == 0)
				{
					byte[] array2 = array;
					int num = i;
					array2[num] |= 1;
				}
			}
			return array;
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00067F3C File Offset: 0x0006613C
		[SecurityCritical]
		internal unsafe static void DWORDFromLittleEndian(uint* x, int digits, byte* block)
		{
			int i = 0;
			int num = 0;
			while (i < digits)
			{
				x[i] = (uint)((int)block[num] | (int)block[num + 1] << 8 | (int)block[num + 2] << 16 | (int)block[num + 3] << 24);
				i++;
				num += 4;
			}
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00067F84 File Offset: 0x00066184
		internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits)
		{
			int i = 0;
			int num = 0;
			while (i < digits)
			{
				block[num] = (byte)(x[i] & 255U);
				block[num + 1] = (byte)(x[i] >> 8 & 255U);
				block[num + 2] = (byte)(x[i] >> 16 & 255U);
				block[num + 3] = (byte)(x[i] >> 24 & 255U);
				i++;
				num += 4;
			}
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00067FE8 File Offset: 0x000661E8
		[SecurityCritical]
		internal unsafe static void DWORDFromBigEndian(uint* x, int digits, byte* block)
		{
			int i = 0;
			int num = 0;
			while (i < digits)
			{
				x[i] = (uint)((int)block[num] << 24 | (int)block[num + 1] << 16 | (int)block[num + 2] << 8 | (int)block[num + 3]);
				i++;
				num += 4;
			}
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00068030 File Offset: 0x00066230
		internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits)
		{
			int i = 0;
			int num = 0;
			while (i < digits)
			{
				block[num] = (byte)(x[i] >> 24 & 255U);
				block[num + 1] = (byte)(x[i] >> 16 & 255U);
				block[num + 2] = (byte)(x[i] >> 8 & 255U);
				block[num + 3] = (byte)(x[i] & 255U);
				i++;
				num += 4;
			}
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00068094 File Offset: 0x00066294
		[SecurityCritical]
		internal unsafe static void QuadWordFromBigEndian(ulong* x, int digits, byte* block)
		{
			int i = 0;
			int num = 0;
			while (i < digits)
			{
				x[i] = ((ulong)block[num] << 56 | (ulong)block[num + 1] << 48 | (ulong)block[num + 2] << 40 | (ulong)block[num + 3] << 32 | (ulong)block[num + 4] << 24 | (ulong)block[num + 5] << 16 | (ulong)block[num + 6] << 8 | (ulong)block[num + 7]);
				i++;
				num += 8;
			}
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x0006810C File Offset: 0x0006630C
		internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits)
		{
			int i = 0;
			int num = 0;
			while (i < digits)
			{
				block[num] = (byte)(x[i] >> 56 & 255UL);
				block[num + 1] = (byte)(x[i] >> 48 & 255UL);
				block[num + 2] = (byte)(x[i] >> 40 & 255UL);
				block[num + 3] = (byte)(x[i] >> 32 & 255UL);
				block[num + 4] = (byte)(x[i] >> 24 & 255UL);
				block[num + 5] = (byte)(x[i] >> 16 & 255UL);
				block[num + 6] = (byte)(x[i] >> 8 & 255UL);
				block[num + 7] = (byte)(x[i] & 255UL);
				i++;
				num += 8;
			}
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x000681C3 File Offset: 0x000663C3
		internal static bool _ProduceLegacyHmacValues()
		{
			return Environment.GetEnvironmentVariable("legacyHMACMode") == "1";
		}

		// Token: 0x04000A0C RID: 2572
		private static volatile RNGCryptoServiceProvider _rng;
	}
}
