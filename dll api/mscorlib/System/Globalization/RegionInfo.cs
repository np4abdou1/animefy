using System;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>Contains information about the country/region.</summary>
	// Token: 0x020005B4 RID: 1460
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public class RegionInfo
	{
		// Token: 0x06002C24 RID: 11300 RVA: 0x000B7478 File Offset: 0x000B5678
		internal static void ClearCachedData()
		{
			RegionInfo.currentRegion = null;
		}

		// Token: 0x0400180B RID: 6155
		private static RegionInfo currentRegion;

		// Token: 0x0400180C RID: 6156
		private int regionId;

		// Token: 0x0400180D RID: 6157
		private string iso2Name;

		// Token: 0x0400180E RID: 6158
		private string iso3Name;

		// Token: 0x0400180F RID: 6159
		private string win3Name;

		// Token: 0x04001810 RID: 6160
		private string englishName;

		// Token: 0x04001811 RID: 6161
		private string nativeName;

		// Token: 0x04001812 RID: 6162
		private string currencySymbol;

		// Token: 0x04001813 RID: 6163
		private string isoCurrencySymbol;

		// Token: 0x04001814 RID: 6164
		private string currencyEnglishName;

		// Token: 0x04001815 RID: 6165
		private string currencyNativeName;
	}
}
