﻿using System;

namespace System.Data
{
	/// <summary>Determines the action that occurs when the <see cref="M:System.Data.DataSet.AcceptChanges" /> or <see cref="M:System.Data.DataTable.RejectChanges" /> method is invoked on a <see cref="T:System.Data.DataTable" /> with a <see cref="T:System.Data.ForeignKeyConstraint" />.</summary>
	// Token: 0x02000003 RID: 3
	public enum AcceptRejectRule
	{
		/// <summary>No action occurs (default).</summary>
		// Token: 0x04000002 RID: 2
		None,
		/// <summary>Changes are cascaded across the relationship.</summary>
		// Token: 0x04000003 RID: 3
		Cascade
	}
}
