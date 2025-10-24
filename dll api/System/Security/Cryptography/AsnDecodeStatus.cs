using System;

namespace System.Security.Cryptography
{
	// Token: 0x020000DF RID: 223
	internal enum AsnDecodeStatus
	{
		// Token: 0x04000447 RID: 1095
		NotDecoded = -1,
		// Token: 0x04000448 RID: 1096
		Ok,
		// Token: 0x04000449 RID: 1097
		BadAsn,
		// Token: 0x0400044A RID: 1098
		BadTag,
		// Token: 0x0400044B RID: 1099
		BadLength,
		// Token: 0x0400044C RID: 1100
		InformationNotAvailable
	}
}
