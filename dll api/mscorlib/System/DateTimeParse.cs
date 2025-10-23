﻿using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace System
{
	// Token: 0x020000A2 RID: 162
	internal static class DateTimeParse
	{
		// Token: 0x06000572 RID: 1394 RVA: 0x000150F4 File Offset: 0x000132F4
		internal static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			if (DateTimeParse.TryParseExact(s, format, dtfi, style, ref dateTimeResult))
			{
				return dateTimeResult.parsedDate;
			}
			throw DateTimeParse.GetDateTimeParseException(ref dateTimeResult);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0001512C File Offset: 0x0001332C
		internal static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out TimeSpan offset)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			offset = TimeSpan.Zero;
			dateTimeResult.Init(s);
			dateTimeResult.flags |= ParseFlags.CaptureOffset;
			if (DateTimeParse.TryParseExact(s, format, dtfi, style, ref dateTimeResult))
			{
				offset = dateTimeResult.timeZoneOffset;
				return dateTimeResult.parsedDate;
			}
			throw DateTimeParse.GetDateTimeParseException(ref dateTimeResult);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00015190 File Offset: 0x00013390
		internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result)
		{
			result = DateTime.MinValue;
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			if (DateTimeParse.TryParseExact(s, format, dtfi, style, ref dateTimeResult))
			{
				result = dateTimeResult.parsedDate;
				return true;
			}
			return false;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x000151D8 File Offset: 0x000133D8
		internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset)
		{
			result = DateTime.MinValue;
			offset = TimeSpan.Zero;
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			dateTimeResult.flags |= ParseFlags.CaptureOffset;
			if (DateTimeParse.TryParseExact(s, format, dtfi, style, ref dateTimeResult))
			{
				result = dateTimeResult.parsedDate;
				offset = dateTimeResult.timeZoneOffset;
				return true;
			}
			return false;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00015247 File Offset: 0x00013447
		internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result)
		{
			if (s.Length == 0)
			{
				result.SetFailure(ParseFailureKind.FormatWithParameter, "String was not recognized as a valid DateTime.");
				return false;
			}
			if (format.Length == 0)
			{
				result.SetBadFormatSpecifierFailure();
				return false;
			}
			return DateTimeParse.DoStrictParse(s, format, style, dtfi, ref result);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00015280 File Offset: 0x00013480
		internal static DateTime ParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			if (DateTimeParse.TryParseExactMultiple(s, formats, dtfi, style, ref dateTimeResult))
			{
				return dateTimeResult.parsedDate;
			}
			throw DateTimeParse.GetDateTimeParseException(ref dateTimeResult);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x000152B8 File Offset: 0x000134B8
		internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result)
		{
			if (formats == null)
			{
				result.SetFailure(ParseFailureKind.ArgumentNull, "String reference not set to an instance of a String.", null, "formats");
				return false;
			}
			if (s.Length == 0)
			{
				result.SetFailure(ParseFailureKind.FormatWithParameter, "String was not recognized as a valid DateTime.");
				return false;
			}
			if (formats.Length == 0)
			{
				result.SetFailure(ParseFailureKind.Format, "Format_NoFormatSpecifier");
				return false;
			}
			for (int i = 0; i < formats.Length; i++)
			{
				if (formats[i] == null || formats[i].Length == 0)
				{
					result.SetBadFormatSpecifierFailure();
					return false;
				}
				DateTimeResult dateTimeResult = default(DateTimeResult);
				dateTimeResult.Init(s);
				dateTimeResult.flags = result.flags;
				if (DateTimeParse.TryParseExact(s, formats[i], dtfi, style, ref dateTimeResult))
				{
					result.parsedDate = dateTimeResult.parsedDate;
					result.timeZoneOffset = dateTimeResult.timeZoneOffset;
					return true;
				}
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00015384 File Offset: 0x00013584
		private unsafe static bool MatchWord(ref __DTString str, string target)
		{
			if (target.Length > str.Value.Length - str.Index)
			{
				return false;
			}
			if (str.CompareInfo.Compare(str.Value.Slice(str.Index, target.Length), target, CompareOptions.IgnoreCase) != 0)
			{
				return false;
			}
			int num = str.Index + target.Length;
			if (num < str.Value.Length && char.IsLetter((char)(*str.Value[num])))
			{
				return false;
			}
			str.Index = num;
			if (str.Index < str.Length)
			{
				str.m_current = (char)(*str.Value[str.Index]);
			}
			return true;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00015435 File Offset: 0x00013635
		private static bool GetTimeZoneName(ref __DTString str)
		{
			return DateTimeParse.MatchWord(ref str, "GMT") || DateTimeParse.MatchWord(ref str, "Z");
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00015456 File Offset: 0x00013656
		internal static bool IsDigit(char ch)
		{
			return ch - '0' <= '\t';
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00015464 File Offset: 0x00013664
		private static bool ParseFraction(ref __DTString str, out double result)
		{
			result = 0.0;
			double num = 0.1;
			int num2 = 0;
			char current;
			while (str.GetNext() && DateTimeParse.IsDigit(current = str.m_current))
			{
				result += (double)(current - '0') * num;
				num *= 0.1;
				num2++;
			}
			return num2 > 0;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000154C4 File Offset: 0x000136C4
		private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result)
		{
			int num = 0;
			DTSubString subString = str.GetSubString();
			if (subString.length != 1)
			{
				return false;
			}
			char c = subString[0];
			if (c != '+' && c != '-')
			{
				return false;
			}
			str.ConsumeSubString(subString);
			subString = str.GetSubString();
			if (subString.type != DTSubStringType.Number)
			{
				return false;
			}
			int value = subString.value;
			int length = subString.length;
			int hours;
			if (length == 1 || length == 2)
			{
				hours = value;
				str.ConsumeSubString(subString);
				subString = str.GetSubString();
				if (subString.length == 1 && subString[0] == ':')
				{
					str.ConsumeSubString(subString);
					subString = str.GetSubString();
					if (subString.type != DTSubStringType.Number || subString.length < 1 || subString.length > 2)
					{
						return false;
					}
					num = subString.value;
					str.ConsumeSubString(subString);
				}
			}
			else
			{
				if (length != 3 && length != 4)
				{
					return false;
				}
				hours = value / 100;
				num = value % 100;
				str.ConsumeSubString(subString);
			}
			if (num < 0 || num >= 60)
			{
				return false;
			}
			result = new TimeSpan(hours, num, 0);
			if (c == '-')
			{
				result = result.Negate();
			}
			return true;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000155DC File Offset: 0x000137DC
		private unsafe static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result)
		{
			if (str.Index < str.Length - 1)
			{
				char c = (char)(*str.Value[str.Index]);
				int num = 0;
				while (char.IsWhiteSpace(c) && str.Index + num < str.Length - 1)
				{
					num++;
					c = (char)(*str.Value[str.Index + num]);
				}
				if (c == '+' || c == '-')
				{
					str.Index += num;
					if ((result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0)
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					result.flags |= ParseFlags.TimeZoneUsed;
					if (!DateTimeParse.ParseTimeZone(ref str, ref result.timeZoneOffset))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00015698 File Offset: 0x00013898
		private unsafe static bool Lex(DateTimeParse.DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles)
		{
			dtok.dtt = DateTimeParse.DTT.Unk;
			TokenType tokenType;
			int num;
			str.GetRegularToken(out tokenType, out num, dtfi);
			switch (tokenType)
			{
			case TokenType.NumberToken:
			case TokenType.YearNumberToken:
				if (raw.numCount == 3 || num == -1)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				if (dps == DateTimeParse.DS.T_NNt && str.Index < str.Length - 1 && *str.Value[str.Index] == 46)
				{
					DateTimeParse.ParseFraction(ref str, out raw.fraction);
				}
				if ((dps == DateTimeParse.DS.T_NNt || dps == DateTimeParse.DS.T_Nt) && str.Index < str.Length - 1 && !DateTimeParse.HandleTimeZone(ref str, ref result))
				{
					return false;
				}
				dtok.num = num;
				if (tokenType != TokenType.YearNumberToken)
				{
					int index;
					char current;
					TokenType separatorToken;
					TokenType tokenType2 = separatorToken = str.GetSeparatorToken(dtfi, out index, out current);
					if (separatorToken > TokenType.SEP_YearSuff)
					{
						if (separatorToken <= TokenType.SEP_HourSuff)
						{
							if (separatorToken == TokenType.SEP_MonthSuff || separatorToken == TokenType.SEP_DaySuff)
							{
								dtok.dtt = DateTimeParse.DTT.NumDatesuff;
								dtok.suffix = tokenType2;
								break;
							}
							if (separatorToken != TokenType.SEP_HourSuff)
							{
								goto IL_59F;
							}
						}
						else if (separatorToken <= TokenType.SEP_SecondSuff)
						{
							if (separatorToken != TokenType.SEP_MinuteSuff && separatorToken != TokenType.SEP_SecondSuff)
							{
								goto IL_59F;
							}
						}
						else
						{
							if (separatorToken == TokenType.SEP_LocalTimeMark)
							{
								dtok.dtt = DateTimeParse.DTT.NumLocalTimeMark;
								raw.AddNumber(dtok.num);
								break;
							}
							if (separatorToken != TokenType.SEP_DateOrOffset)
							{
								goto IL_59F;
							}
							if (DateTimeParse.dateParsingStates[(int)dps][4] == DateTimeParse.DS.ERROR && DateTimeParse.dateParsingStates[(int)dps][3] > DateTimeParse.DS.ERROR)
							{
								str.Index = index;
								str.m_current = current;
								dtok.dtt = DateTimeParse.DTT.NumSpace;
							}
							else
							{
								dtok.dtt = DateTimeParse.DTT.NumDatesep;
							}
							raw.AddNumber(dtok.num);
							break;
						}
						dtok.dtt = DateTimeParse.DTT.NumTimesuff;
						dtok.suffix = tokenType2;
						break;
					}
					if (separatorToken <= TokenType.SEP_Am)
					{
						if (separatorToken == TokenType.SEP_End)
						{
							dtok.dtt = DateTimeParse.DTT.NumEnd;
							raw.AddNumber(dtok.num);
							break;
						}
						if (separatorToken == TokenType.SEP_Space)
						{
							dtok.dtt = DateTimeParse.DTT.NumSpace;
							raw.AddNumber(dtok.num);
							break;
						}
						if (separatorToken != TokenType.SEP_Am)
						{
							goto IL_59F;
						}
					}
					else if (separatorToken <= TokenType.SEP_Date)
					{
						if (separatorToken != TokenType.SEP_Pm)
						{
							if (separatorToken != TokenType.SEP_Date)
							{
								goto IL_59F;
							}
							dtok.dtt = DateTimeParse.DTT.NumDatesep;
							raw.AddNumber(dtok.num);
							break;
						}
					}
					else if (separatorToken != TokenType.SEP_Time)
					{
						if (separatorToken != TokenType.SEP_YearSuff)
						{
							goto IL_59F;
						}
						try
						{
							dtok.num = dtfi.Calendar.ToFourDigitYear(num);
						}
						catch (ArgumentOutOfRangeException)
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						dtok.dtt = DateTimeParse.DTT.NumDatesuff;
						dtok.suffix = tokenType2;
						break;
					}
					else
					{
						if (raw.hasSameDateAndTimeSeparators && (dps == DateTimeParse.DS.D_Y || dps == DateTimeParse.DS.D_YN || dps == DateTimeParse.DS.D_YNd || dps == DateTimeParse.DS.D_YM || dps == DateTimeParse.DS.D_YMd))
						{
							dtok.dtt = DateTimeParse.DTT.NumDatesep;
							raw.AddNumber(dtok.num);
							break;
						}
						dtok.dtt = DateTimeParse.DTT.NumTimesep;
						raw.AddNumber(dtok.num);
						break;
					}
					if (raw.timeMark != DateTimeParse.TM.NotSet)
					{
						result.SetBadDateTimeFailure();
						break;
					}
					raw.timeMark = ((tokenType2 == TokenType.SEP_Am) ? DateTimeParse.TM.AM : DateTimeParse.TM.PM);
					dtok.dtt = DateTimeParse.DTT.NumAmpm;
					if (dps == DateTimeParse.DS.D_NN && !DateTimeParse.ProcessTerminalState(DateTimeParse.DS.DX_NN, ref str, ref result, ref styles, ref raw, dtfi))
					{
						return false;
					}
					raw.AddNumber(dtok.num);
					if ((dps == DateTimeParse.DS.T_NNt || dps == DateTimeParse.DS.T_Nt) && !DateTimeParse.HandleTimeZone(ref str, ref result))
					{
						return false;
					}
					break;
					IL_59F:
					result.SetBadDateTimeFailure();
					return false;
				}
				if (raw.year == -1)
				{
					raw.year = num;
					int index;
					char current;
					TokenType separatorToken;
					TokenType tokenType2 = separatorToken = str.GetSeparatorToken(dtfi, out index, out current);
					if (separatorToken <= TokenType.SEP_Time)
					{
						if (separatorToken <= TokenType.SEP_Am)
						{
							if (separatorToken == TokenType.SEP_End)
							{
								dtok.dtt = DateTimeParse.DTT.YearEnd;
								return true;
							}
							if (separatorToken == TokenType.SEP_Space)
							{
								dtok.dtt = DateTimeParse.DTT.YearSpace;
								return true;
							}
							if (separatorToken != TokenType.SEP_Am)
							{
								goto IL_2B4;
							}
						}
						else if (separatorToken != TokenType.SEP_Pm)
						{
							if (separatorToken == TokenType.SEP_Date)
							{
								dtok.dtt = DateTimeParse.DTT.YearDateSep;
								return true;
							}
							if (separatorToken != TokenType.SEP_Time)
							{
								goto IL_2B4;
							}
							if (!raw.hasSameDateAndTimeSeparators)
							{
								result.SetBadDateTimeFailure();
								return false;
							}
							dtok.dtt = DateTimeParse.DTT.YearDateSep;
							return true;
						}
						if (raw.timeMark == DateTimeParse.TM.NotSet)
						{
							raw.timeMark = ((tokenType2 == TokenType.SEP_Am) ? DateTimeParse.TM.AM : DateTimeParse.TM.PM);
							dtok.dtt = DateTimeParse.DTT.YearSpace;
							return true;
						}
						result.SetBadDateTimeFailure();
						return true;
					}
					else
					{
						if (separatorToken > TokenType.SEP_DaySuff)
						{
							if (separatorToken <= TokenType.SEP_MinuteSuff)
							{
								if (separatorToken != TokenType.SEP_HourSuff && separatorToken != TokenType.SEP_MinuteSuff)
								{
									goto IL_2B4;
								}
							}
							else if (separatorToken != TokenType.SEP_SecondSuff)
							{
								if (separatorToken != TokenType.SEP_DateOrOffset)
								{
									goto IL_2B4;
								}
								if (DateTimeParse.dateParsingStates[(int)dps][13] == DateTimeParse.DS.ERROR && DateTimeParse.dateParsingStates[(int)dps][12] > DateTimeParse.DS.ERROR)
								{
									str.Index = index;
									str.m_current = current;
									dtok.dtt = DateTimeParse.DTT.YearSpace;
									return true;
								}
								dtok.dtt = DateTimeParse.DTT.YearDateSep;
								return true;
							}
							dtok.dtt = DateTimeParse.DTT.NumTimesuff;
							dtok.suffix = tokenType2;
							return true;
						}
						if (separatorToken == TokenType.SEP_YearSuff || separatorToken == TokenType.SEP_MonthSuff || separatorToken == TokenType.SEP_DaySuff)
						{
							dtok.dtt = DateTimeParse.DTT.NumDatesuff;
							dtok.suffix = tokenType2;
							return true;
						}
					}
					IL_2B4:
					result.SetBadDateTimeFailure();
					return false;
				}
				result.SetBadDateTimeFailure();
				return false;
			case TokenType.Am:
			case TokenType.Pm:
				if (raw.timeMark != DateTimeParse.TM.NotSet)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				raw.timeMark = (DateTimeParse.TM)num;
				break;
			case TokenType.MonthToken:
			{
				if (raw.month != -1)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				int index;
				char current;
				TokenType separatorToken;
				TokenType tokenType2 = separatorToken = str.GetSeparatorToken(dtfi, out index, out current);
				if (separatorToken <= TokenType.SEP_Space)
				{
					if (separatorToken == TokenType.SEP_End)
					{
						dtok.dtt = DateTimeParse.DTT.MonthEnd;
						goto IL_7F7;
					}
					if (separatorToken == TokenType.SEP_Space)
					{
						dtok.dtt = DateTimeParse.DTT.MonthSpace;
						goto IL_7F7;
					}
				}
				else
				{
					if (separatorToken == TokenType.SEP_Date)
					{
						dtok.dtt = DateTimeParse.DTT.MonthDatesep;
						goto IL_7F7;
					}
					if (separatorToken != TokenType.SEP_Time)
					{
						if (separatorToken == TokenType.SEP_DateOrOffset)
						{
							if (DateTimeParse.dateParsingStates[(int)dps][8] == DateTimeParse.DS.ERROR && DateTimeParse.dateParsingStates[(int)dps][7] > DateTimeParse.DS.ERROR)
							{
								str.Index = index;
								str.m_current = current;
								dtok.dtt = DateTimeParse.DTT.MonthSpace;
								goto IL_7F7;
							}
							dtok.dtt = DateTimeParse.DTT.MonthDatesep;
							goto IL_7F7;
						}
					}
					else
					{
						if (!raw.hasSameDateAndTimeSeparators)
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						dtok.dtt = DateTimeParse.DTT.MonthDatesep;
						goto IL_7F7;
					}
				}
				result.SetBadDateTimeFailure();
				return false;
				IL_7F7:
				raw.month = num;
				break;
			}
			case TokenType.EndOfString:
				dtok.dtt = DateTimeParse.DTT.End;
				break;
			case TokenType.DayOfWeekToken:
				if (raw.dayOfWeek != -1)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				raw.dayOfWeek = num;
				dtok.dtt = DateTimeParse.DTT.DayOfWeek;
				break;
			case TokenType.TimeZoneToken:
				if ((result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				dtok.dtt = DateTimeParse.DTT.TimeZone;
				result.flags |= ParseFlags.TimeZoneUsed;
				result.timeZoneOffset = new TimeSpan(0L);
				result.flags |= ParseFlags.TimeZoneUtc;
				break;
			case TokenType.EraToken:
				if (result.era == -1)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				result.era = num;
				dtok.dtt = DateTimeParse.DTT.Era;
				break;
			case TokenType.UnknownToken:
				if (char.IsLetter(str.m_current))
				{
					result.SetFailure(ParseFailureKind.FormatWithOriginalDateTimeAndParameter, "Format_UnknownDateTimeWord", str.Index);
					return false;
				}
				if ((str.m_current == '-' || str.m_current == '+') && (result.flags & ParseFlags.TimeZoneUsed) == (ParseFlags)0)
				{
					int index2 = str.Index;
					if (DateTimeParse.ParseTimeZone(ref str, ref result.timeZoneOffset))
					{
						result.flags |= ParseFlags.TimeZoneUsed;
						return true;
					}
					str.Index = index2;
				}
				if (DateTimeParse.VerifyValidPunctuation(ref str))
				{
					return true;
				}
				result.SetBadDateTimeFailure();
				return false;
			case TokenType.HebrewNumber:
			{
				int index;
				char current;
				TokenType separatorToken;
				TokenType tokenType2;
				if (num < 100)
				{
					dtok.num = num;
					raw.AddNumber(dtok.num);
					tokenType2 = (separatorToken = str.GetSeparatorToken(dtfi, out index, out current));
					if (separatorToken <= TokenType.SEP_Space)
					{
						if (separatorToken == TokenType.SEP_End)
						{
							dtok.dtt = DateTimeParse.DTT.NumEnd;
							break;
						}
						if (separatorToken != TokenType.SEP_Space)
						{
							goto IL_6F5;
						}
					}
					else if (separatorToken != TokenType.SEP_Date)
					{
						if (separatorToken != TokenType.SEP_DateOrOffset)
						{
							goto IL_6F5;
						}
						if (DateTimeParse.dateParsingStates[(int)dps][4] == DateTimeParse.DS.ERROR && DateTimeParse.dateParsingStates[(int)dps][3] > DateTimeParse.DS.ERROR)
						{
							str.Index = index;
							str.m_current = current;
							dtok.dtt = DateTimeParse.DTT.NumSpace;
							break;
						}
						dtok.dtt = DateTimeParse.DTT.NumDatesep;
						break;
					}
					dtok.dtt = DateTimeParse.DTT.NumDatesep;
					break;
					IL_6F5:
					result.SetBadDateTimeFailure();
					return false;
				}
				if (raw.year != -1)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				raw.year = num;
				tokenType2 = (separatorToken = str.GetSeparatorToken(dtfi, out index, out current));
				if (separatorToken != TokenType.SEP_End)
				{
					if (separatorToken != TokenType.SEP_Space)
					{
						if (separatorToken == TokenType.SEP_DateOrOffset)
						{
							if (DateTimeParse.dateParsingStates[(int)dps][12] > DateTimeParse.DS.ERROR)
							{
								str.Index = index;
								str.m_current = current;
								dtok.dtt = DateTimeParse.DTT.YearSpace;
								break;
							}
						}
						result.SetBadDateTimeFailure();
						return false;
					}
					dtok.dtt = DateTimeParse.DTT.YearSpace;
				}
				else
				{
					dtok.dtt = DateTimeParse.DTT.YearEnd;
				}
				break;
			}
			case TokenType.JapaneseEraToken:
				if (GlobalizationMode.Invariant)
				{
					throw new PlatformNotSupportedException();
				}
				result.calendar = DateTimeParse.GetJapaneseCalendarDefaultInstance();
				dtfi = DateTimeFormatInfo.GetJapaneseCalendarDTFI();
				if (result.era == -1)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				result.era = num;
				dtok.dtt = DateTimeParse.DTT.Era;
				break;
			case TokenType.TEraToken:
				if (GlobalizationMode.Invariant)
				{
					throw new PlatformNotSupportedException();
				}
				result.calendar = DateTimeParse.GetTaiwanCalendarDefaultInstance();
				dtfi = DateTimeFormatInfo.GetTaiwanCalendarDTFI();
				if (result.era == -1)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				result.era = num;
				dtok.dtt = DateTimeParse.DTT.Era;
				break;
			}
			return true;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0001608C File Offset: 0x0001428C
		private static Calendar GetJapaneseCalendarDefaultInstance()
		{
			if (GlobalizationMode.Invariant)
			{
				throw new PlatformNotSupportedException();
			}
			return JapaneseCalendar.GetDefaultInstance();
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x000160A0 File Offset: 0x000142A0
		internal static Calendar GetTaiwanCalendarDefaultInstance()
		{
			if (GlobalizationMode.Invariant)
			{
				throw new PlatformNotSupportedException();
			}
			return TaiwanCalendar.GetDefaultInstance();
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000160B4 File Offset: 0x000142B4
		private unsafe static bool VerifyValidPunctuation(ref __DTString str)
		{
			char c = (char)(*str.Value[str.Index]);
			if (c == '#')
			{
				bool flag = false;
				bool flag2 = false;
				for (int i = 0; i < str.Length; i++)
				{
					c = (char)(*str.Value[i]);
					if (c == '#')
					{
						if (flag)
						{
							if (flag2)
							{
								return false;
							}
							flag2 = true;
						}
						else
						{
							flag = true;
						}
					}
					else if (c == '\0')
					{
						if (!flag2)
						{
							return false;
						}
					}
					else if (!char.IsWhiteSpace(c) && (!flag || flag2))
					{
						return false;
					}
				}
				if (!flag2)
				{
					return false;
				}
				str.GetNext();
				return true;
			}
			else
			{
				if (c == '\0')
				{
					for (int j = str.Index; j < str.Length; j++)
					{
						if (*str.Value[j] != 0)
						{
							return false;
						}
					}
					str.Index = str.Length;
					return true;
				}
				return false;
			}
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00016178 File Offset: 0x00014378
		private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order)
		{
			int num = -1;
			int num2 = -1;
			int num3 = -1;
			int num4 = 0;
			bool flag = false;
			int num5 = 0;
			while (num5 < datePattern.Length && num4 < 3)
			{
				char c = datePattern[num5];
				if (c == '\\' || c == '%')
				{
					num5++;
				}
				else
				{
					if (c == '\'' || c == '"')
					{
						flag = !flag;
					}
					if (!flag)
					{
						if (c == 'y')
						{
							num = num4++;
							while (num5 + 1 < datePattern.Length)
							{
								if (datePattern[num5 + 1] != 'y')
								{
									break;
								}
								num5++;
							}
						}
						else if (c == 'M')
						{
							num2 = num4++;
							while (num5 + 1 < datePattern.Length)
							{
								if (datePattern[num5 + 1] != 'M')
								{
									break;
								}
								num5++;
							}
						}
						else if (c == 'd')
						{
							int num6 = 1;
							while (num5 + 1 < datePattern.Length && datePattern[num5 + 1] == 'd')
							{
								num6++;
								num5++;
							}
							if (num6 <= 2)
							{
								num3 = num4++;
							}
						}
					}
				}
				num5++;
			}
			if (num == 0 && num2 == 1 && num3 == 2)
			{
				order = 0;
				return true;
			}
			if (num2 == 0 && num3 == 1 && num == 2)
			{
				order = 1;
				return true;
			}
			if (num3 == 0 && num2 == 1 && num == 2)
			{
				order = 2;
				return true;
			}
			if (num == 0 && num3 == 1 && num2 == 2)
			{
				order = 3;
				return true;
			}
			order = -1;
			return false;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000162CC File Offset: 0x000144CC
		private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order)
		{
			int num = -1;
			int num2 = -1;
			int num3 = 0;
			bool flag = false;
			int num4 = 0;
			while (num4 < pattern.Length && num3 < 2)
			{
				char c = pattern[num4];
				if (c == '\\' || c == '%')
				{
					num4++;
				}
				else
				{
					if (c == '\'' || c == '"')
					{
						flag = !flag;
					}
					if (!flag)
					{
						if (c == 'y')
						{
							num = num3++;
							while (num4 + 1 < pattern.Length)
							{
								if (pattern[num4 + 1] != 'y')
								{
									break;
								}
								num4++;
							}
						}
						else if (c == 'M')
						{
							num2 = num3++;
							while (num4 + 1 < pattern.Length && pattern[num4 + 1] == 'M')
							{
								num4++;
							}
						}
					}
				}
				num4++;
			}
			if (num == 0 && num2 == 1)
			{
				order = 4;
				return true;
			}
			if (num2 == 0 && num == 1)
			{
				order = 5;
				return true;
			}
			order = -1;
			return false;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x000163AC File Offset: 0x000145AC
		private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order)
		{
			int num = -1;
			int num2 = -1;
			int num3 = 0;
			bool flag = false;
			int num4 = 0;
			while (num4 < pattern.Length && num3 < 2)
			{
				char c = pattern[num4];
				if (c == '\\' || c == '%')
				{
					num4++;
				}
				else
				{
					if (c == '\'' || c == '"')
					{
						flag = !flag;
					}
					if (!flag)
					{
						if (c == 'd')
						{
							int num5 = 1;
							while (num4 + 1 < pattern.Length && pattern[num4 + 1] == 'd')
							{
								num5++;
								num4++;
							}
							if (num5 <= 2)
							{
								num2 = num3++;
							}
						}
						else if (c == 'M')
						{
							num = num3++;
							while (num4 + 1 < pattern.Length && pattern[num4 + 1] == 'M')
							{
								num4++;
							}
						}
					}
				}
				num4++;
			}
			if (num == 0 && num2 == 1)
			{
				order = 6;
				return true;
			}
			if (num2 == 0 && num == 1)
			{
				order = 7;
				return true;
			}
			order = -1;
			return false;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000164A0 File Offset: 0x000146A0
		private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear)
		{
			if (year < 100)
			{
				try
				{
					year = result.calendar.ToFourDigitYear(year);
				}
				catch (ArgumentOutOfRangeException)
				{
					adjustedYear = -1;
					return false;
				}
			}
			adjustedYear = year;
			return true;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000164E0 File Offset: 0x000146E0
		private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day)
		{
			if (result.calendar.IsValidDay(year, month, day, result.era))
			{
				result.SetDate(year, month, day);
				return true;
			}
			return false;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00016504 File Offset: 0x00014704
		private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year)
		{
			return DateTimeParse.SetDateYMD(ref result, year, month, day);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0001650F File Offset: 0x0001470F
		private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year)
		{
			return DateTimeParse.SetDateYMD(ref result, year, month, day);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0001651A File Offset: 0x0001471A
		private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month)
		{
			return DateTimeParse.SetDateYMD(ref result, year, month, day);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00016525 File Offset: 0x00014725
		private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles)
		{
			result.Year = result.calendar.GetYear(DateTimeParse.GetDateTimeNow(ref result, ref styles));
			result.flags |= ParseFlags.YearDefault;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00016550 File Offset: 0x00014750
		private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int number = raw.GetNumber(0);
			int number2 = raw.GetNumber(1);
			DateTimeParse.GetDefaultYear(ref result, ref styles);
			int num;
			if (!DateTimeParse.GetMonthDayOrder(dtfi.MonthDayPattern, dtfi, out num))
			{
				result.SetFailure(ParseFailureKind.FormatWithParameter, "Could not determine the order of year, month, and date from '{0}'.", dtfi.MonthDayPattern);
				return false;
			}
			if (num == 6)
			{
				if (DateTimeParse.SetDateYMD(ref result, result.Year, number, number2))
				{
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (DateTimeParse.SetDateYMD(ref result, result.Year, number2, number))
			{
				result.flags |= ParseFlags.HaveDate;
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x000165FC File Offset: 0x000147FC
		private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int number = raw.GetNumber(0);
			int number2 = raw.GetNumber(1);
			int number3 = raw.GetNumber(2);
			int num;
			if (!DateTimeParse.GetYearMonthDayOrder(dtfi.ShortDatePattern, dtfi, out num))
			{
				result.SetFailure(ParseFailureKind.FormatWithParameter, "Could not determine the order of year, month, and date from '{0}'.", dtfi.ShortDatePattern);
				return false;
			}
			int year;
			if (num == 0)
			{
				if (DateTimeParse.TryAdjustYear(ref result, number, out year) && DateTimeParse.SetDateYMD(ref result, year, number2, number3))
				{
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (num == 1)
			{
				if (DateTimeParse.TryAdjustYear(ref result, number3, out year) && DateTimeParse.SetDateMDY(ref result, number, number2, year))
				{
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (num == 2)
			{
				if (DateTimeParse.TryAdjustYear(ref result, number3, out year) && DateTimeParse.SetDateDMY(ref result, number, number2, year))
				{
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (num == 3 && DateTimeParse.TryAdjustYear(ref result, number, out year) && DateTimeParse.SetDateYDM(ref result, year, number2, number3))
			{
				result.flags |= ParseFlags.HaveDate;
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00016718 File Offset: 0x00014918
		private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int num;
			if (!DateTimeParse.GetMonthDayOrder(dtfi.MonthDayPattern, dtfi, out num))
			{
				result.SetFailure(ParseFailureKind.FormatWithParameter, "Could not determine the order of year, month, and date from '{0}'.", dtfi.MonthDayPattern);
				return false;
			}
			if (num == 7)
			{
				int num2;
				if (!DateTimeParse.GetYearMonthOrder(dtfi.YearMonthPattern, dtfi, out num2))
				{
					result.SetFailure(ParseFailureKind.FormatWithParameter, "Could not determine the order of year, month, and date from '{0}'.", dtfi.YearMonthPattern);
					return false;
				}
				if (num2 == 5)
				{
					int year;
					if (!DateTimeParse.TryAdjustYear(ref result, raw.GetNumber(0), out year) || !DateTimeParse.SetDateYMD(ref result, year, raw.month, 1))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					return true;
				}
			}
			DateTimeParse.GetDefaultYear(ref result, ref styles);
			if (!DateTimeParse.SetDateYMD(ref result, result.Year, raw.month, raw.GetNumber(0)))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			return true;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x000167E4 File Offset: 0x000149E4
		private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			int num;
			if (!DateTimeParse.GetMonthDayOrder(dtfi.MonthDayPattern, dtfi, out num))
			{
				result.SetFailure(ParseFailureKind.FormatWithParameter, "Could not determine the order of year, month, and date from '{0}'.", dtfi.MonthDayPattern);
				return false;
			}
			result.Month = raw.month;
			if ((num == 7 || num == 6) && result.calendar.IsValidDay(result.Year, result.Month, raw.GetNumber(0), result.era))
			{
				result.Day = raw.GetNumber(0);
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00016868 File Offset: 0x00014A68
		private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int num;
			if (!DateTimeParse.GetMonthDayOrder(dtfi.MonthDayPattern, dtfi, out num))
			{
				result.SetFailure(ParseFailureKind.FormatWithParameter, "Could not determine the order of year, month, and date from '{0}'.", dtfi.MonthDayPattern);
				return false;
			}
			if (num == 6)
			{
				int num2;
				if (!DateTimeParse.GetYearMonthOrder(dtfi.YearMonthPattern, dtfi, out num2))
				{
					result.SetFailure(ParseFailureKind.FormatWithParameter, "Could not determine the order of year, month, and date from '{0}'.", dtfi.YearMonthPattern);
					return false;
				}
				if (num2 == 4)
				{
					int year;
					if (!DateTimeParse.TryAdjustYear(ref result, raw.GetNumber(0), out year) || !DateTimeParse.SetDateYMD(ref result, year, raw.month, 1))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					return true;
				}
			}
			DateTimeParse.GetDefaultYear(ref result, ref styles);
			if (!DateTimeParse.SetDateYMD(ref result, result.Year, raw.month, raw.GetNumber(0)))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			return true;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00016934 File Offset: 0x00014B34
		private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int number = raw.GetNumber(0);
			int number2 = raw.GetNumber(1);
			int num;
			if (!DateTimeParse.GetYearMonthDayOrder(dtfi.ShortDatePattern, dtfi, out num))
			{
				result.SetFailure(ParseFailureKind.FormatWithParameter, "Could not determine the order of year, month, and date from '{0}'.", dtfi.ShortDatePattern);
				return false;
			}
			if (num == 1)
			{
				int year;
				if (DateTimeParse.TryAdjustYear(ref result, number2, out year) && result.calendar.IsValidDay(year, raw.month, number, result.era))
				{
					result.SetDate(year, raw.month, number);
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
				if (DateTimeParse.TryAdjustYear(ref result, number, out year) && result.calendar.IsValidDay(year, raw.month, number2, result.era))
				{
					result.SetDate(year, raw.month, number2);
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (num == 0)
			{
				int year;
				if (DateTimeParse.TryAdjustYear(ref result, number, out year) && result.calendar.IsValidDay(year, raw.month, number2, result.era))
				{
					result.SetDate(year, raw.month, number2);
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
				if (DateTimeParse.TryAdjustYear(ref result, number2, out year) && result.calendar.IsValidDay(year, raw.month, number, result.era))
				{
					result.SetDate(year, raw.month, number);
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (num == 2)
			{
				int year;
				if (DateTimeParse.TryAdjustYear(ref result, number2, out year) && result.calendar.IsValidDay(year, raw.month, number, result.era))
				{
					result.SetDate(year, raw.month, number);
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
				if (DateTimeParse.TryAdjustYear(ref result, number, out year) && result.calendar.IsValidDay(year, raw.month, number2, result.era))
				{
					result.SetDate(year, raw.month, number2);
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00016B50 File Offset: 0x00014D50
		private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int number = raw.GetNumber(0);
			int number2 = raw.GetNumber(1);
			int num;
			if (DateTimeParse.GetYearMonthDayOrder(dtfi.ShortDatePattern, dtfi, out num) && num == 3)
			{
				if (DateTimeParse.SetDateYMD(ref result, raw.year, number2, number))
				{
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (DateTimeParse.SetDateYMD(ref result, raw.year, number, number2))
			{
				result.flags |= ParseFlags.HaveDate;
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00016BE0 File Offset: 0x00014DE0
		private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int number = raw.GetNumber(0);
			int number2 = raw.GetNumber(1);
			int num;
			if (!DateTimeParse.GetYearMonthDayOrder(dtfi.ShortDatePattern, dtfi, out num))
			{
				result.SetFailure(ParseFailureKind.FormatWithParameter, "Could not determine the order of year, month, and date from '{0}'.", dtfi.ShortDatePattern);
				return false;
			}
			if (num == 1 || num == 0)
			{
				if (DateTimeParse.SetDateYMD(ref result, raw.year, number, number2))
				{
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (DateTimeParse.SetDateYMD(ref result, raw.year, number2, number))
			{
				result.flags |= ParseFlags.HaveDate;
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00016C88 File Offset: 0x00014E88
		private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (DateTimeParse.SetDateYMD(ref result, raw.year, raw.month, raw.GetNumber(0)))
			{
				result.flags |= ParseFlags.HaveDate;
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00016CE0 File Offset: 0x00014EE0
		private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (DateTimeParse.SetDateYMD(ref result, raw.year, raw.GetNumber(0), 1))
			{
				result.flags |= ParseFlags.HaveDate;
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00016D34 File Offset: 0x00014F34
		private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (DateTimeParse.SetDateYMD(ref result, raw.year, raw.month, 1))
			{
				result.flags |= ParseFlags.HaveDate;
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00016D84 File Offset: 0x00014F84
		private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw)
		{
			if (raw.timeMark == DateTimeParse.TM.NotSet && dtfi.AMDesignator != null && dtfi.PMDesignator != null)
			{
				if (dtfi.AMDesignator.Length == 0 && dtfi.PMDesignator.Length != 0)
				{
					raw.timeMark = DateTimeParse.TM.AM;
				}
				if (dtfi.PMDesignator.Length == 0 && dtfi.AMDesignator.Length != 0)
				{
					raw.timeMark = DateTimeParse.TM.PM;
				}
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00016DEC File Offset: 0x00014FEC
		private static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark)
		{
			if (timeMark != DateTimeParse.TM.NotSet)
			{
				if (timeMark == DateTimeParse.TM.AM)
				{
					if (hour < 0 || hour > 12)
					{
						return false;
					}
					hour = ((hour == 12) ? 0 : hour);
				}
				else
				{
					if (hour < 0 || hour > 23)
					{
						return false;
					}
					if (hour < 12)
					{
						hour += 12;
					}
				}
			}
			return true;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00016E2C File Offset: 0x0001502C
		private static bool GetTimeOfN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			if ((result.flags & ParseFlags.HaveTime) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (raw.timeMark == DateTimeParse.TM.NotSet)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			result.Hour = raw.GetNumber(0);
			result.flags |= ParseFlags.HaveTime;
			return true;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00016E6C File Offset: 0x0001506C
		private static bool GetTimeOfNN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			if ((result.flags & ParseFlags.HaveTime) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			result.Hour = raw.GetNumber(0);
			result.Minute = raw.GetNumber(1);
			result.flags |= ParseFlags.HaveTime;
			return true;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00016EA8 File Offset: 0x000150A8
		private static bool GetTimeOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			if ((result.flags & ParseFlags.HaveTime) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			result.Hour = raw.GetNumber(0);
			result.Minute = raw.GetNumber(1);
			result.Second = raw.GetNumber(2);
			result.flags |= ParseFlags.HaveTime;
			return true;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00016EFC File Offset: 0x000150FC
		private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			if (raw.numCount != 1 || result.Day != -1)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			result.Day = raw.GetNumber(0);
			return true;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00016F28 File Offset: 0x00015128
		private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			if (result.Month == -1)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (result.Year != -1)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (!DateTimeParse.TryAdjustYear(ref result, raw.GetNumber(0), out result.Year))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			result.Day = 1;
			return true;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00016F7C File Offset: 0x0001517C
		private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveYear) != (ParseFlags)0)
			{
				if ((result.flags & ParseFlags.HaveMonth) == (ParseFlags)0 && (result.flags & ParseFlags.HaveDay) == (ParseFlags)0 && DateTimeParse.TryAdjustYear(ref result, raw.year, out result.Year) && DateTimeParse.SetDateYMD(ref result, result.Year, raw.GetNumber(0), raw.GetNumber(1)))
				{
					return true;
				}
			}
			else if ((result.flags & ParseFlags.HaveMonth) != (ParseFlags)0 && (result.flags & ParseFlags.HaveYear) == (ParseFlags)0 && (result.flags & ParseFlags.HaveDay) == (ParseFlags)0)
			{
				int num;
				if (!DateTimeParse.GetYearMonthDayOrder(dtfi.ShortDatePattern, dtfi, out num))
				{
					result.SetFailure(ParseFailureKind.FormatWithParameter, "Could not determine the order of year, month, and date from '{0}'.", dtfi.ShortDatePattern);
					return false;
				}
				int year;
				if (num == 0)
				{
					if (DateTimeParse.TryAdjustYear(ref result, raw.GetNumber(0), out year) && DateTimeParse.SetDateYMD(ref result, year, result.Month, raw.GetNumber(1)))
					{
						return true;
					}
				}
				else if (DateTimeParse.TryAdjustYear(ref result, raw.GetNumber(1), out year) && DateTimeParse.SetDateYMD(ref result, year, result.Month, raw.GetNumber(0)))
				{
					return true;
				}
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0001708C File Offset: 0x0001528C
		private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok)
		{
			TokenType suffix = dtok.suffix;
			if (suffix <= TokenType.SEP_DaySuff)
			{
				if (suffix != TokenType.SEP_YearSuff)
				{
					if (suffix != TokenType.SEP_MonthSuff)
					{
						if (suffix == TokenType.SEP_DaySuff)
						{
							if ((result.flags & ParseFlags.HaveDay) != (ParseFlags)0)
							{
								return false;
							}
							result.flags |= ParseFlags.HaveDay;
							result.Day = dtok.num;
						}
					}
					else
					{
						if ((result.flags & ParseFlags.HaveMonth) != (ParseFlags)0)
						{
							return false;
						}
						result.flags |= ParseFlags.HaveMonth;
						result.Month = (raw.month = dtok.num);
					}
				}
				else
				{
					if ((result.flags & ParseFlags.HaveYear) != (ParseFlags)0)
					{
						return false;
					}
					result.flags |= ParseFlags.HaveYear;
					result.Year = (raw.year = dtok.num);
				}
			}
			else if (suffix != TokenType.SEP_HourSuff)
			{
				if (suffix != TokenType.SEP_MinuteSuff)
				{
					if (suffix == TokenType.SEP_SecondSuff)
					{
						if ((result.flags & ParseFlags.HaveSecond) != (ParseFlags)0)
						{
							return false;
						}
						result.flags |= ParseFlags.HaveSecond;
						result.Second = dtok.num;
					}
				}
				else
				{
					if ((result.flags & ParseFlags.HaveMinute) != (ParseFlags)0)
					{
						return false;
					}
					result.flags |= ParseFlags.HaveMinute;
					result.Minute = dtok.num;
				}
			}
			else
			{
				if ((result.flags & ParseFlags.HaveHour) != (ParseFlags)0)
				{
					return false;
				}
				result.flags |= ParseFlags.HaveHour;
				result.Hour = dtok.num;
			}
			return true;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000171E8 File Offset: 0x000153E8
		internal static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			switch (dps)
			{
			case DateTimeParse.DS.DX_MN:
			case DateTimeParse.DS.DX_NM:
				DateTimeParse.GetDefaultYear(ref result, ref styles);
				if (!dtfi.YearMonthAdjustment(ref result.Year, ref raw.month, true))
				{
					result.SetFailure(ParseFailureKind.FormatBadDateTimeCalendar, "The DateTime represented by the string is not supported in calendar {0}.");
					return false;
				}
				if (!GlobalizationMode.Invariant && !DateTimeParse.GetHebrewDayOfNM(ref result, ref raw, dtfi))
				{
					return false;
				}
				goto IL_1BC;
			case DateTimeParse.DS.DX_MNN:
				raw.year = raw.GetNumber(1);
				if (!dtfi.YearMonthAdjustment(ref raw.year, ref raw.month, true))
				{
					result.SetFailure(ParseFailureKind.FormatBadDateTimeCalendar, "The DateTime represented by the string is not supported in calendar {0}.");
					return false;
				}
				if (!DateTimeParse.GetDayOfMNN(ref result, ref raw, dtfi))
				{
					return false;
				}
				goto IL_1BC;
			case DateTimeParse.DS.DX_YMN:
				if (!dtfi.YearMonthAdjustment(ref raw.year, ref raw.month, true))
				{
					result.SetFailure(ParseFailureKind.FormatBadDateTimeCalendar, "The DateTime represented by the string is not supported in calendar {0}.");
					return false;
				}
				if (!DateTimeParse.GetDayOfYMN(ref result, ref raw))
				{
					return false;
				}
				goto IL_1BC;
			case DateTimeParse.DS.DX_YM:
				if (!dtfi.YearMonthAdjustment(ref raw.year, ref raw.month, true))
				{
					result.SetFailure(ParseFailureKind.FormatBadDateTimeCalendar, "The DateTime represented by the string is not supported in calendar {0}.");
					return false;
				}
				if (!DateTimeParse.GetDayOfYM(ref result, ref raw))
				{
					return false;
				}
				goto IL_1BC;
			case DateTimeParse.DS.TX_N:
				if (!DateTimeParse.GetTimeOfN(ref result, ref raw))
				{
					return false;
				}
				goto IL_1BC;
			case DateTimeParse.DS.TX_NN:
				if (!DateTimeParse.GetTimeOfNN(ref result, ref raw))
				{
					return false;
				}
				goto IL_1BC;
			case DateTimeParse.DS.TX_NNN:
				if (!DateTimeParse.GetTimeOfNNN(ref result, ref raw))
				{
					return false;
				}
				goto IL_1BC;
			case DateTimeParse.DS.DX_NNY:
				if (raw.year < 1000)
				{
					raw.year += 5000;
				}
				if (!DateTimeParse.GetDayOfNNY(ref result, ref raw, dtfi))
				{
					return false;
				}
				if (!dtfi.YearMonthAdjustment(ref result.Year, ref raw.month, true))
				{
					result.SetFailure(ParseFailureKind.FormatBadDateTimeCalendar, "The DateTime represented by the string is not supported in calendar {0}.");
					return false;
				}
				goto IL_1BC;
			}
			result.SetBadDateTimeFailure();
			return false;
			IL_1BC:
			if (dps > DateTimeParse.DS.ERROR)
			{
				raw.numCount = 0;
			}
			return true;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000173C0 File Offset: 0x000155C0
		internal static bool ProcessTerminalState(DateTimeParse.DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			bool flag = true;
			switch (dps)
			{
			case DateTimeParse.DS.DX_NN:
				flag = DateTimeParse.GetDayOfNN(ref result, ref styles, ref raw, dtfi);
				break;
			case DateTimeParse.DS.DX_NNN:
				flag = DateTimeParse.GetDayOfNNN(ref result, ref raw, dtfi);
				break;
			case DateTimeParse.DS.DX_MN:
				flag = DateTimeParse.GetDayOfMN(ref result, ref styles, ref raw, dtfi);
				break;
			case DateTimeParse.DS.DX_NM:
				flag = DateTimeParse.GetDayOfNM(ref result, ref styles, ref raw, dtfi);
				break;
			case DateTimeParse.DS.DX_MNN:
				flag = DateTimeParse.GetDayOfMNN(ref result, ref raw, dtfi);
				break;
			case DateTimeParse.DS.DX_DS:
				flag = true;
				break;
			case DateTimeParse.DS.DX_DSN:
				flag = DateTimeParse.GetDateOfDSN(ref result, ref raw);
				break;
			case DateTimeParse.DS.DX_NDS:
				flag = DateTimeParse.GetDateOfNDS(ref result, ref raw);
				break;
			case DateTimeParse.DS.DX_NNDS:
				flag = DateTimeParse.GetDateOfNNDS(ref result, ref raw, dtfi);
				break;
			case DateTimeParse.DS.DX_YNN:
				flag = DateTimeParse.GetDayOfYNN(ref result, ref raw, dtfi);
				break;
			case DateTimeParse.DS.DX_YMN:
				flag = DateTimeParse.GetDayOfYMN(ref result, ref raw);
				break;
			case DateTimeParse.DS.DX_YN:
				flag = DateTimeParse.GetDayOfYN(ref result, ref raw);
				break;
			case DateTimeParse.DS.DX_YM:
				flag = DateTimeParse.GetDayOfYM(ref result, ref raw);
				break;
			case DateTimeParse.DS.TX_N:
				flag = DateTimeParse.GetTimeOfN(ref result, ref raw);
				break;
			case DateTimeParse.DS.TX_NN:
				flag = DateTimeParse.GetTimeOfNN(ref result, ref raw);
				break;
			case DateTimeParse.DS.TX_NNN:
				flag = DateTimeParse.GetTimeOfNNN(ref result, ref raw);
				break;
			case DateTimeParse.DS.TX_TS:
				flag = true;
				break;
			case DateTimeParse.DS.DX_NNY:
				flag = DateTimeParse.GetDayOfNNY(ref result, ref raw, dtfi);
				break;
			}
			if (!flag)
			{
				return false;
			}
			if (dps > DateTimeParse.DS.ERROR)
			{
				raw.numCount = 0;
			}
			return true;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00017514 File Offset: 0x00015714
		internal static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			if (DateTimeParse.TryParse(s, dtfi, styles, ref dateTimeResult))
			{
				return dateTimeResult.parsedDate;
			}
			throw DateTimeParse.GetDateTimeParseException(ref dateTimeResult);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0001754C File Offset: 0x0001574C
		internal static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			dateTimeResult.flags |= ParseFlags.CaptureOffset;
			if (DateTimeParse.TryParse(s, dtfi, styles, ref dateTimeResult))
			{
				offset = dateTimeResult.timeZoneOffset;
				return dateTimeResult.parsedDate;
			}
			throw DateTimeParse.GetDateTimeParseException(ref dateTimeResult);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000175A0 File Offset: 0x000157A0
		internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result)
		{
			result = DateTime.MinValue;
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			if (DateTimeParse.TryParse(s, dtfi, styles, ref dateTimeResult))
			{
				result = dateTimeResult.parsedDate;
				return true;
			}
			return false;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000175E4 File Offset: 0x000157E4
		internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result, out TimeSpan offset)
		{
			result = DateTime.MinValue;
			offset = TimeSpan.Zero;
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			dateTimeResult.flags |= ParseFlags.CaptureOffset;
			if (DateTimeParse.TryParse(s, dtfi, styles, ref dateTimeResult))
			{
				result = dateTimeResult.parsedDate;
				offset = dateTimeResult.timeZoneOffset;
				return true;
			}
			return false;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00017650 File Offset: 0x00015850
		internal unsafe static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result)
		{
			if (s.Length == 0)
			{
				result.SetFailure(ParseFailureKind.FormatWithParameter, "String was not recognized as a valid DateTime.");
				return false;
			}
			DateTimeParse.DS ds = DateTimeParse.DS.BEGIN;
			bool flag = false;
			DateTimeToken dateTimeToken = default(DateTimeToken);
			dateTimeToken.suffix = TokenType.SEP_Unk;
			DateTimeRawInfo dateTimeRawInfo = default(DateTimeRawInfo);
			int* numberBuffer = stackalloc int[(UIntPtr)12];
			dateTimeRawInfo.Init(numberBuffer);
			dateTimeRawInfo.hasSameDateAndTimeSeparators = dtfi.DateSeparator.Equals(dtfi.TimeSeparator, StringComparison.Ordinal);
			result.calendar = dtfi.Calendar;
			result.era = 0;
			__DTString _DTString = new __DTString(s, dtfi);
			_DTString.GetNext();
			while (DateTimeParse.Lex(ds, ref _DTString, ref dateTimeToken, ref dateTimeRawInfo, ref result, ref dtfi, styles))
			{
				if (dateTimeToken.dtt != DateTimeParse.DTT.Unk)
				{
					if (dateTimeToken.suffix != TokenType.SEP_Unk)
					{
						if (!DateTimeParse.ProcessDateTimeSuffix(ref result, ref dateTimeRawInfo, ref dateTimeToken))
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						dateTimeToken.suffix = TokenType.SEP_Unk;
					}
					if (dateTimeToken.dtt == DateTimeParse.DTT.NumLocalTimeMark)
					{
						if (ds == DateTimeParse.DS.D_YNd || ds == DateTimeParse.DS.D_YN)
						{
							return DateTimeParse.ParseISO8601(ref dateTimeRawInfo, ref _DTString, styles, ref result);
						}
						result.SetBadDateTimeFailure();
						return false;
					}
					else
					{
						if (dateTimeRawInfo.hasSameDateAndTimeSeparators)
						{
							if (dateTimeToken.dtt == DateTimeParse.DTT.YearEnd || dateTimeToken.dtt == DateTimeParse.DTT.YearSpace || dateTimeToken.dtt == DateTimeParse.DTT.YearDateSep)
							{
								if (ds == DateTimeParse.DS.T_Nt)
								{
									ds = DateTimeParse.DS.D_Nd;
								}
								if (ds == DateTimeParse.DS.T_NNt)
								{
									ds = DateTimeParse.DS.D_NNd;
								}
							}
							bool flag2 = _DTString.AtEnd();
							if (DateTimeParse.dateParsingStates[(int)ds][(int)dateTimeToken.dtt] == DateTimeParse.DS.ERROR || flag2)
							{
								DateTimeParse.DTT dtt = dateTimeToken.dtt;
								switch (dtt)
								{
								case DateTimeParse.DTT.NumDatesep:
									dateTimeToken.dtt = (flag2 ? DateTimeParse.DTT.NumEnd : DateTimeParse.DTT.NumSpace);
									break;
								case DateTimeParse.DTT.NumTimesep:
									dateTimeToken.dtt = (flag2 ? DateTimeParse.DTT.NumEnd : DateTimeParse.DTT.NumSpace);
									break;
								case DateTimeParse.DTT.MonthEnd:
								case DateTimeParse.DTT.MonthSpace:
									break;
								case DateTimeParse.DTT.MonthDatesep:
									dateTimeToken.dtt = (flag2 ? DateTimeParse.DTT.MonthEnd : DateTimeParse.DTT.MonthSpace);
									break;
								default:
									if (dtt == DateTimeParse.DTT.YearDateSep)
									{
										dateTimeToken.dtt = (flag2 ? DateTimeParse.DTT.YearEnd : DateTimeParse.DTT.YearSpace);
									}
									break;
								}
							}
						}
						ds = DateTimeParse.dateParsingStates[(int)ds][(int)dateTimeToken.dtt];
						if (ds == DateTimeParse.DS.ERROR)
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						if (ds > DateTimeParse.DS.ERROR)
						{
							if ((dtfi.FormatFlags & DateTimeFormatFlags.UseHebrewRule) != DateTimeFormatFlags.None)
							{
								if (!GlobalizationMode.Invariant && !DateTimeParse.ProcessHebrewTerminalState(ds, ref _DTString, ref result, ref styles, ref dateTimeRawInfo, dtfi))
								{
									return false;
								}
							}
							else if (!DateTimeParse.ProcessTerminalState(ds, ref _DTString, ref result, ref styles, ref dateTimeRawInfo, dtfi))
							{
								return false;
							}
							flag = true;
							ds = DateTimeParse.DS.BEGIN;
						}
					}
				}
				if (dateTimeToken.dtt == DateTimeParse.DTT.End || dateTimeToken.dtt == DateTimeParse.DTT.NumEnd || dateTimeToken.dtt == DateTimeParse.DTT.MonthEnd)
				{
					if (!flag)
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					DateTimeParse.AdjustTimeMark(dtfi, ref dateTimeRawInfo);
					if (!DateTimeParse.AdjustHour(ref result.Hour, dateTimeRawInfo.timeMark))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					bool bTimeOnly = result.Year == -1 && result.Month == -1 && result.Day == -1;
					if (!DateTimeParse.CheckDefaultDateTime(ref result, ref result.calendar, styles))
					{
						return false;
					}
					DateTime dateTime;
					if (!result.calendar.TryToDateTime(result.Year, result.Month, result.Day, result.Hour, result.Minute, result.Second, 0, result.era, out dateTime))
					{
						result.SetFailure(ParseFailureKind.FormatBadDateTimeCalendar, "The DateTime represented by the string is not supported in calendar {0}.");
						return false;
					}
					if (dateTimeRawInfo.fraction > 0.0)
					{
						dateTime = dateTime.AddTicks((long)Math.Round(dateTimeRawInfo.fraction * 10000000.0));
					}
					if (dateTimeRawInfo.dayOfWeek != -1 && dateTimeRawInfo.dayOfWeek != (int)result.calendar.GetDayOfWeek(dateTime))
					{
						result.SetFailure(ParseFailureKind.FormatWithOriginalDateTime, "String was not recognized as a valid DateTime because the day of week was incorrect.");
						return false;
					}
					result.parsedDate = dateTime;
					return DateTimeParse.DetermineTimeZoneAdjustments(ref _DTString, ref result, styles, bTimeOnly);
				}
			}
			return false;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000179B4 File Offset: 0x00015BB4
		private static bool DetermineTimeZoneAdjustments(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly)
		{
			if ((result.flags & ParseFlags.CaptureOffset) != (ParseFlags)0)
			{
				return DateTimeParse.DateTimeOffsetTimeZonePostProcessing(ref str, ref result, styles);
			}
			long ticks = result.timeZoneOffset.Ticks;
			if (ticks < -504000000000L || ticks > 504000000000L)
			{
				result.SetFailure(ParseFailureKind.FormatWithOriginalDateTime, "The time zone offset must be within plus or minus 14 hours.");
				return false;
			}
			if ((result.flags & ParseFlags.TimeZoneUsed) == (ParseFlags)0)
			{
				if ((styles & DateTimeStyles.AssumeLocal) != DateTimeStyles.None)
				{
					if ((styles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.None)
					{
						result.parsedDate = DateTime.SpecifyKind(result.parsedDate, DateTimeKind.Local);
						return true;
					}
					result.flags |= ParseFlags.TimeZoneUsed;
					result.timeZoneOffset = TimeZoneInfo.GetLocalUtcOffset(result.parsedDate, TimeZoneInfoOptions.NoThrowOnInvalidTime);
				}
				else
				{
					if ((styles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.None)
					{
						return true;
					}
					if ((styles & DateTimeStyles.AdjustToUniversal) != DateTimeStyles.None)
					{
						result.parsedDate = DateTime.SpecifyKind(result.parsedDate, DateTimeKind.Utc);
						return true;
					}
					result.flags |= ParseFlags.TimeZoneUsed;
					result.timeZoneOffset = TimeSpan.Zero;
				}
			}
			if ((styles & DateTimeStyles.RoundtripKind) != DateTimeStyles.None && (result.flags & ParseFlags.TimeZoneUtc) != (ParseFlags)0)
			{
				result.parsedDate = DateTime.SpecifyKind(result.parsedDate, DateTimeKind.Utc);
				return true;
			}
			if ((styles & DateTimeStyles.AdjustToUniversal) != DateTimeStyles.None)
			{
				return DateTimeParse.AdjustTimeZoneToUniversal(ref result);
			}
			return DateTimeParse.AdjustTimeZoneToLocal(ref result, bTimeOnly);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00017ADC File Offset: 0x00015CDC
		private static bool DateTimeOffsetTimeZonePostProcessing(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles)
		{
			if ((result.flags & ParseFlags.TimeZoneUsed) == (ParseFlags)0)
			{
				if ((styles & DateTimeStyles.AssumeUniversal) != DateTimeStyles.None)
				{
					result.timeZoneOffset = TimeSpan.Zero;
				}
				else
				{
					result.timeZoneOffset = TimeZoneInfo.GetLocalUtcOffset(result.parsedDate, TimeZoneInfoOptions.NoThrowOnInvalidTime);
				}
			}
			long ticks = result.timeZoneOffset.Ticks;
			long num = result.parsedDate.Ticks - ticks;
			if (num < 0L || num > 3155378975999999999L)
			{
				result.SetFailure(ParseFailureKind.FormatWithOriginalDateTime, "The UTC representation of the date falls outside the year range 1-9999.");
				return false;
			}
			if (ticks < -504000000000L || ticks > 504000000000L)
			{
				result.SetFailure(ParseFailureKind.FormatWithOriginalDateTime, "The time zone offset must be within plus or minus 14 hours.");
				return false;
			}
			if ((styles & DateTimeStyles.AdjustToUniversal) != DateTimeStyles.None)
			{
				if ((result.flags & ParseFlags.TimeZoneUsed) == (ParseFlags)0 && (styles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.None)
				{
					bool result2 = DateTimeParse.AdjustTimeZoneToUniversal(ref result);
					result.timeZoneOffset = TimeSpan.Zero;
					return result2;
				}
				result.parsedDate = new DateTime(num, DateTimeKind.Utc);
				result.timeZoneOffset = TimeSpan.Zero;
			}
			return true;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00017BC0 File Offset: 0x00015DC0
		private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result)
		{
			long num = result.parsedDate.Ticks;
			num -= result.timeZoneOffset.Ticks;
			if (num < 0L)
			{
				num += 864000000000L;
			}
			if (num < 0L || num > 3155378975999999999L)
			{
				result.SetFailure(ParseFailureKind.FormatWithOriginalDateTime, "The DateTime represented by the string is out of range.");
				return false;
			}
			result.parsedDate = new DateTime(num, DateTimeKind.Utc);
			return true;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00017C28 File Offset: 0x00015E28
		private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly)
		{
			long num = result.parsedDate.Ticks;
			TimeZoneInfo local = TimeZoneInfo.Local;
			bool isAmbiguousDst = false;
			if (num < 864000000000L)
			{
				num -= result.timeZoneOffset.Ticks;
				num += local.GetUtcOffset(bTimeOnly ? DateTime.Now : result.parsedDate, TimeZoneInfoOptions.NoThrowOnInvalidTime).Ticks;
				if (num < 0L)
				{
					num += 864000000000L;
				}
			}
			else
			{
				num -= result.timeZoneOffset.Ticks;
				if (num < 0L || num > 3155378975999999999L)
				{
					num += local.GetUtcOffset(result.parsedDate, TimeZoneInfoOptions.NoThrowOnInvalidTime).Ticks;
				}
				else
				{
					DateTime time = new DateTime(num, DateTimeKind.Utc);
					bool flag = false;
					num += TimeZoneInfo.GetUtcOffsetFromUtc(time, TimeZoneInfo.Local, out flag, out isAmbiguousDst).Ticks;
				}
			}
			if (num < 0L || num > 3155378975999999999L)
			{
				result.parsedDate = DateTime.MinValue;
				result.SetFailure(ParseFailureKind.FormatWithOriginalDateTime, "The DateTime represented by the string is out of range.");
				return false;
			}
			result.parsedDate = new DateTime(num, DateTimeKind.Local, isAmbiguousDst);
			return true;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00017D34 File Offset: 0x00015F34
		private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result)
		{
			if (raw.year >= 0 && raw.GetNumber(0) >= 0)
			{
				raw.GetNumber(1);
			}
			str.Index--;
			int second = 0;
			double num = 0.0;
			str.SkipWhiteSpaces();
			int hour;
			if (!DateTimeParse.ParseDigits(ref str, 2, out hour))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			str.SkipWhiteSpaces();
			if (!str.Match(':'))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			str.SkipWhiteSpaces();
			int minute;
			if (!DateTimeParse.ParseDigits(ref str, 2, out minute))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			str.SkipWhiteSpaces();
			if (str.Match(':'))
			{
				str.SkipWhiteSpaces();
				if (!DateTimeParse.ParseDigits(ref str, 2, out second))
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				if (str.Match('.'))
				{
					if (!DateTimeParse.ParseFraction(ref str, out num))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					str.Index--;
				}
				str.SkipWhiteSpaces();
			}
			if (str.GetNext())
			{
				char @char = str.GetChar();
				if (@char == '+' || @char == '-')
				{
					result.flags |= ParseFlags.TimeZoneUsed;
					if (!DateTimeParse.ParseTimeZone(ref str, ref result.timeZoneOffset))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
				}
				else if (@char == 'Z' || @char == 'z')
				{
					result.flags |= ParseFlags.TimeZoneUsed;
					result.timeZoneOffset = TimeSpan.Zero;
					result.flags |= ParseFlags.TimeZoneUtc;
				}
				else
				{
					str.Index--;
				}
				str.SkipWhiteSpaces();
				if (str.Match('#'))
				{
					if (!DateTimeParse.VerifyValidPunctuation(ref str))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					str.SkipWhiteSpaces();
				}
				if (str.Match('\0') && !DateTimeParse.VerifyValidPunctuation(ref str))
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				if (str.GetNext())
				{
					result.SetBadDateTimeFailure();
					return false;
				}
			}
			DateTime parsedDate;
			if (!GregorianCalendar.GetDefaultInstance().TryToDateTime(raw.year, raw.GetNumber(0), raw.GetNumber(1), hour, minute, second, 0, result.era, out parsedDate))
			{
				result.SetFailure(ParseFailureKind.FormatBadDateTimeCalendar, "The DateTime represented by the string is not supported in calendar {0}.");
				return false;
			}
			parsedDate = parsedDate.AddTicks((long)Math.Round(num * 10000000.0));
			result.parsedDate = parsedDate;
			return DateTimeParse.DetermineTimeZoneAdjustments(ref str, ref result, styles, false);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00017F54 File Offset: 0x00016154
		internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number)
		{
			number = 0;
			HebrewNumberParsingContext hebrewNumberParsingContext = new HebrewNumberParsingContext(0);
			HebrewNumberParsingState hebrewNumberParsingState = HebrewNumberParsingState.ContinueParsing;
			while (hebrewNumberParsingState == HebrewNumberParsingState.ContinueParsing && str.GetNext())
			{
				hebrewNumberParsingState = HebrewNumber.ParseByChar(str.GetChar(), ref hebrewNumberParsingContext);
			}
			if (hebrewNumberParsingState == HebrewNumberParsingState.FoundEndOfHebrewNumber)
			{
				number = hebrewNumberParsingContext.result;
				return true;
			}
			return false;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00017F99 File Offset: 0x00016199
		internal static bool ParseDigits(ref __DTString str, int digitLen, out int result)
		{
			if (digitLen == 1)
			{
				return DateTimeParse.ParseDigits(ref str, 1, 2, out result);
			}
			return DateTimeParse.ParseDigits(ref str, digitLen, digitLen, out result);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00017FB4 File Offset: 0x000161B4
		internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result)
		{
			int num = 0;
			int index = str.Index;
			int i;
			for (i = 0; i < maxDigitLen; i++)
			{
				if (!str.GetNextDigit())
				{
					str.Index--;
					break;
				}
				num = num * 10 + str.GetDigit();
			}
			result = num;
			if (i < minDigitLen)
			{
				str.Index = index;
				return false;
			}
			return true;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00018008 File Offset: 0x00016208
		private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result)
		{
			if (!str.GetNextDigit())
			{
				str.Index--;
				return false;
			}
			result = (double)str.GetDigit();
			int i;
			for (i = 1; i < maxDigitLen; i++)
			{
				if (!str.GetNextDigit())
				{
					str.Index--;
					break;
				}
				result = result * 10.0 + (double)str.GetDigit();
			}
			result /= (double)TimeSpanParse.Pow10(i);
			return i == maxDigitLen;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0001807C File Offset: 0x0001627C
		private static bool ParseSign(ref __DTString str, ref bool result)
		{
			if (!str.GetNext())
			{
				return false;
			}
			char @char = str.GetChar();
			if (@char == '+')
			{
				result = true;
				return true;
			}
			if (@char == '-')
			{
				result = false;
				return true;
			}
			return false;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000180B0 File Offset: 0x000162B0
		private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result)
		{
			bool flag = true;
			int num = 0;
			int hours;
			if (len - 1 <= 1)
			{
				if (!DateTimeParse.ParseSign(ref str, ref flag))
				{
					return false;
				}
				if (!DateTimeParse.ParseDigits(ref str, len, out hours))
				{
					return false;
				}
			}
			else
			{
				if (!DateTimeParse.ParseSign(ref str, ref flag))
				{
					return false;
				}
				if (!DateTimeParse.ParseDigits(ref str, 1, out hours))
				{
					return false;
				}
				if (str.Match(":"))
				{
					if (!DateTimeParse.ParseDigits(ref str, 2, out num))
					{
						return false;
					}
				}
				else
				{
					str.Index--;
					if (!DateTimeParse.ParseDigits(ref str, 2, out num))
					{
						return false;
					}
				}
			}
			if (num < 0 || num >= 60)
			{
				return false;
			}
			result = new TimeSpan(hours, num, 0);
			if (!flag)
			{
				result = result.Negate();
			}
			return true;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00018154 File Offset: 0x00016354
		private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			int num = 0;
			result = -1;
			if (str.GetNext())
			{
				int num2 = (dtfi.GetMonthName(13).Length == 0) ? 12 : 13;
				for (int i = 1; i <= num2; i++)
				{
					string abbreviatedMonthName = dtfi.GetAbbreviatedMonthName(i);
					int length = abbreviatedMonthName.Length;
					if ((dtfi.HasSpacesInMonthNames ? str.MatchSpecifiedWords(abbreviatedMonthName, false, ref length) : str.MatchSpecifiedWord(abbreviatedMonthName)) && length > num)
					{
						num = length;
						result = i;
					}
				}
				if ((dtfi.FormatFlags & DateTimeFormatFlags.UseLeapYearMonth) != DateTimeFormatFlags.None)
				{
					int num3 = str.MatchLongestWords(dtfi.internalGetLeapYearMonthNames(), ref num);
					if (num3 >= 0)
					{
						result = num3 + 1;
					}
				}
			}
			if (result > 0)
			{
				str.Index += num - 1;
				return true;
			}
			return false;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00018204 File Offset: 0x00016404
		private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			int num = 0;
			result = -1;
			if (str.GetNext())
			{
				int num2 = (dtfi.GetMonthName(13).Length == 0) ? 12 : 13;
				for (int i = 1; i <= num2; i++)
				{
					string monthName = dtfi.GetMonthName(i);
					int length = monthName.Length;
					if ((dtfi.HasSpacesInMonthNames ? str.MatchSpecifiedWords(monthName, false, ref length) : str.MatchSpecifiedWord(monthName)) && length > num)
					{
						num = length;
						result = i;
					}
				}
				if ((dtfi.FormatFlags & DateTimeFormatFlags.UseGenitiveMonth) != DateTimeFormatFlags.None)
				{
					int num3 = str.MatchLongestWords(dtfi.MonthGenitiveNames, ref num);
					if (num3 >= 0)
					{
						result = num3 + 1;
					}
				}
				if ((dtfi.FormatFlags & DateTimeFormatFlags.UseLeapYearMonth) != DateTimeFormatFlags.None)
				{
					int num4 = str.MatchLongestWords(dtfi.internalGetLeapYearMonthNames(), ref num);
					if (num4 >= 0)
					{
						result = num4 + 1;
					}
				}
			}
			if (result > 0)
			{
				str.Index += num - 1;
				return true;
			}
			return false;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x000182DC File Offset: 0x000164DC
		private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			int num = 0;
			result = -1;
			if (str.GetNext())
			{
				for (DayOfWeek dayOfWeek = DayOfWeek.Sunday; dayOfWeek <= DayOfWeek.Saturday; dayOfWeek++)
				{
					string abbreviatedDayName = dtfi.GetAbbreviatedDayName(dayOfWeek);
					int length = abbreviatedDayName.Length;
					if ((dtfi.HasSpacesInDayNames ? str.MatchSpecifiedWords(abbreviatedDayName, false, ref length) : str.MatchSpecifiedWord(abbreviatedDayName)) && length > num)
					{
						num = length;
						result = (int)dayOfWeek;
					}
				}
			}
			if (result >= 0)
			{
				str.Index += num - 1;
				return true;
			}
			return false;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0001834C File Offset: 0x0001654C
		private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			int num = 0;
			result = -1;
			if (str.GetNext())
			{
				for (DayOfWeek dayOfWeek = DayOfWeek.Sunday; dayOfWeek <= DayOfWeek.Saturday; dayOfWeek++)
				{
					string dayName = dtfi.GetDayName(dayOfWeek);
					int length = dayName.Length;
					if ((dtfi.HasSpacesInDayNames ? str.MatchSpecifiedWords(dayName, false, ref length) : str.MatchSpecifiedWord(dayName)) && length > num)
					{
						num = length;
						result = (int)dayOfWeek;
					}
				}
			}
			if (result >= 0)
			{
				str.Index += num - 1;
				return true;
			}
			return false;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000183BC File Offset: 0x000165BC
		private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			if (str.GetNext())
			{
				int[] eras = dtfi.Calendar.Eras;
				if (eras != null)
				{
					for (int i = 0; i < eras.Length; i++)
					{
						string text = dtfi.GetEraName(eras[i]);
						if (str.MatchSpecifiedWord(text))
						{
							str.Index += text.Length - 1;
							result = eras[i];
							return true;
						}
						text = dtfi.GetAbbreviatedEraName(eras[i]);
						if (str.MatchSpecifiedWord(text))
						{
							str.Index += text.Length - 1;
							result = eras[i];
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00018448 File Offset: 0x00016648
		private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result)
		{
			result = DateTimeParse.TM.NotSet;
			if (dtfi.AMDesignator.Length == 0)
			{
				result = DateTimeParse.TM.AM;
			}
			if (dtfi.PMDesignator.Length == 0)
			{
				result = DateTimeParse.TM.PM;
			}
			if (str.GetNext())
			{
				string text = dtfi.AMDesignator;
				if (text.Length > 0 && str.MatchSpecifiedWord(text))
				{
					str.Index += text.Length - 1;
					result = DateTimeParse.TM.AM;
					return true;
				}
				text = dtfi.PMDesignator;
				if (text.Length > 0 && str.MatchSpecifiedWord(text))
				{
					str.Index += text.Length - 1;
					result = DateTimeParse.TM.PM;
					return true;
				}
				str.Index--;
			}
			return result != DateTimeParse.TM.NotSet;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000184F4 File Offset: 0x000166F4
		private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result)
		{
			if (str.GetNext())
			{
				string amdesignator = dtfi.AMDesignator;
				if (amdesignator.Length > 0 && str.GetChar() == amdesignator[0])
				{
					result = DateTimeParse.TM.AM;
					return true;
				}
				string pmdesignator = dtfi.PMDesignator;
				if (pmdesignator.Length > 0 && str.GetChar() == pmdesignator[0])
				{
					result = DateTimeParse.TM.PM;
					return true;
				}
			}
			return false;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00018552 File Offset: 0x00016752
		private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result)
		{
			if (currentValue == -1)
			{
				currentValue = newValue;
				return true;
			}
			if (newValue != currentValue)
			{
				result.SetFailure(ParseFailureKind.FormatWithParameter, "DateTime pattern '{0}' appears more than once with different values.", patternChar);
				return false;
			}
			return true;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00018578 File Offset: 0x00016778
		private static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles)
		{
			if ((result.flags & ParseFlags.CaptureOffset) != (ParseFlags)0)
			{
				if ((result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0)
				{
					return new DateTime(DateTime.UtcNow.Ticks + result.timeZoneOffset.Ticks, DateTimeKind.Unspecified);
				}
				if ((styles & DateTimeStyles.AssumeUniversal) != DateTimeStyles.None)
				{
					return DateTime.UtcNow;
				}
			}
			return DateTime.Now;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000185D4 File Offset: 0x000167D4
		private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles)
		{
			if ((result.flags & ParseFlags.CaptureOffset) != (ParseFlags)0 && (result.Month != -1 || result.Day != -1) && (result.Year == -1 || (result.flags & ParseFlags.YearDefault) != (ParseFlags)0) && (result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0)
			{
				result.SetFailure(ParseFailureKind.FormatWithOriginalDateTime, "There must be at least a partial date with a year present in the input.");
				return false;
			}
			if (result.Year == -1 || result.Month == -1 || result.Day == -1)
			{
				DateTime dateTimeNow = DateTimeParse.GetDateTimeNow(ref result, ref styles);
				if (result.Month == -1 && result.Day == -1)
				{
					if (result.Year == -1)
					{
						if ((styles & DateTimeStyles.NoCurrentDateDefault) != DateTimeStyles.None)
						{
							cal = GregorianCalendar.GetDefaultInstance();
							result.Year = (result.Month = (result.Day = 1));
						}
						else
						{
							result.Year = cal.GetYear(dateTimeNow);
							result.Month = cal.GetMonth(dateTimeNow);
							result.Day = cal.GetDayOfMonth(dateTimeNow);
						}
					}
					else
					{
						result.Month = 1;
						result.Day = 1;
					}
				}
				else
				{
					if (result.Year == -1)
					{
						result.Year = cal.GetYear(dateTimeNow);
					}
					if (result.Month == -1)
					{
						result.Month = 1;
					}
					if (result.Day == -1)
					{
						result.Day = 1;
					}
				}
			}
			if (result.Hour == -1)
			{
				result.Hour = 0;
			}
			if (result.Minute == -1)
			{
				result.Minute = 0;
			}
			if (result.Second == -1)
			{
				result.Second = 0;
			}
			if (result.era == -1)
			{
				result.era = 0;
			}
			return true;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00018754 File Offset: 0x00016954
		private unsafe static string ExpandPredefinedFormat(ReadOnlySpan<char> format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result)
		{
			char c = (char)(*format[0]);
			if (c <= 'R')
			{
				if (c != 'O')
				{
					if (c != 'R')
					{
						goto IL_153;
					}
					goto IL_67;
				}
			}
			else if (c != 'U')
			{
				switch (c)
				{
				case 'o':
					break;
				case 'p':
				case 'q':
				case 't':
					goto IL_153;
				case 'r':
					goto IL_67;
				case 's':
					dtfi = DateTimeFormatInfo.InvariantInfo;
					parseInfo.calendar = GregorianCalendar.GetDefaultInstance();
					goto IL_153;
				case 'u':
					parseInfo.calendar = GregorianCalendar.GetDefaultInstance();
					dtfi = DateTimeFormatInfo.InvariantInfo;
					if ((result.flags & ParseFlags.CaptureOffset) != (ParseFlags)0)
					{
						result.flags |= ParseFlags.UtcSortPattern;
						goto IL_153;
					}
					goto IL_153;
				default:
					goto IL_153;
				}
			}
			else
			{
				parseInfo.calendar = GregorianCalendar.GetDefaultInstance();
				result.flags |= ParseFlags.TimeZoneUsed;
				result.timeZoneOffset = new TimeSpan(0L);
				result.flags |= ParseFlags.TimeZoneUtc;
				if (dtfi.Calendar.GetType() != typeof(GregorianCalendar))
				{
					dtfi = (DateTimeFormatInfo)dtfi.Clone();
					dtfi.Calendar = GregorianCalendar.GetDefaultInstance();
					goto IL_153;
				}
				goto IL_153;
			}
			parseInfo.calendar = GregorianCalendar.GetDefaultInstance();
			dtfi = DateTimeFormatInfo.InvariantInfo;
			goto IL_153;
			IL_67:
			parseInfo.calendar = GregorianCalendar.GetDefaultInstance();
			dtfi = DateTimeFormatInfo.InvariantInfo;
			if ((result.flags & ParseFlags.CaptureOffset) != (ParseFlags)0)
			{
				result.flags |= ParseFlags.Rfc1123Pattern;
			}
			IL_153:
			return DateTimeFormat.GetRealFormat(format, dtfi);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000188BC File Offset: 0x00016ABC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ParseJapaneseEraStart(ref __DTString str, DateTimeFormatInfo dtfi)
		{
			if (AppContextSwitches.EnforceLegacyJapaneseDateParsing || dtfi.Calendar.ID != 3 || !str.GetNext())
			{
				return false;
			}
			if (str.m_current != "元"[0])
			{
				str.Index--;
				return false;
			}
			return true;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0001890C File Offset: 0x00016B0C
		private unsafe static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result)
		{
			int num = 0;
			int newValue = 0;
			int newValue2 = 0;
			int newValue3 = 0;
			int newValue4 = 0;
			int newValue5 = 0;
			int newValue6 = 0;
			int newValue7 = 0;
			double num2 = 0.0;
			DateTimeParse.TM tm = DateTimeParse.TM.AM;
			char @char = format.GetChar();
			if (@char <= 'K')
			{
				if (@char <= '.')
				{
					if (@char <= '%')
					{
						if (@char != '"')
						{
							if (@char != '%')
							{
								goto IL_93B;
							}
							if (format.Index >= format.Value.Length - 1 || *format.Value[format.Index + 1] == 37)
							{
								result.SetBadFormatSpecifierFailure(format.Value);
								return false;
							}
							return true;
						}
					}
					else if (@char != '\'')
					{
						if (@char != '.')
						{
							goto IL_93B;
						}
						if (str.Match(@char))
						{
							return true;
						}
						if (format.GetNext() && format.Match('F'))
						{
							format.GetRepeatCount();
							return true;
						}
						result.SetBadDateTimeFailure();
						return false;
					}
					StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
					if (!DateTimeParse.TryParseQuoteString(format.Value, format.Index, stringBuilder, out num))
					{
						result.SetFailure(ParseFailureKind.FormatWithParameter, "Cannot find a matching quote character for the character '{0}'.", @char);
						StringBuilderCache.Release(stringBuilder);
						return false;
					}
					format.Index += num - 1;
					string stringAndRelease = StringBuilderCache.GetStringAndRelease(stringBuilder);
					for (int i = 0; i < stringAndRelease.Length; i++)
					{
						if (stringAndRelease[i] == ' ' && parseInfo.fAllowInnerWhite)
						{
							str.SkipWhiteSpaces();
						}
						else if (!str.Match(stringAndRelease[i]))
						{
							result.SetBadDateTimeFailure();
							return false;
						}
					}
					if ((result.flags & ParseFlags.CaptureOffset) == (ParseFlags)0)
					{
						return true;
					}
					if ((result.flags & ParseFlags.Rfc1123Pattern) != (ParseFlags)0 && stringAndRelease == "GMT")
					{
						result.flags |= ParseFlags.TimeZoneUsed;
						result.timeZoneOffset = TimeSpan.Zero;
						return true;
					}
					if ((result.flags & ParseFlags.UtcSortPattern) != (ParseFlags)0 && stringAndRelease == "Z")
					{
						result.flags |= ParseFlags.TimeZoneUsed;
						result.timeZoneOffset = TimeSpan.Zero;
						return true;
					}
					return true;
				}
				else if (@char <= ':')
				{
					if (@char != '/')
					{
						if (@char != ':')
						{
							goto IL_93B;
						}
						if (((dtfi.TimeSeparator.Length > 1 && dtfi.TimeSeparator[0] == ':') || !str.Match(':')) && !str.Match(dtfi.TimeSeparator))
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						return true;
					}
					else
					{
						if (((dtfi.DateSeparator.Length > 1 && dtfi.DateSeparator[0] == '/') || !str.Match('/')) && !str.Match(dtfi.DateSeparator))
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						return true;
					}
				}
				else if (@char != 'F')
				{
					if (@char != 'H')
					{
						if (@char != 'K')
						{
							goto IL_93B;
						}
						if (str.Match('Z'))
						{
							if ((result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0 && result.timeZoneOffset != TimeSpan.Zero)
							{
								result.SetFailure(ParseFailureKind.FormatWithParameter, "DateTime pattern '{0}' appears more than once with different values.", 'K');
								return false;
							}
							result.flags |= ParseFlags.TimeZoneUsed;
							result.timeZoneOffset = new TimeSpan(0L);
							result.flags |= ParseFlags.TimeZoneUtc;
							return true;
						}
						else
						{
							if (!str.Match('+') && !str.Match('-'))
							{
								return true;
							}
							str.Index--;
							TimeSpan timeSpan = new TimeSpan(0L);
							if (!DateTimeParse.ParseTimeZoneOffset(ref str, 3, ref timeSpan))
							{
								result.SetBadDateTimeFailure();
								return false;
							}
							if ((result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0 && timeSpan != result.timeZoneOffset)
							{
								result.SetFailure(ParseFailureKind.FormatWithParameter, "DateTime pattern '{0}' appears more than once with different values.", 'K');
								return false;
							}
							result.timeZoneOffset = timeSpan;
							result.flags |= ParseFlags.TimeZoneUsed;
							return true;
						}
					}
					else
					{
						num = format.GetRepeatCount();
						if (!DateTimeParse.ParseDigits(ref str, (num < 2) ? 1 : 2, out newValue5))
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						if (!DateTimeParse.CheckNewValue(ref result.Hour, newValue5, @char, ref result))
						{
							return false;
						}
						return true;
					}
				}
			}
			else if (@char <= 'h')
			{
				if (@char <= 'Z')
				{
					if (@char != 'M')
					{
						if (@char != 'Z')
						{
							goto IL_93B;
						}
						if ((result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0 && result.timeZoneOffset != TimeSpan.Zero)
						{
							result.SetFailure(ParseFailureKind.FormatWithParameter, "DateTime pattern '{0}' appears more than once with different values.", 'Z');
							return false;
						}
						result.flags |= ParseFlags.TimeZoneUsed;
						result.timeZoneOffset = new TimeSpan(0L);
						result.flags |= ParseFlags.TimeZoneUtc;
						str.Index++;
						if (!DateTimeParse.GetTimeZoneName(ref str))
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						str.Index--;
						return true;
					}
					else
					{
						num = format.GetRepeatCount();
						if (num <= 2)
						{
							if (!DateTimeParse.ParseDigits(ref str, num, out newValue2) && (!parseInfo.fCustomNumberParser || !parseInfo.parseNumberDelegate(ref str, num, out newValue2)))
							{
								result.SetBadDateTimeFailure();
								return false;
							}
						}
						else
						{
							if (num == 3)
							{
								if (!DateTimeParse.MatchAbbreviatedMonthName(ref str, dtfi, ref newValue2))
								{
									result.SetBadDateTimeFailure();
									return false;
								}
							}
							else if (!DateTimeParse.MatchMonthName(ref str, dtfi, ref newValue2))
							{
								result.SetBadDateTimeFailure();
								return false;
							}
							result.flags |= ParseFlags.ParsedMonthName;
						}
						if (!DateTimeParse.CheckNewValue(ref result.Month, newValue2, @char, ref result))
						{
							return false;
						}
						return true;
					}
				}
				else if (@char != '\\')
				{
					switch (@char)
					{
					case 'd':
						num = format.GetRepeatCount();
						if (num <= 2)
						{
							if (!DateTimeParse.ParseDigits(ref str, num, out newValue3) && (!parseInfo.fCustomNumberParser || !parseInfo.parseNumberDelegate(ref str, num, out newValue3)))
							{
								result.SetBadDateTimeFailure();
								return false;
							}
							if (!DateTimeParse.CheckNewValue(ref result.Day, newValue3, @char, ref result))
							{
								return false;
							}
							return true;
						}
						else
						{
							if (num == 3)
							{
								if (!DateTimeParse.MatchAbbreviatedDayName(ref str, dtfi, ref newValue4))
								{
									result.SetBadDateTimeFailure();
									return false;
								}
							}
							else if (!DateTimeParse.MatchDayName(ref str, dtfi, ref newValue4))
							{
								result.SetBadDateTimeFailure();
								return false;
							}
							if (!DateTimeParse.CheckNewValue(ref parseInfo.dayOfWeek, newValue4, @char, ref result))
							{
								return false;
							}
							return true;
						}
						break;
					case 'e':
						goto IL_93B;
					case 'f':
						break;
					case 'g':
						num = format.GetRepeatCount();
						if (!DateTimeParse.MatchEraName(ref str, dtfi, ref result.era))
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						return true;
					case 'h':
						parseInfo.fUseHour12 = true;
						num = format.GetRepeatCount();
						if (!DateTimeParse.ParseDigits(ref str, (num < 2) ? 1 : 2, out newValue5))
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						if (!DateTimeParse.CheckNewValue(ref result.Hour, newValue5, @char, ref result))
						{
							return false;
						}
						return true;
					default:
						goto IL_93B;
					}
				}
				else
				{
					if (!format.GetNext())
					{
						result.SetBadFormatSpecifierFailure(format.Value);
						return false;
					}
					if (!str.Match(format.GetChar()))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					return true;
				}
			}
			else if (@char <= 's')
			{
				if (@char != 'm')
				{
					if (@char != 's')
					{
						goto IL_93B;
					}
					num = format.GetRepeatCount();
					if (!DateTimeParse.ParseDigits(ref str, (num < 2) ? 1 : 2, out newValue7))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					if (!DateTimeParse.CheckNewValue(ref result.Second, newValue7, @char, ref result))
					{
						return false;
					}
					return true;
				}
				else
				{
					num = format.GetRepeatCount();
					if (!DateTimeParse.ParseDigits(ref str, (num < 2) ? 1 : 2, out newValue6))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					if (!DateTimeParse.CheckNewValue(ref result.Minute, newValue6, @char, ref result))
					{
						return false;
					}
					return true;
				}
			}
			else if (@char != 't')
			{
				if (@char != 'y')
				{
					if (@char != 'z')
					{
						goto IL_93B;
					}
					num = format.GetRepeatCount();
					TimeSpan timeSpan2 = new TimeSpan(0L);
					if (!DateTimeParse.ParseTimeZoneOffset(ref str, num, ref timeSpan2))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					if ((result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0 && timeSpan2 != result.timeZoneOffset)
					{
						result.SetFailure(ParseFailureKind.FormatWithParameter, "DateTime pattern '{0}' appears more than once with different values.", 'z');
						return false;
					}
					result.timeZoneOffset = timeSpan2;
					result.flags |= ParseFlags.TimeZoneUsed;
					return true;
				}
				else
				{
					num = format.GetRepeatCount();
					bool flag;
					if (DateTimeParse.ParseJapaneseEraStart(ref str, dtfi))
					{
						newValue = 1;
						flag = true;
					}
					else if (dtfi.HasForceTwoDigitYears)
					{
						flag = DateTimeParse.ParseDigits(ref str, 1, 4, out newValue);
					}
					else
					{
						if (num <= 2)
						{
							parseInfo.fUseTwoDigitYear = true;
						}
						flag = DateTimeParse.ParseDigits(ref str, num, out newValue);
					}
					if (!flag && parseInfo.fCustomNumberParser)
					{
						flag = parseInfo.parseNumberDelegate(ref str, num, out newValue);
					}
					if (!flag)
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					if (!DateTimeParse.CheckNewValue(ref result.Year, newValue, @char, ref result))
					{
						return false;
					}
					return true;
				}
			}
			else
			{
				num = format.GetRepeatCount();
				if (num == 1)
				{
					if (!DateTimeParse.MatchAbbreviatedTimeMark(ref str, dtfi, ref tm))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
				}
				else if (!DateTimeParse.MatchTimeMark(ref str, dtfi, ref tm))
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				if (parseInfo.timeMark == DateTimeParse.TM.NotSet)
				{
					parseInfo.timeMark = tm;
					return true;
				}
				if (parseInfo.timeMark != tm)
				{
					result.SetFailure(ParseFailureKind.FormatWithParameter, "DateTime pattern '{0}' appears more than once with different values.", @char);
					return false;
				}
				return true;
			}
			num = format.GetRepeatCount();
			if (num > 7)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (!DateTimeParse.ParseFractionExact(ref str, num, ref num2) && @char == 'f')
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (result.fraction < 0.0)
			{
				result.fraction = num2;
				return true;
			}
			if (num2 != result.fraction)
			{
				result.SetFailure(ParseFailureKind.FormatWithParameter, "DateTime pattern '{0}' appears more than once with different values.", @char);
				return false;
			}
			return true;
			IL_93B:
			if (@char == ' ')
			{
				if (!parseInfo.fAllowInnerWhite && !str.Match(@char))
				{
					if (parseInfo.fAllowTrailingWhite && format.GetNext() && DateTimeParse.ParseByFormat(ref str, ref format, ref parseInfo, dtfi, ref result))
					{
						return true;
					}
					result.SetBadDateTimeFailure();
					return false;
				}
			}
			else if (format.MatchSpecifiedWord("GMT"))
			{
				format.Index += "GMT".Length - 1;
				result.flags |= ParseFlags.TimeZoneUsed;
				result.timeZoneOffset = TimeSpan.Zero;
				if (!str.Match("GMT"))
				{
					result.SetBadDateTimeFailure();
					return false;
				}
			}
			else if (!str.Match(@char))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			return true;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00019304 File Offset: 0x00017504
		internal unsafe static bool TryParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result, out int returnValue)
		{
			returnValue = 0;
			int length = format.Length;
			int num = pos;
			char c = (char)(*format[pos++]);
			bool flag = false;
			while (pos < length)
			{
				char c2 = (char)(*format[pos++]);
				if (c2 == c)
				{
					flag = true;
					break;
				}
				if (c2 == '\\')
				{
					if (pos >= length)
					{
						return false;
					}
					result.Append((char)(*format[pos++]));
				}
				else
				{
					result.Append(c2);
				}
			}
			if (!flag)
			{
				return false;
			}
			returnValue = pos - num;
			return true;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00019388 File Offset: 0x00017588
		private unsafe static bool DoStrictParse(ReadOnlySpan<char> s, ReadOnlySpan<char> formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result)
		{
			ParsingInfo parsingInfo = default(ParsingInfo);
			parsingInfo.Init();
			parsingInfo.calendar = dtfi.Calendar;
			parsingInfo.fAllowInnerWhite = ((styles & DateTimeStyles.AllowInnerWhite) > DateTimeStyles.None);
			parsingInfo.fAllowTrailingWhite = ((styles & DateTimeStyles.AllowTrailingWhite) > DateTimeStyles.None);
			if (formatParam.Length == 1)
			{
				if ((result.flags & ParseFlags.CaptureOffset) != (ParseFlags)0 && *formatParam[0] == 85)
				{
					result.SetBadFormatSpecifierFailure(formatParam);
					return false;
				}
				formatParam = DateTimeParse.ExpandPredefinedFormat(formatParam, ref dtfi, ref parsingInfo, ref result);
			}
			result.calendar = parsingInfo.calendar;
			if (!GlobalizationMode.Invariant && (ushort)parsingInfo.calendar.ID == 8)
			{
				LazyInitializer.EnsureInitialized<DateTimeParse.MatchNumberDelegate>(ref DateTimeParse.m_hebrewNumberParser, () => new DateTimeParse.MatchNumberDelegate(DateTimeParse.MatchHebrewDigits));
				parsingInfo.parseNumberDelegate = DateTimeParse.m_hebrewNumberParser;
				parsingInfo.fCustomNumberParser = true;
			}
			result.Hour = (result.Minute = (result.Second = -1));
			__DTString _DTString = new __DTString(formatParam, dtfi, false);
			__DTString _DTString2 = new __DTString(s, dtfi, false);
			if (parsingInfo.fAllowTrailingWhite)
			{
				_DTString.TrimTail();
				_DTString.RemoveTrailingInQuoteSpaces();
				_DTString2.TrimTail();
			}
			if ((styles & DateTimeStyles.AllowLeadingWhite) != DateTimeStyles.None)
			{
				_DTString.SkipWhiteSpaces();
				_DTString.RemoveLeadingInQuoteSpaces();
				_DTString2.SkipWhiteSpaces();
			}
			while (_DTString.GetNext())
			{
				if (parsingInfo.fAllowInnerWhite)
				{
					_DTString2.SkipWhiteSpaces();
				}
				if (!DateTimeParse.ParseByFormat(ref _DTString2, ref _DTString, ref parsingInfo, dtfi, ref result))
				{
					return false;
				}
			}
			if (_DTString2.Index < _DTString2.Value.Length - 1)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (parsingInfo.fUseTwoDigitYear && (dtfi.FormatFlags & DateTimeFormatFlags.UseHebrewRule) == DateTimeFormatFlags.None)
			{
				if (result.Year >= 100)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				try
				{
					result.Year = parsingInfo.calendar.ToFourDigitYear(result.Year);
				}
				catch (ArgumentOutOfRangeException)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
			}
			if (parsingInfo.fUseHour12)
			{
				if (parsingInfo.timeMark == DateTimeParse.TM.NotSet)
				{
					parsingInfo.timeMark = DateTimeParse.TM.AM;
				}
				if (result.Hour > 12)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				if (parsingInfo.timeMark == DateTimeParse.TM.AM)
				{
					if (result.Hour == 12)
					{
						result.Hour = 0;
					}
				}
				else
				{
					result.Hour = ((result.Hour == 12) ? 12 : (result.Hour + 12));
				}
			}
			else if ((parsingInfo.timeMark == DateTimeParse.TM.AM && result.Hour >= 12) || (parsingInfo.timeMark == DateTimeParse.TM.PM && result.Hour < 12))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			bool flag = result.Year == -1 && result.Month == -1 && result.Day == -1;
			if (!DateTimeParse.CheckDefaultDateTime(ref result, ref parsingInfo.calendar, styles))
			{
				return false;
			}
			if (!flag && dtfi.HasYearMonthAdjustment && !dtfi.YearMonthAdjustment(ref result.Year, ref result.Month, (result.flags & ParseFlags.ParsedMonthName) > (ParseFlags)0))
			{
				result.SetFailure(ParseFailureKind.FormatBadDateTimeCalendar, "The DateTime represented by the string is not supported in calendar {0}.");
				return false;
			}
			if (!parsingInfo.calendar.TryToDateTime(result.Year, result.Month, result.Day, result.Hour, result.Minute, result.Second, 0, result.era, out result.parsedDate))
			{
				result.SetFailure(ParseFailureKind.FormatBadDateTimeCalendar, "The DateTime represented by the string is not supported in calendar {0}.");
				return false;
			}
			if (result.fraction > 0.0)
			{
				result.parsedDate = result.parsedDate.AddTicks((long)Math.Round(result.fraction * 10000000.0));
			}
			if (parsingInfo.dayOfWeek != -1 && parsingInfo.dayOfWeek != (int)parsingInfo.calendar.GetDayOfWeek(result.parsedDate))
			{
				result.SetFailure(ParseFailureKind.FormatWithOriginalDateTime, "String was not recognized as a valid DateTime because the day of week was incorrect.");
				return false;
			}
			return DateTimeParse.DetermineTimeZoneAdjustments(ref _DTString2, ref result, styles, flag);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00019770 File Offset: 0x00017970
		private static Exception GetDateTimeParseException(ref DateTimeResult result)
		{
			switch (result.failure)
			{
			case ParseFailureKind.ArgumentNull:
				return new ArgumentNullException(result.failureArgumentName, SR.GetResourceString(result.failureMessageID));
			case ParseFailureKind.Format:
				return new FormatException(SR.GetResourceString(result.failureMessageID));
			case ParseFailureKind.FormatWithParameter:
				return new FormatException(SR.Format(SR.GetResourceString(result.failureMessageID), result.failureMessageFormatArgument));
			case ParseFailureKind.FormatWithOriginalDateTime:
				return new FormatException(SR.Format(SR.GetResourceString(result.failureMessageID), new string(result.originalDateTimeString)));
			case ParseFailureKind.FormatWithFormatSpecifier:
				return new FormatException(SR.Format(SR.GetResourceString(result.failureMessageID), new string(result.failedFormatSpecifier)));
			case ParseFailureKind.FormatWithOriginalDateTimeAndParameter:
				return new FormatException(SR.Format(SR.GetResourceString(result.failureMessageID), new string(result.originalDateTimeString), result.failureMessageFormatArgument));
			case ParseFailureKind.FormatBadDateTimeCalendar:
				return new FormatException(SR.Format(SR.GetResourceString(result.failureMessageID), new string(result.originalDateTimeString), result.calendar));
			default:
				return null;
			}
		}

		// Token: 0x0400022C RID: 556
		internal static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser;

		// Token: 0x0400022D RID: 557
		private static DateTimeParse.DS[][] dateParsingStates = new DateTimeParse.DS[][]
		{
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.BEGIN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.TX_N,
				DateTimeParse.DS.N,
				DateTimeParse.DS.D_Nd,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_M,
				DateTimeParse.DS.D_M,
				DateTimeParse.DS.D_S,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.BEGIN,
				DateTimeParse.DS.D_Y,
				DateTimeParse.DS.D_Y,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.BEGIN,
				DateTimeParse.DS.BEGIN,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.NN,
				DateTimeParse.DS.D_NNd,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NM,
				DateTimeParse.DS.D_NM,
				DateTimeParse.DS.D_MNd,
				DateTimeParse.DS.D_NDS,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.N,
				DateTimeParse.DS.D_YN,
				DateTimeParse.DS.D_YNd,
				DateTimeParse.DS.DX_YN,
				DateTimeParse.DS.N,
				DateTimeParse.DS.N,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_NN,
				DateTimeParse.DS.DX_NNN,
				DateTimeParse.DS.TX_N,
				DateTimeParse.DS.DX_NNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.NN,
				DateTimeParse.DS.DX_NNY,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NNY,
				DateTimeParse.DS.NN,
				DateTimeParse.DS.NN,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_NN,
				DateTimeParse.DS.D_NNd,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NM,
				DateTimeParse.DS.D_MN,
				DateTimeParse.DS.D_MNd,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_Nd,
				DateTimeParse.DS.D_YN,
				DateTimeParse.DS.D_YNd,
				DateTimeParse.DS.DX_YN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_Nd,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_NN,
				DateTimeParse.DS.DX_NNN,
				DateTimeParse.DS.TX_N,
				DateTimeParse.DS.DX_NNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_DS,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.D_NN,
				DateTimeParse.DS.DX_NNY,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NNY,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_NN,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NNN,
				DateTimeParse.DS.DX_NNN,
				DateTimeParse.DS.DX_NNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_DS,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_NNd,
				DateTimeParse.DS.DX_NNY,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NNY,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_NNd,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_MN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_MN,
				DateTimeParse.DS.D_MNd,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_M,
				DateTimeParse.DS.D_YM,
				DateTimeParse.DS.D_YMd,
				DateTimeParse.DS.DX_YM,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_M,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_MN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_DS,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.D_MN,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_MN,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_NM,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_DS,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.D_NM,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_NM,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_MNd,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_MNd,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_NDS,
				DateTimeParse.DS.DX_NNDS,
				DateTimeParse.DS.DX_NNDS,
				DateTimeParse.DS.DX_NNDS,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_NDS,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.D_NDS,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_NDS,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YN,
				DateTimeParse.DS.D_YNd,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YM,
				DateTimeParse.DS.D_YM,
				DateTimeParse.DS.D_YMd,
				DateTimeParse.DS.D_YM,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_Y,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_Y,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_YN,
				DateTimeParse.DS.DX_YNN,
				DateTimeParse.DS.DX_YNN,
				DateTimeParse.DS.DX_YNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YN,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YNN,
				DateTimeParse.DS.DX_YNN,
				DateTimeParse.DS.DX_YNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YN,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_YM,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YM,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YM,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YM,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YM,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_DS,
				DateTimeParse.DS.DX_DSN,
				DateTimeParse.DS.TX_N,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_S,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.D_S,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_S,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.TX_TS,
				DateTimeParse.DS.TX_TS,
				DateTimeParse.DS.TX_TS,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.D_Nd,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_S,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.TX_NN,
				DateTimeParse.DS.TX_NN,
				DateTimeParse.DS.TX_NN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_NNt,
				DateTimeParse.DS.DX_NM,
				DateTimeParse.DS.D_NM,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.TX_NN
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.TX_NNN,
				DateTimeParse.DS.TX_NNN,
				DateTimeParse.DS.TX_NNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.T_NNt,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_NNt,
				DateTimeParse.DS.T_NNt,
				DateTimeParse.DS.TX_NNN
			}
		};

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x060005C4 RID: 1476
		internal delegate bool MatchNumberDelegate(ref __DTString str, int digitLen, out int result);

		// Token: 0x020000A4 RID: 164
		internal enum DTT
		{
			// Token: 0x0400022F RID: 559
			End,
			// Token: 0x04000230 RID: 560
			NumEnd,
			// Token: 0x04000231 RID: 561
			NumAmpm,
			// Token: 0x04000232 RID: 562
			NumSpace,
			// Token: 0x04000233 RID: 563
			NumDatesep,
			// Token: 0x04000234 RID: 564
			NumTimesep,
			// Token: 0x04000235 RID: 565
			MonthEnd,
			// Token: 0x04000236 RID: 566
			MonthSpace,
			// Token: 0x04000237 RID: 567
			MonthDatesep,
			// Token: 0x04000238 RID: 568
			NumDatesuff,
			// Token: 0x04000239 RID: 569
			NumTimesuff,
			// Token: 0x0400023A RID: 570
			DayOfWeek,
			// Token: 0x0400023B RID: 571
			YearSpace,
			// Token: 0x0400023C RID: 572
			YearDateSep,
			// Token: 0x0400023D RID: 573
			YearEnd,
			// Token: 0x0400023E RID: 574
			TimeZone,
			// Token: 0x0400023F RID: 575
			Era,
			// Token: 0x04000240 RID: 576
			NumUTCTimeMark,
			// Token: 0x04000241 RID: 577
			Unk,
			// Token: 0x04000242 RID: 578
			NumLocalTimeMark,
			// Token: 0x04000243 RID: 579
			Max
		}

		// Token: 0x020000A5 RID: 165
		internal enum TM
		{
			// Token: 0x04000245 RID: 581
			NotSet = -1,
			// Token: 0x04000246 RID: 582
			AM,
			// Token: 0x04000247 RID: 583
			PM
		}

		// Token: 0x020000A6 RID: 166
		internal enum DS
		{
			// Token: 0x04000249 RID: 585
			BEGIN,
			// Token: 0x0400024A RID: 586
			N,
			// Token: 0x0400024B RID: 587
			NN,
			// Token: 0x0400024C RID: 588
			D_Nd,
			// Token: 0x0400024D RID: 589
			D_NN,
			// Token: 0x0400024E RID: 590
			D_NNd,
			// Token: 0x0400024F RID: 591
			D_M,
			// Token: 0x04000250 RID: 592
			D_MN,
			// Token: 0x04000251 RID: 593
			D_NM,
			// Token: 0x04000252 RID: 594
			D_MNd,
			// Token: 0x04000253 RID: 595
			D_NDS,
			// Token: 0x04000254 RID: 596
			D_Y,
			// Token: 0x04000255 RID: 597
			D_YN,
			// Token: 0x04000256 RID: 598
			D_YNd,
			// Token: 0x04000257 RID: 599
			D_YM,
			// Token: 0x04000258 RID: 600
			D_YMd,
			// Token: 0x04000259 RID: 601
			D_S,
			// Token: 0x0400025A RID: 602
			T_S,
			// Token: 0x0400025B RID: 603
			T_Nt,
			// Token: 0x0400025C RID: 604
			T_NNt,
			// Token: 0x0400025D RID: 605
			ERROR,
			// Token: 0x0400025E RID: 606
			DX_NN,
			// Token: 0x0400025F RID: 607
			DX_NNN,
			// Token: 0x04000260 RID: 608
			DX_MN,
			// Token: 0x04000261 RID: 609
			DX_NM,
			// Token: 0x04000262 RID: 610
			DX_MNN,
			// Token: 0x04000263 RID: 611
			DX_DS,
			// Token: 0x04000264 RID: 612
			DX_DSN,
			// Token: 0x04000265 RID: 613
			DX_NDS,
			// Token: 0x04000266 RID: 614
			DX_NNDS,
			// Token: 0x04000267 RID: 615
			DX_YNN,
			// Token: 0x04000268 RID: 616
			DX_YMN,
			// Token: 0x04000269 RID: 617
			DX_YN,
			// Token: 0x0400026A RID: 618
			DX_YM,
			// Token: 0x0400026B RID: 619
			TX_N,
			// Token: 0x0400026C RID: 620
			TX_NN,
			// Token: 0x0400026D RID: 621
			TX_NNN,
			// Token: 0x0400026E RID: 622
			TX_TS,
			// Token: 0x0400026F RID: 623
			DX_NNY
		}
	}
}
