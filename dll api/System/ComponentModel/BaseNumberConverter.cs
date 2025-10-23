using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a base type converter for nonfloating-point numerical types.</summary>
	// Token: 0x0200024D RID: 589
	public abstract class BaseNumberConverter : TypeConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.BaseNumberConverter" /> class.</summary>
		// Token: 0x06000FD6 RID: 4054 RVA: 0x00015CF6 File Offset: 0x00013EF6
		internal BaseNumberConverter()
		{
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x00009518 File Offset: 0x00007718
		internal virtual bool AllowHex
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000FD8 RID: 4056
		internal abstract Type TargetType { get; }

		// Token: 0x06000FD9 RID: 4057
		internal abstract object FromString(string value, int radix);

		// Token: 0x06000FDA RID: 4058
		internal abstract object FromString(string value, NumberFormatInfo formatInfo);

		// Token: 0x06000FDB RID: 4059
		internal abstract string ToString(object value, NumberFormatInfo formatInfo);

		/// <summary>Determines if this converter can convert an object in the given source type to the native type of the converter.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type from which you want to convert. </param>
		/// <returns>
		///     <see langword="true" /> if this converter can perform the operation; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FDC RID: 4060 RVA: 0x0004DC20 File Offset: 0x0004BE20
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Converts the given object to the converter's native type.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that specifies the culture to represent the number. </param>
		/// <param name="value">The object to convert. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.Exception">
		///         <paramref name="value" /> is not a valid value for the target type.</exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x06000FDD RID: 4061 RVA: 0x0004DC40 File Offset: 0x0004BE40
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string text = value as string;
			if (text != null)
			{
				text = text.Trim();
				try
				{
					if (this.AllowHex && text[0] == '#')
					{
						return this.FromString(text.Substring(1), 16);
					}
					if ((this.AllowHex && text.StartsWith("0x", StringComparison.OrdinalIgnoreCase)) || text.StartsWith("&h", StringComparison.OrdinalIgnoreCase))
					{
						return this.FromString(text.Substring(2), 16);
					}
					if (culture == null)
					{
						culture = CultureInfo.CurrentCulture;
					}
					NumberFormatInfo formatInfo = (NumberFormatInfo)culture.GetFormat(typeof(NumberFormatInfo));
					return this.FromString(text, formatInfo);
				}
				catch (Exception innerException)
				{
					throw new ArgumentException(SR.Format("{0} is not a valid value for {1}.", text, this.TargetType.Name), "value", innerException);
				}
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Converts the specified object to another type.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that specifies the culture to represent the number. </param>
		/// <param name="value">The object to convert. </param>
		/// <param name="destinationType">The type to convert the object to. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="destinationType" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x06000FDE RID: 4062 RVA: 0x0004DD28 File Offset: 0x0004BF28
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(string) && value != null && this.TargetType.IsInstanceOfType(value))
			{
				if (culture == null)
				{
					culture = CultureInfo.CurrentCulture;
				}
				NumberFormatInfo formatInfo = (NumberFormatInfo)culture.GetFormat(typeof(NumberFormatInfo));
				return this.ToString(value, formatInfo);
			}
			if (destinationType.IsPrimitive)
			{
				return Convert.ChangeType(value, destinationType, culture);
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Returns a value indicating whether this converter can convert an object to the given destination type using the context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="t">A <see cref="T:System.Type" /> that represents the type to which you want to convert. </param>
		/// <returns>
		///     <see langword="true" /> if this converter can perform the operation; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FDF RID: 4063 RVA: 0x0004DDB5 File Offset: 0x0004BFB5
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return base.CanConvertTo(context, destinationType) || destinationType.IsPrimitive;
		}
	}
}
