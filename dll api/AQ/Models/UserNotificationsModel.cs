using System;

namespace AQ.Models
{
	// Token: 0x02000081 RID: 129
	public class UserNotificationsModel
	{
		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00010761 File Offset: 0x0000E961
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00010769 File Offset: 0x0000E969
		public int Id { get; set; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00010772 File Offset: 0x0000E972
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x0001077A File Offset: 0x0000E97A
		public int UserId { get; set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00010783 File Offset: 0x0000E983
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x0001078B File Offset: 0x0000E98B
		public string Action { get; set; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00010794 File Offset: 0x0000E994
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x0001079C File Offset: 0x0000E99C
		public int ActionUserId { get; set; }

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x000107A5 File Offset: 0x0000E9A5
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x000107AD File Offset: 0x0000E9AD
		public string Subject { get; set; }

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x000107B6 File Offset: 0x0000E9B6
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x000107BE File Offset: 0x0000E9BE
		public int SubjectId { get; set; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x000107C7 File Offset: 0x0000E9C7
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x000107CF File Offset: 0x0000E9CF
		public string Date { get; set; }

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x000107D8 File Offset: 0x0000E9D8
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x000107E0 File Offset: 0x0000E9E0
		public CommentsModel Comment { get; set; }

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x000107E9 File Offset: 0x0000E9E9
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x000107F1 File Offset: 0x0000E9F1
		public CommentRepliesModel Reply { get; set; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x000107FA File Offset: 0x0000E9FA
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x00010802 File Offset: 0x0000EA02
		public UsersModel User { get; set; }
	}
}
