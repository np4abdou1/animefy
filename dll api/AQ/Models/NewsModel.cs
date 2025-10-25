using System;

namespace AQ.Models
{
	// Token: 0x0200007F RID: 127
	public class NewsModel
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00010666 File Offset: 0x0000E866
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x0001066E File Offset: 0x0000E86E
		public int ID { get; set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00010677 File Offset: 0x0000E877
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x0001067F File Offset: 0x0000E87F
		public string Title { get; set; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00010688 File Offset: 0x0000E888
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00010690 File Offset: 0x0000E890
		public string Glance { get; set; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00010699 File Offset: 0x0000E899
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x000106A1 File Offset: 0x0000E8A1
		public string Date { get; set; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000106AA File Offset: 0x0000E8AA
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x000106B2 File Offset: 0x0000E8B2
		public string DateN { get; set; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x000106BB File Offset: 0x0000E8BB
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x000106C3 File Offset: 0x0000E8C3
		public string RelationId { get; set; }

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x000106CC File Offset: 0x0000E8CC
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x000106D4 File Offset: 0x0000E8D4
		public UsersModel Editor { get; set; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x000106DD File Offset: 0x0000E8DD
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x000106E5 File Offset: 0x0000E8E5
		public string Thumbnail { get; set; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x000106EE File Offset: 0x0000E8EE
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x000106F6 File Offset: 0x0000E8F6
		public int Views { get; set; }

		// Token: 0x0400031B RID: 795
		public static string News = "News";

		// Token: 0x0400031C RID: 796
		public static int CurrentNewsScreenWidthRows = 0;
	}
}
