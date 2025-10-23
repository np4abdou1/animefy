using System;
using System.Runtime.Serialization;

namespace System.Globalization
{
	// Token: 0x0200059E RID: 1438
	[Serializable]
	internal class EraInfo
	{
		// Token: 0x06002B02 RID: 11010 RVA: 0x000AE3D4 File Offset: 0x000AC5D4
		internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear)
		{
			this.era = era;
			this.yearOffset = yearOffset;
			this.minEraYear = minEraYear;
			this.maxEraYear = maxEraYear;
			this.ticks = new DateTime(startYear, startMonth, startDay).Ticks;
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x000AE420 File Offset: 0x000AC620
		internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName)
		{
			this.era = era;
			this.yearOffset = yearOffset;
			this.minEraYear = minEraYear;
			this.maxEraYear = maxEraYear;
			this.ticks = new DateTime(startYear, startMonth, startDay).Ticks;
			this.eraName = eraName;
			this.abbrevEraName = abbrevEraName;
			this.englishEraName = englishEraName;
		}

		// Token: 0x04001736 RID: 5942
		internal int era;

		// Token: 0x04001737 RID: 5943
		internal long ticks;

		// Token: 0x04001738 RID: 5944
		internal int yearOffset;

		// Token: 0x04001739 RID: 5945
		internal int minEraYear;

		// Token: 0x0400173A RID: 5946
		internal int maxEraYear;

		// Token: 0x0400173B RID: 5947
		[OptionalField(VersionAdded = 4)]
		internal string eraName;

		// Token: 0x0400173C RID: 5948
		[OptionalField(VersionAdded = 4)]
		internal string abbrevEraName;

		// Token: 0x0400173D RID: 5949
		[OptionalField(VersionAdded = 4)]
		internal string englishEraName;
	}
}
