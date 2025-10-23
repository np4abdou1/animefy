using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	// Token: 0x0200059C RID: 1436
	[StructLayout(0)]
	internal class CalendarData
	{
		// Token: 0x06002ADF RID: 10975 RVA: 0x000AD417 File Offset: 0x000AB617
		private CalendarData()
		{
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000AD42C File Offset: 0x000AB62C
		static CalendarData()
		{
			CalendarData calendarData = new CalendarData();
			calendarData.sNativeName = "Gregorian Calendar";
			calendarData.iTwoDigitYearMax = 2029;
			calendarData.iCurrentEra = 1;
			calendarData.saShortDates = new string[]
			{
				"MM/dd/yyyy",
				"yyyy-MM-dd"
			};
			calendarData.saLongDates = new string[]
			{
				"dddd, dd MMMM yyyy"
			};
			calendarData.saYearMonths = new string[]
			{
				"yyyy MMMM"
			};
			calendarData.sMonthDay = "MMMM dd";
			calendarData.saEraNames = new string[]
			{
				"A.D."
			};
			calendarData.saAbbrevEraNames = new string[]
			{
				"AD"
			};
			calendarData.saAbbrevEnglishEraNames = new string[]
			{
				"AD"
			};
			calendarData.saDayNames = new string[]
			{
				"Sunday",
				"Monday",
				"Tuesday",
				"Wednesday",
				"Thursday",
				"Friday",
				"Saturday"
			};
			calendarData.saAbbrevDayNames = new string[]
			{
				"Sun",
				"Mon",
				"Tue",
				"Wed",
				"Thu",
				"Fri",
				"Sat"
			};
			calendarData.saSuperShortDayNames = new string[]
			{
				"Su",
				"Mo",
				"Tu",
				"We",
				"Th",
				"Fr",
				"Sa"
			};
			calendarData.saMonthNames = new string[]
			{
				"January",
				"February",
				"March",
				"April",
				"May",
				"June",
				"July",
				"August",
				"September",
				"October",
				"November",
				"December",
				string.Empty
			};
			calendarData.saAbbrevMonthNames = new string[]
			{
				"Jan",
				"Feb",
				"Mar",
				"Apr",
				"May",
				"Jun",
				"Jul",
				"Aug",
				"Sep",
				"Oct",
				"Nov",
				"Dec",
				string.Empty
			};
			calendarData.saMonthGenitiveNames = calendarData.saMonthNames;
			calendarData.saAbbrevMonthGenitiveNames = calendarData.saAbbrevMonthNames;
			calendarData.saLeapYearMonthNames = calendarData.saMonthNames;
			calendarData.bUseUserOverrides = false;
			CalendarData.Invariant = calendarData;
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x000AD7C8 File Offset: 0x000AB9C8
		internal CalendarData(string localeName, int calendarId, bool bUseUserOverrides)
		{
			this.bUseUserOverrides = bUseUserOverrides;
			if (!CalendarData.nativeGetCalendarData(this, localeName, calendarId))
			{
				if (this.sNativeName == null)
				{
					this.sNativeName = string.Empty;
				}
				if (this.saShortDates == null)
				{
					this.saShortDates = CalendarData.Invariant.saShortDates;
				}
				if (this.saYearMonths == null)
				{
					this.saYearMonths = CalendarData.Invariant.saYearMonths;
				}
				if (this.saLongDates == null)
				{
					this.saLongDates = CalendarData.Invariant.saLongDates;
				}
				if (this.sMonthDay == null)
				{
					this.sMonthDay = CalendarData.Invariant.sMonthDay;
				}
				if (this.saEraNames == null)
				{
					this.saEraNames = CalendarData.Invariant.saEraNames;
				}
				if (this.saAbbrevEraNames == null)
				{
					this.saAbbrevEraNames = CalendarData.Invariant.saAbbrevEraNames;
				}
				if (this.saAbbrevEnglishEraNames == null)
				{
					this.saAbbrevEnglishEraNames = CalendarData.Invariant.saAbbrevEnglishEraNames;
				}
				if (this.saDayNames == null)
				{
					this.saDayNames = CalendarData.Invariant.saDayNames;
				}
				if (this.saAbbrevDayNames == null)
				{
					this.saAbbrevDayNames = CalendarData.Invariant.saAbbrevDayNames;
				}
				if (this.saSuperShortDayNames == null)
				{
					this.saSuperShortDayNames = CalendarData.Invariant.saSuperShortDayNames;
				}
				if (this.saMonthNames == null)
				{
					this.saMonthNames = CalendarData.Invariant.saMonthNames;
				}
				if (this.saAbbrevMonthNames == null)
				{
					this.saAbbrevMonthNames = CalendarData.Invariant.saAbbrevMonthNames;
				}
			}
			this.saShortDates = CultureData.ReescapeWin32Strings(this.saShortDates);
			this.saLongDates = CultureData.ReescapeWin32Strings(this.saLongDates);
			this.saYearMonths = CultureData.ReescapeWin32Strings(this.saYearMonths);
			this.sMonthDay = CultureData.ReescapeWin32String(this.sMonthDay);
			if ((ushort)calendarId == 4)
			{
				if (CultureInfo.IsTaiwanSku)
				{
					this.sNativeName = "中華民國曆";
				}
				else
				{
					this.sNativeName = string.Empty;
				}
			}
			if (this.saMonthGenitiveNames == null || string.IsNullOrEmpty(this.saMonthGenitiveNames[0]))
			{
				this.saMonthGenitiveNames = this.saMonthNames;
			}
			if (this.saAbbrevMonthGenitiveNames == null || string.IsNullOrEmpty(this.saAbbrevMonthGenitiveNames[0]))
			{
				this.saAbbrevMonthGenitiveNames = this.saAbbrevMonthNames;
			}
			if (this.saLeapYearMonthNames == null || string.IsNullOrEmpty(this.saLeapYearMonthNames[0]))
			{
				this.saLeapYearMonthNames = this.saMonthNames;
			}
			this.InitializeEraNames(localeName, calendarId);
			this.InitializeAbbreviatedEraNames(localeName, calendarId);
			if (!GlobalizationMode.Invariant && calendarId == 3)
			{
				this.saAbbrevEnglishEraNames = CalendarData.GetJapaneseEnglishEraNames();
			}
			else
			{
				this.saAbbrevEnglishEraNames = new string[]
				{
					""
				};
			}
			this.iCurrentEra = this.saEraNames.Length;
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x000ADA48 File Offset: 0x000ABC48
		private void InitializeEraNames(string localeName, int calendarId)
		{
			switch ((ushort)calendarId)
			{
			case 1:
				if (this.saEraNames == null || this.saEraNames.Length == 0 || string.IsNullOrEmpty(this.saEraNames[0]))
				{
					this.saEraNames = new string[]
					{
						"A.D."
					};
					return;
				}
				return;
			case 2:
			case 13:
				this.saEraNames = new string[]
				{
					"A.D."
				};
				return;
			case 3:
			case 14:
				this.saEraNames = CalendarData.GetJapaneseEraNames();
				return;
			case 4:
				if (CultureInfo.IsTaiwanSku)
				{
					this.saEraNames = new string[]
					{
						"中華民國"
					};
					return;
				}
				this.saEraNames = new string[]
				{
					string.Empty
				};
				return;
			case 5:
				this.saEraNames = new string[]
				{
					"단기"
				};
				return;
			case 6:
			case 23:
				if (localeName == "dv-MV")
				{
					this.saEraNames = new string[]
					{
						"ހިޖްރީ"
					};
					return;
				}
				this.saEraNames = new string[]
				{
					"بعد الهجرة"
				};
				return;
			case 7:
				this.saEraNames = new string[]
				{
					"พ.ศ."
				};
				return;
			case 8:
				this.saEraNames = new string[]
				{
					"C.E."
				};
				return;
			case 9:
				this.saEraNames = new string[]
				{
					"ap. J.-C."
				};
				return;
			case 10:
			case 11:
			case 12:
				this.saEraNames = new string[]
				{
					"م"
				};
				return;
			case 22:
				if (this.saEraNames == null || this.saEraNames.Length == 0 || string.IsNullOrEmpty(this.saEraNames[0]))
				{
					this.saEraNames = new string[]
					{
						"ه.ش"
					};
					return;
				}
				return;
			}
			this.saEraNames = CalendarData.Invariant.saEraNames;
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x000ADC30 File Offset: 0x000ABE30
		private static string[] GetJapaneseEraNames()
		{
			if (GlobalizationMode.Invariant)
			{
				throw new PlatformNotSupportedException();
			}
			return JapaneseCalendar.EraNames();
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x000ADC44 File Offset: 0x000ABE44
		private static string[] GetJapaneseEnglishEraNames()
		{
			if (GlobalizationMode.Invariant)
			{
				throw new PlatformNotSupportedException();
			}
			return JapaneseCalendar.EnglishEraNames();
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x000ADC58 File Offset: 0x000ABE58
		private void InitializeAbbreviatedEraNames(string localeName, int calendarId)
		{
			CalendarId calendarId2 = (CalendarId)calendarId;
			if (calendarId2 <= CalendarId.JULIAN)
			{
				switch (calendarId2)
				{
				case CalendarId.GREGORIAN:
					if (this.saAbbrevEraNames == null || this.saAbbrevEraNames.Length == 0 || string.IsNullOrEmpty(this.saAbbrevEraNames[0]))
					{
						this.saAbbrevEraNames = new string[]
						{
							"AD"
						};
						return;
					}
					return;
				case CalendarId.GREGORIAN_US:
					break;
				case CalendarId.JAPAN:
					goto IL_96;
				case CalendarId.TAIWAN:
					this.saAbbrevEraNames = new string[1];
					if (this.saEraNames[0].Length == 4)
					{
						this.saAbbrevEraNames[0] = this.saEraNames[0].Substring(2, 2);
						return;
					}
					this.saAbbrevEraNames[0] = this.saEraNames[0];
					return;
				case CalendarId.KOREA:
					goto IL_159;
				case CalendarId.HIJRI:
					goto IL_B0;
				default:
					if (calendarId2 != CalendarId.JULIAN)
					{
						goto IL_159;
					}
					break;
				}
				this.saAbbrevEraNames = new string[]
				{
					"AD"
				};
				return;
			}
			if (calendarId2 != CalendarId.JAPANESELUNISOLAR)
			{
				if (calendarId2 != CalendarId.PERSIAN)
				{
					if (calendarId2 != CalendarId.UMALQURA)
					{
						goto IL_159;
					}
					goto IL_B0;
				}
				else
				{
					if (this.saAbbrevEraNames == null || this.saAbbrevEraNames.Length == 0 || string.IsNullOrEmpty(this.saAbbrevEraNames[0]))
					{
						this.saAbbrevEraNames = this.saEraNames;
						return;
					}
					return;
				}
			}
			IL_96:
			if (GlobalizationMode.Invariant)
			{
				throw new PlatformNotSupportedException();
			}
			this.saAbbrevEraNames = this.saEraNames;
			return;
			IL_B0:
			if (localeName == "dv-MV")
			{
				this.saAbbrevEraNames = new string[]
				{
					"ހ."
				};
				return;
			}
			this.saAbbrevEraNames = new string[]
			{
				"هـ"
			};
			return;
			IL_159:
			this.saAbbrevEraNames = this.saEraNames;
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x000ADDCA File Offset: 0x000ABFCA
		internal static CalendarData GetCalendarData(int calendarId)
		{
			return CultureInfo.GetCultureInfo(CalendarData.CalendarIdToCultureName(calendarId)).m_cultureData.GetCalendar(calendarId);
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x000ADDE4 File Offset: 0x000ABFE4
		private static string CalendarIdToCultureName(int calendarId)
		{
			switch (calendarId)
			{
			case 2:
				return "fa-IR";
			case 3:
				return "ja-JP";
			case 4:
				return "zh-TW";
			case 5:
				return "ko-KR";
			case 6:
			case 10:
			case 23:
				return "ar-SA";
			case 7:
				return "th-TH";
			case 8:
				return "he-IL";
			case 9:
				return "ar-DZ";
			case 11:
			case 12:
				return "ar-IQ";
			}
			return "en-US";
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x0009CFF0 File Offset: 0x0009B1F0
		public static int nativeGetTwoDigitYearMax(int calID)
		{
			return -1;
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x000ADE8E File Offset: 0x000AC08E
		private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId)
		{
			if (data.fill_calendar_data(localeName.ToLowerInvariant(), calendarId))
			{
				if ((ushort)calendarId == 8)
				{
					data.saMonthNames = CalendarData.HEBREW_MONTH_NAMES;
					data.saLeapYearMonthNames = CalendarData.HEBREW_LEAP_MONTH_NAMES;
				}
				return true;
			}
			return false;
		}

		// Token: 0x06002AEA RID: 10986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool fill_calendar_data(string localeName, int datetimeIndex);

		// Token: 0x0400171C RID: 5916
		internal string sNativeName;

		// Token: 0x0400171D RID: 5917
		internal string[] saShortDates;

		// Token: 0x0400171E RID: 5918
		internal string[] saYearMonths;

		// Token: 0x0400171F RID: 5919
		internal string[] saLongDates;

		// Token: 0x04001720 RID: 5920
		internal string sMonthDay;

		// Token: 0x04001721 RID: 5921
		internal string[] saEraNames;

		// Token: 0x04001722 RID: 5922
		internal string[] saAbbrevEraNames;

		// Token: 0x04001723 RID: 5923
		internal string[] saAbbrevEnglishEraNames;

		// Token: 0x04001724 RID: 5924
		internal string[] saDayNames;

		// Token: 0x04001725 RID: 5925
		internal string[] saAbbrevDayNames;

		// Token: 0x04001726 RID: 5926
		internal string[] saSuperShortDayNames;

		// Token: 0x04001727 RID: 5927
		internal string[] saMonthNames;

		// Token: 0x04001728 RID: 5928
		internal string[] saAbbrevMonthNames;

		// Token: 0x04001729 RID: 5929
		internal string[] saMonthGenitiveNames;

		// Token: 0x0400172A RID: 5930
		internal string[] saAbbrevMonthGenitiveNames;

		// Token: 0x0400172B RID: 5931
		internal string[] saLeapYearMonthNames;

		// Token: 0x0400172C RID: 5932
		internal int iTwoDigitYearMax = 2029;

		// Token: 0x0400172D RID: 5933
		internal int iCurrentEra;

		// Token: 0x0400172E RID: 5934
		internal bool bUseUserOverrides;

		// Token: 0x0400172F RID: 5935
		internal static CalendarData Invariant;

		// Token: 0x04001730 RID: 5936
		private static string[] HEBREW_MONTH_NAMES = new string[]
		{
			"תשרי",
			"חשון",
			"כסלו",
			"טבת",
			"שבט",
			"אדר",
			"אדר ב",
			"ניסן",
			"אייר",
			"סיון",
			"תמוז",
			"אב",
			"אלול"
		};

		// Token: 0x04001731 RID: 5937
		private static string[] HEBREW_LEAP_MONTH_NAMES = new string[]
		{
			"תשרי",
			"חשון",
			"כסלו",
			"טבת",
			"שבט",
			"אדר א",
			"אדר ב",
			"ניסן",
			"אייר",
			"סיון",
			"תמוז",
			"אב",
			"אלול"
		};
	}
}
