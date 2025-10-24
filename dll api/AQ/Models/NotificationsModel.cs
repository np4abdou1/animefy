using System;
using SQLite;

namespace AQ.Models
{
	// Token: 0x02000080 RID: 128
	[Table("NotificationsTable")]
	public class NotificationsModel
	{
		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00010711 File Offset: 0x0000E911
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00010719 File Offset: 0x0000E919
		[PrimaryKey]
		[MaxLength(255)]
		public string AnimeID { get; set; }

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00010722 File Offset: 0x0000E922
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x0001072A File Offset: 0x0000E92A
		[MaxLength(255)]
		public string AnimeTitle { get; set; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00010733 File Offset: 0x0000E933
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x0001073B File Offset: 0x0000E93B
		[MaxLength(255)]
		public int EpisodesCount { get; set; }

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00010744 File Offset: 0x0000E944
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x0001074C File Offset: 0x0000E94C
		[MaxLength(4)]
		public int Status { get; set; }

		// Token: 0x04000321 RID: 801
		public static readonly string EPISODE_CHANNEL_ID = "episdes_notification";
	}
}
