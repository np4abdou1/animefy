using System;
using System.Globalization;
using System.Runtime.Versioning;

namespace System
{
	/// <summary>Represents an 8-bit unsigned integer.</summary>
	// Token: 0x02000088 RID: 136
	[Serializable]
	public readonly struct Byte : IComparable, IConvertible, IFormattable, IComparable<byte>, IEquatable<byte>, ISpanFormattable
	{
		/// <summary>Compares this instance to a specified object and returns an indication of their relative values.</summary>
		/// <param name="value">An object to compare, or <see langword="null" />. </param>
		/// <returns>A signed integer that indicates the relative order of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />.-or- 
		///             <paramref name="value" /> is <see langword="null" />. </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is not a <see cref="T:System.Byte" />. </exception>
		// Token: 0x06000302 RID: 770 RVA: 0x0000F500 File Offset: 0x0000D700
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is byte))
			{
				throw new ArgumentException("Object must be of type Byte.");
			}
			return (int)(this - (byte)value);
		}

		/// <summary>Compares this instance to a specified 8-bit unsigned integer and returns an indication of their relative values.</summary>
		/// <param name="value">An 8-bit unsigned integer to compare. </param>
		/// <returns>A signed integer that indicates the relative order of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />. </returns>
		// Token: 0x06000303 RID: 771 RVA: 0x0000F523 File Offset: 0x0000D723
		public int CompareTo(byte value)
		{
			return (int)(this - value);
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare with this instance, or <see langword="null" />. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is an instance of <see cref="T:System.Byte" /> and equals the value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000304 RID: 772 RVA: 0x0000F529 File Offset: 0x0000D729
		public override bool Equals(object obj)
		{
			return obj is byte && this == (byte)obj;
		}

		/// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Byte" /> object represent the same value.</summary>
		/// <param name="obj">An object to compare to this instance.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000305 RID: 773 RVA: 0x0000F2BF File Offset: 0x0000D4BF
		[NonVersionable]
		public bool Equals(byte obj)
		{
			return this == obj;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Byte" />.</returns>
		// Token: 0x06000306 RID: 774 RVA: 0x0000F43D File Offset: 0x0000D63D
		public override int GetHashCode()
		{
			return (int)this;
		}

		/// <summary>Converts the string representation of a number in a specified culture-specific format to its <see cref="T:System.Byte" /> equivalent.</summary>
		/// <param name="s">A string that contains a number to convert. The string is interpreted using the <see cref="F:System.Globalization.NumberStyles.Integer" /> style. </param>
		/// <param name="provider">An object that supplies culture-specific parsing information about <paramref name="s" />. If <paramref name="provider" /> is <see langword="null" />, the thread current culture is used. </param>
		/// <returns>A byte value that is equivalent to the number contained in <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not of the correct format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
		// Token: 0x06000307 RID: 775 RVA: 0x0000F53F File Offset: 0x0000D73F
		public static byte Parse(string s, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return byte.Parse(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Converts the string representation of a number in a specified style and culture-specific format to its <see cref="T:System.Byte" /> equivalent.</summary>
		/// <param name="s">A string that contains a number to convert. The string is interpreted using the style specified by <paramref name="style" />. </param>
		/// <param name="style">A bitwise combination of enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">An object that supplies culture-specific information about the format of <paramref name="s" />. If <paramref name="provider" /> is <see langword="null" />, the thread current culture is used. </param>
		/// <returns>A byte value that is equivalent to the number contained in <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not of the correct format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. -or-
		///         <paramref name="s" /> includes non-zero, fractional digits.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-
		///         <paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception>
		// Token: 0x06000308 RID: 776 RVA: 0x0000F55D File Offset: 0x0000D75D
		public static byte Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return byte.Parse(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000F584 File Offset: 0x0000D784
		private static byte Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info)
		{
			int num = 0;
			try
			{
				num = Number.ParseInt32(s, style, info);
			}
			catch (OverflowException innerException)
			{
				throw new OverflowException("Value was either too large or too small for an unsigned byte.", innerException);
			}
			if (num < 0 || num > 255)
			{
				throw new OverflowException("Value was either too large or too small for an unsigned byte.");
			}
			return (byte)num;
		}

		/// <summary>Converts the string representation of a number in a specified style and culture-specific format to its <see cref="T:System.Byte" /> equivalent. A return value indicates whether the conversion succeeded or failed.</summary>
		/// <param name="s">A string containing a number to convert. The string is interpreted using the style specified by <paramref name="style" />. </param>
		/// <param name="style">A bitwise combination of enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. If <paramref name="provider" /> is <see langword="null" />, the thread current culture is used. </param>
		/// <param name="result">When this method returns, contains the 8-bit unsigned integer value equivalent to the number contained in <paramref name="s" /> if the conversion succeeded, or zero if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is <see langword="null" />  or <see cref="F:System.String.Empty" />, is not of the correct format, or represents a number less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. This parameter is passed uninitialized; any value originally supplied in <paramref name="result" /> will be overwritten. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="s" /> was converted successfully; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-
		///         <paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception>
		// Token: 0x0600030A RID: 778 RVA: 0x0000F5D4 File Offset: 0x0000D7D4
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0;
				return false;
			}
			return byte.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000F5F8 File Offset: 0x0000D7F8
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out byte result)
		{
			result = 0;
			int num;
			if (!Number.TryParseInt32(s, style, info, out num))
			{
				return false;
			}
			if (num < 0 || num > 255)
			{
				return false;
			}
			result = (byte)num;
			return true;
		}

		/// <summary>Converts the value of the current <see cref="T:System.Byte" /> object to its equivalent string representation.</summary>
		/// <returns>The string representation of the value of this object, which consists of a sequence of digits that range from 0 to 9 with no leading zeroes.</returns>
		// Token: 0x0600030C RID: 780 RVA: 0x0000F629 File Offset: 0x0000D829
		public override string ToString()
		{
			return Number.FormatInt32((int)this, null, null);
		}

		/// <summary>Converts the value of the current <see cref="T:System.Byte" /> object to its equivalent string representation using the specified format.</summary>
		/// <param name="format">A numeric format string.</param>
		/// <returns>The string representation of the current <see cref="T:System.Byte" /> object, formatted as specified by the <paramref name="format" /> parameter.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="format" /> includes an unsupported specifier. Supported format specifiers are listed in the Remarks section.</exception>
		// Token: 0x0600030D RID: 781 RVA: 0x0000F639 File Offset: 0x0000D839
		public string ToString(string format)
		{
			return Number.FormatInt32((int)this, format, null);
		}

		/// <summary>Converts the numeric value of the current <see cref="T:System.Byte" /> object to its equivalent string representation using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		/// <returns>The string representation of the value of this object in the format specified by the <paramref name="provider" /> parameter.</returns>
		// Token: 0x0600030E RID: 782 RVA: 0x0000F649 File Offset: 0x0000D849
		public string ToString(IFormatProvider provider)
		{
			return Number.FormatInt32((int)this, null, provider);
		}

		/// <summary>Converts the value of the current <see cref="T:System.Byte" /> object to its equivalent string representation using the specified format and culture-specific formatting information.</summary>
		/// <param name="format">A standard or custom numeric format string.</param>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		/// <returns>The string representation of the current <see cref="T:System.Byte" /> object, formatted as specified by the <paramref name="format" /> and <paramref name="provider" /> parameters.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="format" /> includes an unsupported specifier. Supported format specifiers are listed in the Remarks section.</exception>
		// Token: 0x0600030F RID: 783 RVA: 0x0000F659 File Offset: 0x0000D859
		public string ToString(string format, IFormatProvider provider)
		{
			return Number.FormatInt32((int)this, format, provider);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000F669 File Offset: 0x0000D869
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			return Number.TryFormatInt32((int)this, format, provider, destination, out charsWritten);
		}

		/// <summary>Returns the <see cref="T:System.TypeCode" /> for value type <see cref="T:System.Byte" />.</summary>
		/// <returns>The enumerated constant, <see cref="F:System.TypeCode.Byte" />.</returns>
		// Token: 0x06000311 RID: 785 RVA: 0x0000F677 File Offset: 0x0000D877
		public TypeCode GetTypeCode()
		{
			return TypeCode.Byte;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>
		///     <see langword="true" /> if the value of the current instance is not zero; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000312 RID: 786 RVA: 0x0000F67A File Offset: 0x0000D87A
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Char" />.</returns>
		// Token: 0x06000313 RID: 787 RVA: 0x0000F683 File Offset: 0x0000D883
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to an <see cref="T:System.SByte" />.</returns>
		// Token: 0x06000314 RID: 788 RVA: 0x0000F68C File Offset: 0x0000D88C
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, unchanged.</returns>
		// Token: 0x06000315 RID: 789 RVA: 0x0000F43D File Offset: 0x0000D63D
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to an <see cref="T:System.Int16" />.</returns>
		// Token: 0x06000316 RID: 790 RVA: 0x0000F695 File Offset: 0x0000D895
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt16" />.</returns>
		// Token: 0x06000317 RID: 791 RVA: 0x0000F69E File Offset: 0x0000D89E
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to an <see cref="T:System.Int32" />.</returns>
		// Token: 0x06000318 RID: 792 RVA: 0x0000F6A7 File Offset: 0x0000D8A7
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt32" />.</returns>
		// Token: 0x06000319 RID: 793 RVA: 0x0000F6B0 File Offset: 0x0000D8B0
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to an <see cref="T:System.Int64" />.</returns>
		// Token: 0x0600031A RID: 794 RVA: 0x0000F6B9 File Offset: 0x0000D8B9
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt64" />.</returns>
		// Token: 0x0600031B RID: 795 RVA: 0x0000F6C2 File Offset: 0x0000D8C2
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Single" />.</returns>
		// Token: 0x0600031C RID: 796 RVA: 0x0000F6CB File Offset: 0x0000D8CB
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Double" />.</returns>
		// Token: 0x0600031D RID: 797 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Decimal" />.</returns>
		// Token: 0x0600031E RID: 798 RVA: 0x0000F6DD File Offset: 0x0000D8DD
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x0600031F RID: 799 RVA: 0x0000F6E6 File Offset: 0x0000D8E6
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Byte", "DateTime"));
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />. </summary>
		/// <param name="type">The type to which to convert this <see cref="T:System.Byte" /> value. </param>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> implementation that supplies information about the format of the returned value.</param>
		/// <returns>The value of the current instance, converted to <paramref name="type" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The requested type conversion is not supported. </exception>
		// Token: 0x06000320 RID: 800 RVA: 0x0000F701 File Offset: 0x0000D901
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x040001D1 RID: 465
		private readonly byte m_value;
	}
}
