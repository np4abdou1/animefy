using System;

namespace AQ.Models
{
	// Token: 0x02000069 RID: 105
	public class CommentsModel
	{
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0000FAA8 File Offset: 0x0000DCA8
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		public int CommID { get; set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0000FAB9 File Offset: 0x0000DCB9
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x0000FAC1 File Offset: 0x0000DCC1
		public int UserID { get; set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0000FACA File Offset: 0x0000DCCA
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x0000FAD2 File Offset: 0x0000DCD2
		public string CommBody { get; set; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0000FADB File Offset: 0x0000DCDB
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x0000FAE3 File Offset: 0x0000DCE3
		public string CommTime { get; set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0000FAEC File Offset: 0x0000DCEC
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x0000FAF4 File Offset: 0x0000DCF4
		public string AnimeID { get; set; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0000FAFD File Offset: 0x0000DCFD
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x0000FB05 File Offset: 0x0000DD05
		public float Episode { get; set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0000FB0E File Offset: 0x0000DD0E
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x0000FB16 File Offset: 0x0000DD16
		public int Spoiler { get; set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0000FB1F File Offset: 0x0000DD1F
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x0000FB27 File Offset: 0x0000DD27
		public int Pinned { get; set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0000FB30 File Offset: 0x0000DD30
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x0000FB38 File Offset: 0x0000DD38
		public int LikesCount { get; set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0000FB41 File Offset: 0x0000DD41
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x0000FB49 File Offset: 0x0000DD49
		public int DislikesCount { get; set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x0000FB52 File Offset: 0x0000DD52
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x0000FB5A File Offset: 0x0000DD5A
		public string LikeOrDislike { get; set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0000FB63 File Offset: 0x0000DD63
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x0000FB6B File Offset: 0x0000DD6B
		public int RepliesCount { get; set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x0000FB74 File Offset: 0x0000DD74
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x0000FB7C File Offset: 0x0000DD7C
		public UsersModel User { get; set; }
	}
}
