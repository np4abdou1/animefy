using System;

namespace System.Net
{
	// Token: 0x0200010D RID: 269
	internal static class HttpValidationHelpers
	{
		// Token: 0x060007A7 RID: 1959 RVA: 0x0002B9D4 File Offset: 0x00029BD4
		public static string CheckBadHeaderValueChars(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return string.Empty;
			}
			value = value.Trim(HttpValidationHelpers.s_httpTrimCharacters);
			int num = 0;
			for (int i = 0; i < value.Length; i++)
			{
				char c = 'ÿ' & value[i];
				switch (num)
				{
				case 0:
					if (c == '\r')
					{
						num = 1;
					}
					else if (c == '\n')
					{
						num = 2;
					}
					else if (c == '\u007f' || (c < ' ' && c != '\t'))
					{
						throw new ArgumentException("Specified value has invalid Control characters.", "value");
					}
					break;
				case 1:
					if (c != '\n')
					{
						throw new ArgumentException("Specified value has invalid CRLF characters.", "value");
					}
					num = 2;
					break;
				case 2:
					if (c != ' ' && c != '\t')
					{
						throw new ArgumentException("Specified value has invalid Control characters.", "value");
					}
					num = 0;
					break;
				}
			}
			if (num != 0)
			{
				throw new ArgumentException("Specified value has invalid CRLF characters.", "value");
			}
			return value;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0002BAB4 File Offset: 0x00029CB4
		public static bool IsInvalidMethodOrHeaderString(string stringValue)
		{
			foreach (char c in stringValue)
			{
				if (c <= '/')
				{
					if (c <= ' ')
					{
						switch (c)
						{
						case '\t':
						case '\n':
						case '\r':
							return true;
						case '\v':
						case '\f':
							break;
						default:
							if (c == ' ')
							{
								return true;
							}
							break;
						}
					}
					else
					{
						if (c == '"')
						{
							return true;
						}
						switch (c)
						{
						case '\'':
						case '(':
						case ')':
						case ',':
						case '/':
							return true;
						}
					}
				}
				else if (c <= ']')
				{
					switch (c)
					{
					case ':':
					case ';':
					case '<':
					case '=':
					case '>':
					case '?':
					case '@':
						return true;
					default:
						switch (c)
						{
						case '[':
						case '\\':
						case ']':
							return true;
						}
						break;
					}
				}
				else if (c == '{' || c == '}')
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0400051E RID: 1310
		private static readonly char[] s_httpTrimCharacters = new char[]
		{
			'\t',
			'\n',
			'\v',
			'\f',
			'\r',
			' '
		};
	}
}
