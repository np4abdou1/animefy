using System;
using SQLite;

namespace AQ.Models
{
	// Token: 0x02000086 RID: 134
	[Table("WatchHistoryTable")]
	public class WatchHistorySqliteModel
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00010A2B File Offset: 0x0000EC2B
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00010A33 File Offset: 0x0000EC33
		[PrimaryKey]
		[AutoIncrement]
		[MaxLength(50)]
		public int Id { get; set; }

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00010A3C File Offset: 0x0000EC3C
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00010A44 File Offset: 0x0000EC44
		[MaxLength(255)]
		public string AnimeID { get; set; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00010A4D File Offset: 0x0000EC4D
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x00010A55 File Offset: 0x0000EC55
		[MaxLength(10)]
		public float Episode { get; set; }
	}
}
