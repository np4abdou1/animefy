using System;
using System.Security.Cryptography;
using System.Text;

namespace System.Net
{
	// Token: 0x020001A5 RID: 421
	internal class DigestSession
	{
		// Token: 0x06000B42 RID: 2882 RVA: 0x0003B2B9 File Offset: 0x000394B9
		public DigestSession()
		{
			this._nc = 1;
			this.lastUse = DateTime.UtcNow;
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x0003B2D3 File Offset: 0x000394D3
		public string Algorithm
		{
			get
			{
				return this.parser.Algorithm;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x0003B2E0 File Offset: 0x000394E0
		public string Realm
		{
			get
			{
				return this.parser.Realm;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x0003B2ED File Offset: 0x000394ED
		public string Nonce
		{
			get
			{
				return this.parser.Nonce;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0003B2FA File Offset: 0x000394FA
		public string Opaque
		{
			get
			{
				return this.parser.Opaque;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0003B307 File Offset: 0x00039507
		public string QOP
		{
			get
			{
				return this.parser.QOP;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x0003B314 File Offset: 0x00039514
		public string CNonce
		{
			get
			{
				if (this._cnonce == null)
				{
					byte[] array = new byte[15];
					DigestSession.rng.GetBytes(array);
					this._cnonce = Convert.ToBase64String(array);
					Array.Clear(array, 0, array.Length);
				}
				return this._cnonce;
			}
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0003B358 File Offset: 0x00039558
		public bool Parse(string challenge)
		{
			this.parser = new DigestHeaderParser(challenge);
			if (!this.parser.Parse())
			{
				return false;
			}
			if (this.parser.Algorithm == null || this.parser.Algorithm.ToUpper().StartsWith("MD5"))
			{
				this.hash = MD5.Create();
			}
			return true;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0003B3B8 File Offset: 0x000395B8
		private string HashToHexString(string toBeHashed)
		{
			if (this.hash == null)
			{
				return null;
			}
			this.hash.Initialize();
			byte[] array = this.hash.ComputeHash(Encoding.ASCII.GetBytes(toBeHashed));
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0003B424 File Offset: 0x00039624
		private string HA1(string username, string password)
		{
			string toBeHashed = string.Format("{0}:{1}:{2}", username, this.Realm, password);
			if (this.Algorithm != null && this.Algorithm.ToLower() == "md5-sess")
			{
				toBeHashed = string.Format("{0}:{1}:{2}", this.HashToHexString(toBeHashed), this.Nonce, this.CNonce);
			}
			return this.HashToHexString(toBeHashed);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0003B488 File Offset: 0x00039688
		private string HA2(HttpWebRequest webRequest)
		{
			string toBeHashed = string.Format("{0}:{1}", webRequest.Method, webRequest.RequestUri.PathAndQuery);
			this.QOP == "auth-int";
			return this.HashToHexString(toBeHashed);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0003B4CC File Offset: 0x000396CC
		private string Response(string username, string password, HttpWebRequest webRequest)
		{
			string text = string.Format("{0}:{1}:", this.HA1(username, password), this.Nonce);
			if (this.QOP != null)
			{
				text += string.Format("{0}:{1}:{2}:", this._nc.ToString("X8"), this.CNonce, this.QOP);
			}
			text += this.HA2(webRequest);
			return this.HashToHexString(text);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0003B53C File Offset: 0x0003973C
		public Authorization Authenticate(WebRequest webRequest, ICredentials credentials)
		{
			if (this.parser == null)
			{
				throw new InvalidOperationException();
			}
			HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
			if (httpWebRequest == null)
			{
				return null;
			}
			this.lastUse = DateTime.UtcNow;
			NetworkCredential credential = credentials.GetCredential(httpWebRequest.RequestUri, "digest");
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
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("Digest username=\"{0}\", ", userName);
			stringBuilder.AppendFormat("realm=\"{0}\", ", this.Realm);
			stringBuilder.AppendFormat("nonce=\"{0}\", ", this.Nonce);
			stringBuilder.AppendFormat("uri=\"{0}\", ", httpWebRequest.Address.PathAndQuery);
			if (this.Algorithm != null)
			{
				stringBuilder.AppendFormat("algorithm=\"{0}\", ", this.Algorithm);
			}
			stringBuilder.AppendFormat("response=\"{0}\", ", this.Response(userName, password, httpWebRequest));
			if (this.QOP != null)
			{
				stringBuilder.AppendFormat("qop=\"{0}\", ", this.QOP);
			}
			lock (this)
			{
				if (this.QOP != null)
				{
					stringBuilder.AppendFormat("nc={0:X8}, ", this._nc);
					this._nc++;
				}
			}
			if (this.CNonce != null)
			{
				stringBuilder.AppendFormat("cnonce=\"{0}\", ", this.CNonce);
			}
			if (this.Opaque != null)
			{
				stringBuilder.AppendFormat("opaque=\"{0}\", ", this.Opaque);
			}
			stringBuilder.Length -= 2;
			return new Authorization(stringBuilder.ToString());
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0003B6F0 File Offset: 0x000398F0
		public DateTime LastUse
		{
			get
			{
				return this.lastUse;
			}
		}

		// Token: 0x04000822 RID: 2082
		private static RandomNumberGenerator rng = RandomNumberGenerator.Create();

		// Token: 0x04000823 RID: 2083
		private DateTime lastUse;

		// Token: 0x04000824 RID: 2084
		private int _nc;

		// Token: 0x04000825 RID: 2085
		private HashAlgorithm hash;

		// Token: 0x04000826 RID: 2086
		private DigestHeaderParser parser;

		// Token: 0x04000827 RID: 2087
		private string _cnonce;
	}
}
