using System;

namespace AQ.Models
{
	// Token: 0x0200006A RID: 106
	public class CommentRepliesModel
	{
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x0000FB85 File Offset: 0x0000DD85
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x0000FB8D File Offset: 0x0000DD8D
		public int ReplyID { get; set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0000FB96 File Offset: 0x0000DD96
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x0000FB9E File Offset: 0x0000DD9E
		public int CommID { get; set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0000FBA7 File Offset: 0x0000DDA7
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x0000FBAF File Offset: 0x0000DDAF
		public int UserID { get; set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x0000FBC0 File Offset: 0x0000DDC0
		public string ReplyBody { get; set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x0000FBC9 File Offset: 0x0000DDC9
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x0000FBD1 File Offset: 0x0000DDD1
		public string ReplyTime { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0000FBDA File Offset: 0x0000DDDA
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x0000FBE2 File Offset: 0x0000DDE2
		public int LikesCount { get; set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0000FBEB File Offset: 0x0000DDEB
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x0000FBF3 File Offset: 0x0000DDF3
		public int DislikesCount { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0000FBFC File Offset: 0x0000DDFC
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x0000FC04 File Offset: 0x0000DE04
		public string LikeOrDislike { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0000FC0D File Offset: 0x0000DE0D
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x0000FC15 File Offset: 0x0000DE15
		public UsersModel User { get; set; }
	}
}
