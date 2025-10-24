using System;

namespace AQ.Models
{
	// Token: 0x02000061 RID: 97
	public class AnimeModelWithOtherData
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x0000F57A File Offset: 0x0000D77A
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x0000F582 File Offset: 0x0000D782
		public AnimeModel Anime { get; set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x0000F58B File Offset: 0x0000D78B
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x0000F593 File Offset: 0x0000D793
		public EpisodeModel Episode { get; set; }
	}
}
