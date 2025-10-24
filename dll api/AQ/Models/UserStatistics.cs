using System;

namespace AQ.Models
{
	// Token: 0x02000085 RID: 133
	public class UserStatistics
	{
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00010981 File Offset: 0x0000EB81
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x00010989 File Offset: 0x0000EB89
		public int user_id { get; set; }

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x00010992 File Offset: 0x0000EB92
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x0001099A File Offset: 0x0000EB9A
		public int comments { get; set; }

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x000109A3 File Offset: 0x0000EBA3
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x000109AB File Offset: 0x0000EBAB
		public int comments_replies { get; set; }

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x000109B4 File Offset: 0x0000EBB4
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x000109BC File Offset: 0x0000EBBC
		public int ratings { get; set; }

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x000109C5 File Offset: 0x0000EBC5
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x000109CD File Offset: 0x0000EBCD
		public int library_favourites { get; set; }

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x000109D6 File Offset: 0x0000EBD6
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x000109DE File Offset: 0x0000EBDE
		public int library_watch_done { get; set; }

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x000109E7 File Offset: 0x0000EBE7
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x000109EF File Offset: 0x0000EBEF
		public int library_watch_later { get; set; }

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x000109F8 File Offset: 0x0000EBF8
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00010A00 File Offset: 0x0000EC00
		public int library_watch_currently { get; set; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00010A09 File Offset: 0x0000EC09
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00010A11 File Offset: 0x0000EC11
		public int profile_views { get; set; }

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00010A1A File Offset: 0x0000EC1A
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00010A22 File Offset: 0x0000EC22
		public int notifications { get; set; }
	}
}
