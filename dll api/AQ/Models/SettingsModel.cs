using System;
using SQLite;

namespace AQ.Models
{
	// Token: 0x02000082 RID: 130
	[Table("Settings")]
	public class SettingsModel
	{
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x0001080B File Offset: 0x0000EA0B
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x00010813 File Offset: 0x0000EA13
		[PrimaryKey]
		[MaxLength(255)]
		public string Id { get; set; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x0001081C File Offset: 0x0000EA1C
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x00010824 File Offset: 0x0000EA24
		public string Name { get; set; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0001082D File Offset: 0x0000EA2D
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x00010835 File Offset: 0x0000EA35
		public bool Toggle { get; set; }
	}
}
