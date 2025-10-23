using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020000A8 RID: 168
	internal ref struct __DTString
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00019A66 File Offset: 0x00017C66
		internal int Length
		{
			get
			{
				return this.Value.Length;
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00019A73 File Offset: 0x00017C73
		internal __DTString(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi, bool checkDigitToken)
		{
			this = new __DTString(str, dtfi);
			this.m_checkDigitToken = checkDigitToken;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00019A84 File Offset: 0x00017C84
		internal __DTString(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi)
		{
			this.Index = -1;
			this.Value = str;
			this.m_current = '\0';
			if (dtfi != null)
			{
				this.m_info = dtfi.CompareInfo;
				this.m_checkDigitToken = ((dtfi.FormatFlags & DateTimeFormatFlags.UseDigitPrefixInTokens) > DateTimeFormatFlags.None);
				return;
			}
			this.m_info = CultureInfo.CurrentCulture.CompareInfo;
			this.m_checkDigitToken = false;
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00019ADF File Offset: 0x00017CDF
		internal CompareInfo CompareInfo
		{
			get
			{
				return this.m_info;
			}
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00019AE7 File Offset: 0x00017CE7
		internal unsafe bool GetNext()
		{
			this.Index++;
			if (this.Index < this.Length)
			{
				this.m_current = (char)(*this.Value[this.Index]);
				return true;
			}
			return false;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00019B20 File Offset: 0x00017D20
		internal bool AtEnd()
		{
			return this.Index >= this.Length;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00019B33 File Offset: 0x00017D33
		internal unsafe bool Advance(int count)
		{
			this.Index += count;
			if (this.Index < this.Length)
			{
				this.m_current = (char)(*this.Value[this.Index]);
				return true;
			}
			return false;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00019B6C File Offset: 0x00017D6C
		internal unsafe void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi)
		{
			tokenValue = 0;
			if (this.Index >= this.Length)
			{
				tokenType = TokenType.EndOfString;
				return;
			}
			tokenType = TokenType.UnknownToken;
			IL_19:
			while (!DateTimeParse.IsDigit(this.m_current))
			{
				if (char.IsWhiteSpace(this.m_current))
				{
					for (;;)
					{
						int num = this.Index + 1;
						this.Index = num;
						if (num >= this.Length)
						{
							break;
						}
						this.m_current = (char)(*this.Value[this.Index]);
						if (!char.IsWhiteSpace(this.m_current))
						{
							goto IL_19;
						}
					}
					tokenType = TokenType.EndOfString;
					return;
				}
				dtfi.Tokenize(TokenType.RegularTokenMask, out tokenType, out tokenValue, ref this);
				return;
			}
			tokenValue = (int)(this.m_current - '0');
			int index = this.Index;
			for (;;)
			{
				int num = this.Index + 1;
				this.Index = num;
				if (num >= this.Length)
				{
					break;
				}
				this.m_current = (char)(*this.Value[this.Index]);
				int num2 = (int)(this.m_current - '0');
				if (num2 < 0 || num2 > 9)
				{
					break;
				}
				tokenValue = tokenValue * 10 + num2;
			}
			if (this.Index - index > 8)
			{
				tokenType = TokenType.NumberToken;
				tokenValue = -1;
			}
			else if (this.Index - index < 3)
			{
				tokenType = TokenType.NumberToken;
			}
			else
			{
				tokenType = TokenType.YearNumberToken;
			}
			if (!this.m_checkDigitToken)
			{
				return;
			}
			int index2 = this.Index;
			char current = this.m_current;
			this.Index = index;
			this.m_current = (char)(*this.Value[this.Index]);
			TokenType tokenType2;
			int num3;
			if (dtfi.Tokenize(TokenType.RegularTokenMask, out tokenType2, out num3, ref this))
			{
				tokenType = tokenType2;
				tokenValue = num3;
				return;
			}
			this.Index = index2;
			this.m_current = current;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00019CF0 File Offset: 0x00017EF0
		internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator)
		{
			indexBeforeSeparator = this.Index;
			charBeforeSeparator = this.m_current;
			if (!this.SkipWhiteSpaceCurrent())
			{
				return TokenType.SEP_End;
			}
			TokenType result;
			if (!DateTimeParse.IsDigit(this.m_current))
			{
				int num;
				if (!dtfi.Tokenize(TokenType.SeparatorTokenMask, out result, out num, ref this))
				{
					result = TokenType.SEP_Space;
				}
			}
			else
			{
				result = TokenType.SEP_Space;
			}
			return result;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00019D49 File Offset: 0x00017F49
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool MatchSpecifiedWord(string target)
		{
			return this.Index + target.Length <= this.Length && this.m_info.Compare(this.Value.Slice(this.Index, target.Length), target, CompareOptions.IgnoreCase) == 0;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00019D8C File Offset: 0x00017F8C
		internal unsafe bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength)
		{
			int num = this.Value.Length - this.Index;
			matchLength = target.Length;
			if (matchLength > num || this.m_info.Compare(this.Value.Slice(this.Index, matchLength), target, CompareOptions.IgnoreCase) != 0)
			{
				int num2 = 0;
				int num3 = this.Index;
				int num4 = target.IndexOfAny(__DTString.WhiteSpaceChecks, num2);
				if (num4 == -1)
				{
					return false;
				}
				for (;;)
				{
					int num5 = num4 - num2;
					if (num3 >= this.Value.Length - num5)
					{
						break;
					}
					if (num5 == 0)
					{
						matchLength--;
					}
					else
					{
						if (!char.IsWhiteSpace((char)(*this.Value[num3 + num5])))
						{
							return false;
						}
						if (this.m_info.CompareOptionIgnoreCase(this.Value.Slice(num3, num5), target.AsSpan(num2, num5)) != 0)
						{
							return false;
						}
						num3 = num3 + num5 + 1;
					}
					num2 = num4 + 1;
					while (num3 < this.Value.Length && char.IsWhiteSpace((char)(*this.Value[num3])))
					{
						num3++;
						matchLength++;
					}
					if ((num4 = target.IndexOfAny(__DTString.WhiteSpaceChecks, num2)) < 0)
					{
						goto Block_8;
					}
				}
				return false;
				Block_8:
				if (num2 < target.Length)
				{
					int num6 = target.Length - num2;
					if (num3 > this.Value.Length - num6)
					{
						return false;
					}
					if (this.m_info.CompareOptionIgnoreCase(this.Value.Slice(num3, num6), target.AsSpan(num2, num6)) != 0)
					{
						return false;
					}
				}
			}
			if (checkWordBoundary)
			{
				int num7 = this.Index + matchLength;
				if (num7 < this.Value.Length && char.IsLetter((char)(*this.Value[num7])))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00019F2C File Offset: 0x0001812C
		internal bool Match(string str)
		{
			int num = this.Index + 1;
			this.Index = num;
			if (num >= this.Length)
			{
				return false;
			}
			if (str.Length > this.Value.Length - this.Index)
			{
				return false;
			}
			if (this.m_info.Compare(this.Value.Slice(this.Index, str.Length), str, CompareOptions.Ordinal) == 0)
			{
				this.Index += str.Length - 1;
				return true;
			}
			return false;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00019FB4 File Offset: 0x000181B4
		internal unsafe bool Match(char ch)
		{
			int num = this.Index + 1;
			this.Index = num;
			if (num >= this.Length)
			{
				return false;
			}
			if (*this.Value[this.Index] == (ushort)ch)
			{
				this.m_current = ch;
				return true;
			}
			this.Index--;
			return false;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0001A00C File Offset: 0x0001820C
		internal int MatchLongestWords(string[] words, ref int maxMatchStrLen)
		{
			int result = -1;
			for (int i = 0; i < words.Length; i++)
			{
				string text = words[i];
				int length = text.Length;
				if (this.MatchSpecifiedWords(text, false, ref length) && length > maxMatchStrLen)
				{
					maxMatchStrLen = length;
					result = i;
				}
			}
			return result;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0001A04C File Offset: 0x0001824C
		internal unsafe int GetRepeatCount()
		{
			char c = (char)(*this.Value[this.Index]);
			int num = this.Index + 1;
			while (num < this.Length && *this.Value[num] == (ushort)c)
			{
				num++;
			}
			int result = num - this.Index;
			this.Index = num - 1;
			return result;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0001A0A8 File Offset: 0x000182A8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe bool GetNextDigit()
		{
			int num = this.Index + 1;
			this.Index = num;
			return num < this.Length && DateTimeParse.IsDigit((char)(*this.Value[this.Index]));
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0001A0E7 File Offset: 0x000182E7
		internal unsafe char GetChar()
		{
			return (char)(*this.Value[this.Index]);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0001A0FB File Offset: 0x000182FB
		internal unsafe int GetDigit()
		{
			return (int)(*this.Value[this.Index] - 48);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0001A112 File Offset: 0x00018312
		internal unsafe void SkipWhiteSpaces()
		{
			while (this.Index + 1 < this.Length)
			{
				if (!char.IsWhiteSpace((char)(*this.Value[this.Index + 1])))
				{
					return;
				}
				this.Index++;
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0001A150 File Offset: 0x00018350
		internal unsafe bool SkipWhiteSpaceCurrent()
		{
			if (this.Index >= this.Length)
			{
				return false;
			}
			if (!char.IsWhiteSpace(this.m_current))
			{
				return true;
			}
			do
			{
				int num = this.Index + 1;
				this.Index = num;
				if (num >= this.Length)
				{
					return false;
				}
				this.m_current = (char)(*this.Value[this.Index]);
			}
			while (char.IsWhiteSpace(this.m_current));
			return true;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0001A1C0 File Offset: 0x000183C0
		internal unsafe void TrimTail()
		{
			int num = this.Length - 1;
			while (num >= 0 && char.IsWhiteSpace((char)(*this.Value[num])))
			{
				num--;
			}
			this.Value = this.Value.Slice(0, num + 1);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0001A20C File Offset: 0x0001840C
		internal unsafe void RemoveTrailingInQuoteSpaces()
		{
			int num = this.Length - 1;
			if (num <= 1)
			{
				return;
			}
			char c = (char)(*this.Value[num]);
			if ((c == '\'' || c == '"') && char.IsWhiteSpace((char)(*this.Value[num - 1])))
			{
				num--;
				while (num >= 1 && char.IsWhiteSpace((char)(*this.Value[num - 1])))
				{
					num--;
				}
				Span<char> span = new char[num + 1];
				*span[num] = c;
				this.Value.Slice(0, num).CopyTo(span);
				this.Value = span;
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0001A2B4 File Offset: 0x000184B4
		internal unsafe void RemoveLeadingInQuoteSpaces()
		{
			if (this.Length <= 2)
			{
				return;
			}
			int num = 0;
			char c = (char)(*this.Value[num]);
			if (c != '\'')
			{
				if (c != '"')
				{
					return;
				}
			}
			while (num + 1 < this.Length && char.IsWhiteSpace((char)(*this.Value[num + 1])))
			{
				num++;
			}
			if (num != 0)
			{
				Span<char> span = new char[this.Value.Length - num];
				*span[0] = c;
				this.Value.Slice(num + 1).CopyTo(span.Slice(1));
				this.Value = span;
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0001A35C File Offset: 0x0001855C
		internal unsafe DTSubString GetSubString()
		{
			DTSubString dtsubString = default(DTSubString);
			dtsubString.index = this.Index;
			dtsubString.s = this.Value;
			while (this.Index + dtsubString.length < this.Length)
			{
				char c = (char)(*this.Value[this.Index + dtsubString.length]);
				DTSubStringType dtsubStringType;
				if (c >= '0' && c <= '9')
				{
					dtsubStringType = DTSubStringType.Number;
				}
				else
				{
					dtsubStringType = DTSubStringType.Other;
				}
				if (dtsubString.length == 0)
				{
					dtsubString.type = dtsubStringType;
				}
				else if (dtsubString.type != dtsubStringType)
				{
					break;
				}
				dtsubString.length++;
				if (dtsubStringType != DTSubStringType.Number)
				{
					break;
				}
				if (dtsubString.length > 8)
				{
					dtsubString.type = DTSubStringType.Invalid;
					return dtsubString;
				}
				int num = (int)(c - '0');
				dtsubString.value = dtsubString.value * 10 + num;
			}
			if (dtsubString.length == 0)
			{
				dtsubString.type = DTSubStringType.End;
				return dtsubString;
			}
			return dtsubString;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0001A437 File Offset: 0x00018637
		internal unsafe void ConsumeSubString(DTSubString sub)
		{
			this.Index = sub.index + sub.length;
			if (this.Index < this.Length)
			{
				this.m_current = (char)(*this.Value[this.Index]);
			}
		}

		// Token: 0x04000272 RID: 626
		internal ReadOnlySpan<char> Value;

		// Token: 0x04000273 RID: 627
		internal int Index;

		// Token: 0x04000274 RID: 628
		internal char m_current;

		// Token: 0x04000275 RID: 629
		private CompareInfo m_info;

		// Token: 0x04000276 RID: 630
		private bool m_checkDigitToken;

		// Token: 0x04000277 RID: 631
		private static readonly char[] WhiteSpaceChecks = new char[]
		{
			' ',
			'\u00a0'
		};
	}
}
