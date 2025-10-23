using System;

namespace AQ.Models
{
	// Token: 0x02000077 RID: 119
	public class HomeTrendingModel
	{
		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00010116 File Offset: 0x0000E316
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x0001011E File Offset: 0x0000E31E
		public string SubjectId { get; set; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00010127 File Offset: 0x0000E327
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x0001012F File Offset: 0x0000E32F
		public string Title { get; set; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00010138 File Offset: 0x0000E338
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00010140 File Offset: 0x0000E340
		public string Hint { get; set; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00010149 File Offset: 0x0000E349
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00010151 File Offset: 0x0000E351
		public string Data { get; set; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0001015A File Offset: 0x0000E35A
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00010162 File Offset: 0x0000E362
		public string Episodes { get; set; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0001016B File Offset: 0x0000E36B
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00010173 File Offset: 0x0000E373
		public string Photo { get; set; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0001017C File Offset: 0x0000E37C
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00010184 File Offset: 0x0000E384
		public string Type { get; set; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0001018D File Offset: 0x0000E38D
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00010195 File Offset: 0x0000E395
		public string TextTheme { get; set; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0001019E File Offset: 0x0000E39E
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x000101A6 File Offset: 0x0000E3A6
		public AnimeModel Anime { get; set; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x000101AF File Offset: 0x0000E3AF
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x000101B7 File Offset: 0x0000E3B7
		public EpisodeModel Episode { get; set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x000101C0 File Offset: 0x0000E3C0
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x000101C8 File Offset: 0x0000E3C8
		public CharacterModel Character { get; set; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x000101D1 File Offset: 0x0000E3D1
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x000101D9 File Offset: 0x0000E3D9
		public NewsModel News { get; set; }
	}
}
