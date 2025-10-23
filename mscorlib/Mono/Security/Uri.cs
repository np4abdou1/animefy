﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Mono.Security
{
	// Token: 0x02000046 RID: 70
	internal class Uri
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00007F4E File Offset: 0x0000614E
		public Uri(string uriString) : this(uriString, false)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00007F58 File Offset: 0x00006158
		public Uri(string uriString, bool dontEscape)
		{
			this.userEscaped = dontEscape;
			this.source = uriString;
			this.Parse();
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00007FCF File Offset: 0x000061CF
		public string AbsolutePath
		{
			get
			{
				return this.path;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00007FD7 File Offset: 0x000061D7
		public bool IsFile
		{
			get
			{
				return this.scheme == Uri.UriSchemeFile;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00007FE9 File Offset: 0x000061E9
		public bool IsUnc
		{
			get
			{
				return this.isUnc;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00007FF4 File Offset: 0x000061F4
		public string LocalPath
		{
			get
			{
				if (this.cachedLocalPath != null)
				{
					return this.cachedLocalPath;
				}
				if (!this.IsFile)
				{
					return this.AbsolutePath;
				}
				bool flag = this.path.Length > 3 && this.path[1] == ':' && (this.path[2] == '\\' || this.path[2] == '/');
				if (!this.IsUnc)
				{
					string text = this.Unescape(this.path);
					if (Path.DirectorySeparatorChar == '\\' || flag)
					{
						this.cachedLocalPath = text.Replace('/', '\\');
					}
					else
					{
						this.cachedLocalPath = text;
					}
				}
				else if (this.path.Length > 1 && this.path[1] == ':')
				{
					this.cachedLocalPath = this.Unescape(this.path.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar));
				}
				else if (Path.DirectorySeparatorChar == '\\')
				{
					this.cachedLocalPath = "\\\\" + this.Unescape(this.host + this.path.Replace('/', '\\'));
				}
				else
				{
					this.cachedLocalPath = this.Unescape(this.path);
				}
				if (this.cachedLocalPath == string.Empty)
				{
					this.cachedLocalPath = Path.DirectorySeparatorChar.ToString();
				}
				return this.cachedLocalPath;
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00008160 File Offset: 0x00006360
		public override bool Equals(object comparant)
		{
			if (comparant == null)
			{
				return false;
			}
			Uri uri = comparant as Uri;
			if (uri == null)
			{
				string text = comparant as string;
				if (text == null)
				{
					return false;
				}
				uri = new Uri(text);
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return this.scheme.ToLower(invariantCulture) == uri.scheme.ToLower(invariantCulture) && this.userinfo.ToLower(invariantCulture) == uri.userinfo.ToLower(invariantCulture) && this.host.ToLower(invariantCulture) == uri.host.ToLower(invariantCulture) && this.port == uri.port && this.path == uri.path && this.query.ToLower(invariantCulture) == uri.query.ToLower(invariantCulture);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00008234 File Offset: 0x00006434
		public override int GetHashCode()
		{
			if (this.cachedHashCode == 0)
			{
				this.cachedHashCode = this.scheme.GetHashCode() + this.userinfo.GetHashCode() + this.host.GetHashCode() + this.port + this.path.GetHashCode() + this.query.GetHashCode();
			}
			return this.cachedHashCode;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00008298 File Offset: 0x00006498
		public string GetLeftPart(UriPartial part)
		{
			switch (part)
			{
			case UriPartial.Scheme:
				return this.scheme + this.GetOpaqueWiseSchemeDelimiter();
			case UriPartial.Authority:
			{
				if (this.host == string.Empty || this.scheme == Uri.UriSchemeMailto || this.scheme == Uri.UriSchemeNews)
				{
					return string.Empty;
				}
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(this.scheme);
				stringBuilder.Append(this.GetOpaqueWiseSchemeDelimiter());
				if (this.path.Length > 1 && this.path[1] == ':' && Uri.UriSchemeFile == this.scheme)
				{
					stringBuilder.Append('/');
				}
				if (this.userinfo.Length > 0)
				{
					stringBuilder.Append(this.userinfo).Append('@');
				}
				stringBuilder.Append(this.host);
				int defaultPort = Uri.GetDefaultPort(this.scheme);
				if (this.port != -1 && this.port != defaultPort)
				{
					stringBuilder.Append(':').Append(this.port);
				}
				return stringBuilder.ToString();
			}
			case UriPartial.Path:
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.Append(this.scheme);
				stringBuilder2.Append(this.GetOpaqueWiseSchemeDelimiter());
				if (this.path.Length > 1 && this.path[1] == ':' && Uri.UriSchemeFile == this.scheme)
				{
					stringBuilder2.Append('/');
				}
				if (this.userinfo.Length > 0)
				{
					stringBuilder2.Append(this.userinfo).Append('@');
				}
				stringBuilder2.Append(this.host);
				int defaultPort = Uri.GetDefaultPort(this.scheme);
				if (this.port != -1 && this.port != defaultPort)
				{
					stringBuilder2.Append(':').Append(this.port);
				}
				stringBuilder2.Append(this.path);
				return stringBuilder2.ToString();
			}
			default:
				return null;
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000849A File Offset: 0x0000669A
		public static int FromHex(char digit)
		{
			if ('0' <= digit && digit <= '9')
			{
				return (int)(digit - '0');
			}
			if ('a' <= digit && digit <= 'f')
			{
				return (int)(digit - 'a' + '\n');
			}
			if ('A' <= digit && digit <= 'F')
			{
				return (int)(digit - 'A' + '\n');
			}
			throw new ArgumentException("digit");
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000084DC File Offset: 0x000066DC
		public static string HexEscape(char character)
		{
			if (character > 'ÿ')
			{
				throw new ArgumentOutOfRangeException("character");
			}
			return "%" + Uri.hexUpperChars[(int)((character & 'ð') >> 4)].ToString() + Uri.hexUpperChars[(int)(character & '\u000f')].ToString();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00008538 File Offset: 0x00006738
		public static char HexUnescape(string pattern, ref int index)
		{
			if (pattern == null)
			{
				throw new ArgumentException("pattern");
			}
			if (index < 0 || index >= pattern.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int num = 0;
			int num2 = 0;
			while (index + 3 <= pattern.Length && pattern[index] == '%' && Uri.IsHexDigit(pattern[index + 1]) && Uri.IsHexDigit(pattern[index + 2]))
			{
				index++;
				int num3 = index;
				index = num3 + 1;
				int num4 = Uri.FromHex(pattern[num3]);
				num3 = index;
				index = num3 + 1;
				int num5 = Uri.FromHex(pattern[num3]);
				int num6 = (num4 << 4) + num5;
				if (num == 0)
				{
					if (num6 < 192)
					{
						return (char)num6;
					}
					if (num6 < 224)
					{
						num2 = num6 - 192;
						num = 2;
					}
					else if (num6 < 240)
					{
						num2 = num6 - 224;
						num = 3;
					}
					else if (num6 < 248)
					{
						num2 = num6 - 240;
						num = 4;
					}
					else if (num6 < 251)
					{
						num2 = num6 - 248;
						num = 5;
					}
					else if (num6 < 254)
					{
						num2 = num6 - 252;
						num = 6;
					}
					num2 <<= (num - 1) * 6;
				}
				else
				{
					num2 += num6 - 128 << (num - 1) * 6;
				}
				num--;
				if (num <= 0)
				{
					IL_154:
					return (char)num2;
				}
			}
			if (num == 0)
			{
				int num3 = index;
				index = num3 + 1;
				return pattern[num3];
			}
			goto IL_154;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000869B File Offset: 0x0000689B
		public static bool IsHexDigit(char digit)
		{
			return ('0' <= digit && digit <= '9') || ('a' <= digit && digit <= 'f') || ('A' <= digit && digit <= 'F');
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000086C2 File Offset: 0x000068C2
		public static bool IsHexEncoding(string pattern, int index)
		{
			return index + 3 <= pattern.Length && (pattern[index++] == '%' && Uri.IsHexDigit(pattern[index++])) && Uri.IsHexDigit(pattern[index]);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00008704 File Offset: 0x00006904
		public override string ToString()
		{
			if (this.cachedToString != null)
			{
				return this.cachedToString;
			}
			string str = this.query.StartsWith("?") ? ("?" + this.Unescape(this.query.Substring(1))) : this.Unescape(this.query);
			this.cachedToString = this.Unescape(this.GetLeftPart(UriPartial.Path), true) + str + this.fragment;
			return this.cachedToString;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00008783 File Offset: 0x00006983
		protected static string EscapeString(string str)
		{
			return Uri.EscapeString(str, false, true, true);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00008790 File Offset: 0x00006990
		internal static string EscapeString(string str, bool escapeReserved, bool escapeHex, bool escapeBrackets)
		{
			if (str == null)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int length = str.Length;
			for (int i = 0; i < length; i++)
			{
				if (Uri.IsHexEncoding(str, i))
				{
					stringBuilder.Append(str.Substring(i, 3));
					i += 2;
				}
				else
				{
					byte[] bytes = Encoding.UTF8.GetBytes(new char[]
					{
						str[i]
					});
					int num = bytes.Length;
					for (int j = 0; j < num; j++)
					{
						char c = (char)bytes[j];
						if (c <= ' ' || c >= '\u007f' || "<>%\"{}|\\^`".IndexOf(c) != -1 || (escapeHex && c == '#') || (escapeBrackets && (c == '[' || c == ']')) || (escapeReserved && ";/?:@&=+$,".IndexOf(c) != -1))
						{
							stringBuilder.Append(Uri.HexEscape(c));
						}
						else
						{
							stringBuilder.Append(c);
						}
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00008881 File Offset: 0x00006A81
		protected void Parse()
		{
			this.Parse(this.source);
			if (this.userEscaped)
			{
				return;
			}
			this.host = Uri.EscapeString(this.host, false, true, false);
			this.path = Uri.EscapeString(this.path);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000088BD File Offset: 0x00006ABD
		protected string Unescape(string str)
		{
			return this.Unescape(str, false);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000088C8 File Offset: 0x00006AC8
		internal string Unescape(string str, bool excludeSharp)
		{
			if (str == null)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int length = str.Length;
			for (int i = 0; i < length; i++)
			{
				char c = str[i];
				if (c == '%')
				{
					char c2 = Uri.HexUnescape(str, ref i);
					if (excludeSharp && c2 == '#')
					{
						stringBuilder.Append("%23");
					}
					else
					{
						stringBuilder.Append(c2);
					}
					i--;
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00008944 File Offset: 0x00006B44
		private void ParseAsWindowsUNC(string uriString)
		{
			this.scheme = Uri.UriSchemeFile;
			this.port = -1;
			this.fragment = string.Empty;
			this.query = string.Empty;
			this.isUnc = true;
			uriString = uriString.TrimStart(new char[]
			{
				'\\'
			});
			int num = uriString.IndexOf('\\');
			if (num > 0)
			{
				this.path = uriString.Substring(num);
				this.host = uriString.Substring(0, num);
			}
			else
			{
				this.host = uriString;
				this.path = string.Empty;
			}
			this.path = this.path.Replace("\\", "/");
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000089EC File Offset: 0x00006BEC
		private void ParseAsWindowsAbsoluteFilePath(string uriString)
		{
			if (uriString.Length > 2 && uriString[2] != '\\' && uriString[2] != '/')
			{
				throw new FormatException("Relative file path is not allowed.");
			}
			this.scheme = Uri.UriSchemeFile;
			this.host = string.Empty;
			this.port = -1;
			this.path = uriString.Replace("\\", "/");
			this.fragment = string.Empty;
			this.query = string.Empty;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00008A6C File Offset: 0x00006C6C
		private void ParseAsUnixAbsoluteFilePath(string uriString)
		{
			this.isUnixFilePath = true;
			this.scheme = Uri.UriSchemeFile;
			this.port = -1;
			this.fragment = string.Empty;
			this.query = string.Empty;
			this.host = string.Empty;
			this.path = null;
			if (uriString.StartsWith("//"))
			{
				uriString = uriString.TrimStart(new char[]
				{
					'/'
				});
				this.path = "/" + uriString;
			}
			if (this.path == null)
			{
				this.path = uriString;
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00008AFC File Offset: 0x00006CFC
		private void Parse(string uriString)
		{
			if (uriString == null)
			{
				throw new ArgumentNullException("uriString");
			}
			if (uriString.Length <= 1)
			{
				throw new FormatException();
			}
			int num = uriString.IndexOf(':');
			if (num < 0)
			{
				if (uriString[0] == '/')
				{
					this.ParseAsUnixAbsoluteFilePath(uriString);
					return;
				}
				if (uriString.StartsWith("\\\\"))
				{
					this.ParseAsWindowsUNC(uriString);
					return;
				}
				throw new FormatException("URI scheme was not recognized, nor input string is not recognized as an absolute file path.");
			}
			else if (num == 1)
			{
				if (!char.IsLetter(uriString[0]))
				{
					throw new FormatException("URI scheme must start with alphabet character.");
				}
				this.ParseAsWindowsAbsoluteFilePath(uriString);
				return;
			}
			else
			{
				this.scheme = uriString.Substring(0, num).ToLower(CultureInfo.InvariantCulture);
				if (!char.IsLetter(this.scheme[0]))
				{
					throw new FormatException("URI scheme must start with alphabet character.");
				}
				for (int i = 1; i < this.scheme.Length; i++)
				{
					if (!char.IsLetterOrDigit(this.scheme, i))
					{
						switch (this.scheme[i])
						{
						case '+':
						case '-':
						case '.':
							break;
						default:
							throw new FormatException("URI scheme must consist of one of alphabet, digits, '+', '-' or '.' character.");
						}
					}
				}
				uriString = uriString.Substring(num + 1);
				num = uriString.IndexOf('#');
				if (!this.IsUnc && num != -1)
				{
					this.fragment = uriString.Substring(num);
					uriString = uriString.Substring(0, num);
				}
				num = uriString.IndexOf('?');
				if (num != -1)
				{
					this.query = uriString.Substring(num);
					uriString = uriString.Substring(0, num);
					if (!this.userEscaped)
					{
						this.query = Uri.EscapeString(this.query);
					}
				}
				bool flag = this.scheme == Uri.UriSchemeFile && uriString.StartsWith("///");
				if (uriString.StartsWith("//"))
				{
					if (uriString.StartsWith("////"))
					{
						flag = false;
					}
					uriString = uriString.TrimStart(new char[]
					{
						'/'
					});
					if (uriString.Length > 1 && uriString[1] == ':')
					{
						flag = false;
					}
				}
				else if (!Uri.IsPredefinedScheme(this.scheme))
				{
					this.path = uriString;
					this.isOpaquePart = true;
					return;
				}
				num = uriString.IndexOfAny(new char[]
				{
					'/',
					'\\'
				});
				if (flag)
				{
					num = -1;
				}
				if (num == -1)
				{
					if (this.scheme != Uri.UriSchemeMailto && this.scheme != Uri.UriSchemeNews && this.scheme != Uri.UriSchemeFile)
					{
						this.path = "/";
					}
				}
				else
				{
					this.path = uriString.Substring(num);
					uriString = uriString.Substring(0, num);
				}
				num = uriString.IndexOf("@");
				if (flag)
				{
					num = -1;
				}
				if (num != -1)
				{
					this.userinfo = uriString.Substring(0, num);
					uriString = uriString.Remove(0, num + 1);
				}
				this.port = -1;
				num = uriString.LastIndexOf(":");
				if (flag)
				{
					num = -1;
				}
				if (num == 1 && this.scheme == Uri.UriSchemeFile && char.IsLetter(uriString[0]))
				{
					num = -1;
				}
				if (num != -1 && num != uriString.Length - 1)
				{
					string text = uriString.Remove(0, num + 1);
					if (text.Length > 1 && text[text.Length - 1] != ']')
					{
						try
						{
							this.port = (int)uint.Parse(text, CultureInfo.InvariantCulture);
							uriString = uriString.Substring(0, num);
						}
						catch (Exception)
						{
							throw new FormatException("Invalid URI: invalid port number");
						}
					}
				}
				if (this.port == -1)
				{
					this.port = Uri.GetDefaultPort(this.scheme);
				}
				this.host = uriString;
				if (flag)
				{
					this.path = "/" + uriString;
					this.host = string.Empty;
				}
				else if (this.host.Length == 2 && this.host[1] == ':')
				{
					this.path = this.host + this.path;
					this.host = string.Empty;
				}
				else if (this.isUnixFilePath)
				{
					uriString = "//" + uriString;
					this.host = string.Empty;
				}
				else
				{
					if (this.host.Length == 0)
					{
						throw new FormatException("Invalid URI: The hostname could not be parsed");
					}
					if (this.scheme == Uri.UriSchemeFile)
					{
						this.isUnc = true;
					}
				}
				if (this.scheme != Uri.UriSchemeMailto && this.scheme != Uri.UriSchemeNews && this.scheme != Uri.UriSchemeFile && this.reduce)
				{
					this.path = Uri.Reduce(this.path);
				}
				return;
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00008F94 File Offset: 0x00007194
		private static string Reduce(string path)
		{
			path = path.Replace('\\', '/');
			string[] array = path.Split('/', StringSplitOptions.None);
			List<string> list = new List<string>();
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				string text = array[i];
				if (text.Length != 0 && !(text == "."))
				{
					if (text == "..")
					{
						if (list.Count == 0)
						{
							if (i != 1)
							{
								throw new Exception("Invalid path.");
							}
						}
						else
						{
							list.RemoveAt(list.Count - 1);
						}
					}
					else
					{
						list.Add(text);
					}
				}
			}
			if (list.Count == 0)
			{
				return "/";
			}
			list.Insert(0, string.Empty);
			string text2 = string.Join("/", list.ToArray());
			if (path.EndsWith("/"))
			{
				text2 += "/";
			}
			return text2;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00009074 File Offset: 0x00007274
		internal static string GetSchemeDelimiter(string scheme)
		{
			for (int i = 0; i < Uri.schemes.Length; i++)
			{
				if (Uri.schemes[i].scheme == scheme)
				{
					return Uri.schemes[i].delimiter;
				}
			}
			return Uri.SchemeDelimiter;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000090C4 File Offset: 0x000072C4
		internal static int GetDefaultPort(string scheme)
		{
			for (int i = 0; i < Uri.schemes.Length; i++)
			{
				if (Uri.schemes[i].scheme == scheme)
				{
					return Uri.schemes[i].defaultPort;
				}
			}
			return -1;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000910D File Offset: 0x0000730D
		private string GetOpaqueWiseSchemeDelimiter()
		{
			if (this.isOpaquePart)
			{
				return ":";
			}
			return Uri.GetSchemeDelimiter(this.scheme);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00009128 File Offset: 0x00007328
		private static bool IsPredefinedScheme(string scheme)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(scheme);
			if (num <= 2867484483U)
			{
				if (num <= 1271381062U)
				{
					if (num != 227981521U)
					{
						if (num != 1271381062U)
						{
							return false;
						}
						if (!(scheme == "news"))
						{
							return false;
						}
					}
					else if (!(scheme == "nntp"))
					{
						return false;
					}
				}
				else if (num != 1315902419U)
				{
					if (num != 2867484483U)
					{
						return false;
					}
					if (!(scheme == "file"))
					{
						return false;
					}
				}
				else if (!(scheme == "mailto"))
				{
					return false;
				}
			}
			else if (num <= 3378792613U)
			{
				if (num != 3101544485U)
				{
					if (num != 3378792613U)
					{
						return false;
					}
					if (!(scheme == "http"))
					{
						return false;
					}
				}
				else if (!(scheme == "ftp"))
				{
					return false;
				}
			}
			else if (num != 3500961320U)
			{
				if (num != 3739134178U)
				{
					return false;
				}
				if (!(scheme == "https"))
				{
					return false;
				}
			}
			else if (!(scheme == "gopher"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x04000148 RID: 328
		private bool isUnixFilePath;

		// Token: 0x04000149 RID: 329
		private string source;

		// Token: 0x0400014A RID: 330
		private string scheme = string.Empty;

		// Token: 0x0400014B RID: 331
		private string host = string.Empty;

		// Token: 0x0400014C RID: 332
		private int port = -1;

		// Token: 0x0400014D RID: 333
		private string path = string.Empty;

		// Token: 0x0400014E RID: 334
		private string query = string.Empty;

		// Token: 0x0400014F RID: 335
		private string fragment = string.Empty;

		// Token: 0x04000150 RID: 336
		private string userinfo = string.Empty;

		// Token: 0x04000151 RID: 337
		private bool isUnc;

		// Token: 0x04000152 RID: 338
		private bool isOpaquePart;

		// Token: 0x04000153 RID: 339
		private bool userEscaped;

		// Token: 0x04000154 RID: 340
		private string cachedToString;

		// Token: 0x04000155 RID: 341
		private string cachedLocalPath;

		// Token: 0x04000156 RID: 342
		private int cachedHashCode;

		// Token: 0x04000157 RID: 343
		private bool reduce = true;

		// Token: 0x04000158 RID: 344
		private static readonly string hexUpperChars = "0123456789ABCDEF";

		// Token: 0x04000159 RID: 345
		public static readonly string SchemeDelimiter = "://";

		// Token: 0x0400015A RID: 346
		public static readonly string UriSchemeFile = "file";

		// Token: 0x0400015B RID: 347
		public static readonly string UriSchemeFtp = "ftp";

		// Token: 0x0400015C RID: 348
		public static readonly string UriSchemeGopher = "gopher";

		// Token: 0x0400015D RID: 349
		public static readonly string UriSchemeHttp = "http";

		// Token: 0x0400015E RID: 350
		public static readonly string UriSchemeHttps = "https";

		// Token: 0x0400015F RID: 351
		public static readonly string UriSchemeMailto = "mailto";

		// Token: 0x04000160 RID: 352
		public static readonly string UriSchemeNews = "news";

		// Token: 0x04000161 RID: 353
		public static readonly string UriSchemeNntp = "nntp";

		// Token: 0x04000162 RID: 354
		private static Uri.UriScheme[] schemes = new Uri.UriScheme[]
		{
			new Uri.UriScheme(Uri.UriSchemeHttp, Uri.SchemeDelimiter, 80),
			new Uri.UriScheme(Uri.UriSchemeHttps, Uri.SchemeDelimiter, 443),
			new Uri.UriScheme(Uri.UriSchemeFtp, Uri.SchemeDelimiter, 21),
			new Uri.UriScheme(Uri.UriSchemeFile, Uri.SchemeDelimiter, -1),
			new Uri.UriScheme(Uri.UriSchemeMailto, ":", 25),
			new Uri.UriScheme(Uri.UriSchemeNews, ":", -1),
			new Uri.UriScheme(Uri.UriSchemeNntp, Uri.SchemeDelimiter, 119),
			new Uri.UriScheme(Uri.UriSchemeGopher, Uri.SchemeDelimiter, 70)
		};

		// Token: 0x02000047 RID: 71
		private struct UriScheme
		{
			// Token: 0x0600013E RID: 318 RVA: 0x00009365 File Offset: 0x00007565
			public UriScheme(string s, string d, int p)
			{
				this.scheme = s;
				this.delimiter = d;
				this.defaultPort = p;
			}

			// Token: 0x04000163 RID: 355
			public string scheme;

			// Token: 0x04000164 RID: 356
			public string delimiter;

			// Token: 0x04000165 RID: 357
			public int defaultPort;
		}
	}
}
