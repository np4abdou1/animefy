using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001DF RID: 479
	internal class BsonBoolean : BsonValue
	{
		// Token: 0x0600101A RID: 4122 RVA: 0x000469DD File Offset: 0x00044BDD
		private BsonBoolean(bool value) : base(value, BsonType.Boolean)
		{
		}

		// Token: 0x0400085D RID: 2141
		public static readonly BsonBoolean False = new BsonBoolean(false);

		// Token: 0x0400085E RID: 2142
		public static readonly BsonBoolean True = new BsonBoolean(true);
	}
}
