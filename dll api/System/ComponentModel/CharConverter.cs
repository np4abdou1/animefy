﻿using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert Unicode character objects to and from various other representations.</summary>
	// Token: 0x02000250 RID: 592
	public class CharConverter : TypeConverter
	{
		/// <summary>Gets a value indicating whether this converter can convert an object in the given source type to a Unicode character object using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type you want to convert from. </param>
		/// <returns>
		///     <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FEA RID: 4074 RVA: 0x0004DC20 File Offset: 0x0004BE20
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Converts the given value object to a Unicode character object using the arguments.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">The culture into which <paramref name="value" /> will be converted.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the value to. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x06000FEB RID: 4075 RVA: 0x0004DEB5 File Offset: 0x0004C0B5
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string) && value is char && (char)value == '\0')
			{
				return "";
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Converts the given object to a Unicode character object.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">The culture into which <paramref name="value" /> will be converted.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted <paramref name="value" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not a valid value for the target type. </exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x06000FEC RID: 4076 RVA: 0x0004DEEC File Offset: 0x0004C0EC
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string text = value as string;
			if (text == null)
			{
				return base.ConvertFrom(context, culture, value);
			}
			if (text.Length > 1)
			{
				text = text.Trim();
			}
			if (text.Length <= 0)
			{
				return '\0';
			}
			if (text.Length != 1)
			{
				throw new FormatException(SR.Format("{0} is not a valid value for {1}.", text, "Char"));
			}
			return text[0];
		}
	}
}
