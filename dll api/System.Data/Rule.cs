using System;

namespace System.Data
{
	/// <summary>Indicates the action that occurs when a <see cref="T:System.Data.ForeignKeyConstraint" /> is enforced.</summary>
	// Token: 0x02000088 RID: 136
	public enum Rule
	{
		/// <summary>No action taken on related rows.</summary>
		// Token: 0x040002C0 RID: 704
		None,
		/// <summary>Delete or update related rows. This is the default.</summary>
		// Token: 0x040002C1 RID: 705
		Cascade,
		/// <summary>Set values in related rows to <see langword="DBNull" />.</summary>
		// Token: 0x040002C2 RID: 706
		SetNull,
		/// <summary>Set values in related rows to the value contained in the <see cref="P:System.Data.DataColumn.DefaultValue" /> property.</summary>
		// Token: 0x040002C3 RID: 707
		SetDefault
	}
}
