using System;

namespace System.Data
{
	/// <summary>Provides data for the <see cref="M:System.Data.DataTable.NewRow" /> method.</summary>
	// Token: 0x02000041 RID: 65
	public sealed class DataTableNewRowEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of <see cref="T:System.Data.DataTableNewRowEventArgs" />.</summary>
		/// <param name="dataRow">The <see cref="T:System.Data.DataRow" /> being added.</param>
		// Token: 0x0600058A RID: 1418 RVA: 0x0001A6BF File Offset: 0x000188BF
		public DataTableNewRowEventArgs(DataRow dataRow)
		{
			this.<Row>k__BackingField = dataRow;
		}
	}
}
