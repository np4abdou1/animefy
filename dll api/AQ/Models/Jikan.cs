using System;

namespace AQ.Models
{
	// Token: 0x0200007A RID: 122
	public class Jikan
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x0001037A File Offset: 0x0000E57A
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x00010382 File Offset: 0x0000E582
		public int mal_id { get; set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x0001038B File Offset: 0x0000E58B
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x00010393 File Offset: 0x0000E593
		public double score { get; set; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x0001039C File Offset: 0x0000E59C
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x000103A4 File Offset: 0x0000E5A4
		public int scored_by { get; set; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x000103AD File Offset: 0x0000E5AD
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x000103B5 File Offset: 0x0000E5B5
		public int rank { get; set; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x000103BE File Offset: 0x0000E5BE
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x000103C6 File Offset: 0x0000E5C6
		public int popularity { get; set; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x000103CF File Offset: 0x0000E5CF
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x000103D7 File Offset: 0x0000E5D7
		public int favorites { get; set; }
	}
}
