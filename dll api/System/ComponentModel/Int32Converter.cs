using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 32-bit signed integer objects to and from other representations.</summary>
	// Token: 0x02000271 RID: 625
	public class Int32Converter : BaseNumberConverter
	{
		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x00050405 File Offset: 0x0004E605
		internal override Type TargetType
		{
			get
			{
				return typeof(int);
			}
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00050411 File Offset: 0x0004E611
		internal override object FromString(string value, int radix)
		{
			return Convert.ToInt32(value, radix);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0005041F File Offset: 0x0004E61F
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return int.Parse(value, NumberStyles.Integer, formatInfo);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00050430 File Offset: 0x0004E630
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return ((int)value).ToString("G", formatInfo);
		}
	}
}
