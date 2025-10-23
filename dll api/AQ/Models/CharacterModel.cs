using System;

namespace AQ.Models
{
	// Token: 0x02000064 RID: 100
	public class CharacterModel
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x0000F6F8 File Offset: 0x0000D8F8
		public int Id { get; set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0000F701 File Offset: 0x0000D901
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x0000F709 File Offset: 0x0000D909
		public string CharId { get; set; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0000F712 File Offset: 0x0000D912
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x0000F71A File Offset: 0x0000D91A
		public string NameEN { get; set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0000F723 File Offset: 0x0000D923
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0000F72B File Offset: 0x0000D92B
		public string Aka { get; set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0000F734 File Offset: 0x0000D934
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x0000F73C File Offset: 0x0000D93C
		public string NameAR { get; set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0000F745 File Offset: 0x0000D945
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x0000F74D File Offset: 0x0000D94D
		public string NameJP { get; set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0000F756 File Offset: 0x0000D956
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x0000F75E File Offset: 0x0000D95E
		public int Gender { get; set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0000F767 File Offset: 0x0000D967
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x0000F76F File Offset: 0x0000D96F
		public string Age { get; set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0000F778 File Offset: 0x0000D978
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x0000F780 File Offset: 0x0000D980
		public string Height { get; set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0000F789 File Offset: 0x0000D989
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x0000F791 File Offset: 0x0000D991
		public string Weight { get; set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0000F79A File Offset: 0x0000D99A
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x0000F7A2 File Offset: 0x0000D9A2
		public string BloodType { get; set; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000F7AB File Offset: 0x0000D9AB
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x0000F7B3 File Offset: 0x0000D9B3
		public string RelationId { get; set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0000F7BC File Offset: 0x0000D9BC
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x0000F7C4 File Offset: 0x0000D9C4
		public string HexCode { get; set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0000F7CD File Offset: 0x0000D9CD
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x0000F7D5 File Offset: 0x0000D9D5
		public string Photo { get; set; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0000F7DE File Offset: 0x0000D9DE
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x0000F7E6 File Offset: 0x0000D9E6
		public int ExtraPhotosCount { get; set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0000F7EF File Offset: 0x0000D9EF
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x0000F7F7 File Offset: 0x0000D9F7
		public string Cover { get; set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0000F800 File Offset: 0x0000DA00
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0000F808 File Offset: 0x0000DA08
		public int LikersCount { get; set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0000F811 File Offset: 0x0000DA11
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x0000F819 File Offset: 0x0000DA19
		public int DislikersCount { get; set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0000F822 File Offset: 0x0000DA22
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x0000F82A File Offset: 0x0000DA2A
		public int Enabled { get; set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0000F833 File Offset: 0x0000DA33
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x0000F83B File Offset: 0x0000DA3B
		public int Views { get; set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0000F844 File Offset: 0x0000DA44
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x0000F84C File Offset: 0x0000DA4C
		public int Love { get; set; }
	}
}
