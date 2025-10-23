using System;

namespace System.Globalization
{
	// Token: 0x02000584 RID: 1412
	internal struct HebrewNumberParsingContext
	{
		// Token: 0x06002A75 RID: 10869 RVA: 0x000AA358 File Offset: 0x000A8558
		public HebrewNumberParsingContext(int result)
		{
			this.state = HebrewNumber.HS.Start;
			this.result = result;
		}

		// Token: 0x04001678 RID: 5752
		internal HebrewNumber.HS state;

		// Token: 0x04001679 RID: 5753
		internal int result;
	}
}
