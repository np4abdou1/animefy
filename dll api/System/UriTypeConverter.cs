using System;
using System.ComponentModel;
using System.Globalization;

namespace System
{
	/// <summary>Converts a <see cref="T:System.String" /> type to a <see cref="T:System.Uri" /> type, and vice versa.</summary>
	// Token: 0x02000097 RID: 151
	public class UriTypeConverter : TypeConverter
	{
		// Token: 0x060003C8 RID: 968 RVA: 0x00015CFE File Offset: 0x00013EFE
		private bool CanConvert(Type type)
		{
			return type == typeof(string) || type == typeof(Uri);
		}

		/// <summary>Returns whether this converter can convert an object of the given type to the type of this converter.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" />  that provides a format context.</param>
		/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type that you want to convert from.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="sourceType" /> is a <see cref="T:System.String" /> type or a <see cref="T:System.Uri" /> type can be assigned from <paramref name="sourceType" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="sourceType" /> parameter is <see langword="null" />.</exception>
		// Token: 0x060003C9 RID: 969 RVA: 0x00015D29 File Offset: 0x00013F29
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (sourceType == null)
			{
				throw new ArgumentNullException("sourceType");
			}
			return this.CanConvert(sourceType);
		}

		/// <summary>Returns whether this converter can convert the object to the specified type, using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" />  that provides a format context.</param>
		/// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type that you want to convert to.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="destinationType" /> is of type <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" />, <see cref="T:System.String" />, or <see cref="T:System.Uri" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060003CA RID: 970 RVA: 0x00015D46 File Offset: 0x00013F46
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return !(destinationType == null) && this.CanConvert(destinationType);
		}

		/// <summary>Converts the given object to the type of this converter, using the specified context and culture information.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" />  that provides a format context.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use as the current culture.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
		// Token: 0x060003CB RID: 971 RVA: 0x00015D5C File Offset: 0x00013F5C
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value == null)
			{
				throw new NotSupportedException(Locale.GetText("Cannot convert from value."));
			}
			if (!this.CanConvertFrom(context, value.GetType()))
			{
				throw new NotSupportedException(Locale.GetText("Cannot convert from value."));
			}
			if (value is Uri)
			{
				return value;
			}
			string text = value as string;
			if (text == null)
			{
				return base.ConvertFrom(context, culture, value);
			}
			if (text == "")
			{
				return null;
			}
			return new Uri(text, UriKind.RelativeOrAbsolute);
		}

		/// <summary>Converts a given value object to the specified type, using the specified context and culture information.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" />  that provides a format context.</param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If <see langword="null" /> is passed, the current culture is assumed.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
		/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the <paramref name="value" /> parameter to.</param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="destinationType" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
		// Token: 0x060003CC RID: 972 RVA: 0x00015DD0 File Offset: 0x00013FD0
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!this.CanConvertTo(context, destinationType))
			{
				throw new NotSupportedException(Locale.GetText("Cannot convert to destination type."));
			}
			Uri uri = value as Uri;
			if (!(uri != null))
			{
				throw new NotSupportedException(Locale.GetText("Cannot convert to destination type."));
			}
			if (destinationType == typeof(string))
			{
				return uri.ToString();
			}
			if (destinationType == typeof(Uri))
			{
				return uri;
			}
			throw new NotSupportedException(Locale.GetText("Cannot convert to destination type."));
		}
	}
}
