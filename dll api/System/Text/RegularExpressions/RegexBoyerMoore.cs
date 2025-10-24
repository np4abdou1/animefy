﻿using System;
using System.Globalization;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000A5 RID: 165
	internal sealed class RegexBoyerMoore
	{
		// Token: 0x06000440 RID: 1088 RVA: 0x000170AC File Offset: 0x000152AC
		public RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture)
		{
			if (caseInsensitive)
			{
				StringBuilder stringBuilder = StringBuilderCache.Acquire(pattern.Length);
				for (int i = 0; i < pattern.Length; i++)
				{
					stringBuilder.Append(culture.TextInfo.ToLower(pattern[i]));
				}
				pattern = StringBuilderCache.GetStringAndRelease(stringBuilder);
			}
			this.Pattern = pattern;
			this.RightToLeft = rightToLeft;
			this.CaseInsensitive = caseInsensitive;
			this._culture = culture;
			int num;
			int num2;
			int num3;
			if (!rightToLeft)
			{
				num = -1;
				num2 = pattern.Length - 1;
				num3 = 1;
			}
			else
			{
				num = pattern.Length;
				num2 = 0;
				num3 = -1;
			}
			this.Positive = new int[pattern.Length];
			int num4 = num2;
			char c = pattern[num4];
			this.Positive[num4] = num3;
			num4 -= num3;
			while (num4 != num)
			{
				if (pattern[num4] != c)
				{
					num4 -= num3;
				}
				else
				{
					int num5 = num2;
					int num6 = num4;
					while (num6 != num && pattern[num5] == pattern[num6])
					{
						num6 -= num3;
						num5 -= num3;
					}
					if (this.Positive[num5] == 0)
					{
						this.Positive[num5] = num5 - num6;
					}
					num4 -= num3;
				}
			}
			for (int num5 = num2 - num3; num5 != num; num5 -= num3)
			{
				if (this.Positive[num5] == 0)
				{
					this.Positive[num5] = num3;
				}
			}
			this.NegativeASCII = new int[128];
			for (int j = 0; j < 128; j++)
			{
				this.NegativeASCII[j] = num2 - num;
			}
			this.LowASCII = 127;
			this.HighASCII = 0;
			for (num4 = num2; num4 != num; num4 -= num3)
			{
				c = pattern[num4];
				if (c < '\u0080')
				{
					if (this.LowASCII > (int)c)
					{
						this.LowASCII = (int)c;
					}
					if (this.HighASCII < (int)c)
					{
						this.HighASCII = (int)c;
					}
					if (this.NegativeASCII[(int)c] == num2 - num)
					{
						this.NegativeASCII[(int)c] = num2 - num4;
					}
				}
				else
				{
					int num7 = (int)(c >> 8);
					int num8 = (int)(c & 'ÿ');
					if (this.NegativeUnicode == null)
					{
						this.NegativeUnicode = new int[256][];
					}
					if (this.NegativeUnicode[num7] == null)
					{
						int[] array = new int[256];
						for (int k = 0; k < array.Length; k++)
						{
							array[k] = num2 - num;
						}
						if (num7 == 0)
						{
							Array.Copy(this.NegativeASCII, 0, array, 0, 128);
							this.NegativeASCII = array;
						}
						this.NegativeUnicode[num7] = array;
					}
					if (this.NegativeUnicode[num7][num8] == num2 - num)
					{
						this.NegativeUnicode[num7][num8] = num2 - num4;
					}
				}
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00017344 File Offset: 0x00015544
		private bool MatchPattern(string text, int index)
		{
			if (!this.CaseInsensitive)
			{
				return string.CompareOrdinal(this.Pattern, 0, text, index, this.Pattern.Length) == 0;
			}
			if (text.Length - index < this.Pattern.Length)
			{
				return false;
			}
			TextInfo textInfo = this._culture.TextInfo;
			for (int i = 0; i < this.Pattern.Length; i++)
			{
				if (textInfo.ToLower(text[index + i]) != this.Pattern[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000173D0 File Offset: 0x000155D0
		public bool IsMatch(string text, int index, int beglimit, int endlimit)
		{
			if (!this.RightToLeft)
			{
				return index >= beglimit && endlimit - index >= this.Pattern.Length && this.MatchPattern(text, index);
			}
			return index <= endlimit && index - beglimit >= this.Pattern.Length && this.MatchPattern(text, index - this.Pattern.Length);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00017430 File Offset: 0x00015630
		public int Scan(string text, int index, int beglimit, int endlimit)
		{
			int num;
			int num2;
			int num3;
			int num4;
			int num5;
			if (!this.RightToLeft)
			{
				num = this.Pattern.Length;
				num2 = this.Pattern.Length - 1;
				num3 = 0;
				num4 = index + num - 1;
				num5 = 1;
			}
			else
			{
				num = -this.Pattern.Length;
				num2 = 0;
				num3 = -num - 1;
				num4 = index + num;
				num5 = -1;
			}
			char c = this.Pattern[num2];
			IL_58:
			while (num4 < endlimit && num4 >= beglimit)
			{
				char c2 = text[num4];
				if (this.CaseInsensitive)
				{
					c2 = this._culture.TextInfo.ToLower(c2);
				}
				if (c2 != c)
				{
					int num6;
					int[] array;
					if (c2 < '\u0080')
					{
						num6 = this.NegativeASCII[(int)c2];
					}
					else if (this.NegativeUnicode != null && (array = this.NegativeUnicode[(int)(c2 >> 8)]) != null)
					{
						num6 = array[(int)(c2 & 'ÿ')];
					}
					else
					{
						num6 = num;
					}
					num4 += num6;
				}
				else
				{
					int num7 = num4;
					int num8 = num2;
					while (num8 != num3)
					{
						num8 -= num5;
						num7 -= num5;
						c2 = text[num7];
						if (this.CaseInsensitive)
						{
							c2 = this._culture.TextInfo.ToLower(c2);
						}
						if (c2 != this.Pattern[num8])
						{
							int num6 = this.Positive[num8];
							if ((c2 & 'ﾀ') == '\0')
							{
								num7 = num8 - num2 + this.NegativeASCII[(int)c2];
							}
							else
							{
								int[] array;
								if (this.NegativeUnicode == null || (array = this.NegativeUnicode[(int)(c2 >> 8)]) == null)
								{
									num4 += num6;
									goto IL_58;
								}
								num7 = num8 - num2 + array[(int)(c2 & 'ÿ')];
							}
							if (this.RightToLeft ? (num7 < num6) : (num7 > num6))
							{
								num6 = num7;
							}
							num4 += num6;
							goto IL_58;
						}
					}
					if (!this.RightToLeft)
					{
						return num7;
					}
					return num7 + 1;
				}
			}
			return -1;
		}

		// Token: 0x040002D6 RID: 726
		public readonly int[] Positive;

		// Token: 0x040002D7 RID: 727
		public readonly int[] NegativeASCII;

		// Token: 0x040002D8 RID: 728
		public readonly int[][] NegativeUnicode;

		// Token: 0x040002D9 RID: 729
		public readonly string Pattern;

		// Token: 0x040002DA RID: 730
		public readonly int LowASCII;

		// Token: 0x040002DB RID: 731
		public readonly int HighASCII;

		// Token: 0x040002DC RID: 732
		public readonly bool RightToLeft;

		// Token: 0x040002DD RID: 733
		public readonly bool CaseInsensitive;

		// Token: 0x040002DE RID: 734
		private readonly CultureInfo _culture;
	}
}
