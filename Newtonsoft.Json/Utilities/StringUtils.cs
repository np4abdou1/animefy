using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000EF RID: 239
	[NullableContext(1)]
	[Nullable(0)]
	internal static class StringUtils
	{
		// Token: 0x06000702 RID: 1794 RVA: 0x000241D7 File Offset: 0x000223D7
		[NullableContext(2)]
		public static bool IsNullOrEmpty([NotNullWhen(false)] string value)
		{
			return string.IsNullOrEmpty(value);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x000241DF File Offset: 0x000223DF
		public static string FormatWith(this string format, IFormatProvider provider, [Nullable(2)] object arg0)
		{
			return format.FormatWith(provider, new object[]
			{
				arg0
			});
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x000241F2 File Offset: 0x000223F2
		public static string FormatWith(this string format, IFormatProvider provider, [Nullable(2)] object arg0, [Nullable(2)] object arg1)
		{
			return format.FormatWith(provider, new object[]
			{
				arg0,
				arg1
			});
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00024209 File Offset: 0x00022409
		public static string FormatWith(this string format, IFormatProvider provider, [Nullable(2)] object arg0, [Nullable(2)] object arg1, [Nullable(2)] object arg2)
		{
			return format.FormatWith(provider, new object[]
			{
				arg0,
				arg1,
				arg2
			});
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00024225 File Offset: 0x00022425
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string FormatWith([Nullable(1)] this string format, [Nullable(1)] IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
		{
			return format.FormatWith(provider, new object[]
			{
				arg0,
				arg1,
				arg2,
				arg3
			});
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00024246 File Offset: 0x00022446
		private static string FormatWith(this string format, IFormatProvider provider, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			ValidationUtils.ArgumentNotNull(format, "format");
			return string.Format(provider, format, args);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0002425C File Offset: 0x0002245C
		public static bool IsWhiteSpace(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (s.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < s.Length; i++)
			{
				if (!char.IsWhiteSpace(s[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000242A3 File Offset: 0x000224A3
		public static StringWriter CreateStringWriter(int capacity)
		{
			return new StringWriter(new StringBuilder(capacity), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000242B8 File Offset: 0x000224B8
		public static void ToCharAsUnicode(char c, char[] buffer)
		{
			buffer[0] = '\\';
			buffer[1] = 'u';
			buffer[2] = MathUtils.IntToHex((int)(c >> 12 & '\u000f'));
			buffer[3] = MathUtils.IntToHex((int)(c >> 8 & '\u000f'));
			buffer[4] = MathUtils.IntToHex((int)(c >> 4 & '\u000f'));
			buffer[5] = MathUtils.IntToHex((int)(c & '\u000f'));
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00024308 File Offset: 0x00022508
		[return: Nullable(2)]
		public static TSource ForgivingCaseSensitiveFind<[Nullable(2)] TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (valueSelector == null)
			{
				throw new ArgumentNullException("valueSelector");
			}
			IEnumerable<TSource> source2 = from s in source
			where string.Equals(valueSelector(s), testValue, StringComparison.OrdinalIgnoreCase)
			select s;
			if (source2.Count<TSource>() <= 1)
			{
				return source2.SingleOrDefault<TSource>();
			}
			return (from s in source
			where string.Equals(valueSelector(s), testValue, StringComparison.Ordinal)
			select s).SingleOrDefault<TSource>();
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00024384 File Offset: 0x00022584
		public static string ToCamelCase(string s)
		{
			if (StringUtils.IsNullOrEmpty(s) || !char.IsUpper(s[0]))
			{
				return s;
			}
			char[] array = s.ToCharArray();
			int num = 0;
			while (num < array.Length && (num != 1 || char.IsUpper(array[num])))
			{
				bool flag = num + 1 < array.Length;
				if (num > 0 && flag && !char.IsUpper(array[num + 1]))
				{
					if (char.IsSeparator(array[num + 1]))
					{
						array[num] = StringUtils.ToLower(array[num]);
						break;
					}
					break;
				}
				else
				{
					array[num] = StringUtils.ToLower(array[num]);
					num++;
				}
			}
			return new string(array);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00024413 File Offset: 0x00022613
		private static char ToLower(char c)
		{
			c = char.ToLower(c, CultureInfo.InvariantCulture);
			return c;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00024423 File Offset: 0x00022623
		public static string ToSnakeCase(string s)
		{
			return StringUtils.ToSeparatedCase(s, '_');
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0002442D File Offset: 0x0002262D
		public static string ToKebabCase(string s)
		{
			return StringUtils.ToSeparatedCase(s, '-');
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00024438 File Offset: 0x00022638
		private static string ToSeparatedCase(string s, char separator)
		{
			if (StringUtils.IsNullOrEmpty(s))
			{
				return s;
			}
			StringBuilder stringBuilder = new StringBuilder();
			StringUtils.SeparatedCaseState separatedCaseState = StringUtils.SeparatedCaseState.Start;
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == ' ')
				{
					if (separatedCaseState != StringUtils.SeparatedCaseState.Start)
					{
						separatedCaseState = StringUtils.SeparatedCaseState.NewWord;
					}
				}
				else if (char.IsUpper(s[i]))
				{
					switch (separatedCaseState)
					{
					case StringUtils.SeparatedCaseState.Lower:
					case StringUtils.SeparatedCaseState.NewWord:
						stringBuilder.Append(separator);
						break;
					case StringUtils.SeparatedCaseState.Upper:
					{
						bool flag = i + 1 < s.Length;
						if (i > 0 && flag)
						{
							char c = s[i + 1];
							if (!char.IsUpper(c) && c != separator)
							{
								stringBuilder.Append(separator);
							}
						}
						break;
					}
					}
					char value = char.ToLower(s[i], CultureInfo.InvariantCulture);
					stringBuilder.Append(value);
					separatedCaseState = StringUtils.SeparatedCaseState.Upper;
				}
				else if (s[i] == separator)
				{
					stringBuilder.Append(separator);
					separatedCaseState = StringUtils.SeparatedCaseState.Start;
				}
				else
				{
					if (separatedCaseState == StringUtils.SeparatedCaseState.NewWord)
					{
						stringBuilder.Append(separator);
					}
					stringBuilder.Append(s[i]);
					separatedCaseState = StringUtils.SeparatedCaseState.Lower;
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00024541 File Offset: 0x00022741
		public static bool IsHighSurrogate(char c)
		{
			return char.IsHighSurrogate(c);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00024549 File Offset: 0x00022749
		public static bool IsLowSurrogate(char c)
		{
			return char.IsLowSurrogate(c);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00024551 File Offset: 0x00022751
		public static int IndexOf(string s, char c)
		{
			return s.IndexOf(c);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0002455A File Offset: 0x0002275A
		public static string Replace(string s, string oldValue, string newValue)
		{
			return s.Replace(oldValue, newValue);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00024564 File Offset: 0x00022764
		public static bool StartsWith(this string source, char value)
		{
			return source.Length > 0 && source[0] == value;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0002457B File Offset: 0x0002277B
		public static bool EndsWith(this string source, char value)
		{
			return source.Length > 0 && source[source.Length - 1] == value;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0002459C File Offset: 0x0002279C
		public static string Trim(this string s, int start, int length)
		{
			if (s == null)
			{
				throw new ArgumentNullException();
			}
			if (start < 0)
			{
				throw new ArgumentOutOfRangeException("start");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			int num = start + length - 1;
			if (num >= s.Length)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			while (start < num)
			{
				if (!char.IsWhiteSpace(s[start]))
				{
					IL_6C:
					while (num >= start && char.IsWhiteSpace(s[num]))
					{
						num--;
					}
					return s.Substring(start, num - start + 1);
				}
				start++;
			}
			goto IL_6C;
		}

		// Token: 0x040004C8 RID: 1224
		public const string CarriageReturnLineFeed = "\r\n";

		// Token: 0x040004C9 RID: 1225
		public const string Empty = "";

		// Token: 0x040004CA RID: 1226
		public const char CarriageReturn = '\r';

		// Token: 0x040004CB RID: 1227
		public const char LineFeed = '\n';

		// Token: 0x040004CC RID: 1228
		public const char Tab = '\t';

		// Token: 0x020000F0 RID: 240
		[NullableContext(0)]
		private enum SeparatedCaseState
		{
			// Token: 0x040004CE RID: 1230
			Start,
			// Token: 0x040004CF RID: 1231
			Lower,
			// Token: 0x040004D0 RID: 1232
			Upper,
			// Token: 0x040004D1 RID: 1233
			NewWord
		}
	}
}
