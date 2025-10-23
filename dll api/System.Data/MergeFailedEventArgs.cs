using System;

namespace System.Data
{
	/// <summary>Occurs when a target and source <see langword="DataRow" /> have the same primary key value, and the <see cref="P:System.Data.DataSet.EnforceConstraints" /> property is set to true.</summary>
	// Token: 0x02000075 RID: 117
	public class MergeFailedEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of a <see cref="T:System.Data.MergeFailedEventArgs" /> class with the <see cref="T:System.Data.DataTable" /> and a description of the merge conflict.</summary>
		/// <param name="table">The <see cref="T:System.Data.DataTable" /> object. </param>
		/// <param name="conflict">A description of the merge conflict. </param>
		// Token: 0x060007BC RID: 1980 RVA: 0x000258BB File Offset: 0x00023ABB
		public MergeFailedEventArgs(DataTable table, string conflict)
		{
			this.<Table>k__BackingField = table;
			this.Conflict = conflict;
		}

		/// <summary>Returns a description of the merge conflict.</summary>
		/// <returns>A description of the merge conflict.</returns>
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x000258D1 File Offset: 0x00023AD1
		public string Conflict { get; }
	}
}
