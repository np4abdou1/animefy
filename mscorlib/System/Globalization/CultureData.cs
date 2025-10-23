using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace System.Globalization
{
	// Token: 0x020005A7 RID: 1447
	[StructLayout(0)]
	internal class CultureData
	{
		// Token: 0x06002B98 RID: 11160 RVA: 0x000B01B7 File Offset: 0x000AE3B7
		private CultureData(string name)
		{
			this.sRealName = name;
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002B99 RID: 11161 RVA: 0x000B01C8 File Offset: 0x000AE3C8
		public static CultureData Invariant
		{
			get
			{
				if (CultureData.s_Invariant == null)
				{
					CultureData cultureData = new CultureData("");
					cultureData.sISO639Language = "iv";
					cultureData.sAM1159 = "AM";
					cultureData.sPM2359 = "PM";
					cultureData.sTimeSeparator = ":";
					cultureData.saLongTimes = new string[]
					{
						"HH:mm:ss"
					};
					cultureData.saShortTimes = new string[]
					{
						"HH:mm",
						"hh:mm tt",
						"H:mm",
						"h:mm tt"
					};
					cultureData.iFirstDayOfWeek = 0;
					cultureData.iFirstWeekOfYear = 0;
					cultureData.waCalendars = new int[]
					{
						1
					};
					cultureData.calendars = new CalendarData[23];
					cultureData.calendars[0] = CalendarData.Invariant;
					cultureData.iDefaultAnsiCodePage = 1252;
					cultureData.iDefaultOemCodePage = 437;
					cultureData.iDefaultMacCodePage = 10000;
					cultureData.iDefaultEbcdicCodePage = 37;
					cultureData.sListSeparator = ",";
					Interlocked.CompareExchange<CultureData>(ref CultureData.s_Invariant, cultureData, null);
				}
				return CultureData.s_Invariant;
			}
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x000B02DC File Offset: 0x000AE4DC
		public static CultureData GetCultureData(string cultureName, bool useUserOverride)
		{
			CultureData result;
			try
			{
				result = new CultureInfo(cultureName, useUserOverride).m_cultureData;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x000B0310 File Offset: 0x000AE510
		public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator)
		{
			if (string.IsNullOrEmpty(cultureName))
			{
				return CultureData.Invariant;
			}
			CultureData cultureData = new CultureData(cultureName);
			cultureData.fill_culture_data(datetimeIndex);
			cultureData.bUseOverrides = useUserOverride;
			cultureData.calendarId = calendarId;
			cultureData.numberIndex = numberIndex;
			cultureData.sISO639Language = iso2lang;
			cultureData.iDefaultAnsiCodePage = ansiCodePage;
			cultureData.iDefaultOemCodePage = oemCodePage;
			cultureData.iDefaultMacCodePage = macCodePage;
			cultureData.iDefaultEbcdicCodePage = ebcdicCodePage;
			cultureData.isRightToLeft = rightToLeft;
			cultureData.sListSeparator = listSeparator;
			return cultureData;
		}

		// Token: 0x06002B9C RID: 11164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void fill_culture_data(int datetimeIndex);

		// Token: 0x06002B9D RID: 11165 RVA: 0x000B0388 File Offset: 0x000AE588
		public CalendarData GetCalendar(int calendarId)
		{
			int num = calendarId - 1;
			if (this.calendars == null)
			{
				this.calendars = new CalendarData[23];
			}
			CalendarData calendarData = this.calendars[num];
			if (calendarData == null)
			{
				calendarData = new CalendarData(this.sRealName, calendarId, this.bUseOverrides);
				this.calendars[num] = calendarData;
			}
			return calendarData;
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002B9E RID: 11166 RVA: 0x000B03D7 File Offset: 0x000AE5D7
		internal string[] LongTimes
		{
			get
			{
				return this.saLongTimes;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x000B03E1 File Offset: 0x000AE5E1
		internal string[] ShortTimes
		{
			get
			{
				return this.saShortTimes;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06002BA0 RID: 11168 RVA: 0x000B03EB File Offset: 0x000AE5EB
		internal string SISO639LANGNAME
		{
			get
			{
				return this.sISO639Language;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x000B03F3 File Offset: 0x000AE5F3
		internal int IFIRSTDAYOFWEEK
		{
			get
			{
				return this.iFirstDayOfWeek;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x000B03FB File Offset: 0x000AE5FB
		internal int IFIRSTWEEKOFYEAR
		{
			get
			{
				return this.iFirstWeekOfYear;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x000B0403 File Offset: 0x000AE603
		internal string SAM1159
		{
			get
			{
				return this.sAM1159;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x000B040B File Offset: 0x000AE60B
		internal string SPM2359
		{
			get
			{
				return this.sPM2359;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x000B0413 File Offset: 0x000AE613
		internal string TimeSeparator
		{
			get
			{
				return this.sTimeSeparator;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x000B041C File Offset: 0x000AE61C
		internal int[] CalendarIds
		{
			get
			{
				if (this.waCalendars == null)
				{
					string a = this.sISO639Language;
					if (!(a == "ja"))
					{
						if (!(a == "zh"))
						{
							if (!(a == "he"))
							{
								this.waCalendars = new int[]
								{
									this.calendarId
								};
							}
							else
							{
								this.waCalendars = new int[]
								{
									this.calendarId,
									8
								};
							}
						}
						else
						{
							this.waCalendars = new int[]
							{
								this.calendarId,
								4
							};
						}
					}
					else
					{
						this.waCalendars = new int[]
						{
							this.calendarId,
							3
						};
					}
				}
				return this.waCalendars;
			}
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x000B04DC File Offset: 0x000AE6DC
		internal CalendarId[] GetCalendarIds()
		{
			CalendarId[] array = new CalendarId[this.CalendarIds.Length];
			for (int i = 0; i < this.CalendarIds.Length; i++)
			{
				array[i] = (CalendarId)this.CalendarIds[i];
			}
			return array;
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06002BA8 RID: 11176 RVA: 0x000B0517 File Offset: 0x000AE717
		internal bool IsInvariantCulture
		{
			get
			{
				return string.IsNullOrEmpty(this.sRealName);
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x000B0524 File Offset: 0x000AE724
		internal string CultureName
		{
			get
			{
				return this.sRealName;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06002BAA RID: 11178 RVA: 0x000B052C File Offset: 0x000AE72C
		internal string SCOMPAREINFO
		{
			get
			{
				return "";
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06002BAB RID: 11179 RVA: 0x000B0524 File Offset: 0x000AE724
		internal string STEXTINFO
		{
			get
			{
				return this.sRealName;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x000B0533 File Offset: 0x000AE733
		internal int IDEFAULTANSICODEPAGE
		{
			get
			{
				return this.iDefaultAnsiCodePage;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002BAD RID: 11181 RVA: 0x000B053B File Offset: 0x000AE73B
		internal bool UseUserOverride
		{
			get
			{
				return this.bUseOverrides;
			}
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x000B0543 File Offset: 0x000AE743
		internal string[] EraNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saEraNames;
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x000B0551 File Offset: 0x000AE751
		internal string[] AbbrevEraNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saAbbrevEraNames;
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x000B055F File Offset: 0x000AE75F
		internal string[] AbbreviatedEnglishEraNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saAbbrevEnglishEraNames;
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x000B056D File Offset: 0x000AE76D
		internal string[] ShortDates(int calendarId)
		{
			return this.GetCalendar(calendarId).saShortDates;
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x000B057B File Offset: 0x000AE77B
		internal string[] LongDates(int calendarId)
		{
			return this.GetCalendar(calendarId).saLongDates;
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x000B0589 File Offset: 0x000AE789
		internal string[] YearMonths(int calendarId)
		{
			return this.GetCalendar(calendarId).saYearMonths;
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x000B0597 File Offset: 0x000AE797
		internal string[] DayNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saDayNames;
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x000B05A5 File Offset: 0x000AE7A5
		internal string[] AbbreviatedDayNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saAbbrevDayNames;
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x000B05B3 File Offset: 0x000AE7B3
		internal string[] MonthNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saMonthNames;
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x000B05C1 File Offset: 0x000AE7C1
		internal string[] GenitiveMonthNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saMonthGenitiveNames;
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x000B05CF File Offset: 0x000AE7CF
		internal string[] AbbreviatedMonthNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saAbbrevMonthNames;
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x000B05DD File Offset: 0x000AE7DD
		internal string[] AbbreviatedGenitiveMonthNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saAbbrevMonthGenitiveNames;
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x000B05EB File Offset: 0x000AE7EB
		internal string[] LeapYearMonthNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saLeapYearMonthNames;
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x000B05F9 File Offset: 0x000AE7F9
		internal string MonthDay(int calendarId)
		{
			return this.GetCalendar(calendarId).sMonthDay;
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x000B0607 File Offset: 0x000AE807
		internal string DateSeparator(int calendarId)
		{
			if (calendarId == 3 && !AppContextSwitches.EnforceLegacyJapaneseDateParsing)
			{
				return "/";
			}
			return CultureData.GetDateSeparator(this.ShortDates(calendarId)[0]);
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x000B0628 File Offset: 0x000AE828
		private static string GetDateSeparator(string format)
		{
			return CultureData.GetSeparator(format, "dyM");
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x000B0638 File Offset: 0x000AE838
		private static string GetSeparator(string format, string timeParts)
		{
			int num = CultureData.IndexOfTimePart(format, 0, timeParts);
			if (num != -1)
			{
				char c = format[num];
				do
				{
					num++;
				}
				while (num < format.Length && format[num] == c);
				int num2 = num;
				if (num2 < format.Length)
				{
					int num3 = CultureData.IndexOfTimePart(format, num2, timeParts);
					if (num3 != -1)
					{
						return CultureData.UnescapeNlsString(format, num2, num3 - 1);
					}
				}
			}
			return string.Empty;
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x000B069C File Offset: 0x000AE89C
		private static int IndexOfTimePart(string format, int startIndex, string timeParts)
		{
			bool flag = false;
			for (int i = startIndex; i < format.Length; i++)
			{
				if (!flag && timeParts.IndexOf(format[i]) != -1)
				{
					return i;
				}
				char c = format[i];
				if (c != '\'')
				{
					if (c == '\\' && i + 1 < format.Length)
					{
						i++;
						char c2 = format[i];
						if (c2 != '\'' && c2 != '\\')
						{
							i--;
						}
					}
				}
				else
				{
					flag = !flag;
				}
			}
			return -1;
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x000B0710 File Offset: 0x000AE910
		private static string UnescapeNlsString(string str, int start, int end)
		{
			StringBuilder stringBuilder = null;
			int num = start;
			while (num < str.Length && num <= end)
			{
				char c = str[num];
				if (c != '\'')
				{
					if (c != '\\')
					{
						if (stringBuilder != null)
						{
							stringBuilder.Append(str[num]);
						}
					}
					else
					{
						if (stringBuilder == null)
						{
							stringBuilder = new StringBuilder(str, start, num - start, str.Length);
						}
						num++;
						if (num < str.Length)
						{
							stringBuilder.Append(str[num]);
						}
					}
				}
				else if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(str, start, num - start, str.Length);
				}
				num++;
			}
			if (stringBuilder == null)
			{
				return str.Substring(start, end - start + 1);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x0000245A File Offset: 0x0000065A
		internal static string[] ReescapeWin32Strings(string[] array)
		{
			return array;
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x0000245A File Offset: 0x0000065A
		internal static string ReescapeWin32String(string str)
		{
			return str;
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x000B07B8 File Offset: 0x000AE9B8
		private unsafe static int strlen(byte* s)
		{
			int num = 0;
			while (s[num] != 0)
			{
				num++;
			}
			return num;
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x000B07D4 File Offset: 0x000AE9D4
		private unsafe static string idx2string(byte* data, int idx)
		{
			return Encoding.UTF8.GetString(data + idx, CultureData.strlen(data + idx));
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x000B07EB File Offset: 0x000AE9EB
		private int[] create_group_sizes_array(int gs0, int gs1)
		{
			if (gs0 == -1)
			{
				return new int[0];
			}
			if (gs1 != -1)
			{
				return new int[]
				{
					gs0,
					gs1
				};
			}
			return new int[]
			{
				gs0
			};
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x000B0818 File Offset: 0x000AEA18
		internal unsafe void GetNFIValues(NumberFormatInfo nfi)
		{
			if (!this.IsInvariantCulture)
			{
				CultureData.NumberFormatEntryManaged numberFormatEntryManaged = default(CultureData.NumberFormatEntryManaged);
				byte* data = CultureData.fill_number_data(this.numberIndex, ref numberFormatEntryManaged);
				nfi.currencyGroupSizes = this.create_group_sizes_array(numberFormatEntryManaged.currency_group_sizes0, numberFormatEntryManaged.currency_group_sizes1);
				nfi.numberGroupSizes = this.create_group_sizes_array(numberFormatEntryManaged.number_group_sizes0, numberFormatEntryManaged.number_group_sizes1);
				nfi.NaNSymbol = CultureData.idx2string(data, numberFormatEntryManaged.nan_symbol);
				nfi.currencyDecimalDigits = numberFormatEntryManaged.currency_decimal_digits;
				nfi.currencyDecimalSeparator = CultureData.idx2string(data, numberFormatEntryManaged.currency_decimal_separator);
				nfi.currencyGroupSeparator = CultureData.idx2string(data, numberFormatEntryManaged.currency_group_separator);
				nfi.currencyNegativePattern = numberFormatEntryManaged.currency_negative_pattern;
				nfi.currencyPositivePattern = numberFormatEntryManaged.currency_positive_pattern;
				nfi.currencySymbol = CultureData.idx2string(data, numberFormatEntryManaged.currency_symbol);
				nfi.negativeInfinitySymbol = CultureData.idx2string(data, numberFormatEntryManaged.negative_infinity_symbol);
				nfi.negativeSign = CultureData.idx2string(data, numberFormatEntryManaged.negative_sign);
				nfi.numberDecimalDigits = numberFormatEntryManaged.number_decimal_digits;
				nfi.numberDecimalSeparator = CultureData.idx2string(data, numberFormatEntryManaged.number_decimal_separator);
				nfi.numberGroupSeparator = CultureData.idx2string(data, numberFormatEntryManaged.number_group_separator);
				nfi.numberNegativePattern = numberFormatEntryManaged.number_negative_pattern;
				nfi.perMilleSymbol = CultureData.idx2string(data, numberFormatEntryManaged.per_mille_symbol);
				nfi.percentNegativePattern = numberFormatEntryManaged.percent_negative_pattern;
				nfi.percentPositivePattern = numberFormatEntryManaged.percent_positive_pattern;
				nfi.percentSymbol = CultureData.idx2string(data, numberFormatEntryManaged.percent_symbol);
				nfi.positiveInfinitySymbol = CultureData.idx2string(data, numberFormatEntryManaged.positive_infinity_symbol);
				nfi.positiveSign = CultureData.idx2string(data, numberFormatEntryManaged.positive_sign);
			}
			nfi.percentDecimalDigits = nfi.numberDecimalDigits;
			nfi.percentDecimalSeparator = nfi.numberDecimalSeparator;
			nfi.percentGroupSizes = nfi.numberGroupSizes;
			nfi.percentGroupSeparator = nfi.numberGroupSeparator;
		}

		// Token: 0x06002BC7 RID: 11207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern byte* fill_number_data(int index, ref CultureData.NumberFormatEntryManaged nfe);

		// Token: 0x04001786 RID: 6022
		private string sAM1159;

		// Token: 0x04001787 RID: 6023
		private string sPM2359;

		// Token: 0x04001788 RID: 6024
		private string sTimeSeparator;

		// Token: 0x04001789 RID: 6025
		private volatile string[] saLongTimes;

		// Token: 0x0400178A RID: 6026
		private volatile string[] saShortTimes;

		// Token: 0x0400178B RID: 6027
		private int iFirstDayOfWeek;

		// Token: 0x0400178C RID: 6028
		private int iFirstWeekOfYear;

		// Token: 0x0400178D RID: 6029
		private volatile int[] waCalendars;

		// Token: 0x0400178E RID: 6030
		private CalendarData[] calendars;

		// Token: 0x0400178F RID: 6031
		private string sISO639Language;

		// Token: 0x04001790 RID: 6032
		private readonly string sRealName;

		// Token: 0x04001791 RID: 6033
		private bool bUseOverrides;

		// Token: 0x04001792 RID: 6034
		private int calendarId;

		// Token: 0x04001793 RID: 6035
		private int numberIndex;

		// Token: 0x04001794 RID: 6036
		private int iDefaultAnsiCodePage;

		// Token: 0x04001795 RID: 6037
		private int iDefaultOemCodePage;

		// Token: 0x04001796 RID: 6038
		private int iDefaultMacCodePage;

		// Token: 0x04001797 RID: 6039
		private int iDefaultEbcdicCodePage;

		// Token: 0x04001798 RID: 6040
		private bool isRightToLeft;

		// Token: 0x04001799 RID: 6041
		private string sListSeparator;

		// Token: 0x0400179A RID: 6042
		private static CultureData s_Invariant;

		// Token: 0x020005A8 RID: 1448
		internal struct NumberFormatEntryManaged
		{
			// Token: 0x0400179B RID: 6043
			internal int currency_decimal_digits;

			// Token: 0x0400179C RID: 6044
			internal int currency_decimal_separator;

			// Token: 0x0400179D RID: 6045
			internal int currency_group_separator;

			// Token: 0x0400179E RID: 6046
			internal int currency_group_sizes0;

			// Token: 0x0400179F RID: 6047
			internal int currency_group_sizes1;

			// Token: 0x040017A0 RID: 6048
			internal int currency_negative_pattern;

			// Token: 0x040017A1 RID: 6049
			internal int currency_positive_pattern;

			// Token: 0x040017A2 RID: 6050
			internal int currency_symbol;

			// Token: 0x040017A3 RID: 6051
			internal int nan_symbol;

			// Token: 0x040017A4 RID: 6052
			internal int negative_infinity_symbol;

			// Token: 0x040017A5 RID: 6053
			internal int negative_sign;

			// Token: 0x040017A6 RID: 6054
			internal int number_decimal_digits;

			// Token: 0x040017A7 RID: 6055
			internal int number_decimal_separator;

			// Token: 0x040017A8 RID: 6056
			internal int number_group_separator;

			// Token: 0x040017A9 RID: 6057
			internal int number_group_sizes0;

			// Token: 0x040017AA RID: 6058
			internal int number_group_sizes1;

			// Token: 0x040017AB RID: 6059
			internal int number_negative_pattern;

			// Token: 0x040017AC RID: 6060
			internal int per_mille_symbol;

			// Token: 0x040017AD RID: 6061
			internal int percent_negative_pattern;

			// Token: 0x040017AE RID: 6062
			internal int percent_positive_pattern;

			// Token: 0x040017AF RID: 6063
			internal int percent_symbol;

			// Token: 0x040017B0 RID: 6064
			internal int positive_infinity_symbol;

			// Token: 0x040017B1 RID: 6065
			internal int positive_sign;
		}
	}
}
