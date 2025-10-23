using System;

namespace System.Net
{
	// Token: 0x02000181 RID: 385
	internal class CookieTokenizer
	{
		// Token: 0x06000A74 RID: 2676 RVA: 0x000373D4 File Offset: 0x000355D4
		internal CookieTokenizer(string tokenStream)
		{
			this.m_length = tokenStream.Length;
			this.m_tokenStream = tokenStream;
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x000373EF File Offset: 0x000355EF
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x000373F7 File Offset: 0x000355F7
		internal bool EndOfCookie
		{
			get
			{
				return this.m_eofCookie;
			}
			set
			{
				this.m_eofCookie = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00037400 File Offset: 0x00035600
		internal bool Eof
		{
			get
			{
				return this.m_index >= this.m_length;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00037413 File Offset: 0x00035613
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x0003741B File Offset: 0x0003561B
		internal string Name
		{
			get
			{
				return this.m_name;
			}
			set
			{
				this.m_name = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x00037424 File Offset: 0x00035624
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x0003742C File Offset: 0x0003562C
		internal bool Quoted
		{
			get
			{
				return this.m_quoted;
			}
			set
			{
				this.m_quoted = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x00037435 File Offset: 0x00035635
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x0003743D File Offset: 0x0003563D
		internal CookieToken Token
		{
			get
			{
				return this.m_token;
			}
			set
			{
				this.m_token = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00037446 File Offset: 0x00035646
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x0003744E File Offset: 0x0003564E
		internal string Value
		{
			get
			{
				return this.m_value;
			}
			set
			{
				this.m_value = value;
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00037458 File Offset: 0x00035658
		internal string Extract()
		{
			string text = string.Empty;
			if (this.m_tokenLength != 0)
			{
				text = this.m_tokenStream.Substring(this.m_start, this.m_tokenLength);
				if (!this.Quoted)
				{
					text = text.Trim();
				}
			}
			return text;
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0003749C File Offset: 0x0003569C
		internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals)
		{
			this.m_tokenLength = 0;
			this.m_start = this.m_index;
			while (this.m_index < this.m_length && char.IsWhiteSpace(this.m_tokenStream[this.m_index]))
			{
				this.m_index++;
				this.m_start++;
			}
			CookieToken result = CookieToken.End;
			int num = 1;
			if (!this.Eof)
			{
				if (this.m_tokenStream[this.m_index] == '"')
				{
					this.Quoted = true;
					this.m_index++;
					bool flag = false;
					while (this.m_index < this.m_length)
					{
						char c = this.m_tokenStream[this.m_index];
						if (!flag && c == '"')
						{
							break;
						}
						if (flag)
						{
							flag = false;
						}
						else if (c == '\\')
						{
							flag = true;
						}
						this.m_index++;
					}
					if (this.m_index < this.m_length)
					{
						this.m_index++;
					}
					this.m_tokenLength = this.m_index - this.m_start;
					num = 0;
					ignoreComma = false;
				}
				while (this.m_index < this.m_length && this.m_tokenStream[this.m_index] != ';' && (ignoreEquals || this.m_tokenStream[this.m_index] != '=') && (ignoreComma || this.m_tokenStream[this.m_index] != ','))
				{
					if (this.m_tokenStream[this.m_index] == ',')
					{
						this.m_start = this.m_index + 1;
						this.m_tokenLength = -1;
						ignoreComma = false;
					}
					this.m_index++;
					this.m_tokenLength += num;
				}
				if (!this.Eof)
				{
					char c2 = this.m_tokenStream[this.m_index];
					if (c2 != ';')
					{
						if (c2 != '=')
						{
							result = CookieToken.EndCookie;
						}
						else
						{
							result = CookieToken.Equals;
						}
					}
					else
					{
						result = CookieToken.EndToken;
					}
					this.m_index++;
				}
			}
			return result;
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x000376A0 File Offset: 0x000358A0
		internal CookieToken Next(bool first, bool parseResponseCookies)
		{
			this.Reset();
			CookieToken cookieToken = this.FindNext(false, false);
			if (cookieToken == CookieToken.EndCookie)
			{
				this.EndOfCookie = true;
			}
			if (cookieToken == CookieToken.End || cookieToken == CookieToken.EndCookie)
			{
				if ((this.Name = this.Extract()).Length != 0)
				{
					this.Token = this.TokenFromName(parseResponseCookies);
					return CookieToken.Attribute;
				}
				return cookieToken;
			}
			else
			{
				this.Name = this.Extract();
				if (first)
				{
					this.Token = CookieToken.CookieName;
				}
				else
				{
					this.Token = this.TokenFromName(parseResponseCookies);
				}
				if (cookieToken == CookieToken.Equals)
				{
					cookieToken = this.FindNext(!first && this.Token == CookieToken.Expires, true);
					if (cookieToken == CookieToken.EndCookie)
					{
						this.EndOfCookie = true;
					}
					this.Value = this.Extract();
					return CookieToken.NameValuePair;
				}
				return CookieToken.Attribute;
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00037752 File Offset: 0x00035952
		internal void Reset()
		{
			this.m_eofCookie = false;
			this.m_name = string.Empty;
			this.m_quoted = false;
			this.m_start = this.m_index;
			this.m_token = CookieToken.Nothing;
			this.m_tokenLength = 0;
			this.m_value = string.Empty;
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00037794 File Offset: 0x00035994
		internal CookieToken TokenFromName(bool parseResponseCookies)
		{
			if (!parseResponseCookies)
			{
				for (int i = 0; i < CookieTokenizer.RecognizedServerAttributes.Length; i++)
				{
					if (CookieTokenizer.RecognizedServerAttributes[i].IsEqualTo(this.Name))
					{
						return CookieTokenizer.RecognizedServerAttributes[i].Token;
					}
				}
			}
			else
			{
				for (int j = 0; j < CookieTokenizer.RecognizedAttributes.Length; j++)
				{
					if (CookieTokenizer.RecognizedAttributes[j].IsEqualTo(this.Name))
					{
						return CookieTokenizer.RecognizedAttributes[j].Token;
					}
				}
			}
			return CookieToken.Unknown;
		}

		// Token: 0x040007B4 RID: 1972
		private bool m_eofCookie;

		// Token: 0x040007B5 RID: 1973
		private int m_index;

		// Token: 0x040007B6 RID: 1974
		private int m_length;

		// Token: 0x040007B7 RID: 1975
		private string m_name;

		// Token: 0x040007B8 RID: 1976
		private bool m_quoted;

		// Token: 0x040007B9 RID: 1977
		private int m_start;

		// Token: 0x040007BA RID: 1978
		private CookieToken m_token;

		// Token: 0x040007BB RID: 1979
		private int m_tokenLength;

		// Token: 0x040007BC RID: 1980
		private string m_tokenStream;

		// Token: 0x040007BD RID: 1981
		private string m_value;

		// Token: 0x040007BE RID: 1982
		private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes = new CookieTokenizer.RecognizedAttribute[]
		{
			new CookieTokenizer.RecognizedAttribute("Path", CookieToken.Path),
			new CookieTokenizer.RecognizedAttribute("Max-Age", CookieToken.MaxAge),
			new CookieTokenizer.RecognizedAttribute("Expires", CookieToken.Expires),
			new CookieTokenizer.RecognizedAttribute("Version", CookieToken.Version),
			new CookieTokenizer.RecognizedAttribute("Domain", CookieToken.Domain),
			new CookieTokenizer.RecognizedAttribute("Secure", CookieToken.Secure),
			new CookieTokenizer.RecognizedAttribute("Discard", CookieToken.Discard),
			new CookieTokenizer.RecognizedAttribute("Port", CookieToken.Port),
			new CookieTokenizer.RecognizedAttribute("Comment", CookieToken.Comment),
			new CookieTokenizer.RecognizedAttribute("CommentURL", CookieToken.CommentUrl),
			new CookieTokenizer.RecognizedAttribute("HttpOnly", CookieToken.HttpOnly)
		};

		// Token: 0x040007BF RID: 1983
		private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes = new CookieTokenizer.RecognizedAttribute[]
		{
			new CookieTokenizer.RecognizedAttribute("$Path", CookieToken.Path),
			new CookieTokenizer.RecognizedAttribute("$Version", CookieToken.Version),
			new CookieTokenizer.RecognizedAttribute("$Domain", CookieToken.Domain),
			new CookieTokenizer.RecognizedAttribute("$Port", CookieToken.Port),
			new CookieTokenizer.RecognizedAttribute("$HttpOnly", CookieToken.HttpOnly)
		};

		// Token: 0x02000182 RID: 386
		private struct RecognizedAttribute
		{
			// Token: 0x06000A86 RID: 2694 RVA: 0x00037974 File Offset: 0x00035B74
			internal RecognizedAttribute(string name, CookieToken token)
			{
				this.m_name = name;
				this.m_token = token;
			}

			// Token: 0x170001FB RID: 507
			// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00037984 File Offset: 0x00035B84
			internal CookieToken Token
			{
				get
				{
					return this.m_token;
				}
			}

			// Token: 0x06000A88 RID: 2696 RVA: 0x0003798C File Offset: 0x00035B8C
			internal bool IsEqualTo(string value)
			{
				return string.Compare(this.m_name, value, StringComparison.OrdinalIgnoreCase) == 0;
			}

			// Token: 0x040007C0 RID: 1984
			private string m_name;

			// Token: 0x040007C1 RID: 1985
			private CookieToken m_token;
		}
	}
}
