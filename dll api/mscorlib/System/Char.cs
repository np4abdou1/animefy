using System;
using System.Globalization;
using System.Runtime.Versioning;

namespace System
{
	/// <summary>Represents a character as a UTF-16 code unit.</summary>
	// Token: 0x0200008A RID: 138
	[Serializable]
	public readonly struct Char : IComparable, IComparable<char>, IEquatable<char>, IConvertible
	{
		// Token: 0x06000322 RID: 802 RVA: 0x0000F720 File Offset: 0x0000D920
		private static bool IsLatin1(char ch)
		{
			return ch <= 'ÿ';
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000F72D File Offset: 0x0000D92D
		private static bool IsAscii(char ch)
		{
			return ch <= '\u007f';
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000F737 File Offset: 0x0000D937
		private static UnicodeCategory GetLatin1UnicodeCategory(char ch)
		{
			return (UnicodeCategory)char.s_categoryForLatin1[(int)ch];
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000325 RID: 805 RVA: 0x0000F740 File Offset: 0x0000D940
		public override int GetHashCode()
		{
			return (int)(this | (int)this << 16);
		}

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare with this instance or <see langword="null" />. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is an instance of <see cref="T:System.Char" /> and equals the value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000326 RID: 806 RVA: 0x0000F74A File Offset: 0x0000D94A
		public override bool Equals(object obj)
		{
			return obj is char && this == (char)obj;
		}

		/// <summary>Returns a value that indicates whether this instance is equal to the specified <see cref="T:System.Char" /> object.</summary>
		/// <param name="obj">An object to compare to this instance. </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="obj" /> parameter equals the value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000327 RID: 807 RVA: 0x0000F760 File Offset: 0x0000D960
		[NonVersionable]
		public bool Equals(char obj)
		{
			return this == obj;
		}

		/// <summary>Compares this instance to a specified object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="T:System.Object" />.</summary>
		/// <param name="value">An object to compare this instance to, or <see langword="null" />. </param>
		/// <returns>A signed number indicating the position of this instance in the sort order in relation to the <paramref name="value" /> parameter.Return Value Description Less than zero This instance precedes <paramref name="value" />. Zero This instance has the same position in the sort order as <paramref name="value" />. Greater than zero This instance follows <paramref name="value" />.-or- 
		///             <paramref name="value" /> is <see langword="null" />. </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is not a <see cref="T:System.Char" /> object. </exception>
		// Token: 0x06000328 RID: 808 RVA: 0x0000F767 File Offset: 0x0000D967
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is char))
			{
				throw new ArgumentException("Object must be of type Char.");
			}
			return (int)(this - (char)value);
		}

		/// <summary>Compares this instance to a specified <see cref="T:System.Char" /> object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="T:System.Char" /> object.</summary>
		/// <param name="value">A <see cref="T:System.Char" /> object to compare. </param>
		/// <returns>A signed number indicating the position of this instance in the sort order in relation to the <paramref name="value" /> parameter.Return Value Description Less than zero This instance precedes <paramref name="value" />. Zero This instance has the same position in the sort order as <paramref name="value" />. Greater than zero This instance follows <paramref name="value" />. </returns>
		// Token: 0x06000329 RID: 809 RVA: 0x0000F78A File Offset: 0x0000D98A
		public int CompareTo(char value)
		{
			return (int)(this - value);
		}

		/// <summary>Converts the value of this instance to its equivalent string representation.</summary>
		/// <returns>The string representation of the value of this instance.</returns>
		// Token: 0x0600032A RID: 810 RVA: 0x0000F790 File Offset: 0x0000D990
		public override string ToString()
		{
			return char.ToString(this);
		}

		/// <summary>Converts the value of this instance to its equivalent string representation using the specified culture-specific format information.</summary>
		/// <param name="provider">(Reserved) An object that supplies culture-specific formatting information. </param>
		/// <returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns>
		// Token: 0x0600032B RID: 811 RVA: 0x0000F790 File Offset: 0x0000D990
		public string ToString(IFormatProvider provider)
		{
			return char.ToString(this);
		}

		/// <summary>Converts the specified Unicode character to its equivalent string representation.</summary>
		/// <param name="c">The Unicode character to convert. </param>
		/// <returns>The string representation of the value of <paramref name="c" />.</returns>
		// Token: 0x0600032C RID: 812 RVA: 0x0000F799 File Offset: 0x0000D999
		public static string ToString(char c)
		{
			return string.CreateFromChar(c);
		}

		/// <summary>Converts the value of the specified string to its equivalent Unicode character.</summary>
		/// <param name="s">A string that contains a single character, or <see langword="null" />. </param>
		/// <returns>A Unicode character equivalent to the sole character in <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">The length of <paramref name="s" /> is not 1. </exception>
		// Token: 0x0600032D RID: 813 RVA: 0x0000F7A1 File Offset: 0x0000D9A1
		public static char Parse(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (s.Length != 1)
			{
				throw new FormatException("String must be exactly one character long.");
			}
			return s[0];
		}

		/// <summary>Converts the value of the specified string to its equivalent Unicode character. A return code indicates whether the conversion succeeded or failed.</summary>
		/// <param name="s">A string that contains a single character, or <see langword="null" />. </param>
		/// <param name="result">When this method returns, contains a Unicode character equivalent to the sole character in <paramref name="s" />, if the conversion succeeded, or an undefined value if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is <see langword="null" /> or the length of <paramref name="s" /> is not 1. This parameter is passed uninitialized. </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="s" /> parameter was converted successfully; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600032E RID: 814 RVA: 0x0000F7CC File Offset: 0x0000D9CC
		public static bool TryParse(string s, out char result)
		{
			result = '\0';
			if (s == null)
			{
				return false;
			}
			if (s.Length != 1)
			{
				return false;
			}
			result = s[0];
			return true;
		}

		/// <summary>Indicates whether the specified Unicode character is categorized as a decimal digit.</summary>
		/// <param name="c">The Unicode character to evaluate. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="c" /> is a decimal digit; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600032F RID: 815 RVA: 0x0000F7EB File Offset: 0x0000D9EB
		public static bool IsDigit(char c)
		{
			if (char.IsLatin1(c))
			{
				return c >= '0' && c <= '9';
			}
			return CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.DecimalDigitNumber;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000F80E File Offset: 0x0000DA0E
		internal static bool CheckLetter(UnicodeCategory uc)
		{
			return uc <= UnicodeCategory.OtherLetter;
		}

		/// <summary>Indicates whether the specified Unicode character is categorized as a Unicode letter. </summary>
		/// <param name="c">The Unicode character to evaluate. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="c" /> is a letter; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000331 RID: 817 RVA: 0x0000F817 File Offset: 0x0000DA17
		public static bool IsLetter(char c)
		{
			if (!char.IsLatin1(c))
			{
				return char.CheckLetter(CharUnicodeInfo.GetUnicodeCategory(c));
			}
			if (char.IsAscii(c))
			{
				c |= ' ';
				return c >= 'a' && c <= 'z';
			}
			return char.CheckLetter(char.GetLatin1UnicodeCategory(c));
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000F857 File Offset: 0x0000DA57
		private static bool IsWhiteSpaceLatin1(char c)
		{
			return c == ' ' || c - '\t' <= '\u0004' || c == '\u00a0' || c == '\u0085';
		}

		/// <summary>Indicates whether the specified Unicode character is categorized as white space.</summary>
		/// <param name="c">The Unicode character to evaluate. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="c" /> is white space; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000333 RID: 819 RVA: 0x0000F877 File Offset: 0x0000DA77
		public static bool IsWhiteSpace(char c)
		{
			if (char.IsLatin1(c))
			{
				return char.IsWhiteSpaceLatin1(c);
			}
			return CharUnicodeInfo.IsWhiteSpace(c);
		}

		/// <summary>Indicates whether the specified Unicode character is categorized as an uppercase letter.</summary>
		/// <param name="c">The Unicode character to evaluate. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="c" /> is an uppercase letter; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000334 RID: 820 RVA: 0x0000F88E File Offset: 0x0000DA8E
		public static bool IsUpper(char c)
		{
			if (!char.IsLatin1(c))
			{
				return CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.UppercaseLetter;
			}
			if (char.IsAscii(c))
			{
				return c >= 'A' && c <= 'Z';
			}
			return char.GetLatin1UnicodeCategory(c) == UnicodeCategory.UppercaseLetter;
		}

		/// <summary>Indicates whether the specified Unicode character is categorized as a lowercase letter.</summary>
		/// <param name="c">The Unicode character to evaluate. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="c" /> is a lowercase letter; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000335 RID: 821 RVA: 0x0000F8C3 File Offset: 0x0000DAC3
		public static bool IsLower(char c)
		{
			if (!char.IsLatin1(c))
			{
				return CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.LowercaseLetter;
			}
			if (char.IsAscii(c))
			{
				return c >= 'a' && c <= 'z';
			}
			return char.GetLatin1UnicodeCategory(c) == UnicodeCategory.LowercaseLetter;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000F8F8 File Offset: 0x0000DAF8
		internal static bool CheckLetterOrDigit(UnicodeCategory uc)
		{
			return uc <= UnicodeCategory.OtherLetter || uc == UnicodeCategory.DecimalDigitNumber;
		}

		/// <summary>Indicates whether the specified Unicode character is categorized as a letter or a decimal digit.</summary>
		/// <param name="c">The Unicode character to evaluate. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="c" /> is a letter or a decimal digit; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000337 RID: 823 RVA: 0x0000F905 File Offset: 0x0000DB05
		public static bool IsLetterOrDigit(char c)
		{
			if (char.IsLatin1(c))
			{
				return char.CheckLetterOrDigit(char.GetLatin1UnicodeCategory(c));
			}
			return char.CheckLetterOrDigit(CharUnicodeInfo.GetUnicodeCategory(c));
		}

		/// <summary>Converts the value of a specified Unicode character to its uppercase equivalent using specified culture-specific formatting information.</summary>
		/// <param name="c">The Unicode character to convert. </param>
		/// <param name="culture">
		///       An object that supplies culture-specific casing rules. </param>
		/// <returns>The uppercase equivalent of <paramref name="c" />, modified according to <paramref name="culture" />, or the unchanged value of <paramref name="c" /> if <paramref name="c" /> is already uppercase, has no uppercase equivalent, or is not alphabetic.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="culture" /> is <see langword="null" />. </exception>
		// Token: 0x06000338 RID: 824 RVA: 0x0000F926 File Offset: 0x0000DB26
		public static char ToUpper(char c, CultureInfo culture)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			return culture.TextInfo.ToUpper(c);
		}

		/// <summary>Converts the value of a Unicode character to its uppercase equivalent using the casing rules of the invariant culture.</summary>
		/// <param name="c">The Unicode character to convert. </param>
		/// <returns>The uppercase equivalent of the <paramref name="c" /> parameter, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already uppercase or not alphabetic.</returns>
		// Token: 0x06000339 RID: 825 RVA: 0x0000F942 File Offset: 0x0000DB42
		public static char ToUpperInvariant(char c)
		{
			return CultureInfo.InvariantCulture.TextInfo.ToUpper(c);
		}

		/// <summary>Converts the value of a specified Unicode character to its lowercase equivalent using specified culture-specific formatting information.</summary>
		/// <param name="c">The Unicode character to convert. </param>
		/// <param name="culture">
		///       An object that supplies culture-specific casing rules. </param>
		/// <returns>The lowercase equivalent of <paramref name="c" />, modified according to <paramref name="culture" />, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already lowercase or not alphabetic.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="culture" /> is <see langword="null" />. </exception>
		// Token: 0x0600033A RID: 826 RVA: 0x0000F954 File Offset: 0x0000DB54
		public static char ToLower(char c, CultureInfo culture)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			return culture.TextInfo.ToLower(c);
		}

		/// <summary>Converts the value of a Unicode character to its lowercase equivalent.</summary>
		/// <param name="c">The Unicode character to convert. </param>
		/// <returns>The lowercase equivalent of <paramref name="c" />, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already lowercase or not alphabetic.</returns>
		// Token: 0x0600033B RID: 827 RVA: 0x0000F970 File Offset: 0x0000DB70
		public static char ToLower(char c)
		{
			return CultureInfo.CurrentCulture.TextInfo.ToLower(c);
		}

		/// <summary>Converts the value of a Unicode character to its lowercase equivalent using the casing rules of the invariant culture.</summary>
		/// <param name="c">The Unicode character to convert. </param>
		/// <returns>The lowercase equivalent of the <paramref name="c" /> parameter, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already lowercase or not alphabetic.</returns>
		// Token: 0x0600033C RID: 828 RVA: 0x0000F982 File Offset: 0x0000DB82
		public static char ToLowerInvariant(char c)
		{
			return CultureInfo.InvariantCulture.TextInfo.ToLower(c);
		}

		/// <summary>Returns the <see cref="T:System.TypeCode" /> for value type <see cref="T:System.Char" />.</summary>
		/// <returns>The enumerated constant, <see cref="F:System.TypeCode.Char" />.</returns>
		// Token: 0x0600033D RID: 829 RVA: 0x0000F994 File Offset: 0x0000DB94
		public TypeCode GetTypeCode()
		{
			return TypeCode.Char;
		}

		/// <summary>
		///     Note   This conversion is not supported. Attempting to do so throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported.</exception>
		// Token: 0x0600033E RID: 830 RVA: 0x0000F997 File Offset: 0x0000DB97
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Char", "Boolean"));
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current <see cref="T:System.Char" /> object unchanged.</returns>
		// Token: 0x0600033F RID: 831 RVA: 0x0000F9B2 File Offset: 0x0000DBB2
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return this;
		}

		/// <summary> For a description of this member, see <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
		// Token: 0x06000340 RID: 832 RVA: 0x0000F9B6 File Offset: 0x0000DBB6
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
		// Token: 0x06000341 RID: 833 RVA: 0x0000F9BF File Offset: 0x0000DBBF
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		/// <summary> For a description of this member, see <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
		// Token: 0x06000342 RID: 834 RVA: 0x0000F9C8 File Offset: 0x0000DBC8
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object. (Specify <see langword="null" /> because the <paramref name="provider" /> parameter is ignored.)</param>
		/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
		// Token: 0x06000343 RID: 835 RVA: 0x0000F9D1 File Offset: 0x0000DBD1
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
		// Token: 0x06000344 RID: 836 RVA: 0x0000F9DA File Offset: 0x0000DBDA
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object. (Specify <see langword="null" /> because the <paramref name="provider" /> parameter is ignored.)</param>
		/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
		// Token: 0x06000345 RID: 837 RVA: 0x0000F9E3 File Offset: 0x0000DBE3
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary> For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
		// Token: 0x06000346 RID: 838 RVA: 0x0000F9EC File Offset: 0x0000DBEC
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object. (Specify <see langword="null" /> because the <paramref name="provider" /> parameter is ignored.)</param>
		/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
		// Token: 0x06000347 RID: 839 RVA: 0x0000F9F5 File Offset: 0x0000DBF5
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>
		///     Note   This conversion is not supported. Attempting to do so throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported.</exception>
		// Token: 0x06000348 RID: 840 RVA: 0x0000F9FE File Offset: 0x0000DBFE
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Char", "Single"));
		}

