using System;

namespace AQ.Models
{
	// Token: 0x0200006D RID: 109
	public class EpisodeResponse
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0000FC73 File Offset: 0x0000DE73
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x0000FC7B File Offset: 0x0000DE7B
		public EpisodeModel CurrentEpisode { get; set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0000FC84 File Offset: 0x0000DE84
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x0000FC8C File Offset: 0x0000DE8C
		public EpisodeModel NextEpisode { get; set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0000FC95 File Offset: 0x0000DE95
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x0000FC9D File Offset: 0x0000DE9D
		public EpisodeModel PreviousEpisode { get; set; }
	}
}
