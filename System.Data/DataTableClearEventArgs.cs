using System;

namespace System.Data
{
	/// <summary>Provides data for the <see cref="M:System.Data.DataTable.Clear" /> method.</summary>
	// Token: 0x0200003E RID: 62
	public sealed class DataTableClearEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataTableClearEventArgs" /> class.</summary>
		/// <param name="dataTable">The <see cref="T:System.Data.DataTable" /> whose rows are being cleared.</param>
		// Token: 0x06000563 RID: 1379 RVA: 0x00019A84 File Offset: 0x00017C84
		public DataTableClearEventArgs(DataTable dataTable)
		{
			this.<Table>k__BackingField = dataTable;
		}
	}
}
