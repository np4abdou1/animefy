using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert 8-bit unsigned integer objects to and from various other representations.</summary>
	// Token: 0x0200024F RID: 591
	public class ByteConverter : BaseNumberConverter
	{
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x0004DE62 File Offset: 0x0004C062
		internal override Type TargetType
		{
			get
			{
				return typeof(byte);
			}
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0004DE6E File Offset: 0x0004C06E
		internal override object FromString(string value, int radix)
		{
			return Convert.ToByte(value, radix);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0004DE7C File Offset: 0x0004C07C
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return byte.Parse(value, NumberStyles.Integer, formatInfo);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0004DE8C File Offset: 0x0004C08C
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return ((byte)value).ToString("G", formatInfo);
		}
	}
}
