using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001E1 RID: 481
	internal class BsonBinary : BsonValue
	{
		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x00046A2E File Offset: 0x00044C2E
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x00046A36 File Offset: 0x00044C36
		public BsonBinaryType BinaryType { get; set; }

		// Token: 0x06001022 RID: 4130 RVA: 0x00046A3F File Offset: 0x00044C3F
		public BsonBinary(byte[] value, BsonBinaryType binaryType) : base(value, BsonType.Binary)
		{
			this.BinaryType = binaryType;
		}
	}
}
