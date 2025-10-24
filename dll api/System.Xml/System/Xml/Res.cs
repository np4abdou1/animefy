using System;

namespace System.Xml
{
	// Token: 0x020001BF RID: 447
	internal static class Res
	{
		// Token: 0x06000F45 RID: 3909 RVA: 0x00044153 File Offset: 0x00042353
		public static string GetString(string name)
		{
			return name;
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x000620AA File Offset: 0x000602AA
		public static string GetString(string name, params object[] args)
		{
			if (args == null)
			{
				return name;
			}
			return SR.GetString(name, args);
		}
	}
}
