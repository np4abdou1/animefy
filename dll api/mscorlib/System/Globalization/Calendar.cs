using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Globalization
{
	/// <summary>Represents time in divisions, such as weeks, months, and years.</summary>
	// Token: 0x0200059B RID: 1435
	[ComVisible(true)]
	[Serializable]
	public abstract class Calendar : ICloneable
	{
		/// <summary>Gets the earliest date and time supported by this <see cref="T:System.Globalization.Calendar" /> object.</summary>
		/// <returns>The earliest date and time supported by this calendar. The default is <see cref="F:System.DateTime.MinValue" />.</returns>
		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x000AD22B File Offset: 0x000AB42B
		[ComVisible(false)]
		public virtual DateTime MinSupportedDateTime
		{
			get
			{
				return DateTime.MinValue;
			}
		}

		/// <summary>Gets the latest date and time supported by this <see cref="T:System.Globalization.Calendar" /> object.</summary>
		/// <returns>The latest date and time supported by this calendar. The default is <see cref="F:System.DateTime.MaxValue" />.</returns>
		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x000AD232 File Offset: 0x000AB432
		[ComVisible(false)]
		public virtual DateTime MaxSupportedDateTime
		{
			get
			{
				return DateTime.MaxValue;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x0009CFF0 File Offset: 0x0009B1F0
		internal virtual int ID
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x000AD24F File Offset: 0x000AB44F
		internal virtual int BaseCalendarID
		{
			get
			{
				return this.ID;
			}
		}

		/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Globalization.Calendar" /> object.</summary>
		/// <returns>A new instance of <see cref="T:System.Object" /> that is the memberwise clone of the current <see cref="T:System.Globalization.Calendar" /> object.</returns>
		// Token: 0x06002AC7 RID: 10951 RVA: 0x000AD257 File Offset: 0x000AB457
		[ComVisible(false)]
		public virtual object Clone()
		{
			object obj = base.MemberwiseClone();
			((Calendar)obj).SetReadOnlyState(false);
			return obj;
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x000AD26B File Offset: 0x000AB46B
		internal void VerifyWritable()
		{
			if (this.m_isReadOnly)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Instance is read-only."));
			}
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x000AD285 File Offset: 0x000AB485
		internal void SetReadOnlyState(bool readOnly)
		{
			this.m_isReadOnly = readOnly;
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x000AD28E File Offset: 0x000AB48E
		internal virtual int CurrentEraValue
		{
			get
			{
				if (this.m_currentEraValue == -1)
				{
					this.m_currentEraValue = CalendarData.GetCalendarData(this.BaseCalendarID).iCurrentEra;
				}
				return this.m_currentEraValue;
			}
		}

		/// <summary>When overridden in a derived class, returns the day of the month in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>A positive integer that represents the day of the month in the <paramref name="time" /> parameter.</returns>
		// Token: 0x06002ACB RID: 10955
		public abstract int GetDayOfMonth(DateTime time);

		/// <summary>When overridden in a derived class, returns the day of the week in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>A <see cref="T:System.DayOfWeek" /> value that represents the day of the week in the <paramref name="time" /> parameter.</returns>
		// Token: 0x06002ACC RID: 10956
		public abstract DayOfWeek GetDayOfWeek(DateTime time);

		/// <summary>When overridden in a derived class, returns the number of days in the specified month, year, and era.</summary>
		/// <param name="year">An integer that represents the year. </param>
		/// <param name="month">A positive integer that represents the month. </param>
		/// <param name="era">An integer that represents the era. </param>
		/// <returns>The number of days in the specified month in the specified year in the specified era.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="month" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="era" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002ACD RID: 10957
		public abstract int GetDaysInMonth(int year, int month, int era);

		/// <summary>When overridden in a derived class, returns the era in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>An integer that represents the era in <paramref name="time" />.</returns>
		// Token: 0x06002ACE RID: 10958
		public abstract int GetEra(DateTime time);

		/// <summary>When overridden in a derived class, gets the list of eras in the current calendar.</summary>
		/// <returns>An array of integers that represents the eras in the current calendar.</returns>
		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06002ACF RID: 10959
		public abstract int[] Eras { get; }

		/// <summary>When overridden in a derived class, returns the month in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>A positive integer that represents the month in <paramref name="time" />.</returns>
		// Token: 0x06002AD0 RID: 10960
		public abstract int GetMonth(DateTime time);

		/// <summary>When overridden in a derived class, returns the number of months in the specified year in the specified era.</summary>
		/// <param name="year">An integer that represents the year. </param>
		/// <param name="era">An integer that represents the era. </param>
		/// <returns>The number of months in the specified year in the specified era.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="era" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002AD1 RID: 10961
		public abstract int GetMonthsInYear(int year, int era);

		/// <summary>When overridden in a derived class, returns the year in the specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		/// <returns>An integer that represents the year in <paramref name="time" />.</returns>
		// Token: 0x06002AD2 RID: 10962
		public abstract int GetYear(DateTime time);

		/// <summary>Determines whether the specified year in the current era is a leap year.</summary>
		/// <param name="year">An integer that represents the year. </param>
		/// <returns>
		///     <see langword="true" /> if the specified year is a leap year; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002AD3 RID: 10963 RVA: 0x000AD2B5 File Offset: 0x000AB4B5
		public virtual bool IsLeapYear(int year)
		{
			return this.IsLeapYear(year, 0);
		}

		/// <summary>When overridden in a derived class, determines whether the specified year in the specified era is a leap year.</summary>
		/// <param name="year">An integer that represents the year. </param>
		/// <param name="era">An integer that represents the era. </param>
		/// <returns>
		///     <see langword="true" /> if the specified year is a leap year; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="era" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002AD4 RID: 10964
		public abstract bool IsLeapYear(int year, int era);

		/// <summary>Returns a <see cref="T:System.DateTime" /> that is set to the specified date and time in the current era.</summary>
		/// <param name="year">An integer that represents the year. </param>
		/// <param name="month">A positive integer that represents the month. </param>
		/// <param name="day">A positive integer that represents the day. </param>
		/// <param name="hour">An integer from 0 to 23 that represents the hour. </param>
		/// <param name="minute">An integer from 0 to 59 that represents the minute. </param>
		/// <param name="second">An integer from 0 to 59 that represents the second. </param>
		/// <param name="millisecond">An integer from 0 to 999 that represents the millisecond. </param>
		/// <returns>The <see cref="T:System.DateTime" /> that is set to the specified date and time in the current era.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="month" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="day" /> is outside the range supported by the calendar.-or- 
		///         <paramref name="hour" /> is less than zero or greater than 23.-or- 
		///         <paramref name="minute" /> is less than zero or greater than 59.-or- 
		///         <paramref name="second" /> is less than zero or greater than 59.-or- 
		///         <paramref name="millisecond" /> is less than zero or greater than 999. </exception>
		// Token: 0x06002AD5 RID: 10965 RVA: 0x000AD2C0 File Offset: 0x000AB4C0
		public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			return this.ToDateTime(year, month, day, hour, minute, second, millisecond, 0);
		}

		/// <summary>When overridden in a derived class, returns a <see cref="T:System.DateTime" /> that is set to the specified date and time in the specified era.</summary>
		/// <param name="year">An integer that represents the year. </param>
		/// <param name="month">A positive integer that represents the month. </param>
		/// <param name="day">A positive integer that represents the day. </param>
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
		// Token: 0x06002AD6 RID: 10966
		public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

		// Token: 0x06002AD7 RID: 10967 RVA: 0x000AD2E0 File Offset: 0x000AB4E0
		internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
		{
			result = DateTime.MinValue;
			bool result2;
			try
			{
				result = this.ToDateTime(year, month, day, hour, minute, second, millisecond, era);
				result2 = true;
			}
			catch (ArgumentException)
			{
				result2 = false;
			}
			return result2;
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x000AD330 File Offset: 0x000AB530
		internal virtual bool IsValidYear(int year, int era)
		{
			return year >= this.GetYear(this.MinSupportedDateTime) && year <= this.GetYear(this.MaxSupportedDateTime);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000AD355 File Offset: 0x000AB555
		internal virtual bool IsValidMonth(int year, int month, int era)
		{
			return this.IsValidYear(year, era) && month >= 1 && month <= this.GetMonthsInYear(year, era);
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x000AD375 File Offset: 0x000AB575
		internal virtual bool IsValidDay(int year, int month, int day, int era)
		{
			return this.IsValidMonth(year, month, era) && day >= 1 && day <= this.GetDaysInMonth(year, month, era);
		}

		/// <summary>Gets or sets the last year of a 100-year range that can be represented by a 2-digit year.</summary>
		/// <returns>The last year of a 100-year range that can be represented by a 2-digit year.</returns>
		/// <exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Globalization.Calendar" /> object is read-only.</exception>
		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x000AD399 File Offset: 0x000AB599
		// (set) Token: 0x06002ADC RID: 10972 RVA: 0x000AD3A1 File Offset: 0x000AB5A1
		public virtual int TwoDigitYearMax
		{
			get
			{
				return this.twoDigitYearMax;
			}
			set
			{
				this.VerifyWritable();
				this.twoDigitYearMax = value;
			}
		}

		/// <summary>Converts the specified year to a four-digit year by using the <see cref="P:System.Globalization.Calendar.TwoDigitYearMax" /> property to determine the appropriate century.</summary>
		/// <param name="year">A two-digit or four-digit integer that represents the year to convert. </param>
		/// <returns>An integer that contains the four-digit representation of <paramref name="year" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is outside the range supported by the calendar. </exception>
		// Token: 0x06002ADD RID: 10973 RVA: 0x000AD3B0 File Offset: 0x000AB5B0
		public virtual int ToFourDigitYear(int year)
		{
			if (year < 0)
			{
				throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("Non-negative number required."));
			}
			if (year < 100)
			{
				return (this.TwoDigitYearMax / 100 - ((year > this.TwoDigitYearMax % 100) ? 1 : 0)) * 100 + year;
			}
			return year;
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x000AD3FC File Offset: 0x000AB5FC
		[SecuritySafeCritical]
		internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue)
		{
			int num = CalendarData.nativeGetTwoDigitYearMax(CalID);
			if (num < 0)
			{
				num = defaultYearValue;
			}
			return num;
		}

		// Token: 0x04001719 RID: 5913
		internal int m_currentEraValue = -1;

		// Token: 0x0400171A RID: 5914
		[OptionalField(VersionAdded = 2)]
		private bool m_isReadOnly;

		// Token: 0x0400171B RID: 5915
		internal int twoDigitYearMax = -1;
	}
}
