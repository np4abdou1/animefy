using System;

namespace AQ.Models
{
	// Token: 0x0200007C RID: 124
	public class MainModel
	{
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00010402 File Offset: 0x0000E602
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x0001040A File Offset: 0x0000E60A
		public Configurations Configurations { get; set; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x00010413 File Offset: 0x0000E613
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x0001041B File Offset: 0x0000E61B
		public UpdatesChart UpdatesChart { get; set; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00010424 File Offset: 0x0000E624
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x0001042C File Offset: 0x0000E62C
		public UserStatistics UserStatistics { get; set; }
	}
}
