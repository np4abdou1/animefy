using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 16-bit signed integer objects to and from other representations.</summary>
	// Token: 0x02000270 RID: 624
	public class Int16Converter : BaseNumberConverter
	{
		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x000503BA File Offset: 0x0004E5BA
		internal override Type TargetType
		{
			get
			{
				return typeof(short);
			}
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x000503C6 File Offset: 0x0004E5C6
		internal override object FromString(string value, int radix)
		{
			return Convert.ToInt16(value, radix);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x000503D4 File Offset: 0x0004E5D4
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return short.Parse(value, NumberStyles.Integer, formatInfo);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x000503E4 File Offset: 0x0004E5E4
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return ((short)value).ToString("G", formatInfo);
		}
	}
}
