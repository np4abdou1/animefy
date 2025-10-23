using System;

namespace Internal.Cryptography.Pal
{
	// Token: 0x0200006B RID: 107
	internal enum GeneralNameType
	{
		// Token: 0x04000163 RID: 355
		OtherName,
		// Token: 0x04000164 RID: 356
		Rfc822Name,
		// Token: 0x04000165 RID: 357
		Email = 1,
		// Token: 0x04000166 RID: 358
		DnsName,
		// Token: 0x04000167 RID: 359
		X400Address,
		// Token: 0x04000168 RID: 360
		DirectoryName,
		// Token: 0x04000169 RID: 361
		EdiPartyName,
		// Token: 0x0400016A RID: 362
		UniformResourceIdentifier,
		// Token: 0x0400016B RID: 363
		IPAddress,
		// Token: 0x0400016C RID: 364
		RegisteredId
	}
}
