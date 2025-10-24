using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 64-bit unsigned integer objects to and from other representations.</summary>
	// Token: 0x0200028D RID: 653
	public class UInt64Converter : BaseNumberConverter
	{
		// Token: 0x17000389 RID: 905
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x00051FDD File Offset: 0x000501DD
		internal override Type TargetType
		{
			get
			{
				return typeof(ulong);
			}
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x00051FE9 File Offset: 0x000501E9
		internal override object FromString(string value, int radix)
		{
			return Convert.ToUInt64(value, radix);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00051FF7 File Offset: 0x000501F7
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return ulong.Parse(value, NumberStyles.Integer, formatInfo);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00052008 File Offset: 0x00050208
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return ((ulong)value).ToString("G", formatInfo);
		}
	}
}
