using System;

namespace AQ.Models
{
	// Token: 0x02000067 RID: 103
	public class CharacterVoiceActors
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x0000F9FE File Offset: 0x0000DBFE
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x0000FA06 File Offset: 0x0000DC06
		public int Id { get; set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0000FA0F File Offset: 0x0000DC0F
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x0000FA17 File Offset: 0x0000DC17
		public string CharId { get; set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0000FA20 File Offset: 0x0000DC20
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x0000FA28 File Offset: 0x0000DC28
		public string Name { get; set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0000FA31 File Offset: 0x0000DC31
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x0000FA39 File Offset: 0x0000DC39
		public string NameAR { get; set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0000FA42 File Offset: 0x0000DC42
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x0000FA4A File Offset: 0x0000DC4A
		public string Language { get; set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0000FA53 File Offset: 0x0000DC53
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x0000FA5B File Offset: 0x0000DC5B
		public string Photo { get; set; }
	}
}
