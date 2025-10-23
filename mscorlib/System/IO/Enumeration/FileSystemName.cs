﻿using System;
using System.Text;

namespace System.IO.Enumeration
{
	// Token: 0x02000575 RID: 1397
	public static class FileSystemName
	{
		// Token: 0x060029AE RID: 10670 RVA: 0x000A6244 File Offset: 0x000A4444
		public unsafe static string TranslateWin32Expression(string expression)
		{
			if (string.IsNullOrEmpty(expression) || expression == "*" || expression == "*.*")
			{
				return "*";
			}
			bool flag = false;
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)64], 32);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			int length = expression.Length;
			for (int i = 0; i < length; i++)
			{
				char c = expression[i];
				if (c != '.')
				{
					if (c != '?')
					{
						valueStringBuilder.Append(c);
					}
					else
					{
						flag = true;
						valueStringBuilder.Append('>');
					}
				}
				else
				{
					flag = true;
					if (i >= 1 && i == length - 1 && expression[i - 1] == '*')
					{
						*valueStringBuilder[valueStringBuilder.Length - 1] = '<';
					}
					else if (i < length - 1 && (expression[i + 1] == '?' || expression[i + 1] == '*'))
					{
						valueStringBuilder.Append('"');
					}
					else
					{
						valueStringBuilder.Append('.');
					}
				}
			}
			if (!flag)
			{
				return expression;
			}
			return valueStringBuilder.ToString();
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x000A6357 File Offset: 0x000A4557
		public static bool MatchesWin32Expression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = true)
		{
			return FileSystemName.MatchPattern(expression, name, ignoreCase, true);
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x000A6362 File Offset: 0x000A4562
		public static bool MatchesSimpleExpression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = true)
		{
			return FileSystemName.MatchPattern(expression, name, ignoreCase, false);
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x000A6370 File Offset: 0x000A4570
		private unsafe static bool MatchPattern(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase, bool useExtendedWildcards)
		{
			if (expression.Length == 0 || name.Length == 0)
			{
				return false;
			}
			if (*expression[0] == 42)
			{
				if (expression.Length == 1)
				{
					return true;
				}
				ReadOnlySpan<char> readOnlySpan = expression.Slice(1);
				if (readOnlySpan.IndexOfAny(useExtendedWildcards ? FileSystemName.s_wildcardChars : FileSystemName.s_simpleWildcardChars) == -1)
				{
					return name.Length >= readOnlySpan.Length && name.EndsWith(readOnlySpan, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
				}
			}
			int num = 0;
			int num2 = 1;
			char c = '\0';
			Span<int> span = default(Span<int>);
			Span<int> span2 = new Span<int>(stackalloc byte[(UIntPtr)64], 16);
			Span<int> span3 = new Span<int>(stackalloc byte[(UIntPtr)64], 16);
			*span3[0] = 0;
			int num3 = expression.Length * 2;
			bool flag = false;
			int num5;
			while (!flag)
			{
				if (num < name.Length)
				{
					c = (char)(*name[num++]);
				}
				else
				{
					if (*span3[num2 - 1] == num3)
					{
						break;
					}
					flag = true;
				}
				int i = 0;
				int num4 = 0;
				int j = 0;
				while (i < num2)
				{
					int k = (*span3[i++] + 1) / 2;
					while (k < expression.Length)
					{
						num5 = k * 2;
						char c2 = (char)(*expression[k]);
						if (num4 >= span2.Length - 2)
						{
							int num6 = span2.Length * 2;
							span = new int[num6];
							span2.CopyTo(span);
							span2 = span;
							span = new int[num6];
							span3.CopyTo(span);
							span3 = span;
						}
						if (c2 == '*')
						{
							goto IL_2B7;
						}
						if (useExtendedWildcards && c2 == '<')
						{
							bool flag2 = false;
							if (!flag && c == '.')
							{
								for (int l = num; l < name.Length; l++)
								{
									if (*name[l] == 46)
									{
										flag2 = true;
										break;
									}
								}
							}
							if (flag || c != '.' || flag2)
							{
								goto IL_2B7;
							}
							goto IL_2C6;
						}
						else
						{
							num5 += 2;
							if (useExtendedWildcards && c2 == '>')
							{
								if (!flag && c != '.')
								{
									*span2[num4++] = num5;
									break;
								}
							}
							else if (useExtendedWildcards && c2 == '"')
							{
								if (!flag)
								{
									if (c == '.')
									{
										*span2[num4++] = num5;
										break;
									}
									break;
								}
							}
							else
							{
								if (c2 == '\\')
								{
									if (++k == expression.Length)
									{
										*span2[num4++] = num3;
										break;
									}
									num5 = k * 2 + 2;
									c2 = (char)(*expression[k]);
								}
								if (flag)
								{
									break;
								}
								if (c2 == '?')
								{
									*span2[num4++] = num5;
									break;
								}
								if (ignoreCase ? (char.ToUpperInvariant(c2) == char.ToUpperInvariant(c)) : (c2 == c))
								{
									*span2[num4++] = num5;
									break;
								}
								break;
							}
						}
						IL_2D7:
						if (++k == expression.Length)
						{
							*span2[num4++] = num3;
							continue;
						}
						continue;
						IL_2C6:
						*span2[num4++] = num5 + 1;
						goto IL_2D7;
						IL_2B7:
						*span2[num4++] = num5;
						goto IL_2C6;
					}
					if (i < num2 && j < num4)
					{
						while (j < num4)
						{
							int length = span3.Length;
							while (i < length && *span3[i] < *span2[j])
							{
								i++;
							}
							j++;
						}
					}
				}
				if (num4 == 0)
				{
					return false;
				}
				span = span3;
				span3 = span2;
				span2 = span;
				num2 = num4;
			}
			num5 = *span3[num2 - 1];
			return num5 == num3;
		}

		// Token: 0x040015BC RID: 5564
		private static readonly char[] s_wildcardChars = new char[]
		{
			'"',
			'<',
			'>',
			'*',
			'?'
		};

		// Token: 0x040015BD RID: 5565
		private static readonly char[] s_simpleWildcardChars = new char[]
		{
			'*',
			'?'
		};
	}
}
