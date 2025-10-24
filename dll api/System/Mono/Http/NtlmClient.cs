using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace Mono.Http
{
	// Token: 0x0200002A RID: 42
	internal class NtlmClient : IAuthenticationModule
	{
		// Token: 0x060000EF RID: 239 RVA: 0x000056C4 File Offset: 0x000038C4
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			if (credentials == null || challenge == null)
			{
				return null;
			}
			string text = challenge.Trim();
			int num = text.ToLower().IndexOf("ntlm");
			if (num == -1)
			{
				return null;
			}
			num = text.IndexOfAny(new char[]
			{
				' ',
				'\t'
			});
			if (num != -1)
			{
				text = text.Substring(num).Trim();
			}
			else
			{
				text = null;
			}
			HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
			if (httpWebRequest == null)
			{
				return null;
			}
			ConditionalWeakTable<HttpWebRequest, NtlmSession> obj = NtlmClient.cache;
			Authorization result;
			lock (obj)
			{
				result = NtlmClient.cache.GetValue(httpWebRequest, (HttpWebRequest x) => new NtlmSession()).Authenticate(text, webRequest, credentials);
			}
			return result;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000022FE File Offset: 0x000004FE
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00005794 File Offset: 0x00003994
		public string AuthenticationType
		{
			get
			{
				return "NTLM";
			}
		}

		// Token: 0x0400009E RID: 158
		private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache = new ConditionalWeakTable<HttpWebRequest, NtlmSession>();
	}
}
