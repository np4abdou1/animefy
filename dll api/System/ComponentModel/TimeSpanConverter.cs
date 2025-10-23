using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert <see cref="T:System.TimeSpan" /> objects to and from other representations.</summary>
	// Token: 0x02000286 RID: 646
	public class TimeSpanConverter : TypeConverter
	{
		/// <summary>Gets a value indicating whether this converter can convert an object in the given source type to a <see cref="T:System.TimeSpan" /> using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type you wish to convert from. </param>
		/// <returns>
		///     <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001149 RID: 4425 RVA: 0x0004DC20 File Offset: 0x0004BE20
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Gets a value indicating whether this converter can convert an object to the given destination type using the context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you wish to convert to. </param>
		/// <returns>
		///     <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="destinationType" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not a valid value for the target type. </exception>
		// Token: 0x0600114A RID: 4426 RVA: 0x0004DFAB File Offset: 0x0004C1AB
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Converts the given object to a <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">An optional <see cref="T:System.Globalization.CultureInfo" />. If not supplied, the current culture is assumed. </param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not a valid value for the target type. </exception>
		// Token: 0x0600114B RID: 4427 RVA: 0x00051C74 File Offset: 0x0004FE74
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string text = value as string;
			if (text != null)
			{
				text = text.Trim();
				try
				{
					return TimeSpan.Parse(text, culture);
				}
				catch (FormatException innerException)
				{
					throw new FormatException(SR.Format("{0} is not a valid value for {1}.", (string)value, "TimeSpan"), innerException);
				}
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Converts the given object to another type. </summary>
		/// <param name="context">A formatter context. </param>
		/// <param name="culture">The culture into which <paramref name="value" /> will be converted.</param>
		/// <param name="value">The object to convert. </param>
		/// <param name="destinationType">The type to convert the object to. </param>
		/// <returns>The converted object.</returns>
		// Token: 0x0600114C RID: 4428 RVA: 0x00051CDC File Offset: 0x0004FEDC
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(InstanceDescriptor) && value is TimeSpan)
			{
				MethodInfo method = typeof(TimeSpan).GetMethod("Parse", new Type[]
				{
					typeof(string)
				});
				if (method != null)
				{
					return new InstanceDescriptor(method, new object[]
					{
						value.ToString()
					});
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
