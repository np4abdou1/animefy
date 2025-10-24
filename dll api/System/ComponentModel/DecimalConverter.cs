using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert <see cref="T:System.Decimal" /> objects to and from various other representations.</summary>
	// Token: 0x02000259 RID: 601
	public class DecimalConverter : BaseNumberConverter
	{
		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x000023F6 File Offset: 0x000005F6
		internal override bool AllowHex
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0004F746 File Offset: 0x0004D946
		internal override Type TargetType
		{
			get
			{
				return typeof(decimal);
			}
		}

		/// <summary>Gets a value indicating whether this converter can convert an object to the given destination type using the context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you wish to convert to. </param>
		/// <returns>
		///     <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001017 RID: 4119 RVA: 0x0004F752 File Offset: 0x0004D952
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Converts the given value object to a <see cref="T:System.Decimal" /> using the arguments.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">An optional <see cref="T:System.Globalization.CultureInfo" />. If not supplied, the current culture is assumed. </param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the value to. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="destinationType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x06001018 RID: 4120 RVA: 0x0004F770 File Offset: 0x0004D970
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (!(destinationType == typeof(InstanceDescriptor)) || !(value is decimal))
			{
				return base.ConvertTo(context, culture, value, destinationType);
			}
			object[] arguments = new object[]
			{
				decimal.GetBits((decimal)value)
			};
			MemberInfo constructor = typeof(decimal).GetConstructor(new Type[]
			{
				typeof(int[])
			});
			if (constructor != null)
			{
				return new InstanceDescriptor(constructor, arguments);
			}
			return null;
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0004F803 File Offset: 0x0004DA03
		internal override object FromString(string value, int radix)
		{
			return Convert.ToDecimal(value, CultureInfo.CurrentCulture);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0004F815 File Offset: 0x0004DA15
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return decimal.Parse(value, NumberStyles.Float, formatInfo);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0004F828 File Offset: 0x0004DA28
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return ((decimal)value).ToString("G", formatInfo);
		}
	}
}
