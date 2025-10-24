using System;

namespace System.Net
{
	// Token: 0x0200019C RID: 412
	internal class BasicClient : IAuthenticationModule
	{
		// Token: 0x06000B22 RID: 2850 RVA: 0x0003AA96 File Offset: 0x00038C96
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			if (credentials == null || challenge == null)
			{
				return null;
			}
			if (challenge.Trim().ToLower().IndexOf("basic", StringComparison.Ordinal) == -1)
			{
				return null;
			}
			return BasicClient.InternalAuthenticate(webRequest, credentials);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0003AAC4 File Offset: 0x00038CC4
		private static byte[] GetBytes(string str)
		{
			int i = str.Length;
			byte[] array = new byte[i];
			for (i--; i >= 0; i--)
			{
				array[i] = (byte)str[i];
			}
			return array;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0003AAFC File Offset: 0x00038CFC
		private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
			if (httpWebRequest == null || credentials == null)
			{
				return null;
			}
			NetworkCredential credential = credentials.GetCredential(httpWebRequest.AuthUri, "basic");
			if (credential == null)
			{
				return null;
			}
			string userName = credential.UserName;
			if (userName == null || userName == "")
			{
				return null;
			}
			string password = credential.Password;
			string domain = credential.Domain;
			byte[] bytes;
			if (domain == null || domain == "" || domain.Trim() == "")
			{
				bytes = BasicClient.GetBytes(userName + ":" + password);
			}
			else
			{
				bytes = BasicClient.GetBytes(string.Concat(new string[]
				{
					domain,
					"\\",
					userName,
					":",
					password
				}));
			}
			return new Authorization("Basic " + Convert.ToBase64String(bytes));
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0003ABD6 File Offset: 0x00038DD6
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			return BasicClient.InternalAuthenticate(webRequest, credentials);
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x0003ABDF File Offset: 0x00038DDF
		public string AuthenticationType
		{
			get
			{
				return "Basic";
			}
		}
	}
}
