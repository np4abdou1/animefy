using System;

namespace System.Data.Common
{
	// Token: 0x020000D8 RID: 216
	internal sealed class LoadAdapter : DataAdapter
	{
		// Token: 0x06000EDE RID: 3806 RVA: 0x0004A99D File Offset: 0x00048B9D
		internal LoadAdapter()
		{
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0004A9A5 File Offset: 0x00048BA5
		internal int FillFromReader(DataTable[] dataTables, IDataReader dataReader, int startRecord, int maxRecords)
		{
			return this.Fill(dataTables, dataReader, startRecord, maxRecords);
		}
	}
}
