using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001E0 RID: 480
	internal class BsonString : BsonValue
	{
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x00046A04 File Offset: 0x00044C04
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x00046A0C File Offset: 0x00044C0C
		public int ByteCount { get; set; }

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x00046A15 File Offset: 0x00044C15
		public bool IncludeLength { get; }

		// Token: 0x0600101F RID: 4127 RVA: 0x00046A1D File Offset: 0x00044C1D
		public BsonString(object value, bool includeLength) : base(value, BsonType.String)
		{
			this.IncludeLength = includeLength;
		}
	}
}
