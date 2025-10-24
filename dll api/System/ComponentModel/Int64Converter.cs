using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 64-bit signed integer objects to and from various other representations.</summary>
	// Token: 0x02000272 RID: 626
	public class Int64Converter : BaseNumberConverter
	{
		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00050451 File Offset: 0x0004E651
		internal override Type TargetType
		{
			get
			{
				return typeof(long);
			}
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0005045D File Offset: 0x0004E65D
		internal override object FromString(string value, int radix)
		{
			return Convert.ToInt64(value, radix);
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0005046B File Offset: 0x0004E66B
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return long.Parse(value, NumberStyles.Integer, formatInfo);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0005047C File Offset: 0x0004E67C
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return ((long)value).ToString("G", formatInfo);
		}
	}
}
