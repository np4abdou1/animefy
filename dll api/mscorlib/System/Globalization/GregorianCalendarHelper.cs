using System;
using System.Runtime.Serialization;

namespace System.Globalization
{
	// Token: 0x0200059F RID: 1439
	[Serializable]
	internal class GregorianCalendarHelper
	{
		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06002B04 RID: 11012 RVA: 0x000AE481 File Offset: 0x000AC681
		internal int MaxYear
		{
			get
			{
				return this.m_maxYear;
			}
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x000AE48C File Offset: 0x000AC68C
		internal GregorianCalendarHelper(Calendar cal, EraInfo[] eraInfo)
		{
			this.m_Cal = cal;
			this.m_EraInfo = eraInfo;
			this.m_minDate = this.m_Cal.MinSupportedDateTime;
			this.m_maxYear = this.m_EraInfo[0].maxEraYear;
			this.m_minYear = this.m_EraInfo[0].minEraYear;
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x000AE4F0 File Offset: 0x000AC6F0
		private int GetYearOffset(int year, int era, bool throwOnError)
		{
			if (year < 0)
			{
				if (throwOnError)
				{
					throw new ArgumentOutOfRangeException("year", "Non-negative number required.");
				}
				return -1;
			}
			else
			{
				if (era == 0)
				{
					era = this.m_Cal.CurrentEraValue;
				}
				int i = 0;
				while (i < this.m_EraInfo.Length)
				{
					if (era == this.m_EraInfo[i].era)
					{
						if (year >= this.m_EraInfo[i].minEraYear)
						{
							if (year <= this.m_EraInfo[i].maxEraYear)
							{
								return this.m_EraInfo[i].yearOffset;
							}
							if (!AppContextSwitches.EnforceJapaneseEraYearRanges)
							{
								int num = year - this.m_EraInfo[i].maxEraYear;
								for (int j = i - 1; j >= 0; j--)
								{
									if (num <= this.m_EraInfo[j].maxEraYear)
									{
										return this.m_EraInfo[i].yearOffset;
									}
									num -= this.m_EraInfo[j].maxEraYear;
								}
							}
						}
						if (throwOnError)
						{
							throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, "Valid values are between {0} and {1}, inclusive.", this.m_EraInfo[i].minEraYear, this.m_EraInfo[i].maxEraYear));
						}
						break;
					}
					else
					{
						i++;
					}
				}
				if (throwOnError)
				{
					throw new ArgumentOutOfRangeException("era", "Era value was not valid.");
				}
				return -1;
			}
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x000AE628 File Offset: 0x000AC828
		internal int GetGregorianYear(int year, int era)
		{
			return this.GetYearOffset(year, era, true) + year;
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x000AE635 File Offset: 0x000AC835
		internal bool IsValidYear(int year, int era)
		{
			return this.GetYearOffset(year, era, false) >= 0;
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x000AE648 File Offset: 0x000AC848
		internal virtual int GetDatePart(long ticks, int part)
		{
			this.CheckTicksRange(ticks);
			int i = (int)(ticks / 864000000000L);
			int num = i / 146097;
			i -= num * 146097;
			int num2 = i / 36524;
			if (num2 == 4)
			{
				num2 = 3;
			}
			i -= num2 * 36524;
			int num3 = i / 1461;
			i -= num3 * 1461;
			int num4 = i / 365;
			if (num4 == 4)
			{
				num4 = 3;
			}
			if (part == 0)
			{
				return num * 400 + num2 * 100 + num3 * 4 + num4 + 1;
			}
			i -= num4 * 365;
			if (part == 1)
			{
				return i + 1;
			}
			int[] array = (num4 == 3 && (num3 != 24 || num2 == 3)) ? GregorianCalendarHelper.DaysToMonth366 : GregorianCalendarHelper.DaysToMonth365;
			int num5 = i >> 6;
			while (i >= array[num5])
			{
				num5++;
			}
			if (part == 2)
			{
				return num5;
			}
			return i - array[num5 - 1] + 1;
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x000AE730 File Offset: 0x000AC930
		internal static long GetAbsoluteDate(int year, int month, int day)
		{
			if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
			{
				int[] array = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) ? GregorianCalendarHelper.DaysToMonth366 : GregorianCalendarHelper.DaysToMonth365;
				if (day >= 1 && day <= array[month] - array[month - 1])
				{
					int num = year - 1;
					return (long)(num * 365 + num / 4 - num / 100 + num / 400 + array[month - 1] + day - 1);
				}
			}
			throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("Year, Month, and Day parameters describe an un-representable DateTime."));
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x000AE7BB File Offset: 0x000AC9BB
		internal static long DateToTicks(int year, int month, int day)
		{
			return GregorianCalendarHelper.GetAbsoluteDate(year, month, day) * 864000000000L;
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x000AE7D0 File Offset: 0x000AC9D0
		internal static long TimeToTicks(int hour, int minute, int second, int millisecond)
		{
			if (hour < 0 || hour >= 24 || minute < 0 || minute >= 60 || second < 0 || second >= 60)
			{
				throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("Hour, Minute, and Second parameters describe an un-representable DateTime."));
			}
			if (millisecond < 0 || millisecond >= 1000)
			{
				throw new ArgumentOutOfRangeException("millisecond", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 0, 999));
			}
			return TimeSpan.TimeToTicks(hour, minute, second) + (long)millisecond * 10000L;
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x000AE858 File Offset: 0x000ACA58
		internal void CheckTicksRange(long ticks)
		{
			if (ticks < this.m_Cal.MinSupportedDateTime.Ticks || ticks > this.m_Cal.MaxSupportedDateTime.Ticks)
			{
				throw new ArgumentOutOfRangeException("time", string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("Specified time is not supported in this calendar. It should be between {0} (Gregorian date) and {1} (Gregorian date), inclusive."), this.m_Cal.MinSupportedDateTime, this.m_Cal.MaxSupportedDateTime));
			}
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x000AE8D0 File Offset: 0x000ACAD0
		public int GetDayOfMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 3);
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x000AE8E0 File Offset: 0x000ACAE0
		public DayOfWeek GetDayOfWeek(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			return (DayOfWeek)((time.Ticks / 864000000000L + 1L) % 7L);
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x000AE908 File Offset: 0x000ACB08
		public int GetDaysInMonth(int year, int month, int era)
		{
			year = this.GetGregorianYear(year, era);
			if (month < 1 || month > 12)
			{
				throw new ArgumentOutOfRangeException("month", Environment.GetResourceString("Month must be between one and twelve."));
			}
			int[] array = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) ? GregorianCalendarHelper.DaysToMonth366 : GregorianCalendarHelper.DaysToMonth365;
			return array[month] - array[month - 1];
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x000AE968 File Offset: 0x000ACB68
		public int GetEra(DateTime time)
		{
			long ticks = time.Ticks;
			for (int i = 0; i < this.m_EraInfo.Length; i++)
			{
				if (ticks >= this.m_EraInfo[i].ticks)
				{
					return this.m_EraInfo[i].era;
				}
			}
			throw new ArgumentOutOfRangeException(Environment.GetResourceString("Time value was out of era range."));
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x000AE9C0 File Offset: 0x000ACBC0
		public int[] Eras
		{
			get
			{
				if (this.m_eras == null)
				{
					this.m_eras = new int[this.m_EraInfo.Length];
					for (int i = 0; i < this.m_EraInfo.Length; i++)
					{
						this.m_eras[i] = this.m_EraInfo[i].era;
					}
				}
				return (int[])this.m_eras.Clone();
			}
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x000AEA20 File Offset: 0x000ACC20
		public int GetMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 2);
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x000AEA30 File Offset: 0x000ACC30
		public int GetMonthsInYear(int year, int era)
		{
			year = this.GetGregorianYear(year, era);
			return 12;
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x000AEA40 File Offset: 0x000ACC40
		public int GetYear(DateTime time)
		{
			long ticks = time.Ticks;
			int datePart = this.GetDatePart(ticks, 0);
			for (int i = 0; i < this.m_EraInfo.Length; i++)
			{
				if (ticks >= this.m_EraInfo[i].ticks)
				{
					return datePart - this.m_EraInfo[i].yearOffset;
				}
			}
			throw new ArgumentException(Environment.GetResourceString("No Era was supplied."));
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x000AEAA0 File Offset: 0x000ACCA0
		public bool IsLeapYear(int year, int era)
		{
			year = this.GetGregorianYear(year, era);
			return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x000AEAC8 File Offset: 0x000ACCC8
		public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			year = this.GetGregorianYear(year, era);
			long ticks = GregorianCalendarHelper.DateToTicks(year, month, day) + GregorianCalendarHelper.TimeToTicks(hour, minute, second, millisecond);
			this.CheckTicksRange(ticks);
			return new DateTime(ticks);
		}

		// Token: 0x0400173E RID: 5950
		internal static readonly int[] DaysToMonth365 = new int[]
		{
			0,
			31,
			59,
			90,
			120,
			151,
			181,
			212,
			243,
			273,
			304,
			334,
			365
		};

		// Token: 0x0400173F RID: 5951
		internal static readonly int[] DaysToMonth366 = new int[]
		{
			0,
			31,
			60,
			91,
			121,
			152,
			182,
			213,
			244,
			274,
			305,
			335,
			366
		};

		// Token: 0x04001740 RID: 5952
		[OptionalField(VersionAdded = 1)]
		internal int m_maxYear = 9999;

		// Token: 0x04001741 RID: 5953
		[OptionalField(VersionAdded = 1)]
		internal int m_minYear;

		// Token: 0x04001742 RID: 5954
		internal Calendar m_Cal;

		// Token: 0x04001743 RID: 5955
		[OptionalField(VersionAdded = 1)]
		internal EraInfo[] m_EraInfo;

		// Token: 0x04001744 RID: 5956
		[OptionalField(VersionAdded = 1)]
		internal int[] m_eras;

		// Token: 0x04001745 RID: 5957
		[OptionalField(VersionAdded = 1)]
		internal DateTime m_minDate;
	}
}
