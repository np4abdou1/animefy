﻿using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert <see cref="T:System.DateTimeOffset" /> structures to and from various other representations.</summary>
	// Token: 0x0200029B RID: 667
	public class DateTimeOffsetConverter : TypeConverter
	{
		/// <summary>Returns a value that indicates whether an object of the specified source type can be converted to a <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="context">The date format context.</param>
		/// <param name="sourceType">The source type to check.</param>
		/// <returns>
		///     <see langword="true" /> if the specified type can be converted to a <see cref="T:System.DateTimeOffset" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001194 RID: 4500 RVA: 0x0004DF8D File Offset: 0x0004C18D
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Returns a value that indicates whether a <see cref="T:System.DateTimeOffset" /> can be converted to an object of the specified type.</summary>
		/// <param name="context">The date format context.</param>
		/// <param name="destinationType">The destination type to check.</param>
		/// <returns>
		///     <see langword="true" /> if a <see cref="T:System.DateTimeOffset" /> can be converted to the specified type; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001195 RID: 4501 RVA: 0x0004DFAB File Offset: 0x0004C1AB
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Converts the specified object to a <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="context">The date format context.</param>
		/// <param name="culture">The date culture.</param>
		/// <param name="value">The object to be converted.</param>
		/// <returns>A <see cref="T:System.DateTimeOffset" /> that represents the specified object.</returns>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
		// Token: 0x06001196 RID: 4502 RVA: 0x00052290 File Offset: 0x00050490
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string)
			{
				string text = ((string)value).Trim();
				if (text.Length == 0)
				{
					return DateTimeOffset.MinValue;
				}
				try
				{
					DateTimeFormatInfo dateTimeFormatInfo = null;
					if (culture != null)
					{
						dateTimeFormatInfo = (DateTimeFormatInfo)culture.GetFormat(typeof(DateTimeFormatInfo));
					}
					if (dateTimeFormatInfo != null)
					{
						return DateTimeOffset.Parse(text, dateTimeFormatInfo);
					}
					return DateTimeOffset.Parse(text, culture);
				}
				catch (FormatException innerException)
				{
					throw new FormatException(SR.GetString("{0} is not a valid value for {1}.", new object[]
					{
						(string)value,
						"DateTimeOffset"
					}), innerException);
				}
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Converts a <see cref="T:System.DateTimeOffset" /> to an object of the specified type.</summary>
		/// <param name="context">The date format context.</param>
		/// <param name="culture">The date culture.</param>
		/// <param name="value">The <see cref="T:System.DateTimeOffset" /> to be converted.</param>
		/// <param name="destinationType">The type to convert to.</param>
		/// <returns>An object of the specified type that represents the <see cref="T:System.DateTimeOffset" />. </returns>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
		// Token: 0x06001197 RID: 4503 RVA: 0x00052348 File Offset: 0x00050548
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!(destinationType == typeof(string)) || !(value is DateTimeOffset))
			{
				if (destinationType == typeof(InstanceDescriptor) && value is DateTimeOffset)
				{
					DateTimeOffset dateTimeOffset = (DateTimeOffset)value;
					if (dateTimeOffset.Ticks == 0L)
					{
						ConstructorInfo constructor = typeof(DateTimeOffset).GetConstructor(new Type[]
						{
							typeof(long)
						});
						if (constructor != null)
						{
							return new InstanceDescriptor(constructor, new object[]
							{
								dateTimeOffset.Ticks
							});
						}
					}
					ConstructorInfo constructor2 = typeof(DateTimeOffset).GetConstructor(new Type[]
					{
						typeof(int),
						typeof(int),
						typeof(int),
						typeof(int),
						typeof(int),
						typeof(int),
						typeof(int),
						typeof(TimeSpan)
					});
					if (constructor2 != null)
					{
						return new InstanceDescriptor(constructor2, new object[]
						{
							dateTimeOffset.Year,
							dateTimeOffset.Month,
							dateTimeOffset.Day,
							dateTimeOffset.Hour,
							dateTimeOffset.Minute,
							dateTimeOffset.Second,
							dateTimeOffset.Millisecond,
							dateTimeOffset.Offset
						});
					}
				}
				return base.ConvertTo(context, culture, value, destinationType);
			}
			DateTimeOffset left = (DateTimeOffset)value;
			if (left == DateTimeOffset.MinValue)
			{
				return string.Empty;
			}
			if (culture == null)
			{
				culture = CultureInfo.CurrentCulture;
			}
			DateTimeFormatInfo dateTimeFormatInfo = (DateTimeFormatInfo)culture.GetFormat(typeof(DateTimeFormatInfo));
			if (culture != CultureInfo.InvariantCulture)
			{
				string format;
				if (left.TimeOfDay.TotalSeconds == 0.0)
				{
					format = dateTimeFormatInfo.ShortDatePattern + " zzz";
				}
				else
				{
					format = dateTimeFormatInfo.ShortDatePattern + " " + dateTimeFormatInfo.ShortTimePattern + " zzz";
				}
				return left.ToString(format, CultureInfo.CurrentCulture);
			}
			if (left.TimeOfDay.TotalSeconds == 0.0)
			{
				return left.ToString("yyyy-MM-dd zzz", culture);
			}
			return left.ToString(culture);
		}
	}
}
