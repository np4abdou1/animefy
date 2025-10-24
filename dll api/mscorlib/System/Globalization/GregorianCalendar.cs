using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization
{
	/// <summary>Represents the Gregorian calendar.</summary>
	// Token: 0x0200059D RID: 1437
	[ComVisible(true)]
	[Serializable]
	public class GregorianCalendar : Calendar
	{
		// Token: 0x06002AEB RID: 10987 RVA: 0x000ADEC0 File Offset: 0x000AC0C0
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			if (this.m_type == (GregorianCalendarTypes)0)
			{
				this.m_type = GregorianCalendarTypes.Localized;
			}
			if (this.m_type < GregorianCalendarTypes.Localized || this.m_type > GregorianCalendarTypes.TransliteratedFrench)
			{
				throw new SerializationException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("The deserialized value of the member \"{0}\" in the class \"{1}\" is out of range."), "type", "GregorianCalendar"));
			}
		}

		/// <summary>Gets the earliest date and time supported by the <see cref="T:System.Globalization.GregorianCalendar" /> type.</summary>
		/// <returns>The earliest date and time supported by the <see cref="T:System.Globalization.GregorianCalendar" /> type, which is the first moment of January 1, 0001 C.E. and is equivalent to <see cref="F:System.DateTime.MinValue" />.</returns>
		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x000AD22B File Offset: 0x000AB42B
		[ComVisible(false)]
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return DateTime.MinValue;
			}
		}

		/// <summary>Gets the latest date and time supported by the <see cref="T:System.Globalization.GregorianCalendar" /> type.</summary>
		/// <returns>The latest date and time supported by the <see cref="T:System.Globalization.GregorianCalendar" /> type, which is the last moment of December 31, 9999 C.E. and is equivalent to <see cref="F:System.DateTime.MaxValue" />.</returns>
		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06002AED RID: 10989 RVA: 0x000AD232 File Offset: 0x000AB432
		[ComVisible(false)]
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return DateTime.MaxValue;
			}
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x000ADF13 File Offset: 0x000AC113
		internal static Calendar GetDefaultInstance()
		{
			if (GregorianCalendar.s_defaultInstance == null)
			{
				GregorianCalendar.s_defaultInstance = new GregorianCalendar();
			}
			return GregorianCalendar.s_defaultInstance;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.GregorianCalendar" /> class using the default <see cref="T:System.Globalization.GregorianCalendarTypes" /> value.</summary>
		// Token: 0x06002AEF RID: 10991 RVA: 0x000ADF31 File Offset: 0x000AC131
		public GregorianCalendar() : this(GregorianCalendarTypes.Localized)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.GregorianCalendar" /> class using the specified <see cref="T:System.Globalization.GregorianCalendarTypes" /> value.</summary>
		/// <param name="type">The <see cref="T:System.Globalization.GregorianCalendarTypes" /> value that denotes which language version of the calendar to create. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="type" /> is not a member of the <see cref="T:System.Globalization.GregorianCalendarTypes" /> enumeration.</exception>
		// Token: 0x06002AF0 RID: 10992 RVA: 0x000ADF3C File Offset: 0x000AC13C
		public GregorianCalendar(GregorianCalendarTypes type)
		{
			if (type < GregorianCalendarTypes.Localized || type > GregorianCalendarTypes.TransliteratedFrench)
			{
				throw new ArgumentOutOfRangeException("type", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					GregorianCalendarTypes.Localized,
					GregorianCalendarTypes.TransliteratedFrench
				}));
			}
			this.m_type = type;
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x000ADF8D File Offset: 0x000AC18D
		internal override int ID
		{
			get
			{
				return (int)this.m_type;
			}
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x000ADF98 File Offset: 0x000AC198
		internal virtual int GetDatePart(long ticks, int part)
		{
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
			int[] array = (num4 == 3 && (num3 != 24 || num2 == 3)) ? GregorianCalendar.DaysToMonth366 : GregorianCalendar.DaysToMonth365;
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

		/// <summary>Returns the day of the month in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>An integer from 1 to 31 that represents the day of the month in <paramref name="time" />.</returns>
		// Token: 0x06002AF3 RID: 10995 RVA: 0x000AE076 File Offset: 0x000AC276
		public override int GetDayOfMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 3);
		}

		/// <summary>Returns the day of the week in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>A <see cref="T:System.DayOfWeek" /> value that represents the day of the week in <paramref name="time" />.</returns>
		// Token: 0x06002AF4 RID: 10996 RVA: 0x000AE086 File Offset: 0x000AC286
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return (DayOfWeek)(time.Ticks / 864000000000L + 1L) % (DayOfWeek)7;
		}

		/// <summary>Returns the number of days in the specified month in the specified year in the specified era.</summary>
		/// <param name="year">An integer that represents the year. </param>
		/// <param name="month">An integer from 1 to 12 that represents the month. </param>
		/// <param name="era">An integer that represents the era. </param>
		/// <returns>The number of days in the specified month in the specified year in the specified era.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="era" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="year" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="month" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002AF5 RID: 10997 RVA: 0x000AE0A0 File Offset: 0x000AC2A0
		public override int GetDaysInMonth(int year, int month, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
			}
			if (year < 1 || year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					1,
					9999
				}));
			}
			if (month < 1 || month > 12)
			{
				throw new ArgumentOutOfRangeException("month", Environment.GetResourceString("Month must be between one and twelve."));
			}
			int[] array = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) ? GregorianCalendar.DaysToMonth366 : GregorianCalendar.DaysToMonth365;
			return array[month] - array[month - 1];
		}

		/// <summary>Returns the era in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>An integer that represents the era in <paramref name="time" />.</returns>
		// Token: 0x06002AF6 RID: 10998 RVA: 0x0000B18D File Offset: 0x0000938D
		public override int GetEra(DateTime time)
		{
			return 1;
		}

		/// <summary>Gets the list of eras in the <see cref="T:System.Globalization.GregorianCalendar" />.</summary>
		/// <returns>An array of integers that represents the eras in the <see cref="T:System.Globalization.GregorianCalendar" />.</returns>
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x000AE151 File Offset: 0x000AC351
		public override int[] Eras
		{
			get
			{
				return new int[]
				{
					1
				};
			}
		}

		/// <summary>Returns the month in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>An integer from 1 to 12 that represents the month in <paramref name="time" />.</returns>
		// Token: 0x06002AF8 RID: 11000 RVA: 0x000AE15D File Offset: 0x000AC35D
		public override int GetMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 2);
		}

		/// <summary>Returns the number of months in the specified year in the specified era.</summary>
		/// <param name="year">An integer that represents the year. </param>
		/// <param name="era">An integer that represents the era. </param>
		/// <returns>The number of months in the specified year in the specified era.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="era" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="year" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002AF9 RID: 11001 RVA: 0x000AE170 File Offset: 0x000AC370
		public override int GetMonthsInYear(int year, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
			}
			if (year >= 1 && year <= 9999)
			{
				return 12;
			}
			throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, 9999));
		}

		/// <summary>Returns the year in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>An integer that represents the year in <paramref name="time" />.</returns>
		// Token: 0x06002AFA RID: 11002 RVA: 0x000AE1D6 File Offset: 0x000AC3D6
		public override int GetYear(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 0);
		}

		/// <summary>Determines whether the specified year in the specified era is a leap year.</summary>
		/// <param name="year">An integer that represents the year. </param>
		/// <param name="era">An integer that represents the era. </param>
		/// <returns>
		///     <see langword="true" /> if the specified year is a leap year; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="era" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="year" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002AFB RID: 11003 RVA: 0x000AE1E8 File Offset: 0x000AC3E8
		public override bool IsLeapYear(int year, int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
			}
			if (year >= 1 && year <= 9999)
			{
				return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
			}
			throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, 9999));
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
		///         <paramref name="era" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="year" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="month" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="day" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="hour" /> is less than zero or greater than 23.-or- 
		///         <paramref name="minute" /> is less than zero or greater than 59.-or- 
		///         <paramref name="second" /> is less than zero or greater than 59.-or- 
		///         <paramref name="millisecond" /> is less than zero or greater than 999. </exception>
		// Token: 0x06002AFC RID: 11004 RVA: 0x000AE265 File Offset: 0x000AC465
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			if (era == 0 || era == 1)
			{
				return new DateTime(year, month, day, hour, minute, second, millisecond);
			}
			throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x000AE295 File Offset: 0x000AC495
		internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
		{
			if (era == 0 || era == 1)
			{
				return DateTime.TryCreate(year, month, day, hour, minute, second, millisecond, out result);
			}
			result = DateTime.MinValue;
			return false;
		}

		/// <summary>Gets or sets the last year of a 100-year range that can be represented by a 2-digit year.</summary>
		/// <returns>The last year of a 100-year range that can be represented by a 2-digit year.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified in a set operation is less than 99. -or- The value specified in a set operation is greater than <see langword="MaxSupportedDateTime.Year" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">In a set operation, the current instance is read-only.</exception>
		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06002AFE RID: 11006 RVA: 0x000AE2C0 File Offset: 0x000AC4C0
		// (set) Token: 0x06002AFF RID: 11007 RVA: 0x000AE2E8 File Offset: 0x000AC4E8
		public override int TwoDigitYearMax
		{
			get
			{
				if (this.twoDigitYearMax == -1)
				{
					this.twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.ID, 2029);
				}
				return this.twoDigitYearMax;
			}
			set
			{
				base.VerifyWritable();
				if (value < 99 || value > 9999)
				{
					throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 99, 9999));
				}
				this.twoDigitYearMax = value;
			}
		}

		/// <summary>Converts the specified year to a four-digit year by using the <see cref="P:System.Globalization.GregorianCalendar.TwoDigitYearMax" /> property to determine the appropriate century.</summary>
		/// <param name="year">A two-digit or four-digit integer that represents the year to convert. </param>
		/// <returns>An integer that contains the four-digit representation of <paramref name="year" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002B00 RID: 11008 RVA: 0x000AE340 File Offset: 0x000AC540
		public override int ToFourDigitYear(int year)
		{
			if (year < 0)
			{
				throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("Non-negative number required."));
			}
			if (year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, 9999));
			}
			return base.ToFourDigitYear(year);
		}

		// Token: 0x04001732 RID: 5938
		internal GregorianCalendarTypes m_type;

		// Token: 0x04001733 RID: 5939
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

		// Token: 0x04001734 RID: 5940
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

		// Token: 0x04001735 RID: 5941
		private static volatile Calendar s_defaultInstance;
	}
}
