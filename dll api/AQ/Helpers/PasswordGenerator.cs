using System;
using System.Text;

namespace AQ.Helpers
{
	// Token: 0x02000092 RID: 146
	public class PasswordGenerator
	{
		// Token: 0x06000691 RID: 1681 RVA: 0x00013960 File Offset: 0x00011B60
		public static string CreatePassword()
		{
			int num = 8;
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			while (0 < num--)
			{
				stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".Length)]);
			}
			return stringBuilder.ToString();
		}
	}
}
