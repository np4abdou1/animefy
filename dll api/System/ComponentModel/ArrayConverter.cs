using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert <see cref="T:System.Array" /> objects to and from various other representations.</summary>
	// Token: 0x02000249 RID: 585
	public class ArrayConverter : CollectionConverter
	{
		/// <summary>Converts the given value object to the specified destination type.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">The culture into which <paramref name="value" /> will be converted.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the value to. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="destinationType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x06000FC5 RID: 4037 RVA: 0x0004D830 File Offset: 0x0004BA30
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(string) && value is Array)
			{
				return SR.Format("{0} Array", value.GetType().Name);
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
