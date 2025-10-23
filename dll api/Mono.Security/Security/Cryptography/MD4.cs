using System;
using System.Security.Cryptography;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000049 RID: 73
	public abstract class MD4 : HashAlgorithm
	{
		// Token: 0x0600017E RID: 382 RVA: 0x0000A0F5 File Offset: 0x000082F5
		protected MD4()
		{
			this.HashSizeValue = 128;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000A108 File Offset: 0x00008308
		public static MD4 Create()
		{
			return MD4.Create("MD4");
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000A114 File Offset: 0x00008314
		public new static MD4 Create(string hashName)
		{
			object obj = CryptoConfig.CreateFromName(hashName);
			if (obj == null)
			{
				obj = new MD4Managed();
			}
			return (MD4)obj;
		}
	}
}
