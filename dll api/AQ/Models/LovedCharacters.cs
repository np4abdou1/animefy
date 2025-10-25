using System;

namespace AQ.Models
{
	// Token: 0x02000068 RID: 104
	public class LovedCharacters
	{
		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x0000FA64 File Offset: 0x0000DC64
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x0000FA6C File Offset: 0x0000DC6C
		public int Id { get; set; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0000FA75 File Offset: 0x0000DC75
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x0000FA7D File Offset: 0x0000DC7D
		public int UserId { get; set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0000FA86 File Offset: 0x0000DC86
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x0000FA8E File Offset: 0x0000DC8E
		public string CharId { get; set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0000FA97 File Offset: 0x0000DC97
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x0000FA9F File Offset: 0x0000DC9F
		public int Love { get; set; }
	}
}
