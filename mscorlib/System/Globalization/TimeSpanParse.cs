﻿using System;
using System.Text;

namespace System.Globalization
{
	// Token: 0x0200058F RID: 1423
	internal static class TimeSpanParse
	{
		// Token: 0x06002A8A RID: 10890 RVA: 0x000AB1D0 File Offset: 0x000A93D0
		internal static long Pow10(int pow)
		{
			switch (pow)
			{
			case 0:
				return 1L;
			case 1:
				return 10L;
			case 2:
				return 100L;
			case 3:
				return 1000L;
			case 4:
				return 10000L;
			case 5:
				return 100000L;
			case 6:
				return 1000000L;
			case 7:
				return 10000000L;
			default:
				return (long)Math.Pow(10.0, (double)pow);
			}
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x000AB244 File Offset: 0x000A9444
		private static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, out long result)
		{
			if (days._num > 10675199 || hours._num > 23 || minutes._num > 59 || seconds._num > 59 || fraction.IsInvalidFraction())
			{
				result = 0L;
				return false;
			}
			long num = ((long)days._num * 3600L * 24L + (long)hours._num * 3600L + (long)minutes._num * 60L + (long)seconds._num) * 1000L;
			if (num > 922337203685477L || num < -922337203685477L)
			{
				result = 0L;
				return false;
			}
			long num2 = (long)fraction._num;
			if (num2 != 0L)
			{
				long num3 = 1000000L;
				if (fraction._zeroes > 0)
				{
					long num4 = TimeSpanParse.Pow10(fraction._zeroes);
					num3 /= num4;
				}
				while (num2 < num3)
				{
					num2 *= 10L;
				}
			}
			result = num * 10000L + num2;
			if (positive && result < 0L)
			{
				result = 0L;
				return false;
			}
			return true;
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x000AB344 File Offset: 0x000A9544
		internal static TimeSpan Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider)
		{
			TimeSpanParse.TimeSpanResult timeSpanResult = new TimeSpanParse.TimeSpanResult(true);
			TimeSpanParse.TryParseTimeSpan(input, TimeSpanParse.TimeSpanStandardStyles.Any, formatProvider, ref timeSpanResult);
			return timeSpanResult.parsedTimeSpan;
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x000AB36C File Offset: 0x000A956C
		internal static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
		{
			TimeSpanParse.TimeSpanResult timeSpanResult = new TimeSpanParse.TimeSpanResult(false);
			if (TimeSpanParse.TryParseExactTimeSpan(input, format, formatProvider, styles, ref timeSpanResult))
			{
				result = timeSpanResult.parsedTimeSpan;
				return true;
			}
			result = default(TimeSpan);
			return false;
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x000AB3A8 File Offset: 0x000A95A8
		private static bool TryParseTimeSpan(ReadOnlySpan<char> input, TimeSpanParse.TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanParse.TimeSpanResult result)
		{
			input = input.Trim();
			if (input.IsEmpty)
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
			}
			TimeSpanParse.TimeSpanTokenizer timeSpanTokenizer = new TimeSpanParse.TimeSpanTokenizer(input);
			TimeSpanParse.TimeSpanRawInfo timeSpanRawInfo = default(TimeSpanParse.TimeSpanRawInfo);
			timeSpanRawInfo.Init(DateTimeFormatInfo.GetInstance(formatProvider));
			TimeSpanParse.TimeSpanToken nextToken = timeSpanTokenizer.GetNextToken();
			while (nextToken._ttt != TimeSpanParse.TTT.End)
			{
				if (!timeSpanRawInfo.ProcessToken(ref nextToken, ref result))
				{
					return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
				}
				nextToken = timeSpanTokenizer.GetNextToken();
			}
			return TimeSpanParse.ProcessTerminalState(ref timeSpanRawInfo, style, ref result) || result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x000AB444 File Offset: 0x000A9644
		private static bool ProcessTerminalState(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			if (raw._lastSeenTTT == TimeSpanParse.TTT.Num)
			{
				TimeSpanParse.TimeSpanToken timeSpanToken = default(TimeSpanParse.TimeSpanToken);
				timeSpanToken._ttt = TimeSpanParse.TTT.Sep;
				if (!raw.ProcessToken(ref timeSpanToken, ref result))
				{
					return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
				}
			}
			switch (raw._numCount)
			{
			case 1:
				return TimeSpanParse.ProcessTerminal_D(ref raw, style, ref result);
			case 2:
				return TimeSpanParse.ProcessTerminal_HM(ref raw, style, ref result);
			case 3:
				return TimeSpanParse.ProcessTerminal_HM_S_D(ref raw, style, ref result);
			case 4:
				return TimeSpanParse.ProcessTerminal_HMS_F_D(ref raw, style, ref result);
			case 5:
				return TimeSpanParse.ProcessTerminal_DHMSF(ref raw, style, ref result);
			default:
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
			}
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x000AB4E4 File Offset: 0x000A96E4
		private static bool ProcessTerminal_DHMSF(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			if (raw._sepCount != 6)
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
			}
			bool flag = (style & TimeSpanParse.TimeSpanStandardStyles.Invariant) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag2 = (style & TimeSpanParse.TimeSpanStandardStyles.Localized) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag3 = false;
			bool flag4 = false;
			if (flag)
			{
				if (raw.FullMatch(raw.PositiveInvariant))
				{
					flag4 = true;
					flag3 = true;
				}
				if (!flag4 && raw.FullMatch(raw.NegativeInvariant))
				{
					flag4 = true;
					flag3 = false;
				}
			}
			if (flag2)
			{
				if (!flag4 && raw.FullMatch(raw.PositiveLocalized))
				{
					flag4 = true;
					flag3 = true;
				}
				if (!flag4 && raw.FullMatch(raw.NegativeLocalized))
				{
					flag4 = true;
					flag3 = false;
				}
			}
			if (!flag4)
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
			}
			long num;
			if (!TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, raw._numbers4, out num))
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
			}
			if (!flag3)
			{
				num = -num;
				if (num > 0L)
				{
					return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
				}
			}
			result.parsedTimeSpan = new TimeSpan(num);
			return true;
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x000AB5E0 File Offset: 0x000A97E0
		private static bool ProcessTerminal_HMS_F_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			if (raw._sepCount != 5 || (style & TimeSpanParse.TimeSpanStandardStyles.RequireFull) != TimeSpanParse.TimeSpanStandardStyles.None)
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
			}
			bool flag = (style & TimeSpanParse.TimeSpanStandardStyles.Invariant) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag2 = (style & TimeSpanParse.TimeSpanStandardStyles.Localized) > TimeSpanParse.TimeSpanStandardStyles.None;
			long num = 0L;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			TimeSpanParse.TimeSpanToken timeSpanToken = new TimeSpanParse.TimeSpanToken(0);
			if (flag)
			{
				if (raw.FullHMSFMatch(raw.PositiveInvariant))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMSMatch(raw.PositiveInvariant))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullAppCompatMatch(raw.PositiveInvariant))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullHMSFMatch(raw.NegativeInvariant))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMSMatch(raw.NegativeInvariant))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullAppCompatMatch(raw.NegativeInvariant))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
			}
			if (flag2)
			{
				if (!flag4 && raw.FullHMSFMatch(raw.PositiveLocalized))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMSMatch(raw.PositiveLocalized))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullAppCompatMatch(raw.PositiveLocalized))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullHMSFMatch(raw.NegativeLocalized))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMSMatch(raw.NegativeLocalized))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullAppCompatMatch(raw.NegativeLocalized))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
			}
			if (flag4)
			{
				if (!flag3)
				{
					num = -num;
					if (num > 0L)
					{
						return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
					}
				}
				result.parsedTimeSpan = new TimeSpan(num);
				return true;
			}
			if (!flag5)
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
			}
			return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x000AB9A4 File Offset: 0x000A9BA4
		private static bool ProcessTerminal_HM_S_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			if (raw._sepCount != 4 || (style & TimeSpanParse.TimeSpanStandardStyles.RequireFull) != TimeSpanParse.TimeSpanStandardStyles.None)
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
			}
			bool flag = (style & TimeSpanParse.TimeSpanStandardStyles.Invariant) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag2 = (style & TimeSpanParse.TimeSpanStandardStyles.Localized) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			TimeSpanParse.TimeSpanToken timeSpanToken = new TimeSpanParse.TimeSpanToken(0);
			long num = 0L;
			if (flag)
			{
				if (raw.FullHMSMatch(raw.PositiveInvariant))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMMatch(raw.PositiveInvariant))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.PartialAppCompatMatch(raw.PositiveInvariant))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, timeSpanToken, raw._numbers2, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullHMSMatch(raw.NegativeInvariant))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMMatch(raw.NegativeInvariant))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.PartialAppCompatMatch(raw.NegativeInvariant))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, timeSpanToken, raw._numbers2, out num);
					flag5 = (flag5 || !flag4);
				}
			}
			if (flag2)
			{
				if (!flag4 && raw.FullHMSMatch(raw.PositiveLocalized))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMMatch(raw.PositiveLocalized))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.PartialAppCompatMatch(raw.PositiveLocalized))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, timeSpanToken, raw._numbers2, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullHMSMatch(raw.NegativeLocalized))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMMatch(raw.NegativeLocalized))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.PartialAppCompatMatch(raw.NegativeLocalized))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, timeSpanToken, raw._numbers2, out num);
					flag5 = (flag5 || !flag4);
				}
			}
			if (flag4)
			{
				if (!flag3)
				{
					num = -num;
					if (num > 0L)
					{
						return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
					}
				}
				result.parsedTimeSpan = new TimeSpan(num);
				return true;
			}
			if (!flag5)
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
			}
			return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x000ABD20 File Offset: 0x000A9F20
		private static bool ProcessTerminal_HM(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			if (raw._sepCount != 3 || (style & TimeSpanParse.TimeSpanStandardStyles.RequireFull) != TimeSpanParse.TimeSpanStandardStyles.None)
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
			}
			bool flag = (style & TimeSpanParse.TimeSpanStandardStyles.Invariant) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag2 = (style & TimeSpanParse.TimeSpanStandardStyles.Localized) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag3 = false;
			bool flag4 = false;
			if (flag)
			{
				if (raw.FullHMMatch(raw.PositiveInvariant))
				{
					flag4 = true;
					flag3 = true;
				}
				if (!flag4 && raw.FullHMMatch(raw.NegativeInvariant))
				{
					flag4 = true;
					flag3 = false;
				}
			}
			if (flag2)
			{
				if (!flag4 && raw.FullHMMatch(raw.PositiveLocalized))
				{
					flag4 = true;
					flag3 = true;
				}
				if (!flag4 && raw.FullHMMatch(raw.NegativeLocalized))
				{
					flag4 = true;
					flag3 = false;
				}
			}
			if (!flag4)
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
			}
			long num = 0L;
			TimeSpanParse.TimeSpanToken timeSpanToken = new TimeSpanParse.TimeSpanToken(0);
			if (!TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, timeSpanToken, timeSpanToken, out num))
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
			}
			if (!flag3)
			{
				num = -num;
				if (num > 0L)
				{
					return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
				}
			}
			result.parsedTimeSpan = new TimeSpan(num);
			return true;
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x000ABE20 File Offset: 0x000AA020
		private static bool ProcessTerminal_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			if (raw._sepCount != 2 || (style & TimeSpanParse.TimeSpanStandardStyles.RequireFull) != TimeSpanParse.TimeSpanStandardStyles.None)
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
			}
			bool flag = (style & TimeSpanParse.TimeSpanStandardStyles.Invariant) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag2 = (style & TimeSpanParse.TimeSpanStandardStyles.Localized) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag3 = false;
			bool flag4 = false;
			if (flag)
			{
				if (raw.FullDMatch(raw.PositiveInvariant))
				{
					flag4 = true;
					flag3 = true;
				}
				if (!flag4 && raw.FullDMatch(raw.NegativeInvariant))
				{
					flag4 = true;
					flag3 = false;
				}
			}
			if (flag2)
			{
				if (!flag4 && raw.FullDMatch(raw.PositiveLocalized))
				{
					flag4 = true;
					flag3 = true;
				}
				if (!flag4 && raw.FullDMatch(raw.NegativeLocalized))
				{
					flag4 = true;
					flag3 = false;
				}
			}
			if (!flag4)
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
			}
			long num = 0L;
			TimeSpanParse.TimeSpanToken timeSpanToken = new TimeSpanParse.TimeSpanToken(0);
			if (!TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, timeSpanToken, timeSpanToken, timeSpanToken, timeSpanToken, out num))
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
			}
			if (!flag3)
			{
				num = -num;
				if (num > 0L)
				{
					return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
				}
			}
			result.parsedTimeSpan = new TimeSpan(num);
			return true;
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x000ABF1C File Offset: 0x000AA11C
		private unsafe static bool TryParseExactTimeSpan(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, ref TimeSpanParse.TimeSpanResult result)
		{
			if (format.Length == 0)
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "Format specifier was invalid.", null, null);
			}
			if (format.Length == 1)
			{
				char c = (char)(*format[0]);
				if (c <= 'T')
				{
					if (c == 'G')
					{
						return TimeSpanParse.TryParseTimeSpan(input, TimeSpanParse.TimeSpanStandardStyles.Localized | TimeSpanParse.TimeSpanStandardStyles.RequireFull, formatProvider, ref result);
					}
					if (c != 'T')
					{
						goto IL_6C;
					}
				}
				else if (c != 'c')
				{
					if (c == 'g')
					{
						return TimeSpanParse.TryParseTimeSpan(input, TimeSpanParse.TimeSpanStandardStyles.Localized, formatProvider, ref result);
					}
					if (c != 't')
					{
						goto IL_6C;
					}
				}
				return TimeSpanParse.TryParseTimeSpanConstant(input, ref result);
				IL_6C:
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "Format specifier was invalid.", null, null);
			}
			return TimeSpanParse.TryParseByFormat(input, format, styles, ref result);
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x000ABFB0 File Offset: 0x000AA1B0
		private unsafe static bool TryParseByFormat(ReadOnlySpan<char> input, ReadOnlySpan<char> format, TimeSpanStyles styles, ref TimeSpanParse.TimeSpanResult result)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			int number = 0;
			int number2 = 0;
			int number3 = 0;
			int number4 = 0;
			int leadingZeroes = 0;
			int number5 = 0;
			int i = 0;
			int num = 0;
			TimeSpanParse.TimeSpanTokenizer timeSpanTokenizer = new TimeSpanParse.TimeSpanTokenizer(input, -1);
			while (i < format.Length)
			{
				char c = (char)(*format[i]);
				if (c <= 'F')
				{
					if (c <= '%')
					{
						if (c != '"')
						{
							if (c != '%')
							{
								goto IL_2E1;
							}
							int num2 = DateTimeFormat.ParseNextChar(format, i);
							if (num2 >= 0 && num2 != 37)
							{
								num = 1;
								goto IL_2F0;
							}
							return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "Input string was not in a correct format.", null, null);
						}
					}
					else if (c != '\'')
					{
						if (c != 'F')
						{
							goto IL_2E1;
						}
						num = DateTimeFormat.ParseRepeatPattern(format, i, c);
						if (num > 7 || flag5)
						{
							return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "Input string was not in a correct format.", null, null);
						}
						TimeSpanParse.ParseExactDigits(ref timeSpanTokenizer, num, num, out leadingZeroes, out number5);
						flag5 = true;
						goto IL_2F0;
					}
					StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
					if (!DateTimeParse.TryParseQuoteString(format, i, stringBuilder, out num))
					{
						StringBuilderCache.Release(stringBuilder);
						return result.SetFailure(TimeSpanParse.ParseFailureKind.FormatWithParameter, "Cannot find a matching quote character for the character '{0}'.", c, null);
					}
					if (!TimeSpanParse.ParseExactLiteral(ref timeSpanTokenizer, stringBuilder))
					{
						StringBuilderCache.Release(stringBuilder);
						return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "Input string was not in a correct format.", null, null);
					}
					StringBuilderCache.Release(stringBuilder);
				}
				else if (c <= 'h')
				{
					if (c != '\\')
					{
						switch (c)
						{
						case 'd':
						{
							num = DateTimeFormat.ParseRepeatPattern(format, i, c);
							int num3 = 0;
							if (num > 8 || flag || !TimeSpanParse.ParseExactDigits(ref timeSpanTokenizer, (num < 2) ? 1 : num, (num < 2) ? 8 : num, out num3, out number))
							{
								return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "Input string was not in a correct format.", null, null);
							}
							flag = true;
							break;
						}
						case 'e':
						case 'g':
							goto IL_2E1;
						case 'f':
							num = DateTimeFormat.ParseRepeatPattern(format, i, c);
							if (num > 7 || flag5 || !TimeSpanParse.ParseExactDigits(ref timeSpanTokenizer, num, num, out leadingZeroes, out number5))
							{
								return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "Input string was not in a correct format.", null, null);
							}
							flag5 = true;
							break;
						case 'h':
							num = DateTimeFormat.ParseRepeatPattern(format, i, c);
							if (num > 2 || flag2 || !TimeSpanParse.ParseExactDigits(ref timeSpanTokenizer, num, out number2))
							{
								return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "Input string was not in a correct format.", null, null);
							}
							flag2 = true;
							break;
						default:
							goto IL_2E1;
						}
					}
					else
					{
						int num2 = DateTimeFormat.ParseNextChar(format, i);
						if (num2 < 0 || timeSpanTokenizer.NextChar != (char)num2)
						{
							return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "Input string was not in a correct format.", null, null);
						}
						num = 2;
					}
				}
				else if (c != 'm')
				{
					if (c != 's')
					{
						goto IL_2E1;
					}
					num = DateTimeFormat.ParseRepeatPattern(format, i, c);
					if (num > 2 || flag4 || !TimeSpanParse.ParseExactDigits(ref timeSpanTokenizer, num, out number4))
					{
						return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "Input string was not in a correct format.", null, null);
					}
					flag4 = true;
				}
				else
				{
					num = DateTimeFormat.ParseRepeatPattern(format, i, c);
					if (num > 2 || flag3 || !TimeSpanParse.ParseExactDigits(ref timeSpanTokenizer, num, out number3))
					{
						return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "Input string was not in a correct format.", null, null);
					}
					flag3 = true;
				}
				IL_2F0:
				i += num;
				continue;
				IL_2E1:
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "Input string was not in a correct format.", null, null);
			}
			if (!timeSpanTokenizer.EOL)
			{
				return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
			}
			bool flag6 = (styles & TimeSpanStyles.AssumeNegative) == TimeSpanStyles.None;
			long num4;
			if (TimeSpanParse.TryTimeToTicks(flag6, new TimeSpanParse.TimeSpanToken(number), new TimeSpanParse.TimeSpanToken(number2), new TimeSpanParse.TimeSpanToken(number3), new TimeSpanParse.TimeSpanToken(number4), new TimeSpanParse.TimeSpanToken(number5, leadingZeroes), out num4))
			{
				if (!flag6)
				{
					num4 = -num4;
				}
				result.parsedTimeSpan = new TimeSpan(num4);
				return true;
			}
			return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x000AC338 File Offset: 0x000AA538
		private static bool ParseExactDigits(ref TimeSpanParse.TimeSpanTokenizer tokenizer, int minDigitLength, out int result)
		{
			result = 0;
			int num = 0;
			int maxDigitLength = (minDigitLength == 1) ? 2 : minDigitLength;
			return TimeSpanParse.ParseExactDigits(ref tokenizer, minDigitLength, maxDigitLength, out num, out result);
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x000AC360 File Offset: 0x000AA560
		private static bool ParseExactDigits(ref TimeSpanParse.TimeSpanTokenizer tokenizer, int minDigitLength, int maxDigitLength, out int zeroes, out int result)
		{
			int num = 0;
			int num2 = 0;
			int i;
			for (i = 0; i < maxDigitLength; i++)
			{
				char nextChar = tokenizer.NextChar;
				if (nextChar < '0' || nextChar > '9')
				{
					tokenizer.BackOne();
					break;
				}
				num = num * 10 + (int)(nextChar - '0');
				if (num == 0)
				{
					num2++;
				}
			}
			zeroes = num2;
			result = num;
			return i >= minDigitLength;
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x000AC3B8 File Offset: 0x000AA5B8
		private static bool ParseExactLiteral(ref TimeSpanParse.TimeSpanTokenizer tokenizer, StringBuilder enquotedString)
		{
			for (int i = 0; i < enquotedString.Length; i++)
			{
				if (enquotedString[i] != tokenizer.NextChar)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x000AC3E8 File Offset: 0x000AA5E8
		private static bool TryParseTimeSpanConstant(ReadOnlySpan<char> input, ref TimeSpanParse.TimeSpanResult result)
		{
			return default(TimeSpanParse.StringParser).TryParse(input, ref result);
		}

		// Token: 0x02000590 RID: 1424
		private enum ParseFailureKind : byte
		{
			// Token: 0x040016C4 RID: 5828
			None,
			// Token: 0x040016C5 RID: 5829
			ArgumentNull,
			// Token: 0x040016C6 RID: 5830
			Format,
			// Token: 0x040016C7 RID: 5831
			FormatWithParameter,
			// Token: 0x040016C8 RID: 5832
			Overflow
		}

		// Token: 0x02000591 RID: 1425
		[Flags]
		private enum TimeSpanStandardStyles : byte
		{
			// Token: 0x040016CA RID: 5834
			None = 0,
			// Token: 0x040016CB RID: 5835
			Invariant = 1,
			// Token: 0x040016CC RID: 5836
			Localized = 2,
			// Token: 0x040016CD RID: 5837
			RequireFull = 4,
			// Token: 0x040016CE RID: 5838
			Any = 3
		}

		// Token: 0x02000592 RID: 1426
		private enum TTT : byte
		{
			// Token: 0x040016D0 RID: 5840
			None,
			// Token: 0x040016D1 RID: 5841
			End,
			// Token: 0x040016D2 RID: 5842
			Num,
			// Token: 0x040016D3 RID: 5843
			Sep,
			// Token: 0x040016D4 RID: 5844
			NumOverflow
		}

		// Token: 0x02000593 RID: 1427
		private ref struct TimeSpanToken
		{
			// Token: 0x06002A9B RID: 10907 RVA: 0x000AC408 File Offset: 0x000AA608
			public TimeSpanToken(TimeSpanParse.TTT type)
			{
				this = new TimeSpanParse.TimeSpanToken(type, 0, 0, default(ReadOnlySpan<char>));
			}

			// Token: 0x06002A9C RID: 10908 RVA: 0x000AC428 File Offset: 0x000AA628
			public TimeSpanToken(int number)
			{
				this = new TimeSpanParse.TimeSpanToken(TimeSpanParse.TTT.Num, number, 0, default(ReadOnlySpan<char>));
			}

			// Token: 0x06002A9D RID: 10909 RVA: 0x000AC448 File Offset: 0x000AA648
			public TimeSpanToken(int number, int leadingZeroes)
			{
				this = new TimeSpanParse.TimeSpanToken(TimeSpanParse.TTT.Num, number, leadingZeroes, default(ReadOnlySpan<char>));
			}

			// Token: 0x06002A9E RID: 10910 RVA: 0x000AC467 File Offset: 0x000AA667
			public TimeSpanToken(TimeSpanParse.TTT type, int number, int leadingZeroes, ReadOnlySpan<char> separator)
			{
				this._ttt = type;
				this._num = number;
				this._zeroes = leadingZeroes;
				this._sep = separator;
			}

			// Token: 0x06002A9F RID: 10911 RVA: 0x000AC488 File Offset: 0x000AA688
			public bool IsInvalidFraction()
			{
				return this._num > 9999999 || this._zeroes > 7 || (this._num != 0 && this._zeroes != 0 && (long)this._num >= 9999999L / TimeSpanParse.Pow10(this._zeroes - 1));
			}

			// Token: 0x040016D5 RID: 5845
			internal TimeSpanParse.TTT _ttt;

			// Token: 0x040016D6 RID: 5846
			internal int _num;

			// Token: 0x040016D7 RID: 5847
			internal int _zeroes;

			// Token: 0x040016D8 RID: 5848
			internal ReadOnlySpan<char> _sep;
		}

		// Token: 0x02000594 RID: 1428
		private ref struct TimeSpanTokenizer
		{
			// Token: 0x06002AA0 RID: 10912 RVA: 0x000AC4DF File Offset: 0x000AA6DF
			internal TimeSpanTokenizer(ReadOnlySpan<char> input)
			{
				this = new TimeSpanParse.TimeSpanTokenizer(input, 0);
			}

			// Token: 0x06002AA1 RID: 10913 RVA: 0x000AC4E9 File Offset: 0x000AA6E9
			internal TimeSpanTokenizer(ReadOnlySpan<char> input, int startPosition)
			{
				this._value = input;
				this._pos = startPosition;
			}

			// Token: 0x06002AA2 RID: 10914 RVA: 0x000AC4FC File Offset: 0x000AA6FC
			internal unsafe TimeSpanParse.TimeSpanToken GetNextToken()
			{
				int pos = this._pos;
				if (pos >= this._value.Length)
				{
					return new TimeSpanParse.TimeSpanToken(TimeSpanParse.TTT.End);
				}
				int num = (int)(*this._value[pos] - 48);
				if (num <= 9)
				{
					int num2 = 0;
					if (num == 0)
					{
						num2 = 1;
						int num4;
						for (;;)
						{
							int num3 = this._pos + 1;
							this._pos = num3;
							if (num3 >= this._value.Length || (num4 = (int)(*this._value[this._pos] - 48)) > 9)
							{
								break;
							}
							if (num4 != 0)
							{
								goto IL_99;
							}
							num2++;
						}
						return new TimeSpanParse.TimeSpanToken(TimeSpanParse.TTT.Num, 0, num2, default(ReadOnlySpan<char>));
						IL_99:
						num = num4;
					}
					do
					{
						int num3 = this._pos + 1;
						this._pos = num3;
						if (num3 >= this._value.Length)
						{
							goto IL_F6;
						}
						int num5 = (int)(*this._value[this._pos] - 48);
						if (num5 > 9)
						{
							goto IL_F6;
						}
						num = num * 10 + num5;
					}
					while (((long)num & (long)((ulong)-268435456)) == 0L);
					return new TimeSpanParse.TimeSpanToken(TimeSpanParse.TTT.NumOverflow);
					IL_F6:
					return new TimeSpanParse.TimeSpanToken(TimeSpanParse.TTT.Num, num, num2, default(ReadOnlySpan<char>));
				}
				int num6 = 1;
				for (;;)
				{
					int num3 = this._pos + 1;
					this._pos = num3;
					if (num3 >= this._value.Length || *this._value[this._pos] - 48 <= 9)
					{
						break;
					}
					num6++;
				}
				return new TimeSpanParse.TimeSpanToken(TimeSpanParse.TTT.Sep, 0, 0, this._value.Slice(pos, num6));
			}

			// Token: 0x1700064E RID: 1614
			// (get) Token: 0x06002AA3 RID: 10915 RVA: 0x000AC669 File Offset: 0x000AA869
			internal bool EOL
			{
				get
				{
					return this._pos >= this._value.Length - 1;
				}
			}

			// Token: 0x06002AA4 RID: 10916 RVA: 0x000AC683 File Offset: 0x000AA883
			internal void BackOne()
			{
				if (this._pos > 0)
				{
					this._pos--;
				}
			}

			// Token: 0x1700064F RID: 1615
			// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x000AC69C File Offset: 0x000AA89C
			internal unsafe char NextChar
			{
				get
				{
					int num = this._pos + 1;
					this._pos = num;
					int num2 = num;
					if (num2 >= this._value.Length)
					{
						return '\0';
					}
					return (char)(*this._value[num2]);
				}
			}

			// Token: 0x040016D9 RID: 5849
			private ReadOnlySpan<char> _value;

			// Token: 0x040016DA RID: 5850
			private int _pos;
		}

		// Token: 0x02000595 RID: 1429
		private ref struct TimeSpanRawInfo
		{
			// Token: 0x17000650 RID: 1616
			// (get) Token: 0x06002AA6 RID: 10918 RVA: 0x000AC6D8 File Offset: 0x000AA8D8
			internal TimeSpanFormat.FormatLiterals PositiveInvariant
			{
				get
				{
					return TimeSpanFormat.PositiveInvariantFormatLiterals;
				}
			}

			// Token: 0x17000651 RID: 1617
			// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x000AC6DF File Offset: 0x000AA8DF
			internal TimeSpanFormat.FormatLiterals NegativeInvariant
			{
				get
				{
					return TimeSpanFormat.NegativeInvariantFormatLiterals;
				}
			}

			// Token: 0x17000652 RID: 1618
			// (get) Token: 0x06002AA8 RID: 10920 RVA: 0x000AC6E6 File Offset: 0x000AA8E6
			internal TimeSpanFormat.FormatLiterals PositiveLocalized
			{
				get
				{
					if (!this._posLocInit)
					{
						this._posLoc = default(TimeSpanFormat.FormatLiterals);
						this._posLoc.Init(this._fullPosPattern, false);
						this._posLocInit = true;
					}
					return this._posLoc;
				}
			}

			// Token: 0x17000653 RID: 1619
			// (get) Token: 0x06002AA9 RID: 10921 RVA: 0x000AC720 File Offset: 0x000AA920
			internal TimeSpanFormat.FormatLiterals NegativeLocalized
			{
				get
				{
					if (!this._negLocInit)
					{
						this._negLoc = default(TimeSpanFormat.FormatLiterals);
						this._negLoc.Init(this._fullNegPattern, false);
						this._negLocInit = true;
					}
					return this._negLoc;
				}
			}

			// Token: 0x06002AAA RID: 10922 RVA: 0x000AC75C File Offset: 0x000AA95C
			internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 5 && this._numCount == 4 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.DayHourSep) && this._literals2.EqualsOrdinal(pattern.HourMinuteSep) && this._literals3.EqualsOrdinal(pattern.AppCompatLiteral) && this._literals4.EqualsOrdinal(pattern.End);
			}

			// Token: 0x06002AAB RID: 10923 RVA: 0x000AC7FC File Offset: 0x000AA9FC
			internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 4 && this._numCount == 3 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.HourMinuteSep) && this._literals2.EqualsOrdinal(pattern.AppCompatLiteral) && this._literals3.EqualsOrdinal(pattern.End);
			}

			// Token: 0x06002AAC RID: 10924 RVA: 0x000AC880 File Offset: 0x000AAA80
			internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 6 && this._numCount == 5 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.DayHourSep) && this._literals2.EqualsOrdinal(pattern.HourMinuteSep) && this._literals3.EqualsOrdinal(pattern.MinuteSecondSep) && this._literals4.EqualsOrdinal(pattern.SecondFractionSep) && this._literals5.EqualsOrdinal(pattern.End);
			}

			// Token: 0x06002AAD RID: 10925 RVA: 0x000AC93C File Offset: 0x000AAB3C
			internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 2 && this._numCount == 1 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.End);
			}

			// Token: 0x06002AAE RID: 10926 RVA: 0x000AC990 File Offset: 0x000AAB90
			internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 3 && this._numCount == 2 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.HourMinuteSep) && this._literals2.EqualsOrdinal(pattern.End);
			}

			// Token: 0x06002AAF RID: 10927 RVA: 0x000AC9FC File Offset: 0x000AABFC
			internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 4 && this._numCount == 3 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.DayHourSep) && this._literals2.EqualsOrdinal(pattern.HourMinuteSep) && this._literals3.EqualsOrdinal(pattern.End);
			}

			// Token: 0x06002AB0 RID: 10928 RVA: 0x000ACA80 File Offset: 0x000AAC80
			internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 4 && this._numCount == 3 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.HourMinuteSep) && this._literals2.EqualsOrdinal(pattern.MinuteSecondSep) && this._literals3.EqualsOrdinal(pattern.End);
			}

			// Token: 0x06002AB1 RID: 10929 RVA: 0x000ACB04 File Offset: 0x000AAD04
			internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 5 && this._numCount == 4 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.DayHourSep) && this._literals2.EqualsOrdinal(pattern.HourMinuteSep) && this._literals3.EqualsOrdinal(pattern.MinuteSecondSep) && this._literals4.EqualsOrdinal(pattern.End);
			}

			// Token: 0x06002AB2 RID: 10930 RVA: 0x000ACBA4 File Offset: 0x000AADA4
			internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 5 && this._numCount == 4 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.HourMinuteSep) && this._literals2.EqualsOrdinal(pattern.MinuteSecondSep) && this._literals3.EqualsOrdinal(pattern.SecondFractionSep) && this._literals4.EqualsOrdinal(pattern.End);
			}

			// Token: 0x06002AB3 RID: 10931 RVA: 0x000ACC44 File Offset: 0x000AAE44
			internal void Init(DateTimeFormatInfo dtfi)
			{
				this._lastSeenTTT = TimeSpanParse.TTT.None;
				this._tokenCount = 0;
				this._sepCount = 0;
				this._numCount = 0;
				this._fullPosPattern = dtfi.FullTimeSpanPositivePattern;
				this._fullNegPattern = dtfi.FullTimeSpanNegativePattern;
				this._posLocInit = false;
				this._negLocInit = false;
			}

			// Token: 0x06002AB4 RID: 10932 RVA: 0x000ACC94 File Offset: 0x000AAE94
			internal bool ProcessToken(ref TimeSpanParse.TimeSpanToken tok, ref TimeSpanParse.TimeSpanResult result)
			{
				switch (tok._ttt)
				{
				case TimeSpanParse.TTT.Num:
					if ((this._tokenCount == 0 && !this.AddSep(default(ReadOnlySpan<char>), ref result)) || !this.AddNum(tok, ref result))
					{
						return false;
					}
					break;
				case TimeSpanParse.TTT.Sep:
					if (!this.AddSep(tok._sep, ref result))
					{
						return false;
					}
					break;
				case TimeSpanParse.TTT.NumOverflow:
					return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
				default:
					return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
				}
				this._lastSeenTTT = tok._ttt;
				return true;
			}

			// Token: 0x06002AB5 RID: 10933 RVA: 0x000ACD28 File Offset: 0x000AAF28
			private bool AddSep(ReadOnlySpan<char> sep, ref TimeSpanParse.TimeSpanResult result)
			{
				if (this._sepCount >= 6 || this._tokenCount >= 11)
				{
					return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
				}
				int sepCount = this._sepCount;
				this._sepCount = sepCount + 1;
				switch (sepCount)
				{
				case 0:
					this._literals0 = sep;
					break;
				case 1:
					this._literals1 = sep;
					break;
				case 2:
					this._literals2 = sep;
					break;
				case 3:
					this._literals3 = sep;
					break;
				case 4:
					this._literals4 = sep;
					break;
				default:
					this._literals5 = sep;
					break;
				}
				this._tokenCount++;
				return true;
			}

			// Token: 0x06002AB6 RID: 10934 RVA: 0x000ACDC8 File Offset: 0x000AAFC8
			private bool AddNum(TimeSpanParse.TimeSpanToken num, ref TimeSpanParse.TimeSpanResult result)
			{
				if (this._numCount >= 5 || this._tokenCount >= 11)
				{
					return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
				}
				int numCount = this._numCount;
				this._numCount = numCount + 1;
				switch (numCount)
				{
				case 0:
					this._numbers0 = num;
					break;
				case 1:
					this._numbers1 = num;
					break;
				case 2:
					this._numbers2 = num;
					break;
				case 3:
					this._numbers3 = num;
					break;
				default:
					this._numbers4 = num;
					break;
				}
				this._tokenCount++;
				return true;
			}

			// Token: 0x040016DB RID: 5851
			internal TimeSpanParse.TTT _lastSeenTTT;

			// Token: 0x040016DC RID: 5852
			internal int _tokenCount;

			// Token: 0x040016DD RID: 5853
			internal int _sepCount;

			// Token: 0x040016DE RID: 5854
			internal int _numCount;

			// Token: 0x040016DF RID: 5855
			private TimeSpanFormat.FormatLiterals _posLoc;

			// Token: 0x040016E0 RID: 5856
			private TimeSpanFormat.FormatLiterals _negLoc;

			// Token: 0x040016E1 RID: 5857
			private bool _posLocInit;

			// Token: 0x040016E2 RID: 5858
			private bool _negLocInit;

			// Token: 0x040016E3 RID: 5859
			private string _fullPosPattern;

			// Token: 0x040016E4 RID: 5860
			private string _fullNegPattern;

			// Token: 0x040016E5 RID: 5861
			internal TimeSpanParse.TimeSpanToken _numbers0;

			// Token: 0x040016E6 RID: 5862
			internal TimeSpanParse.TimeSpanToken _numbers1;

			// Token: 0x040016E7 RID: 5863
			internal TimeSpanParse.TimeSpanToken _numbers2;

			// Token: 0x040016E8 RID: 5864
			internal TimeSpanParse.TimeSpanToken _numbers3;

			// Token: 0x040016E9 RID: 5865
			internal TimeSpanParse.TimeSpanToken _numbers4;

			// Token: 0x040016EA RID: 5866
			internal ReadOnlySpan<char> _literals0;

			// Token: 0x040016EB RID: 5867
			internal ReadOnlySpan<char> _literals1;

			// Token: 0x040016EC RID: 5868
			internal ReadOnlySpan<char> _literals2;

			// Token: 0x040016ED RID: 5869
			internal ReadOnlySpan<char> _literals3;

			// Token: 0x040016EE RID: 5870
			internal ReadOnlySpan<char> _literals4;

			// Token: 0x040016EF RID: 5871
			internal ReadOnlySpan<char> _literals5;
		}

		// Token: 0x02000596 RID: 1430
		private struct TimeSpanResult
		{
			// Token: 0x06002AB7 RID: 10935 RVA: 0x000ACE5B File Offset: 0x000AB05B
			internal TimeSpanResult(bool throwOnFailure)
			{
				this.parsedTimeSpan = default(TimeSpan);
				this._throwOnFailure = throwOnFailure;
			}

			// Token: 0x06002AB8 RID: 10936 RVA: 0x000ACE70 File Offset: 0x000AB070
			internal bool SetFailure(TimeSpanParse.ParseFailureKind kind, string resourceKey, object messageArgument = null, string argumentName = null)
			{
				if (!this._throwOnFailure)
				{
					return false;
				}
				string resourceString = SR.GetResourceString(resourceKey);
				switch (kind)
				{
				case TimeSpanParse.ParseFailureKind.ArgumentNull:
					throw new ArgumentNullException(argumentName, resourceString);
				case TimeSpanParse.ParseFailureKind.FormatWithParameter:
					throw new FormatException(SR.Format(resourceString, messageArgument));
				case TimeSpanParse.ParseFailureKind.Overflow:
					throw new OverflowException(resourceString);
				}
				throw new FormatException(resourceString);
			}

			// Token: 0x040016F0 RID: 5872
			internal TimeSpan parsedTimeSpan;

			// Token: 0x040016F1 RID: 5873
			private readonly bool _throwOnFailure;
		}

		// Token: 0x02000597 RID: 1431
		private ref struct StringParser
		{
			// Token: 0x06002AB9 RID: 10937 RVA: 0x000ACECC File Offset: 0x000AB0CC
			internal unsafe void NextChar()
			{
				if (this._pos < this._len)
				{
					this._pos++;
				}
				this._ch = (char)((this._pos < this._len) ? (*this._str[this._pos]) : 0);
			}

			// Token: 0x06002ABA RID: 10938 RVA: 0x000ACF20 File Offset: 0x000AB120
			internal unsafe char NextNonDigit()
			{
				for (int i = this._pos; i < this._len; i++)
				{
					char c = (char)(*this._str[i]);
					if (c < '0' || c > '9')
					{
						return c;
					}
				}
				return '\0';
			}

			// Token: 0x06002ABB RID: 10939 RVA: 0x000ACF60 File Offset: 0x000AB160
			internal bool TryParse(ReadOnlySpan<char> input, ref TimeSpanParse.TimeSpanResult result)
			{
				result.parsedTimeSpan = default(TimeSpan);
				this._str = input;
				this._len = input.Length;
				this._pos = -1;
				this.NextChar();
				this.SkipBlanks();
				bool flag = false;
				if (this._ch == '-')
				{
					flag = true;
					this.NextChar();
				}
				long num;
				if (this.NextNonDigit() == ':')
				{
					if (!this.ParseTime(out num, ref result))
					{
						return false;
					}
				}
				else
				{
					int num2;
					if (!this.ParseInt(10675199, out num2, ref result))
					{
						return false;
					}
					num = (long)num2 * 864000000000L;
					if (this._ch == '.')
					{
						this.NextChar();
						long num3;
						if (!this.ParseTime(out num3, ref result))
						{
							return false;
						}
						num += num3;
					}
				}
				if (flag)
				{
					num = -num;
					if (num > 0L)
					{
						return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
					}
				}
				else if (num < 0L)
				{
					return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
				}
				this.SkipBlanks();
				if (this._pos < this._len)
				{
					return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
				}
				result.parsedTimeSpan = new TimeSpan(num);
				return true;
			}

			// Token: 0x06002ABC RID: 10940 RVA: 0x000AD06C File Offset: 0x000AB26C
			internal bool ParseInt(int max, out int i, ref TimeSpanParse.TimeSpanResult result)
			{
				i = 0;
				int pos = this._pos;
				while (this._ch >= '0' && this._ch <= '9')
				{
					if (((long)i & (long)((ulong)-268435456)) != 0L)
					{
						return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
					}
					i = i * 10 + (int)this._ch - 48;
					if (i < 0)
					{
						return result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
					}
					this.NextChar();
				}
				if (pos == this._pos)
				{
					return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
				}
				return i <= max || result.SetFailure(TimeSpanParse.ParseFailureKind.Overflow, "The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.", null, null);
			}

			// Token: 0x06002ABD RID: 10941 RVA: 0x000AD10C File Offset: 0x000AB30C
			internal bool ParseTime(out long time, ref TimeSpanParse.TimeSpanResult result)
			{
				time = 0L;
				int num;
				if (!this.ParseInt(23, out num, ref result))
				{
					return false;
				}
				time = (long)num * 36000000000L;
				if (this._ch != ':')
				{
					return result.SetFailure(TimeSpanParse.ParseFailureKind.Format, "String was not recognized as a valid TimeSpan.", null, null);
				}
				this.NextChar();
				if (!this.ParseInt(59, out num, ref result))
				{
					return false;
				}
				time += (long)num * 600000000L;
				if (this._ch == ':')
				{
					this.NextChar();
					if (this._ch != '.')
					{
						if (!this.ParseInt(59, out num, ref result))
						{
							return false;
						}
						time += (long)num * 10000000L;
					}
					if (this._ch == '.')
					{
						this.NextChar();
						int num2 = 10000000;
						while (num2 > 1 && this._ch >= '0' && this._ch <= '9')
						{
							num2 /= 10;
							time += (long)((int)(this._ch - '0') * num2);
							this.NextChar();
						}
					}
				}
				return true;
			}

			// Token: 0x06002ABE RID: 10942 RVA: 0x000AD1FA File Offset: 0x000AB3FA
			internal void SkipBlanks()
			{
				while (this._ch == ' ' || this._ch == '\t')
				{
					this.NextChar();
				}
			}

			// Token: 0x040016F2 RID: 5874
			private ReadOnlySpan<char> _str;

			// Token: 0x040016F3 RID: 5875
			private char _ch;

			// Token: 0x040016F4 RID: 5876
			private int _pos;

			// Token: 0x040016F5 RID: 5877
			private int _len;
		}
	}
}
