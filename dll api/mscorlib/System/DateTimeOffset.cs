using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Represents a point in time, typically expressed as a date and time of day, relative to Coordinated Universal Time (UTC).</summary>
	// Token: 0x02000091 RID: 145
	[Serializable]
	[StructLayout(3)]
	public readonly struct DateTimeOffset : IComparable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanFormattable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified number of ticks and offset.</summary>
		/// <param name="ticks">A date and time expressed as the number of 100-nanosecond intervals that have elapsed since 12:00:00 midnight on January 1, 0001.</param>
		/// <param name="offset">The time's offset from Coordinated Universal Time (UTC).</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="offset" /> is not specified in whole minutes.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <see cref="P:System.DateTimeOffset.UtcDateTime" /> property is earlier than <see cref="F:System.DateTimeOffset.MinValue" /> or later than <see cref="F:System.DateTimeOffset.MaxValue" />.-or-
		///         <paramref name="ticks" /> is less than <see langword="DateTimeOffset.MinValue.Ticks" /> or greater than <see langword="DateTimeOffset.MaxValue.Ticks" />.-or-
		///         <paramref name="Offset" /> s less than -14 hours or greater than 14 hours.</exception>
		// Token: 0x060004D3 RID: 1235 RVA: 0x00012D60 File Offset: 0x00010F60
		public DateTimeOffset(long ticks, TimeSpan offset)
		{
			this._offsetMinutes = DateTimeOffset.ValidateOffset(offset);
			DateTime dateTime = new DateTime(ticks);
			this._dateTime = DateTimeOffset.ValidateDate(dateTime, offset);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified <see cref="T:System.DateTime" /> value.</summary>
		/// <param name="dateTime">A date and time.   </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The Coordinated Universal Time (UTC) date and time that results from applying the offset is earlier than <see cref="F:System.DateTimeOffset.MinValue" />.-or-The UTC date and time that results from applying the offset is later than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x060004D4 RID: 1236 RVA: 0x00012D90 File Offset: 0x00010F90
		public DateTimeOffset(DateTime dateTime)
		{
			TimeSpan localUtcOffset;
			if (dateTime.Kind != DateTimeKind.Utc)
			{
				localUtcOffset = TimeZoneInfo.GetLocalUtcOffset(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime);
			}
			else
			{
				localUtcOffset = new TimeSpan(0L);
			}
			this._offsetMinutes = DateTimeOffset.ValidateOffset(localUtcOffset);
			this._dateTime = DateTimeOffset.ValidateDate(dateTime, localUtcOffset);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified <see cref="T:System.DateTime" /> value and offset.</summary>
		/// <param name="dateTime">A date and time.   </param>
		/// <param name="offset">The time's offset from Coordinated Universal Time (UTC).</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="dateTime.Kind" /> equals <see cref="F:System.DateTimeKind.Utc" /> and <paramref name="offset" /> does not equal zero.-or-
		///         <paramref name="dateTime.Kind" /> equals <see cref="F:System.DateTimeKind.Local" /> and <paramref name="offset" /> does not equal the offset of the system's local time zone.-or-
		///         <paramref name="offset" /> is not specified in whole minutes.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> is less than -14 hours or greater than 14 hours.-or-
		///         <see cref="P:System.DateTimeOffset.UtcDateTime" /> is less than <see cref="F:System.DateTimeOffset.MinValue" /> or greater than <see cref="F:System.DateTimeOffset.MaxValue" />. </exception>
		// Token: 0x060004D5 RID: 1237 RVA: 0x00012DD4 File Offset: 0x00010FD4
		public DateTimeOffset(DateTime dateTime, TimeSpan offset)
		{
			if (dateTime.Kind == DateTimeKind.Local)
			{
				if (offset != TimeZoneInfo.GetLocalUtcOffset(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime))
				{
					throw new ArgumentException("The UTC Offset of the local dateTime parameter does not match the offset argument.", "offset");
				}
			}
			else if (dateTime.Kind == DateTimeKind.Utc && offset != TimeSpan.Zero)
			{
				throw new ArgumentException("The UTC Offset for Utc DateTime instances must be 0.", "offset");
			}
			this._offsetMinutes = DateTimeOffset.ValidateOffset(offset);
			this._dateTime = DateTimeOffset.ValidateDate(dateTime, offset);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified year, month, day, hour, minute, second, and offset.</summary>
		/// <param name="year">The year (1 through 9999).</param>
		/// <param name="month">The month (1 through 12).</param>
		/// <param name="day">The day (1 through the number of days in <paramref name="month" />).</param>
		/// <param name="hour">The hours (0 through 23).   </param>
		/// <param name="minute">The minutes (0 through 59).</param>
		/// <param name="second">The seconds (0 through 59).</param>
		/// <param name="offset">The time's offset from Coordinated Universal Time (UTC).</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="offset" /> does not represent whole minutes.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is less than one or greater than 9999.-or-
		///         <paramref name="month" /> is less than one or greater than 12.-or-
		///         <paramref name="day" /> is less than one or greater than the number of days in <paramref name="month" />.-or-
		///         <paramref name="hour" /> is less than zero or greater than 23.-or-
		///         <paramref name="minute" /> is less than 0 or greater than 59.-or-
		///         <paramref name="second" /> is less than 0 or greater than 59.-or-
		///         <paramref name="offset" /> is less than -14 hours or greater than 14 hours.-or-The <see cref="P:System.DateTimeOffset.UtcDateTime" /> property is earlier than <see cref="F:System.DateTimeOffset.MinValue" /> or later than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x060004D6 RID: 1238 RVA: 0x00012E4A File Offset: 0x0001104A
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset)
		{
			this._offsetMinutes = DateTimeOffset.ValidateOffset(offset);
			this._dateTime = DateTimeOffset.ValidateDate(new DateTime(year, month, day, hour, minute, second), offset);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified year, month, day, hour, minute, second, millisecond, and offset.</summary>
		/// <param name="year">The year (1 through 9999).</param>
		/// <param name="month">The month (1 through 12).</param>
		/// <param name="day">The day (1 through the number of days in <paramref name="month" />).</param>
		/// <param name="hour">The hours (0 through 23).   </param>
		/// <param name="minute">The minutes (0 through 59).</param>
		/// <param name="second">The seconds (0 through 59).</param>
		/// <param name="millisecond">The milliseconds (0 through 999).</param>
		/// <param name="offset">The time's offset from Coordinated Universal Time (UTC).</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="offset" /> does not represent whole minutes.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is less than one or greater than 9999.-or-
		///         <paramref name="month" /> is less than one or greater than 12.-or-
		///         <paramref name="day" /> is less than one or greater than the number of days in <paramref name="month" />.-or-
		///         <paramref name="hour" /> is less than zero or greater than 23.-or-
		///         <paramref name="minute" /> is less than 0 or greater than 59.-or-
		///         <paramref name="second" /> is less than 0 or greater than 59.-or-
		///         <paramref name="millisecond" /> is less than 0 or greater than 999.-or-
		///         <paramref name="offset" /> is less than -14 or greater than 14.-or-The <see cref="P:System.DateTimeOffset.UtcDateTime" /> property is earlier than <see cref="F:System.DateTimeOffset.MinValue" /> or later than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x060004D7 RID: 1239 RVA: 0x00012E74 File Offset: 0x00011074
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset)
		{
			this._offsetMinutes = DateTimeOffset.ValidateOffset(offset);
			this._dateTime = DateTimeOffset.ValidateDate(new DateTime(year, month, day, hour, minute, second, millisecond), offset);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified year, month, day, hour, minute, second, millisecond, and offset of a specified calendar.</summary>
		/// <param name="year">The year.</param>
		/// <param name="month">The month (1 through 12).</param>
		/// <param name="day">The day (1 through the number of days in <paramref name="month" />).</param>
		/// <param name="hour">The hours (0 through 23).   </param>
		/// <param name="minute">The minutes (0 through 59).</param>
		/// <param name="second">The seconds (0 through 59).</param>
		/// <param name="millisecond">The milliseconds (0 through 999).</param>
		/// <param name="calendar">The calendar that is used to interpret <paramref name="year" />, <paramref name="month" />, and <paramref name="day" />.</param>
		/// <param name="offset">The time's offset from Coordinated Universal Time (UTC).</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="offset" /> does not represent whole minutes.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="calendar" /> cannot be <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is less than the <paramref name="calendar" /> parameter's <see langword="MinSupportedDateTime.Year" /> or greater than <see langword="MaxSupportedDateTime.Year" />.-or-
		///         <paramref name="month" /> is either less than or greater than the number of months in <paramref name="year" /> in the <paramref name="calendar" />. -or-
		///         <paramref name="day" /> is less than one or greater than the number of days in <paramref name="month" />.-or-
		///         <paramref name="hour" /> is less than zero or greater than 23.-or-
		///         <paramref name="minute" /> is less than 0 or greater than 59.-or-
		///         <paramref name="second" /> is less than 0 or greater than 59.-or-
		///         <paramref name="millisecond" /> is less than 0 or greater than 999.-or-
		///         <paramref name="offset" /> is less than -14 hours or greater than 14 hours.-or-The <paramref name="year" />, <paramref name="month" />, and <paramref name="day" /> parameters cannot be represented as a date and time value.-or-The <see cref="P:System.DateTimeOffset.UtcDateTime" /> property is earlier than <see cref="F:System.DateTimeOffset.MinValue" /> or later than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x060004D8 RID: 1240 RVA: 0x00012EA0 File Offset: 0x000110A0
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset)
		{
			this._offsetMinutes = DateTimeOffset.ValidateOffset(offset);
			this._dateTime = DateTimeOffset.ValidateDate(new DateTime(year, month, day, hour, minute, second, millisecond, calendar), offset);
		}

		/// <summary>Gets a <see cref="T:System.DateTimeOffset" /> object that is set to the current date and time on the current computer, with the offset set to the local time's offset from Coordinated Universal Time (UTC).</summary>
		/// <returns>A <see cref="T:System.DateTimeOffset" /> object whose date and time is the current local time and whose offset is the local time zone's offset from Coordinated Universal Time (UTC).</returns>
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00012ED9 File Offset: 0x000110D9
		public static DateTimeOffset Now
		{
			get
			{
				return new DateTimeOffset(DateTime.Now);
			}
		}

		/// <summary>Gets a <see cref="T:System.DateTime" /> value that represents the date and time of the current <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <returns>The date and time of the current <see cref="T:System.DateTimeOffset" /> object.</returns>
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00012EE5 File Offset: 0x000110E5
		public DateTime DateTime
		{
			get
			{
				return this.ClockDateTime;
			}
		}

		/// <summary>Gets a <see cref="T:System.DateTime" /> value that represents the Coordinated Universal Time (UTC) date and time of the current <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <returns>The Coordinated Universal Time (UTC) date and time of the current <see cref="T:System.DateTimeOffset" /> object.</returns>
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00012EED File Offset: 0x000110ED
		public DateTime UtcDateTime
		{
			get
			{
				return DateTime.SpecifyKind(this._dateTime, DateTimeKind.Utc);
			}
		}

		/// <summary>Gets a <see cref="T:System.DateTime" /> value that represents the local date and time of the current <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <returns>The local date and time of the current <see cref="T:System.DateTimeOffset" /> object.</returns>
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00012EFC File Offset: 0x000110FC
		public DateTime LocalDateTime
		{
			get
			{
				return this.UtcDateTime.ToLocalTime();
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00012F18 File Offset: 0x00011118
		private DateTime ClockDateTime
		{
			get
			{
				return new DateTime((this._dateTime + this.Offset).Ticks, DateTimeKind.Unspecified);
			}
		}

		/// <summary>Gets the day of the month represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <returns>The day component of the current <see cref="T:System.DateTimeOffset" /> object, expressed as a value between 1 and 31.</returns>
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00012F44 File Offset: 0x00011144
		public int Day
		{
			get
			{
				return this.ClockDateTime.Day;
			}
		}

		/// <summary>Gets the hour component of the time represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <returns>The hour component of the current <see cref="T:System.DateTimeOffset" /> object. This property uses a 24-hour clock; the value ranges from 0 to 23.</returns>
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00012F60 File Offset: 0x00011160
		public int Hour
		{
			get
			{
				return this.ClockDateTime.Hour;
			}
		}

		/// <summary>Gets the millisecond component of the time represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <returns>The millisecond component of the current <see cref="T:System.DateTimeOffset" /> object, expressed as an integer between 0 and 999.</returns>
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00012F7C File Offset: 0x0001117C
		public int Millisecond
		{
			get
			{
				return this.ClockDateTime.Millisecond;
			}
		}

		/// <summary>Gets the minute component of the time represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <returns>The minute component of the current <see cref="T:System.DateTimeOffset" /> object, expressed as an integer between 0 and 59.</returns>
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00012F98 File Offset: 0x00011198
		public int Minute
		{
			get
			{
				return this.ClockDateTime.Minute;
			}
		}

		/// <summary>Gets the month component of the date represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <returns>The month component of the current <see cref="T:System.DateTimeOffset" /> object, expressed as an integer between 1 and 12.</returns>
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00012FB4 File Offset: 0x000111B4
		public int Month
		{
			get
			{
				return this.ClockDateTime.Month;
			}
		}

		/// <summary>Gets the time's offset from Coordinated Universal Time (UTC). </summary>
		/// <returns>The difference between the current <see cref="T:System.DateTimeOffset" /> object's time value and Coordinated Universal Time (UTC).</returns>
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00012FCF File Offset: 0x000111CF
		public TimeSpan Offset
		{
			get
			{
				return new TimeSpan(0, (int)this._offsetMinutes, 0);
			}
		}

		/// <summary>Gets the second component of the clock time represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <returns>The second component of the <see cref="T:System.DateTimeOffset" /> object, expressed as an integer value between 0 and 59.</returns>
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00012FE0 File Offset: 0x000111E0
		public int Second
		{
			get
			{
				return this.ClockDateTime.Second;
			}
		}

		/// <summary>Gets the number of ticks that represents the date and time of the current <see cref="T:System.DateTimeOffset" /> object in clock time.</summary>
		/// <returns>The number of ticks in the <see cref="T:System.DateTimeOffset" /> object's clock time.</returns>
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00012FFC File Offset: 0x000111FC
		public long Ticks
		{
			get
			{
				return this.ClockDateTime.Ticks;
			}
		}

		/// <summary>Gets the number of ticks that represents the date and time of the current <see cref="T:System.DateTimeOffset" /> object in Coordinated Universal Time (UTC).</summary>
		/// <returns>The number of ticks in the <see cref="T:System.DateTimeOffset" /> object's Coordinated Universal Time (UTC).</returns>
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00013018 File Offset: 0x00011218
		public long UtcTicks
		{
			get
			{
				return this.UtcDateTime.Ticks;
			}
		}

		/// <summary>Gets the time of day for the current <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <returns>The time interval of the current date that has elapsed since midnight.</returns>
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00013034 File Offset: 0x00011234
		public TimeSpan TimeOfDay
		{
			get
			{
				return this.ClockDateTime.TimeOfDay;
			}
		}

		/// <summary>Gets the year component of the date represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <returns>The year component of the current <see cref="T:System.DateTimeOffset" /> object, expressed as an integer value between 0 and 9999.</returns>
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00013050 File Offset: 0x00011250
		public int Year
		{
			get
			{
				return this.ClockDateTime.Year;
			}
		}

		/// <summary>Compares two <see cref="T:System.DateTimeOffset" /> objects and indicates whether the first is earlier than the second, equal to the second, or later than the second.</summary>
		/// <param name="first">The first object to compare.</param>
		/// <param name="second">The second object to compare.</param>
		/// <returns>A signed integer that indicates whether the value of the <paramref name="first" /> parameter is earlier than, later than, or the same time as the value of the <paramref name="second" /> parameter, as the following table shows.Return valueMeaningLess than zero
		///             <paramref name="first" /> is earlier than <paramref name="second" />.Zero
		///             <paramref name="first" /> is equal to <paramref name="second" />.Greater than zero
		///             <paramref name="first" /> is later than <paramref name="second" />.</returns>
		// Token: 0x060004E9 RID: 1257 RVA: 0x0001306B File Offset: 0x0001126B
		public static int Compare(DateTimeOffset first, DateTimeOffset second)
		{
			return DateTime.Compare(first.UtcDateTime, second.UtcDateTime);
		}

		/// <summary>Compares the value of the current <see cref="T:System.DateTimeOffset" /> object with another object of the same type.</summary>
		/// <param name="obj">The object to compare with the current <see cref="T:System.DateTimeOffset" /> object.</param>
		/// <returns>A 32-bit signed integer that indicates whether the current <see cref="T:System.DateTimeOffset" /> object is less than, equal to, or greater than <paramref name="obj" />. The return values of the method are interpreted as follows:Return ValueDescriptionLess than zeroThe current <see cref="T:System.DateTimeOffset" /> object is less than (earlier than) <paramref name="obj" />.ZeroThe current <see cref="T:System.DateTimeOffset" /> object is equal to (the same point in time as) <paramref name="obj" />.Greater than zeroThe current <see cref="T:System.DateTimeOffset" /> object is greater than (later than) <paramref name="obj" />.</returns>
		// Token: 0x060004EA RID: 1258 RVA: 0x00013080 File Offset: 0x00011280
		int IComparable.CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			if (!(obj is DateTimeOffset))
			{
				throw new ArgumentException("Object must be of type DateTimeOffset.");
			}
			DateTime utcDateTime = ((DateTimeOffset)obj).UtcDateTime;
			DateTime utcDateTime2 = this.UtcDateTime;
			if (utcDateTime2 > utcDateTime)
			{
				return 1;
			}
			if (utcDateTime2 < utcDateTime)
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Compares the current <see cref="T:System.DateTimeOffset" /> object to a specified <see cref="T:System.DateTimeOffset" /> object and indicates whether the current object is earlier than, the same as, or later than the second <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <param name="other">An object to compare with the current <see cref="T:System.DateTimeOffset" /> object.</param>
		/// <returns>A signed integer that indicates the relationship between the current <see cref="T:System.DateTimeOffset" /> object and <paramref name="other" />, as the following table shows.Return ValueDescriptionLess than zeroThe current <see cref="T:System.DateTimeOffset" /> object is earlier than <paramref name="other" />.ZeroThe current <see cref="T:System.DateTimeOffset" /> object is the same as <paramref name="other" />.Greater than zero.The current <see cref="T:System.DateTimeOffset" /> object is later than <paramref name="other" />.</returns>
		// Token: 0x060004EB RID: 1259 RVA: 0x000130D4 File Offset: 0x000112D4
		public int CompareTo(DateTimeOffset other)
		{
			DateTime utcDateTime = other.UtcDateTime;
			DateTime utcDateTime2 = this.UtcDateTime;
			if (utcDateTime2 > utcDateTime)
			{
				return 1;
			}
			if (utcDateTime2 < utcDateTime)
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Determines whether a <see cref="T:System.DateTimeOffset" /> object represents the same point in time as a specified object.</summary>
		/// <param name="obj">The object to compare to the current <see cref="T:System.DateTimeOffset" /> object.</param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="obj" /> parameter is a <see cref="T:System.DateTimeOffset" /> object and represents the same point in time as the current <see cref="T:System.DateTimeOffset" /> object; otherwise, <see langword="false" />.</returns>
		// Token: 0x060004EC RID: 1260 RVA: 0x00013108 File Offset: 0x00011308
		public override bool Equals(object obj)
		{
			return obj is DateTimeOffset && this.UtcDateTime.Equals(((DateTimeOffset)obj).UtcDateTime);
		}

		/// <summary>Determines whether the current <see cref="T:System.DateTimeOffset" /> object represents the same point in time as a specified <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <param name="other">An object to compare to the current <see cref="T:System.DateTimeOffset" /> object.   </param>
		/// <returns>
		///     <see langword="true" /> if both <see cref="T:System.DateTimeOffset" /> objects have the same <see cref="P:System.DateTimeOffset.UtcDateTime" /> value; otherwise, <see langword="false" />.</returns>
		// Token: 0x060004ED RID: 1261 RVA: 0x0001313C File Offset: 0x0001133C
		public bool Equals(DateTimeOffset other)
		{
			return this.UtcDateTime.Equals(other.UtcDateTime);
		}

		/// <summary>Converts a Unix time expressed as the number of seconds that have elapsed since 1970-01-01T00:00:00Z to a <see cref="T:System.DateTimeOffset" /> value. </summary>
		/// <param name="seconds">A Unix time, expressed as the number of seconds that have elapsed since 1970-01-01T00:00:00Z (January 1, 1970, at 12:00 AM UTC). For Unix times before this date, its value is negative. </param>
		/// <returns>A date and time value that represents the same moment in time as the Unix time. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="seconds" /> is less than  -62,135,596,800. -or-
		///         <paramref name="seconds" /> is greater than 253,402,300,799. </exception>
		// Token: 0x060004EE RID: 1262 RVA: 0x00013160 File Offset: 0x00011360
		public static DateTimeOffset FromUnixTimeSeconds(long seconds)
		{
			if (seconds < -62135596800L || seconds > 253402300799L)
			{
				throw new ArgumentOutOfRangeException("seconds", SR.Format("Valid values are between {0} and {1}, inclusive.", -62135596800L, 253402300799L));
			}
			return new DateTimeOffset(seconds * 10000000L + 621355968000000000L, TimeSpan.Zero);
		}

		/// <summary>Runs when the deserialization of an object has been completed.</summary>
		/// <param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented.</param>
		// Token: 0x060004EF RID: 1263 RVA: 0x000131D4 File Offset: 0x000113D4
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			try
			{
				DateTimeOffset.ValidateOffset(this.Offset);
				DateTimeOffset.ValidateDate(this.ClockDateTime, this.Offset);
			}
			catch (ArgumentException innerException)
			{
				throw new SerializationException("An error occurred while deserializing the object.  The serialized data is corrupt.", innerException);
			}
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data required to serialize the current <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <param name="info">The object to populate with data.</param>
		/// <param name="context">The destination for this serialization (see <see cref="T:System.Runtime.Serialization.StreamingContext" />).</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />.</exception>
		// Token: 0x060004F0 RID: 1264 RVA: 0x00013220 File Offset: 0x00011420
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("DateTime", this._dateTime);
			info.AddValue("OffsetMinutes", this._offsetMinutes);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00013254 File Offset: 0x00011454
		private DateTimeOffset(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this._dateTime = (DateTime)info.GetValue("DateTime", typeof(DateTime));
			this._offsetMinutes = (short)info.GetValue("OffsetMinutes", typeof(short));
		}

		/// <summary>Returns the hash code for the current <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060004F2 RID: 1266 RVA: 0x000132B0 File Offset: 0x000114B0
		public override int GetHashCode()
		{
			return this.UtcDateTime.GetHashCode();
		}

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent using the specified culture-specific format information.</summary>
		/// <param name="input">A string that contains a date and time to convert.   </param>
		/// <param name="formatProvider">An object that provides culture-specific format information about <paramref name="input" />.</param>
		/// <returns>An object that is equivalent to the date and time that is contained in <paramref name="input" />, as specified by <paramref name="formatProvider" />.</returns>
		/// <exception cref="T:System.ArgumentException">The offset is greater than 14 hours or less than -14 hours.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="input" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="input" /> does not contain a valid string representation of a date and time.-or-
		///         <paramref name="input" /> contains the string representation of an offset value without a date or time.</exception>
		// Token: 0x060004F3 RID: 1267 RVA: 0x000132CB File Offset: 0x000114CB
		public static DateTimeOffset Parse(string input, IFormatProvider formatProvider)
		{
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			return DateTimeOffset.Parse(input, formatProvider, DateTimeStyles.None);
		}

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent using the specified culture-specific format information and formatting style.</summary>
		/// <param name="input">A string that contains a date and time to convert.   </param>
		/// <param name="formatProvider">An object that provides culture-specific format information about <paramref name="input" />.</param>
		/// <param name="styles">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="input" />. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.   </param>
		/// <returns>An object that is equivalent to the date and time that is contained in <paramref name="input" /> as specified by <paramref name="formatProvider" /> and <paramref name="styles" />.</returns>
		/// <exception cref="T:System.ArgumentException">The offset is greater than 14 hours or less than -14 hours.-or-
		///         <paramref name="styles" /> is not a valid <see cref="T:System.Globalization.DateTimeStyles" /> value.-or-
		///         <paramref name="styles" /> includes an unsupported <see cref="T:System.Globalization.DateTimeStyles" /> value.-or-
		///         <paramref name="styles" /> includes <see cref="T:System.Globalization.DateTimeStyles" /> values that cannot be used together.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="input" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="input" /> does not contain a valid string representation of a date and time.-or-
		///         <paramref name="input" /> contains the string representation of an offset value without a date or time.</exception>
		// Token: 0x060004F4 RID: 1268 RVA: 0x000132E0 File Offset: 0x000114E0
		public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.Parse(input, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
		}

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly.</summary>
		/// <param name="input">A string that contains a date and time to convert.</param>
		/// <param name="format">A format specifier that defines the expected format of <paramref name="input" />.</param>
		/// <param name="formatProvider">An object that supplies culture-specific formatting information about <paramref name="input" />.</param>
		/// <param name="styles">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="input" />.</param>
		/// <returns>An object that is equivalent to the date and time that is contained in the <paramref name="input" /> parameter, as specified by the <paramref name="format" />, <paramref name="formatProvider" />, and <paramref name="styles" /> parameters.</returns>
		/// <exception cref="T:System.ArgumentException">The offset is greater than 14 hours or less than -14 hours.-or-The <paramref name="styles" /> parameter includes an unsupported value.-or-The <paramref name="styles" /> parameter contains <see cref="T:System.Globalization.DateTimeStyles" /> values that cannot be used together.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="input" /> is <see langword="null" />.-or-
		///         <paramref name="format" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="input" /> is an empty string ("").-or-
		///         <paramref name="input" /> does not contain a valid string representation of a date and time.-or-
		///         <paramref name="format" /> is an empty string.-or-
		///         The hour component and the AM/PM designator in <paramref name="input" /> do not agree. </exception>
		// Token: 0x060004F5 RID: 1269 RVA: 0x00013328 File Offset: 0x00011528
		public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			if (format == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.format);
			}
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.ParseExact(input, format, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
		}

		/// <summary>Converts the value of the current <see cref="T:System.DateTimeOffset" /> object to its equivalent string representation.</summary>
		/// <returns>A string representation of a <see cref="T:System.DateTimeOffset" /> object that includes the offset appended at the end of the string.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by the current culture. </exception>
		// Token: 0x060004F6 RID: 1270 RVA: 0x0001337E File Offset: 0x0001157E
		public override string ToString()
		{
			return DateTimeFormat.Format(this.ClockDateTime, null, null, this.Offset);
		}

		/// <summary>Converts the value of the current <see cref="T:System.DateTimeOffset" /> object to its equivalent string representation using the specified culture-specific formatting information.</summary>
		/// <param name="formatProvider">An object that supplies culture-specific formatting information.</param>
		/// <returns>A string representation of the value of the current <see cref="T:System.DateTimeOffset" /> object, as specified by <paramref name="formatProvider" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by <paramref name="formatProvider" />. </exception>
		// Token: 0x060004F7 RID: 1271 RVA: 0x00013393 File Offset: 0x00011593
		public string ToString(IFormatProvider formatProvider)
		{
			return DateTimeFormat.Format(this.ClockDateTime, null, formatProvider, this.Offset);
		}

		/// <summary>Converts the value of the current <see cref="T:System.DateTimeOffset" /> object to its equivalent string representation using the specified format and culture-specific format information.</summary>
		/// <param name="format">A format string.</param>
		/// <param name="formatProvider">An object that supplies culture-specific formatting information.</param>
		/// <returns>A string representation of the value of the current <see cref="T:System.DateTimeOffset" /> object, as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
		/// <exception cref="T:System.FormatException">The length of <paramref name="format" /> is one, and it is not one of the standard format specifier characters defined for <see cref="T:System.Globalization.DateTimeFormatInfo" />.-or-
		///         <paramref name="format" /> does not contain a valid custom format pattern. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by <paramref name="formatProvider" />. </exception>
		// Token: 0x060004F8 RID: 1272 RVA: 0x000133A8 File Offset: 0x000115A8
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return DateTimeFormat.Format(this.ClockDateTime, format, formatProvider, this.Offset);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000133BD File Offset: 0x000115BD
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider formatProvider = null)
		{
			return DateTimeFormat.TryFormat(this.ClockDateTime, destination, out charsWritten, format, formatProvider, this.Offset);
		}

		/// <summary>Converts the current <see cref="T:System.DateTimeOffset" /> object to a <see cref="T:System.DateTimeOffset" /> value that represents the Coordinated Universal Time (UTC).</summary>
		/// <returns>An object that represents the date and time of the current <see cref="T:System.DateTimeOffset" /> object converted to Coordinated Universal Time (UTC).</returns>
		// Token: 0x060004FA RID: 1274 RVA: 0x000133D5 File Offset: 0x000115D5
		public DateTimeOffset ToUniversalTime()
		{
			return new DateTimeOffset(this.UtcDateTime);
		}

		/// <summary>Tries to convert a specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent, and returns a value that indicates whether the conversion succeeded.</summary>
		/// <param name="input">A string that contains a date and time to convert.</param>
		/// <param name="formatProvider">An object that provides culture-specific formatting information about <paramref name="input" />.</param>
		/// <param name="styles">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="input" />. </param>
		/// <param name="result">When the method returns, contains the <see cref="T:System.DateTimeOffset" /> value equivalent to the date and time of <paramref name="input" />, if the conversion succeeded, or <see cref="F:System.DateTimeOffset.MinValue" />, if the conversion failed. The conversion fails if the <paramref name="input" /> parameter is <see langword="null" /> or does not contain a valid string representation of a date and time. This parameter is passed uninitialized.</param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="input" /> parameter is successfully converted; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="styles" /> includes an undefined <see cref="T:System.Globalization.DateTimeStyles" /> value.-or-
		///         <see cref="F:System.Globalization.DateTimeStyles.NoCurrentDateDefault" />  is not supported.-or-
		///         <paramref name="styles" /> includes mutually exclusive <see cref="T:System.Globalization.DateTimeStyles" /> values.</exception>
		// Token: 0x060004FB RID: 1275 RVA: 0x000133E4 File Offset: 0x000115E4
		public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null)
			{
				result = default(DateTimeOffset);
				return false;
			}
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParse(input, DateTimeFormatInfo.GetInstance(formatProvider), styles, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly.</summary>
		/// <param name="input">A string that contains a date and time to convert.</param>
		/// <param name="format">A format specifier that defines the required format of <paramref name="input" />.</param>
		/// <param name="formatProvider">An object that supplies culture-specific formatting information about <paramref name="input" />.</param>
		/// <param name="styles">A bitwise combination of enumeration values that indicates the permitted format of input. A typical value to specify is <see langword="None" />.</param>
		/// <param name="result">When the method returns, contains the <see cref="T:System.DateTimeOffset" /> equivalent to the date and time of <paramref name="input" />, if the conversion succeeded, or <see cref="F:System.DateTimeOffset.MinValue" />, if the conversion failed. The conversion fails if the <paramref name="input" /> parameter is <see langword="null" />, or does not contain a valid string representation of a date and time in the expected format defined by <paramref name="format" /> and <paramref name="provider" />. This parameter is passed uninitialized.</param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="input" /> parameter is successfully converted; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="styles" /> includes an undefined <see cref="T:System.Globalization.DateTimeStyles" /> value.-or-
		///         <see cref="F:System.Globalization.DateTimeStyles.NoCurrentDateDefault" />  is not supported.-or-
		///         <paramref name="styles" /> includes mutually exclusive <see cref="T:System.Globalization.DateTimeStyles" /> values.</exception>
		// Token: 0x060004FC RID: 1276 RVA: 0x00013434 File Offset: 0x00011634
		public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null || format == null)
			{
				result = default(DateTimeOffset);
				return false;
			}
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParseExact(input, format, DateTimeFormatInfo.GetInstance(formatProvider), styles, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00013490 File Offset: 0x00011690
		private static short ValidateOffset(TimeSpan offset)
		{
			long ticks = offset.Ticks;
			if (ticks % 600000000L != 0L)
			{
				throw new ArgumentException("Offset must be specified in whole minutes.", "offset");
			}
			if (ticks < -504000000000L || ticks > 504000000000L)
			{
				throw new ArgumentOutOfRangeException("offset", "Offset must be within plus or minus 14 hours.");
			}
			return (short)(offset.Ticks / 600000000L);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000134F8 File Offset: 0x000116F8
		private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset)
		{
			long num = dateTime.Ticks - offset.Ticks;
			if (num < 0L || num > 3155378975999999999L)
			{
				throw new ArgumentOutOfRangeException("offset", "The UTC time represented when the offset is applied must be between year 0 and 10,000.");
			}
			return new DateTime(num, DateTimeKind.Unspecified);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00013540 File Offset: 0x00011740
		private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName)
		{
			if ((style & ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind)) != DateTimeStyles.None)
			{
				throw new ArgumentException("An undefined DateTimeStyles value is being used.", parameterName);
			}
			if ((style & DateTimeStyles.AssumeLocal) != DateTimeStyles.None && (style & DateTimeStyles.AssumeUniversal) != DateTimeStyles.None)
			{
				throw new ArgumentException("The DateTimeStyles values AssumeLocal and AssumeUniversal cannot be used together.", parameterName);
			}
			if ((style & DateTimeStyles.NoCurrentDateDefault) != DateTimeStyles.None)
			{
				throw new ArgumentException("The DateTimeStyles value 'NoCurrentDateDefault' is not allowed when parsing DateTimeOffset.", parameterName);
			}
			style &= ~DateTimeStyles.RoundtripKind;
			style &= ~DateTimeStyles.AssumeLocal;
			return style;
		}

		/// <summary>Defines an implicit conversion of a <see cref="T:System.DateTime" /> object to a <see cref="T:System.DateTimeOffset" /> object.</summary>
		/// <param name="dateTime">The object to convert. </param>
		/// <returns>The converted object.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The Coordinated Universal Time (UTC) date and time that results from applying the offset is earlier than <see cref="F:System.DateTimeOffset.MinValue" />.-or-The UTC date and time that results from applying the offset is later than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
		// Token: 0x06000500 RID: 1280 RVA: 0x0001359B File Offset: 0x0001179B
		public static implicit operator DateTimeOffset(DateTime dateTime)
		{
			return new DateTimeOffset(dateTime);
		}

		/// <summary>Subtracts one <see cref="T:System.DateTimeOffset" /> object from another and yields a time interval.</summary>
		/// <param name="left">The minuend.   </param>
		/// <param name="right">The subtrahend.</param>
		/// <returns>An object that represents the difference between <paramref name="left" /> and <paramref name="right" />.</returns>
		// Token: 0x06000501 RID: 1281 RVA: 0x000135A3 File Offset: 0x000117A3
		public static TimeSpan operator -(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime - right.UtcDateTime;
		}

		/// <summary>Determines whether two specified <see cref="T:System.DateTimeOffset" /> objects represent the same point in time.</summary>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		/// <returns>
		///     <see langword="true" /> if both <see cref="T:System.DateTimeOffset" /> objects have the same <see cref="P:System.DateTimeOffset.UtcDateTime" /> value; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000502 RID: 1282 RVA: 0x000135B8 File Offset: 0x000117B8
		public static bool operator ==(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime == right.UtcDateTime;
		}

		/// <summary>Determines whether two specified <see cref="T:System.DateTimeOffset" /> objects refer to different points in time.</summary>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> do not have the same <see cref="P:System.DateTimeOffset.UtcDateTime" /> value; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000503 RID: 1283 RVA: 0x000135CD File Offset: 0x000117CD
		public static bool operator !=(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime != right.UtcDateTime;
		}

		/// <summary>Represents the earliest possible <see cref="T:System.DateTimeOffset" /> value. This field is read-only.</summary>
		// Token: 0x04000214 RID: 532
		public static readonly DateTimeOffset MinValue = new DateTimeOffset(0L, TimeSpan.Zero);

		/// <summary>Represents the greatest possible value of <see cref="T:System.DateTimeOffset" />. This field is read-only.</summary>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <see cref="F:System.DateTime.MaxValue" /> is outside the range of the current or specified culture's default calendar.</exception>
		// Token: 0x04000215 RID: 533
		public static readonly DateTimeOffset MaxValue = new DateTimeOffset(3155378975999999999L, TimeSpan.Zero);

		// Token: 0x04000216 RID: 534
		public static readonly DateTimeOffset UnixEpoch = new DateTimeOffset(621355968000000000L, TimeSpan.Zero);

		// Token: 0x04000217 RID: 535
		private readonly DateTime _dateTime;

		// Token: 0x04000218 RID: 536
		private readonly short _offsetMinutes;
	}
}
