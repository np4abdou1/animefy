using System;

namespace System.Data
{
	/// <summary>The <see langword="DataRowBuilder" /> type supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	// Token: 0x0200002C RID: 44
	public sealed class DataRowBuilder
	{
		// Token: 0x0600033A RID: 826 RVA: 0x0000BB7F File Offset: 0x00009D7F
		internal DataRowBuilder(DataTable table, int record)
		{
			this._table = table;
			this._record = record;
		}

		// Token: 0x04000094 RID: 148
		internal readonly DataTable _table;

		// Token: 0x04000095 RID: 149
		internal int _record;
	}
}
