using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Represents an instant in time, typically expressed as a date and time of day. To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x0200008F RID: 143
	[Serializable]
	[StructLayout(3)]
	public readonly struct DateTime : IComparable, IFormattable, IConvertible, IComparable<DateTime>, IEquatable<DateTime>, ISerializable, ISpanFormattable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to a specified number of ticks.</summary>
		/// <param name="ticks">A date and time expressed in the number of 100-nanosecond intervals that have elapsed since January 1, 0001 at 00:00:00.000 in the Gregorian calendar. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="ticks" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		// Token: 0x06000475 RID: 1141 RVA: 0x00011C44 File Offset: 0x0000FE44
		public DateTime(long ticks)
		{
			if (ticks < 0L || ticks > 3155378975999999999L)
			{
				throw new ArgumentOutOfRangeException("ticks", "Ticks must be between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.");
			}
			this._dateData = (ulong)ticks;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00011C6E File Offset: 0x0000FE6E
		private DateTime(ulong dateData)
		{
			this._dateData = dateData;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to a specified number of ticks and to Coordinated Universal Time (UTC) or local time.</summary>
		/// <param name="ticks">A date and time expressed in the number of 100-nanosecond intervals that have elapsed since January 1, 0001 at 00:00:00.000 in the Gregorian calendar. </param>
		/// <param name="kind">One of the enumeration values that indicates whether <paramref name="ticks" /> specifies a local time, Coordinated Universal Time (UTC), or neither.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="ticks" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="kind" /> is not one of the <see cref="T:System.DateTimeKind" /> values.</exception>
		// Token: 0x06000477 RID: 1143 RVA: 0x00011C78 File Offset: 0x0000FE78
		public DateTime(long ticks, DateTimeKind kind)
		{
			if (ticks < 0L || ticks > 3155378975999999999L)
			{
				throw new ArgumentOutOfRangeException("ticks", "Ticks must be between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.");
			}
			if (kind < DateTimeKind.Unspecified || kind > DateTimeKind.Local)
			{
				throw new ArgumentException("Invalid DateTimeKind value.", "kind");
			}
			this._dateData = (ulong)(ticks | (long)kind << 62);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00011CCC File Offset: 0x0000FECC
		internal DateTime(long ticks, DateTimeKind kind, bool isAmbiguousDst)
		{
			if (ticks < 0L || ticks > 3155378975999999999L)
			{
				throw new ArgumentOutOfRangeException("ticks", "Ticks must be between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.");
			}
			this._dateData = (ulong)(ticks | (isAmbiguousDst ? -4611686018427387904L : long.MinValue));
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to the specified year, month, and day.</summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in <paramref name="month" />). </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is less than 1 or greater than 9999.-or- 
		///         <paramref name="month" /> is less than 1 or greater than 12.-or- 
		///         <paramref name="day" /> is less than 1 or greater than the number of days in <paramref name="month" />. </exception>
		// Token: 0x06000479 RID: 1145 RVA: 0x00011D19 File Offset: 0x0000FF19
		public DateTime(int year, int month, int day)
		{
			this._dateData = (ulong)DateTime.DateToTicks(year, month, day);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to the specified year, month, day, hour, minute, and second.</summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in <paramref name="month" />). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is less than 1 or greater than 9999. -or- 
		///         <paramref name="month" /> is less than 1 or greater than 12. -or- 
		///         <paramref name="day" /> is less than 1 or greater than the number of days in <paramref name="month" />.-or- 
		///         <paramref name="hour" /> is less than 0 or greater than 23. -or- 
		///         <paramref name="minute" /> is less than 0 or greater than 59. -or- 
		///         <paramref name="second" /> is less than 0 or greater than 59. </exception>
		// Token: 0x0600047A RID: 1146 RVA: 0x00011D29 File Offset: 0x0000FF29
		public DateTime(int year, int month, int day, int hour, int minute, int second)
		{
			this._dateData = (ulong)(DateTime.DateToTicks(year, month, day) + DateTime.TimeToTicks(hour, minute, second));
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to the specified year, month, day, hour, minute, second, and Coordinated Universal Time (UTC) or local time.</summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in <paramref name="month" />). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="kind">One of the enumeration values that indicates whether <paramref name="year" />, <paramref name="month" />, <paramref name="day" />, <paramref name="hour" />, <paramref name="minute" /> and <paramref name="second" /> specify a local time, Coordinated Universal Time (UTC), or neither.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is less than 1 or greater than 9999. -or- 
		///         <paramref name="month" /> is less than 1 or greater than 12. -or- 
		///         <paramref name="day" /> is less than 1 or greater than the number of days in <paramref name="month" />.-or- 
		///         <paramref name="hour" /> is less than 0 or greater than 23. -or- 
		///         <paramref name="minute" /> is less than 0 or greater than 59. -or- 
		///         <paramref name="second" /> is less than 0 or greater than 59. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="kind" /> is not one of the <see cref="T:System.DateTimeKind" /> values.</exception>
		// Token: 0x0600047B RID: 1147 RVA: 0x00011D48 File Offset: 0x0000FF48
		public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind)
		{
			if (kind < DateTimeKind.Unspecified || kind > DateTimeKind.Local)
			{
				throw new ArgumentException("Invalid DateTimeKind value.", "kind");
			}
			long num = DateTime.DateToTicks(year, month, day) + DateTime.TimeToTicks(hour, minute, second);
			this._dateData = (ulong)(num | (long)kind << 62);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to the specified year, month, day, hour, minute, second, and millisecond.</summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in <paramref name="month" />). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="millisecond">The milliseconds (0 through 999). </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is less than 1 or greater than 9999.-or- 
		///         <paramref name="month" /> is less than 1 or greater than 12.-or- 
		///         <paramref name="day" /> is less than 1 or greater than the number of days in <paramref name="month" />.-or- 
		///         <paramref name="hour" /> is less than 0 or greater than 23.-or- 
		///         <paramref name="minute" /> is less than 0 or greater than 59.-or- 
		///         <paramref name="second" /> is less than 0 or greater than 59.-or- 
		///         <paramref name="millisecond" /> is less than 0 or greater than 999. </exception>
		// Token: 0x0600047C RID: 1148 RVA: 0x00011D94 File Offset: 0x0000FF94
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			if (millisecond < 0 || millisecond >= 1000)
			{
				throw new ArgumentOutOfRangeException("millisecond", SR.Format("Valid values are between {0} and {1}, inclusive.", 0, 999));
			}
			long num = DateTime.DateToTicks(year, month, day) + DateTime.TimeToTicks(hour, minute, second);
			num += (long)millisecond * 10000L;
			if (num < 0L || num > 3155378975999999999L)
			{
				throw new ArgumentException("Combination of arguments to the DateTime constructor is out of the legal range.");
			}
			this._dateData = (ulong)num;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to the specified year, month, day, hour, minute, second, and millisecond for the specified calendar.</summary>
		/// <param name="year">The year (1 through the number of years in <paramref name="calendar" />). </param>
		/// <param name="month">The month (1 through the number of months in <paramref name="calendar" />). </param>
		/// <param name="day">The day (1 through the number of days in <paramref name="month" />). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="millisecond">The milliseconds (0 through 999). </param>
		/// <param name="calendar">The calendar that is used to interpret <paramref name="year" />, <paramref name="month" />, and <paramref name="day" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="calendar" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is not in the range supported by <paramref name="calendar" />.-or- 
		///         <paramref name="month" /> is less than 1 or greater than the number of months in <paramref name="calendar" />.-or- 
		///         <paramref name="day" /> is less than 1 or greater than the number of days in <paramref name="month" />.-or- 
		///         <paramref name="hour" /> is less than 0 or greater than 23.-or- 
		///         <paramref name="minute" /> is less than 0 or greater than 59.-or- 
		///         <paramref name="second" /> is less than 0 or greater than 59.-or- 
		///         <paramref name="millisecond" /> is less than 0 or greater than 999. </exception>
		// Token: 0x0600047D RID: 1149 RVA: 0x00011E1C File Offset: 0x0001001C
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar)
		{
			if (calendar == null)
			{
				throw new ArgumentNullException("calendar");
			}
			if (millisecond < 0 || millisecond >= 1000)
			{
				throw new ArgumentOutOfRangeException("millisecond", SR.Format("Valid values are between {0} and {1}, inclusive.", 0, 999));
			}
			long num = calendar.ToDateTime(year, month, day, hour, minute, second, 0).Ticks;
			num += (long)millisecond * 10000L;
			if (num < 0L || num > 3155378975999999999L)
			{
				throw new ArgumentException("Combination of arguments to the DateTime constructor is out of the legal range.");
			}
			this._dateData = (ulong)num;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00011EB8 File Offset: 0x000100B8
		private DateTime(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			bool flag = false;
			bool flag2 = false;
			long dateData = 0L;
			ulong dateData2 = 0UL;
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string name = enumerator.Name;
				if (!(name == "ticks"))
				{
					if (name == "dateData")
					{
						dateData2 = Convert.ToUInt64(enumerator.Value, CultureInfo.InvariantCulture);
						flag2 = true;
					}
				}
				else
				{
					dateData = Convert.ToInt64(enumerator.Value, CultureInfo.InvariantCulture);
					flag = true;
				}
			}
			if (flag2)
			{
				this._dateData = dateData2;
			}
			else
			{
				if (!flag)
				{
					throw new SerializationException("Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'.");
				}
				this._dateData = (ulong)dateData;
			}
			long internalTicks = this.InternalTicks;
			if (internalTicks < 0L || internalTicks > 3155378975999999999L)
			{
				throw new SerializationException("Invalid serialized DateTime data. Ticks must be between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.");
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00011F8A File Offset: 0x0001018A
		internal long InternalTicks
		{
			get
			{
				return (long)(this._dateData & 4611686018427387903UL);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00011F9C File Offset: 0x0001019C
		private ulong InternalKind
		{
			get
			{
				return this._dateData & 13835058055282163712UL;
			}
		}

		/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the value of the specified <see cref="T:System.TimeSpan" /> to the value of this instance.</summary>
		/// <param name="value">A positive or negative time interval. </param>
		/// <returns>An object whose value is the sum of the date and time represented by this instance and the time interval represented by <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		// Token: 0x06000481 RID: 1153 RVA: 0x00011FAE File Offset: 0x000101AE
		public DateTime Add(TimeSpan value)
		{
			return this.AddTicks(value._ticks);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00011FBC File Offset: 0x000101BC
		private DateTime Add(double value, int scale)
		{
			long num = (long)(value * (double)scale + ((value >= 0.0) ? 0.5 : -0.5));
			if (num <= -315537897600000L || num >= 315537897600000L)
			{
				throw new ArgumentOutOfRangeException("value", "Value to add was out of range.");
			}
			return this.AddTicks(num * 10000L);
		}

		/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of days to the value of this instance.</summary>
		/// <param name="value">A number of whole and fractional days. The <paramref name="value" /> parameter can be negative or positive. </param>
		/// <returns>An object whose value is the sum of the date and time represented by this instance and the number of days represented by <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		// Token: 0x06000483 RID: 1155 RVA: 0x00012026 File Offset: 0x00010226
		public DateTime AddDays(double value)
		{
			return this.Add(value, 86400000);
		}

		/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of months to the value of this instance.</summary>
		/// <param name="months">A number of months. The <paramref name="months" /> parameter can be negative or positive. </param>
		/// <returns>An object whose value is the sum of the date and time represented by this instance and <paramref name="months" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />.-or- 
		///         <paramref name="months" /> is less than -120,000 or greater than 120,000. </exception>
		// Token: 0x06000484 RID: 1156 RVA: 0x00012034 File Offset: 0x00010234
		public DateTime AddMonths(int months)
		{
			if (months < -120000 || months > 120000)
			{
				throw new ArgumentOutOfRangeException("months", "Months value must be between +/-120000.");
			}
			int num;
			int num2;
			int num3;
			this.GetDatePart(out num, out num2, out num3);
			int num4 = num2 - 1 + months;
			if (num4 >= 0)
			{
				num2 = num4 % 12 + 1;
				num += num4 / 12;
			}
			else
			{
				num2 = 12 + (num4 + 1) % 12;
				num += (num4 - 11) / 12;
			}
			if (num < 1 || num > 9999)
			{
				throw new ArgumentOutOfRangeException("months", "The added or subtracted value results in an un-representable DateTime.");
			}
			int num5 = DateTime.DaysInMonth(num, num2);
			if (num3 > num5)
			{
				num3 = num5;
			}
			return new DateTime((ulong)(DateTime.DateToTicks(num, num2, num3) + this.InternalTicks % 864000000000L | (long)this.InternalKind));
		}

		/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of seconds to the value of this instance.</summary>
		/// <param name="value">A number of whole and fractional seconds. The <paramref name="value" /> parameter can be negative or positive. </param>
		/// <returns>An object whose value is the sum of the date and time represented by this instance and the number of seconds represented by <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		// Token: 0x06000485 RID: 1157 RVA: 0x000120ED File Offset: 0x000102ED
		public DateTime AddSeconds(double value)
		{
			return this.Add(value, 1000);
		}

		/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of ticks to the value of this instance.</summary>
		/// <param name="value">A number of 100-nanosecond ticks. The <paramref name="value" /> parameter can be positive or negative. </param>
		/// <returns>An object whose value is the sum of the date and time represented by this instance and the time represented by <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		// Token: 0x06000486 RID: 1158 RVA: 0x000120FC File Offset: 0x000102FC
		public DateTime AddTicks(long value)
		{
			long internalTicks = this.InternalTicks;
			if (value > 3155378975999999999L - internalTicks || value < 0L - internalTicks)
			{
				throw new ArgumentOutOfRangeException("value", "The added or subtracted value results in an un-representable DateTime.");
			}
			return new DateTime((ulong)(internalTicks + value | (long)this.InternalKind));
		}

		/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of years to the value of this instance.</summary>
		/// <param name="value">A number of years. The <paramref name="value" /> parameter can be negative or positive. </param>
		/// <returns>An object whose value is the sum of the date and time represented by this instance and the number of years represented by <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="value" /> or the resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		// Token: 0x06000487 RID: 1159 RVA: 0x00012144 File Offset: 0x00010344
		public DateTime AddYears(int value)
		{
			if (value < -10000 || value > 10000)
			{
				throw new ArgumentOutOfRangeException("years", "Years value must be between +/-10000.");
			}
			return this.AddMonths(value * 12);
		}

		/// <summary>Compares two instances of <see cref="T:System.DateTime" /> and returns an integer that indicates whether the first instance is earlier than, the same as, or later than the second instance.</summary>
		/// <param name="t1">The first object to compare. </param>
		/// <param name="t2">The second object to compare. </param>
		/// <returns>A signed number indicating the relative values of <paramref name="t1" /> and <paramref name="t2" />.Value Type Condition Less than zero 
		///             <paramref name="t1" /> is earlier than <paramref name="t2" />. Zero 
		///             <paramref name="t1" /> is the same as <paramref name="t2" />. Greater than zero 
		///             <paramref name="t1" /> is later than <paramref name="t2" />. </returns>
		// Token: 0x06000488 RID: 1160 RVA: 0x00012170 File Offset: 0x00010370
		public static int Compare(DateTime t1, DateTime t2)
		{
			long internalTicks = t1.InternalTicks;
			long internalTicks2 = t2.InternalTicks;
			if (internalTicks > internalTicks2)
			{
				return 1;
			}
			if (internalTicks < internalTicks2)
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Compares the value of this instance to a specified object that contains a specified <see cref="T:System.DateTime" /> value, and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified <see cref="T:System.DateTime" /> value.</summary>
		/// <param name="value">A boxed object to compare, or <see langword="null" />. </param>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Value Description Less than zero This instance is earlier than <paramref name="value" />. Zero This instance is the same as <paramref name="value" />. Greater than zero This instance is later than <paramref name="value" />, or <paramref name="value" /> is <see langword="null" />. </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is not a <see cref="T:System.DateTime" />. </exception>
		// Token: 0x06000489 RID: 1161 RVA: 0x0001219A File Offset: 0x0001039A
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is DateTime))
			{
				throw new ArgumentException("Object must be of type DateTime.");
			}
			return DateTime.Compare(this, (DateTime)value);
		}

		/// <summary>Compares the value of this instance to a specified <see cref="T:System.DateTime" /> value and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified <see cref="T:System.DateTime" /> value.</summary>
		/// <param name="value">The object to compare to the current instance. </param>
		/// <returns>A signed number indicating the relative values of this instance and the <paramref name="value" /> parameter.Value Description Less than zero This instance is earlier than <paramref name="value" />. Zero This instance is the same as <paramref name="value" />. Greater than zero This instance is later than <paramref name="value" />. </returns>
		// Token: 0x0600048A RID: 1162 RVA: 0x000121C5 File Offset: 0x000103C5
		public int CompareTo(DateTime value)
		{
			return DateTime.Compare(this, value);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x000121D4 File Offset: 0x000103D4
		private static long DateToTicks(int year, int month, int day)
		{
			if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
			{
				int[] array = DateTime.IsLeapYear(year) ? DateTime.s_daysToMonth366 : DateTime.s_daysToMonth365;
				if (day >= 1 && day <= array[month] - array[month - 1])
				{
					int num = year - 1;
					return (long)(num * 365 + num / 4 - num / 100 + num / 400 + array[month - 1] + day - 1) * 864000000000L;
				}
			}
			throw new ArgumentOutOfRangeException(null, "Year, Month, and Day parameters describe an un-representable DateTime.");
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00012258 File Offset: 0x00010458
		private static long TimeToTicks(int hour, int minute, int second)
		{
			if (hour >= 0 && hour < 24 && minute >= 0 && minute < 60 && second >= 0 && second < 60)
			{
				return TimeSpan.TimeToTicks(hour, minute, second);
			}
			throw new ArgumentOutOfRangeException(null, "Hour, Minute, and Second parameters describe an un-representable DateTime.");
		}

		/// <summary>Returns the number of days in the specified month and year.</summary>
		/// <param name="year">The year. </param>
		/// <param name="month">The month (a number ranging from 1 to 12). </param>
		/// <returns>The number of days in <paramref name="month" /> for the specified <paramref name="year" />.For example, if <paramref name="month" /> equals 2 for February, the return value is 28 or 29 depending upon whether <paramref name="year" /> is a leap year.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="month" /> is less than 1 or greater than 12.-or-
		///         <paramref name="year" /> is less than 1 or greater than 9999.</exception>
		// Token: 0x0600048D RID: 1165 RVA: 0x0001228C File Offset: 0x0001048C
		public static int DaysInMonth(int year, int month)
		{
			if (month < 1 || month > 12)
			{
				throw new ArgumentOutOfRangeException("month", "Month must be between one and twelve.");
			}
			int[] array = DateTime.IsLeapYear(year) ? DateTime.s_daysToMonth366 : DateTime.s_daysToMonth365;
			return array[month] - array[month - 1];
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <param name="value">The object to compare to this instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is an instance of <see cref="T:System.DateTime" /> and equals the value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600048E RID: 1166 RVA: 0x000122D0 File Offset: 0x000104D0
		public override bool Equals(object value)
		{
			return value is DateTime && this.InternalTicks == ((DateTime)value).InternalTicks;
		}

		/// <summary>
		///     Returns a value indicating whether the value of this instance is equal to the value of the specified <see cref="T:System.DateTime" /> instance.</summary>
		/// <param name="value">The object to compare to this instance. </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="value" /> parameter equals the value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600048F RID: 1167 RVA: 0x000122FD File Offset: 0x000104FD
		public bool Equals(DateTime value)
		{
			return this.InternalTicks == value.InternalTicks;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00012310 File Offset: 0x00010510
		internal static DateTime FromBinaryRaw(long dateData)
		{
			long num = dateData & 4611686018427387903L;
			if (num < 0L || num > 3155378975999999999L)
			{
				throw new ArgumentException("The binary data must result in a DateTime with ticks between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.", "dateData");
			}
			return new DateTime((ulong)dateData);
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data needed to serialize the current <see cref="T:System.DateTime" /> object.</summary>
		/// <param name="info">The object to populate with data. </param>
		/// <param name="context">The destination for this serialization. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />.</exception>
		// Token: 0x06000491 RID: 1169 RVA: 0x00012350 File Offset: 0x00010550
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("ticks", this.InternalTicks);
			info.AddValue("dateData", this._dateData);
		}

		/// <summary>Creates a new <see cref="T:System.DateTime" /> object that has the same number of ticks as the specified <see cref="T:System.DateTime" />, but is designated as either local time, Coordinated Universal Time (UTC), or neither, as indicated by the specified <see cref="T:System.DateTimeKind" /> value.</summary>
		/// <param name="value">A date and time. </param>
		/// <param name="kind">One of the enumeration values that indicates whether the new object represents local time, UTC, or neither.</param>
		/// <returns>A new object that has the same number of ticks as the object represented by the <paramref name="value" /> parameter and the <see cref="T:System.DateTimeKind" /> value specified by the <paramref name="kind" /> parameter. </returns>
		// Token: 0x06000492 RID: 1170 RVA: 0x00012382 File Offset: 0x00010582
		public static DateTime SpecifyKind(DateTime value, DateTimeKind kind)
		{
			return new DateTime(value.InternalTicks, kind);
		}

		/// <summary>Gets the date component of this instance.</summary>
		/// <returns>A new object with the same date as this instance, and the time value set to 12:00:00 midnight (00:00:00).</returns>
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00012391 File Offset: 0x00010591
		public DateTime Date
		{
			get
			{
				long internalTicks = this.InternalTicks;
				return new DateTime((ulong)(internalTicks - internalTicks % 864000000000L | (long)this.InternalKind));
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000123B4 File Offset: 0x000105B4
		private int GetDatePart(int part)
		{
			int i = (int)(this.InternalTicks / 864000000000L);
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
			int[] array = (num4 == 3 && (num3 != 24 || num2 == 3)) ? DateTime.s_daysToMonth366 : DateTime.s_daysToMonth365;
			int num5 = (i >> 5) + 1;
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

		// Token: 0x06000495 RID: 1173 RVA: 0x0001249C File Offset: 0x0001069C
		internal void GetDatePart(out int year, out int month, out int day)
		{
			int i = (int)(this.InternalTicks / 864000000000L);
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
			year = num * 400 + num2 * 100 + num3 * 4 + num4 + 1;
			i -= num4 * 365;
			int[] array = (num4 == 3 && (num3 != 24 || num2 == 3)) ? DateTime.s_daysToMonth366 : DateTime.s_daysToMonth365;
			int num5 = (i >> 5) + 1;
			while (i >= array[num5])
			{
				num5++;
			}
			month = num5;
			day = i - array[num5 - 1] + 1;
		}

		/// <summary>Gets the day of the month represented by this instance.</summary>
		/// <returns>The day component, expressed as a value between 1 and 31.</returns>
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00012576 File Offset: 0x00010776
		public int Day
		{
			get
			{
				return this.GetDatePart(3);
			}
		}

		/// <summary>Gets the day of the week represented by this instance.</summary>
		/// <returns>An enumerated constant that indicates the day of the week of this <see cref="T:System.DateTime" /> value. </returns>
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0001257F File Offset: 0x0001077F
		public DayOfWeek DayOfWeek
		{
			get
			{
				return (DayOfWeek)((this.InternalTicks / 864000000000L + 1L) % 7L);
			}
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000498 RID: 1176 RVA: 0x00012598 File Offset: 0x00010798
		public override int GetHashCode()
		{
			long internalTicks = this.InternalTicks;
			return (int)internalTicks ^ (int)(internalTicks >> 32);
		}

		/// <summary>Gets the hour component of the date represented by this instance.</summary>
		/// <returns>The hour component, expressed as a value between 0 and 23.</returns>
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x000125B4 File Offset: 0x000107B4
		public int Hour
		{
			get
			{
				return (int)(this.InternalTicks / 36000000000L % 24L);
			}
		}

		/// <summary>Gets a value that indicates whether the time represented by this instance is based on local time, Coordinated Universal Time (UTC), or neither.</summary>
		/// <returns>One of the enumeration values that indicates what the current time represents. The default is <see cref="F:System.DateTimeKind.Unspecified" />.</returns>
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x000125CC File Offset: 0x000107CC
		public DateTimeKind Kind
		{
			get
			{
				ulong internalKind = this.InternalKind;
				if (internalKind == 0UL)
				{
					return DateTimeKind.Unspecified;
				}
				if (internalKind != 4611686018427387904UL)
				{
					return DateTimeKind.Local;
				}
				return DateTimeKind.Utc;
			}
		}

		/// <summary>Gets the milliseconds component of the date represented by this instance.</summary>
		/// <returns>The milliseconds component, expressed as a value between 0 and 999.</returns>
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x000125F6 File Offset: 0x000107F6
		public int Millisecond
		{
			get
			{
				return (int)(this.InternalTicks / 10000L % 1000L);
			}
		}

		/// <summary>Gets the minute component of the date represented by this instance.</summary>
		/// <returns>The minute component, expressed as a value between 0 and 59.</returns>
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0001260D File Offset: 0x0001080D
		public int Minute
		{
			get
			{
				return (int)(this.InternalTicks / 600000000L % 60L);
			}
		}

		/// <summary>Gets the month component of the date represented by this instance.</summary>
		/// <returns>The month component, expressed as a value between 1 and 12.</returns>
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00012621 File Offset: 0x00010821
		public int Month
		{
			get
			{
				return this.GetDatePart(2);
			}
		}

		/// <summary>Gets a <see cref="T:System.DateTime" /> object that is set to the current date and time on this computer, expressed as the local time.</summary>
		/// <returns>An object whose value is the current local date and time.</returns>
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0001262C File Offset: 0x0001082C
		public static DateTime Now
		{
			get
			{
				DateTime utcNow = DateTime.UtcNow;
				bool isAmbiguousDst = false;
				long ticks = TimeZoneInfo.GetDateTimeNowUtcOffsetFromUtc(utcNow, out isAmbiguousDst).Ticks;
				long num = utcNow.Ticks + ticks;
				if (num > 3155378975999999999L)
				{
					return new DateTime(3155378975999999999L, DateTimeKind.Local);
				}
				if (num < 0L)
				{
					return new DateTime(0L, DateTimeKind.Local);
				}
				return new DateTime(num, DateTimeKind.Local, isAmbiguousDst);
			}
		}

		/// <summary>Gets the seconds component of the date represented by this instance.</summary>
		/// <returns>The seconds component, expressed as a value between 0 and 59.</returns>
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0001268F File Offset: 0x0001088F
		public int Second
		{
			get
			{
				return (int)(this.InternalTicks / 10000000L % 60L);
			}
		}

		/// <summary>Gets the number of ticks that represent the date and time of this instance.</summary>
		/// <returns>The number of ticks that represent the date and time of this instance. The value is between <see langword="DateTime.MinValue.Ticks" /> and <see langword="DateTime.MaxValue.Ticks" />.</returns>
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x000126A3 File Offset: 0x000108A3
		public long Ticks
		{
			get
			{
				return this.InternalTicks;
			}
		}

		/// <summary>Gets the time of day for this instance.</summary>
		/// <returns>A time interval that represents the fraction of the day that has elapsed since midnight.</returns>
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x000126AB File Offset: 0x000108AB
		public TimeSpan TimeOfDay
		{
			get
			{
				return new TimeSpan(this.InternalTicks % 864000000000L);
			}
		}

		/// <summary>Gets the year component of the date represented by this instance.</summary>
		/// <returns>The year, between 1 and 9999.</returns>
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x000126C2 File Offset: 0x000108C2
		public int Year
		{
			get
			{
				return this.GetDatePart(0);
			}
		}

		/// <summary>Returns an indication whether the specified year is a leap year.</summary>
		/// <param name="year">A 4-digit year. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="year" /> is a leap year; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="year" /> is less than 1 or greater than 9999.</exception>
		// Token: 0x060004A3 RID: 1187 RVA: 0x000126CB File Offset: 0x000108CB
		public static bool IsLeapYear(int year)
		{
			if (year < 1 || year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", "Year must be between 1 and 9999.");
			}
			return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
		}

		/// <summary>Converts the string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent.</summary>
		/// <param name="s">A string that contains a date and time to convert. </param>
		/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> does not contain a valid string representation of a date and time. </exception>
		// Token: 0x060004A4 RID: 1188 RVA: 0x00012702 File Offset: 0x00010902
		public static DateTime Parse(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return DateTimeParse.Parse(s, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None);
		}

		/// <summary>Converts the string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent by using culture-specific format information.</summary>
		/// <param name="s">A string that contains a date and time to convert. </param>
		/// <param name="provider">An object that supplies culture-specific format information about <paramref name="s" />. </param>
		/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" /> as specified by <paramref name="provider" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> does not contain a valid string representation of a date and time. </exception>
		// Token: 0x060004A5 RID: 1189 RVA: 0x0001271F File Offset: 0x0001091F
		public static DateTime Parse(string s, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return DateTimeParse.Parse(s, DateTimeFormatInfo.GetInstance(provider), DateTimeStyles.None);
		}

		/// <summary>Converts the string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent by using culture-specific format information and formatting style.</summary>
		/// <param name="s">A string that contains a date and time to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param>
		/// <param name="styles">A bitwise combination of the enumeration values that indicates the style elements that can be present in <paramref name="s" /> for the parse operation to succeed, and that defines how to interpret the parsed date in relation to the current time zone or the current date. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" />, as specified by <paramref name="provider" /> and <paramref name="styles" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> does not contain a valid string representation of a date and time. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="styles" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values. For example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />.</exception>
		// Token: 0x060004A6 RID: 1190 RVA: 0x0001273D File Offset: 0x0001093D
		public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
		{
			DateTimeFormatInfo.ValidateStyles(styles, "styles");
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return DateTimeParse.Parse(s, DateTimeFormatInfo.GetInstance(provider), styles);
		}

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly or an exception is thrown.</summary>
		/// <param name="s">A string containing a date and time to convert. </param>
		/// <param name="format">A format specifier that defines the required format of <paramref name="s" />. For more information, see the Remarks section. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param>
		/// <param name="style">A bitwise combination of the enumeration values that provides additional information about <paramref name="s" />, about style elements that may be present in <paramref name="s" />, or about the conversion from <paramref name="s" /> to a <see cref="T:System.DateTime" /> value. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" />, as specified by <paramref name="format" />, <paramref name="provider" />, and <paramref name="style" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> or <paramref name="format" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> or <paramref name="format" /> is an empty string. -or- 
		///         <paramref name="s" /> does not contain a date and time that corresponds to the pattern specified in <paramref name="format" />. -or-
		///         The hour component and the AM/PM designator in <paramref name="s" /> do not agree.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="style" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values. For example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />.</exception>
		// Token: 0x060004A7 RID: 1191 RVA: 0x00012766 File Offset: 0x00010966
		public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
		{
			DateTimeFormatInfo.ValidateStyles(style, "style");
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (format == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.format);
			}
			return DateTimeParse.ParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), style);
		}

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified array of formats, culture-specific format information, and style. The format of the string representation must match at least one of the specified formats exactly or an exception is thrown.</summary>
		/// <param name="s">A string that contains a date and time to convert. </param>
		/// <param name="formats">An array of allowable formats of <paramref name="s" />. For more information, see the Remarks section. </param>
		/// <param name="provider">An object that supplies culture-specific format information about <paramref name="s" />. </param>
		/// <param name="style">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" />, as specified by <paramref name="formats" />, <paramref name="provider" />, and <paramref name="style" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> or <paramref name="formats" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is an empty string. -or- an element of <paramref name="formats" /> is an empty string. -or- 
		///         <paramref name="s" /> does not contain a date and time that corresponds to any element of <paramref name="formats" />. -or-
		///         The hour component and the AM/PM designator in <paramref name="s" /> do not agree.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="style" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values. For example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />.</exception>
		// Token: 0x060004A8 RID: 1192 RVA: 0x0001279F File Offset: 0x0001099F
		public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style)
		{
			DateTimeFormatInfo.ValidateStyles(style, "style");
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return DateTimeParse.ParseExactMultiple(s, formats, DateTimeFormatInfo.GetInstance(provider), style);
		}

		/// <summary>Subtracts the specified date and time from this instance.</summary>
		/// <param name="value">The date and time value to subtract. </param>
		/// <returns>A time interval that is equal to the date and time represented by this instance minus the date and time represented by <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The result is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		// Token: 0x060004A9 RID: 1193 RVA: 0x000127C9 File Offset: 0x000109C9
		public TimeSpan Subtract(DateTime value)
		{
			return new TimeSpan(this.InternalTicks - value.InternalTicks);
		}

		/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to local time.</summary>
		/// <returns>An object whose <see cref="P:System.DateTime.Kind" /> property is <see cref="F:System.DateTimeKind.Local" />, and whose value is the local time equivalent to the value of the current <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MaxValue" /> if the converted value is too large to be represented by a <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MinValue" /> if the converted value is too small to be represented as a <see cref="T:System.DateTime" /> object.</returns>
		// Token: 0x060004AA RID: 1194 RVA: 0x000127DE File Offset: 0x000109DE
		public DateTime ToLocalTime()
		{
			return this.ToLocalTime(false);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000127E8 File Offset: 0x000109E8
		internal DateTime ToLocalTime(bool throwOnOverflow)
		{
			if (this.Kind == DateTimeKind.Local)
			{
				return this;
			}
			bool flag = false;
			bool isAmbiguousDst = false;
			long ticks = TimeZoneInfo.GetUtcOffsetFromUtc(this, TimeZoneInfo.Local, out flag, out isAmbiguousDst).Ticks;
			long num = this.Ticks + ticks;
			if (num > 3155378975999999999L)
			{
				if (throwOnOverflow)
				{
					throw new ArgumentException("Specified argument was out of the range of valid values.");
				}
				return new DateTime(3155378975999999999L, DateTimeKind.Local);
			}
			else
			{
				if (num >= 0L)
				{
					return new DateTime(num, DateTimeKind.Local, isAmbiguousDst);
				}
				if (throwOnOverflow)
				{
					throw new ArgumentException("Specified argument was out of the range of valid values.");
				}
				return new DateTime(0L, DateTimeKind.Local);
			}
		}

		/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent short date string representation.</summary>
		/// <returns>A string that contains the short date string representation of the current <see cref="T:System.DateTime" /> object.</returns>
		// Token: 0x060004AC RID: 1196 RVA: 0x0001287E File Offset: 0x00010A7E
		public string ToShortDateString()
		{
			return DateTimeFormat.Format(this, "d", null);
		}

		/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent string representation using the formatting conventions of the current culture.</summary>
		/// <returns>A string representation of the value of the current <see cref="T:System.DateTime" /> object.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by the current culture. </exception>
		// Token: 0x060004AD RID: 1197 RVA: 0x00012891 File Offset: 0x00010A91
		public override string ToString()
		{
			return DateTimeFormat.Format(this, null, null);
		}

		/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent string representation using the specified format and the formatting conventions of the current culture.</summary>
		/// <param name="format">A standard or custom date and time format string (see Remarks). </param>
		/// <returns>A string representation of value of the current <see cref="T:System.DateTime" /> object as specified by <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">The length of <paramref name="format" /> is 1, and it is not one of the format specifier characters defined for <see cref="T:System.Globalization.DateTimeFormatInfo" />.-or- 
		///         <paramref name="format" /> does not contain a valid custom format pattern. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by the current culture.</exception>
		// Token: 0x060004AE RID: 1198 RVA: 0x000128A0 File Offset: 0x00010AA0
		public string ToString(string format)
		{
			return DateTimeFormat.Format(this, format, null);
		}

		/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent string representation using the specified culture-specific format information.</summary>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A string representation of value of the current <see cref="T:System.DateTime" /> object as specified by <paramref name="provider" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by <paramref name="provider" />. </exception>
		// Token: 0x060004AF RID: 1199 RVA: 0x000128AF File Offset: 0x00010AAF
		public string ToString(IFormatProvider provider)
		{
			return DateTimeFormat.Format(this, null, provider);
		}

		/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent string representation using the specified format and culture-specific format information.</summary>
		/// <param name="format">A standard or custom date and time format string. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A string representation of value of the current <see cref="T:System.DateTime" /> object as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
		/// <exception cref="T:System.FormatException">The length of <paramref name="format" /> is 1, and it is not one of the format specifier characters defined for <see cref="T:System.Globalization.DateTimeFormatInfo" />.-or- 
		///         <paramref name="format" /> does not contain a valid custom format pattern. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by <paramref name="provider" />. </exception>
		// Token: 0x060004B0 RID: 1200 RVA: 0x000128BE File Offset: 0x00010ABE
		public string ToString(string format, IFormatProvider provider)
		{
			return DateTimeFormat.Format(this, format, provider);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000128CD File Offset: 0x00010ACD
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			return DateTimeFormat.TryFormat(this, destination, out charsWritten, format, provider);
		}

		/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to Coordinated Universal Time (UTC).</summary>
		/// <returns>An object whose <see cref="P:System.DateTime.Kind" /> property is <see cref="F:System.DateTimeKind.Utc" />, and whose value is the UTC equivalent to the value of the current <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MaxValue" /> if the converted value is too large to be represented by a <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MinValue" /> if the converted value is too small to be represented by a <see cref="T:System.DateTime" /> object.</returns>
		// Token: 0x060004B2 RID: 1202 RVA: 0x000128DF File Offset: 0x00010ADF
		public DateTime ToUniversalTime()
		{
			return TimeZoneInfo.ConvertTimeToUtc(this, TimeZoneInfoOptions.NoThrowOnInvalidTime);
		}

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified culture-specific format information and formatting style, and returns a value that indicates whether the conversion succeeded.</summary>
		/// <param name="s">A string containing a date and time to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />.</param>
		/// <param name="styles">A bitwise combination of enumeration values that defines how to interpret the parsed date in relation to the current time zone or the current date. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <param name="result">When this method returns, contains the <see cref="T:System.DateTime" /> value equivalent to the date and time contained in <paramref name="s" />, if the conversion succeeded, or <see cref="F:System.DateTime.MinValue" /> if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is <see langword="null" />, is an empty string (""), or does not contain a valid string representation of a date and time. This parameter is passed uninitialized. </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="s" /> parameter was converted successfully; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="styles" /> is not a valid <see cref="T:System.Globalization.DateTimeStyles" /> value.-or-
		///         <paramref name="styles" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values (for example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />).</exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="provider" /> is a neutral culture and cannot be used in a parsing operation.</exception>
		// Token: 0x060004B3 RID: 1203 RVA: 0x000128ED File Offset: 0x00010AED
		public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
		{
			DateTimeFormatInfo.ValidateStyles(styles, "styles");
			if (s == null)
			{
				result = default(DateTime);
				return false;
			}
			return DateTimeParse.TryParse(s, DateTimeFormatInfo.GetInstance(provider), styles, out result);
		}

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly. The method returns a value that indicates whether the conversion succeeded.</summary>
		/// <param name="s">A string containing a date and time to convert. </param>
		/// <param name="format">The required format of <paramref name="s" />. See the Remarks section for more information. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param>
		/// <param name="style">A bitwise combination of one or more enumeration values that indicate the permitted format of <paramref name="s" />. </param>
		/// <param name="result">When this method returns, contains the <see cref="T:System.DateTime" /> value equivalent to the date and time contained in <paramref name="s" />, if the conversion succeeded, or <see cref="F:System.DateTime.MinValue" /> if the conversion failed. The conversion fails if either the <paramref name="s" /> or <paramref name="format" /> parameter is <see langword="null" />, is an empty string, or does not contain a date and time that correspond to the pattern specified in <paramref name="format" />. This parameter is passed uninitialized. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="s" /> was converted successfully; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="styles" /> is not a valid <see cref="T:System.Globalization.DateTimeStyles" /> value.-or-
		///         <paramref name="styles" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values (for example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />).</exception>
		// Token: 0x060004B4 RID: 1204 RVA: 0x00012919 File Offset: 0x00010B19
		public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			DateTimeFormatInfo.ValidateStyles(style, "style");
			if (s == null || format == null)
			{
				result = default(DateTime);
				return false;
			}
			return DateTimeParse.TryParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), style, out result);
		}

		/// <summary>Adds a specified time interval to a specified date and time, yielding a new date and time.</summary>
		/// <param name="d">The date and time value to add. </param>
		/// <param name="t">The time interval to add. </param>
		/// <returns>An object that is the sum of the values of <paramref name="d" /> and <paramref name="t" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		// Token: 0x060004B5 RID: 1205 RVA: 0x00012950 File Offset: 0x00010B50
		public static DateTime operator +(DateTime d, TimeSpan t)
		{
			long internalTicks = d.InternalTicks;
			long ticks = t._ticks;
			if (ticks > 3155378975999999999L - internalTicks || ticks < 0L - internalTicks)
			{
				throw new ArgumentOutOfRangeException("t", "The added or subtracted value results in an un-representable DateTime.");
			}
			return new DateTime((ulong)(internalTicks + ticks | (long)d.InternalKind));
		}

		/// <summary>Subtracts a specified time interval from a specified date and time and returns a new date and time.</summary>
		/// <param name="d">The date and time value to subtract from. </param>
		/// <param name="t">The time interval to subtract. </param>
		/// <returns>An object whose value is the value of <paramref name="d" /> minus the value of <paramref name="t" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		// Token: 0x060004B6 RID: 1206 RVA: 0x000129A4 File Offset: 0x00010BA4
		public static DateTime operator -(DateTime d, TimeSpan t)
		{
			long internalTicks = d.InternalTicks;
			long ticks = t._ticks;
			if (internalTicks < ticks || internalTicks - 3155378975999999999L > ticks)
			{
				throw new ArgumentOutOfRangeException("t", "The added or subtracted value results in an un-representable DateTime.");
			}
			return new DateTime((ulong)(internalTicks - ticks | (long)d.InternalKind));
		}

		/// <summary>Subtracts a specified date and time from another specified date and time and returns a time interval.</summary>
		/// <param name="d1">The date and time value to subtract from (the minuend). </param>
		/// <param name="d2">The date and time value to subtract (the subtrahend). </param>
		/// <returns>The time interval between <paramref name="d1" /> and <paramref name="d2" />; that is, <paramref name="d1" /> minus <paramref name="d2" />.</returns>
		// Token: 0x060004B7 RID: 1207 RVA: 0x000129F2 File Offset: 0x00010BF2
		public static TimeSpan operator -(DateTime d1, DateTime d2)
		{
			return new TimeSpan(d1.InternalTicks - d2.InternalTicks);
		}

		/// <summary>Determines whether two specified instances of <see cref="T:System.DateTime" /> are equal.</summary>
		/// <param name="d1">The first object to compare. </param>
		/// <param name="d2">The second object to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="d1" /> and <paramref name="d2" /> represent the same date and time; otherwise, <see langword="false" />.</returns>
		// Token: 0x060004B8 RID: 1208 RVA: 0x00012A08 File Offset: 0x00010C08
		public static bool operator ==(DateTime d1, DateTime d2)
		{
			return d1.InternalTicks == d2.InternalTicks;
		}

		/// <summary>Determines whether two specified instances of <see cref="T:System.DateTime" /> are not equal.</summary>
		/// <param name="d1">The first object to compare. </param>
		/// <param name="d2">The second object to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="d1" /> and <paramref name="d2" /> do not represent the same date and time; otherwise, <see langword="false" />.</returns>
		// Token: 0x060004B9 RID: 1209 RVA: 0x00012A1A File Offset: 0x00010C1A
		public static bool operator !=(DateTime d1, DateTime d2)
		{
			return d1.InternalTicks != d2.InternalTicks;
		}

		/// <summary>Determines whether one specified <see cref="T:System.DateTime" /> is earlier than another specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="t1">The first object to compare. </param>
		/// <param name="t2">The second object to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="t1" /> is earlier than <paramref name="t2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060004BA RID: 1210 RVA: 0x00012A2F File Offset: 0x00010C2F
		public static bool operator <(DateTime t1, DateTime t2)
		{
			return t1.InternalTicks < t2.InternalTicks;
		}

		/// <summary>Determines whether one specified <see cref="T:System.DateTime" /> represents a date and time that is the same as or earlier than another specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="t1">The first object to compare.</param>
		/// <param name="t2">The second object to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="t1" /> is the same as or earlier than <paramref name="t2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060004BB RID: 1211 RVA: 0x00012A41 File Offset: 0x00010C41
		public static bool operator <=(DateTime t1, DateTime t2)
		{
			return t1.InternalTicks <= t2.InternalTicks;
		}

		/// <summary>Determines whether one specified <see cref="T:System.DateTime" /> is later than another specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="t1">The first object to compare. </param>
		/// <param name="t2">The second object to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="t1" /> is later than <paramref name="t2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060004BC RID: 1212 RVA: 0x00012A56 File Offset: 0x00010C56
		public static bool operator >(DateTime t1, DateTime t2)
		{
			return t1.InternalTicks > t2.InternalTicks;
		}

		/// <summary>Determines whether one specified <see cref="T:System.DateTime" /> represents a date and time that is the same as or later than another specified <see cref="T:System.DateTime" />.</summary>
		/// <param name="t1">The first object to compare. </param>
		/// <param name="t2">The second object to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="t1" /> is the same as or later than <paramref name="t2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060004BD RID: 1213 RVA: 0x00012A68 File Offset: 0x00010C68
		public static bool operator >=(DateTime t1, DateTime t2)
		{
			return t1.InternalTicks >= t2.InternalTicks;
		}

		/// <summary>Returns the <see cref="T:System.TypeCode" /> for value type <see cref="T:System.DateTime" />.</summary>
		/// <returns>The enumerated constant, <see cref="F:System.TypeCode.DateTime" />.</returns>
		// Token: 0x060004BE RID: 1214 RVA: 0x00012A7D File Offset: 0x00010C7D
		public TypeCode GetTypeCode()
		{
			return TypeCode.DateTime;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x060004BF RID: 1215 RVA: 0x00012A81 File Offset: 0x00010C81
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Boolean"));
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x060004C0 RID: 1216 RVA: 0x00012A9C File Offset: 0x00010C9C
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Char"));
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x060004C1 RID: 1217 RVA: 0x00012AB7 File Offset: 0x00010CB7
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "SByte"));
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x060004C2 RID: 1218 RVA: 0x00012AD2 File Offset: 0x00010CD2
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Byte"));
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x060004C3 RID: 1219 RVA: 0x00012AED File Offset: 0x00010CED
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Int16"));
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x060004C4 RID: 1220 RVA: 0x00012B08 File Offset: 0x00010D08
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "UInt16"));
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x060004C5 RID: 1221 RVA: 0x00012B23 File Offset: 0x00010D23
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Int32"));
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x060004C6 RID: 1222 RVA: 0x00012B3E File Offset: 0x00010D3E
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "UInt32"));
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x060004C7 RID: 1223 RVA: 0x00012B59 File Offset: 0x00010D59
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Int64"));
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x060004C8 RID: 1224 RVA: 0x00012B74 File Offset: 0x00010D74
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "UInt64"));
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases. </exception>
		// Token: 0x060004C9 RID: 1225 RVA: 0x00012B8F File Offset: 0x00010D8F
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Single"));
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x060004CA RID: 1226 RVA: 0x00012BAA File Offset: 0x00010DAA
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Double"));
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>The return value for this member is not used.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x060004CB RID: 1227 RVA: 0x00012BC5 File Offset: 0x00010DC5
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Decimal"));
		}

		/// <summary>Returns the current <see cref="T:System.DateTime" /> object.</summary>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>The current object.</returns>
		// Token: 0x060004CC RID: 1228 RVA: 0x00012BE0 File Offset: 0x00010DE0
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>Converts the current <see cref="T:System.DateTime" /> object to an object of a specified type.</summary>
		/// <param name="type">The desired type. </param>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <returns>An object of the type specified by the <paramref name="type" /> parameter, with a value equivalent to the current <see cref="T:System.DateTime" /> object.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DateTime" /> type.</exception>
		// Token: 0x060004CD RID: 1229 RVA: 0x00012BE8 File Offset: 0x00010DE8
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00012BFC File Offset: 0x00010DFC
		internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result)
		{
			result = DateTime.MinValue;
			if (year < 1 || year > 9999 || month < 1 || month > 12)
			{
				return false;
			}
			int[] array = DateTime.IsLeapYear(year) ? DateTime.s_daysToMonth366 : DateTime.s_daysToMonth365;
			if (day < 1 || day > array[month] - array[month - 1])
			{
				return false;
			}
			if (hour < 0 || hour >= 24 || minute < 0 || minute >= 60 || second < 0 || second >= 60)
			{
				return false;
			}
			if (millisecond < 0 || millisecond >= 1000)
			{
				return false;
			}
			long num = DateTime.DateToTicks(year, month, day) + DateTime.TimeToTicks(hour, minute, second);
			num += (long)millisecond * 10000L;
			if (num < 0L || num > 3155378975999999999L)
			{
				return false;
			}
			result = new DateTime(num, DateTimeKind.Unspecified);
			return true;
		}

		/// <summary>Gets a <see cref="T:System.DateTime" /> object that is set to the current date and time on this computer, expressed as the Coordinated Universal Time (UTC).</summary>
		/// <returns>An object whose value is the current UTC date and time.</returns>
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00012CC7 File Offset: 0x00010EC7
		public static DateTime UtcNow
		{
			get
			{
				return new DateTime((ulong)(DateTime.GetSystemTimeAsFileTime() + 504911232000000000L | 4611686018427387904L));
			}
		}

		// Token: 0x060004D0 RID: 1232
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern long GetSystemTimeAsFileTime();

		// Token: 0x060004D1 RID: 1233 RVA: 0x00012CE7 File Offset: 0x00010EE7
		internal long ToBinaryRaw()
		{
			return (long)this._dateData;
		}

		// Token: 0x040001E1 RID: 481
		private const long TicksPerMillisecond = 10000L;

		// Token: 0x040001E2 RID: 482
		private const long TicksPerSecond = 10000000L;

		// Token: 0x040001E3 RID: 483
		private const long TicksPerMinute = 600000000L;

		// Token: 0x040001E4 RID: 484
		private const long TicksPerHour = 36000000000L;

		// Token: 0x040001E5 RID: 485
		private const long TicksPerDay = 864000000000L;

		// Token: 0x040001E6 RID: 486
		private const int MillisPerSecond = 1000;

		// Token: 0x040001E7 RID: 487
		private const int MillisPerMinute = 60000;

		// Token: 0x040001E8 RID: 488
		private const int MillisPerHour = 3600000;

		// Token: 0x040001E9 RID: 489
		private const int MillisPerDay = 86400000;

		// Token: 0x040001EA RID: 490
		private const int DaysPerYear = 365;

		// Token: 0x040001EB RID: 491
		private const int DaysPer4Years = 1461;

		// Token: 0x040001EC RID: 492
		private const int DaysPer100Years = 36524;

		// Token: 0x040001ED RID: 493
		private const int DaysPer400Years = 146097;

		// Token: 0x040001EE RID: 494
		private const int DaysTo1601 = 584388;

		// Token: 0x040001EF RID: 495
		private const int DaysTo1899 = 693593;

		// Token: 0x040001F0 RID: 496
		internal const int DaysTo1970 = 719162;

		// Token: 0x040001F1 RID: 497
		private const int DaysTo10000 = 3652059;

		// Token: 0x040001F2 RID: 498
		internal const long MinTicks = 0L;

		// Token: 0x040001F3 RID: 499
		internal const long MaxTicks = 3155378975999999999L;

		// Token: 0x040001F4 RID: 500
		private const long MaxMillis = 315537897600000L;

		// Token: 0x040001F5 RID: 501
		internal const long UnixEpochTicks = 621355968000000000L;

		// Token: 0x040001F6 RID: 502
		private const long FileTimeOffset = 504911232000000000L;

		// Token: 0x040001F7 RID: 503
		private const long DoubleDateOffset = 599264352000000000L;

		// Token: 0x040001F8 RID: 504
		private const long OADateMinAsTicks = 31241376000000000L;

		// Token: 0x040001F9 RID: 505
		private const double OADateMinAsDouble = -657435.0;

		// Token: 0x040001FA RID: 506
		private const double OADateMaxAsDouble = 2958466.0;

		// Token: 0x040001FB RID: 507
		private const int DatePartYear = 0;

		// Token: 0x040001FC RID: 508
		private const int DatePartDayOfYear = 1;

		// Token: 0x040001FD RID: 509
		private const int DatePartMonth = 2;

		// Token: 0x040001FE RID: 510
		private const int DatePartDay = 3;

		// Token: 0x040001FF RID: 511
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

		// Token: 0x04000200 RID: 512
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

		/// <summary>Represents the smallest possible value of <see cref="T:System.DateTime" />. This field is read-only.</summary>
		// Token: 0x04000201 RID: 513
		public static readonly DateTime MinValue = new DateTime(0L, DateTimeKind.Unspecified);

		/// <summary>Represents the largest possible value of <see cref="T:System.DateTime" />. This field is read-only.</summary>
		// Token: 0x04000202 RID: 514
		public static readonly DateTime MaxValue = new DateTime(3155378975999999999L, DateTimeKind.Unspecified);

		// Token: 0x04000203 RID: 515
		public static readonly DateTime UnixEpoch = new DateTime(621355968000000000L, DateTimeKind.Utc);

		// Token: 0x04000204 RID: 516
		private const ulong TicksMask = 4611686018427387903UL;

		// Token: 0x04000205 RID: 517
		private const ulong FlagsMask = 13835058055282163712UL;

		// Token: 0x04000206 RID: 518
		private const ulong LocalMask = 9223372036854775808UL;

		// Token: 0x04000207 RID: 519
		private const long TicksCeiling = 4611686018427387904L;

		// Token: 0x04000208 RID: 520
		private const ulong KindUnspecified = 0UL;

		// Token: 0x04000209 RID: 521
		private const ulong KindUtc = 4611686018427387904UL;

		// Token: 0x0400020A RID: 522
		private const ulong KindLocal = 9223372036854775808UL;

		// Token: 0x0400020B RID: 523
		private const ulong KindLocalAmbiguousDst = 13835058055282163712UL;

		// Token: 0x0400020C RID: 524
		private const int KindShift = 62;

		// Token: 0x0400020D RID: 525
		private const string TicksField = "ticks";

		// Token: 0x0400020E RID: 526
		private const string DateDataField = "dateData";

		// Token: 0x0400020F RID: 527
		private readonly ulong _dateData;
	}
}
