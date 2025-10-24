using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 8-bit unsigned integer objects to and from a string.</summary>
	// Token: 0x02000283 RID: 643
	public class SByteConverter : BaseNumberConverter
	{
		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x00051BB1 File Offset: 0x0004FDB1
		internal override Type TargetType
		{
			get
			{
				return typeof(sbyte);
			}
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00051BBD File Offset: 0x0004FDBD
		internal override object FromString(string value, int radix)
		{
			return Convert.ToSByte(value, radix);
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00051BCB File Offset: 0x0004FDCB
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return sbyte.Parse(value, NumberStyles.Integer, formatInfo);
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00051BDC File Offset: 0x0004FDDC
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return ((sbyte)value).ToString("G", formatInfo);
		}
	}
}
