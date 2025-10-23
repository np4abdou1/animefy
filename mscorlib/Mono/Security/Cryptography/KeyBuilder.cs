using System;
using System.Security.Cryptography;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000049 RID: 73
	internal sealed class KeyBuilder
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00009AA7 File Offset: 0x00007CA7
		private static RandomNumberGenerator Rng
		{
			get
			{
				if (KeyBuilder.rng == null)
				{
					KeyBuilder.rng = RandomNumberGenerator.Create();
				}
				return KeyBuilder.rng;
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00009AC0 File Offset: 0x00007CC0
		public static byte[] Key(int size)
		{
			byte[] array = new byte[size];
			KeyBuilder.Rng.GetBytes(array);
			return array;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00009AE0 File Offset: 0x00007CE0
		public static byte[] IV(int size)
		{
			byte[] array = new byte[size];
			KeyBuilder.Rng.GetBytes(array);
			return array;
		}

		// Token: 0x04000166 RID: 358
		private static RandomNumberGenerator rng;
	}
}
