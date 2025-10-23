using System;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000034 RID: 52
	public static class NtlmSettings
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00009186 File Offset: 0x00007386
		public static NtlmAuthLevel DefaultAuthLevel
		{
			get
			{
				return NtlmSettings.defaultAuthLevel;
			}
		}

		// Token: 0x040000A1 RID: 161
		private static NtlmAuthLevel defaultAuthLevel = NtlmAuthLevel.LM_and_NTLM_and_try_NTLMv2_Session;
	}
}
