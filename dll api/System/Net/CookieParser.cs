﻿using System;
using System.Globalization;

namespace System.Net
{
	// Token: 0x02000183 RID: 387
	internal class CookieParser
	{
		// Token: 0x06000A89 RID: 2697 RVA: 0x0003799E File Offset: 0x00035B9E
		internal CookieParser(string cookieString)
		{
			this.m_tokenizer = new CookieTokenizer(cookieString);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x000379B4 File Offset: 0x00035BB4
		internal Cookie Get()
		{
			Cookie cookie = null;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			bool flag8 = false;
			bool flag9 = false;
			do
			{
				CookieToken cookieToken = this.m_tokenizer.Next(cookie == null, true);
				if (cookie == null && (cookieToken == CookieToken.NameValuePair || cookieToken == CookieToken.Attribute))
				{
					cookie = new Cookie();
					if (!cookie.InternalSetName(this.m_tokenizer.Name))
					{
						cookie.InternalSetName(string.Empty);
					}
					cookie.Value = this.m_tokenizer.Value;
				}
				else if (cookieToken != CookieToken.NameValuePair)
				{
					if (cookieToken == CookieToken.Attribute)
					{
						CookieToken token = this.m_tokenizer.Token;
						if (token != CookieToken.Discard)
						{
							switch (token)
							{
							case CookieToken.Port:
								if (!flag6)
								{
									flag6 = true;
									cookie.Port = string.Empty;
								}
								break;
							case CookieToken.Secure:
								if (!flag8)
								{
									flag8 = true;
									cookie.Secure = true;
								}
								break;
							case CookieToken.HttpOnly:
								cookie.HttpOnly = true;
								break;
							}
						}
						else if (!flag9)
						{
							flag9 = true;
							cookie.Discard = true;
						}
					}
				}
				else
				{
					switch (this.m_tokenizer.Token)
					{
					case CookieToken.Comment:
						if (!flag)
						{
							flag = true;
							cookie.Comment = this.m_tokenizer.Value;
							goto IL_2F4;
						}
						goto IL_2F4;
					case CookieToken.CommentUrl:
					{
						if (flag2)
						{
							goto IL_2F4;
						}
						flag2 = true;
						Uri commentUri;
						if (Uri.TryCreate(CookieParser.CheckQuoted(this.m_tokenizer.Value), UriKind.Absolute, out commentUri))
						{
							cookie.CommentUri = commentUri;
							goto IL_2F4;
						}
						goto IL_2F4;
					}
					case CookieToken.CookieName:
					case CookieToken.Discard:
					case CookieToken.Secure:
					case CookieToken.HttpOnly:
					case CookieToken.Unknown:
						goto IL_2F4;
					case CookieToken.Domain:
						if (!flag3)
						{
							flag3 = true;
							cookie.Domain = CookieParser.CheckQuoted(this.m_tokenizer.Value);
							cookie.IsQuotedDomain = this.m_tokenizer.Quoted;
							goto IL_2F4;
						}
						goto IL_2F4;
					case CookieToken.Expires:
					{
						if (flag4)
						{
							goto IL_2F4;
						}
						flag4 = true;
						DateTime expires;
						if (DateTime.TryParse(CookieParser.CheckQuoted(this.m_tokenizer.Value), CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out expires))
						{
							cookie.Expires = expires;
							goto IL_2F4;
						}
						cookie.InternalSetName(string.Empty);
						goto IL_2F4;
					}
					case CookieToken.MaxAge:
					{
						if (flag4)
						{
							goto IL_2F4;
						}
						flag4 = true;
						int num;
						if (int.TryParse(CookieParser.CheckQuoted(this.m_tokenizer.Value), out num))
						{
							cookie.Expires = DateTime.Now.AddSeconds((double)num);
							goto IL_2F4;
						}
						cookie.InternalSetName(string.Empty);
						goto IL_2F4;
					}
					case CookieToken.Path:
						if (!flag5)
						{
							flag5 = true;
							cookie.Path = this.m_tokenizer.Value;
							goto IL_2F4;
						}
						goto IL_2F4;
					case CookieToken.Port:
						if (flag6)
						{
							goto IL_2F4;
						}
						flag6 = true;
						try
						{
							cookie.Port = this.m_tokenizer.Value;
							goto IL_2F4;
						}
						catch
						{
							cookie.InternalSetName(string.Empty);
							goto IL_2F4;
						}
						break;
					case CookieToken.Version:
						break;
					default:
						goto IL_2F4;
					}
					if (!flag7)
					{
						flag7 = true;
						int version;
						if (int.TryParse(CookieParser.CheckQuoted(this.m_tokenizer.Value), out version))
						{
							cookie.Version = version;
							cookie.IsQuotedVersion = this.m_tokenizer.Quoted;
						}
						else
						{
							cookie.InternalSetName(string.Empty);
						}
					}
				}
				IL_2F4:;
			}
			while (!this.m_tokenizer.Eof && !this.m_tokenizer.EndOfCookie);
			return cookie;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00037CE4 File Offset: 0x00035EE4
		internal static string CheckQuoted(string value)
		{
			if (value.Length < 2 || value[0] != '"' || value[value.Length - 1] != '"')
			{
				return value;
			}
			if (value.Length != 2)
			{
				return value.Substring(1, value.Length - 2);
			}
			return string.Empty;
		}

		// Token: 0x040007C2 RID: 1986
		private CookieTokenizer m_tokenizer;
	}
}
