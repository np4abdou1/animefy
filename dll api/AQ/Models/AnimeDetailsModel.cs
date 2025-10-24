using System;
using System.Collections.Generic;

namespace AQ.Models
{
	// Token: 0x02000062 RID: 98
	public class AnimeDetailsModel
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0000F59C File Offset: 0x0000D79C
		// (set) Token: 0x060003CA RID: 970 RVA: 0x0000F5A4 File Offset: 0x0000D7A4
		public string Plot { get; set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0000F5AD File Offset: 0x0000D7AD
		// (set) Token: 0x060003CC RID: 972 RVA: 0x0000F5B5 File Offset: 0x0000D7B5
		public LibraryModel Library { get; set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0000F5BE File Offset: 0x0000D7BE
		// (set) Token: 0x060003CE RID: 974 RVA: 0x0000F5C6 File Offset: 0x0000D7C6
		public AnimeStatistics AnimeStatistics { get; set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0000F5CF File Offset: 0x0000D7CF
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x0000F5D7 File Offset: 0x0000D7D7
		public List<AnimeModel> RelatedAnime { get; set; }
	}
}
