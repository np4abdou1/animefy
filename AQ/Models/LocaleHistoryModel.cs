using System;
using SQLite;

namespace AQ.Models
{
	// Token: 0x02000070 RID: 112
	[Table("EyeEpisodesTable")]
	public class LocaleHistoryModel
	{
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0000FED7 File Offset: 0x0000E0D7
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x0000FEDF File Offset: 0x0000E0DF
		[PrimaryKey]
		[AutoIncrement]
		[MaxLength(50)]
		public int Id { get; set; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x0000FEF0 File Offset: 0x0000E0F0
		[MaxLength(255)]
		public string AnimeId { get; set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0000FEF9 File Offset: 0x0000E0F9
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x0000FF01 File Offset: 0x0000E101
		[MaxLength(10)]
		public float Episode { get; set; }
	}
}
