using System;

namespace System.Data
{
	// Token: 0x02000068 RID: 104
	internal interface IFilter
	{
		// Token: 0x0600074F RID: 1871
		bool Invoke(DataRow row, DataRowVersion version);
	}
}
