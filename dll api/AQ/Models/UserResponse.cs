using System;

namespace AQ.Models
{
	// Token: 0x02000084 RID: 132
	public class UserResponse
	{
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x0001094E File Offset: 0x0000EB4E
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00010956 File Offset: 0x0000EB56
		public int code { get; set; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x0001095F File Offset: 0x0000EB5F
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x00010967 File Offset: 0x0000EB67
		public string message { get; set; }

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x00010970 File Offset: 0x0000EB70
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x00010978 File Offset: 0x0000EB78
		public UsersModel data { get; set; }
	}
}
