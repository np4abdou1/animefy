using System;
using System.Collections.Generic;

namespace AQ.Models
{
	// Token: 0x02000071 RID: 113
	public class ExploreModel
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x0000FF0A File Offset: 0x0000E10A
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x0000FF12 File Offset: 0x0000E112
		public List<AnimeModel> Schedule { get; set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0000FF1B File Offset: 0x0000E11B
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x0000FF23 File Offset: 0x0000E123
		public List<AnimeModel> Seasons { get; set; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0000FF2C File Offset: 0x0000E12C
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x0000FF34 File Offset: 0x0000E134
		public List<AnimeModelWithOtherData> MostWatchedEpisodes { get; set; }
	}
}
