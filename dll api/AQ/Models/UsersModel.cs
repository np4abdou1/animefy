using System;
using SQLite;

namespace AQ.Models
{
	// Token: 0x02000083 RID: 131
	[Table("UserProfile")]
	public class UsersModel
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0001083E File Offset: 0x0000EA3E
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x00010846 File Offset: 0x0000EA46
		[PrimaryKey]
		[MaxLength(50)]
		public int UserID { get; set; }

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0001084F File Offset: 0x0000EA4F
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00010857 File Offset: 0x0000EA57
		public string GoogleUserID { get; set; }

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00010860 File Offset: 0x0000EA60
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x00010868 File Offset: 0x0000EA68
		public string UserName { get; set; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x00010871 File Offset: 0x0000EA71
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00010879 File Offset: 0x0000EA79
		public string FullName { get; set; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x00010882 File Offset: 0x0000EA82
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x0001088A File Offset: 0x0000EA8A
		public string Password { get; set; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00010893 File Offset: 0x0000EA93
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x0001089B File Offset: 0x0000EA9B
		public string Email { get; set; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x000108A4 File Offset: 0x0000EAA4
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x000108AC File Offset: 0x0000EAAC
		public string Bio { get; set; }

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x000108B5 File Offset: 0x0000EAB5
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x000108BD File Offset: 0x0000EABD
		public string Gender { get; set; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x000108C6 File Offset: 0x0000EAC6
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x000108CE File Offset: 0x0000EACE
		public string ProfileImage { get; set; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x000108D7 File Offset: 0x0000EAD7
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x000108DF File Offset: 0x0000EADF
		public string ProfileCover { get; set; }

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x000108E8 File Offset: 0x0000EAE8
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x000108F0 File Offset: 0x0000EAF0
		public string CommunicationStatus { get; set; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x000108F9 File Offset: 0x0000EAF9
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00010901 File Offset: 0x0000EB01
		public string FeedbackStatus { get; set; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0001090A File Offset: 0x0000EB0A
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x00010912 File Offset: 0x0000EB12
		public string Membership { get; set; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x0001091B File Offset: 0x0000EB1B
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x00010923 File Offset: 0x0000EB23
		public int AllowLibraryView { get; set; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0001092C File Offset: 0x0000EB2C
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00010934 File Offset: 0x0000EB34
		public int IsActivated { get; set; }

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x0001093D File Offset: 0x0000EB3D
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00010945 File Offset: 0x0000EB45
		public string GoogleProfilePhotoUrl { get; set; }

		// Token: 0x0400033F RID: 831
		public static bool OnResumeLogin;
	}
}
