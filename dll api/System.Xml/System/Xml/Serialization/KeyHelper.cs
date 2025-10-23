using System;
using System.Globalization;
using System.Text;

namespace System.Xml.Serialization
{
	// Token: 0x020001D2 RID: 466
	internal class KeyHelper
	{
		// Token: 0x06000F98 RID: 3992 RVA: 0x00062C61 File Offset: 0x00060E61
		public static void AddField(StringBuilder sb, int n, string val)
		{
			KeyHelper.AddField(sb, n, val, null);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00062C6C File Offset: 0x00060E6C
		public static void AddField(StringBuilder sb, int n, string val, string def)
		{
			if (val != def)
			{
				sb.Append(n.ToString());
				sb.Append(val.Length.ToString(CultureInfo.InvariantCulture));
				sb.Append(val);
			}
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00062CB2 File Offset: 0x00060EB2
		public static void AddField(StringBuilder sb, int n, bool val)
		{
			KeyHelper.AddField(sb, n, val, false);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00062CBD File Offset: 0x00060EBD
		public static void AddField(StringBuilder sb, int n, bool val, bool def)
		{
			if (val != def)
			{
				sb.Append(n.ToString());
			}
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00062CD1 File Offset: 0x00060ED1
		public static void AddField(StringBuilder sb, int n, int val, int def)
		{
			if (val != def)
			{
				sb.Append(n.ToString());
				sb.Append(val.ToString(CultureInfo.InvariantCulture));
			}
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00062CF8 File Offset: 0x00060EF8
		public static void AddField(StringBuilder sb, int n, Type val)
		{
			if (val != null)
			{
				sb.Append(n.ToString(CultureInfo.InvariantCulture));
				sb.Append(val.ToString());
			}
		}
	}
}
