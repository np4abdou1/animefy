﻿using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert string objects to and from other representations.</summary>
	// Token: 0x02000285 RID: 645
	public class StringConverter : TypeConverter
	{
		/// <summary>Gets a value indicating whether this converter can convert an object in the given source type to a string using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type you wish to convert from. </param>
		/// <returns>
		///     <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001146 RID: 4422 RVA: 0x0004DC20 File Offset: 0x0004BE20
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Converts the specified value object to a <see cref="T:System.String" /> object.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use. </param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.NotSupportedException">The conversion could not be performed. </exception>
		// Token: 0x06001147 RID: 4423 RVA: 0x00051C51 File Offset: 0x0004FE51
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string)
			{
				return (string)value;
			}
			if (value == null)
			{
				return string.Empty;
			}
			return base.ConvertFrom(context, culture, value);
		}
	}
}
