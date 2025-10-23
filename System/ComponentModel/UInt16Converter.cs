using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 16-bit unsigned integer objects to and from other representations.</summary>
	// Token: 0x0200028B RID: 651
	public class UInt16Converter : BaseNumberConverter
	{
		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x00051F44 File Offset: 0x00050144
		internal override Type TargetType
		{
			get
			{
				return typeof(ushort);
			}
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00051F50 File Offset: 0x00050150
		internal override object FromString(string value, int radix)
		{
			return Convert.ToUInt16(value, radix);
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00051F5E File Offset: 0x0005015E
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return ushort.Parse(value, NumberStyles.Integer, formatInfo);
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00051F70 File Offset: 0x00050170
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return ((ushort)value).ToString("G", formatInfo);
		}
	}
}
