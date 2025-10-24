using System;
using System.Runtime.Versioning;

namespace System
{
	/// <summary>Represents a Boolean (<see langword="true" /> or <see langword="false" />) value.</summary>
	// Token: 0x02000087 RID: 135
	[Serializable]
	public readonly struct Boolean : IComparable, IConvertible, IComparable<bool>, IEquatable<bool>
	{
		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Boolean" />.</returns>
		// Token: 0x060002E5 RID: 741 RVA: 0x0000F287 File Offset: 0x0000D487
		public override int GetHashCode()
		{
			if (!this)
			{
				return 0;
			}
			return 1;
		}

		/// <summary>Converts the value of this instance to its equivalent string representation (either "True" or "False").</summary>
		/// <returns>"True" (the value of the <see cref="F:System.Boolean.TrueString" /> property) if the value of this instance is <see langword="true" />, or "False" (the value of the <see cref="F:System.Boolean.FalseString" /> property) if the value of this instance is <see langword="false" />.</returns>
		// Token: 0x060002E6 RID: 742 RVA: 0x0000F290 File Offset: 0x0000D490
		public override string ToString()
		{
			if (!this)
			{
				return "False";
			}
			return "True";
		}

		/// <summary>Converts the value of this instance to its equivalent string representation (either "True" or "False").</summary>
		/// <param name="provider">(Reserved) An <see cref="T:System.IFormatProvider" /> object. </param>
		/// <returns>
		///     <see cref="F:System.Boolean.TrueString" /> if the value of this instance is <see langword="true" />, or <see cref="F:System.Boolean.FalseString" /> if the value of this instance is <see langword="false" />.</returns>
		// Token: 0x060002E7 RID: 743 RVA: 0x0000F2A1 File Offset: 0x0000D4A1
		public string ToString(IFormatProvider provider)
		{
			return this.ToString();
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare to this instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.Boolean" /> and has the same value as this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x060002E8 RID: 744 RVA: 0x0000F2A9 File Offset: 0x0000D4A9
		public override bool Equals(object obj)
		{
			return obj is bool && this == (bool)obj;
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.Boolean" /> object.</summary>
		/// <param name="obj">A <see cref="T:System.Boolean" /> value to compare to this instance.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> has the same value as this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x060002E9 RID: 745 RVA: 0x0000F2BF File Offset: 0x0000D4BF
		[NonVersionable]
		public bool Equals(bool obj)
		{
			return this == obj;
		}

		/// <summary>Compares this instance to a specified object and returns an integer that indicates their relationship to one another.</summary>
		/// <param name="obj">An object to compare to this instance, or <see langword="null" />. </param>
		/// <returns>A signed integer that indicates the relative order of this instance and <paramref name="obj" />.Return Value Condition Less than zero This instance is <see langword="false" /> and <paramref name="obj" /> is <see langword="true" />. Zero This instance and <paramref name="obj" /> are equal (either both are <see langword="true" /> or both are <see langword="false" />). Greater than zero This instance is <see langword="true" /> and <paramref name="obj" /> is <see langword="false" />.-or- 
		///             <paramref name="obj" /> is <see langword="null" />. </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="obj" /> is not a <see cref="T:System.Boolean" />. </exception>
		// Token: 0x060002EA RID: 746 RVA: 0x0000F2C6 File Offset: 0x0000D4C6
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			if (!(obj is bool))
			{
				throw new ArgumentException("Object must be of type Boolean.");
			}
			if (this == (bool)obj)
			{
				return 0;
			}
			if (!this)
			{
				return -1;
			}
			return 1;
		}

		/// <summary>Compares this instance to a specified <see cref="T:System.Boolean" /> object and returns an integer that indicates their relationship to one another.</summary>
		/// <param name="value">A <see cref="T:System.Boolean" /> object to compare to this instance. </param>
		/// <returns>A signed integer that indicates the relative values of this instance and <paramref name="value" />.Return Value Condition Less than zero This instance is <see langword="false" /> and <paramref name="value" /> is <see langword="true" />. Zero This instance and <paramref name="value" /> are equal (either both are <see langword="true" /> or both are <see langword="false" />). Greater than zero This instance is <see langword="true" /> and <paramref name="value" /> is <see langword="false" />. </returns>
		// Token: 0x060002EB RID: 747 RVA: 0x0000F2F3 File Offset: 0x0000D4F3
		public int CompareTo(bool value)
		{
			if (this == value)
			{
				return 0;
			}
			if (!this)
			{
				return -1;
			}
			return 1;
		}

		/// <summary>Converts the specified string representation of a logical value to its <see cref="T:System.Boolean" /> equivalent.</summary>
		/// <param name="value">A string containing the value to convert. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is equivalent to <see cref="F:System.Boolean.TrueString" />; <see langword="false" /> if <paramref name="value" /> is equivalent to <see cref="F:System.Boolean.FalseString" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not equivalent to <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />. </exception>
		// Token: 0x060002EC RID: 748 RVA: 0x0000F303 File Offset: 0x0000D503
		public static bool Parse(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return bool.Parse(value.AsSpan());
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000F320 File Offset: 0x0000D520
		public static bool Parse(ReadOnlySpan<char> value)
		{
			bool result;
			if (!bool.TryParse(value, out result))
			{
				throw new FormatException("String was not recognized as a valid Boolean.");
			}
			return result;
		}

		/// <summary>Tries to convert the specified string representation of a logical value to its <see cref="T:System.Boolean" /> equivalent. A return value indicates whether the conversion succeeded or failed.</summary>
		/// <param name="value">A string containing the value to convert. </param>
		/// <param name="result">When this method returns, if the conversion succeeded, contains <see langword="true" /> if <paramref name="value" /> is equal to <see cref="F:System.Boolean.TrueString" /> or <see langword="false" /> if <paramref name="value" /> is equal to <see cref="F:System.Boolean.FalseString" />. If the conversion failed, contains <see langword="false" />. The conversion fails if <paramref name="value" /> is <see langword="null" /> or is not equal to the value of either the <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" /> field.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> was converted successfully; otherwise, <see langword="false" />.</returns>
		// Token: 0x060002EE RID: 750 RVA: 0x0000F343 File Offset: 0x0000D543
		public static bool TryParse(string value, out bool result)
		{
			if (value == null)
			{
				result = false;
				return false;
			}
			return bool.TryParse(value.AsSpan(), out result);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000F35C File Offset: 0x0000D55C
		public static bool TryParse(ReadOnlySpan<char> value, out bool result)
		{
			ReadOnlySpan<char> span = "True".AsSpan();
			if (span.EqualsOrdinalIgnoreCase(value))
			{
				result = true;
				return true;
			}
			ReadOnlySpan<char> span2 = "False".AsSpan();
			if (span2.EqualsOrdinalIgnoreCase(value))
			{
				result = false;
				return true;
			}
			value = bool.TrimWhiteSpaceAndNull(value);
			if (span.EqualsOrdinalIgnoreCase(value))
			{
				result = true;
				return true;
			}
			if (span2.EqualsOrdinalIgnoreCase(value))
			{
				result = false;
				return true;
			}
			result = false;
			return false;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000F3C4 File Offset: 0x0000D5C4
		private unsafe static ReadOnlySpan<char> TrimWhiteSpaceAndNull(ReadOnlySpan<char> value)
		{
			int num = 0;
			while (num < value.Length && (char.IsWhiteSpace((char)(*value[num])) || *value[num] == 0))
			{
				num++;
			}
			int num2 = value.Length - 1;
			while (num2 >= num && (char.IsWhiteSpace((char)(*value[num2])) || *value[num2] == 0))
			{
				num2--;
			}
			return value.Slice(num, num2 - num + 1);
		}

		/// <summary>Returns the type code for the <see cref="T:System.Boolean" /> value type. </summary>
		/// <returns>The enumerated constant <see cref="F:System.TypeCode.Boolean" />.</returns>
		// Token: 0x060002F1 RID: 753 RVA: 0x0000F43A File Offset: 0x0000D63A
		public TypeCode GetTypeCode()
		{
			return TypeCode.Boolean;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>
		///     <see langword="true" /> or <see langword="false" />.</returns>
		// Token: 0x060002F2 RID: 754 RVA: 0x0000F43D File Offset: 0x0000D63D
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">You attempt to convert a <see cref="T:System.Boolean" /> value to a <see cref="T:System.Char" /> value. This conversion is not supported.</exception>
		// Token: 0x060002F3 RID: 755 RVA: 0x0000F441 File Offset: 0x0000D641
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Boolean", "Char"));
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060002F4 RID: 756 RVA: 0x0000F45C File Offset: 0x0000D65C
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>1 if the value of this instance is <see langword="true" />; otherwise, 0. </returns>
		// Token: 0x060002F5 RID: 757 RVA: 0x0000F465 File Offset: 0x0000D665
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060002F6 RID: 758 RVA: 0x0000F46E File Offset: 0x0000D66E
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060002F7 RID: 759 RVA: 0x0000F477 File Offset: 0x0000D677
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060002F8 RID: 760 RVA: 0x0000F480 File Offset: 0x0000D680
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060002F9 RID: 761 RVA: 0x0000F489 File Offset: 0x0000D689
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060002FA RID: 762 RVA: 0x0000F492 File Offset: 0x0000D692
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />. </summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060002FB RID: 763 RVA: 0x0000F49B File Offset: 0x0000D69B
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />..</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060002FC RID: 764 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />..</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060002FD RID: 765 RVA: 0x0000F4AD File Offset: 0x0000D6AD
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />..</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060002FE RID: 766 RVA: 0x0000F4B6 File Offset: 0x0000D6B6
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">You attempt to convert a <see cref="T:System.Boolean" /> value to a <see cref="T:System.DateTime" /> value. This conversion is not supported.</exception>
		// Token: 0x060002FF RID: 767 RVA: 0x0000F4BF File Offset: 0x0000D6BF
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Boolean", "DateTime"));
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />. </summary>
		/// <param name="type">The desired type. </param>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> implementation that supplies culture-specific information about the format of the returned value.</param>
		/// <returns>An object of the specified type, with a value that is equivalent to the value of this <see langword="Boolean" /> object.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The requested type conversion is not supported. </exception>
		// Token: 0x06000300 RID: 768 RVA: 0x0000F4DA File Offset: 0x0000D6DA
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x040001CE RID: 462
		private readonly bool m_value;

		/// <summary>Represents the Boolean value <see langword="true" /> as a string. This field is read-only.</summary>
		// Token: 0x040001CF RID: 463
		public static readonly string TrueString = "True";

		/// <summary>Represents the Boolean value <see langword="false" /> as a string. This field is read-only.</summary>
		// Token: 0x040001D0 RID: 464
		public static readonly string FalseString = "False";
	}
}
