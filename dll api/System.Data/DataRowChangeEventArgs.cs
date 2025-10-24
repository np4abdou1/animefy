using System;

namespace System.Data
{
	/// <summary>Provides data for the <see cref="E:System.Data.DataTable.RowChanged" />, <see cref="E:System.Data.DataTable.RowChanging" />, <see cref="M:System.Data.DataTable.OnRowDeleting(System.Data.DataRowChangeEventArgs)" />, and <see cref="M:System.Data.DataTable.OnRowDeleted(System.Data.DataRowChangeEventArgs)" /> events.</summary>
	// Token: 0x0200002E RID: 46
	public class DataRowChangeEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataRowChangeEventArgs" /> class.</summary>
		/// <param name="row">The <see cref="T:System.Data.DataRow" /> upon which an action is occuring. </param>
		/// <param name="action">One of the <see cref="T:System.Data.DataRowAction" /> values. </param>
		// Token: 0x0600033B RID: 827 RVA: 0x0000BB95 File Offset: 0x00009D95
		public DataRowChangeEventArgs(DataRow row, DataRowAction action)
		{
			this.Row = row;
			this.Action = action;
		}

		/// <summary>Gets the row upon which an action has occurred.</summary>
		/// <returns>The <see cref="T:System.Data.DataRow" /> upon which an action has occurred.</returns>
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000BBAB File Offset: 0x00009DAB
		public DataRow Row { get; }

		/// <summary>Gets the action that has occurred on a <see cref="T:System.Data.DataRow" />.</summary>
		/// <returns>One of the <see cref="T:System.Data.DataRowAction" /> values.</returns>
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000BBB3 File Offset: 0x00009DB3
		public DataRowAction Action { get; }
	}
}
