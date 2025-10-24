using System;
using System.Collections;

namespace System.Net
{
	// Token: 0x020001A6 RID: 422
	internal class DigestClient : IAuthenticationModule
	{
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x0003B6F8 File Offset: 0x000398F8
		private static Hashtable Cache
		{
			get
			{
				object syncRoot = DigestClient.cache.SyncRoot;
				lock (syncRoot)
				{
					DigestClient.CheckExpired(DigestClient.cache.Count);
				}
				return DigestClient.cache;
			}
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0003B74C File Offset: 0x0003994C
		private static void CheckExpired(int count)
		{
			if (count < 10)
			{
				return;
			}
			DateTime t = DateTime.MaxValue;
			DateTime utcNow = DateTime.UtcNow;
			ArrayList arrayList = null;
			foreach (object obj in DigestClient.cache.Keys)
			{
				int num = (int)obj;
				DigestSession digestSession = (DigestSession)DigestClient.cache[num];
				if (digestSession.LastUse < t && (digestSession.LastUse - utcNow).Ticks > 6000000000L)
				{
					t = digestSession.LastUse;
					if (arrayList == null)
					{
						arrayList = new ArrayList();
					}
					arrayList.Add(num);
				}
			}
			if (arrayList != null)
			{
				foreach (object obj2 in arrayList)
				{
					int num2 = (int)obj2;
					DigestClient.cache.Remove(num2);
				}
			}
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0003B878 File Offset: 0x00039A78
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			if (credentials == null || challenge == null)
			{
				return null;
			}
			if (challenge.Trim().ToLower().IndexOf("digest") == -1)
			{
				return null;
			}
			HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
			if (httpWebRequest == null)
			{
				return null;
			}
			DigestSession digestSession = new DigestSession();
			if (!digestSession.Parse(challenge))
			{
				return null;
			}
			int num = httpWebRequest.Address.GetHashCode() ^ credentials.GetHashCode() ^ digestSession.Nonce.GetHashCode();
			DigestSession digestSession2 = (DigestSession)DigestClient.Cache[num];
			bool flag = digestSession2 == null;
			if (flag)
			{
				digestSession2 = digestSession;
			}
			else if (!digestSession2.Parse(challenge))
			{
				return null;
			}
			if (flag)
			{
				DigestClient.Cache.Add(num, digestSession2);
			}
			return digestSession2.Authenticate(webRequest, credentials);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0003B930 File Offset: 0x00039B30
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
			if (httpWebRequest == null)
			{
				return null;
			}
			if (credentials == null)
			{
				return null;
			}
			int num = httpWebRequest.Address.GetHashCode() ^ credentials.GetHashCode();
			DigestSession digestSession = (DigestSession)DigestClient.Cache[num];
			if (digestSession == null)
			{
				return null;
			}
			return digestSession.Authenticate(webRequest, credentials);
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0003B984 File Offset: 0x00039B84
		public string AuthenticationType
		{
			get
			{
				return "Digest";
			}
		}

		// Token: 0x04000828 RID: 2088
		private static readonly Hashtable cache = Hashtable.Synchronized(new Hashtable());
	}
}
