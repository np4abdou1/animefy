using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides automatic conversion between a nullable type and its underlying primitive type.</summary>
	// Token: 0x02000279 RID: 633
	public class NullableConverter : TypeConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.NullableConverter" /> class.</summary>
		/// <param name="type">The specified nullable type.</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> is not a nullable type.</exception>
		// Token: 0x060010D3 RID: 4307 RVA: 0x000506C0 File Offset: 0x0004E8C0
		public NullableConverter(Type type)
		{
			this.NullableType = type;
			this.UnderlyingType = Nullable.GetUnderlyingType(type);
			if (this.UnderlyingType == null)
			{
				throw new ArgumentException("The specified type is not a nullable type.", "type");
			}
			this.UnderlyingTypeConverter = TypeDescriptor.GetConverter(this.UnderlyingType);
		}

		/// <summary>Returns whether this converter can convert an object of the given type to the type of this converter, using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" />  that provides a format context.</param>
		/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type you want to convert from.</param>
		/// <returns>
		///     <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
		// Token: 0x060010D4 RID: 4308 RVA: 0x00050715 File Offset: 0x0004E915
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (sourceType == this.UnderlyingType)
			{
				return true;
			}
			if (this.UnderlyingTypeConverter != null)
			{
				return this.UnderlyingTypeConverter.CanConvertFrom(context, sourceType);
			}
			return base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Converts the given object to the type of this converter, using the specified context and culture information.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use as the current culture.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x060010D5 RID: 4309 RVA: 0x00050748 File Offset: 0x0004E948
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value == null || value.GetType() == this.UnderlyingType)
			{
				return value;
			}
			if (value is string && string.IsNullOrEmpty(value as string))
			{
				return null;
			}
			if (this.UnderlyingTypeConverter != null)
			{
				return this.UnderlyingTypeConverter.ConvertFrom(context, culture, value);
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Returns whether this converter can convert the object to the specified type, using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		/// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to.</param>
		/// <returns>
		///     <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
		// Token: 0x060010D6 RID: 4310 RVA: 0x000507A4 File Offset: 0x0004E9A4
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if (destinationType == this.UnderlyingType)
			{
				return true;
			}
			if (this.UnderlyingTypeConverter != null)
			{
				return this.UnderlyingTypeConverter.CanConvertTo(context, destinationType);
			}
			return base.CanConvertTo(context, destinationType);
		}

		/// <summary>Converts the given value object to the specified type, using the specified context and culture information.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use as the current culture.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
		/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the value parameter to.</param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="destinationType" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x060010D7 RID: 4311 RVA: 0x000507D4 File Offset: 0x0004E9D4
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == this.UnderlyingType && value != null && this.NullableType.IsInstanceOfType(value))
			{
				return value;
			}
			if (value == null)
			{
				if (destinationType == typeof(string))
				{
					return string.Empty;
				}
			}
			else if (this.UnderlyingTypeConverter != null)
			{
				return this.UnderlyingTypeConverter.ConvertTo(context, culture, value, destinationType);
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Returns a collection of standard values for the data type this type converter is designed for when provided with a format context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context that can be used to extract additional information about the environment from which this converter is invoked. This parameter or properties of this parameter can be <see langword="null" />.</param>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> that holds a standard set of valid values, or <see langword="null" /> if the data type does not support a standard set of values.</returns>
		// Token: 0x060010D8 RID: 4312 RVA: 0x00050858 File Offset: 0x0004EA58
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			if (this.UnderlyingTypeConverter != null)
			{
				TypeConverter.StandardValuesCollection standardValues = this.UnderlyingTypeConverter.GetStandardValues(context);
				if (this.GetStandardValuesSupported(context) && standardValues != null)
				{
					object[] array = new object[standardValues.Count + 1];
					int num = 0;
					array[num++] = null;
					foreach (object obj in standardValues)
					{
						array[num++] = obj;
					}
					return new TypeConverter.StandardValuesCollection(array);
				}
			}
			return base.GetStandardValues(context);
		}

		/// <summary>Returns whether this object supports a standard set of values that can be picked from a list, using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		/// <returns>
		///     <see langword="true" /> if <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> should be called to find a common set of values the object supports; otherwise, <see langword="false" />.</returns>
		// Token: 0x060010D9 RID: 4313 RVA: 0x000508F4 File Offset: 0x0004EAF4
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			if (this.UnderlyingTypeConverter != null)
			{
				return this.UnderlyingTypeConverter.GetStandardValuesSupported(context);
			}
			return base.GetStandardValuesSupported(context);
		}

		/// <summary>Gets the nullable type.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the nullable type.</returns>
		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x00050912 File Offset: 0x0004EB12
		public Type NullableType { get; }

		/// <summary>Gets the underlying type.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the underlying type.</returns>
		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x0005091A File Offset: 0x0004EB1A
		public Type UnderlyingType { get; }

		/// <summary>Gets the underlying type converter.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter" /> that represents the underlying type converter.</returns>
		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x00050922 File Offset: 0x0004EB22
		public TypeConverter UnderlyingTypeConverter { get; }
	}
}
