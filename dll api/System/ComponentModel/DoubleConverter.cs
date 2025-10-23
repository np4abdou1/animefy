using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert double-precision, floating point number objects to and from various other representations.</summary>
	// Token: 0x0200025F RID: 607
	public class DoubleConverter : BaseNumberConverter
	{
		// Token: 0x1700033E RID: 830
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x000023F6 File Offset: 0x000005F6
		internal override bool AllowHex
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x0004FAB5 File Offset: 0x0004DCB5
		internal override Type TargetType
		{
			get
			{
				return typeof(double);
			}
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0004FAC1 File Offset: 0x0004DCC1
		internal override object FromString(string value, int radix)
		{
			return Convert.ToDouble(value, CultureInfo.CurrentCulture);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0004FAD3 File Offset: 0x0004DCD3
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return double.Parse(value, NumberStyles.Float, formatInfo);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0004FAE8 File Offset: 0x0004DCE8
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return ((double)value).ToString("R", formatInfo);
		}
	}
}
