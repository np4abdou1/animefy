using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Converts a base data type to another base data type.</summary>
	// Token: 0x0200008C RID: 140
	public static class Convert
	{
		// Token: 0x06000366 RID: 870 RVA: 0x0000FEB4 File Offset: 0x0000E0B4
		private unsafe static bool TryDecodeFromUtf16(ReadOnlySpan<char> utf16, Span<byte> bytes, out int consumed, out int written)
		{
			ref char reference = ref MemoryMarshal.GetReference<char>(utf16);
			ref byte reference2 = ref MemoryMarshal.GetReference<byte>(bytes);
			int num = utf16.Length & -4;
			int length = bytes.Length;
			int i = 0;
			int num2 = 0;
			if (utf16.Length != 0)
			{
				ref sbyte ptr = ref Convert.s_decodingMap[0];
				int num3;
				if (length >= (num >> 2) * 3)
				{
					num3 = num - 4;
				}
				else
				{
					num3 = length / 3 * 4;
				}
				while (i < num3)
				{
					int num4 = Convert.Decode(Unsafe.Add<char>(ref reference, i), ref ptr);
					if (num4 < 0)
					{
						IL_201:
						consumed = i;
						written = num2;
						return false;
					}
					Convert.WriteThreeLowOrderBytes(Unsafe.Add<byte>(ref reference2, num2), num4);
					num2 += 3;
					i += 4;
				}
				if (num3 != num - 4 || i == num)
				{
					goto IL_201;
				}
				int num5 = (int)(*Unsafe.Add<char>(ref reference, num - 4));
				int num6 = (int)(*Unsafe.Add<char>(ref reference, num - 3));
				int num7 = (int)(*Unsafe.Add<char>(ref reference, num - 2));
				int num8 = (int)(*Unsafe.Add<char>(ref reference, num - 1));
				if (((long)(num5 | num6 | num7 | num8) & (long)((ulong)-256)) != 0L)
				{
					goto IL_201;
				}
				num5 = (int)(*Unsafe.Add<sbyte>(ref ptr, num5));
				num6 = (int)(*Unsafe.Add<sbyte>(ref ptr, num6));
				num5 <<= 18;
				num6 <<= 12;
				num5 |= num6;
				if (num8 != 61)
				{
					num7 = (int)(*Unsafe.Add<sbyte>(ref ptr, num7));
					num8 = (int)(*Unsafe.Add<sbyte>(ref ptr, num8));
					num7 <<= 6;
					num5 |= num8;
					num5 |= num7;
					if (num5 < 0 || num2 > length - 3)
					{
						goto IL_201;
					}
					Convert.WriteThreeLowOrderBytes(Unsafe.Add<byte>(ref reference2, num2), num5);
					num2 += 3;
				}
				else if (num7 != 61)
				{
					num7 = (int)(*Unsafe.Add<sbyte>(ref ptr, num7));
					num7 <<= 6;
					num5 |= num7;
					if (num5 < 0 || num2 > length - 2)
					{
						goto IL_201;
					}
					*Unsafe.Add<byte>(ref reference2, num2) = (byte)(num5 >> 16);
					*Unsafe.Add<byte>(ref reference2, num2 + 1) = (byte)(num5 >> 8);
					num2 += 2;
				}
				else
				{
					if (num5 < 0 || num2 > length - 1)
					{
						goto IL_201;
					}
					*Unsafe.Add<byte>(ref reference2, num2) = (byte)(num5 >> 16);
					num2++;
				}
				i += 4;
				if (num != utf16.Length)
				{
					goto IL_201;
				}
			}
			consumed = i;
			written = num2;
			return true;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000100CC File Offset: 0x0000E2CC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static int Decode(ref char encodedChars, ref sbyte decodingMap)
		{
			int num = (int)encodedChars;
			int num2 = (int)(*Unsafe.Add<char>(ref encodedChars, 1));
			int num3 = (int)(*Unsafe.Add<char>(ref encodedChars, 2));
			int num4 = (int)(*Unsafe.Add<char>(ref encodedChars, 3));
			if (((long)(num | num2 | num3 | num4) & (long)((ulong)-256)) != 0L)
			{
				return -1;
			}
			num = (int)(*Unsafe.Add<sbyte>(ref decodingMap, num));
			num2 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, num2));
			num3 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, num3));
			num4 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, num4));
			num <<= 18;
			num2 <<= 12;
			num3 <<= 6;
			num |= num4;
			num2 |= num3;
			return num | num2;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00010149 File Offset: 0x0000E349
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void WriteThreeLowOrderBytes(ref byte destination, int value)
		{
			destination = (byte)(value >> 16);
			*Unsafe.Add<byte>(ref destination, 1) = (byte)(value >> 8);
			*Unsafe.Add<byte>(ref destination, 2) = (byte)value;
		}

		/// <summary>Returns the <see cref="T:System.TypeCode" /> for the specified object.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <returns>The <see cref="T:System.TypeCode" /> for <paramref name="value" />, or <see cref="F:System.TypeCode.Empty" /> if <paramref name="value" /> is <see langword="null" />.</returns>
		// Token: 0x06000369 RID: 873 RVA: 0x00010168 File Offset: 0x0000E368
		public static TypeCode GetTypeCode(object value)
		{
			if (value == null)
			{
				return TypeCode.Empty;
			}
			IConvertible convertible = value as IConvertible;
			if (convertible != null)
			{
				return convertible.GetTypeCode();
			}
			return TypeCode.Object;
		}

		/// <summary>Returns an indication whether the specified object is of type <see cref="T:System.DBNull" />.</summary>
		/// <param name="value">An object. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is of type <see cref="T:System.DBNull" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600036A RID: 874 RVA: 0x0001018C File Offset: 0x0000E38C
		public static bool IsDBNull(object value)
		{
			if (value == System.DBNull.Value)
			{
				return true;
			}
			IConvertible convertible = value as IConvertible;
			return convertible != null && convertible.GetTypeCode() == TypeCode.DBNull;
		}

		/// <summary>Returns an object of the specified type whose value is equivalent to the specified object. A parameter supplies culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="typeCode">The type of object to return. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>An object whose underlying type is <paramref name="typeCode" /> and whose value is equivalent to <paramref name="value" />.-or- A null reference (<see langword="Nothing" /> in Visual Basic), if <paramref name="value" /> is <see langword="null" /> and <paramref name="typeCode" /> is <see cref="F:System.TypeCode.Empty" />, <see cref="F:System.TypeCode.String" />, or <see cref="F:System.TypeCode.Object" />.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported.  -or-
		///         <paramref name="value" /> is <see langword="null" /> and <paramref name="typeCode" /> specifies a value type.-or-
		///         <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.</exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in a format for the <paramref name="typeCode" /> type recognized by <paramref name="provider" />.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is out of the range of the <paramref name="typeCode" /> type.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="typeCode" /> is invalid. </exception>
		// Token: 0x0600036B RID: 875 RVA: 0x000101B8 File Offset: 0x0000E3B8
		public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider)
		{
			if (value == null && (typeCode == TypeCode.Empty || typeCode == TypeCode.String || typeCode == TypeCode.Object))
			{
				return null;
			}
			IConvertible convertible = value as IConvertible;
			if (convertible == null)
			{
				throw new InvalidCastException("Object must implement IConvertible.");
			}
			switch (typeCode)
			{
			case TypeCode.Empty:
				throw new InvalidCastException("Object cannot be cast to Empty.");
			case TypeCode.Object:
				return value;
			case TypeCode.DBNull:
				throw new InvalidCastException("Object cannot be cast to DBNull.");
			case TypeCode.Boolean:
				return convertible.ToBoolean(provider);
			case TypeCode.Char:
				return convertible.ToChar(provider);
			case TypeCode.SByte:
				return convertible.ToSByte(provider);
			case TypeCode.Byte:
				return convertible.ToByte(provider);
			case TypeCode.Int16:
				return convertible.ToInt16(provider);
			case TypeCode.UInt16:
				return convertible.ToUInt16(provider);
			case TypeCode.Int32:
				return convertible.ToInt32(provider);
			case TypeCode.UInt32:
				return convertible.ToUInt32(provider);
			case TypeCode.Int64:
				return convertible.ToInt64(provider);
			case TypeCode.UInt64:
				return convertible.ToUInt64(provider);
			case TypeCode.Single:
				return convertible.ToSingle(provider);
			case TypeCode.Double:
				return convertible.ToDouble(provider);
			case TypeCode.Decimal:
				return convertible.ToDecimal(provider);
			case TypeCode.DateTime:
				return convertible.ToDateTime(provider);
			case TypeCode.String:
				return convertible.ToString(provider);
			}
			throw new ArgumentException("Unknown TypeCode value.");
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00010324 File Offset: 0x0000E524
		internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider)
		{
			if (targetType == null)
			{
				throw new ArgumentNullException("targetType");
			}
			if (value.GetType() == targetType)
			{
				return value;
			}
			if (targetType == Convert.ConvertTypes[3])
			{
				return value.ToBoolean(provider);
			}
			if (targetType == Convert.ConvertTypes[4])
			{
				return value.ToChar(provider);
			}
			if (targetType == Convert.ConvertTypes[5])
			{
				return value.ToSByte(provider);
			}
			if (targetType == Convert.ConvertTypes[6])
			{
				return value.ToByte(provider);
			}
			if (targetType == Convert.ConvertTypes[7])
			{
				return value.ToInt16(provider);
			}
			if (targetType == Convert.ConvertTypes[8])
			{
				return value.ToUInt16(provider);
			}
			if (targetType == Convert.ConvertTypes[9])
			{
				return value.ToInt32(provider);
			}
			if (targetType == Convert.ConvertTypes[10])
			{
				return value.ToUInt32(provider);
			}
			if (targetType == Convert.ConvertTypes[11])
			{
				return value.ToInt64(provider);
			}
			if (targetType == Convert.ConvertTypes[12])
			{
				return value.ToUInt64(provider);
			}
			if (targetType == Convert.ConvertTypes[13])
			{
				return value.ToSingle(provider);
			}
			if (targetType == Convert.ConvertTypes[14])
			{
				return value.ToDouble(provider);
			}
			if (targetType == Convert.ConvertTypes[15])
			{
				return value.ToDecimal(provider);
			}
			if (targetType == Convert.ConvertTypes[16])
			{
				return value.ToDateTime(provider);
			}
			if (targetType == Convert.ConvertTypes[18])
			{
				return value.ToString(provider);
			}
			if (targetType == Convert.ConvertTypes[1])
			{
				return value;
			}
			if (targetType == Convert.EnumType)
			{
				return (Enum)value;
			}
			if (targetType == Convert.ConvertTypes[2])
			{
				throw new InvalidCastException("Object cannot be cast to DBNull.");
			}
			if (targetType == Convert.ConvertTypes[0])
			{
				throw new InvalidCastException("Object cannot be cast to Empty.");
			}
			throw new InvalidCastException(string.Format("Invalid cast from '{0}' to '{1}'.", value.GetType().FullName, targetType.FullName));
		}

		/// <summary>Returns an object of the specified type and whose value is equivalent to the specified object.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="conversionType">The type of object to return. </param>
		/// <returns>An object whose type is <paramref name="conversionType" /> and whose value is equivalent to <paramref name="value" />.-or-A null reference (<see langword="Nothing" /> in Visual Basic), if <paramref name="value" /> is <see langword="null" /> and <paramref name="conversionType" /> is not a value type. </returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported.  -or-
		///         <paramref name="value" /> is <see langword="null" /> and <paramref name="conversionType" /> is a value type.-or-
		///         <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.</exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in a format recognized by <paramref name="conversionType" />.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is out of the range of <paramref name="conversionType" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="conversionType" /> is <see langword="null" />.</exception>
		// Token: 0x0600036D RID: 877 RVA: 0x00010512 File Offset: 0x0000E712
		public static object ChangeType(object value, Type conversionType)
		{
			return Convert.ChangeType(value, conversionType, CultureInfo.CurrentCulture);
		}

		/// <summary>Returns an object of the specified type whose value is equivalent to the specified object. A parameter supplies culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="conversionType">The type of object to return. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>An object whose type is <paramref name="conversionType" /> and whose value is equivalent to <paramref name="value" />.-or- 
		///     <paramref name="value" />, if the <see cref="T:System.Type" /> of <paramref name="value" /> and <paramref name="conversionType" /> are equal.-or- A null reference (<see langword="Nothing" /> in Visual Basic), if <paramref name="value" /> is <see langword="null" /> and <paramref name="conversionType" /> is not a value type.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported. -or-
		///         <paramref name="value" /> is <see langword="null" /> and <paramref name="conversionType" /> is a value type.-or-
		///         <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.</exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in a format for <paramref name="conversionType" /> recognized by <paramref name="provider" />.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is out of the range of <paramref name="conversionType" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="conversionType" /> is <see langword="null" />.</exception>
		// Token: 0x0600036E RID: 878 RVA: 0x00010520 File Offset: 0x0000E720
		public static object ChangeType(object value, Type conversionType, IFormatProvider provider)
		{
			if (conversionType == null)
			{
				throw new ArgumentNullException("conversionType");
			}
			if (value == null)
			{
				if (conversionType.IsValueType)
				{
					throw new InvalidCastException("Null object cannot be converted to a value type.");
				}
				return null;
			}
			else
			{
				IConvertible convertible = value as IConvertible;
				if (convertible == null)
				{
					if (value.GetType() == conversionType)
					{
						return value;
					}
					throw new InvalidCastException("Object must implement IConvertible.");
				}
				else
				{
					if (conversionType == Convert.ConvertTypes[3])
					{
						return convertible.ToBoolean(provider);
					}
					if (conversionType == Convert.ConvertTypes[4])
					{
						return convertible.ToChar(provider);
					}
					if (conversionType == Convert.ConvertTypes[5])
					{
						return convertible.ToSByte(provider);
					}
					if (conversionType == Convert.ConvertTypes[6])
					{
						return convertible.ToByte(provider);
					}
					if (conversionType == Convert.ConvertTypes[7])
					{
						return convertible.ToInt16(provider);
					}
					if (conversionType == Convert.ConvertTypes[8])
					{
						return convertible.ToUInt16(provider);
					}
					if (conversionType == Convert.ConvertTypes[9])
					{
						return convertible.ToInt32(provider);
					}
					if (conversionType == Convert.ConvertTypes[10])
					{
						return convertible.ToUInt32(provider);
					}
					if (conversionType == Convert.ConvertTypes[11])
					{
						return convertible.ToInt64(provider);
					}
					if (conversionType == Convert.ConvertTypes[12])
					{
						return convertible.ToUInt64(provider);
					}
					if (conversionType == Convert.ConvertTypes[13])
					{
						return convertible.ToSingle(provider);
					}
					if (conversionType == Convert.ConvertTypes[14])
					{
						return convertible.ToDouble(provider);
					}
					if (conversionType == Convert.ConvertTypes[15])
					{
						return convertible.ToDecimal(provider);
					}
					if (conversionType == Convert.ConvertTypes[16])
					{
						return convertible.ToDateTime(provider);
					}
					if (conversionType == Convert.ConvertTypes[18])
					{
						return convertible.ToString(provider);
					}
					if (conversionType == Convert.ConvertTypes[1])
					{
						return value;
					}
					return convertible.ToType(conversionType, provider);
				}
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000106E9 File Offset: 0x0000E8E9
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowCharOverflowException()
		{
			throw new OverflowException("Value was either too large or too small for a character.");
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000106F5 File Offset: 0x0000E8F5
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowByteOverflowException()
		{
			throw new OverflowException("Value was either too large or too small for an unsigned byte.");
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00010701 File Offset: 0x0000E901
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowSByteOverflowException()
		{
			throw new OverflowException("Value was either too large or too small for a signed byte.");
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0001070D File Offset: 0x0000E90D
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowInt16OverflowException()
		{
			throw new OverflowException("Value was either too large or too small for an Int16.");
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00010719 File Offset: 0x0000E919
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowUInt16OverflowException()
		{
			throw new OverflowException("Value was either too large or too small for a UInt16.");
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00010725 File Offset: 0x0000E925
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowInt32OverflowException()
		{
			throw new OverflowException("Value was either too large or too small for an Int32.");
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00010731 File Offset: 0x0000E931
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowUInt32OverflowException()
		{
			throw new OverflowException("Value was either too large or too small for a UInt32.");
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0001073D File Offset: 0x0000E93D
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowInt64OverflowException()
		{
			throw new OverflowException("Value was either too large or too small for an Int64.");
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00010749 File Offset: 0x0000E949
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowUInt64OverflowException()
		{
			throw new OverflowException("Value was either too large or too small for a UInt64.");
		}

		/// <summary>Converts the value of the specified object to an equivalent Boolean value, using the specified culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>
		///     <see langword="true" /> or <see langword="false" />, which reflects the value returned by invoking the <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" /> method for the underlying type of <paramref name="value" />. If <paramref name="value" /> is <see langword="null" />, the method returns <see langword="false" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is a string that does not equal <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.-or-The conversion of <paramref name="value" /> to a <see cref="T:System.Boolean" /> is not supported. </exception>
		// Token: 0x06000378 RID: 888 RVA: 0x00010755 File Offset: 0x0000E955
		public static bool ToBoolean(object value, IFormatProvider provider)
		{
			return value != null && ((IConvertible)value).ToBoolean(provider);
		}

		/// <summary>Converts the value of the specified 8-bit signed integer to an equivalent Boolean value.</summary>
		/// <param name="value">The 8-bit signed integer to convert. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000379 RID: 889 RVA: 0x00010768 File Offset: 0x0000E968
		[CLSCompliant(false)]
		public static bool ToBoolean(sbyte value)
		{
			return value != 0;
		}

		/// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
		// Token: 0x0600037A RID: 890 RVA: 0x0001076E File Offset: 0x0000E96E
		public static bool ToBoolean(char value)
		{
			return ((IConvertible)value).ToBoolean(null);
		}

		/// <summary>Converts the value of the specified 8-bit unsigned integer to an equivalent Boolean value.</summary>
		/// <param name="value">The 8-bit unsigned integer to convert. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600037B RID: 891 RVA: 0x00010768 File Offset: 0x0000E968
		public static bool ToBoolean(byte value)
		{
			return value > 0;
		}

		/// <summary>Converts the value of the specified 16-bit signed integer to an equivalent Boolean value.</summary>
		/// <param name="value">The 16-bit signed integer to convert. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600037C RID: 892 RVA: 0x00010768 File Offset: 0x0000E968
		public static bool ToBoolean(short value)
		{
			return value != 0;
		}

		/// <summary>Converts the value of the specified 16-bit unsigned integer to an equivalent Boolean value.</summary>
		/// <param name="value">The 16-bit unsigned integer to convert. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600037D RID: 893 RVA: 0x00010768 File Offset: 0x0000E968
		[CLSCompliant(false)]
		public static bool ToBoolean(ushort value)
		{
			return value > 0;
		}

		/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent Boolean value.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600037E RID: 894 RVA: 0x00010768 File Offset: 0x0000E968
		public static bool ToBoolean(int value)
		{
			return value != 0;
		}

		/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent Boolean value.</summary>
		/// <param name="value">The 32-bit unsigned integer to convert. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600037F RID: 895 RVA: 0x00010768 File Offset: 0x0000E968
		[CLSCompliant(false)]
		public static bool ToBoolean(uint value)
		{
			return value > 0U;
		}

		/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent Boolean value.</summary>
		/// <param name="value">The 64-bit signed integer to convert. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000380 RID: 896 RVA: 0x0001077C File Offset: 0x0000E97C
		public static bool ToBoolean(long value)
		{
			return value != 0L;
		}

		/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent Boolean value.</summary>
		/// <param name="value">The 64-bit unsigned integer to convert. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000381 RID: 897 RVA: 0x0001077C File Offset: 0x0000E97C
		[CLSCompliant(false)]
		public static bool ToBoolean(ulong value)
		{
			return value > 0UL;
		}

		/// <summary>Converts the specified string representation of a logical value to its Boolean equivalent, using the specified culture-specific formatting information.</summary>
		/// <param name="value">A string that contains the value of either <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. This parameter is ignored.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> equals <see cref="F:System.Boolean.TrueString" />, or <see langword="false" /> if <paramref name="value" /> equals <see cref="F:System.Boolean.FalseString" /> or <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not equal to <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />. </exception>
		// Token: 0x06000382 RID: 898 RVA: 0x00010783 File Offset: 0x0000E983
		public static bool ToBoolean(string value, IFormatProvider provider)
		{
			return value != null && bool.Parse(value);
		}

		/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent Boolean value.</summary>
		/// <param name="value">The single-precision floating-point number to convert. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000383 RID: 899 RVA: 0x00010790 File Offset: 0x0000E990
		public static bool ToBoolean(float value)
		{
			return value != 0f;
		}

		/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent Boolean value.</summary>
		/// <param name="value">The double-precision floating-point number to convert. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000384 RID: 900 RVA: 0x0001079D File Offset: 0x0000E99D
		public static bool ToBoolean(double value)
		{
			return value != 0.0;
		}

		/// <summary>Converts the value of the specified decimal number to an equivalent Boolean value.</summary>
		/// <param name="value">The number to convert. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000385 RID: 901 RVA: 0x000107AE File Offset: 0x0000E9AE
		public static bool ToBoolean(decimal value)
		{
			return value != 0m;
		}

		/// <summary>Converts the value of the specified object to its equivalent Unicode character, using the specified culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A Unicode character that is equivalent to <paramref name="value" />, or <see cref="F:System.Char.MinValue" /> if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is a null string.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion of <paramref name="value" /> to a <see cref="T:System.Char" /> is not supported.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" /> or greater than <see cref="F:System.Char.MaxValue" />.</exception>
		// Token: 0x06000386 RID: 902 RVA: 0x000107BB File Offset: 0x0000E9BB
		public static char ToChar(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToChar(provider);
			}
			return '\0';
		}

		/// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">The Boolean value to convert. </param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
		// Token: 0x06000387 RID: 903 RVA: 0x000107CE File Offset: 0x0000E9CE
		public static char ToChar(bool value)
		{
			return ((IConvertible)value).ToChar(null);
		}

		/// <summary>Returns the specified Unicode character value; no actual conversion is performed.</summary>
		/// <param name="value">The Unicode character to return. </param>
		/// <returns>
		///     <paramref name="value" /> is returned unchanged.</returns>
		// Token: 0x06000388 RID: 904 RVA: 0x0000245A File Offset: 0x0000065A
		public static char ToChar(char value)
		{
			return value;
		}

		/// <summary>Converts the value of the specified 8-bit signed integer to its equivalent Unicode character.</summary>
		/// <param name="value">The 8-bit signed integer to convert. </param>
		/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" />. </exception>
		// Token: 0x06000389 RID: 905 RVA: 0x000107DC File Offset: 0x0000E9DC
		[CLSCompliant(false)]
		public static char ToChar(sbyte value)
		{
			if (value < 0)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		/// <summary>Converts the value of the specified 8-bit unsigned integer to its equivalent Unicode character.</summary>
		/// <param name="value">The 8-bit unsigned integer to convert. </param>
		/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600038A RID: 906 RVA: 0x0000245A File Offset: 0x0000065A
		public static char ToChar(byte value)
		{
			return (char)value;
		}

		/// <summary>Converts the value of the specified 16-bit signed integer to its equivalent Unicode character.</summary>
		/// <param name="value">The 16-bit signed integer to convert. </param>
		/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" />. </exception>
		// Token: 0x0600038B RID: 907 RVA: 0x000107DC File Offset: 0x0000E9DC
		public static char ToChar(short value)
		{
			if (value < 0)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		/// <summary>Converts the value of the specified 16-bit unsigned integer to its equivalent Unicode character.</summary>
		/// <param name="value">The 16-bit unsigned integer to convert. </param>
		/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600038C RID: 908 RVA: 0x0000245A File Offset: 0x0000065A
		[CLSCompliant(false)]
		public static char ToChar(ushort value)
		{
			return (char)value;
		}

		/// <summary>Converts the value of the specified 32-bit signed integer to its equivalent Unicode character.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" /> or greater than <see cref="F:System.Char.MaxValue" />. </exception>
		// Token: 0x0600038D RID: 909 RVA: 0x000107E9 File Offset: 0x0000E9E9
		public static char ToChar(int value)
		{
			if (value < 0 || value > 65535)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		/// <summary>Converts the value of the specified 32-bit unsigned integer to its equivalent Unicode character.</summary>
		/// <param name="value">The 32-bit unsigned integer to convert. </param>
		/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Char.MaxValue" />. </exception>
		// Token: 0x0600038E RID: 910 RVA: 0x000107FE File Offset: 0x0000E9FE
		[CLSCompliant(false)]
		public static char ToChar(uint value)
		{
			if (value > 65535U)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		/// <summary>Converts the value of the specified 64-bit signed integer to its equivalent Unicode character.</summary>
		/// <param name="value">The 64-bit signed integer to convert. </param>
		/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" /> or greater than <see cref="F:System.Char.MaxValue" />. </exception>
		// Token: 0x0600038F RID: 911 RVA: 0x0001080F File Offset: 0x0000EA0F
		public static char ToChar(long value)
		{
			if (value < 0L || value > 65535L)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		/// <summary>Converts the value of the specified 64-bit unsigned integer to its equivalent Unicode character.</summary>
		/// <param name="value">The 64-bit unsigned integer to convert. </param>
		/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Char.MaxValue" />. </exception>
		// Token: 0x06000390 RID: 912 RVA: 0x00010826 File Offset: 0x0000EA26
		[CLSCompliant(false)]
		public static char ToChar(ulong value)
		{
			if (value > 65535UL)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		/// <summary>Converts the first character of a specified string to a Unicode character, using specified culture-specific formatting information.</summary>
		/// <param name="value">A string of length 1 or <see langword="null" />. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. This parameter is ignored.</param>
		/// <returns>A Unicode character that is equivalent to the first and only character in <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">The length of <paramref name="value" /> is not 1. </exception>
		// Token: 0x06000391 RID: 913 RVA: 0x00010838 File Offset: 0x0000EA38
		public static char ToChar(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length != 1)
			{
				throw new FormatException("String must be exactly one character long.");
			}
			return value[0];
		}

		/// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">The single-precision floating-point number to convert. </param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
		// Token: 0x06000392 RID: 914 RVA: 0x00010863 File Offset: 0x0000EA63
		public static char ToChar(float value)
		{
			return ((IConvertible)value).ToChar(null);
		}

		/// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">The double-precision floating-point number to convert. </param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
		// Token: 0x06000393 RID: 915 RVA: 0x00010871 File Offset: 0x0000EA71
		public static char ToChar(double value)
		{
			return ((IConvertible)value).ToChar(null);
		}

		/// <summary>Converts the value of the specified object to an 8-bit signed integer, using the specified culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in an appropriate format. </exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />.</exception>
		// Token: 0x06000394 RID: 916 RVA: 0x0001087F File Offset: 0x0000EA7F
		[CLSCompliant(false)]
		public static sbyte ToSByte(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToSByte(provider);
			}
			return 0;
		}

		/// <summary>Converts the specified Boolean value to the equivalent 8-bit signed integer.</summary>
		/// <param name="value">The Boolean value to convert. </param>
		/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x06000395 RID: 917 RVA: 0x00010892 File Offset: 0x0000EA92
		[CLSCompliant(false)]
		public static sbyte ToSByte(bool value)
		{
			if (!value)
			{
				return 0;
			}
			return 1;
		}

		/// <summary>Converts the value of the specified Unicode character to the equivalent 8-bit signed integer.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" />. </exception>
		// Token: 0x06000396 RID: 918 RVA: 0x0001089A File Offset: 0x0000EA9A
		[CLSCompliant(false)]
		public static sbyte ToSByte(char value)
		{
			if (value > '\u007f')
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 8-bit signed integer.</summary>
		/// <param name="value">The 8-bit unsigned integer to convert. </param>
		/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" />. </exception>
		// Token: 0x06000397 RID: 919 RVA: 0x0001089A File Offset: 0x0000EA9A
		[CLSCompliant(false)]
		public static sbyte ToSByte(byte value)
		{
			if (value > 127)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Converts the value of the specified 16-bit signed integer to the equivalent 8-bit signed integer.</summary>
		/// <param name="value">The 16-bit signed integer to convert. </param>
		/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
		// Token: 0x06000398 RID: 920 RVA: 0x000108A8 File Offset: 0x0000EAA8
		[CLSCompliant(false)]
		public static sbyte ToSByte(short value)
		{
			if (value < -128 || value > 127)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 8-bit signed integer.</summary>
		/// <param name="value">The 16-bit unsigned integer to convert. </param>
		/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" />. </exception>
		// Token: 0x06000399 RID: 921 RVA: 0x0001089A File Offset: 0x0000EA9A
		[CLSCompliant(false)]
		public static sbyte ToSByte(ushort value)
		{
			if (value > 127)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 8-bit signed integer.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
		// Token: 0x0600039A RID: 922 RVA: 0x000108A8 File Offset: 0x0000EAA8
		[CLSCompliant(false)]
		public static sbyte ToSByte(int value)
		{
			if (value < -128 || value > 127)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 8-bit signed integer.</summary>
		/// <param name="value">The 32-bit unsigned integer to convert. </param>
		/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
		// Token: 0x0600039B RID: 923 RVA: 0x000108BB File Offset: 0x0000EABB
		[CLSCompliant(false)]
		public static sbyte ToSByte(uint value)
		{
			if ((ulong)value > 127UL)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 8-bit signed integer.</summary>
		/// <param name="value">The 64-bit signed integer to convert. </param>
		/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
		// Token: 0x0600039C RID: 924 RVA: 0x000108CB File Offset: 0x0000EACB
		[CLSCompliant(false)]
		public static sbyte ToSByte(long value)
		{
			if (value < -128L || value > 127L)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 8-bit signed integer.</summary>
		/// <param name="value">The 64-bit unsigned integer to convert. </param>
		/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
		// Token: 0x0600039D RID: 925 RVA: 0x000108E0 File Offset: 0x0000EAE0
		[CLSCompliant(false)]
		public static sbyte ToSByte(ulong value)
		{
			if (value > 127UL)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 8-bit signed integer.</summary>
		/// <param name="value">The single-precision floating-point number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 8-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
		// Token: 0x0600039E RID: 926 RVA: 0x000108EF File Offset: 0x0000EAEF
		[CLSCompliant(false)]
		public static sbyte ToSByte(float value)
		{
			return Convert.ToSByte((double)value);
		}

		/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 8-bit signed integer.</summary>
		/// <param name="value">The double-precision floating-point number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 8-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
		// Token: 0x0600039F RID: 927 RVA: 0x000108F8 File Offset: 0x0000EAF8
		[CLSCompliant(false)]
		public static sbyte ToSByte(double value)
		{
			return Convert.ToSByte(Convert.ToInt32(value));
		}

		/// <summary>Converts the value of the specified decimal number to an equivalent 8-bit signed integer.</summary>
		/// <param name="value">The decimal number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 8-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
		// Token: 0x060003A0 RID: 928 RVA: 0x00010905 File Offset: 0x0000EB05
		[CLSCompliant(false)]
		public static sbyte ToSByte(decimal value)
		{
			return decimal.ToSByte(decimal.Round(value, 0));
		}

		/// <summary>Converts the specified string representation of a number to an equivalent 8-bit signed integer, using the specified culture-specific formatting information.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />. </exception>
		// Token: 0x060003A1 RID: 929 RVA: 0x00010913 File Offset: 0x0000EB13
		[CLSCompliant(false)]
		public static sbyte ToSByte(string value, IFormatProvider provider)
		{
			return sbyte.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>Converts the value of the specified object to an 8-bit unsigned integer, using the specified culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in the property format for a <see cref="T:System.Byte" /> value.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement <see cref="T:System.IConvertible" />. -or-Conversion from <paramref name="value" /> to the <see cref="T:System.Byte" /> type is not supported.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x060003A2 RID: 930 RVA: 0x0001091D File Offset: 0x0000EB1D
		public static byte ToByte(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToByte(provider);
			}
			return 0;
		}

		/// <summary>Converts the specified Boolean value to the equivalent 8-bit unsigned integer.</summary>
		/// <param name="value">The Boolean value to convert. </param>
		/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060003A3 RID: 931 RVA: 0x00010892 File Offset: 0x0000EA92
		public static byte ToByte(bool value)
		{
			if (!value)
			{
				return 0;
			}
			return 1;
		}

		/// <summary>Converts the value of the specified Unicode character to the equivalent 8-bit unsigned integer.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is greater than <see cref="F:System.Byte.MaxValue" />. </exception>
		// Token: 0x060003A4 RID: 932 RVA: 0x00010930 File Offset: 0x0000EB30
		public static byte ToByte(char value)
		{
			if (value > 'ÿ')
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Converts the value of the specified 8-bit signed integer to an equivalent 8-bit unsigned integer.</summary>
		/// <param name="value">The 8-bit signed integer to be converted. </param>
		/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" />. </exception>
		// Token: 0x060003A5 RID: 933 RVA: 0x00010941 File Offset: 0x0000EB41
		[CLSCompliant(false)]
		public static byte ToByte(sbyte value)
		{
			if (value < 0)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Converts the value of the specified 16-bit signed integer to an equivalent 8-bit unsigned integer.</summary>
		/// <param name="value">The 16-bit signed integer to convert. </param>
		/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
		// Token: 0x060003A6 RID: 934 RVA: 0x0001094E File Offset: 0x0000EB4E
		public static byte ToByte(short value)
		{
			if (value < 0 || value > 255)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Converts the value of the specified 16-bit unsigned integer to an equivalent 8-bit unsigned integer.</summary>
		/// <param name="value">The 16-bit unsigned integer to convert. </param>
		/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" />. </exception>
		// Token: 0x060003A7 RID: 935 RVA: 0x00010930 File Offset: 0x0000EB30
		[CLSCompliant(false)]
		public static byte ToByte(ushort value)
		{
			if (value > 255)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 8-bit unsigned integer.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
		// Token: 0x060003A8 RID: 936 RVA: 0x0001094E File Offset: 0x0000EB4E
		public static byte ToByte(int value)
		{
			if (value < 0 || value > 255)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 8-bit unsigned integer.</summary>
		/// <param name="value">The 32-bit unsigned integer to convert. </param>
		/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" />. </exception>
		// Token: 0x060003A9 RID: 937 RVA: 0x00010963 File Offset: 0x0000EB63
		[CLSCompliant(false)]
		public static byte ToByte(uint value)
		{
			if (value > 255U)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 8-bit unsigned integer.</summary>
		/// <param name="value">The 64-bit signed integer to convert. </param>
		/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
		// Token: 0x060003AA RID: 938 RVA: 0x00010974 File Offset: 0x0000EB74
		public static byte ToByte(long value)
		{
			if (value < 0L || value > 255L)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 8-bit unsigned integer.</summary>
		/// <param name="value">The 64-bit unsigned integer to convert. </param>
		/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" />. </exception>
		// Token: 0x060003AB RID: 939 RVA: 0x0001098B File Offset: 0x0000EB8B
		[CLSCompliant(false)]
		public static byte ToByte(ulong value)
		{
			if (value > 255UL)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 8-bit unsigned integer.</summary>
		/// <param name="value">A single-precision floating-point number. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 8-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" /> or less than <see cref="F:System.Byte.MinValue" />. </exception>
		// Token: 0x060003AC RID: 940 RVA: 0x0001099D File Offset: 0x0000EB9D
		public static byte ToByte(float value)
		{
			return Convert.ToByte((double)value);
		}

		/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 8-bit unsigned integer.</summary>
		/// <param name="value">The double-precision floating-point number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 8-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" /> or less than <see cref="F:System.Byte.MinValue" />. </exception>
		// Token: 0x060003AD RID: 941 RVA: 0x000109A6 File Offset: 0x0000EBA6
		public static byte ToByte(double value)
		{
			return Convert.ToByte(Convert.ToInt32(value));
		}

		/// <summary>Converts the value of the specified decimal number to an equivalent 8-bit unsigned integer.</summary>
		/// <param name="value">The number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 8-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" /> or less than <see cref="F:System.Byte.MinValue" />. </exception>
		// Token: 0x060003AE RID: 942 RVA: 0x000109B3 File Offset: 0x0000EBB3
		public static byte ToByte(decimal value)
		{
			return decimal.ToByte(decimal.Round(value, 0));
		}

		/// <summary>Converts the specified string representation of a number to an equivalent 8-bit unsigned integer.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
		// Token: 0x060003AF RID: 943 RVA: 0x000109C1 File Offset: 0x0000EBC1
		public static byte ToByte(string value)
		{
			if (value == null)
			{
				return 0;
			}
			return byte.Parse(value, CultureInfo.CurrentCulture);
		}

		/// <summary>Converts the specified string representation of a number to an equivalent 8-bit unsigned integer, using specified culture-specific formatting information.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
		// Token: 0x060003B0 RID: 944 RVA: 0x000109D3 File Offset: 0x0000EBD3
		public static byte ToByte(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0;
			}
			return byte.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>Converts the value of the specified object to a 16-bit signed integer, using the specified culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in an appropriate format for an <see cref="T:System.Int16" /> type.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement <see cref="T:System.IConvertible" />. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />.</exception>
		// Token: 0x060003B1 RID: 945 RVA: 0x000109E2 File Offset: 0x0000EBE2
		public static short ToInt16(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt16(provider);
			}
			return 0;
		}

		/// <summary>Converts the specified Boolean value to the equivalent 16-bit signed integer.</summary>
		/// <param name="value">The Boolean value to convert. </param>
		/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060003B2 RID: 946 RVA: 0x00010892 File Offset: 0x0000EA92
		public static short ToInt16(bool value)
		{
			if (!value)
			{
				return 0;
			}
			return 1;
		}

		/// <summary>Converts the value of the specified Unicode character to the equivalent 16-bit signed integer.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />. </returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" />. </exception>
		// Token: 0x060003B3 RID: 947 RVA: 0x000109F5 File Offset: 0x0000EBF5
		public static short ToInt16(char value)
		{
			if (value > '翿')
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 16-bit signed integer.</summary>
		/// <param name="value">The 8-bit signed integer to convert. </param>
		/// <returns>A 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003B4 RID: 948 RVA: 0x0000245A File Offset: 0x0000065A
		[CLSCompliant(false)]
		public static short ToInt16(sbyte value)
		{
			return (short)value;
		}

		/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 16-bit signed integer.</summary>
		/// <param name="value">The 8-bit unsigned integer to convert. </param>
		/// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003B5 RID: 949 RVA: 0x0000245A File Offset: 0x0000065A
		public static short ToInt16(byte value)
		{
			return (short)value;
		}

		/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 16-bit signed integer.</summary>
		/// <param name="value">The 16-bit unsigned integer to convert. </param>
		/// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" />. </exception>
		// Token: 0x060003B6 RID: 950 RVA: 0x000109F5 File Offset: 0x0000EBF5
		[CLSCompliant(false)]
		public static short ToInt16(ushort value)
		{
			if (value > 32767)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 16-bit signed integer.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <returns>The 16-bit signed integer equivalent of <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />. </exception>
		// Token: 0x060003B7 RID: 951 RVA: 0x00010A06 File Offset: 0x0000EC06
		public static short ToInt16(int value)
		{
			if (value < -32768 || value > 32767)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 16-bit signed integer.</summary>
		/// <param name="value">The 32-bit unsigned integer to convert. </param>
		/// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" />. </exception>
		// Token: 0x060003B8 RID: 952 RVA: 0x00010A1F File Offset: 0x0000EC1F
		[CLSCompliant(false)]
		public static short ToInt16(uint value)
		{
			if ((ulong)value > 32767UL)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 16-bit signed integer.</summary>
		/// <param name="value">The 64-bit signed integer to convert. </param>
		/// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />. </exception>
		// Token: 0x060003B9 RID: 953 RVA: 0x00010A32 File Offset: 0x0000EC32
		public static short ToInt16(long value)
		{
			if (value < -32768L || value > 32767L)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 16-bit signed integer.</summary>
		/// <param name="value">The 64-bit unsigned integer to convert. </param>
		/// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" />. </exception>
		// Token: 0x060003BA RID: 954 RVA: 0x00010A4D File Offset: 0x0000EC4D
		[CLSCompliant(false)]
		public static short ToInt16(ulong value)
		{
			if (value > 32767UL)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 16-bit signed integer.</summary>
		/// <param name="value">The single-precision floating-point number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 16-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />. </exception>
		// Token: 0x060003BB RID: 955 RVA: 0x00010A5F File Offset: 0x0000EC5F
		public static short ToInt16(float value)
		{
			return Convert.ToInt16((double)value);
		}

		/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 16-bit signed integer.</summary>
		/// <param name="value">The double-precision floating-point number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 16-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />. </exception>
		// Token: 0x060003BC RID: 956 RVA: 0x00010A68 File Offset: 0x0000EC68
		public static short ToInt16(double value)
		{
			return Convert.ToInt16(Convert.ToInt32(value));
		}

		/// <summary>Converts the value of the specified decimal number to an equivalent 16-bit signed integer.</summary>
		/// <param name="value">The decimal number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 16-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />. </exception>
		// Token: 0x060003BD RID: 957 RVA: 0x00010A75 File Offset: 0x0000EC75
		public static short ToInt16(decimal value)
		{
			return decimal.ToInt16(decimal.Round(value, 0));
		}

		/// <summary>Converts the specified string representation of a number to an equivalent 16-bit signed integer, using the specified culture-specific formatting information.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A 16-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />. </exception>
		// Token: 0x060003BE RID: 958 RVA: 0x00010A83 File Offset: 0x0000EC83
		public static short ToInt16(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0;
			}
			return short.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>Converts the value of the specified object to a 16-bit unsigned integer, using the specified culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in an appropriate format.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement the  <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x060003BF RID: 959 RVA: 0x00010A92 File Offset: 0x0000EC92
		[CLSCompliant(false)]
		public static ushort ToUInt16(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToUInt16(provider);
			}
			return 0;
		}

		/// <summary>Converts the specified Boolean value to the equivalent 16-bit unsigned integer.</summary>
		/// <param name="value">The Boolean value to convert. </param>
		/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060003C0 RID: 960 RVA: 0x00010892 File Offset: 0x0000EA92
		[CLSCompliant(false)]
		public static ushort ToUInt16(bool value)
		{
			if (!value)
			{
				return 0;
			}
			return 1;
		}

		/// <summary>Converts the value of the specified Unicode character to the equivalent 16-bit unsigned integer.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <returns>The 16-bit unsigned integer equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003C1 RID: 961 RVA: 0x0000245A File Offset: 0x0000065A
		[CLSCompliant(false)]
		public static ushort ToUInt16(char value)
		{
			return (ushort)value;
		}

		/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 16-bit unsigned integer.</summary>
		/// <param name="value">The 8-bit signed integer to convert. </param>
		/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero. </exception>
		// Token: 0x060003C2 RID: 962 RVA: 0x00010AA5 File Offset: 0x0000ECA5
		[CLSCompliant(false)]
		public static ushort ToUInt16(sbyte value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 16-bit unsigned integer.</summary>
		/// <param name="value">The 8-bit unsigned integer to convert. </param>
		/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003C3 RID: 963 RVA: 0x0000245A File Offset: 0x0000065A
		[CLSCompliant(false)]
		public static ushort ToUInt16(byte value)
		{
			return (ushort)value;
		}

		/// <summary>Converts the value of the specified 16-bit signed integer to the equivalent 16-bit unsigned integer.</summary>
		/// <param name="value">The 16-bit signed integer to convert. </param>
		/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero. </exception>
		// Token: 0x060003C4 RID: 964 RVA: 0x00010AA5 File Offset: 0x0000ECA5
		[CLSCompliant(false)]
		public static ushort ToUInt16(short value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 16-bit unsigned integer.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
		// Token: 0x060003C5 RID: 965 RVA: 0x00010AB2 File Offset: 0x0000ECB2
		[CLSCompliant(false)]
		public static ushort ToUInt16(int value)
		{
			if (value < 0 || value > 65535)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 16-bit unsigned integer.</summary>
		/// <param name="value">The 32-bit unsigned integer to convert. </param>
		/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
		// Token: 0x060003C6 RID: 966 RVA: 0x00010AC7 File Offset: 0x0000ECC7
		[CLSCompliant(false)]
		public static ushort ToUInt16(uint value)
		{
			if (value > 65535U)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 16-bit unsigned integer.</summary>
		/// <param name="value">The 64-bit signed integer to convert. </param>
		/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
		// Token: 0x060003C7 RID: 967 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		[CLSCompliant(false)]
		public static ushort ToUInt16(long value)
		{
			if (value < 0L || value > 65535L)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 16-bit unsigned integer.</summary>
		/// <param name="value">The 64-bit unsigned integer to convert. </param>
		/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
		// Token: 0x060003C8 RID: 968 RVA: 0x00010AEF File Offset: 0x0000ECEF
		[CLSCompliant(false)]
		public static ushort ToUInt16(ulong value)
		{
			if (value > 65535UL)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 16-bit unsigned integer.</summary>
		/// <param name="value">The single-precision floating-point number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 16-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
		// Token: 0x060003C9 RID: 969 RVA: 0x00010B01 File Offset: 0x0000ED01
		[CLSCompliant(false)]
		public static ushort ToUInt16(float value)
		{
			return Convert.ToUInt16((double)value);
		}

		/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 16-bit unsigned integer.</summary>
		/// <param name="value">The double-precision floating-point number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 16-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
		// Token: 0x060003CA RID: 970 RVA: 0x00010B0A File Offset: 0x0000ED0A
		[CLSCompliant(false)]
		public static ushort ToUInt16(double value)
		{
			return Convert.ToUInt16(Convert.ToInt32(value));
		}

		/// <summary>Converts the value of the specified decimal number to an equivalent 16-bit unsigned integer.</summary>
		/// <param name="value">The decimal number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 16-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
		// Token: 0x060003CB RID: 971 RVA: 0x00010B17 File Offset: 0x0000ED17
		[CLSCompliant(false)]
		public static ushort ToUInt16(decimal value)
		{
			return decimal.ToUInt16(decimal.Round(value, 0));
		}

		/// <summary>Converts the specified string representation of a number to an equivalent 16-bit unsigned integer, using the specified culture-specific formatting information.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A 16-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
		// Token: 0x060003CC RID: 972 RVA: 0x00010B25 File Offset: 0x0000ED25
		[CLSCompliant(false)]
		public static ushort ToUInt16(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0;
			}
			return ushort.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>Converts the value of the specified object to a 32-bit signed integer.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />. </param>
		/// <returns>A 32-bit signed integer equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in an appropriate format.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement the  <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x060003CD RID: 973 RVA: 0x00010B34 File Offset: 0x0000ED34
		public static int ToInt32(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt32(null);
			}
			return 0;
		}

		/// <summary>Converts the value of the specified object to a 32-bit signed integer, using the specified culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in an appropriate format.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement <see cref="T:System.IConvertible" />. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x060003CE RID: 974 RVA: 0x00010B47 File Offset: 0x0000ED47
		public static int ToInt32(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt32(provider);
			}
			return 0;
		}

		/// <summary>Converts the specified Boolean value to the equivalent 32-bit signed integer.</summary>
		/// <param name="value">The Boolean value to convert. </param>
		/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060003CF RID: 975 RVA: 0x00010892 File Offset: 0x0000EA92
		public static int ToInt32(bool value)
		{
			if (!value)
			{
				return 0;
			}
			return 1;
		}

		/// <summary>Converts the value of the specified Unicode character to the equivalent 32-bit signed integer.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003D0 RID: 976 RVA: 0x0000245A File Offset: 0x0000065A
		public static int ToInt32(char value)
		{
			return (int)value;
		}

		/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 32-bit signed integer.</summary>
		/// <param name="value">The 8-bit unsigned integer to convert. </param>
		/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003D1 RID: 977 RVA: 0x0000245A File Offset: 0x0000065A
		public static int ToInt32(byte value)
		{
			return (int)value;
		}

		/// <summary>Converts the value of the specified 16-bit signed integer to an equivalent 32-bit signed integer.</summary>
		/// <param name="value">The 16-bit signed integer to convert. </param>
		/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003D2 RID: 978 RVA: 0x0000245A File Offset: 0x0000065A
		public static int ToInt32(short value)
		{
			return (int)value;
		}

		/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 32-bit signed integer.</summary>
		/// <param name="value">The 16-bit unsigned integer to convert. </param>
		/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003D3 RID: 979 RVA: 0x0000245A File Offset: 0x0000065A
		[CLSCompliant(false)]
		public static int ToInt32(ushort value)
		{
			return (int)value;
		}

		/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 32-bit signed integer.</summary>
		/// <param name="value">The 32-bit unsigned integer to convert. </param>
		/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		// Token: 0x060003D4 RID: 980 RVA: 0x00010B5A File Offset: 0x0000ED5A
		[CLSCompliant(false)]
		public static int ToInt32(uint value)
		{
			if (value > 2147483647U)
			{
				Convert.ThrowInt32OverflowException();
			}
			return (int)value;
		}

		/// <summary>Returns the specified 32-bit signed integer; no actual conversion is performed.</summary>
		/// <param name="value">The 32-bit signed integer to return. </param>
		/// <returns>
		///     <paramref name="value" /> is returned unchanged.</returns>
		// Token: 0x060003D5 RID: 981 RVA: 0x0000245A File Offset: 0x0000065A
		public static int ToInt32(int value)
		{
			return value;
		}

		/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 32-bit signed integer.</summary>
		/// <param name="value">The 64-bit signed integer to convert. </param>
		/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" /> or less than <see cref="F:System.Int32.MinValue" />. </exception>
		// Token: 0x060003D6 RID: 982 RVA: 0x00010B6A File Offset: 0x0000ED6A
		public static int ToInt32(long value)
		{
			if (value < -2147483648L || value > 2147483647L)
			{
				Convert.ThrowInt32OverflowException();
			}
			return (int)value;
		}

		/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 32-bit signed integer.</summary>
		/// <param name="value">The 64-bit unsigned integer to convert. </param>
		/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		// Token: 0x060003D7 RID: 983 RVA: 0x00010B85 File Offset: 0x0000ED85
		[CLSCompliant(false)]
		public static int ToInt32(ulong value)
		{
			if (value > 2147483647UL)
			{
				Convert.ThrowInt32OverflowException();
			}
			return (int)value;
		}

		/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 32-bit signed integer.</summary>
		/// <param name="value">The single-precision floating-point number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 32-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" /> or less than <see cref="F:System.Int32.MinValue" />. </exception>
		// Token: 0x060003D8 RID: 984 RVA: 0x00010B97 File Offset: 0x0000ED97
		public static int ToInt32(float value)
		{
			return Convert.ToInt32((double)value);
		}

		/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 32-bit signed integer.</summary>
		/// <param name="value">The double-precision floating-point number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 32-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" /> or less than <see cref="F:System.Int32.MinValue" />. </exception>
		// Token: 0x060003D9 RID: 985 RVA: 0x00010BA0 File Offset: 0x0000EDA0
		public static int ToInt32(double value)
		{
			if (value >= 0.0)
			{
				if (value < 2147483647.5)
				{
					int num = (int)value;
					double num2 = value - (double)num;
					if (num2 > 0.5 || (num2 == 0.5 && (num & 1) != 0))
					{
						num++;
					}
					return num;
				}
			}
			else if (value >= -2147483648.5)
			{
				int num3 = (int)value;
				double num4 = value - (double)num3;
				if (num4 < -0.5 || (num4 == -0.5 && (num3 & 1) != 0))
				{
					num3--;
				}
				return num3;
			}
			throw new OverflowException("Value was either too large or too small for an Int32.");
		}

		/// <summary>Converts the value of the specified decimal number to an equivalent 32-bit signed integer.</summary>
		/// <param name="value">The decimal number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 32-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" /> or less than <see cref="F:System.Int32.MinValue" />. </exception>
		// Token: 0x060003DA RID: 986 RVA: 0x00010C31 File Offset: 0x0000EE31
		public static int ToInt32(decimal value)
		{
			return decimal.ToInt32(decimal.Round(value, 0));
		}

		/// <summary>Converts the specified string representation of a number to an equivalent 32-bit signed integer, using the specified culture-specific formatting information.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A 32-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		// Token: 0x060003DB RID: 987 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static int ToInt32(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0;
			}
			return int.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>Converts the value of the specified object to a 32-bit unsigned integer, using the specified culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in an appropriate format.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x060003DC RID: 988 RVA: 0x00010C4E File Offset: 0x0000EE4E
		[CLSCompliant(false)]
		public static uint ToUInt32(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToUInt32(provider);
			}
			return 0U;
		}

		/// <summary>Converts the specified Boolean value to the equivalent 32-bit unsigned integer.</summary>
		/// <param name="value">The Boolean value to convert. </param>
		/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060003DD RID: 989 RVA: 0x00010892 File Offset: 0x0000EA92
		[CLSCompliant(false)]
		public static uint ToUInt32(bool value)
		{
			if (!value)
			{
				return 0U;
			}
			return 1U;
		}

		/// <summary>Converts the value of the specified Unicode character to the equivalent 32-bit unsigned integer.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003DE RID: 990 RVA: 0x0000245A File Offset: 0x0000065A
		[CLSCompliant(false)]
		public static uint ToUInt32(char value)
		{
			return (uint)value;
		}

		/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 32-bit unsigned integer.</summary>
		/// <param name="value">The 8-bit signed integer to convert. </param>
		/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero. </exception>
		// Token: 0x060003DF RID: 991 RVA: 0x00010C61 File Offset: 0x0000EE61
		[CLSCompliant(false)]
		public static uint ToUInt32(sbyte value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt32OverflowException();
			}
			return (uint)value;
		}

		/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 32-bit unsigned integer.</summary>
		/// <param name="value">The 8-bit unsigned integer to convert. </param>
		/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003E0 RID: 992 RVA: 0x0000245A File Offset: 0x0000065A
		[CLSCompliant(false)]
		public static uint ToUInt32(byte value)
		{
			return (uint)value;
		}

		/// <summary>Converts the value of the specified 16-bit signed integer to the equivalent 32-bit unsigned integer.</summary>
		/// <param name="value">The 16-bit signed integer to convert. </param>
		/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero. </exception>
		// Token: 0x060003E1 RID: 993 RVA: 0x00010C61 File Offset: 0x0000EE61
		[CLSCompliant(false)]
		public static uint ToUInt32(short value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt32OverflowException();
			}
			return (uint)value;
		}

		/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 32-bit unsigned integer.</summary>
		/// <param name="value">The 16-bit unsigned integer to convert. </param>
		/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003E2 RID: 994 RVA: 0x0000245A File Offset: 0x0000065A
		[CLSCompliant(false)]
		public static uint ToUInt32(ushort value)
		{
			return (uint)value;
		}

		/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 32-bit unsigned integer.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero. </exception>
		// Token: 0x060003E3 RID: 995 RVA: 0x00010C61 File Offset: 0x0000EE61
		[CLSCompliant(false)]
		public static uint ToUInt32(int value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt32OverflowException();
			}
			return (uint)value;
		}

		/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 32-bit unsigned integer.</summary>
		/// <param name="value">The 64-bit signed integer to convert. </param>
		/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
		// Token: 0x060003E4 RID: 996 RVA: 0x00010C6D File Offset: 0x0000EE6D
		[CLSCompliant(false)]
		public static uint ToUInt32(long value)
		{
			if (value < 0L || value > (long)((ulong)-1))
			{
				Convert.ThrowUInt32OverflowException();
			}
			return (uint)value;
		}

		/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 32-bit unsigned integer.</summary>
		/// <param name="value">The 64-bit unsigned integer to convert. </param>
		/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
		// Token: 0x060003E5 RID: 997 RVA: 0x00010C80 File Offset: 0x0000EE80
		[CLSCompliant(false)]
		public static uint ToUInt32(ulong value)
		{
			if (value > (ulong)-1)
			{
				Convert.ThrowUInt32OverflowException();
			}
			return (uint)value;
		}

		/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 32-bit unsigned integer.</summary>
		/// <param name="value">The single-precision floating-point number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 32-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
		// Token: 0x060003E6 RID: 998 RVA: 0x00010C8E File Offset: 0x0000EE8E
		[CLSCompliant(false)]
		public static uint ToUInt32(float value)
		{
			return Convert.ToUInt32((double)value);
		}

		/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 32-bit unsigned integer.</summary>
		/// <param name="value">The double-precision floating-point number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 32-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
		// Token: 0x060003E7 RID: 999 RVA: 0x00010C98 File Offset: 0x0000EE98
		[CLSCompliant(false)]
		public static uint ToUInt32(double value)
		{
			if (value >= -0.5 && value < 4294967295.5)
			{
				uint num = (uint)value;
				double num2 = value - num;
				if (num2 > 0.5 || (num2 == 0.5 && (num & 1U) != 0U))
				{
					num += 1U;
				}
				return num;
			}
			throw new OverflowException("Value was either too large or too small for a UInt32.");
		}

		/// <summary>Converts the value of the specified decimal number to an equivalent 32-bit unsigned integer.</summary>
		/// <param name="value">The decimal number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 32-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
		// Token: 0x060003E8 RID: 1000 RVA: 0x00010CF3 File Offset: 0x0000EEF3
		[CLSCompliant(false)]
		public static uint ToUInt32(decimal value)
		{
			return decimal.ToUInt32(decimal.Round(value, 0));
		}

		/// <summary>Converts the specified string representation of a number to an equivalent 32-bit unsigned integer, using the specified culture-specific formatting information.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A 32-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
		// Token: 0x060003E9 RID: 1001 RVA: 0x00010D01 File Offset: 0x0000EF01
		[CLSCompliant(false)]
		public static uint ToUInt32(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0U;
			}
			return uint.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>Converts the value of the specified object to a 64-bit signed integer.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />. </param>
		/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in an appropriate format.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />.</exception>
		// Token: 0x060003EA RID: 1002 RVA: 0x00010D10 File Offset: 0x0000EF10
		public static long ToInt64(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt64(null);
			}
			return 0L;
		}

		/// <summary>Converts the value of the specified object to a 64-bit signed integer, using the specified culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in an appropriate format.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.-or-The conversion is not supported. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />.</exception>
		// Token: 0x060003EB RID: 1003 RVA: 0x00010D24 File Offset: 0x0000EF24
		public static long ToInt64(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt64(provider);
			}
			return 0L;
		}

		/// <summary>Converts the specified Boolean value to the equivalent 64-bit signed integer.</summary>
		/// <param name="value">The Boolean value to convert. </param>
		/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060003EC RID: 1004 RVA: 0x00010D38 File Offset: 0x0000EF38
		public static long ToInt64(bool value)
		{
			return value ? 1L : 0L;
		}

		/// <summary>Converts the value of the specified Unicode character to the equivalent 64-bit signed integer.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003ED RID: 1005 RVA: 0x00010D42 File Offset: 0x0000EF42
		public static long ToInt64(char value)
		{
			return (long)((ulong)value);
		}

		/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 64-bit signed integer.</summary>
		/// <param name="value">The 8-bit signed integer to convert. </param>
		/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003EE RID: 1006 RVA: 0x00010D46 File Offset: 0x0000EF46
		[CLSCompliant(false)]
		public static long ToInt64(sbyte value)
		{
			return (long)value;
		}

		/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 64-bit signed integer.</summary>
		/// <param name="value">The 8-bit unsigned integer to convert. </param>
		/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003EF RID: 1007 RVA: 0x00010D42 File Offset: 0x0000EF42
		public static long ToInt64(byte value)
		{
			return (long)((ulong)value);
		}

		/// <summary>Converts the value of the specified 16-bit signed integer to an equivalent 64-bit signed integer.</summary>
		/// <param name="value">The 16-bit signed integer to convert. </param>
		/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003F0 RID: 1008 RVA: 0x00010D46 File Offset: 0x0000EF46
		public static long ToInt64(short value)
		{
			return (long)value;
		}

		/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 64-bit signed integer.</summary>
		/// <param name="value">The 16-bit unsigned integer to convert. </param>
		/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003F1 RID: 1009 RVA: 0x00010D42 File Offset: 0x0000EF42
		[CLSCompliant(false)]
		public static long ToInt64(ushort value)
		{
			return (long)((ulong)value);
		}

		/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 64-bit signed integer.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003F2 RID: 1010 RVA: 0x00010D46 File Offset: 0x0000EF46
		public static long ToInt64(int value)
		{
			return (long)value;
		}

		/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 64-bit signed integer.</summary>
		/// <param name="value">The 32-bit unsigned integer to convert. </param>
		/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003F3 RID: 1011 RVA: 0x00010D42 File Offset: 0x0000EF42
		[CLSCompliant(false)]
		public static long ToInt64(uint value)
		{
			return (long)((ulong)value);
		}

		/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 64-bit signed integer.</summary>
		/// <param name="value">The 64-bit unsigned integer to convert. </param>
		/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int64.MaxValue" />. </exception>
		// Token: 0x060003F4 RID: 1012 RVA: 0x00010D4A File Offset: 0x0000EF4A
		[CLSCompliant(false)]
		public static long ToInt64(ulong value)
		{
			if (value > 9223372036854775807UL)
			{
				Convert.ThrowInt64OverflowException();
			}
			return (long)value;
		}

		/// <summary>Returns the specified 64-bit signed integer; no actual conversion is performed.</summary>
		/// <param name="value">A 64-bit signed integer. </param>
		/// <returns>
		///     <paramref name="value" /> is returned unchanged.</returns>
		// Token: 0x060003F5 RID: 1013 RVA: 0x0000245A File Offset: 0x0000065A
		public static long ToInt64(long value)
		{
			return value;
		}

		/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 64-bit signed integer.</summary>
		/// <param name="value">The single-precision floating-point number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 64-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int64.MaxValue" /> or less than <see cref="F:System.Int64.MinValue" />. </exception>
		// Token: 0x060003F6 RID: 1014 RVA: 0x00010D5E File Offset: 0x0000EF5E
		public static long ToInt64(float value)
		{
			return Convert.ToInt64((double)value);
		}

		/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 64-bit signed integer.</summary>
		/// <param name="value">The double-precision floating-point number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 64-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int64.MaxValue" /> or less than <see cref="F:System.Int64.MinValue" />. </exception>
		// Token: 0x060003F7 RID: 1015 RVA: 0x00010D67 File Offset: 0x0000EF67
		public static long ToInt64(double value)
		{
			return checked((long)Math.Round(value));
		}

		/// <summary>Converts the value of the specified decimal number to an equivalent 64-bit signed integer.</summary>
		/// <param name="value">The decimal number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 64-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Int64.MaxValue" /> or less than <see cref="F:System.Int64.MinValue" />. </exception>
		// Token: 0x060003F8 RID: 1016 RVA: 0x00010D70 File Offset: 0x0000EF70
		public static long ToInt64(decimal value)
		{
			return decimal.ToInt64(decimal.Round(value, 0));
		}

		/// <summary>Converts the specified string representation of a number to an equivalent 64-bit signed integer.</summary>
		/// <param name="value">A string that contains a number to convert. </param>
		/// <returns>A 64-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />. </exception>
		// Token: 0x060003F9 RID: 1017 RVA: 0x00010D7E File Offset: 0x0000EF7E
		public static long ToInt64(string value)
		{
			if (value == null)
			{
				return 0L;
			}
			return long.Parse(value, CultureInfo.CurrentCulture);
		}

		/// <summary>Converts the specified string representation of a number to an equivalent 64-bit signed integer, using the specified culture-specific formatting information.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A 64-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />. </exception>
		// Token: 0x060003FA RID: 1018 RVA: 0x00010D91 File Offset: 0x0000EF91
		public static long ToInt64(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0L;
			}
			return long.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>Converts the value of the specified object to a 64-bit unsigned integer, using the specified culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in an appropriate format.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
		// Token: 0x060003FB RID: 1019 RVA: 0x00010DA1 File Offset: 0x0000EFA1
		[CLSCompliant(false)]
		public static ulong ToUInt64(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToUInt64(provider);
			}
			return 0UL;
		}

		/// <summary>Converts the specified Boolean value to the equivalent 64-bit unsigned integer.</summary>
		/// <param name="value">The Boolean value to convert. </param>
		/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x060003FC RID: 1020 RVA: 0x00010DB5 File Offset: 0x0000EFB5
		[CLSCompliant(false)]
		public static ulong ToUInt64(bool value)
		{
			if (!value)
			{
				return 0UL;
			}
			return 1UL;
		}

		/// <summary>Converts the value of the specified Unicode character to the equivalent 64-bit unsigned integer.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003FD RID: 1021 RVA: 0x00010D42 File Offset: 0x0000EF42
		[CLSCompliant(false)]
		public static ulong ToUInt64(char value)
		{
			return (ulong)value;
		}

		/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 64-bit unsigned integer.</summary>
		/// <param name="value">The 8-bit signed integer to convert. </param>
		/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero. </exception>
		// Token: 0x060003FE RID: 1022 RVA: 0x00010DBF File Offset: 0x0000EFBF
		[CLSCompliant(false)]
		public static ulong ToUInt64(sbyte value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt64OverflowException();
			}
			return (ulong)((long)value);
		}

		/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 64-bit unsigned integer.</summary>
		/// <param name="value">The 8-bit unsigned integer to convert. </param>
		/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060003FF RID: 1023 RVA: 0x00010D42 File Offset: 0x0000EF42
		[CLSCompliant(false)]
		public static ulong ToUInt64(byte value)
		{
			return (ulong)value;
		}

		/// <summary>Converts the value of the specified 16-bit signed integer to the equivalent 64-bit unsigned integer.</summary>
		/// <param name="value">The 16-bit signed integer to convert. </param>
		/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero. </exception>
		// Token: 0x06000400 RID: 1024 RVA: 0x00010DBF File Offset: 0x0000EFBF
		[CLSCompliant(false)]
		public static ulong ToUInt64(short value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt64OverflowException();
			}
			return (ulong)((long)value);
		}

		/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 64-bit unsigned integer.</summary>
		/// <param name="value">The 16-bit unsigned integer to convert. </param>
		/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x06000401 RID: 1025 RVA: 0x00010D42 File Offset: 0x0000EF42
		[CLSCompliant(false)]
		public static ulong ToUInt64(ushort value)
		{
			return (ulong)value;
		}

		/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 64-bit unsigned integer.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero. </exception>
		// Token: 0x06000402 RID: 1026 RVA: 0x00010DBF File Offset: 0x0000EFBF
		[CLSCompliant(false)]
		public static ulong ToUInt64(int value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt64OverflowException();
			}
			return (ulong)((long)value);
		}

		/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 64-bit unsigned integer.</summary>
		/// <param name="value">The 32-bit unsigned integer to convert. </param>
		/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x06000403 RID: 1027 RVA: 0x00010D42 File Offset: 0x0000EF42
		[CLSCompliant(false)]
		public static ulong ToUInt64(uint value)
		{
			return (ulong)value;
		}

		/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 64-bit unsigned integer.</summary>
		/// <param name="value">The 64-bit signed integer to convert. </param>
		/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero. </exception>
		// Token: 0x06000404 RID: 1028 RVA: 0x00010DCC File Offset: 0x0000EFCC
		[CLSCompliant(false)]
		public static ulong ToUInt64(long value)
		{
			if (value < 0L)
			{
				Convert.ThrowUInt64OverflowException();
			}
			return (ulong)value;
		}

		/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 64-bit unsigned integer.</summary>
		/// <param name="value">The single-precision floating-point number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 64-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt64.MaxValue" />. </exception>
		// Token: 0x06000405 RID: 1029 RVA: 0x00010DD9 File Offset: 0x0000EFD9
		[CLSCompliant(false)]
		public static ulong ToUInt64(float value)
		{
			return Convert.ToUInt64((double)value);
		}

		/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 64-bit unsigned integer.</summary>
		/// <param name="value">The double-precision floating-point number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 64-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt64.MaxValue" />. </exception>
		// Token: 0x06000406 RID: 1030 RVA: 0x00010DE2 File Offset: 0x0000EFE2
		[CLSCompliant(false)]
		public static ulong ToUInt64(double value)
		{
			return checked((ulong)Math.Round(value));
		}

		/// <summary>Converts the value of the specified decimal number to an equivalent 64-bit unsigned integer.</summary>
		/// <param name="value">The decimal number to convert. </param>
		/// <returns>
		///     <paramref name="value" />, rounded to the nearest 64-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt64.MaxValue" />. </exception>
		// Token: 0x06000407 RID: 1031 RVA: 0x00010DEB File Offset: 0x0000EFEB
		[CLSCompliant(false)]
		public static ulong ToUInt64(decimal value)
		{
			return decimal.ToUInt64(decimal.Round(value, 0));
		}

		/// <summary>Converts the specified string representation of a number to an equivalent 64-bit unsigned integer, using the specified culture-specific formatting information.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A 64-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />. </exception>
		// Token: 0x06000408 RID: 1032 RVA: 0x00010DF9 File Offset: 0x0000EFF9
		[CLSCompliant(false)]
		public static ulong ToUInt64(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0UL;
			}
			return ulong.Parse(value, NumberStyles.Integer, provider);
		}

		/// <summary>Converts the value of the specified object to an single-precision floating-point number, using the specified culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in an appropriate format.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement <see cref="T:System.IConvertible" />. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />.</exception>
		// Token: 0x06000409 RID: 1033 RVA: 0x00010E09 File Offset: 0x0000F009
		public static float ToSingle(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToSingle(provider);
			}
			return 0f;
		}

		/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent single-precision floating-point number.</summary>
		/// <param name="value">The 8-bit signed integer to convert. </param>
		/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600040A RID: 1034 RVA: 0x00010E20 File Offset: 0x0000F020
		[CLSCompliant(false)]
		public static float ToSingle(sbyte value)
		{
			return (float)value;
		}

		/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent single-precision floating-point number.</summary>
		/// <param name="value">The 8-bit unsigned integer to convert. </param>
		/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600040B RID: 1035 RVA: 0x00010E20 File Offset: 0x0000F020
		public static float ToSingle(byte value)
		{
			return (float)value;
		}

		/// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
		// Token: 0x0600040C RID: 1036 RVA: 0x00010E24 File Offset: 0x0000F024
		public static float ToSingle(char value)
		{
			return ((IConvertible)value).ToSingle(null);
		}

		/// <summary>Converts the value of the specified 16-bit signed integer to an equivalent single-precision floating-point number.</summary>
		/// <param name="value">The 16-bit signed integer to convert. </param>
		/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600040D RID: 1037 RVA: 0x00010E20 File Offset: 0x0000F020
		public static float ToSingle(short value)
		{
			return (float)value;
		}

		/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent single-precision floating-point number.</summary>
		/// <param name="value">The 16-bit unsigned integer to convert. </param>
		/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600040E RID: 1038 RVA: 0x00010E20 File Offset: 0x0000F020
		[CLSCompliant(false)]
		public static float ToSingle(ushort value)
		{
			return (float)value;
		}

		/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent single-precision floating-point number.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600040F RID: 1039 RVA: 0x00010E20 File Offset: 0x0000F020
		public static float ToSingle(int value)
		{
			return (float)value;
		}

		/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent single-precision floating-point number.</summary>
		/// <param name="value">The 32-bit unsigned integer to convert. </param>
		/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x06000410 RID: 1040 RVA: 0x00010E32 File Offset: 0x0000F032
		[CLSCompliant(false)]
		public static float ToSingle(uint value)
		{
			return value;
		}

		/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent single-precision floating-point number.</summary>
		/// <param name="value">The 64-bit signed integer to convert. </param>
		/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x06000411 RID: 1041 RVA: 0x00010E20 File Offset: 0x0000F020
		public static float ToSingle(long value)
		{
			return (float)value;
		}

		/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent single-precision floating-point number.</summary>
		/// <param name="value">The 64-bit unsigned integer to convert. </param>
		/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x06000412 RID: 1042 RVA: 0x00010E32 File Offset: 0x0000F032
		[CLSCompliant(false)]
		public static float ToSingle(ulong value)
		{
			return value;
		}

		/// <summary>Returns the specified single-precision floating-point number; no actual conversion is performed.</summary>
		/// <param name="value">The single-precision floating-point number to return. </param>
		/// <returns>
		///     <paramref name="value" /> is returned unchanged.</returns>
		// Token: 0x06000413 RID: 1043 RVA: 0x0000245A File Offset: 0x0000065A
		public static float ToSingle(float value)
		{
			return value;
		}

		/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent single-precision floating-point number.</summary>
		/// <param name="value">The double-precision floating-point number to convert. </param>
		/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.
		///     <paramref name="value" /> is rounded using rounding to nearest. For example, when rounded to two decimals, the value 2.345 becomes 2.34 and the value 2.355 becomes 2.36.</returns>
		// Token: 0x06000414 RID: 1044 RVA: 0x00010E20 File Offset: 0x0000F020
		public static float ToSingle(double value)
		{
			return (float)value;
		}

		/// <summary>Converts the value of the specified decimal number to an equivalent single-precision floating-point number.</summary>
		/// <param name="value">The decimal number to convert. </param>
		/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.
		///     <paramref name="value" /> is rounded using rounding to nearest. For example, when rounded to two decimals, the value 2.345 becomes 2.34 and the value 2.355 becomes 2.36.</returns>
		// Token: 0x06000415 RID: 1045 RVA: 0x00010E37 File Offset: 0x0000F037
		public static float ToSingle(decimal value)
		{
			return (float)value;
		}

		/// <summary>Converts the specified string representation of a number to an equivalent single-precision floating-point number, using the specified culture-specific formatting information.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A single-precision floating-point number that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not a number in a valid format.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />. </exception>
		// Token: 0x06000416 RID: 1046 RVA: 0x00010E40 File Offset: 0x0000F040
		public static float ToSingle(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0f;
			}
			return float.Parse(value, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider);
		}

		/// <summary>Converts the specified Boolean value to the equivalent single-precision floating-point number.</summary>
		/// <param name="value">The Boolean value to convert. </param>
		/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x06000417 RID: 1047 RVA: 0x00010E57 File Offset: 0x0000F057
		public static float ToSingle(bool value)
		{
			return (float)(value ? 1 : 0);
		}

		/// <summary>Converts the value of the specified object to a double-precision floating-point number.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />. </param>
		/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in an appropriate format for a <see cref="T:System.Double" /> type.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception>
		// Token: 0x06000418 RID: 1048 RVA: 0x00010E61 File Offset: 0x0000F061
		public static double ToDouble(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDouble(null);
			}
			return 0.0;
		}

		/// <summary>Converts the value of the specified object to an double-precision floating-point number, using the specified culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in an appropriate format for a <see cref="T:System.Double" /> type.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception>
		// Token: 0x06000419 RID: 1049 RVA: 0x00010E7C File Offset: 0x0000F07C
		public static double ToDouble(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDouble(provider);
			}
			return 0.0;
		}

		/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent double-precision floating-point number.</summary>
		/// <param name="value">The 8-bit signed integer to convert. </param>
		/// <returns>The 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600041A RID: 1050 RVA: 0x00010E97 File Offset: 0x0000F097
		[CLSCompliant(false)]
		public static double ToDouble(sbyte value)
		{
			return (double)value;
		}

		/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent double-precision floating-point number.</summary>
		/// <param name="value">The 8-bit unsigned integer to convert. </param>
		/// <returns>The double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600041B RID: 1051 RVA: 0x00010E97 File Offset: 0x0000F097
		public static double ToDouble(byte value)
		{
			return (double)value;
		}

		/// <summary>Converts the value of the specified 16-bit signed integer to an equivalent double-precision floating-point number.</summary>
		/// <param name="value">The 16-bit signed integer to convert. </param>
		/// <returns>A double-precision floating-point number equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600041C RID: 1052 RVA: 0x00010E97 File Offset: 0x0000F097
		public static double ToDouble(short value)
		{
			return (double)value;
		}

		/// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
		// Token: 0x0600041D RID: 1053 RVA: 0x00010E9B File Offset: 0x0000F09B
		public static double ToDouble(char value)
		{
			return ((IConvertible)value).ToDouble(null);
		}

		/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent double-precision floating-point number.</summary>
		/// <param name="value">The 16-bit unsigned integer to convert. </param>
		/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600041E RID: 1054 RVA: 0x00010E97 File Offset: 0x0000F097
		[CLSCompliant(false)]
		public static double ToDouble(ushort value)
		{
			return (double)value;
		}

		/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent double-precision floating-point number.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600041F RID: 1055 RVA: 0x00010E97 File Offset: 0x0000F097
		public static double ToDouble(int value)
		{
			return (double)value;
		}

		/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent double-precision floating-point number.</summary>
		/// <param name="value">The 32-bit unsigned integer to convert. </param>
		/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x06000420 RID: 1056 RVA: 0x00010EA9 File Offset: 0x0000F0A9
		[CLSCompliant(false)]
		public static double ToDouble(uint value)
		{
			return value;
		}

		/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent double-precision floating-point number.</summary>
		/// <param name="value">The 64-bit signed integer to convert. </param>
		/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x06000421 RID: 1057 RVA: 0x00010E97 File Offset: 0x0000F097
		public static double ToDouble(long value)
		{
			return (double)value;
		}

		/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent double-precision floating-point number.</summary>
		/// <param name="value">The 64-bit unsigned integer to convert. </param>
		/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x06000422 RID: 1058 RVA: 0x00010EA9 File Offset: 0x0000F0A9
		[CLSCompliant(false)]
		public static double ToDouble(ulong value)
		{
			return value;
		}

		/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent double-precision floating-point number.</summary>
		/// <param name="value">The single-precision floating-point number. </param>
		/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x06000423 RID: 1059 RVA: 0x00010E97 File Offset: 0x0000F097
		public static double ToDouble(float value)
		{
			return (double)value;
		}

		/// <summary>Returns the specified double-precision floating-point number; no actual conversion is performed.</summary>
		/// <param name="value">The double-precision floating-point number to return. </param>
		/// <returns>
		///     <paramref name="value" /> is returned unchanged.</returns>
		// Token: 0x06000424 RID: 1060 RVA: 0x0000245A File Offset: 0x0000065A
		public static double ToDouble(double value)
		{
			return value;
		}

		/// <summary>Converts the value of the specified decimal number to an equivalent double-precision floating-point number.</summary>
		/// <param name="value">The decimal number to convert. </param>
		/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x06000425 RID: 1061 RVA: 0x00010EAE File Offset: 0x0000F0AE
		public static double ToDouble(decimal value)
		{
			return (double)value;
		}

		/// <summary>Converts the specified string representation of a number to an equivalent double-precision floating-point number, using the specified culture-specific formatting information.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A double-precision floating-point number that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not a number in a valid format.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception>
		// Token: 0x06000426 RID: 1062 RVA: 0x00010EB7 File Offset: 0x0000F0B7
		public static double ToDouble(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0.0;
			}
			return double.Parse(value, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider);
		}

		/// <summary>Converts the specified Boolean value to the equivalent double-precision floating-point number.</summary>
		/// <param name="value">The Boolean value to convert. </param>
		/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x06000427 RID: 1063 RVA: 0x00010ED2 File Offset: 0x0000F0D2
		public static double ToDouble(bool value)
		{
			return (double)(value ? 1 : 0);
		}

		/// <summary>Converts the value of the specified object to an equivalent decimal number, using the specified culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A decimal number that is equivalent to <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not in an appropriate format for a <see cref="T:System.Decimal" /> type.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.-or-The conversion is not supported. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
		// Token: 0x06000428 RID: 1064 RVA: 0x00010EDC File Offset: 0x0000F0DC
		public static decimal ToDecimal(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDecimal(provider);
			}
			return 0m;
		}

		/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent decimal number.</summary>
		/// <param name="value">The 8-bit signed integer to convert. </param>
		/// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x06000429 RID: 1065 RVA: 0x00010EF3 File Offset: 0x0000F0F3
		[CLSCompliant(false)]
		public static decimal ToDecimal(sbyte value)
		{
			return value;
		}

		/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent decimal number.</summary>
		/// <param name="value">The 8-bit unsigned integer to convert. </param>
		/// <returns>The decimal number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600042A RID: 1066 RVA: 0x00010EFB File Offset: 0x0000F0FB
		public static decimal ToDecimal(byte value)
		{
			return value;
		}

		/// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
		// Token: 0x0600042B RID: 1067 RVA: 0x00010F03 File Offset: 0x0000F103
		public static decimal ToDecimal(char value)
		{
			return ((IConvertible)value).ToDecimal(null);
		}

		/// <summary>Converts the value of the specified 16-bit signed integer to an equivalent decimal number.</summary>
		/// <param name="value">The 16-bit signed integer to convert. </param>
		/// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600042C RID: 1068 RVA: 0x00010F11 File Offset: 0x0000F111
		public static decimal ToDecimal(short value)
		{
			return value;
		}

		/// <summary>Converts the value of the specified 16-bit unsigned integer to an equivalent decimal number.</summary>
		/// <param name="value">The 16-bit unsigned integer to convert. </param>
		/// <returns>The decimal number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600042D RID: 1069 RVA: 0x00010F19 File Offset: 0x0000F119
		[CLSCompliant(false)]
		public static decimal ToDecimal(ushort value)
		{
			return value;
		}

		/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent decimal number.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600042E RID: 1070 RVA: 0x00010F21 File Offset: 0x0000F121
		public static decimal ToDecimal(int value)
		{
			return value;
		}

		/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent decimal number.</summary>
		/// <param name="value">The 32-bit unsigned integer to convert. </param>
		/// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x0600042F RID: 1071 RVA: 0x00010F29 File Offset: 0x0000F129
		[CLSCompliant(false)]
		public static decimal ToDecimal(uint value)
		{
			return value;
		}

		/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent decimal number.</summary>
		/// <param name="value">The 64-bit signed integer to convert. </param>
		/// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x06000430 RID: 1072 RVA: 0x00010F31 File Offset: 0x0000F131
		public static decimal ToDecimal(long value)
		{
			return value;
		}

		/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent decimal number.</summary>
		/// <param name="value">The 64-bit unsigned integer to convert. </param>
		/// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
		// Token: 0x06000431 RID: 1073 RVA: 0x00010F39 File Offset: 0x0000F139
		[CLSCompliant(false)]
		public static decimal ToDecimal(ulong value)
		{
			return value;
		}

		/// <summary>Converts the value of the specified single-precision floating-point number to the equivalent decimal number.</summary>
		/// <param name="value">The single-precision floating-point number to convert. </param>
		/// <returns>A decimal number that is equivalent to <paramref name="value" />. </returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />.</exception>
		// Token: 0x06000432 RID: 1074 RVA: 0x00010F41 File Offset: 0x0000F141
		public static decimal ToDecimal(float value)
		{
			return (decimal)value;
		}

		/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent decimal number.</summary>
		/// <param name="value">The double-precision floating-point number to convert. </param>
		/// <returns>A decimal number that is equivalent to <paramref name="value" />. </returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />. </exception>
		// Token: 0x06000433 RID: 1075 RVA: 0x00010F49 File Offset: 0x0000F149
		public static decimal ToDecimal(double value)
		{
			return (decimal)value;
		}

		/// <summary>Converts the specified string representation of a number to an equivalent decimal number, using the specified culture-specific formatting information.</summary>
		/// <param name="value">A string that contains a number to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>A decimal number that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not a number in a valid format.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		// Token: 0x06000434 RID: 1076 RVA: 0x00010F51 File Offset: 0x0000F151
		public static decimal ToDecimal(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0m;
			}
			return decimal.Parse(value, NumberStyles.Number, provider);
		}

		/// <summary>Converts the specified Boolean value to the equivalent decimal number.</summary>
		/// <param name="value">The Boolean value to convert. </param>
		/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
		// Token: 0x06000435 RID: 1077 RVA: 0x00010F65 File Offset: 0x0000F165
		public static decimal ToDecimal(bool value)
		{
			return value ? 1 : 0;
		}

		/// <summary>Converts the value of the specified object to a <see cref="T:System.DateTime" /> object, using the specified culture-specific formatting information.</summary>
		/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>The date and time equivalent of the value of <paramref name="value" />, or the date and time equivalent of <see cref="F:System.DateTime.MinValue" /> if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not a valid date and time value.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///         <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
		// Token: 0x06000436 RID: 1078 RVA: 0x00010F73 File Offset: 0x0000F173
		public static DateTime ToDateTime(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDateTime(provider);
			}
			return DateTime.MinValue;
		}

		/// <summary>Converts the specified string representation of a number to an equivalent date and time, using the specified culture-specific formatting information.</summary>
		/// <param name="value">A string that contains a date and time to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>The date and time equivalent of the value of <paramref name="value" />, or the date and time equivalent of <see cref="F:System.DateTime.MinValue" /> if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not a properly formatted date and time string. </exception>
		// Token: 0x06000437 RID: 1079 RVA: 0x00010F8A File Offset: 0x0000F18A
		public static DateTime ToDateTime(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return new DateTime(0L);
			}
			return DateTime.Parse(value, provider);
		}

		/// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
		// Token: 0x06000438 RID: 1080 RVA: 0x00010F9E File Offset: 0x0000F19E
		public static DateTime ToDateTime(int value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">The 64-bit signed integer to convert. </param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
		// Token: 0x06000439 RID: 1081 RVA: 0x00010FAC File Offset: 0x0000F1AC
		public static DateTime ToDateTime(long value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">The Boolean value to convert. </param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
		// Token: 0x0600043A RID: 1082 RVA: 0x00010FBA File Offset: 0x0000F1BA
		public static DateTime ToDateTime(bool value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
		// Token: 0x0600043B RID: 1083 RVA: 0x00010FC8 File Offset: 0x0000F1C8
		public static DateTime ToDateTime(char value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">The single-precision floating-point value to convert. </param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
		// Token: 0x0600043C RID: 1084 RVA: 0x00010FD6 File Offset: 0x0000F1D6
		public static DateTime ToDateTime(float value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="value">The double-precision floating-point value to convert. </param>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
		// Token: 0x0600043D RID: 1085 RVA: 0x00010FE4 File Offset: 0x0000F1E4
		public static DateTime ToDateTime(double value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		/// <summary>Converts the value of the specified object to its equivalent string representation using the specified culture-specific formatting information.</summary>
		/// <param name="value">An object that supplies the value to convert, or <see langword="null" />. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>The string representation of <paramref name="value" />, or <see cref="F:System.String.Empty" /> if <paramref name="value" /> is an object whose value is <see langword="null" />. If <paramref name="value" /> is <see langword="null" />, the method returns <see langword="null" />. </returns>
		// Token: 0x0600043E RID: 1086 RVA: 0x00010FF4 File Offset: 0x0000F1F4
		public static string ToString(object value, IFormatProvider provider)
		{
			IConvertible convertible = value as IConvertible;
			if (convertible != null)
			{
				return convertible.ToString(provider);
			}
			IFormattable formattable = value as IFormattable;
			if (formattable != null)
			{
				return formattable.ToString(null, provider);
			}
			if (value != null)
			{
				return value.ToString();
			}
			return string.Empty;
		}

		/// <summary>Converts the specified Boolean value to its equivalent string representation.</summary>
		/// <param name="value">The Boolean value to convert. </param>
		/// <returns>The string representation of <paramref name="value" />.</returns>
		// Token: 0x0600043F RID: 1087 RVA: 0x00011035 File Offset: 0x0000F235
		public static string ToString(bool value)
		{
			return value.ToString();
		}

		/// <summary>Converts the value of the specified Unicode character to its equivalent string representation.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <returns>The string representation of <paramref name="value" />.</returns>
		// Token: 0x06000440 RID: 1088 RVA: 0x0001103E File Offset: 0x0000F23E
		public static string ToString(char value)
		{
			return char.ToString(value);
		}

		/// <summary>Converts the value of the specified Unicode character to its equivalent string representation, using the specified culture-specific formatting information.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. This parameter is ignored. </param>
		/// <returns>The string representation of <paramref name="value" />.</returns>
		// Token: 0x06000441 RID: 1089 RVA: 0x00011046 File Offset: 0x0000F246
		public static string ToString(char value, IFormatProvider provider)
		{
			return value.ToString();
		}

		/// <summary>Converts the value of the specified 32-bit signed integer to its equivalent string representation.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <returns>The string representation of <paramref name="value" />.</returns>
		// Token: 0x06000442 RID: 1090 RVA: 0x0001104F File Offset: 0x0000F24F
		public static string ToString(int value)
		{
			return value.ToString(CultureInfo.CurrentCulture);
		}

		/// <summary>Converts the value of the specified 32-bit signed integer to its equivalent string representation, using the specified culture-specific formatting information.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>The string representation of <paramref name="value" />.</returns>
		// Token: 0x06000443 RID: 1091 RVA: 0x0001105D File Offset: 0x0000F25D
		public static string ToString(int value, IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		/// <summary>Converts the value of the specified 64-bit signed integer to its equivalent string representation.</summary>
		/// <param name="value">The 64-bit signed integer to convert. </param>
		/// <returns>The string representation of <paramref name="value" />.</returns>
		// Token: 0x06000444 RID: 1092 RVA: 0x00011067 File Offset: 0x0000F267
		public static string ToString(long value)
		{
			return value.ToString(CultureInfo.CurrentCulture);
		}

		/// <summary>Converts the value of the specified single-precision floating-point number to its equivalent string representation.</summary>
		/// <param name="value">The single-precision floating-point number to convert. </param>
		/// <returns>The string representation of <paramref name="value" />.</returns>
		// Token: 0x06000445 RID: 1093 RVA: 0x00011075 File Offset: 0x0000F275
		public static string ToString(float value)
		{
			return value.ToString(CultureInfo.CurrentCulture);
		}

		/// <summary>Converts the value of the specified double-precision floating-point number to its equivalent string representation.</summary>
		/// <param name="value">The double-precision floating-point number to convert. </param>
		/// <returns>The string representation of <paramref name="value" />.</returns>
		// Token: 0x06000446 RID: 1094 RVA: 0x00011083 File Offset: 0x0000F283
		public static string ToString(double value)
		{
			return value.ToString(CultureInfo.CurrentCulture);
		}

		/// <summary>Converts the string representation of a number in a specified base to an equivalent 8-bit unsigned integer.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
		/// <returns>An 8-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-
		///         <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" />, which represents a base 10 unsigned number, is prefixed with a negative sign.-or-
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x06000447 RID: 1095 RVA: 0x00011094 File Offset: 0x0000F294
		public static byte ToByte(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0;
			}
			int num = ParseNumbers.StringToInt(value.AsSpan(), fromBase, 4608);
			if (num < 0 || num > 255)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)num;
		}

		/// <summary>Converts the string representation of a number in a specified base to an equivalent 8-bit signed integer.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
		/// <returns>An 8-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-
		///         <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.-or-
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />.</exception>
		// Token: 0x06000448 RID: 1096 RVA: 0x000110E8 File Offset: 0x0000F2E8
		[CLSCompliant(false)]
		public static sbyte ToSByte(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0;
			}
			int num = ParseNumbers.StringToInt(value.AsSpan(), fromBase, 5120);
			if (fromBase != 10 && num <= 255)
			{
				return (sbyte)num;
			}
			if (num < -128 || num > 127)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)num;
		}

		/// <summary>Converts the string representation of a number in a specified base to an equivalent 16-bit signed integer.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
		/// <returns>A 16-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-
		///         <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.-or-
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />.</exception>
		// Token: 0x06000449 RID: 1097 RVA: 0x0001114C File Offset: 0x0000F34C
		public static short ToInt16(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0;
			}
			int num = ParseNumbers.StringToInt(value.AsSpan(), fromBase, 6144);
			if (fromBase != 10 && num <= 65535)
			{
				return (short)num;
			}
			if (num < -32768 || num > 32767)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)num;
		}

		/// <summary>Converts the string representation of a number in a specified base to an equivalent 16-bit unsigned integer.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
		/// <returns>A 16-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-
		///         <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign.-or-
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x0600044A RID: 1098 RVA: 0x000111B4 File Offset: 0x0000F3B4
		[CLSCompliant(false)]
		public static ushort ToUInt16(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0;
			}
			int num = ParseNumbers.StringToInt(value.AsSpan(), fromBase, 4608);
			if (num < 0 || num > 65535)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)num;
		}

		/// <summary>Converts the string representation of a number in a specified base to an equivalent 32-bit signed integer.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
		/// <returns>A 32-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-
		///         <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.-or-
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x0600044B RID: 1099 RVA: 0x00011208 File Offset: 0x0000F408
		public static int ToInt32(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0;
			}
			return ParseNumbers.StringToInt(value.AsSpan(), fromBase, 4096);
		}

		/// <summary>Converts the string representation of a number in a specified base to an equivalent 32-bit unsigned integer.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
		/// <returns>A 32-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-
		///         <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign.-or-
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x0600044C RID: 1100 RVA: 0x0001123D File Offset: 0x0000F43D
		[CLSCompliant(false)]
		public static uint ToUInt32(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0U;
			}
			return (uint)ParseNumbers.StringToInt(value.AsSpan(), fromBase, 4608);
		}

		/// <summary>Converts the string representation of a number in a specified base to an equivalent 64-bit signed integer.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
		/// <returns>A 64-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-
		///         <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.-or-
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />.</exception>
		// Token: 0x0600044D RID: 1101 RVA: 0x00011272 File Offset: 0x0000F472
		public static long ToInt64(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0L;
			}
			return ParseNumbers.StringToLong(value.AsSpan(), fromBase, 4096);
		}

		/// <summary>Converts the string representation of a number in a specified base to an equivalent 64-bit unsigned integer.</summary>
		/// <param name="value">A string that contains the number to convert. </param>
		/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
		/// <returns>A 64-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-
		///         <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign.-or-
		///         <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
		// Token: 0x0600044E RID: 1102 RVA: 0x000112A8 File Offset: 0x0000F4A8
		[CLSCompliant(false)]
		public static ulong ToUInt64(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				throw new ArgumentException("Invalid Base.");
			}
			if (value == null)
			{
				return 0UL;
			}
			return (ulong)ParseNumbers.StringToLong(value.AsSpan(), fromBase, 4608);
		}

		/// <summary>Converts an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits.</summary>
		/// <param name="inArray">An array of 8-bit unsigned integers. </param>
		/// <returns>The string representation, in base 64, of the contents of <paramref name="inArray" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="inArray" /> is <see langword="null" />. </exception>
		// Token: 0x0600044F RID: 1103 RVA: 0x000112DE File Offset: 0x0000F4DE
		public static string ToBase64String(byte[] inArray)
		{
			if (inArray == null)
			{
				throw new ArgumentNullException("inArray");
			}
			return Convert.ToBase64String(new ReadOnlySpan<byte>(inArray), Base64FormattingOptions.None);
		}

		/// <summary>Converts a subset of an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits. Parameters specify the subset as an offset in the input array, and the number of elements in the array to convert.</summary>
		/// <param name="inArray">An array of 8-bit unsigned integers. </param>
		/// <param name="offset">An offset in <paramref name="inArray" />. </param>
		/// <param name="length">The number of elements of <paramref name="inArray" /> to convert. </param>
		/// <returns>The string representation in base 64 of <paramref name="length" /> elements of <paramref name="inArray" />, starting at position <paramref name="offset" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="inArray" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> or <paramref name="length" /> is negative.-or- 
		///         <paramref name="offset" /> plus <paramref name="length" /> is greater than the length of <paramref name="inArray" />. </exception>
		// Token: 0x06000450 RID: 1104 RVA: 0x000112FA File Offset: 0x0000F4FA
		public static string ToBase64String(byte[] inArray, int offset, int length)
		{
			return Convert.ToBase64String(inArray, offset, length, Base64FormattingOptions.None);
		}

		/// <summary>Converts a subset of an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits. Parameters specify the subset as an offset in the input array, the number of elements in the array to convert, and whether to insert line breaks in the return value.</summary>
		/// <param name="inArray">An array of 8-bit unsigned integers. </param>
		/// <param name="offset">An offset in <paramref name="inArray" />. </param>
		/// <param name="length">The number of elements of <paramref name="inArray" /> to convert. </param>
		/// <param name="options">
		///       <see cref="F:System.Base64FormattingOptions.InsertLineBreaks" /> to insert a line break every 76 characters, or <see cref="F:System.Base64FormattingOptions.None" /> to not insert line breaks.</param>
		/// <returns>The string representation in base 64 of <paramref name="length" /> elements of <paramref name="inArray" />, starting at position <paramref name="offset" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="inArray" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> or <paramref name="length" /> is negative.-or- 
		///         <paramref name="offset" /> plus <paramref name="length" /> is greater than the length of <paramref name="inArray" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="options" /> is not a valid <see cref="T:System.Base64FormattingOptions" /> value. </exception>
		// Token: 0x06000451 RID: 1105 RVA: 0x00011308 File Offset: 0x0000F508
		public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options)
		{
			if (inArray == null)
			{
				throw new ArgumentNullException("inArray");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Value must be positive.");
			}
			if (offset > inArray.Length - length)
			{
				throw new ArgumentOutOfRangeException("offset", "Offset and length must refer to a position in the string.");
			}
			return Convert.ToBase64String(new ReadOnlySpan<byte>(inArray, offset, length), options);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00011374 File Offset: 0x0000F574
		public unsafe static string ToBase64String(ReadOnlySpan<byte> bytes, Base64FormattingOptions options = Base64FormattingOptions.None)
		{
			if (options < Base64FormattingOptions.None || options > Base64FormattingOptions.InsertLineBreaks)
			{
				throw new ArgumentException(string.Format("Illegal enum value: {0}.", (int)options), "options");
			}
			if (bytes.Length == 0)
			{
				return string.Empty;
			}
			bool insertLineBreaks = options == Base64FormattingOptions.InsertLineBreaks;
			string text = string.FastAllocateString(Convert.ToBase64_CalculateAndValidateOutputLength(bytes.Length, insertLineBreaks));
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				byte* inData = reference;
				fixed (string text2 = text)
				{
					char* ptr = text2;
					if (ptr != null)
					{
						ptr += RuntimeHelpers.OffsetToStringData / 2;
					}
					Convert.ConvertToBase64Array(ptr, inData, 0, bytes.Length, insertLineBreaks);
				}
			}
			return text;
		}

		/// <summary>Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array encoded with base-64 digits. Parameters specify the subsets as offsets in the input and output arrays, and the number of elements in the input array to convert.</summary>
		/// <param name="inArray">An input array of 8-bit unsigned integers. </param>
		/// <param name="offsetIn">A position within <paramref name="inArray" />. </param>
		/// <param name="length">The number of elements of <paramref name="inArray" /> to convert. </param>
		/// <param name="outArray">An output array of Unicode characters. </param>
		/// <param name="offsetOut">A position within <paramref name="outArray" />. </param>
		/// <returns>A 32-bit signed integer containing the number of bytes in <paramref name="outArray" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="inArray" /> or <paramref name="outArray" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offsetIn" />, <paramref name="offsetOut" />, or <paramref name="length" /> is negative.-or- 
		///         <paramref name="offsetIn" /> plus <paramref name="length" /> is greater than the length of <paramref name="inArray" />.-or- 
		///         <paramref name="offsetOut" /> plus the number of elements to return is greater than the length of <paramref name="outArray" />. </exception>
		// Token: 0x06000453 RID: 1107 RVA: 0x000113FD File Offset: 0x0000F5FD
		public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut)
		{
			return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut, Base64FormattingOptions.None);
		}

		/// <summary>Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array encoded with base-64 digits. Parameters specify the subsets as offsets in the input and output arrays, the number of elements in the input array to convert, and whether line breaks are inserted in the output array.</summary>
		/// <param name="inArray">An input array of 8-bit unsigned integers. </param>
		/// <param name="offsetIn">A position within <paramref name="inArray" />. </param>
		/// <param name="length">The number of elements of <paramref name="inArray" /> to convert. </param>
		/// <param name="outArray">An output array of Unicode characters. </param>
		/// <param name="offsetOut">A position within <paramref name="outArray" />. </param>
		/// <param name="options">
		///       <see cref="F:System.Base64FormattingOptions.InsertLineBreaks" /> to insert a line break every 76 characters, or <see cref="F:System.Base64FormattingOptions.None" /> to not insert line breaks.</param>
		/// <returns>A 32-bit signed integer containing the number of bytes in <paramref name="outArray" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="inArray" /> or <paramref name="outArray" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offsetIn" />, <paramref name="offsetOut" />, or <paramref name="length" /> is negative.-or- 
		///         <paramref name="offsetIn" /> plus <paramref name="length" /> is greater than the length of <paramref name="inArray" />.-or- 
		///         <paramref name="offsetOut" /> plus the number of elements to return is greater than the length of <paramref name="outArray" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="options" /> is not a valid <see cref="T:System.Base64FormattingOptions" /> value. </exception>
		// Token: 0x06000454 RID: 1108 RVA: 0x0001140C File Offset: 0x0000F60C
		public unsafe static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options)
		{
			if (inArray == null)
			{
				throw new ArgumentNullException("inArray");
			}
			if (outArray == null)
			{
				throw new ArgumentNullException("outArray");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (offsetIn < 0)
			{
				throw new ArgumentOutOfRangeException("offsetIn", "Value must be positive.");
			}
			if (offsetOut < 0)
			{
				throw new ArgumentOutOfRangeException("offsetOut", "Value must be positive.");
			}
			if (options < Base64FormattingOptions.None || options > Base64FormattingOptions.InsertLineBreaks)
			{
				throw new ArgumentException(string.Format("Illegal enum value: {0}.", (int)options), "options");
			}
			int num = inArray.Length;
			if (offsetIn > num - length)
			{
				throw new ArgumentOutOfRangeException("offsetIn", "Offset and length must refer to a position in the string.");
			}
			if (num == 0)
			{
				return 0;
			}
			bool insertLineBreaks = options == Base64FormattingOptions.InsertLineBreaks;
			int num2 = outArray.Length;
			int num3 = Convert.ToBase64_CalculateAndValidateOutputLength(length, insertLineBreaks);
			if (offsetOut > num2 - num3)
			{
				throw new ArgumentOutOfRangeException("offsetOut", "Either offset did not refer to a position in the string, or there is an insufficient length of destination character array.");
			}
			int result;
			fixed (char* ptr = &outArray[offsetOut])
			{
				char* outChars = ptr;
				fixed (byte* ptr2 = &inArray[0])
				{
					byte* inData = ptr2;
					result = Convert.ConvertToBase64Array(outChars, inData, offsetIn, length, insertLineBreaks);
				}
			}
			return result;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00011510 File Offset: 0x0000F710
		private unsafe static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks)
		{
			int num = length % 3;
			int num2 = offset + (length - num);
			int num3 = 0;
			int num4 = 0;
			fixed (char* ptr = &Convert.base64Table[0])
			{
				char* ptr2 = ptr;
				int i;
				for (i = offset; i < num2; i += 3)
				{
					if (insertLineBreaks)
					{
						if (num4 == 76)
						{
							outChars[num3++] = '\r';
							outChars[num3++] = '\n';
							num4 = 0;
						}
						num4 += 4;
					}
					outChars[num3] = ptr2[(inData[i] & 252) >> 2];
					outChars[num3 + 1] = ptr2[(int)(inData[i] & 3) << 4 | (inData[i + 1] & 240) >> 4];
					outChars[num3 + 2] = ptr2[(int)(inData[i + 1] & 15) << 2 | (inData[i + 2] & 192) >> 6];
					outChars[num3 + 3] = ptr2[inData[i + 2] & 63];
					num3 += 4;
				}
				i = num2;
				if (insertLineBreaks && num != 0 && num4 == 76)
				{
					outChars[num3++] = '\r';
					outChars[num3++] = '\n';
				}
				if (num != 1)
				{
					if (num == 2)
					{
						outChars[num3] = ptr2[(inData[i] & 252) >> 2];
						outChars[num3 + 1] = ptr2[(int)(inData[i] & 3) << 4 | (inData[i + 1] & 240) >> 4];
						outChars[num3 + 2] = ptr2[(inData[i + 1] & 15) << 2];
						outChars[num3 + 3] = ptr2[64];
						num3 += 4;
					}
				}
				else
				{
					outChars[num3] = ptr2[(inData[i] & 252) >> 2];
					outChars[num3 + 1] = ptr2[(inData[i] & 3) << 4];
					outChars[num3 + 2] = ptr2[64];
					outChars[num3 + 3] = ptr2[64];
					num3 += 4;
				}
			}
			return num3;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00011718 File Offset: 0x0000F918
		private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks)
		{
			long num = (long)inputLength / 3L * 4L;
			num += ((inputLength % 3 != 0) ? 4L : 0L);
			if (num == 0L)
			{
				return 0;
			}
			if (insertLineBreaks)
			{
				long num2 = num / 76L;
				if (num % 76L == 0L)
				{
					num2 -= 1L;
				}
				num += num2 * 2L;
			}
			if (num > 2147483647L)
			{
				throw new OutOfMemoryException();
			}
			return (int)num;
		}

		/// <summary>Converts the specified string, which encodes binary data as base-64 digits, to an equivalent 8-bit unsigned integer array.</summary>
		/// <param name="s">The string to convert. </param>
		/// <returns>An array of 8-bit unsigned integers that is equivalent to <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">The length of <paramref name="s" />, ignoring white-space characters, is not zero or a multiple of 4. -or-The format of <paramref name="s" /> is invalid. <paramref name="s" /> contains a non-base-64 character, more than two padding characters, or a non-white space-character among the padding characters.</exception>
		// Token: 0x06000457 RID: 1111 RVA: 0x00011770 File Offset: 0x0000F970
		public unsafe static byte[] FromBase64String(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			char* ptr = s;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return Convert.FromBase64CharPtr(ptr, s.Length);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000117A8 File Offset: 0x0000F9A8
		public unsafe static bool TryFromBase64Chars(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten)
		{
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)8], 4);
			bytesWritten = 0;
			while (chars.Length != 0)
			{
				int start;
				int num;
				bool flag = Convert.TryDecodeFromUtf16(chars, bytes, out start, out num);
				bytesWritten += num;
				if (flag)
				{
					return true;
				}
				chars = chars.Slice(start);
				bytes = bytes.Slice(num);
				if (((char)(*chars[0])).IsSpace())
				{
					int num2 = 1;
					while (num2 != chars.Length && ((char)(*chars[num2])).IsSpace())
					{
						num2++;
					}
					chars = chars.Slice(num2);
					if (num % 3 != 0 && chars.Length != 0)
					{
						bytesWritten = 0;
						return false;
					}
				}
				else
				{
					int start2;
					int num3;
					Convert.CopyToTempBufferWithoutWhiteSpace(chars, span, out start2, out num3);
					if ((num3 & 3) != 0)
					{
						bytesWritten = 0;
						return false;
					}
					span = span.Slice(0, num3);
					int num4;
					int num5;
					if (!Convert.TryDecodeFromUtf16(span, bytes, out num4, out num5))
					{
						bytesWritten = 0;
						return false;
					}
					bytesWritten += num5;
					chars = chars.Slice(start2);
					bytes = bytes.Slice(num5);
					if (num5 % 3 != 0)
					{
						for (int i = 0; i < chars.Length; i++)
						{
							if (!((char)(*chars[i])).IsSpace())
							{
								bytesWritten = 0;
								return false;
							}
						}
						return true;
					}
				}
			}
			return true;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000118DC File Offset: 0x0000FADC
		private unsafe static void CopyToTempBufferWithoutWhiteSpace(ReadOnlySpan<char> chars, Span<char> tempBuffer, out int consumed, out int charsWritten)
		{
			charsWritten = 0;
			for (int i = 0; i < chars.Length; i++)
			{
				char c = (char)(*chars[i]);
				if (!c.IsSpace())
				{
					int num = charsWritten;
					charsWritten = num + 1;
					*tempBuffer[num] = c;
					if (charsWritten == tempBuffer.Length)
					{
						consumed = i + 1;
						return;
					}
				}
			}
			consumed = chars.Length;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0001193C File Offset: 0x0000FB3C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsSpace(this char c)
		{
			return c == ' ' || c == '\t' || c == '\r' || c == '\n';
		}

		/// <summary>Converts a subset of a Unicode character array, which encodes binary data as base-64 digits, to an equivalent 8-bit unsigned integer array. Parameters specify the subset in the input array and the number of elements to convert.</summary>
		/// <param name="inArray">A Unicode character array. </param>
		/// <param name="offset">A position within <paramref name="inArray" />. </param>
		/// <param name="length">The number of elements in <paramref name="inArray" /> to convert. </param>
		/// <returns>An array of 8-bit unsigned integers equivalent to <paramref name="length" /> elements at position <paramref name="offset" /> in <paramref name="inArray" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="inArray" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> or <paramref name="length" /> is less than 0.-or- 
		///         <paramref name="offset" /> plus <paramref name="length" /> indicates a position not within <paramref name="inArray" />. </exception>
		/// <exception cref="T:System.FormatException">The length of <paramref name="inArray" />, ignoring white-space characters, is not zero or a multiple of 4. -or-The format of <paramref name="inArray" /> is invalid. <paramref name="inArray" /> contains a non-base-64 character, more than two padding characters, or a non-white-space character among the padding characters. </exception>
		// Token: 0x0600045B RID: 1115 RVA: 0x00011954 File Offset: 0x0000FB54
		public unsafe static byte[] FromBase64CharArray(char[] inArray, int offset, int length)
		{
			if (inArray == null)
			{
				throw new ArgumentNullException("inArray");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Value must be positive.");
			}
			if (offset > inArray.Length - length)
			{
				throw new ArgumentOutOfRangeException("offset", "Offset and length must refer to a position in the string.");
			}
			if (inArray.Length == 0)
			{
				return Array.Empty<byte>();
			}
			fixed (char* ptr = &inArray[0])
			{
				return Convert.FromBase64CharPtr(ptr + offset, length);
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000119D0 File Offset: 0x0000FBD0
		private unsafe static byte[] FromBase64CharPtr(char* inputPtr, int inputLength)
		{
			while (inputLength > 0)
			{
				int num = (int)inputPtr[inputLength - 1];
				if (num != 32 && num != 10 && num != 13 && num != 9)
				{
					break;
				}
				inputLength--;
			}
			byte[] array = new byte[Convert.FromBase64_ComputeResultLength(inputPtr, inputLength)];
			int num2;
			if (!Convert.TryFromBase64Chars(new ReadOnlySpan<char>((void*)inputPtr, inputLength), array, out num2))
			{
				throw new FormatException("The input is not a valid Base-64 string as it contains a non-base 64 character, more than two padding characters, or an illegal character among the padding characters.");
			}
			return array;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00011A38 File Offset: 0x0000FC38
		private unsafe static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength)
		{
			char* ptr = inputPtr + inputLength;
			int num = inputLength;
			int num2 = 0;
			while (inputPtr < ptr)
			{
				uint num3 = (uint)(*inputPtr);
				inputPtr++;
				if (num3 <= 32U)
				{
					num--;
				}
				else if (num3 == 61U)
				{
					num--;
					num2++;
				}
			}
			if (num2 != 0)
			{
				if (num2 == 1)
				{
					num2 = 2;
				}
				else
				{
					if (num2 != 2)
					{
						throw new FormatException("The input is not a valid Base-64 string as it contains a non-base 64 character, more than two padding characters, or an illegal character among the padding characters.");
					}
					num2 = 1;
				}
			}
			return num / 4 * 3 + num2;
		}

		// Token: 0x040001D8 RID: 472
		private static readonly sbyte[] s_decodingMap = new sbyte[]
		{
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			62,
			-1,
			-1,
			-1,
			63,
			52,
			53,
			54,
			55,
			56,
			57,
			58,
			59,
			60,
			61,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			0,
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			9,
			10,
			11,
			12,
			13,
			14,
			15,
			16,
			17,
			18,
			19,
			20,
			21,
			22,
			23,
			24,
			25,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			26,
			27,
			28,
			29,
			30,
			31,
			32,
			33,
			34,
			35,
			36,
			37,
			38,
			39,
			40,
			41,
			42,
			43,
			44,
			45,
			46,
			47,
			48,
			49,
			50,
			51,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1
		};

		// Token: 0x040001D9 RID: 473
		internal static readonly Type[] ConvertTypes = new Type[]
		{
			typeof(Empty),
			typeof(object),
			typeof(DBNull),
			typeof(bool),
			typeof(char),
			typeof(sbyte),
			typeof(byte),
			typeof(short),
			typeof(ushort),
			typeof(int),
			typeof(uint),
			typeof(long),
			typeof(ulong),
			typeof(float),
			typeof(double),
			typeof(decimal),
			typeof(DateTime),
			typeof(object),
			typeof(string)
		};

		// Token: 0x040001DA RID: 474
		private static readonly Type EnumType = typeof(Enum);

		// Token: 0x040001DB RID: 475
		internal static readonly char[] base64Table = new char[]
		{
			'A',
			'B',
			'C',
			'D',
			'E',
			'F',
			'G',
			'H',
			'I',
			'J',
			'K',
			'L',
			'M',
			'N',
			'O',
			'P',
			'Q',
			'R',
			'S',
			'T',
			'U',
			'V',
			'W',
			'X',
			'Y',
			'Z',
			'a',
			'b',
			'c',
			'd',
			'e',
			'f',
			'g',
			'h',
			'i',
			'j',
			'k',
			'l',
			'm',
			'n',
			'o',
			'p',
			'q',
			'r',
			's',
			't',
			'u',
			'v',
			'w',
			'x',
			'y',
			'z',
			'0',
			'1',
			'2',
			'3',
			'4',
			'5',
			'6',
			'7',
			'8',
			'9',
			'+',
			'/',
			'='
		};

		/// <summary>A constant that represents a database column that is absent of data; that is, database null.</summary>
		// Token: 0x040001DC RID: 476
		public static readonly object DBNull = System.DBNull.Value;
	}
}
