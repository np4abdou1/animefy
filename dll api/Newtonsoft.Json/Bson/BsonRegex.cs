using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001E2 RID: 482
	internal class BsonRegex : BsonToken
	{
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x00046A50 File Offset: 0x00044C50
		// (set) Token: 0x06001024 RID: 4132 RVA: 0x00046A58 File Offset: 0x00044C58
		public BsonString Pattern { get; set; }

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x00046A61 File Offset: 0x00044C61
		// (set) Token: 0x06001026 RID: 4134 RVA: 0x00046A69 File Offset: 0x00044C69
		public BsonString Options { get; set; }

		// Token: 0x06001027 RID: 4135 RVA: 0x00046A72 File Offset: 0x00044C72
		public BsonRegex(string pattern, string options)
		{
			this.Pattern = new BsonString(pattern, false);
			this.Options = new BsonString(options, false);
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x00046A94 File Offset: 0x00044C94
		public override BsonType Type
		{
			get
			{
				return BsonType.Regex;
			}
		}
	}
}
