using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001E3 RID: 483
	internal class BsonProperty
	{
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x00046A98 File Offset: 0x00044C98
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x00046AA0 File Offset: 0x00044CA0
		public BsonString Name { get; set; }

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x00046AA9 File Offset: 0x00044CA9
		// (set) Token: 0x0600102C RID: 4140 RVA: 0x00046AB1 File Offset: 0x00044CB1
		public BsonToken Value { get; set; }
	}
}
