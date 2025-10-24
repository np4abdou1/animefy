using System;

namespace AQ.Models
{
	// Token: 0x02000073 RID: 115
	public class FeedBackRepliesModel
	{
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0000FFB4 File Offset: 0x0000E1B4
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x0000FFBC File Offset: 0x0000E1BC
		public int ID { get; set; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0000FFC5 File Offset: 0x0000E1C5
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x0000FFCD File Offset: 0x0000E1CD
		public int AdminId { get; set; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0000FFD6 File Offset: 0x0000E1D6
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x0000FFDE File Offset: 0x0000E1DE
		public int UserId { get; set; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0000FFE7 File Offset: 0x0000E1E7
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x0000FFEF File Offset: 0x0000E1EF
		public int FeedbackId { get; set; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x0000FFF8 File Offset: 0x0000E1F8
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00010000 File Offset: 0x0000E200
		public string ReplyBody { get; set; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00010009 File Offset: 0x0000E209
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00010011 File Offset: 0x0000E211
		public UsersModel UserData { get; set; }
	}
}
