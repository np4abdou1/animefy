using System;

namespace System.Xml.Schema
{
	// Token: 0x02000236 RID: 566
	internal struct Position
	{
		// Token: 0x060012A1 RID: 4769 RVA: 0x00071F24 File Offset: 0x00070124
		public Position(int symbol, object particle)
		{
			this.symbol = symbol;
			this.particle = particle;
		}

		// Token: 0x04000C97 RID: 3223
		public int symbol;

		// Token: 0x04000C98 RID: 3224
		public object particle;
	}
}
