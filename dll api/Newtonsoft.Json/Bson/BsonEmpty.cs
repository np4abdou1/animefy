using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001DD RID: 477
	internal class BsonEmpty : BsonToken
	{
		// Token: 0x06001014 RID: 4116 RVA: 0x00046987 File Offset: 0x00044B87
		private BsonEmpty(BsonType type)
		{
			this.Type = type;
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x00046996 File Offset: 0x00044B96
		public override BsonType Type { get; }

		// Token: 0x04000858 RID: 2136
		public static readonly BsonToken Null = new BsonEmpty(BsonType.Null);

		// Token: 0x04000859 RID: 2137
		public static readonly BsonToken Undefined = new BsonEmpty(BsonType.Undefined);
	}
}
