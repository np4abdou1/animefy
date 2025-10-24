using System;
using System.ComponentModel;
using System.Globalization;

namespace System.Data
{
	// Token: 0x0200007A RID: 122
	internal sealed class PrimaryKeyTypeConverter : ReferenceConverter
	{
		// Token: 0x060007CF RID: 1999 RVA: 0x000269DE File Offset: 0x00024BDE
		public PrimaryKeyTypeConverter() : base(typeof(DataColumn[]))
		{
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00002238 File Offset: 0x00000438
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x000269F0 File Offset: 0x00024BF0
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (!(destinationType == typeof(string)))
			{
				return base.ConvertTo(context, culture, value, destinationType);
			}
			return Array.Empty<DataColumn>().GetType().Name;
		}
	}
}
