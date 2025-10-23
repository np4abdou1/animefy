using System;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000032 RID: 50
	public enum NtlmAuthLevel
	{
		// Token: 0x04000092 RID: 146
		LM_and_NTLM,
		// Token: 0x04000093 RID: 147
		LM_and_NTLM_and_try_NTLMv2_Session,
		// Token: 0x04000094 RID: 148
		NTLM_only,
		// Token: 0x04000095 RID: 149
		NTLMv2_only
	}
}
