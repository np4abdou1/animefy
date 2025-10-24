using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Globalization
{
	/// <summary>Represents the Japanese calendar.</summary>
	// Token: 0x020005A1 RID: 1441
	[ComVisible(true)]
	[Serializable]
	public class JapaneseCalendar : Calendar
	{
		/// <summary>Gets the earliest date and time supported by the current <see cref="T:System.Globalization.JapaneseCalendar" /> object.</summary>
		/// <returns>The earliest date and time supported by the <see cref="T:System.Globalization.JapaneseCalendar" /> type, which is equivalent to the first moment of September 8, 1868 C.E. in the Gregorian calendar. </returns>
		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06002B19 RID: 11033 RVA: 0x000AEB34 File Offset: 0x000ACD34
		[ComVisible(false)]
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return JapaneseCalendar.calendarMinValue;
			}
		}

		/// <summary>Gets the latest date and time supported by the current <see cref="T:System.Globalization.JapaneseCalendar" /> object.</summary>
		/// <returns>The latest date and time supported by the <see cref="T:System.Globalization.JapaneseCalendar" /> type, which is equivalent to the last moment of December 31, 9999 C.E. in the Gregorian calendar.</returns>
		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06002B1A RID: 11034 RVA: 0x000AD232 File Offset: 0x000AB432
		[ComVisible(false)]
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return DateTime.MaxValue;
			}
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x000AEB3C File Offset: 0x000ACD3C
		internal static EraInfo[] GetEraInfo()
		{
			if (JapaneseCalendar.japaneseEraInfo == null)
			{
				JapaneseCalendar.japaneseEraInfo = JapaneseCalendar.GetErasFromRegistry();
				if (JapaneseCalendar.japaneseEraInfo == null)
				{
					JapaneseCalendar.japaneseEraInfo = new EraInfo[]
					{
						new EraInfo(5, 2019, 5, 1, 2018, 1, 7981, "令和", "令", "R"),
						new EraInfo(4, 1989, 1, 8, 1988, 1, 31, "平成", "平", "H"),
						new EraInfo(3, 1926, 12, 25, 1925, 1, 64, "昭和", "昭", "S"),
						new EraInfo(2, 1912, 7, 30, 1911, 1, 15, "大正", "大", "T"),
						new EraInfo(1, 1868, 1, 1, 1867, 1, 45, "明治", "明", "M")
					};
				}
			}
			return JapaneseCalendar.japaneseEraInfo;
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x0002AC82 File Offset: 0x00028E82
		[SecuritySafeCritical]
		private static EraInfo[] GetErasFromRegistry()
		{
			return null;
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x000AEC4A File Offset: 0x000ACE4A
		internal static Calendar GetDefaultInstance()
		{
			if (JapaneseCalendar.s_defaultInstance == null)
			{
				JapaneseCalendar.s_defaultInstance = new JapaneseCalendar();
			}
			return JapaneseCalendar.s_defaultInstance;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.JapaneseCalendar" /> class.</summary>
		/// <exception cref="T:System.TypeInitializationException">Unable to initialize a <see cref="T:System.Globalization.JapaneseCalendar" /> object because of missing culture information.</exception>
		// Token: 0x06002B1E RID: 11038 RVA: 0x000AEC68 File Offset: 0x000ACE68
		public JapaneseCalendar()
		{
			try
			{
				new CultureInfo("ja-JP");
			}
			catch (ArgumentException innerException)
			{
				throw new TypeInitializationException(base.GetType().FullName, innerException);
			}
			this.helper = new GregorianCalendarHelper(this, JapaneseCalendar.GetEraInfo());
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002B1F RID: 11039 RVA: 0x0000F43A File Offset: 0x0000D63A
		internal override int ID
		{
			get
			{
				return 3;
			}
		}

		/// <summary>Returns the number of days in the specified month in the specified year in the specified era.</summary>
		/// <param name="year">An integer that represents the year. </param>
		/// <param name="month">An integer from 1 to 12 that represents the month. </param>
		/// <param name="era">An integer that represents the era. </param>
		/// <returns>The number of days in the specified month in the specified year in the specified era.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="month" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="era" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002B20 RID: 11040 RVA: 0x000AECBC File Offset: 0x000ACEBC
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return this.helper.GetDaysInMonth(year, month, era);
		}

		/// <summary>Returns the day of the month in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>An integer from 1 to 31 that represents the day of the month in the specified <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06002B21 RID: 11041 RVA: 0x000AECCC File Offset: 0x000ACECC
		public override int GetDayOfMonth(DateTime time)
		{
			return this.helper.GetDayOfMonth(time);
		}

		/// <summary>Returns the day of the week in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>A <see cref="T:System.DayOfWeek" /> value that represents the day of the week in the specified <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06002B22 RID: 11042 RVA: 0x000AECDA File Offset: 0x000ACEDA
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return this.helper.GetDayOfWeek(time);
		}

		/// <summary>Returns the number of months in the specified year in the specified era.</summary>
		/// <param name="year">An integer that represents the year. </param>
		/// <param name="era">An integer that represents the era. </param>
		/// <returns>The return value is always 12.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="era" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002B23 RID: 11043 RVA: 0x000AECE8 File Offset: 0x000ACEE8
		public override int GetMonthsInYear(int year, int era)
		{
			return this.helper.GetMonthsInYear(year, era);
		}

		/// <summary>Returns the era in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>An integer that represents the era in the specified <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is outside the supported range. </exception>
		// Token: 0x06002B24 RID: 11044 RVA: 0x000AECF7 File Offset: 0x000ACEF7
		public override int GetEra(DateTime time)
		{
			return this.helper.GetEra(time);
		}

		/// <summary>Returns the month in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>An integer from 1 to 12 that represents the month in the specified <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06002B25 RID: 11045 RVA: 0x000AED05 File Offset: 0x000ACF05
		public override int GetMonth(DateTime time)
		{
			return this.helper.GetMonth(time);
		}

		/// <summary>Returns the year in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>An integer that represents the year in the specified <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06002B26 RID: 11046 RVA: 0x000AED13 File Offset: 0x000ACF13
		public override int GetYear(DateTime time)
		{
			return this.helper.GetYear(time);
		}

		/// <summary>Determines whether the specified year in the specified era is a leap year.</summary>
		/// <param name="year">An integer that represents the year. </param>
		/// <param name="era">An integer that represents the era. </param>
		/// <returns>
		///     <see langword="true" />, if the specified year is a leap year; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="era" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002B27 RID: 11047 RVA: 0x000AED21 File Offset: 0x000ACF21
		public override bool IsLeapYear(int year, int era)
		{
			return this.helper.IsLeapYear(year, era);
		}

		/// <summary>Returns a <see cref="T:System.DateTime" /> that is set to the specified date and time in the specified era.</summary>
		/// <param name="year">An integer that represents the year. </param>
		/// <param name="month">An integer from 1 to 12 that represents the month. </param>
		/// <param name="day">An integer from 1 to 31 that represents the day. </param>
		/// <param name="hour">An integer from 0 to 23 that represents the hour. </param>
		/// <param name="minute">An integer from 0 to 59 that represents the minute. </param>
		/// <param name="second">An integer from 0 to 59 that represents the second. </param>
		/// <param name="millisecond">An integer from 0 to 999 that represents the millisecond. </param>
		/// <param name="era">An integer that represents the era. </param>
		/// <returns>The <see cref="T:System.DateTime" /> that is set to the specified date and time in the current era.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="month" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="day" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="hour" /> is less than zero or greater than 23.-or- 
		///         <paramref name="minute" /> is less than zero or greater than 59.-or- 
		///         <paramref name="second" /> is less than zero or greater than 59.-or- 
		///         <paramref name="millisecond" /> is less than zero or greater than 999.-or- 
		///         <paramref name="era" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002B28 RID: 11048 RVA: 0x000AED30 File Offset: 0x000ACF30
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return this.helper.ToDateTime(year, month, day, hour, minute, second, millisecond, era);
		}

		/// <summary>Converts the specified year to a four-digit year by using the <see cref="P:System.Globalization.JapaneseCalendar.TwoDigitYearMax" /> property to determine the appropriate century.</summary>
		/// <param name="year">An integer (usually two digits) that represents the year to convert. </param>
		/// <returns>An integer that contains the four-digit representation of <paramref name="year" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002B29 RID: 11049 RVA: 0x000AED58 File Offset: 0x000ACF58
		public override int ToFourDigitYear(int year)
		{
			if (year <= 0)
			{
				throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("Positive number required."));
			}
			if (year > this.helper.MaxYear)
			{
				throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, this.helper.MaxYear));
			}
			return year;
		}

		/// <summary>Gets the list of eras in the <see cref="T:System.Globalization.JapaneseCalendar" />.</summary>
		/// <returns>An array of integers that represents the eras in the <see cref="T:System.Globalization.JapaneseCalendar" />.</returns>
		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06002B2A RID: 11050 RVA: 0x000AEDC2 File Offset: 0x000ACFC2
		public override int[] Eras
		{
			get
			{
				return this.helper.Eras;
			}
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x000AEDD0 File Offset: 0x000ACFD0
		internal static string[] EraNames()
		{
			EraInfo[] eraInfo = JapaneseCalendar.GetEraInfo();
			string[] array = new string[eraInfo.Length];
			for (int i = 0; i < eraInfo.Length; i++)
			{
				array[i] = eraInfo[eraInfo.Length - i - 1].eraName;
			}
			return array;
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x000AEE0C File Offset: 0x000AD00C
		internal static string[] EnglishEraNames()
		{
			EraInfo[] eraInfo = JapaneseCalendar.GetEraInfo();
			string[] array = new string[eraInfo.Length];
			for (int i = 0; i < eraInfo.Length; i++)
			{
				array[i] = eraInfo[eraInfo.Length - i - 1].englishEraName;
			}
			return array;
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x000AEE48 File Offset: 0x000AD048
		internal override bool IsValidYear(int year, int era)
		{
			return this.helper.IsValidYear(year, era);
		}

		/// <summary>Gets or sets the last year of a 100-year range that can be represented by a 2-digit year.</summary>
		/// <returns>The last year of a 100-year range that can be represented by a 2-digit year.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified in a set operation is less than 99. -or- The value specified in a set operation is greater than 8011 (or <see langword="MaxSupportedDateTime.Year" />).</exception>
		/// <exception cref="T:System.InvalidOperationException">In a set operation, the current instance is read-only.</exception>
		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002B2E RID: 11054 RVA: 0x000AEE57 File Offset: 0x000AD057
		// (set) Token: 0x06002B2F RID: 11055 RVA: 0x000AEE7C File Offset: 0x000AD07C
		public override int TwoDigitYearMax
		{
			get
			{
				if (this.twoDigitYearMax == -1)
				{
					this.twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.ID, 99);
				}
				return this.twoDigitYearMax;
			}
			set
			{
				base.VerifyWritable();
				if (value < 99 || value > this.helper.MaxYear)
				{
					throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 99, this.helper.MaxYear));
				}
				this.twoDigitYearMax = value;
			}
		}

		// Token: 0x0400174D RID: 5965
		internal static readonly DateTime calendarMinValue = new DateTime(1868, 9, 8);

		// Token: 0x0400174E RID: 5966
		internal static volatile EraInfo[] japaneseEraInfo;

		// Token: 0x0400174F RID: 5967
		internal static volatile Calendar s_defaultInstance;

		// Token: 0x04001750 RID: 5968
		internal GregorianCalendarHelper helper;
	}
}
