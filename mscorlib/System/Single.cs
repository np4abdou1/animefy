using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System
{
	/// <summary>Represents a single-precision floating-point number.</summary>
	// Token: 0x020000F3 RID: 243
	[Serializable]
	public readonly struct Single : IComparable, IConvertible, IFormattable, IComparable<float>, IEquatable<float>, ISpanFormattable
	{
		// Token: 0x06000822 RID: 2082 RVA: 0x000242C9 File Offset: 0x000224C9
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsFinite(float f)
		{
			return (BitConverter.SingleToInt32Bits(f) & int.MaxValue) < 2139095040;
		}

		/// <summary>Returns a value indicating whether the specified number evaluates to negative or positive infinity.</summary>
		/// <param name="f">A single-precision floating-point number. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="f" /> evaluates to <see cref="F:System.Single.PositiveInfinity" /> or <see cref="F:System.Single.NegativeInfinity" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000823 RID: 2083 RVA: 0x000242DE File Offset: 0x000224DE
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInfinity(float f)
		{
			return (BitConverter.SingleToInt32Bits(f) & int.MaxValue) == 2139095040;
		}

		/// <summary>Returns a value that indicates whether the specified value is not a number (<see cref="F:System.Single.NaN" />).</summary>
		/// <param name="f">A single-precision floating-point number. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="f" /> evaluates to not a number (<see cref="F:System.Single.NaN" />); otherwise, <see langword="false" />.</returns>
		// Token: 0x06000824 RID: 2084 RVA: 0x000242F3 File Offset: 0x000224F3
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNaN(float f)
		{
			return (BitConverter.SingleToInt32Bits(f) & int.MaxValue) > 2139095040;
		}

		/// <summary>Returns a value indicating whether the specified number evaluates to negative infinity.</summary>
		/// <param name="f">A single-precision floating-point number. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="f" /> evaluates to <see cref="F:System.Single.NegativeInfinity" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000825 RID: 2085 RVA: 0x00024308 File Offset: 0x00022508
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNegativeInfinity(float f)
		{
			return f == float.NegativeInfinity;
		}

		/// <summary>Returns a value indicating whether the specified number evaluates to positive infinity.</summary>
		/// <param name="f">A single-precision floating-point number. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="f" /> evaluates to <see cref="F:System.Single.PositiveInfinity" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000826 RID: 2086 RVA: 0x00024312 File Offset: 0x00022512
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsPositiveInfinity(float f)
		{
			return f == float.PositiveInfinity;
		}

		/// <summary>Compares this instance to a specified object and returns an integer that indicates whether the value of this instance is less than, equal to, or greater than the value of the specified object.</summary>
		/// <param name="value">An object to compare, or <see langword="null" />. </param>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />.-or- This instance is not a number (<see cref="F:System.Single.NaN" />) and <paramref name="value" /> is a number. Zero This instance is equal to <paramref name="value" />.-or- This instance and value are both not a number (<see cref="F:System.Single.NaN" />), <see cref="F:System.Single.PositiveInfinity" />, or <see cref="F:System.Single.NegativeInfinity" />. Greater than zero This instance is greater than <paramref name="value" />.-or- This instance is a number and <paramref name="value" /> is not a number (<see cref="F:System.Single.NaN" />).-or- 
		///             <paramref name="value" /> is <see langword="null" />. </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is not a <see cref="T:System.Single" />. </exception>
		// Token: 0x06000827 RID: 2087 RVA: 0x0002431C File Offset: 0x0002251C
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is float))
			{
				throw new ArgumentException("Object must be of type Single.");
			}
			float num = (float)value;
			if (this < num)
			{
				return -1;
			}
			if (this > num)
			{
				return 1;
			}
			if (this == num)
			{
				return 0;
			}
			if (!float.IsNaN(this))
			{
				return 1;
			}
			if (!float.IsNaN(num))
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Compares this instance to a specified single-precision floating-point number and returns an integer that indicates whether the value of this instance is less than, equal to, or greater than the value of the specified single-precision floating-point number.</summary>
		/// <param name="value">A single-precision floating-point number to compare. </param>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />.-or- This instance is not a number (<see cref="F:System.Single.NaN" />) and <paramref name="value" /> is a number. Zero This instance is equal to <paramref name="value" />.-or- Both this instance and <paramref name="value" /> are not a number (<see cref="F:System.Single.NaN" />), <see cref="F:System.Single.PositiveInfinity" />, or <see cref="F:System.Single.NegativeInfinity" />. Greater than zero This instance is greater than <paramref name="value" />.-or- This instance is a number and <paramref name="value" /> is not a number (<see cref="F:System.Single.NaN" />). </returns>
		// Token: 0x06000828 RID: 2088 RVA: 0x00024373 File Offset: 0x00022573
		public int CompareTo(float value)
		{
			if (this < value)
			{
				return -1;
			}
			if (this > value)
			{
				return 1;
			}
			if (this == value)
			{
				return 0;
			}
			if (!float.IsNaN(this))
			{
				return 1;
			}
			if (!float.IsNaN(value))
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare with this instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is an instance of <see cref="T:System.Single" /> and equals the value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000829 RID: 2089 RVA: 0x000243A0 File Offset: 0x000225A0
		public override bool Equals(object obj)
		{
			if (!(obj is float))
			{
				return false;
			}
			float num = (float)obj;
			return num == this || (float.IsNaN(num) && float.IsNaN(this));
		}

		/// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Single" /> object represent the same value.</summary>
		/// <param name="obj">An object to compare with this instance.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600082A RID: 2090 RVA: 0x000243D6 File Offset: 0x000225D6
		public bool Equals(float obj)
		{
			return obj == this || (float.IsNaN(obj) && float.IsNaN(this));
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x0600082B RID: 2091 RVA: 0x000243F0 File Offset: 0x000225F0
		public override int GetHashCode()
		{
			int num = BitConverter.SingleToInt32Bits(this);
			if ((num - 1 & 2147483647) >= 2139095040)
			{
				num &= 2139095040;
			}
			return num;
		}

		/// <summary>Converts the numeric value of this instance to its equivalent string representation.</summary>
		/// <returns>The string representation of the value of this instance.</returns>
		// Token: 0x0600082C RID: 2092 RVA: 0x0002441E File Offset: 0x0002261E
		public override string ToString()
		{
			return Number.FormatSingle(this, null, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns>
		// Token: 0x0600082D RID: 2093 RVA: 0x0002442D File Offset: 0x0002262D
		public string ToString(IFormatProvider provider)
		{
			return Number.FormatSingle(this, null, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary>
		/// <param name="format">A numeric format string.</param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
		// Token: 0x0600082E RID: 2094 RVA: 0x0002443D File Offset: 0x0002263D
		public string ToString(string format, IFormatProvider provider)
		{
			return Number.FormatSingle(this, format, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0002444D File Offset: 0x0002264D
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			return Number.TryFormatSingle(this, format, NumberFormatInfo.GetInstance(provider), destination, out charsWritten);
		}

		/// <summary>Converts the string representation of a number in a specified culture-specific format to its single-precision floating-point number equivalent.</summary>
		/// <param name="s">A string that contains a number to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param>
		/// <returns>A single-precision floating-point number equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> does not represent a number in a valid format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />. </exception>
		// Token: 0x06000830 RID: 2096 RVA: 0x00024460 File Offset: 0x00022660
		public static float Parse(string s, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseSingle(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Converts the string representation of a number in a specified style and culture-specific format to its single-precision floating-point number equivalent.</summary>
		/// <param name="s">A string that contains a number to convert. </param>
		/// <param name="style">A bitwise combination of enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Float" /> combined with <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param>
		/// <returns>A single-precision floating-point number equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> does not represent a numeric value. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-
		///         <paramref name="style" /> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number that is less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />.</exception>
		// Token: 0x06000831 RID: 2097 RVA: 0x00024482 File Offset: 0x00022682
		public static float Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseSingle(s, style, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Converts the string representation of a number in a specified style and culture-specific format to its single-precision floating-point number equivalent. A return value indicates whether the conversion succeeded or failed.</summary>
		/// <param name="s">A string representing a number to convert. </param>
		/// <param name="style">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Float" /> combined with <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param>
		/// <param name="result">When this method returns, contains the single-precision floating-point number equivalent to the numeric value or symbol contained in <paramref name="s" />, if the conversion succeeded, or zero if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is <see langword="null" /> or <see cref="F:System.String.Empty" />, is not in a format compliant with <paramref name="style" />, represents a number less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />, or if <paramref name="style" /> is not a valid combination of <see cref="T:System.Globalization.NumberStyles" /> enumerated constants. This parameter is passed uninitialized; any value originally supplied in <paramref name="result" /> will be overwritten.  </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="s" /> was converted successfully; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-
		///         <paramref name="style" /> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value.</exception>
		// Token: 0x06000832 RID: 2098 RVA: 0x000244A6 File Offset: 0x000226A6
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			if (s == null)
			{
				result = 0f;
				return false;
			}
			return float.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x000244D0 File Offset: 0x000226D0
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out float result)
		{
			if (!Number.TryParseSingle(s, style, info, out result))
			{
				ReadOnlySpan<char> span = s.Trim();
				if (span.EqualsOrdinal(info.PositiveInfinitySymbol))
				{
					result = float.PositiveInfinity;
				}
				else if (span.EqualsOrdinal(info.NegativeInfinitySymbol))
				{
					result = float.NegativeInfinity;
				}
				else
				{
					if (!span.EqualsOrdinal(info.NaNSymbol))
					{
						return false;
					}
					result = float.NaN;
				}
			}
			return true;
		}

		/// <summary>Returns the <see cref="T:System.TypeCode" /> for value type <see cref="T:System.Single" />.</summary>
		/// <returns>The enumerated constant, <see cref="F:System.TypeCode.Single" />.</returns>
		// Token: 0x06000834 RID: 2100 RVA: 0x00024546 File Offset: 0x00022746
		public TypeCode GetTypeCode()
		{
			return TypeCode.Single;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>
		///     <see langword="true" /> if the value of the current instance is not zero; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000835 RID: 2101 RVA: 0x0002454A File Offset: 0x0002274A
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x06000836 RID: 2102 RVA: 0x00024553 File Offset: 0x00022753
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Single", "Char"));
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to an <see cref="T:System.SByte" />.</returns>
		// Token: 0x06000837 RID: 2103 RVA: 0x0002456E File Offset: 0x0002276E
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Byte" />.</returns>
		// Token: 0x06000838 RID: 2104 RVA: 0x00024577 File Offset: 0x00022777
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to an <see cref="T:System.Int16" />.</returns>
		// Token: 0x06000839 RID: 2105 RVA: 0x00024580 File Offset: 0x00022780
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt16" />.</returns>
		// Token: 0x0600083A RID: 2106 RVA: 0x00024589 File Offset: 0x00022789
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to an <see cref="T:System.Int32" />.</returns>
		// Token: 0x0600083B RID: 2107 RVA: 0x00024592 File Offset: 0x00022792
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt32" />.</returns>
		// Token: 0x0600083C RID: 2108 RVA: 0x0002459B File Offset: 0x0002279B
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to an <see cref="T:System.Int64" />.</returns>
		// Token: 0x0600083D RID: 2109 RVA: 0x000245A4 File Offset: 0x000227A4
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt64" />.</returns>
		// Token: 0x0600083E RID: 2110 RVA: 0x000245AD File Offset: 0x000227AD
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, unchanged.</returns>
		// Token: 0x0600083F RID: 2111 RVA: 0x000245B6 File Offset: 0x000227B6
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Double" />.</returns>
		// Token: 0x06000840 RID: 2112 RVA: 0x000245BA File Offset: 0x000227BA
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Decimal" />.</returns>
		// Token: 0x06000841 RID: 2113 RVA: 0x000245C3 File Offset: 0x000227C3
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x06000842 RID: 2114 RVA: 0x000245CC File Offset: 0x000227CC
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Single", "DateTime"));
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />. </summary>
		/// <param name="type">The type to which to convert this <see cref="T:System.Single" /> value.</param>
		/// <param name="provider">An object that supplies information about the format of the returned value.</param>
		/// <returns>The value of the current instance, converted to <paramref name="type" />.</returns>
		// Token: 0x06000843 RID: 2115 RVA: 0x000245E7 File Offset: 0x000227E7
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x0400035D RID: 861
		private readonly float m_value;
	}
}
