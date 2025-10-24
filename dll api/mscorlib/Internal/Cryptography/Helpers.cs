using System;

namespace Internal.Cryptography
{
	// Token: 0x02000661 RID: 1633
	internal static class Helpers
	{
		// Token: 0x06003125 RID: 12581 RVA: 0x000C5B85 File Offset: 0x000C3D85
		public static byte[] CloneByteArray(this byte[] src)
		{
			if (src == null)
			{
				return null;
			}
			return (byte[])src.Clone();
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x000C5B98 File Offset: 0x000C3D98
		public static char[] ToHexArrayUpper(this byte[] bytes)
		{
			char[] array = new char[bytes.Length * 2];
			int num = 0;
			foreach (byte b in bytes)
			{
				array[num++] = Helpers.NibbleToHex((byte)(b >> 4));
				array[num++] = Helpers.NibbleToHex(b & 15);
			}
			return array;
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x000C5BEB File Offset: 0x000C3DEB
		public static string ToHexStringUpper(this byte[] bytes)
		{
			return new string(bytes.ToHexArrayUpper());
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x000C5BF8 File Offset: 0x000C3DF8
		private static char NibbleToHex(byte b)
		{
			return (char)((b >= 0 && b <= 9) ? (48 + b) : (65 + (b - 10)));
		}
	}
}
