using System;

namespace SQLite
{
	// Token: 0x0200003A RID: 58
	public abstract class BaseTableQuery
	{
		// Token: 0x0200003B RID: 59
		protected class Ordering
		{
			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000187 RID: 391 RVA: 0x000071C0 File Offset: 0x000053C0
			// (set) Token: 0x06000188 RID: 392 RVA: 0x000071C8 File Offset: 0x000053C8
			public string ColumnName { get; set; }

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000189 RID: 393 RVA: 0x000071D1 File Offset: 0x000053D1
			// (set) Token: 0x0600018A RID: 394 RVA: 0x000071D9 File Offset: 0x000053D9
			public bool Ascending { get; set; }
		}
	}
}
