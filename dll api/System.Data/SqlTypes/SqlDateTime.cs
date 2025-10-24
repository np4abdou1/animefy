using System;
using System.Data.Common;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Represents the date and time data ranging in value from January 1, 1753 to December 31, 9999 to an accuracy of 3.33 milliseconds to be stored in or retrieved from a database. The <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure has a different underlying data structure from its corresponding .NET Framework type, <see cref="T:System.DateTime" />, which can represent any time between 12:00:00 AM 1/1/0001 and 11:59:59 PM 12/31/9999, to the accuracy of 100 nanoseconds. <see cref="T:System.Data.SqlTypes.SqlDateTime" /> actually stores the relative difference to 00:00:00 AM 1/1/1900. Therefore, a conversion from "00:00:00 AM 1/1/1900" to an integer will return 0.</summary>
	// Token: 0x020000B6 RID: 182
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlDateTime : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x06000B26 RID: 2854 RVA: 0x0003E6DF File Offset: 0x0003C8DF
		private SqlDateTime(bool fNull)
		{
			this.m_fNotNull = false;
			this.m_day = 0;
			this.m_time = 0;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure using the specified <see cref="T:System.DateTime" /> value.</summary>
		/// <param name="value">A <see langword="DateTime" /> structure. </param>
		// Token: 0x06000B27 RID: 2855 RVA: 0x0003E6F6 File Offset: 0x0003C8F6
		public SqlDateTime(DateTime value)
		{
			this = SqlDateTime.FromDateTime(value);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure using the supplied parameters to initialize the year, month, day.</summary>
		/// <param name="year">An integer representing the year of the of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="month">An integer value representing the month of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="day">An integer value representing the day number of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		// Token: 0x06000B28 RID: 2856 RVA: 0x0003E704 File Offset: 0x0003C904
		public SqlDateTime(int year, int month, int day)
		{
			this = new SqlDateTime(year, month, day, 0, 0, 0, 0.0);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure using the supplied parameters to initialize the year, month, day, hour, minute, and second of the new structure.</summary>
		/// <param name="year">An integer value representing the year of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="month">An integer value representing the month of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="day">An integer value representing the day of the month of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="hour">An integer value representing the hour of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="minute">An integer value representing the minute of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="second">An integer value representing the second of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		// Token: 0x06000B29 RID: 2857 RVA: 0x0003E71B File Offset: 0x0003C91B
		public SqlDateTime(int year, int month, int day, int hour, int minute, int second)
		{
			this = new SqlDateTime(year, month, day, hour, minute, second, 0.0);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure using the supplied parameters to initialize the year, month, day, hour, minute, second, and millisecond of the new structure.</summary>
		/// <param name="year">An integer value representing the year of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="month">An integer value representing the month of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="day">An integer value representing the day of the month of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="hour">An integer value representing the hour of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="minute">An integer value representing the minute of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="second">An integer value representing the second of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="millisecond">An double value representing the millisecond of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		// Token: 0x06000B2A RID: 2858 RVA: 0x0003E738 File Offset: 0x0003C938
		public SqlDateTime(int year, int month, int day, int hour, int minute, int second, double millisecond)
		{
			if (year >= SqlDateTime.s_minYear && year <= SqlDateTime.s_maxYear && month >= 1 && month <= 12)
			{
				int[] array = SqlDateTime.IsLeapYear(year) ? SqlDateTime.s_daysToMonth366 : SqlDateTime.s_daysToMonth365;
				if (day >= 1 && day <= array[month] - array[month - 1])
				{
					int num = year - 1;
					int num2 = num * 365 + num / 4 - num / 100 + num / 400 + array[month - 1] + day - 1;
					num2 -= SqlDateTime.s_dayBase;
					if (num2 >= SqlDateTime.s_minDay && num2 <= SqlDateTime.s_maxDay && hour >= 0 && hour < 24 && minute >= 0 && minute < 60 && second >= 0 && second < 60 && millisecond >= 0.0 && millisecond < 1000.0)
					{
						double num3 = millisecond * SqlDateTime.s_SQLTicksPerMillisecond + 0.5;
						int num4 = hour * SqlDateTime.SQLTicksPerHour + minute * SqlDateTime.SQLTicksPerMinute + second * SqlDateTime.SQLTicksPerSecond + (int)num3;
						if (num4 > SqlDateTime.s_maxTime)
						{
							num4 = 0;
							num2++;
						}
						this = new SqlDateTime(num2, num4);
						return;
					}
				}
			}
			throw new SqlTypeException(SQLResource.InvalidDateTimeMessage);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure using the supplied parameters to initialize the year, month, day, hour, minute, second, and billisecond of the new structure.</summary>
		/// <param name="year">An integer value representing the year of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="month">An integer value representing the month of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="day">An integer value representing the day of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="hour">An integer value representing the hour of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="minute">An integer value representing the minute of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="second">An integer value representing the second of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="bilisecond">An integer value representing the bilisecond (billionth of a second) of the new <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		// Token: 0x06000B2B RID: 2859 RVA: 0x0003E878 File Offset: 0x0003CA78
		public SqlDateTime(int year, int month, int day, int hour, int minute, int second, int bilisecond)
		{
			this = new SqlDateTime(year, month, day, hour, minute, second, (double)bilisecond / 1000.0);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure using the supplied parameters.</summary>
		/// <param name="dayTicks">An integer value that represents the date as ticks. </param>
		/// <param name="timeTicks">An integer value that represents the time as ticks. </param>
		// Token: 0x06000B2C RID: 2860 RVA: 0x0003E8A4 File Offset: 0x0003CAA4
		public SqlDateTime(int dayTicks, int timeTicks)
		{
			if (dayTicks < SqlDateTime.s_minDay || dayTicks > SqlDateTime.s_maxDay || timeTicks < SqlDateTime.s_minTime || timeTicks > SqlDateTime.s_maxTime)
			{
				this.m_fNotNull = false;
				throw new OverflowException(SQLResource.DateTimeOverflowMessage);
			}
			this.m_day = dayTicks;
			this.m_time = timeTicks;
			this.m_fNotNull = true;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0003E8F8 File Offset: 0x0003CAF8
		internal SqlDateTime(double dblVal)
		{
			if (dblVal < (double)SqlDateTime.s_minDay || dblVal >= (double)(SqlDateTime.s_maxDay + 1))
			{
				throw new OverflowException(SQLResource.DateTimeOverflowMessage);
			}
			int num = (int)dblVal;
			int num2 = (int)((dblVal - (double)num) * (double)SqlDateTime.s_SQLTicksPerDay);
			if (num2 < 0)
			{
				num--;
				num2 += SqlDateTime.s_SQLTicksPerDay;
			}
			else if (num2 >= SqlDateTime.s_SQLTicksPerDay)
			{
				num++;
				num2 -= SqlDateTime.s_SQLTicksPerDay;
			}
			this = new SqlDateTime(num, num2);
		}

		/// <summary>Indicates whether this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure is null.</summary>
		/// <returns>
		///     <see langword="true" /> if null. Otherwise, <see langword="false" />. </returns>
		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x0003E967 File Offset: 0x0003CB67
		public bool IsNull
		{
			get
			{
				return !this.m_fNotNull;
			}
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0003E974 File Offset: 0x0003CB74
		private static TimeSpan ToTimeSpan(SqlDateTime value)
		{
			long num = (long)((double)value.m_time / SqlDateTime.s_SQLTicksPerMillisecond + 0.5);
			return new TimeSpan((long)value.m_day * 864000000000L + num * 10000L);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0003E9B9 File Offset: 0x0003CBB9
		private static DateTime ToDateTime(SqlDateTime value)
		{
			return SqlDateTime.s_SQLBaseDate.Add(SqlDateTime.ToTimeSpan(value));
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0003E9CC File Offset: 0x0003CBCC
		internal static DateTime ToDateTime(int daypart, int timepart)
		{
			if (daypart < SqlDateTime.s_minDay || daypart > SqlDateTime.s_maxDay || timepart < SqlDateTime.s_minTime || timepart > SqlDateTime.s_maxTime)
			{
				throw new OverflowException(SQLResource.DateTimeOverflowMessage);
			}
			long num = (long)daypart * 864000000000L;
			long num2 = (long)((double)timepart / SqlDateTime.s_SQLTicksPerMillisecond + 0.5) * 10000L;
			return new DateTime(SqlDateTime.s_SQLBaseDateTicks + num + num2);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0003EA3C File Offset: 0x0003CC3C
		private static SqlDateTime FromTimeSpan(TimeSpan value)
		{
			if (value < SqlDateTime.s_minTimeSpan || value > SqlDateTime.s_maxTimeSpan)
			{
				throw new SqlTypeException(SQLResource.DateTimeOverflowMessage);
			}
			int num = value.Days;
			long num2 = value.Ticks - (long)num * 864000000000L;
			if (num2 < 0L)
			{
				num--;
				num2 += 864000000000L;
			}
			int num3 = (int)((double)num2 / 10000.0 * SqlDateTime.s_SQLTicksPerMillisecond + 0.5);
			if (num3 > SqlDateTime.s_maxTime)
			{
				num3 = 0;
				num++;
			}
			return new SqlDateTime(num, num3);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0003EAD3 File Offset: 0x0003CCD3
		private static SqlDateTime FromDateTime(DateTime value)
		{
			if (value == DateTime.MaxValue)
			{
				return SqlDateTime.MaxValue;
			}
			return SqlDateTime.FromTimeSpan(value.Subtract(SqlDateTime.s_SQLBaseDate));
		}

		/// <summary>Gets the value of the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. This property is read-only.</summary>
		/// <returns>The value of this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">The exception that is thrown when the <see langword="Value" /> property of a <see cref="N:System.Data.SqlTypes" /> structure is set to null.</exception>
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0003EAF9 File Offset: 0x0003CCF9
		public DateTime Value
		{
			get
			{
				if (this.m_fNotNull)
				{
					return SqlDateTime.ToDateTime(this);
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Gets the number of ticks representing the date of this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</summary>
		/// <returns>The number of ticks representing the date that is contained in the <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> property of this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">The exception that is thrown when the <see langword="Value" /> property of a <see cref="N:System.Data.SqlTypes" /> structure is set to null.</exception>
		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x0003EB14 File Offset: 0x0003CD14
		public int DayTicks
		{
			get
			{
				if (this.m_fNotNull)
				{
					return this.m_day;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Gets the number of ticks representing the time of this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</summary>
		/// <returns>The number of ticks representing the time of this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</returns>
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0003EB2A File Offset: 0x0003CD2A
		public int TimeTicks
		{
			get
			{
				if (this.m_fNotNull)
				{
					return this.m_time;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Converts a <see cref="T:System.DateTime" /> structure to a <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</summary>
		/// <param name="value">A <see langword="DateTime" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> is equal to the combined <see cref="P:System.DateTime.Date" /> and <see cref="P:System.DateTime.TimeOfDay" /> properties of the supplied <see cref="T:System.DateTime" /> structure.</returns>
		// Token: 0x06000B37 RID: 2871 RVA: 0x0003EB40 File Offset: 0x0003CD40
		public static implicit operator SqlDateTime(DateTime value)
		{
			return new SqlDateTime(value);
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure to a <see cref="T:System.DateTime" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</param>
		/// <returns>A <see cref="T:System.DateTime" /> object whose <see cref="P:System.DateTime.Date" /> and <see cref="P:System.DateTime.TimeOfDay" /> properties contain the same date and time values as the <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> property of the supplied <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</returns>
		// Token: 0x06000B38 RID: 2872 RVA: 0x0003EB48 File Offset: 0x0003CD48
		public static explicit operator DateTime(SqlDateTime x)
		{
			return SqlDateTime.ToDateTime(x);
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure to a <see cref="T:System.String" />.</summary>
		/// <returns>A <see langword="String" /> representing the <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> property of this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</returns>
		// Token: 0x06000B39 RID: 2873 RVA: 0x0003EB50 File Offset: 0x0003CD50
		public override string ToString()
		{
			if (this.IsNull)
			{
				return SQLResource.NullString;
			}
			return SqlDateTime.ToDateTime(this).ToString(null);
		}

		/// <summary>Converts the specified <see cref="T:System.String" /> representation of a date and time to its <see cref="T:System.Data.SqlTypes.SqlDateTime" /> equivalent.</summary>
		/// <param name="s">The <see langword="string" /> to be parsed. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure equal to the date and time represented by the specified <see langword="string" />.</returns>
		// Token: 0x06000B3A RID: 2874 RVA: 0x0003EB80 File Offset: 0x0003CD80
		public static SqlDateTime Parse(string s)
		{
			if (s == SQLResource.NullString)
			{
				return SqlDateTime.Null;
			}
			DateTime value;
			try
			{
				value = DateTime.Parse(s, CultureInfo.InvariantCulture);
			}
			catch (FormatException)
			{
				DateTimeFormatInfo provider = (DateTimeFormatInfo)CultureInfo.CurrentCulture.GetFormat(typeof(DateTimeFormatInfo));
				value = DateTime.ParseExact(s, SqlDateTime.s_dateTimeFormats, provider, DateTimeStyles.AllowWhiteSpaces);
			}
			return new SqlDateTime(value);
		}

		/// <summary>Adds the period of time indicated by the supplied <see cref="T:System.TimeSpan" /> parameter, <paramref name="t" />, to the supplied <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="t">A <see cref="T:System.TimeSpan" /> structure. </param>
		/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDateTime" />. If either argument is <see cref="F:System.Data.SqlTypes.SqlDateTime.Null" />, the new <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> is <see cref="F:System.Data.SqlTypes.SqlDateTime.Null" />.</returns>
		// Token: 0x06000B3B RID: 2875 RVA: 0x0003EBF0 File Offset: 0x0003CDF0
		public static SqlDateTime operator +(SqlDateTime x, TimeSpan t)
		{
			if (!x.IsNull)
			{
				return SqlDateTime.FromDateTime(SqlDateTime.ToDateTime(x) + t);
			}
			return SqlDateTime.Null;
		}

		/// <summary>Subtracts the supplied <see cref="T:System.TimeSpan" /> structure, <paramref name="t" />, from the supplied <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="t">A <see cref="T:System.TimeSpan" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure representing the results of the subtraction.</returns>
		// Token: 0x06000B3C RID: 2876 RVA: 0x0003EC12 File Offset: 0x0003CE12
		public static SqlDateTime operator -(SqlDateTime x, TimeSpan t)
		{
			if (!x.IsNull)
			{
				return SqlDateTime.FromDateTime(SqlDateTime.ToDateTime(x) - t);
			}
			return SqlDateTime.Null;
		}

		/// <summary>Adds a <see cref="T:System.Data.SqlTypes.SqlDateTime" /> to the specified <see langword="TimeSpan" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> value.</param>
		/// <param name="t">A <see langword="Timespan" /> value.</param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> value.</returns>
		// Token: 0x06000B3D RID: 2877 RVA: 0x0003EC34 File Offset: 0x0003CE34
		public static SqlDateTime Add(SqlDateTime x, TimeSpan t)
		{
			return x + t;
		}

		/// <summary>Subtracts the specified <see langword="Timespan" /> from this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> instance.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> value.</param>
		/// <param name="t">A <see langword="Timespan" /> value.</param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> value.</returns>
		// Token: 0x06000B3E RID: 2878 RVA: 0x0003EC3D File Offset: 0x0003CE3D
		public static SqlDateTime Subtract(SqlDateTime x, TimeSpan t)
		{
			return x - t;
		}

		/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlString" /> parameter to a <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> is equal to the date and time represented by the <see cref="T:System.Data.SqlTypes.SqlString" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlString" /> is null, the <see langword="Value" /> of the newly created <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure will be null.</returns>
		// Token: 0x06000B3F RID: 2879 RVA: 0x0003EC46 File Offset: 0x0003CE46
		public static explicit operator SqlDateTime(SqlString x)
		{
			if (!x.IsNull)
			{
				return SqlDateTime.Parse(x.Value);
			}
			return SqlDateTime.Null;
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0003EC63 File Offset: 0x0003CE63
		private static bool IsLeapYear(int year)
		{
			return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
		}

		/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structures to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <returns>
		///     <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />.</returns>
		// Token: 0x06000B41 RID: 2881 RVA: 0x0003EC7E File Offset: 0x0003CE7E
		public static SqlBoolean operator ==(SqlDateTime x, SqlDateTime y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_day == y.m_day && x.m_time == y.m_time);
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a logical comparison of two instances of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000B42 RID: 2882 RVA: 0x0003ECBC File Offset: 0x0003CEBC
		public static SqlBoolean operator !=(SqlDateTime x, SqlDateTime y)
		{
			return !(x == y);
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000B43 RID: 2883 RVA: 0x0003ECCC File Offset: 0x0003CECC
		public static SqlBoolean operator <(SqlDateTime x, SqlDateTime y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_day < y.m_day || (x.m_day == y.m_day && x.m_time < y.m_time));
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000B44 RID: 2884 RVA: 0x0003ED28 File Offset: 0x0003CF28
		public static SqlBoolean operator >(SqlDateTime x, SqlDateTime y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_day > y.m_day || (x.m_day == y.m_day && x.m_time > y.m_time));
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000B45 RID: 2885 RVA: 0x0003ED84 File Offset: 0x0003CF84
		public static SqlBoolean operator <=(SqlDateTime x, SqlDateTime y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_day < y.m_day || (x.m_day == y.m_day && x.m_time <= y.m_time));
			}
			return SqlBoolean.Null;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000B46 RID: 2886 RVA: 0x0003EDE4 File Offset: 0x0003CFE4
		public static SqlBoolean operator >=(SqlDateTime x, SqlDateTime y)
		{
			if (!x.IsNull && !y.IsNull)
			{
				return new SqlBoolean(x.m_day > y.m_day || (x.m_day == y.m_day && x.m_time >= y.m_time));
			}
			return SqlBoolean.Null;
		}

		/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structures to determine whether they are equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <returns>
		///     <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />.</returns>
		// Token: 0x06000B47 RID: 2887 RVA: 0x0003EE41 File Offset: 0x0003D041
		public static SqlBoolean Equals(SqlDateTime x, SqlDateTime y)
		{
			return x == y;
		}

		/// <summary>Performs a logical comparison of two instances of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> to determine whether they are not equal.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are not equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000B48 RID: 2888 RVA: 0x0003EE4A File Offset: 0x0003D04A
		public static SqlBoolean NotEquals(SqlDateTime x, SqlDateTime y)
		{
			return x != y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> to determine whether the first is less than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000B49 RID: 2889 RVA: 0x0003EE53 File Offset: 0x0003D053
		public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y)
		{
			return x < y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> to determine whether the first is greater than the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000B4A RID: 2890 RVA: 0x0003EE5C File Offset: 0x0003D05C
		public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y)
		{
			return x > y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> to determine whether the first is less than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000B4B RID: 2891 RVA: 0x0003EE65 File Offset: 0x0003D065
		public static SqlBoolean LessThanOrEqual(SqlDateTime x, SqlDateTime y)
		{
			return x <= y;
		}

		/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> to determine whether the first is greater than or equal to the second.</summary>
		/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure. </param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than or equal to the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x06000B4C RID: 2892 RVA: 0x0003EE6E File Offset: 0x0003D06E
		public static SqlBoolean GreaterThanOrEqual(SqlDateTime x, SqlDateTime y)
		{
			return x >= y;
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure to <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>A <see langword="SqlString" /> structure whose value is a string representing the date and time that is contained in this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</returns>
		// Token: 0x06000B4D RID: 2893 RVA: 0x0003EE77 File Offset: 0x0003D077
		public SqlString ToSqlString()
		{
			return (SqlString)this;
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure to the supplied <see cref="T:System.Object" /> and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to be compared. </param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return value Condition Less than zero This instance is less than the object. Zero This instance is the same as the object. Greater than zero This instance is greater than the object -or- The object is a null reference (<see langword="Nothing" /> as Visual Basic). </returns>
		// Token: 0x06000B4E RID: 2894 RVA: 0x0003EE84 File Offset: 0x0003D084
		public int CompareTo(object value)
		{
			if (value is SqlDateTime)
			{
				SqlDateTime value2 = (SqlDateTime)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlDateTime));
		}

		/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure to the supplied <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure and returns an indication of their relative values.</summary>
		/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure to be compared.</param>
		/// <returns>A signed number that indicates the relative values of the instance and the object.Return value Condition Less than zero This instance is less than <see cref="T:System.Data.SqlTypes.SqlDateTime" />. Zero This instance is the same as <see cref="T:System.Data.SqlTypes.SqlDateTime" />. Greater than zero This instance is greater than <see cref="T:System.Data.SqlTypes.SqlDateTime" />-or- 
		///             <see cref="T:System.Data.SqlTypes.SqlDateTime" /> is a null reference (<see langword="Nothing " />in Visual Basic) </returns>
		// Token: 0x06000B4F RID: 2895 RVA: 0x0003EEC0 File Offset: 0x0003D0C0
		public int CompareTo(SqlDateTime value)
		{
			if (this.IsNull)
			{
				if (!value.IsNull)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (value.IsNull)
				{
					return 1;
				}
				if (this < value)
				{
					return -1;
				}
				if (this > value)
				{
					return 1;
				}
				return 0;
			}
		}

		/// <summary>Compares the supplied object parameter to the <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> object.</summary>
		/// <param name="value">The object to be compared. </param>
		/// <returns>
		///     <see langword="true" /> if the object is an instance of <see cref="T:System.Data.SqlTypes.SqlDateTime" /> and the two are equal; otherwise <see langword="false" />.</returns>
		// Token: 0x06000B50 RID: 2896 RVA: 0x0003EF18 File Offset: 0x0003D118
		public override bool Equals(object value)
		{
			if (!(value is SqlDateTime))
			{
				return false;
			}
			SqlDateTime y = (SqlDateTime)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Gets the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000B51 RID: 2897 RVA: 0x0003EF70 File Offset: 0x0003D170
		public override int GetHashCode()
		{
			if (!this.IsNull)
			{
				return this.Value.GetHashCode();
			}
			return 0;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <returns>An <see langword="XmlSchema" />.</returns>
		// Token: 0x06000B52 RID: 2898 RVA: 0x000020F7 File Offset: 0x000002F7
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="reader">
		///       <see langword="XmlReader " />
		///     </param>
		// Token: 0x06000B53 RID: 2899 RVA: 0x0003EF98 File Offset: 0x0003D198
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_fNotNull = false;
				return;
			}
			DateTime value = XmlConvert.ToDateTime(reader.ReadElementString(), XmlDateTimeSerializationMode.RoundtripKind);
			if (value.Kind != DateTimeKind.Unspecified)
			{
				throw new SqlTypeException(SQLResource.TimeZoneSpecifiedMessage);
			}
			SqlDateTime sqlDateTime = SqlDateTime.FromDateTime(value);
			this.m_day = sqlDateTime.DayTicks;
			this.m_time = sqlDateTime.TimeTicks;
			this.m_fNotNull = true;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="writer">
		///       <see langword="XmlWriter " />
		///     </param>
		// Token: 0x06000B54 RID: 2900 RVA: 0x0003F019 File Offset: 0x0003D219
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString(XmlConvert.ToString(this.Value, SqlDateTime.s_ISO8601_DateTimeFormat));
		}

		/// <summary>Returns the XML Schema definition language (XSD) of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">A <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>A <see langword="string" /> value that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06000B55 RID: 2901 RVA: 0x0003F054 File Offset: 0x0003D254
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("dateTime", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x040003AA RID: 938
		private bool m_fNotNull;

		// Token: 0x040003AB RID: 939
		private int m_day;

		// Token: 0x040003AC RID: 940
		private int m_time;

		// Token: 0x040003AD RID: 941
		private static readonly double s_SQLTicksPerMillisecond = 0.3;

		/// <summary>A constant whose value is the number of ticks equivalent to one second.</summary>
		// Token: 0x040003AE RID: 942
		public static readonly int SQLTicksPerSecond = 300;

		/// <summary>A constant whose value is the number of ticks equivalent to one minute.</summary>
		// Token: 0x040003AF RID: 943
		public static readonly int SQLTicksPerMinute = SqlDateTime.SQLTicksPerSecond * 60;

		/// <summary>A constant whose value is the number of ticks equivalent to one hour.</summary>
		// Token: 0x040003B0 RID: 944
		public static readonly int SQLTicksPerHour = SqlDateTime.SQLTicksPerMinute * 60;

		// Token: 0x040003B1 RID: 945
		private static readonly int s_SQLTicksPerDay = SqlDateTime.SQLTicksPerHour * 24;

		// Token: 0x040003B2 RID: 946
		private static readonly long s_ticksPerSecond = 10000000L;

		// Token: 0x040003B3 RID: 947
		private static readonly DateTime s_SQLBaseDate = new DateTime(1900, 1, 1);

		// Token: 0x040003B4 RID: 948
		private static readonly long s_SQLBaseDateTicks = SqlDateTime.s_SQLBaseDate.Ticks;

		// Token: 0x040003B5 RID: 949
		private static readonly int s_minYear = 1753;

		// Token: 0x040003B6 RID: 950
		private static readonly int s_maxYear = 9999;

		// Token: 0x040003B7 RID: 951
		private static readonly int s_minDay = -53690;

		// Token: 0x040003B8 RID: 952
		private static readonly int s_maxDay = 2958463;

		// Token: 0x040003B9 RID: 953
		private static readonly int s_minTime = 0;

		// Token: 0x040003BA RID: 954
		private static readonly int s_maxTime = SqlDateTime.s_SQLTicksPerDay - 1;

		// Token: 0x040003BB RID: 955
		private static readonly int s_dayBase = 693595;

		// Token: 0x040003BC RID: 956
		private static readonly int[] s_daysToMonth365 = new int[]
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

		// Token: 0x040003BD RID: 957
		private static readonly int[] s_daysToMonth366 = new int[]
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

		// Token: 0x040003BE RID: 958
		private static readonly DateTime s_minDateTime = new DateTime(1753, 1, 1);

		// Token: 0x040003BF RID: 959
		private static readonly DateTime s_maxDateTime = DateTime.MaxValue;

		// Token: 0x040003C0 RID: 960
		private static readonly TimeSpan s_minTimeSpan = SqlDateTime.s_minDateTime.Subtract(SqlDateTime.s_SQLBaseDate);

		// Token: 0x040003C1 RID: 961
		private static readonly TimeSpan s_maxTimeSpan = SqlDateTime.s_maxDateTime.Subtract(SqlDateTime.s_SQLBaseDate);

		// Token: 0x040003C2 RID: 962
		private static readonly string s_ISO8601_DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fff";

		// Token: 0x040003C3 RID: 963
		private static readonly string[] s_dateTimeFormats = new string[]
		{
			"MMM d yyyy hh:mm:ss:ffftt",
			"MMM d yyyy hh:mm:ss:fff",
			"d MMM yyyy hh:mm:ss:ffftt",
			"d MMM yyyy hh:mm:ss:fff",
			"hh:mm:ss:ffftt",
			"hh:mm:ss:fff",
			"yyMMdd",
			"yyyyMMdd"
		};

		// Token: 0x040003C4 RID: 964
		private const DateTimeStyles x_DateTimeStyle = DateTimeStyles.AllowWhiteSpaces;

		/// <summary>Represents the minimum valid date value for a <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</summary>
		// Token: 0x040003C5 RID: 965
		public static readonly SqlDateTime MinValue = new SqlDateTime(SqlDateTime.s_minDay, 0);

		/// <summary>Represents the maximum valid date value for a <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</summary>
		// Token: 0x040003C6 RID: 966
		public static readonly SqlDateTime MaxValue = new SqlDateTime(SqlDateTime.s_maxDay, SqlDateTime.s_maxTime);

		/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlDateTime" /> structure.</summary>
		// Token: 0x040003C7 RID: 967
		public static readonly SqlDateTime Null = new SqlDateTime(true);
	}
}
