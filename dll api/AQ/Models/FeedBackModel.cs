using System;

namespace AQ.Models
{
	// Token: 0x02000072 RID: 114
	public class FeedBackModel
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0000FF3D File Offset: 0x0000E13D
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x0000FF45 File Offset: 0x0000E145
		public int ID { get; set; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0000FF4E File Offset: 0x0000E14E
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x0000FF56 File Offset: 0x0000E156
		public string UserID { get; set; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x0000FF5F File Offset: 0x0000E15F
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x0000FF67 File Offset: 0x0000E167
		public int Type { get; set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x0000FF70 File Offset: 0x0000E170
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x0000FF78 File Offset: 0x0000E178
		public string Subject { get; set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x0000FF81 File Offset: 0x0000E181
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x0000FF89 File Offset: 0x0000E189
		public string Note { get; set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x0000FF92 File Offset: 0x0000E192
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x0000FF9A File Offset: 0x0000E19A
		public string SendDate { get; set; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x0000FFA3 File Offset: 0x0000E1A3
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x0000FFAB File Offset: 0x0000E1AB
		public int Status { get; set; }
	}
}
