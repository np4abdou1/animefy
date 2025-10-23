using System;
using System.ComponentModel;
using System.Globalization;

namespace System.Data
{
	// Token: 0x02000050 RID: 80
	internal sealed class DefaultValueTypeConverter : StringConverter
	{
		// Token: 0x06000679 RID: 1657 RVA: 0x0001D7BC File Offset: 0x0001B9BC
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(string))
			{
				if (value == null)
				{
					return "<null>";
				}
				if (value == DBNull.Value)
				{
					return "<DBNull>";
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0001D814 File Offset: 0x0001BA14
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value != null && value.GetType() == typeof(string))
			{
				string a = (string)value;
				if (string.Equals(a, "<null>", StringComparison.OrdinalIgnoreCase))
				{
					return null;
				}
				if (string.Equals(a, "<DBNull>", StringComparison.OrdinalIgnoreCase))
				{
					return DBNull.Value;
				}
			}
			return base.ConvertFrom(context, culture, value);
		}
	}
}
