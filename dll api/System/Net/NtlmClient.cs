using System;
using Mono.Http;

namespace System.Net
{
	// Token: 0x020001BC RID: 444
	internal class NtlmClient : IAuthenticationModule
	{
		// Token: 0x06000C06 RID: 3078 RVA: 0x0003F692 File Offset: 0x0003D892
		public NtlmClient()
		{
			this.authObject = new NtlmClient();
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0003F6A5 File Offset: 0x0003D8A5
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			if (this.authObject == null)
			{
				return null;
			}
			return this.authObject.Authenticate(challenge, webRequest, credentials);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x000022FE File Offset: 0x000004FE
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x00005794 File Offset: 0x00003994
		public string AuthenticationType
		{
			get
			{
				return "NTLM";
			}
		}

		// Token: 0x040008CF RID: 2255
		private IAuthenticationModule authObject;
	}
}
