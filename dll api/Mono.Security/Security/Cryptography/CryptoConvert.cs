using System;
using System.Globalization;
using System.Text;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000048 RID: 72
	public sealed class CryptoConvert
	{
		// Token: 0x0600017B RID: 379 RVA: 0x00009FDC File Offset: 0x000081DC
		public static string ToHex(byte[] input)
		{
			if (input == null)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder(input.Length * 2);
			foreach (byte b in input)
			{
				stringBuilder.Append(b.ToString("X2", CultureInfo.InvariantCulture));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000A02C File Offset: 0x0000822C
		private static byte FromHexChar(char c)
		{
			if (c >= 'a' && c <= 'f')
			{
				return (byte)(c - 'a' + '\n');
			}
			if (c >= 'A' && c <= 'F')
			{
				return (byte)(c - 'A' + '\n');
			}
			if (c >= '0' && c <= '9')
			{
				return (byte)(c - '0');
			}
			throw new ArgumentException("invalid hex char");
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000A07C File Offset: 0x0000827C
		public static byte[] FromHex(string hex)
		{
			if (hex == null)
			{
				return null;
			}
			if ((hex.Length & 1) == 1)
			{
				throw new ArgumentException("Length must be a multiple of 2");
			}
			byte[] array = new byte[hex.Length >> 1];
			int i = 0;
			int num = 0;
			while (i < array.Length)
			{
				array[i] = (byte)(CryptoConvert.FromHexChar(hex[num++]) << 4);
				byte[] array2 = array;
				int num2 = i++;
				array2[num2] += CryptoConvert.FromHexChar(hex[num++]);
			}
			return array;
		}
	}
}
