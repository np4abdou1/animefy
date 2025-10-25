using System;
using System.Collections.Generic;

namespace AQ.Models
{
	// Token: 0x02000076 RID: 118
	public class HomeModel
	{
		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x000100A2 File Offset: 0x0000E2A2
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x000100AA File Offset: 0x0000E2AA
		public List<AnimeModelWithOtherData> LatestEpisodes { get; set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x000100B3 File Offset: 0x0000E2B3
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x000100BB File Offset: 0x0000E2BB
		public List<AnimeModel> LatestAnime { get; set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x000100C4 File Offset: 0x0000E2C4
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x000100CC File Offset: 0x0000E2CC
		public List<CharacterModel> LatestCharacters { get; set; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x000100D5 File Offset: 0x0000E2D5
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x000100DD File Offset: 0x0000E2DD
		public List<AnimeModel> Broadcast { get; set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x000100E6 File Offset: 0x0000E2E6
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x000100EE File Offset: 0x0000E2EE
		public List<AnimeModel> Premiere { get; set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x000100F7 File Offset: 0x0000E2F7
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x000100FF File Offset: 0x0000E2FF
		public List<NewsModel> LatestNews { get; set; }

		// Token: 0x040002C0 RID: 704
		public static int SelectedGenrePosition = -1;

		// Token: 0x040002C1 RID: 705
		public static bool OpenSearch = false;
	}
}
