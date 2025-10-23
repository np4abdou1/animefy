using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert <see cref="T:System.Boolean" /> objects to and from various other representations.</summary>
	// Token: 0x0200024E RID: 590
	public class BooleanConverter : TypeConverter
	{
		/// <summary>Gets a value indicating whether this converter can convert an object in the given source type to a Boolean object using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type you wish to convert from. </param>
		/// <returns>
		///     <see langword="true" /> if this object can perform the conversion; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FE0 RID: 4064 RVA: 0x0004DC20 File Offset: 0x0004BE20
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Converts the given value object to a Boolean object.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that specifies the culture to which to convert.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted <paramref name="value" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not a valid value for the target type. </exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x06000FE1 RID: 4065 RVA: 0x0004DDCC File Offset: 0x0004BFCC
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string text = value as string;
			if (text != null)
			{
				text = text.Trim();
				try
				{
					return bool.Parse(text);
				}
				catch (FormatException innerException)
				{
					throw new FormatException(SR.Format("{0} is not a valid value for {1}.", (string)value, "Boolean"), innerException);
				}
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Gets a collection of standard values for the Boolean data type.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> that holds a standard set of valid values.</returns>
		// Token: 0x06000FE2 RID: 4066 RVA: 0x0004DE30 File Offset: 0x0004C030
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			TypeConverter.StandardValuesCollection result;
			if ((result = BooleanConverter.s_values) == null)
			{
				result = (BooleanConverter.s_values = new TypeConverter.StandardValuesCollection(new object[]
				{
					true,
					false
				}));
			}
			return result;
		}

		/// <summary>Gets a value indicating whether this object supports a standard set of values that can be picked from a list.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <returns>
		///     <see langword="true" /> because <see cref="M:System.ComponentModel.BooleanConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" /> can be called to find a common set of values the object supports. This method never returns <see langword="false" />.</returns>
		// Token: 0x06000FE3 RID: 4067 RVA: 0x00009518 File Offset: 0x00007718
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x04000C33 RID: 3123
		private static volatile TypeConverter.StandardValuesCollection s_values;
	}
}
