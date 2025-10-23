using System;

namespace System.Net
{
	// Token: 0x020001A4 RID: 420
	internal class DigestHeaderParser
	{
		// Token: 0x06000B36 RID: 2870 RVA: 0x0003AF2D File Offset: 0x0003912D
		public DigestHeaderParser(string header)
		{
			this.header = header.Trim();
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0003AF53 File Offset: 0x00039153
		public string Realm
		{
			get
			{
				return this.values[0];
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0003AF5D File Offset: 0x0003915D
		public string Opaque
		{
			get
			{
				return this.values[1];
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0003AF67 File Offset: 0x00039167
		public string Nonce
		{
			get
			{
				return this.values[2];
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0003AF71 File Offset: 0x00039171
		public string Algorithm
		{
			get
			{
				return this.values[3];
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x0003AF7B File Offset: 0x0003917B
		public string QOP
		{
			get
			{
				return this.values[4];
			}
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0003AF88 File Offset: 0x00039188
		public bool Parse()
		{
			if (!this.header.ToLower().StartsWith("digest "))
			{
				return false;
			}
			this.pos = 6;
			this.length = this.header.Length;
			while (this.pos < this.length)
			{
				string value;
				string text;
				if (!this.GetKeywordAndValue(out value, out text))
				{
					return false;
				}
				this.SkipWhitespace();
				if (this.pos < this.length && this.header[this.pos] == ',')
				{
					this.pos++;
				}
				int num = Array.IndexOf<string>(DigestHeaderParser.keywords, value);
				if (num != -1)
				{
					if (this.values[num] != null)
					{
						return false;
					}
					this.values[num] = text;
				}
			}
			return this.Realm != null && this.Nonce != null;
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0003B054 File Offset: 0x00039254
		private void SkipWhitespace()
		{
			char c = ' ';
			while (this.pos < this.length && (c == ' ' || c == '\t' || c == '\r' || c == '\n'))
			{
				string text = this.header;
				int num = this.pos;
				this.pos = num + 1;
				c = text[num];
			}
			this.pos--;
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0003B0B4 File Offset: 0x000392B4
		private string GetKey()
		{
			this.SkipWhitespace();
			int num = this.pos;
			while (this.pos < this.length && this.header[this.pos] != '=')
			{
				this.pos++;
			}
			return this.header.Substring(num, this.pos - num).Trim().ToLower();
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0003B120 File Offset: 0x00039320
		private bool GetKeywordAndValue(out string key, out string value)
		{
			key = null;
			value = null;
			key = this.GetKey();
			if (this.pos >= this.length)
			{
				return false;
			}
			this.SkipWhitespace();
			if (this.pos + 1 < this.length)
			{
				string text = this.header;
				int num = this.pos;
				this.pos = num + 1;
				if (text[num] == '=')
				{
					this.SkipWhitespace();
					if (this.pos + 1 >= this.length)
					{
						return false;
					}
					bool flag = false;
					if (this.header[this.pos] == '"')
					{
						this.pos++;
						flag = true;
					}
					int num2 = this.pos;
					if (flag)
					{
						this.pos = this.header.IndexOf('"', this.pos);
						if (this.pos == -1)
						{
							return false;
						}
					}
					else
					{
						do
						{
							char c = this.header[this.pos];
							if (c == ',' || c == ' ' || c == '\t' || c == '\r' || c == '\n')
							{
								break;
							}
							num = this.pos + 1;
							this.pos = num;
						}
						while (num < this.length);
						if (this.pos >= this.length && num2 == this.pos)
						{
							return false;
						}
					}
					value = this.header.Substring(num2, this.pos - num2);
					this.pos += (flag ? 2 : 1);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0400081D RID: 2077
		private string header;

		// Token: 0x0400081E RID: 2078
		private int length;

		// Token: 0x0400081F RID: 2079
		private int pos;

		// Token: 0x04000820 RID: 2080
		private static string[] keywords = new string[]
		{
			"realm",
			"opaque",
			"nonce",
			"algorithm",
			"qop"
		};

		// Token: 0x04000821 RID: 2081
		private string[] values = new string[DigestHeaderParser.keywords.Length];
	}
}
