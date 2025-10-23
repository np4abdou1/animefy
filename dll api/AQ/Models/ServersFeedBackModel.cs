using System;

namespace AQ.Models
{
	// Token: 0x02000074 RID: 116
	public class ServersFeedBackModel
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0001001A File Offset: 0x0000E21A
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00010022 File Offset: 0x0000E222
		public int ID { get; set; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0001002B File Offset: 0x0000E22B
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00010033 File Offset: 0x0000E233
		public string AnimeID { get; set; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0001003C File Offset: 0x0000E23C
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00010044 File Offset: 0x0000E244
		public string Type { get; set; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0001004D File Offset: 0x0000E24D
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00010055 File Offset: 0x0000E255
		public float Episode { get; set; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0001005E File Offset: 0x0000E25E
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00010066 File Offset: 0x0000E266
		public string Status { get; set; }
	}
}
