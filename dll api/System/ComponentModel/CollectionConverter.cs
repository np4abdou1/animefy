using System;
using System.Collections;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert collection objects to and from various other representations.</summary>
	// Token: 0x02000298 RID: 664
	public class CollectionConverter : TypeConverter
	{
		/// <summary>Converts the given value object to the specified destination type.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">The culture to which <paramref name="value" /> will be converted.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. This parameter must inherit from <see cref="T:System.Collections.ICollection" />. </param>
		/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the value to. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="destinationType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x06001185 RID: 4485 RVA: 0x000520AC File Offset: 0x000502AC
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(string) && value is ICollection)
			{
				return SR.GetString("(Collection)");
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
