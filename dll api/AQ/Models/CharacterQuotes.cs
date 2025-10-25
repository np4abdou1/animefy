using System;

namespace AQ.Models
{
	// Token: 0x02000066 RID: 102
	public class CharacterQuotes
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0000F9CB File Offset: 0x0000DBCB
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x0000F9D3 File Offset: 0x0000DBD3
		public int Id { get; set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0000F9DC File Offset: 0x0000DBDC
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x0000F9E4 File Offset: 0x0000DBE4
		public string CharId { get; set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0000F9ED File Offset: 0x0000DBED
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x0000F9F5 File Offset: 0x0000DBF5
		public string Quote { get; set; }
	}
}