		/// <summary>
		///     Note   This conversion is not supported. Attempting to do so throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported.</exception>
		// Token: 0x06000349 RID: 841 RVA: 0x0000FA19 File Offset: 0x0000DC19
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Char", "Double"));
		}

		/// <summary>
		///     Note   This conversion is not supported. Attempting to do so throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported.</exception>
		// Token: 0x0600034A RID: 842 RVA: 0x0000FA34 File Offset: 0x0000DC34
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Char", "Decimal"));
		}

		/// <summary>
		///     Note   This conversion is not supported. Attempting to do so throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported.</exception>
		// Token: 0x0600034B RID: 843 RVA: 0x0000FA4F File Offset: 0x0000DC4F
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Char", "DateTime"));
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> object. </param>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object. </param>
		/// <returns>An object of the specified type.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">The value of the current <see cref="T:System.Char" /> object cannot be converted to the type specified by the <paramref name="type" /> parameter. </exception>
		// Token: 0x0600034C RID: 844 RVA: 0x0000FA6A File Offset: 0x0000DC6A
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		/// <summary>Indicates whether the character at the specified position in a specified string is categorized as a letter or a decimal digit.</summary>
		/// <param name="s">A string. </param>
		/// <param name="index">The position of the character to evaluate in <paramref name="s" />. </param>
		/// <returns>
		///     <see langword="true" /> if the character at position <paramref name="index" /> in <paramref name="s" /> is a letter or a decimal digit; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception>
		// Token: 0x0600034D RID: 845 RVA: 0x0000FA7C File Offset: 0x0000DC7C
		public static bool IsLetterOrDigit(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			char ch = s[index];
			if (char.IsLatin1(ch))
			{
				return char.CheckLetterOrDigit(char.GetLatin1UnicodeCategory(ch));
			}
			return char.CheckLetterOrDigit(CharUnicodeInfo.GetUnicodeCategory(s, index));
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000FAD3 File Offset: 0x0000DCD3
		internal static bool CheckNumber(UnicodeCategory uc)
		{
			return uc - UnicodeCategory.DecimalDigitNumber <= 2;
		}

		/// <summary>Indicates whether the specified Unicode character is categorized as a number.</summary>
		/// <param name="c">The Unicode character to evaluate. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="c" /> is a number; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600034F RID: 847 RVA: 0x0000FADE File Offset: 0x0000DCDE
		public static bool IsNumber(char c)
		{
			if (!char.IsLatin1(c))
			{
				return char.CheckNumber(CharUnicodeInfo.GetUnicodeCategory(c));
			}
			if (char.IsAscii(c))
			{
				return c >= '0' && c <= '9';
			}
			return char.CheckNumber(char.GetLatin1UnicodeCategory(c));
		}

		/// <summary>Indicates whether the character at the specified position in a specified string is categorized as a number.</summary>
		/// <param name="s">A string. </param>
		/// <param name="index">The position of the character to evaluate in <paramref name="s" />. </param>
		/// <returns>
		///     <see langword="true" /> if the character at position <paramref name="index" /> in <paramref name="s" /> is a number; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception>
		// Token: 0x06000350 RID: 848 RVA: 0x0000FB18 File Offset: 0x0000DD18
		public static bool IsNumber(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			char c = s[index];
			if (!char.IsLatin1(c))
			{
				return char.CheckNumber(CharUnicodeInfo.GetUnicodeCategory(s, index));
			}
			if (char.IsAscii(c))
			{
				return c >= '0' && c <= '9';
			}
			return char.CheckNumber(char.GetLatin1UnicodeCategory(c));
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000FB87 File Offset: 0x0000DD87
		internal static bool CheckSeparator(UnicodeCategory uc)
		{
			return uc - UnicodeCategory.SpaceSeparator <= 2;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000FB93 File Offset: 0x0000DD93
		private static bool IsSeparatorLatin1(char c)
		{
			return c == ' ' || c == '\u00a0';
		}

		/// <summary>Indicates whether the specified Unicode character is categorized as a separator character.</summary>
		/// <param name="c">The Unicode character to evaluate. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="c" /> is a separator character; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000353 RID: 851 RVA: 0x0000FBA4 File Offset: 0x0000DDA4
		public static bool IsSeparator(char c)
		{
			if (char.IsLatin1(c))
			{
				return char.IsSeparatorLatin1(c);
			}
			return char.CheckSeparator(CharUnicodeInfo.GetUnicodeCategory(c));
		}

		/// <summary>Indicates whether the specified character has a surrogate code unit.</summary>
		/// <param name="c">The Unicode character to evaluate. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="c" /> is either a high surrogate or a low surrogate; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000354 RID: 852 RVA: 0x0000FBC0 File Offset: 0x0000DDC0
		public static bool IsSurrogate(char c)
		{
			return c >= '\ud800' && c <= '\udfff';
		}

		/// <summary>Indicates whether the character at the specified position in a specified string has a surrogate code unit.</summary>
		/// <param name="s">A string. </param>
		/// <param name="index">The position of the character to evaluate in <paramref name="s" />. </param>
		/// <returns>
		///     <see langword="true" /> if the character at position <paramref name="index" /> in <paramref name="s" /> is a either a high surrogate or a low surrogate; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception>
		// Token: 0x06000355 RID: 853 RVA: 0x0000FBD7 File Offset: 0x0000DDD7
		public static bool IsSurrogate(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return char.IsSurrogate(s[index]);
		}

		/// <summary>Indicates whether the character at the specified position in a specified string is categorized as white space.</summary>
		/// <param name="s">A string. </param>
		/// <param name="index">The position of the character to evaluate in <paramref name="s" />. </param>
		/// <returns>
		///     <see langword="true" /> if the character at position <paramref name="index" /> in <paramref name="s" /> is white space; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception>
		// Token: 0x06000356 RID: 854 RVA: 0x0000FC08 File Offset: 0x0000DE08
		public static bool IsWhiteSpace(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (char.IsLatin1(s[index]))
			{
				return char.IsWhiteSpaceLatin1(s[index]);
			}
			return CharUnicodeInfo.IsWhiteSpace(s, index);
		}

		/// <summary>Categorizes a specified Unicode character into a group identified by one of the <see cref="T:System.Globalization.UnicodeCategory" /> values.</summary>
		/// <param name="c">The Unicode character to categorize. </param>
		/// <returns>A <see cref="T:System.Globalization.UnicodeCategory" /> value that identifies the group that contains <paramref name="c" />.</returns>
		// Token: 0x06000357 RID: 855 RVA: 0x0000FC59 File Offset: 0x0000DE59
		public static UnicodeCategory GetUnicodeCategory(char c)
		{
			if (char.IsLatin1(c))
			{
				return char.GetLatin1UnicodeCategory(c);
			}
			return CharUnicodeInfo.GetUnicodeCategory((int)c);
		}

		/// <summary>Categorizes the character at the specified position in a specified string into a group identified by one of the <see cref="T:System.Globalization.UnicodeCategory" /> values.</summary>
		/// <param name="s">A <see cref="T:System.String" />. </param>
		/// <param name="index">The character position in <paramref name="s" />. </param>
		/// <returns>A <see cref="T:System.Globalization.UnicodeCategory" /> enumerated constant that identifies the group that contains the character at position <paramref name="index" /> in <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />. </exception>
		// Token: 0x06000358 RID: 856 RVA: 0x0000FC70 File Offset: 0x0000DE70
		public static UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (char.IsLatin1(s[index]))
			{
				return char.GetLatin1UnicodeCategory(s[index]);
			}
			return CharUnicodeInfo.InternalGetUnicodeCategory(s, index);
		}

		/// <summary>Indicates whether the specified <see cref="T:System.Char" /> object is a high surrogate.</summary>
		/// <param name="c">The Unicode character to evaluate. </param>
		/// <returns>
		///     <see langword="true" /> if the numeric value of the <paramref name="c" /> parameter ranges from U+D800 through U+DBFF; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000359 RID: 857 RVA: 0x0000FCC1 File Offset: 0x0000DEC1
		public static bool IsHighSurrogate(char c)
		{
			return c >= '\ud800' && c <= '\udbff';
		}

		/// <summary>Indicates whether the <see cref="T:System.Char" /> object at the specified position in a string is a high surrogate.</summary>
		/// <param name="s">A string. </param>
		/// <param name="index">The position of the character to evaluate in <paramref name="s" />. </param>
		/// <returns>
		///     <see langword="true" /> if the numeric value of the specified character in the <paramref name="s" /> parameter ranges from U+D800 through U+DBFF; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is not a position within <paramref name="s" />. </exception>
		// Token: 0x0600035A RID: 858 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		public static bool IsHighSurrogate(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index < 0 || index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return char.IsHighSurrogate(s[index]);
		}

		/// <summary>Indicates whether the specified <see cref="T:System.Char" /> object is a low surrogate.</summary>
		/// <param name="c">The character to evaluate. </param>
		/// <returns>
		///     <see langword="true" /> if the numeric value of the <paramref name="c" /> parameter ranges from U+DC00 through U+DFFF; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600035B RID: 859 RVA: 0x0000FD0C File Offset: 0x0000DF0C
		public static bool IsLowSurrogate(char c)
		{
			return c >= '\udc00' && c <= '\udfff';
		}

		/// <summary>Indicates whether the two specified <see cref="T:System.Char" /> objects form a surrogate pair.</summary>
		/// <param name="highSurrogate">The character to evaluate as the high surrogate of a surrogate pair. </param>
		/// <param name="lowSurrogate">The character to evaluate as the low surrogate of a surrogate pair. </param>
		/// <returns>
		///     <see langword="true" /> if the numeric value of the <paramref name="highSurrogate" /> parameter ranges from U+D800 through U+DBFF, and the numeric value of the <paramref name="lowSurrogate" /> parameter ranges from U+DC00 through U+DFFF; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600035C RID: 860 RVA: 0x0000FD23 File Offset: 0x0000DF23
		public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate)
		{
			return highSurrogate >= '\ud800' && highSurrogate <= '\udbff' && lowSurrogate >= '\udc00' && lowSurrogate <= '\udfff';
		}

		/// <summary>Converts the value of a UTF-16 encoded surrogate pair into a Unicode code point.</summary>
		/// <param name="highSurrogate">A high surrogate code unit (that is, a code unit ranging from U+D800 through U+DBFF). </param>
		/// <param name="lowSurrogate">A low surrogate code unit (that is, a code unit ranging from U+DC00 through U+DFFF). </param>
		/// <returns>The 21-bit Unicode code point represented by the <paramref name="highSurrogate" /> and <paramref name="lowSurrogate" /> parameters.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="highSurrogate" /> is not in the range U+D800 through U+DBFF, or <paramref name="lowSurrogate" /> is not in the range U+DC00 through U+DFFF. </exception>
		// Token: 0x0600035D RID: 861 RVA: 0x0000FD4C File Offset: 0x0000DF4C
		public static int ConvertToUtf32(char highSurrogate, char lowSurrogate)
		{
			if (!char.IsHighSurrogate(highSurrogate))
			{
				throw new ArgumentOutOfRangeException("highSurrogate", "A valid high surrogate character is between 0xd800 and 0xdbff, inclusive.");
			}
			if (!char.IsLowSurrogate(lowSurrogate))
			{
				throw new ArgumentOutOfRangeException("lowSurrogate", "A valid low surrogate character is between 0xdc00 and 0xdfff, inclusive.");
			}
			return (int)((highSurrogate - '\ud800') * 'Ѐ' + (lowSurrogate - '\udc00')) + 65536;
		}

		// Token: 0x040001D3 RID: 467
		private readonly char m_value;

		// Token: 0x040001D4 RID: 468
		private static readonly byte[] s_categoryForLatin1 = new byte[]
		{
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			11,
			24,
			24,
			24,
			26,
			24,
			24,
			24,
			20,
			21,
			24,
			25,
			24,
			19,
			24,
			24,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			24,
			24,
			25,
			25,
			25,
			24,
			24,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			20,
			24,
			21,
			27,
			18,
			27,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			20,
			25,
			21,
			25,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			11,
			24,
			26,
			26,
			26,
			26,
			28,
			28,
			27,
			28,
			1,
			22,
			25,
			19,
			28,
			27,
			28,
			25,
			10,
			10,
			27,
			1,
			28,
			24,
			27,
			10,
			1,
			23,
			10,
			10,
			10,
			24,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			25,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			25,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1
		};
	}
}
