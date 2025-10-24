using System;
using System.Globalization;

namespace System
{
	/// <summary>Represents a time interval.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x02000105 RID: 261
	[Serializable]
	public readonly struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable, ISpanFormattable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.TimeSpan" /> structure to the specified number of ticks.</summary>
		/// <param name="ticks">A time period expressed in 100-nanosecond units. </param>
		// Token: 0x06000953 RID: 2387 RVA: 0x0002974B File Offset: 0x0002794B
		public TimeSpan(long ticks)
		{
			this._ticks = ticks;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.TimeSpan" /> structure to a specified number of hours, minutes, and seconds.</summary>
		/// <param name="hours">Number of hours. </param>
		/// <param name="minutes">Number of minutes. </param>
		/// <param name="seconds">Number of seconds. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The parameters specify a <see cref="T:System.TimeSpan" /> value less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
		// Token: 0x06000954 RID: 2388 RVA: 0x00029754 File Offset: 0x00027954
		public TimeSpan(int hours, int minutes, int seconds)
		{
			this._ticks = TimeSpan.TimeToTicks(hours, minutes, seconds);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.TimeSpan" /> structure to a specified number of days, hours, minutes, seconds, and milliseconds.</summary>
		/// <param name="days">Number of days. </param>
		/// <param name="hours">Number of hours. </param>
		/// <param name="minutes">Number of minutes. </param>
		/// <param name="seconds">Number of seconds. </param>
		/// <param name="milliseconds">Number of milliseconds. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The parameters specify a <see cref="T:System.TimeSpan" /> value less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
		// Token: 0x06000955 RID: 2389 RVA: 0x00029764 File Offset: 0x00027964
		public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
		{
			long num = ((long)days * 3600L * 24L + (long)hours * 3600L + (long)minutes * 60L + (long)seconds) * 1000L + (long)milliseconds;
			if (num > 922337203685477L || num < -922337203685477L)
			{
				throw new ArgumentOutOfRangeException(null, "TimeSpan overflowed because the duration is too long.");
			}
			this._ticks = num * 10000L;
		}

		/// <summary>Gets the number of ticks that represent the value of the current <see cref="T:System.TimeSpan" /> structure.</summary>
		/// <returns>The number of ticks contained in this instance.</returns>
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x000297D1 File Offset: 0x000279D1
		public long Ticks
		{
			get
			{
				return this._ticks;
			}
		}

		/// <summary>Gets the days component of the time interval represented by the current <see cref="T:System.TimeSpan" /> structure.</summary>
		/// <returns>The day component of this instance. The return value can be positive or negative.</returns>
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x000297D9 File Offset: 0x000279D9
		public int Days
		{
			get
			{
				return (int)(this._ticks / 864000000000L);
			}
		}

		/// <summary>Gets the hours component of the time interval represented by the current <see cref="T:System.TimeSpan" /> structure.</summary>
		/// <returns>The hour component of the current <see cref="T:System.TimeSpan" /> structure. The return value ranges from -23 through 23.</returns>
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x000297EC File Offset: 0x000279EC
		public int Hours
		{
			get
			{
				return (int)(this._ticks / 36000000000L % 24L);
			}
		}

		/// <summary>Gets the minutes component of the time interval represented by the current <see cref="T:System.TimeSpan" /> structure.</summary>
		/// <returns>The minute component of the current <see cref="T:System.TimeSpan" /> structure. The return value ranges from -59 through 59.</returns>
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x00029803 File Offset: 0x00027A03
		public int Minutes
		{
			get
			{
				return (int)(this._ticks / 600000000L % 60L);
			}
		}

		/// <summary>Gets the seconds component of the time interval represented by the current <see cref="T:System.TimeSpan" /> structure.</summary>
		/// <returns>The second component of the current <see cref="T:System.TimeSpan" /> structure. The return value ranges from -59 through 59.</returns>
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00029817 File Offset: 0x00027A17
		public int Seconds
		{
			get
			{
				return (int)(this._ticks / 10000000L % 60L);
			}
		}

		/// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional hours.</summary>
		/// <returns>The total number of hours represented by this instance.</returns>
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0002982B File Offset: 0x00027A2B
		public double TotalHours
		{
			get
			{
				return (double)this._ticks * 2.7777777777777777E-11;
			}
		}

		/// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional milliseconds.</summary>
		/// <returns>The total number of milliseconds represented by this instance.</returns>
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x00029840 File Offset: 0x00027A40
		public double TotalMilliseconds
		{
			get
			{
				double num = (double)this._ticks * 0.0001;
				if (num > 922337203685477.0)
				{
					return 922337203685477.0;
				}
				if (num < -922337203685477.0)
				{
					return -922337203685477.0;
				}
				return num;
			}
		}

		/// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional minutes.</summary>
		/// <returns>The total number of minutes represented by this instance.</returns>
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0002988C File Offset: 0x00027A8C
		public double TotalMinutes
		{
			get
			{
				return (double)this._ticks * 1.6666666666666667E-09;
			}
		}

		/// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional seconds.</summary>
		/// <returns>The total number of seconds represented by this instance.</returns>
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x0002989F File Offset: 0x00027A9F
		public double TotalSeconds
		{
			get
			{
				return (double)this._ticks * 1E-07;
			}
		}

		/// <summary>
		///     Returns a new <see cref="T:System.TimeSpan" /> object whose value is the sum of the specified <see cref="T:System.TimeSpan" /> object and this instance.</summary>
		/// <param name="ts">The time interval to add.</param>
		/// <returns>A new object that represents the value of this instance plus the value of <paramref name="ts" />.</returns>
		/// <exception cref="T:System.OverflowException">The resulting <see cref="T:System.TimeSpan" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
		// Token: 0x0600095F RID: 2399 RVA: 0x000298B4 File Offset: 0x00027AB4
		public TimeSpan Add(TimeSpan ts)
		{
			long num = this._ticks + ts._ticks;
			if (this._ticks >> 63 == ts._ticks >> 63 && this._ticks >> 63 != num >> 63)
			{
				throw new OverflowException("TimeSpan overflowed because the duration is too long.");
			}
			return new TimeSpan(num);
		}

		/// <summary>Compares two <see cref="T:System.TimeSpan" /> values and returns an integer that indicates whether the first value is shorter than, equal to, or longer than the second value.</summary>
		/// <param name="t1">The first time interval to compare. </param>
		/// <param name="t2">The second time interval to compare. </param>
		/// <returns>One of the following values.Value Description -1 
		///             <paramref name="t1" /> is shorter than <paramref name="t2" />. 0 
		///             <paramref name="t1" /> is equal to <paramref name="t2" />. 1 
		///             <paramref name="t1" /> is longer than <paramref name="t2" />. </returns>
		// Token: 0x06000960 RID: 2400 RVA: 0x00029903 File Offset: 0x00027B03
		public static int Compare(TimeSpan t1, TimeSpan t2)
		{
			if (t1._ticks > t2._ticks)
			{
				return 1;
			}
			if (t1._ticks < t2._ticks)
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Compares this instance to a specified object and returns an integer that indicates whether this instance is shorter than, equal to, or longer than the specified object.</summary>
		/// <param name="value">An object to compare, or <see langword="null" />. </param>
		/// <returns>One of the following values.Value Description -1 This instance is shorter than <paramref name="value" />. 0 This instance is equal to <paramref name="value" />. 1 This instance is longer than <paramref name="value" />.-or- 
		///             <paramref name="value" /> is <see langword="null" />. </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is not a <see cref="T:System.TimeSpan" />. </exception>
		// Token: 0x06000961 RID: 2401 RVA: 0x00029928 File Offset: 0x00027B28
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is TimeSpan))
			{
				throw new ArgumentException("Object must be of type TimeSpan.");
			}
			long ticks = ((TimeSpan)value)._ticks;
			if (this._ticks > ticks)
			{
				return 1;
			}
			if (this._ticks < ticks)
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Compares this instance to a specified <see cref="T:System.TimeSpan" /> object and returns an integer that indicates whether this instance is shorter than, equal to, or longer than the <see cref="T:System.TimeSpan" /> object.</summary>
		/// <param name="value">An object to compare to this instance.</param>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Value Description A negative integer This instance is shorter than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. A positive integer This instance is longer than <paramref name="value" />. </returns>
		// Token: 0x06000962 RID: 2402 RVA: 0x00029970 File Offset: 0x00027B70
		public int CompareTo(TimeSpan value)
		{
			long ticks = value._ticks;
			if (this._ticks > ticks)
			{
				return 1;
			}
			if (this._ticks < ticks)
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of days, where the specification is accurate to the nearest millisecond.</summary>
		/// <param name="value">A number of days, accurate to the nearest millisecond. </param>
		/// <returns>An object that represents <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. -or-
		///         <paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-
		///         <paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception>
		// Token: 0x06000963 RID: 2403 RVA: 0x0002999B File Offset: 0x00027B9B
		public static TimeSpan FromDays(double value)
		{
			return TimeSpan.Interval(value, 86400000);
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <param name="value">An object to compare with this instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is a <see cref="T:System.TimeSpan" /> object that represents the same time interval as the current <see cref="T:System.TimeSpan" /> structure; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000964 RID: 2404 RVA: 0x000299A8 File Offset: 0x00027BA8
		public override bool Equals(object value)
		{
			return value is TimeSpan && this._ticks == ((TimeSpan)value)._ticks;
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.TimeSpan" /> object.</summary>
		/// <param name="obj">An object to compare with this instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> represents the same time interval as this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000965 RID: 2405 RVA: 0x000299C7 File Offset: 0x00027BC7
		public bool Equals(TimeSpan obj)
		{
			return this._ticks == obj._ticks;
		}

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000966 RID: 2406 RVA: 0x000299D7 File Offset: 0x00027BD7
		public override int GetHashCode()
		{
			return (int)this._ticks ^ (int)(this._ticks >> 32);
		}

		/// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of hours, where the specification is accurate to the nearest millisecond.</summary>
		/// <param name="value">A number of hours accurate to the nearest millisecond. </param>
		/// <returns>An object that represents <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. -or-
		///         <paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-
		///         <paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception>
		// Token: 0x06000967 RID: 2407 RVA: 0x000299EB File Offset: 0x00027BEB
		public static TimeSpan FromHours(double value)
		{
			return TimeSpan.Interval(value, 3600000);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000299F8 File Offset: 0x00027BF8
		private static TimeSpan Interval(double value, int scale)
		{
			if (double.IsNaN(value))
			{
				throw new ArgumentException("TimeSpan does not accept floating point Not-a-Number values.");
			}
			double num = value * (double)scale + ((value >= 0.0) ? 0.5 : -0.5);
			if (num > 922337203685477.0 || num < -922337203685477.0)
			{
				throw new OverflowException("TimeSpan overflowed because the duration is too long.");
			}
			return new TimeSpan((long)num * 10000L);
		}

		/// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of milliseconds.</summary>
		/// <param name="value">A number of milliseconds. </param>
		/// <returns>An object that represents <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or-
		///         <paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-
		///         <paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception>
		// Token: 0x06000969 RID: 2409 RVA: 0x00029A6F File Offset: 0x00027C6F
		public static TimeSpan FromMilliseconds(double value)
		{
			return TimeSpan.Interval(value, 1);
		}

		/// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of minutes, where the specification is accurate to the nearest millisecond.</summary>
		/// <param name="value">A number of minutes, accurate to the nearest millisecond. </param>
		/// <returns>An object that represents <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or-
		///         <paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-
		///         <paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception>
		// Token: 0x0600096A RID: 2410 RVA: 0x00029A78 File Offset: 0x00027C78
		public static TimeSpan FromMinutes(double value)
		{
			return TimeSpan.Interval(value, 60000);
		}

		/// <summary>Returns a new <see cref="T:System.TimeSpan" /> object whose value is the negated value of this instance.</summary>
		/// <returns>A new object with the same numeric value as this instance, but with the opposite sign.</returns>
		/// <exception cref="T:System.OverflowException">The negated value of this instance cannot be represented by a <see cref="T:System.TimeSpan" />; that is, the value of this instance is <see cref="F:System.TimeSpan.MinValue" />. </exception>
		// Token: 0x0600096B RID: 2411 RVA: 0x00029A85 File Offset: 0x00027C85
		public TimeSpan Negate()
		{
			if (this.Ticks == TimeSpan.MinValue.Ticks)
			{
				throw new OverflowException("Negating the minimum value of a twos complement number is invalid.");
			}
			return new TimeSpan(-this._ticks);
		}

		/// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of seconds, where the specification is accurate to the nearest millisecond.</summary>
		/// <param name="value">A number of seconds, accurate to the nearest millisecond. </param>
		/// <returns>An object that represents <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or-
		///         <paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-
		///         <paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception>
		// Token: 0x0600096C RID: 2412 RVA: 0x00029AB0 File Offset: 0x00027CB0
		public static TimeSpan FromSeconds(double value)
		{
			return TimeSpan.Interval(value, 1000);
		}

		/// <summary>
		///     Returns a new <see cref="T:System.TimeSpan" /> object whose value is the difference between the specified <see cref="T:System.TimeSpan" /> object and this instance.</summary>
		/// <param name="ts">The time interval to be subtracted. </param>
		/// <returns>A new time interval whose value is the result of the value of this instance minus the value of <paramref name="ts" />.</returns>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
		// Token: 0x0600096D RID: 2413 RVA: 0x00029AC0 File Offset: 0x00027CC0
		public TimeSpan Subtract(TimeSpan ts)
		{
			long num = this._ticks - ts._ticks;
			if (this._ticks >> 63 != ts._ticks >> 63 && this._ticks >> 63 != num >> 63)
			{
				throw new OverflowException("TimeSpan overflowed because the duration is too long.");
			}
			return new TimeSpan(num);
		}

		/// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified time, where the specification is in units of ticks.</summary>
		/// <param name="value">A number of ticks that represent a time. </param>
		/// <returns>An object that represents <paramref name="value" />.</returns>
		// Token: 0x0600096E RID: 2414 RVA: 0x00029B0F File Offset: 0x00027D0F
		public static TimeSpan FromTicks(long value)
		{
			return new TimeSpan(value);
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00029B18 File Offset: 0x00027D18
		internal static long TimeToTicks(int hour, int minute, int second)
		{
			long num = (long)hour * 3600L + (long)minute * 60L + (long)second;
			if (num > 922337203685L || num < -922337203685L)
			{
				throw new ArgumentOutOfRangeException(null, "TimeSpan overflowed because the duration is too long.");
			}
			return num * 10000000L;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00029B65 File Offset: 0x00027D65
		private static void ValidateStyles(TimeSpanStyles style, string parameterName)
		{
			if (style != TimeSpanStyles.None && style != TimeSpanStyles.AssumeNegative)
			{
				throw new ArgumentException("An undefined TimeSpanStyles value is being used.", parameterName);
			}
		}

		/// <summary>Converts the string representation of a time interval to its <see cref="T:System.TimeSpan" /> equivalent. </summary>
		/// <param name="s">A string that specifies the time interval to convert. </param>
		/// <returns>A time interval that corresponds to <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> has an invalid format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number that is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or- At least one of the days, hours, minutes, or seconds components is outside its valid range. </exception>
		// Token: 0x06000971 RID: 2417 RVA: 0x00029B7A File Offset: 0x00027D7A
		public static TimeSpan Parse(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			return TimeSpanParse.Parse(s, null);
		}

		/// <summary>Converts the string representation of a time interval to its <see cref="T:System.TimeSpan" /> equivalent by using the specified culture-specific format information.</summary>
		/// <param name="input">A string that specifies the time interval to convert.</param>
		/// <param name="formatProvider">An object that supplies culture-specific formatting information.</param>
		/// <returns>A time interval that corresponds to <paramref name="input" />, as specified by <paramref name="formatProvider" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="input" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="input" /> has an invalid format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="input" /> represents a number that is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or- At least one of the days, hours, minutes, or seconds components in <paramref name="input" /> is outside its valid range. </exception>
		// Token: 0x06000972 RID: 2418 RVA: 0x00029B92 File Offset: 0x00027D92
		public static TimeSpan Parse(string input, IFormatProvider formatProvider)
		{
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			return TimeSpanParse.Parse(input, formatProvider);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00029BAA File Offset: 0x00027DAA
		public static TimeSpan Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider = null)
		{
			return TimeSpanParse.Parse(input, formatProvider);
		}

		/// <summary>Converts the string representation of a time interval to its <see cref="T:System.TimeSpan" /> equivalent by using the specified format, culture-specific format information, and styles, and returns a value that indicates whether the conversion succeeded. The format of the string representation must match the specified format exactly. </summary>
		/// <param name="input">A string that specifies the time interval to convert.</param>
		/// <param name="format">A standard or custom format string that defines the required format of <paramref name="input" />.</param>
		/// <param name="formatProvider">An object that provides culture-specific formatting information.</param>
		/// <param name="styles">One or more enumeration values that indicate the style of <paramref name="input" />.</param>
		/// <param name="result">When this method returns, contains an object that represents the time interval specified by <paramref name="input" />, or <see cref="F:System.TimeSpan.Zero" /> if the conversion failed. This parameter is passed uninitialized.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="input" /> was converted successfully; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000974 RID: 2420 RVA: 0x00029BB3 File Offset: 0x00027DB3
		public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
		{
			TimeSpan.ValidateStyles(styles, "styles");
			if (input == null || format == null)
			{
				result = default(TimeSpan);
				return false;
			}
			return TimeSpanParse.TryParseExact(input, format, formatProvider, styles, out result);
		}

		/// <summary>Converts the value of the current <see cref="T:System.TimeSpan" /> object to its equivalent string representation.</summary>
		/// <returns>The string representation of the current <see cref="T:System.TimeSpan" /> value. </returns>
		// Token: 0x06000975 RID: 2421 RVA: 0x00029BE5 File Offset: 0x00027DE5
		public override string ToString()
		{
			return TimeSpanFormat.Format(this, null, null);
		}

		/// <summary>Converts the value of the current <see cref="T:System.TimeSpan" /> object to its equivalent string representation by using the specified format and culture-specific formatting information.</summary>
		/// <param name="format">A standard or custom <see cref="T:System.TimeSpan" /> format string.</param>
		/// <param name="formatProvider">An object that supplies culture-specific formatting information.</param>
		/// <returns>The string representation of the current <see cref="T:System.TimeSpan" /> value, as specified by <paramref name="format" /> and <paramref name="formatProvider" />.</returns>
		/// <exception cref="T:System.FormatException">The <paramref name="format" /> parameter is not recognized or is not supported.</exception>
		// Token: 0x06000976 RID: 2422 RVA: 0x00029BF4 File Offset: 0x00027DF4
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return TimeSpanFormat.Format(this, format, formatProvider);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00029C03 File Offset: 0x00027E03
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider formatProvider = null)
		{
			return TimeSpanFormat.TryFormat(this, destination, out charsWritten, format, formatProvider);
		}

		/// <summary>Subtracts a specified <see cref="T:System.TimeSpan" /> from another specified <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="t1">The minuend. </param>
		/// <param name="t2">The subtrahend. </param>
		/// <returns>An object whose value is the result of the value of <paramref name="t1" /> minus the value of <paramref name="t2" />.</returns>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
		// Token: 0x06000978 RID: 2424 RVA: 0x00029C15 File Offset: 0x00027E15
		public static TimeSpan operator -(TimeSpan t1, TimeSpan t2)
		{
			return t1.Subtract(t2);
		}

		/// <summary>Adds two specified <see cref="T:System.TimeSpan" /> instances.</summary>
		/// <param name="t1">The first time interval to add. </param>
		/// <param name="t2">The second time interval to add.</param>
		/// <returns>An object whose value is the sum of the values of <paramref name="t1" /> and <paramref name="t2" />.</returns>
		/// <exception cref="T:System.OverflowException">The resulting <see cref="T:System.TimeSpan" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
		// Token: 0x06000979 RID: 2425 RVA: 0x00029C1F File Offset: 0x00027E1F
		public static TimeSpan operator +(TimeSpan t1, TimeSpan t2)
		{
			return t1.Add(t2);
		}

		/// <summary>Indicates whether two <see cref="T:System.TimeSpan" /> instances are equal.</summary>
		/// <param name="t1">The first time interval to compare. </param>
		/// <param name="t2">The second time interval to compare. </param>
		/// <returns>
		///     <see langword="true" /> if the values of <paramref name="t1" /> and <paramref name="t2" /> are equal; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600097A RID: 2426 RVA: 0x000299C7 File Offset: 0x00027BC7
		public static bool operator ==(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks == t2._ticks;
		}

		/// <summary>Indicates whether two <see cref="T:System.TimeSpan" /> instances are not equal.</summary>
		/// <param name="t1">The first time interval to compare.</param>
		/// <param name="t2">The second time interval to compare.</param>
		/// <returns>
		///     <see langword="true" /> if the values of <paramref name="t1" /> and <paramref name="t2" /> are not equal; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600097B RID: 2427 RVA: 0x00029C29 File Offset: 0x00027E29
		public static bool operator !=(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks != t2._ticks;
		}

		/// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is less than another specified <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="t1">The first time interval to compare.</param>
		/// <param name="t2">The second time interval to compare. </param>
		/// <returns>
		///     <see langword="true" /> if the value of <paramref name="t1" /> is less than the value of <paramref name="t2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600097C RID: 2428 RVA: 0x00029C3C File Offset: 0x00027E3C
		public static bool operator <(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks < t2._ticks;
		}

		/// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is less than or equal to another specified <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="t1">The first time interval to compare. </param>
		/// <param name="t2">The second time interval to compare. </param>
		/// <returns>
		///     <see langword="true" /> if the value of <paramref name="t1" /> is less than or equal to the value of <paramref name="t2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600097D RID: 2429 RVA: 0x00029C4C File Offset: 0x00027E4C
		public static bool operator <=(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks <= t2._ticks;
		}

		/// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is greater than another specified <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="t1">The first time interval to compare. </param>
		/// <param name="t2">The second time interval to compare. </param>
		/// <returns>
		///     <see langword="true" /> if the value of <paramref name="t1" /> is greater than the value of <paramref name="t2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600097E RID: 2430 RVA: 0x00029C5F File Offset: 0x00027E5F
		public static bool operator >(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks > t2._ticks;
		}

		/// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is greater than or equal to another specified <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="t1">The first time interval to compare.</param>
		/// <param name="t2">The second time interval to compare.</param>
		/// <returns>
		///     <see langword="true" /> if the value of <paramref name="t1" /> is greater than or equal to the value of <paramref name="t2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600097F RID: 2431 RVA: 0x00029C6F File Offset: 0x00027E6F
		public static bool operator >=(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks >= t2._ticks;
		}

		/// <summary>Represents the zero <see cref="T:System.TimeSpan" /> value. This field is read-only.</summary>
		// Token: 0x0400037C RID: 892
		public static readonly TimeSpan Zero = new TimeSpan(0L);

		/// <summary>Represents the maximum <see cref="T:System.TimeSpan" /> value. This field is read-only.</summary>
		// Token: 0x0400037D RID: 893
		public static readonly TimeSpan MaxValue = new TimeSpan(long.MaxValue);

		/// <summary>Represents the minimum <see cref="T:System.TimeSpan" /> value. This field is read-only.</summary>
		// Token: 0x0400037E RID: 894
		public static readonly TimeSpan MinValue = new TimeSpan(long.MinValue);

		// Token: 0x0400037F RID: 895
		internal readonly long _ticks;
	}
}
