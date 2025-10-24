using System;
using System.Collections.Generic;
using System.Text;

namespace System.Globalization
{
	// Token: 0x02000581 RID: 1409
	internal class DateTimeFormatInfoScanner
	{
		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06002A65 RID: 10853 RVA: 0x000A9B64 File Offset: 0x000A7D64
		private static Dictionary<string, string> KnownWords
		{
			get
			{
				if (DateTimeFormatInfoScanner.s_knownWords == null)
				{
					DateTimeFormatInfoScanner.s_knownWords = new Dictionary<string, string>
					{
						{
							"/",
							string.Empty
						},
						{
							"-",
							string.Empty
						},
						{
							".",
							string.Empty
						},
						{
							"年",
							string.Empty
						},
						{
							"月",
							string.Empty
						},
						{
							"日",
							string.Empty
						},
						{
							"년",
							string.Empty
						},
						{
							"월",
							string.Empty
						},
						{
							"일",
							string.Empty
						},
						{
							"시",
							string.Empty
						},
						{
							"분",
							string.Empty
						},
						{
							"초",
							string.Empty
						},
						{
							"時",
							string.Empty
						},
						{
							"时",
							string.Empty
						},
						{
							"分",
							string.Empty
						},
						{
							"秒",
							string.Empty
						}
					};
				}
				return DateTimeFormatInfoScanner.s_knownWords;
			}
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x000A9C90 File Offset: 0x000A7E90
		internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex)
		{
			while (currentIndex < pattern.Length)
			{
				char c = pattern[currentIndex];
				if (c == '\\')
				{
					currentIndex++;
					if (currentIndex >= pattern.Length)
					{
						break;
					}
					c = pattern[currentIndex];
					if (c == '\'')
					{
						continue;
					}
				}
				if (char.IsLetter(c) || c == '\'' || c == '.')
				{
					break;
				}
				currentIndex++;
			}
			return currentIndex;
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x000A9CE8 File Offset: 0x000A7EE8
		internal void AddDateWordOrPostfix(string formatPostfix, string str)
		{
			if (str.Length > 0)
			{
				if (str.Equals("."))
				{
					this.AddIgnorableSymbols(".");
					return;
				}
				string text;
				if (!DateTimeFormatInfoScanner.KnownWords.TryGetValue(str, out text))
				{
					if (this.m_dateWords == null)
					{
						this.m_dateWords = new List<string>();
					}
					if (formatPostfix == "MMMM")
					{
						string item = "" + str;
						if (!this.m_dateWords.Contains(item))
						{
							this.m_dateWords.Add(item);
							return;
						}
					}
					else
					{
						if (!this.m_dateWords.Contains(str))
						{
							this.m_dateWords.Add(str);
						}
						if (str[str.Length - 1] == '.')
						{
							string item2 = str.Substring(0, str.Length - 1);
							if (!this.m_dateWords.Contains(item2))
							{
								this.m_dateWords.Add(item2);
							}
						}
					}
				}
			}
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x000A9DCC File Offset: 0x000A7FCC
		internal int AddDateWords(string pattern, int index, string formatPostfix)
		{
			int num = DateTimeFormatInfoScanner.SkipWhiteSpacesAndNonLetter(pattern, index);
			if (num != index && formatPostfix != null)
			{
				formatPostfix = null;
			}
			index = num;
			StringBuilder stringBuilder = new StringBuilder();
			while (index < pattern.Length)
			{
				char c = pattern[index];
				if (c == '\'')
				{
					this.AddDateWordOrPostfix(formatPostfix, stringBuilder.ToString());
					index++;
					break;
				}
				if (c == '\\')
				{
					index++;
					if (index < pattern.Length)
					{
						stringBuilder.Append(pattern[index]);
						index++;
					}
				}
				else if (char.IsWhiteSpace(c))
				{
					this.AddDateWordOrPostfix(formatPostfix, stringBuilder.ToString());
					if (formatPostfix != null)
					{
						formatPostfix = null;
					}
					stringBuilder.Length = 0;
					index++;
				}
				else
				{
					stringBuilder.Append(c);
					index++;
				}
			}
			return index;
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x000A9E80 File Offset: 0x000A8080
		internal static int ScanRepeatChar(string pattern, char ch, int index, out int count)
		{
			count = 1;
			while (++index < pattern.Length && pattern[index] == ch)
			{
				count++;
			}
			return index;
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x000A9EA8 File Offset: 0x000A80A8
		internal void AddIgnorableSymbols(string text)
		{
			if (this.m_dateWords == null)
			{
				this.m_dateWords = new List<string>();
			}
			string item = "" + text;
			if (!this.m_dateWords.Contains(item))
			{
				this.m_dateWords.Add(item);
			}
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x000A9EF0 File Offset: 0x000A80F0
		internal void ScanDateWord(string pattern)
		{
			this._ymdFlags = DateTimeFormatInfoScanner.FoundDatePattern.None;
			for (int i = 0; i < pattern.Length; i++)
			{
				char c = pattern[i];
				if (c <= 'M')
				{
					if (c == '\'')
					{
						i = this.AddDateWords(pattern, i + 1, null);
						continue;
					}
					if (c == '.')
					{
						if (this._ymdFlags == DateTimeFormatInfoScanner.FoundDatePattern.FoundYMDPatternFlag)
						{
							this.AddIgnorableSymbols(".");
							this._ymdFlags = DateTimeFormatInfoScanner.FoundDatePattern.None;
						}
						i++;
						continue;
					}
					if (c == 'M')
					{
						int num;
						i = DateTimeFormatInfoScanner.ScanRepeatChar(pattern, 'M', i, out num);
						if (num >= 4 && i < pattern.Length && pattern[i] == '\'')
						{
							i = this.AddDateWords(pattern, i + 1, "MMMM");
						}
						this._ymdFlags |= DateTimeFormatInfoScanner.FoundDatePattern.FoundMonthPatternFlag;
						continue;
					}
				}
				else
				{
					if (c == '\\')
					{
						i += 2;
						continue;
					}
					if (c != 'd')
					{
						if (c == 'y')
						{
							int num;
							i = DateTimeFormatInfoScanner.ScanRepeatChar(pattern, 'y', i, out num);
							this._ymdFlags |= DateTimeFormatInfoScanner.FoundDatePattern.FoundYearPatternFlag;
							continue;
						}
					}
					else
					{
						int num;
						i = DateTimeFormatInfoScanner.ScanRepeatChar(pattern, 'd', i, out num);
						if (num <= 2)
						{
							this._ymdFlags |= DateTimeFormatInfoScanner.FoundDatePattern.FoundDayPatternFlag;
							continue;
						}
						continue;
					}
				}
				if (this._ymdFlags == DateTimeFormatInfoScanner.FoundDatePattern.FoundYMDPatternFlag && !char.IsWhiteSpace(c))
				{
					this._ymdFlags = DateTimeFormatInfoScanner.FoundDatePattern.None;
				}
			}
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x000AA028 File Offset: 0x000A8228
		internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi)
		{
			string[] allDateTimePatterns = dtfi.GetAllDateTimePatterns('D');
			for (int i = 0; i < allDateTimePatterns.Length; i++)
			{
				this.ScanDateWord(allDateTimePatterns[i]);
			}
			allDateTimePatterns = dtfi.GetAllDateTimePatterns('d');
			for (int i = 0; i < allDateTimePatterns.Length; i++)
			{
				this.ScanDateWord(allDateTimePatterns[i]);
			}
			allDateTimePatterns = dtfi.GetAllDateTimePatterns('y');
			for (int i = 0; i < allDateTimePatterns.Length; i++)
			{
				this.ScanDateWord(allDateTimePatterns[i]);
			}
			this.ScanDateWord(dtfi.MonthDayPattern);
			allDateTimePatterns = dtfi.GetAllDateTimePatterns('T');
			for (int i = 0; i < allDateTimePatterns.Length; i++)
			{
				this.ScanDateWord(allDateTimePatterns[i]);
			}
			allDateTimePatterns = dtfi.GetAllDateTimePatterns('t');
			for (int i = 0; i < allDateTimePatterns.Length; i++)
			{
				this.ScanDateWord(allDateTimePatterns[i]);
			}
			string[] array = null;
			if (this.m_dateWords != null && this.m_dateWords.Count > 0)
			{
				array = new string[this.m_dateWords.Count];
				for (int i = 0; i < this.m_dateWords.Count; i++)
				{
					array[i] = this.m_dateWords[i];
				}
			}
			return array;
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x000AA130 File Offset: 0x000A8330
		internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames)
		{
			if (DateTimeFormatInfoScanner.EqualStringArrays(monthNames, genitveMonthNames) && DateTimeFormatInfoScanner.EqualStringArrays(abbrevMonthNames, genetiveAbbrevMonthNames))
			{
				return FORMATFLAGS.None;
			}
			return FORMATFLAGS.UseGenitiveMonth;
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x000AA148 File Offset: 0x000A8348
		internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames)
		{
			return FORMATFLAGS.None | ((DateTimeFormatInfoScanner.ArrayElementsBeginWithDigit(monthNames) || DateTimeFormatInfoScanner.ArrayElementsBeginWithDigit(genitveMonthNames) || DateTimeFormatInfoScanner.ArrayElementsBeginWithDigit(abbrevMonthNames) || DateTimeFormatInfoScanner.ArrayElementsBeginWithDigit(genetiveAbbrevMonthNames)) ? FORMATFLAGS.UseDigitPrefixInTokens : FORMATFLAGS.None) | ((DateTimeFormatInfoScanner.ArrayElementsHaveSpace(monthNames) || DateTimeFormatInfoScanner.ArrayElementsHaveSpace(genitveMonthNames) || DateTimeFormatInfoScanner.ArrayElementsHaveSpace(abbrevMonthNames) || DateTimeFormatInfoScanner.ArrayElementsHaveSpace(genetiveAbbrevMonthNames)) ? FORMATFLAGS.UseSpacesInMonthNames : FORMATFLAGS.None);
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x000AA1A1 File Offset: 0x000A83A1
		internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames)
		{
			if (!DateTimeFormatInfoScanner.ArrayElementsHaveSpace(dayNames) && !DateTimeFormatInfoScanner.ArrayElementsHaveSpace(abbrevDayNames))
			{
				return FORMATFLAGS.None;
			}
			return FORMATFLAGS.UseSpacesInDayNames;
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x000AA1B7 File Offset: 0x000A83B7
		internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID)
		{
			if (calID != 8)
			{
				return FORMATFLAGS.None;
			}
			return (FORMATFLAGS)10;
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x000AA1C4 File Offset: 0x000A83C4
		private static bool EqualStringArrays(string[] array1, string[] array2)
		{
			if (array1 == array2)
			{
				return true;
			}
			if (array1.Length != array2.Length)
			{
				return false;
			}
			for (int i = 0; i < array1.Length; i++)
			{
				if (!array1[i].Equals(array2[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x000AA200 File Offset: 0x000A8400
		private static bool ArrayElementsHaveSpace(string[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array[i].Length; j++)
				{
					if (char.IsWhiteSpace(array[i][j]))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x000AA244 File Offset: 0x000A8444
		private static bool ArrayElementsBeginWithDigit(string[] array)
		{
			int i = 0;
			while (i < array.Length)
			{
				if (array[i].Length > 0 && array[i][0] >= '0' && array[i][0] <= '9')
				{
					int num = 1;
					while (num < array[i].Length && array[i][num] >= '0' && array[i][num] <= '9')
					{
						num++;
					}
					if (num == array[i].Length)
					{
						return false;
					}
					if (num == array[i].Length - 1)
					{
						char c = array[i][num];
						if (c == '月' || c == '월')
						{
							return false;
						}
					}
					return num != array[i].Length - 4 || array[i][num] != '\'' || array[i][num + 1] != ' ' || array[i][num + 2] != '月' || array[i][num + 3] != '\'';
				}
				else
				{
					i++;
				}
			}
			return false;
		}

		// Token: 0x04001664 RID: 5732
		internal List<string> m_dateWords = new List<string>();

		// Token: 0x04001665 RID: 5733
		private static volatile Dictionary<string, string> s_knownWords;

		// Token: 0x04001666 RID: 5734
		private DateTimeFormatInfoScanner.FoundDatePattern _ymdFlags;

		// Token: 0x02000582 RID: 1410
		private enum FoundDatePattern
		{
			// Token: 0x04001668 RID: 5736
			None,
			// Token: 0x04001669 RID: 5737
			FoundYearPatternFlag,
			// Token: 0x0400166A RID: 5738
			FoundMonthPatternFlag,
			// Token: 0x0400166B RID: 5739
			FoundDayPatternFlag = 4,
			// Token: 0x0400166C RID: 5740
			FoundYMDPatternFlag = 7
		}
	}
}
