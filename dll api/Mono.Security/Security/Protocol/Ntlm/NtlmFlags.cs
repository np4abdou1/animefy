using System;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000033 RID: 51
	[Flags]
	public enum NtlmFlags
	{
		// Token: 0x04000097 RID: 151
		NegotiateUnicode = 1,
		// Token: 0x04000098 RID: 152
		NegotiateOem = 2,
		// Token: 0x04000099 RID: 153
		RequestTarget = 4,
		// Token: 0x0400009A RID: 154
		NegotiateNtlm = 512,
		// Token: 0x0400009B RID: 155
		NegotiateDomainSupplied = 4096,
		// Token: 0x0400009C RID: 156
		NegotiateWorkstationSupplied = 8192,
		// Token: 0x0400009D RID: 157
		NegotiateAlwaysSign = 32768,
		// Token: 0x0400009E RID: 158
		NegotiateNtlm2Key = 524288,
		// Token: 0x0400009F RID: 159
		Negotiate128 = 536870912,
		// Token: 0x040000A0 RID: 160
		Negotiate56 = -2147483648
	}
}
