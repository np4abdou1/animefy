using System;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>the Taiwan calendar.</summary>
	// Token: 0x020005A3 RID: 1443
	[ComVisible(true)]
	[Serializable]
	public class TaiwanCalendar : Calendar
	{
		// Token: 0x06002B5A RID: 11098 RVA: 0x000AF3FE File Offset: 0x000AD5FE
		internal static Calendar GetDefaultInstance()
		{
			if (TaiwanCalendar.s_defaultInstance == null)
			{
				TaiwanCalendar.s_defaultInstance = new TaiwanCalendar();
			}
			return TaiwanCalendar.s_defaultInstance;
		}

		/// <summary>Gets the earliest date and time supported by the <see cref="T:System.Globalization.TaiwanCalendar" /> class.</summary>
		/// <returns>The earliest date and time supported by the <see cref="T:System.Globalization.TaiwanCalendar" /> class, which is equivalent to the first moment of January 1, 1912 C.E. in the Gregorian calendar.</returns>
		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06002B5B RID: 11099 RVA: 0x000AF41C File Offset: 0x000AD61C
		[ComVisible(false)]
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return TaiwanCalendar.calendarMinValue;
			}
		}

		/// <summary>Gets the latest date and time supported by the <see cref="T:System.Globalization.TaiwanCalendar" /> class.</summary>
		/// <returns>The latest date and time supported by the <see cref="T:System.Globalization.TaiwanCalendar" /> class, which is equivalent to the last moment of December 31, 9999 C.E. in the Gregorian calendar.</returns>
		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06002B5C RID: 11100 RVA: 0x000AD232 File Offset: 0x000AB432
		[ComVisible(false)]
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return DateTime.MaxValue;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.TaiwanCalendar" /> class.</summary>
		/// <exception cref="T:System.TypeInitializationException">Unable to initialize a <see cref="T:System.Globalization.TaiwanCalendar" /> object because of missing culture information.</exception>
		// Token: 0x06002B5D RID: 11101 RVA: 0x000AF424 File Offset: 0x000AD624
		public TaiwanCalendar()
		{
			try
			{
				new CultureInfo("zh-TW");
			}
			catch (ArgumentException innerException)
			{
				throw new TypeInitializationException(base.GetType().FullName, innerException);
			}
			this.helper = new GregorianCalendarHelper(this, TaiwanCalendar.taiwanEraInfo);
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x0000F994 File Offset: 0x0000DB94
		internal override int ID
		{
			get
			{
				return 4;
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
		// Token: 0x06002B5F RID: 11103 RVA: 0x000AF478 File Offset: 0x000AD678
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return this.helper.GetDaysInMonth(year, month, era);
		}

		/// <summary>Returns the day of the month in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>An integer from 1 to 31 that represents the day of the month in the specified <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06002B60 RID: 11104 RVA: 0x000AF488 File Offset: 0x000AD688
		public override int GetDayOfMonth(DateTime time)
		{
			return this.helper.GetDayOfMonth(time);
		}

		/// <summary>Returns the day of the week in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>A <see cref="T:System.DayOfWeek" /> value that represents the day of the week in the specified <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06002B61 RID: 11105 RVA: 0x000AF496 File Offset: 0x000AD696
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return this.helper.GetDayOfWeek(time);
		}

		/// <summary>Returns the number of months in the specified year in the specified era.</summary>
		/// <param name="year">An integer that represents the year. </param>
		/// <param name="era">An integer that represents the era. </param>
		/// <returns>The number of months in the specified year in the specified era.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="era" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002B62 RID: 11106 RVA: 0x000AF4A4 File Offset: 0x000AD6A4
		public override int GetMonthsInYear(int year, int era)
		{
			return this.helper.GetMonthsInYear(year, era);
		}

		/// <summary>Returns the era in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>An integer that represents the era in the specified <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06002B63 RID: 11107 RVA: 0x000AF4B3 File Offset: 0x000AD6B3
		public override int GetEra(DateTime time)
		{
			return this.helper.GetEra(time);
		}

		/// <summary>Returns the month in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>An integer from 1 to 12 that represents the month in the specified <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06002B64 RID: 11108 RVA: 0x000AF4C1 File Offset: 0x000AD6C1
		public override int GetMonth(DateTime time)
		{
			return this.helper.GetMonth(time);
		}

		/// <summary>Returns the year in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>An integer that represents the year in the specified <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06002B65 RID: 11109 RVA: 0x000AF4CF File Offset: 0x000AD6CF
		public override int GetYear(DateTime time)
		{
			return this.helper.GetYear(time);
		}

		/// <summary>Determines whether the specified year in the specified era is a leap year.</summary>
		/// <param name="year">An integer that represents the year. </param>
		/// <param name="era">An integer that represents the era. </param>
		/// <returns>
		///     <see langword="true" /> if the specified year is a leap year; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="era" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002B66 RID: 11110 RVA: 0x000AF4DD File Offset: 0x000AD6DD
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
		// Token: 0x06002B67 RID: 11111 RVA: 0x000AF4EC File Offset: 0x000AD6EC
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return this.helper.ToDateTime(year, month, day, hour, minute, second, millisecond, era);
		}

		/// <summary>Gets the list of eras in the <see cref="T:System.Globalization.TaiwanCalendar" />.</summary>
		/// <returns>An array that consists of a single element for which the value is always the current era.</returns>
		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06002B68 RID: 11112 RVA: 0x000AF511 File Offset: 0x000AD711
		public override int[] Eras
		{
			get
			{
				return this.helper.Eras;
			}
		}

		/// <summary>Gets or sets the last year of a 100-year range that can be represented by a 2-digit year.</summary>
		/// <returns>The last year of a 100-year range that can be represented by a 2-digit year.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified in a set operation is less than 99. -or- The value specified in a set operation is greater than <see langword="MaxSupportedDateTime.Year" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">In a set operation, the current instance is read-only.</exception>
		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x000AEE57 File Offset: 0x000AD057
		// (set) Token: 0x06002B6A RID: 11114 RVA: 0x000AF520 File Offset: 0x000AD720
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

		/// <summary>Converts the specified year to a four-digit year by using the <see cref="P:System.Globalization.TaiwanCalendar.TwoDigitYearMax" /> property to determine the appropriate century.</summary>
		/// <param name="year">A two-digit or four-digit integer that represents the year to convert. </param>
		/// <returns>An integer that contains the four-digit representation of <paramref name="year" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002B6B RID: 11115 RVA: 0x000AF584 File Offset: 0x000AD784
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

		// Token: 0x04001775 RID: 6005
		internal static EraInfo[] taiwanEraInfo = new EraInfo[]
		{
			new EraInfo(1, 1912, 1, 1, 1911, 1, 8088)
		};

		// Token: 0x04001776 RID: 6006
		internal static volatile Calendar s_defaultInstance;

		// Token: 0x04001777 RID: 6007
		internal GregorianCalendarHelper helper;

		// Token: 0x04001778 RID: 6008
		internal static readonly DateTime calendarMinValue = new DateTime(1912, 1, 1);
	}
}
