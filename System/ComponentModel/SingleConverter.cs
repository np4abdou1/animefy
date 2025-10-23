using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert single-precision, floating point number objects to and from various other representations.</summary>
	// Token: 0x02000284 RID: 644
	public class SingleConverter : BaseNumberConverter
	{
		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x000023F6 File Offset: 0x000005F6
		internal override bool AllowHex
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x00051BFD File Offset: 0x0004FDFD
		internal override Type TargetType
		{
			get
			{
				return typeof(float);
			}
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00051C09 File Offset: 0x0004FE09
		internal override object FromString(string value, int radix)
		{
			return Convert.ToSingle(value, CultureInfo.CurrentCulture);
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00051C1B File Offset: 0x0004FE1B
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return float.Parse(value, NumberStyles.Float, formatInfo);
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00051C30 File Offset: 0x0004FE30
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return ((float)value).ToString("R", formatInfo);
		}
	}
}
