using System;

namespace System
{
	/// <summary>Defines methods that convert the value of the implementing reference or value type to a common language runtime type that has an equivalent value.</summary>
	// Token: 0x020000BB RID: 187
	[CLSCompliant(false)]
	public interface IConvertible
	{
		/// <summary>Returns the <see cref="T:System.TypeCode" /> for this instance.</summary>
		/// <returns>The enumerated constant that is the <see cref="T:System.TypeCode" /> of the class or value type that implements this interface.</returns>
		// Token: 0x06000625 RID: 1573
		TypeCode GetTypeCode();

		/// <summary>Converts the value of this instance to an equivalent Boolean value using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>A Boolean value equivalent to the value of this instance.</returns>
		// Token: 0x06000626 RID: 1574
		bool ToBoolean(IFormatProvider provider);

		/// <summary>Converts the value of this instance to an equivalent Unicode character using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>A Unicode character equivalent to the value of this instance.</returns>
		// Token: 0x06000627 RID: 1575
		char ToChar(IFormatProvider provider);

		/// <summary>Converts the value of this instance to an equivalent 8-bit signed integer using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>An 8-bit signed integer equivalent to the value of this instance.</returns>
		// Token: 0x06000628 RID: 1576
		sbyte ToSByte(IFormatProvider provider);

		/// <summary>Converts the value of this instance to an equivalent 8-bit unsigned integer using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>An 8-bit unsigned integer equivalent to the value of this instance.</returns>
		// Token: 0x06000629 RID: 1577
		byte ToByte(IFormatProvider provider);

		/// <summary>Converts the value of this instance to an equivalent 16-bit signed integer using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>An 16-bit signed integer equivalent to the value of this instance.</returns>
		// Token: 0x0600062A RID: 1578
		short ToInt16(IFormatProvider provider);

		/// <summary>Converts the value of this instance to an equivalent 16-bit unsigned integer using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>An 16-bit unsigned integer equivalent to the value of this instance.</returns>
		// Token: 0x0600062B RID: 1579
		ushort ToUInt16(IFormatProvider provider);

		/// <summary>Converts the value of this instance to an equivalent 32-bit signed integer using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>An 32-bit signed integer equivalent to the value of this instance.</returns>
		// Token: 0x0600062C RID: 1580
		int ToInt32(IFormatProvider provider);

		/// <summary>Converts the value of this instance to an equivalent 32-bit unsigned integer using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>An 32-bit unsigned integer equivalent to the value of this instance.</returns>
		// Token: 0x0600062D RID: 1581
		uint ToUInt32(IFormatProvider provider);

		/// <summary>Converts the value of this instance to an equivalent 64-bit signed integer using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>An 64-bit signed integer equivalent to the value of this instance.</returns>
		// Token: 0x0600062E RID: 1582
		long ToInt64(IFormatProvider provider);

		/// <summary>Converts the value of this instance to an equivalent 64-bit unsigned integer using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>An 64-bit unsigned integer equivalent to the value of this instance.</returns>
		// Token: 0x0600062F RID: 1583
		ulong ToUInt64(IFormatProvider provider);

		/// <summary>Converts the value of this instance to an equivalent single-precision floating-point number using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>A single-precision floating-point number equivalent to the value of this instance.</returns>
		// Token: 0x06000630 RID: 1584
		float ToSingle(IFormatProvider provider);

		/// <summary>Converts the value of this instance to an equivalent double-precision floating-point number using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>A double-precision floating-point number equivalent to the value of this instance.</returns>
		// Token: 0x06000631 RID: 1585
		double ToDouble(IFormatProvider provider);

		/// <summary>Converts the value of this instance to an equivalent <see cref="T:System.Decimal" /> number using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>A <see cref="T:System.Decimal" /> number equivalent to the value of this instance.</returns>
		// Token: 0x06000632 RID: 1586
		decimal ToDecimal(IFormatProvider provider);

		/// <summary>Converts the value of this instance to an equivalent <see cref="T:System.DateTime" /> using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>A <see cref="T:System.DateTime" /> instance equivalent to the value of this instance.</returns>
		// Token: 0x06000633 RID: 1587
		DateTime ToDateTime(IFormatProvider provider);

		/// <summary>Converts the value of this instance to an equivalent <see cref="T:System.String" /> using the specified culture-specific formatting information.</summary>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>A <see cref="T:System.String" /> instance equivalent to the value of this instance.</returns>
		// Token: 0x06000634 RID: 1588
		string ToString(IFormatProvider provider);

		/// <summary>Converts the value of this instance to an <see cref="T:System.Object" /> of the specified <see cref="T:System.Type" /> that has an equivalent value, using the specified culture-specific formatting information.</summary>
		/// <param name="conversionType">The <see cref="T:System.Type" /> to which the value of this instance is converted. </param>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> interface implementation that supplies culture-specific formatting information. </param>
		/// <returns>An <see cref="T:System.Object" /> instance of type <paramref name="conversionType" /> whose value is equivalent to the value of this instance.</returns>
		// Token: 0x06000635 RID: 1589
		object ToType(Type conversionType, IFormatProvider provider);
	}
}
