using System;
using System.Globalization;
using System.Runtime.Versioning;

namespace System
{
	/// <summary>Represents a 16-bit unsigned integer.</summary>
	// Token: 0x02000112 RID: 274
	[CLSCompliant(false)]
	[Serializable]
	public readonly struct UInt16 : IComparable, IConvertible, IFormattable, IComparable<ushort>, IEquatable<ushort>, ISpanFormattable
	{
		/// <summary>Compares this instance to a specified object and returns an indication of their relative values.</summary>
		/// <param name="value">An object to compare, or <see langword="null" />. </param>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />.-or- 
		///             <paramref name="value" /> is <see langword="null" />. </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is not a <see cref="T:System.UInt16" />. </exception>
		// Token: 0x06000A5F RID: 2655 RVA: 0x0002B49E File Offset: 0x0002969E
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (value is ushort)
			{
				return (int)(this - (ushort)value);
			}
			throw new ArgumentException("Object must be of type UInt16.");
		}

		/// <summary>Compares this instance to a specified 16-bit unsigned integer and returns an indication of their relative values.</summary>
		/// <param name="value">An unsigned integer to compare. </param>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />. </returns>
		// Token: 0x06000A60 RID: 2656 RVA: 0x0000F78A File Offset: 0x0000D98A
		public int CompareTo(ushort value)
		{
			return (int)(this - value);
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare to this instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is an instance of <see cref="T:System.UInt16" /> and equals the value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000A61 RID: 2657 RVA: 0x0002B4C1 File Offset: 0x000296C1
		public override bool Equals(object obj)
		{
			return obj is ushort && this == (ushort)obj;
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.UInt16" /> value.</summary>
		/// <param name="obj">A 16-bit unsigned integer to compare to this instance.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> has the same value as this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000A62 RID: 2658 RVA: 0x0000F760 File Offset: 0x0000D960
		[NonVersionable]
		public bool Equals(ushort obj)
		{
			return this == obj;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000A63 RID: 2659 RVA: 0x0000F9B2 File Offset: 0x0000DBB2
		public override int GetHashCode()
		{
			return (int)this;
		}

		/// <summary>Converts the numeric value of this instance to its equivalent string representation.</summary>
		/// <returns>The string representation of the value of this instance, which consists of a sequence of digits ranging from 0 to 9, without a sign or leading zeros.</returns>
		// Token: 0x06000A64 RID: 2660 RVA: 0x0002B4D7 File Offset: 0x000296D7
		public override string ToString()
		{
			return Number.FormatUInt32((uint)this, null, null);
		}

		/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>The string representation of the value of this instance, which consists of a sequence of digits ranging from 0 to 9, without a sign or leading zeros.</returns>
		// Token: 0x06000A65 RID: 2661 RVA: 0x0002B4E7 File Offset: 0x000296E7
		public string ToString(IFormatProvider provider)
		{
			return Number.FormatUInt32((uint)this, null, provider);
		}

		/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary>
		/// <param name="format">A numeric format string.</param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>The string representation of the value of this instance, as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="format" /> is invalid. </exception>
		// Token: 0x06000A66 RID: 2662 RVA: 0x0002B4F7 File Offset: 0x000296F7
		public string ToString(string format, IFormatProvider provider)
		{
			return Number.FormatUInt32((uint)this, format, provider);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0002B507 File Offset: 0x00029707
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			return Number.TryFormatUInt32((uint)this, format, provider, destination, out charsWritten);
		}

		/// <summary>Converts the string representation of a number in a specified culture-specific format to its 16-bit unsigned integer equivalent.</summary>
		/// <param name="s">A string that represents the number to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param>
		/// <returns>A 16-bit unsigned integer equivalent to the number specified in <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not in the correct format.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
		// Token: 0x06000A68 RID: 2664 RVA: 0x0002B515 File Offset: 0x00029715
		[CLSCompliant(false)]
		public static ushort Parse(string s, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return ushort.Parse(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Converts the string representation of a number in a specified style and culture-specific format to its 16-bit unsigned integer equivalent.</summary>
		/// <param name="s">A string that represents the number to convert. The string is interpreted by using the style specified by the <paramref name="style" /> parameter.</param>
		/// <param name="style">A bitwise combination of enumeration values that indicate the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param>
		/// <returns>A 16-bit unsigned integer equivalent to the number specified in <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-
		///         <paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not in a format compliant with <paramref name="style" />. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number that is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />. -or-
		///         <paramref name="s" /> includes non-zero, fractional digits.</exception>
		// Token: 0x06000A69 RID: 2665 RVA: 0x0002B533 File Offset: 0x00029733
		[CLSCompliant(false)]
		public static ushort Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return ushort.Parse(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0002B558 File Offset: 0x00029758
		private static ushort Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info)
		{
			uint num = 0U;
			try
			{
				num = Number.ParseUInt32(s, style, info);
			}
			catch (OverflowException innerException)
			{
				throw new OverflowException("Value was either too large or too small for a UInt16.", innerException);
			}
			if (num > 65535U)
			{
				throw new OverflowException("Value was either too large or too small for a UInt16.");
			}
			return (ushort)num;
		}

		/// <summary>Tries to convert the string representation of a number in a specified style and culture-specific format to its 16-bit unsigned integer equivalent. A return value indicates whether the conversion succeeded or failed.</summary>
		/// <param name="s">A string that represents the number to convert. The string is interpreted by using the style specified by the <paramref name="style" /> parameter.</param>
		/// <param name="style">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param>
		/// <param name="result">When this method returns, contains the 16-bit unsigned integer value equivalent to the number contained in <paramref name="s" />, if the conversion succeeded, or zero if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is <see langword="null" /> or <see cref="F:System.String.Empty" />, is not in a format compliant with <paramref name="style" />, or represents a number less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />. This parameter is passed uninitialized; any value originally supplied in <paramref name="result" /> will be overwritten.  </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="s" /> was converted successfully; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-
		///         <paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception>
		// Token: 0x06000A6B RID: 2667 RVA: 0x0002B5A4 File Offset: 0x000297A4
		[CLSCompliant(false)]
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0;
				return false;
			}
			return ushort.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0002B5C8 File Offset: 0x000297C8
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out ushort result)
		{
			result = 0;
			uint num;
			if (!Number.TryParseUInt32(s, style, info, out num))
			{
				return false;
			}
			if (num > 65535U)
			{
				return false;
			}
			result = (ushort)num;
			return true;
		}

		/// <summary>Returns the <see cref="T:System.TypeCode" /> for value type <see cref="T:System.UInt16" />.</summary>
		/// <returns>The enumerated constant, <see cref="F:System.TypeCode.UInt16" />.</returns>
		// Token: 0x06000A6D RID: 2669 RVA: 0x0002B5F5 File Offset: 0x000297F5
		public TypeCode GetTypeCode()
		{
			return TypeCode.UInt16;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>
		///     <see langword="true" /> if the value of the current instance is not zero; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000A6E RID: 2670 RVA: 0x0002B5F8 File Offset: 0x000297F8
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Char" />.</returns>
		// Token: 0x06000A6F RID: 2671 RVA: 0x0002B601 File Offset: 0x00029801
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The current value of this instance, converted to an <see cref="T:System.SByte" />.</returns>
		// Token: 0x06000A70 RID: 2672 RVA: 0x0002B60A File Offset: 0x0002980A
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Byte" />.</returns>
		// Token: 0x06000A71 RID: 2673 RVA: 0x0002B613 File Offset: 0x00029813
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The current value of this instance, converted to an <see cref="T:System.Int16" />.</returns>
		// Token: 0x06000A72 RID: 2674 RVA: 0x0002B61C File Offset: 0x0002981C
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The current value of this instance, unchanged.</returns>
		// Token: 0x06000A73 RID: 2675 RVA: 0x0000F9B2 File Offset: 0x0000DBB2
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of this instance, converted to an <see cref="T:System.Int32" />.</returns>
		// Token: 0x06000A74 RID: 2676 RVA: 0x0002B625 File Offset: 0x00029825
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The current value of this instance, converted to a <see cref="T:System.UInt32" />.</returns>
		// Token: 0x06000A75 RID: 2677 RVA: 0x0002B62E File Offset: 0x0002982E
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The current value of this instance, converted to an <see cref="T:System.Int64" />.</returns>
		// Token: 0x06000A76 RID: 2678 RVA: 0x0002B637 File Offset: 0x00029837
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The current value of this instance, converted to a <see cref="T:System.UInt64" />.</returns>
		// Token: 0x06000A77 RID: 2679 RVA: 0x0002B640 File Offset: 0x00029840
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The current value pf this instance, converted to a <see cref="T:System.Single" />.</returns>
		// Token: 0x06000A78 RID: 2680 RVA: 0x0002B649 File Offset: 0x00029849
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The current value of this instance, converted to a <see cref="T:System.Double" />.</returns>
		// Token: 0x06000A79 RID: 2681 RVA: 0x0002B652 File Offset: 0x00029852
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The current value of this instance, converted to a <see cref="T:System.Decimal" />.</returns>
		// Token: 0x06000A7A RID: 2682 RVA: 0x0002B65B File Offset: 0x0002985B
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x06000A7B RID: 2683 RVA: 0x0002B664 File Offset: 0x00029864
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "UInt16", "DateTime"));
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />. </summary>
		/// <param name="type">The type to which to convert this <see cref="T:System.UInt16" /> value.</param>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> implementation that supplies information about the format of the returned value.</param>
		/// <returns>The current value of this instance, converted to <paramref name="type" />.</returns>
		// Token: 0x06000A7C RID: 2684 RVA: 0x0002B67F File Offset: 0x0002987F
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x040003A6 RID: 934
		private readonly ushort m_value;
	}
}
