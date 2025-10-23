using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 32-bit unsigned integer objects to and from various other representations.</summary>
	// Token: 0x0200028C RID: 652
	public class UInt32Converter : BaseNumberConverter
	{
		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x00051F91 File Offset: 0x00050191
		internal override Type TargetType
		{
			get
			{
				return typeof(uint);
			}
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00051F9D File Offset: 0x0005019D
		internal override object FromString(string value, int radix)
		{
			return Convert.ToUInt32(value, radix);
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00051FAB File Offset: 0x000501AB
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return uint.Parse(value, NumberStyles.Integer, formatInfo);
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00051FBC File Offset: 0x000501BC
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return ((uint)value).ToString("G", formatInfo);
		}
	}
}
