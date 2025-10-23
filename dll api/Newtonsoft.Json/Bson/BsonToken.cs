using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001DA RID: 474
	internal abstract class BsonToken
	{
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06001004 RID: 4100
		public abstract BsonType Type { get; }

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x000468C9 File Offset: 0x00044AC9
		// (set) Token: 0x06001006 RID: 4102 RVA: 0x000468D1 File Offset: 0x00044AD1
		public BsonToken Parent { get; set; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x000468DA File Offset: 0x00044ADA
		// (set) Token: 0x06001008 RID: 4104 RVA: 0x000468E2 File Offset: 0x00044AE2
		public int CalculatedSize { get; set; }
	}
}
